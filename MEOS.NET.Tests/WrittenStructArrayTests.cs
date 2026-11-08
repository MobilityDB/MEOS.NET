using MEOS.NET.Exceptions;
using MEOS.NET.Types;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// A MEOS function that reads an array of structs of scalars and strings
    /// takes them as C# values: each is laid out at the offsets the catalog
    /// records, and its strings are copies the call frees, MEOS copying what it
    /// keeps.
    /// </summary>
    [TestClass]
    public class WrittenStructArrayTests : MeosTest
    {
        // The dimensions MobilityDB's meos/test/decimal_digits_test.c registers.
        private static PCDimensionSpec[] Dims() =>
        [
            new("X", "X coordinate", 1, "int32_t", 0.01, 0, true),
            new("Y", "Y coordinate", 2, "int32_t", 0.01, 0, true),
            new("Z", "Z coordinate", 3, "int32_t", 0.01, 0, true),
        ];

        [TestMethod]
        public void ASchemaRegisteredFromItsDimensionsStatesThem()
        {
            const uint pcid = 9101;

            Assert.IsTrue(Pcschema.RegisterDims(pcid, 4326, "none", Dims()));

            Assert.AreEqual(3, Pcschema.Ndims(pcid));
            Assert.AreEqual(4326, Pcschema.SRID(pcid));
            Assert.AreEqual("none", Pcschema.Compression(pcid));
            // The names and interpretations are the copies MEOS keeps, read back
            // after the strings the call passed are freed; each field lands at
            // the offset MEOS reads it at.
            string xml = Pcschema.Xml(pcid)!;
            StringAssert.Contains(xml, "<pc:position>3</pc:position>");
            StringAssert.Contains(xml, "<pc:name>Z</pc:name>");
            StringAssert.Contains(xml, "<pc:interpretation>int32_t</pc:interpretation>");
            StringAssert.Contains(xml, "<pc:scale>0.01</pc:scale>");
            StringAssert.Contains(xml, "<pc:active>1</pc:active>");
        }

        [TestMethod]
        public void ASchemaIsBuiltFromItsDimensions()
        {
            Assert.IsNotNull(Pcschema.FromDims(9102, 0, "none", Dims()));
        }

        [TestMethod]
        public void ADimensionOfAnUnknownInterpretationIsRefused()
        {
            // pc_interpretation_number reads no such type, so MEOS refuses the
            // schema rather than storing a dimension it cannot read.
            PCDimensionSpec[] dims = [new("X", "X coordinate", 1, "nonsense", 1, 0, true)];

            Assert.ThrowsException<MEOSInvalidArgValueException>(
                () => Pcschema.FromDims(9103, 0, "none", dims));
        }
    }
}
