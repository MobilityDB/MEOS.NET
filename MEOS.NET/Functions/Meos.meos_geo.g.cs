using System.Runtime.InteropServices;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>meos_geo.h</c> declares.</summary>
    public static partial class Meos
    {
        public static IntPtr Box3dMake(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, int srid)
            => SafeExecution<IntPtr>(() => Native.Box3dMake(xmin, xmax, ymin, ymax, zmin, zmax, srid));

        public static IntPtr Box3dIn(string str)
            => SafeExecution<IntPtr>(() => Native.Box3dIn(str));

        public static string Box3dOut(IntPtr box, int maxdd)
            => SafeExecution<string>(() => Native.Box3dOut(box, maxdd));

        public static IntPtr GboxMake(bool hasz, bool hasm, bool geodetic, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, double mmin, double mmax)
            => SafeExecution<IntPtr>(() => Native.GboxMake(hasz, hasm, geodetic, xmin, xmax, ymin, ymax, zmin, zmax, mmin, mmax));

        public static IntPtr GboxIn(string str)
            => SafeExecution<IntPtr>(() => Native.GboxIn(str));

        public static string GboxOut(IntPtr box, int maxdd)
            => SafeExecution<string>(() => Native.GboxOut(box, maxdd));

        public static IntPtr GeoAsEwkb(IntPtr gs, string endian, IntPtr size)
            => SafeExecution<IntPtr>(() => Native.GeoAsEwkb(gs, endian, size));

        public static string GeoAsEwkt(IntPtr gs, int precision)
            => SafeExecution<string>(() => Native.GeoAsEwkt(gs, precision));

        public static string GeoAsGeojson(IntPtr gs, int option, int precision, string srs)
            => SafeExecution<string>(() => Native.GeoAsGeojson(gs, option, precision, srs));

        public static string GeoAsHexewkb(IntPtr gs, string endian)
            => SafeExecution<string>(() => Native.GeoAsHexewkb(gs, endian));

        public static string GeoAsText(IntPtr gs, int precision)
            => SafeExecution<string>(() => Native.GeoAsText(gs, precision));

        public static IntPtr GeoFromEwkb(IntPtr wkb, ulong wkb_size, int srid)
            => SafeExecution<IntPtr>(() => Native.GeoFromEwkb(wkb, wkb_size, srid));

        public static IntPtr GeoFromGeojson(string geojson)
            => SafeExecution<IntPtr>(() => Native.GeoFromGeojson(geojson));

        public static IntPtr GeoFromText(string wkt, int srid)
            => SafeExecution<IntPtr>(() => Native.GeoFromText(wkt, srid));

        public static string GeoOut(IntPtr gs)
            => SafeExecution<string>(() => Native.GeoOut(gs));

        public static IntPtr GeogFromHexewkb(string wkt)
            => SafeExecution<IntPtr>(() => Native.GeogFromHexewkb(wkt));

        public static IntPtr GeogIn(string str, int typmod)
            => SafeExecution<IntPtr>(() => Native.GeogIn(str, typmod));

        public static IntPtr GeomFromHexewkb(string wkt)
            => SafeExecution<IntPtr>(() => Native.GeomFromHexewkb(wkt));

        public static IntPtr GeomIn(string str, int typmod)
            => SafeExecution<IntPtr>(() => Native.GeomIn(str, typmod));

        public static IntPtr GeoCopy(IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.GeoCopy(gs));

        public static IntPtr GeogpointMake2d(int srid, double x, double y)
            => SafeExecution<IntPtr>(() => Native.GeogpointMake2d(srid, x, y));

        public static IntPtr GeogpointMake3dz(int srid, double x, double y, double z)
            => SafeExecution<IntPtr>(() => Native.GeogpointMake3dz(srid, x, y, z));

        public static IntPtr GeompointMake2d(int srid, double x, double y)
            => SafeExecution<IntPtr>(() => Native.GeompointMake2d(srid, x, y));

        public static IntPtr GeompointMake3dz(int srid, double x, double y, double z)
            => SafeExecution<IntPtr>(() => Native.GeompointMake3dz(srid, x, y, z));

        public static IntPtr GeomToGeog(IntPtr geom)
            => SafeExecution<IntPtr>(() => Native.GeomToGeog(geom));

        public static IntPtr GeogToGeom(IntPtr geog)
            => SafeExecution<IntPtr>(() => Native.GeogToGeom(geog));

        public static bool GeoIsEmpty(IntPtr gs)
            => SafeExecution<bool>(() => Native.GeoIsEmpty(gs));

        public static bool GeoIsUnitary(IntPtr gs)
            => SafeExecution<bool>(() => Native.GeoIsUnitary(gs));

        public static string? GeoTypename(int type)
            => Marshal.PtrToStringUTF8(SafeExecution<IntPtr>(() => Native.GeoTypename(type)));

        public static double GeogArea(IntPtr gs, bool use_spheroid)
            => SafeExecution<double>(() => Native.GeogArea(gs, use_spheroid));

        public static IntPtr GeogCentroid(IntPtr gs, bool use_spheroid)
            => SafeExecution<IntPtr>(() => Native.GeogCentroid(gs, use_spheroid));

        public static double GeogLength(IntPtr gs, bool use_spheroid)
            => SafeExecution<double>(() => Native.GeogLength(gs, use_spheroid));

        public static double GeogPerimeter(IntPtr gs, bool use_spheroid)
            => SafeExecution<double>(() => Native.GeogPerimeter(gs, use_spheroid));

        public static bool GeomAzimuth(IntPtr gs1, IntPtr gs2, IntPtr result)
            => SafeExecution<bool>(() => Native.GeomAzimuth(gs1, gs2, result));

        public static double GeomLength(IntPtr gs)
            => SafeExecution<double>(() => Native.GeomLength(gs));

        public static double GeomPerimeter(IntPtr gs)
            => SafeExecution<double>(() => Native.GeomPerimeter(gs));

        public static int LineNumpoints(IntPtr gs)
            => SafeExecution<int>(() => Native.LineNumpoints(gs));

        public static IntPtr LinePointN(IntPtr geom, int n)
            => SafeExecution<IntPtr>(() => Native.LinePointN(geom, n));

        public static IntPtr GeoReverse(IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.GeoReverse(gs));

        public static IntPtr GeoRound(IntPtr gs, int maxdd)
            => SafeExecution<IntPtr>(() => Native.GeoRound(gs, maxdd));

        public static IntPtr GeoSetSrid(IntPtr gs, int srid)
            => SafeExecution<IntPtr>(() => Native.GeoSetSrid(gs, srid));

        public static int GeoSrid(IntPtr gs)
            => SafeExecution<int>(() => Native.GeoSrid(gs));

        public static IntPtr GeoTransform(IntPtr geom, int srid_to)
            => SafeExecution<IntPtr>(() => Native.GeoTransform(geom, srid_to));

        public static IntPtr GeoTransformPipeline(IntPtr gs, string pipeline, int srid_to, bool is_forward)
            => SafeExecution<IntPtr>(() => Native.GeoTransformPipeline(gs, pipeline, srid_to, is_forward));

        public static IntPtr GeoCollectGarray(IntPtr gsarr, int count)
            => SafeExecution<IntPtr>(() => Native.GeoCollectGarray(gsarr, count));

        public static IntPtr GeoMakelineGarray(IntPtr gsarr, int count)
            => SafeExecution<IntPtr>(() => Native.GeoMakelineGarray(gsarr, count));

        public static int GeoNumPoints(IntPtr gs)
            => SafeExecution<int>(() => Native.GeoNumPoints(gs));

        public static int GeoNumGeos(IntPtr gs)
            => SafeExecution<int>(() => Native.GeoNumGeos(gs));

        public static IntPtr GeoGeoN(IntPtr geom, int n)
            => SafeExecution<IntPtr>(() => Native.GeoGeoN(geom, n));

        public static IntPtr[] GeoPointarr(IntPtr gs)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.GeoPointarr(gs, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr GeoPoints(IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.GeoPoints(gs));

        public static IntPtr GeomArrayUnion(IntPtr gsarr, int count)
            => SafeExecution<IntPtr>(() => Native.GeomArrayUnion(gsarr, count));

        public static IntPtr GeogArrayUnion(IntPtr gsarr, int count)
            => SafeExecution<IntPtr>(() => Native.GeogArrayUnion(gsarr, count));

        public static IntPtr GeomBoundary(IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.GeomBoundary(gs));

        public static IntPtr GeomBuffer(IntPtr gs, double size, string @params)
            => SafeExecution<IntPtr>(() => Native.GeomBuffer(gs, size, @params));

        public static IntPtr GeomCentroid(IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.GeomCentroid(gs));

        public static IntPtr GeomConvexHull(IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.GeomConvexHull(gs));

        public static IntPtr GeomDifference2d(IntPtr gs1, IntPtr gs2)
            => SafeExecution<IntPtr>(() => Native.GeomDifference2d(gs1, gs2));

        public static bool GeomIsSimple(IntPtr gs)
            => SafeExecution<bool>(() => Native.GeomIsSimple(gs));

        public static IntPtr GeomIntersection2d(IntPtr gs1, IntPtr gs2)
            => SafeExecution<IntPtr>(() => Native.GeomIntersection2d(gs1, gs2));

        public static IntPtr GeomIntersection2dColl(IntPtr gs1, IntPtr gs2)
            => SafeExecution<IntPtr>(() => Native.GeomIntersection2dColl(gs1, gs2));

        public static IntPtr GeomMinBoundingRadius(IntPtr geom, IntPtr radius)
            => SafeExecution<IntPtr>(() => Native.GeomMinBoundingRadius(geom, radius));

        public static IntPtr GeomOrientedEnvelope(IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.GeomOrientedEnvelope(gs));

        public static IntPtr GeomShortestline2d(IntPtr gs1, IntPtr gs2)
            => SafeExecution<IntPtr>(() => Native.GeomShortestline2d(gs1, gs2));

        public static IntPtr GeomShortestline3d(IntPtr gs1, IntPtr gs2)
            => SafeExecution<IntPtr>(() => Native.GeomShortestline3d(gs1, gs2));

        public static IntPtr GeomUnaryUnion(IntPtr gs, double prec)
            => SafeExecution<IntPtr>(() => Native.GeomUnaryUnion(gs, prec));

        public static IntPtr LineInterpolatePoint(IntPtr gs, double distance_fraction, bool repeat)
            => SafeExecution<IntPtr>(() => Native.LineInterpolatePoint(gs, distance_fraction, repeat));

        public static double LineLocatePoint(IntPtr gs1, IntPtr gs2)
            => SafeExecution<double>(() => Native.LineLocatePoint(gs1, gs2));

        public static IntPtr LineSubstring(IntPtr gs, double from, double to)
            => SafeExecution<IntPtr>(() => Native.LineSubstring(gs, from, to));

        public static bool GeogDwithin(IntPtr g1, IntPtr g2, double tolerance, bool use_spheroid)
            => SafeExecution<bool>(() => Native.GeogDwithin(g1, g2, tolerance, use_spheroid));

        public static bool GeogIntersects(IntPtr gs1, IntPtr gs2, bool use_spheroid)
            => SafeExecution<bool>(() => Native.GeogIntersects(gs1, gs2, use_spheroid));

        public static bool GeomContains(IntPtr gs1, IntPtr gs2)
            => SafeExecution<bool>(() => Native.GeomContains(gs1, gs2));

        public static bool GeomCovers(IntPtr gs1, IntPtr gs2)
            => SafeExecution<bool>(() => Native.GeomCovers(gs1, gs2));

        public static bool GeomDisjoint2d(IntPtr gs1, IntPtr gs2)
            => SafeExecution<bool>(() => Native.GeomDisjoint2d(gs1, gs2));

        public static bool GeomDwithin(IntPtr gs1, IntPtr gs2, double tolerance)
            => SafeExecution<bool>(() => Native.GeomDwithin(gs1, gs2, tolerance));

        public static bool GeomDwithin2d(IntPtr gs1, IntPtr gs2, double tolerance)
            => SafeExecution<bool>(() => Native.GeomDwithin2d(gs1, gs2, tolerance));

        public static bool GeomDwithin3d(IntPtr gs1, IntPtr gs2, double tolerance)
            => SafeExecution<bool>(() => Native.GeomDwithin3d(gs1, gs2, tolerance));

        public static bool GeomIntersects(IntPtr gs1, IntPtr gs2)
            => SafeExecution<bool>(() => Native.GeomIntersects(gs1, gs2));

        public static bool GeomIntersects2d(IntPtr gs1, IntPtr gs2)
            => SafeExecution<bool>(() => Native.GeomIntersects2d(gs1, gs2));

        public static bool GeomIntersects3d(IntPtr gs1, IntPtr gs2)
            => SafeExecution<bool>(() => Native.GeomIntersects3d(gs1, gs2));

        public static string GeomRelate(IntPtr gs1, IntPtr gs2)
            => SafeExecution<string>(() => Native.GeomRelate(gs1, gs2));

        public static bool GeomRelatePattern(IntPtr gs1, IntPtr gs2, string patt)
            => SafeExecution<bool>(() => Native.GeomRelatePattern(gs1, gs2, patt));

        public static bool GeomTouches(IntPtr gs1, IntPtr gs2)
            => SafeExecution<bool>(() => Native.GeomTouches(gs1, gs2));

        public static IntPtr[] GeoStboxes(IntPtr gs)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.GeoStboxes(gs, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 80); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] GeoSplitEachNStboxes(IntPtr gs, int elem_count)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.GeoSplitEachNStboxes(gs, elem_count, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 80); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] GeoSplitNStboxes(IntPtr gs, int box_count)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.GeoSplitNStboxes(gs, box_count, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 80); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static double GeogDistance(IntPtr g1, IntPtr g2)
            => SafeExecution<double>(() => Native.GeogDistance(g1, g2));

        public static double GeomDistance2d(IntPtr gs1, IntPtr gs2)
            => SafeExecution<double>(() => Native.GeomDistance2d(gs1, gs2));

        public static double GeomMaxDistance2d(IntPtr gs1, IntPtr gs2)
            => SafeExecution<double>(() => Native.GeomMaxDistance2d(gs1, gs2));

        public static double GeomDistance3d(IntPtr gs1, IntPtr gs2)
            => SafeExecution<double>(() => Native.GeomDistance3d(gs1, gs2));

        public static int GeoEquals(IntPtr gs1, IntPtr gs2)
            => SafeExecution<int>(() => Native.GeoEquals(gs1, gs2));

        public static bool GeoSame(IntPtr gs1, IntPtr gs2)
            => SafeExecution<bool>(() => Native.GeoSame(gs1, gs2));

        public static IntPtr GeogsetIn(string str)
            => SafeExecution<IntPtr>(() => Native.GeogsetIn(str));

        public static IntPtr GeomsetIn(string str)
            => SafeExecution<IntPtr>(() => Native.GeomsetIn(str));

        public static string SpatialsetOut(IntPtr s, int maxdd)
            => SafeExecution<string>(() => Native.SpatialsetOut(s, maxdd));

        public static string SpatialsetAsText(IntPtr set, int maxdd)
            => SafeExecution<string>(() => Native.SpatialsetAsText(set, maxdd));

        public static string SpatialsetAsEwkt(IntPtr set, int maxdd)
            => SafeExecution<string>(() => Native.SpatialsetAsEwkt(set, maxdd));

        public static IntPtr GeosetMake(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => Native.GeosetMake(values, count));

        public static IntPtr GeoToSet(IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.GeoToSet(gs));

        public static IntPtr GeosetEndValue(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.GeosetEndValue(s));

        public static IntPtr GeosetStartValue(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.GeosetStartValue(s));

        public static bool GeosetValueN(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.GeosetValueN(s, n, result));

        public static IntPtr[] GeosetValues(IntPtr s)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.GeosetValues(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool ContainedGeoSet(IntPtr gs, IntPtr s)
            => SafeExecution<bool>(() => Native.ContainedGeoSet(gs, s));

        public static bool ContainsSetGeo(IntPtr s, IntPtr gs)
            => SafeExecution<bool>(() => Native.ContainsSetGeo(s, gs));

        public static IntPtr GeoUnionTransfn(IntPtr state, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.GeoUnionTransfn(state, gs));

        public static IntPtr IntersectionGeoSet(IntPtr gs, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.IntersectionGeoSet(gs, s));

        public static IntPtr IntersectionSetGeo(IntPtr s, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.IntersectionSetGeo(s, gs));

        public static IntPtr MinusGeoSet(IntPtr gs, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.MinusGeoSet(gs, s));

        public static IntPtr MinusSetGeo(IntPtr s, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.MinusSetGeo(s, gs));

        public static IntPtr UnionGeoSet(IntPtr gs, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.UnionGeoSet(gs, s));

        public static IntPtr UnionSetGeo(IntPtr s, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.UnionSetGeo(s, gs));

        public static IntPtr SpatialsetSetSrid(IntPtr s, int srid)
            => SafeExecution<IntPtr>(() => Native.SpatialsetSetSrid(s, srid));

        public static int SpatialsetSrid(IntPtr s)
            => SafeExecution<int>(() => Native.SpatialsetSrid(s));

        public static IntPtr SpatialsetTransform(IntPtr s, int srid)
            => SafeExecution<IntPtr>(() => Native.SpatialsetTransform(s, srid));

        public static IntPtr SpatialsetTransformPipeline(IntPtr s, string pipelinestr, int srid, bool is_forward)
            => SafeExecution<IntPtr>(() => Native.SpatialsetTransformPipeline(s, pipelinestr, srid, is_forward));

        public static string StboxAsHexwkb(IntPtr box, byte variant, IntPtr size_out)
            => SafeExecution<string>(() => Native.StboxAsHexwkb(box, variant, size_out));

        public static IntPtr StboxAsWkb(IntPtr box, byte variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => Native.StboxAsWkb(box, variant, size_out));

        public static IntPtr StboxFromHexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => Native.StboxFromHexwkb(hexwkb));

        public static IntPtr StboxFromWkb(IntPtr wkb, ulong size)
            => SafeExecution<IntPtr>(() => Native.StboxFromWkb(wkb, size));

        public static IntPtr StboxIn(string str)
            => SafeExecution<IntPtr>(() => Native.StboxIn(str));

        public static string StboxOut(IntPtr box, int maxdd)
            => SafeExecution<string>(() => Native.StboxOut(box, maxdd));

        public static IntPtr GeoTimestamptzToStbox(IntPtr gs, long t)
            => SafeExecution<IntPtr>(() => Native.GeoTimestamptzToStbox(gs, t));

        public static IntPtr GeoTstzspanToStbox(IntPtr gs, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.GeoTstzspanToStbox(gs, s));

        public static IntPtr StboxCopy(IntPtr box)
            => SafeExecution<IntPtr>(() => Native.StboxCopy(box));

        public static IntPtr StboxMake(bool hasx, bool hasz, bool geodetic, int srid, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.StboxMake(hasx, hasz, geodetic, srid, xmin, xmax, ymin, ymax, zmin, zmax, s));

        public static IntPtr GeoToStbox(IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.GeoToStbox(gs));

        public static IntPtr SpatialsetToStbox(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.SpatialsetToStbox(s));

        public static IntPtr StboxToBox3d(IntPtr box)
            => SafeExecution<IntPtr>(() => Native.StboxToBox3d(box));

        public static IntPtr StboxToGbox(IntPtr box)
            => SafeExecution<IntPtr>(() => Native.StboxToGbox(box));

        public static IntPtr StboxToGeo(IntPtr box)
            => SafeExecution<IntPtr>(() => Native.StboxToGeo(box));

        public static IntPtr StboxToTstzspan(IntPtr box)
            => SafeExecution<IntPtr>(() => Native.StboxToTstzspan(box));

        public static IntPtr TimestamptzToStbox(long t)
            => SafeExecution<IntPtr>(() => Native.TimestamptzToStbox(t));

        public static IntPtr TstzsetToStbox(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TstzsetToStbox(s));

        public static IntPtr TstzspanToStbox(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TstzspanToStbox(s));

        public static IntPtr TstzspansetToStbox(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TstzspansetToStbox(ss));

        public static double StboxArea(IntPtr box, bool spheroid)
            => SafeExecution<double>(() => Native.StboxArea(box, spheroid));

        public static uint StboxHash(IntPtr box)
            => SafeExecution<uint>(() => Native.StboxHash(box));

        public static ulong StboxHashExtended(IntPtr box, ulong seed)
            => SafeExecution<ulong>(() => Native.StboxHashExtended(box, seed));

        public static bool StboxHast(IntPtr box)
            => SafeExecution<bool>(() => Native.StboxHast(box));

        public static bool StboxHasx(IntPtr box)
            => SafeExecution<bool>(() => Native.StboxHasx(box));

        public static bool StboxHasz(IntPtr box)
            => SafeExecution<bool>(() => Native.StboxHasz(box));

        public static bool StboxIsgeodetic(IntPtr box)
            => SafeExecution<bool>(() => Native.StboxIsgeodetic(box));

        public static double StboxPerimeter(IntPtr box, bool spheroid)
            => SafeExecution<double>(() => Native.StboxPerimeter(box, spheroid));

        public static bool StboxTmax(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.StboxTmax(box, result));

        public static bool StboxTmaxInc(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.StboxTmaxInc(box, result));

        public static bool StboxTmin(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.StboxTmin(box, result));

        public static bool StboxTminInc(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.StboxTminInc(box, result));

        public static double StboxVolume(IntPtr box)
            => SafeExecution<double>(() => Native.StboxVolume(box));

        public static bool StboxXmax(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.StboxXmax(box, result));

        public static bool StboxXmin(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.StboxXmin(box, result));

        public static bool StboxYmax(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.StboxYmax(box, result));

        public static bool StboxYmin(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.StboxYmin(box, result));

        public static bool StboxZmax(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.StboxZmax(box, result));

        public static bool StboxZmin(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.StboxZmin(box, result));

        public static IntPtr StboxExpandSpace(IntPtr box, double d)
            => SafeExecution<IntPtr>(() => Native.StboxExpandSpace(box, d));

        public static IntPtr StboxExpandTime(IntPtr box, IntPtr interv)
            => SafeExecution<IntPtr>(() => Native.StboxExpandTime(box, interv));

        public static IntPtr StboxGetSpace(IntPtr box)
            => SafeExecution<IntPtr>(() => Native.StboxGetSpace(box));

        public static IntPtr[] StboxQuadSplit(IntPtr box)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.StboxQuadSplit(box, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 80); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr StboxRound(IntPtr box, int maxdd)
            => SafeExecution<IntPtr>(() => Native.StboxRound(box, maxdd));

        public static IntPtr StboxShiftScaleTime(IntPtr box, IntPtr shift, IntPtr duration)
            => SafeExecution<IntPtr>(() => Native.StboxShiftScaleTime(box, shift, duration));

        public static IntPtr StboxarrRound(IntPtr boxarr, int count, int maxdd)
            => SafeExecution<IntPtr>(() => Native.StboxarrRound(boxarr, count, maxdd));

        public static IntPtr StboxSetSrid(IntPtr box, int srid)
            => SafeExecution<IntPtr>(() => Native.StboxSetSrid(box, srid));

        public static int StboxSrid(IntPtr box)
            => SafeExecution<int>(() => Native.StboxSrid(box));

        public static IntPtr StboxTransform(IntPtr box, int srid)
            => SafeExecution<IntPtr>(() => Native.StboxTransform(box, srid));

        public static IntPtr StboxTransformPipeline(IntPtr box, string pipelinestr, int srid, bool is_forward)
            => SafeExecution<IntPtr>(() => Native.StboxTransformPipeline(box, pipelinestr, srid, is_forward));

        public static bool AdjacentStboxStbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.AdjacentStboxStbox(box1, box2));

        public static bool ContainedStboxStbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.ContainedStboxStbox(box1, box2));

        public static bool ContainsStboxStbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.ContainsStboxStbox(box1, box2));

        public static bool OverlapsStboxStbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.OverlapsStboxStbox(box1, box2));

        public static bool SameStboxStbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.SameStboxStbox(box1, box2));

        public static bool AboveStboxStbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.AboveStboxStbox(box1, box2));

        public static bool AfterStboxStbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.AfterStboxStbox(box1, box2));

        public static bool BackStboxStbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.BackStboxStbox(box1, box2));

        public static bool BeforeStboxStbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.BeforeStboxStbox(box1, box2));

        public static bool BelowStboxStbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.BelowStboxStbox(box1, box2));

        public static bool FrontStboxStbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.FrontStboxStbox(box1, box2));

        public static bool LeftStboxStbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.LeftStboxStbox(box1, box2));

        public static bool OveraboveStboxStbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.OveraboveStboxStbox(box1, box2));

        public static bool OverafterStboxStbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.OverafterStboxStbox(box1, box2));

        public static bool OverbackStboxStbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.OverbackStboxStbox(box1, box2));

        public static bool OverbeforeStboxStbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.OverbeforeStboxStbox(box1, box2));

        public static bool OverbelowStboxStbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.OverbelowStboxStbox(box1, box2));

        public static bool OverfrontStboxStbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.OverfrontStboxStbox(box1, box2));

        public static bool OverleftStboxStbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.OverleftStboxStbox(box1, box2));

        public static bool OverrightStboxStbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.OverrightStboxStbox(box1, box2));

        public static bool RightStboxStbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.RightStboxStbox(box1, box2));

        public static IntPtr UnionStboxStbox(IntPtr box1, IntPtr box2, bool strict)
            => SafeExecution<IntPtr>(() => Native.UnionStboxStbox(box1, box2, strict));

        public static IntPtr IntersectionStboxStbox(IntPtr box1, IntPtr box2)
            => SafeExecution<IntPtr>(() => Native.IntersectionStboxStbox(box1, box2));

        public static int StboxCmp(IntPtr box1, IntPtr box2)
            => SafeExecution<int>(() => Native.StboxCmp(box1, box2));

        public static bool StboxEq(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.StboxEq(box1, box2));

        public static bool StboxGe(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.StboxGe(box1, box2));

        public static bool StboxGt(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.StboxGt(box1, box2));

        public static bool StboxLe(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.StboxLe(box1, box2));

        public static bool StboxLt(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.StboxLt(box1, box2));

        public static bool StboxNe(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.StboxNe(box1, box2));

        public static string TspatialOut(IntPtr temp, int maxdd)
            => SafeExecution<string>(() => Native.TspatialOut(temp, maxdd));

        public static IntPtr TgeogpointFromMfjson(string str)
            => SafeExecution<IntPtr>(() => Native.TgeogpointFromMfjson(str));

        public static IntPtr TgeogpointIn(string str)
            => SafeExecution<IntPtr>(() => Native.TgeogpointIn(str));

        public static IntPtr TgeographyFromMfjson(string mfjson)
            => SafeExecution<IntPtr>(() => Native.TgeographyFromMfjson(mfjson));

        public static IntPtr TgeographyIn(string str)
            => SafeExecution<IntPtr>(() => Native.TgeographyIn(str));

        public static IntPtr TgeometryFromMfjson(string str)
            => SafeExecution<IntPtr>(() => Native.TgeometryFromMfjson(str));

        public static IntPtr TgeometryIn(string str)
            => SafeExecution<IntPtr>(() => Native.TgeometryIn(str));

        public static IntPtr TgeompointFromMfjson(string str)
            => SafeExecution<IntPtr>(() => Native.TgeompointFromMfjson(str));

        public static IntPtr TgeompointIn(string str)
            => SafeExecution<IntPtr>(() => Native.TgeompointIn(str));

        public static string TspatialAsEwkt(IntPtr temp, int maxdd)
            => SafeExecution<string>(() => Native.TspatialAsEwkt(temp, maxdd));

        public static string TspatialAsText(IntPtr temp, int maxdd)
            => SafeExecution<string>(() => Native.TspatialAsText(temp, maxdd));

        public static IntPtr TgeoFromBaseTemp(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TgeoFromBaseTemp(gs, temp));

        public static IntPtr TgeoinstMake(IntPtr gs, long t)
            => SafeExecution<IntPtr>(() => Native.TgeoinstMake(gs, t));

        public static IntPtr TgeoseqFromBaseTstzset(IntPtr gs, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TgeoseqFromBaseTstzset(gs, s));

        public static IntPtr TgeoseqFromBaseTstzspan(IntPtr gs, IntPtr s, int interp)
            => SafeExecution<IntPtr>(() => Native.TgeoseqFromBaseTstzspan(gs, s, interp));

        public static IntPtr TgeoseqsetFromBaseTstzspanset(IntPtr gs, IntPtr ss, int interp)
            => SafeExecution<IntPtr>(() => Native.TgeoseqsetFromBaseTstzspanset(gs, ss, interp));

        public static IntPtr TpointFromBaseTemp(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TpointFromBaseTemp(gs, temp));

        public static IntPtr TpointinstMake(IntPtr gs, long t)
            => SafeExecution<IntPtr>(() => Native.TpointinstMake(gs, t));

        public static IntPtr TpointseqFromBaseTstzset(IntPtr gs, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TpointseqFromBaseTstzset(gs, s));

        public static IntPtr TpointseqFromBaseTstzspan(IntPtr gs, IntPtr s, int interp)
            => SafeExecution<IntPtr>(() => Native.TpointseqFromBaseTstzspan(gs, s, interp));

        public static IntPtr TpointseqMakeCoords(IntPtr xcoords, IntPtr ycoords, IntPtr zcoords, IntPtr times, int count, int srid, bool geodetic, bool lower_inc, bool upper_inc, int interp, bool normalize)
            => SafeExecution<IntPtr>(() => Native.TpointseqMakeCoords(xcoords, ycoords, zcoords, times, count, srid, geodetic, lower_inc, upper_inc, interp, normalize));

        public static IntPtr TpointseqsetFromBaseTstzspanset(IntPtr gs, IntPtr ss, int interp)
            => SafeExecution<IntPtr>(() => Native.TpointseqsetFromBaseTstzspanset(gs, ss, interp));

        public static IntPtr Box3dToStbox(IntPtr box)
            => SafeExecution<IntPtr>(() => Native.Box3dToStbox(box));

        public static IntPtr GboxToStbox(IntPtr box)
            => SafeExecution<IntPtr>(() => Native.GboxToStbox(box));

        public static IntPtr GeomeasToTpoint(IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.GeomeasToTpoint(gs));

        public static IntPtr TgeogpointToTgeography(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TgeogpointToTgeography(temp));

        public static IntPtr TgeographyToTgeogpoint(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TgeographyToTgeogpoint(temp));

        public static IntPtr TgeographyToTgeometry(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TgeographyToTgeometry(temp));

        public static IntPtr TgeometryToTgeography(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TgeometryToTgeography(temp));

        public static IntPtr TgeometryToTgeompoint(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TgeometryToTgeompoint(temp));

        public static IntPtr TgeompointToTgeometry(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TgeompointToTgeometry(temp));

        public static IntPtr TpointAsMvtgeom(IntPtr temp, IntPtr bounds, int extent, int buffer, bool clip_geom)
            => SafeExecution<IntPtr>(() => Native.TpointAsMvtgeom(temp, bounds, extent, buffer, clip_geom));

        public static bool TpointTfloatToGeomeas(IntPtr tpoint, IntPtr measure, bool segmentize, IntPtr result)
            => SafeExecution<bool>(() => Native.TpointTfloatToGeomeas(tpoint, measure, segmentize, result));

        public static IntPtr TspatialToStbox(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TspatialToStbox(temp));

        public static bool BearingPointPoint(IntPtr gs1, IntPtr gs2, IntPtr result)
            => SafeExecution<bool>(() => Native.BearingPointPoint(gs1, gs2, result));

        public static IntPtr BearingTpointPoint(IntPtr temp, IntPtr gs, bool invert)
            => SafeExecution<IntPtr>(() => Native.BearingTpointPoint(temp, gs, invert));

        public static IntPtr BearingTpointTpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.BearingTpointTpoint(temp1, temp2));

        public static IntPtr TgeoCentroid(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TgeoCentroid(temp));

        public static IntPtr TgeoConvexHull(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TgeoConvexHull(temp));

        public static IntPtr TgeoEndValue(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TgeoEndValue(temp));

        public static IntPtr TgeoStartValue(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TgeoStartValue(temp));

        public static IntPtr TgeoTraversedArea(IntPtr temp, bool unary_union)
            => SafeExecution<IntPtr>(() => Native.TgeoTraversedArea(temp, unary_union));

        public static bool TgeoValueAtTimestamptz(IntPtr temp, long t, bool strict, IntPtr result)
            => SafeExecution<bool>(() => Native.TgeoValueAtTimestamptz(temp, t, strict, result));

        public static bool TgeoValueN(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.TgeoValueN(temp, n, result));

        public static IntPtr[] TgeoValues(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TgeoValues(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr TpointAngularDifference(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TpointAngularDifference(temp));

        public static IntPtr TpointAzimuth(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TpointAzimuth(temp));

        public static IntPtr TpointCumulativeLength(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TpointCumulativeLength(temp));

        public static bool TpointDirection(IntPtr temp, IntPtr result)
            => SafeExecution<bool>(() => Native.TpointDirection(temp, result));

        public static IntPtr TpointGetX(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TpointGetX(temp));

        public static IntPtr TpointGetY(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TpointGetY(temp));

        public static IntPtr TpointGetZ(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TpointGetZ(temp));

        public static bool TpointIsSimple(IntPtr temp)
            => SafeExecution<bool>(() => Native.TpointIsSimple(temp));

        public static double TpointLength(IntPtr temp)
            => SafeExecution<double>(() => Native.TpointLength(temp));

        public static IntPtr TpointSpeed(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TpointSpeed(temp));

        public static IntPtr TpointTrajectory(IntPtr temp, bool unary_union)
            => SafeExecution<IntPtr>(() => Native.TpointTrajectory(temp, unary_union));

        public static IntPtr TpointTwcentroid(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TpointTwcentroid(temp));

        public static IntPtr TgeoAffine(IntPtr temp, IntPtr a)
            => SafeExecution<IntPtr>(() => Native.TgeoAffine(temp, a));

        public static IntPtr TgeoScale(IntPtr temp, IntPtr scale, IntPtr sorigin)
            => SafeExecution<IntPtr>(() => Native.TgeoScale(temp, scale, sorigin));

        public static IntPtr[] TpointMakeSimple(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TpointMakeSimple(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int TspatialSrid(IntPtr temp)
            => SafeExecution<int>(() => Native.TspatialSrid(temp));

        public static IntPtr TspatialSetSrid(IntPtr temp, int srid)
            => SafeExecution<IntPtr>(() => Native.TspatialSetSrid(temp, srid));

        public static IntPtr TspatialTransform(IntPtr temp, int srid)
            => SafeExecution<IntPtr>(() => Native.TspatialTransform(temp, srid));

        public static IntPtr TspatialTransformPipeline(IntPtr temp, string pipelinestr, int srid, bool is_forward)
            => SafeExecution<IntPtr>(() => Native.TspatialTransformPipeline(temp, pipelinestr, srid, is_forward));

        public static IntPtr TgeoAtGeom(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TgeoAtGeom(temp, gs));

        public static IntPtr TgeoAtStbox(IntPtr temp, IntPtr box, bool border_inc)
            => SafeExecution<IntPtr>(() => Native.TgeoAtStbox(temp, box, border_inc));

        public static IntPtr TgeoAtValue(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TgeoAtValue(temp, gs));

        public static IntPtr TgeoMinusGeom(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TgeoMinusGeom(temp, gs));

        public static IntPtr TgeoMinusStbox(IntPtr temp, IntPtr box, bool border_inc)
            => SafeExecution<IntPtr>(() => Native.TgeoMinusStbox(temp, box, border_inc));

        public static IntPtr TgeoMinusValue(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TgeoMinusValue(temp, gs));

        public static IntPtr TpointAtElevation(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TpointAtElevation(temp, s));

        public static IntPtr TpointAtGeom(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TpointAtGeom(temp, gs));

        public static IntPtr TpointAtValue(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TpointAtValue(temp, gs));

        public static IntPtr TpointMinusElevation(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TpointMinusElevation(temp, s));

        public static IntPtr TpointMinusGeom(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TpointMinusGeom(temp, gs));

        public static IntPtr TpointMinusValue(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TpointMinusValue(temp, gs));

        public static int AlwaysEqGeoTgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysEqGeoTgeo(gs, temp));

        public static int AlwaysEqTgeoGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.AlwaysEqTgeoGeo(temp, gs));

        public static int AlwaysEqTgeoTgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysEqTgeoTgeo(temp1, temp2));

        public static int AlwaysNeGeoTgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysNeGeoTgeo(gs, temp));

        public static int AlwaysNeTgeoGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.AlwaysNeTgeoGeo(temp, gs));

        public static int AlwaysNeTgeoTgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysNeTgeoTgeo(temp1, temp2));

        public static int EverEqGeoTgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => Native.EverEqGeoTgeo(gs, temp));

        public static int EverEqTgeoGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.EverEqTgeoGeo(temp, gs));

        public static int EverEqTgeoTgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverEqTgeoTgeo(temp1, temp2));

        public static int EverNeGeoTgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => Native.EverNeGeoTgeo(gs, temp));

        public static int EverNeTgeoGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.EverNeTgeoGeo(temp, gs));

        public static int EverNeTgeoTgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverNeTgeoTgeo(temp1, temp2));

        public static IntPtr TeqGeoTgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TeqGeoTgeo(gs, temp));

        public static IntPtr TeqTgeoGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TeqTgeoGeo(temp, gs));

        public static IntPtr TneGeoTgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TneGeoTgeo(gs, temp));

        public static IntPtr TneTgeoGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TneTgeoGeo(temp, gs));

        public static IntPtr[] TgeoStboxes(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TgeoStboxes(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 80); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TgeoSpaceBoxes(IntPtr temp, double xsize, double ysize, double zsize, IntPtr sorigin, bool bitmatrix, bool border_inc)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TgeoSpaceBoxes(temp, xsize, ysize, zsize, sorigin, bitmatrix, border_inc, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 80); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TgeoSpaceTimeBoxes(IntPtr temp, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, long torigin, bool bitmatrix, bool border_inc)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TgeoSpaceTimeBoxes(temp, xsize, ysize, zsize, duration, sorigin, torigin, bitmatrix, border_inc, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 80); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TgeoSplitEachNStboxes(IntPtr temp, int elem_count)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TgeoSplitEachNStboxes(temp, elem_count, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 80); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TgeoSplitNStboxes(IntPtr temp, int box_count)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TgeoSplitNStboxes(temp, box_count, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 80); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool AdjacentStboxTspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.AdjacentStboxTspatial(box, temp));

        public static bool AdjacentTspatialStbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.AdjacentTspatialStbox(temp, box));

        public static bool AdjacentTspatialTspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.AdjacentTspatialTspatial(temp1, temp2));

        public static bool ContainedStboxTspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.ContainedStboxTspatial(box, temp));

        public static bool ContainedTspatialStbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.ContainedTspatialStbox(temp, box));

        public static bool ContainedTspatialTspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.ContainedTspatialTspatial(temp1, temp2));

        public static bool ContainsStboxTspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.ContainsStboxTspatial(box, temp));

        public static bool ContainsTspatialStbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.ContainsTspatialStbox(temp, box));

        public static bool ContainsTspatialTspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.ContainsTspatialTspatial(temp1, temp2));

        public static bool OverlapsStboxTspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.OverlapsStboxTspatial(box, temp));

        public static bool OverlapsTspatialStbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.OverlapsTspatialStbox(temp, box));

        public static bool OverlapsTspatialTspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.OverlapsTspatialTspatial(temp1, temp2));

        public static bool SameStboxTspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.SameStboxTspatial(box, temp));

        public static bool SameTspatialStbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.SameTspatialStbox(temp, box));

        public static bool SameTspatialTspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.SameTspatialTspatial(temp1, temp2));

        public static bool AboveStboxTspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.AboveStboxTspatial(box, temp));

        public static bool AboveTspatialStbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.AboveTspatialStbox(temp, box));

        public static bool AboveTspatialTspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.AboveTspatialTspatial(temp1, temp2));

        public static bool AfterStboxTspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.AfterStboxTspatial(box, temp));

        public static bool AfterTspatialStbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.AfterTspatialStbox(temp, box));

        public static bool AfterTspatialTspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.AfterTspatialTspatial(temp1, temp2));

        public static bool BackStboxTspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.BackStboxTspatial(box, temp));

        public static bool BackTspatialStbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.BackTspatialStbox(temp, box));

        public static bool BackTspatialTspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.BackTspatialTspatial(temp1, temp2));

        public static bool BeforeStboxTspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.BeforeStboxTspatial(box, temp));

        public static bool BeforeTspatialStbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.BeforeTspatialStbox(temp, box));

        public static bool BeforeTspatialTspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.BeforeTspatialTspatial(temp1, temp2));

        public static bool BelowStboxTspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.BelowStboxTspatial(box, temp));

        public static bool BelowTspatialStbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.BelowTspatialStbox(temp, box));

        public static bool BelowTspatialTspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.BelowTspatialTspatial(temp1, temp2));

        public static bool FrontStboxTspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.FrontStboxTspatial(box, temp));

        public static bool FrontTspatialStbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.FrontTspatialStbox(temp, box));

        public static bool FrontTspatialTspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.FrontTspatialTspatial(temp1, temp2));

        public static bool LeftStboxTspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.LeftStboxTspatial(box, temp));

        public static bool LeftTspatialStbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.LeftTspatialStbox(temp, box));

        public static bool LeftTspatialTspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.LeftTspatialTspatial(temp1, temp2));

        public static bool OveraboveStboxTspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.OveraboveStboxTspatial(box, temp));

        public static bool OveraboveTspatialStbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.OveraboveTspatialStbox(temp, box));

        public static bool OveraboveTspatialTspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.OveraboveTspatialTspatial(temp1, temp2));

        public static bool OverafterStboxTspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.OverafterStboxTspatial(box, temp));

        public static bool OverafterTspatialStbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.OverafterTspatialStbox(temp, box));

        public static bool OverafterTspatialTspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.OverafterTspatialTspatial(temp1, temp2));

        public static bool OverbackStboxTspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.OverbackStboxTspatial(box, temp));

        public static bool OverbackTspatialStbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.OverbackTspatialStbox(temp, box));

        public static bool OverbackTspatialTspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.OverbackTspatialTspatial(temp1, temp2));

        public static bool OverbeforeStboxTspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.OverbeforeStboxTspatial(box, temp));

        public static bool OverbeforeTspatialStbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.OverbeforeTspatialStbox(temp, box));

        public static bool OverbeforeTspatialTspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.OverbeforeTspatialTspatial(temp1, temp2));

        public static bool OverbelowStboxTspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.OverbelowStboxTspatial(box, temp));

        public static bool OverbelowTspatialStbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.OverbelowTspatialStbox(temp, box));

        public static bool OverbelowTspatialTspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.OverbelowTspatialTspatial(temp1, temp2));

        public static bool OverfrontStboxTspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.OverfrontStboxTspatial(box, temp));

        public static bool OverfrontTspatialStbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.OverfrontTspatialStbox(temp, box));

        public static bool OverfrontTspatialTspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.OverfrontTspatialTspatial(temp1, temp2));

        public static bool OverleftStboxTspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.OverleftStboxTspatial(box, temp));

        public static bool OverleftTspatialStbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.OverleftTspatialStbox(temp, box));

        public static bool OverleftTspatialTspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.OverleftTspatialTspatial(temp1, temp2));

        public static bool OverrightStboxTspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.OverrightStboxTspatial(box, temp));

        public static bool OverrightTspatialStbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.OverrightTspatialStbox(temp, box));

        public static bool OverrightTspatialTspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.OverrightTspatialTspatial(temp1, temp2));

        public static bool RightStboxTspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.RightStboxTspatial(box, temp));

        public static bool RightTspatialStbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.RightTspatialStbox(temp, box));

        public static bool RightTspatialTspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.RightTspatialTspatial(temp1, temp2));

        public static int AcontainsGeoTgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => Native.AcontainsGeoTgeo(gs, temp));

        public static int AcontainsTgeoGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.AcontainsTgeoGeo(temp, gs));

        public static int AcontainsTgeoTgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AcontainsTgeoTgeo(temp1, temp2));

        public static int AcoversGeoTgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => Native.AcoversGeoTgeo(gs, temp));

        public static int AcoversTgeoGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.AcoversTgeoGeo(temp, gs));

        public static int AcoversTgeoTgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AcoversTgeoTgeo(temp1, temp2));

        public static int AdisjointGeoTgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => Native.AdisjointGeoTgeo(gs, temp));

        public static int AdisjointTgeoGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.AdisjointTgeoGeo(temp, gs));

        public static int AdisjointTgeoTgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AdisjointTgeoTgeo(temp1, temp2));

        public static int AdwithinGeoTgeo(IntPtr gs, IntPtr temp, double dist)
            => SafeExecution<int>(() => Native.AdwithinGeoTgeo(gs, temp, dist));

        public static int AdwithinTgeoGeo(IntPtr temp, IntPtr gs, double dist)
            => SafeExecution<int>(() => Native.AdwithinTgeoGeo(temp, gs, dist));

        public static int AdwithinTgeoTgeo(IntPtr temp1, IntPtr temp2, double dist)
            => SafeExecution<int>(() => Native.AdwithinTgeoTgeo(temp1, temp2, dist));

        public static int AintersectsGeoTgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => Native.AintersectsGeoTgeo(gs, temp));

        public static int AintersectsTgeoGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.AintersectsTgeoGeo(temp, gs));

        public static int AintersectsTgeoTgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AintersectsTgeoTgeo(temp1, temp2));

        public static int AtouchesGeoTgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => Native.AtouchesGeoTgeo(gs, temp));

        public static int AtouchesTgeoGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.AtouchesTgeoGeo(temp, gs));

        public static int AtouchesTgeoTgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AtouchesTgeoTgeo(temp1, temp2));

        public static int AtouchesTpointGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.AtouchesTpointGeo(temp, gs));

        public static int AtouchesGeoTpoint(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => Native.AtouchesGeoTpoint(gs, temp));

        public static int EcontainsGeoTgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => Native.EcontainsGeoTgeo(gs, temp));

        public static int EcontainsTgeoGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.EcontainsTgeoGeo(temp, gs));

        public static int EcontainsTgeoTgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EcontainsTgeoTgeo(temp1, temp2));

        public static int EcoversGeoTgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => Native.EcoversGeoTgeo(gs, temp));

        public static int EcoversTgeoGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.EcoversTgeoGeo(temp, gs));

        public static int EcoversTgeoTgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EcoversTgeoTgeo(temp1, temp2));

        public static int EdisjointGeoTgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => Native.EdisjointGeoTgeo(gs, temp));

        public static int EdisjointTgeoGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.EdisjointTgeoGeo(temp, gs));

        public static int EdisjointTgeoTgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EdisjointTgeoTgeo(temp1, temp2));

        public static int EdwithinGeoTgeo(IntPtr gs, IntPtr temp, double dist)
            => SafeExecution<int>(() => Native.EdwithinGeoTgeo(gs, temp, dist));

        public static int EdwithinTgeoGeo(IntPtr temp, IntPtr gs, double dist)
            => SafeExecution<int>(() => Native.EdwithinTgeoGeo(temp, gs, dist));

        public static int EdwithinTgeoTgeo(IntPtr temp1, IntPtr temp2, double dist)
            => SafeExecution<int>(() => Native.EdwithinTgeoTgeo(temp1, temp2, dist));

        public static int EintersectsGeoTgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => Native.EintersectsGeoTgeo(gs, temp));

        public static int EintersectsTgeoGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.EintersectsTgeoGeo(temp, gs));

        public static int EintersectsTgeoTgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EintersectsTgeoTgeo(temp1, temp2));

        public static int EtouchesGeoTgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => Native.EtouchesGeoTgeo(gs, temp));

        public static int EtouchesTgeoGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.EtouchesTgeoGeo(temp, gs));

        public static int EtouchesTgeoTgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EtouchesTgeoTgeo(temp1, temp2));

        public static int EtouchesTpointGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.EtouchesTpointGeo(temp, gs));

        public static int EtouchesGeoTpoint(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => Native.EtouchesGeoTpoint(gs, temp));

        public static IntPtr TcontainsGeoTgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TcontainsGeoTgeo(gs, temp));

        public static IntPtr TcontainsTgeoGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TcontainsTgeoGeo(temp, gs));

        public static IntPtr TcontainsTgeoTgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TcontainsTgeoTgeo(temp1, temp2));

        public static IntPtr TcoversGeoTgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TcoversGeoTgeo(gs, temp));

        public static IntPtr TcoversTgeoGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TcoversTgeoGeo(temp, gs));

        public static IntPtr TcoversTgeoTgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TcoversTgeoTgeo(temp1, temp2));

        public static IntPtr TdisjointGeoTgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TdisjointGeoTgeo(gs, temp));

        public static IntPtr TdisjointTgeoGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TdisjointTgeoGeo(temp, gs));

        public static IntPtr TdisjointTgeoTgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TdisjointTgeoTgeo(temp1, temp2));

        public static IntPtr TdwithinGeoTgeo(IntPtr gs, IntPtr temp, double dist)
            => SafeExecution<IntPtr>(() => Native.TdwithinGeoTgeo(gs, temp, dist));

        public static IntPtr TdwithinTgeoGeo(IntPtr temp, IntPtr gs, double dist)
            => SafeExecution<IntPtr>(() => Native.TdwithinTgeoGeo(temp, gs, dist));

        public static IntPtr TdwithinTgeoTgeo(IntPtr temp1, IntPtr temp2, double dist)
            => SafeExecution<IntPtr>(() => Native.TdwithinTgeoTgeo(temp1, temp2, dist));

        public static IntPtr TintersectsGeoTgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TintersectsGeoTgeo(gs, temp));

        public static IntPtr TintersectsTgeoGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TintersectsTgeoGeo(temp, gs));

        public static IntPtr TintersectsTgeoTgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TintersectsTgeoTgeo(temp1, temp2));

        public static IntPtr TtouchesGeoTgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TtouchesGeoTgeo(gs, temp));

        public static IntPtr TtouchesTgeoGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TtouchesTgeoGeo(temp, gs));

        public static IntPtr TtouchesTgeoTgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TtouchesTgeoTgeo(temp1, temp2));

        public static int[] EdwithinTgeoarrTgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2, double dist)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.EdwithinTgeoarrTgeoarr(arr1, count1, arr2, count2, dist, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                int[] _out = new int[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int[] AdwithinTgeoarrTgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2, double dist)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.AdwithinTgeoarrTgeoarr(arr1, count1, arr2, count2, dist, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                int[] _out = new int[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int[] EintersectsTgeoarrTgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.EintersectsTgeoarrTgeoarr(arr1, count1, arr2, count2, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                int[] _out = new int[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int[] AintersectsTgeoarrTgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.AintersectsTgeoarrTgeoarr(arr1, count1, arr2, count2, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                int[] _out = new int[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int[] EtouchesTgeoarrTgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.EtouchesTgeoarrTgeoarr(arr1, count1, arr2, count2, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                int[] _out = new int[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int[] AtouchesTgeoarrTgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.AtouchesTgeoarrTgeoarr(arr1, count1, arr2, count2, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                int[] _out = new int[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int[] EdisjointTgeoarrTgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.EdisjointTgeoarrTgeoarr(arr1, count1, arr2, count2, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                int[] _out = new int[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int[] AdisjointTgeoarrTgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.AdisjointTgeoarrTgeoarr(arr1, count1, arr2, count2, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                int[] _out = new int[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static (int[], IntPtr[]) TdwithinTgeoarrTgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2, double dist)
        {
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            IntPtr _out_periods = Marshal.AllocHGlobal(IntPtr.Size);
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => Native.TdwithinTgeoarrTgeoarr(arr1, count1, arr2, count2, dist, _count_count, _out_periods));
                int _n = Marshal.ReadInt32(_count_count);
                int[] _resultArr = new int[_n];
                Marshal.Copy(_resultPtr, _resultArr, 0, _n);
                IntPtr __out_periods_arr = Marshal.ReadIntPtr(_out_periods);
                IntPtr[] __out_periods_out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { __out_periods_out[_i] = Marshal.ReadIntPtr(__out_periods_arr, _i * IntPtr.Size); }
                return (_resultArr, __out_periods_out);
            }
            finally
            {
            Marshal.FreeHGlobal(_count_count);
            Marshal.FreeHGlobal(_out_periods);
            }
        }

        public static (int[], IntPtr[]) TintersectsTgeoarrTgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2)
        {
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            IntPtr _out_periods = Marshal.AllocHGlobal(IntPtr.Size);
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => Native.TintersectsTgeoarrTgeoarr(arr1, count1, arr2, count2, _count_count, _out_periods));
                int _n = Marshal.ReadInt32(_count_count);
                int[] _resultArr = new int[_n];
                Marshal.Copy(_resultPtr, _resultArr, 0, _n);
                IntPtr __out_periods_arr = Marshal.ReadIntPtr(_out_periods);
                IntPtr[] __out_periods_out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { __out_periods_out[_i] = Marshal.ReadIntPtr(__out_periods_arr, _i * IntPtr.Size); }
                return (_resultArr, __out_periods_out);
            }
            finally
            {
            Marshal.FreeHGlobal(_count_count);
            Marshal.FreeHGlobal(_out_periods);
            }
        }

        public static (int[], IntPtr[]) TtouchesTgeoarrTgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2)
        {
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            IntPtr _out_periods = Marshal.AllocHGlobal(IntPtr.Size);
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => Native.TtouchesTgeoarrTgeoarr(arr1, count1, arr2, count2, _count_count, _out_periods));
                int _n = Marshal.ReadInt32(_count_count);
                int[] _resultArr = new int[_n];
                Marshal.Copy(_resultPtr, _resultArr, 0, _n);
                IntPtr __out_periods_arr = Marshal.ReadIntPtr(_out_periods);
                IntPtr[] __out_periods_out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { __out_periods_out[_i] = Marshal.ReadIntPtr(__out_periods_arr, _i * IntPtr.Size); }
                return (_resultArr, __out_periods_out);
            }
            finally
            {
            Marshal.FreeHGlobal(_count_count);
            Marshal.FreeHGlobal(_out_periods);
            }
        }

        public static (int[], IntPtr[]) TdisjointTgeoarrTgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2)
        {
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            IntPtr _out_periods = Marshal.AllocHGlobal(IntPtr.Size);
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => Native.TdisjointTgeoarrTgeoarr(arr1, count1, arr2, count2, _count_count, _out_periods));
                int _n = Marshal.ReadInt32(_count_count);
                int[] _resultArr = new int[_n];
                Marshal.Copy(_resultPtr, _resultArr, 0, _n);
                IntPtr __out_periods_arr = Marshal.ReadIntPtr(_out_periods);
                IntPtr[] __out_periods_out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { __out_periods_out[_i] = Marshal.ReadIntPtr(__out_periods_arr, _i * IntPtr.Size); }
                return (_resultArr, __out_periods_out);
            }
            finally
            {
            Marshal.FreeHGlobal(_count_count);
            Marshal.FreeHGlobal(_out_periods);
            }
        }

        public static IntPtr TdistanceTgeoGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TdistanceTgeoGeo(temp, gs));

        public static IntPtr TdistanceTgeoTgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TdistanceTgeoTgeo(temp1, temp2));

        public static double NadStboxGeo(IntPtr box, IntPtr gs)
            => SafeExecution<double>(() => Native.NadStboxGeo(box, gs));

        public static double NadStboxStbox(IntPtr box1, IntPtr box2)
            => SafeExecution<double>(() => Native.NadStboxStbox(box1, box2));

        public static double StboxSpatialDistance(IntPtr box1, IntPtr box2)
            => SafeExecution<double>(() => Native.StboxSpatialDistance(box1, box2));

        public static double NadTgeoGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<double>(() => Native.NadTgeoGeo(temp, gs));

        public static double NadTgeoStbox(IntPtr temp, IntPtr box)
            => SafeExecution<double>(() => Native.NadTgeoStbox(temp, box));

        public static double NadTgeoTgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => Native.NadTgeoTgeo(temp1, temp2));

        public static IntPtr NaiTgeoGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.NaiTgeoGeo(temp, gs));

        public static IntPtr NaiTgeoTgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.NaiTgeoTgeo(temp1, temp2));

        public static IntPtr ShortestlineTgeoGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.ShortestlineTgeoGeo(temp, gs));

        public static IntPtr ShortestlineTgeoTgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.ShortestlineTgeoTgeo(temp1, temp2));

        public static double MindistanceTgeoTgeo(IntPtr temp1, IntPtr temp2, double threshold)
            => SafeExecution<double>(() => Native.MindistanceTgeoTgeo(temp1, temp2, threshold));

        public static double MindistanceTgeoarrTgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2)
            => SafeExecution<double>(() => Native.MindistanceTgeoarrTgeoarr(arr1, count1, arr2, count2));

        public static IntPtr TpointTcentroidFinalfn(IntPtr state)
            => SafeExecution<IntPtr>(() => Native.TpointTcentroidFinalfn(state));

        public static IntPtr TpointTcentroidTransfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TpointTcentroidTransfn(state, temp));

        public static IntPtr TspatialExtentTransfn(IntPtr box, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TspatialExtentTransfn(box, temp));

        public static IntPtr StboxGetSpaceTile(IntPtr point, double xsize, double ysize, double zsize, IntPtr sorigin)
            => SafeExecution<IntPtr>(() => Native.StboxGetSpaceTile(point, xsize, ysize, zsize, sorigin));

        public static IntPtr StboxGetSpaceTimeTile(IntPtr point, long t, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, long torigin)
            => SafeExecution<IntPtr>(() => Native.StboxGetSpaceTimeTile(point, t, xsize, ysize, zsize, duration, sorigin, torigin));

        public static IntPtr StboxGetTimeTile(long t, IntPtr duration, long torigin)
            => SafeExecution<IntPtr>(() => Native.StboxGetTimeTile(t, duration, torigin));

        public static IntPtr[] StboxSpaceTiles(IntPtr bounds, double xsize, double ysize, double zsize, IntPtr sorigin, bool border_inc)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.StboxSpaceTiles(bounds, xsize, ysize, zsize, sorigin, border_inc, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 80); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] StboxSpaceTimeTiles(IntPtr bounds, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, long torigin, bool border_inc)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.StboxSpaceTimeTiles(bounds, xsize, ysize, zsize, duration, sorigin, torigin, border_inc, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 80); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] StboxTimeTiles(IntPtr bounds, IntPtr duration, long torigin, bool border_inc)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.StboxTimeTiles(bounds, duration, torigin, border_inc, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 80); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr TgeoSpaceSplit(IntPtr temp, double xsize, double ysize, double zsize, IntPtr sorigin, bool bitmatrix, bool border_inc)
            => SafeExecution<IntPtr>(() => Native.TgeoSpaceSplit(temp, xsize, ysize, zsize, sorigin, bitmatrix, border_inc));

        public static IntPtr TgeoSpaceTimeSplit(IntPtr temp, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, long torigin, bool bitmatrix, bool border_inc)
            => SafeExecution<IntPtr>(() => Native.TgeoSpaceTimeSplit(temp, xsize, ysize, zsize, duration, sorigin, torigin, bitmatrix, border_inc));

        public static int[] GeoClusterKmeans(IntPtr geoms, uint ngeoms, uint k)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.GeoClusterKmeans(geoms, ngeoms, k, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                int[] _out = new int[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] GeoClusterDbscan(IntPtr geoms, uint ngeoms, double tolerance, int minpoints)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.GeoClusterDbscan(geoms, ngeoms, tolerance, minpoints, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] GeoClusterIntersecting(IntPtr geoms, uint ngeoms)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.GeoClusterIntersecting(geoms, ngeoms, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] GeoClusterWithin(IntPtr geoms, uint ngeoms, double tolerance)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.GeoClusterWithin(geoms, ngeoms, tolerance, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

    }
}
