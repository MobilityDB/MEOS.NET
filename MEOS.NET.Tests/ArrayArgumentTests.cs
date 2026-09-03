using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// An array MEOS reads is one parameter to the caller and two to MEOS, the
    /// pointer and its length. The catalog names both, so a method takes the
    /// array whatever MEOS calls the length.
    /// </summary>
    [TestClass]
    public class ArrayArgumentTests : MeosTest
    {
        [TestMethod]
        public void ASetIsBuiltFromAnArrayOfGeometries()
        {
            Geo[] points =
            {
                Geo.FromText("POINT(1 1)", 0)!,
                Geo.FromText("POINT(2 2)", 0)!,
            };

            Set? set = GeomSet.Make(points);

            Assert.IsNotNull(set);
            Assert.AreEqual(2, set!.NumValues());
        }

        [TestMethod]
        public void AJsonbIsQueriedWithAnArrayOfKeysWhoseLengthIsNotNamedCount()
        {
            // `jsonb_exists_array(jb, text **keys_elems, int keys_len, bool any)`
            // — the length is `keys_len`, and the catalog is what says so.
            Jsonb jb = Jsonb.In("{\"a\": 1, \"b\": 2}")!;
            Text[] keys = { Text.In("a")!, Text.In("z")! };

            Assert.IsTrue(jb.ExistsArray(keys, true));
            Assert.IsFalse(jb.ExistsArray(keys, false));

            Text[] missing = { Text.In("y")!, Text.In("z")! };

            Assert.IsFalse(jb.ExistsArray(missing, true));
        }
    }
}
