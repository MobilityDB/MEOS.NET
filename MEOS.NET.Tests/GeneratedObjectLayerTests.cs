using MEOS.NET.Exceptions;
using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// The object layer generated from the catalog's object model: that a MEOS
    /// pointer arrives wrapped in the class its own header names, that the values
    /// crossing the boundary are the values MEOS holds, and that a MEOS error
    /// reaches the caller as an exception rather than a null.
    /// </summary>
    [TestClass]
    public class GeneratedObjectLayerTests : MeosTest
    {
        private const string Instant = "25.0@2024-12-06";
        private const string Sequence = "[25.0@2024-12-06, 27.0@2024-12-07]";
        private const string SpanSetText = "{[8, 10], [11, 12]}";

        [TestMethod]
        public void InstantTextGivesTheConcreteInstantClass()
        {
            Temporal? temp = TFloat.In(Instant);

            Assert.IsInstanceOfType(temp, typeof(TFloatInst));
        }

        [TestMethod]
        public void SequenceTextGivesTheConcreteSequenceClass()
        {
            Temporal? temp = TFloat.In(Sequence);

            Assert.IsInstanceOfType(temp, typeof(TFloatSeq));
        }

        [TestMethod]
        public void SequenceHoldsItsTwoInstants()
        {
            Temporal temp = TFloat.In(Sequence)!;

            Assert.AreEqual(2, temp.NumInstants());
            Assert.AreEqual("Linear", temp.Interp());
        }

        [TestMethod]
        public void StartTimestamptzIsTheMomentTheTextNames()
        {
            Temporal temp = TFloat.In(Sequence)!;

            Assert.AreEqual(new DateTime(2024, 12, 6, 0, 0, 0, DateTimeKind.Utc),
                temp.StartTimestamptz().ToUniversalTime());
        }

        [TestMethod]
        public void RestrictingToAnInstantGivesThatInstant()
        {
            Temporal temp = TFloat.In(Sequence)!;
            DateTime start = temp.StartTimestamptz();

            Temporal? at = temp.AtTimestamptz(start);

            Assert.IsInstanceOfType(at, typeof(TFloatInst));
            Assert.AreEqual(1, at!.NumInstants());
        }

        [TestMethod]
        public void ValueSpanOfTheSequenceIsItsFloatExtent()
        {
            TNumber temp = (TNumber)TFloat.In(Sequence)!;

            Span span = temp.ToSpan()!;

            Assert.IsInstanceOfType(span, typeof(FloatSpan));
            Assert.AreEqual(25.0, ((FloatSpan)span).Lower());
            Assert.AreEqual(27.0, ((FloatSpan)span).Upper());
        }

        [TestMethod]
        public void SpanSetTextGivesTheConcreteFloatSpanSet()
        {
            SpanSet? spanset = FloatSpanSet.In(SpanSetText);

            Assert.IsInstanceOfType(spanset, typeof(FloatSpanSet));
            Assert.AreEqual(2, spanset!.NumSpans());
        }

        [TestMethod]
        public void EachSpanOfTheSetIsTheSpanTheTextNames()
        {
            SpanSet spanset = FloatSpanSet.In(SpanSetText)!;

            Span?[] spans = spanset.Spanarr();

            Assert.AreEqual(2, spans.Length);
            Assert.AreEqual(8.0, ((FloatSpan)spans[0]!).Lower());
            Assert.AreEqual(10.0, ((FloatSpan)spans[0]!).Upper());
            Assert.AreEqual(11.0, ((FloatSpan)spans[1]!).Lower());
            Assert.AreEqual(12.0, ((FloatSpan)spans[1]!).Upper());
        }

        [TestMethod]
        public void SpanTextIsWhatTheSpanHolds()
        {
            SpanSet spanset = FloatSpanSet.In(SpanSetText)!;

            Assert.AreEqual("[8, 10]", ((FloatSpan)spanset.StartSpan()!).Out(15));
            Assert.AreEqual("[11, 12]", ((FloatSpan)spanset.EndSpan()!).Out(15));
        }

        [TestMethod]
        public void TimeDomainOfTheSequenceIsATstzSpanSet()
        {
            Temporal temp = TFloat.In(Sequence)!;

            SpanSet time = temp.Time()!;

            Assert.IsInstanceOfType(time, typeof(TsTzSpanSet));
            Assert.AreEqual(1, time.NumSpans());
        }

        [TestMethod]
        public void MakingAnInstantFromAValueAndAMomentReadsBack()
        {
            DateTime moment = new DateTime(2024, 12, 6, 9, 30, 0, DateTimeKind.Utc);

            Temporal instant = TFloatInst.Make(25.0, moment)!;

            Assert.IsInstanceOfType(instant, typeof(TFloatInst));
            Assert.AreEqual(moment, instant.StartTimestamptz().ToUniversalTime());
        }

        [TestMethod]
        public void MalformedTextRaisesTheMeosError()
        {
            MEOSException raised = Assert.ThrowsException<MEOSInternalErrorException>(
                () => TFloat.In("e" + Instant));

            StringAssert.Contains(raised.Message, "e25.0");
        }
    }
}
