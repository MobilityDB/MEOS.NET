#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TRGeometry class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TRGeometry : TSpatial
    {
        internal TRGeometry(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public new Temporal? AfterTimestamptz(DateTime t, bool strict)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryAfterTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict));

        public Temporal? AngularSpeed()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryAngularSpeed(this.Ptr));

        public new Temporal? AppendTinstant(Temporal inst, InterpType interp, double maxdist, Interval maxt, bool expand)
        {
            IntPtr _maxt = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(maxt, _maxt, false);
                return MEOSFactory.WrapTemporal(Meos.TrgeometryAppendTinstant(this.Ptr, inst.Ptr, (int) interp, maxdist, _maxt, expand));
            }
            finally
            {
                Marshal.FreeHGlobal(_maxt);
            }
        }

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

        public Temporal? AtGeom(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryAtGeom(this.Ptr, gs.Ptr));

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

        public Temporal? AtValue(Pose pose)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryAtValue(this.Ptr, pose.Ptr));

        public new Temporal? AtValues(Set s)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryAtValues(this.Ptr, s.Ptr));

        public new Temporal? BeforeTimestamptz(DateTime t, bool strict)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryBeforeTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict));

        public Temporal? BodyPointTrajectory(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryBodyPointTrajectory(this.Ptr, gs.Ptr));

        public Temporal? Centroid()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryCentroid(this.Ptr));

        public Geo? ConvexHull()
            => MEOSFactory.WrapGeo(Meos.TrgeometryConvexHull(this.Ptr));

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

        public new Match[] DyntimewarpPath(Temporal temp2)
            => MEOSConvert.ToStructArray<Match>(Meos.TrgeometryDyntimewarpPath(this.Ptr, temp2.Ptr));

        public new Temporal? EndInstant()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryEndInstant(this.Ptr));

        public new Temporal? EndSequence()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryEndSequence(this.Ptr));

        public Geo? EndValue()
            => MEOSFactory.WrapGeo(Meos.TrgeometryEndValue(this.Ptr));

        public new double FrechetDistance(Temporal temp2)
            => Meos.TrgeometryFrechetDistance(this.Ptr, temp2.Ptr);

        public new Match[] FrechetPath(Temporal temp2)
            => MEOSConvert.ToStructArray<Match>(Meos.TrgeometryFrechetPath(this.Ptr, temp2.Ptr));

        public Geo? Geom()
            => MEOSFactory.WrapGeo(Meos.TrgeometryGeom(this.Ptr));

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

        public Temporal? MinusGeom(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryMinusGeom(this.Ptr, gs.Ptr));

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

        public Temporal? MinusValue(Pose pose)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryMinusValue(this.Ptr, pose.Ptr));

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

        public STBox?[] SpaceBoxes(double xsize, double ysize, double zsize, Geo sorigin, bool bitmatrix, bool border_inc)
            => MEOSFactory.WrapSTBoxArray(Meos.TrgeometrySpaceBoxes(this.Ptr, xsize, ysize, zsize, sorigin.Ptr, bitmatrix, border_inc));

        public STBox?[] SpaceTimeBoxes(double xsize, double ysize, double zsize, Interval duration, Geo sorigin, DateTime torigin, bool bitmatrix, bool border_inc)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSTBoxArray(Meos.TrgeometrySpaceTimeBoxes(this.Ptr, xsize, ysize, zsize, _duration, sorigin.Ptr, MEOSConvert.ToTimestampTz(torigin), bitmatrix, border_inc));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public Temporal? Speed()
            => MEOSFactory.WrapTemporal(Meos.TrgeometrySpeed(this.Ptr));

        public STBox?[] SplitEachNStboxes(int elem_count)
            => MEOSFactory.WrapSTBoxArray(Meos.TrgeometrySplitEachNStboxes(this.Ptr, elem_count));

        public STBox?[] SplitNStboxes(int box_count)
            => MEOSFactory.WrapSTBoxArray(Meos.TrgeometrySplitNStboxes(this.Ptr, box_count));

        public new Temporal? StartInstant()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryStartInstant(this.Ptr));

        public new Temporal? StartSequence()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryStartSequence(this.Ptr));

        public Geo? StartValue()
            => MEOSFactory.WrapGeo(Meos.TrgeometryStartValue(this.Ptr));

        public STBox?[] Stboxes()
            => MEOSFactory.WrapSTBoxArray(Meos.TrgeometryStboxes(this.Ptr));

        public Temporal? ToTgeometry()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryToTgeometry(this.Ptr));

        public Temporal? ToTgeompoint()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryToTgeompoint(this.Ptr));

        public Temporal? ToTpose()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryToTpose(this.Ptr));

        public Geo? TraversedArea(bool unary_union)
            => MEOSFactory.WrapGeo(Meos.TrgeometryTraversedArea(this.Ptr, unary_union));

        public Geo? Twcentroid()
            => MEOSFactory.WrapGeo(Meos.TrgeometryTwcentroid(this.Ptr));

        public Geo? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TrgeometryValueN(this.Ptr, n, _result))
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

        public Temporal? Yaw()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryYaw(this.Ptr));

        public static Temporal? FromMFJSON(string mfjson)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryFromMfjson(mfjson));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryIn(str));

        public new static Temporal? MergeArray(Temporal[] temparr)
        {
            IntPtr[] _temparrValues = new IntPtr[temparr.Length];
            for (int i = 0; i < temparr.Length; i++)
            {
                _temparrValues[i] = temparr[i].Ptr;
            }

            GCHandle _temparr = GCHandle.Alloc(_temparrValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapTemporal(Meos.TrgeometryMergeArray(_temparr.AddrOfPinnedObject(), temparr.Length));
            }
            finally
            {
                _temparr.Free();
            }
        }

    }
}
