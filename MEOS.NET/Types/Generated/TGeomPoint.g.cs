#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The TGeomPoint class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TGeomPoint : TPoint
    {
        internal TGeomPoint(IntPtr ptr) : base(ptr) { }

        public Temporal? ToTgeometry()
            => MEOSFactory.WrapTemporal(Meos.TgeompointToTgeometry(this.Ptr));

        public Temporal? ToTh3index(int resolution)
            => MEOSFactory.WrapTemporal(Meos.TgeompointToTh3index(this.Ptr, resolution));

        public Temporal? ToTnpoint()
            => MEOSFactory.WrapTemporal(Meos.TgeompointToTnpoint(this.Ptr));

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(Meos.TgeompointFromMfjson(str));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TgeompointIn(str));

    }
}
