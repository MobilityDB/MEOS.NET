using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// An aggregate several transitions serve under one name, one per type of
    /// its values (tsum is tint_tsum_transfn over tint and tfloat_tsum_transfn
    /// over tfloat), is a static method of each value's class: the catalog names
    /// that class by the SQL type of the aggregate's values, the prefix of its
    /// leaf of the lattice. Each answer is the one MobilityDB's
    /// 040_temporal_aggfuncs test states for the same values, as
    /// AggregateTests states the raster aggregates'.
    /// </summary>
    [TestClass]
    public class AggregateOverloadTests : MeosTest
    {
        private static TFloat Float(string text) => (TFloat)TFloat.FromText(text)!;
        private static TInt Int(string text) => (TInt)TInt.FromText(text)!;

        [TestMethod]
        public void TheSumOfTwoTemporalFloatsAddsThemWhereTheyOverlap()
        {
            Temporal sum = TFloat.TSum(new[]
            {
                Float("[1@2001-01-01, 2@2001-01-03, 1@2001-01-05, 2@2001-01-07]"),
                Float("[3@2001-01-02, 4@2001-01-06]"),
            })!;

            Temporal expected = Float("{[1@2001-01-01, 1.5@2001-01-02), "
                + "[4.5@2001-01-02, 5.25@2001-01-03, 4.75@2001-01-05, 5.5@2001-01-06], "
                + "(1.5@2001-01-06, 2@2001-01-07]}");
            Assert.AreEqual(expected.AsText(15), sum.AsText(15));
        }

        [TestMethod]
        public void TheMinimumOfOneTemporalIntegerIsThatValue()
        {
            Temporal min = TInt.TMinAgg(new[] { Int("1@2001-01-01") })!;

            Assert.AreEqual(Int("{1@2001-01-01}").AsText(15), min.AsText(15));
        }

        [TestMethod]
        public void AnAggregateOverNoValuesIsNull()
        {
            Assert.IsNull(TInt.TMinAgg(Array.Empty<TInt>()));
            Assert.IsNull(TFloat.TSum(Array.Empty<TFloat>()));
        }
    }
}
