using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// The operators the catalog's object model assigns each class
    /// (<c>classes.&lt;C&gt;.operators</c>) and the constructors it builds from base
    /// values (<c>scope: fromBase</c>): that each reaches the MEOS function the
    /// model names, called on the operand the model says is the receiver, and that
    /// one name covers every operand type as C# overloads.
    /// </summary>
    [TestClass]
    public class OperatorTests : MeosTest
    {
        private const string Sequence = "[1.0@2024-12-06, 3.0@2024-12-07]";

        private static TFloat Rising() => (TFloat)TFloat.In(Sequence)!;

        [TestMethod]
        public void EverEqualToAScalarIsTheOverloadTakingThatScalar()
        {
            // ever_eq_tfloat_float: the sequence passes through 2 and never 5.
            Assert.AreEqual(1, Rising().EverEq(2.0));
            Assert.AreEqual(0, Rising().EverEq(5.0));
        }

        [TestMethod]
        public void AddingATemporalNumberIsTheOverloadTakingTheClass()
        {
            // add_tnumber_tnumber, its other operand typed as the TNumber its SQL
            // signatures instantiate rather than any Temporal.
            TNumber sum = (TNumber)Rising().Add((TNumber)Rising())!;

            Assert.AreEqual(2.0, ((TFloat)sum).StartValue());
        }

        [TestMethod]
        public void LeftOfABoxAndLeftOfATemporalNumberAreOverloadsOfOneName()
        {
            TBox low = TBox.In("TBOXFLOAT X([1.0, 2.0])")!;
            TBox high = TBox.In("TBOXFLOAT X([5.0, 6.0])")!;
            TNumber temp = (TNumber)TFloat.In("[7.0@2024-12-06, 8.0@2024-12-07]")!;

            // left_tbox_tbox and left_tbox_tnumber.
            Assert.IsTrue(low.Left(high));
            Assert.IsFalse(high.Left(low));
            Assert.IsTrue(high.Left(temp));
        }

        [TestMethod]
        public void ReflectedSubtractionIsCalledOnTheRightOperand()
        {
            // sub_float_tfloat(10, temp) is 10 - temp, so it starts at 9; the
            // left-receiver sub_tfloat_float(temp, 10) starts at -9.
            Assert.AreEqual(9.0, ((TFloat)Rising().Rsub(10.0)!).StartValue());
            Assert.AreEqual(-9.0, ((TFloat)Rising().Sub(10.0)!).StartValue());
        }

        [TestMethod]
        public void ContainsOnAnIntSetTakesAnInt()
        {
            // contains_set_int, instantiated onto IntSet from the template Set.
            IntSet set = (IntSet)IntSet.In("{1, 3, 5}")!;

            Assert.IsTrue(set.Contains(3));
            Assert.IsFalse(set.Contains(4));
        }

        [TestMethod]
        public void FromFloatBuildsTheBoxOfThatValue()
        {
            // float_to_tbox.
            TBox box = TBox.FromFloat(1.5)!;

            Assert.AreEqual(1.5, box.Xmin());
            Assert.AreEqual(1.5, box.Xmax());
        }

        [TestMethod]
        public void FromIntBuildsTheIntSetOfThatValue()
        {
            // int_to_set, refined from Set onto IntSet by its SQL signature.
            Set? set = IntSet.FromInt(7);

            Assert.IsInstanceOfType(set, typeof(IntSet));
            Assert.IsTrue(((IntSet)set!).Contains(7));
        }
    }
}
