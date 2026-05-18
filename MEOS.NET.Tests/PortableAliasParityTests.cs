using System.Text.Json;
using System.Text.RegularExpressions;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// Portable bare-name parity gate (RFC #920; MEOS-API cross-repo handoff
    /// PR #9). A binding is done when its <b>generated symbol set ⊇
    /// portableAliases.bareNames</b>, verified with the same prefix logic as
    /// MEOS-API portable_parity.py — a bare name is backed iff some emitted
    /// MEOS symbol <c>== bareName</c> or <c>startsWith(bareName + "_")</c>,
    /// falling back to the verified <c>explicitBacking</c> prefixes
    /// (<c>nearestApproachDistance</c> ← the <c>nad_*</c> family). 0 unbacked,
    /// no per-binding exceptions, across all six in-scope type families
    /// (cbuffer/npoint/pose/rgeo are full user-facing types — never excluded
    /// from the parity headline). This is the C# mirror of
    /// tools/portable_parity.py, so the verdict is identical and
    /// language-independent.
    /// </summary>
    [TestClass]
    public class PortableAliasParityTests
    {
        private static readonly string[] InScopeFamilies =
            { "temporal", "geo", "cbuffer", "npoint", "pose", "rgeo" };

        private static string RepoRoot()
        {
            var dir = new DirectoryInfo(AppContext.BaseDirectory);
            while (dir is not null &&
                   !File.Exists(Path.Combine(dir.FullName, "MEOS.NET.sln")))
                dir = dir.Parent;
            Assert.IsNotNull(dir, "Could not locate repo root (MEOS.NET.sln).");
            return dir!.FullName;
        }

        private static HashSet<string> GeneratedSymbols(string repo)
        {
            var cs = Path.Combine(repo, "MEOS.NET", "Internal",
                                  "MEOSExternalFunctions.cs");
            Assert.IsTrue(File.Exists(cs),
                $"Generated bindings missing: {cs}");
            var rx = new Regex(@"public\s+static\s+partial\s+\S+\s+([A-Za-z_]\w*)\s*\(");
            return rx.Matches(File.ReadAllText(cs))
                     .Select(m => m.Groups[1].Value)
                     .ToHashSet(StringComparer.Ordinal);
        }

        private static (List<(string op, string bare, string fam)> pairs,
                        Dictionary<string, string[]> explicitBacking)
            Contract(string repo)
        {
            var json = Path.Combine(repo, "tools", "portable-aliases.json");
            Assert.IsTrue(File.Exists(json),
                $"Vendored portable-aliases SoT missing: {json}");
            using var doc = JsonDocument.Parse(File.ReadAllText(json));
            var root = doc.RootElement;

            var pairs = new List<(string, string, string)>();
            foreach (var fam in root.GetProperty("families").EnumerateObject())
                foreach (var e in fam.Value.EnumerateArray())
                    pairs.Add((e.GetProperty("operator").GetString()!,
                               e.GetProperty("bareName").GetString()!,
                               fam.Name));

            var explicitBacking = new Dictionary<string, string[]>();
            if (root.TryGetProperty("explicitBacking", out var eb))
                foreach (var p in eb.EnumerateObject())
                    explicitBacking[p.Name] =
                        p.Value.EnumerateArray()
                               .Select(x => x.GetString()!).ToArray();

            return (pairs, explicitBacking);
        }

        private static List<string> Backing(string bare,
            HashSet<string> symbols, Dictionary<string, string[]> explicitBacking)
        {
            bool M(string s, string p) => s == p || s.StartsWith(p + "_",
                StringComparison.Ordinal);
            var hits = symbols.Where(s => M(s, bare)).ToList();
            if (hits.Count == 0 &&
                explicitBacking.TryGetValue(bare, out var prefixes))
                foreach (var pref in prefixes)
                    hits.AddRange(symbols.Where(s => M(s, pref)));
            return hits;
        }

        private static string FamilyOf(string name)
        {
            var n = name.ToLowerInvariant();
            if (n.Contains("rgeo")) return "rgeo";
            if (n.Contains("cbuffer")) return "cbuffer";
            if (n.Contains("npoint")) return "npoint";
            if (n.Contains("pose")) return "pose";
            if (n.Contains("geo") || n.Contains("geom") || n.Contains("geog")
                || n.Contains("point") || n.Contains("spatial")) return "geo";
            return "temporal";
        }

        [TestMethod]
        public void GeneratedApi_Superset_Of_PortableBareNames_ZeroUnbacked()
        {
            var repo = RepoRoot();
            var symbols = GeneratedSymbols(repo);
            var (pairs, explicitBacking) = Contract(repo);

            Assert.AreEqual(29, pairs.Count,
                "The canonical contract must carry exactly 29 operator→bareName pairs.");

            var unbacked = new List<string>();
            var famTotals = InScopeFamilies.ToDictionary(f => f, _ => 0);
            foreach (var (op, bare, fam) in pairs)
            {
                var hits = Backing(bare, symbols, explicitBacking);
                if (hits.Count == 0) { unbacked.Add($"{bare} ({op}, {fam})"); continue; }
                foreach (var h in hits)
                {
                    var k = FamilyOf(h);
                    if (famTotals.ContainsKey(k)) famTotals[k]++;
                }
            }

            Assert.AreEqual(0, unbacked.Count,
                "Unbacked canonical bare names (generated symbol set must be a "
                + "superset, 0 unbacked): " + string.Join(", ", unbacked));

            var missing = InScopeFamilies.Where(f => famTotals[f] == 0).ToList();
            Assert.AreEqual(0, missing.Count,
                "In-scope user-facing families absent from the generated binding "
                + "(cbuffer/npoint/pose/rgeo are never excluded from the parity "
                + "headline): " + string.Join(", ", missing)
                + ". Coverage: "
                + string.Join(", ", famTotals.Select(kv => $"{kv.Key}={kv.Value}")));
        }
    }
}
