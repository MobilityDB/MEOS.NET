#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>Superclass of every temporal type; temporal_* functions are late-bound over `subtype` and `temptype`.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Temporal : MEOSObject
    {
        internal Temporal(IntPtr ptr) : base(ptr) { }

        public Temporal? AfterTimestamptz(DateTime t, bool strict)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_after_timestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict));

        public Temporal? AppendTsequence(Temporal seq, bool expand)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_append_tsequence(this.Ptr, seq.Ptr, expand));

        public string AsMFJSON(bool with_bbox, int flags, int precision, string srs)
            => MEOSExposedFunctions.temporal_as_mfjson(this.Ptr, with_bbox, flags, precision, srs);

        public Temporal? AsTinstant()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_as_tinstant(this.Ptr));

        public Temporal? AsTsequence(InterpolationType interp)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_as_tsequence(this.Ptr, (int) interp));

        public Temporal? AsTsequenceset(InterpolationType interp)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_as_tsequenceset(this.Ptr, (int) interp));

        public Temporal? AtMax()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_at_max(this.Ptr));

        public Temporal? AtMin()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_at_min(this.Ptr));

        public Temporal? AtTimestamptz(DateTime t)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_at_timestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public Temporal? AtTstzset(Set s)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_at_tstzset(this.Ptr, s.Ptr));

        public Temporal? AtTstzspan(Span s)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_at_tstzspan(this.Ptr, s.Ptr));

        public Temporal? AtTstzspanset(SpanSet ss)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_at_tstzspanset(this.Ptr, ss.Ptr));

        public Temporal? AtValues(Set set)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_at_values(this.Ptr, set.Ptr));

        public double AverageHausdorffDistance(Temporal temp2)
            => MEOSExposedFunctions.temporal_average_hausdorff_distance(this.Ptr, temp2.Ptr);

        public string? BasetypeName()
            => MEOSExposedFunctions.temporal_basetype_name(this.Ptr);

        public Temporal? BeforeTimestamptz(DateTime t, bool strict)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_before_timestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict));

        public int Cmp(Temporal temp2)
            => MEOSExposedFunctions.temporal_cmp(this.Ptr, temp2.Ptr);

        public Temporal? Copy()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_copy(this.Ptr));

        public Temporal? DeleteTimestamptz(DateTime t, bool connect)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_delete_timestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), connect));

        public Temporal? DeleteTstzset(Set s, bool connect)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_delete_tstzset(this.Ptr, s.Ptr, connect));

        public Temporal? DeleteTstzspan(Span s, bool connect)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_delete_tstzspan(this.Ptr, s.Ptr, connect));

        public Temporal? DeleteTstzspanset(SpanSet ss, bool connect)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_delete_tstzspanset(this.Ptr, ss.Ptr, connect));

        public Temporal? Derivative()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_derivative(this.Ptr));

        public double DyntimewarpDistance(Temporal temp2)
            => MEOSExposedFunctions.temporal_dyntimewarp_distance(this.Ptr, temp2.Ptr);

        public Temporal? EndInstant()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_end_instant(this.Ptr));

        public Temporal? EndSequence()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_end_sequence(this.Ptr));

        public DateTime EndTimestamptz()
            => MEOSConvert.ToDateTime(MEOSExposedFunctions.temporal_end_timestamptz(this.Ptr));

        public bool Eq(Temporal temp2)
            => MEOSExposedFunctions.temporal_eq(this.Ptr, temp2.Ptr);

        public Temporal? ExtKalmanFilter(double gate, double q, double variance, bool to_drop)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_ext_kalman_filter(this.Ptr, gate, q, variance, to_drop));

        public double FrechetDistance(Temporal temp2)
            => MEOSExposedFunctions.temporal_frechet_distance(this.Ptr, temp2.Ptr);

        public bool Ge(Temporal temp2)
            => MEOSExposedFunctions.temporal_ge(this.Ptr, temp2.Ptr);

        public bool Gt(Temporal temp2)
            => MEOSExposedFunctions.temporal_gt(this.Ptr, temp2.Ptr);

        public uint Hash()
            => MEOSExposedFunctions.temporal_hash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => MEOSExposedFunctions.temporal_hash_extended(this.Ptr, seed);

        public double HausdorffDistance(Temporal temp2)
            => MEOSExposedFunctions.temporal_hausdorff_distance(this.Ptr, temp2.Ptr);

        public Temporal? Insert(Temporal temp2, bool connect)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_insert(this.Ptr, temp2.Ptr, connect));

        public Temporal? InstantN(int n)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_instant_n(this.Ptr, n));

        public Temporal?[] Instants()
            => MEOSFactory.WrapTemporalArray(MEOSExposedFunctions.temporal_instants(this.Ptr));

        public string? Interp()
            => MEOSExposedFunctions.temporal_interp(this.Ptr);

        public double LcssDistance(Temporal temp2, double epsilon)
            => MEOSExposedFunctions.temporal_lcss_distance(this.Ptr, temp2.Ptr, epsilon);

        public bool Le(Temporal temp2)
            => MEOSExposedFunctions.temporal_le(this.Ptr, temp2.Ptr);

        public bool LowerInc()
            => MEOSExposedFunctions.temporal_lower_inc(this.Ptr);

        public bool Lt(Temporal temp2)
            => MEOSExposedFunctions.temporal_lt(this.Ptr, temp2.Ptr);

        public Temporal? MaxInstant()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_max_instant(this.Ptr));

        public Temporal? Merge(Temporal temp2)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_merge(this.Ptr, temp2.Ptr));

        public Temporal? MinInstant()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_min_instant(this.Ptr));

        public Temporal? MinusMax()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_minus_max(this.Ptr));

        public Temporal? MinusMin()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_minus_min(this.Ptr));

        public Temporal? MinusTimestamptz(DateTime t)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_minus_timestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public Temporal? MinusTstzset(Set s)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_minus_tstzset(this.Ptr, s.Ptr));

        public Temporal? MinusTstzspan(Span s)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_minus_tstzspan(this.Ptr, s.Ptr));

        public Temporal? MinusTstzspanset(SpanSet ss)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_minus_tstzspanset(this.Ptr, ss.Ptr));

        public Temporal? MinusValues(Set set)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_minus_values(this.Ptr, set.Ptr));

        public bool Ne(Temporal temp2)
            => MEOSExposedFunctions.temporal_ne(this.Ptr, temp2.Ptr);

        public int NumInstants()
            => MEOSExposedFunctions.temporal_num_instants(this.Ptr);

        public int NumSequences()
            => MEOSExposedFunctions.temporal_num_sequences(this.Ptr);

        public int NumTimestamps()
            => MEOSExposedFunctions.temporal_num_timestamps(this.Ptr);

        public Temporal? Round(int maxdd)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_round(this.Ptr, maxdd));

        public Temporal?[] Segments()
            => MEOSFactory.WrapTemporalArray(MEOSExposedFunctions.temporal_segments(this.Ptr));

        public Temporal? SequenceN(int i)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_sequence_n(this.Ptr, i));

        public Temporal?[] Sequences()
            => MEOSFactory.WrapTemporalArray(MEOSExposedFunctions.temporal_sequences(this.Ptr));

        public Temporal? SetInterp(InterpolationType interp)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_set_interp(this.Ptr, (int) interp));

        public Temporal? SimplifyDp(double dist, bool synchronized)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_simplify_dp(this.Ptr, dist, synchronized));

        public Temporal? SimplifyMaxDist(double dist, bool synchronized)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_simplify_max_dist(this.Ptr, dist, synchronized));

        public Temporal? SimplifyMinDist(double dist)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_simplify_min_dist(this.Ptr, dist));

        public Temporal? StartInstant()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_start_instant(this.Ptr));

        public Temporal? StartSequence()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_start_sequence(this.Ptr));

        public DateTime StartTimestamptz()
            => MEOSConvert.ToDateTime(MEOSExposedFunctions.temporal_start_timestamptz(this.Ptr));

        public string? Subtype()
            => MEOSExposedFunctions.temporal_subtype(this.Ptr);

        public SpanSet? Time()
            => MEOSFactory.WrapSpanSet(MEOSExposedFunctions.temporal_time(this.Ptr));

        public long[] Timestamps()
            => MEOSExposedFunctions.temporal_timestamps(this.Ptr);

        public Span? ToTstzspan()
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.temporal_to_tstzspan(this.Ptr));

        public Temporal? Update(Temporal temp2, bool connect)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_update(this.Ptr, temp2.Ptr, connect));

        public bool UpperInc()
            => MEOSExposedFunctions.temporal_upper_inc(this.Ptr);

        public static Temporal? FromHEXWKB(string hexwkb)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.temporal_from_hexwkb(hexwkb));

    }
}
