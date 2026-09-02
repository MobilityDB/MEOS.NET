#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>Temporal points. API-level intermediate (C predicate tpoint_type + the tpoint_* method family); NOT drawn in the manual Figure 7.1 (a conceptual diagram) but required so the tpoint_* methods bind to a class — see correction OM-M6.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TPoint : TGeo
    {
        internal TPoint(IntPtr ptr) : base(ptr) { }

        public Temporal? AngularDifference()
            => MEOSFactory.WrapTemporal(Meos.TpointAngularDifference(this.Ptr));

        public Temporal? AtElevation(Span s)
            => MEOSFactory.WrapTemporal(Meos.TpointAtElevation(this.Ptr, s.Ptr));

        public Temporal? Azimuth()
            => MEOSFactory.WrapTemporal(Meos.TpointAzimuth(this.Ptr));

        public Temporal? CumulativeLength()
            => MEOSFactory.WrapTemporal(Meos.TpointCumulativeLength(this.Ptr));

        public Temporal? GetX()
            => MEOSFactory.WrapTemporal(Meos.TpointGetX(this.Ptr));

        public Temporal? GetY()
            => MEOSFactory.WrapTemporal(Meos.TpointGetY(this.Ptr));

        public Temporal? GetZ()
            => MEOSFactory.WrapTemporal(Meos.TpointGetZ(this.Ptr));

        public bool IsSimple()
            => Meos.TpointIsSimple(this.Ptr);

        public double Length()
            => Meos.TpointLength(this.Ptr);

        public Temporal?[] MakeSimple()
            => MEOSFactory.WrapTemporalArray(Meos.TpointMakeSimple(this.Ptr));

        public Temporal? MinusElevation(Span s)
            => MEOSFactory.WrapTemporal(Meos.TpointMinusElevation(this.Ptr, s.Ptr));

        public Temporal? Speed()
            => MEOSFactory.WrapTemporal(Meos.TpointSpeed(this.Ptr));

    }
}
