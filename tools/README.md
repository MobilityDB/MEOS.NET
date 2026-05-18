# MEOS.NET binding regen via MEOS-API

`codegen.py` regenerates `MEOS.NET/Internal/MEOSExternalFunctions.cs` and
`MEOS.NET/Internal/MEOSExposedFunctions.cs` from MobilityDB/MEOS-API's
unified `meos-idl.json` catalog.

This replaces the previous regex-based `MEOS.NET.Builder` workflow, which
had known parse defects (e.g. `int32_t srid` rendered as `int_t srid`,
single-line-only regex, hardcoded developer DllPath).

## Quick start

1. Build `meos-idl.json` from the MobilityDB headers you want to target:
   ```
   git clone https://github.com/MobilityDB/MEOS-API
   cd MEOS-API
   pip install -r requirements.txt
   python setup.py --branch stable-1.3            # or master for 1.4
   python run.py                                  # emits output/meos-idl.json
   ```

2. Run the generator from this repo:
   ```
   python3 tools/codegen.py /path/to/meos-idl.json
   ```

The two `.cs` files under `MEOS.NET/Internal/` are overwritten in place
with bindings for every public MEOS function in the catalog.

## DllPath

`DllPath` is set to the bare name `"meos"` so the OS loader resolves it
via `LD_LIBRARY_PATH` (Linux), `DYLD_LIBRARY_PATH` (macOS), or `PATH`
(Windows). No hardcoded developer paths.

## Type mapping

Pointer types of any depth map to `IntPtr`. `char *` parameters with
`StringMarshalling.Utf8` map to managed `string`. Scalar types
(`int`/`int32`/`int64`/`bool`/`double`/...) map per the table in
`SCALAR_MAP` inside `codegen.py`.

## Known follow-up after a MEOS major-version bump

The bindings are auto-generated; the high-level C# code under
`MEOS.NET/Types/` is hand-written and calls into the bindings. When MEOS
renames or re-types a function, the call sites must follow.

For the MEOS 1.2 → 1.3 bump (this commit's purpose), the regen pulled
in roughly 1100 new functions and dropped/renamed a handful. The
hand-written wrappers in `MEOS.NET/Types/` need updates for:

- `int` → `bool` mismatches on predicates (some MEOS 1.3 predicates that
  used to return `bool` now return `int`, or vice versa).
- Renames: `tfloat_derivative`, `tfloat_round`, `distance_tfloat_float`
  and similar names no longer resolve directly; the 1.3 equivalents live
  under `tnumber_*` or have type-suffixed names.

Running `dotnet build MEOS.NET/MEOS.NET.csproj` against the new
bindings surfaces every adaptation point as a compiler error — work
through the list, no hidden runtime breakage.

## Portable bare-name dialect (RFC #920)

The MobilityDB ecosystem defines a canonical, type-agnostic
operator → bare-name dialect so one query runs identically on every
engine and binding (a user learns one reference and assumes the rest).
The contract is **29 operator → bareName pairs** across eight families
(topology, time-position, space X/Y/Z, temporal-comparison, distance,
same), the single source of truth being MEOS-API
`meta/portable-aliases.json` (discussion MobilityDB#861 · RFC #920 ·
native MobilityDB#1075 · manual MobilityDB#1078).

`tools/portable-aliases.json` is that contract, vendored **byte-identical**
so this binding is self-contained until MEOS-API folds `portableAliases`
into `meos-idl.json` (after which the catalog copy is preferred
automatically).

A bare name is **backed** when the generated symbol set contains a MEOS
function whose name `== bareName` or `startsWith(bareName + "_")`, with
`nearestApproachDistance` backed by the verified `nad_*` family
(`explicitBacking`). MEOS C already names every operator's backing
function this way, so the generated bindings expose the dialect by
construction — each portable name reuses the operator's own backing
function, never a reimplementation. No type-qualified or per-binding
forms are introduced.

### Verifying parity

```
python3 tools/portable_parity.py --check
```

Exits non-zero unless **29/29 bare names are backed, 0 unbacked**, across
all six in-scope user-facing type families — `temporal`, `geo`,
`cbuffer`, `npoint`, `pose`, `rgeo` (`cbuffer`/`npoint`/`pose`/`rgeo` are
full temporal types and are never excluded from the parity headline).
The same check runs as the `PortableAliasParityTests` MSTest case and in
the `portable-aliases parity` CI workflow.

Note: the MEOS 1.4 surface is required for full six-family coverage —
the MEOS 1.3 catalog does not expose `cbuffer`/`pose`/`rgeo` operator
functions.
