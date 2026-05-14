#!/usr/bin/env python3
"""Generate MEOSExternalFunctions.cs and MEOSExposedFunctions.cs from MEOS-API's meos-idl.json.

Consumes the unified MEOS API catalog (https://github.com/MobilityDB/MEOS-API) and produces
the two MEOS.NET internal-binding files. Replaces the regex-based MEOS.NET.Builder which has
known parse defects on signatures like `int32_t srid` (rendered as `int_t`).

Usage:
    python3 tools/codegen.py path/to/meos-idl.json

Writes MEOS.NET/Internal/MEOSExternalFunctions.cs and MEOSExposedFunctions.cs in-place.
"""

from __future__ import annotations

import json
import sys
from pathlib import Path

DLL_PATH = "meos"  # let the OS loader resolve via LD_LIBRARY_PATH / DYLD_LIBRARY_PATH / PATH
GENERATOR_VERSION = "0.1.0"

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
    "size_t": "ulong",
    "ssize_t": "long",
    "meosType": "int",
    "MeosType": "int",
    "interpType": "int",
    "tempSubtype": "int",
    "spanType": "int",
}

# C pointer-to-char marshalled as managed string when StringMarshalling.Utf8 is on.
def is_string_pointer(c_type: str) -> bool:
    t = c_type.replace("const ", "").strip()
    return t in ("char *", "char**", "char *const *", "const char *")


def csharp_type_for(canonical: str) -> str:
    """Translate a libclang-canonical C type to a C# type for LibraryImport signatures."""
    t = canonical.strip()
    # Strip leading const
    if t.startswith("const "):
        t = t[len("const "):].strip()
    # Pointer of any depth -> IntPtr (we don't propagate pointer types into C# semantics).
    if "*" in t or t.endswith("[]"):
        return "IntPtr"
    return SCALAR_MAP.get(t, "IntPtr")  # unknown scalar -> opaque pointer is safer than guessing


def csharp_param_type(c_type: str, canonical: str) -> str:
    """For a single parameter, decide the C# type, treating `char *` specially as string."""
    if is_string_pointer(c_type):
        return "string"
    return csharp_type_for(canonical)


def csharp_return_type(c_type: str, canonical: str) -> str:
    if is_string_pointer(c_type):
        return "string"
    return csharp_type_for(canonical)


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
    }
    return f"@{name}" if name in reserved else name


def gen_external_functions(funcs: list[dict]) -> str:
    lines: list[str] = []
    lines.append("using System.CodeDom.Compiler;")
    lines.append("using System.Runtime.InteropServices;")
    lines.append("")
    lines.append("using MEOS.NET.Enums;")
    lines.append("")
    lines.append("namespace MEOS.NET.Internal")
    lines.append("{")
    lines.append("    internal partial class MEOSExposedFunctions")
    lines.append("    {")
    lines.append(f'        [GeneratedCode("MEOS.NET.Builder.MEOSIDL", "{GENERATOR_VERSION}")]')
    lines.append("        private partial class MEOSExternalFunctions")
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
        lines.append("            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]")
        if rt == "bool":
            lines.append("            [return: MarshalAs(UnmanagedType.U1)]")
        lines.append(f"            public static partial {rt} {name}({param_list});")
        lines.append("")

    lines.append("        }")
    lines.append("    }")
    lines.append("}")
    return "\n".join(lines) + "\n"


