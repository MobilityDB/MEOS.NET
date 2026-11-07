#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TPoseChain class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TPoseChain : TSpatial
    {
        internal TPoseChain(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public int AlwaysEq(PoseChain posechain)
            => Meos.AlwaysEqTposechainPosechain(this.Ptr, posechain.Ptr);

        public int AlwaysEq(TPoseChain temp2)
            => Meos.AlwaysEqTposechainTposechain(this.Ptr, temp2.Ptr);

        public int AlwaysNe(PoseChain posechain)
            => Meos.AlwaysNeTposechainPosechain(this.Ptr, posechain.Ptr);

        public int AlwaysNe(TPoseChain temp2)
            => Meos.AlwaysNeTposechainTposechain(this.Ptr, temp2.Ptr);

        public string AsGeopose(int precision)
            => Meos.TposechainAsGeopose(this.Ptr, precision);

        public Temporal? AtValue(PoseChain pc)
            => MEOSFactory.WrapTemporal(Meos.TposechainAtValue(this.Ptr, pc.Ptr));

        public PoseChain? EndValue()
            => MEOSFactory.WrapPoseChain(Meos.TposechainEndValue(this.Ptr));

        public int EverEq(PoseChain posechain)
            => Meos.EverEqTposechainPosechain(this.Ptr, posechain.Ptr);

        public int EverEq(TPoseChain temp2)
            => Meos.EverEqTposechainTposechain(this.Ptr, temp2.Ptr);

        public int EverNe(PoseChain posechain)
            => Meos.EverNeTposechainPosechain(this.Ptr, posechain.Ptr);

        public int EverNe(TPoseChain temp2)
            => Meos.EverNeTposechainTposechain(this.Ptr, temp2.Ptr);

        public Temporal? MinusValue(PoseChain pc)
            => MEOSFactory.WrapTemporal(Meos.TposechainMinusValue(this.Ptr, pc.Ptr));

        public double Nad(Geo gs)
            => Meos.NadTposechainGeo(this.Ptr, gs.Ptr);

        public double Nad(PoseChain pc)
            => Meos.NadTposechainPosechain(this.Ptr, pc.Ptr);

        public double Nad(STBox box)
            => Meos.NadTposechainStbox(this.Ptr, box.Ptr);

        public double Nad(TPoseChain temp2)
            => Meos.NadTposechainTposechain(this.Ptr, temp2.Ptr);

        public Temporal? Nai(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.NaiTposechainGeo(this.Ptr, gs.Ptr));

        public Temporal? Nai(PoseChain pc)
            => MEOSFactory.WrapTemporal(Meos.NaiTposechainPosechain(this.Ptr, pc.Ptr));

        public Temporal? Nai(TPoseChain temp2)
            => MEOSFactory.WrapTemporal(Meos.NaiTposechainTposechain(this.Ptr, temp2.Ptr));

        public int NumPoses()
            => Meos.TposechainNumPoses(this.Ptr);

        public Temporal? Rotate(double angle, double x0, double y0)
            => MEOSFactory.WrapTemporal(Meos.TposechainRotate(this.Ptr, angle, x0, y0));

        public Temporal? RotateX(double angle)
            => MEOSFactory.WrapTemporal(Meos.TposechainRotateX(this.Ptr, angle));

        public Temporal? RotateY(double angle)
            => MEOSFactory.WrapTemporal(Meos.TposechainRotateY(this.Ptr, angle));

        public Temporal? RotateZ(double angle)
            => MEOSFactory.WrapTemporal(Meos.TposechainRotateZ(this.Ptr, angle));

        public Geo? Shortestline(Geo gs)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTposechainGeo(this.Ptr, gs.Ptr));

        public Geo? Shortestline(PoseChain pc)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTposechainPosechain(this.Ptr, pc.Ptr));

        public Geo? Shortestline(TPoseChain temp2)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTposechainTposechain(this.Ptr, temp2.Ptr));

        public PoseChain? StartValue()
            => MEOSFactory.WrapPoseChain(Meos.TposechainStartValue(this.Ptr));

        public Temporal? Tdistance(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTposechainGeo(this.Ptr, gs.Ptr));

        public Temporal? Tdistance(PoseChain pc)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTposechainPosechain(this.Ptr, pc.Ptr));

        public Temporal? Tdistance(TPoseChain temp2)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTposechainTposechain(this.Ptr, temp2.Ptr));

        public Temporal? Teq(PoseChain posechain)
            => MEOSFactory.WrapTemporal(Meos.TeqTposechainPosechain(this.Ptr, posechain.Ptr));

        public Temporal? Tne(PoseChain posechain)
            => MEOSFactory.WrapTemporal(Meos.TneTposechainPosechain(this.Ptr, posechain.Ptr));

        public Temporal? ToTpose()
            => MEOSFactory.WrapTemporal(Meos.TposechainToTpose(this.Ptr));

        public Temporal? Translate(double deltax, double deltay, double deltaz)
            => MEOSFactory.WrapTemporal(Meos.TposechainTranslate(this.Ptr, deltax, deltay, deltaz));

        public (SpanSet?[], PoseChain?[]) Unnest()
        {
            var _answered = Meos.TposechainUnnest(this.Ptr);

            return (MEOSFactory.WrapSpanSetArray(_answered.Item1), MEOSFactory.WrapPoseChainArray(_answered.Item2));
        }

        public PoseChain? Value()
            => MEOSFactory.WrapPoseChain(Meos.TposechainValue(this.Ptr));

        public PoseChain? ValueAtTimestamptz(DateTime t, bool strict)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TposechainValueAtTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict, _result))
                {
                    return null;
                }

                return MEOSFactory.WrapPoseChain(Marshal.ReadIntPtr(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public PoseChain? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TposechainValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSFactory.WrapPoseChain(Marshal.ReadIntPtr(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public PoseChain?[] Values()
            => MEOSFactory.WrapPoseChainArray(Meos.TposechainValues(this.Ptr));

        public static Temporal? FromBaseTemp(PoseChain pc, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.TposechainFromBaseTemp(pc.Ptr, temp.Ptr));

        public static Temporal? FromEWKB(byte[] wkb)
            => Temporal.FromWKB(wkb);

        public static Temporal? FromEWKT(string str)
            => TPoseChain.In(str);

        public static Temporal? FromGeopose(string json)
            => MEOSFactory.WrapTemporal(Meos.TposechainFromGeopose(json));

        public static Temporal? FromHexEWKB(string hexwkb)
            => Temporal.FromHexWKB(hexwkb);

        public static Temporal? FromMFJSON(string mfjson)
            => MEOSFactory.WrapTemporal(Meos.TposechainFromMfjson(mfjson));

        public static Temporal? FromText(string str)
            => TPoseChain.In(str);

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TposechainIn(str));

    }
}
