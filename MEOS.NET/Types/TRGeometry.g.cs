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
            => this.AsText(15);

        public bool Above(TRGeometry temp2)
            => Meos.AboveTspatialTspatial(this.Ptr, temp2.Ptr);

        public int Acovers(Geometry gs)
            => Meos.AcoversTrgeometryGeo(this.Ptr, gs.Ptr);

        public int Adisjoint(Geometry gs)
            => Meos.AdisjointTrgeometryGeo(this.Ptr, gs.Ptr);

        public int Adisjoint(TRGeometry temp2)
            => Meos.AdisjointTrgeometryTrgeometry(this.Ptr, temp2.Ptr);

        public bool Adjacent(TRGeometry temp2)
            => Meos.AdjacentTspatialTspatial(this.Ptr, temp2.Ptr);

        public int Adwithin(Geometry gs, double dist)
            => Meos.AdwithinTrgeometryGeo(this.Ptr, gs.Ptr, dist);

        public int Adwithin(TRGeometry temp2, double dist)
            => Meos.AdwithinTrgeometryTrgeometry(this.Ptr, temp2.Ptr, dist);

        public bool After(TRGeometry temp2)
            => Meos.AfterTspatialTspatial(this.Ptr, temp2.Ptr);

        public new Temporal? AfterTimestamptz(DateTime t, bool strict)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryAfterTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict));

        public int Aintersects(Geometry gs)
            => Meos.AintersectsTrgeometryGeo(this.Ptr, gs.Ptr);

        public int Aintersects(TRGeometry temp2)
            => Meos.AintersectsTrgeometryTrgeometry(this.Ptr, temp2.Ptr);

        public int AlwaysEq(Geometry gs)
            => Meos.AlwaysEqTrgeometryGeo(this.Ptr, gs.Ptr);

        public int AlwaysEq(TRGeometry temp2)
            => Meos.AlwaysEqTrgeometryTrgeometry(this.Ptr, temp2.Ptr);

        public int AlwaysNe(Geometry gs)
            => Meos.AlwaysNeTrgeometryGeo(this.Ptr, gs.Ptr);

        public int AlwaysNe(TRGeometry temp2)
            => Meos.AlwaysNeTrgeometryTrgeometry(this.Ptr, temp2.Ptr);

        public Temporal? AngularSpeed()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryAngularSpeed(this.Ptr));

        public new Temporal? AppendTinstant(Temporal inst, string interp, double maxdist, Interval maxt, bool expand)
        {
            IntPtr _maxt = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(maxt, _maxt, false);
                return MEOSFactory.WrapTemporal(Meos.TrgeometryAppendTinstant(this.Ptr, inst.Ptr, Meos.InterptypeFromString(interp), maxdist, _maxt, expand));
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

        public new Temporal? AsTsequence(string interp_str)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryAsTsequence(this.Ptr, interp_str));

        public new Temporal? AsTsequenceset(string interp_str)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryAsTsequenceset(this.Ptr, interp_str));

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

        public int Atouches(Geometry gs)
            => Meos.AtouchesTrgeometryGeo(this.Ptr, gs.Ptr);

        public bool Back(TRGeometry temp2)
            => Meos.BackTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Before(TRGeometry temp2)
            => Meos.BeforeTspatialTspatial(this.Ptr, temp2.Ptr);

        public new Temporal? BeforeTimestamptz(DateTime t, bool strict)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryBeforeTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict));

        public bool Below(TRGeometry temp2)
            => Meos.BelowTspatialTspatial(this.Ptr, temp2.Ptr);

        public Temporal? BodyPointTrajectory(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryBodyPointTrajectory(this.Ptr, gs.Ptr));

        public Temporal? Centroid()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryCentroid(this.Ptr));

        public bool Contained(TRGeometry temp2)
            => Meos.ContainedTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Contains(TRGeometry temp2)
            => Meos.ContainsTspatialTspatial(this.Ptr, temp2.Ptr);

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

        public int Ecovers(Geometry gs)
            => Meos.EcoversTrgeometryGeo(this.Ptr, gs.Ptr);

        public int Edisjoint(Geometry gs)
            => Meos.EdisjointTrgeometryGeo(this.Ptr, gs.Ptr);

        public int Edisjoint(TRGeometry temp2)
            => Meos.EdisjointTrgeometryTrgeometry(this.Ptr, temp2.Ptr);

        public int Edwithin(Geometry gs, double dist)
            => Meos.EdwithinTrgeometryGeo(this.Ptr, gs.Ptr, dist);

        public int Edwithin(TRGeometry temp2, double dist)
            => Meos.EdwithinTrgeometryTrgeometry(this.Ptr, temp2.Ptr, dist);

        public int Eintersects(Geometry gs)
            => Meos.EintersectsTrgeometryGeo(this.Ptr, gs.Ptr);

        public int Eintersects(TRGeometry temp2)
            => Meos.EintersectsTrgeometryTrgeometry(this.Ptr, temp2.Ptr);

        public new Temporal? EndInstant()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryEndInstant(this.Ptr));

        public new Temporal? EndSequence()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryEndSequence(this.Ptr));

        public Geo? EndValue()
            => MEOSFactory.WrapGeo(Meos.TrgeometryEndValue(this.Ptr));

        public int Etouches(Geometry gs)
            => Meos.EtouchesTrgeometryGeo(this.Ptr, gs.Ptr);

        public int EverEq(Geometry gs)
            => Meos.EverEqTrgeometryGeo(this.Ptr, gs.Ptr);

        public int EverEq(TRGeometry temp2)
            => Meos.EverEqTrgeometryTrgeometry(this.Ptr, temp2.Ptr);

        public int EverNe(Geometry gs)
            => Meos.EverNeTrgeometryGeo(this.Ptr, gs.Ptr);

        public int EverNe(TRGeometry temp2)
            => Meos.EverNeTrgeometryTrgeometry(this.Ptr, temp2.Ptr);

        public Temporal? Force2d()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryForce2d(this.Ptr));

        public bool Front(TRGeometry temp2)
            => Meos.FrontTspatialTspatial(this.Ptr, temp2.Ptr);

        public Geo? Geom()
            => MEOSFactory.WrapGeo(Meos.TrgeometryGeom(this.Ptr));

        public new Temporal? InstantN(int n)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryInstantN(this.Ptr, n));

        public new Temporal?[] Instants()
            => MEOSFactory.WrapTemporalArray(Meos.TrgeometryInstants(this.Ptr));

        public bool Left(TRGeometry temp2)
            => Meos.LeftTspatialTspatial(this.Ptr, temp2.Ptr);

        public double Length()
            => Meos.TrgeometryLength(this.Ptr);

        public new Temporal? Merge(Temporal temp2)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryMerge(this.Ptr, temp2.Ptr));

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

        public double Nad(Geometry gs)
            => Meos.NadTrgeometryGeo(this.Ptr, gs.Ptr);

        public double Nad(STBox box)
            => Meos.NadTrgeometryStbox(this.Ptr, box.Ptr);

        public double Nad(TGeomPoint temp2)
            => Meos.NadTrgeometryTpoint(this.Ptr, temp2.Ptr);

        public double Nad(TRGeometry temp2)
            => Meos.NadTrgeometryTrgeometry(this.Ptr, temp2.Ptr);

        public Temporal? Nai(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.NaiTrgeometryGeo(this.Ptr, gs.Ptr));

        public Temporal? Nai(TGeomPoint temp2)
            => MEOSFactory.WrapTemporal(Meos.NaiTrgeometryTpoint(this.Ptr, temp2.Ptr));

        public Temporal? Nai(TRGeometry temp2)
            => MEOSFactory.WrapTemporal(Meos.NaiTrgeometryTrgeometry(this.Ptr, temp2.Ptr));

        public string Out()
            => Meos.TrgeometryOut(this.Ptr);

        public bool Overabove(TRGeometry temp2)
            => Meos.OveraboveTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overafter(TRGeometry temp2)
            => Meos.OverafterTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overback(TRGeometry temp2)
            => Meos.OverbackTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overbefore(TRGeometry temp2)
            => Meos.OverbeforeTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overbelow(TRGeometry temp2)
            => Meos.OverbelowTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overfront(TRGeometry temp2)
            => Meos.OverfrontTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overlaps(TRGeometry temp2)
            => Meos.OverlapsTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overleft(TRGeometry temp2)
            => Meos.OverleftTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overright(TRGeometry temp2)
            => Meos.OverrightTspatialTspatial(this.Ptr, temp2.Ptr);

        public Temporal? Pitch()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryPitch(this.Ptr));

        public Set? Points()
            => MEOSFactory.WrapSet(Meos.TrgeometryPoints(this.Ptr));

        public bool Right(TRGeometry temp2)
            => Meos.RightTspatialTspatial(this.Ptr, temp2.Ptr);

        public Temporal? Roll()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryRoll(this.Ptr));

        public Temporal? Rotate(double angle, double x0, double y0)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryRotate(this.Ptr, angle, x0, y0));

        public Temporal? RotateX(double angle)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryRotateX(this.Ptr, angle));

        public Temporal? RotateY(double angle)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryRotateY(this.Ptr, angle));

        public Temporal? RotateZ(double angle)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryRotateZ(this.Ptr, angle));

        public new Temporal? Round(int maxdd)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryRound(this.Ptr, maxdd));

        public bool Same(TRGeometry temp2)
            => Meos.SameTspatialTspatial(this.Ptr, temp2.Ptr);

        public new Temporal?[] Segments()
            => MEOSFactory.WrapTemporalArray(Meos.TrgeometrySegments(this.Ptr));

        public new Temporal? SequenceN(int i)
            => MEOSFactory.WrapTemporal(Meos.TrgeometrySequenceN(this.Ptr, i));

        public new Temporal?[] Sequences()
            => MEOSFactory.WrapTemporalArray(Meos.TrgeometrySequences(this.Ptr));

        public new Temporal? SetInterp(string interp)
            => MEOSFactory.WrapTemporal(Meos.TrgeometrySetInterp(this.Ptr, Meos.InterptypeFromString(interp)));

        public Geo? Shortestline(Geometry gs)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTrgeometryGeo(this.Ptr, gs.Ptr));

        public Geo? Shortestline(TGeomPoint temp2)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTrgeometryTpoint(this.Ptr, temp2.Ptr));

        public Geo? Shortestline(TRGeometry temp2)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTrgeometryTrgeometry(this.Ptr, temp2.Ptr));

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

        public Temporal? Tdisjoint(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TdisjointTrgeometryGeo(this.Ptr, gs.Ptr));

        public Temporal? Tdisjoint(TRGeometry temp2)
            => MEOSFactory.WrapTemporal(Meos.TdisjointTrgeometryTrgeometry(this.Ptr, temp2.Ptr));

        public Temporal? Tdistance(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTrgeometryGeo(this.Ptr, gs.Ptr));

        public Temporal? Tdistance(TGeomPoint temp2)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTrgeometryTpoint(this.Ptr, temp2.Ptr));

        public Temporal? Tdistance(TRGeometry temp2)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTrgeometryTrgeometry(this.Ptr, temp2.Ptr));

        public Temporal? Tdwithin(Geometry gs, double dist)
            => MEOSFactory.WrapTemporal(Meos.TdwithinTrgeometryGeo(this.Ptr, gs.Ptr, dist));

        public Temporal? Tdwithin(TRGeometry temp2, double dist)
            => MEOSFactory.WrapTemporal(Meos.TdwithinTrgeometryTrgeometry(this.Ptr, temp2.Ptr, dist));

        public Temporal? Teq(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TeqTrgeometryGeo(this.Ptr, gs.Ptr));

        public Temporal? Teq(TRGeometry temp2)
            => MEOSFactory.WrapTemporal(Meos.TeqTemporalTemporal(this.Ptr, temp2.Ptr));

        public STBox?[] TimeBoxes(Interval duration, DateTime torigin, bool bitmatrix, bool border_inc)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSTBoxArray(Meos.TrgeometryTimeBoxes(this.Ptr, _duration, MEOSConvert.ToTimestampTz(torigin), bitmatrix, border_inc));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public Temporal? Tintersects(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TintersectsTrgeometryGeo(this.Ptr, gs.Ptr));

        public Temporal? Tintersects(TRGeometry temp2)
            => MEOSFactory.WrapTemporal(Meos.TintersectsTrgeometryTrgeometry(this.Ptr, temp2.Ptr));

        public Temporal? Tne(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TneTrgeometryGeo(this.Ptr, gs.Ptr));

        public Temporal? Tne(TRGeometry temp2)
            => MEOSFactory.WrapTemporal(Meos.TneTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? ToTgeogpoint()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryToTgeogpoint(this.Ptr));

        public Temporal? ToTgeography()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryToTgeography(this.Ptr));

        public Temporal? ToTgeometry()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryToTgeometry(this.Ptr));

        public Temporal? ToTgeompoint()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryToTgeompoint(this.Ptr));

        public Temporal? ToTpose()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryToTpose(this.Ptr));

        public Temporal? Translate(double deltax, double deltay, double deltaz)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryTranslate(this.Ptr, deltax, deltay, deltaz));

        public Geo? TraversedArea(bool unary_union)
            => MEOSFactory.WrapGeo(Meos.TrgeometryTraversedArea(this.Ptr, unary_union));

        public Geo? Twcentroid()
            => MEOSFactory.WrapGeo(Meos.TrgeometryTwcentroid(this.Ptr));

        public (SpanSet?[], Geo?[]) Unnest()
        {
            var _answered = Meos.TrgeometryUnnest(this.Ptr);

            return (MEOSFactory.WrapSpanSetArray(_answered.Item1), MEOSFactory.WrapGeoArray(_answered.Item2));
        }

        public Pose? Value()
            => MEOSFactory.WrapPose(Meos.TrgeometryValue(this.Ptr));

        public Geo? ValueAtTimestamptz(DateTime t, bool strict)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TrgeometryValueAtTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict, _result))
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

        public Pose?[] Values()
            => MEOSFactory.WrapPoseArray(Meos.TrgeometryValues(this.Ptr));

        public Temporal? Yaw()
            => MEOSFactory.WrapTemporal(Meos.TrgeometryYaw(this.Ptr));

        public static Temporal? FromEWKB(byte[] wkb)
            => Temporal.FromWKB(wkb);

        public static Temporal? FromEWKT(string str)
            => TRGeometry.In(str);

        public static Temporal? FromHexEWKB(string hexwkb)
            => Temporal.FromHexWKB(hexwkb);

        public static Temporal? FromMFJSON(string mfjson)
            => MEOSFactory.WrapTemporal(Meos.TrgeometryFromMfjson(mfjson));

        public static Temporal? FromText(string str)
            => TRGeometry.In(str);

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
