#!/usr/bin/env python3
# BINDING-HEADER-PARSE-OK: this generator reads only the meos-idl.json catalog,
# never a C header; the catalog is the binding's single source of truth.
"""Generate the MEOS.NET object layer from MEOS-API's meos-idl.json.

The catalog's ``objectModel`` is the ecosystem-wide source of truth for the class
hierarchy implicit in MEOS: ``lattice`` carries the temporal tree, ``companions``
the Box and Collection hierarchies, and ``classes.<Class>.methods`` assigns every
public MEOS function to the class it is a method of, with its canonical camelCase
``ooName``.  This generator projects that model onto C#: one class per model class,
inheritance from the model's parent edges, and one method per assigned function
delegating to the ``MEOSExposedFunctions`` wrapper that ``codegen.py`` emits for the
same function.

The wrapper signatures come from ``codegen.SIGNATURES`` rather than from the raw C
parameter list, so the two generators cannot disagree about a folded out-parameter.

Usage:
    python3 tools/objectgen.py path/to/meos-idl.json [--report]

Writes MEOS.NET/Types/Generated/*.g.cs, replacing that directory's contents.
"""

from __future__ import annotations

import argparse
import json
import shutil
import sys
from collections import defaultdict
from pathlib import Path

import codegen

GENERATOR_VERSION = "0.1.0"
NAMESPACE = "MEOS.NET.Types.Generated"
ERROR_NAMESPACE = "MEOS.NET.Errors"
EXCEPTION_NAMESPACE = "MEOS.NET.Exceptions"

# The C struct a class's instances are pointers to.  Every other class resolves to
# one of these through the model's own hierarchy, so this map holds only the roots
# of each hierarchy plus the template subtypes.
ROOT_CTYPE = {
    "Temporal": "Temporal",
    "TInstant": "TInstant",
    "TSequence": "TSequence",
    "TSequenceSet": "TSequenceSet",
    "Set": "Set",
    "Span": "Span",
    "SpanSet": "SpanSet",
    "TBox": "TBox",
    "STBox": "STBox",
}

# The C structs that carry the Temporal header and are discriminated by its
# ``subtype`` field.
TEMPORAL_STRUCTS = ("Temporal", "TInstant", "TSequence", "TSequenceSet")

# The template axis: a concrete class is the product `<leaf><suffix>`.
SUBTYPE_SUFFIX = {"TInstant": "Inst", "TSequence": "Seq", "TSequenceSet": "SeqSet"}

# C types the object layer passes and returns as C# scalars, keyed by the cleaned
# C spelling.  Everything else is either a wrapped class pointer or deferred.
PASSTHROUGH_C = {
    "bool", "char", "int", "int8", "int8_t", "uint8", "uint8_t", "int16", "int16_t",
    "uint16", "uint16_t", "int32", "int32_t", "uint32", "uint32_t", "int64",
    "int64_t", "uint64", "uint64_t", "long", "double", "float", "size_t",
    "char *", "void",
}

# Acronym runs the error names carry, kept upper-case so the C# spelling reads
# the way the catalog's own camelCase names do (`asMFJSON`).
ERROR_ACRONYMS = {"wkb", "mfjson", "geojson", "sql", "json"}

RESERVED = {
    "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char",
    "checked", "class", "const", "continue", "decimal", "default", "delegate",
    "do", "double", "else", "enum", "event", "explicit", "extern", "false",
    "finally", "fixed", "float", "for", "foreach", "goto", "if", "implicit",
    "in", "int", "interface", "internal", "is", "lock", "long", "namespace",
    "new", "null", "object", "operator", "out", "override", "params", "private",
    "protected", "public", "readonly", "ref", "return", "sbyte", "sealed",
    "short", "sizeof", "stackalloc", "static", "string", "struct", "switch",
    "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked",
    "unsafe", "ushort", "using", "virtual", "void", "volatile", "while",
}


def clean(c_type: str) -> str:
    """The C type without ``const`` and with single spaces."""
    return " ".join(c_type.replace("const ", "").split())


def pascal(oo_name: str) -> str:
    return oo_name[:1].upper() + oo_name[1:]


def error_member(code_name: str) -> str:
    """The C# name of an errorCode constant: `MEOS_ERR_INVALID_ARG_VALUE` reads
    `InvalidArgValue`, `MEOS_ERR_MFJSON_INPUT` reads `MFJSONInput`."""
    bare = code_name.removeprefix("MEOS_ERR_").removeprefix("MEOS_")
    return "".join(part.upper() if part.lower() in ERROR_ACRONYMS
                   else part.capitalize()
                   for part in bare.lower().split("_"))


