using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// A method that answers many MEOS values answers them as the classes their
    /// own headers name, whether MEOS returns an array of pointers or an array of
    /// the values themselves walked at the struct's stride.
    /// </summary>
    [TestClass]
    public class ValueArrayTests : MeosTest
    {
        [TestMethod]
        public void TheSpansOfASpanSetComeBackAsSpans()
        {
            SpanSet spanset = FloatSpanSet.In("{[8, 10], [11, 12]}")!;

            Span?[] spans = spanset.Spans();

            Assert.AreEqual(2, spans.Length);
            Assert.IsInstanceOfType(spans[0], typeof(FloatSpan));
            Assert.AreEqual("[8, 10]", spans[0]!.ToString());
            Assert.AreEqual("[11, 12]", spans[1]!.ToString());
        }

        [TestMethod]
        public void TheQuadrantsOfABoxComeBackAsBoxes()
        {
            STBox box = STBox.In("STBOX X((0,0),(4,4))")!;

            STBox?[] quadrants = box.QuadSplit();

            Assert.AreEqual(4, quadrants.Length);
            foreach (STBox? quadrant in quadrants)
            {
                StringAssert.StartsWith(quadrant!.ToString(), "STBOX X(");
            }
        }

        [TestMethod]
        public void TheInstantsOfASequenceComeBackAsTemporalValues()
        {
            Temporal temp = TFloat.In("[25.0@2024-12-06, 27.0@2024-12-07]")!;

            Temporal?[] instants = temp.Instants();

            Assert.AreEqual(2, instants.Length);
            Assert.IsInstanceOfType(instants[0], typeof(TFloatInst));
            Assert.AreEqual("25@2024-12-06 00:00:00+00", instants[0]!.ToString());
        }
    }
}
