#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TGeogPoint class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TGeogPoint : TPoint
    {
        internal TGeogPoint(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public Temporal? GreatCircleDistance(Temporal b)
            => MEOSFactory.WrapTemporal(Meos.TgeogpointGreatCircleDistance(this.Ptr, b.Ptr));

        public (Temporal?[], ulong[]) H3indexSplit(int resolution, bool border_inc)
        {
            var _answered = Meos.TgeogpointH3indexSplit(this.Ptr, resolution, border_inc);

            return (MEOSFactory.WrapTemporalArray(_answered.Item1), _answered.Item2);
        }

        public (Temporal?[], ulong[]) QuadbinSplit(int resolution, bool border_inc)
        {
            var _answered = Meos.TgeogpointQuadbinSplit(this.Ptr, resolution, border_inc);

            return (MEOSFactory.WrapTemporalArray(_answered.Item1), _answered.Item2);
        }

        public (Temporal?[], ulong[]) S2cellSplit(int level, bool border_inc)
        {
            var _answered = Meos.TgeogpointS2cellSplit(this.Ptr, level, border_inc);

            return (MEOSFactory.WrapTemporalArray(_answered.Item1), _answered.Item2);
        }

        public Temporal? ToTgeography()
            => MEOSFactory.WrapTemporal(Meos.TgeogpointToTgeography(this.Ptr));

        public Temporal? ToTgeompoint()
            => MEOSFactory.WrapTemporal(Meos.TgeogpointToTgeompoint(this.Ptr));

        public Temporal? ToTh3index(int resolution, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TgeogpointToTh3index(this.Ptr, resolution, border_inc));

        public Temporal? ToTquadbin(int resolution, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TgeogpointToTquadbin(this.Ptr, resolution, border_inc));

        public Temporal? ToTs2cell(int level, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TgeogpointToTs2cell(this.Ptr, level, border_inc));

        public static Temporal? FromEWKB(byte[] wkb)
            => Temporal.FromWKB(wkb);

        public static Temporal? FromEWKT(string str)
            => TGeogPoint.In(str);

        public static Temporal? FromHexEWKB(string hexwkb)
            => Temporal.FromHexWKB(hexwkb);

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(Meos.TgeogpointFromMfjson(str));

        public static Temporal? FromText(string str)
            => TGeogPoint.In(str);

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TgeogpointIn(str));

    }
}
