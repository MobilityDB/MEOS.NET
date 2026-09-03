#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>Temporal points. API-level intermediate (C predicate tpoint_type + the tpoint_* method family); NOT drawn in the manual Figure 7.1 (a conceptual diagram) but required so the tpoint_* methods bind to a class — see correction OM-M6.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TPoint : TGeo
    {
        internal TPoint(IntPtr ptr) : base(ptr) { }

        public Temporal? AngularDifference()
            => MEOSFactory.WrapTemporal(Meos.TpointAngularDifference(this.Ptr));

        public MvtGeom AsMvtgeom(STBox bounds, int extent, int buffer, bool clip_geom)
            => Meos.TpointAsMvtgeom(this.Ptr, bounds.Ptr, extent, buffer, clip_geom);

        public Temporal? AtElevation(Span s)
            => MEOSFactory.WrapTemporal(Meos.TpointAtElevation(this.Ptr, s.Ptr));

        public new Temporal? AtGeom(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TpointAtGeom(this.Ptr, gs.Ptr));

        public new Temporal? AtValue(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TpointAtValue(this.Ptr, gs.Ptr));

        public Temporal? Azimuth()
            => MEOSFactory.WrapTemporal(Meos.TpointAzimuth(this.Ptr));

        public Temporal? CumulativeLength()
            => MEOSFactory.WrapTemporal(Meos.TpointCumulativeLength(this.Ptr));

        public double? Direction()
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TpointDirection(this.Ptr, _result))
                {
                    return null;
                }

                return Marshal.PtrToStructure<double>(_result);
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

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

        public new Temporal? MinusGeom(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TpointMinusGeom(this.Ptr, gs.Ptr));

        public new Temporal? MinusValue(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TpointMinusValue(this.Ptr, gs.Ptr));

        public Temporal? Speed()
            => MEOSFactory.WrapTemporal(Meos.TpointSpeed(this.Ptr));

        public Geo? TfloatToGeomeas(Temporal measure, bool segmentize)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TpointTfloatToGeomeas(this.Ptr, measure.Ptr, segmentize, _result))
                {
                    return null;
                }

                return MEOSFactory.WrapGeo(Marshal.ReadIntPtr(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public Geo? Trajectory(bool unary_union)
            => MEOSFactory.WrapGeo(Meos.TpointTrajectory(this.Ptr, unary_union));

        public Geo? Twcentroid()
            => MEOSFactory.WrapGeo(Meos.TpointTwcentroid(this.Ptr));

        public new static Temporal? FromBaseTemp(Geo gs, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.TpointFromBaseTemp(gs.Ptr, temp.Ptr));

    }
}
