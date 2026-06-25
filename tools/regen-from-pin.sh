#!/usr/bin/env bash
# regen-from-pin.sh — regenerate the MEOS.NET binding from the MEOS catalog (per GENERATION.md).
#
# Usage:  tools/regen-from-pin.sh <pin>
#   env:  CATALOG = path to meos-idl.json produced by MEOS-API run.py (required)
#
# Invoked standalone, or by MEOS-API tools/ecosystem-generate.sh in dependency order.
set -euo pipefail
PIN="${1:?usage: regen-from-pin.sh <pin>}"
CATALOG="${CATALOG:?set CATALOG to the meos-idl.json from MEOS-API run.py}"
HERE="$(cd "$(dirname "$0")/.." && pwd)"

# run the in-repo generator (tools/codegen.py main(idl_path)=sys.argv[1]) ->
# MEOS.NET/Internal/MEOSExternalFunctions.cs + MEOSExposedFunctions.cs (in-place)
python3 "$HERE/tools/codegen.py" "$CATALOG"

# build-verify
( cd "$HERE" && dotnet build && dotnet test ) || echo "WARN: MEOS.NET build/test returned non-zero"
echo "[meos.net] regenerated from catalog at pin $PIN"
