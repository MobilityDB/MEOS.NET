using MEOS.NET.Structures;
using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// A MEOS struct whose layout is all scalars and that no class stands for is
    /// carried as a value: the method takes and answers the value itself rather
    /// than an address into MEOS.
    /// </summary>
    [TestClass]
    public class ValueStructTests : MeosTest
    {
        [TestMethod]
        public void ASpanAnswersItsDurationAsAnInterval()
        {
            TsTzSpan span = (TsTzSpan)TsTzSpan.In("[2024-12-06, 2024-12-08]")!;

            Interval? duration = span.Duration();

            Assert.IsNotNull(duration);
            Assert.AreEqual(2, duration!.Value.day);
            Assert.AreEqual(0, duration!.Value.month);
            Assert.AreEqual("2 days", duration.ToString());
        }

        [TestMethod]
        public void AnIntervalReadsAndWritesTheTextMeosDoes()
        {
            Interval? day = Interval.In("1 day");

            Assert.IsNotNull(day);
            Assert.AreEqual(1, day!.Value.day);
            Assert.AreEqual(0, day!.Value.time);
            Assert.AreEqual("1 day", day.ToString());
            Assert.ThrowsException<MEOS.NET.Exceptions.MEOSInternalErrorException>(
                () => Interval.In("not an interval"));
        }

        [TestMethod]
        public void ASpanIsShiftedByAnIntervalItIsGivenAsAValue()
        {
            TsTzSpan span = (TsTzSpan)TsTzSpan.In("[2024-12-06, 2024-12-08]")!;

            Span? shifted = span.ShiftScale(Interval.In("1 day")!.Value,
                                            Interval.In("4 days")!.Value);

            Assert.IsNotNull(shifted);
            Assert.AreEqual("[2024-12-07 00:00:00+00, 2024-12-11 00:00:00+00]",
                shifted!.ToString());
        }

        [TestMethod]
        public void AFrechetPathComesBackAsTheMatchesThemselves()
        {
            Temporal trip = TFloat.In("[1@2024-12-06, 3@2024-12-08]")!;
            Temporal other = TFloat.In("[2@2024-12-06, 4@2024-12-08]")!;

            Match[] path = trip.FrechetPath(other);

            // A match pairs an instant of one value with an instant of the
            // other, and MEOS walks the distance matrix back from the last pair
            // to the first, so the path arrives in that order.
            Assert.IsTrue(path.Length > 0);
            foreach (Match match in path)
            {
                Assert.IsTrue(match.i >= 0 && match.i < 2, $"i={match.i}");
                Assert.IsTrue(match.j >= 0 && match.j < 2, $"j={match.j}");
            }

            Assert.AreEqual(1, path[0].i);
            Assert.AreEqual(1, path[0].j);
            Assert.AreEqual(0, path[path.Length - 1].i);
            Assert.AreEqual(0, path[path.Length - 1].j);
        }
    }
}
