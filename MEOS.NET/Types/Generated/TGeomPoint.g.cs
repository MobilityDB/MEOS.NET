#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The TGeomPoint class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TGeomPoint : TPoint
    {
        internal TGeomPoint(IntPtr ptr) : base(ptr) { }

        public Temporal? ToTgeometry()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tgeompoint_to_tgeometry(this.Ptr));

        public Temporal? ToTh3index(int resolution)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tgeompoint_to_th3index(this.Ptr, resolution));

        public Temporal? ToTnpoint()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tgeompoint_to_tnpoint(this.Ptr));

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tgeompoint_from_mfjson(str));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tgeompoint_in(str));

    }
}
