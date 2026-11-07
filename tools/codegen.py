#!/usr/bin/env python3
"""Generate MEOSExternalFunctions.cs and MEOSExposedFunctions.cs from MEOS-API's meos-idl.json.

Consumes the unified MEOS API catalog (https://github.com/MobilityDB/MEOS-API) and produces
the two MEOS.NET internal-binding files. Replaces the regex-based MEOS.NET.Builder which has
known parse defects on signatures like `int32_t srid` (rendered as `int_t`).

Usage:
    python3 tools/codegen.py path/to/meos-idl.json [--dll-path NAME]

Writes MEOS.NET/Internal/MEOSExternalFunctions.cs and MEOSExposedFunctions.cs in-place.
"""

from __future__ import annotations

import argparse
import json
import sys
from pathlib import Path

import gapledger

# What this run could not read out of the catalog, or None when the surface is
# generated for its signatures alone — objectgen.py does that, and keeps its own
# account.  A fall-through below records into it rather than quietly emitting
# the weaker form.
LEDGER: gapledger.Ledger | None = None


def _gap(kind: str, *row: str) -> None:
    if LEDGER is not None:
        LEDGER.record(kind, *row)

# Default lets the OS loader resolve via LD_LIBRARY_PATH / DYLD_LIBRARY_PATH /
# PATH; override with --dll-path to embed a specific library name or path.
DLL_PATH = "meos"
GENERATOR_VERSION = "0.1.0"

# The public surface: one static class, in one namespace, split across one file
# per MEOS header exactly as the catalog groups the functions.
NAMESPACE = "MEOS.NET.Functions"
CLASS = "Meos"
STRUCT_NAMESPACE = "MEOS.NET.Structures"

# The C standard types a slot's `canonical` states a width in: the C# type each
# crosses the boundary as, and its size in bytes, which is also its alignment, on
# the 64-bit targets the binding ships for.  Every other name `canonical` uses is
# the catalog's own — an enum, a struct, a callback, or an entry of `typedefs`
# that resolves to one of these — so no MEOS or PostgreSQL spelling has a row.
# A pointer-sized unsigned integer reads `ulong`, as `size_t` does.
C_TYPES: dict[str, tuple[str, int]] = {
    "void": ("void", 0),
    "bool": ("bool", 1),
    "char": ("byte", 1),
    "signed char": ("sbyte", 1),
    "unsigned char": ("byte", 1),
    "short": ("short", 2),
    "unsigned short": ("ushort", 2),
    "int": ("int", 4),
    "unsigned int": ("uint", 4),
    "long": ("long", 8),
    "unsigned long": ("ulong", 8),
    "long long": ("long", 8),
    "unsigned long long": ("ulong", 8),
    "float": ("float", 4),
    "double": ("double", 8),
    "int8_t": ("sbyte", 1),
    "uint8_t": ("byte", 1),
    "int16_t": ("short", 2),
    "uint16_t": ("ushort", 2),
    "int32_t": ("int", 4),
    "uint32_t": ("uint", 4),
    "int64_t": ("long", 8),
    "uint64_t": ("ulong", 8),
    "size_t": ("ulong", 8),
    "ssize_t": ("long", 8),
    "intptr_t": ("long", 8),
    "uintptr_t": ("ulong", 8),
}

# The C# types a scalar crosses the boundary as.
SCALAR_CS: set[str] = {cs for cs, _size in C_TYPES.values()}

# The names PostgreSQL and MEOS declare and `canonical` keeps — `TimestampTz`,
# `Datum`, `Oid`, `text` — each with the type it is defined as, filled in by
# ``configure`` from the catalog's `typedefs`.
TYPEDEFS: dict[str, str] = {}

# The catalog's callback types by name, filled in by ``configure``: a function
# pointer at the ABI.
CALLBACKS: set[str] = set()


class UnmappedType(SystemExit):
    """A type the catalog names that this generator cannot map.

    The run stops on it: a binding emitted with a guessed width reads the
    wrong bytes at run time, and nothing downstream can tell."""

    def __init__(self, c_type: str, where: str):
        super().__init__(f"codegen: {where}: C type {c_type!r} maps to no C# "
                         f"type — it is no C standard type and the catalog "
                         f"states it as no enum, struct, callback or typedef")


def _bare(c_type: str) -> str:
    """The type without `const` and without a `struct` tag, single-spaced."""
    t = " ".join(c_type.replace("const ", "").split())
    return t[len("struct "):] if t.startswith("struct ") else t


def is_pointer(c_type: str) -> bool:
    """Whether the type crosses the boundary as an address: a pointer of any
    depth, an array, or a function pointer."""
    return "*" in c_type or "[" in c_type


def resolve(c_type: str, where: str) -> str:
    """The name a by-value type is at the ABI: a C standard type, an enum, a
    struct or a callback, reached through the catalog's `typedefs`."""
    t = _bare(c_type)
    seen: set[str] = set()
    while t in TYPEDEFS and t not in C_TYPES and t not in seen:
        seen.add(t)
        t = _bare(TYPEDEFS[t])
    if t in C_TYPES or t in ENUM_TYPES or t in STRUCT_NAMES or t in CALLBACKS:
        return t
    raise UnmappedType(c_type, where)


def scalar_bytes(c_type: str, where: str) -> int | None:
    """The width of a by-value scalar, or None when the type is no scalar."""
    if is_pointer(c_type):
        return None
    t = resolve(c_type, where)
    if t in C_TYPES and t != "void":
        return C_TYPES[t][1]
    return None


def scalar_cs(c_type: str, where: str) -> str | None:
    """The C# type of a by-value scalar, or None when the type is no scalar."""
    if is_pointer(c_type):
        return None
    t = resolve(c_type, where)
    return C_TYPES[t][0] if t in C_TYPES and t != "void" else None


# The names of the catalog's own enums, filled in by ``configure``.  A C enum is
# an int at the ABI, and taking the set from the catalog is what keeps a newly
# added enum from arriving as an opaque pointer the way a hand-list leaves it.
ENUM_TYPES: set[str] = set()

# The catalog's text I/O per C type, filled in by ``configure``: which function
# reads a value and which writes it, and what the arguments beside the value
# itself default to.
TYPE_ENCODINGS: dict[str, dict] = {}


# The catalog's structs by name, filled in by ``configure``.  An array of struct
# values is walked at the struct's own stride, which the field layout the catalog
# records is what gives.
STRUCTS: dict[str, dict] = {}

# Every struct the catalog names, a layout stated or not.
STRUCT_NAMES: set[str] = set()


