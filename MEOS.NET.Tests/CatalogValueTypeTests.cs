using MEOS.NET.Structures;
using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// Whatever the wrapper already states as a C# value — an enum the catalog
    /// names, a struct carried by value — the object layer hands on as that
    /// value, and a scalar behind a typedef the catalog gives a class held by
    /// value comes back as that class.
    /// </summary>
    [TestClass]
    public class CatalogValueTypeTests : MeosTest
    {
        [TestMethod]
        public void AnEnumArgumentIsTheTextMeosReadsThroughItsPair()
        {
            TJsonb temp = (TJsonb)TJsonb.FromText(
                "[{\"a\": [1, 2]}@2024-12-06, {\"a\": [1, 2]}@2024-12-08]")!;

            // The handling of a SQL NULL is passed as the SQL functions take it,
            // as text, which nullhandletype_from_string reads.
            Temporal? first = temp.ArrayElement(0, "use_json_null");

            Assert.IsNotNull(first);
        }

        [TestMethod]
        public void AScalarBehindACellTypedefComesBackAsItsClass()
        {
            Geo point = Geo.FromText("POINT(1 1)", 4326)!;

            S2Cell cell = point.ToS2cellCell(10);

            Assert.AreNotEqual(0UL, (ulong)cell);
            Assert.AreEqual(10u, cell.GetResolution());
        }
    }
}