def ident(name: str) -> str:
    return f"@{name}" if name in RESERVED else name


class Model:
    """The class hierarchy the catalog defines, indexed for emission."""

    def __init__(self, idl: dict):
        self.idl = idl
        self.om = idl["objectModel"]
        self.functions = {f["name"]: f for f in idl["functions"]}
        self.enum_values = {
            e["name"]: {v["name"]: v["value"] for v in e.get("values", [])}
            for e in idl["enums"] if e.get("name")
        }
        self.parent: dict[str, str | None] = {}
        self.ctype: dict[str, str] = {}
        self.meostype: dict[str, str] = {}      # class -> its MeosType constant
        self.subtype_of: dict[str, str] = {}    # concrete class -> template subtype
        self._build()

    def _build(self) -> None:
        lattice = self.om["lattice"]
        for name, node in lattice.items():
            self.parent[name] = node["parent"]
            self.ctype[name] = "Temporal"
            temptypes = node.get("temptypes") or []
            if node["kind"] == "leaf" and len(temptypes) == 1:
                self.meostype[name] = temptypes[0]

        # The template subtypes are classes of their own, under the root.
        for value in self.om["axes"]["subtype"]["values"]:
            cls = value.get("class")
            if cls:
                self.parent[cls] = "Temporal"
                self.ctype[cls] = cls

        # A concrete class is `<leaf><suffix>`: it inherits the leaf's family surface
        # and its instances are pointers to the template subtype's struct.
        for leaf in [n for n, v in lattice.items() if v["kind"] == "leaf"]:
            for subtype, suffix in SUBTYPE_SUFFIX.items():
                concrete = leaf + suffix
                if concrete in self.om["classes"]:
                    self.parent[concrete] = leaf
                    self.ctype[concrete] = subtype
                    self.subtype_of[concrete] = subtype

        for family in ("Box", "Collection"):
            for name, node in self.om["companions"][family]["nodes"].items():
                self.parent[name] = node["parent"]
                if node.get("temptype"):
                    self.meostype[name] = node["temptype"]
        for name in self.om["companions"]["Collection"]["nodes"]:
            self.ctype[name] = self._collection_ctype(name)
        self.ctype["TBox"] = "TBox"
        self.ctype["STBox"] = "STBox"

    def _collection_ctype(self, name: str) -> str:
        node = self.om["companions"]["Collection"]["nodes"][name]
        for a in [name] + list(node["ancestors"]):
            if a in ROOT_CTYPE:
                return ROOT_CTYPE[a]
        return ""

    def classes(self) -> list[str]:
        """Every class the model defines, superclass before subclass."""
        ordered: list[str] = []

        def emit(n: str) -> None:
            if n in ordered:
                return
            p = self.parent.get(n)
            if p:
                emit(p)
            ordered.append(n)

        for n in sorted(self.parent):
            emit(n)
        return ordered

    def struct_offset(self, struct: str, field: str) -> int:
        for s in self.idl["structs"]:
            if s["name"] == struct:
                for f in s["fields"]:
                    if f["name"] == field:
                        return f["offset_bits"] // 8
        raise KeyError(f"{struct}.{field} is not in the catalog")

    def class_for_ctype(self, c_type: str) -> str | None:
        """The class a single pointer to this C struct is wrapped in.

        Every temporal struct — TInstant, TSequence, TSequenceSet — begins with the
        Temporal header and MEOS discriminates them by the ``subtype`` field, so a
        pointer to any of them is a Temporal at the surface and the factory hands
        back the concrete class the header names.  Modelling them as C# classes of
        their own would not: a concrete class is the product leaf x subtype, and C#
        single inheritance already spends that class's one base on its leaf family,
        which carries by far the larger surface."""
        base = clean(c_type)
        if not base.endswith(" *"):
            return None
        base = base[:-2].strip()
        if base in TEMPORAL_STRUCTS:
            return "Temporal"
        for cls, ct in ROOT_CTYPE.items():
            if ct == base:
                return cls
        return None


class Method:
    """One emitted method: its C# signature and the wrapper call behind it."""

    def __init__(self, name: str, ret: str, params: list[tuple[str, str]],
                 body: str, static: bool):
        self.name = name
        self.ret = ret
        self.params = params
        self.body = body
        self.static = static


