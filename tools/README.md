# MEOS.NET binding regen via MEOS-API

`codegen.py` regenerates `MEOS.NET/Functions/` from MobilityDB/MEOS-API's
unified `meos-idl.json` catalog: the public `MEOS.NET.Functions.Meos` class,
one file per MEOS header exactly as the catalog groups the declarations, plus
`Meos.Native.g.cs` with the P/Invoke declarations behind them. A method is the
C name in PascalCase — `tfloat_in` reads `TfloatIn`, `meos_initialize` reads
`MeosInitialize` — the spelling GoMEOS exports, so one rule serves the
ecosystem rather than a per-binding invention.

`objectgen.py` regenerates `MEOS.NET/Types/*.g.cs` — the object layer —
and the error taxonomy under `MEOS.NET/Errors/` and `MEOS.NET/Exceptions/`,
from the same catalog's `objectModel`, which is the ecosystem-wide
source of truth for the class hierarchy implicit in MEOS.

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

2. Run the generators from this repo:
   ```
   python3 tools/codegen.py /path/to/meos-idl.json
   python3 tools/objectgen.py /path/to/meos-idl.json --report
   ```

`MEOS.NET/Functions/` is rewritten with a binding for every MEOS function in
the catalog, and
`MEOS.NET/Types/` is rewritten with one class per object-model class. `--report` lists, per class, every method the object layer leaves
to the raw binding and why.

## DllPath

`DllPath` defaults to the bare name `"meos"` so the OS loader resolves it
via `LD_LIBRARY_PATH` (Linux), `DYLD_LIBRARY_PATH` (macOS), or `PATH`
(Windows). No hardcoded developer paths. Override it without editing the
generator:

```
python3 tools/codegen.py /path/to/meos-idl.json --dll-path libmeos.so.1
```

## The object layer

One C# class per `objectModel.classes` entry, inheriting along the model's
own parent edges: the temporal lattice under `Temporal`, the `Set`/`Span`/
`SpanSet` collections under `Collection`, and `TBox`/`STBox` under `Box`. A
concrete class is the product leaf x subtype — `TFloatSeq`, `TGeomPointInst`
— and inherits its leaf, which carries the larger surface.

Every method delegates to the `MEOSExposedFunctions` wrapper of the function
the model assigns it, reading that wrapper's signature from `codegen.py` so
the two generators cannot disagree about a folded out-parameter. A returned
MEOS pointer goes through `MEOSFactory`, which reads the discriminator the
catalog's own struct layout puts in the value's header — `Temporal.temptype`
and `Temporal.subtype`, `Set.settype`, `Span.spantype`,
`SpanSet.spansettype` — and hands back the exact class. Every temporal
struct starts with the Temporal header, so a `TInstant *` or `TSequence *`
return is a `Temporal` at the surface whose runtime class is the concrete
one.

A method whose marshalling the layer does not emit — a `GSERIALIZED *`
geometry, an `Interval *`, a counted array argument, a scalar
out-parameter — is reported by `--report` and left to the raw binding, which
carries every function either way.

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
