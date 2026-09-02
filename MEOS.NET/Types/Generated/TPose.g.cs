#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The TPose class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TPose : TSpatial
    {
        internal TPose(IntPtr ptr) : base(ptr) { }

        public Temporal? AngularSpeed()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tpose_angular_speed(this.Ptr));

        public string AsGeopose(int conformance, int precision)
            => MEOSExposedFunctions.tpose_as_geopose(this.Ptr, conformance, precision);

        public string AsGeoposeStream(int precision)
            => MEOSExposedFunctions.tpose_as_geopose_stream(this.Ptr, precision);

        public string AsGeoposeStreamElement(Temporal inst, int precision)
            => MEOSExposedFunctions.tpose_as_geopose_stream_element(this.Ptr, inst.Ptr, precision);

        public Temporal? AtElevation(Span s)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tpose_at_elevation(this.Ptr, s.Ptr));

        public Temporal? AtStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tpose_at_stbox(this.Ptr, box.Ptr, border_inc));

        public Temporal? ComposeTpose(Temporal frame)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tpose_compose_tpose(this.Ptr, frame.Ptr));

        public Temporal? Inverse()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tpose_inverse(this.Ptr));

        public Temporal? Make(Temporal ttheta)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tpose_make(this.Ptr, ttheta.Ptr));

        public Temporal? MinusElevation(Span s)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tpose_minus_elevation(this.Ptr, s.Ptr));

        public Temporal? MinusStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tpose_minus_stbox(this.Ptr, box.Ptr, border_inc));

        public Temporal? Pitch()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tpose_pitch(this.Ptr));

        public Set? Points()
            => MEOSFactory.WrapSet(MEOSExposedFunctions.tpose_points(this.Ptr));

        public Temporal? Roll()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tpose_roll(this.Ptr));

        public Temporal? Speed()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tpose_speed(this.Ptr));

        public Temporal? ToTpoint()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tpose_to_tpoint(this.Ptr));

        public Temporal? Yaw()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tpose_yaw(this.Ptr));

        public static Temporal? FromGeopose(string json)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tpose_from_geopose(json));

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tpose_from_mfjson(str));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tpose_in(str));

    }
}
