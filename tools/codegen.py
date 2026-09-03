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

# Default lets the OS loader resolve via LD_LIBRARY_PATH / DYLD_LIBRARY_PATH /
# PATH; override with --dll-path to embed a specific library name or path.
DLL_PATH = "meos"
GENERATOR_VERSION = "0.1.0"

# The public surface: one static class, in one namespace, split across one file
# per MEOS header exactly as the catalog groups the functions.
NAMESPACE = "MEOS.NET.Functions"
CLASS = "Meos"
STRUCT_NAMESPACE = "MEOS.NET.Structures"

# Canonical C type -> C# parameter/return type.
# `canonical` field from meos-idl.json is libclang-normalized (e.g. int32_t -> int).
SCALAR_MAP: dict[str, str] = {
    "void": "void",
    "bool": "bool",
    "char": "byte",
    "int": "int",
    "unsigned int": "uint",
    "short": "short",
    "long": "long",
    "long long": "long",
    "unsigned long": "ulong",
    "unsigned long long": "ulong",
    "float": "float",
    "double": "double",
    # MEOS / Postgres / vendored typedefs that libclang doesn't always reduce.
    "DateADT": "int",
    "TimeADT": "long",
    "TimeOffset": "long",
    "TimestampTz": "long",
    "Timestamp": "long",
    "Datum": "long",
    "int8": "sbyte",
    "uint8": "byte",
    "uint8_t": "byte",
    "int16": "short",
    "uint16": "ushort",
    "int32": "int",
    "uint32": "uint",
    "int64": "long",
    "uint64": "ulong",
    "int8_t": "sbyte",
    "int16_t": "short",
    "int32_t": "int",
    "int64_t": "long",
    "uint16_t": "ushort",
    "uint32_t": "uint",
    "uint64_t": "ulong",
    "signed char": "sbyte",
    "unsigned char": "byte",
    "unsigned short": "ushort",
    "size_t": "ulong",
    "ssize_t": "long",
}

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


def configure(idl: dict) -> None:
    """Take from the catalog the type facts the mapping below reads."""
    ENUM_TYPES.clear()
    ENUM_TYPES.update(e["name"] for e in idl.get("enums", []) if e.get("name"))
    STRUCTS.clear()
    STRUCTS.update({s["name"]: s for s in idl.get("structs", []) if s.get("fields")})
    TYPE_ENCODINGS.clear()
    TYPE_ENCODINGS.update(idl.get("typeEncodings", {}))
    BY_VALUE_STRUCTS.clear()
    classed = {c["cType"] for c in
               idl.get("objectModel", {}).get("classes", {}).values()
               if c.get("cType")}
    for f in idl.get("functions", []):
        if f.get("vendored"):
            continue
        for spot in [f["returnType"]] + list(f.get("params", [])):
            canonical = spot["canonical"].replace("const ", "").strip()
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
                if all(fl["cType"] in _SCALAR_BYTES for fl in fields):
                    BY_VALUE_STRUCTS.add(base)


# Size and alignment in bytes of the scalar C types a struct field can have, on
# the 64-bit targets the binding ships for.
_SCALAR_BYTES: dict[str, int] = {
    "bool": 1, "char": 1, "int8": 1, "int8_t": 1, "uint8": 1, "uint8_t": 1,
    "short": 2, "int16": 2, "int16_t": 2, "uint16": 2, "uint16_t": 2,
    "int": 4, "int32": 4, "int32_t": 4, "uint32": 4, "uint32_t": 4,
    "float": 4, "Oid": 4, "DateADT": 4,
    "long": 8, "int64": 8, "int64_t": 8, "uint64": 8, "uint64_t": 8,
    "double": 8, "float8": 8, "Datum": 8, "Timestamp": 8, "TimestampTz": 8,
    "TimeADT": 8, "TimeOffset": 8, "size_t": 8, "uintptr_t": 8,
}


# The catalog structs the binding gives a C# VALUE type, filled in by
# ``configure``: the ones a function hands over by value, and the ones it hands
# over through a pointer while stating their whole layout in scalars and giving
# them no class.  Every other MEOS struct crosses the boundary as a pointer and
# stays opaque.
BY_VALUE_STRUCTS: set[str] = set()


