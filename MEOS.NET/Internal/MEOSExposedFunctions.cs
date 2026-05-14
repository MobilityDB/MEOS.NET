using System.CodeDom.Compiler;
using System.Runtime.InteropServices;

using MEOS.NET.Enums;

namespace MEOS.NET.Internal
{
    [GeneratedCode("MEOS.NET.Builder.MEOSIDL", "0.1.0")]
    internal partial class MEOSExposedFunctions
    {
        public static string describeH3Error(uint err)
            => SafeExecution<string>(() => MEOSExternalFunctions.describeH3Error(err));

        public static uint latLngToCell(IntPtr g, int res, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.latLngToCell(g, res, @out));

        public static uint cellToLatLng(ulong h3, IntPtr g)
            => SafeExecution<uint>(() => MEOSExternalFunctions.cellToLatLng(h3, g));

        public static uint cellToBoundary(ulong h3, IntPtr gp)
            => SafeExecution<uint>(() => MEOSExternalFunctions.cellToBoundary(h3, gp));

        public static uint maxGridDiskSize(int k, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.maxGridDiskSize(k, @out));

        public static uint gridDiskUnsafe(ulong origin, int k, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.gridDiskUnsafe(origin, k, @out));

        public static uint gridDiskDistancesUnsafe(ulong origin, int k, IntPtr @out, IntPtr distances)
            => SafeExecution<uint>(() => MEOSExternalFunctions.gridDiskDistancesUnsafe(origin, k, @out, distances));

        public static uint gridDiskDistancesSafe(ulong origin, int k, IntPtr @out, IntPtr distances)
            => SafeExecution<uint>(() => MEOSExternalFunctions.gridDiskDistancesSafe(origin, k, @out, distances));

        public static uint gridDisksUnsafe(IntPtr h3Set, int length, int k, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.gridDisksUnsafe(h3Set, length, k, @out));

        public static uint gridDisk(ulong origin, int k, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.gridDisk(origin, k, @out));

        public static uint gridDiskDistances(ulong origin, int k, IntPtr @out, IntPtr distances)
            => SafeExecution<uint>(() => MEOSExternalFunctions.gridDiskDistances(origin, k, @out, distances));

        public static uint maxGridRingSize(int k, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.maxGridRingSize(k, @out));

        public static uint gridRingUnsafe(ulong origin, int k, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.gridRingUnsafe(origin, k, @out));

        public static uint gridRing(ulong origin, int k, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.gridRing(origin, k, @out));

        public static uint maxPolygonToCellsSize(IntPtr geoPolygon, int res, uint flags, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.maxPolygonToCellsSize(geoPolygon, res, flags, @out));

        public static uint polygonToCells(IntPtr geoPolygon, int res, uint flags, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.polygonToCells(geoPolygon, res, flags, @out));

        public static uint maxPolygonToCellsSizeExperimental(IntPtr polygon, int res, uint flags, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.maxPolygonToCellsSizeExperimental(polygon, res, flags, @out));

        public static uint polygonToCellsExperimental(IntPtr polygon, int res, uint flags, long size, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.polygonToCellsExperimental(polygon, res, flags, size, @out));

        public static uint cellsToLinkedMultiPolygon(IntPtr h3Set, int numHexes, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.cellsToLinkedMultiPolygon(h3Set, numHexes, @out));

        public static void destroyLinkedMultiPolygon(IntPtr polygon)
            => SafeExecution(() => MEOSExternalFunctions.destroyLinkedMultiPolygon(polygon));

        public static double degsToRads(double degrees)
            => SafeExecution<double>(() => MEOSExternalFunctions.degsToRads(degrees));

        public static double radsToDegs(double radians)
            => SafeExecution<double>(() => MEOSExternalFunctions.radsToDegs(radians));

        public static double greatCircleDistanceRads(IntPtr a, IntPtr b)
            => SafeExecution<double>(() => MEOSExternalFunctions.greatCircleDistanceRads(a, b));

        public static double greatCircleDistanceKm(IntPtr a, IntPtr b)
            => SafeExecution<double>(() => MEOSExternalFunctions.greatCircleDistanceKm(a, b));

        public static double greatCircleDistanceM(IntPtr a, IntPtr b)
            => SafeExecution<double>(() => MEOSExternalFunctions.greatCircleDistanceM(a, b));

        public static uint getHexagonAreaAvgKm2(int res, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.getHexagonAreaAvgKm2(res, @out));

        public static uint getHexagonAreaAvgM2(int res, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.getHexagonAreaAvgM2(res, @out));

        public static uint cellAreaRads2(ulong h, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.cellAreaRads2(h, @out));

        public static uint cellAreaKm2(ulong h, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.cellAreaKm2(h, @out));

        public static uint cellAreaM2(ulong h, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.cellAreaM2(h, @out));

        public static uint getHexagonEdgeLengthAvgKm(int res, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.getHexagonEdgeLengthAvgKm(res, @out));

        public static uint getHexagonEdgeLengthAvgM(int res, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.getHexagonEdgeLengthAvgM(res, @out));

        public static uint edgeLengthRads(ulong edge, IntPtr length)
            => SafeExecution<uint>(() => MEOSExternalFunctions.edgeLengthRads(edge, length));

        public static uint edgeLengthKm(ulong edge, IntPtr length)
            => SafeExecution<uint>(() => MEOSExternalFunctions.edgeLengthKm(edge, length));

        public static uint edgeLengthM(ulong edge, IntPtr length)
            => SafeExecution<uint>(() => MEOSExternalFunctions.edgeLengthM(edge, length));

        public static uint getNumCells(int res, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.getNumCells(res, @out));

        public static int res0CellCount()
            => SafeExecution<int>(() => MEOSExternalFunctions.res0CellCount());

        public static uint getRes0Cells(IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.getRes0Cells(@out));

        public static int pentagonCount()
            => SafeExecution<int>(() => MEOSExternalFunctions.pentagonCount());

        public static uint getPentagons(int res, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.getPentagons(res, @out));

        public static int getResolution(ulong h)
            => SafeExecution<int>(() => MEOSExternalFunctions.getResolution(h));

        public static int getBaseCellNumber(ulong h)
            => SafeExecution<int>(() => MEOSExternalFunctions.getBaseCellNumber(h));

        public static uint getIndexDigit(ulong h, int res, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.getIndexDigit(h, res, @out));

        public static uint constructCell(int res, int baseCellNumber, IntPtr digits, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.constructCell(res, baseCellNumber, digits, @out));

        public static uint stringToH3(string str, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.stringToH3(str, @out));

        public static uint h3ToString(ulong h, string str, ulong sz)
            => SafeExecution<uint>(() => MEOSExternalFunctions.h3ToString(h, str, sz));

        public static int isValidCell(ulong h)
            => SafeExecution<int>(() => MEOSExternalFunctions.isValidCell(h));

        public static int isValidIndex(ulong h)
            => SafeExecution<int>(() => MEOSExternalFunctions.isValidIndex(h));

        public static uint cellToParent(ulong h, int parentRes, IntPtr parent)
            => SafeExecution<uint>(() => MEOSExternalFunctions.cellToParent(h, parentRes, parent));

        public static uint cellToChildrenSize(ulong h, int childRes, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.cellToChildrenSize(h, childRes, @out));

        public static uint cellToChildren(ulong h, int childRes, IntPtr children)
            => SafeExecution<uint>(() => MEOSExternalFunctions.cellToChildren(h, childRes, children));

        public static uint cellToCenterChild(ulong h, int childRes, IntPtr child)
            => SafeExecution<uint>(() => MEOSExternalFunctions.cellToCenterChild(h, childRes, child));

        public static uint cellToChildPos(ulong child, int parentRes, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.cellToChildPos(child, parentRes, @out));

        public static uint childPosToCell(long childPos, ulong parent, int childRes, IntPtr child)
            => SafeExecution<uint>(() => MEOSExternalFunctions.childPosToCell(childPos, parent, childRes, child));

        public static uint compactCells(IntPtr h3Set, IntPtr compactedSet, long numHexes)
            => SafeExecution<uint>(() => MEOSExternalFunctions.compactCells(h3Set, compactedSet, numHexes));

        public static uint uncompactCellsSize(IntPtr compactedSet, long numCompacted, int res, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.uncompactCellsSize(compactedSet, numCompacted, res, @out));

        public static uint uncompactCells(IntPtr compactedSet, long numCompacted, IntPtr outSet, long numOut, int res)
            => SafeExecution<uint>(() => MEOSExternalFunctions.uncompactCells(compactedSet, numCompacted, outSet, numOut, res));

        public static int isResClassIII(ulong h)
            => SafeExecution<int>(() => MEOSExternalFunctions.isResClassIII(h));

        public static int isPentagon(ulong h)
            => SafeExecution<int>(() => MEOSExternalFunctions.isPentagon(h));

        public static uint maxFaceCount(ulong h3, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.maxFaceCount(h3, @out));

        public static uint getIcosahedronFaces(ulong h3, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.getIcosahedronFaces(h3, @out));

        public static uint areNeighborCells(ulong origin, ulong destination, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.areNeighborCells(origin, destination, @out));

        public static uint cellsToDirectedEdge(ulong origin, ulong destination, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.cellsToDirectedEdge(origin, destination, @out));

        public static int isValidDirectedEdge(ulong edge)
            => SafeExecution<int>(() => MEOSExternalFunctions.isValidDirectedEdge(edge));

        public static uint getDirectedEdgeOrigin(ulong edge, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.getDirectedEdgeOrigin(edge, @out));

        public static uint getDirectedEdgeDestination(ulong edge, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.getDirectedEdgeDestination(edge, @out));

        public static uint directedEdgeToCells(ulong edge, IntPtr originDestination)
            => SafeExecution<uint>(() => MEOSExternalFunctions.directedEdgeToCells(edge, originDestination));

        public static uint originToDirectedEdges(ulong origin, IntPtr edges)
            => SafeExecution<uint>(() => MEOSExternalFunctions.originToDirectedEdges(origin, edges));

        public static uint directedEdgeToBoundary(ulong edge, IntPtr gb)
            => SafeExecution<uint>(() => MEOSExternalFunctions.directedEdgeToBoundary(edge, gb));

        public static uint cellToVertex(ulong origin, int vertexNum, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.cellToVertex(origin, vertexNum, @out));

        public static uint cellToVertexes(ulong origin, IntPtr vertexes)
            => SafeExecution<uint>(() => MEOSExternalFunctions.cellToVertexes(origin, vertexes));

        public static uint vertexToLatLng(ulong vertex, IntPtr point)
            => SafeExecution<uint>(() => MEOSExternalFunctions.vertexToLatLng(vertex, point));

        public static int isValidVertex(ulong vertex)
            => SafeExecution<int>(() => MEOSExternalFunctions.isValidVertex(vertex));

        public static uint gridDistance(ulong origin, ulong h3, IntPtr distance)
            => SafeExecution<uint>(() => MEOSExternalFunctions.gridDistance(origin, h3, distance));

        public static uint gridPathCellsSize(ulong start, ulong end, IntPtr size)
            => SafeExecution<uint>(() => MEOSExternalFunctions.gridPathCellsSize(start, end, size));

        public static uint gridPathCells(ulong start, ulong end, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.gridPathCells(start, end, @out));

        public static uint cellToLocalIj(ulong origin, ulong h3, uint mode, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.cellToLocalIj(origin, h3, mode, @out));

        public static uint localIjToCell(ulong origin, IntPtr ij, uint mode, IntPtr @out)
            => SafeExecution<uint>(() => MEOSExternalFunctions.localIjToCell(origin, ij, mode, @out));

        public static int date_in(string str)
            => SafeExecution<int>(() => MEOSExternalFunctions.date_in(str));

        public static string date_out(int d)
            => SafeExecution<string>(() => MEOSExternalFunctions.date_out(d));

        public static int interval_cmp(IntPtr interv1, IntPtr interv2)
            => SafeExecution<int>(() => MEOSExternalFunctions.interval_cmp(interv1, interv2));

        public static IntPtr interval_in(string str, int typmod)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.interval_in(str, typmod));

        public static string interval_out(IntPtr interv)
            => SafeExecution<string>(() => MEOSExternalFunctions.interval_out(interv));

        public static long time_in(string str, int typmod)
            => SafeExecution<long>(() => MEOSExternalFunctions.time_in(str, typmod));

        public static string time_out(long t)
            => SafeExecution<string>(() => MEOSExternalFunctions.time_out(t));

        public static long timestamp_in(string str, int typmod)
            => SafeExecution<long>(() => MEOSExternalFunctions.timestamp_in(str, typmod));

        public static string timestamp_out(long t)
            => SafeExecution<string>(() => MEOSExternalFunctions.timestamp_out(t));

        public static long timestamptz_in(string str, int typmod)
            => SafeExecution<long>(() => MEOSExternalFunctions.timestamptz_in(str, typmod));

        public static string timestamptz_out(long t)
            => SafeExecution<string>(() => MEOSExternalFunctions.timestamptz_out(t));

