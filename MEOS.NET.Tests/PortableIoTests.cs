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
            CBuffer cbuffer = CBuffer.FromText("Cbuffer(Point(1 1),0.5)")!;

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
        public void ATemporalCellIndexAndItsSetHaveTheirClasses()
        {
            Temporal temp = TH3Index.FromText("8a2a1072b59ffff@2024-12-06")!;
            Set set = H3IndexSet.FromText("{8a2a1072b59ffff}")!;

            Assert.IsInstanceOfType(temp, typeof(TH3Index));
            Assert.AreEqual("8a2a1072b59ffff@2024-12-06 00:00:00+00", temp.ToString());
            // The text MobilityDB writes for an h3indexset, each cell quoted.
            Assert.AreEqual("{\"8a2a1072b59ffff\"}", set.ToString());
        }

        [TestMethod]
        public void AQuadbinCellRoundTripsThroughItsTextAndWkb()
        {
            Quadbin cell = Quadbin.FromText("48427fffffffffff");

            Assert.AreEqual("48427fffffffffff", cell.AsText());
            Assert.AreEqual("48427fffffffffff", cell.ToString());
            Assert.AreEqual("01470000FFFFFFFFFF7F4248", cell.AsHexWKB(0));
            Assert.AreEqual(cell, Quadbin.FromHexWKB("01470000FFFFFFFFFF7F4248"));
            Assert.AreEqual(cell, Quadbin.FromWKB(cell.AsWKB(0)!));
        }

        [TestMethod]
        public void AnS2CellRoundTripsThroughItsTextAndWkb()
        {
            S2Cell cell = S2Cell.FromText("47c3c444c");

            Assert.AreEqual("47c3c444c", cell.AsText());
            Assert.AreEqual("47c3c444c", cell.ToString());
            Assert.AreEqual("01550000000000C044C4C347", cell.AsHexWKB(0));
            Assert.AreEqual(cell, S2Cell.FromHexWKB("01550000000000C044C4C347"));
            Assert.AreEqual(cell, S2Cell.FromWKB(cell.AsWKB(0)!));
        }

        [TestMethod]
        public void AnH3CellRoundTripsThroughItsTextAndWkb()
        {
            H3Index cell = H3Index.FromText("8a2a1072b59ffff");

            Assert.AreEqual("8a2a1072b59ffff", cell.AsText());
            Assert.AreEqual("8a2a1072b59ffff", cell.ToString());
            Assert.AreEqual(cell, H3Index.FromHexWKB(cell.AsHexWKB(0)));
            Assert.AreEqual(cell, H3Index.FromWKB(cell.AsWKB(0)!));
        }

        [TestMethod]
        public void ATemporalCellAnswersItsValueAsTheCellClass()
        {
            TH3Index temp = (TH3Index)TH3Index.FromText("8a2a1072b59ffff@2024-12-06")!;

            Assert.AreEqual(H3Index.FromText("8a2a1072b59ffff"), temp.StartValue());
            Assert.AreEqual("8a2a1072b59ffff", temp.StartValue().ToString());
        }

        [TestMethod]
        public void AJsonbSetAndATemporalPoseChainHaveTheirClasses()
        {
            Set set = JsonbSet.FromText("{\"{\\\"a\\\": 1}\"}")!;
            Temporal chain = TPoseChain.FromText(
                "PoseChain(Pose(Point(1 1), 0.5))@2024-12-06")!;

            Assert.IsInstanceOfType(set, typeof(JsonbSet));
            Assert.IsInstanceOfType(chain, typeof(TPoseChain));
            Assert.AreEqual(
                "PoseChain(Pose(POINT(1 1),0.5))@2024-12-06 00:00:00+00", chain.ToString());
        }

        [TestMethod]
        public void ASetASpanASpanSetATemporalValueAndABoxRoundTripThroughTheirText()
        {
            string[] texts =
            {
                IntSet.FromText("{1, 3, 5}")!.AsText(15),
                FloatSpan.FromText("[8, 10]")!.AsText(15),
                FloatSpanSet.FromText("{[8, 10], [11, 12]}")!.AsText(15),
                TFloat.FromText("[25.5@2024-12-06, 27.5@2024-12-07]")!.AsText(15),
                TBox.FromText("TBOXFLOAT XT([1, 3),[2024-12-06, 2024-12-08])")!.AsText(15),
            };

            Assert.AreEqual("{1, 3, 5}", texts[0]);
            Assert.AreEqual("[8, 10]", texts[1]);
            Assert.AreEqual("{[8, 10], [11, 12]}", texts[2]);
            Assert.AreEqual(
                "[25.5@2024-12-06 00:00:00+00, 27.5@2024-12-07 00:00:00+00]", texts[3]);
            Assert.AreEqual(texts[0], IntSet.FromText(texts[0])!.AsText(15));
            Assert.AreEqual(texts[1], FloatSpan.FromText(texts[1])!.AsText(15));
            Assert.AreEqual(texts[2], FloatSpanSet.FromText(texts[2])!.AsText(15));
            Assert.AreEqual(texts[3], TFloat.FromText(texts[3])!.AsText(15));
            Assert.AreEqual(texts[4], TBox.FromText(texts[4])!.AsText(15));
        }

        [TestMethod]
        public void ABoxRoundTripsThroughItsExtendedText()
        {
            const string Box = "SRID=4326;STBOX X((1,1),(2,2))";

            STBox box = STBox.FromText(Box)!;

            Assert.AreEqual(Box, box.AsEWKT(15));
            Assert.AreEqual(Box, STBox.FromEWKT(box.AsEWKT(15))!.AsEWKT(15));
            Assert.AreEqual("STBOX X((1,1),(2,2))", box.AsText(15));
        }

        [TestMethod]
        public void AJsonbAJsonPathAndANumericRoundTripThroughTheirText()
        {
            Jsonb jb = Jsonb.FromText("{\"a\": 1, \"b\": \"two\"}")!;
            JsonPath path = JsonPath.FromText("$.a")!;
            Numeric num = Numeric.FromText("12.50", -1)!;

            Assert.AreEqual("{\"a\": 1, \"b\": \"two\"}", jb.AsText());
            Assert.AreEqual(jb.AsText(), Jsonb.FromText(jb.AsText())!.AsText());
            Assert.AreEqual("$.\"a\"", path.AsText());
            Assert.AreEqual(path.AsText(), JsonPath.FromText(path.AsText())!.AsText());
            Assert.AreEqual("12.50", num.AsText());
            Assert.AreEqual(num.AsText(), Numeric.FromText(num.AsText(), -1)!.AsText());
        }

        [TestMethod]
        public void ASpanReadsItsTextUnderThePortableName()
        {
            Span span = FloatSpan.FromText("[8, 10]")!;

            Assert.AreEqual("[8, 10]", span.ToString());
        }
    }
}
