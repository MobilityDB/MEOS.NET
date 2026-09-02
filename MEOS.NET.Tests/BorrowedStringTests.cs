using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// The MEOS functions that answer with a `const char *` hand back a pointer
    /// into a static table, so the caller reads it and does not free it. Freeing
    /// it takes the process down, which is what these read.
    /// </summary>
    [TestClass]
    public class BorrowedStringTests : MeosTest
    {
        [TestMethod]
        public void InterpolationOfALinearSequenceIsRead()
        {
            Temporal temp = TFloat.In("[25.0@2024-12-06, 27.0@2024-12-07]")!;

            Assert.AreEqual("Linear", temp.Interp());
        }

        [TestMethod]
        public void InterpolationOfADiscreteSequenceIsRead()
        {
            Temporal temp = TFloat.In("{25.0@2024-12-06, 27.0@2024-12-07}")!;

            Assert.AreEqual("Discrete", temp.Interp());
        }

        [TestMethod]
        public void TheSameBorrowedNameIsReadableTwice()
        {
            Temporal first = TFloat.In("[25.0@2024-12-06, 27.0@2024-12-07]")!;
            Temporal second = TFloat.In("[1.0@2024-12-06, 2.0@2024-12-07]")!;

            Assert.AreEqual(first.Interp(), second.Interp());
        }

        [TestMethod]
        public void SubtypeOfASequenceIsRead()
        {
            Temporal temp = TFloat.In("[25.0@2024-12-06, 27.0@2024-12-07]")!;

            Assert.AreEqual("Sequence", temp.Subtype());
        }
    }
}
