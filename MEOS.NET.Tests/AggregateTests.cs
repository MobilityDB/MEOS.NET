using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// An aggregate of the catalog's `aggregates` is a static method of the
    /// class of its values: the transition threaded over the values from a NULL
    /// state, then the final function. Each answer is the one MobilityDB's
    /// 500_raster test states for the same tiles.
    /// </summary>
    [TestClass]
    public class AggregateTests : MeosTest
    {
        // The example of the manual: two 2x2 tiles of one 32BF band, the second
        // one pixel east and one south of the first, holding 1 and 3.
        private static Raster[] Tiles() => new[]
        {
            Raster.MakeEmpty(2, 2, 0, 2, 1, -1, 0, 0, 3857)!.AddBand(1, "32BF", 1, -9999, true)!,
            Raster.MakeEmpty(2, 2, 1, 1, 1, -1, 0, 0, 3857)!.AddBand(1, "32BF", 3, -9999, true)!,
        };

        [TestMethod]
        public void TheUnionOfTwoTilesTakesTheMeanWhereTheyOverlap()
        {
            Raster union = Raster.RasterUnion(Tiles(), 1, "MEAN")!;

            // {{1,1,NULL},{1,2,3},{NULL,3,3}}
            var (values, nodata) = union.DumpValues(1, true);
            CollectionAssert.AreEqual(
                new[] { false, false, true, false, false, false, true, false, false }, nodata);
            CollectionAssert.AreEqual(new[] { 1.0, 1, 1, 2, 3, 3, 3 },
                values.Where((_v, i) => !nodata[i]).ToArray());
        }

        [TestMethod]
        public void TheStatisticsOfABandSpanTheTiles()
        {
            BandStats stats = Raster.SummaryStatsAgg(Tiles(), 1, true)!;

            Assert.AreEqual(8, stats.Count());
            Assert.AreEqual(16.0, stats.Sum());
            Assert.AreEqual(2.0, stats.Mean());
            Assert.AreEqual(1.0, stats.Stddev());
            Assert.AreEqual(1.0, stats.Min());
            Assert.AreEqual(3.0, stats.Max());
        }

        [TestMethod]
        public void AnAggregateOverNoValuesIsNull()
        {
            Assert.IsNull(Raster.RasterUnion(Array.Empty<Raster>(), 1, "MEAN"));
            Assert.IsNull(Raster.SummaryStatsAgg(Array.Empty<Raster>(), 1, true));
        }
    }
}
