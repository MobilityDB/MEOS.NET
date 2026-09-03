using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// MEOS states the length of a buffer it answers through a pointer, and reads
    /// one back as a pointer and a length. Both are one C# array to the caller.
    /// </summary>
    [TestClass]
    public class ByteBufferTests : MeosTest
    {
        [TestMethod]
        public void ASpanRoundTripsThroughItsOwnWKB()
        {
            Span span = FloatSpan.In("[8, 10]")!;

            byte[]? wkb = span.AsWKB(0);

            Assert.IsNotNull(wkb);
            Assert.IsTrue(wkb!.Length > 0);

            Span? read = Span.FromWKB(wkb);

            Assert.IsNotNull(read);
            Assert.AreEqual("[8, 10]", read!.ToString());
        }

        [TestMethod]
        public void ATemporalValueRoundTripsThroughItsOwnWKB()
        {
            Temporal temp = TFloat.In("[25.5@2024-12-06, 27.5@2024-12-08]")!;

            byte[]? wkb = temp.AsWKB(0);

            Assert.IsNotNull(wkb);

            Temporal? read = Temporal.FromWKB(wkb!);

            Assert.IsNotNull(read);
            Assert.AreEqual(temp.ToString(), read!.ToString());
        }

        [TestMethod]
        public void TheHexFormNeedsNoLengthOfItsOwn()
        {
            Span span = FloatSpan.In("[8, 10]")!;

            string hex = span.AsHEXWKB(0);

            Assert.IsTrue(hex.Length > 0);
            Assert.AreEqual("[8, 10]", Span.FromHEXWKB(hex)!.ToString());
        }
    }
}
