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
            TBox box = TBox.FromText("TBOXFLOAT XT([1.0, 3.0],[2024-12-06, 2024-12-08])")!;

            Assert.AreEqual(1.0, box.Xmin());
            Assert.AreEqual(3.0, box.Xmax());
            Assert.AreEqual(true, box.TminInc());
        }

        [TestMethod]
        public void ATemporalH3IndexAnswersTheCellsItHolds()
        {
            // th3index_value_n and th3index_value_at_timestamptz write an
            // H3Index, a uint64_t, through their result pointer, and the
            // method answers it as the H3Index it is.
            TH3Index cells = (TH3Index)TH3Index.FromText(
                "[831c02fffffffff@2001-01-01, 831c00fffffffff@2001-01-02]")!;
            DateTime second = new DateTime(2001, 1, 2, 0, 0, 0, DateTimeKind.Utc);

            Assert.AreEqual<H3Index?>(new H3Index(0x831c02fffffffffUL), cells.ValueN(1));
            Assert.AreEqual<H3Index?>(new H3Index(0x831c00fffffffffUL), cells.ValueN(2));
            Assert.IsNull(cells.ValueN(3));
            Assert.AreEqual<H3Index?>(new H3Index(0x831c00fffffffffUL),
                cells.ValueAtTimestamptz(second, true));
        }

        [TestMethod]
        public void AnH3IndexSetAnswersTheCellsItHolds()
        {
            // h3indexset_value_n, over a set MEOS keeps in ascending order.
            H3IndexSet set = (H3IndexSet)H3IndexSet.FromText("{831c02fffffffff, 831c00fffffffff}")!;

            Assert.AreEqual<H3Index?>(new H3Index(0x831c00fffffffffUL), set.ValueN(1));
            Assert.AreEqual<H3Index?>(new H3Index(0x831c02fffffffffUL), set.ValueN(2));
        }

        [TestMethod]
        public void ABoxAnswersNullForABoundItDoesNotHave()
        {
            TBox box = TBox.FromText("TBOX T([2024-12-06, 2024-12-08])")!;

            Assert.IsNull(box.Xmin());
            Assert.IsNull(box.Xmax());
            Assert.IsNotNull(box.TminInc());
        }

        [TestMethod]
        public void ASetAnswersTheValueAtAnIndex()
        {
            Set set = FloatSet.FromText("{1.5, 2.5, 3.5}")!;

            Assert.AreEqual(1.5, ((FloatSet)set).ValueN(1));
            Assert.AreEqual(3.5, ((FloatSet)set).ValueN(3));
            Assert.IsNull(((FloatSet)set).ValueN(4));
        }

        [TestMethod]
        public void ATemporalFloatAnswersItsValueAtAMoment()
        {
            TFloat temp = (TFloat)TFloat.FromText("[25.0@2024-12-06, 27.0@2024-12-08]")!;

            Assert.AreEqual(25.0,
                temp.ValueAtTimestamptz(new DateTime(2024, 12, 6, 0, 0, 0, DateTimeKind.Utc), true));
            Assert.IsNull(
                temp.ValueAtTimestamptz(new DateTime(2024, 12, 9, 0, 0, 0, DateTimeKind.Utc), true));
        }

        [TestMethod]
        public void ANearestNeighbourStepAnswersTheEntryAndItsDistance()
        {
            RTree tree = RTree.CreateStbox()!;
            STBox near = STBox.FromText("STBOX X((1,1),(2,2))")!;
            STBox far = STBox.FromText("STBOX X((9,9),(10,10))")!;
            Assert.IsTrue(tree.Insert(near.Ptr, 1));
            Assert.IsTrue(tree.Insert(far.Ptr, 2));

            STBox query = STBox.FromText("STBOX X((0,0),(0,0))")!;
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
