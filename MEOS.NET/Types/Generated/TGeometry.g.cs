#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The TGeometry class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TGeometry : TGeo
    {
        internal TGeometry(IntPtr ptr) : base(ptr) { }

        public Temporal? ToTcbuffer()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tgeometry_to_tcbuffer(this.Ptr));

        public Temporal? ToTgeography()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tgeometry_to_tgeography(this.Ptr));

        public Temporal? ToTgeompoint()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tgeometry_to_tgeompoint(this.Ptr));

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tgeometry_from_mfjson(str));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tgeometry_in(str));

    }
}
