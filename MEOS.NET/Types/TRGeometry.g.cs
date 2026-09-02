#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The TRGeometry class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TRGeometry : TSpatial
    {
        internal TRGeometry(IntPtr ptr) : base(ptr) { }

        public new Temporal? AfterTimestamptz(DateTime t, bool strict)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryAfterTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict));

        public Temporal? AngularSpeed()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryAngularSpeed(this.Ptr));

        public new Temporal? AppendTsequence(Temporal seq, bool expand)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryAppendTsequence(this.Ptr, seq.Ptr, expand));

        public new string AsEWKT(int maxdd)
            => Meos.TrgeometryAsEwkt(this.Ptr, maxdd);

        public new string AsText(int maxdd)
            => Meos.TrgeometryAsText(this.Ptr, maxdd);

        public new Temporal? AsTinstant()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryAsTinstant(this.Ptr));

        public Temporal? AsTsequence(string interp_str)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryAsTsequence(this.Ptr, interp_str));

        public Temporal? AsTsequenceset(string interp_str)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryAsTsequenceset(this.Ptr, interp_str));

        public Temporal? AtElevation(Span s)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryAtElevation(this.Ptr, s.Ptr));

        public Temporal? AtStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryAtStbox(this.Ptr, box.Ptr, border_inc));

        public new Temporal? AtTimestamptz(DateTime t)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryAtTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public new Temporal? AtTstzset(Set s)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryAtTstzset(this.Ptr, s.Ptr));

        public new Temporal? AtTstzspan(Span s)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryAtTstzspan(this.Ptr, s.Ptr));

        public new Temporal? AtTstzspanset(SpanSet ss)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryAtTstzspanset(this.Ptr, ss.Ptr));

        public new Temporal? AtValues(Set s)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryAtValues(this.Ptr, s.Ptr));

        public new Temporal? BeforeTimestamptz(DateTime t, bool strict)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryBeforeTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict));

        public Temporal? Centroid()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryCentroid(this.Ptr));

        public Temporal? CumulativeLength()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryCumulativeLength(this.Ptr));

        public new Temporal? DeleteTimestamptz(DateTime t, bool connect)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryDeleteTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), connect));

        public new Temporal? DeleteTstzset(Set s, bool connect)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryDeleteTstzset(this.Ptr, s.Ptr, connect));

        public new Temporal? DeleteTstzspan(Span s, bool connect)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryDeleteTstzspan(this.Ptr, s.Ptr, connect));

        public new Temporal? DeleteTstzspanset(SpanSet ss, bool connect)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryDeleteTstzspanset(this.Ptr, ss.Ptr, connect));

        public new double DyntimewarpDistance(Temporal temp2)
            => Meos.TrgeometryDyntimewarpDistance(this.Ptr, temp2.Ptr);

        public new Temporal? EndInstant()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryEndInstant(this.Ptr));

        public new Temporal? EndSequence()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryEndSequence(this.Ptr));

        public new double FrechetDistance(Temporal temp2)
            => Meos.TrgeometryFrechetDistance(this.Ptr, temp2.Ptr);

        public new double HausdorffDistance(Temporal temp2)
            => Meos.TrgeometryHausdorffDistance(this.Ptr, temp2.Ptr);

        public new Temporal? InstantN(int n)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryInstantN(this.Ptr, n));

        public new Temporal?[] Instants()
            => MEOSFactory.WrapTemporalArray(Meos.TrgeometryInstants(this.Ptr));

        public double Length()
            => Meos.TrgeometryLength(this.Ptr);

        public new Temporal? Merge(Temporal temp2)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryMerge(this.Ptr, temp2.Ptr));

        public Temporal? MinusElevation(Span s)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryMinusElevation(this.Ptr, s.Ptr));

        public Temporal? MinusStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryMinusStbox(this.Ptr, box.Ptr, border_inc));

        public new Temporal? MinusTimestamptz(DateTime t)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryMinusTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public new Temporal? MinusTstzset(Set s)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryMinusTstzset(this.Ptr, s.Ptr));

        public new Temporal? MinusTstzspan(Span s)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryMinusTstzspan(this.Ptr, s.Ptr));

        public new Temporal? MinusTstzspanset(SpanSet ss)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryMinusTstzspanset(this.Ptr, ss.Ptr));

        public new Temporal? MinusValues(Set s)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryMinusValues(this.Ptr, s.Ptr));

        public string Out()
            => Meos.TrgeometryOut(this.Ptr);

        public Temporal? Pitch()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryPitch(this.Ptr));

        public Set? Points()
            => MEOSFactory.WrapSet(Meos.TrgeometryPoints(this.Ptr));

        public Temporal? Roll()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryRoll(this.Ptr));

        public new Temporal? Round(int maxdd)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryRound(this.Ptr, maxdd));

        public new Temporal?[] Segments()
            => MEOSFactory.WrapTemporalArray(Meos.TrgeometrySegments(this.Ptr));

        public new Temporal? SequenceN(int i)
            => MEOSFactory.WrapTemporal(Meos.TrgeometrySequenceN(this.Ptr, i));

        public new Temporal?[] Sequences()
            => MEOSFactory.WrapTemporalArray(Meos.TrgeometrySequences(this.Ptr));

        public new Temporal? SetInterp(InterpType interp)
            => MEOSFactory.WrapTemporal(Meos.TrgeometrySetInterp(this.Ptr, (int) interp));

        public Temporal? Speed()
            => MEOSFactory.WrapTemporal(Meos.TrgeometrySpeed(this.Ptr));

        public new Temporal? StartInstant()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryStartInstant(this.Ptr));

        public new Temporal? StartSequence()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryStartSequence(this.Ptr));

        public Temporal? ToTgeometry()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryToTgeometry(this.Ptr));

        public Temporal? ToTgeompoint()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryToTgeompoint(this.Ptr));

        public Temporal? ToTpose()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryToTpose(this.Ptr));

        public Temporal? Yaw()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryYaw(this.Ptr));

        public static Temporal? FromMFJSON(string mfjson)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryFromMfjson(mfjson));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryIn(str));

    }
}
