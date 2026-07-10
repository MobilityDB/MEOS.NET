# MEOS.NET binding regen via MEOS-API

`codegen.py` regenerates `MEOS.NET/Internal/MEOSExternalFunctions.cs` and
`MEOS.NET/Internal/MEOSExposedFunctions.cs` from MobilityDB/MEOS-API's
unified `meos-idl.json` catalog.

This replaces the previous regex-based `MEOS.NET.Builder` workflow, which
had known parse defects (e.g. `int32_t srid` rendered as `int_t srid`,
single-line-only regex, hardcoded developer DllPath).

## Quick start

1. Build `meos-idl.json` from the MobilityDB headers you want to target.
   Current MEOS lives on MobilityDB `master` (there is no stable-1.4
   branch yet). The bindings consume MEOS-API's shape metadata, available
   only on the `feat/shape-metadata` branch until it merges to MEOS-API
   `master`:
   ```
   git clone --branch feat/shape-metadata https://github.com/MobilityDB/MEOS-API
   cd MEOS-API
   pip install -r requirements.txt
   python setup.py --branch master                # MobilityDB ref to target
   python run.py                                  # emits output/meos-idl.json
   ```

2. Run the generator from this repo:
   ```
   python3 tools/codegen.py /path/to/meos-idl.json
   ```

The two `.cs` files under `MEOS.NET/Internal/` are overwritten in place
with bindings for every public MEOS function in the catalog.

## DllPath

`DllPath` defaults to the bare name `"meos"` so the OS loader resolves it
via `LD_LIBRARY_PATH` (Linux), `DYLD_LIBRARY_PATH` (macOS), or `PATH`
(Windows). No hardcoded developer paths. Override it without editing the
generator:

```
python3 tools/codegen.py /path/to/meos-idl.json --dll-path libmeos.so.1
```

## Type mapping

Pointer types of any depth map to `IntPtr`. `char *` parameters with
`StringMarshalling.Utf8` map to managed `string`. Scalar types
(`int`/`int32`/`int64`/`bool`/`double`/...) map per the table in
`SCALAR_MAP` inside `codegen.py`.

## Known follow-up after a MEOS major-version bump

The bindings are auto-generated; the high-level C# code under
`MEOS.NET/Types/` is hand-written and calls into the bindings. When MEOS
renames or re-types a function, the call sites must follow. Two recurring
adaptation classes:

- `int` / `bool` boundary: `_Bool` returns and parameters marshal as C#
  `bool` (`UnmanagedType.U1`), so predicate wrappers must not wrap calls
  in `!= 0` and flags pass as `bool`, not `(cond ? 1 : 0)`.
- Renames or type-suffixed replacements: a function that no longer
  resolves directly has moved or been split into type-specific names.

Running `dotnet build MEOS.NET/MEOS.NET.csproj` against the regenerated
bindings surfaces every adaptation point as a compiler error, with no
hidden runtime breakage. The CI workflow does exactly this on every
push.
