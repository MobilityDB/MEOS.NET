#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The TRGeometry class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TRGeometry : TSpatial
    {
        internal TRGeometry(IntPtr ptr) : base(ptr) { }

        public new Temporal? AfterTimestamptz(DateTime t, bool strict)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_after_timestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict));

        public Temporal? AngularSpeed()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_angular_speed(this.Ptr));

        public new Temporal? AppendTsequence(Temporal seq, bool expand)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_append_tsequence(this.Ptr, seq.Ptr, expand));

        public new string AsEWKT(int maxdd)
            => MEOSExposedFunctions.trgeometry_as_ewkt(this.Ptr, maxdd);

        public new string AsText(int maxdd)
            => MEOSExposedFunctions.trgeometry_as_text(this.Ptr, maxdd);

        public new Temporal? AsTinstant()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_as_tinstant(this.Ptr));

        public Temporal? AsTsequence(string interp_str)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_as_tsequence(this.Ptr, interp_str));

        public Temporal? AsTsequenceset(string interp_str)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_as_tsequenceset(this.Ptr, interp_str));

        public Temporal? AtElevation(Span s)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_at_elevation(this.Ptr, s.Ptr));

        public Temporal? AtStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_at_stbox(this.Ptr, box.Ptr, border_inc));

        public new Temporal? AtTimestamptz(DateTime t)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_at_timestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public new Temporal? AtTstzset(Set s)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_at_tstzset(this.Ptr, s.Ptr));

        public new Temporal? AtTstzspan(Span s)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_at_tstzspan(this.Ptr, s.Ptr));

        public new Temporal? AtTstzspanset(SpanSet ss)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_at_tstzspanset(this.Ptr, ss.Ptr));

        public new Temporal? AtValues(Set s)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_at_values(this.Ptr, s.Ptr));

        public new Temporal? BeforeTimestamptz(DateTime t, bool strict)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_before_timestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict));

        public Temporal? Centroid()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_centroid(this.Ptr));

        public Temporal? CumulativeLength()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_cumulative_length(this.Ptr));

        public new Temporal? DeleteTimestamptz(DateTime t, bool connect)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_delete_timestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), connect));

        public new Temporal? DeleteTstzset(Set s, bool connect)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_delete_tstzset(this.Ptr, s.Ptr, connect));

        public new Temporal? DeleteTstzspan(Span s, bool connect)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_delete_tstzspan(this.Ptr, s.Ptr, connect));

        public new Temporal? DeleteTstzspanset(SpanSet ss, bool connect)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_delete_tstzspanset(this.Ptr, ss.Ptr, connect));

        public new double DyntimewarpDistance(Temporal temp2)
            => MEOSExposedFunctions.trgeometry_dyntimewarp_distance(this.Ptr, temp2.Ptr);

        public new Temporal? EndInstant()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_end_instant(this.Ptr));

        public new Temporal? EndSequence()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_end_sequence(this.Ptr));

        public new double FrechetDistance(Temporal temp2)
            => MEOSExposedFunctions.trgeometry_frechet_distance(this.Ptr, temp2.Ptr);

        public new double HausdorffDistance(Temporal temp2)
            => MEOSExposedFunctions.trgeometry_hausdorff_distance(this.Ptr, temp2.Ptr);

        public new Temporal? InstantN(int n)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_instant_n(this.Ptr, n));

        public new Temporal?[] Instants()
            => MEOSFactory.WrapTemporalArray(MEOSExposedFunctions.trgeometry_instants(this.Ptr));

        public double Length()
            => MEOSExposedFunctions.trgeometry_length(this.Ptr);

        public new Temporal? Merge(Temporal temp2)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_merge(this.Ptr, temp2.Ptr));

        public Temporal? MinusElevation(Span s)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_minus_elevation(this.Ptr, s.Ptr));

        public Temporal? MinusStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_minus_stbox(this.Ptr, box.Ptr, border_inc));

        public new Temporal? MinusTimestamptz(DateTime t)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_minus_timestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public new Temporal? MinusTstzset(Set s)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_minus_tstzset(this.Ptr, s.Ptr));

        public new Temporal? MinusTstzspan(Span s)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_minus_tstzspan(this.Ptr, s.Ptr));

        public new Temporal? MinusTstzspanset(SpanSet ss)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_minus_tstzspanset(this.Ptr, ss.Ptr));

        public new Temporal? MinusValues(Set s)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_minus_values(this.Ptr, s.Ptr));

        public string Out()
            => MEOSExposedFunctions.trgeometry_out(this.Ptr);

        public Temporal? Pitch()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_pitch(this.Ptr));

        public Set? Points()
            => MEOSFactory.WrapSet(MEOSExposedFunctions.trgeometry_points(this.Ptr));

        public Temporal? Roll()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_roll(this.Ptr));

        public new Temporal? Round(int maxdd)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_round(this.Ptr, maxdd));

        public new Temporal?[] Segments()
            => MEOSFactory.WrapTemporalArray(MEOSExposedFunctions.trgeometry_segments(this.Ptr));

        public new Temporal? SequenceN(int i)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_sequence_n(this.Ptr, i));

        public new Temporal?[] Sequences()
            => MEOSFactory.WrapTemporalArray(MEOSExposedFunctions.trgeometry_sequences(this.Ptr));

        public new Temporal? SetInterp(InterpolationType interp)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_set_interp(this.Ptr, (int) interp));

        public Temporal? Speed()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_speed(this.Ptr));

        public new Temporal? StartInstant()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_start_instant(this.Ptr));

        public new Temporal? StartSequence()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_start_sequence(this.Ptr));

        public Temporal? ToTgeometry()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_to_tgeometry(this.Ptr));

        public Temporal? ToTgeompoint()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_to_tgeompoint(this.Ptr));

        public Temporal? ToTpose()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_to_tpose(this.Ptr));

        public Temporal? Yaw()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_yaw(this.Ptr));

        public static Temporal? FromMFJSON(string mfjson)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_from_mfjson(mfjson));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.trgeometry_in(str));

    }
}
