#!/usr/bin/env python3
"""Portable bare-name parity gate for MEOS.NET.

The MEOS.NET analogue of MEOS-API's portable_parity.py and MobilityDB's
`tools/portable_aliases/generate.py --check`.  Per the cross-repo handoff
(MEOS-API PR #9): a binding is done when its **generated symbol set ⊇
portableAliases.bareNames**, verified with the *same prefix logic* as
MEOS-API portable_parity.py, **0 unbacked**, no per-binding exceptions,
across all six in-scope type families.

"Generated symbol set" = the P/Invoke declarations the codegen emits into
MEOS.NET/Internal/MEOSExternalFunctions.cs (the MEOS C function names the
binding actually exposes).  A bare name is *backed* iff some emitted symbol
`== bareName` or `startswith(bareName + "_")`, falling back to the verified
`explicitBacking` prefixes (e.g. `nearestApproachDistance` <- the `nad_*`
family).  This is the operator's *own* backing function reused by
construction — never reimplemented.

The portable-aliases contract is read from the catalog's folded-in
`portableAliases` when an --idl is given and carries it; otherwise from the
vendored, byte-identical SoT copy tools/portable-aliases.json (so the gate
is self-contained while upstream MEOS-API #8 is in flight).

    python3 tools/portable_parity.py            # write report
    python3 tools/portable_parity.py --check    # exit non-zero on any gap

Writes tools/portable-parity.report.json.
"""

from __future__ import annotations

import argparse
import json
import re
import sys
from pathlib import Path

REPO = Path(__file__).resolve().parent.parent
GENERATED = REPO / "MEOS.NET" / "Internal" / "MEOSExternalFunctions.cs"
VENDORED = Path(__file__).resolve().parent / "portable-aliases.json"
REPORT = Path(__file__).resolve().parent / "portable-parity.report.json"

# Full user-facing temporal type families — cbuffer/npoint/pose/rgeo are NOT
# internals and must never be excluded from the parity headline.  Precedence
# keeps the broad geo/temporal buckets from swallowing them.
IN_SCOPE_FAMILIES = ["temporal", "geo", "cbuffer", "npoint", "pose", "rgeo"]

_DECL_RE = re.compile(r"public\s+static\s+partial\s+\S+\s+([A-Za-z_]\w*)\s*\(")


def generated_symbols(cs_path: Path) -> list[str]:
    """The MEOS C function names the binding exposes (one per P/Invoke decl)."""
    return sorted(set(_DECL_RE.findall(cs_path.read_text())))


def load_portable_aliases(idl_path: str | None) -> dict:
    """Prefer the catalog's folded-in portableAliases; else the vendored SoT."""
    if idl_path:
        idl = json.loads(Path(idl_path).read_text())
        pa = idl.get("portableAliases")
        if pa and pa.get("families"):
            return pa
    return json.loads(VENDORED.read_text())


def family_of(name: str) -> str:
    n = name.lower()
    if "rgeo" in n:
        return "rgeo"
    if "cbuffer" in n:
        return "cbuffer"
    if "npoint" in n:
        return "npoint"
    if "pose" in n:
        return "pose"
    if any(t in n for t in ("geo", "geom", "geog", "point", "spatial")):
        return "geo"
    return "temporal"


def build_parity(symbols: list[str], pa: dict) -> dict:
    fam_of = {p["bareName"]: (fam, p["operator"])
              for fam, lst in pa["families"].items() for p in lst}
    explicit = pa.get("explicitBacking", {})

    def matches(prefix: str) -> list[str]:
        return [s for s in symbols
                if s == prefix or s.startswith(prefix + "_")]

    by_bare: dict[str, dict] = {}
    fam_totals: dict[str, int] = {f: 0 for f in IN_SCOPE_FAMILIES}
    for bare, (fam, op) in sorted(fam_of.items()):
        hits, via = matches(bare), "prefix"
        if not hits:
            for pref in explicit.get(bare, []):
                hits += matches(pref)
            via = ("explicit:" + ",".join(explicit.get(bare, []))
                   if hits else None)
        hist: dict[str, int] = {}
        for h in hits:
            k = family_of(h)
            hist[k] = hist.get(k, 0) + 1
            fam_totals[k] = fam_totals.get(k, 0) + 1
        by_bare[bare] = {
            "operator": op, "family": fam, "via": via,
            "backedBy": len(hits), "sample": sorted(hits)[:3],
            "familyCoverage": hist,
            "status": "backed" if hits else "needs-explicit-backing",
        }

    backed = [b for b, v in by_bare.items() if v["status"] == "backed"]
    unbacked = sorted(b for b, v in by_bare.items()
                      if v["status"] == "needs-explicit-backing")
    missing_fams = [f for f in IN_SCOPE_FAMILIES if fam_totals.get(f, 0) == 0]
    total = len(by_bare)
    return {
        "generatedSymbols": len(symbols),
        "total": total,
        "backed": len(backed),
        "needsExplicitBacking": len(unbacked),
        "parityPct": round(len(backed) * 100 / total, 1) if total else 0,
        "unbacked": unbacked,
        "familyCoverage": fam_totals,
        "missingFamilies": missing_fams,
        "byBareName": by_bare,
        "provenance": pa.get("provenance", {}),
        "scope": pa.get("scope", {}),
    }


def main() -> int:
    ap = argparse.ArgumentParser(description=__doc__)
    ap.add_argument("--idl", metavar="meos-idl.json", default=None,
                    help="catalog to read portableAliases from "
                         "(default: vendored tools/portable-aliases.json)")
    ap.add_argument("--generated", default=str(GENERATED),
                    help="generated P/Invoke file to audit")
    ap.add_argument("--check", action="store_true",
                    help="exit non-zero if any bare name is unbacked or any "
                         "in-scope family is uncovered (CI gate)")
    args = ap.parse_args()

    symbols = generated_symbols(Path(args.generated))
    pa = load_portable_aliases(args.idl)
    rep = build_parity(symbols, pa)
    REPORT.write_text(json.dumps(rep, indent=2) + "\n")

    src = ("idl.portableAliases" if args.idl
           and json.loads(Path(args.idl).read_text())
           .get("portableAliases", {}).get("families")
           else "vendored tools/portable-aliases.json")
    print(f"[portable-parity] {rep['backed']}/{rep['total']} bare names "
          f"backed in the generated .NET symbol set ({rep['parityPct']}%); "
          f"{rep['needsExplicitBacking']} unbacked [contract: {src}]",
          file=sys.stderr)
    print(f"[portable-parity] six-family coverage "
          f"{rep['familyCoverage']} -> {REPORT}", file=sys.stderr)
    for b in rep["unbacked"]:
        v = rep["byBareName"][b]
        print(f"  needs-explicit-backing: {b!r} ({v['operator']}, "
              f"{v['family']})", file=sys.stderr)

    fail = bool(rep["unbacked"] or rep["missingFamilies"])
    if args.check:
        if rep["missingFamilies"]:
            print("  uncovered in-scope families: "
                  f"{rep['missingFamilies']}", file=sys.stderr)
        verdict = ("FAIL" if fail else
                   f"PASS — {rep['backed']}/{rep['total']} = 100%, "
                   "0 unbacked, all six families covered")
        print(f"CHECK: {verdict}", file=sys.stderr)
        return 1 if fail else 0
    return 0


if __name__ == "__main__":
    sys.exit(main())
