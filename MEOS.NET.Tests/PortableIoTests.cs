using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// Every type reads and writes each format the catalog gives it under the
    /// portable name of the SQL function, <c>From&lt;Format&gt;</c> and
    /// <c>As&lt;Format&gt;</c>, and a spatial value prints as its <c>AsText</c>,
    /// its points written as WKT.
    /// </summary>
    [TestClass]
    public class PortableIoTests : MeosTest
    {
        private const string Point = "SRID=4326;[Point(1 1)@2024-12-06, Point(2 2)@2024-12-07]";

        [TestMethod]
        public void ATemporalPointPrintsItsPointsAsWkt()
        {
            Temporal temp = TGeomPoint.FromText(Point)!;

            Assert.AreEqual(
                "[POINT(1 1)@2024-12-06 00:00:00+00, POINT(2 2)@2024-12-07 00:00:00+00]",
                temp.ToString());
        }

        [TestMethod]
        public void ACircularBufferPrintsItsCentreAsWkt()
        {
            Cbuffer cbuffer = Cbuffer.FromText("Cbuffer(Point(1 1),0.5)")!;

            Assert.AreEqual("Cbuffer(POINT(1 1),0.5)", cbuffer.ToString());
        }

        [TestMethod]
        public void TheExtendedTextCarriesTheSrid()
        {
            Temporal temp = TGeomPoint.FromEWKT(Point)!;

            Assert.AreEqual(
                "SRID=4326;[POINT(1 1)@2024-12-06 00:00:00+00, POINT(2 2)@2024-12-07 00:00:00+00]",
                ((TSpatial)temp).AsEWKT(15));
        }

        [TestMethod]
        public void ATemporalPointRoundTripsThroughItsExtendedWkb()
        {
            TSpatial temp = (TSpatial)TGeomPoint.FromEWKT(Point)!;

            Temporal? fromBytes = TGeomPoint.FromEWKB(temp.AsEWKB(0)!);
            Temporal? fromHex = TGeomPoint.FromHexEWKB(temp.AsHexEWKB(0));

            Assert.AreEqual(temp.AsEWKT(15), ((TSpatial)fromBytes!).AsEWKT(15));
            Assert.AreEqual(temp.AsEWKT(15), ((TSpatial)fromHex!).AsEWKT(15));
        }

        [TestMethod]
        public void ASpanReadsItsTextUnderThePortableName()
        {
            Span span = FloatSpan.FromText("[8, 10]")!;

            Assert.AreEqual("[8, 10]", span.ToString());
        }
    }
}
