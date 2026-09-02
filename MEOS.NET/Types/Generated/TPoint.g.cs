#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>Temporal points. API-level intermediate (C predicate tpoint_type + the tpoint_* method family); NOT drawn in the manual Figure 7.1 (a conceptual diagram) but required so the tpoint_* methods bind to a class — see correction OM-M6.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TPoint : TGeo
    {
        internal TPoint(IntPtr ptr) : base(ptr) { }

        public Temporal? AngularDifference()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tpoint_angular_difference(this.Ptr));

        public Temporal? AtElevation(Span s)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tpoint_at_elevation(this.Ptr, s.Ptr));

        public Temporal? Azimuth()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tpoint_azimuth(this.Ptr));

        public Temporal? CumulativeLength()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tpoint_cumulative_length(this.Ptr));

        public Temporal? GetX()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tpoint_get_x(this.Ptr));

        public Temporal? GetY()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tpoint_get_y(this.Ptr));

        public Temporal? GetZ()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tpoint_get_z(this.Ptr));

        public bool IsSimple()
            => MEOSExposedFunctions.tpoint_is_simple(this.Ptr);

        public double Length()
            => MEOSExposedFunctions.tpoint_length(this.Ptr);

        public Temporal?[] MakeSimple()
            => MEOSFactory.WrapTemporalArray(MEOSExposedFunctions.tpoint_make_simple(this.Ptr));

        public Temporal? MinusElevation(Span s)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tpoint_minus_elevation(this.Ptr, s.Ptr));

        public Temporal? Speed()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tpoint_speed(this.Ptr));

    }
}
