#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The TGeometry class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TGeometry : TGeo
    {
        internal TGeometry(IntPtr ptr) : base(ptr) { }

        public Temporal? ToTcbuffer()
            => MEOSFactory.WrapTemporal(Meos.TgeometryToTcbuffer(this.Ptr));

        public Temporal? ToTgeography()
            => MEOSFactory.WrapTemporal(Meos.TgeometryToTgeography(this.Ptr));

        public Temporal? ToTgeompoint()
            => MEOSFactory.WrapTemporal(Meos.TgeometryToTgeompoint(this.Ptr));

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(Meos.TgeometryFromMfjson(str));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TgeometryIn(str));

    }
}
