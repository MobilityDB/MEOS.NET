using System.Runtime.InteropServices;

using MEOS.NET.Functions;
using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// A MEOS function that answers a value through one output pointer and an
    /// array through another, counted by a third, hands back the array and takes
    /// the pointer it writes the value through; where MEOS says it answers
    /// nothing, the array is null.
    /// </summary>
    [TestClass]
    public class OutputPointerTests : MeosTest
    {
        private const string Trip =
            "[POINT(1 1)@2000-01-01, POINT(2 2)@2000-01-02, POINT(3 3)@2000-01-03]";

        [TestMethod]
        public void AnMvtGeometryAnswersItsGeometryAndItsTimesInOrder()
        {
            Temporal trip = TGeomPoint.In(Trip)!;
            STBox bounds = STBox.In("STBOX XT(((0,0),(10,10)),[2000-01-01, 2000-01-04])")!;

            IntPtr geom = Marshal.AllocHGlobal(IntPtr.Size);
            try
            {
                long[]? times = Meos.TpointAsMvtgeom(trip.Ptr, bounds.Ptr, 4096, 0, true, geom);

                // The geometry is a GSERIALIZED the geometry functions read.
                StringAssert.StartsWith(Meos.GeoAsText(Marshal.ReadIntPtr(geom), 6), "LINESTRING");

                // The times are the array MEOS counted, in order.
                Assert.IsNotNull(times);
                Assert.IsTrue(times!.Length > 0, $"count was {times.Length}");
                for (int i = 1; i < times.Length; i++)
                {
                    Assert.IsTrue(times[i] > times[i - 1], $"timestamp {i} is out of order");
                }
            }
            finally
            {
                Marshal.FreeHGlobal(geom);
            }
        }

        [TestMethod]
        public void AnMvtGeometryOutsideTheTileIsNull()
        {
            // tpoint_as_mvtgeom answers false for a trip with no representation
            // in the tile, and writes neither the geometry nor the times.
            Temporal trip = TGeomPoint.In(Trip)!;
            STBox bounds = STBox.In("STBOX XT(((100,100),(110,110)),[2000-01-01, 2000-01-04])")!;

            IntPtr geom = Marshal.AllocHGlobal(IntPtr.Size);
            try
            {
                Assert.IsNull(Meos.TpointAsMvtgeom(trip.Ptr, bounds.Ptr, 4096, 0, true, geom));
            }
            finally
            {
                Marshal.FreeHGlobal(geom);
            }
        }
    }
}
