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
delegating to the ``Meos`` wrapper that ``codegen.py`` emits for the
same function.

The wrapper signatures come from ``codegen.SIGNATURES`` rather than from the raw C
parameter list, so the two generators cannot disagree about a folded out-parameter.

Usage:
    python3 tools/objectgen.py path/to/meos-idl.json [--report]

Writes MEOS.NET/Types/*.g.cs, plus the error taxonomy under MEOS.NET/Errors
 and MEOS.NET/Exceptions, replacing those directories.
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
NAMESPACE = "MEOS.NET.Types"
ENUM_NAMESPACE = "MEOS.NET.Enums"
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

# What a value out-parameter of each pointee type reads back as: the C# type, the
# bytes to allocate for it, and how to read the value MEOS wrote there.
OUT_PARAM_READERS = {
    "double *": ("double", 8, "Marshal.PtrToStructure<double>({0})"),
    "float8 *": ("double", 8, "Marshal.PtrToStructure<double>({0})"),
    "bool *": ("bool", 1, "Marshal.ReadByte({0}) != 0"),
    "int *": ("int", 4, "Marshal.ReadInt32({0})"),
    "int32_t *": ("int", 4, "Marshal.ReadInt32({0})"),
    "int64_t *": ("long", 8, "Marshal.ReadInt64({0})"),
    "TimestampTz *": ("DateTime", 8, "MEOSConvert.ToDateTime(Marshal.ReadInt64({0}))"),
    "DateADT *": ("DateOnly", 4, "MEOSConvert.ToDateOnly(Marshal.ReadInt32({0}))"),
}

def is_scalar(cs_type: str) -> bool:
    """Whether the wrapper already states this as a C# value the layer hands on.

    The wrapper's own C# type is what decides it: codegen resolves every scalar
    the catalog names — through the typedefs it carries, so `S2CellId` reads
    `ulong` and `float8` reads `double` — and a struct it carries by value is a
    value too. A second list of C spellings here would answer for the ones the
    layer was told about and defer the rest."""
    return cs_type in _SCALAR_CS or cs_type in codegen.BY_VALUE_STRUCTS


_SCALAR_CS = set(codegen.SCALAR_MAP.values()) | {"void", "bool", "string", "string?"}

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


def scratch(name: str) -> str:
    """The name of a local the body derives from a parameter's.

    A parameter whose name is a C# keyword is escaped to `@out`, and `_@out` is
    no identifier at all — the escape belongs at the START of a name or nowhere,
    so a derived name drops it."""
    return "_" + name.lstrip("@")


def pascal(oo_name: str) -> str:
    return oo_name[:1].upper() + oo_name[1:]


def enum_type_name(name: str) -> str:
    """The C# name of a catalog enum: `interpType` reads `InterpType`, and a name
    that already starts upper — `MeosType`, `SPTreeKind`, `ENDIANS` — stands."""
    return name[:1].upper() + name[1:]


def enum_member(value_name: str) -> str:
    """The C# name of an enum constant: `INTERP_NONE` reads `InterpNone`,
    `TSEQUENCE` reads `Tsequence` — each underscore-separated part capitalized,
    the same rule the function names carry."""
    return "".join(part.capitalize() for part in value_name.lower().split("_") if part)


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
        self.wrap_root: dict[str, str] = {}     # C struct -> the class it wraps as
        self._build()

    def _build(self) -> None:
        lattice = self.om["lattice"]
        for name, node in lattice.items():
            self.parent[name] = node["parent"]
            temptypes = node.get("temptypes") or []
            if node["kind"] == "leaf" and len(temptypes) == 1:
                self.meostype[name] = temptypes[0]

        # The template subtypes are classes of their own, under the root.
        for value in self.om["axes"]["subtype"]["values"]:
            cls = value.get("class")
            if cls:
                self.parent[cls] = "Temporal"

        # A concrete class is `<leaf><suffix>`: it inherits the leaf's family surface
        # and its instances are pointers to the template subtype's struct.
        for leaf in [n for n, v in lattice.items() if v["kind"] == "leaf"]:
            for subtype, suffix in SUBTYPE_SUFFIX.items():
                concrete = leaf + suffix
                if concrete in self.om["classes"]:
                    self.parent[concrete] = leaf
                    self.subtype_of[concrete] = subtype

        for family in self.companion_families():
            for name, node in self.om["companions"][family]["nodes"].items():
                if name.startswith("_"):
                    continue
                self.parent[name] = node["parent"]
                if node.get("temptype"):
                    self.meostype[name] = node["temptype"]

        # What a class's instances are a pointer to is the catalog's to say, so
        # every class takes the `cType` the model derives from MEOS's own
        # signatures. A binding holding that map itself is one a class the model
        # gains cannot reach until the map is edited.
        for name, spec in self.om["classes"].items():
            if spec.get("cType"):
                self.ctype[name] = spec["cType"]

        # A pointer to a C struct is wrapped in the SHALLOWEST class carrying it,
        # so a `GSERIALIZED *` is a Geo and its Geometry and Geography leaves stay
        # distinct classes under it, exactly as a `Set *` is a Set.
        for name, ct in self.ctype.items():
            best = self.wrap_root.get(ct)
            if best is None or self._depth(name) < self._depth(best):
                self.wrap_root[ct] = name

    def companion_families(self) -> list[str]:
        """The companion hierarchies the model carries, in its own order."""
        return [k for k in self.om["companions"] if not k.startswith("_")]

    def _depth(self, cls: str) -> int:
        depth, seen = 0, {cls}
        parent = self.parent.get(cls)
        while parent and parent not in seen:
            seen.add(parent)
            depth += 1
            parent = self.parent.get(parent)
        return depth

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
        return self.wrap_root.get(base)


class Method:
    """One emitted method: its C# signature and the wrapper call behind it."""

    def __init__(self, name: str, ret: str, params: list[tuple[str, str]],
                 body: str, static: bool, arrays: list[tuple[str, str]] | None = None,
                 out_param: tuple[str, int, str] | None = None,
                 structs: list[tuple[str, str]] | None = None,
                 scalar_arrays: list[str] | None = None,
                 length_out: str | None = None, byte_buffer: bool = False):
        self.name = name
        self.ret = ret
        self.params = params
        self.body = body
        self.static = static
        # (parameter name, element class) for each counted array the method takes.
        self.arrays = arrays or []
        # (parameter name, bytes, reader expression) for a value out-parameter.
        self.out_param = out_param
        # (parameter name, struct type) for each struct argument passed by value.
        self.structs = structs or []
        # The caller's own arrays of scalars, pinned across the call.
        self.scalar_arrays = scalar_arrays or []
        # The out-parameter MEOS states the answered buffer's length in, and
        # whether that buffer is the answer itself.
        self.length_out = length_out
        self.byte_buffer = byte_buffer


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
        if c in codegen.ENUM_TYPES:
            return (enum_type_name(c), f"({enum_type_name(c)}) $")
        if is_scalar(wrapper_ret):
            return (wrapper_ret, "$")
        cls = self.m.class_for_ctype(c)
        if cls and wrapper_ret == "IntPtr":
            return (f"{cls}?", f"MEOSFactory.Wrap{cls}($)")
        if wrapper_ret == "IntPtr[]":
            # An array of MEOS values reaches the wrapper as an array of pointers,
            # whether MEOS returns pointers (`T **`) or the values themselves
            # (`T *`, walked at the struct's own stride), so both wrap element by
            # element into the class each value's header names.
            elem = self.m.class_for_ctype(c[:-1] if c.endswith(" **") else c)
            if elem:
                return (f"{elem}?[]", f"MEOSFactory.Wrap{elem}Array($)")
        # An array of scalars is handed on as it stands, whichever scalar it is
        # — the wrapper has already read it at the element's own width.
        if wrapper_ret.endswith("[]") and is_scalar(wrapper_ret[:-2]):
            return (wrapper_ret, "$")
        if c == "void *" and wrapper_ret == "IntPtr":
            return ("IntPtr", "$")
        struct = self.value_struct(c)
        if struct and wrapper_ret == "IntPtr":
            return (f"{struct}?", f"MEOSConvert.ToStruct<{struct}>($)")
        if struct and wrapper_ret == "IntPtr[]":
            return (f"{struct}[]", f"MEOSConvert.ToStructArray<{struct}>($)")
        return None

    def wrapped_out_reader(self, pointee: str) -> tuple[str, int, str] | None:
        """The reader for a value MEOS writes through a pointer to a pointer.

        The buffer holds the ADDRESS of the value rather than the value, so the
        reader takes that address out of it and wraps it in the class the model
        gives the type — the same wrap a return of that type gets."""
        if not pointee.endswith("**"):
            return None
        cls = self.m.class_for_ctype(pointee[:-1].strip())
        if cls is None:
            return None
        return (cls, 8, f"MEOSFactory.Wrap{cls}(Marshal.ReadIntPtr({{0}}))")

    def value_struct(self, c_type: str) -> str | None:
        """The struct a single pointer to a scalar-only struct carries.

        MEOS hands such a value over through a pointer, but nothing about it is
        opaque: the catalog states its whole layout and no class stands for it,
        so the layer carries the value rather than the address."""
        base = clean(c_type)
        base = base[:-1].strip() if base.endswith("*") else base
        base = base[:-1].strip() if base.endswith("*") else base
        return base if base in codegen.BY_VALUE_STRUCTS else None

    def map_param(self, c_type: str, cs_type: str, name: str) -> tuple[str, str] | None:
        """``(csharp_type, argument expression)`` for one parameter, or None."""
        c = clean(c_type)
        if c in ("TimestampTz", "Timestamp"):
            return ("DateTime", f"MEOSConvert.ToTimestampTz({name})")
        if c == "DateADT":
            return ("DateOnly", f"MEOSConvert.ToDateADT({name})")
        if c in codegen.ENUM_TYPES:
            # The wrapper takes the enum's value as an int, and the catalog
            # already names every enum the surface uses — so a method takes the
            # C# enum whichever one it is, rather than the one enum the layer
            # was told about.
            return (enum_type_name(c), f"(int) {name}")
        if is_scalar(cs_type):
            return (cs_type, name)
        if cs_type == "string":
            return ("string", name)
        cls = self.m.class_for_ctype(c)
        if cls and cs_type == "IntPtr":
            return (cls, f"{name}.Ptr")
        # An UNTYPED pointer stays untyped: MEOS states nothing about what it
        # points at, so the layer states nothing either and the caller hands
        # over the pointer of the value it means — the `Ptr` every wrapped
        # instance publishes. GoMEOS answers the same shape with
        # `unsafe.Pointer`.
        if c == "void *" and cs_type == "IntPtr":
            return ("IntPtr", name)
        struct = self.value_struct(c)
        if struct and cs_type == "IntPtr":
            return (struct, scratch(name))
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

        # An array ARGUMENT is one parameter to the caller and two to MEOS, the
        # pointer and its length. Which parameters those are is the catalog's to
        # say — `shape.inputArrays` names each array, the parameter its length
        # comes from and its element type — so the layer reads it rather than
        # matching a length by its name, which the surface spells eight ways.
        input_arrays = (f.get("shape") or {}).get("inputArrays") or []
        counted = {codegen.csharp_param_name(a["param"]): a["element"]["c"]
                   for a in input_arrays}
        recv_ctype = self.m.ctype.get(cls)

        params = list(wrapper_params)
        static = True
        args: list[str] = []
        if params and clean(c_by_name.get(params[0][1], "")) == f"{recv_ctype} *":
            static = False
            args.append("this.Ptr")
            params = params[1:]

        # A `size_t *` out-parameter states the LENGTH of the buffer the call
        # answers. It leaves the C# signature — a byte array and a string each
        # carry their own length — and the buffer MEOS writes it into is
        # allocated for the call.
        out_params = (f.get("shape") or {}).get("outParams") or []
        length_out = next(
            (codegen.csharp_param_name(p["name"]) for p in f.get("params", [])
             if p["name"] in out_params and clean(p["cType"]) == "size_t *"), None)
        if length_out:
            out_params = [o for o in out_params
                          if codegen.csharp_param_name(o) != length_out]

        # A `bool` return with one value out-parameter is MEOS saying whether the
        # value exists: the method answers the value, or nothing.
        result_out = None
        if clean(f["returnType"]["c"]) == "bool" and len(out_params) == 1:
            pointee = clean(next(
                (p["cType"] for p in f.get("params", [])
                 if p["name"] == out_params[0]), ""))
            reader = OUT_PARAM_READERS.get(pointee) or self.wrapped_out_reader(pointee)
            if reader:
                result_out = (codegen.csharp_param_name(out_params[0]), reader)
            else:
                self.deferred[cls].append(
                    f"{oo}: the value out-parameter {out_params[0]} is a "
                    f"{pointee}, which has no reader")
                return None

        if length_out and clean(f["returnType"]["c"]) == "uint8_t *":
            ret = ("byte[]?", "$")
        else:
            ret = self.map_return(f, wrapper_ret)
        if ret is None:
            self.deferred[cls].append(
                f"{oo}: return {clean(f['returnType']['c'])} needs wrapping")
            return None
        ret_type, ret_expr = ret

        # The length is the array's own, so it leaves the C# signature.
        count_of = {codegen.csharp_param_name(a["lengthFrom"]["name"]):
                    codegen.csharp_param_name(a["param"])
                    for a in input_arrays}

        if result_out is not None:
            ret_type = f"{result_out[1][0]}?"
            ret_expr = "$"

        sig: list[tuple[str, str]] = []
        arrays: list[tuple[str, str]] = []
        scalar_arrays: list[str] = []
        structs: list[tuple[str, str]] = []
        for cs_type, pname in params:
            if result_out is not None and pname == result_out[0]:
                args.append(scratch(pname))
                continue
            if pname == length_out:
                args.append(scratch(pname))
                continue
            if pname in count_of:
                cast = "" if cs_type == "int" else f"({cs_type}) "
                args.append(f"{cast}{count_of[pname]}.Length")
                continue
            if pname in counted:
                pointee = clean(counted[pname])
                element = self.m.class_for_ctype(pointee)
                if element is not None:
                    sig.append((f"{element}[]", pname))
                    arrays.append((pname, element))
                    args.append(f"{scratch(pname)}.AddrOfPinnedObject()")
                    continue
                # A scalar element is the array itself: the values need no
                # gathering, so what is pinned is the caller's own array.
                scalar = codegen.SCALAR_MAP.get(pointee)
                if scalar is not None:
                    sig.append((f"{scalar}[]", pname))
                    scalar_arrays.append(pname)
                    args.append(f"{scratch(pname)}.AddrOfPinnedObject()")
                    continue
                self.deferred[cls].append(
                    f"{oo}: argument {pname} is an array of "
                    f"{pointee}, which has no class")
                return None
            mapped = self.map_param(c_by_name.get(pname, ""), cs_type, pname)
            if mapped is None:
                self.deferred[cls].append(
                    f"{oo}: argument {pname} of type "
                    f"{clean(c_by_name.get(pname, cs_type))} needs marshalling")
                return None
            sig.append((mapped[0], pname))
            args.append(mapped[1])
            if mapped[1] == scratch(pname) and self.value_struct(c_by_name.get(pname, "")):
                structs.append((pname, mapped[0]))

        call = f"Meos.{codegen.public_name(fname)}({', '.join(args)})"
        out = None
        if result_out is not None:
            name, (_, size, reader) = result_out
            out = (name, size, reader.format(scratch(name)))
        if structs and (arrays or out or scalar_arrays or length_out):
            self.deferred[cls].append(
                f"{oo}: a struct argument beside a counted array or an "
                "out-parameter needs one body doing both")
            return None
        if length_out and (arrays or out):
            self.deferred[cls].append(
                f"{oo}: a length out-parameter beside a counted array or a "
                "value out-parameter needs one body doing both")
            return None
        return Method(pascal(oo), ret_type, sig, ret_expr.replace("$", call), static,
                      arrays, out, structs, scalar_arrays, length_out,
                      ret_type == "byte[]?")

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
            "using System.Runtime.InteropServices;",
            "",
            "using MEOS.NET.Enums;",
            "using MEOS.NET.Functions;",
            "using MEOS.NET.Structures;",
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
        lines += self.to_string(cls, methods)
        for m in methods:
            args = ", ".join(f"{t} {ident(n)}" for t, n in m.params)
            new = "new " if (m.name, tuple(t for t, _ in m.params)) in inherited else ""
            kind = "static " if m.static else ""
            lines.append(f"        public {new}{kind}{m.ret} {m.name}({args})")
            if m.out_param:
                lines.extend(self.out_param_body(m))
            elif m.length_out:
                lines.extend(self.buffer_body(m))
            elif m.arrays or m.scalar_arrays:
                lines.extend(self.array_body(m))
            elif m.structs:
                lines.extend(self.struct_body(m))
            else:
                lines.append(f"            => {m.body};")
            lines.append("")
        lines += ["    }", "}", ""]
        return "\n".join(lines)

    def out_param_body(self, method: Method) -> list[str]:
        """The body of a method whose value MEOS writes through an out-parameter.

        MEOS answers `false` when the value does not exist and leaves the
        out-parameter untouched, so the method answers null there and the value
        otherwise."""
        name, size, reader = method.out_param
        return [
            "        {",
            f"            IntPtr {scratch(name)} = Marshal.AllocHGlobal({size});",
            "            try",
            "            {",
            f"                if (!{method.body})",
            "                {",
            "                    return null;",
            "                }",
            "",
            f"                return {reader};",
            "            }",
            "            finally",
            "            {",
            f"                Marshal.FreeHGlobal({scratch(name)});",
            "            }",
            "        }",
        ]

    def struct_body(self, method: Method) -> list[str]:
        """The body of a method taking a struct MEOS reads through a pointer.

        The caller hands over a value, so the call gets the address of a copy
        that lives exactly as long as it does. MEOS reads what it needs before
        returning — the values it keeps it copies — so nothing outlives the
        frame."""
        lines = ["        {"]
        for name, struct in method.structs:
            lines.append(
                f"            IntPtr {scratch(name)} = "
                f"Marshal.AllocHGlobal(Marshal.SizeOf<{struct}>());")
        lines.append("            try")
        lines.append("            {")
        for name, _ in method.structs:
            lines.append(
                f"                Marshal.StructureToPtr({ident(name)}, {scratch(name)}, false);")
        lines.append(f"                return {method.body};")
        lines.append("            }")
        lines.append("            finally")
        lines.append("            {")
        for name, _ in method.structs:
            lines.append(f"                Marshal.FreeHGlobal({scratch(name)});")
        lines += ["            }", "        }"]
        return lines

    def buffer_body(self, method: Method) -> list[str]:
        """The body of a method whose call states a length through a pointer.

        MEOS writes the length of what it answers into a buffer the caller
        supplies. A string carries its own length, so there the buffer is
        written and dropped; a byte array does not, so there it says how much of
        what MEOS answered to copy."""
        name = method.length_out
        lines = [
            "        {",
            f"            IntPtr {scratch(name)} = Marshal.AllocHGlobal(sizeof(long));",
            "            try",
            "            {",
        ]
        if method.byte_buffer:
            lines += [
                f"                IntPtr _bytes = {method.body};",
                "                if (_bytes == IntPtr.Zero)",
                "                {",
                "                    return null;",
                "                }",
                "",
                f"                byte[] _wkb = new byte[Marshal.ReadInt64({scratch(name)})];",
                "                Marshal.Copy(_bytes, _wkb, 0, _wkb.Length);",
                "                return _wkb;",
            ]
        else:
            lines.append(f"                return {method.body};")
        lines += [
            "            }",
            "            finally",
            "            {",
            f"                Marshal.FreeHGlobal({scratch(name)});",
            "            }",
            "        }",
        ]
        return lines

    def array_body(self, method: Method) -> list[str]:
        """The body of a method taking a counted array.

        MEOS reads an array of its own values through a pointer to the first
        element, so the wrappers' pointers are gathered into one array and pinned
        for the call.  MEOS copies what it keeps, so the pin lasts exactly as long
        as the call does."""
        lines = ["        {"]
        for name in method.scalar_arrays:
            lines.append(
                f"            GCHandle {scratch(name)} = "
                f"GCHandle.Alloc({ident(name)}, GCHandleType.Pinned);")
        for name, element in method.arrays:
            lines += [
                f"            IntPtr[] {scratch(name)}Values = new IntPtr[{ident(name)}.Length];",
                f"            for (int i = 0; i < {ident(name)}.Length; i++)",
                "            {",
                f"                {scratch(name)}Values[i] = {ident(name)}[i].Ptr;",
                "            }",
                "",
                f"            GCHandle {scratch(name)} = GCHandle.Alloc({scratch(name)}Values, GCHandleType.Pinned);",
            ]
        lines.append("            try")
        lines.append("            {")
        lines.append(f"                return {method.body};")
        lines.append("            }")
        lines.append("            finally")
        lines.append("            {")
        for name in method.scalar_arrays:
            lines.append(f"                {scratch(name)}.Free();")
        for name, _ in method.arrays:
            lines.append(f"                {scratch(name)}.Free();")
        lines += ["            }", "        }"]
        return lines

    def to_string(self, cls: str, methods: list) -> list[str]:
        """`ToString` over the class's own text output, where MEOS publishes one.

        MEOS publishes text output per concrete type — `tfloat_out`, `stbox_out`,
        `floatspan_out` — and keeps the generic dispatchers internal, so a class
        that carries an `Out` of its own is exactly a class whose values MEOS
        writes.  The decimal digits are the default the catalog records for that
        C type's text encoding."""
        out = next((m for m in methods if m.name == "Out" and not m.static
                    and [t for t, _ in m.params] in ([], ["int"])), None)
        if out is None:
            return []
        ctype = self.m.ctype.get(cls)
        encoding = self.m.idl.get("typeEncodings", {}).get(ctype, {})
        aux = {a["name"]: a["default"] for a in encoding.get("out_aux", [])}
        argument = str(aux.get("maxdd", "")) if out.params else ""
        if out.params and not argument:
            return []
        nullable = "?" if out.ret.endswith("?") else ""
        return [
            "        /// <summary>The text MEOS writes this value as.</summary>",
            f"        public override string{nullable} ToString()",
            f"            => this.Out({argument});",
            "",
        ]

    def doc_for(self, cls: str) -> str:
        node = self.m.om["lattice"].get(cls)
        if node and node.get("doc"):
            return node["doc"]
        for family in self.m.companion_families():
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
        /// <summary>The MEOS value this object holds, for the functions on
        /// <see cref="MEOS.NET.Functions.Meos"/> that take it.</summary>
        public IntPtr Ptr {{ get; }}

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
using System.Runtime.InteropServices;

using MEOS.NET.Functions;

namespace {NAMESPACE}
{{
    /// <summary>The MEOS scalar time types as .NET values, and back.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "{GENERATOR_VERSION}")]
    internal static class MEOSConvert
    {{
        /// <summary>A MEOS TimestampTz as a DateTime.</summary>
        internal static DateTime ToDateTime(long timestamptz)
            => DateTime.Parse(Meos.TimestamptzOut(timestamptz),
                CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal
                    | DateTimeStyles.AssumeUniversal);

        /// <summary>A DateTime as a MEOS TimestampTz.</summary>
        internal static long ToTimestampTz(DateTime moment)
            => Meos.TimestamptzIn(
                moment.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss.ffffff+00",
                    CultureInfo.InvariantCulture), -1);

        /// <summary>A MEOS DateADT as a DateOnly.</summary>
        internal static DateOnly ToDateOnly(int date)
            => DateOnly.Parse(Meos.DateOut(date),
                CultureInfo.InvariantCulture);

        /// <summary>A DateOnly as a MEOS DateADT.</summary>
        internal static int ToDateADT(DateOnly day)
            => Meos.DateIn(
                day.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));

        /// <summary>The struct MEOS answers through a pointer, as a value. The
        /// memory behind the pointer stays MEOS's, as it does for every other
        /// value the layer reads back.</summary>
        internal static T? ToStruct<T>(IntPtr ptr) where T : struct
            => ptr == IntPtr.Zero ? null : Marshal.PtrToStructure<T>(ptr);

        /// <summary>Each struct of an array MEOS answers, as a value.</summary>
        internal static T[] ToStructArray<T>(IntPtr[] ptrs) where T : struct
        {{
            T[] values = new T[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {{
                values[i] = Marshal.PtrToStructure<T>(ptrs[i]);
            }}

            return values;
        }}
    }}
}}
'''

    # The error taxonomy has a file of its own, with an exception class per code;
    # the plain enums are projected as they stand.
    ENUM_EXCLUDE = ("errorCode",)

    def enum_file(self, enum: dict) -> str:
        name = enum_type_name(enum["name"])
        lines = [
            "#nullable enable",
            "",
            f"namespace {ENUM_NAMESPACE}",
            "{",
            f"    /// <summary>The MEOS <c>{enum['name']}</c> enum, from <c>{enum.get('file', '')}</c>.</summary>",
            f'    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "{GENERATOR_VERSION}")]',
            f"    public enum {name}",
            "    {",
        ]
        seen: set[str] = set()
        for value in enum.get("values", []):
            member = enum_member(value["name"])
            if member in seen:
                raise SystemExit(
                    f"objectgen: {enum['name']} has two values reading {member} in C#")
            seen.add(member)
            lines += [
                f"        /// <summary><c>{value['name']}</c></summary>",
                f"        {member} = {value['value']},",
                "",
            ]
        lines += ["    }", "}", ""]
        return "\n".join(lines)

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
            "    /// <remarks>",
            "    /// This is the way back from a function on",
            "    /// <see cref=\"MEOS.NET.Functions.Meos\"/>, which answers the MEOS pointer,",
            "    /// into the object layer.",
            "    /// </remarks>",
            f'    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "{GENERATOR_VERSION}")]',
            "    public static class MEOSFactory",
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
        roots = [r for c, r in sorted(self.m.wrap_root.items())
                 if c not in TEMPORAL_STRUCTS or r == "Temporal"]
        for root in roots:
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
            f"        public static {root}? Wrap{root}(IntPtr ptr)",
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
            f"        public static {root}?[] Wrap{root}Array(IntPtr[] ptrs)",
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

    def run_enums(self, enums_dir: Path) -> int:
        """One C# enum per catalog enum, so a caller names a MEOS constant rather
        than passing the int the C API takes."""
        if enums_dir.exists():
            shutil.rmtree(enums_dir)
        enums_dir.mkdir(parents=True)
        emitted = 0
        for enum in self.m.idl.get("enums", []):
            if not enum.get("name") or enum["name"] in self.ENUM_EXCLUDE:
                continue
            (enums_dir / f"{enum_type_name(enum['name'])}.g.cs").write_text(
                self.enum_file(enum))
            emitted += 1
        return emitted

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
    gen.run(repo_root / "MEOS.NET" / "Types")
    gen.run_errors(repo_root / "MEOS.NET" / "Errors",
                   repo_root / "MEOS.NET" / "Exceptions")
    enums = gen.run_enums(repo_root / "MEOS.NET" / "Enums")

    classes = model.classes()
    total_deferred = sum(len(v) for v in gen.deferred.values())
    print(f"objectgen: {len(classes)} classes, {gen.emitted} methods emitted, "
          f"{total_deferred} deferred, {enums} enums", file=sys.stderr)
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
