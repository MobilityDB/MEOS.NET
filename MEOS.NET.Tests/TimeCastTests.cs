using MEOS.NET.Functions;
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

        [TestMethod]
        public void IntervalOfDaysAndTimeIsATimeSpan()
        {
            IntPtr interval = Meos.IntervalIn("2 days 03:00:00.5", -1);

            Assert.AreEqual(new TimeSpan(2, 3, 0, 0, 500), MEOSConvert.ToTimeSpan(interval));
        }

        [TestMethod]
        public void TimeSpanIsAnIntervalOfWholeDaysAndTheRest()
        {
            IntPtr interval = MEOSConvert.ToInterval(TimeSpan.FromHours(36));

            Assert.AreEqual("1 day 12:00:00", Meos.IntervalOut(interval));
        }

        [TestMethod]
        public void IntervalWithMonthsIsRefused()
        {
            IntPtr interval = Meos.IntervalIn("1 mon 2 days", -1);

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => MEOSConvert.ToTimeSpan(interval));
        }

        [TestMethod]
        public void TimeRoundTripsAsATimeOnly()
        {
            long time = Meos.TimeIn("13:45:30.5", -1);

            TimeOnly clock = MEOSConvert.ToTimeOnly(time);

            Assert.AreEqual(new TimeOnly(13, 45, 30, 500), clock);
            Assert.AreEqual("13:45:30.5", Meos.TimeOut(MEOSConvert.ToTimeADT(clock)));
        }

        [TestMethod]
        public void EndOfDayIsRefusedByATimeOnly()
        {
            long time = Meos.TimeIn("24:00:00", -1);

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => MEOSConvert.ToTimeOnly(time));
        }

        [TestMethod]
        public void TimeWithTimeZoneRoundTripsAsATimeAndItsOffset()
        {
            IntPtr timetz = Meos.TimetzIn("13:45:30+02", -1);

            (TimeOnly Time, TimeSpan Offset) parts = MEOSConvert.ToTimeWithOffset(timetz);

            Assert.AreEqual(new TimeOnly(13, 45, 30), parts.Time);
            Assert.AreEqual(TimeSpan.FromHours(2), parts.Offset);
            Assert.AreEqual("13:45:30+02", Meos.TimetzOut(MEOSConvert.ToTimetzADT(parts)));
        }
    }
}
