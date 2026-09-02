#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>Superclass of every temporal type; temporal_* functions are late-bound over `subtype` and `temptype`.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Temporal : MEOSObject
    {
        internal Temporal(IntPtr ptr) : base(ptr) { }

        public Temporal? AfterTimestamptz(DateTime t, bool strict)
            => MEOSFactory.WrapTemporal(Meos.TemporalAfterTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict));

        public Temporal? AppendTsequence(Temporal seq, bool expand)
            => MEOSFactory.WrapTemporal(Meos.TemporalAppendTsequence(this.Ptr, seq.Ptr, expand));

        public string AsMFJSON(bool with_bbox, int flags, int precision, string srs)
            => Meos.TemporalAsMfjson(this.Ptr, with_bbox, flags, precision, srs);

        public Temporal? AsTinstant()
            => MEOSFactory.WrapTemporal(Meos.TemporalAsTinstant(this.Ptr));

        public Temporal? AsTsequence(InterpType interp)
            => MEOSFactory.WrapTemporal(Meos.TemporalAsTsequence(this.Ptr, (int) interp));

        public Temporal? AsTsequenceset(InterpType interp)
            => MEOSFactory.WrapTemporal(Meos.TemporalAsTsequenceset(this.Ptr, (int) interp));

        public Temporal? AtMax()
            => MEOSFactory.WrapTemporal(Meos.TemporalAtMax(this.Ptr));

        public Temporal? AtMin()
            => MEOSFactory.WrapTemporal(Meos.TemporalAtMin(this.Ptr));

        public Temporal? AtTimestamptz(DateTime t)
            => MEOSFactory.WrapTemporal(Meos.TemporalAtTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public Temporal? AtTstzset(Set s)
            => MEOSFactory.WrapTemporal(Meos.TemporalAtTstzset(this.Ptr, s.Ptr));

        public Temporal? AtTstzspan(Span s)
            => MEOSFactory.WrapTemporal(Meos.TemporalAtTstzspan(this.Ptr, s.Ptr));

        public Temporal? AtTstzspanset(SpanSet ss)
            => MEOSFactory.WrapTemporal(Meos.TemporalAtTstzspanset(this.Ptr, ss.Ptr));

        public Temporal? AtValues(Set set)
            => MEOSFactory.WrapTemporal(Meos.TemporalAtValues(this.Ptr, set.Ptr));

        public double AverageHausdorffDistance(Temporal temp2)
            => Meos.TemporalAverageHausdorffDistance(this.Ptr, temp2.Ptr);

        public string? BasetypeName()
            => Meos.TemporalBasetypeName(this.Ptr);

        public Temporal? BeforeTimestamptz(DateTime t, bool strict)
            => MEOSFactory.WrapTemporal(Meos.TemporalBeforeTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict));

        public int Cmp(Temporal temp2)
            => Meos.TemporalCmp(this.Ptr, temp2.Ptr);

        public Temporal? Copy()
            => MEOSFactory.WrapTemporal(Meos.TemporalCopy(this.Ptr));

        public Temporal? DeleteTimestamptz(DateTime t, bool connect)
            => MEOSFactory.WrapTemporal(Meos.TemporalDeleteTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), connect));

        public Temporal? DeleteTstzset(Set s, bool connect)
            => MEOSFactory.WrapTemporal(Meos.TemporalDeleteTstzset(this.Ptr, s.Ptr, connect));

        public Temporal? DeleteTstzspan(Span s, bool connect)
            => MEOSFactory.WrapTemporal(Meos.TemporalDeleteTstzspan(this.Ptr, s.Ptr, connect));

        public Temporal? DeleteTstzspanset(SpanSet ss, bool connect)
            => MEOSFactory.WrapTemporal(Meos.TemporalDeleteTstzspanset(this.Ptr, ss.Ptr, connect));

        public Temporal? Derivative()
            => MEOSFactory.WrapTemporal(Meos.TemporalDerivative(this.Ptr));

        public double DyntimewarpDistance(Temporal temp2)
            => Meos.TemporalDyntimewarpDistance(this.Ptr, temp2.Ptr);

        public Temporal? EndInstant()
            => MEOSFactory.WrapTemporal(Meos.TemporalEndInstant(this.Ptr));

        public Temporal? EndSequence()
            => MEOSFactory.WrapTemporal(Meos.TemporalEndSequence(this.Ptr));

        public DateTime EndTimestamptz()
            => MEOSConvert.ToDateTime(Meos.TemporalEndTimestamptz(this.Ptr));

        public bool Eq(Temporal temp2)
            => Meos.TemporalEq(this.Ptr, temp2.Ptr);

        public Temporal? ExtKalmanFilter(double gate, double q, double variance, bool to_drop)
            => MEOSFactory.WrapTemporal(Meos.TemporalExtKalmanFilter(this.Ptr, gate, q, variance, to_drop));

        public double FrechetDistance(Temporal temp2)
            => Meos.TemporalFrechetDistance(this.Ptr, temp2.Ptr);

        public bool Ge(Temporal temp2)
            => Meos.TemporalGe(this.Ptr, temp2.Ptr);

        public bool Gt(Temporal temp2)
            => Meos.TemporalGt(this.Ptr, temp2.Ptr);

        public uint Hash()
            => Meos.TemporalHash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => Meos.TemporalHashExtended(this.Ptr, seed);

        public double HausdorffDistance(Temporal temp2)
            => Meos.TemporalHausdorffDistance(this.Ptr, temp2.Ptr);

        public Temporal? Insert(Temporal temp2, bool connect)
            => MEOSFactory.WrapTemporal(Meos.TemporalInsert(this.Ptr, temp2.Ptr, connect));

        public Temporal? InstantN(int n)
            => MEOSFactory.WrapTemporal(Meos.TemporalInstantN(this.Ptr, n));

        public Temporal?[] Instants()
            => MEOSFactory.WrapTemporalArray(Meos.TemporalInstants(this.Ptr));

        public string? Interp()
            => Meos.TemporalInterp(this.Ptr);

        public double LcssDistance(Temporal temp2, double epsilon)
            => Meos.TemporalLcssDistance(this.Ptr, temp2.Ptr, epsilon);

        public bool Le(Temporal temp2)
            => Meos.TemporalLe(this.Ptr, temp2.Ptr);

        public bool LowerInc()
            => Meos.TemporalLowerInc(this.Ptr);

        public bool Lt(Temporal temp2)
            => Meos.TemporalLt(this.Ptr, temp2.Ptr);

        public Temporal? MaxInstant()
            => MEOSFactory.WrapTemporal(Meos.TemporalMaxInstant(this.Ptr));

        public Temporal? Merge(Temporal temp2)
            => MEOSFactory.WrapTemporal(Meos.TemporalMerge(this.Ptr, temp2.Ptr));

        public Temporal? MinInstant()
            => MEOSFactory.WrapTemporal(Meos.TemporalMinInstant(this.Ptr));

        public Temporal? MinusMax()
            => MEOSFactory.WrapTemporal(Meos.TemporalMinusMax(this.Ptr));

        public Temporal? MinusMin()
            => MEOSFactory.WrapTemporal(Meos.TemporalMinusMin(this.Ptr));

        public Temporal? MinusTimestamptz(DateTime t)
            => MEOSFactory.WrapTemporal(Meos.TemporalMinusTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public Temporal? MinusTstzset(Set s)
            => MEOSFactory.WrapTemporal(Meos.TemporalMinusTstzset(this.Ptr, s.Ptr));

        public Temporal? MinusTstzspan(Span s)
            => MEOSFactory.WrapTemporal(Meos.TemporalMinusTstzspan(this.Ptr, s.Ptr));

        public Temporal? MinusTstzspanset(SpanSet ss)
            => MEOSFactory.WrapTemporal(Meos.TemporalMinusTstzspanset(this.Ptr, ss.Ptr));

        public Temporal? MinusValues(Set set)
            => MEOSFactory.WrapTemporal(Meos.TemporalMinusValues(this.Ptr, set.Ptr));

        public bool Ne(Temporal temp2)
            => Meos.TemporalNe(this.Ptr, temp2.Ptr);

        public int NumInstants()
            => Meos.TemporalNumInstants(this.Ptr);

        public int NumSequences()
            => Meos.TemporalNumSequences(this.Ptr);

        public int NumTimestamps()
            => Meos.TemporalNumTimestamps(this.Ptr);

        public Temporal? Round(int maxdd)
            => MEOSFactory.WrapTemporal(Meos.TemporalRound(this.Ptr, maxdd));

        public Temporal?[] Segments()
            => MEOSFactory.WrapTemporalArray(Meos.TemporalSegments(this.Ptr));

        public Temporal? SequenceN(int i)
            => MEOSFactory.WrapTemporal(Meos.TemporalSequenceN(this.Ptr, i));

        public Temporal?[] Sequences()
            => MEOSFactory.WrapTemporalArray(Meos.TemporalSequences(this.Ptr));

        public Temporal? SetInterp(InterpType interp)
            => MEOSFactory.WrapTemporal(Meos.TemporalSetInterp(this.Ptr, (int) interp));

        public Temporal? SimplifyDp(double dist, bool synchronized)
            => MEOSFactory.WrapTemporal(Meos.TemporalSimplifyDp(this.Ptr, dist, synchronized));

        public Temporal? SimplifyMaxDist(double dist, bool synchronized)
            => MEOSFactory.WrapTemporal(Meos.TemporalSimplifyMaxDist(this.Ptr, dist, synchronized));

        public Temporal? SimplifyMinDist(double dist)
            => MEOSFactory.WrapTemporal(Meos.TemporalSimplifyMinDist(this.Ptr, dist));

        public Temporal? StartInstant()
            => MEOSFactory.WrapTemporal(Meos.TemporalStartInstant(this.Ptr));

        public Temporal? StartSequence()
            => MEOSFactory.WrapTemporal(Meos.TemporalStartSequence(this.Ptr));

        public DateTime StartTimestamptz()
            => MEOSConvert.ToDateTime(Meos.TemporalStartTimestamptz(this.Ptr));

        public string? Subtype()
            => Meos.TemporalSubtype(this.Ptr);

        public SpanSet? Time()
            => MEOSFactory.WrapSpanSet(Meos.TemporalTime(this.Ptr));

        public long[] Timestamps()
            => Meos.TemporalTimestamps(this.Ptr);

        public Span? ToTstzspan()
            => MEOSFactory.WrapSpan(Meos.TemporalToTstzspan(this.Ptr));

        public Temporal? Update(Temporal temp2, bool connect)
            => MEOSFactory.WrapTemporal(Meos.TemporalUpdate(this.Ptr, temp2.Ptr, connect));

        public bool UpperInc()
            => Meos.TemporalUpperInc(this.Ptr);

        public static Temporal? FromHEXWKB(string hexwkb)
            => MEOSFactory.WrapTemporal(Meos.TemporalFromHexwkb(hexwkb));

    }
}
