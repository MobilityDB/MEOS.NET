using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// MEOS answers some values through an out-parameter and returns whether the
    /// value exists at all, so those methods answer the value or null.
    /// </summary>
    [TestClass]
    public class OutParameterTests : MeosTest
    {
        [TestMethod]
        public void ABoxAnswersTheBoundsItHas()
        {
            TBox box = TBox.In("TBOXFLOAT XT([1.0, 3.0],[2024-12-06, 2024-12-08])")!;

            Assert.AreEqual(1.0, box.Xmin());
            Assert.AreEqual(3.0, box.Xmax());
            Assert.AreEqual(true, box.TminInc());
        }

        [TestMethod]
        public void ABoxAnswersNullForABoundItDoesNotHave()
        {
            TBox box = TBox.In("TBOX T([2024-12-06, 2024-12-08])")!;

            Assert.IsNull(box.Xmin());
            Assert.IsNull(box.Xmax());
            Assert.IsNotNull(box.TminInc());
        }

        [TestMethod]
        public void ASetAnswersTheValueAtAnIndex()
        {
            Set set = FloatSet.In("{1.5, 2.5, 3.5}")!;

            Assert.AreEqual(1.5, ((FloatSet)set).ValueN(1));
            Assert.AreEqual(3.5, ((FloatSet)set).ValueN(3));
            Assert.IsNull(((FloatSet)set).ValueN(4));
        }

        [TestMethod]
        public void ATemporalFloatAnswersItsValueAtAMoment()
        {
            TFloat temp = (TFloat)TFloat.In("[25.0@2024-12-06, 27.0@2024-12-08]")!;

            Assert.AreEqual(25.0,
                temp.ValueAtTimestamptz(new DateTime(2024, 12, 6, 0, 0, 0, DateTimeKind.Utc), true));
            Assert.IsNull(
                temp.ValueAtTimestamptz(new DateTime(2024, 12, 9, 0, 0, 0, DateTimeKind.Utc), true));
        }

        [TestMethod]
        public void ANearestNeighbourStepAnswersTheEntryAndItsDistance()
        {
            RTree tree = RTree.CreateStbox()!;
            STBox near = STBox.In("STBOX X((1,1),(2,2))")!;
            STBox far = STBox.In("STBOX X((9,9),(10,10))")!;
            Assert.IsTrue(tree.Insert(near.Ptr, 1));
            Assert.IsTrue(tree.Insert(far.Ptr, 2));

            STBox query = STBox.In("STBOX X((0,0),(0,0))")!;
            RTreeNNCursor walk = RTreeNNCursor.Open(tree, query.Ptr)!;
            try
            {
                (long Id, double Distance)? nearest = walk.Next();
                (long Id, double Distance)? next = walk.Next();

                Assert.IsNotNull(nearest);
                Assert.IsNotNull(next);
                Assert.AreEqual(1L, nearest!.Value.Id);
                Assert.AreEqual(2L, next!.Value.Id);
                Assert.IsTrue(next.Value.Distance > nearest.Value.Distance);
                Assert.IsNull(walk.Next());
            }
            finally
            {
                walk.Close();
            }
        }
    }
}
