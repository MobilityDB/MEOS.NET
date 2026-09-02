using System.Runtime.InteropServices;

using MEOS.NET.Functions;
using MEOS.NET.Structures;
using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// The three MEOS functions that hand a struct back by value. A struct return
    /// is not a pointer — the ABI passes it in registers or through a hidden
    /// pointer the caller supplies — so a field read out of one is only the field
    /// MEOS filled when the return is declared as the struct it is.
    /// </summary>
    [TestClass]
    public class ByValueStructTests : MeosTest
    {
        private const string Trip =
            "[POINT(1 1)@2000-01-01, POINT(2 2)@2000-01-02, POINT(3 3)@2000-01-03]";

        [TestMethod]
        public void EveryFieldOfAnMvtGeomIsTheOneMeosFilled()
        {
            Temporal trip = TGeomPoint.In(Trip)!;
            STBox bounds = STBox.In("STBOX XT(((0,0),(10,10)),[2000-01-01, 2000-01-04])")!;

            MvtGeom mvt = Meos.TpointAsMvtgeom(trip.Ptr, bounds.Ptr, 4096, 0, true);

            // The geometry field is a GSERIALIZED the geometry functions read.
            StringAssert.StartsWith(Meos.GeoAsText(mvt.geom, 6), "LINESTRING");

            // The times field is an array of exactly count timestamps, in order.
            Assert.IsTrue(mvt.count > 0, $"count was {mvt.count}");
            long previous = long.MinValue;
            for (int i = 0; i < mvt.count; i++)
            {
                long moment = Marshal.ReadInt64(mvt.times, i * sizeof(long));
                Assert.IsTrue(moment > previous, $"timestamp {i} is out of order");
                previous = moment;
            }
        }

        [TestMethod]
        public void EveryFieldOfASpaceSplitIsTheOneMeosFilled()
        {
            Temporal trip = TGeomPoint.In(Trip)!;
            IntPtr origin = Meos.GeomIn("POINT(0 0)", -1);

            SpaceSplit split = Meos.TgeoSpaceSplit(
                trip.Ptr, 2.0, 2.0, 2.0, origin, false, true);

            Assert.IsTrue(split.count > 0, $"count was {split.count}");
            for (int i = 0; i < split.count; i++)
            {
                IntPtr fragment = Marshal.ReadIntPtr(split.fragments, i * IntPtr.Size);
                IntPtr bin = Marshal.ReadIntPtr(split.bins, i * IntPtr.Size);

                // Each fragment is a temporal point and each bin the geometry it
                // falls in, so both read back through their own MEOS functions.
                StringAssert.Contains(Meos.TspatialAsText(fragment, 6), "POINT");
                StringAssert.StartsWith(Meos.GeoAsText(bin, 6), "POINT");
            }
        }
    }
}
