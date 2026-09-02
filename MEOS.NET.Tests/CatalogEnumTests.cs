using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Tests
{
    /// <summary>
    /// The generated enums carry MEOS's own constants, so MEOS names back the same
    /// thing the enum member does. A value that drifted would name something else,
    /// or nothing.
    /// </summary>
    [TestClass]
    public class CatalogEnumTests : MeosTest
    {
        [TestMethod]
        public void MeosNamesTheTypeTheEnumMemberDoes()
        {
            Assert.AreEqual("tfloat", Meos.MeostypeName((int)MeosType.TTfloat));
            Assert.AreEqual("tgeompoint", Meos.MeostypeName((int)MeosType.TTgeompoint));
            Assert.AreEqual("floatspan", Meos.MeostypeName((int)MeosType.TFloatspan));
        }

        [TestMethod]
        public void MeosNamesTheInterpolationTheEnumMemberDoes()
        {
            Assert.AreEqual("Discrete", Meos.InterptypeName((int)InterpType.Discrete));
            Assert.AreEqual("Step", Meos.InterptypeName((int)InterpType.Step));
            Assert.AreEqual("Linear", Meos.InterptypeName((int)InterpType.Linear));
        }

        [TestMethod]
        public void MeosNamesTheSubtypeTheEnumMemberDoes()
        {
            Assert.AreEqual("Instant", Meos.TempsubtypeName((int)TempSubtype.Tinstant));
            Assert.AreEqual("Sequence", Meos.TempsubtypeName((int)TempSubtype.Tsequence));
            Assert.AreEqual("SequenceSet", Meos.TempsubtypeName((int)TempSubtype.Tsequenceset));
        }

        [TestMethod]
        public void TheInterpolationNameReadsBackAsItsMember()
        {
            Assert.AreEqual((int)InterpType.Linear, Meos.InterptypeFromString("Linear"));
            Assert.AreEqual((int)InterpType.Step, Meos.InterptypeFromString("Step"));
        }
    }
}
