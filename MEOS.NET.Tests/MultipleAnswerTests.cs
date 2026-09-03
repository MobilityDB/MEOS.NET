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
        [TestMethod]
        public void SplittingByTimeAnswersThePiecesAndTheirBins()
        {
            Temporal trip = TFloat.In(
                "[1@2024-12-06, 2@2024-12-07, 3@2024-12-08]")!;

            (Temporal?[] pieces, DateTime[] bins) = trip.TimeSplit(
                Interval.In("1 day")!.Value,
                new DateTime(2024, 12, 6, 0, 0, 0, DateTimeKind.Utc));

            Assert.AreEqual(pieces.Length, bins.Length);
            Assert.IsTrue(pieces.Length > 1);
            Assert.AreEqual(new DateTime(2024, 12, 6, 0, 0, 0, DateTimeKind.Utc),
                bins[0]);
        }
    }
}
