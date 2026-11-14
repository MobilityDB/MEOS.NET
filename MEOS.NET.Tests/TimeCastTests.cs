using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// The casts between the time types of .NET and those of MEOS, which convert
    /// through the MEOS conversions of the counts from the Unix epoch, as the
    /// round trips of #GeneratedObjectLayerTests reach them: a DateTime of UTC or
    /// local kind is a timestamptz, one of unspecified kind is a timestamp read in
    /// the zone of the MEOS session, as MEOS reads a timestamp without an offset,
    /// and a tick below a microsecond, which no MEOS timestamp holds, is refused.
    /// The counts are those of the MEOS bindings specification,
    /// doc/specs/meos-bindings-algebra.md of MobilityDB.
    /// </summary>
    [TestClass]
    public class TimeCastTests : MeosTest
    {
        private static DateTime StartOf(DateTime moment)
            => TFloatInst.Make(1.0, moment)!.StartTimestamptz();

        [TestMethod]
        public void UtcMomentRoundTripsToTheMicrosecond()
        {
            DateTime moment = new DateTime(2025, 3, 1, 8, 0, 0, DateTimeKind.Utc)
                .AddTicks(1234560);

            Assert.AreEqual(moment, StartOf(moment).ToUniversalTime());
        }

        [TestMethod]
        public void MomentBelowAMicrosecondIsRefused()
        {
            DateTime moment = new DateTime(2025, 3, 1, 8, 0, 0, DateTimeKind.Utc)
                .AddTicks(1234565);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => StartOf(moment));
        }

        [TestMethod]
        public void UnspecifiedMomentIsReadInTheSessionZone()
        {
            DateTime moment = new DateTime(2001, 1, 1, 0, 0, 0, DateTimeKind.Unspecified);

            Assert.AreEqual(new DateTime(2001, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                StartOf(moment).ToUniversalTime());
        }

        [TestMethod]
        public void DateRoundTrips()
        {
            DateOnly day = new DateOnly(2025, 3, 1);

            Span span = DateSpan.Make(day, day, true, true)!;

            Assert.AreEqual(day, ((DateSpan)span).Lower());
        }

        [TestMethod]
        public void LastDateOfDotNetRoundTrips()
        {
            DateOnly day = DateOnly.MaxValue;

            Span span = DateSpan.Make(day, day, true, true)!;

            Assert.AreEqual(day, ((DateSpan)span).Lower());
        }
    }
}
