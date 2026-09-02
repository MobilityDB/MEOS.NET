#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Structures;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>meos_internal_geo.h</c> declares.</summary>
    public static partial class Meos
    {
        public static IntPtr MeosProjGetContext()
            => SafeExecution<IntPtr>(() => Native.MeosProjGetContext());

        public static IntPtr GeosGetContext()
            => SafeExecution<IntPtr>(() => Native.GeosGetContext());

        public static long DatumGeoRound(long value, long size)
            => SafeExecution<long>(() => Native.DatumGeoRound(value, size));

        public static IntPtr PointRound(IntPtr gs, int maxdd)
            => SafeExecution<IntPtr>(() => Native.PointRound(gs, maxdd));

        public static void StboxSet(bool hasx, bool hasz, bool geodetic, int srid, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, IntPtr s, IntPtr result)
            => SafeExecution(() => Native.StboxSet(hasx, hasz, geodetic, srid, xmin, xmax, ymin, ymax, zmin, zmax, s, result));

        public static void GboxSetStbox(IntPtr box, int srid, IntPtr result)
            => SafeExecution(() => Native.GboxSetStbox(box, srid, result));

        public static bool GeoSetStbox(IntPtr gs, IntPtr result)
            => SafeExecution<bool>(() => Native.GeoSetStbox(gs, result));

        public static void GeoarrSetStbox(IntPtr values, int count, IntPtr result)
            => SafeExecution(() => Native.GeoarrSetStbox(values, count, result));

        public static bool SpatialSetStbox(long d, int basetype, IntPtr result)
            => SafeExecution<bool>(() => Native.SpatialSetStbox(d, basetype, result));

        public static void SpatialsetSetStbox(IntPtr set, IntPtr result)
            => SafeExecution(() => Native.SpatialsetSetStbox(set, result));

        public static long DistanceSpatialsetValue(IntPtr s, long value)
            => SafeExecution<long>(() => Native.DistanceSpatialsetValue(s, value));

        public static long DistanceSpatialsetSpatialset(IntPtr s1, IntPtr s2)
            => SafeExecution<long>(() => Native.DistanceSpatialsetSpatialset(s1, s2));

        public static void StboxSetBox3d(IntPtr box, IntPtr result)
            => SafeExecution(() => Native.StboxSetBox3d(box, result));

        public static void StboxSetGbox(IntPtr box, IntPtr result)
            => SafeExecution(() => Native.StboxSetGbox(box, result));

        public static void TstzsetSetStbox(IntPtr s, IntPtr result)
            => SafeExecution(() => Native.TstzsetSetStbox(s, result));

        public static void TimestamptzSetStbox(long t, IntPtr result)
            => SafeExecution(() => Native.TimestamptzSetStbox(t, result));

        public static void TstzspanSetStbox(IntPtr s, IntPtr result)
            => SafeExecution(() => Native.TstzspanSetStbox(s, result));

        public static void TstzspansetSetStbox(IntPtr s, IntPtr result)
            => SafeExecution(() => Native.TstzspansetSetStbox(s, result));

        public static void StboxExpand(IntPtr box1, IntPtr box2)
            => SafeExecution(() => Native.StboxExpand(box1, box2));

        public static bool StboxExpandSpaceSet(IntPtr box, double d, IntPtr result)
            => SafeExecution<bool>(() => Native.StboxExpandSpaceSet(box, d, result));

        public static bool StboxContains(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.StboxContains(box1, box2));

        public static bool StboxContained(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.StboxContained(box1, box2));

        public static bool StboxOverlaps(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.StboxOverlaps(box1, box2));

        public static bool StboxSame(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.StboxSame(box1, box2));

        public static bool StboxAdjacent(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.StboxAdjacent(box1, box2));

        public static bool StboxLeft(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.StboxLeft(box1, box2));

        public static bool StboxRight(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.StboxRight(box1, box2));

        public static bool StboxOverleft(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.StboxOverleft(box1, box2));

        public static bool StboxOverright(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.StboxOverright(box1, box2));

        public static bool StboxBelow(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.StboxBelow(box1, box2));

        public static bool StboxAbove(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.StboxAbove(box1, box2));

        public static bool StboxOverbelow(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.StboxOverbelow(box1, box2));

        public static bool StboxOverabove(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.StboxOverabove(box1, box2));

        public static bool StboxFront(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.StboxFront(box1, box2));

        public static bool StboxBack(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.StboxBack(box1, box2));

        public static bool StboxOverfront(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.StboxOverfront(box1, box2));

        public static bool StboxOverback(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.StboxOverback(box1, box2));

        public static bool StboxBefore(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.StboxBefore(box1, box2));

        public static bool StboxAfter(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.StboxAfter(box1, box2));

        public static bool StboxOverbefore(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.StboxOverbefore(box1, box2));

        public static bool StboxOverafter(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.StboxOverafter(box1, box2));

        public static bool InterStboxStbox(IntPtr box1, IntPtr box2, IntPtr result)
            => SafeExecution<bool>(() => Native.InterStboxStbox(box1, box2, result));

        public static IntPtr StboxGeo(IntPtr box)
            => SafeExecution<IntPtr>(() => Native.StboxGeo(box));

        public static IntPtr TgeogpointinstFromMfjson(IntPtr mfjson, int srid)
            => SafeExecution<IntPtr>(() => Native.TgeogpointinstFromMfjson(mfjson, srid));

        public static IntPtr TgeogpointinstIn(string str)
            => SafeExecution<IntPtr>(() => Native.TgeogpointinstIn(str));

        public static IntPtr TgeogpointseqFromMfjson(IntPtr mfjson, int srid, int interp)
            => SafeExecution<IntPtr>(() => Native.TgeogpointseqFromMfjson(mfjson, srid, interp));

        public static IntPtr TgeogpointseqIn(string str, int interp)
            => SafeExecution<IntPtr>(() => Native.TgeogpointseqIn(str, interp));

        public static IntPtr TgeogpointseqsetFromMfjson(IntPtr mfjson, int srid, int interp)
            => SafeExecution<IntPtr>(() => Native.TgeogpointseqsetFromMfjson(mfjson, srid, interp));

        public static IntPtr TgeogpointseqsetIn(string str)
            => SafeExecution<IntPtr>(() => Native.TgeogpointseqsetIn(str));

        public static IntPtr TgeompointinstFromMfjson(IntPtr mfjson, int srid)
            => SafeExecution<IntPtr>(() => Native.TgeompointinstFromMfjson(mfjson, srid));

        public static IntPtr TgeompointinstIn(string str)
            => SafeExecution<IntPtr>(() => Native.TgeompointinstIn(str));

        public static IntPtr TgeompointseqFromMfjson(IntPtr mfjson, int srid, int interp)
            => SafeExecution<IntPtr>(() => Native.TgeompointseqFromMfjson(mfjson, srid, interp));

        public static IntPtr TgeompointseqIn(string str, int interp)
            => SafeExecution<IntPtr>(() => Native.TgeompointseqIn(str, interp));

        public static IntPtr TgeompointseqsetFromMfjson(IntPtr mfjson, int srid, int interp)
            => SafeExecution<IntPtr>(() => Native.TgeompointseqsetFromMfjson(mfjson, srid, interp));

        public static IntPtr TgeompointseqsetIn(string str)
            => SafeExecution<IntPtr>(() => Native.TgeompointseqsetIn(str));

        public static IntPtr TgeographyinstFromMfjson(IntPtr mfjson, int srid)
            => SafeExecution<IntPtr>(() => Native.TgeographyinstFromMfjson(mfjson, srid));

        public static IntPtr TgeographyinstIn(string str)
            => SafeExecution<IntPtr>(() => Native.TgeographyinstIn(str));

        public static IntPtr TgeographyseqFromMfjson(IntPtr mfjson, int srid, int interp)
            => SafeExecution<IntPtr>(() => Native.TgeographyseqFromMfjson(mfjson, srid, interp));

        public static IntPtr TgeographyseqIn(string str, int interp)
            => SafeExecution<IntPtr>(() => Native.TgeographyseqIn(str, interp));

        public static IntPtr TgeographyseqsetFromMfjson(IntPtr mfjson, int srid, int interp)
            => SafeExecution<IntPtr>(() => Native.TgeographyseqsetFromMfjson(mfjson, srid, interp));

        public static IntPtr TgeographyseqsetIn(string str)
            => SafeExecution<IntPtr>(() => Native.TgeographyseqsetIn(str));

        public static IntPtr TgeometryinstFromMfjson(IntPtr mfjson, int srid)
            => SafeExecution<IntPtr>(() => Native.TgeometryinstFromMfjson(mfjson, srid));

        public static IntPtr TgeometryinstIn(string str)
            => SafeExecution<IntPtr>(() => Native.TgeometryinstIn(str));

        public static IntPtr TgeometryseqFromMfjson(IntPtr mfjson, int srid, int interp)
            => SafeExecution<IntPtr>(() => Native.TgeometryseqFromMfjson(mfjson, srid, interp));

        public static IntPtr TgeometryseqIn(string str, int interp)
            => SafeExecution<IntPtr>(() => Native.TgeometryseqIn(str, interp));

        public static IntPtr TgeometryseqsetFromMfjson(IntPtr mfjson, int srid, int interp)
            => SafeExecution<IntPtr>(() => Native.TgeometryseqsetFromMfjson(mfjson, srid, interp));

        public static IntPtr TgeometryseqsetIn(string str)
            => SafeExecution<IntPtr>(() => Native.TgeometryseqsetIn(str));

        public static void TspatialSetStbox(IntPtr temp, IntPtr result)
            => SafeExecution(() => Native.TspatialSetStbox(temp, result));

        public static void TgeoinstSetStbox(IntPtr inst, IntPtr box)
            => SafeExecution(() => Native.TgeoinstSetStbox(inst, box));

        public static void TspatialseqSetStbox(IntPtr seq, IntPtr box)
            => SafeExecution(() => Native.TspatialseqSetStbox(seq, box));

        public static void TspatialseqsetSetStbox(IntPtr ss, IntPtr box)
            => SafeExecution(() => Native.TspatialseqsetSetStbox(ss, box));

        public static IntPtr TgeoRestrictElevation(IntPtr temp, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TgeoRestrictElevation(temp, s, atfunc));

        public static IntPtr TgeoRestrictGeom(IntPtr temp, IntPtr gs, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TgeoRestrictGeom(temp, gs, atfunc));

        public static IntPtr TgeoRestrictStbox(IntPtr temp, IntPtr box, bool border_inc, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TgeoRestrictStbox(temp, box, border_inc, atfunc));

        public static IntPtr TgeoinstRestrictGeom(IntPtr inst, IntPtr gs, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TgeoinstRestrictGeom(inst, gs, atfunc));

        public static IntPtr TgeoinstRestrictStbox(IntPtr inst, IntPtr box, bool border_inc, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TgeoinstRestrictStbox(inst, box, border_inc, atfunc));

        public static IntPtr TgeoseqRestrictGeom(IntPtr seq, IntPtr gs, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TgeoseqRestrictGeom(seq, gs, atfunc));

        public static IntPtr TgeoseqRestrictStbox(IntPtr seq, IntPtr box, bool border_inc, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TgeoseqRestrictStbox(seq, box, border_inc, atfunc));

        public static IntPtr TgeoseqsetRestrictGeom(IntPtr ss, IntPtr gs, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TgeoseqsetRestrictGeom(ss, gs, atfunc));

        public static IntPtr TgeoseqsetRestrictStbox(IntPtr ss, IntPtr box, bool border_inc, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TgeoseqsetRestrictStbox(ss, box, border_inc, atfunc));

        public static IntPtr GeoEdgeCtxMake(IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.GeoEdgeCtxMake(gs));

        public static void GeoEdgeCtxFree(IntPtr ctx)
            => SafeExecution(() => Native.GeoEdgeCtxFree(ctx));

        public static bool GeoIntersects2d(IntPtr gs1, IntPtr gs2)
            => SafeExecution<bool>(() => Native.GeoIntersects2d(gs1, gs2));

        public static bool GeoIntersects2dCtx(IntPtr gs, IntPtr ctx)
            => SafeExecution<bool>(() => Native.GeoIntersects2dCtx(gs, ctx));

        public static bool GeoCovers2d(IntPtr gs1, IntPtr gs2)
            => SafeExecution<bool>(() => Native.GeoCovers2d(gs1, gs2));

        public static IntPtr TpointLinearInterGeom(IntPtr temp, IntPtr gs, bool clip)
            => SafeExecution<IntPtr>(() => Native.TpointLinearInterGeom(temp, gs, clip));

        public static IntPtr TpointLinearInterGeomCtx(IntPtr temp, IntPtr ctx, bool clip)
            => SafeExecution<IntPtr>(() => Native.TpointLinearInterGeomCtx(temp, ctx, clip));

        public static IntPtr TpointLinearDwithinGeom(IntPtr temp, IntPtr gs, double dist)
            => SafeExecution<IntPtr>(() => Native.TpointLinearDwithinGeom(temp, gs, dist));

        public static IntPtr TpointLinearDwithinGeomCtx(IntPtr temp, IntPtr ctx, double dist)
            => SafeExecution<IntPtr>(() => Native.TpointLinearDwithinGeomCtx(temp, ctx, dist));

        public static IntPtr TpointLinearDistanceGeom(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TpointLinearDistanceGeom(temp, gs));

        public static IntPtr TpointLinearRestrictGeom(IntPtr temp, IntPtr gs, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TpointLinearRestrictGeom(temp, gs, atfunc));

        public static bool GeomMeosSupported(IntPtr geom)
            => SafeExecution<bool>(() => Native.GeomMeosSupported(geom));

        public static int SpatialSrid(long d, int basetype)
            => SafeExecution<int>(() => Native.SpatialSrid(d, basetype));

        public static bool SpatialSetSrid(long d, int basetype, int srid)
            => SafeExecution<bool>(() => Native.SpatialSetSrid(d, basetype, srid));

        public static int TspatialinstSrid(IntPtr inst)
            => SafeExecution<int>(() => Native.TspatialinstSrid(inst));

        public static IntPtr TpointseqAzimuth(IntPtr seq)
            => SafeExecution<IntPtr>(() => Native.TpointseqAzimuth(seq));

        public static IntPtr TpointseqCumulativeLength(IntPtr seq, double prevlength)
            => SafeExecution<IntPtr>(() => Native.TpointseqCumulativeLength(seq, prevlength));

        public static bool TpointseqIsSimple(IntPtr seq)
            => SafeExecution<bool>(() => Native.TpointseqIsSimple(seq));

        public static double TpointseqLength(IntPtr seq)
            => SafeExecution<double>(() => Native.TpointseqLength(seq));

        public static IntPtr TpointseqLinearTrajectory(IntPtr seq, bool unary_union)
            => SafeExecution<IntPtr>(() => Native.TpointseqLinearTrajectory(seq, unary_union));

        public static IntPtr[] TgeoseqStboxes(IntPtr seq)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TgeoseqStboxes(seq, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 80); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TgeoseqSplitNStboxes(IntPtr seq, int max_count)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TgeoseqSplitNStboxes(seq, max_count, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 80); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr TpointseqsetAzimuth(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TpointseqsetAzimuth(ss));

        public static IntPtr TpointseqsetCumulativeLength(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TpointseqsetCumulativeLength(ss));

        public static bool TpointseqsetIsSimple(IntPtr ss)
            => SafeExecution<bool>(() => Native.TpointseqsetIsSimple(ss));

        public static double TpointseqsetLength(IntPtr ss)
            => SafeExecution<double>(() => Native.TpointseqsetLength(ss));

        public static IntPtr[] TgeoseqsetStboxes(IntPtr ss)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TgeoseqsetStboxes(ss, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 80); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TgeoseqsetSplitNStboxes(IntPtr ss, int max_count)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TgeoseqsetSplitNStboxes(ss, max_count, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 80); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr TpointGetCoord(IntPtr temp, int coord)
            => SafeExecution<IntPtr>(() => Native.TpointGetCoord(temp, coord));

        public static IntPtr TgeominstTgeoginst(IntPtr inst, bool oper)
            => SafeExecution<IntPtr>(() => Native.TgeominstTgeoginst(inst, oper));

        public static IntPtr TgeomseqTgeogseq(IntPtr seq, bool oper)
            => SafeExecution<IntPtr>(() => Native.TgeomseqTgeogseq(seq, oper));

        public static IntPtr TgeomseqsetTgeogseqset(IntPtr ss, bool oper)
            => SafeExecution<IntPtr>(() => Native.TgeomseqsetTgeogseqset(ss, oper));

        public static IntPtr TgeomTgeog(IntPtr temp, bool oper)
            => SafeExecution<IntPtr>(() => Native.TgeomTgeog(temp, oper));

        public static IntPtr TgeoTpoint(IntPtr temp, bool oper)
            => SafeExecution<IntPtr>(() => Native.TgeoTpoint(temp, oper));

        public static void TspatialinstSetSrid(IntPtr inst, int srid)
            => SafeExecution(() => Native.TspatialinstSetSrid(inst, srid));

        public static IntPtr[] TpointseqMakeSimple(IntPtr seq)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TpointseqMakeSimple(seq, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static void TspatialseqSetSrid(IntPtr seq, int srid)
            => SafeExecution(() => Native.TspatialseqSetSrid(seq, srid));

        public static IntPtr[] TpointseqsetMakeSimple(IntPtr ss)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TpointseqsetMakeSimple(ss, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static void TspatialseqsetSetSrid(IntPtr ss, int srid)
            => SafeExecution(() => Native.TspatialseqsetSetSrid(ss, srid));

        public static IntPtr TpointseqTwcentroid(IntPtr seq)
            => SafeExecution<IntPtr>(() => Native.TpointseqTwcentroid(seq));

        public static IntPtr TpointseqsetTwcentroid(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TpointseqsetTwcentroid(ss));

    }
}