        public static IntPtr meos_array_create(int elem_size)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.meos_array_create(elem_size));

        public static void meos_array_add(IntPtr array, IntPtr value)
            => SafeExecution(() => MEOSExternalFunctions.meos_array_add(array, value));

        public static IntPtr meos_array_get(IntPtr array, int n)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.meos_array_get(array, n));

        public static int meos_array_count(IntPtr array)
            => SafeExecution<int>(() => MEOSExternalFunctions.meos_array_count(array));

        public static void meos_array_reset(IntPtr array)
            => SafeExecution(() => MEOSExternalFunctions.meos_array_reset(array));

        public static void meos_array_reset_free(IntPtr array)
            => SafeExecution(() => MEOSExternalFunctions.meos_array_reset_free(array));

        public static void meos_array_destroy(IntPtr array)
            => SafeExecution(() => MEOSExternalFunctions.meos_array_destroy(array));

        public static void meos_array_destroy_free(IntPtr array)
            => SafeExecution(() => MEOSExternalFunctions.meos_array_destroy_free(array));

        public static IntPtr rtree_create_intspan()
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.rtree_create_intspan());

        public static IntPtr rtree_create_bigintspan()
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.rtree_create_bigintspan());

        public static IntPtr rtree_create_floatspan()
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.rtree_create_floatspan());

        public static IntPtr rtree_create_datespan()
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.rtree_create_datespan());

        public static IntPtr rtree_create_tstzspan()
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.rtree_create_tstzspan());

        public static IntPtr rtree_create_tbox()
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.rtree_create_tbox());

        public static IntPtr rtree_create_stbox()
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.rtree_create_stbox());

        public static void rtree_free(IntPtr rtree)
            => SafeExecution(() => MEOSExternalFunctions.rtree_free(rtree));

        public static void rtree_insert(IntPtr rtree, IntPtr box, int id)
            => SafeExecution(() => MEOSExternalFunctions.rtree_insert(rtree, box, id));

        public static void rtree_insert_temporal(IntPtr rtree, IntPtr temp, int id)
            => SafeExecution(() => MEOSExternalFunctions.rtree_insert_temporal(rtree, temp, id));

        public static int rtree_search(IntPtr rtree, IntPtr op, IntPtr query, IntPtr result)
            => SafeExecution<int>(() => MEOSExternalFunctions.rtree_search(rtree, op, query, result));

        public static int rtree_search_temporal(IntPtr rtree, IntPtr op, IntPtr temp, IntPtr result)
            => SafeExecution<int>(() => MEOSExternalFunctions.rtree_search_temporal(rtree, op, temp, result));

        public static void meos_error(int errlevel, int errcode, string format)
            => SafeExecution(() => MEOSExternalFunctions.meos_error(errlevel, errcode, format));

        public static int meos_errno()
            => SafeExecution<int>(() => MEOSExternalFunctions.meos_errno());

        public static int meos_errno_set(int err)
            => SafeExecution<int>(() => MEOSExternalFunctions.meos_errno_set(err));

        public static int meos_errno_restore(int err)
            => SafeExecution<int>(() => MEOSExternalFunctions.meos_errno_restore(err));

        public static int meos_errno_reset()
            => SafeExecution<int>(() => MEOSExternalFunctions.meos_errno_reset());

        public static void meos_initialize_timezone(string name)
            => SafeExecution(() => MEOSExternalFunctions.meos_initialize_timezone(name));

        public static void meos_initialize_error_handler(IntPtr err_handler)
            => SafeExecution(() => MEOSExternalFunctions.meos_initialize_error_handler(err_handler));

        public static void meos_finalize_timezone()
            => SafeExecution(() => MEOSExternalFunctions.meos_finalize_timezone());

        public static void meos_finalize_projsrs()
            => SafeExecution(() => MEOSExternalFunctions.meos_finalize_projsrs());

        public static void meos_finalize_ways()
            => SafeExecution(() => MEOSExternalFunctions.meos_finalize_ways());

        public static bool meos_set_datestyle(string newval, IntPtr extra)
            => SafeExecution<bool>(() => MEOSExternalFunctions.meos_set_datestyle(newval, extra));

        public static bool meos_set_intervalstyle(string newval, int extra)
            => SafeExecution<bool>(() => MEOSExternalFunctions.meos_set_intervalstyle(newval, extra));

        public static string meos_get_datestyle()
            => SafeExecution<string>(() => MEOSExternalFunctions.meos_get_datestyle());

        public static string meos_get_intervalstyle()
            => SafeExecution<string>(() => MEOSExternalFunctions.meos_get_intervalstyle());

        public static void meos_set_spatial_ref_sys_csv(string path)
            => SafeExecution(() => MEOSExternalFunctions.meos_set_spatial_ref_sys_csv(path));

        public static void meos_initialize()
            => SafeExecution(() => MEOSExternalFunctions.meos_initialize());

        public static void meos_finalize()
            => SafeExecution(() => MEOSExternalFunctions.meos_finalize());

        public static int add_date_int(int d, int days)
            => SafeExecution<int>(() => MEOSExternalFunctions.add_date_int(d, days));

        public static IntPtr add_interval_interval(IntPtr interv1, IntPtr interv2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.add_interval_interval(interv1, interv2));

        public static long add_timestamptz_interval(long t, IntPtr interv)
            => SafeExecution<long>(() => MEOSExternalFunctions.add_timestamptz_interval(t, interv));

        public static bool bool_in(string str)
            => SafeExecution<bool>(() => MEOSExternalFunctions.bool_in(str));

        public static string bool_out(bool b)
            => SafeExecution<string>(() => MEOSExternalFunctions.bool_out(b));

        public static IntPtr cstring2text(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cstring2text(str));

        public static long date_to_timestamp(int dateVal)
            => SafeExecution<long>(() => MEOSExternalFunctions.date_to_timestamp(dateVal));

        public static long date_to_timestamptz(int d)
            => SafeExecution<long>(() => MEOSExternalFunctions.date_to_timestamptz(d));

        public static double float_exp(double d)
            => SafeExecution<double>(() => MEOSExternalFunctions.float_exp(d));

        public static double float_ln(double d)
            => SafeExecution<double>(() => MEOSExternalFunctions.float_ln(d));

        public static double float_log10(double d)
            => SafeExecution<double>(() => MEOSExternalFunctions.float_log10(d));

        public static string float8_out(double d, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.float8_out(d, maxdd));

        public static double float_round(double d, int maxdd)
            => SafeExecution<double>(() => MEOSExternalFunctions.float_round(d, maxdd));

        public static int int32_cmp(int l, int r)
            => SafeExecution<int>(() => MEOSExternalFunctions.int32_cmp(l, r));

        public static int int64_cmp(long l, long r)
            => SafeExecution<int>(() => MEOSExternalFunctions.int64_cmp(l, r));

        public static IntPtr interval_make(int years, int months, int weeks, int days, int hours, int mins, double secs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.interval_make(years, months, weeks, days, hours, mins, secs));

        public static int minus_date_date(int d1, int d2)
            => SafeExecution<int>(() => MEOSExternalFunctions.minus_date_date(d1, d2));

        public static int minus_date_int(int d, int days)
            => SafeExecution<int>(() => MEOSExternalFunctions.minus_date_int(d, days));

        public static long minus_timestamptz_interval(long t, IntPtr interv)
            => SafeExecution<long>(() => MEOSExternalFunctions.minus_timestamptz_interval(t, interv));

        public static IntPtr minus_timestamptz_timestamptz(long t1, long t2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_timestamptz_timestamptz(t1, t2));

        public static IntPtr mul_interval_double(IntPtr interv, double factor)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.mul_interval_double(interv, factor));

        public static int pg_date_in(string str)
            => SafeExecution<int>(() => MEOSExternalFunctions.pg_date_in(str));

        public static string pg_date_out(int d)
            => SafeExecution<string>(() => MEOSExternalFunctions.pg_date_out(d));

        public static int pg_interval_cmp(IntPtr interv1, IntPtr interv2)
            => SafeExecution<int>(() => MEOSExternalFunctions.pg_interval_cmp(interv1, interv2));

        public static IntPtr pg_interval_in(string str, int typmod)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pg_interval_in(str, typmod));

        public static string pg_interval_out(IntPtr interv)
            => SafeExecution<string>(() => MEOSExternalFunctions.pg_interval_out(interv));

        public static long pg_timestamp_in(string str, int typmod)
            => SafeExecution<long>(() => MEOSExternalFunctions.pg_timestamp_in(str, typmod));

        public static string pg_timestamp_out(long t)
            => SafeExecution<string>(() => MEOSExternalFunctions.pg_timestamp_out(t));

        public static long pg_timestamptz_in(string str, int typmod)
            => SafeExecution<long>(() => MEOSExternalFunctions.pg_timestamptz_in(str, typmod));

        public static string pg_timestamptz_out(long t)
            => SafeExecution<string>(() => MEOSExternalFunctions.pg_timestamptz_out(t));

        public static string text2cstring(IntPtr txt)
            => SafeExecution<string>(() => MEOSExternalFunctions.text2cstring(txt));

        public static int text_cmp(IntPtr txt1, IntPtr txt2)
            => SafeExecution<int>(() => MEOSExternalFunctions.text_cmp(txt1, txt2));

        public static IntPtr text_copy(IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.text_copy(txt));

        public static IntPtr text_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.text_in(str));

        public static IntPtr text_initcap(IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.text_initcap(txt));

        public static IntPtr text_lower(IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.text_lower(txt));

        public static string text_out(IntPtr txt)
            => SafeExecution<string>(() => MEOSExternalFunctions.text_out(txt));

        public static IntPtr text_upper(IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.text_upper(txt));

        public static IntPtr textcat_text_text(IntPtr txt1, IntPtr txt2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.textcat_text_text(txt1, txt2));

        public static long timestamptz_shift(long t, IntPtr interv)
            => SafeExecution<long>(() => MEOSExternalFunctions.timestamptz_shift(t, interv));

        public static int timestamp_to_date(long t)
            => SafeExecution<int>(() => MEOSExternalFunctions.timestamp_to_date(t));

        public static int timestamptz_to_date(long t)
            => SafeExecution<int>(() => MEOSExternalFunctions.timestamptz_to_date(t));

        public static IntPtr bigintset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintset_in(str));

        public static string bigintset_out(IntPtr set)
            => SafeExecution<string>(() => MEOSExternalFunctions.bigintset_out(set));

        public static IntPtr bigintspan_expand(IntPtr s, long value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintspan_expand(s, value));

        public static IntPtr bigintspan_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintspan_in(str));

        public static string bigintspan_out(IntPtr s)
            => SafeExecution<string>(() => MEOSExternalFunctions.bigintspan_out(s));

        public static IntPtr bigintspanset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintspanset_in(str));

        public static string bigintspanset_out(IntPtr ss)
            => SafeExecution<string>(() => MEOSExternalFunctions.bigintspanset_out(ss));

        public static IntPtr dateset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.dateset_in(str));

        public static string dateset_out(IntPtr s)
            => SafeExecution<string>(() => MEOSExternalFunctions.dateset_out(s));

        public static IntPtr datespan_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.datespan_in(str));

        public static string datespan_out(IntPtr s)
            => SafeExecution<string>(() => MEOSExternalFunctions.datespan_out(s));

        public static IntPtr datespanset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.datespanset_in(str));

        public static string datespanset_out(IntPtr ss)
            => SafeExecution<string>(() => MEOSExternalFunctions.datespanset_out(ss));

        public static IntPtr floatset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatset_in(str));

        public static string floatset_out(IntPtr set, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.floatset_out(set, maxdd));

        public static IntPtr floatspan_expand(IntPtr s, double value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspan_expand(s, value));

        public static IntPtr floatspan_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspan_in(str));

        public static string floatspan_out(IntPtr s, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.floatspan_out(s, maxdd));

        public static IntPtr floatspanset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspanset_in(str));

        public static string floatspanset_out(IntPtr ss, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.floatspanset_out(ss, maxdd));

        public static IntPtr intset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intset_in(str));

        public static string intset_out(IntPtr set)
            => SafeExecution<string>(() => MEOSExternalFunctions.intset_out(set));

        public static IntPtr intspan_expand(IntPtr s, int value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intspan_expand(s, value));

        public static IntPtr intspan_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intspan_in(str));

        public static string intspan_out(IntPtr s)
            => SafeExecution<string>(() => MEOSExternalFunctions.intspan_out(s));

        public static IntPtr intspanset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intspanset_in(str));

        public static string intspanset_out(IntPtr ss)
            => SafeExecution<string>(() => MEOSExternalFunctions.intspanset_out(ss));

        public static string set_as_hexwkb(IntPtr s, IntPtr variant, IntPtr size_out)
            => SafeExecution<string>(() => MEOSExternalFunctions.set_as_hexwkb(s, variant, size_out));

        public static IntPtr set_as_wkb(IntPtr s, IntPtr variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_as_wkb(s, variant, size_out));

        public static IntPtr set_from_hexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_from_hexwkb(hexwkb));

        public static IntPtr set_from_wkb(IntPtr wkb, ulong size)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_from_wkb(wkb, size));

        public static string span_as_hexwkb(IntPtr s, IntPtr variant, IntPtr size_out)
            => SafeExecution<string>(() => MEOSExternalFunctions.span_as_hexwkb(s, variant, size_out));

        public static IntPtr span_as_wkb(IntPtr s, IntPtr variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.span_as_wkb(s, variant, size_out));

        public static IntPtr span_from_hexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.span_from_hexwkb(hexwkb));

        public static IntPtr span_from_wkb(IntPtr wkb, ulong size)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.span_from_wkb(wkb, size));

        public static string spanset_as_hexwkb(IntPtr ss, IntPtr variant, IntPtr size_out)
            => SafeExecution<string>(() => MEOSExternalFunctions.spanset_as_hexwkb(ss, variant, size_out));

        public static IntPtr spanset_as_wkb(IntPtr ss, IntPtr variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_as_wkb(ss, variant, size_out));

        public static IntPtr spanset_from_hexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_from_hexwkb(hexwkb));

        public static IntPtr spanset_from_wkb(IntPtr wkb, ulong size)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_from_wkb(wkb, size));

        public static IntPtr textset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.textset_in(str));

        public static string textset_out(IntPtr set)
            => SafeExecution<string>(() => MEOSExternalFunctions.textset_out(set));

        public static IntPtr tstzset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzset_in(str));

        public static string tstzset_out(IntPtr set)
            => SafeExecution<string>(() => MEOSExternalFunctions.tstzset_out(set));

        public static IntPtr tstzspan_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspan_in(str));

        public static string tstzspan_out(IntPtr s)
            => SafeExecution<string>(() => MEOSExternalFunctions.tstzspan_out(s));

        public static IntPtr tstzspanset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspanset_in(str));

        public static string tstzspanset_out(IntPtr ss)
            => SafeExecution<string>(() => MEOSExternalFunctions.tstzspanset_out(ss));

        public static IntPtr bigintset_make(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintset_make(values, count));

        public static IntPtr bigintspan_make(long lower, long upper, bool lower_inc, bool upper_inc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintspan_make(lower, upper, lower_inc, upper_inc));

        public static IntPtr dateset_make(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.dateset_make(values, count));

        public static IntPtr datespan_make(int lower, int upper, bool lower_inc, bool upper_inc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.datespan_make(lower, upper, lower_inc, upper_inc));

        public static IntPtr floatset_make(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatset_make(values, count));

        public static IntPtr floatspan_make(double lower, double upper, bool lower_inc, bool upper_inc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspan_make(lower, upper, lower_inc, upper_inc));

        public static IntPtr intset_make(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intset_make(values, count));

        public static IntPtr intspan_make(int lower, int upper, bool lower_inc, bool upper_inc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intspan_make(lower, upper, lower_inc, upper_inc));

        public static IntPtr set_copy(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_copy(s));

        public static IntPtr span_copy(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.span_copy(s));

        public static IntPtr spanset_copy(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_copy(ss));

        public static IntPtr spanset_make(IntPtr spans, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_make(spans, count));

        public static IntPtr textset_make(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.textset_make(values, count));

        public static IntPtr tstzset_make(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzset_make(values, count));

        public static IntPtr tstzspan_make(long lower, long upper, bool lower_inc, bool upper_inc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspan_make(lower, upper, lower_inc, upper_inc));

        public static IntPtr bigint_to_set(long i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigint_to_set(i));

        public static IntPtr bigint_to_span(int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigint_to_span(i));

        public static IntPtr bigint_to_spanset(int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigint_to_spanset(i));

        public static IntPtr date_to_set(int d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.date_to_set(d));

        public static IntPtr date_to_span(int d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.date_to_span(d));

        public static IntPtr date_to_spanset(int d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.date_to_spanset(d));

        public static IntPtr dateset_to_tstzset(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.dateset_to_tstzset(s));

        public static IntPtr datespan_to_tstzspan(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.datespan_to_tstzspan(s));

        public static IntPtr datespanset_to_tstzspanset(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.datespanset_to_tstzspanset(ss));

        public static IntPtr float_to_set(double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.float_to_set(d));

        public static IntPtr float_to_span(double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.float_to_span(d));

        public static IntPtr float_to_spanset(double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.float_to_spanset(d));

        public static IntPtr floatset_to_intset(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatset_to_intset(s));

        public static IntPtr floatspan_to_intspan(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspan_to_intspan(s));

        public static IntPtr floatspanset_to_intspanset(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspanset_to_intspanset(ss));

        public static IntPtr int_to_set(int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.int_to_set(i));

        public static IntPtr int_to_span(int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.int_to_span(i));

        public static IntPtr int_to_spanset(int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.int_to_spanset(i));

        public static IntPtr intset_to_floatset(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intset_to_floatset(s));

        public static IntPtr intspan_to_floatspan(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intspan_to_floatspan(s));

        public static IntPtr intspanset_to_floatspanset(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intspanset_to_floatspanset(ss));

        public static IntPtr set_to_span(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_to_span(s));

        public static IntPtr set_to_spanset(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_to_spanset(s));

        public static IntPtr span_to_spanset(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.span_to_spanset(s));

        public static IntPtr text_to_set(IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.text_to_set(txt));

        public static IntPtr timestamptz_to_set(long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.timestamptz_to_set(t));

        public static IntPtr timestamptz_to_span(long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.timestamptz_to_span(t));

        public static IntPtr timestamptz_to_spanset(long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.timestamptz_to_spanset(t));

        public static IntPtr tstzset_to_dateset(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzset_to_dateset(s));

        public static IntPtr tstzspan_to_datespan(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspan_to_datespan(s));

        public static IntPtr tstzspanset_to_datespanset(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspanset_to_datespanset(ss));

        public static long bigintset_end_value(IntPtr s)
            => SafeExecution<long>(() => MEOSExternalFunctions.bigintset_end_value(s));

        public static long bigintset_start_value(IntPtr s)
            => SafeExecution<long>(() => MEOSExternalFunctions.bigintset_start_value(s));

        public static bool bigintset_value_n(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.bigintset_value_n(s, n, result));

        public static long[] bigintset_values(IntPtr s)
        {
            int _n = (int)MEOSExposedFunctions.set_num_values(s);
            IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintset_values(s));
            long[] _out = new long[_n];
            Marshal.Copy(_p, _out, 0, _n);
            return _out;
        }

        public static long bigintspan_lower(IntPtr s)
            => SafeExecution<long>(() => MEOSExternalFunctions.bigintspan_lower(s));

        public static long bigintspan_upper(IntPtr s)
            => SafeExecution<long>(() => MEOSExternalFunctions.bigintspan_upper(s));

        public static long bigintspan_width(IntPtr s)
            => SafeExecution<long>(() => MEOSExternalFunctions.bigintspan_width(s));

        public static long bigintspanset_lower(IntPtr ss)
            => SafeExecution<long>(() => MEOSExternalFunctions.bigintspanset_lower(ss));

        public static long bigintspanset_upper(IntPtr ss)
            => SafeExecution<long>(() => MEOSExternalFunctions.bigintspanset_upper(ss));

        public static long bigintspanset_width(IntPtr ss, bool boundspan)
            => SafeExecution<long>(() => MEOSExternalFunctions.bigintspanset_width(ss, boundspan));

        public static int dateset_end_value(IntPtr s)
            => SafeExecution<int>(() => MEOSExternalFunctions.dateset_end_value(s));

        public static int dateset_start_value(IntPtr s)
            => SafeExecution<int>(() => MEOSExternalFunctions.dateset_start_value(s));

        public static bool dateset_value_n(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.dateset_value_n(s, n, result));

        public static int[] dateset_values(IntPtr s)
        {
            int _n = (int)MEOSExposedFunctions.set_num_values(s);
            IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.dateset_values(s));
            int[] _out = new int[_n];
            Marshal.Copy(_p, _out, 0, _n);
            return _out;
        }

        public static IntPtr datespan_duration(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.datespan_duration(s));

        public static int datespan_lower(IntPtr s)
            => SafeExecution<int>(() => MEOSExternalFunctions.datespan_lower(s));

        public static int datespan_upper(IntPtr s)
            => SafeExecution<int>(() => MEOSExternalFunctions.datespan_upper(s));

        public static bool datespanset_date_n(IntPtr ss, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.datespanset_date_n(ss, n, result));

        public static IntPtr datespanset_dates(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.datespanset_dates(ss));

        public static IntPtr datespanset_duration(IntPtr ss, bool boundspan)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.datespanset_duration(ss, boundspan));

        public static int datespanset_end_date(IntPtr ss)
            => SafeExecution<int>(() => MEOSExternalFunctions.datespanset_end_date(ss));

        public static int datespanset_num_dates(IntPtr ss)
            => SafeExecution<int>(() => MEOSExternalFunctions.datespanset_num_dates(ss));

        public static int datespanset_start_date(IntPtr ss)
            => SafeExecution<int>(() => MEOSExternalFunctions.datespanset_start_date(ss));

        public static double floatset_end_value(IntPtr s)
            => SafeExecution<double>(() => MEOSExternalFunctions.floatset_end_value(s));

        public static double floatset_start_value(IntPtr s)
            => SafeExecution<double>(() => MEOSExternalFunctions.floatset_start_value(s));

        public static bool floatset_value_n(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.floatset_value_n(s, n, result));

        public static double[] floatset_values(IntPtr s)
        {
            int _n = (int)MEOSExposedFunctions.set_num_values(s);
            IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatset_values(s));
            double[] _out = new double[_n];
            Marshal.Copy(_p, _out, 0, _n);
            return _out;
        }

        public static double floatspan_lower(IntPtr s)
            => SafeExecution<double>(() => MEOSExternalFunctions.floatspan_lower(s));

        public static double floatspan_upper(IntPtr s)
            => SafeExecution<double>(() => MEOSExternalFunctions.floatspan_upper(s));

        public static double floatspan_width(IntPtr s)
            => SafeExecution<double>(() => MEOSExternalFunctions.floatspan_width(s));

        public static double floatspanset_lower(IntPtr ss)
            => SafeExecution<double>(() => MEOSExternalFunctions.floatspanset_lower(ss));

        public static double floatspanset_upper(IntPtr ss)
            => SafeExecution<double>(() => MEOSExternalFunctions.floatspanset_upper(ss));

        public static double floatspanset_width(IntPtr ss, bool boundspan)
            => SafeExecution<double>(() => MEOSExternalFunctions.floatspanset_width(ss, boundspan));

        public static int intset_end_value(IntPtr s)
            => SafeExecution<int>(() => MEOSExternalFunctions.intset_end_value(s));

        public static int intset_start_value(IntPtr s)
            => SafeExecution<int>(() => MEOSExternalFunctions.intset_start_value(s));

        public static bool intset_value_n(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.intset_value_n(s, n, result));

        public static int[] intset_values(IntPtr s)
        {
            int _n = (int)MEOSExposedFunctions.set_num_values(s);
            IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.intset_values(s));
            int[] _out = new int[_n];
            Marshal.Copy(_p, _out, 0, _n);
            return _out;
        }

        public static int intspan_lower(IntPtr s)
            => SafeExecution<int>(() => MEOSExternalFunctions.intspan_lower(s));

        public static int intspan_upper(IntPtr s)
            => SafeExecution<int>(() => MEOSExternalFunctions.intspan_upper(s));

        public static int intspan_width(IntPtr s)
            => SafeExecution<int>(() => MEOSExternalFunctions.intspan_width(s));

        public static int intspanset_lower(IntPtr ss)
            => SafeExecution<int>(() => MEOSExternalFunctions.intspanset_lower(ss));

        public static int intspanset_upper(IntPtr ss)
            => SafeExecution<int>(() => MEOSExternalFunctions.intspanset_upper(ss));

        public static int intspanset_width(IntPtr ss, bool boundspan)
            => SafeExecution<int>(() => MEOSExternalFunctions.intspanset_width(ss, boundspan));

        public static uint set_hash(IntPtr s)
            => SafeExecution<uint>(() => MEOSExternalFunctions.set_hash(s));

        public static ulong set_hash_extended(IntPtr s, ulong seed)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.set_hash_extended(s, seed));

        public static int set_num_values(IntPtr s)
            => SafeExecution<int>(() => MEOSExternalFunctions.set_num_values(s));

        public static uint span_hash(IntPtr s)
            => SafeExecution<uint>(() => MEOSExternalFunctions.span_hash(s));

        public static ulong span_hash_extended(IntPtr s, ulong seed)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.span_hash_extended(s, seed));

        public static bool span_lower_inc(IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.span_lower_inc(s));

        public static bool span_upper_inc(IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.span_upper_inc(s));

        public static IntPtr spanset_end_span(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_end_span(ss));

        public static uint spanset_hash(IntPtr ss)
            => SafeExecution<uint>(() => MEOSExternalFunctions.spanset_hash(ss));

        public static ulong spanset_hash_extended(IntPtr ss, ulong seed)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.spanset_hash_extended(ss, seed));

        public static bool spanset_lower_inc(IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.spanset_lower_inc(ss));

        public static int spanset_num_spans(IntPtr ss)
            => SafeExecution<int>(() => MEOSExternalFunctions.spanset_num_spans(ss));

        public static IntPtr spanset_span(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_span(ss));

        public static IntPtr spanset_span_n(IntPtr ss, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_span_n(ss, i));

        public static IntPtr[] spanset_spanarr(IntPtr ss)
        {
            int _n = (int)MEOSExposedFunctions.spanset_num_spans(ss);
            IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_spanarr(ss));
            IntPtr[] _out = new IntPtr[_n];
            for (int _i = 0; _i < _n; _i++)
            { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
            return _out;
        }

        public static IntPtr spanset_start_span(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_start_span(ss));

        public static bool spanset_upper_inc(IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.spanset_upper_inc(ss));

        public static IntPtr textset_end_value(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.textset_end_value(s));

        public static IntPtr textset_start_value(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.textset_start_value(s));

        public static bool textset_value_n(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.textset_value_n(s, n, result));

        public static IntPtr[] textset_values(IntPtr s)
        {
            int _n = (int)MEOSExposedFunctions.set_num_values(s);
            IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.textset_values(s));
            IntPtr[] _out = new IntPtr[_n];
            for (int _i = 0; _i < _n; _i++)
            { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
            return _out;
        }

        public static long tstzset_end_value(IntPtr s)
            => SafeExecution<long>(() => MEOSExternalFunctions.tstzset_end_value(s));

        public static long tstzset_start_value(IntPtr s)
            => SafeExecution<long>(() => MEOSExternalFunctions.tstzset_start_value(s));

        public static bool tstzset_value_n(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tstzset_value_n(s, n, result));

        public static long[] tstzset_values(IntPtr s)
        {
            int _n = (int)MEOSExposedFunctions.set_num_values(s);
            IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzset_values(s));
            long[] _out = new long[_n];
            Marshal.Copy(_p, _out, 0, _n);
            return _out;
        }

        public static IntPtr tstzspan_duration(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspan_duration(s));

        public static long tstzspan_lower(IntPtr s)
            => SafeExecution<long>(() => MEOSExternalFunctions.tstzspan_lower(s));

        public static long tstzspan_upper(IntPtr s)
            => SafeExecution<long>(() => MEOSExternalFunctions.tstzspan_upper(s));

        public static IntPtr tstzspanset_duration(IntPtr ss, bool boundspan)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspanset_duration(ss, boundspan));

        public static long tstzspanset_end_timestamptz(IntPtr ss)
            => SafeExecution<long>(() => MEOSExternalFunctions.tstzspanset_end_timestamptz(ss));

        public static long tstzspanset_lower(IntPtr ss)
            => SafeExecution<long>(() => MEOSExternalFunctions.tstzspanset_lower(ss));

        public static int tstzspanset_num_timestamps(IntPtr ss)
            => SafeExecution<int>(() => MEOSExternalFunctions.tstzspanset_num_timestamps(ss));

        public static long tstzspanset_start_timestamptz(IntPtr ss)
            => SafeExecution<long>(() => MEOSExternalFunctions.tstzspanset_start_timestamptz(ss));

        public static IntPtr tstzspanset_timestamps(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspanset_timestamps(ss));

        public static bool tstzspanset_timestamptz_n(IntPtr ss, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tstzspanset_timestamptz_n(ss, n, result));

        public static long tstzspanset_upper(IntPtr ss)
            => SafeExecution<long>(() => MEOSExternalFunctions.tstzspanset_upper(ss));

        public static IntPtr bigintset_shift_scale(IntPtr s, long shift, long width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintset_shift_scale(s, shift, width, hasshift, haswidth));

        public static IntPtr bigintspan_shift_scale(IntPtr s, long shift, long width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintspan_shift_scale(s, shift, width, hasshift, haswidth));

        public static IntPtr bigintspanset_shift_scale(IntPtr ss, long shift, long width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintspanset_shift_scale(ss, shift, width, hasshift, haswidth));

        public static IntPtr dateset_shift_scale(IntPtr s, int shift, int width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.dateset_shift_scale(s, shift, width, hasshift, haswidth));

        public static IntPtr datespan_shift_scale(IntPtr s, int shift, int width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.datespan_shift_scale(s, shift, width, hasshift, haswidth));

        public static IntPtr datespanset_shift_scale(IntPtr ss, int shift, int width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.datespanset_shift_scale(ss, shift, width, hasshift, haswidth));

        public static IntPtr floatset_ceil(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatset_ceil(s));

        public static IntPtr floatset_degrees(IntPtr s, bool normalize)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatset_degrees(s, normalize));

        public static IntPtr floatset_floor(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatset_floor(s));

        public static IntPtr floatset_radians(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatset_radians(s));

        public static IntPtr floatset_shift_scale(IntPtr s, double shift, double width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatset_shift_scale(s, shift, width, hasshift, haswidth));

        public static IntPtr floatspan_ceil(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspan_ceil(s));

        public static IntPtr floatspan_degrees(IntPtr s, bool normalize)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspan_degrees(s, normalize));

        public static IntPtr floatspan_floor(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspan_floor(s));

        public static IntPtr floatspan_radians(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspan_radians(s));

        public static IntPtr floatspan_round(IntPtr s, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspan_round(s, maxdd));

        public static IntPtr floatspan_shift_scale(IntPtr s, double shift, double width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspan_shift_scale(s, shift, width, hasshift, haswidth));

        public static IntPtr floatspanset_ceil(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspanset_ceil(ss));

        public static IntPtr floatspanset_floor(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspanset_floor(ss));

        public static IntPtr floatspanset_degrees(IntPtr ss, bool normalize)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspanset_degrees(ss, normalize));

        public static IntPtr floatspanset_radians(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspanset_radians(ss));

        public static IntPtr floatspanset_round(IntPtr ss, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspanset_round(ss, maxdd));

        public static IntPtr floatspanset_shift_scale(IntPtr ss, double shift, double width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspanset_shift_scale(ss, shift, width, hasshift, haswidth));

        public static IntPtr intset_shift_scale(IntPtr s, int shift, int width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intset_shift_scale(s, shift, width, hasshift, haswidth));

        public static IntPtr intspan_shift_scale(IntPtr s, int shift, int width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intspan_shift_scale(s, shift, width, hasshift, haswidth));

        public static IntPtr intspanset_shift_scale(IntPtr ss, int shift, int width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intspanset_shift_scale(ss, shift, width, hasshift, haswidth));

        public static IntPtr tstzspan_expand(IntPtr s, IntPtr interv)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspan_expand(s, interv));

        public static IntPtr set_round(IntPtr s, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_round(s, maxdd));

        public static IntPtr textcat_text_textset(IntPtr txt, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.textcat_text_textset(txt, s));

        public static IntPtr textcat_textset_text(IntPtr s, IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.textcat_textset_text(s, txt));

        public static IntPtr textset_initcap(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.textset_initcap(s));

        public static IntPtr textset_lower(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.textset_lower(s));

        public static IntPtr textset_upper(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.textset_upper(s));

        public static long timestamptz_tprecision(long t, IntPtr duration, long torigin)
            => SafeExecution<long>(() => MEOSExternalFunctions.timestamptz_tprecision(t, duration, torigin));

        public static IntPtr tstzset_shift_scale(IntPtr s, IntPtr shift, IntPtr duration)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzset_shift_scale(s, shift, duration));

        public static IntPtr tstzset_tprecision(IntPtr s, IntPtr duration, long torigin)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzset_tprecision(s, duration, torigin));

        public static IntPtr tstzspan_shift_scale(IntPtr s, IntPtr shift, IntPtr duration)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspan_shift_scale(s, shift, duration));

        public static IntPtr tstzspan_tprecision(IntPtr s, IntPtr duration, long torigin)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspan_tprecision(s, duration, torigin));

        public static IntPtr tstzspanset_shift_scale(IntPtr ss, IntPtr shift, IntPtr duration)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspanset_shift_scale(ss, shift, duration));

        public static IntPtr tstzspanset_tprecision(IntPtr ss, IntPtr duration, long torigin)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspanset_tprecision(ss, duration, torigin));

        public static int set_cmp(IntPtr s1, IntPtr s2)
            => SafeExecution<int>(() => MEOSExternalFunctions.set_cmp(s1, s2));

        public static bool set_eq(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.set_eq(s1, s2));

        public static bool set_ge(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.set_ge(s1, s2));

        public static bool set_gt(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.set_gt(s1, s2));

        public static bool set_le(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.set_le(s1, s2));

        public static bool set_lt(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.set_lt(s1, s2));

        public static bool set_ne(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.set_ne(s1, s2));

        public static int span_cmp(IntPtr s1, IntPtr s2)
            => SafeExecution<int>(() => MEOSExternalFunctions.span_cmp(s1, s2));

        public static bool span_eq(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.span_eq(s1, s2));

        public static bool span_ge(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.span_ge(s1, s2));

        public static bool span_gt(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.span_gt(s1, s2));

        public static bool span_le(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.span_le(s1, s2));

        public static bool span_lt(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.span_lt(s1, s2));

        public static bool span_ne(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.span_ne(s1, s2));

        public static int spanset_cmp(IntPtr ss1, IntPtr ss2)
            => SafeExecution<int>(() => MEOSExternalFunctions.spanset_cmp(ss1, ss2));

        public static bool spanset_eq(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.spanset_eq(ss1, ss2));

        public static bool spanset_ge(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.spanset_ge(ss1, ss2));

        public static bool spanset_gt(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.spanset_gt(ss1, ss2));

        public static bool spanset_le(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.spanset_le(ss1, ss2));

        public static bool spanset_lt(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.spanset_lt(ss1, ss2));

        public static bool spanset_ne(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.spanset_ne(ss1, ss2));

        public static IntPtr set_spans(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_spans(s));

        public static IntPtr set_split_each_n_spans(IntPtr s, int elems_per_span, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_split_each_n_spans(s, elems_per_span, count));

        public static IntPtr set_split_n_spans(IntPtr s, int span_count, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_split_n_spans(s, span_count, count));

        public static IntPtr spanset_spans(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_spans(ss));

        public static IntPtr spanset_split_each_n_spans(IntPtr ss, int elems_per_span, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_split_each_n_spans(ss, elems_per_span, count));

        public static IntPtr spanset_split_n_spans(IntPtr ss, int span_count, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_split_n_spans(ss, span_count, count));

        public static bool adjacent_span_bigint(IntPtr s, long i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_span_bigint(s, i));

        public static bool adjacent_span_date(IntPtr s, int d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_span_date(s, d));

        public static bool adjacent_span_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_span_float(s, d));

        public static bool adjacent_span_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_span_int(s, i));

        public static bool adjacent_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_span_span(s1, s2));

        public static bool adjacent_span_spanset(IntPtr s, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_span_spanset(s, ss));

        public static bool adjacent_span_timestamptz(IntPtr s, long t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_span_timestamptz(s, t));

        public static bool adjacent_spanset_bigint(IntPtr ss, long i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_spanset_bigint(ss, i));

        public static bool adjacent_spanset_date(IntPtr ss, int d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_spanset_date(ss, d));

        public static bool adjacent_spanset_float(IntPtr ss, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_spanset_float(ss, d));

        public static bool adjacent_spanset_int(IntPtr ss, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_spanset_int(ss, i));

        public static bool adjacent_spanset_timestamptz(IntPtr ss, long t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_spanset_timestamptz(ss, t));

        public static bool adjacent_spanset_span(IntPtr ss, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_spanset_span(ss, s));

        public static bool adjacent_spanset_spanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_spanset_spanset(ss1, ss2));

        public static bool contained_bigint_set(long i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_bigint_set(i, s));

        public static bool contained_bigint_span(long i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_bigint_span(i, s));

        public static bool contained_bigint_spanset(long i, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_bigint_spanset(i, ss));

        public static bool contained_date_set(int d, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_date_set(d, s));

        public static bool contained_date_span(int d, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_date_span(d, s));

        public static bool contained_date_spanset(int d, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_date_spanset(d, ss));

        public static bool contained_float_set(double d, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_float_set(d, s));

        public static bool contained_float_span(double d, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_float_span(d, s));

        public static bool contained_float_spanset(double d, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_float_spanset(d, ss));

        public static bool contained_int_set(int i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_int_set(i, s));

        public static bool contained_int_span(int i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_int_span(i, s));

        public static bool contained_int_spanset(int i, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_int_spanset(i, ss));

        public static bool contained_set_set(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_set_set(s1, s2));

        public static bool contained_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_span_span(s1, s2));

        public static bool contained_span_spanset(IntPtr s, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_span_spanset(s, ss));

        public static bool contained_spanset_span(IntPtr ss, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_spanset_span(ss, s));

        public static bool contained_spanset_spanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_spanset_spanset(ss1, ss2));

        public static bool contained_text_set(IntPtr txt, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_text_set(txt, s));

        public static bool contained_timestamptz_set(long t, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_timestamptz_set(t, s));

        public static bool contained_timestamptz_span(long t, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_timestamptz_span(t, s));

        public static bool contained_timestamptz_spanset(long t, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_timestamptz_spanset(t, ss));

        public static bool contains_set_bigint(IntPtr s, long i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_set_bigint(s, i));

        public static bool contains_set_date(IntPtr s, int d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_set_date(s, d));

        public static bool contains_set_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_set_float(s, d));

        public static bool contains_set_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_set_int(s, i));

        public static bool contains_set_set(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_set_set(s1, s2));

        public static bool contains_set_text(IntPtr s, IntPtr t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_set_text(s, t));

        public static bool contains_set_timestamptz(IntPtr s, long t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_set_timestamptz(s, t));

        public static bool contains_span_bigint(IntPtr s, long i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_span_bigint(s, i));

        public static bool contains_span_date(IntPtr s, int d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_span_date(s, d));

        public static bool contains_span_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_span_float(s, d));

        public static bool contains_span_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_span_int(s, i));

        public static bool contains_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_span_span(s1, s2));

        public static bool contains_span_spanset(IntPtr s, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_span_spanset(s, ss));

        public static bool contains_span_timestamptz(IntPtr s, long t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_span_timestamptz(s, t));

        public static bool contains_spanset_bigint(IntPtr ss, long i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_spanset_bigint(ss, i));

        public static bool contains_spanset_date(IntPtr ss, int d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_spanset_date(ss, d));

        public static bool contains_spanset_float(IntPtr ss, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_spanset_float(ss, d));

        public static bool contains_spanset_int(IntPtr ss, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_spanset_int(ss, i));

        public static bool contains_spanset_span(IntPtr ss, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_spanset_span(ss, s));

        public static bool contains_spanset_spanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_spanset_spanset(ss1, ss2));

        public static bool contains_spanset_timestamptz(IntPtr ss, long t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_spanset_timestamptz(ss, t));

        public static bool overlaps_set_set(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_set_set(s1, s2));

        public static bool overlaps_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_span_span(s1, s2));

        public static bool overlaps_span_spanset(IntPtr s, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_span_spanset(s, ss));

        public static bool overlaps_spanset_span(IntPtr ss, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_spanset_span(ss, s));

        public static bool overlaps_spanset_spanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_spanset_spanset(ss1, ss2));

        public static bool after_date_set(int d, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_date_set(d, s));

        public static bool after_date_span(int d, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_date_span(d, s));

        public static bool after_date_spanset(int d, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_date_spanset(d, ss));

        public static bool after_set_date(IntPtr s, int d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_set_date(s, d));

        public static bool after_set_timestamptz(IntPtr s, long t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_set_timestamptz(s, t));

        public static bool after_span_date(IntPtr s, int d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_span_date(s, d));

        public static bool after_span_timestamptz(IntPtr s, long t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_span_timestamptz(s, t));

        public static bool after_spanset_date(IntPtr ss, int d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_spanset_date(ss, d));

        public static bool after_spanset_timestamptz(IntPtr ss, long t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_spanset_timestamptz(ss, t));

        public static bool after_timestamptz_set(long t, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_timestamptz_set(t, s));

        public static bool after_timestamptz_span(long t, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_timestamptz_span(t, s));

        public static bool after_timestamptz_spanset(long t, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_timestamptz_spanset(t, ss));

        public static bool before_date_set(int d, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_date_set(d, s));

        public static bool before_date_span(int d, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_date_span(d, s));

        public static bool before_date_spanset(int d, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_date_spanset(d, ss));

        public static bool before_set_date(IntPtr s, int d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_set_date(s, d));

        public static bool before_set_timestamptz(IntPtr s, long t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_set_timestamptz(s, t));

        public static bool before_span_date(IntPtr s, int d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_span_date(s, d));

        public static bool before_span_timestamptz(IntPtr s, long t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_span_timestamptz(s, t));

        public static bool before_spanset_date(IntPtr ss, int d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_spanset_date(ss, d));

        public static bool before_spanset_timestamptz(IntPtr ss, long t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_spanset_timestamptz(ss, t));

        public static bool before_timestamptz_set(long t, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_timestamptz_set(t, s));

        public static bool before_timestamptz_span(long t, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_timestamptz_span(t, s));

        public static bool before_timestamptz_spanset(long t, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_timestamptz_spanset(t, ss));

        public static bool left_bigint_set(long i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_bigint_set(i, s));

        public static bool left_bigint_span(long i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_bigint_span(i, s));

        public static bool left_bigint_spanset(long i, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_bigint_spanset(i, ss));

        public static bool left_float_set(double d, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_float_set(d, s));

        public static bool left_float_span(double d, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_float_span(d, s));

        public static bool left_float_spanset(double d, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_float_spanset(d, ss));

        public static bool left_int_set(int i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_int_set(i, s));

        public static bool left_int_span(int i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_int_span(i, s));

        public static bool left_int_spanset(int i, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_int_spanset(i, ss));

        public static bool left_set_bigint(IntPtr s, long i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_set_bigint(s, i));

        public static bool left_set_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_set_float(s, d));

        public static bool left_set_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_set_int(s, i));

        public static bool left_set_set(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_set_set(s1, s2));

        public static bool left_set_text(IntPtr s, IntPtr txt)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_set_text(s, txt));

        public static bool left_span_bigint(IntPtr s, long i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_span_bigint(s, i));

        public static bool left_span_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_span_float(s, d));

        public static bool left_span_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_span_int(s, i));

        public static bool left_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_span_span(s1, s2));

        public static bool left_span_spanset(IntPtr s, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_span_spanset(s, ss));

        public static bool left_spanset_bigint(IntPtr ss, long i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_spanset_bigint(ss, i));

        public static bool left_spanset_float(IntPtr ss, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_spanset_float(ss, d));

        public static bool left_spanset_int(IntPtr ss, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_spanset_int(ss, i));

        public static bool left_spanset_span(IntPtr ss, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_spanset_span(ss, s));

        public static bool left_spanset_spanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_spanset_spanset(ss1, ss2));

        public static bool left_text_set(IntPtr txt, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_text_set(txt, s));

        public static bool overafter_date_set(int d, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_date_set(d, s));

        public static bool overafter_date_span(int d, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_date_span(d, s));

        public static bool overafter_date_spanset(int d, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_date_spanset(d, ss));

        public static bool overafter_set_date(IntPtr s, int d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_set_date(s, d));

        public static bool overafter_set_timestamptz(IntPtr s, long t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_set_timestamptz(s, t));

        public static bool overafter_span_date(IntPtr s, int d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_span_date(s, d));

        public static bool overafter_span_timestamptz(IntPtr s, long t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_span_timestamptz(s, t));

        public static bool overafter_spanset_date(IntPtr ss, int d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_spanset_date(ss, d));

        public static bool overafter_spanset_timestamptz(IntPtr ss, long t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_spanset_timestamptz(ss, t));

        public static bool overafter_timestamptz_set(long t, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_timestamptz_set(t, s));

        public static bool overafter_timestamptz_span(long t, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_timestamptz_span(t, s));

        public static bool overafter_timestamptz_spanset(long t, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_timestamptz_spanset(t, ss));

        public static bool overbefore_date_set(int d, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_date_set(d, s));

        public static bool overbefore_date_span(int d, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_date_span(d, s));

        public static bool overbefore_date_spanset(int d, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_date_spanset(d, ss));

        public static bool overbefore_set_date(IntPtr s, int d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_set_date(s, d));

        public static bool overbefore_set_timestamptz(IntPtr s, long t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_set_timestamptz(s, t));

        public static bool overbefore_span_date(IntPtr s, int d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_span_date(s, d));

        public static bool overbefore_span_timestamptz(IntPtr s, long t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_span_timestamptz(s, t));

        public static bool overbefore_spanset_date(IntPtr ss, int d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_spanset_date(ss, d));

        public static bool overbefore_spanset_timestamptz(IntPtr ss, long t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_spanset_timestamptz(ss, t));

        public static bool overbefore_timestamptz_set(long t, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_timestamptz_set(t, s));

        public static bool overbefore_timestamptz_span(long t, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_timestamptz_span(t, s));

        public static bool overbefore_timestamptz_spanset(long t, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_timestamptz_spanset(t, ss));

        public static bool overleft_bigint_set(long i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_bigint_set(i, s));

        public static bool overleft_bigint_span(long i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_bigint_span(i, s));

        public static bool overleft_bigint_spanset(long i, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_bigint_spanset(i, ss));

        public static bool overleft_float_set(double d, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_float_set(d, s));

        public static bool overleft_float_span(double d, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_float_span(d, s));

        public static bool overleft_float_spanset(double d, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_float_spanset(d, ss));

        public static bool overleft_int_set(int i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_int_set(i, s));

        public static bool overleft_int_span(int i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_int_span(i, s));

        public static bool overleft_int_spanset(int i, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_int_spanset(i, ss));

        public static bool overleft_set_bigint(IntPtr s, long i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_set_bigint(s, i));

        public static bool overleft_set_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_set_float(s, d));

        public static bool overleft_set_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_set_int(s, i));

        public static bool overleft_set_set(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_set_set(s1, s2));

        public static bool overleft_set_text(IntPtr s, IntPtr txt)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_set_text(s, txt));

        public static bool overleft_span_bigint(IntPtr s, long i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_span_bigint(s, i));

        public static bool overleft_span_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_span_float(s, d));

        public static bool overleft_span_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_span_int(s, i));

        public static bool overleft_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_span_span(s1, s2));

        public static bool overleft_span_spanset(IntPtr s, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_span_spanset(s, ss));

        public static bool overleft_spanset_bigint(IntPtr ss, long i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_spanset_bigint(ss, i));

        public static bool overleft_spanset_float(IntPtr ss, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_spanset_float(ss, d));

        public static bool overleft_spanset_int(IntPtr ss, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_spanset_int(ss, i));

        public static bool overleft_spanset_span(IntPtr ss, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_spanset_span(ss, s));

        public static bool overleft_spanset_spanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_spanset_spanset(ss1, ss2));

        public static bool overleft_text_set(IntPtr txt, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_text_set(txt, s));

        public static bool overright_bigint_set(long i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_bigint_set(i, s));

        public static bool overright_bigint_span(long i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_bigint_span(i, s));

        public static bool overright_bigint_spanset(long i, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_bigint_spanset(i, ss));

        public static bool overright_float_set(double d, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_float_set(d, s));

        public static bool overright_float_span(double d, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_float_span(d, s));

        public static bool overright_float_spanset(double d, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_float_spanset(d, ss));

        public static bool overright_int_set(int i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_int_set(i, s));

        public static bool overright_int_span(int i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_int_span(i, s));

        public static bool overright_int_spanset(int i, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_int_spanset(i, ss));

        public static bool overright_set_bigint(IntPtr s, long i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_set_bigint(s, i));

        public static bool overright_set_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_set_float(s, d));

        public static bool overright_set_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_set_int(s, i));

        public static bool overright_set_set(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_set_set(s1, s2));

        public static bool overright_set_text(IntPtr s, IntPtr txt)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_set_text(s, txt));

        public static bool overright_span_bigint(IntPtr s, long i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_span_bigint(s, i));

        public static bool overright_span_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_span_float(s, d));

        public static bool overright_span_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_span_int(s, i));

        public static bool overright_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_span_span(s1, s2));

        public static bool overright_span_spanset(IntPtr s, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_span_spanset(s, ss));

        public static bool overright_spanset_bigint(IntPtr ss, long i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_spanset_bigint(ss, i));

        public static bool overright_spanset_float(IntPtr ss, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_spanset_float(ss, d));

        public static bool overright_spanset_int(IntPtr ss, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_spanset_int(ss, i));

        public static bool overright_spanset_span(IntPtr ss, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_spanset_span(ss, s));

        public static bool overright_spanset_spanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_spanset_spanset(ss1, ss2));

        public static bool overright_text_set(IntPtr txt, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_text_set(txt, s));

        public static bool right_bigint_set(long i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_bigint_set(i, s));

        public static bool right_bigint_span(long i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_bigint_span(i, s));

        public static bool right_bigint_spanset(long i, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_bigint_spanset(i, ss));

        public static bool right_float_set(double d, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_float_set(d, s));

        public static bool right_float_span(double d, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_float_span(d, s));

        public static bool right_float_spanset(double d, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_float_spanset(d, ss));

        public static bool right_int_set(int i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_int_set(i, s));

        public static bool right_int_span(int i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_int_span(i, s));

        public static bool right_int_spanset(int i, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_int_spanset(i, ss));

        public static bool right_set_bigint(IntPtr s, long i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_set_bigint(s, i));

        public static bool right_set_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_set_float(s, d));

        public static bool right_set_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_set_int(s, i));

        public static bool right_set_set(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_set_set(s1, s2));

        public static bool right_set_text(IntPtr s, IntPtr txt)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_set_text(s, txt));

        public static bool right_span_bigint(IntPtr s, long i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_span_bigint(s, i));

        public static bool right_span_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_span_float(s, d));

        public static bool right_span_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_span_int(s, i));

        public static bool right_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_span_span(s1, s2));

        public static bool right_span_spanset(IntPtr s, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_span_spanset(s, ss));

        public static bool right_spanset_bigint(IntPtr ss, long i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_spanset_bigint(ss, i));

        public static bool right_spanset_float(IntPtr ss, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_spanset_float(ss, d));

        public static bool right_spanset_int(IntPtr ss, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_spanset_int(ss, i));

        public static bool right_spanset_span(IntPtr ss, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_spanset_span(ss, s));

        public static bool right_spanset_spanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_spanset_spanset(ss1, ss2));

        public static bool right_text_set(IntPtr txt, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_text_set(txt, s));

        public static IntPtr intersection_bigint_set(long i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_bigint_set(i, s));

        public static IntPtr intersection_date_set(int d, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_date_set(d, s));

        public static IntPtr intersection_float_set(double d, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_float_set(d, s));

        public static IntPtr intersection_int_set(int i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_int_set(i, s));

        public static IntPtr intersection_set_bigint(IntPtr s, long i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_set_bigint(s, i));

        public static IntPtr intersection_set_date(IntPtr s, int d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_set_date(s, d));

        public static IntPtr intersection_set_float(IntPtr s, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_set_float(s, d));

        public static IntPtr intersection_set_int(IntPtr s, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_set_int(s, i));

        public static IntPtr intersection_set_set(IntPtr s1, IntPtr s2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_set_set(s1, s2));

        public static IntPtr intersection_set_text(IntPtr s, IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_set_text(s, txt));

        public static IntPtr intersection_set_timestamptz(IntPtr s, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_set_timestamptz(s, t));

        public static IntPtr intersection_span_bigint(IntPtr s, long i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_span_bigint(s, i));

        public static IntPtr intersection_span_date(IntPtr s, int d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_span_date(s, d));

        public static IntPtr intersection_span_float(IntPtr s, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_span_float(s, d));

        public static IntPtr intersection_span_int(IntPtr s, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_span_int(s, i));

        public static IntPtr intersection_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_span_span(s1, s2));

        public static IntPtr intersection_span_spanset(IntPtr s, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_span_spanset(s, ss));

        public static IntPtr intersection_span_timestamptz(IntPtr s, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_span_timestamptz(s, t));

        public static IntPtr intersection_spanset_bigint(IntPtr ss, long i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_spanset_bigint(ss, i));

        public static IntPtr intersection_spanset_date(IntPtr ss, int d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_spanset_date(ss, d));

        public static IntPtr intersection_spanset_float(IntPtr ss, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_spanset_float(ss, d));

        public static IntPtr intersection_spanset_int(IntPtr ss, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_spanset_int(ss, i));

        public static IntPtr intersection_spanset_span(IntPtr ss, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_spanset_span(ss, s));

        public static IntPtr intersection_spanset_spanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_spanset_spanset(ss1, ss2));

        public static IntPtr intersection_spanset_timestamptz(IntPtr ss, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_spanset_timestamptz(ss, t));

        public static IntPtr intersection_text_set(IntPtr txt, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_text_set(txt, s));

        public static IntPtr intersection_timestamptz_set(long t, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_timestamptz_set(t, s));

        public static IntPtr minus_bigint_set(long i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_bigint_set(i, s));

        public static IntPtr minus_bigint_span(long i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_bigint_span(i, s));

        public static IntPtr minus_bigint_spanset(long i, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_bigint_spanset(i, ss));

        public static IntPtr minus_date_set(int d, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_date_set(d, s));

        public static IntPtr minus_date_span(int d, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_date_span(d, s));

        public static IntPtr minus_date_spanset(int d, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_date_spanset(d, ss));

        public static IntPtr minus_float_set(double d, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_float_set(d, s));

        public static IntPtr minus_float_span(double d, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_float_span(d, s));

        public static IntPtr minus_float_spanset(double d, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_float_spanset(d, ss));

        public static IntPtr minus_int_set(int i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_int_set(i, s));

        public static IntPtr minus_int_span(int i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_int_span(i, s));

        public static IntPtr minus_int_spanset(int i, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_int_spanset(i, ss));

        public static IntPtr minus_set_bigint(IntPtr s, long i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_set_bigint(s, i));

        public static IntPtr minus_set_date(IntPtr s, int d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_set_date(s, d));

        public static IntPtr minus_set_float(IntPtr s, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_set_float(s, d));

        public static IntPtr minus_set_int(IntPtr s, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_set_int(s, i));

        public static IntPtr minus_set_set(IntPtr s1, IntPtr s2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_set_set(s1, s2));

        public static IntPtr minus_set_text(IntPtr s, IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_set_text(s, txt));

        public static IntPtr minus_set_timestamptz(IntPtr s, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_set_timestamptz(s, t));

        public static IntPtr minus_span_bigint(IntPtr s, long i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_span_bigint(s, i));

        public static IntPtr minus_span_date(IntPtr s, int d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_span_date(s, d));

        public static IntPtr minus_span_float(IntPtr s, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_span_float(s, d));

        public static IntPtr minus_span_int(IntPtr s, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_span_int(s, i));

        public static IntPtr minus_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_span_span(s1, s2));

        public static IntPtr minus_span_spanset(IntPtr s, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_span_spanset(s, ss));

        public static IntPtr minus_span_timestamptz(IntPtr s, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_span_timestamptz(s, t));

        public static IntPtr minus_spanset_bigint(IntPtr ss, long i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_spanset_bigint(ss, i));

        public static IntPtr minus_spanset_date(IntPtr ss, int d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_spanset_date(ss, d));

        public static IntPtr minus_spanset_float(IntPtr ss, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_spanset_float(ss, d));

        public static IntPtr minus_spanset_int(IntPtr ss, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_spanset_int(ss, i));

        public static IntPtr minus_spanset_span(IntPtr ss, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_spanset_span(ss, s));

        public static IntPtr minus_spanset_spanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_spanset_spanset(ss1, ss2));

        public static IntPtr minus_spanset_timestamptz(IntPtr ss, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_spanset_timestamptz(ss, t));

        public static IntPtr minus_text_set(IntPtr txt, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_text_set(txt, s));

        public static IntPtr minus_timestamptz_set(long t, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_timestamptz_set(t, s));

        public static IntPtr minus_timestamptz_span(long t, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_timestamptz_span(t, s));

        public static IntPtr minus_timestamptz_spanset(long t, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_timestamptz_spanset(t, ss));

        public static IntPtr union_bigint_set(long i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_bigint_set(i, s));

        public static IntPtr union_bigint_span(IntPtr s, long i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_bigint_span(s, i));

        public static IntPtr union_bigint_spanset(long i, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_bigint_spanset(i, ss));

        public static IntPtr union_date_set(int d, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_date_set(d, s));

        public static IntPtr union_date_span(IntPtr s, int d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_date_span(s, d));

        public static IntPtr union_date_spanset(int d, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_date_spanset(d, ss));

        public static IntPtr union_float_set(double d, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_float_set(d, s));

        public static IntPtr union_float_span(IntPtr s, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_float_span(s, d));

        public static IntPtr union_float_spanset(double d, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_float_spanset(d, ss));

        public static IntPtr union_int_set(int i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_int_set(i, s));

        public static IntPtr union_int_span(int i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_int_span(i, s));

        public static IntPtr union_int_spanset(int i, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_int_spanset(i, ss));

        public static IntPtr union_set_bigint(IntPtr s, long i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_set_bigint(s, i));

        public static IntPtr union_set_date(IntPtr s, int d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_set_date(s, d));

        public static IntPtr union_set_float(IntPtr s, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_set_float(s, d));

        public static IntPtr union_set_int(IntPtr s, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_set_int(s, i));

        public static IntPtr union_set_set(IntPtr s1, IntPtr s2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_set_set(s1, s2));

        public static IntPtr union_set_text(IntPtr s, IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_set_text(s, txt));

        public static IntPtr union_set_timestamptz(IntPtr s, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_set_timestamptz(s, t));

        public static IntPtr union_span_bigint(IntPtr s, long i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_span_bigint(s, i));

        public static IntPtr union_span_date(IntPtr s, int d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_span_date(s, d));

        public static IntPtr union_span_float(IntPtr s, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_span_float(s, d));

        public static IntPtr union_span_int(IntPtr s, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_span_int(s, i));

        public static IntPtr union_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_span_span(s1, s2));

        public static IntPtr union_span_spanset(IntPtr s, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_span_spanset(s, ss));

        public static IntPtr union_span_timestamptz(IntPtr s, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_span_timestamptz(s, t));

        public static IntPtr union_spanset_bigint(IntPtr ss, long i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_spanset_bigint(ss, i));

        public static IntPtr union_spanset_date(IntPtr ss, int d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_spanset_date(ss, d));

        public static IntPtr union_spanset_float(IntPtr ss, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_spanset_float(ss, d));

        public static IntPtr union_spanset_int(IntPtr ss, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_spanset_int(ss, i));

        public static IntPtr union_spanset_span(IntPtr ss, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_spanset_span(ss, s));

        public static IntPtr union_spanset_spanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_spanset_spanset(ss1, ss2));

        public static IntPtr union_spanset_timestamptz(IntPtr ss, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_spanset_timestamptz(ss, t));

        public static IntPtr union_text_set(IntPtr txt, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_text_set(txt, s));

        public static IntPtr union_timestamptz_set(long t, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_timestamptz_set(t, s));

        public static IntPtr union_timestamptz_span(long t, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_timestamptz_span(t, s));

        public static IntPtr union_timestamptz_spanset(long t, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_timestamptz_spanset(t, ss));

        public static long distance_bigintset_bigintset(IntPtr s1, IntPtr s2)
            => SafeExecution<long>(() => MEOSExternalFunctions.distance_bigintset_bigintset(s1, s2));

        public static long distance_bigintspan_bigintspan(IntPtr s1, IntPtr s2)
            => SafeExecution<long>(() => MEOSExternalFunctions.distance_bigintspan_bigintspan(s1, s2));

        public static long distance_bigintspanset_bigintspan(IntPtr ss, IntPtr s)
            => SafeExecution<long>(() => MEOSExternalFunctions.distance_bigintspanset_bigintspan(ss, s));

        public static long distance_bigintspanset_bigintspanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<long>(() => MEOSExternalFunctions.distance_bigintspanset_bigintspanset(ss1, ss2));

        public static int distance_dateset_dateset(IntPtr s1, IntPtr s2)
            => SafeExecution<int>(() => MEOSExternalFunctions.distance_dateset_dateset(s1, s2));

        public static int distance_datespan_datespan(IntPtr s1, IntPtr s2)
            => SafeExecution<int>(() => MEOSExternalFunctions.distance_datespan_datespan(s1, s2));

        public static int distance_datespanset_datespan(IntPtr ss, IntPtr s)
            => SafeExecution<int>(() => MEOSExternalFunctions.distance_datespanset_datespan(ss, s));

        public static int distance_datespanset_datespanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<int>(() => MEOSExternalFunctions.distance_datespanset_datespanset(ss1, ss2));

        public static double distance_floatset_floatset(IntPtr s1, IntPtr s2)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_floatset_floatset(s1, s2));

        public static double distance_floatspan_floatspan(IntPtr s1, IntPtr s2)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_floatspan_floatspan(s1, s2));

        public static double distance_floatspanset_floatspan(IntPtr ss, IntPtr s)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_floatspanset_floatspan(ss, s));

        public static double distance_floatspanset_floatspanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_floatspanset_floatspanset(ss1, ss2));

        public static int distance_intset_intset(IntPtr s1, IntPtr s2)
            => SafeExecution<int>(() => MEOSExternalFunctions.distance_intset_intset(s1, s2));

        public static int distance_intspan_intspan(IntPtr s1, IntPtr s2)
            => SafeExecution<int>(() => MEOSExternalFunctions.distance_intspan_intspan(s1, s2));

        public static int distance_intspanset_intspan(IntPtr ss, IntPtr s)
            => SafeExecution<int>(() => MEOSExternalFunctions.distance_intspanset_intspan(ss, s));

        public static int distance_intspanset_intspanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<int>(() => MEOSExternalFunctions.distance_intspanset_intspanset(ss1, ss2));

        public static long distance_set_bigint(IntPtr s, long i)
            => SafeExecution<long>(() => MEOSExternalFunctions.distance_set_bigint(s, i));

        public static int distance_set_date(IntPtr s, int d)
            => SafeExecution<int>(() => MEOSExternalFunctions.distance_set_date(s, d));

        public static double distance_set_float(IntPtr s, double d)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_set_float(s, d));

        public static int distance_set_int(IntPtr s, int i)
            => SafeExecution<int>(() => MEOSExternalFunctions.distance_set_int(s, i));

        public static double distance_set_timestamptz(IntPtr s, long t)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_set_timestamptz(s, t));

        public static long distance_span_bigint(IntPtr s, long i)
            => SafeExecution<long>(() => MEOSExternalFunctions.distance_span_bigint(s, i));

        public static int distance_span_date(IntPtr s, int d)
            => SafeExecution<int>(() => MEOSExternalFunctions.distance_span_date(s, d));

        public static double distance_span_float(IntPtr s, double d)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_span_float(s, d));

        public static int distance_span_int(IntPtr s, int i)
            => SafeExecution<int>(() => MEOSExternalFunctions.distance_span_int(s, i));

        public static double distance_span_timestamptz(IntPtr s, long t)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_span_timestamptz(s, t));

        public static long distance_spanset_bigint(IntPtr ss, long i)
            => SafeExecution<long>(() => MEOSExternalFunctions.distance_spanset_bigint(ss, i));

        public static int distance_spanset_date(IntPtr ss, int d)
            => SafeExecution<int>(() => MEOSExternalFunctions.distance_spanset_date(ss, d));

        public static double distance_spanset_float(IntPtr ss, double d)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_spanset_float(ss, d));

        public static int distance_spanset_int(IntPtr ss, int i)
            => SafeExecution<int>(() => MEOSExternalFunctions.distance_spanset_int(ss, i));

        public static double distance_spanset_timestamptz(IntPtr ss, long t)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_spanset_timestamptz(ss, t));

        public static double distance_tstzset_tstzset(IntPtr s1, IntPtr s2)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_tstzset_tstzset(s1, s2));

        public static double distance_tstzspan_tstzspan(IntPtr s1, IntPtr s2)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_tstzspan_tstzspan(s1, s2));

        public static double distance_tstzspanset_tstzspan(IntPtr ss, IntPtr s)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_tstzspanset_tstzspan(ss, s));

        public static double distance_tstzspanset_tstzspanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_tstzspanset_tstzspanset(ss1, ss2));

        public static IntPtr bigint_extent_transfn(IntPtr state, long i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigint_extent_transfn(state, i));

        public static IntPtr bigint_union_transfn(IntPtr state, long i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigint_union_transfn(state, i));

        public static IntPtr date_extent_transfn(IntPtr state, int d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.date_extent_transfn(state, d));

        public static IntPtr date_union_transfn(IntPtr state, int d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.date_union_transfn(state, d));

        public static IntPtr float_extent_transfn(IntPtr state, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.float_extent_transfn(state, d));

        public static IntPtr float_union_transfn(IntPtr state, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.float_union_transfn(state, d));

        public static IntPtr int_extent_transfn(IntPtr state, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.int_extent_transfn(state, i));

        public static IntPtr int_union_transfn(IntPtr state, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.int_union_transfn(state, i));

        public static IntPtr set_extent_transfn(IntPtr state, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_extent_transfn(state, s));

        public static IntPtr set_union_finalfn(IntPtr state)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_union_finalfn(state));

        public static IntPtr set_union_transfn(IntPtr state, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_union_transfn(state, s));

        public static IntPtr span_extent_transfn(IntPtr state, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.span_extent_transfn(state, s));

        public static IntPtr span_union_transfn(IntPtr state, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.span_union_transfn(state, s));

        public static IntPtr spanset_extent_transfn(IntPtr state, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_extent_transfn(state, ss));

        public static IntPtr spanset_union_finalfn(IntPtr state)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_union_finalfn(state));

        public static IntPtr spanset_union_transfn(IntPtr state, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_union_transfn(state, ss));

        public static IntPtr text_union_transfn(IntPtr state, IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.text_union_transfn(state, txt));

        public static IntPtr timestamptz_extent_transfn(IntPtr state, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.timestamptz_extent_transfn(state, t));

        public static IntPtr timestamptz_union_transfn(IntPtr state, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.timestamptz_union_transfn(state, t));

        public static long bigint_get_bin(long value, long vsize, long vorigin)
            => SafeExecution<long>(() => MEOSExternalFunctions.bigint_get_bin(value, vsize, vorigin));

        public static IntPtr bigintspan_bins(IntPtr s, long vsize, long vorigin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintspan_bins(s, vsize, vorigin, count));

        public static IntPtr bigintspanset_bins(IntPtr ss, long vsize, long vorigin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintspanset_bins(ss, vsize, vorigin, count));

        public static int date_get_bin(int d, IntPtr duration, int torigin)
            => SafeExecution<int>(() => MEOSExternalFunctions.date_get_bin(d, duration, torigin));

        public static IntPtr datespan_bins(IntPtr s, IntPtr duration, int torigin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.datespan_bins(s, duration, torigin, count));

        public static IntPtr datespanset_bins(IntPtr ss, IntPtr duration, int torigin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.datespanset_bins(ss, duration, torigin, count));

        public static double float_get_bin(double value, double vsize, double vorigin)
            => SafeExecution<double>(() => MEOSExternalFunctions.float_get_bin(value, vsize, vorigin));

        public static IntPtr floatspan_bins(IntPtr s, double vsize, double vorigin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspan_bins(s, vsize, vorigin, count));

        public static IntPtr floatspanset_bins(IntPtr ss, double vsize, double vorigin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspanset_bins(ss, vsize, vorigin, count));

        public static int int_get_bin(int value, int vsize, int vorigin)
            => SafeExecution<int>(() => MEOSExternalFunctions.int_get_bin(value, vsize, vorigin));

        public static IntPtr intspan_bins(IntPtr s, int vsize, int vorigin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intspan_bins(s, vsize, vorigin, count));

        public static IntPtr intspanset_bins(IntPtr ss, int vsize, int vorigin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intspanset_bins(ss, vsize, vorigin, count));

        public static long timestamptz_get_bin(long t, IntPtr duration, long torigin)
            => SafeExecution<long>(() => MEOSExternalFunctions.timestamptz_get_bin(t, duration, torigin));

        public static IntPtr tstzspan_bins(IntPtr s, IntPtr duration, long origin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspan_bins(s, duration, origin, count));

        public static IntPtr tstzspanset_bins(IntPtr ss, IntPtr duration, long torigin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspanset_bins(ss, duration, torigin, count));

        public static string tbox_as_hexwkb(IntPtr box, IntPtr variant, IntPtr size)
            => SafeExecution<string>(() => MEOSExternalFunctions.tbox_as_hexwkb(box, variant, size));

        public static IntPtr tbox_as_wkb(IntPtr box, IntPtr variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_as_wkb(box, variant, size_out));

        public static IntPtr tbox_from_hexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_from_hexwkb(hexwkb));

        public static IntPtr tbox_from_wkb(IntPtr wkb, ulong size)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_from_wkb(wkb, size));

        public static IntPtr tbox_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_in(str));

        public static string tbox_out(IntPtr box, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.tbox_out(box, maxdd));

        public static IntPtr float_timestamptz_to_tbox(double d, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.float_timestamptz_to_tbox(d, t));

        public static IntPtr float_tstzspan_to_tbox(double d, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.float_tstzspan_to_tbox(d, s));

        public static IntPtr int_timestamptz_to_tbox(int i, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.int_timestamptz_to_tbox(i, t));

        public static IntPtr int_tstzspan_to_tbox(int i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.int_tstzspan_to_tbox(i, s));

        public static IntPtr numspan_tstzspan_to_tbox(IntPtr span, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.numspan_tstzspan_to_tbox(span, s));

        public static IntPtr numspan_timestamptz_to_tbox(IntPtr span, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.numspan_timestamptz_to_tbox(span, t));

        public static IntPtr tbox_copy(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_copy(box));

        public static IntPtr tbox_make(IntPtr s, IntPtr p)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_make(s, p));

        public static IntPtr float_to_tbox(double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.float_to_tbox(d));

        public static IntPtr int_to_tbox(int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.int_to_tbox(i));

        public static IntPtr set_to_tbox(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_to_tbox(s));

        public static IntPtr span_to_tbox(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.span_to_tbox(s));

        public static IntPtr spanset_to_tbox(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_to_tbox(ss));

        public static IntPtr tbox_to_intspan(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_to_intspan(box));

        public static IntPtr tbox_to_floatspan(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_to_floatspan(box));

        public static IntPtr tbox_to_tstzspan(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_to_tstzspan(box));

        public static IntPtr timestamptz_to_tbox(long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.timestamptz_to_tbox(t));

        public static uint tbox_hash(IntPtr box)
            => SafeExecution<uint>(() => MEOSExternalFunctions.tbox_hash(box));

        public static ulong tbox_hash_extended(IntPtr box, ulong seed)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.tbox_hash_extended(box, seed));

        public static bool tbox_hast(IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbox_hast(box));

        public static bool tbox_hasx(IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbox_hasx(box));

        public static bool tbox_tmax(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbox_tmax(box, result));

        public static bool tbox_tmax_inc(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbox_tmax_inc(box, result));

        public static bool tbox_tmin(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbox_tmin(box, result));

        public static bool tbox_tmin_inc(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbox_tmin_inc(box, result));

        public static bool tbox_xmax(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbox_xmax(box, result));

        public static bool tbox_xmax_inc(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbox_xmax_inc(box, result));

        public static bool tbox_xmin(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbox_xmin(box, result));

        public static bool tbox_xmin_inc(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbox_xmin_inc(box, result));

        public static bool tboxfloat_xmax(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tboxfloat_xmax(box, result));

        public static bool tboxfloat_xmin(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tboxfloat_xmin(box, result));

        public static bool tboxint_xmax(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tboxint_xmax(box, result));

        public static bool tboxint_xmin(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tboxint_xmin(box, result));

        public static IntPtr tbox_expand_time(IntPtr box, IntPtr interv)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_expand_time(box, interv));

        public static IntPtr tbox_round(IntPtr box, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_round(box, maxdd));

        public static IntPtr tbox_shift_scale_time(IntPtr box, IntPtr shift, IntPtr duration)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_shift_scale_time(box, shift, duration));

        public static IntPtr tfloatbox_expand(IntPtr box, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloatbox_expand(box, d));

        public static IntPtr tfloatbox_shift_scale(IntPtr box, double shift, double width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloatbox_shift_scale(box, shift, width, hasshift, haswidth));

        public static IntPtr tintbox_expand(IntPtr box, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintbox_expand(box, i));

        public static IntPtr tintbox_shift_scale(IntPtr box, int shift, int width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintbox_shift_scale(box, shift, width, hasshift, haswidth));

        public static IntPtr union_tbox_tbox(IntPtr box1, IntPtr box2, bool strict)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_tbox_tbox(box1, box2, strict));

        public static IntPtr intersection_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_tbox_tbox(box1, box2));

        public static bool adjacent_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_tbox_tbox(box1, box2));

        public static bool contained_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_tbox_tbox(box1, box2));

        public static bool contains_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_tbox_tbox(box1, box2));

        public static bool overlaps_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_tbox_tbox(box1, box2));

        public static bool same_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.same_tbox_tbox(box1, box2));

        public static bool after_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_tbox_tbox(box1, box2));

        public static bool before_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_tbox_tbox(box1, box2));

        public static bool left_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_tbox_tbox(box1, box2));

        public static bool overafter_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_tbox_tbox(box1, box2));

        public static bool overbefore_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_tbox_tbox(box1, box2));

        public static bool overleft_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_tbox_tbox(box1, box2));

        public static bool overright_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_tbox_tbox(box1, box2));

        public static bool right_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_tbox_tbox(box1, box2));

        public static int tbox_cmp(IntPtr box1, IntPtr box2)
            => SafeExecution<int>(() => MEOSExternalFunctions.tbox_cmp(box1, box2));

        public static bool tbox_eq(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbox_eq(box1, box2));

        public static bool tbox_ge(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbox_ge(box1, box2));

        public static bool tbox_gt(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbox_gt(box1, box2));

        public static bool tbox_le(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbox_le(box1, box2));

        public static bool tbox_lt(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbox_lt(box1, box2));

        public static bool tbox_ne(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbox_ne(box1, box2));

        public static IntPtr tbool_from_mfjson(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbool_from_mfjson(str));

        public static IntPtr tbool_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbool_in(str));

        public static string tbool_out(IntPtr temp)
            => SafeExecution<string>(() => MEOSExternalFunctions.tbool_out(temp));

        public static string temporal_as_hexwkb(IntPtr temp, IntPtr variant, IntPtr size_out)
            => SafeExecution<string>(() => MEOSExternalFunctions.temporal_as_hexwkb(temp, variant, size_out));

        public static string temporal_as_mfjson(IntPtr temp, bool with_bbox, int flags, int precision, string srs)
            => SafeExecution<string>(() => MEOSExternalFunctions.temporal_as_mfjson(temp, with_bbox, flags, precision, srs));

        public static IntPtr temporal_as_wkb(IntPtr temp, IntPtr variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_as_wkb(temp, variant, size_out));

        public static IntPtr temporal_from_hexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_from_hexwkb(hexwkb));

        public static IntPtr temporal_from_wkb(IntPtr wkb, ulong size)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_from_wkb(wkb, size));

        public static IntPtr tfloat_from_mfjson(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_from_mfjson(str));

        public static IntPtr tfloat_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_in(str));

        public static string tfloat_out(IntPtr temp, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.tfloat_out(temp, maxdd));

        public static IntPtr tint_from_mfjson(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_from_mfjson(str));

        public static IntPtr tint_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_in(str));

        public static string tint_out(IntPtr temp)
            => SafeExecution<string>(() => MEOSExternalFunctions.tint_out(temp));

        public static IntPtr ttext_from_mfjson(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_from_mfjson(str));

        public static IntPtr ttext_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_in(str));

        public static string ttext_out(IntPtr temp)
            => SafeExecution<string>(() => MEOSExternalFunctions.ttext_out(temp));

        public static IntPtr tbool_from_base_temp(bool b, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbool_from_base_temp(b, temp));

        public static IntPtr tboolinst_make(bool b, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tboolinst_make(b, t));

        public static IntPtr tboolseq_from_base_tstzset(bool b, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tboolseq_from_base_tstzset(b, s));

        public static IntPtr tboolseq_from_base_tstzspan(bool b, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tboolseq_from_base_tstzspan(b, s));

        public static IntPtr tboolseqset_from_base_tstzspanset(bool b, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tboolseqset_from_base_tstzspanset(b, ss));

        public static IntPtr temporal_copy(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_copy(temp));

        public static IntPtr tfloat_from_base_temp(double d, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_from_base_temp(d, temp));

        public static IntPtr tfloatinst_make(double d, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloatinst_make(d, t));

        public static IntPtr tfloatseq_from_base_tstzset(double d, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloatseq_from_base_tstzset(d, s));

        public static IntPtr tfloatseq_from_base_tstzspan(double d, IntPtr s, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloatseq_from_base_tstzspan(d, s, interp));

        public static IntPtr tfloatseqset_from_base_tstzspanset(double d, IntPtr ss, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloatseqset_from_base_tstzspanset(d, ss, interp));

        public static IntPtr tint_from_base_temp(int i, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_from_base_temp(i, temp));

        public static IntPtr tintinst_make(int i, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintinst_make(i, t));

        public static IntPtr tintseq_from_base_tstzset(int i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintseq_from_base_tstzset(i, s));

        public static IntPtr tintseq_from_base_tstzspan(int i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintseq_from_base_tstzspan(i, s));

        public static IntPtr tintseqset_from_base_tstzspanset(int i, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintseqset_from_base_tstzspanset(i, ss));

        public static IntPtr tsequence_make(IntPtr instants, int count, bool lower_inc, bool upper_inc, int interp, bool normalize)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_make(instants, count, lower_inc, upper_inc, interp, normalize));

        public static IntPtr tsequenceset_make(IntPtr sequences, int count, bool normalize)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_make(sequences, count, normalize));

        public static IntPtr tsequenceset_make_gaps(IntPtr instants, int count, int interp, IntPtr maxt, double maxdist)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_make_gaps(instants, count, interp, maxt, maxdist));

        public static IntPtr ttext_from_base_temp(IntPtr txt, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_from_base_temp(txt, temp));

        public static IntPtr ttextinst_make(IntPtr txt, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttextinst_make(txt, t));

        public static IntPtr ttextseq_from_base_tstzset(IntPtr txt, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttextseq_from_base_tstzset(txt, s));

        public static IntPtr ttextseq_from_base_tstzspan(IntPtr txt, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttextseq_from_base_tstzspan(txt, s));

        public static IntPtr ttextseqset_from_base_tstzspanset(IntPtr txt, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttextseqset_from_base_tstzspanset(txt, ss));

        public static IntPtr tbool_to_tint(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbool_to_tint(temp));

        public static IntPtr temporal_to_tstzspan(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_to_tstzspan(temp));

        public static IntPtr tfloat_to_tint(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_to_tint(temp));

        public static IntPtr tint_to_tfloat(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_to_tfloat(temp));

        public static IntPtr tnumber_to_span(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_to_span(temp));

        public static IntPtr tnumber_to_tbox(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_to_tbox(temp));

        public static bool tbool_end_value(IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbool_end_value(temp));

        public static bool tbool_start_value(IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbool_start_value(temp));

        public static bool tbool_value_at_timestamptz(IntPtr temp, long t, bool strict, IntPtr value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbool_value_at_timestamptz(temp, t, strict, value));

        public static bool tbool_value_n(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbool_value_n(temp, n, result));

        public static IntPtr tbool_values(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbool_values(temp, count));

        public static IntPtr temporal_duration(IntPtr temp, bool boundspan)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_duration(temp, boundspan));

        public static IntPtr temporal_end_instant(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_end_instant(temp));

        public static IntPtr temporal_end_sequence(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_end_sequence(temp));

        public static long temporal_end_timestamptz(IntPtr temp)
            => SafeExecution<long>(() => MEOSExternalFunctions.temporal_end_timestamptz(temp));

        public static uint temporal_hash(IntPtr temp)
            => SafeExecution<uint>(() => MEOSExternalFunctions.temporal_hash(temp));

        public static IntPtr temporal_instant_n(IntPtr temp, int n)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_instant_n(temp, n));

        public static IntPtr temporal_instants(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_instants(temp, count));

        public static string temporal_interp(IntPtr temp)
            => SafeExecution<string>(() => MEOSExternalFunctions.temporal_interp(temp));

        public static bool temporal_lower_inc(IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.temporal_lower_inc(temp));

        public static IntPtr temporal_max_instant(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_max_instant(temp));

        public static IntPtr temporal_min_instant(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_min_instant(temp));

        public static int temporal_num_instants(IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.temporal_num_instants(temp));

        public static int temporal_num_sequences(IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.temporal_num_sequences(temp));

        public static int temporal_num_timestamps(IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.temporal_num_timestamps(temp));

        public static IntPtr temporal_segm_duration(IntPtr temp, IntPtr duration, bool atleast, bool strict)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_segm_duration(temp, duration, atleast, strict));

        public static IntPtr temporal_segments(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_segments(temp, count));

        public static IntPtr temporal_sequence_n(IntPtr temp, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_sequence_n(temp, i));

        public static IntPtr temporal_sequences(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_sequences(temp, count));

        public static IntPtr temporal_start_instant(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_start_instant(temp));

        public static IntPtr temporal_start_sequence(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_start_sequence(temp));

        public static long temporal_start_timestamptz(IntPtr temp)
            => SafeExecution<long>(() => MEOSExternalFunctions.temporal_start_timestamptz(temp));

        public static IntPtr temporal_stops(IntPtr temp, double maxdist, IntPtr minduration)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_stops(temp, maxdist, minduration));

        public static string temporal_subtype(IntPtr temp)
            => SafeExecution<string>(() => MEOSExternalFunctions.temporal_subtype(temp));

        public static IntPtr temporal_time(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_time(temp));

        public static IntPtr temporal_timestamps(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_timestamps(temp, count));

        public static bool temporal_timestamptz_n(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.temporal_timestamptz_n(temp, n, result));

        public static bool temporal_upper_inc(IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.temporal_upper_inc(temp));

        public static double tfloat_avg_value(IntPtr temp)
            => SafeExecution<double>(() => MEOSExternalFunctions.tfloat_avg_value(temp));

        public static double tfloat_end_value(IntPtr temp)
            => SafeExecution<double>(() => MEOSExternalFunctions.tfloat_end_value(temp));

        public static double tfloat_min_value(IntPtr temp)
            => SafeExecution<double>(() => MEOSExternalFunctions.tfloat_min_value(temp));

        public static double tfloat_max_value(IntPtr temp)
            => SafeExecution<double>(() => MEOSExternalFunctions.tfloat_max_value(temp));

        public static double tfloat_start_value(IntPtr temp)
            => SafeExecution<double>(() => MEOSExternalFunctions.tfloat_start_value(temp));

        public static bool tfloat_value_at_timestamptz(IntPtr temp, long t, bool strict, IntPtr value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tfloat_value_at_timestamptz(temp, t, strict, value));

        public static bool tfloat_value_n(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tfloat_value_n(temp, n, result));

        public static IntPtr tfloat_values(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_values(temp, count));

        public static int tint_end_value(IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.tint_end_value(temp));

        public static int tint_max_value(IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.tint_max_value(temp));

        public static int tint_min_value(IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.tint_min_value(temp));

        public static int tint_start_value(IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.tint_start_value(temp));

        public static bool tint_value_at_timestamptz(IntPtr temp, long t, bool strict, IntPtr value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tint_value_at_timestamptz(temp, t, strict, value));

        public static bool tint_value_n(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tint_value_n(temp, n, result));

        public static IntPtr tint_values(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_values(temp, count));

        public static double tnumber_avg_value(IntPtr temp)
            => SafeExecution<double>(() => MEOSExternalFunctions.tnumber_avg_value(temp));

        public static double tnumber_integral(IntPtr temp)
            => SafeExecution<double>(() => MEOSExternalFunctions.tnumber_integral(temp));

        public static double tnumber_twavg(IntPtr temp)
            => SafeExecution<double>(() => MEOSExternalFunctions.tnumber_twavg(temp));

        public static IntPtr tnumber_valuespans(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_valuespans(temp));

        public static IntPtr ttext_end_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_end_value(temp));

        public static IntPtr ttext_max_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_max_value(temp));

        public static IntPtr ttext_min_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_min_value(temp));

        public static IntPtr ttext_start_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_start_value(temp));

        public static bool ttext_value_at_timestamptz(IntPtr temp, long t, bool strict, IntPtr value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ttext_value_at_timestamptz(temp, t, strict, value));

        public static bool ttext_value_n(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ttext_value_n(temp, n, result));

        public static IntPtr ttext_values(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_values(temp, count));

        public static double float_degrees(double value, bool normalize)
            => SafeExecution<double>(() => MEOSExternalFunctions.float_degrees(value, normalize));

        public static IntPtr temparr_round(IntPtr temp, int count, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temparr_round(temp, count, maxdd));

        public static IntPtr temporal_round(IntPtr temp, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_round(temp, maxdd));

        public static IntPtr temporal_scale_time(IntPtr temp, IntPtr duration)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_scale_time(temp, duration));

        public static IntPtr temporal_set_interp(IntPtr temp, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_set_interp(temp, interp));

        public static IntPtr temporal_shift_scale_time(IntPtr temp, IntPtr shift, IntPtr duration)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_shift_scale_time(temp, shift, duration));

        public static IntPtr temporal_shift_time(IntPtr temp, IntPtr shift)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_shift_time(temp, shift));

        public static IntPtr temporal_to_tinstant(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_to_tinstant(temp));

        public static IntPtr temporal_to_tsequence(IntPtr temp, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_to_tsequence(temp, interp));

        public static IntPtr temporal_to_tsequenceset(IntPtr temp, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_to_tsequenceset(temp, interp));

        public static IntPtr tfloat_ceil(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_ceil(temp));

        public static IntPtr tfloat_degrees(IntPtr temp, bool normalize)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_degrees(temp, normalize));

        public static IntPtr tfloat_floor(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_floor(temp));

        public static IntPtr tfloat_radians(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_radians(temp));

        public static IntPtr tfloat_scale_value(IntPtr temp, double width)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_scale_value(temp, width));

        public static IntPtr tfloat_shift_scale_value(IntPtr temp, double shift, double width)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_shift_scale_value(temp, shift, width));

        public static IntPtr tfloat_shift_value(IntPtr temp, double shift)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_shift_value(temp, shift));

        public static IntPtr tint_scale_value(IntPtr temp, int width)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_scale_value(temp, width));

        public static IntPtr tint_shift_scale_value(IntPtr temp, int shift, int width)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_shift_scale_value(temp, shift, width));

        public static IntPtr tint_shift_value(IntPtr temp, int shift)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_shift_value(temp, shift));

        public static IntPtr temporal_append_tinstant(IntPtr temp, IntPtr inst, int interp, double maxdist, IntPtr maxt, bool expand)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_append_tinstant(temp, inst, interp, maxdist, maxt, expand));

        public static IntPtr temporal_append_tsequence(IntPtr temp, IntPtr seq, bool expand)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_append_tsequence(temp, seq, expand));

        public static IntPtr temporal_delete_timestamptz(IntPtr temp, long t, bool connect)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_delete_timestamptz(temp, t, connect));

        public static IntPtr temporal_delete_tstzset(IntPtr temp, IntPtr s, bool connect)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_delete_tstzset(temp, s, connect));

        public static IntPtr temporal_delete_tstzspan(IntPtr temp, IntPtr s, bool connect)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_delete_tstzspan(temp, s, connect));

        public static IntPtr temporal_delete_tstzspanset(IntPtr temp, IntPtr ss, bool connect)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_delete_tstzspanset(temp, ss, connect));

        public static IntPtr temporal_insert(IntPtr temp1, IntPtr temp2, bool connect)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_insert(temp1, temp2, connect));

        public static IntPtr temporal_merge(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_merge(temp1, temp2));

        public static IntPtr temporal_merge_array(IntPtr temparr, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_merge_array(temparr, count));

        public static IntPtr temporal_update(IntPtr temp1, IntPtr temp2, bool connect)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_update(temp1, temp2, connect));

        public static IntPtr tbool_at_value(IntPtr temp, bool b)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbool_at_value(temp, b));

        public static IntPtr tbool_minus_value(IntPtr temp, bool b)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbool_minus_value(temp, b));

        public static IntPtr temporal_after_timestamptz(IntPtr temp, long t, bool strict)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_after_timestamptz(temp, t, strict));

        public static IntPtr temporal_at_max(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_at_max(temp));

        public static IntPtr temporal_at_min(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_at_min(temp));

        public static IntPtr temporal_at_timestamptz(IntPtr temp, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_at_timestamptz(temp, t));

        public static IntPtr temporal_at_tstzset(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_at_tstzset(temp, s));

        public static IntPtr temporal_at_tstzspan(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_at_tstzspan(temp, s));

        public static IntPtr temporal_at_tstzspanset(IntPtr temp, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_at_tstzspanset(temp, ss));

        public static IntPtr temporal_at_values(IntPtr temp, IntPtr set)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_at_values(temp, set));

        public static IntPtr temporal_before_timestamptz(IntPtr temp, long t, bool strict)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_before_timestamptz(temp, t, strict));

        public static IntPtr temporal_minus_max(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_minus_max(temp));

        public static IntPtr temporal_minus_min(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_minus_min(temp));

        public static IntPtr temporal_minus_timestamptz(IntPtr temp, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_minus_timestamptz(temp, t));

        public static IntPtr temporal_minus_tstzset(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_minus_tstzset(temp, s));

        public static IntPtr temporal_minus_tstzspan(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_minus_tstzspan(temp, s));

        public static IntPtr temporal_minus_tstzspanset(IntPtr temp, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_minus_tstzspanset(temp, ss));

        public static IntPtr temporal_minus_values(IntPtr temp, IntPtr set)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_minus_values(temp, set));

        public static IntPtr tfloat_at_value(IntPtr temp, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_at_value(temp, d));

        public static IntPtr tfloat_minus_value(IntPtr temp, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_minus_value(temp, d));

        public static IntPtr tint_at_value(IntPtr temp, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_at_value(temp, i));

        public static IntPtr tint_minus_value(IntPtr temp, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_minus_value(temp, i));

        public static IntPtr tnumber_at_span(IntPtr temp, IntPtr span)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_at_span(temp, span));

        public static IntPtr tnumber_at_spanset(IntPtr temp, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_at_spanset(temp, ss));

        public static IntPtr tnumber_at_tbox(IntPtr temp, IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_at_tbox(temp, box));

        public static IntPtr tnumber_minus_span(IntPtr temp, IntPtr span)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_minus_span(temp, span));

        public static IntPtr tnumber_minus_spanset(IntPtr temp, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_minus_spanset(temp, ss));

        public static IntPtr tnumber_minus_tbox(IntPtr temp, IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_minus_tbox(temp, box));

        public static IntPtr ttext_at_value(IntPtr temp, IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_at_value(temp, txt));

        public static IntPtr ttext_minus_value(IntPtr temp, IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_minus_value(temp, txt));

        public static int temporal_cmp(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.temporal_cmp(temp1, temp2));

        public static bool temporal_eq(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.temporal_eq(temp1, temp2));

        public static bool temporal_ge(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.temporal_ge(temp1, temp2));

        public static bool temporal_gt(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.temporal_gt(temp1, temp2));

        public static bool temporal_le(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.temporal_le(temp1, temp2));

        public static bool temporal_lt(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.temporal_lt(temp1, temp2));

        public static bool temporal_ne(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.temporal_ne(temp1, temp2));

        public static int always_eq_bool_tbool(bool b, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_bool_tbool(b, temp));

        public static int always_eq_float_tfloat(double d, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_float_tfloat(d, temp));

        public static int always_eq_int_tint(int i, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_int_tint(i, temp));

        public static int always_eq_tbool_bool(IntPtr temp, bool b)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_tbool_bool(temp, b));

        public static int always_eq_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_temporal_temporal(temp1, temp2));

        public static int always_eq_text_ttext(IntPtr txt, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_text_ttext(txt, temp));

        public static int always_eq_tfloat_float(IntPtr temp, double d)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_tfloat_float(temp, d));

        public static int always_eq_tint_int(IntPtr temp, int i)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_tint_int(temp, i));

        public static int always_eq_ttext_text(IntPtr temp, IntPtr txt)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_ttext_text(temp, txt));

        public static int always_ge_float_tfloat(double d, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ge_float_tfloat(d, temp));

        public static int always_ge_int_tint(int i, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ge_int_tint(i, temp));

        public static int always_ge_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ge_temporal_temporal(temp1, temp2));

        public static int always_ge_text_ttext(IntPtr txt, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ge_text_ttext(txt, temp));

        public static int always_ge_tfloat_float(IntPtr temp, double d)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ge_tfloat_float(temp, d));

        public static int always_ge_tint_int(IntPtr temp, int i)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ge_tint_int(temp, i));

        public static int always_ge_ttext_text(IntPtr temp, IntPtr txt)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ge_ttext_text(temp, txt));

        public static int always_gt_float_tfloat(double d, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_gt_float_tfloat(d, temp));

        public static int always_gt_int_tint(int i, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_gt_int_tint(i, temp));

        public static int always_gt_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_gt_temporal_temporal(temp1, temp2));

        public static int always_gt_text_ttext(IntPtr txt, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_gt_text_ttext(txt, temp));

        public static int always_gt_tfloat_float(IntPtr temp, double d)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_gt_tfloat_float(temp, d));

        public static int always_gt_tint_int(IntPtr temp, int i)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_gt_tint_int(temp, i));

        public static int always_gt_ttext_text(IntPtr temp, IntPtr txt)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_gt_ttext_text(temp, txt));

        public static int always_le_float_tfloat(double d, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_le_float_tfloat(d, temp));

        public static int always_le_int_tint(int i, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_le_int_tint(i, temp));

        public static int always_le_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_le_temporal_temporal(temp1, temp2));

        public static int always_le_text_ttext(IntPtr txt, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_le_text_ttext(txt, temp));

        public static int always_le_tfloat_float(IntPtr temp, double d)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_le_tfloat_float(temp, d));

        public static int always_le_tint_int(IntPtr temp, int i)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_le_tint_int(temp, i));

        public static int always_le_ttext_text(IntPtr temp, IntPtr txt)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_le_ttext_text(temp, txt));

        public static int always_lt_float_tfloat(double d, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_lt_float_tfloat(d, temp));

        public static int always_lt_int_tint(int i, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_lt_int_tint(i, temp));

        public static int always_lt_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_lt_temporal_temporal(temp1, temp2));

        public static int always_lt_text_ttext(IntPtr txt, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_lt_text_ttext(txt, temp));

        public static int always_lt_tfloat_float(IntPtr temp, double d)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_lt_tfloat_float(temp, d));

        public static int always_lt_tint_int(IntPtr temp, int i)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_lt_tint_int(temp, i));

        public static int always_lt_ttext_text(IntPtr temp, IntPtr txt)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_lt_ttext_text(temp, txt));

        public static int always_ne_bool_tbool(bool b, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_bool_tbool(b, temp));

        public static int always_ne_float_tfloat(double d, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_float_tfloat(d, temp));

        public static int always_ne_int_tint(int i, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_int_tint(i, temp));

        public static int always_ne_tbool_bool(IntPtr temp, bool b)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_tbool_bool(temp, b));

        public static int always_ne_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_temporal_temporal(temp1, temp2));

        public static int always_ne_text_ttext(IntPtr txt, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_text_ttext(txt, temp));

        public static int always_ne_tfloat_float(IntPtr temp, double d)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_tfloat_float(temp, d));

        public static int always_ne_tint_int(IntPtr temp, int i)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_tint_int(temp, i));

        public static int always_ne_ttext_text(IntPtr temp, IntPtr txt)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_ttext_text(temp, txt));

        public static int ever_eq_bool_tbool(bool b, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_bool_tbool(b, temp));

        public static int ever_eq_float_tfloat(double d, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_float_tfloat(d, temp));

        public static int ever_eq_int_tint(int i, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_int_tint(i, temp));

        public static int ever_eq_tbool_bool(IntPtr temp, bool b)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_tbool_bool(temp, b));

        public static int ever_eq_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_temporal_temporal(temp1, temp2));

        public static int ever_eq_text_ttext(IntPtr txt, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_text_ttext(txt, temp));

        public static int ever_eq_tfloat_float(IntPtr temp, double d)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_tfloat_float(temp, d));

        public static int ever_eq_tint_int(IntPtr temp, int i)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_tint_int(temp, i));

        public static int ever_eq_ttext_text(IntPtr temp, IntPtr txt)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_ttext_text(temp, txt));

        public static int ever_ge_float_tfloat(double d, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ge_float_tfloat(d, temp));

        public static int ever_ge_int_tint(int i, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ge_int_tint(i, temp));

        public static int ever_ge_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ge_temporal_temporal(temp1, temp2));

        public static int ever_ge_text_ttext(IntPtr txt, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ge_text_ttext(txt, temp));

        public static int ever_ge_tfloat_float(IntPtr temp, double d)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ge_tfloat_float(temp, d));

        public static int ever_ge_tint_int(IntPtr temp, int i)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ge_tint_int(temp, i));

        public static int ever_ge_ttext_text(IntPtr temp, IntPtr txt)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ge_ttext_text(temp, txt));

        public static int ever_gt_float_tfloat(double d, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_gt_float_tfloat(d, temp));

        public static int ever_gt_int_tint(int i, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_gt_int_tint(i, temp));

        public static int ever_gt_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_gt_temporal_temporal(temp1, temp2));

        public static int ever_gt_text_ttext(IntPtr txt, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_gt_text_ttext(txt, temp));

        public static int ever_gt_tfloat_float(IntPtr temp, double d)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_gt_tfloat_float(temp, d));

        public static int ever_gt_tint_int(IntPtr temp, int i)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_gt_tint_int(temp, i));

        public static int ever_gt_ttext_text(IntPtr temp, IntPtr txt)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_gt_ttext_text(temp, txt));

        public static int ever_le_float_tfloat(double d, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_le_float_tfloat(d, temp));

        public static int ever_le_int_tint(int i, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_le_int_tint(i, temp));

        public static int ever_le_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_le_temporal_temporal(temp1, temp2));

        public static int ever_le_text_ttext(IntPtr txt, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_le_text_ttext(txt, temp));

        public static int ever_le_tfloat_float(IntPtr temp, double d)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_le_tfloat_float(temp, d));

        public static int ever_le_tint_int(IntPtr temp, int i)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_le_tint_int(temp, i));

        public static int ever_le_ttext_text(IntPtr temp, IntPtr txt)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_le_ttext_text(temp, txt));

        public static int ever_lt_float_tfloat(double d, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_lt_float_tfloat(d, temp));

        public static int ever_lt_int_tint(int i, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_lt_int_tint(i, temp));

        public static int ever_lt_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_lt_temporal_temporal(temp1, temp2));

        public static int ever_lt_text_ttext(IntPtr txt, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_lt_text_ttext(txt, temp));

        public static int ever_lt_tfloat_float(IntPtr temp, double d)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_lt_tfloat_float(temp, d));

        public static int ever_lt_tint_int(IntPtr temp, int i)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_lt_tint_int(temp, i));

        public static int ever_lt_ttext_text(IntPtr temp, IntPtr txt)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_lt_ttext_text(temp, txt));

        public static int ever_ne_bool_tbool(bool b, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_bool_tbool(b, temp));

        public static int ever_ne_float_tfloat(double d, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_float_tfloat(d, temp));

        public static int ever_ne_int_tint(int i, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_int_tint(i, temp));

        public static int ever_ne_tbool_bool(IntPtr temp, bool b)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_tbool_bool(temp, b));

        public static int ever_ne_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_temporal_temporal(temp1, temp2));

        public static int ever_ne_text_ttext(IntPtr txt, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_text_ttext(txt, temp));

        public static int ever_ne_tfloat_float(IntPtr temp, double d)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_tfloat_float(temp, d));

        public static int ever_ne_tint_int(IntPtr temp, int i)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_tint_int(temp, i));

        public static int ever_ne_ttext_text(IntPtr temp, IntPtr txt)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_ttext_text(temp, txt));

        public static IntPtr teq_bool_tbool(bool b, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_bool_tbool(b, temp));

        public static IntPtr teq_float_tfloat(double d, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_float_tfloat(d, temp));

        public static IntPtr teq_int_tint(int i, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_int_tint(i, temp));

        public static IntPtr teq_tbool_bool(IntPtr temp, bool b)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_tbool_bool(temp, b));

        public static IntPtr teq_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_temporal_temporal(temp1, temp2));

        public static IntPtr teq_text_ttext(IntPtr txt, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_text_ttext(txt, temp));

        public static IntPtr teq_tfloat_float(IntPtr temp, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_tfloat_float(temp, d));

        public static IntPtr teq_tint_int(IntPtr temp, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_tint_int(temp, i));

        public static IntPtr teq_ttext_text(IntPtr temp, IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_ttext_text(temp, txt));

        public static IntPtr tge_float_tfloat(double d, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tge_float_tfloat(d, temp));

        public static IntPtr tge_int_tint(int i, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tge_int_tint(i, temp));

        public static IntPtr tge_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tge_temporal_temporal(temp1, temp2));

        public static IntPtr tge_text_ttext(IntPtr txt, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tge_text_ttext(txt, temp));

        public static IntPtr tge_tfloat_float(IntPtr temp, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tge_tfloat_float(temp, d));

        public static IntPtr tge_tint_int(IntPtr temp, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tge_tint_int(temp, i));

        public static IntPtr tge_ttext_text(IntPtr temp, IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tge_ttext_text(temp, txt));

        public static IntPtr tgt_float_tfloat(double d, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgt_float_tfloat(d, temp));

        public static IntPtr tgt_int_tint(int i, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgt_int_tint(i, temp));

        public static IntPtr tgt_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgt_temporal_temporal(temp1, temp2));

        public static IntPtr tgt_text_ttext(IntPtr txt, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgt_text_ttext(txt, temp));

        public static IntPtr tgt_tfloat_float(IntPtr temp, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgt_tfloat_float(temp, d));

        public static IntPtr tgt_tint_int(IntPtr temp, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgt_tint_int(temp, i));

        public static IntPtr tgt_ttext_text(IntPtr temp, IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgt_ttext_text(temp, txt));

        public static IntPtr tle_float_tfloat(double d, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tle_float_tfloat(d, temp));

        public static IntPtr tle_int_tint(int i, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tle_int_tint(i, temp));

        public static IntPtr tle_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tle_temporal_temporal(temp1, temp2));

        public static IntPtr tle_text_ttext(IntPtr txt, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tle_text_ttext(txt, temp));

        public static IntPtr tle_tfloat_float(IntPtr temp, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tle_tfloat_float(temp, d));

        public static IntPtr tle_tint_int(IntPtr temp, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tle_tint_int(temp, i));

        public static IntPtr tle_ttext_text(IntPtr temp, IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tle_ttext_text(temp, txt));

        public static IntPtr tlt_float_tfloat(double d, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tlt_float_tfloat(d, temp));

        public static IntPtr tlt_int_tint(int i, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tlt_int_tint(i, temp));

        public static IntPtr tlt_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tlt_temporal_temporal(temp1, temp2));

        public static IntPtr tlt_text_ttext(IntPtr txt, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tlt_text_ttext(txt, temp));

        public static IntPtr tlt_tfloat_float(IntPtr temp, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tlt_tfloat_float(temp, d));

        public static IntPtr tlt_tint_int(IntPtr temp, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tlt_tint_int(temp, i));

        public static IntPtr tlt_ttext_text(IntPtr temp, IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tlt_ttext_text(temp, txt));

        public static IntPtr tne_bool_tbool(bool b, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_bool_tbool(b, temp));

        public static IntPtr tne_float_tfloat(double d, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_float_tfloat(d, temp));

        public static IntPtr tne_int_tint(int i, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_int_tint(i, temp));

        public static IntPtr tne_tbool_bool(IntPtr temp, bool b)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_tbool_bool(temp, b));

        public static IntPtr tne_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_temporal_temporal(temp1, temp2));

        public static IntPtr tne_text_ttext(IntPtr txt, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_text_ttext(txt, temp));

        public static IntPtr tne_tfloat_float(IntPtr temp, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_tfloat_float(temp, d));

        public static IntPtr tne_tint_int(IntPtr temp, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_tint_int(temp, i));

        public static IntPtr tne_ttext_text(IntPtr temp, IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_ttext_text(temp, txt));

        public static IntPtr temporal_spans(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_spans(temp, count));

        public static IntPtr temporal_split_each_n_spans(IntPtr temp, int elem_count, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_split_each_n_spans(temp, elem_count, count));

        public static IntPtr temporal_split_n_spans(IntPtr temp, int span_count, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_split_n_spans(temp, span_count, count));

        public static IntPtr tnumber_split_each_n_tboxes(IntPtr temp, int elem_count, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_split_each_n_tboxes(temp, elem_count, count));

        public static IntPtr tnumber_split_n_tboxes(IntPtr temp, int box_count, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_split_n_tboxes(temp, box_count, count));

        public static IntPtr tnumber_tboxes(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_tboxes(temp, count));

        public static bool adjacent_numspan_tnumber(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_numspan_tnumber(s, temp));

        public static bool adjacent_tbox_tnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_tbox_tnumber(box, temp));

        public static bool adjacent_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_temporal_temporal(temp1, temp2));

        public static bool adjacent_temporal_tstzspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_temporal_tstzspan(temp, s));

        public static bool adjacent_tnumber_numspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_tnumber_numspan(temp, s));

        public static bool adjacent_tnumber_tbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_tnumber_tbox(temp, box));

        public static bool adjacent_tnumber_tnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_tnumber_tnumber(temp1, temp2));

        public static bool adjacent_tstzspan_temporal(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_tstzspan_temporal(s, temp));

        public static bool contained_numspan_tnumber(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_numspan_tnumber(s, temp));

        public static bool contained_tbox_tnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_tbox_tnumber(box, temp));

        public static bool contained_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_temporal_temporal(temp1, temp2));

        public static bool contained_temporal_tstzspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_temporal_tstzspan(temp, s));

        public static bool contained_tnumber_numspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_tnumber_numspan(temp, s));

        public static bool contained_tnumber_tbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_tnumber_tbox(temp, box));

        public static bool contained_tnumber_tnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_tnumber_tnumber(temp1, temp2));

        public static bool contained_tstzspan_temporal(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_tstzspan_temporal(s, temp));

        public static bool contains_numspan_tnumber(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_numspan_tnumber(s, temp));

        public static bool contains_tbox_tnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_tbox_tnumber(box, temp));

        public static bool contains_temporal_tstzspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_temporal_tstzspan(temp, s));

        public static bool contains_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_temporal_temporal(temp1, temp2));

        public static bool contains_tnumber_numspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_tnumber_numspan(temp, s));

        public static bool contains_tnumber_tbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_tnumber_tbox(temp, box));

        public static bool contains_tnumber_tnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_tnumber_tnumber(temp1, temp2));

        public static bool contains_tstzspan_temporal(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_tstzspan_temporal(s, temp));

        public static bool overlaps_numspan_tnumber(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_numspan_tnumber(s, temp));

        public static bool overlaps_tbox_tnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_tbox_tnumber(box, temp));

        public static bool overlaps_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_temporal_temporal(temp1, temp2));

        public static bool overlaps_temporal_tstzspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_temporal_tstzspan(temp, s));

        public static bool overlaps_tnumber_numspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_tnumber_numspan(temp, s));

        public static bool overlaps_tnumber_tbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_tnumber_tbox(temp, box));

        public static bool overlaps_tnumber_tnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_tnumber_tnumber(temp1, temp2));

        public static bool overlaps_tstzspan_temporal(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_tstzspan_temporal(s, temp));

        public static bool same_numspan_tnumber(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.same_numspan_tnumber(s, temp));

        public static bool same_tbox_tnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.same_tbox_tnumber(box, temp));

        public static bool same_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.same_temporal_temporal(temp1, temp2));

        public static bool same_temporal_tstzspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.same_temporal_tstzspan(temp, s));

        public static bool same_tnumber_numspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.same_tnumber_numspan(temp, s));

        public static bool same_tnumber_tbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.same_tnumber_tbox(temp, box));

        public static bool same_tnumber_tnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.same_tnumber_tnumber(temp1, temp2));

        public static bool same_tstzspan_temporal(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.same_tstzspan_temporal(s, temp));

        public static bool after_tbox_tnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_tbox_tnumber(box, temp));

        public static bool after_temporal_tstzspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_temporal_tstzspan(temp, s));

        public static bool after_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_temporal_temporal(temp1, temp2));

        public static bool after_tnumber_tbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_tnumber_tbox(temp, box));

        public static bool after_tnumber_tnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_tnumber_tnumber(temp1, temp2));

        public static bool after_tstzspan_temporal(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_tstzspan_temporal(s, temp));

        public static bool before_tbox_tnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_tbox_tnumber(box, temp));

        public static bool before_temporal_tstzspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_temporal_tstzspan(temp, s));

        public static bool before_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_temporal_temporal(temp1, temp2));

        public static bool before_tnumber_tbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_tnumber_tbox(temp, box));

        public static bool before_tnumber_tnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_tnumber_tnumber(temp1, temp2));

        public static bool before_tstzspan_temporal(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_tstzspan_temporal(s, temp));

        public static bool left_tbox_tnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_tbox_tnumber(box, temp));

        public static bool left_numspan_tnumber(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_numspan_tnumber(s, temp));

        public static bool left_tnumber_numspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_tnumber_numspan(temp, s));

        public static bool left_tnumber_tbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_tnumber_tbox(temp, box));

        public static bool left_tnumber_tnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_tnumber_tnumber(temp1, temp2));

        public static bool overafter_tbox_tnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_tbox_tnumber(box, temp));

        public static bool overafter_temporal_tstzspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_temporal_tstzspan(temp, s));

        public static bool overafter_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_temporal_temporal(temp1, temp2));

        public static bool overafter_tnumber_tbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_tnumber_tbox(temp, box));

        public static bool overafter_tnumber_tnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_tnumber_tnumber(temp1, temp2));

        public static bool overafter_tstzspan_temporal(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_tstzspan_temporal(s, temp));

        public static bool overbefore_tbox_tnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_tbox_tnumber(box, temp));

        public static bool overbefore_temporal_tstzspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_temporal_tstzspan(temp, s));

        public static bool overbefore_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_temporal_temporal(temp1, temp2));

        public static bool overbefore_tnumber_tbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_tnumber_tbox(temp, box));

        public static bool overbefore_tnumber_tnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_tnumber_tnumber(temp1, temp2));

        public static bool overbefore_tstzspan_temporal(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_tstzspan_temporal(s, temp));

        public static bool overleft_numspan_tnumber(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_numspan_tnumber(s, temp));

        public static bool overleft_tbox_tnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_tbox_tnumber(box, temp));

        public static bool overleft_tnumber_numspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_tnumber_numspan(temp, s));

        public static bool overleft_tnumber_tbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_tnumber_tbox(temp, box));

        public static bool overleft_tnumber_tnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_tnumber_tnumber(temp1, temp2));

        public static bool overright_numspan_tnumber(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_numspan_tnumber(s, temp));

        public static bool overright_tbox_tnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_tbox_tnumber(box, temp));

        public static bool overright_tnumber_numspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_tnumber_numspan(temp, s));

        public static bool overright_tnumber_tbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_tnumber_tbox(temp, box));

        public static bool overright_tnumber_tnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_tnumber_tnumber(temp1, temp2));

        public static bool right_numspan_tnumber(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_numspan_tnumber(s, temp));

        public static bool right_tbox_tnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_tbox_tnumber(box, temp));

        public static bool right_tnumber_numspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_tnumber_numspan(temp, s));

        public static bool right_tnumber_tbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_tnumber_tbox(temp, box));

        public static bool right_tnumber_tnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_tnumber_tnumber(temp1, temp2));

        public static IntPtr tand_bool_tbool(bool b, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tand_bool_tbool(b, temp));

        public static IntPtr tand_tbool_bool(IntPtr temp, bool b)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tand_tbool_bool(temp, b));

        public static IntPtr tand_tbool_tbool(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tand_tbool_tbool(temp1, temp2));

        public static IntPtr tbool_when_true(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbool_when_true(temp));

        public static IntPtr tnot_tbool(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnot_tbool(temp));

        public static IntPtr tor_bool_tbool(bool b, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tor_bool_tbool(b, temp));

        public static IntPtr tor_tbool_bool(IntPtr temp, bool b)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tor_tbool_bool(temp, b));

        public static IntPtr tor_tbool_tbool(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tor_tbool_tbool(temp1, temp2));

        public static IntPtr add_float_tfloat(double d, IntPtr tnumber)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.add_float_tfloat(d, tnumber));

        public static IntPtr add_int_tint(int i, IntPtr tnumber)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.add_int_tint(i, tnumber));

        public static IntPtr add_tfloat_float(IntPtr tnumber, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.add_tfloat_float(tnumber, d));

        public static IntPtr add_tint_int(IntPtr tnumber, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.add_tint_int(tnumber, i));

        public static IntPtr add_tnumber_tnumber(IntPtr tnumber1, IntPtr tnumber2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.add_tnumber_tnumber(tnumber1, tnumber2));

        public static IntPtr div_float_tfloat(double d, IntPtr tnumber)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.div_float_tfloat(d, tnumber));

        public static IntPtr div_int_tint(int i, IntPtr tnumber)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.div_int_tint(i, tnumber));

        public static IntPtr div_tfloat_float(IntPtr tnumber, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.div_tfloat_float(tnumber, d));

        public static IntPtr div_tint_int(IntPtr tnumber, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.div_tint_int(tnumber, i));

        public static IntPtr div_tnumber_tnumber(IntPtr tnumber1, IntPtr tnumber2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.div_tnumber_tnumber(tnumber1, tnumber2));

        public static IntPtr mult_float_tfloat(double d, IntPtr tnumber)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.mult_float_tfloat(d, tnumber));

        public static IntPtr mult_int_tint(int i, IntPtr tnumber)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.mult_int_tint(i, tnumber));

        public static IntPtr mult_tfloat_float(IntPtr tnumber, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.mult_tfloat_float(tnumber, d));

        public static IntPtr mult_tint_int(IntPtr tnumber, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.mult_tint_int(tnumber, i));

        public static IntPtr mult_tnumber_tnumber(IntPtr tnumber1, IntPtr tnumber2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.mult_tnumber_tnumber(tnumber1, tnumber2));

        public static IntPtr sub_float_tfloat(double d, IntPtr tnumber)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.sub_float_tfloat(d, tnumber));

        public static IntPtr sub_int_tint(int i, IntPtr tnumber)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.sub_int_tint(i, tnumber));

        public static IntPtr sub_tfloat_float(IntPtr tnumber, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.sub_tfloat_float(tnumber, d));

        public static IntPtr sub_tint_int(IntPtr tnumber, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.sub_tint_int(tnumber, i));

        public static IntPtr sub_tnumber_tnumber(IntPtr tnumber1, IntPtr tnumber2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.sub_tnumber_tnumber(tnumber1, tnumber2));

        public static IntPtr temporal_derivative(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_derivative(temp));

        public static IntPtr tfloat_exp(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_exp(temp));

        public static IntPtr tfloat_ln(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_ln(temp));

        public static IntPtr tfloat_log10(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_log10(temp));

        public static IntPtr tnumber_abs(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_abs(temp));

        public static IntPtr tnumber_trend(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_trend(temp));

        public static double float_angular_difference(double degrees1, double degrees2)
            => SafeExecution<double>(() => MEOSExternalFunctions.float_angular_difference(degrees1, degrees2));

        public static IntPtr tnumber_angular_difference(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_angular_difference(temp));

        public static IntPtr tnumber_delta_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_delta_value(temp));

        public static IntPtr textcat_text_ttext(IntPtr txt, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.textcat_text_ttext(txt, temp));

        public static IntPtr textcat_ttext_text(IntPtr temp, IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.textcat_ttext_text(temp, txt));

        public static IntPtr textcat_ttext_ttext(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.textcat_ttext_ttext(temp1, temp2));

        public static IntPtr ttext_initcap(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_initcap(temp));

        public static IntPtr ttext_upper(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_upper(temp));

        public static IntPtr ttext_lower(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_lower(temp));

        public static IntPtr tdistance_tfloat_float(IntPtr temp, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdistance_tfloat_float(temp, d));

        public static IntPtr tdistance_tint_int(IntPtr temp, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdistance_tint_int(temp, i));

        public static IntPtr tdistance_tnumber_tnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdistance_tnumber_tnumber(temp1, temp2));

        public static double nad_tboxfloat_tboxfloat(IntPtr box1, IntPtr box2)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tboxfloat_tboxfloat(box1, box2));

        public static int nad_tboxint_tboxint(IntPtr box1, IntPtr box2)
            => SafeExecution<int>(() => MEOSExternalFunctions.nad_tboxint_tboxint(box1, box2));

        public static double nad_tfloat_float(IntPtr temp, double d)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tfloat_float(temp, d));

        public static double nad_tfloat_tfloat(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tfloat_tfloat(temp1, temp2));

        public static double nad_tfloat_tbox(IntPtr temp, IntPtr box)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tfloat_tbox(temp, box));

        public static int nad_tint_int(IntPtr temp, int i)
            => SafeExecution<int>(() => MEOSExternalFunctions.nad_tint_int(temp, i));

        public static int nad_tint_tbox(IntPtr temp, IntPtr box)
            => SafeExecution<int>(() => MEOSExternalFunctions.nad_tint_tbox(temp, box));

        public static int nad_tint_tint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.nad_tint_tint(temp1, temp2));

        public static IntPtr tbool_tand_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbool_tand_transfn(state, temp));

        public static IntPtr tbool_tor_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbool_tor_transfn(state, temp));

        public static IntPtr temporal_extent_transfn(IntPtr s, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_extent_transfn(s, temp));

        public static IntPtr temporal_merge_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_merge_transfn(state, temp));

        public static IntPtr temporal_merge_combinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_merge_combinefn(state1, state2));

        public static IntPtr temporal_tagg_finalfn(IntPtr state)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_tagg_finalfn(state));

        public static IntPtr temporal_tcount_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_tcount_transfn(state, temp));

        public static IntPtr tfloat_tmax_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_tmax_transfn(state, temp));

        public static IntPtr tfloat_tmin_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_tmin_transfn(state, temp));

        public static IntPtr tfloat_tsum_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_tsum_transfn(state, temp));

        public static IntPtr tfloat_wmax_transfn(IntPtr state, IntPtr temp, IntPtr interv)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_wmax_transfn(state, temp, interv));

        public static IntPtr tfloat_wmin_transfn(IntPtr state, IntPtr temp, IntPtr interv)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_wmin_transfn(state, temp, interv));

        public static IntPtr tfloat_wsum_transfn(IntPtr state, IntPtr temp, IntPtr interv)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_wsum_transfn(state, temp, interv));

        public static IntPtr timestamptz_tcount_transfn(IntPtr state, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.timestamptz_tcount_transfn(state, t));

        public static IntPtr tint_tmax_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_tmax_transfn(state, temp));

        public static IntPtr tint_tmin_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_tmin_transfn(state, temp));

        public static IntPtr tint_tsum_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_tsum_transfn(state, temp));

        public static IntPtr tint_wmax_transfn(IntPtr state, IntPtr temp, IntPtr interv)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_wmax_transfn(state, temp, interv));

        public static IntPtr tint_wmin_transfn(IntPtr state, IntPtr temp, IntPtr interv)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_wmin_transfn(state, temp, interv));

        public static IntPtr tint_wsum_transfn(IntPtr state, IntPtr temp, IntPtr interv)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_wsum_transfn(state, temp, interv));

        public static IntPtr tnumber_extent_transfn(IntPtr box, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_extent_transfn(box, temp));

        public static IntPtr tnumber_tavg_finalfn(IntPtr state)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_tavg_finalfn(state));

        public static IntPtr tnumber_tavg_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_tavg_transfn(state, temp));

        public static IntPtr tnumber_wavg_transfn(IntPtr state, IntPtr temp, IntPtr interv)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_wavg_transfn(state, temp, interv));

        public static IntPtr tstzset_tcount_transfn(IntPtr state, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzset_tcount_transfn(state, s));

        public static IntPtr tstzspan_tcount_transfn(IntPtr state, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspan_tcount_transfn(state, s));

        public static IntPtr tstzspanset_tcount_transfn(IntPtr state, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspanset_tcount_transfn(state, ss));

        public static IntPtr ttext_tmax_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_tmax_transfn(state, temp));

        public static IntPtr ttext_tmin_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_tmin_transfn(state, temp));

        public static IntPtr temporal_simplify_dp(IntPtr temp, double eps_dist, bool synchronized)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_simplify_dp(temp, eps_dist, synchronized));

        public static IntPtr temporal_simplify_max_dist(IntPtr temp, double eps_dist, bool synchronized)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_simplify_max_dist(temp, eps_dist, synchronized));

        public static IntPtr temporal_simplify_min_dist(IntPtr temp, double dist)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_simplify_min_dist(temp, dist));

        public static IntPtr temporal_simplify_min_tdelta(IntPtr temp, IntPtr mint)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_simplify_min_tdelta(temp, mint));

        public static IntPtr temporal_tprecision(IntPtr temp, IntPtr duration, long origin)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_tprecision(temp, duration, origin));

        public static IntPtr temporal_tsample(IntPtr temp, IntPtr duration, long origin, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_tsample(temp, duration, origin, interp));

        public static double temporal_dyntimewarp_distance(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => MEOSExternalFunctions.temporal_dyntimewarp_distance(temp1, temp2));

        public static IntPtr temporal_dyntimewarp_path(IntPtr temp1, IntPtr temp2, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_dyntimewarp_path(temp1, temp2, count));

        public static double temporal_frechet_distance(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => MEOSExternalFunctions.temporal_frechet_distance(temp1, temp2));

        public static IntPtr temporal_frechet_path(IntPtr temp1, IntPtr temp2, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_frechet_path(temp1, temp2, count));

        public static double temporal_hausdorff_distance(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => MEOSExternalFunctions.temporal_hausdorff_distance(temp1, temp2));

        public static IntPtr temporal_time_bins(IntPtr temp, IntPtr duration, long origin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_time_bins(temp, duration, origin, count));

        public static (IntPtr[], long[]) temporal_time_split(IntPtr temp, IntPtr duration, long torigin)
        {
            IntPtr _out_time_bins = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_time_split(temp, duration, torigin, _out_time_bins, _count_count));
                int _n = Marshal.ReadInt32(_count_count);
                IntPtr[] _resultArr = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _resultArr[_i] = Marshal.ReadIntPtr(_resultPtr, _i * IntPtr.Size); }
                IntPtr __out_time_bins_arr = Marshal.ReadIntPtr(_out_time_bins);
                long[] __out_time_bins_out = new long[_n];
                Marshal.Copy(__out_time_bins_arr, __out_time_bins_out, 0, _n);
                return (_resultArr, __out_time_bins_out);
            }
            finally
            {
            Marshal.FreeHGlobal(_out_time_bins);
            Marshal.FreeHGlobal(_count_count);
            }
        }

        public static IntPtr tfloat_time_boxes(IntPtr temp, IntPtr duration, long torigin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_time_boxes(temp, duration, torigin, count));

        public static IntPtr tfloat_value_bins(IntPtr temp, double vsize, double vorigin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_value_bins(temp, vsize, vorigin, count));

        public static IntPtr tfloat_value_boxes(IntPtr temp, double vsize, double vorigin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_value_boxes(temp, vsize, vorigin, count));

        public static (IntPtr[], double[]) tfloat_value_split(IntPtr temp, double size, double origin)
        {
            IntPtr _out_bins = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_value_split(temp, size, origin, _out_bins, _count_count));
                int _n = Marshal.ReadInt32(_count_count);
                IntPtr[] _resultArr = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _resultArr[_i] = Marshal.ReadIntPtr(_resultPtr, _i * IntPtr.Size); }
                IntPtr __out_bins_arr = Marshal.ReadIntPtr(_out_bins);
                double[] __out_bins_out = new double[_n];
                Marshal.Copy(__out_bins_arr, __out_bins_out, 0, _n);
                return (_resultArr, __out_bins_out);
            }
            finally
            {
            Marshal.FreeHGlobal(_out_bins);
            Marshal.FreeHGlobal(_count_count);
            }
        }

        public static IntPtr tfloat_value_time_boxes(IntPtr temp, double vsize, IntPtr duration, double vorigin, long torigin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_value_time_boxes(temp, vsize, duration, vorigin, torigin, count));

        public static (IntPtr[], double[], long[]) tfloat_value_time_split(IntPtr temp, double vsize, IntPtr duration, double vorigin, long torigin)
        {
            IntPtr _out_value_bins = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _out_time_bins = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_value_time_split(temp, vsize, duration, vorigin, torigin, _out_value_bins, _out_time_bins, _count_count));
                int _n = Marshal.ReadInt32(_count_count);
                IntPtr[] _resultArr = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _resultArr[_i] = Marshal.ReadIntPtr(_resultPtr, _i * IntPtr.Size); }
                IntPtr __out_value_bins_arr = Marshal.ReadIntPtr(_out_value_bins);
                double[] __out_value_bins_out = new double[_n];
                Marshal.Copy(__out_value_bins_arr, __out_value_bins_out, 0, _n);
                IntPtr __out_time_bins_arr = Marshal.ReadIntPtr(_out_time_bins);
                long[] __out_time_bins_out = new long[_n];
                Marshal.Copy(__out_time_bins_arr, __out_time_bins_out, 0, _n);
                return (_resultArr, __out_value_bins_out, __out_time_bins_out);
            }
            finally
            {
            Marshal.FreeHGlobal(_out_value_bins);
            Marshal.FreeHGlobal(_out_time_bins);
            Marshal.FreeHGlobal(_count_count);
            }
        }

        public static IntPtr tfloatbox_time_tiles(IntPtr box, IntPtr duration, long torigin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloatbox_time_tiles(box, duration, torigin, count));

        public static IntPtr tfloatbox_value_tiles(IntPtr box, double vsize, double vorigin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloatbox_value_tiles(box, vsize, vorigin, count));

        public static IntPtr tfloatbox_value_time_tiles(IntPtr box, double vsize, IntPtr duration, double vorigin, long torigin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloatbox_value_time_tiles(box, vsize, duration, vorigin, torigin, count));

        public static IntPtr tint_time_boxes(IntPtr temp, IntPtr duration, long torigin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_time_boxes(temp, duration, torigin, count));

        public static IntPtr tint_value_bins(IntPtr temp, int vsize, int vorigin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_value_bins(temp, vsize, vorigin, count));

        public static IntPtr tint_value_boxes(IntPtr temp, int vsize, int vorigin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_value_boxes(temp, vsize, vorigin, count));

        public static (IntPtr[], int[]) tint_value_split(IntPtr temp, int vsize, int vorigin)
        {
            IntPtr _out_bins = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_value_split(temp, vsize, vorigin, _out_bins, _count_count));
                int _n = Marshal.ReadInt32(_count_count);
                IntPtr[] _resultArr = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _resultArr[_i] = Marshal.ReadIntPtr(_resultPtr, _i * IntPtr.Size); }
                IntPtr __out_bins_arr = Marshal.ReadIntPtr(_out_bins);
                int[] __out_bins_out = new int[_n];
                Marshal.Copy(__out_bins_arr, __out_bins_out, 0, _n);
                return (_resultArr, __out_bins_out);
            }
            finally
            {
            Marshal.FreeHGlobal(_out_bins);
            Marshal.FreeHGlobal(_count_count);
            }
        }

        public static IntPtr tint_value_time_boxes(IntPtr temp, int vsize, IntPtr duration, int vorigin, long torigin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_value_time_boxes(temp, vsize, duration, vorigin, torigin, count));

        public static (IntPtr[], int[], long[]) tint_value_time_split(IntPtr temp, int size, IntPtr duration, int vorigin, long torigin)
        {
            IntPtr _out_value_bins = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _out_time_bins = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_value_time_split(temp, size, duration, vorigin, torigin, _out_value_bins, _out_time_bins, _count_count));
                int _n = Marshal.ReadInt32(_count_count);
                IntPtr[] _resultArr = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _resultArr[_i] = Marshal.ReadIntPtr(_resultPtr, _i * IntPtr.Size); }
                IntPtr __out_value_bins_arr = Marshal.ReadIntPtr(_out_value_bins);
                int[] __out_value_bins_out = new int[_n];
                Marshal.Copy(__out_value_bins_arr, __out_value_bins_out, 0, _n);
                IntPtr __out_time_bins_arr = Marshal.ReadIntPtr(_out_time_bins);
                long[] __out_time_bins_out = new long[_n];
                Marshal.Copy(__out_time_bins_arr, __out_time_bins_out, 0, _n);
                return (_resultArr, __out_value_bins_out, __out_time_bins_out);
            }
            finally
            {
            Marshal.FreeHGlobal(_out_value_bins);
            Marshal.FreeHGlobal(_out_time_bins);
            Marshal.FreeHGlobal(_count_count);
            }
        }

        public static IntPtr tintbox_time_tiles(IntPtr box, IntPtr duration, long torigin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintbox_time_tiles(box, duration, torigin, count));

        public static IntPtr tintbox_value_tiles(IntPtr box, int xsize, int xorigin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintbox_value_tiles(box, xsize, xorigin, count));

        public static IntPtr tintbox_value_time_tiles(IntPtr box, int xsize, IntPtr duration, int xorigin, long torigin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintbox_value_time_tiles(box, xsize, duration, xorigin, torigin, count));

        public static bool temptype_subtype(int subtype)
            => SafeExecution<bool>(() => MEOSExternalFunctions.temptype_subtype(subtype));

        public static bool temptype_subtype_all(int subtype)
            => SafeExecution<bool>(() => MEOSExternalFunctions.temptype_subtype_all(subtype));

        public static string tempsubtype_name(int subtype)
            => SafeExecution<string>(() => MEOSExternalFunctions.tempsubtype_name(subtype));

        public static bool tempsubtype_from_string(string str, IntPtr subtype)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tempsubtype_from_string(str, subtype));

        public static string meosoper_name(IntPtr oper)
            => SafeExecution<string>(() => MEOSExternalFunctions.meosoper_name(oper));

        public static IntPtr meosoper_from_string(string name)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.meosoper_from_string(name));

        public static string interptype_name(int interp)
            => SafeExecution<string>(() => MEOSExternalFunctions.interptype_name(interp));

        public static int interptype_from_string(string interp_str)
            => SafeExecution<int>(() => MEOSExternalFunctions.interptype_from_string(interp_str));

        public static string meostype_name(int type)
            => SafeExecution<string>(() => MEOSExternalFunctions.meostype_name(type));

        public static int temptype_basetype(int type)
            => SafeExecution<int>(() => MEOSExternalFunctions.temptype_basetype(type));

        public static int settype_basetype(int type)
            => SafeExecution<int>(() => MEOSExternalFunctions.settype_basetype(type));

        public static int spantype_basetype(int type)
            => SafeExecution<int>(() => MEOSExternalFunctions.spantype_basetype(type));

        public static int spantype_spansettype(int type)
            => SafeExecution<int>(() => MEOSExternalFunctions.spantype_spansettype(type));

        public static int spansettype_spantype(int type)
            => SafeExecution<int>(() => MEOSExternalFunctions.spansettype_spantype(type));

        public static int basetype_spantype(int type)
            => SafeExecution<int>(() => MEOSExternalFunctions.basetype_spantype(type));

        public static int basetype_settype(int type)
            => SafeExecution<int>(() => MEOSExternalFunctions.basetype_settype(type));

        public static bool tnumber_basetype(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tnumber_basetype(type));

        public static bool geo_basetype(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geo_basetype(type));

        public static bool meos_basetype(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.meos_basetype(type));

        public static bool alphanum_basetype(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.alphanum_basetype(type));

        public static bool alphanum_temptype(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.alphanum_temptype(type));

        public static bool time_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.time_type(type));

        public static bool set_basetype(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.set_basetype(type));

        public static bool set_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.set_type(type));

        public static bool numset_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.numset_type(type));

        public static bool ensure_numset_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_numset_type(type));

        public static bool timeset_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.timeset_type(type));

        public static bool set_spantype(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.set_spantype(type));

        public static bool ensure_set_spantype(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_set_spantype(type));

        public static bool alphanumset_type(int settype)
            => SafeExecution<bool>(() => MEOSExternalFunctions.alphanumset_type(settype));

        public static bool geoset_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geoset_type(type));

        public static bool ensure_geoset_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_geoset_type(type));

        public static bool spatialset_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.spatialset_type(type));

        public static bool ensure_spatialset_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_spatialset_type(type));

        public static bool span_basetype(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.span_basetype(type));

        public static bool span_canon_basetype(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.span_canon_basetype(type));

        public static bool span_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.span_type(type));

        public static bool type_span_bbox(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.type_span_bbox(type));

        public static bool span_tbox_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.span_tbox_type(type));

        public static bool ensure_span_tbox_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_span_tbox_type(type));

        public static bool numspan_basetype(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.numspan_basetype(type));

        public static bool numspan_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.numspan_type(type));

        public static bool ensure_numspan_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_numspan_type(type));

        public static bool timespan_basetype(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.timespan_basetype(type));

        public static bool timespan_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.timespan_type(type));

        public static bool spanset_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.spanset_type(type));

        public static bool timespanset_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.timespanset_type(type));

        public static bool ensure_timespanset_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_timespanset_type(type));

        public static bool temporal_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.temporal_type(type));

        public static bool temporal_basetype(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.temporal_basetype(type));

        public static bool temptype_supports_linear(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.temptype_supports_linear(type));

        public static bool basetype_byvalue(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.basetype_byvalue(type));

        public static bool basetype_varlength(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.basetype_varlength(type));

        public static short meostype_length(int type)
            => SafeExecution<short>(() => MEOSExternalFunctions.meostype_length(type));

        public static bool talphanum_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.talphanum_type(type));

        public static bool talpha_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.talpha_type(type));

        public static bool tnumber_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tnumber_type(type));

        public static bool ensure_tnumber_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_tnumber_type(type));

        public static bool ensure_tnumber_basetype(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_tnumber_basetype(type));

        public static bool tnumber_spantype(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tnumber_spantype(type));

        public static bool spatial_basetype(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.spatial_basetype(type));

        public static bool tspatial_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tspatial_type(type));

        public static bool ensure_tspatial_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_tspatial_type(type));

        public static bool tpoint_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpoint_type(type));

        public static bool ensure_tpoint_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_tpoint_type(type));

        public static bool tgeo_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tgeo_type(type));

        public static bool ensure_tgeo_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_tgeo_type(type));

        public static bool tgeo_type_all(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tgeo_type_all(type));

        public static bool ensure_tgeo_type_all(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_tgeo_type_all(type));

        public static bool tgeometry_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tgeometry_type(type));

        public static bool ensure_tgeometry_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_tgeometry_type(type));

        public static bool tgeodetic_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tgeodetic_type(type));

        public static bool ensure_tgeodetic_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_tgeodetic_type(type));

        public static bool ensure_tnumber_tpoint_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_tnumber_tpoint_type(type));

        public static int geo_get_srid(IntPtr g)
            => SafeExecution<int>(() => MEOSExternalFunctions.geo_get_srid(g));

        public static IntPtr geo_as_ewkb(IntPtr gs, string endian, IntPtr size)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_as_ewkb(gs, endian, size));

        public static string geo_as_ewkt(IntPtr gs, int precision)
            => SafeExecution<string>(() => MEOSExternalFunctions.geo_as_ewkt(gs, precision));

        public static string geo_as_geojson(IntPtr gs, int option, int precision, string srs)
            => SafeExecution<string>(() => MEOSExternalFunctions.geo_as_geojson(gs, option, precision, srs));

        public static string geo_as_hexewkb(IntPtr gs, string endian)
            => SafeExecution<string>(() => MEOSExternalFunctions.geo_as_hexewkb(gs, endian));

        public static string geo_as_text(IntPtr gs, int precision)
            => SafeExecution<string>(() => MEOSExternalFunctions.geo_as_text(gs, precision));

        public static IntPtr geo_from_ewkb(IntPtr wkb, ulong wkb_size, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_from_ewkb(wkb, wkb_size, srid));

        public static IntPtr geo_from_geojson(string geojson)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_from_geojson(geojson));

        public static IntPtr geo_from_text(string wkt, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_from_text(wkt, srid));

        public static string geo_out(IntPtr gs)
            => SafeExecution<string>(() => MEOSExternalFunctions.geo_out(gs));

        public static IntPtr geog_from_binary(string wkb_bytea)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geog_from_binary(wkb_bytea));

        public static IntPtr geog_from_hexewkb(string wkt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geog_from_hexewkb(wkt));

        public static IntPtr geog_in(string str, int typmod)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geog_in(str, typmod));

        public static IntPtr geom_from_hexewkb(string wkt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geom_from_hexewkb(wkt));

        public static IntPtr geom_in(string str, int typmod)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geom_in(str, typmod));

        public static IntPtr box3d_make(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.box3d_make(xmin, xmax, ymin, ymax, zmin, zmax, srid));

        public static string box3d_out(IntPtr box, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.box3d_out(box, maxdd));

        public static IntPtr gbox_make(bool hasz, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.gbox_make(hasz, xmin, xmax, ymin, ymax, zmin, zmax));

        public static string gbox_out(IntPtr box, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.gbox_out(box, maxdd));

        public static IntPtr geo_copy(IntPtr g)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_copy(g));

        public static IntPtr geogpoint_make2d(int srid, double x, double y)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geogpoint_make2d(srid, x, y));

        public static IntPtr geogpoint_make3dz(int srid, double x, double y, double z)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geogpoint_make3dz(srid, x, y, z));

        public static IntPtr geompoint_make2d(int srid, double x, double y)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geompoint_make2d(srid, x, y));

        public static IntPtr geompoint_make3dz(int srid, double x, double y, double z)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geompoint_make3dz(srid, x, y, z));

        public static IntPtr geom_to_geog(IntPtr geom)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geom_to_geog(geom));

        public static IntPtr geog_to_geom(IntPtr geog)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geog_to_geom(geog));

        public static bool geo_is_empty(IntPtr g)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geo_is_empty(g));

        public static bool geo_is_unitary(IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geo_is_unitary(gs));

        public static string geo_typename(int type)
            => SafeExecution<string>(() => MEOSExternalFunctions.geo_typename(type));

        public static double geog_area(IntPtr g, bool use_spheroid)
            => SafeExecution<double>(() => MEOSExternalFunctions.geog_area(g, use_spheroid));

        public static IntPtr geog_centroid(IntPtr g, bool use_spheroid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geog_centroid(g, use_spheroid));

        public static double geog_length(IntPtr g, bool use_spheroid)
            => SafeExecution<double>(() => MEOSExternalFunctions.geog_length(g, use_spheroid));

        public static double geog_perimeter(IntPtr g, bool use_spheroid)
            => SafeExecution<double>(() => MEOSExternalFunctions.geog_perimeter(g, use_spheroid));

        public static bool geom_azimuth(IntPtr gs1, IntPtr gs2, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geom_azimuth(gs1, gs2, result));

        public static double geom_length(IntPtr gs)
            => SafeExecution<double>(() => MEOSExternalFunctions.geom_length(gs));

        public static double geom_perimeter(IntPtr gs)
            => SafeExecution<double>(() => MEOSExternalFunctions.geom_perimeter(gs));

        public static int line_numpoints(IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.line_numpoints(gs));

        public static IntPtr line_point_n(IntPtr geom, int n)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.line_point_n(geom, n));

        public static IntPtr geo_reverse(IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_reverse(gs));

        public static IntPtr geo_round(IntPtr gs, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_round(gs, maxdd));

        public static IntPtr geo_set_srid(IntPtr gs, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_set_srid(gs, srid));

        public static int geo_srid(IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.geo_srid(gs));

        public static IntPtr geo_transform(IntPtr geom, int srid_to)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_transform(geom, srid_to));

        public static IntPtr geo_transform_pipeline(IntPtr gs, string pipeline, int srid_to, bool is_forward)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_transform_pipeline(gs, pipeline, srid_to, is_forward));

        public static IntPtr geo_collect_garray(IntPtr gsarr, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_collect_garray(gsarr, count));

        public static IntPtr geo_makeline_garray(IntPtr gsarr, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_makeline_garray(gsarr, count));

        public static int geo_num_points(IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.geo_num_points(gs));

        public static int geo_num_geos(IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.geo_num_geos(gs));

        public static IntPtr geo_geo_n(IntPtr geom, int n)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_geo_n(geom, n));

        public static IntPtr geo_pointarr(IntPtr gs, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_pointarr(gs, count));

        public static IntPtr geo_points(IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_points(gs));

        public static IntPtr geom_array_union(IntPtr gsarr, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geom_array_union(gsarr, count));

        public static IntPtr geom_boundary(IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geom_boundary(gs));

        public static IntPtr geom_buffer(IntPtr gs, double size, string @params)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geom_buffer(gs, size, @params));

        public static IntPtr geom_centroid(IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geom_centroid(gs));

        public static IntPtr geom_convex_hull(IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geom_convex_hull(gs));

        public static IntPtr geom_difference2d(IntPtr gs1, IntPtr gs2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geom_difference2d(gs1, gs2));

        public static IntPtr geom_intersection2d(IntPtr gs1, IntPtr gs2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geom_intersection2d(gs1, gs2));

        public static IntPtr geom_intersection2d_coll(IntPtr gs1, IntPtr gs2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geom_intersection2d_coll(gs1, gs2));

        public static IntPtr geom_min_bounding_radius(IntPtr geom, IntPtr radius)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geom_min_bounding_radius(geom, radius));

        public static IntPtr geom_shortestline2d(IntPtr gs1, IntPtr s2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geom_shortestline2d(gs1, s2));

        public static IntPtr geom_shortestline3d(IntPtr gs1, IntPtr s2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geom_shortestline3d(gs1, s2));

        public static IntPtr geom_unary_union(IntPtr gs, double prec)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geom_unary_union(gs, prec));

        public static IntPtr line_interpolate_point(IntPtr gs, double distance_fraction, bool repeat)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.line_interpolate_point(gs, distance_fraction, repeat));

        public static double line_locate_point(IntPtr gs1, IntPtr gs2)
            => SafeExecution<double>(() => MEOSExternalFunctions.line_locate_point(gs1, gs2));

        public static IntPtr line_substring(IntPtr gs, double from, double to)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.line_substring(gs, from, to));

        public static bool geog_dwithin(IntPtr g1, IntPtr g2, double tolerance, bool use_spheroid)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geog_dwithin(g1, g2, tolerance, use_spheroid));

        public static bool geog_intersects(IntPtr gs1, IntPtr gs2, bool use_spheroid)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geog_intersects(gs1, gs2, use_spheroid));

        public static bool geom_contains(IntPtr gs1, IntPtr gs2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geom_contains(gs1, gs2));

        public static bool geom_covers(IntPtr gs1, IntPtr gs2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geom_covers(gs1, gs2));

        public static bool geom_disjoint2d(IntPtr gs1, IntPtr gs2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geom_disjoint2d(gs1, gs2));

        public static bool geom_dwithin2d(IntPtr gs1, IntPtr gs2, double tolerance)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geom_dwithin2d(gs1, gs2, tolerance));

        public static bool geom_dwithin3d(IntPtr gs1, IntPtr gs2, double tolerance)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geom_dwithin3d(gs1, gs2, tolerance));

        public static bool geom_intersects2d(IntPtr gs1, IntPtr gs2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geom_intersects2d(gs1, gs2));

        public static bool geom_intersects3d(IntPtr gs1, IntPtr gs2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geom_intersects3d(gs1, gs2));

        public static bool geom_relate_pattern(IntPtr gs1, IntPtr gs2, string patt)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geom_relate_pattern(gs1, gs2, patt));

        public static bool geom_touches(IntPtr gs1, IntPtr gs2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geom_touches(gs1, gs2));

        public static IntPtr geo_stboxes(IntPtr gs, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_stboxes(gs, count));

        public static IntPtr geo_split_each_n_stboxes(IntPtr gs, int elem_count, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_split_each_n_stboxes(gs, elem_count, count));

        public static IntPtr geo_split_n_stboxes(IntPtr gs, int box_count, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_split_n_stboxes(gs, box_count, count));

        public static double geog_distance(IntPtr g1, IntPtr g2)
            => SafeExecution<double>(() => MEOSExternalFunctions.geog_distance(g1, g2));

        public static double geom_distance2d(IntPtr gs1, IntPtr gs2)
            => SafeExecution<double>(() => MEOSExternalFunctions.geom_distance2d(gs1, gs2));

        public static double geom_distance3d(IntPtr gs1, IntPtr gs2)
            => SafeExecution<double>(() => MEOSExternalFunctions.geom_distance3d(gs1, gs2));

        public static int geo_equals(IntPtr gs1, IntPtr gs2)
            => SafeExecution<int>(() => MEOSExternalFunctions.geo_equals(gs1, gs2));

        public static bool geo_same(IntPtr gs1, IntPtr gs2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geo_same(gs1, gs2));

        public static IntPtr geogset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geogset_in(str));

        public static IntPtr geomset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geomset_in(str));

        public static string spatialset_as_text(IntPtr set, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.spatialset_as_text(set, maxdd));

        public static string spatialset_as_ewkt(IntPtr set, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.spatialset_as_ewkt(set, maxdd));

        public static IntPtr geoset_make(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geoset_make(values, count));

        public static IntPtr geo_to_set(IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_to_set(gs));

        public static IntPtr geoset_end_value(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geoset_end_value(s));

        public static IntPtr geoset_start_value(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geoset_start_value(s));

        public static bool geoset_value_n(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geoset_value_n(s, n, result));

        public static IntPtr[] geoset_values(IntPtr s)
        {
            int _n = (int)MEOSExposedFunctions.set_num_values(s);
            IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.geoset_values(s));
            IntPtr[] _out = new IntPtr[_n];
            for (int _i = 0; _i < _n; _i++)
            { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
            return _out;
        }

        public static bool contained_geo_set(IntPtr gs, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_geo_set(gs, s));

        public static bool contains_set_geo(IntPtr s, IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_set_geo(s, gs));

        public static IntPtr geo_union_transfn(IntPtr state, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_union_transfn(state, gs));

        public static IntPtr intersection_geo_set(IntPtr gs, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_geo_set(gs, s));

        public static IntPtr intersection_set_geo(IntPtr s, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_set_geo(s, gs));

        public static IntPtr minus_geo_set(IntPtr gs, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_geo_set(gs, s));

        public static IntPtr minus_set_geo(IntPtr s, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_set_geo(s, gs));

        public static IntPtr union_geo_set(IntPtr gs, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_geo_set(gs, s));

        public static IntPtr union_set_geo(IntPtr s, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_set_geo(s, gs));

        public static IntPtr spatialset_set_srid(IntPtr s, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spatialset_set_srid(s, srid));

        public static int spatialset_srid(IntPtr s)
            => SafeExecution<int>(() => MEOSExternalFunctions.spatialset_srid(s));

        public static IntPtr spatialset_transform(IntPtr s, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spatialset_transform(s, srid));

        public static IntPtr spatialset_transform_pipeline(IntPtr s, string pipelinestr, int srid, bool is_forward)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spatialset_transform_pipeline(s, pipelinestr, srid, is_forward));

        public static string stbox_as_hexwkb(IntPtr box, IntPtr variant, IntPtr size)
            => SafeExecution<string>(() => MEOSExternalFunctions.stbox_as_hexwkb(box, variant, size));

        public static IntPtr stbox_as_wkb(IntPtr box, IntPtr variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_as_wkb(box, variant, size_out));

        public static IntPtr stbox_from_hexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_from_hexwkb(hexwkb));

        public static IntPtr stbox_from_wkb(IntPtr wkb, ulong size)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_from_wkb(wkb, size));

        public static IntPtr stbox_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_in(str));

        public static string stbox_out(IntPtr box, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.stbox_out(box, maxdd));

        public static IntPtr geo_timestamptz_to_stbox(IntPtr gs, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_timestamptz_to_stbox(gs, t));

        public static IntPtr geo_tstzspan_to_stbox(IntPtr gs, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_tstzspan_to_stbox(gs, s));

        public static IntPtr stbox_copy(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_copy(box));

        public static IntPtr stbox_make(bool hasx, bool hasz, bool geodetic, int srid, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_make(hasx, hasz, geodetic, srid, xmin, xmax, ymin, ymax, zmin, zmax, s));

        public static IntPtr geo_to_stbox(IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_to_stbox(gs));

        public static IntPtr spatialset_to_stbox(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spatialset_to_stbox(s));

        public static IntPtr stbox_to_box3d(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_to_box3d(box));

        public static IntPtr stbox_to_gbox(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_to_gbox(box));

        public static IntPtr stbox_to_geo(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_to_geo(box));

        public static IntPtr stbox_to_tstzspan(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_to_tstzspan(box));

        public static IntPtr timestamptz_to_stbox(long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.timestamptz_to_stbox(t));

        public static IntPtr tstzset_to_stbox(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzset_to_stbox(s));

        public static IntPtr tstzspan_to_stbox(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspan_to_stbox(s));

        public static IntPtr tstzspanset_to_stbox(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspanset_to_stbox(ss));

        public static double stbox_area(IntPtr box, bool spheroid)
            => SafeExecution<double>(() => MEOSExternalFunctions.stbox_area(box, spheroid));

        public static uint stbox_hash(IntPtr box)
            => SafeExecution<uint>(() => MEOSExternalFunctions.stbox_hash(box));

        public static ulong stbox_hash_extended(IntPtr box, ulong seed)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.stbox_hash_extended(box, seed));

        public static bool stbox_hast(IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_hast(box));

        public static bool stbox_hasx(IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_hasx(box));

        public static bool stbox_hasz(IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_hasz(box));

        public static bool stbox_isgeodetic(IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_isgeodetic(box));

        public static double stbox_perimeter(IntPtr box, bool spheroid)
            => SafeExecution<double>(() => MEOSExternalFunctions.stbox_perimeter(box, spheroid));

        public static bool stbox_tmax(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_tmax(box, result));

        public static bool stbox_tmax_inc(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_tmax_inc(box, result));

        public static bool stbox_tmin(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_tmin(box, result));

        public static bool stbox_tmin_inc(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_tmin_inc(box, result));

        public static double stbox_volume(IntPtr box)
            => SafeExecution<double>(() => MEOSExternalFunctions.stbox_volume(box));

        public static bool stbox_xmax(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_xmax(box, result));

        public static bool stbox_xmin(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_xmin(box, result));

        public static bool stbox_ymax(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_ymax(box, result));

        public static bool stbox_ymin(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_ymin(box, result));

        public static bool stbox_zmax(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_zmax(box, result));

        public static bool stbox_zmin(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_zmin(box, result));

        public static IntPtr stbox_expand_space(IntPtr box, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_expand_space(box, d));

        public static IntPtr stbox_expand_time(IntPtr box, IntPtr interv)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_expand_time(box, interv));

        public static IntPtr stbox_get_space(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_get_space(box));

        public static IntPtr stbox_quad_split(IntPtr box, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_quad_split(box, count));

        public static IntPtr stbox_round(IntPtr box, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_round(box, maxdd));

        public static IntPtr stbox_shift_scale_time(IntPtr box, IntPtr shift, IntPtr duration)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_shift_scale_time(box, shift, duration));

        public static IntPtr stboxarr_round(IntPtr boxarr, int count, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stboxarr_round(boxarr, count, maxdd));

        public static IntPtr stbox_set_srid(IntPtr box, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_set_srid(box, srid));

        public static int stbox_srid(IntPtr box)
            => SafeExecution<int>(() => MEOSExternalFunctions.stbox_srid(box));

        public static IntPtr stbox_transform(IntPtr box, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_transform(box, srid));

        public static IntPtr stbox_transform_pipeline(IntPtr box, string pipelinestr, int srid, bool is_forward)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_transform_pipeline(box, pipelinestr, srid, is_forward));

        public static bool adjacent_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_stbox_stbox(box1, box2));

        public static bool contained_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_stbox_stbox(box1, box2));

        public static bool contains_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_stbox_stbox(box1, box2));

        public static bool overlaps_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_stbox_stbox(box1, box2));

        public static bool same_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.same_stbox_stbox(box1, box2));

        public static bool above_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.above_stbox_stbox(box1, box2));

        public static bool after_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_stbox_stbox(box1, box2));

        public static bool back_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.back_stbox_stbox(box1, box2));

        public static bool before_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_stbox_stbox(box1, box2));

        public static bool below_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.below_stbox_stbox(box1, box2));

        public static bool front_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.front_stbox_stbox(box1, box2));

        public static bool left_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_stbox_stbox(box1, box2));

        public static bool overabove_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overabove_stbox_stbox(box1, box2));

        public static bool overafter_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_stbox_stbox(box1, box2));

        public static bool overback_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overback_stbox_stbox(box1, box2));

        public static bool overbefore_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_stbox_stbox(box1, box2));

        public static bool overbelow_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbelow_stbox_stbox(box1, box2));

        public static bool overfront_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overfront_stbox_stbox(box1, box2));

        public static bool overleft_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_stbox_stbox(box1, box2));

        public static bool overright_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_stbox_stbox(box1, box2));

        public static bool right_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_stbox_stbox(box1, box2));

        public static IntPtr union_stbox_stbox(IntPtr box1, IntPtr box2, bool strict)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_stbox_stbox(box1, box2, strict));

        public static IntPtr intersection_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_stbox_stbox(box1, box2));

        public static int stbox_cmp(IntPtr box1, IntPtr box2)
            => SafeExecution<int>(() => MEOSExternalFunctions.stbox_cmp(box1, box2));

        public static bool stbox_eq(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_eq(box1, box2));

        public static bool stbox_ge(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_ge(box1, box2));

        public static bool stbox_gt(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_gt(box1, box2));

        public static bool stbox_le(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_le(box1, box2));

        public static bool stbox_lt(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_lt(box1, box2));

        public static bool stbox_ne(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_ne(box1, box2));

        public static IntPtr tgeogpoint_from_mfjson(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeogpoint_from_mfjson(str));

        public static IntPtr tgeogpoint_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeogpoint_in(str));

        public static IntPtr tgeography_from_mfjson(string mfjson)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeography_from_mfjson(mfjson));

        public static IntPtr tgeography_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeography_in(str));

        public static IntPtr tgeometry_from_mfjson(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeometry_from_mfjson(str));

        public static IntPtr tgeometry_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeometry_in(str));

        public static IntPtr tgeompoint_from_mfjson(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeompoint_from_mfjson(str));

        public static IntPtr tgeompoint_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeompoint_in(str));

        public static string tspatial_as_ewkt(IntPtr temp, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.tspatial_as_ewkt(temp, maxdd));

        public static string tspatial_as_text(IntPtr temp, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.tspatial_as_text(temp, maxdd));

        public static string tspatial_out(IntPtr temp, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.tspatial_out(temp, maxdd));

        public static IntPtr tgeo_from_base_temp(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_from_base_temp(gs, temp));

        public static IntPtr tgeoinst_make(IntPtr gs, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeoinst_make(gs, t));

        public static IntPtr tgeoseq_from_base_tstzset(IntPtr gs, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeoseq_from_base_tstzset(gs, s));

        public static IntPtr tgeoseq_from_base_tstzspan(IntPtr gs, IntPtr s, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeoseq_from_base_tstzspan(gs, s, interp));

        public static IntPtr tgeoseqset_from_base_tstzspanset(IntPtr gs, IntPtr ss, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeoseqset_from_base_tstzspanset(gs, ss, interp));

        public static IntPtr tpoint_from_base_temp(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_from_base_temp(gs, temp));

        public static IntPtr tpointinst_make(IntPtr gs, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpointinst_make(gs, t));

        public static IntPtr tpointseq_from_base_tstzset(IntPtr gs, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpointseq_from_base_tstzset(gs, s));

        public static IntPtr tpointseq_from_base_tstzspan(IntPtr gs, IntPtr s, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpointseq_from_base_tstzspan(gs, s, interp));

        public static IntPtr tpointseq_make_coords(IntPtr xcoords, IntPtr ycoords, IntPtr zcoords, IntPtr times, int count, int srid, bool geodetic, bool lower_inc, bool upper_inc, int interp, bool normalize)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpointseq_make_coords(xcoords, ycoords, zcoords, times, count, srid, geodetic, lower_inc, upper_inc, interp, normalize));

        public static IntPtr tpointseqset_from_base_tstzspanset(IntPtr gs, IntPtr ss, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpointseqset_from_base_tstzspanset(gs, ss, interp));

        public static IntPtr box3d_to_stbox(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.box3d_to_stbox(box));

        public static IntPtr gbox_to_stbox(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.gbox_to_stbox(box));

        public static IntPtr geomeas_to_tpoint(IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geomeas_to_tpoint(gs));

        public static IntPtr tgeogpoint_to_tgeography(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeogpoint_to_tgeography(temp));

        public static IntPtr tgeography_to_tgeogpoint(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeography_to_tgeogpoint(temp));

        public static IntPtr tgeography_to_tgeometry(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeography_to_tgeometry(temp));

        public static IntPtr tgeometry_to_tgeography(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeometry_to_tgeography(temp));

        public static IntPtr tgeometry_to_tgeompoint(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeometry_to_tgeompoint(temp));

        public static IntPtr tgeompoint_to_tgeometry(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeompoint_to_tgeometry(temp));

        public static (IntPtr[], long[]) tpoint_as_mvtgeom(IntPtr temp, IntPtr bounds, int extent, int buffer, bool clip_geom)
        {
            IntPtr _out_gsarr = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _out_timesarr = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                SafeExecution<bool>(() => MEOSExternalFunctions.tpoint_as_mvtgeom(temp, bounds, extent, buffer, clip_geom, _out_gsarr, _out_timesarr, _count_count));
                int _n = Marshal.ReadInt32(_count_count);
                IntPtr __out_gsarr_arr = Marshal.ReadIntPtr(_out_gsarr);
                IntPtr[] __out_gsarr_out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { __out_gsarr_out[_i] = Marshal.ReadIntPtr(__out_gsarr_arr, _i * IntPtr.Size); }
                IntPtr __out_timesarr_arr = Marshal.ReadIntPtr(_out_timesarr);
                long[] __out_timesarr_out = new long[_n];
                Marshal.Copy(__out_timesarr_arr, __out_timesarr_out, 0, _n);
                return (__out_gsarr_out, __out_timesarr_out);
            }
            finally
            {
            Marshal.FreeHGlobal(_out_gsarr);
            Marshal.FreeHGlobal(_out_timesarr);
            Marshal.FreeHGlobal(_count_count);
            }
        }

        public static bool tpoint_tfloat_to_geomeas(IntPtr tpoint, IntPtr measure, bool segmentize, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpoint_tfloat_to_geomeas(tpoint, measure, segmentize, result));

        public static IntPtr tspatial_to_stbox(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tspatial_to_stbox(temp));

        public static bool bearing_point_point(IntPtr gs1, IntPtr gs2, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.bearing_point_point(gs1, gs2, result));

        public static IntPtr bearing_tpoint_point(IntPtr temp, IntPtr gs, bool invert)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bearing_tpoint_point(temp, gs, invert));

        public static IntPtr bearing_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bearing_tpoint_tpoint(temp1, temp2));

        public static IntPtr tgeo_centroid(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_centroid(temp));

        public static IntPtr tgeo_convex_hull(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_convex_hull(temp));

        public static IntPtr tgeo_end_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_end_value(temp));

        public static IntPtr tgeo_start_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_start_value(temp));

        public static IntPtr tgeo_traversed_area(IntPtr temp, bool unary_union)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_traversed_area(temp, unary_union));

        public static bool tgeo_value_at_timestamptz(IntPtr temp, long t, bool strict, IntPtr value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tgeo_value_at_timestamptz(temp, t, strict, value));

        public static bool tgeo_value_n(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tgeo_value_n(temp, n, result));

        public static IntPtr tgeo_values(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_values(temp, count));

        public static IntPtr tpoint_angular_difference(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_angular_difference(temp));

        public static IntPtr tpoint_azimuth(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_azimuth(temp));

        public static IntPtr tpoint_cumulative_length(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_cumulative_length(temp));

        public static bool tpoint_direction(IntPtr temp, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpoint_direction(temp, result));

        public static IntPtr tpoint_get_x(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_get_x(temp));

        public static IntPtr tpoint_get_y(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_get_y(temp));

        public static IntPtr tpoint_get_z(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_get_z(temp));

        public static bool tpoint_is_simple(IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpoint_is_simple(temp));

        public static double tpoint_length(IntPtr temp)
            => SafeExecution<double>(() => MEOSExternalFunctions.tpoint_length(temp));

        public static IntPtr tpoint_speed(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_speed(temp));

        public static IntPtr tpoint_trajectory(IntPtr temp, bool unary_union)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_trajectory(temp, unary_union));

        public static IntPtr tpoint_twcentroid(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_twcentroid(temp));

        public static IntPtr tgeo_affine(IntPtr temp, IntPtr a)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_affine(temp, a));

        public static IntPtr tgeo_scale(IntPtr temp, IntPtr scale, IntPtr sorigin)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_scale(temp, scale, sorigin));

        public static IntPtr tpoint_make_simple(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_make_simple(temp, count));

        public static int tspatial_srid(IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.tspatial_srid(temp));

        public static IntPtr tspatial_set_srid(IntPtr temp, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tspatial_set_srid(temp, srid));

        public static IntPtr tspatial_transform(IntPtr temp, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tspatial_transform(temp, srid));

        public static IntPtr tspatial_transform_pipeline(IntPtr temp, string pipelinestr, int srid, bool is_forward)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tspatial_transform_pipeline(temp, pipelinestr, srid, is_forward));

        public static IntPtr tgeo_at_geom(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_at_geom(temp, gs));

        public static IntPtr tgeo_at_stbox(IntPtr temp, IntPtr box, bool border_inc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_at_stbox(temp, box, border_inc));

        public static IntPtr tgeo_at_value(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_at_value(temp, gs));

        public static IntPtr tgeo_minus_geom(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_minus_geom(temp, gs));

        public static IntPtr tgeo_minus_stbox(IntPtr temp, IntPtr box, bool border_inc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_minus_stbox(temp, box, border_inc));

        public static IntPtr tgeo_minus_value(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_minus_value(temp, gs));

        public static IntPtr tpoint_at_elevation(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_at_elevation(temp, s));

        public static IntPtr tpoint_at_geom(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_at_geom(temp, gs));

        public static IntPtr tpoint_at_value(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_at_value(temp, gs));

        public static IntPtr tpoint_minus_elevation(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_minus_elevation(temp, s));

        public static IntPtr tpoint_minus_geom(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_minus_geom(temp, gs));

        public static IntPtr tpoint_minus_value(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_minus_value(temp, gs));

        public static int always_eq_geo_tgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_geo_tgeo(gs, temp));

        public static int always_eq_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_tgeo_geo(temp, gs));

        public static int always_eq_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_tgeo_tgeo(temp1, temp2));

        public static int always_ne_geo_tgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_geo_tgeo(gs, temp));

        public static int always_ne_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_tgeo_geo(temp, gs));

        public static int always_ne_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_tgeo_tgeo(temp1, temp2));

        public static int ever_eq_geo_tgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_geo_tgeo(gs, temp));

        public static int ever_eq_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_tgeo_geo(temp, gs));

        public static int ever_eq_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_tgeo_tgeo(temp1, temp2));

        public static int ever_ne_geo_tgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_geo_tgeo(gs, temp));

        public static int ever_ne_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_tgeo_geo(temp, gs));

        public static int ever_ne_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_tgeo_tgeo(temp1, temp2));

        public static IntPtr teq_geo_tgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_geo_tgeo(gs, temp));

        public static IntPtr teq_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_tgeo_geo(temp, gs));

        public static IntPtr tne_geo_tgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_geo_tgeo(gs, temp));

        public static IntPtr tne_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_tgeo_geo(temp, gs));

        public static IntPtr tgeo_stboxes(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_stboxes(temp, count));

        public static IntPtr tgeo_space_boxes(IntPtr temp, double xsize, double ysize, double zsize, IntPtr sorigin, bool bitmatrix, bool border_inc, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_space_boxes(temp, xsize, ysize, zsize, sorigin, bitmatrix, border_inc, count));

        public static IntPtr tgeo_space_time_boxes(IntPtr temp, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, long torigin, bool bitmatrix, bool border_inc, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_space_time_boxes(temp, xsize, ysize, zsize, duration, sorigin, torigin, bitmatrix, border_inc, count));

        public static IntPtr tgeo_split_each_n_stboxes(IntPtr temp, int elem_count, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_split_each_n_stboxes(temp, elem_count, count));

        public static IntPtr tgeo_split_n_stboxes(IntPtr temp, int box_count, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_split_n_stboxes(temp, box_count, count));

        public static bool adjacent_stbox_tspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_stbox_tspatial(box, temp));

        public static bool adjacent_tspatial_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_tspatial_stbox(temp, box));

        public static bool adjacent_tspatial_tspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_tspatial_tspatial(temp1, temp2));

        public static bool contained_stbox_tspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_stbox_tspatial(box, temp));

        public static bool contained_tspatial_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_tspatial_stbox(temp, box));

        public static bool contained_tspatial_tspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_tspatial_tspatial(temp1, temp2));

        public static bool contains_stbox_tspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_stbox_tspatial(box, temp));

        public static bool contains_tspatial_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_tspatial_stbox(temp, box));

        public static bool contains_tspatial_tspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_tspatial_tspatial(temp1, temp2));

        public static bool overlaps_stbox_tspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_stbox_tspatial(box, temp));

        public static bool overlaps_tspatial_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_tspatial_stbox(temp, box));

        public static bool overlaps_tspatial_tspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_tspatial_tspatial(temp1, temp2));

        public static bool same_stbox_tspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.same_stbox_tspatial(box, temp));

        public static bool same_tspatial_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.same_tspatial_stbox(temp, box));

        public static bool same_tspatial_tspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.same_tspatial_tspatial(temp1, temp2));

        public static bool above_stbox_tspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.above_stbox_tspatial(box, temp));

        public static bool above_tspatial_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.above_tspatial_stbox(temp, box));

        public static bool above_tspatial_tspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.above_tspatial_tspatial(temp1, temp2));

        public static bool after_stbox_tspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_stbox_tspatial(box, temp));

        public static bool after_tspatial_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_tspatial_stbox(temp, box));

        public static bool after_tspatial_tspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_tspatial_tspatial(temp1, temp2));

        public static bool back_stbox_tspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.back_stbox_tspatial(box, temp));

        public static bool back_tspatial_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.back_tspatial_stbox(temp, box));

        public static bool back_tspatial_tspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.back_tspatial_tspatial(temp1, temp2));

        public static bool before_stbox_tspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_stbox_tspatial(box, temp));

        public static bool before_tspatial_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_tspatial_stbox(temp, box));

        public static bool before_tspatial_tspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_tspatial_tspatial(temp1, temp2));

        public static bool below_stbox_tspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.below_stbox_tspatial(box, temp));

        public static bool below_tspatial_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.below_tspatial_stbox(temp, box));

        public static bool below_tspatial_tspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.below_tspatial_tspatial(temp1, temp2));

        public static bool front_stbox_tspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.front_stbox_tspatial(box, temp));

        public static bool front_tspatial_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.front_tspatial_stbox(temp, box));

        public static bool front_tspatial_tspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.front_tspatial_tspatial(temp1, temp2));

        public static bool left_stbox_tspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_stbox_tspatial(box, temp));

        public static bool left_tspatial_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_tspatial_stbox(temp, box));

        public static bool left_tspatial_tspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_tspatial_tspatial(temp1, temp2));

        public static bool overabove_stbox_tspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overabove_stbox_tspatial(box, temp));

        public static bool overabove_tspatial_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overabove_tspatial_stbox(temp, box));

        public static bool overabove_tspatial_tspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overabove_tspatial_tspatial(temp1, temp2));

        public static bool overafter_stbox_tspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_stbox_tspatial(box, temp));

        public static bool overafter_tspatial_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_tspatial_stbox(temp, box));

        public static bool overafter_tspatial_tspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_tspatial_tspatial(temp1, temp2));

        public static bool overback_stbox_tspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overback_stbox_tspatial(box, temp));

        public static bool overback_tspatial_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overback_tspatial_stbox(temp, box));

        public static bool overback_tspatial_tspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overback_tspatial_tspatial(temp1, temp2));

        public static bool overbefore_stbox_tspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_stbox_tspatial(box, temp));

        public static bool overbefore_tspatial_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_tspatial_stbox(temp, box));

        public static bool overbefore_tspatial_tspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_tspatial_tspatial(temp1, temp2));

        public static bool overbelow_stbox_tspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbelow_stbox_tspatial(box, temp));

        public static bool overbelow_tspatial_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbelow_tspatial_stbox(temp, box));

        public static bool overbelow_tspatial_tspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbelow_tspatial_tspatial(temp1, temp2));

        public static bool overfront_stbox_tspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overfront_stbox_tspatial(box, temp));

        public static bool overfront_tspatial_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overfront_tspatial_stbox(temp, box));

        public static bool overfront_tspatial_tspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overfront_tspatial_tspatial(temp1, temp2));

        public static bool overleft_stbox_tspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_stbox_tspatial(box, temp));

        public static bool overleft_tspatial_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_tspatial_stbox(temp, box));

        public static bool overleft_tspatial_tspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_tspatial_tspatial(temp1, temp2));

        public static bool overright_stbox_tspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_stbox_tspatial(box, temp));

        public static bool overright_tspatial_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_tspatial_stbox(temp, box));

        public static bool overright_tspatial_tspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_tspatial_tspatial(temp1, temp2));

        public static bool right_stbox_tspatial(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_stbox_tspatial(box, temp));

        public static bool right_tspatial_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_tspatial_stbox(temp, box));

        public static bool right_tspatial_tspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_tspatial_tspatial(temp1, temp2));

        public static int acontains_geo_tgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.acontains_geo_tgeo(gs, temp));

        public static int acontains_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.acontains_tgeo_geo(temp, gs));

        public static int acontains_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.acontains_tgeo_tgeo(temp1, temp2));

        public static int adisjoint_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.adisjoint_tgeo_geo(temp, gs));

        public static int adisjoint_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.adisjoint_tgeo_tgeo(temp1, temp2));

        public static int adwithin_tgeo_geo(IntPtr temp, IntPtr gs, double dist)
            => SafeExecution<int>(() => MEOSExternalFunctions.adwithin_tgeo_geo(temp, gs, dist));

        public static int adwithin_tgeo_tgeo(IntPtr temp1, IntPtr temp2, double dist)
            => SafeExecution<int>(() => MEOSExternalFunctions.adwithin_tgeo_tgeo(temp1, temp2, dist));

        public static int aintersects_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.aintersects_tgeo_geo(temp, gs));

        public static int aintersects_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.aintersects_tgeo_tgeo(temp1, temp2));

        public static int atouches_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.atouches_tgeo_geo(temp, gs));

        public static int atouches_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.atouches_tgeo_tgeo(temp1, temp2));

        public static int atouches_tpoint_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.atouches_tpoint_geo(temp, gs));

        public static int econtains_geo_tgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.econtains_geo_tgeo(gs, temp));

        public static int econtains_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.econtains_tgeo_geo(temp, gs));

        public static int econtains_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.econtains_tgeo_tgeo(temp1, temp2));

        public static int ecovers_geo_tgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ecovers_geo_tgeo(gs, temp));

        public static int ecovers_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.ecovers_tgeo_geo(temp, gs));

        public static int ecovers_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.ecovers_tgeo_tgeo(temp1, temp2));

        public static int edisjoint_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.edisjoint_tgeo_geo(temp, gs));

        public static int edisjoint_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.edisjoint_tgeo_tgeo(temp1, temp2));

        public static int edwithin_tgeo_geo(IntPtr temp, IntPtr gs, double dist)
            => SafeExecution<int>(() => MEOSExternalFunctions.edwithin_tgeo_geo(temp, gs, dist));

        public static int edwithin_tgeo_tgeo(IntPtr temp1, IntPtr temp2, double dist)
            => SafeExecution<int>(() => MEOSExternalFunctions.edwithin_tgeo_tgeo(temp1, temp2, dist));

        public static int eintersects_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.eintersects_tgeo_geo(temp, gs));

        public static int eintersects_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.eintersects_tgeo_tgeo(temp1, temp2));

        public static int etouches_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.etouches_tgeo_geo(temp, gs));

        public static int etouches_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.etouches_tgeo_tgeo(temp1, temp2));

        public static int etouches_tpoint_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.etouches_tpoint_geo(temp, gs));

        public static IntPtr tcontains_geo_tgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcontains_geo_tgeo(gs, temp));

        public static IntPtr tcontains_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcontains_tgeo_geo(temp, gs));

        public static IntPtr tcontains_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcontains_tgeo_tgeo(temp1, temp2));

        public static IntPtr tcovers_geo_tgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcovers_geo_tgeo(gs, temp));

        public static IntPtr tcovers_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcovers_tgeo_geo(temp, gs));

        public static IntPtr tcovers_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcovers_tgeo_tgeo(temp1, temp2));

        public static IntPtr tdisjoint_geo_tgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdisjoint_geo_tgeo(gs, temp));

        public static IntPtr tdisjoint_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdisjoint_tgeo_geo(temp, gs));

        public static IntPtr tdisjoint_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdisjoint_tgeo_tgeo(temp1, temp2));

        public static IntPtr tdwithin_geo_tgeo(IntPtr gs, IntPtr temp, double dist)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdwithin_geo_tgeo(gs, temp, dist));

        public static IntPtr tdwithin_tgeo_geo(IntPtr temp, IntPtr gs, double dist)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdwithin_tgeo_geo(temp, gs, dist));

        public static IntPtr tdwithin_tgeo_tgeo(IntPtr temp1, IntPtr temp2, double dist)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdwithin_tgeo_tgeo(temp1, temp2, dist));

        public static IntPtr tintersects_geo_tgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintersects_geo_tgeo(gs, temp));

        public static IntPtr tintersects_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintersects_tgeo_geo(temp, gs));

        public static IntPtr tintersects_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintersects_tgeo_tgeo(temp1, temp2));

        public static IntPtr ttouches_geo_tgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttouches_geo_tgeo(gs, temp));

        public static IntPtr ttouches_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttouches_tgeo_geo(temp, gs));

        public static IntPtr ttouches_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttouches_tgeo_tgeo(temp1, temp2));

        public static IntPtr tdistance_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdistance_tgeo_geo(temp, gs));

        public static IntPtr tdistance_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdistance_tgeo_tgeo(temp1, temp2));

        public static double nad_stbox_geo(IntPtr box, IntPtr gs)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_stbox_geo(box, gs));

        public static double nad_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_stbox_stbox(box1, box2));

        public static double nad_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tgeo_geo(temp, gs));

        public static double nad_tgeo_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tgeo_stbox(temp, box));

        public static double nad_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tgeo_tgeo(temp1, temp2));

        public static IntPtr nai_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nai_tgeo_geo(temp, gs));

        public static IntPtr nai_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nai_tgeo_tgeo(temp1, temp2));

        public static IntPtr shortestline_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.shortestline_tgeo_geo(temp, gs));

        public static IntPtr shortestline_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.shortestline_tgeo_tgeo(temp1, temp2));

        public static IntPtr tpoint_tcentroid_finalfn(IntPtr state)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_tcentroid_finalfn(state));

        public static IntPtr tpoint_tcentroid_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_tcentroid_transfn(state, temp));

        public static IntPtr tspatial_extent_transfn(IntPtr box, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tspatial_extent_transfn(box, temp));

        public static IntPtr stbox_get_space_tile(IntPtr point, double xsize, double ysize, double zsize, IntPtr sorigin)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_get_space_tile(point, xsize, ysize, zsize, sorigin));

        public static IntPtr stbox_get_space_time_tile(IntPtr point, long t, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, long torigin)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_get_space_time_tile(point, t, xsize, ysize, zsize, duration, sorigin, torigin));

        public static IntPtr stbox_get_time_tile(long t, IntPtr duration, long torigin)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_get_time_tile(t, duration, torigin));

        public static IntPtr stbox_space_tiles(IntPtr bounds, double xsize, double ysize, double zsize, IntPtr sorigin, bool border_inc, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_space_tiles(bounds, xsize, ysize, zsize, sorigin, border_inc, count));

        public static IntPtr stbox_space_time_tiles(IntPtr bounds, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, long torigin, bool border_inc, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_space_time_tiles(bounds, xsize, ysize, zsize, duration, sorigin, torigin, border_inc, count));

        public static IntPtr stbox_time_tiles(IntPtr bounds, IntPtr duration, long torigin, bool border_inc, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_time_tiles(bounds, duration, torigin, border_inc, count));

        public static (IntPtr[], IntPtr[]) tgeo_space_split(IntPtr temp, double xsize, double ysize, double zsize, IntPtr sorigin, bool bitmatrix, bool border_inc)
        {
            IntPtr _out_space_bins = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_space_split(temp, xsize, ysize, zsize, sorigin, bitmatrix, border_inc, _out_space_bins, _count_count));
                int _n = Marshal.ReadInt32(_count_count);
                IntPtr[] _resultArr = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _resultArr[_i] = Marshal.ReadIntPtr(_resultPtr, _i * IntPtr.Size); }
                IntPtr __out_space_bins_arr = Marshal.ReadIntPtr(_out_space_bins);
                IntPtr[] __out_space_bins_out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { __out_space_bins_out[_i] = Marshal.ReadIntPtr(__out_space_bins_arr, _i * IntPtr.Size); }
                return (_resultArr, __out_space_bins_out);
            }
            finally
            {
            Marshal.FreeHGlobal(_out_space_bins);
            Marshal.FreeHGlobal(_count_count);
            }
        }

        public static (IntPtr[], IntPtr[], long[]) tgeo_space_time_split(IntPtr temp, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, long torigin, bool bitmatrix, bool border_inc)
        {
            IntPtr _out_space_bins = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _out_time_bins = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_space_time_split(temp, xsize, ysize, zsize, duration, sorigin, torigin, bitmatrix, border_inc, _out_space_bins, _out_time_bins, _count_count));
                int _n = Marshal.ReadInt32(_count_count);
                IntPtr[] _resultArr = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _resultArr[_i] = Marshal.ReadIntPtr(_resultPtr, _i * IntPtr.Size); }
                IntPtr __out_space_bins_arr = Marshal.ReadIntPtr(_out_space_bins);
                IntPtr[] __out_space_bins_out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { __out_space_bins_out[_i] = Marshal.ReadIntPtr(__out_space_bins_arr, _i * IntPtr.Size); }
                IntPtr __out_time_bins_arr = Marshal.ReadIntPtr(_out_time_bins);
                long[] __out_time_bins_out = new long[_n];
                Marshal.Copy(__out_time_bins_arr, __out_time_bins_out, 0, _n);
                return (_resultArr, __out_space_bins_out, __out_time_bins_out);
            }
            finally
            {
            Marshal.FreeHGlobal(_out_space_bins);
            Marshal.FreeHGlobal(_out_time_bins);
            Marshal.FreeHGlobal(_count_count);
            }
        }

        public static IntPtr geo_cluster_kmeans(IntPtr geoms, uint ngeoms, uint k)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_cluster_kmeans(geoms, ngeoms, k));

        public static IntPtr geo_cluster_dbscan(IntPtr geoms, uint ngeoms, double tolerance, int minpoints, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_cluster_dbscan(geoms, ngeoms, tolerance, minpoints, count));

        public static IntPtr geo_cluster_intersecting(IntPtr geoms, uint ngeoms, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_cluster_intersecting(geoms, ngeoms, count));

        public static IntPtr geo_cluster_within(IntPtr geoms, uint ngeoms, double tolerance, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_cluster_within(geoms, ngeoms, tolerance, count));

        public static string cbuffer_as_ewkt(IntPtr cb, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.cbuffer_as_ewkt(cb, maxdd));

        public static string cbuffer_as_hexwkb(IntPtr cb, IntPtr variant, IntPtr size)
            => SafeExecution<string>(() => MEOSExternalFunctions.cbuffer_as_hexwkb(cb, variant, size));

        public static string cbuffer_as_text(IntPtr cb, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.cbuffer_as_text(cb, maxdd));

        public static IntPtr cbuffer_as_wkb(IntPtr cb, IntPtr variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbuffer_as_wkb(cb, variant, size_out));

        public static IntPtr cbuffer_from_hexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbuffer_from_hexwkb(hexwkb));

        public static IntPtr cbuffer_from_wkb(IntPtr wkb, ulong size)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbuffer_from_wkb(wkb, size));

        public static IntPtr cbuffer_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbuffer_in(str));

        public static string cbuffer_out(IntPtr cb, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.cbuffer_out(cb, maxdd));

        public static IntPtr cbuffer_copy(IntPtr cb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbuffer_copy(cb));

        public static IntPtr cbuffer_make(IntPtr point, double radius)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbuffer_make(point, radius));

        public static IntPtr cbuffer_to_geom(IntPtr cb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbuffer_to_geom(cb));

        public static IntPtr cbuffer_to_stbox(IntPtr cb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbuffer_to_stbox(cb));

        public static IntPtr cbufferarr_to_geom(IntPtr cbarr, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbufferarr_to_geom(cbarr, count));

        public static IntPtr geom_to_cbuffer(IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geom_to_cbuffer(gs));

        public static uint cbuffer_hash(IntPtr cb)
            => SafeExecution<uint>(() => MEOSExternalFunctions.cbuffer_hash(cb));

        public static ulong cbuffer_hash_extended(IntPtr cb, ulong seed)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.cbuffer_hash_extended(cb, seed));

        public static IntPtr cbuffer_point(IntPtr cb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbuffer_point(cb));

        public static double cbuffer_radius(IntPtr cb)
            => SafeExecution<double>(() => MEOSExternalFunctions.cbuffer_radius(cb));

        public static IntPtr cbuffer_round(IntPtr cb, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbuffer_round(cb, maxdd));

        public static IntPtr cbufferarr_round(IntPtr cbarr, int count, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbufferarr_round(cbarr, count, maxdd));

        public static void cbuffer_set_srid(IntPtr cb, int srid)
            => SafeExecution(() => MEOSExternalFunctions.cbuffer_set_srid(cb, srid));

        public static int cbuffer_srid(IntPtr cb)
            => SafeExecution<int>(() => MEOSExternalFunctions.cbuffer_srid(cb));

        public static IntPtr cbuffer_transform(IntPtr cb, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbuffer_transform(cb, srid));

        public static IntPtr cbuffer_transform_pipeline(IntPtr cb, string pipelinestr, int srid, bool is_forward)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbuffer_transform_pipeline(cb, pipelinestr, srid, is_forward));

        public static int contains_cbuffer_cbuffer(IntPtr cb1, IntPtr cb2)
            => SafeExecution<int>(() => MEOSExternalFunctions.contains_cbuffer_cbuffer(cb1, cb2));

        public static int covers_cbuffer_cbuffer(IntPtr cb1, IntPtr cb2)
            => SafeExecution<int>(() => MEOSExternalFunctions.covers_cbuffer_cbuffer(cb1, cb2));

        public static int disjoint_cbuffer_cbuffer(IntPtr cb1, IntPtr cb2)
            => SafeExecution<int>(() => MEOSExternalFunctions.disjoint_cbuffer_cbuffer(cb1, cb2));

        public static int dwithin_cbuffer_cbuffer(IntPtr cb1, IntPtr cb2, double dist)
            => SafeExecution<int>(() => MEOSExternalFunctions.dwithin_cbuffer_cbuffer(cb1, cb2, dist));

        public static int intersects_cbuffer_cbuffer(IntPtr cb1, IntPtr cb2)
            => SafeExecution<int>(() => MEOSExternalFunctions.intersects_cbuffer_cbuffer(cb1, cb2));

        public static int touches_cbuffer_cbuffer(IntPtr cb1, IntPtr cb2)
            => SafeExecution<int>(() => MEOSExternalFunctions.touches_cbuffer_cbuffer(cb1, cb2));

        public static IntPtr cbuffer_tstzspan_to_stbox(IntPtr cb, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbuffer_tstzspan_to_stbox(cb, s));

        public static IntPtr cbuffer_timestamptz_to_stbox(IntPtr cb, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbuffer_timestamptz_to_stbox(cb, t));

        public static double distance_cbuffer_cbuffer(IntPtr cb1, IntPtr cb2)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_cbuffer_cbuffer(cb1, cb2));

        public static double distance_cbuffer_geo(IntPtr cb, IntPtr gs)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_cbuffer_geo(cb, gs));

        public static double distance_cbuffer_stbox(IntPtr cb, IntPtr box)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_cbuffer_stbox(cb, box));

        public static double nad_cbuffer_stbox(IntPtr cb, IntPtr box)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_cbuffer_stbox(cb, box));

        public static int cbuffer_cmp(IntPtr cb1, IntPtr cb2)
            => SafeExecution<int>(() => MEOSExternalFunctions.cbuffer_cmp(cb1, cb2));

        public static bool cbuffer_eq(IntPtr cb1, IntPtr cb2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.cbuffer_eq(cb1, cb2));

        public static bool cbuffer_ge(IntPtr cb1, IntPtr cb2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.cbuffer_ge(cb1, cb2));

        public static bool cbuffer_gt(IntPtr cb1, IntPtr cb2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.cbuffer_gt(cb1, cb2));

        public static bool cbuffer_le(IntPtr cb1, IntPtr cb2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.cbuffer_le(cb1, cb2));

        public static bool cbuffer_lt(IntPtr cb1, IntPtr cb2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.cbuffer_lt(cb1, cb2));

        public static bool cbuffer_ne(IntPtr cb1, IntPtr cb2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.cbuffer_ne(cb1, cb2));

        public static bool cbuffer_nsame(IntPtr cb1, IntPtr cb2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.cbuffer_nsame(cb1, cb2));

        public static bool cbuffer_same(IntPtr cb1, IntPtr cb2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.cbuffer_same(cb1, cb2));

        public static IntPtr cbufferset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbufferset_in(str));

        public static string cbufferset_out(IntPtr s, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.cbufferset_out(s, maxdd));

        public static IntPtr cbufferset_make(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbufferset_make(values, count));

        public static IntPtr cbuffer_to_set(IntPtr cb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbuffer_to_set(cb));

        public static IntPtr cbufferset_end_value(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbufferset_end_value(s));

        public static IntPtr cbufferset_start_value(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbufferset_start_value(s));

        public static bool cbufferset_value_n(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.cbufferset_value_n(s, n, result));

        public static IntPtr[] cbufferset_values(IntPtr s)
        {
            int _n = (int)MEOSExposedFunctions.set_num_values(s);
            IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbufferset_values(s));
            IntPtr[] _out = new IntPtr[_n];
            for (int _i = 0; _i < _n; _i++)
            { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
            return _out;
        }

        public static IntPtr cbuffer_union_transfn(IntPtr state, IntPtr cb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbuffer_union_transfn(state, cb));

        public static bool contained_cbuffer_set(IntPtr cb, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_cbuffer_set(cb, s));

        public static bool contains_set_cbuffer(IntPtr s, IntPtr cb)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_set_cbuffer(s, cb));

        public static IntPtr intersection_cbuffer_set(IntPtr cb, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_cbuffer_set(cb, s));

        public static IntPtr intersection_set_cbuffer(IntPtr s, IntPtr cb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_set_cbuffer(s, cb));

        public static IntPtr minus_cbuffer_set(IntPtr cb, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_cbuffer_set(cb, s));

        public static IntPtr minus_set_cbuffer(IntPtr s, IntPtr cb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_set_cbuffer(s, cb));

        public static IntPtr union_cbuffer_set(IntPtr cb, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_cbuffer_set(cb, s));

        public static IntPtr union_set_cbuffer(IntPtr s, IntPtr cb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_set_cbuffer(s, cb));

        public static IntPtr tcbuffer_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffer_in(str));

        public static IntPtr tcbuffer_make(IntPtr tpoint, IntPtr tfloat)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffer_make(tpoint, tfloat));

        public static IntPtr tcbuffer_points(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffer_points(temp));

        public static IntPtr tcbuffer_radius(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffer_radius(temp));

        public static IntPtr tcbuffer_trav_area(IntPtr temp, bool merge_union)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffer_trav_area(temp, merge_union));

        public static IntPtr tcbuffer_to_tfloat(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffer_to_tfloat(temp));

        public static IntPtr tcbuffer_to_tgeompoint(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffer_to_tgeompoint(temp));

        public static IntPtr tgeometry_to_tcbuffer(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeometry_to_tcbuffer(temp));

        public static IntPtr tcbuffer_expand(IntPtr temp, double dist)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffer_expand(temp, dist));

        public static IntPtr tcbuffer_at_cbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffer_at_cbuffer(temp, cb));

        public static IntPtr tcbuffer_at_geom(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffer_at_geom(temp, gs));

        public static IntPtr tcbuffer_at_stbox(IntPtr temp, IntPtr box, bool border_inc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffer_at_stbox(temp, box, border_inc));

        public static IntPtr tcbuffer_minus_cbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffer_minus_cbuffer(temp, cb));

        public static IntPtr tcbuffer_minus_geom(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffer_minus_geom(temp, gs));

        public static IntPtr tcbuffer_minus_stbox(IntPtr temp, IntPtr box, bool border_inc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffer_minus_stbox(temp, box, border_inc));

        public static IntPtr tdistance_tcbuffer_cbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdistance_tcbuffer_cbuffer(temp, cb));

        public static IntPtr tdistance_tcbuffer_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdistance_tcbuffer_geo(temp, gs));

        public static IntPtr tdistance_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdistance_tcbuffer_tcbuffer(temp1, temp2));

        public static double nad_tcbuffer_cbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tcbuffer_cbuffer(temp, cb));

        public static double nad_tcbuffer_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tcbuffer_geo(temp, gs));

        public static double nad_tcbuffer_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tcbuffer_stbox(temp, box));

        public static double nad_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tcbuffer_tcbuffer(temp1, temp2));

        public static IntPtr nai_tcbuffer_cbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nai_tcbuffer_cbuffer(temp, cb));

        public static IntPtr nai_tcbuffer_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nai_tcbuffer_geo(temp, gs));

        public static IntPtr nai_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nai_tcbuffer_tcbuffer(temp1, temp2));

        public static IntPtr shortestline_tcbuffer_cbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.shortestline_tcbuffer_cbuffer(temp, cb));

        public static IntPtr shortestline_tcbuffer_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.shortestline_tcbuffer_geo(temp, gs));

        public static IntPtr shortestline_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.shortestline_tcbuffer_tcbuffer(temp1, temp2));

        public static int always_eq_cbuffer_tcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_cbuffer_tcbuffer(cb, temp));

        public static int always_eq_tcbuffer_cbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_tcbuffer_cbuffer(temp, cb));

        public static int always_eq_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_tcbuffer_tcbuffer(temp1, temp2));

        public static int always_ne_cbuffer_tcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_cbuffer_tcbuffer(cb, temp));

        public static int always_ne_tcbuffer_cbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_tcbuffer_cbuffer(temp, cb));

        public static int always_ne_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_tcbuffer_tcbuffer(temp1, temp2));

        public static int ever_eq_cbuffer_tcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_cbuffer_tcbuffer(cb, temp));

        public static int ever_eq_tcbuffer_cbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_tcbuffer_cbuffer(temp, cb));

        public static int ever_eq_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_tcbuffer_tcbuffer(temp1, temp2));

        public static int ever_ne_cbuffer_tcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_cbuffer_tcbuffer(cb, temp));

        public static int ever_ne_tcbuffer_cbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_tcbuffer_cbuffer(temp, cb));

        public static int ever_ne_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_tcbuffer_tcbuffer(temp1, temp2));

        public static IntPtr teq_cbuffer_tcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_cbuffer_tcbuffer(cb, temp));

        public static IntPtr teq_tcbuffer_cbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_tcbuffer_cbuffer(temp, cb));

        public static IntPtr tne_cbuffer_tcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_cbuffer_tcbuffer(cb, temp));

        public static IntPtr tne_tcbuffer_cbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_tcbuffer_cbuffer(temp, cb));

        public static int acontains_cbuffer_tcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.acontains_cbuffer_tcbuffer(cb, temp));

        public static int acontains_geo_tcbuffer(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.acontains_geo_tcbuffer(gs, temp));

        public static int acontains_tcbuffer_cbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<int>(() => MEOSExternalFunctions.acontains_tcbuffer_cbuffer(temp, cb));

        public static int acontains_tcbuffer_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.acontains_tcbuffer_geo(temp, gs));

        public static int acovers_cbuffer_tcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.acovers_cbuffer_tcbuffer(cb, temp));

        public static int acovers_geo_tcbuffer(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.acovers_geo_tcbuffer(gs, temp));

        public static int acovers_tcbuffer_cbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<int>(() => MEOSExternalFunctions.acovers_tcbuffer_cbuffer(temp, cb));

        public static int acovers_tcbuffer_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.acovers_tcbuffer_geo(temp, gs));

        public static int adisjoint_tcbuffer_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.adisjoint_tcbuffer_geo(temp, gs));

        public static int adisjoint_tcbuffer_cbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<int>(() => MEOSExternalFunctions.adisjoint_tcbuffer_cbuffer(temp, cb));

        public static int adisjoint_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.adisjoint_tcbuffer_tcbuffer(temp1, temp2));

        public static int adwithin_tcbuffer_geo(IntPtr temp, IntPtr gs, double dist)
            => SafeExecution<int>(() => MEOSExternalFunctions.adwithin_tcbuffer_geo(temp, gs, dist));

        public static int adwithin_tcbuffer_cbuffer(IntPtr temp, IntPtr cb, double dist)
            => SafeExecution<int>(() => MEOSExternalFunctions.adwithin_tcbuffer_cbuffer(temp, cb, dist));

        public static int adwithin_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2, double dist)
            => SafeExecution<int>(() => MEOSExternalFunctions.adwithin_tcbuffer_tcbuffer(temp1, temp2, dist));

        public static int aintersects_tcbuffer_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.aintersects_tcbuffer_geo(temp, gs));

        public static int aintersects_tcbuffer_cbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<int>(() => MEOSExternalFunctions.aintersects_tcbuffer_cbuffer(temp, cb));

        public static int aintersects_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.aintersects_tcbuffer_tcbuffer(temp1, temp2));

        public static int atouches_tcbuffer_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.atouches_tcbuffer_geo(temp, gs));

        public static int atouches_tcbuffer_cbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<int>(() => MEOSExternalFunctions.atouches_tcbuffer_cbuffer(temp, cb));

        public static int atouches_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.atouches_tcbuffer_tcbuffer(temp1, temp2));

        public static int econtains_cbuffer_tcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.econtains_cbuffer_tcbuffer(cb, temp));

        public static int econtains_tcbuffer_cbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<int>(() => MEOSExternalFunctions.econtains_tcbuffer_cbuffer(temp, cb));

        public static int econtains_tcbuffer_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.econtains_tcbuffer_geo(temp, gs));

        public static int ecovers_cbuffer_tcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ecovers_cbuffer_tcbuffer(cb, temp));

        public static int ecovers_tcbuffer_cbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<int>(() => MEOSExternalFunctions.ecovers_tcbuffer_cbuffer(temp, cb));

        public static int ecovers_tcbuffer_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.ecovers_tcbuffer_geo(temp, gs));

        public static int ecovers_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.ecovers_tcbuffer_tcbuffer(temp1, temp2));

        public static int edisjoint_tcbuffer_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.edisjoint_tcbuffer_geo(temp, gs));

        public static int edisjoint_tcbuffer_cbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<int>(() => MEOSExternalFunctions.edisjoint_tcbuffer_cbuffer(temp, cb));

        public static int edwithin_tcbuffer_geo(IntPtr temp, IntPtr gs, double dist)
            => SafeExecution<int>(() => MEOSExternalFunctions.edwithin_tcbuffer_geo(temp, gs, dist));

        public static int edwithin_tcbuffer_cbuffer(IntPtr temp, IntPtr cb, double dist)
            => SafeExecution<int>(() => MEOSExternalFunctions.edwithin_tcbuffer_cbuffer(temp, cb, dist));

        public static int edwithin_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2, double dist)
            => SafeExecution<int>(() => MEOSExternalFunctions.edwithin_tcbuffer_tcbuffer(temp1, temp2, dist));

        public static int eintersects_tcbuffer_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.eintersects_tcbuffer_geo(temp, gs));

        public static int eintersects_tcbuffer_cbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<int>(() => MEOSExternalFunctions.eintersects_tcbuffer_cbuffer(temp, cb));

        public static int eintersects_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.eintersects_tcbuffer_tcbuffer(temp1, temp2));

        public static int etouches_tcbuffer_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.etouches_tcbuffer_geo(temp, gs));

        public static int etouches_tcbuffer_cbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<int>(() => MEOSExternalFunctions.etouches_tcbuffer_cbuffer(temp, cb));

        public static int etouches_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.etouches_tcbuffer_tcbuffer(temp1, temp2));

        public static IntPtr tcontains_cbuffer_tcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcontains_cbuffer_tcbuffer(cb, temp));

        public static IntPtr tcontains_geo_tcbuffer(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcontains_geo_tcbuffer(gs, temp));

        public static IntPtr tcontains_tcbuffer_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcontains_tcbuffer_geo(temp, gs));

        public static IntPtr tcontains_tcbuffer_cbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcontains_tcbuffer_cbuffer(temp, cb));

        public static IntPtr tcontains_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcontains_tcbuffer_tcbuffer(temp1, temp2));

        public static IntPtr tcovers_cbuffer_tcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcovers_cbuffer_tcbuffer(cb, temp));

        public static IntPtr tcovers_geo_tcbuffer(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcovers_geo_tcbuffer(gs, temp));

        public static IntPtr tcovers_tcbuffer_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcovers_tcbuffer_geo(temp, gs));

        public static IntPtr tcovers_tcbuffer_cbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcovers_tcbuffer_cbuffer(temp, cb));

        public static IntPtr tcovers_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcovers_tcbuffer_tcbuffer(temp1, temp2));

        public static IntPtr tdwithin_geo_tcbuffer(IntPtr gs, IntPtr temp, double dist)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdwithin_geo_tcbuffer(gs, temp, dist));

        public static IntPtr tdwithin_tcbuffer_geo(IntPtr temp, IntPtr gs, double dist)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdwithin_tcbuffer_geo(temp, gs, dist));

        public static IntPtr tdwithin_tcbuffer_cbuffer(IntPtr temp, IntPtr cb, double dist)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdwithin_tcbuffer_cbuffer(temp, cb, dist));

        public static IntPtr tdwithin_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2, double dist)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdwithin_tcbuffer_tcbuffer(temp1, temp2, dist));

        public static IntPtr tdisjoint_cbuffer_tcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdisjoint_cbuffer_tcbuffer(cb, temp));

        public static IntPtr tdisjoint_geo_tcbuffer(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdisjoint_geo_tcbuffer(gs, temp));

        public static IntPtr tdisjoint_tcbuffer_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdisjoint_tcbuffer_geo(temp, gs));

        public static IntPtr tdisjoint_tcbuffer_cbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdisjoint_tcbuffer_cbuffer(temp, cb));

        public static IntPtr tdisjoint_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdisjoint_tcbuffer_tcbuffer(temp1, temp2));

        public static IntPtr tintersects_cbuffer_tcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintersects_cbuffer_tcbuffer(cb, temp));

        public static IntPtr tintersects_geo_tcbuffer(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintersects_geo_tcbuffer(gs, temp));

        public static IntPtr tintersects_tcbuffer_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintersects_tcbuffer_geo(temp, gs));

        public static IntPtr tintersects_tcbuffer_cbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintersects_tcbuffer_cbuffer(temp, cb));

        public static IntPtr tintersects_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintersects_tcbuffer_tcbuffer(temp1, temp2));

        public static IntPtr ttouches_geo_tcbuffer(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttouches_geo_tcbuffer(gs, temp));

        public static IntPtr ttouches_tcbuffer_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttouches_tcbuffer_geo(temp, gs));

        public static IntPtr ttouches_cbuffer_tcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttouches_cbuffer_tcbuffer(cb, temp));

        public static IntPtr ttouches_tcbuffer_cbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttouches_tcbuffer_cbuffer(temp, cb));

        public static IntPtr ttouches_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttouches_tcbuffer_tcbuffer(temp1, temp2));

        public static IntPtr gsl_get_generation_rng()
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.gsl_get_generation_rng());

        public static IntPtr gsl_get_aggregation_rng()
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.gsl_get_aggregation_rng());

        public static ulong datum_ceil(ulong d)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.datum_ceil(d));

        public static ulong datum_degrees(ulong d, ulong normalize)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.datum_degrees(d, normalize));

        public static ulong datum_float_round(ulong value, ulong size)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.datum_float_round(value, size));

        public static ulong datum_floor(ulong d)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.datum_floor(d));

        public static uint datum_hash(ulong d, int basetype)
            => SafeExecution<uint>(() => MEOSExternalFunctions.datum_hash(d, basetype));

        public static ulong datum_hash_extended(ulong d, int basetype, ulong seed)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.datum_hash_extended(d, basetype, seed));

        public static ulong datum_radians(ulong d)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.datum_radians(d));

        public static void floatspan_round_set(IntPtr s, int maxdd, IntPtr result)
            => SafeExecution(() => MEOSExternalFunctions.floatspan_round_set(s, maxdd, result));

        public static IntPtr set_in(string str, int basetype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_in(str, basetype));

        public static string set_out(IntPtr s, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.set_out(s, maxdd));

        public static IntPtr span_in(string str, int spantype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.span_in(str, spantype));

        public static string span_out(IntPtr s, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.span_out(s, maxdd));

        public static IntPtr spanset_in(string str, int spantype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_in(str, spantype));

        public static string spanset_out(IntPtr ss, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.spanset_out(ss, maxdd));

        public static IntPtr set_make(IntPtr values, int count, int basetype, bool order)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_make(values, count, basetype, order));

        public static IntPtr set_make_exp(IntPtr values, int count, int maxcount, int basetype, bool order)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_make_exp(values, count, maxcount, basetype, order));

        public static IntPtr set_make_free(IntPtr values, int count, int basetype, bool order)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_make_free(values, count, basetype, order));

        public static IntPtr span_make(ulong lower, ulong upper, bool lower_inc, bool upper_inc, int basetype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.span_make(lower, upper, lower_inc, upper_inc, basetype));

        public static void span_set(ulong lower, ulong upper, bool lower_inc, bool upper_inc, int basetype, int spantype, IntPtr s)
            => SafeExecution(() => MEOSExternalFunctions.span_set(lower, upper, lower_inc, upper_inc, basetype, spantype, s));

        public static IntPtr spanset_make_exp(IntPtr spans, int count, int maxcount, bool normalize, bool order)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_make_exp(spans, count, maxcount, normalize, order));

        public static IntPtr spanset_make_free(IntPtr spans, int count, bool normalize, bool order)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_make_free(spans, count, normalize, order));

        public static IntPtr set_span(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_span(s));

        public static IntPtr set_spanset(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_spanset(s));

        public static void value_set_span(ulong value, int basetype, IntPtr s)
            => SafeExecution(() => MEOSExternalFunctions.value_set_span(value, basetype, s));

        public static IntPtr value_set(ulong d, int basetype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.value_set(d, basetype));

        public static IntPtr value_span(ulong d, int basetype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.value_span(d, basetype));

        public static IntPtr value_spanset(ulong d, int basetype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.value_spanset(d, basetype));

        public static ulong numspan_width(IntPtr s)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.numspan_width(s));

        public static ulong numspanset_width(IntPtr ss, bool boundspan)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.numspanset_width(ss, boundspan));

        public static ulong set_end_value(IntPtr s)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.set_end_value(s));

        public static int set_mem_size(IntPtr s)
            => SafeExecution<int>(() => MEOSExternalFunctions.set_mem_size(s));

        public static void set_set_subspan(IntPtr s, int minidx, int maxidx, IntPtr result)
            => SafeExecution(() => MEOSExternalFunctions.set_set_subspan(s, minidx, maxidx, result));

        public static void set_set_span(IntPtr s, IntPtr result)
            => SafeExecution(() => MEOSExternalFunctions.set_set_span(s, result));

        public static ulong set_start_value(IntPtr s)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.set_start_value(s));

        public static bool set_value_n(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.set_value_n(s, n, result));

        public static IntPtr set_vals(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_vals(s));

        public static IntPtr set_values(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_values(s));

        public static ulong spanset_lower(IntPtr ss)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.spanset_lower(ss));

        public static int spanset_mem_size(IntPtr ss)
            => SafeExecution<int>(() => MEOSExternalFunctions.spanset_mem_size(ss));

        public static IntPtr[] spanset_sps(IntPtr ss)
        {
            int _n = (int)MEOSExposedFunctions.spanset_num_spans(ss);
            IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_sps(ss));
            IntPtr[] _out = new IntPtr[_n];
            for (int _i = 0; _i < _n; _i++)
            { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
            return _out;
        }

        public static ulong spanset_upper(IntPtr ss)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.spanset_upper(ss));

        public static void datespan_set_tstzspan(IntPtr s1, IntPtr s2)
            => SafeExecution(() => MEOSExternalFunctions.datespan_set_tstzspan(s1, s2));

        public static void floatspan_set_intspan(IntPtr s1, IntPtr s2)
            => SafeExecution(() => MEOSExternalFunctions.floatspan_set_intspan(s1, s2));

        public static void intspan_set_floatspan(IntPtr s1, IntPtr s2)
            => SafeExecution(() => MEOSExternalFunctions.intspan_set_floatspan(s1, s2));

        public static IntPtr numset_shift_scale(IntPtr s, ulong shift, ulong width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.numset_shift_scale(s, shift, width, hasshift, haswidth));

        public static IntPtr numspan_expand(IntPtr s, ulong value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.numspan_expand(s, value));

        public static IntPtr numspan_shift_scale(IntPtr s, ulong shift, ulong width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.numspan_shift_scale(s, shift, width, hasshift, haswidth));

        public static IntPtr numspanset_shift_scale(IntPtr ss, ulong shift, ulong width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.numspanset_shift_scale(ss, shift, width, hasshift, haswidth));

        public static IntPtr set_compact(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_compact(s));

        public static void span_expand(IntPtr s1, IntPtr s2)
            => SafeExecution(() => MEOSExternalFunctions.span_expand(s1, s2));

        public static IntPtr spanset_compact(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_compact(ss));

        public static IntPtr tbox_expand_value(IntPtr box, ulong value, int basetyp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_expand_value(box, value, basetyp));

        public static IntPtr textcat_textset_text_common(IntPtr s, IntPtr txt, bool invert)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.textcat_textset_text_common(s, txt, invert));

        public static void tstzspan_set_datespan(IntPtr s1, IntPtr s2)
            => SafeExecution(() => MEOSExternalFunctions.tstzspan_set_datespan(s1, s2));

        public static bool adjacent_span_value(IntPtr s, ulong value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_span_value(s, value));

        public static bool adjacent_spanset_value(IntPtr ss, ulong value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_spanset_value(ss, value));

        public static bool adjacent_value_spanset(ulong value, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_value_spanset(value, ss));

        public static bool contained_value_set(ulong value, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_value_set(value, s));

        public static bool contained_value_span(ulong value, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_value_span(value, s));

        public static bool contained_value_spanset(ulong value, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_value_spanset(value, ss));

        public static bool contains_set_value(IntPtr s, ulong value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_set_value(s, value));

        public static bool contains_span_value(IntPtr s, ulong value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_span_value(s, value));

        public static bool contains_spanset_value(IntPtr ss, ulong value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_spanset_value(ss, value));

        public static bool ovadj_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ovadj_span_span(s1, s2));

        public static bool left_set_value(IntPtr s, ulong value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_set_value(s, value));

        public static bool left_span_value(IntPtr s, ulong value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_span_value(s, value));

        public static bool left_spanset_value(IntPtr ss, ulong value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_spanset_value(ss, value));

        public static bool left_value_set(ulong value, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_value_set(value, s));

        public static bool left_value_span(ulong value, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_value_span(value, s));

        public static bool left_value_spanset(ulong value, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_value_spanset(value, ss));

        public static bool lfnadj_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.lfnadj_span_span(s1, s2));

        public static bool overleft_set_value(IntPtr s, ulong value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_set_value(s, value));

        public static bool overleft_span_value(IntPtr s, ulong value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_span_value(s, value));

        public static bool overleft_spanset_value(IntPtr ss, ulong value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_spanset_value(ss, value));

        public static bool overleft_value_set(ulong value, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_value_set(value, s));

        public static bool overleft_value_span(ulong value, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_value_span(value, s));

        public static bool overleft_value_spanset(ulong value, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_value_spanset(value, ss));

        public static bool overright_set_value(IntPtr s, ulong value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_set_value(s, value));

        public static bool overright_span_value(IntPtr s, ulong value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_span_value(s, value));

        public static bool overright_spanset_value(IntPtr ss, ulong value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_spanset_value(ss, value));

        public static bool overright_value_set(ulong value, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_value_set(value, s));

        public static bool overright_value_span(ulong value, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_value_span(value, s));

        public static bool overright_value_spanset(ulong value, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_value_spanset(value, ss));

        public static bool right_value_set(ulong value, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_value_set(value, s));

        public static bool right_set_value(IntPtr s, ulong value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_set_value(s, value));

        public static bool right_value_span(ulong value, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_value_span(value, s));

        public static bool right_value_spanset(ulong value, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_value_spanset(value, ss));

        public static bool right_span_value(IntPtr s, ulong value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_span_value(s, value));

        public static bool right_spanset_value(IntPtr ss, ulong value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_spanset_value(ss, value));

        public static bool bbox_type(int bboxtype)
            => SafeExecution<bool>(() => MEOSExternalFunctions.bbox_type(bboxtype));

        public static ulong bbox_get_size(int bboxtype)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.bbox_get_size(bboxtype));

        public static int bbox_max_dims(int bboxtype)
            => SafeExecution<int>(() => MEOSExternalFunctions.bbox_max_dims(bboxtype));

        public static bool temporal_bbox_eq(IntPtr box1, IntPtr box2, int temptype)
            => SafeExecution<bool>(() => MEOSExternalFunctions.temporal_bbox_eq(box1, box2, temptype));

        public static int temporal_bbox_cmp(IntPtr box1, IntPtr box2, int temptype)
            => SafeExecution<int>(() => MEOSExternalFunctions.temporal_bbox_cmp(box1, box2, temptype));

        public static void bbox_union_span_span(IntPtr s1, IntPtr s2, IntPtr result)
            => SafeExecution(() => MEOSExternalFunctions.bbox_union_span_span(s1, s2, result));

        public static bool inter_span_span(IntPtr s1, IntPtr s2, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.inter_span_span(s1, s2, result));

        public static IntPtr intersection_set_value(IntPtr s, ulong value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_set_value(s, value));

        public static IntPtr intersection_span_value(IntPtr s, ulong value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_span_value(s, value));

        public static IntPtr intersection_spanset_value(IntPtr ss, ulong value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_spanset_value(ss, value));

        public static IntPtr intersection_value_set(ulong value, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_value_set(value, s));

        public static IntPtr intersection_value_span(ulong value, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_value_span(value, s));

        public static IntPtr intersection_value_spanset(ulong value, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_value_spanset(value, ss));

        public static int mi_span_span(IntPtr s1, IntPtr s2, IntPtr result)
            => SafeExecution<int>(() => MEOSExternalFunctions.mi_span_span(s1, s2, result));

        public static IntPtr minus_set_value(IntPtr s, ulong value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_set_value(s, value));

        public static IntPtr minus_span_value(IntPtr s, ulong value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_span_value(s, value));

        public static IntPtr minus_spanset_value(IntPtr ss, ulong value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_spanset_value(ss, value));

        public static IntPtr minus_value_set(ulong value, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_value_set(value, s));

        public static IntPtr minus_value_span(ulong value, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_value_span(value, s));

        public static IntPtr minus_value_spanset(ulong value, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_value_spanset(value, ss));

        public static IntPtr super_union_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.super_union_span_span(s1, s2));

        public static IntPtr union_set_value(IntPtr s, ulong value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_set_value(s, value));

        public static IntPtr union_span_value(IntPtr s, ulong value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_span_value(s, value));

        public static IntPtr union_spanset_value(IntPtr ss, ulong value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_spanset_value(ss, value));

        public static IntPtr union_value_set(ulong value, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_value_set(value, s));

        public static IntPtr union_value_span(ulong value, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_value_span(value, s));

        public static IntPtr union_value_spanset(ulong value, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_value_spanset(value, ss));

        public static ulong distance_set_set(IntPtr s1, IntPtr s2)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.distance_set_set(s1, s2));

        public static ulong distance_set_value(IntPtr s, ulong value)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.distance_set_value(s, value));

        public static ulong distance_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.distance_span_span(s1, s2));

        public static ulong distance_span_value(IntPtr s, ulong value)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.distance_span_value(s, value));

        public static ulong distance_spanset_span(IntPtr ss, IntPtr s)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.distance_spanset_span(ss, s));

        public static ulong distance_spanset_spanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.distance_spanset_spanset(ss1, ss2));

        public static ulong distance_spanset_value(IntPtr ss, ulong value)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.distance_spanset_value(ss, value));

        public static ulong distance_value_value(ulong l, ulong r, int basetype)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.distance_value_value(l, r, basetype));

        public static IntPtr spanbase_extent_transfn(IntPtr state, ulong value, int basetype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanbase_extent_transfn(state, value, basetype));

        public static IntPtr value_union_transfn(IntPtr state, ulong value, int basetype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.value_union_transfn(state, value, basetype));

        public static IntPtr number_tstzspan_to_tbox(ulong d, int basetype, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.number_tstzspan_to_tbox(d, basetype, s));

        public static IntPtr number_timestamptz_to_tbox(ulong d, int basetype, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.number_timestamptz_to_tbox(d, basetype, t));

        public static void tbox_set(IntPtr s, IntPtr p, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tbox_set(s, p, box));

        public static void float_set_tbox(double d, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.float_set_tbox(d, box));

        public static void int_set_tbox(int i, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.int_set_tbox(i, box));

        public static void number_set_tbox(ulong d, int basetype, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.number_set_tbox(d, basetype, box));

        public static IntPtr number_tbox(ulong value, int basetype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.number_tbox(value, basetype));

        public static void numset_set_tbox(IntPtr s, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.numset_set_tbox(s, box));

        public static void numspan_set_tbox(IntPtr span, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.numspan_set_tbox(span, box));

        public static void timestamptz_set_tbox(long t, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.timestamptz_set_tbox(t, box));

        public static void tstzset_set_tbox(IntPtr s, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tstzset_set_tbox(s, box));

        public static void tstzspan_set_tbox(IntPtr s, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tstzspan_set_tbox(s, box));

        public static IntPtr tbox_shift_scale_value(IntPtr box, ulong shift, ulong width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_shift_scale_value(box, shift, width, hasshift, haswidth));

        public static void tbox_expand(IntPtr box1, IntPtr box2)
            => SafeExecution(() => MEOSExternalFunctions.tbox_expand(box1, box2));

        public static bool inter_tbox_tbox(IntPtr box1, IntPtr box2, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.inter_tbox_tbox(box1, box2, result));

        public static IntPtr tboolinst_from_mfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tboolinst_from_mfjson(mfjson));

        public static IntPtr tboolinst_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tboolinst_in(str));

        public static IntPtr tboolseq_from_mfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tboolseq_from_mfjson(mfjson));

        public static IntPtr tboolseq_in(string str, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tboolseq_in(str, interp));

        public static IntPtr tboolseqset_from_mfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tboolseqset_from_mfjson(mfjson));

        public static IntPtr tboolseqset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tboolseqset_in(str));

        public static IntPtr temporal_in(string str, int temptype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_in(str, temptype));

        public static string temporal_out(IntPtr temp, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.temporal_out(temp, maxdd));

        public static IntPtr temparr_out(IntPtr temparr, int count, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temparr_out(temparr, count, maxdd));

        public static IntPtr tfloatinst_from_mfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloatinst_from_mfjson(mfjson));

        public static IntPtr tfloatinst_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloatinst_in(str));

        public static IntPtr tfloatseq_from_mfjson(IntPtr mfjson, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloatseq_from_mfjson(mfjson, interp));

        public static IntPtr tfloatseq_in(string str, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloatseq_in(str, interp));

        public static IntPtr tfloatseqset_from_mfjson(IntPtr mfjson, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloatseqset_from_mfjson(mfjson, interp));

        public static IntPtr tfloatseqset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloatseqset_in(str));

        public static IntPtr tinstant_from_mfjson(IntPtr mfjson, bool spatial, int srid, int temptype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_from_mfjson(mfjson, spatial, srid, temptype));

        public static IntPtr tinstant_in(string str, int temptype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_in(str, temptype));

        public static string tinstant_out(IntPtr inst, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.tinstant_out(inst, maxdd));

        public static IntPtr tintinst_from_mfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintinst_from_mfjson(mfjson));

        public static IntPtr tintinst_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintinst_in(str));

        public static IntPtr tintseq_from_mfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintseq_from_mfjson(mfjson));

        public static IntPtr tintseq_in(string str, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintseq_in(str, interp));

        public static IntPtr tintseqset_from_mfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintseqset_from_mfjson(mfjson));

        public static IntPtr tintseqset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintseqset_in(str));

        public static IntPtr tsequence_from_mfjson(IntPtr mfjson, bool spatial, int srid, int temptype, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_from_mfjson(mfjson, spatial, srid, temptype, interp));

        public static IntPtr tsequence_in(string str, int temptype, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_in(str, temptype, interp));

        public static string tsequence_out(IntPtr seq, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.tsequence_out(seq, maxdd));

        public static IntPtr tsequenceset_from_mfjson(IntPtr mfjson, bool spatial, int srid, int temptype, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_from_mfjson(mfjson, spatial, srid, temptype, interp));

        public static IntPtr tsequenceset_in(string str, int temptype, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_in(str, temptype, interp));

        public static string tsequenceset_out(IntPtr ss, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.tsequenceset_out(ss, maxdd));

        public static IntPtr ttextinst_from_mfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttextinst_from_mfjson(mfjson));

        public static IntPtr ttextinst_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttextinst_in(str));

        public static IntPtr ttextseq_from_mfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttextseq_from_mfjson(mfjson));

        public static IntPtr ttextseq_in(string str, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttextseq_in(str, interp));

        public static IntPtr ttextseqset_from_mfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttextseqset_from_mfjson(mfjson));

        public static IntPtr ttextseqset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttextseqset_in(str));

        public static IntPtr temporal_from_mfjson(string mfjson, int temptype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_from_mfjson(mfjson, temptype));

        public static IntPtr temporal_from_base_temp(ulong value, int temptype, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_from_base_temp(value, temptype, temp));

        public static IntPtr tinstant_copy(IntPtr inst)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_copy(inst));

        public static IntPtr tinstant_make(ulong value, int temptype, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_make(value, temptype, t));

        public static IntPtr tinstant_make_free(ulong value, int temptype, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_make_free(value, temptype, t));

        public static IntPtr tsequence_copy(IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_copy(seq));

        public static IntPtr tsequence_from_base_temp(ulong value, int temptype, IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_from_base_temp(value, temptype, seq));

        public static IntPtr tsequence_from_base_tstzset(ulong value, int temptype, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_from_base_tstzset(value, temptype, s));

        public static IntPtr tsequence_from_base_tstzspan(ulong value, int temptype, IntPtr s, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_from_base_tstzspan(value, temptype, s, interp));

        public static IntPtr tsequence_make_exp(IntPtr instants, int count, int maxcount, bool lower_inc, bool upper_inc, int interp, bool normalize)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_make_exp(instants, count, maxcount, lower_inc, upper_inc, interp, normalize));

        public static IntPtr tsequence_make_free(IntPtr instants, int count, bool lower_inc, bool upper_inc, int interp, bool normalize)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_make_free(instants, count, lower_inc, upper_inc, interp, normalize));

        public static IntPtr tsequenceset_copy(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_copy(ss));

        public static IntPtr tseqsetarr_to_tseqset(IntPtr seqsets, int count, int totalseqs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tseqsetarr_to_tseqset(seqsets, count, totalseqs));

        public static IntPtr tsequenceset_from_base_temp(ulong value, int temptype, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_from_base_temp(value, temptype, ss));

        public static IntPtr tsequenceset_from_base_tstzspanset(ulong value, int temptype, IntPtr ss, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_from_base_tstzspanset(value, temptype, ss, interp));

        public static IntPtr tsequenceset_make_exp(IntPtr sequences, int count, int maxcount, bool normalize)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_make_exp(sequences, count, maxcount, normalize));

        public static IntPtr tsequenceset_make_free(IntPtr sequences, int count, bool normalize)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_make_free(sequences, count, normalize));

        public static void temporal_set_tstzspan(IntPtr temp, IntPtr s)
            => SafeExecution(() => MEOSExternalFunctions.temporal_set_tstzspan(temp, s));

        public static void tinstant_set_tstzspan(IntPtr inst, IntPtr s)
            => SafeExecution(() => MEOSExternalFunctions.tinstant_set_tstzspan(inst, s));

        public static void tnumber_set_tbox(IntPtr temp, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tnumber_set_tbox(temp, box));

        public static void tnumberinst_set_tbox(IntPtr inst, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tnumberinst_set_tbox(inst, box));

        public static void tnumberseq_set_tbox(IntPtr seq, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tnumberseq_set_tbox(seq, box));

        public static void tnumberseqset_set_tbox(IntPtr ss, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tnumberseqset_set_tbox(ss, box));

        public static void tsequence_set_tstzspan(IntPtr seq, IntPtr s)
            => SafeExecution(() => MEOSExternalFunctions.tsequence_set_tstzspan(seq, s));

        public static void tsequenceset_set_tstzspan(IntPtr ss, IntPtr s)
            => SafeExecution(() => MEOSExternalFunctions.tsequenceset_set_tstzspan(ss, s));

        public static IntPtr temporal_end_inst(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_end_inst(temp));

        public static ulong temporal_end_value(IntPtr temp)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.temporal_end_value(temp));

        public static IntPtr temporal_inst_n(IntPtr temp, int n)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_inst_n(temp, n));

        public static IntPtr temporal_insts_p(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_insts_p(temp, count));

        public static IntPtr temporal_max_inst_p(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_max_inst_p(temp));

        public static ulong temporal_max_value(IntPtr temp)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.temporal_max_value(temp));

        public static ulong temporal_mem_size(IntPtr temp)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.temporal_mem_size(temp));

        public static IntPtr temporal_min_inst_p(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_min_inst_p(temp));

        public static ulong temporal_min_value(IntPtr temp)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.temporal_min_value(temp));

        public static IntPtr temporal_sequences_p(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_sequences_p(temp, count));

        public static void temporal_set_bbox(IntPtr temp, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.temporal_set_bbox(temp, box));

        public static IntPtr temporal_start_inst(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_start_inst(temp));

        public static ulong temporal_start_value(IntPtr temp)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.temporal_start_value(temp));

        public static IntPtr temporal_values_p(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_values_p(temp, count));

        public static bool temporal_value_n(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.temporal_value_n(temp, n, result));

        public static IntPtr temporal_values(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_values(temp, count));

        public static uint tinstant_hash(IntPtr inst)
            => SafeExecution<uint>(() => MEOSExternalFunctions.tinstant_hash(inst));

        public static IntPtr tinstant_insts(IntPtr inst, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_insts(inst, count));

        public static void tinstant_set_bbox(IntPtr inst, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tinstant_set_bbox(inst, box));

        public static IntPtr tinstant_time(IntPtr inst)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_time(inst));

        public static IntPtr tinstant_timestamps(IntPtr inst, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_timestamps(inst, count));

        public static ulong tinstant_value_p(IntPtr inst)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.tinstant_value_p(inst));

        public static ulong tinstant_value(IntPtr inst)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.tinstant_value(inst));

        public static bool tinstant_value_at_timestamptz(IntPtr inst, long t, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tinstant_value_at_timestamptz(inst, t, result));

        public static IntPtr tinstant_values_p(IntPtr inst, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_values_p(inst, count));

        public static void tnumber_set_span(IntPtr temp, IntPtr span)
            => SafeExecution(() => MEOSExternalFunctions.tnumber_set_span(temp, span));

        public static IntPtr tnumberinst_valuespans(IntPtr inst)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumberinst_valuespans(inst));

        public static double tnumberseq_avg_val(IntPtr seq)
            => SafeExecution<double>(() => MEOSExternalFunctions.tnumberseq_avg_val(seq));

        public static IntPtr tnumberseq_valuespans(IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumberseq_valuespans(seq));

        public static double tnumberseqset_avg_val(IntPtr ss)
            => SafeExecution<double>(() => MEOSExternalFunctions.tnumberseqset_avg_val(ss));

        public static IntPtr tnumberseqset_valuespans(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumberseqset_valuespans(ss));

        public static IntPtr tsequence_duration(IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_duration(seq));

        public static long tsequence_end_timestamptz(IntPtr seq)
            => SafeExecution<long>(() => MEOSExternalFunctions.tsequence_end_timestamptz(seq));

        public static uint tsequence_hash(IntPtr seq)
            => SafeExecution<uint>(() => MEOSExternalFunctions.tsequence_hash(seq));

        public static IntPtr[] tsequence_insts_p(IntPtr seq)
        {
            int _n = (int)MEOSExposedFunctions.temporal_num_instants(seq);
            IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_insts_p(seq));
            IntPtr[] _out = new IntPtr[_n];
            for (int _i = 0; _i < _n; _i++)
            { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
            return _out;
        }

        public static IntPtr tsequence_max_inst_p(IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_max_inst_p(seq));

        public static ulong tsequence_max_val(IntPtr seq)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.tsequence_max_val(seq));

        public static IntPtr tsequence_min_inst_p(IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_min_inst_p(seq));

        public static ulong tsequence_min_val(IntPtr seq)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.tsequence_min_val(seq));

        public static IntPtr tsequence_segments(IntPtr seq, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_segments(seq, count));

        public static IntPtr tsequence_seqs(IntPtr seq, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_seqs(seq, count));

        public static long tsequence_start_timestamptz(IntPtr seq)
            => SafeExecution<long>(() => MEOSExternalFunctions.tsequence_start_timestamptz(seq));

        public static IntPtr tsequence_time(IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_time(seq));

        public static IntPtr tsequence_timestamps(IntPtr seq, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_timestamps(seq, count));

        public static bool tsequence_value_at_timestamptz(IntPtr seq, long t, bool strict, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tsequence_value_at_timestamptz(seq, t, strict, result));

        public static IntPtr tsequence_values_p(IntPtr seq, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_values_p(seq, count));

        public static IntPtr tsequenceset_duration(IntPtr ss, bool boundspan)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_duration(ss, boundspan));

        public static long tsequenceset_end_timestamptz(IntPtr ss)
            => SafeExecution<long>(() => MEOSExternalFunctions.tsequenceset_end_timestamptz(ss));

        public static uint tsequenceset_hash(IntPtr ss)
            => SafeExecution<uint>(() => MEOSExternalFunctions.tsequenceset_hash(ss));

        public static IntPtr tsequenceset_inst_n(IntPtr ss, int n)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_inst_n(ss, n));

        public static IntPtr[] tsequenceset_insts_p(IntPtr ss)
        {
            int _n = (int)MEOSExposedFunctions.tsequenceset_num_instants(ss);
            IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_insts_p(ss));
            IntPtr[] _out = new IntPtr[_n];
            for (int _i = 0; _i < _n; _i++)
            { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
            return _out;
        }

        public static IntPtr tsequenceset_max_inst_p(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_max_inst_p(ss));

        public static ulong tsequenceset_max_val(IntPtr ss)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.tsequenceset_max_val(ss));

        public static IntPtr tsequenceset_min_inst_p(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_min_inst_p(ss));

        public static ulong tsequenceset_min_val(IntPtr ss)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.tsequenceset_min_val(ss));

        public static int tsequenceset_num_instants(IntPtr ss)
            => SafeExecution<int>(() => MEOSExternalFunctions.tsequenceset_num_instants(ss));

        public static int tsequenceset_num_timestamps(IntPtr ss)
            => SafeExecution<int>(() => MEOSExternalFunctions.tsequenceset_num_timestamps(ss));

        public static IntPtr tsequenceset_segments(IntPtr ss, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_segments(ss, count));

        public static IntPtr[] tsequenceset_sequences_p(IntPtr ss)
        {
            int _n = (int)MEOSExposedFunctions.temporal_num_sequences(ss);
            IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_sequences_p(ss));
            IntPtr[] _out = new IntPtr[_n];
            for (int _i = 0; _i < _n; _i++)
            { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
            return _out;
        }

        public static long tsequenceset_start_timestamptz(IntPtr ss)
            => SafeExecution<long>(() => MEOSExternalFunctions.tsequenceset_start_timestamptz(ss));

        public static IntPtr tsequenceset_time(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_time(ss));

        public static bool tsequenceset_timestamptz_n(IntPtr ss, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tsequenceset_timestamptz_n(ss, n, result));

        public static IntPtr tsequenceset_timestamps(IntPtr ss, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_timestamps(ss, count));

        public static bool tsequenceset_value_at_timestamptz(IntPtr ss, long t, bool strict, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tsequenceset_value_at_timestamptz(ss, t, strict, result));

        public static bool tsequenceset_value_n(IntPtr ss, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tsequenceset_value_n(ss, n, result));

        public static IntPtr tsequenceset_values_p(IntPtr ss, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_values_p(ss, count));

        public static void temporal_restart(IntPtr temp, int count)
            => SafeExecution(() => MEOSExternalFunctions.temporal_restart(temp, count));

        public static IntPtr temporal_tsequence(IntPtr temp, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_tsequence(temp, interp));

        public static IntPtr temporal_tsequenceset(IntPtr temp, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_tsequenceset(temp, interp));

        public static IntPtr tinstant_shift_time(IntPtr inst, IntPtr interv)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_shift_time(inst, interv));

        public static IntPtr tinstant_to_tsequence(IntPtr inst, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_to_tsequence(inst, interp));

        public static IntPtr tinstant_to_tsequence_free(IntPtr inst, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_to_tsequence_free(inst, interp));

        public static IntPtr tinstant_to_tsequenceset(IntPtr inst, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_to_tsequenceset(inst, interp));

        public static IntPtr tnumber_shift_scale_value(IntPtr temp, ulong shift, ulong width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_shift_scale_value(temp, shift, width, hasshift, haswidth));

        public static IntPtr tnumberinst_shift_value(IntPtr inst, ulong shift)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumberinst_shift_value(inst, shift));

        public static IntPtr tnumberseq_shift_scale_value(IntPtr seq, ulong shift, ulong width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumberseq_shift_scale_value(seq, shift, width, hasshift, haswidth));

        public static IntPtr tnumberseqset_shift_scale_value(IntPtr ss, ulong start, ulong width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumberseqset_shift_scale_value(ss, start, width, hasshift, haswidth));

        public static void tsequence_restart(IntPtr seq, int count)
            => SafeExecution(() => MEOSExternalFunctions.tsequence_restart(seq, count));

        public static IntPtr tsequence_set_interp(IntPtr seq, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_set_interp(seq, interp));

        public static IntPtr tsequence_shift_scale_time(IntPtr seq, IntPtr shift, IntPtr duration)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_shift_scale_time(seq, shift, duration));

        public static IntPtr tsequence_subseq(IntPtr seq, int from, int to, bool lower_inc, bool upper_inc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_subseq(seq, from, to, lower_inc, upper_inc));

        public static IntPtr tsequence_to_tinstant(IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_to_tinstant(seq));

        public static IntPtr tsequence_to_tsequenceset(IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_to_tsequenceset(seq));

        public static IntPtr tsequence_to_tsequenceset_free(IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_to_tsequenceset_free(seq));

        public static IntPtr tsequence_to_tsequenceset_interp(IntPtr seq, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_to_tsequenceset_interp(seq, interp));

        public static void tsequenceset_restart(IntPtr ss, int count)
            => SafeExecution(() => MEOSExternalFunctions.tsequenceset_restart(ss, count));

        public static IntPtr tsequenceset_set_interp(IntPtr ss, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_set_interp(ss, interp));

        public static IntPtr tsequenceset_shift_scale_time(IntPtr ss, IntPtr start, IntPtr duration)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_shift_scale_time(ss, start, duration));

        public static IntPtr tsequenceset_to_discrete(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_to_discrete(ss));

        public static IntPtr tsequenceset_to_linear(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_to_linear(ss));

        public static IntPtr tsequenceset_to_step(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_to_step(ss));

        public static IntPtr tsequenceset_to_tinstant(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_to_tinstant(ss));

        public static IntPtr tsequenceset_to_tsequence(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_to_tsequence(ss));

        public static IntPtr tinstant_merge(IntPtr inst1, IntPtr inst2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_merge(inst1, inst2));

        public static IntPtr tinstant_merge_array(IntPtr instants, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_merge_array(instants, count));

        public static IntPtr tsequence_append_tinstant(IntPtr seq, IntPtr inst, double maxdist, IntPtr maxt, bool expand)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_append_tinstant(seq, inst, maxdist, maxt, expand));

        public static IntPtr tsequence_append_tsequence(IntPtr seq1, IntPtr seq2, bool expand)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_append_tsequence(seq1, seq2, expand));

        public static IntPtr tsequence_delete_timestamptz(IntPtr seq, long t, bool connect)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_delete_timestamptz(seq, t, connect));

        public static IntPtr tsequence_delete_tstzset(IntPtr seq, IntPtr s, bool connect)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_delete_tstzset(seq, s, connect));

        public static IntPtr tsequence_delete_tstzspan(IntPtr seq, IntPtr s, bool connect)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_delete_tstzspan(seq, s, connect));

        public static IntPtr tsequence_delete_tstzspanset(IntPtr seq, IntPtr ss, bool connect)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_delete_tstzspanset(seq, ss, connect));

        public static IntPtr tsequence_insert(IntPtr seq1, IntPtr seq2, bool connect)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_insert(seq1, seq2, connect));

        public static IntPtr tsequence_merge(IntPtr seq1, IntPtr seq2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_merge(seq1, seq2));

        public static IntPtr tsequence_merge_array(IntPtr sequences, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_merge_array(sequences, count));

        public static IntPtr tsequenceset_append_tinstant(IntPtr ss, IntPtr inst, double maxdist, IntPtr maxt, bool expand)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_append_tinstant(ss, inst, maxdist, maxt, expand));

        public static IntPtr tsequenceset_append_tsequence(IntPtr ss, IntPtr seq, bool expand)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_append_tsequence(ss, seq, expand));

        public static IntPtr tsequenceset_delete_timestamptz(IntPtr ss, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_delete_timestamptz(ss, t));

        public static IntPtr tsequenceset_delete_tstzset(IntPtr ss, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_delete_tstzset(ss, s));

        public static IntPtr tsequenceset_delete_tstzspan(IntPtr ss, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_delete_tstzspan(ss, s));

        public static IntPtr tsequenceset_delete_tstzspanset(IntPtr ss, IntPtr ps)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_delete_tstzspanset(ss, ps));

        public static IntPtr tsequenceset_insert(IntPtr ss1, IntPtr ss2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_insert(ss1, ss2));

        public static IntPtr tsequenceset_merge(IntPtr ss1, IntPtr ss2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_merge(ss1, ss2));

        public static IntPtr tsequenceset_merge_array(IntPtr seqsets, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_merge_array(seqsets, count));

        public static void tsequence_expand_bbox(IntPtr seq, IntPtr inst)
            => SafeExecution(() => MEOSExternalFunctions.tsequence_expand_bbox(seq, inst));

        public static void tsequence_set_bbox(IntPtr seq, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tsequence_set_bbox(seq, box));

        public static void tsequenceset_expand_bbox(IntPtr ss, IntPtr seq)
            => SafeExecution(() => MEOSExternalFunctions.tsequenceset_expand_bbox(ss, seq));

        public static void tsequenceset_set_bbox(IntPtr ss, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tsequenceset_set_bbox(ss, box));

        public static IntPtr tcontseq_after_timestamptz(IntPtr seq, long t, bool strict)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcontseq_after_timestamptz(seq, t, strict));

        public static IntPtr tcontseq_before_timestamptz(IntPtr seq, long t, bool strict)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcontseq_before_timestamptz(seq, t, strict));

        public static IntPtr tcontseq_restrict_minmax(IntPtr seq, bool min, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcontseq_restrict_minmax(seq, min, atfunc));

        public static IntPtr tdiscseq_after_timestamptz(IntPtr seq, long t, bool strict)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdiscseq_after_timestamptz(seq, t, strict));

        public static IntPtr tdiscseq_before_timestamptz(IntPtr seq, long t, bool strict)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdiscseq_before_timestamptz(seq, t, strict));

        public static IntPtr tdiscseq_restrict_minmax(IntPtr seq, bool min, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdiscseq_restrict_minmax(seq, min, atfunc));

        public static bool temporal_bbox_restrict_set(IntPtr temp, IntPtr set)
            => SafeExecution<bool>(() => MEOSExternalFunctions.temporal_bbox_restrict_set(temp, set));

        public static IntPtr temporal_restrict_minmax(IntPtr temp, bool min, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_restrict_minmax(temp, min, atfunc));

        public static IntPtr temporal_restrict_timestamptz(IntPtr temp, long t, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_restrict_timestamptz(temp, t, atfunc));

        public static IntPtr temporal_restrict_tstzset(IntPtr temp, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_restrict_tstzset(temp, s, atfunc));

        public static IntPtr temporal_restrict_tstzspan(IntPtr temp, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_restrict_tstzspan(temp, s, atfunc));

        public static IntPtr temporal_restrict_tstzspanset(IntPtr temp, IntPtr ss, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_restrict_tstzspanset(temp, ss, atfunc));

        public static IntPtr temporal_restrict_value(IntPtr temp, ulong value, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_restrict_value(temp, value, atfunc));

        public static IntPtr temporal_restrict_values(IntPtr temp, IntPtr set, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_restrict_values(temp, set, atfunc));

        public static bool temporal_value_at_timestamptz(IntPtr temp, long t, bool strict, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.temporal_value_at_timestamptz(temp, t, strict, result));

        public static IntPtr tinstant_after_timestamptz(IntPtr inst, long t, bool strict)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_after_timestamptz(inst, t, strict));

        public static IntPtr tinstant_before_timestamptz(IntPtr inst, long t, bool strict)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_before_timestamptz(inst, t, strict));

        public static IntPtr tinstant_restrict_tstzspan(IntPtr inst, IntPtr period, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_restrict_tstzspan(inst, period, atfunc));

        public static IntPtr tinstant_restrict_tstzspanset(IntPtr inst, IntPtr ss, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_restrict_tstzspanset(inst, ss, atfunc));

        public static IntPtr tinstant_restrict_timestamptz(IntPtr inst, long t, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_restrict_timestamptz(inst, t, atfunc));

        public static IntPtr tinstant_restrict_tstzset(IntPtr inst, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_restrict_tstzset(inst, s, atfunc));

        public static IntPtr tinstant_restrict_value(IntPtr inst, ulong value, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_restrict_value(inst, value, atfunc));

        public static IntPtr tinstant_restrict_values(IntPtr inst, IntPtr set, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_restrict_values(inst, set, atfunc));

        public static IntPtr tnumber_restrict_span(IntPtr temp, IntPtr span, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_restrict_span(temp, span, atfunc));

        public static IntPtr tnumber_restrict_spanset(IntPtr temp, IntPtr ss, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_restrict_spanset(temp, ss, atfunc));

        public static IntPtr tnumberinst_restrict_span(IntPtr inst, IntPtr span, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumberinst_restrict_span(inst, span, atfunc));

        public static IntPtr tnumberinst_restrict_spanset(IntPtr inst, IntPtr ss, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumberinst_restrict_spanset(inst, ss, atfunc));

        public static IntPtr tnumberseqset_restrict_span(IntPtr ss, IntPtr span, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumberseqset_restrict_span(ss, span, atfunc));

        public static IntPtr tnumberseqset_restrict_spanset(IntPtr ss, IntPtr spanset, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumberseqset_restrict_spanset(ss, spanset, atfunc));

        public static IntPtr tsequence_at_timestamptz(IntPtr seq, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_at_timestamptz(seq, t));

        public static IntPtr tsequence_restrict_tstzspan(IntPtr seq, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_restrict_tstzspan(seq, s, atfunc));

        public static IntPtr tsequence_restrict_tstzspanset(IntPtr seq, IntPtr ss, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_restrict_tstzspanset(seq, ss, atfunc));

        public static IntPtr tsequenceset_after_timestamptz(IntPtr ss, long t, bool strict)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_after_timestamptz(ss, t, strict));

        public static IntPtr tsequenceset_before_timestamptz(IntPtr ss, long t, bool strict)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_before_timestamptz(ss, t, strict));

        public static IntPtr tsequenceset_restrict_minmax(IntPtr ss, bool min, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_restrict_minmax(ss, min, atfunc));

        public static IntPtr tsequenceset_restrict_tstzspan(IntPtr ss, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_restrict_tstzspan(ss, s, atfunc));

        public static IntPtr tsequenceset_restrict_tstzspanset(IntPtr ss, IntPtr ps, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_restrict_tstzspanset(ss, ps, atfunc));

        public static IntPtr tsequenceset_restrict_timestamptz(IntPtr ss, long t, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_restrict_timestamptz(ss, t, atfunc));

        public static IntPtr tsequenceset_restrict_tstzset(IntPtr ss, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_restrict_tstzset(ss, s, atfunc));

        public static IntPtr tsequenceset_restrict_value(IntPtr ss, ulong value, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_restrict_value(ss, value, atfunc));

        public static IntPtr tsequenceset_restrict_values(IntPtr ss, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_restrict_values(ss, s, atfunc));

        public static int tinstant_cmp(IntPtr inst1, IntPtr inst2)
            => SafeExecution<int>(() => MEOSExternalFunctions.tinstant_cmp(inst1, inst2));

        public static bool tinstant_eq(IntPtr inst1, IntPtr inst2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tinstant_eq(inst1, inst2));

        public static int tsequence_cmp(IntPtr seq1, IntPtr seq2)
            => SafeExecution<int>(() => MEOSExternalFunctions.tsequence_cmp(seq1, seq2));

        public static bool tsequence_eq(IntPtr seq1, IntPtr seq2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tsequence_eq(seq1, seq2));

        public static int tsequenceset_cmp(IntPtr ss1, IntPtr ss2)
            => SafeExecution<int>(() => MEOSExternalFunctions.tsequenceset_cmp(ss1, ss2));

        public static bool tsequenceset_eq(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tsequenceset_eq(ss1, ss2));

        public static int always_eq_base_temporal(ulong value, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_base_temporal(value, temp));

        public static int always_eq_temporal_base(IntPtr temp, ulong value)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_temporal_base(temp, value));

        public static int always_ne_base_temporal(ulong value, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_base_temporal(value, temp));

        public static int always_ne_temporal_base(IntPtr temp, ulong value)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_temporal_base(temp, value));

        public static int always_ge_base_temporal(ulong value, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ge_base_temporal(value, temp));

        public static int always_ge_temporal_base(IntPtr temp, ulong value)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ge_temporal_base(temp, value));

        public static int always_gt_base_temporal(ulong value, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_gt_base_temporal(value, temp));

        public static int always_gt_temporal_base(IntPtr temp, ulong value)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_gt_temporal_base(temp, value));

        public static int always_le_base_temporal(ulong value, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_le_base_temporal(value, temp));

        public static int always_le_temporal_base(IntPtr temp, ulong value)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_le_temporal_base(temp, value));

        public static int always_lt_base_temporal(ulong value, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_lt_base_temporal(value, temp));

        public static int always_lt_temporal_base(IntPtr temp, ulong value)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_lt_temporal_base(temp, value));

        public static int ever_eq_base_temporal(ulong value, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_base_temporal(value, temp));

        public static int ever_eq_temporal_base(IntPtr temp, ulong value)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_temporal_base(temp, value));

        public static int ever_ne_base_temporal(ulong value, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_base_temporal(value, temp));

        public static int ever_ne_temporal_base(IntPtr temp, ulong value)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_temporal_base(temp, value));

        public static int ever_ge_base_temporal(ulong value, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ge_base_temporal(value, temp));

        public static int ever_ge_temporal_base(IntPtr temp, ulong value)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ge_temporal_base(temp, value));

        public static int ever_gt_base_temporal(ulong value, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_gt_base_temporal(value, temp));

        public static int ever_gt_temporal_base(IntPtr temp, ulong value)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_gt_temporal_base(temp, value));

        public static int ever_le_base_temporal(ulong value, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_le_base_temporal(value, temp));

        public static int ever_le_temporal_base(IntPtr temp, ulong value)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_le_temporal_base(temp, value));

        public static int ever_lt_base_temporal(ulong value, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_lt_base_temporal(value, temp));

        public static int ever_lt_temporal_base(IntPtr temp, ulong value)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_lt_temporal_base(temp, value));

        public static IntPtr tnumberinst_abs(IntPtr inst)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumberinst_abs(inst));

        public static IntPtr tnumberseq_abs(IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumberseq_abs(seq));

        public static IntPtr tnumberseq_angular_difference(IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumberseq_angular_difference(seq));

        public static IntPtr tnumberseq_delta_value(IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumberseq_delta_value(seq));

        public static IntPtr tnumberseqset_abs(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumberseqset_abs(ss));

        public static IntPtr tnumberseqset_angular_difference(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumberseqset_angular_difference(ss));

        public static IntPtr tnumberseqset_delta_value(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumberseqset_delta_value(ss));

        public static IntPtr tdistance_tnumber_number(IntPtr temp, ulong value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdistance_tnumber_number(temp, value));

        public static double nad_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tbox_tbox(box1, box2));

        public static double nad_tnumber_number(IntPtr temp, ulong value)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tnumber_number(temp, value));

        public static double nad_tnumber_tbox(IntPtr temp, IntPtr box)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tnumber_tbox(temp, box));

        public static double nad_tnumber_tnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tnumber_tnumber(temp1, temp2));

        public static double tnumberseq_integral(IntPtr seq)
            => SafeExecution<double>(() => MEOSExternalFunctions.tnumberseq_integral(seq));

        public static double tnumberseq_twavg(IntPtr seq)
            => SafeExecution<double>(() => MEOSExternalFunctions.tnumberseq_twavg(seq));

        public static double tnumberseqset_integral(IntPtr ss)
            => SafeExecution<double>(() => MEOSExternalFunctions.tnumberseqset_integral(ss));

        public static double tnumberseqset_twavg(IntPtr ss)
            => SafeExecution<double>(() => MEOSExternalFunctions.tnumberseqset_twavg(ss));

        public static IntPtr temporal_compact(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_compact(temp));

        public static IntPtr tsequence_compact(IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_compact(seq));

        public static IntPtr tsequenceset_compact(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_compact(ss));

        public static IntPtr temporal_skiplist_make()
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_skiplist_make());

        public static IntPtr skiplist_make(ulong key_size, ulong value_size, IntPtr comp_fn, IntPtr merge_fn)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.skiplist_make(key_size, value_size, comp_fn, merge_fn));

        public static int skiplist_search(IntPtr list, IntPtr key, IntPtr value)
            => SafeExecution<int>(() => MEOSExternalFunctions.skiplist_search(list, key, value));

        public static void skiplist_free(IntPtr list)
            => SafeExecution(() => MEOSExternalFunctions.skiplist_free(list));

        public static void skiplist_splice(IntPtr list, IntPtr keys, IntPtr values, int count, IntPtr func, bool crossings, IntPtr sktype)
            => SafeExecution(() => MEOSExternalFunctions.skiplist_splice(list, keys, values, count, func, crossings, sktype));

        public static void temporal_skiplist_splice(IntPtr list, IntPtr values, int count, IntPtr func, bool crossings)
            => SafeExecution(() => MEOSExternalFunctions.temporal_skiplist_splice(list, values, count, func, crossings));

        public static IntPtr skiplist_values(IntPtr list)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.skiplist_values(list));

        public static IntPtr skiplist_keys_values(IntPtr list, IntPtr values)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.skiplist_keys_values(list, values));

        public static IntPtr temporal_app_tinst_transfn(IntPtr state, IntPtr inst, int interp, double maxdist, IntPtr maxt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_app_tinst_transfn(state, inst, interp, maxdist, maxt));

        public static IntPtr temporal_app_tseq_transfn(IntPtr state, IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_app_tseq_transfn(state, seq));

        public static IntPtr span_bins(IntPtr s, ulong size, ulong origin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.span_bins(s, size, origin, count));

        public static IntPtr spanset_bins(IntPtr ss, ulong size, ulong origin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_bins(ss, size, origin, count));

        public static IntPtr tnumber_value_bins(IntPtr temp, ulong size, ulong origin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_value_bins(temp, size, origin, count));

        public static IntPtr tnumber_value_time_boxes(IntPtr temp, ulong vsize, IntPtr duration, ulong vorigin, long torigin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_value_time_boxes(temp, vsize, duration, vorigin, torigin, count));

        public static IntPtr tnumber_value_split(IntPtr temp, ulong vsize, ulong vorigin, IntPtr bins, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_value_split(temp, vsize, vorigin, bins, count));

        public static IntPtr tbox_get_value_time_tile(ulong value, long t, ulong vsize, IntPtr duration, ulong vorigin, long torigin, int basetype, int spantype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_get_value_time_tile(value, t, vsize, duration, vorigin, torigin, basetype, spantype));

        public static IntPtr tnumber_value_time_split(IntPtr temp, ulong size, IntPtr duration, ulong vorigin, long torigin, IntPtr value_bins, IntPtr time_bins, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_value_time_split(temp, size, duration, vorigin, torigin, value_bins, time_bins, count));

        public static IntPtr proj_get_context()
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.proj_get_context());

        public static ulong datum_geo_round(ulong value, ulong size)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.datum_geo_round(value, size));

        public static IntPtr point_round(IntPtr gs, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.point_round(gs, maxdd));

        public static void stbox_set(bool hasx, bool hasz, bool geodetic, int srid, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, IntPtr s, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.stbox_set(hasx, hasz, geodetic, srid, xmin, xmax, ymin, ymax, zmin, zmax, s, box));

        public static void gbox_set_stbox(IntPtr box, int srid, IntPtr result)
            => SafeExecution(() => MEOSExternalFunctions.gbox_set_stbox(box, srid, result));

        public static bool geo_set_stbox(IntPtr gs, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geo_set_stbox(gs, box));

        public static void geoarr_set_stbox(IntPtr values, int count, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.geoarr_set_stbox(values, count, box));

        public static bool spatial_set_stbox(ulong d, int basetype, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.spatial_set_stbox(d, basetype, box));

        public static void spatialset_set_stbox(IntPtr set, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.spatialset_set_stbox(set, box));

        public static void stbox_set_box3d(IntPtr box, IntPtr box3d)
            => SafeExecution(() => MEOSExternalFunctions.stbox_set_box3d(box, box3d));

        public static void stbox_set_gbox(IntPtr box, IntPtr gbox)
            => SafeExecution(() => MEOSExternalFunctions.stbox_set_gbox(box, gbox));

        public static void tstzset_set_stbox(IntPtr s, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tstzset_set_stbox(s, box));

        public static void tstzspan_set_stbox(IntPtr s, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tstzspan_set_stbox(s, box));

        public static void tstzspanset_set_stbox(IntPtr s, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tstzspanset_set_stbox(s, box));

        public static void stbox_expand(IntPtr box1, IntPtr box2)
            => SafeExecution(() => MEOSExternalFunctions.stbox_expand(box1, box2));

        public static bool inter_stbox_stbox(IntPtr box1, IntPtr box2, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.inter_stbox_stbox(box1, box2, result));

        public static IntPtr stbox_geo(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_geo(box));

        public static IntPtr tgeogpointinst_from_mfjson(IntPtr mfjson, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeogpointinst_from_mfjson(mfjson, srid));

        public static IntPtr tgeogpointinst_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeogpointinst_in(str));

        public static IntPtr tgeogpointseq_from_mfjson(IntPtr mfjson, int srid, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeogpointseq_from_mfjson(mfjson, srid, interp));

        public static IntPtr tgeogpointseq_in(string str, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeogpointseq_in(str, interp));

        public static IntPtr tgeogpointseqset_from_mfjson(IntPtr mfjson, int srid, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeogpointseqset_from_mfjson(mfjson, srid, interp));

        public static IntPtr tgeogpointseqset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeogpointseqset_in(str));

        public static IntPtr tgeompointinst_from_mfjson(IntPtr mfjson, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeompointinst_from_mfjson(mfjson, srid));

        public static IntPtr tgeompointinst_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeompointinst_in(str));

        public static IntPtr tgeompointseq_from_mfjson(IntPtr mfjson, int srid, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeompointseq_from_mfjson(mfjson, srid, interp));

        public static IntPtr tgeompointseq_in(string str, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeompointseq_in(str, interp));

        public static IntPtr tgeompointseqset_from_mfjson(IntPtr mfjson, int srid, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeompointseqset_from_mfjson(mfjson, srid, interp));

        public static IntPtr tgeompointseqset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeompointseqset_in(str));

        public static IntPtr tgeographyinst_from_mfjson(IntPtr mfjson, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeographyinst_from_mfjson(mfjson, srid));

        public static IntPtr tgeographyinst_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeographyinst_in(str));

        public static IntPtr tgeographyseq_from_mfjson(IntPtr mfjson, int srid, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeographyseq_from_mfjson(mfjson, srid, interp));

        public static IntPtr tgeographyseq_in(string str, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeographyseq_in(str, interp));

        public static IntPtr tgeographyseqset_from_mfjson(IntPtr mfjson, int srid, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeographyseqset_from_mfjson(mfjson, srid, interp));

        public static IntPtr tgeographyseqset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeographyseqset_in(str));

        public static IntPtr tgeometryinst_from_mfjson(IntPtr mfjson, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeometryinst_from_mfjson(mfjson, srid));

        public static IntPtr tgeometryinst_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeometryinst_in(str));

        public static IntPtr tgeometryseq_from_mfjson(IntPtr mfjson, int srid, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeometryseq_from_mfjson(mfjson, srid, interp));

        public static IntPtr tgeometryseq_in(string str, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeometryseq_in(str, interp));

        public static IntPtr tgeometryseqset_from_mfjson(IntPtr mfjson, int srid, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeometryseqset_from_mfjson(mfjson, srid, interp));

        public static IntPtr tgeometryseqset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeometryseqset_in(str));

        public static void tspatial_set_stbox(IntPtr temp, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tspatial_set_stbox(temp, box));

        public static void tgeoinst_set_stbox(IntPtr inst, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tgeoinst_set_stbox(inst, box));

        public static void tspatialseq_set_stbox(IntPtr seq, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tspatialseq_set_stbox(seq, box));

        public static void tspatialseqset_set_stbox(IntPtr ss, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tspatialseqset_set_stbox(ss, box));

        public static IntPtr tgeo_restrict_elevation(IntPtr temp, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_restrict_elevation(temp, s, atfunc));

        public static IntPtr tgeo_restrict_geom(IntPtr temp, IntPtr gs, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_restrict_geom(temp, gs, atfunc));

        public static IntPtr tgeo_restrict_stbox(IntPtr temp, IntPtr box, bool border_inc, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_restrict_stbox(temp, box, border_inc, atfunc));

        public static IntPtr tgeoinst_restrict_geom(IntPtr inst, IntPtr gs, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeoinst_restrict_geom(inst, gs, atfunc));

        public static IntPtr tgeoinst_restrict_stbox(IntPtr inst, IntPtr box, bool border_inc, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeoinst_restrict_stbox(inst, box, border_inc, atfunc));

        public static IntPtr tgeoseq_restrict_geom(IntPtr seq, IntPtr gs, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeoseq_restrict_geom(seq, gs, atfunc));

        public static IntPtr tgeoseq_restrict_stbox(IntPtr seq, IntPtr box, bool border_inc, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeoseq_restrict_stbox(seq, box, border_inc, atfunc));

        public static IntPtr tgeoseqset_restrict_geom(IntPtr ss, IntPtr gs, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeoseqset_restrict_geom(ss, gs, atfunc));

        public static IntPtr tgeoseqset_restrict_stbox(IntPtr ss, IntPtr box, bool border_inc, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeoseqset_restrict_stbox(ss, box, border_inc, atfunc));

        public static int spatial_srid(ulong d, int basetype)
            => SafeExecution<int>(() => MEOSExternalFunctions.spatial_srid(d, basetype));

        public static bool spatial_set_srid(ulong d, int basetype, int srid)
            => SafeExecution<bool>(() => MEOSExternalFunctions.spatial_set_srid(d, basetype, srid));

        public static int tspatialinst_srid(IntPtr inst)
            => SafeExecution<int>(() => MEOSExternalFunctions.tspatialinst_srid(inst));

        public static IntPtr tpointseq_azimuth(IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpointseq_azimuth(seq));

        public static IntPtr tpointseq_cumulative_length(IntPtr seq, double prevlength)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpointseq_cumulative_length(seq, prevlength));

        public static bool tpointseq_is_simple(IntPtr seq)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpointseq_is_simple(seq));

        public static double tpointseq_length(IntPtr seq)
            => SafeExecution<double>(() => MEOSExternalFunctions.tpointseq_length(seq));

        public static IntPtr tpointseq_linear_trajectory(IntPtr seq, bool unary_union)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpointseq_linear_trajectory(seq, unary_union));

        public static IntPtr tgeoseq_stboxes(IntPtr seq, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeoseq_stboxes(seq, count));

        public static IntPtr tgeoseq_split_n_stboxes(IntPtr seq, int max_count, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeoseq_split_n_stboxes(seq, max_count, count));

        public static IntPtr tpointseqset_azimuth(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpointseqset_azimuth(ss));

        public static IntPtr tpointseqset_cumulative_length(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpointseqset_cumulative_length(ss));

        public static bool tpointseqset_is_simple(IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpointseqset_is_simple(ss));

        public static double tpointseqset_length(IntPtr ss)
            => SafeExecution<double>(() => MEOSExternalFunctions.tpointseqset_length(ss));

        public static IntPtr tgeoseqset_stboxes(IntPtr ss, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeoseqset_stboxes(ss, count));

        public static IntPtr tgeoseqset_split_n_stboxes(IntPtr ss, int max_count, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeoseqset_split_n_stboxes(ss, max_count, count));

        public static IntPtr tpoint_get_coord(IntPtr temp, int coord)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_get_coord(temp, coord));

        public static IntPtr tgeominst_tgeoginst(IntPtr inst, bool oper)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeominst_tgeoginst(inst, oper));

        public static IntPtr tgeomseq_tgeogseq(IntPtr seq, bool oper)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeomseq_tgeogseq(seq, oper));

        public static IntPtr tgeomseqset_tgeogseqset(IntPtr ss, bool oper)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeomseqset_tgeogseqset(ss, oper));

        public static IntPtr tgeom_tgeog(IntPtr temp, bool oper)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeom_tgeog(temp, oper));

        public static IntPtr tgeo_tpoint(IntPtr temp, bool oper)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_tpoint(temp, oper));

        public static void tspatialinst_set_srid(IntPtr inst, int srid)
            => SafeExecution(() => MEOSExternalFunctions.tspatialinst_set_srid(inst, srid));

        public static IntPtr tpointseq_make_simple(IntPtr seq, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpointseq_make_simple(seq, count));

        public static void tspatialseq_set_srid(IntPtr seq, int srid)
            => SafeExecution(() => MEOSExternalFunctions.tspatialseq_set_srid(seq, srid));

        public static IntPtr tpointseqset_make_simple(IntPtr ss, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpointseqset_make_simple(ss, count));

        public static void tspatialseqset_set_srid(IntPtr ss, int srid)
            => SafeExecution(() => MEOSExternalFunctions.tspatialseqset_set_srid(ss, srid));

        public static IntPtr tpointseq_twcentroid(IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpointseq_twcentroid(seq));

        public static IntPtr tpointseqset_twcentroid(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpointseqset_twcentroid(ss));

        public static string npoint_as_ewkt(IntPtr np, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.npoint_as_ewkt(np, maxdd));

        public static string npoint_as_hexwkb(IntPtr np, IntPtr variant, IntPtr size_out)
            => SafeExecution<string>(() => MEOSExternalFunctions.npoint_as_hexwkb(np, variant, size_out));

        public static string npoint_as_text(IntPtr np, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.npoint_as_text(np, maxdd));

        public static IntPtr npoint_as_wkb(IntPtr np, IntPtr variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.npoint_as_wkb(np, variant, size_out));

        public static IntPtr npoint_from_hexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.npoint_from_hexwkb(hexwkb));

        public static IntPtr npoint_from_wkb(IntPtr wkb, ulong size)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.npoint_from_wkb(wkb, size));

        public static IntPtr npoint_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.npoint_in(str));

        public static string npoint_out(IntPtr np, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.npoint_out(np, maxdd));

        public static IntPtr nsegment_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nsegment_in(str));

        public static string nsegment_out(IntPtr ns, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.nsegment_out(ns, maxdd));

        public static IntPtr npoint_make(long rid, double pos)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.npoint_make(rid, pos));

        public static IntPtr nsegment_make(long rid, double pos1, double pos2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nsegment_make(rid, pos1, pos2));

        public static IntPtr geompoint_to_npoint(IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geompoint_to_npoint(gs));

        public static IntPtr geom_to_nsegment(IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geom_to_nsegment(gs));

        public static IntPtr npoint_to_geompoint(IntPtr np)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.npoint_to_geompoint(np));

        public static IntPtr npoint_to_nsegment(IntPtr np)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.npoint_to_nsegment(np));

        public static IntPtr npoint_to_stbox(IntPtr np)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.npoint_to_stbox(np));

        public static IntPtr nsegment_to_geom(IntPtr ns)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nsegment_to_geom(ns));

        public static IntPtr nsegment_to_stbox(IntPtr np)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nsegment_to_stbox(np));

        public static uint npoint_hash(IntPtr np)
            => SafeExecution<uint>(() => MEOSExternalFunctions.npoint_hash(np));

        public static ulong npoint_hash_extended(IntPtr np, ulong seed)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.npoint_hash_extended(np, seed));

        public static double npoint_position(IntPtr np)
            => SafeExecution<double>(() => MEOSExternalFunctions.npoint_position(np));

        public static long npoint_route(IntPtr np)
            => SafeExecution<long>(() => MEOSExternalFunctions.npoint_route(np));

        public static double nsegment_end_position(IntPtr ns)
            => SafeExecution<double>(() => MEOSExternalFunctions.nsegment_end_position(ns));

        public static long nsegment_route(IntPtr ns)
            => SafeExecution<long>(() => MEOSExternalFunctions.nsegment_route(ns));

        public static double nsegment_start_position(IntPtr ns)
            => SafeExecution<double>(() => MEOSExternalFunctions.nsegment_start_position(ns));

        public static bool route_exists(long rid)
            => SafeExecution<bool>(() => MEOSExternalFunctions.route_exists(rid));

        public static IntPtr route_geom(long rid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.route_geom(rid));

        public static double route_length(long rid)
            => SafeExecution<double>(() => MEOSExternalFunctions.route_length(rid));

        public static IntPtr npoint_round(IntPtr np, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.npoint_round(np, maxdd));

        public static IntPtr nsegment_round(IntPtr ns, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nsegment_round(ns, maxdd));

        public static int get_srid_ways()
            => SafeExecution<int>(() => MEOSExternalFunctions.get_srid_ways());

        public static int npoint_srid(IntPtr np)
            => SafeExecution<int>(() => MEOSExternalFunctions.npoint_srid(np));

        public static int nsegment_srid(IntPtr ns)
            => SafeExecution<int>(() => MEOSExternalFunctions.nsegment_srid(ns));

        public static IntPtr npoint_timestamptz_to_stbox(IntPtr np, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.npoint_timestamptz_to_stbox(np, t));

        public static IntPtr npoint_tstzspan_to_stbox(IntPtr np, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.npoint_tstzspan_to_stbox(np, s));

        public static int npoint_cmp(IntPtr np1, IntPtr np2)
            => SafeExecution<int>(() => MEOSExternalFunctions.npoint_cmp(np1, np2));

        public static bool npoint_eq(IntPtr np1, IntPtr np2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.npoint_eq(np1, np2));

        public static bool npoint_ge(IntPtr np1, IntPtr np2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.npoint_ge(np1, np2));

        public static bool npoint_gt(IntPtr np1, IntPtr np2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.npoint_gt(np1, np2));

        public static bool npoint_le(IntPtr np1, IntPtr np2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.npoint_le(np1, np2));

        public static bool npoint_lt(IntPtr np1, IntPtr np2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.npoint_lt(np1, np2));

        public static bool npoint_ne(IntPtr np1, IntPtr np2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.npoint_ne(np1, np2));

        public static bool npoint_same(IntPtr np1, IntPtr np2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.npoint_same(np1, np2));

        public static int nsegment_cmp(IntPtr ns1, IntPtr ns2)
            => SafeExecution<int>(() => MEOSExternalFunctions.nsegment_cmp(ns1, ns2));

        public static bool nsegment_eq(IntPtr ns1, IntPtr ns2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.nsegment_eq(ns1, ns2));

        public static bool nsegment_ge(IntPtr ns1, IntPtr ns2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.nsegment_ge(ns1, ns2));

        public static bool nsegment_gt(IntPtr ns1, IntPtr ns2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.nsegment_gt(ns1, ns2));

        public static bool nsegment_le(IntPtr ns1, IntPtr ns2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.nsegment_le(ns1, ns2));

        public static bool nsegment_lt(IntPtr ns1, IntPtr ns2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.nsegment_lt(ns1, ns2));

        public static bool nsegment_ne(IntPtr ns1, IntPtr ns2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.nsegment_ne(ns1, ns2));

        public static IntPtr npointset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.npointset_in(str));

        public static string npointset_out(IntPtr s, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.npointset_out(s, maxdd));

        public static IntPtr npointset_make(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.npointset_make(values, count));

        public static IntPtr npoint_to_set(IntPtr np)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.npoint_to_set(np));

        public static IntPtr npointset_end_value(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.npointset_end_value(s));

        public static IntPtr npointset_routes(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.npointset_routes(s));

        public static IntPtr npointset_start_value(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.npointset_start_value(s));

        public static bool npointset_value_n(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.npointset_value_n(s, n, result));

        public static IntPtr[] npointset_values(IntPtr s)
        {
            int _n = (int)MEOSExposedFunctions.set_num_values(s);
            IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.npointset_values(s));
            IntPtr[] _out = new IntPtr[_n];
            for (int _i = 0; _i < _n; _i++)
            { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
            return _out;
        }

        public static bool contained_npoint_set(IntPtr np, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_npoint_set(np, s));

        public static bool contains_set_npoint(IntPtr s, IntPtr np)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_set_npoint(s, np));

        public static IntPtr intersection_npoint_set(IntPtr np, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_npoint_set(np, s));

        public static IntPtr intersection_set_npoint(IntPtr s, IntPtr np)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_set_npoint(s, np));

        public static IntPtr minus_npoint_set(IntPtr np, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_npoint_set(np, s));

        public static IntPtr minus_set_npoint(IntPtr s, IntPtr np)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_set_npoint(s, np));

        public static IntPtr npoint_union_transfn(IntPtr state, IntPtr np)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.npoint_union_transfn(state, np));

        public static IntPtr union_npoint_set(IntPtr np, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_npoint_set(np, s));

        public static IntPtr union_set_npoint(IntPtr s, IntPtr np)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_set_npoint(s, np));

        public static IntPtr tnpoint_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_in(str));

        public static string tnpoint_out(IntPtr temp, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.tnpoint_out(temp, maxdd));

        public static IntPtr tnpointinst_make(IntPtr np, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpointinst_make(np, t));

        public static IntPtr tgeompoint_to_tnpoint(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeompoint_to_tnpoint(temp));

        public static IntPtr tnpoint_to_tgeompoint(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_to_tgeompoint(temp));

        public static IntPtr tnpoint_cumulative_length(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_cumulative_length(temp));

        public static double tnpoint_length(IntPtr temp)
            => SafeExecution<double>(() => MEOSExternalFunctions.tnpoint_length(temp));

        public static IntPtr tnpoint_positions(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_positions(temp, count));

        public static long tnpoint_route(IntPtr temp)
            => SafeExecution<long>(() => MEOSExternalFunctions.tnpoint_route(temp));

        public static IntPtr tnpoint_routes(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_routes(temp));

        public static IntPtr tnpoint_speed(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_speed(temp));

        public static IntPtr tnpoint_trajectory(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_trajectory(temp));

        public static IntPtr tnpoint_twcentroid(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_twcentroid(temp));

        public static IntPtr tnpoint_at_geom(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_at_geom(temp, gs));

        public static IntPtr tnpoint_at_npoint(IntPtr temp, IntPtr np)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_at_npoint(temp, np));

        public static IntPtr tnpoint_at_npointset(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_at_npointset(temp, s));

        public static IntPtr tnpoint_at_stbox(IntPtr temp, IntPtr box, bool border_inc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_at_stbox(temp, box, border_inc));

        public static IntPtr tnpoint_minus_geom(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_minus_geom(temp, gs));

        public static IntPtr tnpoint_minus_npoint(IntPtr temp, IntPtr np)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_minus_npoint(temp, np));

        public static IntPtr tnpoint_minus_npointset(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_minus_npointset(temp, s));

        public static IntPtr tnpoint_minus_stbox(IntPtr temp, IntPtr box, bool border_inc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_minus_stbox(temp, box, border_inc));

        public static IntPtr tdistance_tnpoint_npoint(IntPtr temp, IntPtr np)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdistance_tnpoint_npoint(temp, np));

        public static IntPtr tdistance_tnpoint_point(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdistance_tnpoint_point(temp, gs));

        public static IntPtr tdistance_tnpoint_tnpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdistance_tnpoint_tnpoint(temp1, temp2));

        public static double nad_tnpoint_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tnpoint_geo(temp, gs));

        public static double nad_tnpoint_npoint(IntPtr temp, IntPtr np)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tnpoint_npoint(temp, np));

        public static double nad_tnpoint_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tnpoint_stbox(temp, box));

        public static double nad_tnpoint_tnpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tnpoint_tnpoint(temp1, temp2));

        public static IntPtr nai_tnpoint_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nai_tnpoint_geo(temp, gs));

        public static IntPtr nai_tnpoint_npoint(IntPtr temp, IntPtr np)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nai_tnpoint_npoint(temp, np));

        public static IntPtr nai_tnpoint_tnpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nai_tnpoint_tnpoint(temp1, temp2));

        public static IntPtr shortestline_tnpoint_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.shortestline_tnpoint_geo(temp, gs));

        public static IntPtr shortestline_tnpoint_npoint(IntPtr temp, IntPtr np)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.shortestline_tnpoint_npoint(temp, np));

        public static IntPtr shortestline_tnpoint_tnpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.shortestline_tnpoint_tnpoint(temp1, temp2));

        public static IntPtr tnpoint_tcentroid_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_tcentroid_transfn(state, temp));

        public static int always_eq_npoint_tnpoint(IntPtr np, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_npoint_tnpoint(np, temp));

        public static int always_eq_tnpoint_npoint(IntPtr temp, IntPtr np)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_tnpoint_npoint(temp, np));

        public static int always_eq_tnpoint_tnpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_tnpoint_tnpoint(temp1, temp2));

        public static int always_ne_npoint_tnpoint(IntPtr np, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_npoint_tnpoint(np, temp));

        public static int always_ne_tnpoint_npoint(IntPtr temp, IntPtr np)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_tnpoint_npoint(temp, np));

        public static int always_ne_tnpoint_tnpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_tnpoint_tnpoint(temp1, temp2));

        public static int ever_eq_npoint_tnpoint(IntPtr np, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_npoint_tnpoint(np, temp));

        public static int ever_eq_tnpoint_npoint(IntPtr temp, IntPtr np)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_tnpoint_npoint(temp, np));

        public static int ever_eq_tnpoint_tnpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_tnpoint_tnpoint(temp1, temp2));

        public static int ever_ne_npoint_tnpoint(IntPtr np, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_npoint_tnpoint(np, temp));

        public static int ever_ne_tnpoint_npoint(IntPtr temp, IntPtr np)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_tnpoint_npoint(temp, np));

        public static int ever_ne_tnpoint_tnpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_tnpoint_tnpoint(temp1, temp2));

        public static IntPtr teq_tnpoint_npoint(IntPtr temp, IntPtr np)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_tnpoint_npoint(temp, np));

        public static IntPtr tne_tnpoint_npoint(IntPtr temp, IntPtr np)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_tnpoint_npoint(temp, np));

        public static string pose_as_ewkt(IntPtr pose, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.pose_as_ewkt(pose, maxdd));

        public static string pose_as_hexwkb(IntPtr pose, IntPtr variant, IntPtr size)
            => SafeExecution<string>(() => MEOSExternalFunctions.pose_as_hexwkb(pose, variant, size));

        public static string pose_as_text(IntPtr pose, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.pose_as_text(pose, maxdd));

        public static IntPtr pose_as_wkb(IntPtr pose, IntPtr variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_as_wkb(pose, variant, size_out));

        public static IntPtr pose_from_wkb(IntPtr wkb, ulong size)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_from_wkb(wkb, size));

        public static IntPtr pose_from_hexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_from_hexwkb(hexwkb));

        public static IntPtr pose_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_in(str));

        public static string pose_out(IntPtr pose, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.pose_out(pose, maxdd));

        public static IntPtr pose_copy(IntPtr pose)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_copy(pose));

        public static IntPtr pose_make_2d(double x, double y, double theta, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_make_2d(x, y, theta, srid));

        public static IntPtr pose_make_3d(double x, double y, double z, double W, double X, double Y, double Z, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_make_3d(x, y, z, W, X, Y, Z, srid));

        public static IntPtr pose_make_point2d(IntPtr gs, double theta)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_make_point2d(gs, theta));

        public static IntPtr pose_make_point3d(IntPtr gs, double W, double X, double Y, double Z)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_make_point3d(gs, W, X, Y, Z));

        public static IntPtr pose_to_point(IntPtr pose)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_to_point(pose));

        public static IntPtr pose_to_stbox(IntPtr pose)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_to_stbox(pose));

        public static uint pose_hash(IntPtr pose)
            => SafeExecution<uint>(() => MEOSExternalFunctions.pose_hash(pose));

        public static ulong pose_hash_extended(IntPtr pose, ulong seed)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.pose_hash_extended(pose, seed));

        public static IntPtr pose_orientation(IntPtr pose)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_orientation(pose));

        public static double pose_rotation(IntPtr pose)
            => SafeExecution<double>(() => MEOSExternalFunctions.pose_rotation(pose));

        public static IntPtr pose_round(IntPtr pose, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_round(pose, maxdd));

        public static IntPtr posearr_round(IntPtr posearr, int count, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.posearr_round(posearr, count, maxdd));

        public static void pose_set_srid(IntPtr pose, int srid)
            => SafeExecution(() => MEOSExternalFunctions.pose_set_srid(pose, srid));

        public static int pose_srid(IntPtr pose)
            => SafeExecution<int>(() => MEOSExternalFunctions.pose_srid(pose));

        public static IntPtr pose_transform(IntPtr pose, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_transform(pose, srid));

        public static IntPtr pose_transform_pipeline(IntPtr pose, string pipelinestr, int srid, bool is_forward)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_transform_pipeline(pose, pipelinestr, srid, is_forward));

        public static IntPtr pose_tstzspan_to_stbox(IntPtr pose, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_tstzspan_to_stbox(pose, s));

        public static IntPtr pose_timestamptz_to_stbox(IntPtr pose, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_timestamptz_to_stbox(pose, t));

        public static double distance_pose_geo(IntPtr pose, IntPtr gs)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_pose_geo(pose, gs));

        public static double distance_pose_pose(IntPtr pose1, IntPtr pose2)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_pose_pose(pose1, pose2));

        public static double distance_pose_stbox(IntPtr pose, IntPtr box)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_pose_stbox(pose, box));

        public static int pose_cmp(IntPtr pose1, IntPtr pose2)
            => SafeExecution<int>(() => MEOSExternalFunctions.pose_cmp(pose1, pose2));

        public static bool pose_eq(IntPtr pose1, IntPtr pose2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pose_eq(pose1, pose2));

        public static bool pose_ge(IntPtr pose1, IntPtr pose2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pose_ge(pose1, pose2));

        public static bool pose_gt(IntPtr pose1, IntPtr pose2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pose_gt(pose1, pose2));

        public static bool pose_le(IntPtr pose1, IntPtr pose2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pose_le(pose1, pose2));

        public static bool pose_lt(IntPtr pose1, IntPtr pose2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pose_lt(pose1, pose2));

        public static bool pose_ne(IntPtr pose1, IntPtr pose2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pose_ne(pose1, pose2));

        public static bool pose_nsame(IntPtr pose1, IntPtr pose2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pose_nsame(pose1, pose2));

        public static bool pose_same(IntPtr pose1, IntPtr pose2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pose_same(pose1, pose2));

        public static IntPtr poseset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.poseset_in(str));

        public static string poseset_out(IntPtr s, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.poseset_out(s, maxdd));

        public static IntPtr poseset_make(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.poseset_make(values, count));

        public static IntPtr pose_to_set(IntPtr pose)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_to_set(pose));

        public static IntPtr poseset_end_value(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.poseset_end_value(s));

        public static IntPtr poseset_start_value(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.poseset_start_value(s));

        public static bool poseset_value_n(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.poseset_value_n(s, n, result));

        public static IntPtr[] poseset_values(IntPtr s)
        {
            int _n = (int)MEOSExposedFunctions.set_num_values(s);
            IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.poseset_values(s));
            IntPtr[] _out = new IntPtr[_n];
            for (int _i = 0; _i < _n; _i++)
            { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
            return _out;
        }

        public static bool contained_pose_set(IntPtr pose, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_pose_set(pose, s));

        public static bool contains_set_pose(IntPtr s, IntPtr pose)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_set_pose(s, pose));

        public static IntPtr intersection_pose_set(IntPtr pose, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_pose_set(pose, s));

        public static IntPtr intersection_set_pose(IntPtr s, IntPtr pose)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_set_pose(s, pose));

        public static IntPtr minus_pose_set(IntPtr pose, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_pose_set(pose, s));

        public static IntPtr minus_set_pose(IntPtr s, IntPtr pose)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_set_pose(s, pose));

        public static IntPtr pose_union_transfn(IntPtr state, IntPtr pose)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_union_transfn(state, pose));

        public static IntPtr union_pose_set(IntPtr pose, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_pose_set(pose, s));

        public static IntPtr union_set_pose(IntPtr s, IntPtr pose)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_set_pose(s, pose));

        public static IntPtr tpose_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_in(str));

        public static IntPtr tpose_make(IntPtr tpoint, IntPtr tradius)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_make(tpoint, tradius));

        public static IntPtr tpose_to_tpoint(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_to_tpoint(temp));

        public static IntPtr tpose_end_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_end_value(temp));

        public static IntPtr tpose_points(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_points(temp));

        public static IntPtr tpose_rotation(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_rotation(temp));

        public static IntPtr tpose_start_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_start_value(temp));

        public static IntPtr tpose_trajectory(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_trajectory(temp));

        public static bool tpose_value_at_timestamptz(IntPtr temp, long t, bool strict, IntPtr value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpose_value_at_timestamptz(temp, t, strict, value));

        public static bool tpose_value_n(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpose_value_n(temp, n, result));

        public static IntPtr tpose_values(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_values(temp, count));

        public static IntPtr tpose_at_geom(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_at_geom(temp, gs));

        public static IntPtr tpose_at_stbox(IntPtr temp, IntPtr box, bool border_inc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_at_stbox(temp, box, border_inc));

        public static IntPtr tpose_at_pose(IntPtr temp, IntPtr pose)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_at_pose(temp, pose));

        public static IntPtr tpose_minus_geom(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_minus_geom(temp, gs));

        public static IntPtr tpose_minus_pose(IntPtr temp, IntPtr pose)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_minus_pose(temp, pose));

        public static IntPtr tpose_minus_stbox(IntPtr temp, IntPtr box, bool border_inc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_minus_stbox(temp, box, border_inc));

        public static IntPtr tdistance_tpose_pose(IntPtr temp, IntPtr pose)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdistance_tpose_pose(temp, pose));

        public static IntPtr tdistance_tpose_point(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdistance_tpose_point(temp, gs));

        public static IntPtr tdistance_tpose_tpose(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdistance_tpose_tpose(temp1, temp2));

        public static double nad_tpose_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tpose_geo(temp, gs));

        public static double nad_tpose_pose(IntPtr temp, IntPtr pose)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tpose_pose(temp, pose));

        public static double nad_tpose_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tpose_stbox(temp, box));

        public static double nad_tpose_tpose(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tpose_tpose(temp1, temp2));

        public static IntPtr nai_tpose_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nai_tpose_geo(temp, gs));

        public static IntPtr nai_tpose_pose(IntPtr temp, IntPtr pose)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nai_tpose_pose(temp, pose));

        public static IntPtr nai_tpose_tpose(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nai_tpose_tpose(temp1, temp2));

        public static IntPtr shortestline_tpose_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.shortestline_tpose_geo(temp, gs));

        public static IntPtr shortestline_tpose_pose(IntPtr temp, IntPtr pose)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.shortestline_tpose_pose(temp, pose));

        public static IntPtr shortestline_tpose_tpose(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.shortestline_tpose_tpose(temp1, temp2));

        public static int always_eq_pose_tpose(IntPtr pose, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_pose_tpose(pose, temp));

        public static int always_eq_tpose_pose(IntPtr temp, IntPtr pose)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_tpose_pose(temp, pose));

        public static int always_eq_tpose_tpose(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_tpose_tpose(temp1, temp2));

        public static int always_ne_pose_tpose(IntPtr pose, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_pose_tpose(pose, temp));

        public static int always_ne_tpose_pose(IntPtr temp, IntPtr pose)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_tpose_pose(temp, pose));

        public static int always_ne_tpose_tpose(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_tpose_tpose(temp1, temp2));

        public static int ever_eq_pose_tpose(IntPtr pose, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_pose_tpose(pose, temp));

        public static int ever_eq_tpose_pose(IntPtr temp, IntPtr pose)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_tpose_pose(temp, pose));

        public static int ever_eq_tpose_tpose(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_tpose_tpose(temp1, temp2));

        public static int ever_ne_pose_tpose(IntPtr pose, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_pose_tpose(pose, temp));

        public static int ever_ne_tpose_pose(IntPtr temp, IntPtr pose)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_tpose_pose(temp, pose));

        public static int ever_ne_tpose_tpose(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_tpose_tpose(temp1, temp2));

        public static IntPtr teq_pose_tpose(IntPtr pose, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_pose_tpose(pose, temp));

        public static IntPtr teq_tpose_pose(IntPtr temp, IntPtr pose)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_tpose_pose(temp, pose));

        public static IntPtr tne_pose_tpose(IntPtr pose, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_pose_tpose(pose, temp));

        public static IntPtr tne_tpose_pose(IntPtr temp, IntPtr pose)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_tpose_pose(temp, pose));

        public static string trgeo_out(IntPtr temp)
            => SafeExecution<string>(() => MEOSExternalFunctions.trgeo_out(temp));

        public static IntPtr trgeoinst_make(IntPtr geom, IntPtr pose, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeoinst_make(geom, pose, t));

        public static IntPtr geo_tpose_to_trgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_tpose_to_trgeo(gs, temp));

        public static IntPtr trgeo_to_tpose(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_to_tpose(temp));

        public static IntPtr trgeo_to_tpoint(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_to_tpoint(temp));

        public static IntPtr trgeo_end_instant(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_end_instant(temp));

        public static IntPtr trgeo_end_sequence(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_end_sequence(temp));

        public static IntPtr trgeo_end_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_end_value(temp));

        public static IntPtr trgeo_geom(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_geom(temp));

        public static IntPtr trgeo_instant_n(IntPtr temp, int n)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_instant_n(temp, n));

        public static IntPtr trgeo_instants(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_instants(temp, count));

        public static IntPtr trgeo_points(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_points(temp));

        public static IntPtr trgeo_rotation(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_rotation(temp));

        public static IntPtr trgeo_segments(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_segments(temp, count));

        public static IntPtr trgeo_sequence_n(IntPtr temp, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_sequence_n(temp, i));

        public static IntPtr trgeo_sequences(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_sequences(temp, count));

        public static IntPtr trgeo_start_instant(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_start_instant(temp));

        public static IntPtr trgeo_start_sequence(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_start_sequence(temp));

        public static IntPtr trgeo_start_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_start_value(temp));

        public static bool trgeo_value_n(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.trgeo_value_n(temp, n, result));

        public static IntPtr trgeo_traversed_area(IntPtr temp, bool unary_union)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_traversed_area(temp, unary_union));

        public static IntPtr trgeo_append_tinstant(IntPtr temp, IntPtr inst, int interp, double maxdist, IntPtr maxt, bool expand)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_append_tinstant(temp, inst, interp, maxdist, maxt, expand));

        public static IntPtr trgeo_append_tsequence(IntPtr temp, IntPtr seq, bool expand)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_append_tsequence(temp, seq, expand));

        public static IntPtr trgeo_delete_timestamptz(IntPtr temp, long t, bool connect)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_delete_timestamptz(temp, t, connect));

        public static IntPtr trgeo_delete_tstzset(IntPtr temp, IntPtr s, bool connect)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_delete_tstzset(temp, s, connect));

        public static IntPtr trgeo_delete_tstzspan(IntPtr temp, IntPtr s, bool connect)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_delete_tstzspan(temp, s, connect));

        public static IntPtr trgeo_delete_tstzspanset(IntPtr temp, IntPtr ss, bool connect)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_delete_tstzspanset(temp, ss, connect));

        public static IntPtr trgeo_round(IntPtr temp, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_round(temp, maxdd));

        public static IntPtr trgeo_set_interp(IntPtr temp, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_set_interp(temp, interp));

        public static IntPtr trgeo_to_tinstant(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_to_tinstant(temp));

        public static IntPtr trgeo_after_timestamptz(IntPtr temp, long t, bool strict)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_after_timestamptz(temp, t, strict));

        public static IntPtr trgeo_before_timestamptz(IntPtr temp, long t, bool strict)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_before_timestamptz(temp, t, strict));

        public static IntPtr trgeo_restrict_value(IntPtr temp, ulong value, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_restrict_value(temp, value, atfunc));

        public static IntPtr trgeo_restrict_values(IntPtr temp, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_restrict_values(temp, s, atfunc));

        public static IntPtr trgeo_restrict_timestamptz(IntPtr temp, long t, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_restrict_timestamptz(temp, t, atfunc));

        public static IntPtr trgeo_restrict_tstzset(IntPtr temp, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_restrict_tstzset(temp, s, atfunc));

        public static IntPtr trgeo_restrict_tstzspan(IntPtr temp, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_restrict_tstzspan(temp, s, atfunc));

        public static IntPtr trgeo_restrict_tstzspanset(IntPtr temp, IntPtr ss, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_restrict_tstzspanset(temp, ss, atfunc));

        public static IntPtr tdistance_trgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdistance_trgeo_geo(temp, gs));

        public static IntPtr tdistance_trgeo_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdistance_trgeo_tpoint(temp1, temp2));

        public static IntPtr tdistance_trgeo_trgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdistance_trgeo_trgeo(temp1, temp2));

        public static double nad_stbox_trgeo(IntPtr box, IntPtr temp)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_stbox_trgeo(box, temp));

        public static double nad_trgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_trgeo_geo(temp, gs));

        public static double nad_trgeo_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_trgeo_stbox(temp, box));

        public static double nad_trgeo_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_trgeo_tpoint(temp1, temp2));

        public static double nad_trgeo_trgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_trgeo_trgeo(temp1, temp2));

        public static IntPtr nai_trgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nai_trgeo_geo(temp, gs));

        public static IntPtr nai_trgeo_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nai_trgeo_tpoint(temp1, temp2));

        public static IntPtr nai_trgeo_trgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nai_trgeo_trgeo(temp1, temp2));

        public static IntPtr shortestline_trgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.shortestline_trgeo_geo(temp, gs));

        public static IntPtr shortestline_trgeo_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.shortestline_trgeo_tpoint(temp1, temp2));

        public static IntPtr shortestline_trgeo_trgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.shortestline_trgeo_trgeo(temp1, temp2));

        public static int always_eq_geo_trgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_geo_trgeo(gs, temp));

        public static int always_eq_trgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_trgeo_geo(temp, gs));

        public static int always_eq_trgeo_trgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_trgeo_trgeo(temp1, temp2));

        public static int always_ne_geo_trgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_geo_trgeo(gs, temp));

        public static int always_ne_trgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_trgeo_geo(temp, gs));

        public static int always_ne_trgeo_trgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_trgeo_trgeo(temp1, temp2));

        public static int ever_eq_geo_trgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_geo_trgeo(gs, temp));

        public static int ever_eq_trgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_trgeo_geo(temp, gs));

        public static int ever_eq_trgeo_trgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_trgeo_trgeo(temp1, temp2));

        public static int ever_ne_geo_trgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_geo_trgeo(gs, temp));

        public static int ever_ne_trgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_trgeo_geo(temp, gs));

        public static int ever_ne_trgeo_trgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_trgeo_trgeo(temp1, temp2));

        public static IntPtr teq_geo_trgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_geo_trgeo(gs, temp));

        public static IntPtr teq_trgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_trgeo_geo(temp, gs));

        public static IntPtr tne_geo_trgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_geo_trgeo(gs, temp));

        public static IntPtr tne_trgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_trgeo_geo(temp, gs));

    }
}
