using MEOS.NET.Functions;
using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// A MEOS function that answers a value and writes an array beside it,
    /// counted through another pointer, hands back both; where MEOS answers
    /// NULL, the pair is null.
    /// </summary>
    [TestClass]
    public class OutputPointerTests : MeosTest
    {
        private const string Trip =
            "[POINT(1 1)@2000-01-01, POINT(2 2)@2000-01-02, POINT(3 3)@2000-01-03]";

        [TestMethod]
        public void AnMvtGeometryAnswersItsGeometryAndItsTimesInOrder()
        {
            TPoint trip = (TPoint)TGeomPoint.In(Trip)!;
            STBox bounds = STBox.In("STBOX XT(((0,0),(10,10)),[2000-01-01, 2000-01-04])")!;

            (Geo? geom, long[] times)? answer = trip.AsMVTGeom(bounds, 4096, 0, true);

            Assert.IsNotNull(answer);
            // The geometry is a GSERIALIZED the geometry functions read.
            Assert.IsNotNull(answer!.Value.geom);
            StringAssert.StartsWith(Meos.GeoAsText(answer.Value.geom!.Ptr, 6), "LINESTRING");

            // The times are the array MEOS counted, in order.
            long[] times = answer.Value.times;
            Assert.IsTrue(times.Length > 0, $"count was {times.Length}");
            for (int i = 1; i < times.Length; i++)
            {
                Assert.IsTrue(times[i] > times[i - 1], $"timestamp {i} is out of order");
            }
        }

        [TestMethod]
        public void AnMvtGeometryOutsideTheTileIsNull()
        {
            // tpoint_as_mvtgeom answers NULL for a trip with no representation
            // in the tile, and writes no times.
            TPoint trip = (TPoint)TGeomPoint.In(Trip)!;
            STBox bounds = STBox.In("STBOX XT(((100,100),(110,110)),[2000-01-01, 2000-01-04])")!;

            Assert.IsNull(trip.AsMVTGeom(bounds, 4096, 0, true));
        }
    }
}