def projected(f: dict) -> bool:
    """Whether a catalog function is part of the surface this binding projects.

    The catalog marks the declarations that reach MEOS from a project it
    vendors — pgPointCloud's `pc_api.h` and `hashtable.h`, PostgreSQL's
    `pg_numeric.h` — and those are that project's API rather than MEOS's, so
    they stay out. Where MEOS documents one as its own public API (`api` is
    `public`: `numeric_in` and `numeric_out`, which libmeos exports), it is
    MEOS's surface like any other. The flat surface and the object layer read
    this one predicate, so the layer never builds on a wrapper the flat
    surface does not write."""
    return not f.get("vendored") or f.get("api") == "public"


def configure(idl: dict) -> None:
    """Take from the catalog the type facts the mapping below reads."""
    if "typedefs" not in idl:
        raise SystemExit(
            "codegen: the catalog carries no `typedefs`, so the names `canonical` "
            "keeps (TimestampTz, Datum, Oid, text, ...) resolve to no width; "
            "regenerate it with a MEOS-API that states them")
    TYPEDEFS.clear()
    TYPEDEFS.update({t["name"]: t["canonical"] for t in idl["typedefs"]})
    CALLBACKS.clear()
    CALLBACKS.update(c["name"] for c in idl.get("callbacks", []) if c.get("name"))
    ENUM_TYPES.clear()
    ENUM_TYPES.update(e["name"] for e in idl.get("enums", []) if e.get("name"))
    STRUCTS.clear()
    STRUCTS.update({s["name"]: s for s in idl.get("structs", []) if s.get("fields")})
    STRUCT_NAMES.clear()
    STRUCT_NAMES.update(s["name"] for s in idl.get("structs", []) if s.get("name"))
    TYPE_ENCODINGS.clear()
    TYPE_ENCODINGS.update(idl.get("typeEncodings", {}))
    BY_VALUE_STRUCTS.clear()
    classed = {c["cType"] for c in
               idl.get("objectModel", {}).get("classes", {}).values()
               if c.get("cType")}
    for f in idl.get("functions", []):
        if not projected(f):
            continue
        for spot in [f["returnType"]] + list(f.get("params", [])):
            canonical = _bare(spot["canonical"])
            if "*" not in canonical and canonical in STRUCTS:
                BY_VALUE_STRUCTS.add(canonical)
                continue
            # A struct MEOS hands over through a pointer is a VALUE too when
            # its fields are all scalars and no class stands for it: nothing
            # about it is opaque, so the binding carries the value rather than
            # the address. A struct a class stands for is that class's, and
            # giving it a second C# form would be two spellings of one type.
            if (canonical.endswith("*") and canonical.count("*") == 1
                    and canonical[:-1].strip() in STRUCTS):
                base = canonical[:-1].strip()
                if base in classed:
                    continue
                fields = STRUCTS[base]["fields"]
                if all(scalar_bytes(fl["canonical"], f"{base}.{fl['name']}")
                       for fl in fields):
                    BY_VALUE_STRUCTS.add(base)


# The catalog structs the binding gives a C# VALUE type, filled in by
# ``configure``: the ones a function hands over by value, and the ones it hands
# over through a pointer while stating their whole layout in scalars and giving
# them no class.  Every other MEOS struct crosses the boundary as a pointer and
# stays opaque.
BY_VALUE_STRUCTS: set[str] = set()


def csharp_field_type(c_type: str, where: str) -> str:
    """The C# type of a by-value struct's field."""
    if is_pointer(c_type):
        return "IntPtr"
    t = resolve(c_type, where)
    if t in ENUM_TYPES:
        return "int"
    if t in CALLBACKS:
        return "IntPtr"
    if t not in C_TYPES:
        raise UnmappedType(c_type, where)
    return C_TYPES[t][0]


def gen_structs() -> str:
    """The C# form of each struct the binding carries as a value.

    A struct return is not a pointer: the ABI passes it in registers or through a
    hidden pointer the caller supplies, so declaring it as an IntPtr reads an
    address where there is none.  A struct MEOS reads through a pointer is a
    value too when its layout is all scalars, and it is written and read as the
    text MEOS publishes for it wherever the catalog names that pair."""
    lines = [
        "#nullable enable",
        "",
        "using System.CodeDom.Compiler;",
        "using System.Runtime.InteropServices;",
        "",
        f"using {NAMESPACE};",
        "",
        f"namespace {STRUCT_NAMESPACE}",
        "{",
    ]
    for name in sorted(BY_VALUE_STRUCTS):
        struct = STRUCTS[name]
        lines += [
            f"    /// <summary>The MEOS <c>{name}</c> struct, as MEOS returns it.</summary>",
            f'    [GeneratedCode("MEOS.NET.Codegen", "{GENERATOR_VERSION}")]',
            "    [StructLayout(LayoutKind.Sequential)]",
            f"    public struct {name}",
            "    {",
        ]
        for field in struct["fields"]:
            cs = csharp_field_type(field["canonical"], f"{name}.{field['name']}")
            # A field is marshalled at C#'s own default width, which for `bool`
            # is the 4-byte Windows BOOL; MEOS's `bool` is one byte.
            if cs == "bool":
                lines.append("        [MarshalAs(UnmanagedType.U1)]")
            lines.append(f"        public {cs} {csharp_param_name(field['name'])};")
        lines += _struct_text_io(name, struct)
        lines += ["    }", ""]
    lines += ["}", ""]
    return "\n".join(lines)


def _io_args(params: list, primary: str, aux: list | None) -> str | None:
    """The call arguments of a text reader or writer, or None when one is
    unanswerable.

    The first argument is the value itself — the text to read, or the address of
    the value to write — and the catalog names the rest with the default each
    takes, which is where a `maxdd` gets its digits."""
    defaults = {a["name"]: a.get("default") for a in (aux or [])}
    args = [primary]
    for _cs_type, pname in params[1:]:
        if pname == "typmod":
            args.append("-1")
            continue
        if pname in defaults and defaults[pname] is not None:
            args.append(str(defaults[pname]))
            continue
        return None
    return ", ".join(args)


