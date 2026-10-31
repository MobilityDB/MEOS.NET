using System.Runtime.InteropServices;

using MEOS.NET.Functions;
using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// A MEOS function that answers through output pointers the catalog gives no
    /// length for is passed through as it is declared: the caller hands it the
    /// pointers and reads back what MEOS wrote through each.
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
            IntPtr times = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                Assert.IsTrue(Meos.TpointAsMvtgeom(trip.Ptr, bounds.Ptr, 4096, 0, true,
                    geom, times, count));

                // The geometry is a GSERIALIZED the geometry functions read.
                StringAssert.StartsWith(Meos.GeoAsText(Marshal.ReadIntPtr(geom), 6), "LINESTRING");

                // The times are an array of exactly count timestamps, in order.
                int n = Marshal.ReadInt32(count);
                Assert.IsTrue(n > 0, $"count was {n}");
                IntPtr moments = Marshal.ReadIntPtr(times);
                long previous = long.MinValue;
                for (int i = 0; i < n; i++)
                {
                    long moment = Marshal.ReadInt64(moments, i * sizeof(long));
                    Assert.IsTrue(moment > previous, $"timestamp {i} is out of order");
                    previous = moment;
                }
            }
            finally
            {
                Marshal.FreeHGlobal(geom);
                Marshal.FreeHGlobal(times);
                Marshal.FreeHGlobal(count);
            }
        }
    }
}
