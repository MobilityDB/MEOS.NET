using MEOS.NET.Functions;
using MEOS.NET.Structures;
using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// A name PostgreSQL declares and the catalog keeps crosses the boundary at
    /// the width its `typedefs` entry defines: a <c>Datum</c> is the unsigned
    /// pointer-sized <c>uintptr_t</c>, an <c>Oid</c> an <c>unsigned int</c>, and
    /// a struct field typed through a typedef is laid out at the width it names.
    /// </summary>
    [TestClass]
    public class CatalogTypedefTests : MeosTest
    {
        [TestMethod]
        public void ADatumCrossesAsAnUnsignedWord()
        {
            Set set = BigIntSet.FromText("{-1, 7}")!;

            ulong[] values = Meos.SetValues(set.Ptr);

            CollectionAssert.AreEqual(new[] { ulong.MaxValue, 7UL }, values);
        }

        [TestMethod]
        public void AnOidCrossesAsAnUnsignedInt()
        {
            Text a = Text.FromCstring("abc")!;
            Text b = Text.FromCstring("abd")!;

            // 100 is DEFAULT_COLLATION_OID.
            Assert.IsTrue(Meos.TextCmp(a.Ptr, b.Ptr, 100u) < 0);
            Assert.AreEqual(a.Hash(100u), Text.FromCstring("abc")!.Hash(100u));
        }

        [TestMethod]
        public void AStructFieldTypedThroughATypedefIsLaidOut()
        {
            STBox box = STBox.FromText("STBOX X((1.0,2.0),(3.0,4.0))")!;

            GBOX gbox = box.ToGbox()!.Value;

            Assert.AreEqual(1.0, gbox.xmin);
            Assert.AreEqual(3.0, gbox.xmax);
            Assert.AreEqual(2.0, gbox.ymin);
            Assert.AreEqual(4.0, gbox.ymax);
        }
    }
}