class Generator:
    def __init__(self, model: Model):
        self.m = model
        self.deferred: dict[str, list[str]] = defaultdict(list)
        self.class_member_names: dict[str, set[str]] = {}
        self.emitted = 0

    # -- marshalling ------------------------------------------------------

    def map_return(self, f: dict, wrapper_ret: str) -> tuple[str, str] | None:
        """``(csharp_type, expression template)`` for the return, or None to defer.

        The template spells the wrapper call as ``$``.
        """
        c = clean(f["returnType"]["c"])
        if wrapper_ret == "void":
            return ("void", "$")
        if c in ("TimestampTz", "Timestamp"):
            return ("DateTime", "MEOSConvert.ToDateTime($)")
        if c == "DateADT":
            return ("DateOnly", "MEOSConvert.ToDateOnly($)")
        if wrapper_ret in ("string", "string?"):
            return (wrapper_ret, "$")
        if c in PASSTHROUGH_C and wrapper_ret != "IntPtr":
            return (wrapper_ret, "$")
        cls = self.m.class_for_ctype(c)
        if cls and wrapper_ret == "IntPtr":
            return (f"{cls}?", f"MEOSFactory.Wrap{ROOT_CTYPE[cls]}($)")
        if c.endswith(" **") and wrapper_ret == "IntPtr[]":
            elem = self.m.class_for_ctype(c[:-1])
            if elem:
                return (f"{elem}?[]", f"MEOSFactory.Wrap{ROOT_CTYPE[elem]}Array($)")
        if wrapper_ret in ("long[]", "int[]", "double[]", "byte[]"):
            return (wrapper_ret, "$")
        return None

    def map_param(self, c_type: str, cs_type: str, name: str) -> tuple[str, str] | None:
        """``(csharp_type, argument expression)`` for one parameter, or None."""
        c = clean(c_type)
        if c in ("TimestampTz", "Timestamp"):
            return ("DateTime", f"MEOSConvert.ToTimestampTz({name})")
        if c == "DateADT":
            return ("DateOnly", f"MEOSConvert.ToDateADT({name})")
        if c == "interpType":
            return ("InterpolationType", f"(int) {name}")
        if c in PASSTHROUGH_C and cs_type != "IntPtr":
            return (cs_type, name)
        if cs_type == "string":
            return ("string", name)
        cls = self.m.class_for_ctype(c)
        if cls and cs_type == "IntPtr":
            return (cls, f"{name}.Ptr")
        return None

    # -- emission ---------------------------------------------------------

    def method_for(self, cls: str, entry: dict) -> Method | None:
        oo = entry["ooName"]
        fname = entry["function"]
        f = self.m.functions.get(fname)
        if f is None:
            self.deferred[cls].append(f"{oo}: no catalog function {fname}")
            return None
        signature = codegen.SIGNATURES.get(fname)
        if signature is None:
            self.deferred[cls].append(f"{oo}: {fname} has no emitted wrapper")
            return None
        wrapper_ret, wrapper_params = signature
        c_by_name = {
            (codegen.csharp_param_name(p["name"]) if p["name"] else "arg"): p["cType"]
            for p in f.get("params", [])
        }

        # `T *values, int count` is MEOS's counted-array convention: the pointer is
        # the first element of an array, not one value, so wrapping it as one
        # object would hand the callee a single element and a length that lies.
        raw = [p["name"] for p in f.get("params", [])]
        counted = set()
        for i, p in enumerate(f.get("params", [])):
            nxt = f["params"][i + 1] if i + 1 < len(f["params"]) else None
            if (clean(p["cType"]).endswith("*") and nxt
                    and nxt["name"] in ("count", "n")
                    and clean(nxt["cType"]) in ("int", "int32", "int32_t")):
                counted.add(codegen.csharp_param_name(p["name"]))

        recv_ctype = self.m.ctype.get(cls)
        params = list(wrapper_params)
        static = True
        args: list[str] = []
        if params and clean(c_by_name.get(params[0][1], "")) == f"{recv_ctype} *":
            static = False
            args.append("this.Ptr")
            params = params[1:]

        ret = self.map_return(f, wrapper_ret)
        if ret is None:
            self.deferred[cls].append(
                f"{oo}: return {clean(f['returnType']['c'])} needs wrapping")
            return None
        ret_type, ret_expr = ret
        if static and ret_type == "void":
            self.deferred[cls].append(f"{oo}: neither a receiver nor a value to return")
            return None

        sig: list[tuple[str, str]] = []
        for cs_type, pname in params:
            if pname in counted:
                self.deferred[cls].append(
                    f"{oo}: argument {pname} is a counted array")
                return None
            mapped = self.map_param(c_by_name.get(pname, ""), cs_type, pname)
            if mapped is None:
                self.deferred[cls].append(
                    f"{oo}: argument {pname} of type "
                    f"{clean(c_by_name.get(pname, cs_type))} needs marshalling")
                return None
            sig.append((mapped[0], pname))
            args.append(mapped[1])

        call = f"MEOSExposedFunctions.{fname}({', '.join(args)})"
        return Method(pascal(oo), ret_type, sig, ret_expr.replace("$", call), static)

    def inherited_names(self, cls: str) -> set[tuple]:
        names: set[tuple] = set()
        p = self.m.parent.get(cls)
        while p:
            names |= self.class_member_names.get(p, set())
            p = self.m.parent.get(p)
        return names

    def emit_class(self, cls: str) -> str:
        parent = self.m.parent.get(cls) or "MEOSObject"
        entries = [e for e in self.m.om["classes"].get(cls, {}).get("methods", [])
                   if not e.get("ooExclude")]
        methods = [m for m in (self.method_for(cls, e) for e in entries) if m]
        methods.sort(key=lambda m: (m.static, m.name))
        self.emitted += len(methods)

        # A method hides a base one only when the signature matches too, so the
        # `new` keyword is keyed on the whole signature: on the name alone C#
        # answers CS0109 for an overload that hides nothing.
        inherited = self.inherited_names(cls)
        self.class_member_names[cls] = {
            (m.name, tuple(t for t, _ in m.params)) for m in methods} | inherited

        lines = [
            "#nullable enable",
            "",
            "using MEOS.NET.Enums;",
            "using MEOS.NET.Internal;",
            "",
            f"namespace {NAMESPACE}",
            "{",
            f"    /// <summary>{self.doc_for(cls)}</summary>",
            f'    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "{GENERATOR_VERSION}")]',
            f"    public class {cls} : {parent}",
            "    {",
            f"        internal {cls}(IntPtr ptr) : base(ptr) {{ }}",
            "",
        ]
        for m in methods:
            args = ", ".join(f"{t} {ident(n)}" for t, n in m.params)
            new = "new " if (m.name, tuple(t for t, _ in m.params)) in inherited else ""
            kind = "static " if m.static else ""
            lines.append(f"        public {new}{kind}{m.ret} {m.name}({args})")
            lines.append(f"            => {m.body};")
            lines.append("")
        lines += ["    }", "}", ""]
        return "\n".join(lines)

    def doc_for(self, cls: str) -> str:
        node = self.m.om["lattice"].get(cls)
        if node and node.get("doc"):
            return node["doc"]
        for family in ("Box", "Collection"):
            node = self.m.om["companions"][family]["nodes"].get(cls)
            if node and node.get("doc"):
                return node["doc"]
        subtype = self.m.subtype_of.get(cls)
        if subtype:
            return f"A {self.m.parent[cls]} of subtype {subtype}."
        return f"The {cls} class of the MEOS object model."

    # -- files ------------------------------------------------------------

    def base_file(self) -> str:
        return f'''#nullable enable

namespace {NAMESPACE}
{{
    /// <summary>
    /// A handle on a value MEOS owns.  The pointer is what every generated method
    /// forwards to the C API; the memory behind it belongs to MEOS.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "{GENERATOR_VERSION}")]
    public abstract class MEOSObject
    {{
        internal IntPtr Ptr {{ get; }}

        internal MEOSObject(IntPtr ptr) => this.Ptr = ptr;
    }}
}}
'''

    def convert_file(self) -> str:
        """The two MEOS scalar time types in .NET terms.  MEOS states a timestamp
        and a date through its own text I/O, so the conversion goes through the
        same functions the C API reads and writes them with, not through an epoch
        arithmetic the binding would have to keep in step."""
        return f'''#nullable enable

using System.Globalization;

using MEOS.NET.Internal;

namespace {NAMESPACE}
{{
    /// <summary>The MEOS scalar time types as .NET values, and back.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "{GENERATOR_VERSION}")]
    internal static class MEOSConvert
    {{
        /// <summary>A MEOS TimestampTz as a DateTime.</summary>
        internal static DateTime ToDateTime(long timestamptz)
            => DateTime.Parse(MEOSExposedFunctions.timestamptz_out(timestamptz),
                CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal
                    | DateTimeStyles.AssumeUniversal);

        /// <summary>A DateTime as a MEOS TimestampTz.</summary>
        internal static long ToTimestampTz(DateTime moment)
            => MEOSExposedFunctions.timestamptz_in(
                moment.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss.ffffff+00",
                    CultureInfo.InvariantCulture), -1);

        /// <summary>A MEOS DateADT as a DateOnly.</summary>
        internal static DateOnly ToDateOnly(int date)
            => DateOnly.Parse(MEOSExposedFunctions.date_out(date),
                CultureInfo.InvariantCulture);

        /// <summary>A DateOnly as a MEOS DateADT.</summary>
        internal static int ToDateADT(DateOnly day)
            => MEOSExposedFunctions.date_in(
                day.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
    }}
}}
'''

    def error_codes(self) -> list[dict]:
        """The error taxonomy the model carries, verbatim from MEOS's own enum."""
        return self.m.om["errors"]["codes"]

    def error_codes_file(self) -> str:
        lines = [
            "#nullable enable",
            "",
            f"namespace {ERROR_NAMESPACE}",
            "{",
            "    /// <summary>Every code MEOS raises with, and what each one means.</summary>",
            f'    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "{GENERATOR_VERSION}")]',
            "    public enum MEOSErrorCodes",
            "    {",
        ]
        for code in self.error_codes():
            lines += [
                f"        /// <summary>{code['meaning']} (<c>{code['name']}</c>).</summary>",
                f"        {error_member(code['name'])} = {code['value']},",
                "",
            ]
        lines += ["    }", "}", ""]
        return "\n".join(lines)

    def exception_file(self, code: dict) -> str:
        member = error_member(code["name"])
        return f'''#nullable enable

using {ERROR_NAMESPACE};

namespace {EXCEPTION_NAMESPACE}
{{
    /// <summary>{code['meaning']} (<c>{code['name']}</c>).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "{GENERATOR_VERSION}")]
    public class MEOS{member}Exception : MEOSException
    {{
        internal MEOS{member}Exception(int level, MEOSErrorCodes code, string message)
            : base(level, code, message)
        {{ }}
    }}
}}
'''

    def exception_base_file(self) -> str:
        return f'''#nullable enable

using {ERROR_NAMESPACE};

namespace {EXCEPTION_NAMESPACE}
{{
    /// <summary>An error MEOS raised, with the code and level it raised it at.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "{GENERATOR_VERSION}")]
    public abstract class MEOSException : Exception
    {{
        public int Level {{ get; init; }}

        public MEOSErrorCodes Code {{ get; init; }}

        internal MEOSException(int level, MEOSErrorCodes code, string message)
            : base(message)
        {{
            this.Level = level;
            this.Code = code;
        }}
    }}
}}
'''

    def error_handling_file(self) -> str:
        """The handler MEOS calls, and the check every wrapper makes after a call.

        MEOS reports an error through the handler and returns; the value it returns
        then means nothing, so the wrapper raises what the handler recorded."""
        unknown = error_member(next(
            c["name"] for c in self.error_codes() if c["value"] == 1))
        lines = [
            "#nullable enable",
            "",
            f"using {EXCEPTION_NAMESPACE};",
            "",
            f"namespace {ERROR_NAMESPACE}",
            "{",
            "    /// <summary>Turns the error MEOS reports into the exception for its code.</summary>",
            f'    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "{GENERATOR_VERSION}")]',
            "    internal static class MEOSErrorHandling",
            "    {",
            "        private static MEOSException? pending;",
            "",
            "        /// <summary>Raise what MEOS reported since the last check, if anything.</summary>",
            "        internal static void CheckError()",
            "        {",
            "            if (pending is null)",
            "            {",
            "                return;",
            "            }",
            "",
            "            var raised = pending;",
            "            pending = null;",
            "            throw raised;",
            "        }",
            "",
            "        /// <summary>The handler MEOS calls; it records, and CheckError raises.</summary>",
            "        internal static void InternalErrorHandler(int level, int errorCode, string message)",
            "            => pending = errorCode switch",
            "            {",
        ]
        for code in self.error_codes():
            member = error_member(code["name"])
            if code["value"] == 0:
                lines.append(f"                {code['value']} => null,  // {code['name']}")
            else:
                lines.append(
                    f"                {code['value']} => new MEOS{member}Exception("
                    f"level, MEOSErrorCodes.{member}, message),")
        lines += [
            "                // A code this binding does not name is still an error MEOS",
            "                // raised, so it reaches the caller rather than being dropped.",
            f"                _ => new MEOS{unknown}Exception(",
            f"                    level, MEOSErrorCodes.{unknown}, message),",
            "            };",
            "    }",
            "}",
            "",
        ]
        return "\n".join(lines)

    def factory_file(self) -> str:
        """The runtime factory: a MEOS value carries its own type in its header, so
        a pointer is wrapped in the exact class the model gives that type.  Every
        temporal struct starts with the Temporal header, so one discriminator
        offset serves the whole temporal side."""
        lines = [
            "#nullable enable",
            "",
            "using System.Runtime.InteropServices;",
            "",
            f"namespace {NAMESPACE}",
            "{",
            "    /// <summary>",
            "    /// Wraps a MEOS pointer in the class the model gives its runtime type.",
            "    /// The discriminator is the struct field the catalog records, read at the",
            "    /// offset the catalog's own field layout puts it at.",
            "    /// </summary>",
            f'    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "{GENERATOR_VERSION}")]',
            "    internal static class MEOSFactory",
            "    {",
        ]
        temptype_offset = self.m.struct_offset("Temporal", "temptype")
        subtype_offset = self.m.struct_offset("Temporal", "subtype")
        subtype_values = {v["class"]: v["value"]
                          for v in self.m.om["axes"]["subtype"]["values"] if v.get("class")}

        # (discriminator field, its byte offset) per root; a root with no
        # discriminator is wrapped in the root class itself.
        discriminator = {
            "Temporal": ("Temporal.temptype", temptype_offset),
            "Set": ("Set.settype", self.m.struct_offset("Set", "settype")),
            "Span": ("Span.spantype", self.m.struct_offset("Span", "spantype")),
            "SpanSet": ("SpanSet.spansettype",
                        self.m.struct_offset("SpanSet", "spansettype")),
        }
        # Only the classes a pointer is actually wrapped in: the template subtypes
        # are Temporal at the surface (see Model.class_for_ctype).
        for root in ("Temporal", "Set", "Span", "SpanSet", "TBox", "STBox"):
            lines += self._wrap_method(root, discriminator.get(root),
                                       subtype_offset, subtype_values)
        lines += ["    }", "}", ""]
        return "\n".join(lines)

    def _wrap_method(self, root: str, discriminator, subtype_offset: int,
                     subtype_values: dict) -> list[str]:
        """``Wrap<Root>`` and ``Wrap<Root>Array`` for one root class."""
        lines = [
            f"        /// <summary>The value at <paramref name=\"ptr\"/> as the {root}",
            f"        /// class the model gives its runtime type.</summary>",
            f"        internal static {root}? Wrap{root}(IntPtr ptr)",
            "        {",
            "            if (ptr == IntPtr.Zero)",
            "            {",
            "                return null;",
            "            }",
            "",
        ]
        if discriminator is None:
            lines.append(f"            return new {root}(ptr);")
        else:
            field, offset = discriminator
            # The classes this root discriminates into: those whose instances are
            # pointers to this root's struct and that carry a MeosType constant.
            # For a template subtype the leaf's concrete class is the target.
            cases = []
            for cls, temptype in self.m.meostype.items():
                value = self.m.enum_values["MeosType"].get(temptype)
                if value is None:
                    continue
                if root == "Temporal":
                    if self.m.ctype.get(cls) != "Temporal":
                        continue
                    # A leaf with concrete product classes is refined by the
                    # subtype byte; one without is the class itself.
                    target = None if any(self.m.parent.get(c) == cls
                                         for c in self.m.subtype_of) else cls
                    cases.append((value, cls, temptype, target))
                elif self.m.ctype.get(cls) == root:
                    cases.append((value, cls, temptype, cls))
            lines += [
                f"            // {field}, at byte {offset}",
                f"            return Marshal.ReadByte(ptr, {offset}) switch",
                "            {",
            ]
            for value, cls, temptype, target in sorted(cases):
                call = f"Wrap{cls}Subtype(ptr)" if target is None else f"new {target}(ptr)"
                lines.append(f"                {value} => {call},  // {temptype}")
            lines += [
                f"                _ => new {root}(ptr),",
                "            };",
            ]
        lines += [
            "        }",
            "",
            f"        /// <summary>Every element of a C array of {root} pointers, wrapped.</summary>",
            f"        internal static {root}?[] Wrap{root}Array(IntPtr[] ptrs)",
            "        {",
            f"            {root}?[] wrapped = new {root}?[ptrs.Length];",
            "            for (int i = 0; i < ptrs.Length; i++)",
            "            {",
            f"                wrapped[i] = Wrap{root}(ptrs[i]);",
            "            }",
            "",
            "            return wrapped;",
            "        }",
            "",
        ]
        if root == "Temporal":
            for leaf in sorted({self.m.parent[c] for c in self.m.subtype_of}):
                lines += [
                    f"        /// <summary>The concrete {leaf} class for the template subtype",
                    f"        /// at byte {subtype_offset}.</summary>",
                    f"        private static {leaf} Wrap{leaf}Subtype(IntPtr ptr)",
                    f"            => Marshal.ReadByte(ptr, {subtype_offset}) switch",
                    "            {",
                ]
                for subtype, suffix in SUBTYPE_SUFFIX.items():
                    concrete = leaf + suffix
                    if concrete in self.m.parent:
                        lines.append(
                            f"                {subtype_values[subtype]} => new {concrete}(ptr),")
                lines += [
                    f"                _ => new {leaf}(ptr),",
                    "            };",
                    "",
                ]
        return lines

    def run(self, out_dir: Path) -> None:
        if out_dir.exists():
            shutil.rmtree(out_dir)
        out_dir.mkdir(parents=True)
        (out_dir / "MEOSObject.g.cs").write_text(self.base_file())
        (out_dir / "MEOSConvert.g.cs").write_text(self.convert_file())
        for cls in self.m.classes():
            (out_dir / f"{cls}.g.cs").write_text(self.emit_class(cls))
        (out_dir / "MEOSFactory.g.cs").write_text(self.factory_file())

    def run_errors(self, errors_dir: Path, exceptions_dir: Path) -> None:
        for directory in (errors_dir, exceptions_dir):
            if directory.exists():
                shutil.rmtree(directory)
            directory.mkdir(parents=True)
        (errors_dir / "MEOSErrorCodes.g.cs").write_text(self.error_codes_file())
        (errors_dir / "MEOSErrorHandling.g.cs").write_text(self.error_handling_file())
        (exceptions_dir / "MEOSException.g.cs").write_text(self.exception_base_file())
        for code in self.error_codes():
            if code["value"] == 0:
                continue
            member = error_member(code["name"])
            (exceptions_dir / f"MEOS{member}Exception.g.cs").write_text(
                self.exception_file(code))


