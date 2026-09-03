using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// Some values MEOS writes through a pointer to a pointer, saying whether the
    /// value exists at all: the method answers the value as its own class, or
    /// null.
    /// </summary>
    [TestClass]
    public class WrappedOutParameterTests : MeosTest
    {
        [TestMethod]
        public void AGeometrySetAnswersTheGeometryAtAnIndex()
        {
            GeomSet set = (GeomSet)GeomSet.In("{POINT(1 1), POINT(2 2)}")!;

            Geo? first = set.ValueN(1);

            Assert.IsNotNull(first);
            Assert.AreEqual("POINT(1 1)", first!.AsText(6));
            Assert.IsNull(set.ValueN(3));
        }

        [TestMethod]
        public void ATemporalTextAnswersItsValueAtAMoment()
        {
            TText temp = (TText)TText.In("[AA@2024-12-06, AA@2024-12-08]")!;

            Text? inside = temp.ValueAtTimestamptz(
                new DateTime(2024, 12, 7, 0, 0, 0, DateTimeKind.Utc), true);

            Assert.IsNotNull(inside);
            Assert.AreEqual("AA", inside!.ToString());
            Assert.IsNull(temp.ValueAtTimestamptz(
                new DateTime(2024, 12, 9, 0, 0, 0, DateTimeKind.Utc), true));
        }
    }
}
