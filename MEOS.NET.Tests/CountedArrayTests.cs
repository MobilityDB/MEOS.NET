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
