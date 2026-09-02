#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The TGeography class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TGeography : TGeo
    {
        internal TGeography(IntPtr ptr) : base(ptr) { }

        public Temporal? ToTgeogpoint()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tgeography_to_tgeogpoint(this.Ptr));

        public Temporal? ToTgeometry()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tgeography_to_tgeometry(this.Ptr));

        public static Temporal? FromMFJSON(string mfjson)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tgeography_from_mfjson(mfjson));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tgeography_in(str));

    }
}