def csharp_field_type(c_type: str) -> str:
    """The C# type of a by-value struct's field."""
    t = c_type.replace("const ", "").strip()
    if t.endswith("*"):
        return "IntPtr"
    if t in ENUM_TYPES:
        return "int"
    if t not in SCALAR_MAP:
        raise SystemExit(f"codegen: struct field type {t!r} has no C# mapping")
    return SCALAR_MAP[t]


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
            lines.append(f"        public {csharp_field_type(field['cType'])} "
                         f"{csharp_param_name(field['name'])};")
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
        return []
    read_fn, write_fn = SIGNATURES.get(reader), SIGNATURES.get(writer)
    if not read_fn or not write_fn:
        return []
    encoding = TYPE_ENCODINGS.get(name, {})
    read_args = _io_args(read_fn[1], "str", encoding.get("in_aux"))
    write_args = _io_args(write_fn[1], "ptr", encoding.get("out_aux"))
    if read_args is None or write_args is None:
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
    t = c_type.replace("const ", "").strip()
    if t.endswith("*"):
        return (8, 8)
    if "[" in t:
        base, count = t[:t.index("[")].strip(), int(t[t.index("[") + 1:t.index("]")])
        size, align = _type_layout(base)
        return (size * count, align)
    if t in STRUCTS:
        return struct_layout(t)
    if t not in _SCALAR_BYTES:
        raise KeyError(f"struct field type {t!r} has no known layout")
    return (_SCALAR_BYTES[t], _SCALAR_BYTES[t])


