using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// A MEOS function that answers an array of structs holding MEOS values
    /// answers them as C# values: each geometry is a copy the caller keeps,
    /// and the array is released with the function the catalog names for it.
    /// </summary>
    [TestClass]
    public class HeldStructArrayTests : MeosTest
    {
        // MobilityDB's meos/test/raster_test.c raster_values: a 3x3 raster in
        // SRID 4326 whose band 1 holds eight distinct values and one nodata pixel.
        private const string RasterValues =
            "0100000100000000000000f03f000000000000f0bf0000000000000000000000000000"
            + "084000000000000000000000000000000000e6100000030003004a003c1cc600002041"
            + "003c1cc60000f04100002042000048420000704200008c420000a0420000b442";

        [TestMethod]
        public void ABandDumpsAsOnePolygonPerValueEachAGeometryThatOutlivesTheArray()
        {
            Raster raster = Raster.FromHexWKB(RasterValues)!;

            GeomVal[] polygons = raster.DumpAsPolygons(1, true);

            // No two neighbouring pixels share a value, so every pixel is a
            // region of its own: eight polygons with the nodata pixel excluded.
            Assert.AreEqual(8, polygons.Length);
            Assert.AreEqual(10.0 + 30.0 + 40.0 + 50.0 + 60.0 + 70.0 + 80.0 + 90.0,
                polygons.Sum(p => p.Val));
            // geomval_arr_free has released the array and the geometries in it,
            // so each geometry read here is the copy the struct holds.
            foreach (GeomVal polygon in polygons)
            {
                Assert.IsNotNull(polygon.Geom);
                // A pixel of one degree by one degree covers an area of 1.
                Assert.AreEqual(1.0, polygon.Geom!.Area(false), 0.001);
                Assert.AreEqual(4326, polygon.Geom.SRID());
                StringAssert.StartsWith(polygon.Geom.ToString(), "POLYGON");
            }
        }

        [TestMethod]
        public void ABandAnswersEachPixelWithItsPositionValueAndPoint()
        {
            Raster raster = Raster.FromHexWKB(RasterValues)!;

            Pixel[] pixels = raster.PixelAsPoints(1, true);

            Assert.AreEqual(8, pixels.Length);
            Assert.AreEqual(10.0 + 30.0 + 40.0 + 50.0 + 60.0 + 70.0 + 80.0 + 90.0,
                pixels.Sum(p => p.Value));
            Assert.IsTrue(pixels.All(p => !p.Nodata));
            Assert.IsTrue(pixels.All(p => p.X >= 1 && p.X <= 3 && p.Y >= 1 && p.Y <= 3));
            foreach (Pixel pixel in pixels)
            {
                Assert.AreEqual(4326, pixel.Geom!.SRID());
                StringAssert.StartsWith(pixel.Geom.ToString(), "POINT");
            }
        }
    }
}
