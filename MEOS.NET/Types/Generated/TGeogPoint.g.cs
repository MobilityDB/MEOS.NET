#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The TGeogPoint class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TGeogPoint : TPoint
    {
        internal TGeogPoint(IntPtr ptr) : base(ptr) { }

        public Temporal? GreatCircleDistance(Temporal b)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tgeogpoint_great_circle_distance(this.Ptr, b.Ptr));

        public Temporal? ToTgeography()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tgeogpoint_to_tgeography(this.Ptr));

        public Temporal? ToTh3index(int resolution)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tgeogpoint_to_th3index(this.Ptr, resolution));

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tgeogpoint_from_mfjson(str));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tgeogpoint_in(str));

    }
}
