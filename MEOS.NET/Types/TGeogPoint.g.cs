#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The TGeogPoint class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TGeogPoint : TPoint
    {
        internal TGeogPoint(IntPtr ptr) : base(ptr) { }

        public Temporal? GreatCircleDistance(Temporal b)
            => MEOSFactory.WrapTemporal(Meos.TgeogpointGreatCircleDistance(this.Ptr, b.Ptr));

        public Temporal? ToTgeography()
            => MEOSFactory.WrapTemporal(Meos.TgeogpointToTgeography(this.Ptr));

        public Temporal? ToTh3index(int resolution)
            => MEOSFactory.WrapTemporal(Meos.TgeogpointToTh3index(this.Ptr, resolution));

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(Meos.TgeogpointFromMfjson(str));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TgeogpointIn(str));

    }
}
