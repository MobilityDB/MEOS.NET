using System.CodeDom.Compiler;
using System.Runtime.InteropServices;

using MEOS.NET.Enums;

namespace MEOS.NET.Internal
{
    internal partial class MEOSExposedFunctions
    {
        [GeneratedCode("MEOS.NET.Builder.MEOSIDL", "0.1.0")]
        private partial class MEOSExternalFunctions
        {
            private const string DllPath = "meos";

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string describeH3Error(uint err);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint latLngToCell(IntPtr g, int res, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint cellToLatLng(ulong h3, IntPtr g);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint cellToBoundary(ulong h3, IntPtr gp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint maxGridDiskSize(int k, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint gridDiskUnsafe(ulong origin, int k, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint gridDiskDistancesUnsafe(ulong origin, int k, IntPtr @out, IntPtr distances);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint gridDiskDistancesSafe(ulong origin, int k, IntPtr @out, IntPtr distances);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint gridDisksUnsafe(IntPtr h3Set, int length, int k, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint gridDisk(ulong origin, int k, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint gridDiskDistances(ulong origin, int k, IntPtr @out, IntPtr distances);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint maxGridRingSize(int k, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint gridRingUnsafe(ulong origin, int k, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint gridRing(ulong origin, int k, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint maxPolygonToCellsSize(IntPtr geoPolygon, int res, uint flags, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint polygonToCells(IntPtr geoPolygon, int res, uint flags, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint maxPolygonToCellsSizeExperimental(IntPtr polygon, int res, uint flags, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint polygonToCellsExperimental(IntPtr polygon, int res, uint flags, long size, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint cellsToLinkedMultiPolygon(IntPtr h3Set, int numHexes, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void destroyLinkedMultiPolygon(IntPtr polygon);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double degsToRads(double degrees);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double radsToDegs(double radians);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double greatCircleDistanceRads(IntPtr a, IntPtr b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double greatCircleDistanceKm(IntPtr a, IntPtr b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double greatCircleDistanceM(IntPtr a, IntPtr b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint getHexagonAreaAvgKm2(int res, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint getHexagonAreaAvgM2(int res, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint cellAreaRads2(ulong h, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint cellAreaKm2(ulong h, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint cellAreaM2(ulong h, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint getHexagonEdgeLengthAvgKm(int res, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint getHexagonEdgeLengthAvgM(int res, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint edgeLengthRads(ulong edge, IntPtr length);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint edgeLengthKm(ulong edge, IntPtr length);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint edgeLengthM(ulong edge, IntPtr length);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint getNumCells(int res, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int res0CellCount();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint getRes0Cells(IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int pentagonCount();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint getPentagons(int res, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int getResolution(ulong h);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int getBaseCellNumber(ulong h);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint getIndexDigit(ulong h, int res, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint constructCell(int res, int baseCellNumber, IntPtr digits, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint stringToH3(string str, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint h3ToString(ulong h, string str, ulong sz);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int isValidCell(ulong h);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int isValidIndex(ulong h);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint cellToParent(ulong h, int parentRes, IntPtr parent);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint cellToChildrenSize(ulong h, int childRes, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint cellToChildren(ulong h, int childRes, IntPtr children);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint cellToCenterChild(ulong h, int childRes, IntPtr child);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint cellToChildPos(ulong child, int parentRes, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint childPosToCell(long childPos, ulong parent, int childRes, IntPtr child);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint compactCells(IntPtr h3Set, IntPtr compactedSet, long numHexes);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint uncompactCellsSize(IntPtr compactedSet, long numCompacted, int res, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint uncompactCells(IntPtr compactedSet, long numCompacted, IntPtr outSet, long numOut, int res);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int isResClassIII(ulong h);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int isPentagon(ulong h);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint maxFaceCount(ulong h3, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint getIcosahedronFaces(ulong h3, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint areNeighborCells(ulong origin, ulong destination, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint cellsToDirectedEdge(ulong origin, ulong destination, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int isValidDirectedEdge(ulong edge);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint getDirectedEdgeOrigin(ulong edge, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint getDirectedEdgeDestination(ulong edge, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint directedEdgeToCells(ulong edge, IntPtr originDestination);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint originToDirectedEdges(ulong origin, IntPtr edges);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint directedEdgeToBoundary(ulong edge, IntPtr gb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint cellToVertex(ulong origin, int vertexNum, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint cellToVertexes(ulong origin, IntPtr vertexes);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint vertexToLatLng(ulong vertex, IntPtr point);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int isValidVertex(ulong vertex);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint gridDistance(ulong origin, ulong h3, IntPtr distance);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint gridPathCellsSize(ulong start, ulong end, IntPtr size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint gridPathCells(ulong start, ulong end, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint cellToLocalIj(ulong origin, ulong h3, uint mode, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint localIjToCell(ulong origin, IntPtr ij, uint mode, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int date_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string date_out(int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int interval_cmp(IntPtr interv1, IntPtr interv2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr interval_in(string str, int typmod);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string interval_out(IntPtr interv);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long time_in(string str, int typmod);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string time_out(long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long timestamp_in(string str, int typmod);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string timestamp_out(long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long timestamptz_in(string str, int typmod);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string timestamptz_out(long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr meos_array_create(int elem_size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_array_add(IntPtr array, IntPtr value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr meos_array_get(IntPtr array, int n);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int meos_array_count(IntPtr array);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_array_reset(IntPtr array);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_array_reset_free(IntPtr array);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_array_destroy(IntPtr array);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_array_destroy_free(IntPtr array);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr rtree_create_intspan();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr rtree_create_bigintspan();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr rtree_create_floatspan();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr rtree_create_datespan();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr rtree_create_tstzspan();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr rtree_create_tbox();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr rtree_create_stbox();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void rtree_free(IntPtr rtree);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void rtree_insert(IntPtr rtree, IntPtr box, int id);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void rtree_insert_temporal(IntPtr rtree, IntPtr temp, int id);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int rtree_search(IntPtr rtree, IntPtr op, IntPtr query, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int rtree_search_temporal(IntPtr rtree, IntPtr op, IntPtr temp, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_error(int errlevel, int errcode, string format);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int meos_errno();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int meos_errno_set(int err);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int meos_errno_restore(int err);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int meos_errno_reset();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_initialize_timezone(string name);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_initialize_error_handler(IntPtr err_handler);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_finalize_timezone();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_finalize_projsrs();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_finalize_ways();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool meos_set_datestyle(string newval, IntPtr extra);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool meos_set_intervalstyle(string newval, int extra);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string meos_get_datestyle();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string meos_get_intervalstyle();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_set_spatial_ref_sys_csv(string path);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_initialize();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_finalize();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int add_date_int(int d, int days);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr add_interval_interval(IntPtr interv1, IntPtr interv2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long add_timestamptz_interval(long t, IntPtr interv);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool bool_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string bool_out([MarshalAs(UnmanagedType.U1)] bool b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cstring2text(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long date_to_timestamp(int dateVal);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long date_to_timestamptz(int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double float_exp(double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double float_ln(double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double float_log10(double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string float8_out(double d, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double float_round(double d, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int int32_cmp(int l, int r);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int int64_cmp(long l, long r);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr interval_make(int years, int months, int weeks, int days, int hours, int mins, double secs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int minus_date_date(int d1, int d2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int minus_date_int(int d, int days);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long minus_timestamptz_interval(long t, IntPtr interv);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_timestamptz_timestamptz(long t1, long t2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr mul_interval_double(IntPtr interv, double factor);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int pg_date_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string pg_date_out(int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int pg_interval_cmp(IntPtr interv1, IntPtr interv2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pg_interval_in(string str, int typmod);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string pg_interval_out(IntPtr interv);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long pg_timestamp_in(string str, int typmod);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string pg_timestamp_out(long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long pg_timestamptz_in(string str, int typmod);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string pg_timestamptz_out(long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string text2cstring(IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int text_cmp(IntPtr txt1, IntPtr txt2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr text_copy(IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr text_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr text_initcap(IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr text_lower(IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string text_out(IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr text_upper(IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr textcat_text_text(IntPtr txt1, IntPtr txt2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long timestamptz_shift(long t, IntPtr interv);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int timestamp_to_date(long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int timestamptz_to_date(long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string bigintset_out(IntPtr set);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintspan_expand(IntPtr s, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintspan_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string bigintspan_out(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintspanset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string bigintspanset_out(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr dateset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string dateset_out(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr datespan_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string datespan_out(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr datespanset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string datespanset_out(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string floatset_out(IntPtr set, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspan_expand(IntPtr s, double value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspan_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string floatspan_out(IntPtr s, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspanset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string floatspanset_out(IntPtr ss, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string intset_out(IntPtr set);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intspan_expand(IntPtr s, int value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intspan_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string intspan_out(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intspanset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string intspanset_out(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string set_as_hexwkb(IntPtr s, IntPtr variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_as_wkb(IntPtr s, IntPtr variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_from_hexwkb(string hexwkb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_from_wkb(IntPtr wkb, ulong size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string span_as_hexwkb(IntPtr s, IntPtr variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr span_as_wkb(IntPtr s, IntPtr variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr span_from_hexwkb(string hexwkb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr span_from_wkb(IntPtr wkb, ulong size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string spanset_as_hexwkb(IntPtr ss, IntPtr variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_as_wkb(IntPtr ss, IntPtr variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_from_hexwkb(string hexwkb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_from_wkb(IntPtr wkb, ulong size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr textset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string textset_out(IntPtr set);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tstzset_out(IntPtr set);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspan_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tstzspan_out(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspanset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tstzspanset_out(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintset_make(IntPtr values, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintspan_make(long lower, long upper, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr dateset_make(IntPtr values, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr datespan_make(int lower, int upper, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatset_make(IntPtr values, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspan_make(double lower, double upper, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intset_make(IntPtr values, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intspan_make(int lower, int upper, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_copy(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr span_copy(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_copy(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_make(IntPtr spans, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr textset_make(IntPtr values, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzset_make(IntPtr values, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspan_make(long lower, long upper, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigint_to_set(long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigint_to_span(int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigint_to_spanset(int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr date_to_set(int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr date_to_span(int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr date_to_spanset(int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr dateset_to_tstzset(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr datespan_to_tstzspan(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr datespanset_to_tstzspanset(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr float_to_set(double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr float_to_span(double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr float_to_spanset(double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatset_to_intset(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspan_to_intspan(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspanset_to_intspanset(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr int_to_set(int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr int_to_span(int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr int_to_spanset(int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intset_to_floatset(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intspan_to_floatspan(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intspanset_to_floatspanset(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_to_span(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_to_spanset(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr span_to_spanset(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr text_to_set(IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr timestamptz_to_set(long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr timestamptz_to_span(long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr timestamptz_to_spanset(long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzset_to_dateset(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspan_to_datespan(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspanset_to_datespanset(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long bigintset_end_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long bigintset_start_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool bigintset_value_n(IntPtr s, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintset_values(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long bigintspan_lower(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long bigintspan_upper(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long bigintspan_width(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long bigintspanset_lower(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long bigintspanset_upper(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long bigintspanset_width(IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool boundspan);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int dateset_end_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int dateset_start_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool dateset_value_n(IntPtr s, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr dateset_values(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr datespan_duration(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int datespan_lower(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int datespan_upper(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool datespanset_date_n(IntPtr ss, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr datespanset_dates(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr datespanset_duration(IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool boundspan);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int datespanset_end_date(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int datespanset_num_dates(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int datespanset_start_date(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double floatset_end_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double floatset_start_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool floatset_value_n(IntPtr s, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatset_values(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double floatspan_lower(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double floatspan_upper(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double floatspan_width(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double floatspanset_lower(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double floatspanset_upper(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double floatspanset_width(IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool boundspan);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int intset_end_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int intset_start_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool intset_value_n(IntPtr s, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intset_values(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int intspan_lower(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int intspan_upper(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int intspan_width(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int intspanset_lower(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int intspanset_upper(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int intspanset_width(IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool boundspan);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint set_hash(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong set_hash_extended(IntPtr s, ulong seed);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int set_num_values(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint span_hash(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong span_hash_extended(IntPtr s, ulong seed);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool span_lower_inc(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool span_upper_inc(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_end_span(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint spanset_hash(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong spanset_hash_extended(IntPtr ss, ulong seed);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool spanset_lower_inc(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int spanset_num_spans(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_span(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_span_n(IntPtr ss, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_spanarr(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_start_span(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool spanset_upper_inc(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr textset_end_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr textset_start_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool textset_value_n(IntPtr s, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr textset_values(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long tstzset_end_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long tstzset_start_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tstzset_value_n(IntPtr s, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzset_values(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspan_duration(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long tstzspan_lower(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long tstzspan_upper(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspanset_duration(IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool boundspan);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long tstzspanset_end_timestamptz(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long tstzspanset_lower(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tstzspanset_num_timestamps(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long tstzspanset_start_timestamptz(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspanset_timestamps(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tstzspanset_timestamptz_n(IntPtr ss, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long tstzspanset_upper(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintset_shift_scale(IntPtr s, long shift, long width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintspan_shift_scale(IntPtr s, long shift, long width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintspanset_shift_scale(IntPtr ss, long shift, long width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr dateset_shift_scale(IntPtr s, int shift, int width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr datespan_shift_scale(IntPtr s, int shift, int width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr datespanset_shift_scale(IntPtr ss, int shift, int width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatset_ceil(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatset_degrees(IntPtr s, [MarshalAs(UnmanagedType.U1)] bool normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatset_floor(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatset_radians(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatset_shift_scale(IntPtr s, double shift, double width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspan_ceil(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspan_degrees(IntPtr s, [MarshalAs(UnmanagedType.U1)] bool normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspan_floor(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspan_radians(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspan_round(IntPtr s, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspan_shift_scale(IntPtr s, double shift, double width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspanset_ceil(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspanset_floor(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspanset_degrees(IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspanset_radians(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspanset_round(IntPtr ss, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspanset_shift_scale(IntPtr ss, double shift, double width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intset_shift_scale(IntPtr s, int shift, int width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intspan_shift_scale(IntPtr s, int shift, int width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intspanset_shift_scale(IntPtr ss, int shift, int width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspan_expand(IntPtr s, IntPtr interv);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_round(IntPtr s, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr textcat_text_textset(IntPtr txt, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr textcat_textset_text(IntPtr s, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr textset_initcap(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr textset_lower(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr textset_upper(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long timestamptz_tprecision(long t, IntPtr duration, long torigin);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzset_shift_scale(IntPtr s, IntPtr shift, IntPtr duration);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzset_tprecision(IntPtr s, IntPtr duration, long torigin);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspan_shift_scale(IntPtr s, IntPtr shift, IntPtr duration);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspan_tprecision(IntPtr s, IntPtr duration, long torigin);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspanset_shift_scale(IntPtr ss, IntPtr shift, IntPtr duration);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspanset_tprecision(IntPtr ss, IntPtr duration, long torigin);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int set_cmp(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool set_eq(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool set_ge(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool set_gt(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool set_le(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool set_lt(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool set_ne(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int span_cmp(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool span_eq(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool span_ge(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool span_gt(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool span_le(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool span_lt(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool span_ne(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int spanset_cmp(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool spanset_eq(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool spanset_ge(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool spanset_gt(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool spanset_le(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool spanset_lt(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool spanset_ne(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_spans(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_split_each_n_spans(IntPtr s, int elems_per_span, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_split_n_spans(IntPtr s, int span_count, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_spans(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_split_each_n_spans(IntPtr ss, int elems_per_span, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_split_n_spans(IntPtr ss, int span_count, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_span_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_span_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_span_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_span_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_span_spanset(IntPtr s, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_span_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_spanset_bigint(IntPtr ss, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_spanset_date(IntPtr ss, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_spanset_float(IntPtr ss, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_spanset_int(IntPtr ss, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_spanset_timestamptz(IntPtr ss, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_spanset_span(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_spanset_spanset(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_bigint_set(long i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_bigint_span(long i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_bigint_spanset(long i, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_date_set(int d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_date_span(int d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_date_spanset(int d, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_float_set(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_float_span(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_float_spanset(double d, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_int_set(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_int_span(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_int_spanset(int i, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_set_set(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_span_spanset(IntPtr s, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_spanset_span(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_spanset_spanset(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_text_set(IntPtr txt, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_timestamptz_set(long t, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_timestamptz_span(long t, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_timestamptz_spanset(long t, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_set_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_set_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_set_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_set_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_set_set(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_set_text(IntPtr s, IntPtr t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_set_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_span_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_span_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_span_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_span_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_span_spanset(IntPtr s, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_span_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_spanset_bigint(IntPtr ss, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_spanset_date(IntPtr ss, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_spanset_float(IntPtr ss, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_spanset_int(IntPtr ss, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_spanset_span(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_spanset_spanset(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_spanset_timestamptz(IntPtr ss, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overlaps_set_set(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overlaps_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overlaps_span_spanset(IntPtr s, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overlaps_spanset_span(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overlaps_spanset_spanset(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool after_date_set(int d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool after_date_span(int d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool after_date_spanset(int d, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool after_set_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool after_set_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool after_span_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool after_span_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool after_spanset_date(IntPtr ss, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool after_spanset_timestamptz(IntPtr ss, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool after_timestamptz_set(long t, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool after_timestamptz_span(long t, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool after_timestamptz_spanset(long t, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool before_date_set(int d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool before_date_span(int d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool before_date_spanset(int d, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool before_set_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool before_set_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool before_span_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool before_span_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool before_spanset_date(IntPtr ss, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool before_spanset_timestamptz(IntPtr ss, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool before_timestamptz_set(long t, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool before_timestamptz_span(long t, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool before_timestamptz_spanset(long t, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_bigint_set(long i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_bigint_span(long i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_bigint_spanset(long i, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_float_set(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_float_span(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_float_spanset(double d, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_int_set(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_int_span(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_int_spanset(int i, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_set_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_set_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_set_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_set_set(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_set_text(IntPtr s, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_span_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_span_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_span_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_span_spanset(IntPtr s, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_spanset_bigint(IntPtr ss, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_spanset_float(IntPtr ss, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_spanset_int(IntPtr ss, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_spanset_span(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_spanset_spanset(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_text_set(IntPtr txt, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overafter_date_set(int d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overafter_date_span(int d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overafter_date_spanset(int d, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overafter_set_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overafter_set_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overafter_span_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overafter_span_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overafter_spanset_date(IntPtr ss, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overafter_spanset_timestamptz(IntPtr ss, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overafter_timestamptz_set(long t, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overafter_timestamptz_span(long t, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overafter_timestamptz_spanset(long t, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbefore_date_set(int d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbefore_date_span(int d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbefore_date_spanset(int d, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbefore_set_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbefore_set_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbefore_span_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbefore_span_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbefore_spanset_date(IntPtr ss, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbefore_spanset_timestamptz(IntPtr ss, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbefore_timestamptz_set(long t, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbefore_timestamptz_span(long t, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbefore_timestamptz_spanset(long t, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_bigint_set(long i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_bigint_span(long i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_bigint_spanset(long i, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_float_set(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_float_span(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_float_spanset(double d, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_int_set(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_int_span(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_int_spanset(int i, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_set_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_set_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_set_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_set_set(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_set_text(IntPtr s, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_span_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_span_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_span_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_span_spanset(IntPtr s, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_spanset_bigint(IntPtr ss, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_spanset_float(IntPtr ss, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_spanset_int(IntPtr ss, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_spanset_span(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_spanset_spanset(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_text_set(IntPtr txt, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_bigint_set(long i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_bigint_span(long i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_bigint_spanset(long i, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_float_set(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_float_span(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_float_spanset(double d, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_int_set(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_int_span(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_int_spanset(int i, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_set_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_set_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_set_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_set_set(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_set_text(IntPtr s, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_span_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_span_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_span_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_span_spanset(IntPtr s, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_spanset_bigint(IntPtr ss, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_spanset_float(IntPtr ss, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_spanset_int(IntPtr ss, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_spanset_span(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_spanset_spanset(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_text_set(IntPtr txt, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_bigint_set(long i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_bigint_span(long i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_bigint_spanset(long i, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_float_set(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_float_span(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_float_spanset(double d, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_int_set(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_int_span(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_int_spanset(int i, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_set_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_set_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_set_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_set_set(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_set_text(IntPtr s, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_span_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_span_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_span_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_span_spanset(IntPtr s, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_spanset_bigint(IntPtr ss, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_spanset_float(IntPtr ss, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_spanset_int(IntPtr ss, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_spanset_span(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_spanset_spanset(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_text_set(IntPtr txt, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_bigint_set(long i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_date_set(int d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_float_set(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_int_set(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_set_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_set_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_set_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_set_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_set_set(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_set_text(IntPtr s, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_set_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_span_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_span_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_span_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_span_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_span_spanset(IntPtr s, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_span_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_spanset_bigint(IntPtr ss, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_spanset_date(IntPtr ss, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_spanset_float(IntPtr ss, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_spanset_int(IntPtr ss, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_spanset_span(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_spanset_spanset(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_spanset_timestamptz(IntPtr ss, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_text_set(IntPtr txt, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_timestamptz_set(long t, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_bigint_set(long i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_bigint_span(long i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_bigint_spanset(long i, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_date_set(int d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_date_span(int d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_date_spanset(int d, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_float_set(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_float_span(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_float_spanset(double d, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_int_set(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_int_span(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_int_spanset(int i, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_set_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_set_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_set_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_set_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_set_set(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_set_text(IntPtr s, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_set_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_span_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_span_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_span_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_span_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_span_spanset(IntPtr s, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_span_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_spanset_bigint(IntPtr ss, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_spanset_date(IntPtr ss, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_spanset_float(IntPtr ss, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_spanset_int(IntPtr ss, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_spanset_span(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_spanset_spanset(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_spanset_timestamptz(IntPtr ss, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_text_set(IntPtr txt, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_timestamptz_set(long t, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_timestamptz_span(long t, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_timestamptz_spanset(long t, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_bigint_set(long i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_bigint_span(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_bigint_spanset(long i, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_date_set(int d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_date_span(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_date_spanset(int d, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_float_set(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_float_span(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_float_spanset(double d, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_int_set(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_int_span(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_int_spanset(int i, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_set_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_set_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_set_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_set_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_set_set(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_set_text(IntPtr s, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_set_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_span_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_span_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_span_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_span_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_span_spanset(IntPtr s, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_span_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_spanset_bigint(IntPtr ss, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_spanset_date(IntPtr ss, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_spanset_float(IntPtr ss, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_spanset_int(IntPtr ss, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_spanset_span(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_spanset_spanset(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_spanset_timestamptz(IntPtr ss, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_text_set(IntPtr txt, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_timestamptz_set(long t, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_timestamptz_span(long t, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_timestamptz_spanset(long t, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long distance_bigintset_bigintset(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long distance_bigintspan_bigintspan(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long distance_bigintspanset_bigintspan(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long distance_bigintspanset_bigintspanset(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int distance_dateset_dateset(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int distance_datespan_datespan(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int distance_datespanset_datespan(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int distance_datespanset_datespanset(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_floatset_floatset(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_floatspan_floatspan(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_floatspanset_floatspan(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_floatspanset_floatspanset(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int distance_intset_intset(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int distance_intspan_intspan(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int distance_intspanset_intspan(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int distance_intspanset_intspanset(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long distance_set_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int distance_set_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_set_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int distance_set_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_set_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long distance_span_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int distance_span_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_span_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int distance_span_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_span_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long distance_spanset_bigint(IntPtr ss, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int distance_spanset_date(IntPtr ss, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_spanset_float(IntPtr ss, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int distance_spanset_int(IntPtr ss, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_spanset_timestamptz(IntPtr ss, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_tstzset_tstzset(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_tstzspan_tstzspan(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_tstzspanset_tstzspan(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_tstzspanset_tstzspanset(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigint_extent_transfn(IntPtr state, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigint_union_transfn(IntPtr state, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr date_extent_transfn(IntPtr state, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr date_union_transfn(IntPtr state, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr float_extent_transfn(IntPtr state, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr float_union_transfn(IntPtr state, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr int_extent_transfn(IntPtr state, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr int_union_transfn(IntPtr state, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_extent_transfn(IntPtr state, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_union_finalfn(IntPtr state);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_union_transfn(IntPtr state, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr span_extent_transfn(IntPtr state, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr span_union_transfn(IntPtr state, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_extent_transfn(IntPtr state, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_union_finalfn(IntPtr state);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_union_transfn(IntPtr state, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr text_union_transfn(IntPtr state, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr timestamptz_extent_transfn(IntPtr state, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr timestamptz_union_transfn(IntPtr state, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long bigint_get_bin(long value, long vsize, long vorigin);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintspan_bins(IntPtr s, long vsize, long vorigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintspanset_bins(IntPtr ss, long vsize, long vorigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int date_get_bin(int d, IntPtr duration, int torigin);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr datespan_bins(IntPtr s, IntPtr duration, int torigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr datespanset_bins(IntPtr ss, IntPtr duration, int torigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double float_get_bin(double value, double vsize, double vorigin);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspan_bins(IntPtr s, double vsize, double vorigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspanset_bins(IntPtr ss, double vsize, double vorigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int int_get_bin(int value, int vsize, int vorigin);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intspan_bins(IntPtr s, int vsize, int vorigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intspanset_bins(IntPtr ss, int vsize, int vorigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long timestamptz_get_bin(long t, IntPtr duration, long torigin);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspan_bins(IntPtr s, IntPtr duration, long origin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspanset_bins(IntPtr ss, IntPtr duration, long torigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tbox_as_hexwkb(IntPtr box, IntPtr variant, IntPtr size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_as_wkb(IntPtr box, IntPtr variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_from_hexwkb(string hexwkb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_from_wkb(IntPtr wkb, ulong size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tbox_out(IntPtr box, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr float_timestamptz_to_tbox(double d, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr float_tstzspan_to_tbox(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr int_timestamptz_to_tbox(int i, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr int_tstzspan_to_tbox(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr numspan_tstzspan_to_tbox(IntPtr span, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr numspan_timestamptz_to_tbox(IntPtr span, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_copy(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_make(IntPtr s, IntPtr p);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr float_to_tbox(double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr int_to_tbox(int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_to_tbox(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr span_to_tbox(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_to_tbox(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_to_intspan(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_to_floatspan(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_to_tstzspan(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr timestamptz_to_tbox(long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint tbox_hash(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong tbox_hash_extended(IntPtr box, ulong seed);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tbox_hast(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tbox_hasx(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tbox_tmax(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tbox_tmax_inc(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tbox_tmin(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tbox_tmin_inc(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tbox_xmax(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tbox_xmax_inc(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tbox_xmin(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tbox_xmin_inc(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tboxfloat_xmax(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tboxfloat_xmin(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tboxint_xmax(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tboxint_xmin(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_expand_time(IntPtr box, IntPtr interv);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_round(IntPtr box, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_shift_scale_time(IntPtr box, IntPtr shift, IntPtr duration);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloatbox_expand(IntPtr box, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloatbox_shift_scale(IntPtr box, double shift, double width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintbox_expand(IntPtr box, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintbox_shift_scale(IntPtr box, int shift, int width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_tbox_tbox(IntPtr box1, IntPtr box2, [MarshalAs(UnmanagedType.U1)] bool strict);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overlaps_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool same_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool after_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool before_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overafter_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbefore_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tbox_cmp(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tbox_eq(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tbox_ge(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tbox_gt(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tbox_le(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tbox_lt(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tbox_ne(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbool_from_mfjson(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbool_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tbool_out(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string temporal_as_hexwkb(IntPtr temp, IntPtr variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string temporal_as_mfjson(IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool with_bbox, int flags, int precision, string srs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_as_wkb(IntPtr temp, IntPtr variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_from_hexwkb(string hexwkb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_from_wkb(IntPtr wkb, ulong size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_from_mfjson(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tfloat_out(IntPtr temp, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_from_mfjson(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tint_out(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_from_mfjson(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string ttext_out(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbool_from_base_temp([MarshalAs(UnmanagedType.U1)] bool b, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tboolinst_make([MarshalAs(UnmanagedType.U1)] bool b, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tboolseq_from_base_tstzset([MarshalAs(UnmanagedType.U1)] bool b, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tboolseq_from_base_tstzspan([MarshalAs(UnmanagedType.U1)] bool b, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tboolseqset_from_base_tstzspanset([MarshalAs(UnmanagedType.U1)] bool b, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_copy(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_from_base_temp(double d, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloatinst_make(double d, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloatseq_from_base_tstzset(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloatseq_from_base_tstzspan(double d, IntPtr s, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloatseqset_from_base_tstzspanset(double d, IntPtr ss, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_from_base_temp(int i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintinst_make(int i, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintseq_from_base_tstzset(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintseq_from_base_tstzspan(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintseqset_from_base_tstzspanset(int i, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_make(IntPtr instants, int count, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc, int interp, [MarshalAs(UnmanagedType.U1)] bool normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_make(IntPtr sequences, int count, [MarshalAs(UnmanagedType.U1)] bool normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_make_gaps(IntPtr instants, int count, int interp, IntPtr maxt, double maxdist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_from_base_temp(IntPtr txt, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttextinst_make(IntPtr txt, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttextseq_from_base_tstzset(IntPtr txt, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttextseq_from_base_tstzspan(IntPtr txt, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttextseqset_from_base_tstzspanset(IntPtr txt, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbool_to_tint(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_to_tstzspan(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_to_tint(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_to_tfloat(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_to_span(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_to_tbox(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tbool_end_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tbool_start_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tbool_value_at_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool strict, IntPtr value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tbool_value_n(IntPtr temp, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbool_values(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_duration(IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool boundspan);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_end_instant(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_end_sequence(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long temporal_end_timestamptz(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint temporal_hash(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_instant_n(IntPtr temp, int n);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_instants(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string temporal_interp(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool temporal_lower_inc(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_max_instant(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_min_instant(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int temporal_num_instants(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int temporal_num_sequences(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int temporal_num_timestamps(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_segm_duration(IntPtr temp, IntPtr duration, [MarshalAs(UnmanagedType.U1)] bool atleast, [MarshalAs(UnmanagedType.U1)] bool strict);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_segments(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_sequence_n(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_sequences(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_start_instant(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_start_sequence(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long temporal_start_timestamptz(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_stops(IntPtr temp, double maxdist, IntPtr minduration);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string temporal_subtype(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_time(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_timestamps(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool temporal_timestamptz_n(IntPtr temp, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool temporal_upper_inc(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tfloat_avg_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tfloat_end_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tfloat_min_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tfloat_max_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tfloat_start_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tfloat_value_at_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool strict, IntPtr value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tfloat_value_n(IntPtr temp, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_values(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tint_end_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tint_max_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tint_min_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tint_start_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tint_value_at_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool strict, IntPtr value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tint_value_n(IntPtr temp, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_values(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tnumber_avg_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tnumber_integral(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tnumber_twavg(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_valuespans(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_end_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_max_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_min_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_start_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ttext_value_at_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool strict, IntPtr value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ttext_value_n(IntPtr temp, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_values(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double float_degrees(double value, [MarshalAs(UnmanagedType.U1)] bool normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temparr_round(IntPtr temp, int count, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_round(IntPtr temp, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_scale_time(IntPtr temp, IntPtr duration);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_set_interp(IntPtr temp, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_shift_scale_time(IntPtr temp, IntPtr shift, IntPtr duration);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_shift_time(IntPtr temp, IntPtr shift);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_to_tinstant(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_to_tsequence(IntPtr temp, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_to_tsequenceset(IntPtr temp, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_ceil(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_degrees(IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_floor(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_radians(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_scale_value(IntPtr temp, double width);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_shift_scale_value(IntPtr temp, double shift, double width);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_shift_value(IntPtr temp, double shift);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_scale_value(IntPtr temp, int width);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_shift_scale_value(IntPtr temp, int shift, int width);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_shift_value(IntPtr temp, int shift);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_append_tinstant(IntPtr temp, IntPtr inst, int interp, double maxdist, IntPtr maxt, [MarshalAs(UnmanagedType.U1)] bool expand);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_append_tsequence(IntPtr temp, IntPtr seq, [MarshalAs(UnmanagedType.U1)] bool expand);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_delete_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool connect);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_delete_tstzset(IntPtr temp, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool connect);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_delete_tstzspan(IntPtr temp, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool connect);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_delete_tstzspanset(IntPtr temp, IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool connect);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_insert(IntPtr temp1, IntPtr temp2, [MarshalAs(UnmanagedType.U1)] bool connect);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_merge(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_merge_array(IntPtr temparr, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_update(IntPtr temp1, IntPtr temp2, [MarshalAs(UnmanagedType.U1)] bool connect);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbool_at_value(IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbool_minus_value(IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_after_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool strict);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_at_max(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_at_min(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_at_timestamptz(IntPtr temp, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_at_tstzset(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_at_tstzspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_at_tstzspanset(IntPtr temp, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_at_values(IntPtr temp, IntPtr set);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_before_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool strict);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_minus_max(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_minus_min(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_minus_timestamptz(IntPtr temp, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_minus_tstzset(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_minus_tstzspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_minus_tstzspanset(IntPtr temp, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_minus_values(IntPtr temp, IntPtr set);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_at_value(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_minus_value(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_at_value(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_minus_value(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_at_span(IntPtr temp, IntPtr span);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_at_spanset(IntPtr temp, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_at_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_minus_span(IntPtr temp, IntPtr span);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_minus_spanset(IntPtr temp, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_minus_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_at_value(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_minus_value(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int temporal_cmp(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool temporal_eq(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool temporal_ge(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool temporal_gt(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool temporal_le(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool temporal_lt(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool temporal_ne(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_bool_tbool([MarshalAs(UnmanagedType.U1)] bool b, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_float_tfloat(double d, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_int_tint(int i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_tbool_bool(IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_text_ttext(IntPtr txt, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_tfloat_float(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_tint_int(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_ttext_text(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ge_float_tfloat(double d, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ge_int_tint(int i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ge_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ge_text_ttext(IntPtr txt, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ge_tfloat_float(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ge_tint_int(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ge_ttext_text(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_gt_float_tfloat(double d, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_gt_int_tint(int i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_gt_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_gt_text_ttext(IntPtr txt, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_gt_tfloat_float(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_gt_tint_int(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_gt_ttext_text(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_le_float_tfloat(double d, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_le_int_tint(int i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_le_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_le_text_ttext(IntPtr txt, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_le_tfloat_float(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_le_tint_int(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_le_ttext_text(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_lt_float_tfloat(double d, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_lt_int_tint(int i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_lt_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_lt_text_ttext(IntPtr txt, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_lt_tfloat_float(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_lt_tint_int(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_lt_ttext_text(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_bool_tbool([MarshalAs(UnmanagedType.U1)] bool b, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_float_tfloat(double d, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_int_tint(int i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_tbool_bool(IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_text_ttext(IntPtr txt, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_tfloat_float(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_tint_int(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_ttext_text(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_bool_tbool([MarshalAs(UnmanagedType.U1)] bool b, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_float_tfloat(double d, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_int_tint(int i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_tbool_bool(IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_text_ttext(IntPtr txt, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_tfloat_float(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_tint_int(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_ttext_text(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ge_float_tfloat(double d, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ge_int_tint(int i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ge_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ge_text_ttext(IntPtr txt, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ge_tfloat_float(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ge_tint_int(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ge_ttext_text(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_gt_float_tfloat(double d, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_gt_int_tint(int i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_gt_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_gt_text_ttext(IntPtr txt, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_gt_tfloat_float(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_gt_tint_int(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_gt_ttext_text(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_le_float_tfloat(double d, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_le_int_tint(int i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_le_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_le_text_ttext(IntPtr txt, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_le_tfloat_float(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_le_tint_int(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_le_ttext_text(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_lt_float_tfloat(double d, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_lt_int_tint(int i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_lt_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_lt_text_ttext(IntPtr txt, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_lt_tfloat_float(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_lt_tint_int(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_lt_ttext_text(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_bool_tbool([MarshalAs(UnmanagedType.U1)] bool b, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_float_tfloat(double d, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_int_tint(int i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_tbool_bool(IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_text_ttext(IntPtr txt, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_tfloat_float(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_tint_int(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_ttext_text(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_bool_tbool([MarshalAs(UnmanagedType.U1)] bool b, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_float_tfloat(double d, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_int_tint(int i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_tbool_bool(IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_text_ttext(IntPtr txt, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_tfloat_float(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_tint_int(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_ttext_text(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tge_float_tfloat(double d, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tge_int_tint(int i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tge_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tge_text_ttext(IntPtr txt, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tge_tfloat_float(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tge_tint_int(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tge_ttext_text(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgt_float_tfloat(double d, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgt_int_tint(int i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgt_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgt_text_ttext(IntPtr txt, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgt_tfloat_float(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgt_tint_int(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgt_ttext_text(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tle_float_tfloat(double d, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tle_int_tint(int i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tle_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tle_text_ttext(IntPtr txt, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tle_tfloat_float(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tle_tint_int(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tle_ttext_text(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tlt_float_tfloat(double d, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tlt_int_tint(int i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tlt_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tlt_text_ttext(IntPtr txt, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tlt_tfloat_float(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tlt_tint_int(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tlt_ttext_text(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_bool_tbool([MarshalAs(UnmanagedType.U1)] bool b, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_float_tfloat(double d, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_int_tint(int i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_tbool_bool(IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_text_ttext(IntPtr txt, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_tfloat_float(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_tint_int(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_ttext_text(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_spans(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_split_each_n_spans(IntPtr temp, int elem_count, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_split_n_spans(IntPtr temp, int span_count, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_split_each_n_tboxes(IntPtr temp, int elem_count, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_split_n_tboxes(IntPtr temp, int box_count, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_tboxes(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_numspan_tnumber(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_tbox_tnumber(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_temporal_tstzspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_tnumber_numspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_tstzspan_temporal(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_numspan_tnumber(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_tbox_tnumber(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_temporal_tstzspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_tnumber_numspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_tstzspan_temporal(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_numspan_tnumber(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_tbox_tnumber(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_temporal_tstzspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_tnumber_numspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_tstzspan_temporal(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overlaps_numspan_tnumber(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overlaps_tbox_tnumber(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overlaps_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overlaps_temporal_tstzspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overlaps_tnumber_numspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overlaps_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overlaps_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overlaps_tstzspan_temporal(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool same_numspan_tnumber(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool same_tbox_tnumber(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool same_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool same_temporal_tstzspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool same_tnumber_numspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool same_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool same_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool same_tstzspan_temporal(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool after_tbox_tnumber(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool after_temporal_tstzspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool after_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool after_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool after_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool after_tstzspan_temporal(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool before_tbox_tnumber(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool before_temporal_tstzspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool before_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool before_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool before_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool before_tstzspan_temporal(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_tbox_tnumber(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_numspan_tnumber(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_tnumber_numspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overafter_tbox_tnumber(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overafter_temporal_tstzspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overafter_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overafter_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overafter_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overafter_tstzspan_temporal(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbefore_tbox_tnumber(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbefore_temporal_tstzspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbefore_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbefore_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbefore_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbefore_tstzspan_temporal(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_numspan_tnumber(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_tbox_tnumber(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_tnumber_numspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_numspan_tnumber(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_tbox_tnumber(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_tnumber_numspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_numspan_tnumber(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_tbox_tnumber(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_tnumber_numspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tand_bool_tbool([MarshalAs(UnmanagedType.U1)] bool b, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tand_tbool_bool(IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tand_tbool_tbool(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbool_when_true(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnot_tbool(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tor_bool_tbool([MarshalAs(UnmanagedType.U1)] bool b, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tor_tbool_bool(IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tor_tbool_tbool(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr add_float_tfloat(double d, IntPtr tnumber);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr add_int_tint(int i, IntPtr tnumber);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr add_tfloat_float(IntPtr tnumber, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr add_tint_int(IntPtr tnumber, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr add_tnumber_tnumber(IntPtr tnumber1, IntPtr tnumber2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr div_float_tfloat(double d, IntPtr tnumber);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr div_int_tint(int i, IntPtr tnumber);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr div_tfloat_float(IntPtr tnumber, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr div_tint_int(IntPtr tnumber, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr div_tnumber_tnumber(IntPtr tnumber1, IntPtr tnumber2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr mult_float_tfloat(double d, IntPtr tnumber);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr mult_int_tint(int i, IntPtr tnumber);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr mult_tfloat_float(IntPtr tnumber, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr mult_tint_int(IntPtr tnumber, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr mult_tnumber_tnumber(IntPtr tnumber1, IntPtr tnumber2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr sub_float_tfloat(double d, IntPtr tnumber);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr sub_int_tint(int i, IntPtr tnumber);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr sub_tfloat_float(IntPtr tnumber, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr sub_tint_int(IntPtr tnumber, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr sub_tnumber_tnumber(IntPtr tnumber1, IntPtr tnumber2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_derivative(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_exp(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_ln(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_log10(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_abs(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_trend(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double float_angular_difference(double degrees1, double degrees2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_angular_difference(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_delta_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr textcat_text_ttext(IntPtr txt, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr textcat_ttext_text(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr textcat_ttext_ttext(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_initcap(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_upper(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_lower(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdistance_tfloat_float(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdistance_tint_int(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdistance_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tboxfloat_tboxfloat(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int nad_tboxint_tboxint(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tfloat_float(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tfloat_tfloat(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tfloat_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int nad_tint_int(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int nad_tint_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int nad_tint_tint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbool_tand_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbool_tor_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_extent_transfn(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_merge_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_merge_combinefn(IntPtr state1, IntPtr state2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_tagg_finalfn(IntPtr state);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_tcount_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_tmax_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_tmin_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_tsum_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_wmax_transfn(IntPtr state, IntPtr temp, IntPtr interv);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_wmin_transfn(IntPtr state, IntPtr temp, IntPtr interv);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_wsum_transfn(IntPtr state, IntPtr temp, IntPtr interv);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr timestamptz_tcount_transfn(IntPtr state, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_tmax_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_tmin_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_tsum_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_wmax_transfn(IntPtr state, IntPtr temp, IntPtr interv);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_wmin_transfn(IntPtr state, IntPtr temp, IntPtr interv);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_wsum_transfn(IntPtr state, IntPtr temp, IntPtr interv);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_extent_transfn(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_tavg_finalfn(IntPtr state);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_tavg_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_wavg_transfn(IntPtr state, IntPtr temp, IntPtr interv);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzset_tcount_transfn(IntPtr state, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspan_tcount_transfn(IntPtr state, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspanset_tcount_transfn(IntPtr state, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_tmax_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_tmin_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_simplify_dp(IntPtr temp, double eps_dist, [MarshalAs(UnmanagedType.U1)] bool synchronized);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_simplify_max_dist(IntPtr temp, double eps_dist, [MarshalAs(UnmanagedType.U1)] bool synchronized);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_simplify_min_dist(IntPtr temp, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_simplify_min_tdelta(IntPtr temp, IntPtr mint);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_tprecision(IntPtr temp, IntPtr duration, long origin);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_tsample(IntPtr temp, IntPtr duration, long origin, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double temporal_dyntimewarp_distance(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_dyntimewarp_path(IntPtr temp1, IntPtr temp2, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double temporal_frechet_distance(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_frechet_path(IntPtr temp1, IntPtr temp2, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double temporal_hausdorff_distance(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_time_bins(IntPtr temp, IntPtr duration, long origin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_time_split(IntPtr temp, IntPtr duration, long torigin, IntPtr time_bins, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_time_boxes(IntPtr temp, IntPtr duration, long torigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_value_bins(IntPtr temp, double vsize, double vorigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_value_boxes(IntPtr temp, double vsize, double vorigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_value_split(IntPtr temp, double size, double origin, IntPtr bins, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_value_time_boxes(IntPtr temp, double vsize, IntPtr duration, double vorigin, long torigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_value_time_split(IntPtr temp, double vsize, IntPtr duration, double vorigin, long torigin, IntPtr value_bins, IntPtr time_bins, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloatbox_time_tiles(IntPtr box, IntPtr duration, long torigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloatbox_value_tiles(IntPtr box, double vsize, double vorigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloatbox_value_time_tiles(IntPtr box, double vsize, IntPtr duration, double vorigin, long torigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_time_boxes(IntPtr temp, IntPtr duration, long torigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_value_bins(IntPtr temp, int vsize, int vorigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_value_boxes(IntPtr temp, int vsize, int vorigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_value_split(IntPtr temp, int vsize, int vorigin, IntPtr bins, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_value_time_boxes(IntPtr temp, int vsize, IntPtr duration, int vorigin, long torigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_value_time_split(IntPtr temp, int size, IntPtr duration, int vorigin, long torigin, IntPtr value_bins, IntPtr time_bins, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintbox_time_tiles(IntPtr box, IntPtr duration, long torigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintbox_value_tiles(IntPtr box, int xsize, int xorigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintbox_value_time_tiles(IntPtr box, int xsize, IntPtr duration, int xorigin, long torigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool temptype_subtype(int subtype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool temptype_subtype_all(int subtype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tempsubtype_name(int subtype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tempsubtype_from_string(string str, IntPtr subtype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string meosoper_name(IntPtr oper);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr meosoper_from_string(string name);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string interptype_name(int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int interptype_from_string(string interp_str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string meostype_name(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int temptype_basetype(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int settype_basetype(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int spantype_basetype(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int spantype_spansettype(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int spansettype_spantype(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int basetype_spantype(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int basetype_settype(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tnumber_basetype(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geo_basetype(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool meos_basetype(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool alphanum_basetype(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool alphanum_temptype(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool time_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool set_basetype(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool set_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool numset_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_numset_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool timeset_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool set_spantype(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_set_spantype(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool alphanumset_type(int settype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geoset_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_geoset_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool spatialset_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_spatialset_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool span_basetype(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool span_canon_basetype(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool span_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool type_span_bbox(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool span_tbox_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_span_tbox_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool numspan_basetype(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool numspan_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_numspan_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool timespan_basetype(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool timespan_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool spanset_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool timespanset_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_timespanset_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool temporal_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool temporal_basetype(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool temptype_supports_linear(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool basetype_byvalue(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool basetype_varlength(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial short meostype_length(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool talphanum_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool talpha_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tnumber_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_tnumber_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_tnumber_basetype(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tnumber_spantype(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool spatial_basetype(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tspatial_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_tspatial_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpoint_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_tpoint_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tgeo_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_tgeo_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tgeo_type_all(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_tgeo_type_all(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tgeometry_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_tgeometry_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tgeodetic_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_tgeodetic_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_tnumber_tpoint_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int geo_get_srid(IntPtr g);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_as_ewkb(IntPtr gs, string endian, IntPtr size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string geo_as_ewkt(IntPtr gs, int precision);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string geo_as_geojson(IntPtr gs, int option, int precision, string srs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string geo_as_hexewkb(IntPtr gs, string endian);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string geo_as_text(IntPtr gs, int precision);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_from_ewkb(IntPtr wkb, ulong wkb_size, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_from_geojson(string geojson);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_from_text(string wkt, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string geo_out(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geog_from_binary(string wkb_bytea);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geog_from_hexewkb(string wkt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geog_in(string str, int typmod);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geom_from_hexewkb(string wkt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geom_in(string str, int typmod);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr box3d_make(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string box3d_out(IntPtr box, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr gbox_make([MarshalAs(UnmanagedType.U1)] bool hasz, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string gbox_out(IntPtr box, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_copy(IntPtr g);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geogpoint_make2d(int srid, double x, double y);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geogpoint_make3dz(int srid, double x, double y, double z);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geompoint_make2d(int srid, double x, double y);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geompoint_make3dz(int srid, double x, double y, double z);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geom_to_geog(IntPtr geom);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geog_to_geom(IntPtr geog);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geo_is_empty(IntPtr g);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geo_is_unitary(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string geo_typename(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double geog_area(IntPtr g, [MarshalAs(UnmanagedType.U1)] bool use_spheroid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geog_centroid(IntPtr g, [MarshalAs(UnmanagedType.U1)] bool use_spheroid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double geog_length(IntPtr g, [MarshalAs(UnmanagedType.U1)] bool use_spheroid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double geog_perimeter(IntPtr g, [MarshalAs(UnmanagedType.U1)] bool use_spheroid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geom_azimuth(IntPtr gs1, IntPtr gs2, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double geom_length(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double geom_perimeter(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int line_numpoints(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr line_point_n(IntPtr geom, int n);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_reverse(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_round(IntPtr gs, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_set_srid(IntPtr gs, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int geo_srid(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_transform(IntPtr geom, int srid_to);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_transform_pipeline(IntPtr gs, string pipeline, int srid_to, [MarshalAs(UnmanagedType.U1)] bool is_forward);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_collect_garray(IntPtr gsarr, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_makeline_garray(IntPtr gsarr, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int geo_num_points(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int geo_num_geos(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_geo_n(IntPtr geom, int n);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_pointarr(IntPtr gs, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_points(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geom_array_union(IntPtr gsarr, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geom_boundary(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geom_buffer(IntPtr gs, double size, string @params);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geom_centroid(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geom_convex_hull(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geom_difference2d(IntPtr gs1, IntPtr gs2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geom_intersection2d(IntPtr gs1, IntPtr gs2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geom_intersection2d_coll(IntPtr gs1, IntPtr gs2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geom_min_bounding_radius(IntPtr geom, IntPtr radius);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geom_shortestline2d(IntPtr gs1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geom_shortestline3d(IntPtr gs1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geom_unary_union(IntPtr gs, double prec);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr line_interpolate_point(IntPtr gs, double distance_fraction, [MarshalAs(UnmanagedType.U1)] bool repeat);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double line_locate_point(IntPtr gs1, IntPtr gs2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr line_substring(IntPtr gs, double from, double to);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geog_dwithin(IntPtr g1, IntPtr g2, double tolerance, [MarshalAs(UnmanagedType.U1)] bool use_spheroid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geog_intersects(IntPtr gs1, IntPtr gs2, [MarshalAs(UnmanagedType.U1)] bool use_spheroid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geom_contains(IntPtr gs1, IntPtr gs2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geom_covers(IntPtr gs1, IntPtr gs2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geom_disjoint2d(IntPtr gs1, IntPtr gs2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geom_dwithin2d(IntPtr gs1, IntPtr gs2, double tolerance);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geom_dwithin3d(IntPtr gs1, IntPtr gs2, double tolerance);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geom_intersects2d(IntPtr gs1, IntPtr gs2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geom_intersects3d(IntPtr gs1, IntPtr gs2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geom_relate_pattern(IntPtr gs1, IntPtr gs2, string patt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geom_touches(IntPtr gs1, IntPtr gs2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_stboxes(IntPtr gs, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_split_each_n_stboxes(IntPtr gs, int elem_count, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_split_n_stboxes(IntPtr gs, int box_count, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double geog_distance(IntPtr g1, IntPtr g2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double geom_distance2d(IntPtr gs1, IntPtr gs2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double geom_distance3d(IntPtr gs1, IntPtr gs2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int geo_equals(IntPtr gs1, IntPtr gs2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geo_same(IntPtr gs1, IntPtr gs2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geogset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geomset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string spatialset_as_text(IntPtr set, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string spatialset_as_ewkt(IntPtr set, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geoset_make(IntPtr values, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_to_set(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geoset_end_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geoset_start_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geoset_value_n(IntPtr s, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geoset_values(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_geo_set(IntPtr gs, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_set_geo(IntPtr s, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_union_transfn(IntPtr state, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_geo_set(IntPtr gs, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_set_geo(IntPtr s, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_geo_set(IntPtr gs, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_set_geo(IntPtr s, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_geo_set(IntPtr gs, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_set_geo(IntPtr s, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spatialset_set_srid(IntPtr s, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int spatialset_srid(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spatialset_transform(IntPtr s, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spatialset_transform_pipeline(IntPtr s, string pipelinestr, int srid, [MarshalAs(UnmanagedType.U1)] bool is_forward);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string stbox_as_hexwkb(IntPtr box, IntPtr variant, IntPtr size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_as_wkb(IntPtr box, IntPtr variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_from_hexwkb(string hexwkb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_from_wkb(IntPtr wkb, ulong size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string stbox_out(IntPtr box, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_timestamptz_to_stbox(IntPtr gs, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_tstzspan_to_stbox(IntPtr gs, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_copy(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_make([MarshalAs(UnmanagedType.U1)] bool hasx, [MarshalAs(UnmanagedType.U1)] bool hasz, [MarshalAs(UnmanagedType.U1)] bool geodetic, int srid, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_to_stbox(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spatialset_to_stbox(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_to_box3d(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_to_gbox(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_to_geo(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_to_tstzspan(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr timestamptz_to_stbox(long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzset_to_stbox(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspan_to_stbox(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspanset_to_stbox(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double stbox_area(IntPtr box, [MarshalAs(UnmanagedType.U1)] bool spheroid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint stbox_hash(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong stbox_hash_extended(IntPtr box, ulong seed);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool stbox_hast(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool stbox_hasx(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool stbox_hasz(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool stbox_isgeodetic(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double stbox_perimeter(IntPtr box, [MarshalAs(UnmanagedType.U1)] bool spheroid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool stbox_tmax(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool stbox_tmax_inc(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool stbox_tmin(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool stbox_tmin_inc(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double stbox_volume(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool stbox_xmax(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool stbox_xmin(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool stbox_ymax(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool stbox_ymin(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool stbox_zmax(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool stbox_zmin(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_expand_space(IntPtr box, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_expand_time(IntPtr box, IntPtr interv);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_get_space(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_quad_split(IntPtr box, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_round(IntPtr box, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_shift_scale_time(IntPtr box, IntPtr shift, IntPtr duration);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stboxarr_round(IntPtr boxarr, int count, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_set_srid(IntPtr box, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int stbox_srid(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_transform(IntPtr box, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_transform_pipeline(IntPtr box, string pipelinestr, int srid, [MarshalAs(UnmanagedType.U1)] bool is_forward);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overlaps_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool same_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool above_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool after_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool back_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool before_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool below_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool front_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overabove_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overafter_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overback_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbefore_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbelow_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overfront_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_stbox_stbox(IntPtr box1, IntPtr box2, [MarshalAs(UnmanagedType.U1)] bool strict);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int stbox_cmp(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool stbox_eq(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool stbox_ge(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool stbox_gt(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool stbox_le(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool stbox_lt(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool stbox_ne(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeogpoint_from_mfjson(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeogpoint_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeography_from_mfjson(string mfjson);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeography_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeometry_from_mfjson(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeometry_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeompoint_from_mfjson(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeompoint_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tspatial_as_ewkt(IntPtr temp, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tspatial_as_text(IntPtr temp, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tspatial_out(IntPtr temp, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeo_from_base_temp(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeoinst_make(IntPtr gs, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeoseq_from_base_tstzset(IntPtr gs, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeoseq_from_base_tstzspan(IntPtr gs, IntPtr s, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeoseqset_from_base_tstzspanset(IntPtr gs, IntPtr ss, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_from_base_temp(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpointinst_make(IntPtr gs, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpointseq_from_base_tstzset(IntPtr gs, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpointseq_from_base_tstzspan(IntPtr gs, IntPtr s, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpointseq_make_coords(IntPtr xcoords, IntPtr ycoords, IntPtr zcoords, IntPtr times, int count, int srid, [MarshalAs(UnmanagedType.U1)] bool geodetic, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc, int interp, [MarshalAs(UnmanagedType.U1)] bool normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpointseqset_from_base_tstzspanset(IntPtr gs, IntPtr ss, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr box3d_to_stbox(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr gbox_to_stbox(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geomeas_to_tpoint(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeogpoint_to_tgeography(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeography_to_tgeogpoint(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeography_to_tgeometry(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeometry_to_tgeography(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeometry_to_tgeompoint(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeompoint_to_tgeometry(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpoint_as_mvtgeom(IntPtr temp, IntPtr bounds, int extent, int buffer, [MarshalAs(UnmanagedType.U1)] bool clip_geom, IntPtr gsarr, IntPtr timesarr, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpoint_tfloat_to_geomeas(IntPtr tpoint, IntPtr measure, [MarshalAs(UnmanagedType.U1)] bool segmentize, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tspatial_to_stbox(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool bearing_point_point(IntPtr gs1, IntPtr gs2, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bearing_tpoint_point(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bearing_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeo_centroid(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeo_convex_hull(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeo_end_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeo_start_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeo_traversed_area(IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool unary_union);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tgeo_value_at_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool strict, IntPtr value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tgeo_value_n(IntPtr temp, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeo_values(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_angular_difference(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_azimuth(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_cumulative_length(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpoint_direction(IntPtr temp, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_get_x(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_get_y(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_get_z(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpoint_is_simple(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tpoint_length(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_speed(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_trajectory(IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool unary_union);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_twcentroid(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeo_affine(IntPtr temp, IntPtr a);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeo_scale(IntPtr temp, IntPtr scale, IntPtr sorigin);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_make_simple(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tspatial_srid(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tspatial_set_srid(IntPtr temp, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tspatial_transform(IntPtr temp, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tspatial_transform_pipeline(IntPtr temp, string pipelinestr, int srid, [MarshalAs(UnmanagedType.U1)] bool is_forward);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeo_at_geom(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeo_at_stbox(IntPtr temp, IntPtr box, [MarshalAs(UnmanagedType.U1)] bool border_inc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeo_at_value(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeo_minus_geom(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeo_minus_stbox(IntPtr temp, IntPtr box, [MarshalAs(UnmanagedType.U1)] bool border_inc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeo_minus_value(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_at_elevation(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_at_geom(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_at_value(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_minus_elevation(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_minus_geom(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_minus_value(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_geo_tgeo(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_geo_tgeo(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_geo_tgeo(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_geo_tgeo(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_geo_tgeo(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_geo_tgeo(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeo_stboxes(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeo_space_boxes(IntPtr temp, double xsize, double ysize, double zsize, IntPtr sorigin, [MarshalAs(UnmanagedType.U1)] bool bitmatrix, [MarshalAs(UnmanagedType.U1)] bool border_inc, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeo_space_time_boxes(IntPtr temp, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, long torigin, [MarshalAs(UnmanagedType.U1)] bool bitmatrix, [MarshalAs(UnmanagedType.U1)] bool border_inc, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeo_split_each_n_stboxes(IntPtr temp, int elem_count, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeo_split_n_stboxes(IntPtr temp, int box_count, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_stbox_tspatial(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_tspatial_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_tspatial_tspatial(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_stbox_tspatial(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_tspatial_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_tspatial_tspatial(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_stbox_tspatial(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_tspatial_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_tspatial_tspatial(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overlaps_stbox_tspatial(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overlaps_tspatial_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overlaps_tspatial_tspatial(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool same_stbox_tspatial(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool same_tspatial_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool same_tspatial_tspatial(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool above_stbox_tspatial(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool above_tspatial_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool above_tspatial_tspatial(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool after_stbox_tspatial(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool after_tspatial_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool after_tspatial_tspatial(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool back_stbox_tspatial(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool back_tspatial_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool back_tspatial_tspatial(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool before_stbox_tspatial(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool before_tspatial_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool before_tspatial_tspatial(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool below_stbox_tspatial(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool below_tspatial_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool below_tspatial_tspatial(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool front_stbox_tspatial(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool front_tspatial_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool front_tspatial_tspatial(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_stbox_tspatial(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_tspatial_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_tspatial_tspatial(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overabove_stbox_tspatial(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overabove_tspatial_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overabove_tspatial_tspatial(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overafter_stbox_tspatial(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overafter_tspatial_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overafter_tspatial_tspatial(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overback_stbox_tspatial(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overback_tspatial_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overback_tspatial_tspatial(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbefore_stbox_tspatial(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbefore_tspatial_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbefore_tspatial_tspatial(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbelow_stbox_tspatial(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbelow_tspatial_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbelow_tspatial_tspatial(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overfront_stbox_tspatial(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overfront_tspatial_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overfront_tspatial_tspatial(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_stbox_tspatial(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_tspatial_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_tspatial_tspatial(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_stbox_tspatial(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_tspatial_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_tspatial_tspatial(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_stbox_tspatial(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_tspatial_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_tspatial_tspatial(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int acontains_geo_tgeo(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int acontains_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int acontains_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int adisjoint_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int adisjoint_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int adwithin_tgeo_geo(IntPtr temp, IntPtr gs, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int adwithin_tgeo_tgeo(IntPtr temp1, IntPtr temp2, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int aintersects_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int aintersects_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int atouches_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int atouches_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int atouches_tpoint_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int econtains_geo_tgeo(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int econtains_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int econtains_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ecovers_geo_tgeo(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ecovers_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ecovers_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int edisjoint_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int edisjoint_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int edwithin_tgeo_geo(IntPtr temp, IntPtr gs, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int edwithin_tgeo_tgeo(IntPtr temp1, IntPtr temp2, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int eintersects_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int eintersects_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int etouches_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int etouches_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int etouches_tpoint_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcontains_geo_tgeo(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcontains_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcontains_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcovers_geo_tgeo(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcovers_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcovers_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdisjoint_geo_tgeo(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdisjoint_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdisjoint_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdwithin_geo_tgeo(IntPtr gs, IntPtr temp, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdwithin_tgeo_geo(IntPtr temp, IntPtr gs, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdwithin_tgeo_tgeo(IntPtr temp1, IntPtr temp2, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintersects_geo_tgeo(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintersects_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintersects_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttouches_geo_tgeo(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttouches_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttouches_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdistance_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdistance_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_stbox_geo(IntPtr box, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tgeo_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nai_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nai_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr shortestline_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr shortestline_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_tcentroid_finalfn(IntPtr state);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_tcentroid_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tspatial_extent_transfn(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_get_space_tile(IntPtr point, double xsize, double ysize, double zsize, IntPtr sorigin);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_get_space_time_tile(IntPtr point, long t, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, long torigin);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_get_time_tile(long t, IntPtr duration, long torigin);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_space_tiles(IntPtr bounds, double xsize, double ysize, double zsize, IntPtr sorigin, [MarshalAs(UnmanagedType.U1)] bool border_inc, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_space_time_tiles(IntPtr bounds, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, long torigin, [MarshalAs(UnmanagedType.U1)] bool border_inc, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_time_tiles(IntPtr bounds, IntPtr duration, long torigin, [MarshalAs(UnmanagedType.U1)] bool border_inc, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeo_space_split(IntPtr temp, double xsize, double ysize, double zsize, IntPtr sorigin, [MarshalAs(UnmanagedType.U1)] bool bitmatrix, [MarshalAs(UnmanagedType.U1)] bool border_inc, IntPtr space_bins, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeo_space_time_split(IntPtr temp, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, long torigin, [MarshalAs(UnmanagedType.U1)] bool bitmatrix, [MarshalAs(UnmanagedType.U1)] bool border_inc, IntPtr space_bins, IntPtr time_bins, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_cluster_kmeans(IntPtr geoms, uint ngeoms, uint k);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_cluster_dbscan(IntPtr geoms, uint ngeoms, double tolerance, int minpoints, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_cluster_intersecting(IntPtr geoms, uint ngeoms, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_cluster_within(IntPtr geoms, uint ngeoms, double tolerance, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string cbuffer_as_ewkt(IntPtr cb, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string cbuffer_as_hexwkb(IntPtr cb, IntPtr variant, IntPtr size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string cbuffer_as_text(IntPtr cb, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbuffer_as_wkb(IntPtr cb, IntPtr variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbuffer_from_hexwkb(string hexwkb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbuffer_from_wkb(IntPtr wkb, ulong size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbuffer_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string cbuffer_out(IntPtr cb, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbuffer_copy(IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbuffer_make(IntPtr point, double radius);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbuffer_to_geom(IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbuffer_to_stbox(IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbufferarr_to_geom(IntPtr cbarr, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geom_to_cbuffer(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint cbuffer_hash(IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong cbuffer_hash_extended(IntPtr cb, ulong seed);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbuffer_point(IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double cbuffer_radius(IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbuffer_round(IntPtr cb, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbufferarr_round(IntPtr cbarr, int count, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void cbuffer_set_srid(IntPtr cb, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int cbuffer_srid(IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbuffer_transform(IntPtr cb, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbuffer_transform_pipeline(IntPtr cb, string pipelinestr, int srid, [MarshalAs(UnmanagedType.U1)] bool is_forward);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int contains_cbuffer_cbuffer(IntPtr cb1, IntPtr cb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int covers_cbuffer_cbuffer(IntPtr cb1, IntPtr cb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int disjoint_cbuffer_cbuffer(IntPtr cb1, IntPtr cb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int dwithin_cbuffer_cbuffer(IntPtr cb1, IntPtr cb2, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int intersects_cbuffer_cbuffer(IntPtr cb1, IntPtr cb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int touches_cbuffer_cbuffer(IntPtr cb1, IntPtr cb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbuffer_tstzspan_to_stbox(IntPtr cb, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbuffer_timestamptz_to_stbox(IntPtr cb, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_cbuffer_cbuffer(IntPtr cb1, IntPtr cb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_cbuffer_geo(IntPtr cb, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_cbuffer_stbox(IntPtr cb, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_cbuffer_stbox(IntPtr cb, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int cbuffer_cmp(IntPtr cb1, IntPtr cb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool cbuffer_eq(IntPtr cb1, IntPtr cb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool cbuffer_ge(IntPtr cb1, IntPtr cb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool cbuffer_gt(IntPtr cb1, IntPtr cb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool cbuffer_le(IntPtr cb1, IntPtr cb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool cbuffer_lt(IntPtr cb1, IntPtr cb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool cbuffer_ne(IntPtr cb1, IntPtr cb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool cbuffer_nsame(IntPtr cb1, IntPtr cb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool cbuffer_same(IntPtr cb1, IntPtr cb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbufferset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string cbufferset_out(IntPtr s, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbufferset_make(IntPtr values, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbuffer_to_set(IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbufferset_end_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbufferset_start_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool cbufferset_value_n(IntPtr s, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbufferset_values(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbuffer_union_transfn(IntPtr state, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_cbuffer_set(IntPtr cb, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_set_cbuffer(IntPtr s, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_cbuffer_set(IntPtr cb, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_set_cbuffer(IntPtr s, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_cbuffer_set(IntPtr cb, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_set_cbuffer(IntPtr s, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_cbuffer_set(IntPtr cb, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_set_cbuffer(IntPtr s, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbuffer_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbuffer_make(IntPtr tpoint, IntPtr tfloat);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbuffer_points(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbuffer_radius(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbuffer_trav_area(IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool merge_union);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbuffer_to_tfloat(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbuffer_to_tgeompoint(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeometry_to_tcbuffer(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbuffer_expand(IntPtr temp, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbuffer_at_cbuffer(IntPtr temp, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbuffer_at_geom(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbuffer_at_stbox(IntPtr temp, IntPtr box, [MarshalAs(UnmanagedType.U1)] bool border_inc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbuffer_minus_cbuffer(IntPtr temp, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbuffer_minus_geom(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbuffer_minus_stbox(IntPtr temp, IntPtr box, [MarshalAs(UnmanagedType.U1)] bool border_inc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdistance_tcbuffer_cbuffer(IntPtr temp, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdistance_tcbuffer_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdistance_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tcbuffer_cbuffer(IntPtr temp, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tcbuffer_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tcbuffer_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nai_tcbuffer_cbuffer(IntPtr temp, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nai_tcbuffer_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nai_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr shortestline_tcbuffer_cbuffer(IntPtr temp, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr shortestline_tcbuffer_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr shortestline_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_cbuffer_tcbuffer(IntPtr cb, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_tcbuffer_cbuffer(IntPtr temp, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_cbuffer_tcbuffer(IntPtr cb, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_tcbuffer_cbuffer(IntPtr temp, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_cbuffer_tcbuffer(IntPtr cb, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_tcbuffer_cbuffer(IntPtr temp, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_cbuffer_tcbuffer(IntPtr cb, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_tcbuffer_cbuffer(IntPtr temp, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_cbuffer_tcbuffer(IntPtr cb, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_tcbuffer_cbuffer(IntPtr temp, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_cbuffer_tcbuffer(IntPtr cb, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_tcbuffer_cbuffer(IntPtr temp, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int acontains_cbuffer_tcbuffer(IntPtr cb, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int acontains_geo_tcbuffer(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int acontains_tcbuffer_cbuffer(IntPtr temp, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int acontains_tcbuffer_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int acovers_cbuffer_tcbuffer(IntPtr cb, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int acovers_geo_tcbuffer(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int acovers_tcbuffer_cbuffer(IntPtr temp, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int acovers_tcbuffer_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int adisjoint_tcbuffer_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int adisjoint_tcbuffer_cbuffer(IntPtr temp, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int adisjoint_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int adwithin_tcbuffer_geo(IntPtr temp, IntPtr gs, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int adwithin_tcbuffer_cbuffer(IntPtr temp, IntPtr cb, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int adwithin_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int aintersects_tcbuffer_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int aintersects_tcbuffer_cbuffer(IntPtr temp, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int aintersects_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int atouches_tcbuffer_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int atouches_tcbuffer_cbuffer(IntPtr temp, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int atouches_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int econtains_cbuffer_tcbuffer(IntPtr cb, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int econtains_tcbuffer_cbuffer(IntPtr temp, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int econtains_tcbuffer_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ecovers_cbuffer_tcbuffer(IntPtr cb, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ecovers_tcbuffer_cbuffer(IntPtr temp, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ecovers_tcbuffer_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ecovers_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int edisjoint_tcbuffer_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int edisjoint_tcbuffer_cbuffer(IntPtr temp, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int edwithin_tcbuffer_geo(IntPtr temp, IntPtr gs, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int edwithin_tcbuffer_cbuffer(IntPtr temp, IntPtr cb, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int edwithin_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int eintersects_tcbuffer_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int eintersects_tcbuffer_cbuffer(IntPtr temp, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int eintersects_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int etouches_tcbuffer_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int etouches_tcbuffer_cbuffer(IntPtr temp, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int etouches_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcontains_cbuffer_tcbuffer(IntPtr cb, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcontains_geo_tcbuffer(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcontains_tcbuffer_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcontains_tcbuffer_cbuffer(IntPtr temp, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcontains_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcovers_cbuffer_tcbuffer(IntPtr cb, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcovers_geo_tcbuffer(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcovers_tcbuffer_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcovers_tcbuffer_cbuffer(IntPtr temp, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcovers_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdwithin_geo_tcbuffer(IntPtr gs, IntPtr temp, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdwithin_tcbuffer_geo(IntPtr temp, IntPtr gs, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdwithin_tcbuffer_cbuffer(IntPtr temp, IntPtr cb, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdwithin_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdisjoint_cbuffer_tcbuffer(IntPtr cb, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdisjoint_geo_tcbuffer(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdisjoint_tcbuffer_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdisjoint_tcbuffer_cbuffer(IntPtr temp, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdisjoint_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintersects_cbuffer_tcbuffer(IntPtr cb, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintersects_geo_tcbuffer(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintersects_tcbuffer_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintersects_tcbuffer_cbuffer(IntPtr temp, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintersects_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttouches_geo_tcbuffer(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttouches_tcbuffer_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttouches_cbuffer_tcbuffer(IntPtr cb, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttouches_tcbuffer_cbuffer(IntPtr temp, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttouches_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr gsl_get_generation_rng();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr gsl_get_aggregation_rng();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong datum_ceil(ulong d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong datum_degrees(ulong d, ulong normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong datum_float_round(ulong value, ulong size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong datum_floor(ulong d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint datum_hash(ulong d, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong datum_hash_extended(ulong d, int basetype, ulong seed);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong datum_radians(ulong d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void floatspan_round_set(IntPtr s, int maxdd, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_in(string str, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string set_out(IntPtr s, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr span_in(string str, int spantype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string span_out(IntPtr s, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_in(string str, int spantype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string spanset_out(IntPtr ss, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_make(IntPtr values, int count, int basetype, [MarshalAs(UnmanagedType.U1)] bool order);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_make_exp(IntPtr values, int count, int maxcount, int basetype, [MarshalAs(UnmanagedType.U1)] bool order);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_make_free(IntPtr values, int count, int basetype, [MarshalAs(UnmanagedType.U1)] bool order);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr span_make(ulong lower, ulong upper, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void span_set(ulong lower, ulong upper, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc, int basetype, int spantype, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_make_exp(IntPtr spans, int count, int maxcount, [MarshalAs(UnmanagedType.U1)] bool normalize, [MarshalAs(UnmanagedType.U1)] bool order);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_make_free(IntPtr spans, int count, [MarshalAs(UnmanagedType.U1)] bool normalize, [MarshalAs(UnmanagedType.U1)] bool order);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_span(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_spanset(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void value_set_span(ulong value, int basetype, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr value_set(ulong d, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr value_span(ulong d, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr value_spanset(ulong d, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong numspan_width(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong numspanset_width(IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool boundspan);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong set_end_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int set_mem_size(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void set_set_subspan(IntPtr s, int minidx, int maxidx, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void set_set_span(IntPtr s, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong set_start_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool set_value_n(IntPtr s, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_vals(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_values(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong spanset_lower(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int spanset_mem_size(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_sps(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong spanset_upper(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void datespan_set_tstzspan(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void floatspan_set_intspan(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void intspan_set_floatspan(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr numset_shift_scale(IntPtr s, ulong shift, ulong width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr numspan_expand(IntPtr s, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr numspan_shift_scale(IntPtr s, ulong shift, ulong width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr numspanset_shift_scale(IntPtr ss, ulong shift, ulong width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_compact(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void span_expand(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_compact(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_expand_value(IntPtr box, ulong value, int basetyp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr textcat_textset_text_common(IntPtr s, IntPtr txt, [MarshalAs(UnmanagedType.U1)] bool invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tstzspan_set_datespan(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_span_value(IntPtr s, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_spanset_value(IntPtr ss, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_value_spanset(ulong value, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_value_set(ulong value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_value_span(ulong value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_value_spanset(ulong value, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_set_value(IntPtr s, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_span_value(IntPtr s, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_spanset_value(IntPtr ss, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ovadj_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_set_value(IntPtr s, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_span_value(IntPtr s, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_spanset_value(IntPtr ss, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_value_set(ulong value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_value_span(ulong value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_value_spanset(ulong value, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool lfnadj_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_set_value(IntPtr s, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_span_value(IntPtr s, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_spanset_value(IntPtr ss, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_value_set(ulong value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_value_span(ulong value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_value_spanset(ulong value, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_set_value(IntPtr s, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_span_value(IntPtr s, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_spanset_value(IntPtr ss, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_value_set(ulong value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_value_span(ulong value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_value_spanset(ulong value, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_value_set(ulong value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_set_value(IntPtr s, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_value_span(ulong value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_value_spanset(ulong value, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_span_value(IntPtr s, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_spanset_value(IntPtr ss, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool bbox_type(int bboxtype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong bbox_get_size(int bboxtype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int bbox_max_dims(int bboxtype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool temporal_bbox_eq(IntPtr box1, IntPtr box2, int temptype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int temporal_bbox_cmp(IntPtr box1, IntPtr box2, int temptype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void bbox_union_span_span(IntPtr s1, IntPtr s2, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool inter_span_span(IntPtr s1, IntPtr s2, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_set_value(IntPtr s, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_span_value(IntPtr s, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_spanset_value(IntPtr ss, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_value_set(ulong value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_value_span(ulong value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_value_spanset(ulong value, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int mi_span_span(IntPtr s1, IntPtr s2, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_set_value(IntPtr s, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_span_value(IntPtr s, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_spanset_value(IntPtr ss, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_value_set(ulong value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_value_span(ulong value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_value_spanset(ulong value, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr super_union_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_set_value(IntPtr s, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_span_value(IntPtr s, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_spanset_value(IntPtr ss, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_value_set(ulong value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_value_span(ulong value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_value_spanset(ulong value, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong distance_set_set(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong distance_set_value(IntPtr s, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong distance_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong distance_span_value(IntPtr s, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong distance_spanset_span(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong distance_spanset_spanset(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong distance_spanset_value(IntPtr ss, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong distance_value_value(ulong l, ulong r, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanbase_extent_transfn(IntPtr state, ulong value, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr value_union_transfn(IntPtr state, ulong value, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr number_tstzspan_to_tbox(ulong d, int basetype, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr number_timestamptz_to_tbox(ulong d, int basetype, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tbox_set(IntPtr s, IntPtr p, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void float_set_tbox(double d, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void int_set_tbox(int i, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void number_set_tbox(ulong d, int basetype, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr number_tbox(ulong value, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void numset_set_tbox(IntPtr s, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void numspan_set_tbox(IntPtr span, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void timestamptz_set_tbox(long t, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tstzset_set_tbox(IntPtr s, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tstzspan_set_tbox(IntPtr s, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_shift_scale_value(IntPtr box, ulong shift, ulong width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tbox_expand(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool inter_tbox_tbox(IntPtr box1, IntPtr box2, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tboolinst_from_mfjson(IntPtr mfjson);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tboolinst_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tboolseq_from_mfjson(IntPtr mfjson);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tboolseq_in(string str, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tboolseqset_from_mfjson(IntPtr mfjson);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tboolseqset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_in(string str, int temptype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string temporal_out(IntPtr temp, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temparr_out(IntPtr temparr, int count, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloatinst_from_mfjson(IntPtr mfjson);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloatinst_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloatseq_from_mfjson(IntPtr mfjson, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloatseq_in(string str, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloatseqset_from_mfjson(IntPtr mfjson, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloatseqset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_from_mfjson(IntPtr mfjson, [MarshalAs(UnmanagedType.U1)] bool spatial, int srid, int temptype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_in(string str, int temptype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tinstant_out(IntPtr inst, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintinst_from_mfjson(IntPtr mfjson);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintinst_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintseq_from_mfjson(IntPtr mfjson);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintseq_in(string str, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintseqset_from_mfjson(IntPtr mfjson);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintseqset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_from_mfjson(IntPtr mfjson, [MarshalAs(UnmanagedType.U1)] bool spatial, int srid, int temptype, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_in(string str, int temptype, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tsequence_out(IntPtr seq, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_from_mfjson(IntPtr mfjson, [MarshalAs(UnmanagedType.U1)] bool spatial, int srid, int temptype, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_in(string str, int temptype, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tsequenceset_out(IntPtr ss, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttextinst_from_mfjson(IntPtr mfjson);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttextinst_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttextseq_from_mfjson(IntPtr mfjson);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttextseq_in(string str, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttextseqset_from_mfjson(IntPtr mfjson);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttextseqset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_from_mfjson(string mfjson, int temptype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_from_base_temp(ulong value, int temptype, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_copy(IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_make(ulong value, int temptype, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_make_free(ulong value, int temptype, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_copy(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_from_base_temp(ulong value, int temptype, IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_from_base_tstzset(ulong value, int temptype, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_from_base_tstzspan(ulong value, int temptype, IntPtr s, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_make_exp(IntPtr instants, int count, int maxcount, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc, int interp, [MarshalAs(UnmanagedType.U1)] bool normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_make_free(IntPtr instants, int count, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc, int interp, [MarshalAs(UnmanagedType.U1)] bool normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_copy(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tseqsetarr_to_tseqset(IntPtr seqsets, int count, int totalseqs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_from_base_temp(ulong value, int temptype, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_from_base_tstzspanset(ulong value, int temptype, IntPtr ss, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_make_exp(IntPtr sequences, int count, int maxcount, [MarshalAs(UnmanagedType.U1)] bool normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_make_free(IntPtr sequences, int count, [MarshalAs(UnmanagedType.U1)] bool normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void temporal_set_tstzspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tinstant_set_tstzspan(IntPtr inst, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tnumber_set_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tnumberinst_set_tbox(IntPtr inst, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tnumberseq_set_tbox(IntPtr seq, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tnumberseqset_set_tbox(IntPtr ss, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tsequence_set_tstzspan(IntPtr seq, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tsequenceset_set_tstzspan(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_end_inst(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong temporal_end_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_inst_n(IntPtr temp, int n);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_insts_p(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_max_inst_p(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong temporal_max_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong temporal_mem_size(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_min_inst_p(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong temporal_min_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_sequences_p(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void temporal_set_bbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_start_inst(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong temporal_start_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_values_p(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool temporal_value_n(IntPtr temp, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_values(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint tinstant_hash(IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_insts(IntPtr inst, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tinstant_set_bbox(IntPtr inst, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_time(IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_timestamps(IntPtr inst, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong tinstant_value_p(IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong tinstant_value(IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tinstant_value_at_timestamptz(IntPtr inst, long t, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_values_p(IntPtr inst, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tnumber_set_span(IntPtr temp, IntPtr span);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumberinst_valuespans(IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tnumberseq_avg_val(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumberseq_valuespans(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tnumberseqset_avg_val(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumberseqset_valuespans(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_duration(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long tsequence_end_timestamptz(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint tsequence_hash(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_insts_p(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_max_inst_p(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong tsequence_max_val(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_min_inst_p(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong tsequence_min_val(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_segments(IntPtr seq, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_seqs(IntPtr seq, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long tsequence_start_timestamptz(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_time(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_timestamps(IntPtr seq, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tsequence_value_at_timestamptz(IntPtr seq, long t, [MarshalAs(UnmanagedType.U1)] bool strict, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_values_p(IntPtr seq, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_duration(IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool boundspan);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long tsequenceset_end_timestamptz(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint tsequenceset_hash(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_inst_n(IntPtr ss, int n);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_insts_p(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_max_inst_p(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong tsequenceset_max_val(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_min_inst_p(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong tsequenceset_min_val(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tsequenceset_num_instants(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tsequenceset_num_timestamps(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_segments(IntPtr ss, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_sequences_p(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long tsequenceset_start_timestamptz(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_time(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tsequenceset_timestamptz_n(IntPtr ss, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_timestamps(IntPtr ss, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tsequenceset_value_at_timestamptz(IntPtr ss, long t, [MarshalAs(UnmanagedType.U1)] bool strict, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tsequenceset_value_n(IntPtr ss, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_values_p(IntPtr ss, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void temporal_restart(IntPtr temp, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_tsequence(IntPtr temp, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_tsequenceset(IntPtr temp, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_shift_time(IntPtr inst, IntPtr interv);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_to_tsequence(IntPtr inst, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_to_tsequence_free(IntPtr inst, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_to_tsequenceset(IntPtr inst, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_shift_scale_value(IntPtr temp, ulong shift, ulong width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumberinst_shift_value(IntPtr inst, ulong shift);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumberseq_shift_scale_value(IntPtr seq, ulong shift, ulong width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumberseqset_shift_scale_value(IntPtr ss, ulong start, ulong width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tsequence_restart(IntPtr seq, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_set_interp(IntPtr seq, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_shift_scale_time(IntPtr seq, IntPtr shift, IntPtr duration);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_subseq(IntPtr seq, int from, int to, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_to_tinstant(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_to_tsequenceset(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_to_tsequenceset_free(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_to_tsequenceset_interp(IntPtr seq, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tsequenceset_restart(IntPtr ss, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_set_interp(IntPtr ss, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_shift_scale_time(IntPtr ss, IntPtr start, IntPtr duration);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_to_discrete(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_to_linear(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_to_step(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_to_tinstant(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_to_tsequence(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_merge(IntPtr inst1, IntPtr inst2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_merge_array(IntPtr instants, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_append_tinstant(IntPtr seq, IntPtr inst, double maxdist, IntPtr maxt, [MarshalAs(UnmanagedType.U1)] bool expand);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_append_tsequence(IntPtr seq1, IntPtr seq2, [MarshalAs(UnmanagedType.U1)] bool expand);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_delete_timestamptz(IntPtr seq, long t, [MarshalAs(UnmanagedType.U1)] bool connect);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_delete_tstzset(IntPtr seq, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool connect);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_delete_tstzspan(IntPtr seq, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool connect);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_delete_tstzspanset(IntPtr seq, IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool connect);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_insert(IntPtr seq1, IntPtr seq2, [MarshalAs(UnmanagedType.U1)] bool connect);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_merge(IntPtr seq1, IntPtr seq2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_merge_array(IntPtr sequences, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_append_tinstant(IntPtr ss, IntPtr inst, double maxdist, IntPtr maxt, [MarshalAs(UnmanagedType.U1)] bool expand);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_append_tsequence(IntPtr ss, IntPtr seq, [MarshalAs(UnmanagedType.U1)] bool expand);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_delete_timestamptz(IntPtr ss, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_delete_tstzset(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_delete_tstzspan(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_delete_tstzspanset(IntPtr ss, IntPtr ps);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_insert(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_merge(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_merge_array(IntPtr seqsets, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tsequence_expand_bbox(IntPtr seq, IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tsequence_set_bbox(IntPtr seq, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tsequenceset_expand_bbox(IntPtr ss, IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tsequenceset_set_bbox(IntPtr ss, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcontseq_after_timestamptz(IntPtr seq, long t, [MarshalAs(UnmanagedType.U1)] bool strict);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcontseq_before_timestamptz(IntPtr seq, long t, [MarshalAs(UnmanagedType.U1)] bool strict);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcontseq_restrict_minmax(IntPtr seq, [MarshalAs(UnmanagedType.U1)] bool min, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdiscseq_after_timestamptz(IntPtr seq, long t, [MarshalAs(UnmanagedType.U1)] bool strict);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdiscseq_before_timestamptz(IntPtr seq, long t, [MarshalAs(UnmanagedType.U1)] bool strict);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdiscseq_restrict_minmax(IntPtr seq, [MarshalAs(UnmanagedType.U1)] bool min, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool temporal_bbox_restrict_set(IntPtr temp, IntPtr set);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_restrict_minmax(IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool min, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_restrict_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_restrict_tstzset(IntPtr temp, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_restrict_tstzspan(IntPtr temp, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_restrict_tstzspanset(IntPtr temp, IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_restrict_value(IntPtr temp, ulong value, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_restrict_values(IntPtr temp, IntPtr set, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool temporal_value_at_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool strict, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_after_timestamptz(IntPtr inst, long t, [MarshalAs(UnmanagedType.U1)] bool strict);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_before_timestamptz(IntPtr inst, long t, [MarshalAs(UnmanagedType.U1)] bool strict);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_restrict_tstzspan(IntPtr inst, IntPtr period, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_restrict_tstzspanset(IntPtr inst, IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_restrict_timestamptz(IntPtr inst, long t, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_restrict_tstzset(IntPtr inst, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_restrict_value(IntPtr inst, ulong value, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_restrict_values(IntPtr inst, IntPtr set, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_restrict_span(IntPtr temp, IntPtr span, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_restrict_spanset(IntPtr temp, IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumberinst_restrict_span(IntPtr inst, IntPtr span, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumberinst_restrict_spanset(IntPtr inst, IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumberseqset_restrict_span(IntPtr ss, IntPtr span, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumberseqset_restrict_spanset(IntPtr ss, IntPtr spanset, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_at_timestamptz(IntPtr seq, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_restrict_tstzspan(IntPtr seq, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_restrict_tstzspanset(IntPtr seq, IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_after_timestamptz(IntPtr ss, long t, [MarshalAs(UnmanagedType.U1)] bool strict);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_before_timestamptz(IntPtr ss, long t, [MarshalAs(UnmanagedType.U1)] bool strict);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_restrict_minmax(IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool min, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_restrict_tstzspan(IntPtr ss, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_restrict_tstzspanset(IntPtr ss, IntPtr ps, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_restrict_timestamptz(IntPtr ss, long t, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_restrict_tstzset(IntPtr ss, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_restrict_value(IntPtr ss, ulong value, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_restrict_values(IntPtr ss, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tinstant_cmp(IntPtr inst1, IntPtr inst2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tinstant_eq(IntPtr inst1, IntPtr inst2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tsequence_cmp(IntPtr seq1, IntPtr seq2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tsequence_eq(IntPtr seq1, IntPtr seq2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tsequenceset_cmp(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tsequenceset_eq(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_base_temporal(ulong value, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_temporal_base(IntPtr temp, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_base_temporal(ulong value, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_temporal_base(IntPtr temp, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ge_base_temporal(ulong value, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ge_temporal_base(IntPtr temp, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_gt_base_temporal(ulong value, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_gt_temporal_base(IntPtr temp, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_le_base_temporal(ulong value, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_le_temporal_base(IntPtr temp, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_lt_base_temporal(ulong value, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_lt_temporal_base(IntPtr temp, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_base_temporal(ulong value, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_temporal_base(IntPtr temp, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_base_temporal(ulong value, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_temporal_base(IntPtr temp, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ge_base_temporal(ulong value, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ge_temporal_base(IntPtr temp, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_gt_base_temporal(ulong value, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_gt_temporal_base(IntPtr temp, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_le_base_temporal(ulong value, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_le_temporal_base(IntPtr temp, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_lt_base_temporal(ulong value, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_lt_temporal_base(IntPtr temp, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumberinst_abs(IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumberseq_abs(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumberseq_angular_difference(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumberseq_delta_value(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumberseqset_abs(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumberseqset_angular_difference(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumberseqset_delta_value(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdistance_tnumber_number(IntPtr temp, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tnumber_number(IntPtr temp, ulong value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tnumberseq_integral(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tnumberseq_twavg(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tnumberseqset_integral(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tnumberseqset_twavg(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_compact(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_compact(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_compact(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_skiplist_make();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr skiplist_make(ulong key_size, ulong value_size, IntPtr comp_fn, IntPtr merge_fn);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int skiplist_search(IntPtr list, IntPtr key, IntPtr value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void skiplist_free(IntPtr list);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void skiplist_splice(IntPtr list, IntPtr keys, IntPtr values, int count, IntPtr func, [MarshalAs(UnmanagedType.U1)] bool crossings, IntPtr sktype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void temporal_skiplist_splice(IntPtr list, IntPtr values, int count, IntPtr func, [MarshalAs(UnmanagedType.U1)] bool crossings);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr skiplist_values(IntPtr list);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr skiplist_keys_values(IntPtr list, IntPtr values);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_app_tinst_transfn(IntPtr state, IntPtr inst, int interp, double maxdist, IntPtr maxt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_app_tseq_transfn(IntPtr state, IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr span_bins(IntPtr s, ulong size, ulong origin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_bins(IntPtr ss, ulong size, ulong origin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_value_bins(IntPtr temp, ulong size, ulong origin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_value_time_boxes(IntPtr temp, ulong vsize, IntPtr duration, ulong vorigin, long torigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_value_split(IntPtr temp, ulong vsize, ulong vorigin, IntPtr bins, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_get_value_time_tile(ulong value, long t, ulong vsize, IntPtr duration, ulong vorigin, long torigin, int basetype, int spantype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_value_time_split(IntPtr temp, ulong size, IntPtr duration, ulong vorigin, long torigin, IntPtr value_bins, IntPtr time_bins, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr proj_get_context();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong datum_geo_round(ulong value, ulong size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr point_round(IntPtr gs, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void stbox_set([MarshalAs(UnmanagedType.U1)] bool hasx, [MarshalAs(UnmanagedType.U1)] bool hasz, [MarshalAs(UnmanagedType.U1)] bool geodetic, int srid, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, IntPtr s, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void gbox_set_stbox(IntPtr box, int srid, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geo_set_stbox(IntPtr gs, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void geoarr_set_stbox(IntPtr values, int count, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool spatial_set_stbox(ulong d, int basetype, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void spatialset_set_stbox(IntPtr set, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void stbox_set_box3d(IntPtr box, IntPtr box3d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void stbox_set_gbox(IntPtr box, IntPtr gbox);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tstzset_set_stbox(IntPtr s, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tstzspan_set_stbox(IntPtr s, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tstzspanset_set_stbox(IntPtr s, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void stbox_expand(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool inter_stbox_stbox(IntPtr box1, IntPtr box2, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_geo(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeogpointinst_from_mfjson(IntPtr mfjson, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeogpointinst_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeogpointseq_from_mfjson(IntPtr mfjson, int srid, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeogpointseq_in(string str, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeogpointseqset_from_mfjson(IntPtr mfjson, int srid, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeogpointseqset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeompointinst_from_mfjson(IntPtr mfjson, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeompointinst_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeompointseq_from_mfjson(IntPtr mfjson, int srid, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeompointseq_in(string str, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeompointseqset_from_mfjson(IntPtr mfjson, int srid, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeompointseqset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeographyinst_from_mfjson(IntPtr mfjson, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeographyinst_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeographyseq_from_mfjson(IntPtr mfjson, int srid, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeographyseq_in(string str, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeographyseqset_from_mfjson(IntPtr mfjson, int srid, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeographyseqset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeometryinst_from_mfjson(IntPtr mfjson, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeometryinst_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeometryseq_from_mfjson(IntPtr mfjson, int srid, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeometryseq_in(string str, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeometryseqset_from_mfjson(IntPtr mfjson, int srid, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeometryseqset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tspatial_set_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tgeoinst_set_stbox(IntPtr inst, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tspatialseq_set_stbox(IntPtr seq, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tspatialseqset_set_stbox(IntPtr ss, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeo_restrict_elevation(IntPtr temp, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeo_restrict_geom(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeo_restrict_stbox(IntPtr temp, IntPtr box, [MarshalAs(UnmanagedType.U1)] bool border_inc, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeoinst_restrict_geom(IntPtr inst, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeoinst_restrict_stbox(IntPtr inst, IntPtr box, [MarshalAs(UnmanagedType.U1)] bool border_inc, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeoseq_restrict_geom(IntPtr seq, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeoseq_restrict_stbox(IntPtr seq, IntPtr box, [MarshalAs(UnmanagedType.U1)] bool border_inc, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeoseqset_restrict_geom(IntPtr ss, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeoseqset_restrict_stbox(IntPtr ss, IntPtr box, [MarshalAs(UnmanagedType.U1)] bool border_inc, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int spatial_srid(ulong d, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool spatial_set_srid(ulong d, int basetype, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tspatialinst_srid(IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpointseq_azimuth(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpointseq_cumulative_length(IntPtr seq, double prevlength);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpointseq_is_simple(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tpointseq_length(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpointseq_linear_trajectory(IntPtr seq, [MarshalAs(UnmanagedType.U1)] bool unary_union);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeoseq_stboxes(IntPtr seq, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeoseq_split_n_stboxes(IntPtr seq, int max_count, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpointseqset_azimuth(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpointseqset_cumulative_length(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpointseqset_is_simple(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tpointseqset_length(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeoseqset_stboxes(IntPtr ss, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeoseqset_split_n_stboxes(IntPtr ss, int max_count, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_get_coord(IntPtr temp, int coord);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeominst_tgeoginst(IntPtr inst, [MarshalAs(UnmanagedType.U1)] bool oper);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeomseq_tgeogseq(IntPtr seq, [MarshalAs(UnmanagedType.U1)] bool oper);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeomseqset_tgeogseqset(IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool oper);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeom_tgeog(IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool oper);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeo_tpoint(IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool oper);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tspatialinst_set_srid(IntPtr inst, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpointseq_make_simple(IntPtr seq, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tspatialseq_set_srid(IntPtr seq, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpointseqset_make_simple(IntPtr ss, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tspatialseqset_set_srid(IntPtr ss, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpointseq_twcentroid(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpointseqset_twcentroid(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string npoint_as_ewkt(IntPtr np, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string npoint_as_hexwkb(IntPtr np, IntPtr variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string npoint_as_text(IntPtr np, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr npoint_as_wkb(IntPtr np, IntPtr variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr npoint_from_hexwkb(string hexwkb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr npoint_from_wkb(IntPtr wkb, ulong size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr npoint_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string npoint_out(IntPtr np, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nsegment_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string nsegment_out(IntPtr ns, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr npoint_make(long rid, double pos);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nsegment_make(long rid, double pos1, double pos2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geompoint_to_npoint(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geom_to_nsegment(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr npoint_to_geompoint(IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr npoint_to_nsegment(IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr npoint_to_stbox(IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nsegment_to_geom(IntPtr ns);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nsegment_to_stbox(IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint npoint_hash(IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong npoint_hash_extended(IntPtr np, ulong seed);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double npoint_position(IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long npoint_route(IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nsegment_end_position(IntPtr ns);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long nsegment_route(IntPtr ns);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nsegment_start_position(IntPtr ns);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool route_exists(long rid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr route_geom(long rid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double route_length(long rid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr npoint_round(IntPtr np, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nsegment_round(IntPtr ns, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int get_srid_ways();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int npoint_srid(IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int nsegment_srid(IntPtr ns);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr npoint_timestamptz_to_stbox(IntPtr np, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr npoint_tstzspan_to_stbox(IntPtr np, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int npoint_cmp(IntPtr np1, IntPtr np2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool npoint_eq(IntPtr np1, IntPtr np2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool npoint_ge(IntPtr np1, IntPtr np2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool npoint_gt(IntPtr np1, IntPtr np2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool npoint_le(IntPtr np1, IntPtr np2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool npoint_lt(IntPtr np1, IntPtr np2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool npoint_ne(IntPtr np1, IntPtr np2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool npoint_same(IntPtr np1, IntPtr np2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int nsegment_cmp(IntPtr ns1, IntPtr ns2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool nsegment_eq(IntPtr ns1, IntPtr ns2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool nsegment_ge(IntPtr ns1, IntPtr ns2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool nsegment_gt(IntPtr ns1, IntPtr ns2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool nsegment_le(IntPtr ns1, IntPtr ns2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool nsegment_lt(IntPtr ns1, IntPtr ns2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool nsegment_ne(IntPtr ns1, IntPtr ns2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr npointset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string npointset_out(IntPtr s, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr npointset_make(IntPtr values, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr npoint_to_set(IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr npointset_end_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr npointset_routes(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr npointset_start_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool npointset_value_n(IntPtr s, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr npointset_values(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_npoint_set(IntPtr np, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_set_npoint(IntPtr s, IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_npoint_set(IntPtr np, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_set_npoint(IntPtr s, IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_npoint_set(IntPtr np, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_set_npoint(IntPtr s, IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr npoint_union_transfn(IntPtr state, IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_npoint_set(IntPtr np, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_set_npoint(IntPtr s, IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tnpoint_out(IntPtr temp, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpointinst_make(IntPtr np, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeompoint_to_tnpoint(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_to_tgeompoint(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_cumulative_length(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tnpoint_length(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_positions(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long tnpoint_route(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_routes(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_speed(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_trajectory(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_twcentroid(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_at_geom(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_at_npoint(IntPtr temp, IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_at_npointset(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_at_stbox(IntPtr temp, IntPtr box, [MarshalAs(UnmanagedType.U1)] bool border_inc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_minus_geom(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_minus_npoint(IntPtr temp, IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_minus_npointset(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_minus_stbox(IntPtr temp, IntPtr box, [MarshalAs(UnmanagedType.U1)] bool border_inc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdistance_tnpoint_npoint(IntPtr temp, IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdistance_tnpoint_point(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdistance_tnpoint_tnpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tnpoint_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tnpoint_npoint(IntPtr temp, IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tnpoint_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tnpoint_tnpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nai_tnpoint_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nai_tnpoint_npoint(IntPtr temp, IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nai_tnpoint_tnpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr shortestline_tnpoint_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr shortestline_tnpoint_npoint(IntPtr temp, IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr shortestline_tnpoint_tnpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_tcentroid_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_npoint_tnpoint(IntPtr np, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_tnpoint_npoint(IntPtr temp, IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_tnpoint_tnpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_npoint_tnpoint(IntPtr np, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_tnpoint_npoint(IntPtr temp, IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_tnpoint_tnpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_npoint_tnpoint(IntPtr np, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_tnpoint_npoint(IntPtr temp, IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_tnpoint_tnpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_npoint_tnpoint(IntPtr np, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_tnpoint_npoint(IntPtr temp, IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_tnpoint_tnpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_tnpoint_npoint(IntPtr temp, IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_tnpoint_npoint(IntPtr temp, IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string pose_as_ewkt(IntPtr pose, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string pose_as_hexwkb(IntPtr pose, IntPtr variant, IntPtr size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string pose_as_text(IntPtr pose, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_as_wkb(IntPtr pose, IntPtr variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_from_wkb(IntPtr wkb, ulong size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_from_hexwkb(string hexwkb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string pose_out(IntPtr pose, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_copy(IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_make_2d(double x, double y, double theta, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_make_3d(double x, double y, double z, double W, double X, double Y, double Z, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_make_point2d(IntPtr gs, double theta);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_make_point3d(IntPtr gs, double W, double X, double Y, double Z);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_to_point(IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_to_stbox(IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint pose_hash(IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong pose_hash_extended(IntPtr pose, ulong seed);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_orientation(IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double pose_rotation(IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_round(IntPtr pose, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr posearr_round(IntPtr posearr, int count, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void pose_set_srid(IntPtr pose, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int pose_srid(IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_transform(IntPtr pose, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_transform_pipeline(IntPtr pose, string pipelinestr, int srid, [MarshalAs(UnmanagedType.U1)] bool is_forward);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_tstzspan_to_stbox(IntPtr pose, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_timestamptz_to_stbox(IntPtr pose, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_pose_geo(IntPtr pose, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_pose_pose(IntPtr pose1, IntPtr pose2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_pose_stbox(IntPtr pose, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int pose_cmp(IntPtr pose1, IntPtr pose2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pose_eq(IntPtr pose1, IntPtr pose2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pose_ge(IntPtr pose1, IntPtr pose2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pose_gt(IntPtr pose1, IntPtr pose2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pose_le(IntPtr pose1, IntPtr pose2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pose_lt(IntPtr pose1, IntPtr pose2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pose_ne(IntPtr pose1, IntPtr pose2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pose_nsame(IntPtr pose1, IntPtr pose2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pose_same(IntPtr pose1, IntPtr pose2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr poseset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string poseset_out(IntPtr s, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr poseset_make(IntPtr values, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_to_set(IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr poseset_end_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr poseset_start_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool poseset_value_n(IntPtr s, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr poseset_values(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_pose_set(IntPtr pose, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_set_pose(IntPtr s, IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_pose_set(IntPtr pose, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_set_pose(IntPtr s, IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_pose_set(IntPtr pose, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_set_pose(IntPtr s, IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_union_transfn(IntPtr state, IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_pose_set(IntPtr pose, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_set_pose(IntPtr s, IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpose_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpose_make(IntPtr tpoint, IntPtr tradius);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpose_to_tpoint(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpose_end_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpose_points(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpose_rotation(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpose_start_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpose_trajectory(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpose_value_at_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool strict, IntPtr value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpose_value_n(IntPtr temp, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpose_values(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpose_at_geom(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpose_at_stbox(IntPtr temp, IntPtr box, [MarshalAs(UnmanagedType.U1)] bool border_inc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpose_at_pose(IntPtr temp, IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpose_minus_geom(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpose_minus_pose(IntPtr temp, IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpose_minus_stbox(IntPtr temp, IntPtr box, [MarshalAs(UnmanagedType.U1)] bool border_inc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdistance_tpose_pose(IntPtr temp, IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdistance_tpose_point(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdistance_tpose_tpose(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tpose_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tpose_pose(IntPtr temp, IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tpose_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tpose_tpose(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nai_tpose_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nai_tpose_pose(IntPtr temp, IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nai_tpose_tpose(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr shortestline_tpose_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr shortestline_tpose_pose(IntPtr temp, IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr shortestline_tpose_tpose(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_pose_tpose(IntPtr pose, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_tpose_pose(IntPtr temp, IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_tpose_tpose(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_pose_tpose(IntPtr pose, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_tpose_pose(IntPtr temp, IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_tpose_tpose(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_pose_tpose(IntPtr pose, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_tpose_pose(IntPtr temp, IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_tpose_tpose(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_pose_tpose(IntPtr pose, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_tpose_pose(IntPtr temp, IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_tpose_tpose(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_pose_tpose(IntPtr pose, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_tpose_pose(IntPtr temp, IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_pose_tpose(IntPtr pose, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_tpose_pose(IntPtr temp, IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string trgeo_out(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeoinst_make(IntPtr geom, IntPtr pose, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_tpose_to_trgeo(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_to_tpose(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_to_tpoint(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_end_instant(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_end_sequence(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_end_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_geom(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_instant_n(IntPtr temp, int n);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_instants(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_points(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_rotation(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_segments(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_sequence_n(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_sequences(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_start_instant(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_start_sequence(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_start_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool trgeo_value_n(IntPtr temp, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_traversed_area(IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool unary_union);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_append_tinstant(IntPtr temp, IntPtr inst, int interp, double maxdist, IntPtr maxt, [MarshalAs(UnmanagedType.U1)] bool expand);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_append_tsequence(IntPtr temp, IntPtr seq, [MarshalAs(UnmanagedType.U1)] bool expand);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_delete_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool connect);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_delete_tstzset(IntPtr temp, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool connect);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_delete_tstzspan(IntPtr temp, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool connect);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_delete_tstzspanset(IntPtr temp, IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool connect);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_round(IntPtr temp, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_set_interp(IntPtr temp, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_to_tinstant(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_after_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool strict);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_before_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool strict);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_restrict_value(IntPtr temp, ulong value, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_restrict_values(IntPtr temp, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_restrict_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_restrict_tstzset(IntPtr temp, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_restrict_tstzspan(IntPtr temp, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_restrict_tstzspanset(IntPtr temp, IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdistance_trgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdistance_trgeo_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdistance_trgeo_trgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_stbox_trgeo(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_trgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_trgeo_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_trgeo_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_trgeo_trgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nai_trgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nai_trgeo_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nai_trgeo_trgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr shortestline_trgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr shortestline_trgeo_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr shortestline_trgeo_trgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_geo_trgeo(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_trgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_trgeo_trgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_geo_trgeo(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_trgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_trgeo_trgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_geo_trgeo(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_trgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_trgeo_trgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_geo_trgeo(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_trgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_trgeo_trgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_geo_trgeo(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_trgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_geo_trgeo(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_trgeo_geo(IntPtr temp, IntPtr gs);

        }
    }
}
