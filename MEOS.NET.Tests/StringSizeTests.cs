using MEOS.NET.Functions;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// A string MEOS answers comes with its size, written through a `size_t *`, so
    /// its wrapper takes no such argument and reads the string for that size, as
    /// <see cref="BorrowedStringTests"/> reads a string MEOS keeps. The size counts
    /// bytes, its terminator included, and the string holds characters.
    /// </summary>
    [TestClass]
    public class StringSizeTests : MeosTest
    {
        [TestMethod]
        public void AValueHoldingTwoByteCharactersReadsBackWhole()
        {
            const string text = "{\"Zürich\"@2001-01-01 00:00:00+00, \"Liège\"@2001-01-02 00:00:00+00}";

            Assert.AreEqual(text, Meos.TtextOut(Meos.TtextIn(text)));
        }

        [TestMethod]
        public void AStringBeyondTheLargeObjectThresholdReadsBackWhole()
        {
            string value = new('x', 200000);
            string text = $"\"{value}\"@2001-01-01 00:00:00+00";

            Assert.AreEqual(text, Meos.TtextOut(Meos.TtextIn(text)));
        }

        [TestMethod]
        public void AFunctionWhoseOnlyParameterIsTheSizeTakesNoArgument()
        {
            StringAssert.StartsWith(Meos.MeosVersion(), "MobilityDB");
        }
    }
}
