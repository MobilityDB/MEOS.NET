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

        public string AsGeopose(int precision)
            => Meos.TposechainAsGeopose(this.Ptr, precision);

        public Temporal? AtValue(PoseChain pc)
            => MEOSFactory.WrapTemporal(Meos.TposechainAtValue(this.Ptr, pc.Ptr));

        public PoseChain? EndValue()
            => MEOSFactory.WrapPoseChain(Meos.TposechainEndValue(this.Ptr));

        public Temporal? MinusValue(PoseChain pc)
            => MEOSFactory.WrapTemporal(Meos.TposechainMinusValue(this.Ptr, pc.Ptr));

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

        public PoseChain? StartValue()
            => MEOSFactory.WrapPoseChain(Meos.TposechainStartValue(this.Ptr));

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
