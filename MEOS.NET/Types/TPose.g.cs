#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The TPose class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TPose : TSpatial
    {
        internal TPose(IntPtr ptr) : base(ptr) { }

        public Temporal? AngularSpeed()
            => MEOSFactory.WrapTemporal(Meos.TposeAngularSpeed(this.Ptr));

        public string AsGeopose(int conformance, int precision)
            => Meos.TposeAsGeopose(this.Ptr, conformance, precision);

        public string AsGeoposeStream(int precision)
            => Meos.TposeAsGeoposeStream(this.Ptr, precision);

        public string AsGeoposeStreamElement(Temporal inst, int precision)
            => Meos.TposeAsGeoposeStreamElement(this.Ptr, inst.Ptr, precision);

        public Temporal? AtElevation(Span s)
            => MEOSFactory.WrapTemporal(Meos.TposeAtElevation(this.Ptr, s.Ptr));

        public Temporal? AtStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TposeAtStbox(this.Ptr, box.Ptr, border_inc));

        public Temporal? ComposeTpose(Temporal frame)
            => MEOSFactory.WrapTemporal(Meos.TposeComposeTpose(this.Ptr, frame.Ptr));

        public Temporal? Inverse()
            => MEOSFactory.WrapTemporal(Meos.TposeInverse(this.Ptr));

        public Temporal? Make(Temporal ttheta)
            => MEOSFactory.WrapTemporal(Meos.TposeMake(this.Ptr, ttheta.Ptr));

        public Temporal? MinusElevation(Span s)
            => MEOSFactory.WrapTemporal(Meos.TposeMinusElevation(this.Ptr, s.Ptr));

        public Temporal? MinusStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TposeMinusStbox(this.Ptr, box.Ptr, border_inc));

        public Temporal? Pitch()
            => MEOSFactory.WrapTemporal(Meos.TposePitch(this.Ptr));

        public Set? Points()
            => MEOSFactory.WrapSet(Meos.TposePoints(this.Ptr));

        public Temporal? Roll()
            => MEOSFactory.WrapTemporal(Meos.TposeRoll(this.Ptr));

        public Temporal? Speed()
            => MEOSFactory.WrapTemporal(Meos.TposeSpeed(this.Ptr));

        public Temporal? ToTpoint()
            => MEOSFactory.WrapTemporal(Meos.TposeToTpoint(this.Ptr));

        public Temporal? Yaw()
            => MEOSFactory.WrapTemporal(Meos.TposeYaw(this.Ptr));

        public static Temporal? FromGeopose(string json)
            => MEOSFactory.WrapTemporal(Meos.TposeFromGeopose(json));

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(Meos.TposeFromMfjson(str));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TposeIn(str));

    }
}
