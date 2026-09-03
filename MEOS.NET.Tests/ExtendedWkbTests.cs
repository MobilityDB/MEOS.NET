using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// The extended WKB of a geometry is a buffer whose length MEOS states
    /// through a pointer, so the array a caller gets is exactly as long as the
    /// data — which the hex form of the same value states independently.
    /// </summary>
    [TestClass]
    public class ExtendedWkbTests : MeosTest
    {
        private const string Line = "SRID=4326;LINESTRING(1 1, 2 2, 3 4)";

        [TestMethod]
        public void TheBufferIsAsLongAsTheHexFormSays()
        {
            Geo line = Geometry.In(Line, -1)!;

            byte[]? ewkb = line.AsEWKB("ndr");
            string hex = line.AsHexewkb("ndr");

            Assert.IsNotNull(ewkb);
            Assert.AreEqual(hex.Length, ewkb!.Length * 2);
            Assert.AreEqual(hex.ToUpperInvariant(), Convert.ToHexString(ewkb));
        }

        [TestMethod]
        public void AGeometryRoundTripsThroughItsOwnEWKB()
        {
            Geo line = Geometry.In(Line, -1)!;

            Geo? read = Geo.FromEWKB(line.AsEWKB("ndr")!, 4326);

            Assert.IsNotNull(read);
            Assert.AreEqual(line.ToString(), read!.ToString());
        }
    }
}
