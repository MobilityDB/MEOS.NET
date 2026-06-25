# MEOS.NET generation — the canonical per-binding generator policy

MEOS.NET is a **generated** .NET/C# binding. This document is the contract for how it is
generated, under the ecosystem-wide per-binding generator policy.

## The policy (ecosystem-wide)

Every MobilityDB language binding is a **pure projection of the MEOS-API catalog**, and
**each binding owns its own generator, in its own repo**, in a canonical layout — not a
single central generator-repo. The single source of truth is the **catalog**
(`MEOS-API/output/meos-idl.json`, generated from the MEOS C headers), not a generator
location. This mirrors how MEOS itself is built: independent, plug-and-play, CMake-gated
families — a binding is an independent module that owns its generation.

Each binding repo satisfies the same invariants:

1. **In-repo generator**, one clearly-designated location. For MEOS.NET that is
   **`tools/codegen.py`** — it reads the vendored catalog and emits the P/Invoke layer.
2. **Own pin manifest** `tools/pin/compose-order.txt` — the canonical, dependency-ordered
   fold list of the open PRs that compose this binding's surface onto `main`.
3. **Vendored catalog**, version-pinned, read-only: `meos-idl.json` (from a MobilityDB
   `ecosystem-pin-*`).
4. **Thin language projection** — language-neutral decisions (grouping, skip/classify,
   portable names, shape) belong upstream in the catalog, so per-language generators do
   not re-implement and drift.
5. **Full automation (North Star):** generate-then-retire toward a **zero hand-written**
   surface; anything that seems irreducible is either emitted by the generator or fixed at
   source in MEOS (export the symbol) — never hand-patched in the binding.

## MEOS.NET scope: generated P/Invoke + exposed wrappers

`tools/codegen.py` emits, in-place, `MEOS.NET/Internal/MEOSExternalFunctions.cs` (the
P/Invoke `extern` declarations) and `MEOSExposedFunctions.cs` (the exposed wrappers, with
`SafeExecution` error handling). This replaces the regex-based `MEOS.NET.Builder`.

## Generate-then-retire — the green-CI version is the probe

Removing the hand-written / regex-built surface happens **little by little, never
wipe-first**:

1. align the generator + generate the full surface; the solution builds green;
2. **prove generated ⊇ hand** against the **last green-CI version** (the equivalence
   probe) — tests + parity, **family by family**;
3. retire the corresponding `MEOS.NET.Builder` path for that family;
4. repeat. End state: `MEOS.NET.Builder` is gone; the binding is the generated P/Invoke
   layer. The green-CI baseline catches a generated gap before it ships.

## Pinning: this binding's catalog comes from a MobilityDB pin

MEOS.NET's vendored `meos-idl.json` is generated from a MobilityDB `ecosystem-pin-*`
(master ⊕ the MobilityDB compose-order) via the MEOS-API `run.py`. That pin is the
*catalog/surface* input; MEOS.NET's own `tools/pin/compose-order.txt` governs *this repo's*
PR accumulate. See `tools/pin/compose-order.txt` for the composing set and the disposition
of every open PR.
