#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TGeomPoint class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TGeomPoint : TPoint
    {
        internal TGeomPoint(IntPtr ptr) : base(ptr) { }

        public (Temporal?[], ulong[]) H3indexSplit(int resolution, bool border_inc)
        {
            var _answered = Meos.TgeompointH3indexSplit(this.Ptr, resolution, border_inc);

            return (MEOSFactory.WrapTemporalArray(_answered.Item1), _answered.Item2);
        }

        public (Temporal?[], ulong[]) QuadbinSplit(int resolution, bool border_inc)
        {
            var _answered = Meos.TgeompointQuadbinSplit(this.Ptr, resolution, border_inc);

            return (MEOSFactory.WrapTemporalArray(_answered.Item1), _answered.Item2);
        }

        public (Temporal?[], ulong[]) S2cellSplit(int level, bool border_inc)
        {
            var _answered = Meos.TgeompointS2cellSplit(this.Ptr, level, border_inc);

            return (MEOSFactory.WrapTemporalArray(_answered.Item1), _answered.Item2);
        }

        public Temporal? ToTgeogpoint()
            => MEOSFactory.WrapTemporal(Meos.TgeompointToTgeogpoint(this.Ptr));

        public Temporal? ToTgeometry()
            => MEOSFactory.WrapTemporal(Meos.TgeompointToTgeometry(this.Ptr));

        public Temporal? ToTh3index(int resolution, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TgeompointToTh3index(this.Ptr, resolution, border_inc));

        public Temporal? ToTnpoint()
            => MEOSFactory.WrapTemporal(Meos.TgeompointToTnpoint(this.Ptr));

        public Temporal? ToTquadbin(int resolution, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TgeompointToTquadbin(this.Ptr, resolution, border_inc));

        public Temporal? ToTs2cell(int level, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TgeompointToTs2cell(this.Ptr, level, border_inc));

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(Meos.TgeompointFromMfjson(str));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TgeompointIn(str));

    }
}
