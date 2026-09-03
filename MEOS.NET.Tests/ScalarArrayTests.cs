using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// An array of scalars is read at the scalar's own width. Reading one as an
    /// array of pointers walks it eight bytes at a step, which runs off the end
    /// of a bool array and answers the values' own bytes as addresses.
    /// </summary>
    [TestClass]
    public class ScalarArrayTests : MeosTest
    {
        [TestMethod]
        public void ATemporalBooleanAnswersItsValuesAsBooleans()
        {
            TBool temp = (TBool)TBool.In(
                "{true@2024-12-06, false@2024-12-07, true@2024-12-08}")!;

            bool[] values = temp.Values();

            Assert.AreEqual(2, values.Length);
            CollectionAssert.AreEquivalent(new[] { false, true }, values);
        }

        [TestMethod]
        public void ATemporalFloatAnswersItsValuesAsDoubles()
        {
            TFloat temp = (TFloat)TFloat.In(
                "{1.5@2024-12-06, 2.5@2024-12-07}")!;

            double[] values = temp.Values();

            Assert.AreEqual(2, values.Length);
            CollectionAssert.AreEquivalent(new[] { 1.5, 2.5 }, values);
        }
    }
}
