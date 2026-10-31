using MEOS.NET.Functions;
using MEOS.NET.Structures;
using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// A call that answers several values answers them together, so the method
    /// answers a tuple and the call is made once — the halves of one answer
    /// come from one call.
    /// </summary>
    [TestClass]
    public class MultipleAnswerTests : MeosTest
    {
        private const string Trip =
            "[POINT(1 1)@2000-01-01, POINT(2 2)@2000-01-02, POINT(3 3)@2000-01-03]";

        [TestMethod]
        public void SplittingByTimeAnswersThePiecesAndTheirBins()
        {
            Temporal trip = TFloat.In(
                "[1@2024-12-06, 2@2024-12-07, 3@2024-12-08]")!;

            (Temporal?[] pieces, DateTime[] bins) = trip.TimeSplit(
                Interval.In("1 day")!.Value,
                new DateTime(2024, 12, 6, 0, 0, 0, DateTimeKind.Utc),
                true);

            Assert.AreEqual(pieces.Length, bins.Length);
            Assert.IsTrue(pieces.Length > 1);
            Assert.AreEqual(new DateTime(2024, 12, 6, 0, 0, 0, DateTimeKind.Utc),
                bins[0]);
        }

        [TestMethod]
        public void SplittingBySpaceAnswersThePiecesAndTheirBins()
        {
            Temporal trip = TGeomPoint.In(Trip)!;
            IntPtr origin = Meos.GeomIn("POINT(0 0)", -1);

            (IntPtr[] fragments, IntPtr[] bins) = Meos.TgeoSpaceSplit(
                trip.Ptr, 2.0, 2.0, 2.0, origin, false, true);

            Assert.AreEqual(fragments.Length, bins.Length);
            Assert.IsTrue(fragments.Length > 0, $"count was {fragments.Length}");
            for (int i = 0; i < fragments.Length; i++)
            {
                // Each fragment is a temporal point and each bin the geometry it
                // falls in, so both read back through their own MEOS functions.
                StringAssert.Contains(Meos.TspatialAsText(fragments[i], 6), "POINT");
                StringAssert.StartsWith(Meos.GeoAsText(bins[i], 6), "POINT");
            }
        }

        [TestMethod]
        public void EachAnswersTheKeysAndTheirValues()
        {
            Jsonb jb = Jsonb.In("{\"a\": 1, \"b\": \"two\"}")!;

            (IntPtr[] keys, IntPtr[] values) = Meos.JsonbEach(jb.Ptr);

            Assert.AreEqual(2, keys.Length);
            Assert.AreEqual(keys.Length, values.Length);
            Assert.AreEqual("a", Meos.TextOut(keys[0]));
            Assert.AreEqual("b", Meos.TextOut(keys[1]));
            Assert.AreEqual("1", Meos.JsonbOut(values[0]));
            Assert.AreEqual("\"two\"", Meos.JsonbOut(values[1]));
        }
    }
}