# Element types we know how to Marshal.Copy from a C array pointer back into
# a managed C# array.  IntPtr is the fallback for wrapped opaque pointers.
_MARSHAL_ELEM: dict[str, str] = {
    "long":   "long",
    "int":    "int",
    "double": "double",
    "byte":   "byte",
    "short":  "short",
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
    ext_call_args: list[str] = []
    setup: list[str] = []
    teardown: list[str] = []
    output_locals: list[tuple[str, dict, str]] = []  # (output_param_local, oa_dict, elem_csharp_type)

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
            elem, _strategy = _csharp_array_element(p["cType"], p["canonical"])
            output_locals.append((local, oa, elem))
            continue
        sig_params.append(f"{ptype} {pname}")
        ext_call_args.append(pname)

    # Compose the return tuple type.
    ret_pieces: list[str] = []
    if array_ret:
        ret_elem, _ = _csharp_array_element(f["returnType"]["c"], f["returnType"]["canonical"])
        ret_pieces.append(f"{ret_elem}[]")
    for _, _oa, elem in output_locals:
        ret_pieces.append(f"{elem}[]")
    if not ret_pieces:
        return []  # nothing to type; fall back.
    if len(ret_pieces) == 1:
        ret_type = ret_pieces[0]
    else:
        ret_type = "(" + ", ".join(ret_pieces) + ")"

    user_params = ", ".join(sig_params)
    ext_args = ", ".join(ext_call_args)

    lines: list[str] = []
    lines.append(f"        public static {ret_type} {name}({user_params})")
    lines.append("        {")
    lines.extend(setup)
    lines.append("            try")
    lines.append("            {")
    if array_ret:
        lines.append(f"                IntPtr _resultPtr = SafeExecution<IntPtr>(() => MEOSExternalFunctions.{name}({ext_args}));")
    else:
        # Void or bool return with only outputs.
        rt = csharp_return_type(f["returnType"]["c"], f["returnType"]["canonical"])
        if rt == "void":
            lines.append(f"                SafeExecution(() => MEOSExternalFunctions.{name}({ext_args}));")
        else:
            lines.append(f"                SafeExecution<{rt}>(() => MEOSExternalFunctions.{name}({ext_args}));")
    lines.append(f"                int _n = Marshal.ReadInt32(_count_{count_param});")
    if array_ret:
        ret_elem, ret_strategy = _csharp_array_element(f["returnType"]["c"], f["returnType"]["canonical"])
        lines.append(f"                {ret_elem}[] _resultArr = new {ret_elem}[_n];")
        if ret_strategy == "Marshal.Copy":
            lines.append("                Marshal.Copy(_resultPtr, _resultArr, 0, _n);")
        else:
            lines.append("                for (int _i = 0; _i < _n; _i++)")
            lines.append("                { _resultArr[_i] = Marshal.ReadIntPtr(_resultPtr, _i * IntPtr.Size); }")
    for local, oa, elem in output_locals:
        lines.append(f"                IntPtr _{local}_arr = Marshal.ReadIntPtr({local});")
        lines.append(f"                {elem}[] _{local}_out = new {elem}[_n];")
        if elem == "IntPtr":
            lines.append(f"                for (int _i = 0; _i < _n; _i++)")
            lines.append(f"                {{ _{local}_out[_i] = Marshal.ReadIntPtr(_{local}_arr, _i * IntPtr.Size); }}")
        else:
            lines.append(f"                Marshal.Copy(_{local}_arr, _{local}_out, 0, _n);")

    # Build return expression.
    return_pieces: list[str] = []
    if array_ret:
        return_pieces.append("_resultArr")
    for local, _, _ in output_locals:
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

    Used when shape.arrayReturn is present.  Slice length comes from either
    a sibling accessor call (kind=accessor) or an output parameter
    (kind=param) of the same function."""
    name = f["name"]
    shape = f["shape"]
    length_meta = shape["arrayReturn"]["lengthFrom"]
    elem, strategy = _csharp_array_element(f["returnType"]["c"], f["returnType"]["canonical"])
    ret_type = f"{elem}[]"

    lines: list[str] = []
    lines.append(f"        public static {ret_type} {name}({ext_params})")
    lines.append("        {")
    if length_meta["kind"] == "accessor":
        accessor = length_meta["func"]
        arg = csharp_param_name(length_meta["arg"])
        lines.append(f"            int _n = (int)MEOSExposedFunctions.{accessor}({arg});")
    else:
        # kind == "param": the length is one of the function's own outputs.
        # Emit a stub for now; full param-output unpacking lives in the
        # outputArrays wrapper.  Falls back to IntPtr return.
        return _emit_simple_passthrough(f, ext_params, ext_args, default_rt="IntPtr")

    lines.append(f"            IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.{name}({ext_args}));")
    if strategy == "Marshal.Copy":
        lines.append(f"            {elem}[] _out = new {elem}[_n];")
        lines.append(f"            Marshal.Copy(_p, _out, 0, _n);")
        lines.append("            return _out;")
    else:
        # Read N IntPtrs out of the array.
        lines.append(f"            {elem}[] _out = new {elem}[_n];")
        lines.append(f"            for (int _i = 0; _i < _n; _i++)")
        lines.append(f"            {{ _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }}")
        lines.append("            return _out;")
    lines.append("        }")
    return lines


def _emit_simple_passthrough(f: dict, ext_params: str, ext_args: str, default_rt: str | None = None) -> list[str]:
    name = f["name"]
    rt = default_rt or csharp_return_type(f["returnType"]["c"], f["returnType"]["canonical"])
    if rt == "void":
        return [
            f"        public static void {name}({ext_params})",
            f"            => SafeExecution(() => MEOSExternalFunctions.{name}({ext_args}));",
        ]
    return [
        f"        public static {rt} {name}({ext_params})",
        f"            => SafeExecution<{rt}>(() => MEOSExternalFunctions.{name}({ext_args}));",
    ]


def gen_exposed_functions(funcs: list[dict]) -> str:
    """Generate the safe-executed wrappers.

    Each wrapper either delegates straight through SafeExecution or, when
    meos-idl.json carries a ``shape`` annotation for the function, lifts
    the C signature into a more idiomatic C# return.  arrayReturn with a
    sibling-accessor length emits a Marshal.Copy unpack; other shapes
    fall back to the IntPtr passthrough today."""
    lines: list[str] = []
    lines.append("using System.CodeDom.Compiler;")
    lines.append("using System.Runtime.InteropServices;")
    lines.append("")
    lines.append("using MEOS.NET.Enums;")
    lines.append("")
    lines.append("namespace MEOS.NET.Internal")
    lines.append("{")
    lines.append(f'    [GeneratedCode("MEOS.NET.Builder.MEOSIDL", "{GENERATOR_VERSION}")]')
    lines.append("    internal partial class MEOSExposedFunctions")
    lines.append("    {")

    for f in funcs:
        ext_params, ext_args = _format_params(f)
        shape = f.get("shape", {})

        emitted: list[str] = []
        if "outputArrays" in shape:
            emitted = _emit_outputs_wrapper(f)
        if not emitted and "arrayReturn" in shape and shape["arrayReturn"]["lengthFrom"]["kind"] == "accessor":
            emitted = _emit_array_return_wrapper(f, ext_params, ext_args)
        if not emitted:
            emitted = _emit_simple_passthrough(f, ext_params, ext_args)
        lines.extend(emitted)
        lines.append("")

    lines.append("    }")
    lines.append("}")
    return "\n".join(lines) + "\n"


def _format_params(f: dict) -> tuple[str, str]:
    params: list[str] = []
    arg_names: list[str] = []
    for p in f.get("params", []):
        pname = csharp_param_name(p["name"]) if p["name"] else "arg"
        ptype = csharp_param_type(p["cType"], p["canonical"])
        params.append(f"{ptype} {pname}")
        arg_names.append(pname)
    return ", ".join(params), ", ".join(arg_names)


def main(idl_path: str) -> None:
    with open(idl_path) as fh:
        idl = json.load(fh)
    funcs = idl["functions"]
    repo_root = Path(__file__).resolve().parent.parent
    out_dir = repo_root / "MEOS.NET" / "Internal"
    out_dir.mkdir(parents=True, exist_ok=True)

    (out_dir / "MEOSExternalFunctions.cs").write_text(gen_external_functions(funcs))
    (out_dir / "MEOSExposedFunctions.cs").write_text(gen_exposed_functions(funcs))
    print(f"Wrote {len(funcs)} function bindings to MEOS.NET/Internal/", file=sys.stderr)


if __name__ == "__main__":
    if len(sys.argv) < 2:
        print(__doc__, file=sys.stderr)
        sys.exit(1)
    main(sys.argv[1])
