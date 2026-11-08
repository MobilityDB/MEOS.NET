using MEOS.NET.Structures;
using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// Whatever the wrapper already states as a C# value — an enum the catalog
    /// names, a scalar behind a MEOS typedef, a struct carried by value — the
    /// object layer hands on as that value.
    /// </summary>
    [TestClass]
    public class CatalogValueTypeTests : MeosTest
    {
        [TestMethod]
        public void AnEnumArgumentIsTheTextMeosReadsThroughItsPair()
        {
            TJsonb temp = (TJsonb)TJsonb.In(
                "[{\"a\": [1, 2]}@2024-12-06, {\"a\": [1, 2]}@2024-12-08]")!;

            // The handling of a SQL NULL is passed as the SQL functions take it,
            // as text, which nullhandletype_from_string reads.
            Temporal? first = temp.ArrayElement(0, "use_json_null");

            Assert.IsNotNull(first);
        }

        [TestMethod]
        public void AScalarBehindATypedefComesBackAsThatScalar()
        {
            Geo point = Geo.FromText("POINT(1 1)", 4326)!;

            ulong cell = point.ToS2cellCell(10);

            Assert.AreNotEqual(0UL, cell);
        }
    }
}
