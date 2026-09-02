using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// A base value MEOS passes by reference is a class of its own, so a method
    /// taking or answering one says which value it means rather than handing back
    /// a pointer.
    /// </summary>
    [TestClass]
    public class ValueClassTests : MeosTest
    {
        [TestMethod]
        public void ATextAnswersTheTextMeosWritesItAs()
        {
            Text text = Text.In("mobility")!;

            Assert.AreEqual("mobility", text.ToString());
            Assert.AreEqual("MOBILITY", text.Upper()!.ToString());
            Assert.AreEqual("Mobility", text.Initcap()!.ToString());
        }

        [TestMethod]
        public void AGeometryIsAGeoAndAnswersItsOwnMeasures()
        {
            Geo square = Geo.FromText("POLYGON((0 0,0 2,2 2,2 0,0 0))", 4326)!;

            Assert.IsInstanceOfType(square, typeof(Geo));
            Assert.AreEqual(4326, square.SRID());
            StringAssert.StartsWith(square.AsText(6), "POLYGON(");
        }

        [TestMethod]
        public void ACbufferAnswersItsCentreAsAGeometry()
        {
            Cbuffer buffer = Cbuffer.In("Cbuffer(Point(1 1),5)")!;

            Assert.AreEqual(5.0, buffer.Radius());

            Geo? centre = buffer.Point();

            Assert.IsNotNull(centre);
            Assert.AreEqual("POINT(1 1)", centre!.AsText(6));
        }

        [TestMethod]
        public void ATemporalGeoIsRestrictedByAGeometry()
        {
            Temporal trip = TGeomPoint.In(
                "[POINT(0 0)@2024-12-06, POINT(4 4)@2024-12-08]")!;
            Geo half = Geo.FromText("POLYGON((0 0,0 2,2 2,2 0,0 0))", 0)!;

            Temporal? inside = ((TGeo)trip).AtGeom(half);

            // The trip leaves the square at (2,2), halfway along, so what the
            // restriction answers ends there rather than at the trip's own end.
            Assert.IsNotNull(inside);
            StringAssert.Contains(inside!.ToString(), "2024-12-07");
            Assert.IsFalse(inside.ToString().Contains("2024-12-08"));
        }
    }
}
