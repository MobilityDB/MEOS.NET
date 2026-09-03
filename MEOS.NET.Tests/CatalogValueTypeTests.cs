using MEOS.NET.Enums;
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
        public void AnEnumArgumentIsTheEnumTheCatalogNames()
        {
            TJsonb temp = (TJsonb)TJsonb.In(
                "[{\"a\": [1, 2]}@2024-12-06, {\"a\": [1, 2]}@2024-12-08]")!;

            Temporal? first = temp.ArrayElement(0, true, NullHandleType.NullJsonNull);

            Assert.IsNotNull(first);
        }

        [TestMethod]
        public void AScalarBehindATypedefComesBackAsThatScalar()
        {
            Geo point = Geo.FromText("POINT(1 1)", 4326)!;

            ulong cell = point.ToS2cellCell(10);

            Assert.AreNotEqual(0UL, cell);
        }

        [TestMethod]
        public void AStructReturnedByValueComesBackAsTheStruct()
        {
            TPoint trip = (TPoint)TGeomPoint.In(
                "[POINT(0 0)@2024-12-06, POINT(2 2)@2024-12-08]")!;
            STBox bounds = STBox.In("STBOX X((-1,-1),(3,3))")!;

            MvtGeom mvt = trip.AsMvtgeom(bounds, 4096, 0, true);

            Assert.AreNotEqual(IntPtr.Zero, mvt.geom);
            Assert.IsTrue(mvt.count > 0);
        }
    }
}
