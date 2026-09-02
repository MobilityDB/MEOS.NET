using MEOS.NET.Enums;
using MEOS.NET.Types.Temporal.Number.Float;

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
            TemporalFloat temp = TemporalFloat.FromString("[25.0@2024-12-06, 27.0@2024-12-07]");

            Assert.AreEqual(InterpolationType.Linear, temp.Interpolation());
        }

        [TestMethod]
        public void InterpolationOfADiscreteSequenceIsRead()
        {
            TemporalFloat temp = TemporalFloat.FromString("{25.0@2024-12-06, 27.0@2024-12-07}");

            Assert.AreEqual(InterpolationType.Discrete, temp.Interpolation());
        }

        [TestMethod]
        public void TheSameBorrowedNameIsReadableTwice()
        {
            TemporalFloat first = TemporalFloat.FromString("[25.0@2024-12-06, 27.0@2024-12-07]");
            TemporalFloat second = TemporalFloat.FromString("[1.0@2024-12-06, 2.0@2024-12-07]");

            Assert.AreEqual(first.Interpolation(), second.Interpolation());
        }
    }
}