def struct_layout(name: str) -> tuple[int, int]:
    """``(size, alignment)`` of a catalog struct: each field sits at the offset the
    catalog records, and the whole is padded to a multiple of its widest field."""
    size = align = 1
    for field in STRUCTS[name]["fields"]:
        fsize, falign = _type_layout(field["cType"])
        align = max(align, falign)
        size = max(size, field["offset_bits"] // 8 + fsize)
    return ((size + align - 1) // align * align, align)


# C pointer-to-char marshalled as managed string when StringMarshalling.Utf8 is on.
def is_string_pointer(c_type: str) -> bool:
    t = c_type.replace("const ", "").strip()
    return t in ("char *", "char**", "char *const *", "const char *")


def is_borrowed_string(c_type: str) -> bool:
    """A ``const char *`` return the caller does not own.

    The Utf8 string marshaller frees what it is handed back, which is right for
    the ``char *`` MEOS mallocs for the caller and fatal for the ``const char *``
    it returns out of a static table — ``interptype_name`` hands back an element
    of ``MEOS_INTERPTYPE_NAMES``.  A borrowed return comes back as the pointer
    itself and is read without a free."""
    return " ".join(c_type.split()).startswith("const char *")


def csharp_type_for(canonical: str) -> str:
    """Translate a libclang-canonical C type to a C# type for LibraryImport signatures."""
    t = canonical.strip()
    # Strip leading const
    if t.startswith("const "):
        t = t[len("const "):].strip()
    # Pointer of any depth -> IntPtr (we don't propagate pointer types into C# semantics).
    if "*" in t or t.endswith("[]"):
        return "IntPtr"
    if t in ENUM_TYPES:
        return "int"
    if t in BY_VALUE_STRUCTS:
        return t
    return SCALAR_MAP.get(t, "IntPtr")  # unknown scalar -> opaque pointer is safer than guessing


def csharp_param_type(c_type: str, canonical: str) -> str:
    """For a single parameter, decide the C# type, treating `char *` specially as string."""
    if is_string_pointer(c_type):
        return "string"
    return csharp_type_for(canonical)


def csharp_return_type(c_type: str, canonical: str) -> str:
    if is_borrowed_string(c_type):
        return "IntPtr"
    if is_string_pointer(c_type):
        return "string"
    return csharp_type_for(canonical)


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
        rt = csharp_return_type(f["returnType"]["c"], f["returnType"]["canonical"])
        params: list[str] = []
        for p in f.get("params", []):
            pname = csharp_param_name(p["name"]) if p["name"] else "arg"
            ptype = csharp_param_type(p["cType"], p["canonical"])
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
    s = c_type.replace("const ", "").strip()
    stars = s.count("*")
    return s.replace("*", "").strip(), stars


def _csharp_array_element(c_type: str, canonical: str) -> tuple[str, str]:
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
    base, stars = _strip_const_stars(c_type)
    elem = SCALAR_MAP.get(base) or SCALAR_MAP.get(canonical.replace("*", "").strip())
    if elem in _MARSHAL_ELEM:
        return (elem, "Marshal.Copy")
    if base == "uint8_t":
        return ("byte", "ByteBuffer")
    if elem in _SCALAR_ELEM_READER:
        return (elem, f"ScalarArray:{elem}")
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
        # No identifiable length source; fall back.
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
        ptype = csharp_param_type(p["cType"], p["canonical"])
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
            elem, strategy = _csharp_array_element(p["cType"], p["canonical"])
            output_locals.append((local, oa, elem, strategy))
            continue
        sig_params.append(f"{ptype} {pname}")
        sig_types.append((ptype, pname))
        ext_call_args.append(pname)

    # Compose the return tuple type.
    ret_pieces: list[str] = []
    if array_ret:
        ret_elem, _ = _csharp_array_element(f["returnType"]["c"], f["returnType"]["canonical"])
        ret_pieces.append(f"{ret_elem}[]")
    for _, _oa, elem, _strategy in output_locals:
        ret_pieces.append(f"{elem}[]")
    if not ret_pieces:
        return []  # nothing to type; fall back.
    if len(ret_pieces) == 1:
        ret_type = ret_pieces[0]
    else:
        ret_type = "(" + ", ".join(ret_pieces) + ")"

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
        rt = csharp_return_type(f["returnType"]["c"], f["returnType"]["canonical"])
        if rt == "void":
            lines.append(f"                SafeExecution(() => Native.{public_name(name)}({ext_args}));")
        else:
            lines.append(f"                SafeExecution<{rt}>(() => Native.{public_name(name)}({ext_args}));")
    lines.append(f"                int _n = Marshal.ReadInt32(_count_{count_param});")
    if array_ret:
        ret_elem, ret_strategy = _csharp_array_element(f["returnType"]["c"], f["returnType"]["canonical"])
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
    elem, strategy = _csharp_array_element(f["returnType"]["c"], f["returnType"]["canonical"])
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

    # kind == "param": the length is written back through the function's own
    # ``int *count`` output.  Allocate it, hide it from the public signature,
    # and read the count back after the call.
    count_name = csharp_param_name(length_meta["name"])
    pub = ", ".join(
        f"{csharp_param_type(p['cType'], p['canonical'])} {csharp_param_name(p['name'])}"
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


def _emit_simple_passthrough(f: dict, ext_params: str, ext_args: str, default_rt: str | None = None) -> list[str]:
    name = f["name"]
    rt = default_rt or csharp_return_type(f["returnType"]["c"], f["returnType"]["canonical"])
    if default_rt is None and is_borrowed_string(f["returnType"]["c"]):
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

        emitted: list[str] = []
        if "outputArrays" in shape:
            emitted = _emit_outputs_wrapper(f)
        if not emitted and "arrayReturn" in shape and shape["arrayReturn"]["lengthFrom"]["kind"] in ("accessor", "param"):
            emitted = _emit_array_return_wrapper(f, ext_params, ext_args)
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
    return [(csharp_param_type(p["cType"], p["canonical"]),
             csharp_param_name(p["name"]) if p["name"] else "arg")
            for p in f.get("params", [])]


def _format_params(f: dict) -> tuple[str, str]:
    params: list[str] = []
    arg_names: list[str] = []
    for p in f.get("params", []):
        pname = csharp_param_name(p["name"]) if p["name"] else "arg"
        ptype = csharp_param_type(p["cType"], p["canonical"])
        params.append(f"{ptype} {pname}")
        arg_names.append(pname)
    return ", ".join(params), ", ".join(arg_names)


def main(idl_path: str, dll_path: str = DLL_PATH) -> None:
    global DLL_PATH
    DLL_PATH = dll_path
    with open(idl_path) as fh:
        idl = json.load(fh)
    configure(idl)
    # A binding projects MEOS's own surface. The catalog marks the declarations
    # that reach it from a project MEOS vendors — pgPointCloud's `pc_api.h` and
    # `hashtable.h`, PostgreSQL's `pg_numeric.h` — and those are that project's
    # API, not MEOS's: 150 of them, every one internal, and the only three the
    # built library does not export at all.
    funcs = [f for f in idl["functions"] if not f.get("vendored")]
    repo_root = Path(__file__).resolve().parent.parent
    out_dir = repo_root / "MEOS.NET" / "Functions"
    if out_dir.exists():
        for stale in out_dir.glob("*.g.cs"):
            stale.unlink()
    out_dir.mkdir(parents=True, exist_ok=True)

    collisions = {}
    for f in funcs:
        collisions.setdefault(public_name(f["name"]), []).append(f["name"])
    clashing = {k: v for k, v in collisions.items() if len(v) > 1}
    if clashing:
        raise SystemExit(f"codegen: C names sharing one C# name: {clashing}")

    (out_dir / "Meos.Native.g.cs").write_text(gen_external_functions(funcs))
    grouped = by_header(funcs)
    for header, group in sorted(grouped.items()):
        stem = header.removesuffix(".h")
        (out_dir / f"Meos.{stem}.g.cs").write_text(gen_exposed_functions(group, header))

    # The structs come last: a value struct reads and writes itself through the
    # wrappers above, so the signature registry has to hold them first.
    struct_dir = repo_root / "MEOS.NET" / "Structures"
    if struct_dir.exists():
        for stale in struct_dir.glob("*.g.cs"):
            stale.unlink()
    struct_dir.mkdir(parents=True, exist_ok=True)
    (struct_dir / "MeosStructs.g.cs").write_text(gen_structs())
    vendored = len(idl["functions"]) - len(funcs)
    print(f"Wrote {len(funcs)} functions across {len(grouped)} headers "
          f"to MEOS.NET/Functions/, {len(BY_VALUE_STRUCTS)} by-value structs, "
          f"{vendored} vendored declarations left to their own project",
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
