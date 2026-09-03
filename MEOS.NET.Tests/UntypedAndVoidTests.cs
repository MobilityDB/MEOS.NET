using MEOS.NET.Enums;
using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// A method MEOS states nothing about the pointee of, and a method that
    /// answers nothing, are both methods: the first takes the pointer of the
    /// value the caller means, the second is called for what it does.
    /// </summary>
    [TestClass]
    public class UntypedAndVoidTests : MeosTest
    {
        [TestMethod]
        public void AnIndexTakesTheSpansItIsGivenAsPointers()
        {
            RTree? tree = RTree.CreateFloatspan();

            Assert.IsNotNull(tree);

            Span first = FloatSpan.In("[1, 3]")!;
            Span second = FloatSpan.In("[8, 10]")!;

            Assert.IsTrue(tree!.Insert(first.Ptr, 1));
            Assert.IsTrue(tree.Insert(second.Ptr, 2));

            MeosArray? found = MeosArray.Create(8);

            Assert.IsNotNull(found);
            Assert.AreEqual(1, tree.Search(IndexSearchOp.IndexOverlaps, second.Ptr, found!));
        }

        [TestMethod]
        public void ClearingTheSchemaCacheIsAMethodThatAnswersNothing()
        {
            // `meos_pc_schema_clear()` answers nothing and is called for what
            // it does; a cleared cache holds no schema, and MEOS says so by
            // raising rather than by answering null.
            Pcschema.Clear();

            Assert.ThrowsException<MEOS.NET.Exceptions.MEOSInternalErrorException>(
                () => Pcschema.Get(1));
        }
    }
}