def _struct_text_io(name: str, struct: dict) -> list[str]:
    """`In` and `ToString` for a value struct MEOS publishes text I/O for.

    The catalog names the pair, so the value is read and written through MEOS's
    own parser and printer rather than a format the binding would have to keep
    in step with. The reader hands back a pointer MEOS owns, which is read as a
    value the same way every other struct return is."""
    io = struct.get("serialization") or {}
    reader, writer = io.get("in"), io.get("out")
    if not reader or not writer:
        _gap("value text I/O", name,
             f"serialization names in={reader!r} out={writer!r}")
        return []
    read_fn, write_fn = SIGNATURES.get(reader), SIGNATURES.get(writer)
    if not read_fn or not write_fn:
        _gap("value text I/O", name,
             f"{reader if not read_fn else writer} reaches no emitted wrapper")
        return []
    encoding = TYPE_ENCODINGS.get(name, {})
    read_args = _io_args(read_fn[1], "str", encoding.get("in_aux"))
    write_args = _io_args(write_fn[1], "ptr", encoding.get("out_aux"))
    if read_args is None or write_args is None:
        _gap("value text I/O", name,
             f"typeEncodings gives no default for an argument of "
             f"{reader if read_args is None else writer}")
        return []
    return [
        "",
        f"        /// <summary>The <c>{name}</c> MEOS reads from this text.</summary>",
        f"        public static {name}? In(string str)",
        f"        {{",
        f"            IntPtr ptr = {CLASS}.{public_name(reader)}({read_args});",
        f"            return ptr == IntPtr.Zero"
        f" ? null : Marshal.PtrToStructure<{name}>(ptr);",
        f"        }}",
        "",
        "        /// <summary>The text MEOS writes this value as.</summary>",
        "        public override string ToString()",
        f"        {{",
        f"            IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf<{name}>());",
        "            try",
        f"            {{",
        "                Marshal.StructureToPtr(this, ptr, false);",
        f"                return {CLASS}.{public_name(writer)}({write_args});",
        f"            }}",
        "            finally",
        f"            {{",
        "                Marshal.FreeHGlobal(ptr);",
        f"            }}",
        f"        }}",
    ]


def _type_layout(c_type: str) -> tuple[int, int]:
    """``(size, alignment)`` in bytes of a struct field's type: a scalar, a
    pointer, a fixed-size array, or a nested catalog struct."""
    t = _bare(c_type)
    if "[" in t:
        base, count = t[:t.index("[")].strip(), int(t[t.index("[") + 1:t.index("]")])
        size, align = _type_layout(base)
        return (size * count, align)
    if "*" in t:
        return (8, 8)
    t = resolve(t, f"field type {c_type}")
    if t in STRUCTS:
        return struct_layout(t)
    if t in ENUM_TYPES:
        return (4, 4)
    if t in CALLBACKS:
        return (8, 8)
    if t not in C_TYPES or t == "void":
        raise UnmappedType(c_type, "struct layout")
    return (C_TYPES[t][1], C_TYPES[t][1])


