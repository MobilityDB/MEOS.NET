using MEOS.NET.Enums;
using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// MEOS reads an array of its own values through a pointer to the first
    /// element and a count, so a method taking one takes a C# array and answers
    /// its length to MEOS.
    /// </summary>
    [TestClass]
    public class CountedArrayTests : MeosTest
    {
        [TestMethod]
        public void ASequenceIsMadeOfItsInstants()
        {
            Temporal[] instants =
            [
                TFloat.In("25.0@2024-12-06")!,
                TFloat.In("27.0@2024-12-07")!,
                TFloat.In("30.0@2024-12-09")!,
            ];

            Temporal sequence = TSequence.Make(instants, true, true, InterpType.Linear, true)!;

            Assert.AreEqual(3, sequence.NumInstants());
            Assert.AreEqual(
                "[25@2024-12-06 00:00:00+00, 27@2024-12-07 00:00:00+00, 30@2024-12-09 00:00:00+00]",
                sequence.ToString());
        }

        [TestMethod]
        public void ASpanSetIsMadeOfItsSpans()
        {
            // spanset_make reads its spans as Span values one after another, not
            // as pointers to them.
            Span[] spans =
            [
                FloatSpan.In("[1.0, 2.0]")!,
                FloatSpan.In("[3.0, 4.0]")!,
            ];

            SpanSet set = SpanSet.Make(spans)!;

            Assert.IsInstanceOfType(set, typeof(FloatSpanSet));
            Assert.AreEqual("{[1, 2], [3, 4]}", set.ToString());
        }

        [TestMethod]
        public void ACbufferSetIsMadeOfItsCircularBuffers()
        {
            // cbufferset_make reads its buffers as Cbuffer values one after
            // another.
            Cbuffer[] values =
            [
                Cbuffer.In("Cbuffer(Point(1 1),0.5)")!,
                Cbuffer.In("Cbuffer(Point(2 2),1.5)")!,
            ];

            Set set = CbufferSet.Make(values)!;

            Assert.AreEqual(2, set.NumValues());
            Assert.AreEqual(
                "{\"Cbuffer(POINT(1 1),0.5)\", \"Cbuffer(POINT(2 2),1.5)\"}", set.ToString());
        }

        [TestMethod]
        public void MergingAnArrayOfTemporalValuesJoinsThem()
        {
            Temporal[] parts =
            [
                TFloat.In("[25.0@2024-12-06, 27.0@2024-12-07]")!,
                TFloat.In("[30.0@2024-12-09, 32.0@2024-12-10]")!,
            ];

            Temporal merged = Temporal.MergeArray(parts)!;

            Assert.AreEqual(4, merged.NumInstants());
            Assert.AreEqual(2, merged.NumSequences());
        }

        [TestMethod]
        public void AnEmptyArrayIsARequestMeosRefuses()
        {
            Assert.ThrowsException<MEOS.NET.Exceptions.MEOSInvalidArgValueException>(
                () => TSequence.Make([], true, true, InterpType.Linear, true));
        }
    }
}
