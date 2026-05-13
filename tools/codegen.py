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
            params.append(f"{ptype} {pname}")
        param_list = ", ".join(params)
        lines.append("            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]")
        lines.append(f"            public static partial {rt} {name}({param_list});")
        lines.append("")

    lines.append("        }")
    lines.append("    }")
    lines.append("}")
    return "\n".join(lines) + "\n"


def gen_exposed_functions(funcs: list[dict]) -> str:
    """Generate the safe-executed wrappers (wraps each external call with error-check).

    Pattern from the existing hand-written MEOSExposedFunctions.cs: each wrapper calls
    the external function, then SafeExecution reads meos_errno and throws if non-zero.
    For functions in `bool_compat`, the wrapper preserves the legacy `bool` return
    type by converting the `int` ABI result via `!= 0`.
    """
    lines: list[str] = []
    lines.append("using System.CodeDom.Compiler;")
    lines.append("")
    lines.append("using MEOS.NET.Enums;")
    lines.append("")
    lines.append("namespace MEOS.NET.Internal")
    lines.append("{")
    lines.append(f'    [GeneratedCode("MEOS.NET.Builder.MEOSIDL", "{GENERATOR_VERSION}")]')
    lines.append("    internal partial class MEOSExposedFunctions")
    lines.append("    {")

    for f in funcs:
        name = f["name"]
        rt = csharp_return_type(f["returnType"]["c"], f["returnType"]["canonical"])
        params: list[str] = []
        arg_names: list[str] = []
        for p in f.get("params", []):
            pname = csharp_param_name(p["name"]) if p["name"] else "arg"
            ptype = csharp_param_type(p["cType"], p["canonical"])
            params.append(f"{ptype} {pname}")
            arg_names.append(pname)
        param_list = ", ".join(params)
        arg_list = ", ".join(arg_names)

        if rt == "void":
            lines.append(f"        public static void {name}({param_list})")
            lines.append(f"            => SafeExecution(() => MEOSExternalFunctions.{name}({arg_list}));")
        else:
            lines.append(f"        public static {rt} {name}({param_list})")
            lines.append(f"            => SafeExecution<{rt}>(() => MEOSExternalFunctions.{name}({arg_list}));")
        lines.append("")

    lines.append("    }")
    lines.append("}")
    return "\n".join(lines) + "\n"


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