def struct_layout(name: str) -> tuple[int, int]:
    """``(size, alignment)`` of a catalog struct: each field sits at the offset the
    catalog records, and the whole is padded to a multiple of its widest field."""
    size = align = 1
    for field in STRUCTS[name]["fields"]:
        fsize, falign = _type_layout(field["canonical"])
        align = max(align, falign)
        size = max(size, field["offset_bits"] // 8 + fsize)
    return ((size + align - 1) // align * align, align)


# C pointer-to-char marshalled as managed string when StringMarshalling.Utf8 is on.
def is_string_pointer(canonical: str) -> bool:
    return _bare(canonical) == "char *"


def is_borrowed_string(canonical: str) -> bool:
    """A ``const char *`` return the caller does not own.

    The Utf8 string marshaller frees what it is handed back, which is right for
    the ``char *`` MEOS mallocs for the caller and fatal for the ``const char *``
    it returns out of a static table — ``interptype_name`` hands back an element
    of ``MEOS_INTERPTYPE_NAMES``.  A borrowed return comes back as the pointer
    itself and is read without a free."""
    return " ".join(canonical.split()).startswith("const char *")


def string_size_out(f: dict) -> str | None:
    """The ``size_t *`` a ``char *`` return's shape lists in ``outParams``, or None.

    It states the size of the string the call answers, its terminator included, so
    the import returns the pointer and takes the size as an ``out nuint``, and the
    wrapper reads the string for that size (#_emit_sized_string), as
    #_emit_array_return_wrapper hides an ``int *count``."""
    if " ".join(f["returnType"]["c"].split()) != "char *":
        return None
    out_params = (f.get("shape") or {}).get("outParams") or []
    return next((p["name"] for p in f.get("params", [])
                 if p["name"] in out_params and p["cType"].replace(" ", "") == "size_t*"), None)


def csharp_type_for(canonical: str, where: str) -> str:
    """The C# type a slot crosses the LibraryImport boundary as, read from its
    `canonical`; ``where`` names the slot in the message of a type that maps to
    nothing, which stops the run."""
    # An address of any depth, a function pointer among them, is an IntPtr: the
    # binding does not carry pointee types into C#.
    if is_pointer(canonical):
        return "IntPtr"
    t = resolve(canonical, where)
    if t in C_TYPES:
        return C_TYPES[t][0]
    if t in ENUM_TYPES:
        return "int"
    if t in CALLBACKS:
        return "IntPtr"
    if t in BY_VALUE_STRUCTS:
        return t
    raise UnmappedType(canonical, f"{where} (a struct passed by value with no "
                                  f"layout the catalog states)")


def csharp_param_type(p: dict, fname: str) -> str:
    """The C# type of one parameter, a `char *` read as a managed string."""
    if is_string_pointer(p["canonical"]):
        return "string"
    return csharp_type_for(p["canonical"], f"{fname} parameter {p['name']}")


def csharp_return_type(f: dict) -> str:
    """The C# type of a function's return, a `char *` read as a managed string."""
    canonical = f["returnType"]["canonical"]
    if is_borrowed_string(canonical):
        return "IntPtr"
    if is_string_pointer(canonical):
        return "string"
    return csharp_type_for(canonical, f"{f['name']} return")


def public_name(c_name: str) -> str:
    """The C# name of a MEOS function: `tfloat_in` reads `TfloatIn`.

    Each underscore-separated part is capitalized and the underscores dropped,
    which is the spelling GoMEOS exports (`MeosInitialize`, `TfloatIn`) — one
    ecosystem-wide rule rather than a per-binding invention."""
    return "".join(part[:1].upper() + part[1:] for part in c_name.split("_") if part)


def csharp_param_name(name: str) -> str:
    """Avoid C# reserved keywords as parameter names."""
    reserved = {
        "string", "object", "params", "ref", "out", "in", "this", "base",
        "new", "is", "as", "class", "struct", "enum", "interface", "namespace",
        "event", "delegate", "lock", "fixed", "stackalloc", "unsafe",
        "operator", "implicit", "explicit", "checked", "unchecked",
        "default", "typeof", "sizeof", "true", "false", "null",
        "abstract", "sealed", "override", "virtual", "readonly", "static",
        "extern", "volatile", "public", "private", "protected", "internal",
        "for", "foreach", "while", "do", "if", "else", "switch", "case",
        "break", "continue", "return", "throw", "try", "catch", "finally",
        "goto", "yield", "using", "void",
        "bool", "byte", "sbyte", "char", "short", "ushort", "int", "uint",
        "long", "ulong", "float", "double", "decimal", "nint", "nuint",
        "const",
    }
    return f"@{name}" if name in reserved else name


def gen_external_functions(funcs: list[dict]) -> str:
    lines: list[str] = []
    lines.append("#nullable enable")
    lines.append("")
    lines.append("using System.CodeDom.Compiler;")
    lines.append("using System.Runtime.InteropServices;")
    lines.append("")
    lines.append(f"using {STRUCT_NAMESPACE};")
    lines.append("")
    lines.append(f"namespace {NAMESPACE}")
    lines.append("{")
    lines.append(f"    public static partial class {CLASS}")
    lines.append("    {")
    lines.append(f'        [GeneratedCode("MEOS.NET.Codegen", "{GENERATOR_VERSION}")]')
    lines.append("        private static partial class Native")
    lines.append("        {")
    lines.append(f'            private const string DllPath = "{DLL_PATH}";')
    lines.append("")

    for f in funcs:
        name = f["name"]
        rt = csharp_return_type(f)
        size_out = string_size_out(f)
        if size_out:
            rt = "IntPtr"
        params: list[str] = []
        for p in f.get("params", []):
            pname = csharp_param_name(p["name"]) if p["name"] else "arg"
            if p["name"] == size_out:
                params.append(f"out nuint {pname}")
                continue
            ptype = csharp_param_type(p, f["name"])
            # The LibraryImport source generator marshals C# bool as the
            # 4-byte Windows BOOL by default; MEOS uses C ``_Bool`` (1
            # byte).  Tag both param and return for U1 marshalling so the
            # ABI matches regardless of platform.
            if ptype == "bool":
                params.append(f"[MarshalAs(UnmanagedType.U1)] {ptype} {pname}")
            else:
                params.append(f"{ptype} {pname}")
        param_list = ", ".join(params)
        lines.append(f'            [LibraryImport(DllPath, EntryPoint = "{name}", '
                     "StringMarshalling = StringMarshalling.Utf8)]")
        if rt == "bool":
            lines.append("            [return: MarshalAs(UnmanagedType.U1)]")
        lines.append(f"            internal static partial {rt} {public_name(name)}({param_list});")
        lines.append("")

    lines.append("        }")
    lines.append("    }")
    lines.append("}")
    return "\n".join(lines) + "\n"


# The public signature each exposed wrapper is emitted with, keyed by function
# name: ``(csharp_return_type, [(csharp_param_type, param_name), ...])``.  A
# wrapper's signature is decided by the shape folding below rather than by the
# raw C parameter list, so a second generator over the same catalog reads the
# signature from here instead of re-deriving the folding rules and drifting.
SIGNATURES: dict[str, tuple[str, list[tuple[str, str]]]] = {}


# Element types we know how to Marshal.Copy from a C array pointer back into
# a managed C# array.  IntPtr is the fallback for wrapped opaque pointers.
_MARSHAL_ELEM: dict[str, str] = {
    "long":   "long",
    "int":    "int",
    "double": "double",
    "byte":   "byte",
    "short":  "short",
}

# How to read one element of a scalar array `Marshal.Copy` has no overload for.
# `{0}` is the array's base pointer and `{1}` the byte offset of the element.
# Reading such an array as an array of POINTERS walks it at eight bytes a step,
# which runs off the end of a `bool` array and answers addresses that are the
# values' own bytes.
_SCALAR_ELEM_READER: dict[str, tuple[int, str]] = {
    "bool":   (1, "Marshal.ReadByte({0}, {1}) != 0"),
    "sbyte":  (1, "(sbyte) Marshal.ReadByte({0}, {1})"),
    "ushort": (2, "(ushort) Marshal.ReadInt16({0}, {1})"),
    "uint":   (4, "(uint) Marshal.ReadInt32({0}, {1})"),
    "ulong":  (8, "(ulong) Marshal.ReadInt64({0}, {1})"),
    "float":  (4, "BitConverter.Int32BitsToSingle(Marshal.ReadInt32({0}, {1}))"),
}


def _strip_const_stars(c_type: str) -> tuple[str, int]:
    s = _bare(c_type)
    stars = s.count("*")
    return s.replace("*", "").strip(), stars


def _names_a_value(name: str) -> bool:
    """Whether the catalog states this name as a type it can map by value."""
    return (name in C_TYPES or name in TYPEDEFS or name in ENUM_TYPES
            or name in STRUCT_NAMES or name in CALLBACKS)


def _csharp_array_element(canonical: str, where: str) -> tuple[str, str]:
    """Return ``(elem_csharp_type, marshal_strategy)`` for one C-array element.

    ``marshal_strategy`` is ``"Marshal.Copy"`` for primitives we can copy
    straight back, ``"IntPtrArray"`` for arrays of opaque pointers that we
    surface as ``IntPtr[]`` for the high-level surface to wrap, or
    ``"ByteBuffer"`` for ``uint8_t *`` WKB-style returns.

    The function is called both for a function's array return type (where
    ``T *`` -> array of T, ``T **`` -> array of T-pointers) and for an
    outputArrays parameter (where the C signature carries an extra ``*``
    for the out-parameter handle, so ``T **`` actually represents an array
    of primitive T's that MEOS writes via the handle).  Distinguishing the
    two cases without extra context is awkward; we prefer the primitive
    interpretation when the base type is a known scalar, falling back to
    IntPtrArray only when the base is itself a wrapped opaque type."""
    base, stars = _strip_const_stars(canonical)
    if not _names_a_value(base):
        # A pointer to a type the catalog leaves opaque — `struct json_object
        # **` — is an array of addresses; one array of such VALUES has no stride.
        if stars >= 2:
            return ("IntPtr", "IntPtrArray")
        raise UnmappedType(canonical, f"{where} (array element)")
    elem = scalar_cs(base, f"{where} (array element)")
    if elem in _MARSHAL_ELEM:
        return (elem, "Marshal.Copy")
    if base == "uint8_t":
        return ("byte", "ByteBuffer")
    if elem in _SCALAR_ELEM_READER:
        return (elem, f"ScalarArray:{elem}")
    base = resolve(base, f"{where} (array element)")
    if stars == 1 and base in STRUCTS:
        # A single pointer to a catalog struct is an array of struct VALUES, not
        # of pointers: element i sits at the struct's own stride, and reading it
        # as a pointer reads the first eight bytes of the value itself.
        return ("IntPtr", f"StructArray:{struct_layout(base)[0]}")
    return ("IntPtr", "IntPtrArray")


def _emit_outputs_wrapper(f: dict) -> list[str]:
    """Emit a wrapper for shape.outputArrays: parallel out-parameters
    surfaced as additional tuple-return entries.  Currently handles the
    case where shape.arrayReturn is ALSO present (split family) and the
    case where the function returns void/bool with output-only arrays."""
    name = f["name"]
    shape = f["shape"]
    output_params = shape["outputArrays"]  # list of { "param": ..., optional lengthFrom }
    array_ret = shape.get("arrayReturn")

    # Find the count source -- usually the OUTPUT_COUNT param named "count".
    # We synthesise an int *count buffer either way and rely on the external
    # signature (IntPtr) accepting it.
    if array_ret and array_ret["lengthFrom"]["kind"] == "param":
        count_param = array_ret["lengthFrom"]["name"]
    elif output_params and "lengthFrom" in output_params[0]:
        count_param = output_params[0]["lengthFrom"]["name"]
    else:
        _gap("output array length", name,
             "outputArrays names no lengthFrom and there is no arrayReturn to "
             "take one from",
             "the raw pointers, for the caller to size and read")
        return []

    # Build the wrapper-side parameter list, dropping output params and the
    # count from the user-facing signature.
    output_names = {oa["param"] for oa in output_params}
    sig_params: list[str] = []
    sig_types: list[tuple[str, str]] = []
    ext_call_args: list[str] = []
    setup: list[str] = []
    teardown: list[str] = []
    # (output_param_local, oa_dict, elem_csharp_type, marshal_strategy)
    output_locals: list[tuple[str, dict, str, str]] = []

    for p in f.get("params", []):
        pname = csharp_param_name(p["name"]) if p["name"] else "arg"
        ptype = csharp_param_type(p, f["name"])
        if p["name"] == count_param:
            local = f"_count_{pname}"
            setup.append(f"            IntPtr {local} = Marshal.AllocHGlobal(sizeof(int));")
            teardown.append(f"            Marshal.FreeHGlobal({local});")
            ext_call_args.append(local)
            continue
        if p["name"] in output_names:
            local = f"_out_{pname}"
            setup.append(f"            IntPtr {local} = Marshal.AllocHGlobal(IntPtr.Size);")
            teardown.append(f"            Marshal.FreeHGlobal({local});")
            ext_call_args.append(local)
            oa = next(oa for oa in output_params if oa["param"] == p["name"])
            elem, strategy = _csharp_array_element(p["canonical"], f"{name} parameter {p['name']}")
            output_locals.append((local, oa, elem, strategy))
            continue
        sig_params.append(f"{ptype} {pname}")
        sig_types.append((ptype, pname))
        ext_call_args.append(pname)

    # Compose the return tuple type.
    ret_pieces: list[str] = []
    if array_ret:
        ret_elem, _ = _csharp_array_element(f["returnType"]["canonical"], f"{name} return")
        ret_pieces.append(f"{ret_elem}[]")
    for _, _oa, elem, _strategy in output_locals:
        ret_pieces.append(f"{elem}[]")
    if not ret_pieces:
        _gap("output array length", name,
             "outputArrays names no parameter this run could type",
             "the raw pointers, for the caller to size and read")
        return []
    if len(ret_pieces) == 1:
        ret_type = ret_pieces[0]
    else:
        ret_type = "(" + ", ".join(ret_pieces) + ")"
    # A `bool` beside the out-arrays is MEOS saying whether it answered any:
    # `tpoint_as_mvtgeom` answers false for a trip with no representation in
    # the tile and writes nothing, so the wrapper answers null there rather
    # than reading a count MEOS never wrote.
    answers_found = not array_ret and csharp_return_type(f) == "bool"
    if answers_found:
        ret_type += "?"

    user_params = ", ".join(sig_params)
    ext_args = ", ".join(ext_call_args)
    SIGNATURES[name] = (ret_type, sig_types)

    lines: list[str] = []
    lines.append(f"        public static {ret_type} {public_name(name)}({user_params})")
    lines.append("        {")
    lines.extend(setup)
    lines.append("            try")
    lines.append("            {")
    if array_ret:
        lines.append(f"                IntPtr _resultPtr = SafeExecution<IntPtr>(() => Native.{public_name(name)}({ext_args}));")
    else:
        # Void or bool return with only outputs.
        rt = csharp_return_type(f)
        if rt == "void":
            lines.append(f"                SafeExecution(() => Native.{public_name(name)}({ext_args}));")
        elif answers_found:
            lines.append(f"                if (!SafeExecution<bool>(() => Native.{public_name(name)}({ext_args})))")
            lines.append("                {")
            lines.append("                    return null;")
            lines.append("                }")
            lines.append("")
        else:
            lines.append(f"                SafeExecution<{rt}>(() => Native.{public_name(name)}({ext_args}));")
    lines.append(f"                int _n = Marshal.ReadInt32(_count_{count_param});")
    if array_ret:
        ret_elem, ret_strategy = _csharp_array_element(f["returnType"]["canonical"], f"{name} return")
        lines.append(f"                {ret_elem}[] _resultArr = new {ret_elem}[_n];")
        if ret_strategy == "Marshal.Copy":
            lines.append("                Marshal.Copy(_resultPtr, _resultArr, 0, _n);")
        elif ret_strategy.startswith("StructArray:"):
            stride = ret_strategy.split(":", 1)[1]
            lines.append("                for (int _i = 0; _i < _n; _i++)")
            lines.append(f"                {{ _resultArr[_i] = IntPtr.Add(_resultPtr, _i * {stride}); }}")
        elif ret_strategy.startswith("ScalarArray:"):
            size, reader = _SCALAR_ELEM_READER[ret_strategy.split(":", 1)[1]]
            offset = "_i" if size == 1 else f"_i * {size}"
            lines.append("                for (int _i = 0; _i < _n; _i++)")
            lines.append(f"                {{ _resultArr[_i] = "
                         f"{reader.format('_resultPtr', offset)}; }}")
        else:
            lines.append("                for (int _i = 0; _i < _n; _i++)")
            lines.append("                { _resultArr[_i] = Marshal.ReadIntPtr(_resultPtr, _i * IntPtr.Size); }")
    for local, oa, elem, strategy in output_locals:
        lines.append(f"                IntPtr _{local}_arr = Marshal.ReadIntPtr({local});")
        lines.append(f"                {elem}[] _{local}_out = new {elem}[_n];")
        if strategy.startswith("StructArray:"):
            stride = strategy.split(":", 1)[1]
            lines.append(f"                for (int _i = 0; _i < _n; _i++)")
            lines.append(f"                {{ _{local}_out[_i] = IntPtr.Add(_{local}_arr, _i * {stride}); }}")
        elif strategy.startswith("ScalarArray:"):
            size, reader = _SCALAR_ELEM_READER[strategy.split(":", 1)[1]]
            offset = "_i" if size == 1 else f"_i * {size}"
            lines.append(f"                for (int _i = 0; _i < _n; _i++)")
            lines.append(f"                {{ _{local}_out[_i] = "
                         f"{reader.format(f'_{local}_arr', offset)}; }}")
        elif elem == "IntPtr":
            lines.append(f"                for (int _i = 0; _i < _n; _i++)")
            lines.append(f"                {{ _{local}_out[_i] = Marshal.ReadIntPtr(_{local}_arr, _i * IntPtr.Size); }}")
        else:
            lines.append(f"                Marshal.Copy(_{local}_arr, _{local}_out, 0, _n);")

    # Build return expression.
    return_pieces: list[str] = []
    if array_ret:
        return_pieces.append("_resultArr")
    for local, _, _, _ in output_locals:
        return_pieces.append(f"_{local}_out")
    if len(return_pieces) == 1:
        lines.append(f"                return {return_pieces[0]};")
    else:
        lines.append(f"                return ({', '.join(return_pieces)});")
    lines.append("            }")
    lines.append("            finally")
    lines.append("            {")
    lines.extend(teardown)
    lines.append("            }")
    lines.append("        }")
    return lines


def _emit_array_return_wrapper(f: dict, ext_params: str, ext_args: str) -> list[str]:
    """Emit a wrapper that materialises an array return via Marshal.Copy.

    The slice length comes from either a sibling accessor call (kind=accessor)
    or a by-pointer ``int *count`` output of the same function (kind=param). In
    the param case the count is allocated internally and hidden from the public
    signature, mirroring the MEOS ``TYPE *f(..., int *count)`` convention."""
    name = f["name"]
    shape = f["shape"]
    length_meta = shape["arrayReturn"]["lengthFrom"]
    elem, strategy = _csharp_array_element(f["returnType"]["canonical"], f"{name} return")
    ret_type = f"{elem}[]"

    def _copy(indent: str) -> list[str]:
        out = [f"{indent}{elem}[] _out = new {elem}[_n];"]
        if strategy == "Marshal.Copy":
            out.append(f"{indent}Marshal.Copy(_p, _out, 0, _n);")
        elif strategy.startswith("StructArray:"):
            stride = strategy.split(":", 1)[1]
            out.append(f"{indent}for (int _i = 0; _i < _n; _i++)")
            out.append(f"{indent}{{ _out[_i] = IntPtr.Add(_p, _i * {stride}); }}")
        elif strategy.startswith("ScalarArray:"):
            size, reader = _SCALAR_ELEM_READER[strategy.split(":", 1)[1]]
            offset = "_i" if size == 1 else f"_i * {size}"
            out.append(f"{indent}for (int _i = 0; _i < _n; _i++)")
            out.append(f"{indent}{{ _out[_i] = {reader.format('_p', offset)}; }}")
        else:
            out.append(f"{indent}for (int _i = 0; _i < _n; _i++)")
            out.append(f"{indent}{{ _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }}")
        out.append(f"{indent}return _out;")
        return out

    if length_meta["kind"] == "accessor":
        SIGNATURES[name] = (ret_type, _typed_params(f))
        accessor = length_meta["func"]
        arg = csharp_param_name(length_meta["arg"])
        lines = [
            f"        public static {ret_type} {public_name(name)}({ext_params})",
            "        {",
            f"            int _n = (int)Meos.{public_name(accessor)}({arg});",
            f"            IntPtr _p = SafeExecution<IntPtr>(() => Native.{public_name(name)}({ext_args}));",
        ]
        lines += _copy("            ")
        lines.append("        }")
        return lines

    count_name = csharp_param_name(length_meta["name"])
    count_param = next(p for p in f["params"] if csharp_param_name(p["name"]) == count_name)
    if not is_pointer(count_param["canonical"]):
        # kind == "param" with a by-value ``int count``: the returned array has
        # the length the caller passes (``STBox *stboxarr_round(const STBox
        # *boxarr, int count, int maxdd)``), so the parameter stays in the public
        # signature, as GoMEOS keeps it, and is the length the copy reads.
        SIGNATURES[name] = (ret_type, _typed_params(f))
        lines = [
            f"        public static {ret_type} {public_name(name)}({ext_params})",
            "        {",
            f"            IntPtr _p = SafeExecution<IntPtr>(() => Native.{public_name(name)}({ext_args}));",
            f"            int _n = {count_name};",
        ]
        lines += _copy("            ")
        lines.append("        }")
        return lines

    # kind == "param": the length is written back through the function's own
    # ``int *count`` output.  Allocate it, hide it from the public signature,
    # and read the count back after the call.
    pub = ", ".join(
        f"{csharp_param_type(p, f['name'])} {csharp_param_name(p['name'])}"
        for p in f["params"] if csharp_param_name(p["name"]) != count_name)
    call_args = ", ".join(
        "_cnt" if csharp_param_name(p["name"]) == count_name else csharp_param_name(p["name"])
        for p in f["params"])
    SIGNATURES[name] = (ret_type, [t for t in _typed_params(f) if t[1] != count_name])
    lines = [
        f"        public static {ret_type} {public_name(name)}({pub})",
        "        {",
        "            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));",
        "            try",
        "            {",
        f"                IntPtr _p = SafeExecution<IntPtr>(() => Native.{public_name(name)}({call_args}));",
        "                int _n = Marshal.ReadInt32(_cnt);",
    ]
    lines += _copy("                ")
    lines += [
        "            }",
        "            finally { Marshal.FreeHGlobal(_cnt); }",
        "        }",
    ]
    return lines


def _emit_sized_string(f: dict, size_out: str) -> list[str]:
    """A ``char *`` return read for the size MEOS writes (#string_size_out) and freed.

    A null pointer, for which MEOS wrote no size, answers null, as the Utf8 string
    marshaller of #csharp_return_type answers it."""
    name = f["name"]
    size_name = csharp_param_name(size_out)
    typed = _typed_params(f)
    public = [t for t in typed if t[1] != size_name]
    SIGNATURES[name] = ("string", public)
    pub = ", ".join(f"{t} {n}" for t, n in public)
    args = ", ".join("out _size" if n == size_name else n for _t, n in typed)
    return [
        f"        public static string {public_name(name)}({pub})",
        "        {",
        "            nuint _size = 0;",
        f"            IntPtr _p = SafeExecution<IntPtr>(() => Native.{public_name(name)}({args}));",
        "            if (_p == IntPtr.Zero)",
        "            {",
        "                return null!;",
        "            }",
        "",
        "            try",
        "            {",
        "                return Marshal.PtrToStringUTF8(_p, (int)_size - 1);",
        "            }",
        "            finally",
        "            {",
        "                Marshal.FreeCoTaskMem(_p);",
        "            }",
        "        }",
    ]


def _emit_simple_passthrough(f: dict, ext_params: str, ext_args: str, default_rt: str | None = None) -> list[str]:
    name = f["name"]
    rt = default_rt or csharp_return_type(f)
    if default_rt is None and is_borrowed_string(f["returnType"]["canonical"]):
        SIGNATURES[name] = ("string?", _typed_params(f))
        return [
            f"        public static string? {public_name(name)}({ext_params})",
            f"            => Marshal.PtrToStringUTF8("
            f"SafeExecution<IntPtr>(() => Native.{public_name(name)}({ext_args})));",
        ]
    SIGNATURES[name] = (rt, _typed_params(f))
    if rt == "void":
        return [
            f"        public static void {public_name(name)}({ext_params})",
            f"            => SafeExecution(() => Native.{public_name(name)}({ext_args}));",
        ]
    return [
        f"        public static {rt} {public_name(name)}({ext_params})",
        f"            => SafeExecution<{rt}>(() => Native.{public_name(name)}({ext_args}));",
    ]


def _unstated_element(f: dict) -> str | None:
    """Why the array this function answers cannot be read, or None.

    ``void *`` names no element: it gives neither a type to read one as nor a
    width to step by, and the catalog carries no other statement of either."""
    if "arrayReturn" not in (f.get("shape") or {}):
        return None
    base, _stars = _strip_const_stars(f["returnType"]["canonical"])
    if base != "void":
        return None
    return (f"the catalog states this answers an array and states no element "
            f"type for it — `{f['returnType']['c']}` names neither the type to "
            f"read an element as nor the width to step by")


def gen_exposed_functions(funcs: list[dict], header: str | None = None) -> str:
    """Generate the public wrappers, for one MEOS header or for all of them.

    Each wrapper either delegates straight through SafeExecution or, when
    meos-idl.json carries a ``shape`` annotation for the function, lifts
    the C signature into a more idiomatic C# return.  arrayReturn with a
    sibling-accessor length emits a Marshal.Copy unpack; other shapes
    fall back to the IntPtr passthrough today."""
    lines: list[str] = []
    # A `.g.cs` file sits outside the project's nullable context, so it declares
    # its own; the wrappers over a borrowed string return `string?`.
    lines.append("#nullable enable")
    lines.append("")
    lines.append("using System.Runtime.InteropServices;")
    lines.append("")
    lines.append(f"using {STRUCT_NAMESPACE};")
    lines.append("")
    lines.append(f"namespace {NAMESPACE}")
    lines.append("{")
    if header:
        lines.append(f"    /// <summary>The MEOS functions <c>{header}</c> declares.</summary>")
    # The attribute names the whole partial type, so it sits on the one part that
    # holds the native declarations; a second part carrying it is a duplicate.
    lines.append(f"    public static partial class {CLASS}")
    lines.append("    {")

    for f in funcs:
        ext_params, ext_args = _format_params(f)
        shape = f.get("shape", {})

        unstated = _unstated_element(f)
        if unstated:
            # No wrapper, and no signature for the object layer to build on: a
            # wrapper here would walk the array at a stride the catalog never
            # states, which answers the values' own bytes as addresses.
            _gap("array element type", f["name"], f["returnType"]["c"], unstated)
            lines.extend(gapledger.stub_comment(f["name"], unstated))
            lines.append("")
            continue

        emitted: list[str] = []
        size_out = string_size_out(f)
        if size_out:
            emitted = _emit_sized_string(f, size_out)
        if not emitted and "outputArrays" in shape:
            emitted = _emit_outputs_wrapper(f)
        if not emitted and "arrayReturn" in shape:
            kind = shape["arrayReturn"]["lengthFrom"]["kind"]
            if kind in ("accessor", "param"):
                emitted = _emit_array_return_wrapper(f, ext_params, ext_args)
            else:
                _gap("array return length", f["name"], kind,
                     "the pointer itself, with no length to read it by")
        if not emitted:
            emitted = _emit_simple_passthrough(f, ext_params, ext_args)
        lines.extend(emitted)
        lines.append("")

    lines.append("    }")
    lines.append("}")
    return "\n".join(lines) + "\n"


def by_header(funcs: list[dict]) -> dict[str, list[dict]]:
    """The functions grouped by the header the catalog says declares them, which
    is how the surface is split into files — the grouping MEOS itself publishes,
    not one this generator invents."""
    grouped: dict[str, list[dict]] = {}
    for f in funcs:
        grouped.setdefault(f.get("file") or "meos.h", []).append(f)
    return grouped


def _typed_params(f: dict) -> list[tuple[str, str]]:
    """The wrapper's parameter list as ``(csharp_type, name)`` pairs, in order."""
    return [(csharp_param_type(p, f["name"]),
             csharp_param_name(p["name"]) if p["name"] else "arg")
            for p in f.get("params", [])]


def _format_params(f: dict) -> tuple[str, str]:
    params: list[str] = []
    arg_names: list[str] = []
    for p in f.get("params", []):
        pname = csharp_param_name(p["name"]) if p["name"] else "arg"
        ptype = csharp_param_type(p, f["name"])
        params.append(f"{ptype} {pname}")
        arg_names.append(pname)
    return ", ".join(params), ", ".join(arg_names)


def _declare_kinds(ledger: gapledger.Ledger) -> None:
    """Every class of gap this generator can reach, declared before it runs.

    A class prints whether or not it fires, so an empty one reads as a site that
    was watched rather than one nobody looked at."""
    ledger.kind(
        "parameter nullability",
        "`shape.nullable` names the parameters a function accepts NULL for, and "
        "the catalog carries no field saying a parameter is required. A pointer "
        "parameter named in neither reaches the surface with its contract "
        "unstated: the wrapper takes it, and nothing says whether zero is an "
        "argument or a fault.",
        ("function", "parameters whose nullability is unstated"))
    ledger.kind(
        "unreadable return",
        "A pointer answer whose pointed-to type no emitted function accepts. The "
        "caller receives an address and the catalog names nothing this binding "
        "reaches that renders it, operates on it or takes it back.",
        ("function", "api", "pointed-to type"))
    ledger.kind(
        "array element type",
        "A function the catalog states answers an array without stating what "
        "the elements are. Emitted as a stub: a wrapper would walk the array at "
        "a stride the catalog never states.",
        ("function", "return", "what is missing"))
    ledger.kind(
        "array return length",
        "An `arrayReturn` whose length the catalog states in a way this "
        "generator reads no length out of.",
        ("function", "lengthFrom kind", "emitted instead"))
    ledger.kind(
        "output array length",
        "An `outputArrays` parameter with no length source, so the count of "
        "what the callee wrote is unstated.",
        ("function", "what is missing", "emitted instead"))
    ledger.kind(
        "value text I/O",
        "A struct the binding carries as a value and the catalog names no "
        "complete text reader and writer for, so the value states itself in no "
        "form a caller can read or write.",
        ("struct", "what is missing"))


def survey(funcs: list[dict], idl: dict) -> None:
    """Record the contracts the emitted surface is missing rather than wrong.

    These are not fall-throughs — every function below reaches the surface — so
    nothing in the emission path passes through them. They are read off the
    catalog directly, which also makes each row's absence checkable against it."""
    classed = {c.get("cType") for c in
               idl.get("objectModel", {}).get("classes", {}).values()}
    # Every emitted function is a route back into MEOS, internal ones included:
    # the flat surface wraps the whole projected catalog, so a type one of
    # them takes is a type a caller of this binding can hand back.
    accepted: set[str] = set()
    named: set[str] = set()
    for f in funcs:
        for spot in [f["returnType"]] + list(f.get("params", [])):
            named.add(_strip_const_stars(spot["canonical"])[0])
        for p in f.get("params", []):
            accepted.add(_strip_const_stars(p["canonical"])[0])

    for f in funcs:
        stated = set((f.get("shape") or {}).get("nullable") or [])
        unstated = [p["name"] for p in f.get("params", [])
                    if "*" in p["canonical"] and p["name"] not in stated]
        if unstated:
            _gap("parameter nullability", f["name"], ", ".join(unstated))

        base, stars = _strip_const_stars(f["returnType"]["canonical"])
        scalar = (_names_a_value(base)
                  and scalar_cs(base, f"{f['name']} return") is not None)
        if (stars and base not in ("char", "void", "uint8_t") and not scalar
                and base not in ENUM_TYPES and base not in BY_VALUE_STRUCTS
                and base not in classed and base not in accepted):
            _gap("unreadable return", f["name"], f.get("api", "?"), base)

    # A struct the surface names states every by-value field in a type the
    # catalog maps; one it does not stops the run.
    for struct in idl.get("structs", []):
        if struct["name"] not in named:
            continue
        for field in struct.get("fields") or []:
            t = _bare(field["canonical"]).split("[")[0].strip()
            if not is_pointer(t):
                resolve(t, f"struct {struct['name']} field {field['name']}")


def main(idl_path: str, dll_path: str = DLL_PATH) -> None:
    global DLL_PATH, LEDGER
    DLL_PATH = dll_path
    with open(idl_path) as fh:
        idl = json.load(fh)
    configure(idl)
    LEDGER = gapledger.Ledger("flat surface", "The flat surface — `tools/codegen.py`")
    _declare_kinds(LEDGER)
    # A binding projects MEOS's own surface (#projected).
    funcs = [f for f in idl["functions"] if projected(f)]
    repo_root = Path(__file__).resolve().parent.parent
    out_dir = repo_root / "MEOS.NET" / "Functions"
    struct_dir = repo_root / "MEOS.NET" / "Structures"

    collisions = {}
    for f in funcs:
        collisions.setdefault(public_name(f["name"]), []).append(f["name"])
    clashing = {k: v for k, v in collisions.items() if len(v) > 1}
    if clashing:
        raise SystemExit(f"codegen: C names sharing one C# name: {clashing}")

    # Every file is rendered before any is written, so a type that maps to
    # nothing stops the run with the committed files in place.
    rendered = {out_dir / "Meos.Native.g.cs": gen_external_functions(funcs)}
    grouped = by_header(funcs)
    for header, group in sorted(grouped.items()):
        stem = header.removesuffix(".h")
        rendered[out_dir / f"Meos.{stem}.g.cs"] = gen_exposed_functions(group, header)
    # The structs come last: a value struct reads and writes itself through the
    # wrappers above, so the signature registry has to hold them first.
    rendered[struct_dir / "MeosStructs.g.cs"] = gen_structs()

    for directory in (out_dir, struct_dir):
        if directory.exists():
            for stale in directory.glob("*.g.cs"):
                stale.unlink()
        directory.mkdir(parents=True, exist_ok=True)
    for path, text in rendered.items():
        path.write_text(text)

    # The ledger comes last: it takes the emission's own fall-throughs, which
    # are only known once every wrapper and every struct has been written.
    survey(funcs, idl)
    ledger_path = LEDGER.write(repo_root, idl.get("sourceCommit", "unknown"))

    vendored = len(idl["functions"]) - len(funcs)
    print(f"Wrote {len(funcs)} functions across {len(grouped)} headers "
          f"to MEOS.NET/Functions/, {len(BY_VALUE_STRUCTS)} by-value structs, "
          f"{vendored} vendored declarations left to their own project, "
          f"{LEDGER.total} gaps to {ledger_path.name}",
          file=sys.stderr)


if __name__ == "__main__":
    parser = argparse.ArgumentParser(
        description="Generate MEOS.NET bindings from MEOS-API's meos-idl.json.")
    parser.add_argument("idl", metavar="meos-idl.json",
                        help="path to the MEOS-API catalog")
    parser.add_argument("--dll-path", default=DLL_PATH, metavar="NAME",
                        help='native library name embedded in [LibraryImport] '
                             f'(default: "{DLL_PATH}", resolved by the OS loader)')
    args = parser.parse_args()
    main(args.idl, args.dll_path)
