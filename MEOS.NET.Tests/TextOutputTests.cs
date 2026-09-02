using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// A value prints as the text MEOS writes it as. MEOS publishes that text per
    /// concrete type, so a class carries <c>ToString</c> exactly where MEOS
    /// publishes an output for its own type.
    /// </summary>
    [TestClass]
    public class TextOutputTests : MeosTest
    {
        [TestMethod]
        public void ATemporalFloatPrintsAsMeosWritesIt()
        {
            Temporal temp = TFloat.In("[25.5@2024-12-06, 27.5@2024-12-07]")!;

            Assert.AreEqual(
                "[25.5@2024-12-06 00:00:00+00, 27.5@2024-12-07 00:00:00+00]",
                temp.ToString());
        }

        [TestMethod]
        public void ASpanPrintsAsMeosWritesIt()
        {
            SpanSet spanset = FloatSpanSet.In("{[8, 10], [11, 12]}")!;

            Assert.AreEqual("[8, 10]", spanset.StartSpan()!.ToString());
            Assert.AreEqual("{[8, 10], [11, 12]}", spanset.ToString());
        }

        [TestMethod]
        public void ABoxPrintsAsMeosWritesIt()
        {
            STBox box = STBox.In("STBOX X((1,1),(2,2))")!;

            Assert.AreEqual("STBOX X((1,1),(2,2))", box.ToString());
        }

        [TestMethod]
        public void TheTextComesFromTheClassOfTheValue()
        {
            // Wrapping answers the concrete class, so the text is that class's.
            Temporal instant = TFloat.In("25.5@2024-12-06")!;

            Assert.IsInstanceOfType(instant, typeof(TFloatInst));
            Assert.AreEqual("25.5@2024-12-06 00:00:00+00", instant.ToString());
        }
    }
}