def main() -> int:
    ap = argparse.ArgumentParser(description=__doc__)
    ap.add_argument("idl", metavar="meos-idl.json", help="path to the MEOS-API catalog")
    ap.add_argument("--report", action="store_true",
                    help="print what each class deferred and why")
    args = ap.parse_args()

    idl = json.loads(Path(args.idl).read_bytes().decode())
    codegen.configure(idl)
    # Populate codegen.SIGNATURES: the object layer calls the wrappers codegen.py
    # emits, so it reads their signatures from the same run that decides them.
    codegen.gen_exposed_functions(idl["functions"])

    model = Model(idl)
    gen = Generator(model)
    repo_root = Path(__file__).resolve().parent.parent
    gen.run(repo_root / "MEOS.NET" / "Types" / "Generated")
    gen.run_errors(repo_root / "MEOS.NET" / "Errors",
                   repo_root / "MEOS.NET" / "Exceptions")

    classes = model.classes()
    total_deferred = sum(len(v) for v in gen.deferred.values())
    print(f"objectgen: {len(classes)} classes, {gen.emitted} methods emitted, "
          f"{total_deferred} deferred", file=sys.stderr)
    if args.report:
        for cls in classes:
            reasons = gen.deferred.get(cls, [])
            if reasons:
                print(f"--- {cls} ({len(reasons)} deferred)", file=sys.stderr)
                for r in sorted(reasons):
                    print(f"    {r}", file=sys.stderr)
    return 0


if __name__ == "__main__":
    sys.exit(main())
