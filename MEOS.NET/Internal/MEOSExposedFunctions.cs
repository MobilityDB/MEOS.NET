using System.CodeDom.Compiler;
using System.Runtime.InteropServices;

using MEOS.NET.Enums;

namespace MEOS.NET.Internal
{
    [GeneratedCode("MEOS.NET.Builder.MEOSIDL", "0.1.0")]
    internal partial class MEOSExposedFunctions
    {
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

        public static void rtree_insert_temporal_split(IntPtr rtree, IntPtr temp, int id, int maxboxes)
            => SafeExecution(() => MEOSExternalFunctions.rtree_insert_temporal_split(rtree, temp, id, maxboxes));

        public static int rtree_search(IntPtr rtree, IntPtr op, IntPtr query, IntPtr result)
            => SafeExecution<int>(() => MEOSExternalFunctions.rtree_search(rtree, op, query, result));

        public static int rtree_search_temporal(IntPtr rtree, IntPtr op, IntPtr temp, IntPtr result)
            => SafeExecution<int>(() => MEOSExternalFunctions.rtree_search_temporal(rtree, op, temp, result));

        public static int rtree_search_temporal_dedup(IntPtr rtree, IntPtr op, IntPtr temp, int maxboxes, IntPtr result)
            => SafeExecution<int>(() => MEOSExternalFunctions.rtree_search_temporal_dedup(rtree, op, temp, maxboxes, result));

        public static void meos_initialize_error_handler(IntPtr err_handler)
            => SafeExecution(() => MEOSExternalFunctions.meos_initialize_error_handler(err_handler));

        public static void meos_initialize_allocator(IntPtr malloc_fn, IntPtr realloc_fn, IntPtr free_fn)
            => SafeExecution(() => MEOSExternalFunctions.meos_initialize_allocator(malloc_fn, realloc_fn, free_fn));

        public static void meos_initialize_noexit_error_handler()
            => SafeExecution(() => MEOSExternalFunctions.meos_initialize_noexit_error_handler());

        public static void meos_initialize_timezone(string name)
            => SafeExecution(() => MEOSExternalFunctions.meos_initialize_timezone(name));

        public static void meos_initialize_collation()
            => SafeExecution(() => MEOSExternalFunctions.meos_initialize_collation());

        public static void meos_finalize_timezone()
            => SafeExecution(() => MEOSExternalFunctions.meos_finalize_timezone());

        public static void meos_finalize_collation()
            => SafeExecution(() => MEOSExternalFunctions.meos_finalize_collation());

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

        public static void meos_set_ways_csv(string path)
            => SafeExecution(() => MEOSExternalFunctions.meos_set_ways_csv(path));

        public static void meos_initialize()
            => SafeExecution(() => MEOSExternalFunctions.meos_initialize());

        public static void meos_finalize()
            => SafeExecution(() => MEOSExternalFunctions.meos_finalize());

        public static IntPtr bigintset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintset_in(str));

        public static string bigintset_out(IntPtr set)
            => SafeExecution<string>(() => MEOSExternalFunctions.bigintset_out(set));

        public static IntPtr bigintspan_expand(IntPtr s, IntPtr value)
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

        public static IntPtr bigintspan_make(IntPtr lower, IntPtr upper, bool lower_inc, bool upper_inc)
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

        public static IntPtr bigint_to_set(IntPtr i)
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

        public static IntPtr floatspan_to_bigintspan(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspan_to_bigintspan(s));

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

        public static IntPtr intspan_to_bigintspan(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intspan_to_bigintspan(s));

        public static IntPtr bigintspan_to_intspan(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintspan_to_intspan(s));

        public static IntPtr bigintspan_to_floatspan(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintspan_to_floatspan(s));

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

        public static IntPtr bigintset_end_value(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintset_end_value(s));

        public static IntPtr bigintset_start_value(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintset_start_value(s));

        public static bool bigintset_value_n(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.bigintset_value_n(s, n, result));

        public static IntPtr[] bigintset_values(IntPtr s)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintset_values(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr bigintspan_lower(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintspan_lower(s));

        public static IntPtr bigintspan_upper(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintspan_upper(s));

        public static IntPtr bigintspan_width(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintspan_width(s));

        public static IntPtr bigintspanset_lower(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintspanset_lower(ss));

        public static IntPtr bigintspanset_upper(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintspanset_upper(ss));

        public static IntPtr bigintspanset_width(IntPtr ss, bool boundspan)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintspanset_width(ss, boundspan));

        public static int dateset_end_value(IntPtr s)
            => SafeExecution<int>(() => MEOSExternalFunctions.dateset_end_value(s));

        public static int dateset_start_value(IntPtr s)
            => SafeExecution<int>(() => MEOSExternalFunctions.dateset_start_value(s));

        public static bool dateset_value_n(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.dateset_value_n(s, n, result));

        public static int[] dateset_values(IntPtr s)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.dateset_values(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                int[] _out = new int[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
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
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatset_values(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                double[] _out = new double[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
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
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.intset_values(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                int[] _out = new int[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
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

        public static int set_hash(IntPtr s)
            => SafeExecution<int>(() => MEOSExternalFunctions.set_hash(s));

        public static IntPtr set_hash_extended(IntPtr s, IntPtr seed)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_hash_extended(s, seed));

        public static int set_num_values(IntPtr s)
            => SafeExecution<int>(() => MEOSExternalFunctions.set_num_values(s));

        public static int span_hash(IntPtr s)
            => SafeExecution<int>(() => MEOSExternalFunctions.span_hash(s));

        public static IntPtr span_hash_extended(IntPtr s, IntPtr seed)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.span_hash_extended(s, seed));

        public static bool span_lower_inc(IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.span_lower_inc(s));

        public static bool span_upper_inc(IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.span_upper_inc(s));

        public static IntPtr spanset_end_span(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_end_span(ss));

        public static int spanset_hash(IntPtr ss)
            => SafeExecution<int>(() => MEOSExternalFunctions.spanset_hash(ss));

        public static IntPtr spanset_hash_extended(IntPtr ss, IntPtr seed)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_hash_extended(ss, seed));

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
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_spanarr(ss, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
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
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.textset_values(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static long tstzset_end_value(IntPtr s)
            => SafeExecution<long>(() => MEOSExternalFunctions.tstzset_end_value(s));

        public static long tstzset_start_value(IntPtr s)
            => SafeExecution<long>(() => MEOSExternalFunctions.tstzset_start_value(s));

        public static bool tstzset_value_n(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tstzset_value_n(s, n, result));

        public static long[] tstzset_values(IntPtr s)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzset_values(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                long[] _out = new long[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
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

        public static IntPtr bigintset_shift_scale(IntPtr s, IntPtr shift, IntPtr width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintset_shift_scale(s, shift, width, hasshift, haswidth));

        public static IntPtr bigintspan_shift_scale(IntPtr s, IntPtr shift, IntPtr width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintspan_shift_scale(s, shift, width, hasshift, haswidth));

        public static IntPtr bigintspanset_shift_scale(IntPtr ss, IntPtr shift, IntPtr width, bool hasshift, bool haswidth)
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

        public static IntPtr[] set_spans(IntPtr s)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_spans(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] set_split_each_n_spans(IntPtr s, int elems_per_span)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_split_each_n_spans(s, elems_per_span, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] set_split_n_spans(IntPtr s, int span_count)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_split_n_spans(s, span_count, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] spanset_spans(IntPtr ss)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_spans(ss, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] spanset_split_each_n_spans(IntPtr ss, int elems_per_span)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_split_each_n_spans(ss, elems_per_span, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] spanset_split_n_spans(IntPtr ss, int span_count)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_split_n_spans(ss, span_count, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool adjacent_span_bigint(IntPtr s, IntPtr i)
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

        public static bool adjacent_spanset_bigint(IntPtr ss, IntPtr i)
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

        public static bool contained_bigint_set(IntPtr i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_bigint_set(i, s));

        public static bool contained_bigint_span(IntPtr i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_bigint_span(i, s));

        public static bool contained_bigint_spanset(IntPtr i, IntPtr ss)
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

        public static bool contains_set_bigint(IntPtr s, IntPtr i)
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

        public static bool contains_span_bigint(IntPtr s, IntPtr i)
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

        public static bool contains_spanset_bigint(IntPtr ss, IntPtr i)
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

        public static bool same_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.same_span_span(s1, s2));

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

        public static bool left_bigint_set(IntPtr i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_bigint_set(i, s));

        public static bool left_bigint_span(IntPtr i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_bigint_span(i, s));

        public static bool left_bigint_spanset(IntPtr i, IntPtr ss)
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

        public static bool left_set_bigint(IntPtr s, IntPtr i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_set_bigint(s, i));

        public static bool left_set_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_set_float(s, d));

        public static bool left_set_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_set_int(s, i));

        public static bool left_set_set(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_set_set(s1, s2));

        public static bool left_set_text(IntPtr s, IntPtr txt)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_set_text(s, txt));

        public static bool left_span_bigint(IntPtr s, IntPtr i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_span_bigint(s, i));

        public static bool left_span_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_span_float(s, d));

        public static bool left_span_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_span_int(s, i));

        public static bool left_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_span_span(s1, s2));

        public static bool left_span_spanset(IntPtr s, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_span_spanset(s, ss));

        public static bool left_spanset_bigint(IntPtr ss, IntPtr i)
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

        public static bool overleft_bigint_set(IntPtr i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_bigint_set(i, s));

        public static bool overleft_bigint_span(IntPtr i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_bigint_span(i, s));

        public static bool overleft_bigint_spanset(IntPtr i, IntPtr ss)
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

        public static bool overleft_set_bigint(IntPtr s, IntPtr i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_set_bigint(s, i));

        public static bool overleft_set_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_set_float(s, d));

        public static bool overleft_set_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_set_int(s, i));

        public static bool overleft_set_set(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_set_set(s1, s2));

        public static bool overleft_set_text(IntPtr s, IntPtr txt)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_set_text(s, txt));

        public static bool overleft_span_bigint(IntPtr s, IntPtr i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_span_bigint(s, i));

        public static bool overleft_span_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_span_float(s, d));

        public static bool overleft_span_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_span_int(s, i));

        public static bool overleft_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_span_span(s1, s2));

        public static bool overleft_span_spanset(IntPtr s, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_span_spanset(s, ss));

        public static bool overleft_spanset_bigint(IntPtr ss, IntPtr i)
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

        public static bool overright_bigint_set(IntPtr i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_bigint_set(i, s));

        public static bool overright_bigint_span(IntPtr i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_bigint_span(i, s));

        public static bool overright_bigint_spanset(IntPtr i, IntPtr ss)
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

        public static bool overright_set_bigint(IntPtr s, IntPtr i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_set_bigint(s, i));

        public static bool overright_set_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_set_float(s, d));

        public static bool overright_set_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_set_int(s, i));

        public static bool overright_set_set(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_set_set(s1, s2));

        public static bool overright_set_text(IntPtr s, IntPtr txt)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_set_text(s, txt));

        public static bool overright_span_bigint(IntPtr s, IntPtr i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_span_bigint(s, i));

        public static bool overright_span_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_span_float(s, d));

        public static bool overright_span_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_span_int(s, i));

        public static bool overright_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_span_span(s1, s2));

        public static bool overright_span_spanset(IntPtr s, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_span_spanset(s, ss));

        public static bool overright_spanset_bigint(IntPtr ss, IntPtr i)
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

        public static bool right_bigint_set(IntPtr i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_bigint_set(i, s));

        public static bool right_bigint_span(IntPtr i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_bigint_span(i, s));

        public static bool right_bigint_spanset(IntPtr i, IntPtr ss)
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

        public static bool right_set_bigint(IntPtr s, IntPtr i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_set_bigint(s, i));

        public static bool right_set_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_set_float(s, d));

        public static bool right_set_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_set_int(s, i));

        public static bool right_set_set(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_set_set(s1, s2));

        public static bool right_set_text(IntPtr s, IntPtr txt)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_set_text(s, txt));

        public static bool right_span_bigint(IntPtr s, IntPtr i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_span_bigint(s, i));

        public static bool right_span_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_span_float(s, d));

        public static bool right_span_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_span_int(s, i));

        public static bool right_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_span_span(s1, s2));

        public static bool right_span_spanset(IntPtr s, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_span_spanset(s, ss));

        public static bool right_spanset_bigint(IntPtr ss, IntPtr i)
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

        public static IntPtr intersection_bigint_set(IntPtr i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_bigint_set(i, s));

        public static IntPtr intersection_date_set(int d, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_date_set(d, s));

        public static IntPtr intersection_float_set(double d, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_float_set(d, s));

        public static IntPtr intersection_int_set(int i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_int_set(i, s));

        public static IntPtr intersection_set_bigint(IntPtr s, IntPtr i)
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

        public static IntPtr intersection_span_bigint(IntPtr s, IntPtr i)
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

        public static IntPtr intersection_spanset_bigint(IntPtr ss, IntPtr i)
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

        public static IntPtr minus_bigint_set(IntPtr i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_bigint_set(i, s));

        public static IntPtr minus_bigint_span(IntPtr i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_bigint_span(i, s));

        public static IntPtr minus_bigint_spanset(IntPtr i, IntPtr ss)
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

        public static IntPtr minus_set_bigint(IntPtr s, IntPtr i)
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

        public static IntPtr minus_span_bigint(IntPtr s, IntPtr i)
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

        public static IntPtr minus_spanset_bigint(IntPtr ss, IntPtr i)
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

        public static IntPtr union_bigint_set(IntPtr i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_bigint_set(i, s));

        public static IntPtr union_bigint_span(IntPtr s, IntPtr i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_bigint_span(s, i));

        public static IntPtr union_bigint_spanset(IntPtr i, IntPtr ss)
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

        public static IntPtr union_set_bigint(IntPtr s, IntPtr i)
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

        public static IntPtr union_span_bigint(IntPtr s, IntPtr i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_span_bigint(s, i));

        public static IntPtr union_span_date(IntPtr s, int d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_span_date(s, d));

        public static IntPtr union_span_float(IntPtr s, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_span_float(s, d));

        public static IntPtr union_span_int(IntPtr s, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_span_int(s, i));

        public static IntPtr union_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_span_span(s1, s2));

        public static IntPtr super_union_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.super_union_span_span(s1, s2));

        public static IntPtr union_span_spanset(IntPtr s, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_span_spanset(s, ss));

        public static IntPtr union_span_timestamptz(IntPtr s, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_span_timestamptz(s, t));

        public static IntPtr union_spanset_bigint(IntPtr ss, IntPtr i)
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

        public static IntPtr distance_bigintset_bigintset(IntPtr s1, IntPtr s2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.distance_bigintset_bigintset(s1, s2));

        public static IntPtr distance_bigintspan_bigintspan(IntPtr s1, IntPtr s2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.distance_bigintspan_bigintspan(s1, s2));

        public static IntPtr distance_bigintspanset_bigintspan(IntPtr ss, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.distance_bigintspanset_bigintspan(ss, s));

        public static IntPtr distance_bigintspanset_bigintspanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.distance_bigintspanset_bigintspanset(ss1, ss2));

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

        public static IntPtr distance_set_bigint(IntPtr s, IntPtr i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.distance_set_bigint(s, i));

        public static int distance_set_date(IntPtr s, int d)
            => SafeExecution<int>(() => MEOSExternalFunctions.distance_set_date(s, d));

        public static double distance_set_float(IntPtr s, double d)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_set_float(s, d));

        public static int distance_set_int(IntPtr s, int i)
            => SafeExecution<int>(() => MEOSExternalFunctions.distance_set_int(s, i));

        public static double distance_set_timestamptz(IntPtr s, long t)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_set_timestamptz(s, t));

        public static IntPtr distance_span_bigint(IntPtr s, IntPtr i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.distance_span_bigint(s, i));

        public static int distance_span_date(IntPtr s, int d)
            => SafeExecution<int>(() => MEOSExternalFunctions.distance_span_date(s, d));

        public static double distance_span_float(IntPtr s, double d)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_span_float(s, d));

        public static int distance_span_int(IntPtr s, int i)
            => SafeExecution<int>(() => MEOSExternalFunctions.distance_span_int(s, i));

        public static double distance_span_timestamptz(IntPtr s, long t)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_span_timestamptz(s, t));

        public static IntPtr distance_spanset_bigint(IntPtr ss, IntPtr i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.distance_spanset_bigint(ss, i));

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

        public static IntPtr bigint_extent_transfn(IntPtr state, IntPtr i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigint_extent_transfn(state, i));

        public static IntPtr bigint_union_transfn(IntPtr state, IntPtr i)
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

        public static IntPtr bigint_get_bin(IntPtr value, IntPtr vsize, IntPtr vorigin)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigint_get_bin(value, vsize, vorigin));

        public static IntPtr[] bigintspan_bins(IntPtr s, IntPtr vsize, IntPtr vorigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintspan_bins(s, vsize, vorigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] bigintspanset_bins(IntPtr ss, IntPtr vsize, IntPtr vorigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintspanset_bins(ss, vsize, vorigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int date_get_bin(int d, IntPtr duration, int torigin)
            => SafeExecution<int>(() => MEOSExternalFunctions.date_get_bin(d, duration, torigin));

        public static IntPtr[] datespan_bins(IntPtr s, IntPtr duration, int torigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.datespan_bins(s, duration, torigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] datespanset_bins(IntPtr ss, IntPtr duration, int torigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.datespanset_bins(ss, duration, torigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static double float_get_bin(double value, double vsize, double vorigin)
            => SafeExecution<double>(() => MEOSExternalFunctions.float_get_bin(value, vsize, vorigin));

        public static IntPtr[] floatspan_bins(IntPtr s, double vsize, double vorigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspan_bins(s, vsize, vorigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] floatspanset_bins(IntPtr ss, double vsize, double vorigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspanset_bins(ss, vsize, vorigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int int_get_bin(int value, int vsize, int vorigin)
            => SafeExecution<int>(() => MEOSExternalFunctions.int_get_bin(value, vsize, vorigin));

        public static IntPtr[] intspan_bins(IntPtr s, int vsize, int vorigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.intspan_bins(s, vsize, vorigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] intspanset_bins(IntPtr ss, int vsize, int vorigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.intspanset_bins(ss, vsize, vorigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static long timestamptz_get_bin(long t, IntPtr duration, long torigin)
            => SafeExecution<long>(() => MEOSExternalFunctions.timestamptz_get_bin(t, duration, torigin));

        public static IntPtr[] tstzspan_bins(IntPtr s, IntPtr duration, long origin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspan_bins(s, duration, origin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] tstzspanset_bins(IntPtr ss, IntPtr duration, long torigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspanset_bins(ss, duration, torigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static string tbox_as_hexwkb(IntPtr box, IntPtr variant, IntPtr size_out)
            => SafeExecution<string>(() => MEOSExternalFunctions.tbox_as_hexwkb(box, variant, size_out));

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

        public static IntPtr bigint_timestamptz_to_tbox(IntPtr i, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigint_timestamptz_to_tbox(i, t));

        public static IntPtr int_tstzspan_to_tbox(int i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.int_tstzspan_to_tbox(i, s));

        public static IntPtr bigint_tstzspan_to_tbox(IntPtr i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigint_tstzspan_to_tbox(i, s));

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

        public static IntPtr bigint_to_tbox(IntPtr i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigint_to_tbox(i));

        public static IntPtr set_to_tbox(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_to_tbox(s));

        public static IntPtr span_to_tbox(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.span_to_tbox(s));

        public static IntPtr spanset_to_tbox(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_to_tbox(ss));

        public static IntPtr tbox_to_intspan(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_to_intspan(box));

        public static IntPtr tbox_to_bigintspan(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_to_bigintspan(box));

        public static IntPtr tbox_to_floatspan(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_to_floatspan(box));

        public static IntPtr tbox_to_tstzspan(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_to_tstzspan(box));

        public static IntPtr timestamptz_to_tbox(long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.timestamptz_to_tbox(t));

        public static int tbox_hash(IntPtr box)
            => SafeExecution<int>(() => MEOSExternalFunctions.tbox_hash(box));

        public static IntPtr tbox_hash_extended(IntPtr box, IntPtr seed)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_hash_extended(box, seed));

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

        public static bool tboxbigint_xmax(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tboxbigint_xmax(box, result));

        public static bool tboxint_xmin(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tboxint_xmin(box, result));

        public static bool tboxbigint_xmin(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tboxbigint_xmin(box, result));

        public static IntPtr tfloatbox_expand(IntPtr box, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloatbox_expand(box, d));

        public static IntPtr tintbox_expand(IntPtr box, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintbox_expand(box, i));

        public static IntPtr tbox_expand_time(IntPtr box, IntPtr interv)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_expand_time(box, interv));

        public static IntPtr tbox_round(IntPtr box, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_round(box, maxdd));

        public static IntPtr tfloatbox_shift_scale(IntPtr box, double shift, double width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloatbox_shift_scale(box, shift, width, hasshift, haswidth));

        public static IntPtr tintbox_shift_scale(IntPtr box, int shift, int width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintbox_shift_scale(box, shift, width, hasshift, haswidth));

        public static IntPtr tbox_shift_scale_time(IntPtr box, IntPtr shift, IntPtr duration)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_shift_scale_time(box, shift, duration));

        public static IntPtr tbigintbox_expand(IntPtr box, IntPtr i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbigintbox_expand(box, i));

        public static IntPtr tbigintbox_shift_scale(IntPtr box, IntPtr shift, IntPtr width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbigintbox_shift_scale(box, shift, width, hasshift, haswidth));

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

        public static IntPtr tbigint_from_mfjson(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbigint_from_mfjson(str));

        public static IntPtr tint_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_in(str));

        public static IntPtr tbigint_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbigint_in(str));

        public static string tint_out(IntPtr temp)
            => SafeExecution<string>(() => MEOSExternalFunctions.tint_out(temp));

        public static string tbigint_out(IntPtr temp)
            => SafeExecution<string>(() => MEOSExternalFunctions.tbigint_out(temp));

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

        public static IntPtr tbigint_from_base_temp(IntPtr i, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbigint_from_base_temp(i, temp));

        public static IntPtr tintinst_make(int i, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintinst_make(i, t));

        public static IntPtr tbigintinst_make(IntPtr i, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbigintinst_make(i, t));

        public static IntPtr tintseq_from_base_tstzset(int i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintseq_from_base_tstzset(i, s));

        public static IntPtr tbigintseq_from_base_tstzset(IntPtr i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbigintseq_from_base_tstzset(i, s));

        public static IntPtr tintseq_from_base_tstzspan(int i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintseq_from_base_tstzspan(i, s));

        public static IntPtr tbigintseq_from_base_tstzspan(IntPtr i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbigintseq_from_base_tstzspan(i, s));

        public static IntPtr tintseqset_from_base_tstzspanset(int i, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintseqset_from_base_tstzspanset(i, ss));

        public static IntPtr tbigintseqset_from_base_tstzspanset(IntPtr i, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbigintseqset_from_base_tstzspanset(i, ss));

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

        public static IntPtr tfloat_to_tbigint(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_to_tbigint(temp));

        public static IntPtr tint_to_tfloat(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_to_tfloat(temp));

        public static IntPtr tint_to_tbigint(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_to_tbigint(temp));

        public static IntPtr tbigint_to_tint(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbigint_to_tint(temp));

        public static IntPtr tbigint_to_tfloat(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbigint_to_tfloat(temp));

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

        public static IntPtr[] tbool_values(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbool_values(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr temporal_duration(IntPtr temp, bool boundspan)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_duration(temp, boundspan));

        public static IntPtr temporal_end_instant(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_end_instant(temp));

        public static IntPtr temporal_end_sequence(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_end_sequence(temp));

        public static long temporal_end_timestamptz(IntPtr temp)
            => SafeExecution<long>(() => MEOSExternalFunctions.temporal_end_timestamptz(temp));

        public static int temporal_hash(IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.temporal_hash(temp));

        public static IntPtr temporal_instant_n(IntPtr temp, int n)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_instant_n(temp, n));

        public static IntPtr[] temporal_instants(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_instants(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

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

        public static IntPtr[] temporal_segments(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_segments(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr temporal_sequence_n(IntPtr temp, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_sequence_n(temp, i));

        public static IntPtr[] temporal_sequences(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_sequences(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

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

        public static string temporal_basetype_name(IntPtr temp)
            => SafeExecution<string>(() => MEOSExternalFunctions.temporal_basetype_name(temp));

        public static IntPtr temporal_time(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_time(temp));

        public static long[] temporal_timestamps(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_timestamps(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                long[] _out = new long[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool temporal_timestamptz_n(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.temporal_timestamptz_n(temp, n, result));

        public static bool temporal_upper_inc(IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.temporal_upper_inc(temp));

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

        public static double[] tfloat_values(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_values(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                double[] _out = new double[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int tint_end_value(IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.tint_end_value(temp));

        public static IntPtr tbigint_end_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbigint_end_value(temp));

        public static int tint_max_value(IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.tint_max_value(temp));

        public static IntPtr tbigint_max_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbigint_max_value(temp));

        public static int tint_min_value(IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.tint_min_value(temp));

        public static IntPtr tbigint_min_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbigint_min_value(temp));

        public static int tint_start_value(IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.tint_start_value(temp));

        public static IntPtr tbigint_start_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbigint_start_value(temp));

        public static bool tbigint_value_at_timestamptz(IntPtr temp, long t, bool strict, IntPtr value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbigint_value_at_timestamptz(temp, t, strict, value));

        public static bool tint_value_at_timestamptz(IntPtr temp, long t, bool strict, IntPtr value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tint_value_at_timestamptz(temp, t, strict, value));

        public static bool tint_value_n(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tint_value_n(temp, n, result));

        public static bool tbigint_value_n(IntPtr temp, IntPtr n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbigint_value_n(temp, n, result));

        public static int[] tint_values(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_values(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                int[] _out = new int[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] tbigint_values(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbigint_values(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

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

        public static IntPtr[] ttext_values(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_values(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

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

        public static IntPtr tbigint_scale_value(IntPtr temp, IntPtr width)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbigint_scale_value(temp, width));

        public static IntPtr tint_shift_scale_value(IntPtr temp, int shift, int width)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_shift_scale_value(temp, shift, width));

        public static IntPtr tbigint_shift_scale_value(IntPtr temp, IntPtr shift, IntPtr width)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbigint_shift_scale_value(temp, shift, width));

        public static IntPtr tint_shift_value(IntPtr temp, int shift)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_shift_value(temp, shift));

        public static IntPtr tbigint_shift_value(IntPtr temp, IntPtr shift)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbigint_shift_value(temp, shift));

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

        public static int always_eq_bigint_tbigint(IntPtr i, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_bigint_tbigint(i, temp));

        public static int always_eq_tbigint_bigint(IntPtr temp, IntPtr i)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_tbigint_bigint(temp, i));

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

        public static int always_ge_bigint_tbigint(IntPtr i, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ge_bigint_tbigint(i, temp));

        public static int always_ge_tbigint_bigint(IntPtr temp, IntPtr i)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ge_tbigint_bigint(temp, i));

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

        public static int always_gt_bigint_tbigint(IntPtr i, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_gt_bigint_tbigint(i, temp));

        public static int always_gt_tbigint_bigint(IntPtr temp, IntPtr i)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_gt_tbigint_bigint(temp, i));

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

        public static int always_le_bigint_tbigint(IntPtr i, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_le_bigint_tbigint(i, temp));

        public static int always_le_tbigint_bigint(IntPtr temp, IntPtr i)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_le_tbigint_bigint(temp, i));

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

        public static int always_lt_bigint_tbigint(IntPtr i, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_lt_bigint_tbigint(i, temp));

        public static int always_lt_tbigint_bigint(IntPtr temp, IntPtr i)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_lt_tbigint_bigint(temp, i));

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

        public static int always_ne_bigint_tbigint(IntPtr i, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_bigint_tbigint(i, temp));

        public static int always_ne_tbigint_bigint(IntPtr temp, IntPtr i)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_tbigint_bigint(temp, i));

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

        public static int ever_eq_bigint_tbigint(IntPtr i, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_bigint_tbigint(i, temp));

        public static int ever_eq_tbigint_bigint(IntPtr temp, IntPtr i)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_tbigint_bigint(temp, i));

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

        public static int ever_ge_bigint_tbigint(IntPtr i, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ge_bigint_tbigint(i, temp));

        public static int ever_ge_tbigint_bigint(IntPtr temp, IntPtr i)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ge_tbigint_bigint(temp, i));

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

        public static int ever_gt_bigint_tbigint(IntPtr i, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_gt_bigint_tbigint(i, temp));

        public static int ever_gt_tbigint_bigint(IntPtr temp, IntPtr i)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_gt_tbigint_bigint(temp, i));

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

        public static int ever_le_bigint_tbigint(IntPtr i, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_le_bigint_tbigint(i, temp));

        public static int ever_le_tbigint_bigint(IntPtr temp, IntPtr i)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_le_tbigint_bigint(temp, i));

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

        public static int ever_lt_bigint_tbigint(IntPtr i, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_lt_bigint_tbigint(i, temp));

        public static int ever_lt_tbigint_bigint(IntPtr temp, IntPtr i)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_lt_tbigint_bigint(temp, i));

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

        public static int ever_ne_bigint_tbigint(IntPtr i, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_bigint_tbigint(i, temp));

        public static int ever_ne_tbigint_bigint(IntPtr temp, IntPtr i)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_tbigint_bigint(temp, i));

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

        public static IntPtr[] temporal_spans(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_spans(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] temporal_split_each_n_spans(IntPtr temp, int elem_count)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_split_each_n_spans(temp, elem_count, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] temporal_split_n_spans(IntPtr temp, int span_count)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_split_n_spans(temp, span_count, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] tnumber_split_each_n_tboxes(IntPtr temp, int elem_count)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_split_each_n_tboxes(temp, elem_count, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] tnumber_split_n_tboxes(IntPtr temp, int box_count)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_split_n_tboxes(temp, box_count, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] tnumber_tboxes(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_tboxes(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

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

        public static IntPtr add_bigint_tbigint(IntPtr i, IntPtr tnumber)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.add_bigint_tbigint(i, tnumber));

        public static IntPtr add_tbigint_bigint(IntPtr tnumber, IntPtr i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.add_tbigint_bigint(tnumber, i));

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

        public static IntPtr div_bigint_tbigint(IntPtr i, IntPtr tnumber)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.div_bigint_tbigint(i, tnumber));

        public static IntPtr div_tbigint_bigint(IntPtr tnumber, IntPtr i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.div_tbigint_bigint(tnumber, i));

        public static IntPtr div_tnumber_tnumber(IntPtr tnumber1, IntPtr tnumber2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.div_tnumber_tnumber(tnumber1, tnumber2));

        public static IntPtr mul_float_tfloat(double d, IntPtr tnumber)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.mul_float_tfloat(d, tnumber));

        public static IntPtr mul_int_tint(int i, IntPtr tnumber)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.mul_int_tint(i, tnumber));

        public static IntPtr mul_tfloat_float(IntPtr tnumber, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.mul_tfloat_float(tnumber, d));

        public static IntPtr mul_tint_int(IntPtr tnumber, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.mul_tint_int(tnumber, i));

        public static IntPtr mul_bigint_tbigint(IntPtr i, IntPtr tnumber)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.mul_bigint_tbigint(i, tnumber));

        public static IntPtr mul_tbigint_bigint(IntPtr tnumber, IntPtr i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.mul_tbigint_bigint(tnumber, i));

        public static IntPtr mul_tnumber_tnumber(IntPtr tnumber1, IntPtr tnumber2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.mul_tnumber_tnumber(tnumber1, tnumber2));

        public static IntPtr sub_float_tfloat(double d, IntPtr tnumber)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.sub_float_tfloat(d, tnumber));

        public static IntPtr sub_int_tint(int i, IntPtr tnumber)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.sub_int_tint(i, tnumber));

        public static IntPtr sub_tfloat_float(IntPtr tnumber, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.sub_tfloat_float(tnumber, d));

        public static IntPtr sub_tint_int(IntPtr tnumber, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.sub_tint_int(tnumber, i));

        public static IntPtr sub_bigint_tbigint(IntPtr i, IntPtr tnumber)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.sub_bigint_tbigint(i, tnumber));

        public static IntPtr sub_tbigint_bigint(IntPtr tnumber, IntPtr i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.sub_tbigint_bigint(tnumber, i));

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

        public static IntPtr tfloat_sin(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_sin(temp));

        public static IntPtr tfloat_cos(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_cos(temp));

        public static IntPtr tfloat_tan(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_tan(temp));

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

        public static IntPtr tbool_tand_combinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbool_tand_combinefn(state1, state2));

        public static IntPtr tbool_tor_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbool_tor_transfn(state, temp));

        public static IntPtr tbool_tor_combinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbool_tor_combinefn(state1, state2));

        public static IntPtr temporal_extent_transfn(IntPtr s, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_extent_transfn(s, temp));

        public static IntPtr temporal_tagg_finalfn(IntPtr state)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_tagg_finalfn(state));

        public static IntPtr temporal_tcount_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_tcount_transfn(state, temp));

        public static IntPtr temporal_tcount_combinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_tcount_combinefn(state1, state2));

        public static IntPtr tfloat_tmax_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_tmax_transfn(state, temp));

        public static IntPtr tfloat_tmax_combinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_tmax_combinefn(state1, state2));

        public static IntPtr tfloat_tmin_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_tmin_transfn(state, temp));

        public static IntPtr tfloat_tmin_combinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_tmin_combinefn(state1, state2));

        public static IntPtr tfloat_tsum_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_tsum_transfn(state, temp));

        public static IntPtr tfloat_tsum_combinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_tsum_combinefn(state1, state2));

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

        public static IntPtr tint_tmax_combinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_tmax_combinefn(state1, state2));

        public static IntPtr tint_tmin_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_tmin_transfn(state, temp));

        public static IntPtr tint_tmin_combinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_tmin_combinefn(state1, state2));

        public static IntPtr tint_tsum_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_tsum_transfn(state, temp));

        public static IntPtr tint_tsum_combinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_tsum_combinefn(state1, state2));

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

        public static IntPtr tnumber_tavg_combinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_tavg_combinefn(state1, state2));

        public static IntPtr tnumber_wavg_transfn(IntPtr state, IntPtr temp, IntPtr interv)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_wavg_transfn(state, temp, interv));

        public static IntPtr tstzset_tcount_transfn(IntPtr state, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzset_tcount_transfn(state, s));

        public static IntPtr tstzspan_tcount_transfn(IntPtr state, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspan_tcount_transfn(state, s));

        public static IntPtr tstzspanset_tcount_transfn(IntPtr state, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspanset_tcount_transfn(state, ss));

        public static IntPtr temporal_merge_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_merge_transfn(state, temp));

        public static IntPtr temporal_merge_combinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_merge_combinefn(state1, state2));

        public static IntPtr ttext_tmax_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_tmax_transfn(state, temp));

        public static IntPtr ttext_tmax_combinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_tmax_combinefn(state1, state2));

        public static IntPtr ttext_tmin_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_tmin_transfn(state, temp));

        public static IntPtr ttext_tmin_combinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_tmin_combinefn(state1, state2));

        public static IntPtr temporal_simplify_dp(IntPtr temp, double dist, bool synchronized)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_simplify_dp(temp, dist, synchronized));

        public static IntPtr temporal_simplify_max_dist(IntPtr temp, double dist, bool synchronized)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_simplify_max_dist(temp, dist, synchronized));

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

        public static IntPtr[] temporal_dyntimewarp_path(IntPtr temp1, IntPtr temp2)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_dyntimewarp_path(temp1, temp2, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static double temporal_frechet_distance(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => MEOSExternalFunctions.temporal_frechet_distance(temp1, temp2));

        public static IntPtr[] temporal_frechet_path(IntPtr temp1, IntPtr temp2)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_frechet_path(temp1, temp2, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static double temporal_hausdorff_distance(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => MEOSExternalFunctions.temporal_hausdorff_distance(temp1, temp2));

        public static double temporal_average_hausdorff_distance(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => MEOSExternalFunctions.temporal_average_hausdorff_distance(temp1, temp2));

        public static double temporal_lcss_distance(IntPtr temp1, IntPtr temp2, double epsilon)
            => SafeExecution<double>(() => MEOSExternalFunctions.temporal_lcss_distance(temp1, temp2, epsilon));

        public static IntPtr temporal_ext_kalman_filter(IntPtr temp, double gate, double q, double variance, bool to_drop)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_ext_kalman_filter(temp, gate, q, variance, to_drop));

        public static IntPtr[] temporal_time_bins(IntPtr temp, IntPtr duration, long origin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_time_bins(temp, duration, origin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static (IntPtr[], long[]) temporal_time_split(IntPtr temp, IntPtr duration, long torigin)
        {
            IntPtr _out_bins = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_time_split(temp, duration, torigin, _out_bins, _count_count));
                int _n = Marshal.ReadInt32(_count_count);
                IntPtr[] _resultArr = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _resultArr[_i] = Marshal.ReadIntPtr(_resultPtr, _i * IntPtr.Size); }
                IntPtr __out_bins_arr = Marshal.ReadIntPtr(_out_bins);
                long[] __out_bins_out = new long[_n];
                Marshal.Copy(__out_bins_arr, __out_bins_out, 0, _n);
                return (_resultArr, __out_bins_out);
            }
            finally
            {
            Marshal.FreeHGlobal(_out_bins);
            Marshal.FreeHGlobal(_count_count);
            }
        }

        public static IntPtr[] tfloat_time_boxes(IntPtr temp, IntPtr duration, long torigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_time_boxes(temp, duration, torigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] tfloat_value_bins(IntPtr temp, double vsize, double vorigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_value_bins(temp, vsize, vorigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] tfloat_value_boxes(IntPtr temp, double vsize, double vorigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_value_boxes(temp, vsize, vorigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

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

        public static IntPtr[] tfloat_value_time_boxes(IntPtr temp, double vsize, IntPtr duration, double vorigin, long torigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_value_time_boxes(temp, vsize, duration, vorigin, torigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

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

        public static IntPtr[] tfloatbox_time_tiles(IntPtr box, IntPtr duration, long torigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloatbox_time_tiles(box, duration, torigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] tfloatbox_value_tiles(IntPtr box, double vsize, double vorigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloatbox_value_tiles(box, vsize, vorigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] tfloatbox_value_time_tiles(IntPtr box, double vsize, IntPtr duration, double vorigin, long torigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloatbox_value_time_tiles(box, vsize, duration, vorigin, torigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] tint_time_boxes(IntPtr temp, IntPtr duration, long torigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_time_boxes(temp, duration, torigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] tint_value_bins(IntPtr temp, int vsize, int vorigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_value_bins(temp, vsize, vorigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] tint_value_boxes(IntPtr temp, int vsize, int vorigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_value_boxes(temp, vsize, vorigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

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

        public static IntPtr[] tint_value_time_boxes(IntPtr temp, int vsize, IntPtr duration, int vorigin, long torigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_value_time_boxes(temp, vsize, duration, vorigin, torigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

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

        public static IntPtr[] tintbox_time_tiles(IntPtr box, IntPtr duration, long torigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintbox_time_tiles(box, duration, torigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] tintbox_value_tiles(IntPtr box, int xsize, int xorigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintbox_value_tiles(box, xsize, xorigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] tintbox_value_time_tiles(IntPtr box, int xsize, IntPtr duration, int xorigin, long torigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintbox_value_time_tiles(box, xsize, duration, xorigin, torigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr box3d_from_gbox(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.box3d_from_gbox(box));

        public static IntPtr box3d_make(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.box3d_make(xmin, xmax, ymin, ymax, zmin, zmax, srid));

        public static IntPtr box3d_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.box3d_in(str));

        public static string box3d_out(IntPtr box, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.box3d_out(box, maxdd));

        public static IntPtr gbox_make(bool hasz, bool hasm, bool geodetic, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, double mmin, double mmax)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.gbox_make(hasz, hasm, geodetic, xmin, xmax, ymin, ymax, zmin, zmax, mmin, mmax));

        public static IntPtr gbox_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.gbox_in(str));

        public static string gbox_out(IntPtr box, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.gbox_out(box, maxdd));

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

        public static IntPtr geog_from_hexewkb(string wkt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geog_from_hexewkb(wkt));

        public static IntPtr geog_in(string str, int typmod)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geog_in(str, typmod));

        public static IntPtr geom_from_hexewkb(string wkt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geom_from_hexewkb(wkt));

        public static IntPtr geom_in(string str, int typmod)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geom_in(str, typmod));

        public static IntPtr geo_copy(IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_copy(gs));

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

        public static bool geo_is_empty(IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geo_is_empty(gs));

        public static bool geo_is_unitary(IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geo_is_unitary(gs));

        public static string geo_typename(int type)
            => SafeExecution<string>(() => MEOSExternalFunctions.geo_typename(type));

        public static double geog_area(IntPtr gs, bool use_spheroid)
            => SafeExecution<double>(() => MEOSExternalFunctions.geog_area(gs, use_spheroid));

        public static IntPtr geog_centroid(IntPtr gs, bool use_spheroid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geog_centroid(gs, use_spheroid));

        public static double geog_length(IntPtr gs, bool use_spheroid)
            => SafeExecution<double>(() => MEOSExternalFunctions.geog_length(gs, use_spheroid));

        public static double geog_perimeter(IntPtr gs, bool use_spheroid)
            => SafeExecution<double>(() => MEOSExternalFunctions.geog_perimeter(gs, use_spheroid));

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

        public static IntPtr[] geo_pointarr(IntPtr gs)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_pointarr(gs, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

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

        public static IntPtr geom_shortestline2d(IntPtr gs1, IntPtr gs2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geom_shortestline2d(gs1, gs2));

        public static IntPtr geom_shortestline3d(IntPtr gs1, IntPtr gs2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geom_shortestline3d(gs1, gs2));

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

        public static bool geom_dwithin(IntPtr gs1, IntPtr gs2, double tolerance)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geom_dwithin(gs1, gs2, tolerance));

        public static bool geom_dwithin2d(IntPtr gs1, IntPtr gs2, double tolerance)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geom_dwithin2d(gs1, gs2, tolerance));

        public static bool geom_dwithin3d(IntPtr gs1, IntPtr gs2, double tolerance)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geom_dwithin3d(gs1, gs2, tolerance));

        public static bool geom_intersects(IntPtr gs1, IntPtr gs2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geom_intersects(gs1, gs2));

        public static bool geom_intersects2d(IntPtr gs1, IntPtr gs2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geom_intersects2d(gs1, gs2));

        public static bool geom_intersects3d(IntPtr gs1, IntPtr gs2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geom_intersects3d(gs1, gs2));

        public static bool geom_relate_pattern(IntPtr gs1, IntPtr gs2, string patt)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geom_relate_pattern(gs1, gs2, patt));

        public static bool geom_touches(IntPtr gs1, IntPtr gs2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geom_touches(gs1, gs2));

        public static IntPtr[] geo_stboxes(IntPtr gs)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_stboxes(gs, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] geo_split_each_n_stboxes(IntPtr gs, int elem_count)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_split_each_n_stboxes(gs, elem_count, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] geo_split_n_stboxes(IntPtr gs, int box_count)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_split_n_stboxes(gs, box_count, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

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

        public static string spatialset_out(IntPtr s, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.spatialset_out(s, maxdd));

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
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.geoset_values(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
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

        public static string stbox_as_hexwkb(IntPtr box, IntPtr variant, IntPtr size_out)
            => SafeExecution<string>(() => MEOSExternalFunctions.stbox_as_hexwkb(box, variant, size_out));

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

        public static int stbox_hash(IntPtr box)
            => SafeExecution<int>(() => MEOSExternalFunctions.stbox_hash(box));

        public static IntPtr stbox_hash_extended(IntPtr box, IntPtr seed)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_hash_extended(box, seed));

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

        public static IntPtr[] stbox_quad_split(IntPtr box)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_quad_split(box, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

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

        public static string tspatial_out(IntPtr temp, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.tspatial_out(temp, maxdd));

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

        public static IntPtr tpoint_as_mvtgeom(IntPtr temp, IntPtr bounds, int extent, int buffer, bool clip_geom)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_as_mvtgeom(temp, bounds, extent, buffer, clip_geom));

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

        public static bool tgeo_value_at_timestamptz(IntPtr temp, long t, bool strict, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tgeo_value_at_timestamptz(temp, t, strict, result));

        public static bool tgeo_value_n(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tgeo_value_n(temp, n, result));

        public static IntPtr[] tgeo_values(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_values(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

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

        public static IntPtr[] tpoint_make_simple(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_make_simple(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

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

        public static IntPtr[] tgeo_stboxes(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_stboxes(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] tgeo_space_boxes(IntPtr temp, double xsize, double ysize, double zsize, IntPtr sorigin, bool bitmatrix, bool border_inc)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_space_boxes(temp, xsize, ysize, zsize, sorigin, bitmatrix, border_inc, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] tgeo_space_time_boxes(IntPtr temp, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, long torigin, bool bitmatrix, bool border_inc)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_space_time_boxes(temp, xsize, ysize, zsize, duration, sorigin, torigin, bitmatrix, border_inc, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] tgeo_split_each_n_stboxes(IntPtr temp, int elem_count)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_split_each_n_stboxes(temp, elem_count, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] tgeo_split_n_stboxes(IntPtr temp, int box_count)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_split_n_stboxes(temp, box_count, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

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

        public static int acovers_geo_tgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.acovers_geo_tgeo(gs, temp));

        public static int acovers_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.acovers_tgeo_geo(temp, gs));

        public static int acovers_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.acovers_tgeo_tgeo(temp1, temp2));

        public static int adisjoint_geo_tgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.adisjoint_geo_tgeo(gs, temp));

        public static int adisjoint_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.adisjoint_tgeo_geo(temp, gs));

        public static int adisjoint_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.adisjoint_tgeo_tgeo(temp1, temp2));

        public static int adwithin_geo_tgeo(IntPtr gs, IntPtr temp, double dist)
            => SafeExecution<int>(() => MEOSExternalFunctions.adwithin_geo_tgeo(gs, temp, dist));

        public static int adwithin_tgeo_geo(IntPtr temp, IntPtr gs, double dist)
            => SafeExecution<int>(() => MEOSExternalFunctions.adwithin_tgeo_geo(temp, gs, dist));

        public static int adwithin_tgeo_tgeo(IntPtr temp1, IntPtr temp2, double dist)
            => SafeExecution<int>(() => MEOSExternalFunctions.adwithin_tgeo_tgeo(temp1, temp2, dist));

        public static int aintersects_geo_tgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.aintersects_geo_tgeo(gs, temp));

        public static int aintersects_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.aintersects_tgeo_geo(temp, gs));

        public static int aintersects_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.aintersects_tgeo_tgeo(temp1, temp2));

        public static int atouches_geo_tgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.atouches_geo_tgeo(gs, temp));

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

        public static int edisjoint_geo_tgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.edisjoint_geo_tgeo(gs, temp));

        public static int edisjoint_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.edisjoint_tgeo_geo(temp, gs));

        public static int edisjoint_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.edisjoint_tgeo_tgeo(temp1, temp2));

        public static int edwithin_geo_tgeo(IntPtr gs, IntPtr temp, double dist)
            => SafeExecution<int>(() => MEOSExternalFunctions.edwithin_geo_tgeo(gs, temp, dist));

        public static int edwithin_tgeo_geo(IntPtr temp, IntPtr gs, double dist)
            => SafeExecution<int>(() => MEOSExternalFunctions.edwithin_tgeo_geo(temp, gs, dist));

        public static int edwithin_tgeo_tgeo(IntPtr temp1, IntPtr temp2, double dist)
            => SafeExecution<int>(() => MEOSExternalFunctions.edwithin_tgeo_tgeo(temp1, temp2, dist));

        public static int eintersects_geo_tgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.eintersects_geo_tgeo(gs, temp));

        public static int eintersects_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.eintersects_tgeo_geo(temp, gs));

        public static int eintersects_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.eintersects_tgeo_tgeo(temp1, temp2));

        public static int etouches_geo_tgeo(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.etouches_geo_tgeo(gs, temp));

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

        public static int[] edwithin_tgeoarr_tgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2, double dist)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.edwithin_tgeoarr_tgeoarr(arr1, count1, arr2, count2, dist, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                int[] _out = new int[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int[] adwithin_tgeoarr_tgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2, double dist)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.adwithin_tgeoarr_tgeoarr(arr1, count1, arr2, count2, dist, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                int[] _out = new int[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int[] eintersects_tgeoarr_tgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.eintersects_tgeoarr_tgeoarr(arr1, count1, arr2, count2, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                int[] _out = new int[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int[] aintersects_tgeoarr_tgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.aintersects_tgeoarr_tgeoarr(arr1, count1, arr2, count2, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                int[] _out = new int[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int[] etouches_tgeoarr_tgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.etouches_tgeoarr_tgeoarr(arr1, count1, arr2, count2, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                int[] _out = new int[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int[] atouches_tgeoarr_tgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.atouches_tgeoarr_tgeoarr(arr1, count1, arr2, count2, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                int[] _out = new int[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int[] edisjoint_tgeoarr_tgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.edisjoint_tgeoarr_tgeoarr(arr1, count1, arr2, count2, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                int[] _out = new int[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int[] adisjoint_tgeoarr_tgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.adisjoint_tgeoarr_tgeoarr(arr1, count1, arr2, count2, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                int[] _out = new int[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static (int[], IntPtr[]) tdwithin_tgeoarr_tgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2, double dist)
        {
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            IntPtr _out_periods = Marshal.AllocHGlobal(IntPtr.Size);
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdwithin_tgeoarr_tgeoarr(arr1, count1, arr2, count2, dist, _count_count, _out_periods));
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

        public static (int[], IntPtr[]) tintersects_tgeoarr_tgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2)
        {
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            IntPtr _out_periods = Marshal.AllocHGlobal(IntPtr.Size);
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintersects_tgeoarr_tgeoarr(arr1, count1, arr2, count2, _count_count, _out_periods));
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

        public static (int[], IntPtr[]) ttouches_tgeoarr_tgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2)
        {
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            IntPtr _out_periods = Marshal.AllocHGlobal(IntPtr.Size);
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttouches_tgeoarr_tgeoarr(arr1, count1, arr2, count2, _count_count, _out_periods));
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

        public static (int[], IntPtr[]) tdisjoint_tgeoarr_tgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2)
        {
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            IntPtr _out_periods = Marshal.AllocHGlobal(IntPtr.Size);
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdisjoint_tgeoarr_tgeoarr(arr1, count1, arr2, count2, _count_count, _out_periods));
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

        public static IntPtr tdistance_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdistance_tgeo_geo(temp, gs));

        public static IntPtr tdistance_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdistance_tgeo_tgeo(temp1, temp2));

        public static double nad_stbox_geo(IntPtr box, IntPtr gs)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_stbox_geo(box, gs));

        public static double nad_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_stbox_stbox(box1, box2));

        public static double stbox_spatial_distance(IntPtr box1, IntPtr box2)
            => SafeExecution<double>(() => MEOSExternalFunctions.stbox_spatial_distance(box1, box2));

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

        public static double mindistance_tgeo_tgeo(IntPtr temp1, IntPtr temp2, double threshold)
            => SafeExecution<double>(() => MEOSExternalFunctions.mindistance_tgeo_tgeo(temp1, temp2, threshold));

        public static double mindistance_tgeoarr_tgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2)
            => SafeExecution<double>(() => MEOSExternalFunctions.mindistance_tgeoarr_tgeoarr(arr1, count1, arr2, count2));

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

        public static IntPtr[] stbox_space_tiles(IntPtr bounds, double xsize, double ysize, double zsize, IntPtr sorigin, bool border_inc)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_space_tiles(bounds, xsize, ysize, zsize, sorigin, border_inc, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] stbox_space_time_tiles(IntPtr bounds, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, long torigin, bool border_inc)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_space_time_tiles(bounds, xsize, ysize, zsize, duration, sorigin, torigin, border_inc, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] stbox_time_tiles(IntPtr bounds, IntPtr duration, long torigin, bool border_inc)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_time_tiles(bounds, duration, torigin, border_inc, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr tgeo_space_split(IntPtr temp, double xsize, double ysize, double zsize, IntPtr sorigin, bool bitmatrix, bool border_inc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_space_split(temp, xsize, ysize, zsize, sorigin, bitmatrix, border_inc));

        public static IntPtr tgeo_space_time_split(IntPtr temp, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, long torigin, bool bitmatrix, bool border_inc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_space_time_split(temp, xsize, ysize, zsize, duration, sorigin, torigin, bitmatrix, border_inc));

        public static int[] geo_cluster_kmeans(IntPtr geoms, uint ngeoms, uint k)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_cluster_kmeans(geoms, ngeoms, k, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                int[] _out = new int[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] geo_cluster_dbscan(IntPtr geoms, uint ngeoms, double tolerance, int minpoints)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_cluster_dbscan(geoms, ngeoms, tolerance, minpoints, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] geo_cluster_intersecting(IntPtr geoms, uint ngeoms)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_cluster_intersecting(geoms, ngeoms, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] geo_cluster_within(IntPtr geoms, uint ngeoms, double tolerance)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_cluster_within(geoms, ngeoms, tolerance, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static string cbuffer_as_ewkt(IntPtr cb, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.cbuffer_as_ewkt(cb, maxdd));

        public static string cbuffer_as_hexwkb(IntPtr cb, IntPtr variant, IntPtr size_out)
            => SafeExecution<string>(() => MEOSExternalFunctions.cbuffer_as_hexwkb(cb, variant, size_out));

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

        public static int cbuffer_hash(IntPtr cb)
            => SafeExecution<int>(() => MEOSExternalFunctions.cbuffer_hash(cb));

        public static IntPtr cbuffer_hash_extended(IntPtr cb, IntPtr seed)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbuffer_hash_extended(cb, seed));

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
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbufferset_values(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
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

        public static IntPtr tcbuffer_from_mfjson(string mfjson)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffer_from_mfjson(mfjson));

        public static IntPtr tcbufferinst_make(IntPtr cb, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbufferinst_make(cb, t));

        public static IntPtr tcbuffer_make(IntPtr tpoint, IntPtr tfloat)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffer_make(tpoint, tfloat));

        public static IntPtr tcbuffer_from_base_temp(IntPtr cb, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffer_from_base_temp(cb, temp));

        public static IntPtr tcbufferseq_from_base_tstzset(IntPtr cb, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbufferseq_from_base_tstzset(cb, s));

        public static IntPtr tcbufferseq_from_base_tstzspan(IntPtr cb, IntPtr s, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbufferseq_from_base_tstzspan(cb, s, interp));

        public static IntPtr tcbufferseqset_from_base_tstzspanset(IntPtr cb, IntPtr ss, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbufferseqset_from_base_tstzspanset(cb, ss, interp));

        public static IntPtr tcbuffer_end_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffer_end_value(temp));

        public static IntPtr tcbuffer_points(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffer_points(temp));

        public static IntPtr tcbuffer_radius(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffer_radius(temp));

        public static IntPtr tcbuffer_traversed_area(IntPtr temp, bool unary_union)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffer_traversed_area(temp, unary_union));

        public static IntPtr tcbuffer_convex_hull(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffer_convex_hull(temp));

        public static IntPtr tcbuffer_start_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffer_start_value(temp));

        public static bool tcbuffer_value_at_timestamptz(IntPtr temp, long t, bool strict, IntPtr value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tcbuffer_value_at_timestamptz(temp, t, strict, value));

        public static bool tcbuffer_value_n(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tcbuffer_value_n(temp, n, result));

        public static IntPtr[] tcbuffer_values(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffer_values(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

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

        public static double mindistance_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2, double threshold)
            => SafeExecution<double>(() => MEOSExternalFunctions.mindistance_tcbuffer_tcbuffer(temp1, temp2, threshold));

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

        public static int acovers_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.acovers_tcbuffer_tcbuffer(temp1, temp2));

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

        public static int ecovers_geo_tcbuffer(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ecovers_geo_tcbuffer(gs, temp));

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

        public static bool ensure_valid_cbuffer_cbuffer(IntPtr cb1, IntPtr cb2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_cbuffer_cbuffer(cb1, cb2));

        public static bool ensure_valid_cbuffer_geo(IntPtr cb, IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_cbuffer_geo(cb, gs));

        public static bool ensure_valid_cbuffer_stbox(IntPtr cb, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_cbuffer_stbox(cb, box));

        public static bool ensure_valid_cbufferset_cbuffer(IntPtr s, IntPtr cb)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_cbufferset_cbuffer(s, cb));

        public static bool cbuffer_collinear(IntPtr cb1, IntPtr cb2, IntPtr cbuf3, double ratio)
            => SafeExecution<bool>(() => MEOSExternalFunctions.cbuffer_collinear(cb1, cb2, cbuf3, ratio));

        public static IntPtr cbuffersegm_interpolate(IntPtr start, IntPtr end, IntPtr ratio)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbuffersegm_interpolate(start, end, ratio));

        public static IntPtr cbuffersegm_locate(IntPtr start, IntPtr end, IntPtr value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbuffersegm_locate(start, end, value));

        public static IntPtr cbuffer_parse(IntPtr str, bool end)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbuffer_parse(str, end));

        public static string cbuffer_wkt_out(long value, int maxdd, bool extended)
            => SafeExecution<string>(() => MEOSExternalFunctions.cbuffer_wkt_out(value, maxdd, extended));

        public static IntPtr cbuffer_point_p(IntPtr cb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbuffer_point_p(cb));

        public static long datum_cbuffer_round(long buffer, long size)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_cbuffer_round(buffer, size));

        public static IntPtr cbuffer_transf_pj(IntPtr cb, int srid_to, IntPtr pj)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cbuffer_transf_pj(cb, srid_to, pj));

        public static double cbuffer_distance(IntPtr cb1, IntPtr cb2)
            => SafeExecution<double>(() => MEOSExternalFunctions.cbuffer_distance(cb1, cb2));

        public static long datum_cbuffer_distance(long cb1, long cb2)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_cbuffer_distance(cb1, cb2));

        public static int cbuffersegm_distance_turnpt(IntPtr start1, IntPtr end1, IntPtr start2, IntPtr end2, long lower, long upper, IntPtr t1, IntPtr t2)
            => SafeExecution<int>(() => MEOSExternalFunctions.cbuffersegm_distance_turnpt(start1, end1, start2, end2, lower, upper, t1, t2));

        public static int cbuffer_contains(IntPtr cb1, IntPtr cb2)
            => SafeExecution<int>(() => MEOSExternalFunctions.cbuffer_contains(cb1, cb2));

        public static int cbuffer_covers(IntPtr cb1, IntPtr cb2)
            => SafeExecution<int>(() => MEOSExternalFunctions.cbuffer_covers(cb1, cb2));

        public static int cbuffer_disjoint(IntPtr cb1, IntPtr cb2)
            => SafeExecution<int>(() => MEOSExternalFunctions.cbuffer_disjoint(cb1, cb2));

        public static int cbuffer_intersects(IntPtr cb1, IntPtr cb2)
            => SafeExecution<int>(() => MEOSExternalFunctions.cbuffer_intersects(cb1, cb2));

        public static int cbuffer_dwithin(IntPtr cb1, IntPtr cb2, double dist)
            => SafeExecution<int>(() => MEOSExternalFunctions.cbuffer_dwithin(cb1, cb2, dist));

        public static int cbuffer_touches(IntPtr cb1, IntPtr cb2)
            => SafeExecution<int>(() => MEOSExternalFunctions.cbuffer_touches(cb1, cb2));

        public static long datum_cbuffer_contains(long cb1, long cb2)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_cbuffer_contains(cb1, cb2));

        public static long datum_cbuffer_covers(long cb1, long cb2)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_cbuffer_covers(cb1, cb2));

        public static long datum_cbuffer_disjoint(long cb1, long cb2)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_cbuffer_disjoint(cb1, cb2));

        public static long datum_cbuffer_intersects(long cb1, long cb2)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_cbuffer_intersects(cb1, cb2));

        public static long datum_cbuffer_dwithin(long cb1, long cb2, long dist)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_cbuffer_dwithin(cb1, cb2, dist));

        public static long datum_cbuffer_touches(long cb1, long cb2)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_cbuffer_touches(cb1, cb2));

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

        public static int meos_typeof_hexwkb(string hexwkb)
            => SafeExecution<int>(() => MEOSExternalFunctions.meos_typeof_hexwkb(hexwkb));

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

        public static IntPtr gsl_get_generation_rng()
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.gsl_get_generation_rng());

        public static IntPtr gsl_get_aggregation_rng()
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.gsl_get_aggregation_rng());

        public static long datum_ceil(long d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_ceil(d));

        public static long datum_degrees(long d, long normalize)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_degrees(d, normalize));

        public static long datum_float_round(long value, long size)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_float_round(value, size));

        public static long datum_floor(long d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_floor(d));

        public static int datum_hash(long d, int basetype)
            => SafeExecution<int>(() => MEOSExternalFunctions.datum_hash(d, basetype));

        public static IntPtr datum_hash_extended(long d, int basetype, IntPtr seed)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.datum_hash_extended(d, basetype, seed));

        public static long datum_radians(long d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_radians(d));

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

        public static IntPtr span_make(long lower, long upper, bool lower_inc, bool upper_inc, int basetype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.span_make(lower, upper, lower_inc, upper_inc, basetype));

        public static void span_set(long lower, long upper, bool lower_inc, bool upper_inc, int basetype, int spantype, IntPtr s)
            => SafeExecution(() => MEOSExternalFunctions.span_set(lower, upper, lower_inc, upper_inc, basetype, spantype, s));

        public static IntPtr spanset_make_exp(IntPtr spans, int count, int maxcount, bool normalize, bool order)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_make_exp(spans, count, maxcount, normalize, order));

        public static IntPtr spanset_make_free(IntPtr spans, int count, bool normalize, bool order)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_make_free(spans, count, normalize, order));

        public static IntPtr set_span(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_span(s));

        public static IntPtr set_spanset(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_spanset(s));

        public static void value_set_span(long value, int basetype, IntPtr s)
            => SafeExecution(() => MEOSExternalFunctions.value_set_span(value, basetype, s));

        public static IntPtr value_set(long d, int basetype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.value_set(d, basetype));

        public static IntPtr value_span(long d, int basetype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.value_span(d, basetype));

        public static IntPtr value_spanset(long d, int basetype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.value_spanset(d, basetype));

        public static long numspan_width(IntPtr s)
            => SafeExecution<long>(() => MEOSExternalFunctions.numspan_width(s));

        public static long numspanset_width(IntPtr ss, bool boundspan)
            => SafeExecution<long>(() => MEOSExternalFunctions.numspanset_width(ss, boundspan));

        public static long set_end_value(IntPtr s)
            => SafeExecution<long>(() => MEOSExternalFunctions.set_end_value(s));

        public static int set_mem_size(IntPtr s)
            => SafeExecution<int>(() => MEOSExternalFunctions.set_mem_size(s));

        public static void set_set_subspan(IntPtr s, int minidx, int maxidx, IntPtr result)
            => SafeExecution(() => MEOSExternalFunctions.set_set_subspan(s, minidx, maxidx, result));

        public static void set_set_span(IntPtr s, IntPtr result)
            => SafeExecution(() => MEOSExternalFunctions.set_set_span(s, result));

        public static long set_start_value(IntPtr s)
            => SafeExecution<long>(() => MEOSExternalFunctions.set_start_value(s));

        public static bool set_value_n(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.set_value_n(s, n, result));

        public static IntPtr set_vals(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_vals(s));

        public static long[] set_values(IntPtr s)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_values(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                long[] _out = new long[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static long spanset_lower(IntPtr ss)
            => SafeExecution<long>(() => MEOSExternalFunctions.spanset_lower(ss));

        public static int spanset_mem_size(IntPtr ss)
            => SafeExecution<int>(() => MEOSExternalFunctions.spanset_mem_size(ss));

        public static IntPtr[] spanset_sps(IntPtr ss)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_sps(ss, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static long spanset_upper(IntPtr ss)
            => SafeExecution<long>(() => MEOSExternalFunctions.spanset_upper(ss));

        public static void datespan_set_tstzspan(IntPtr s1, IntPtr s2)
            => SafeExecution(() => MEOSExternalFunctions.datespan_set_tstzspan(s1, s2));

        public static void bigintspan_set_floatspan(IntPtr s1, IntPtr s2)
            => SafeExecution(() => MEOSExternalFunctions.bigintspan_set_floatspan(s1, s2));

        public static void bigintspan_set_intspan(IntPtr s1, IntPtr s2)
            => SafeExecution(() => MEOSExternalFunctions.bigintspan_set_intspan(s1, s2));

        public static void floatspan_set_bigintspan(IntPtr s1, IntPtr s2)
            => SafeExecution(() => MEOSExternalFunctions.floatspan_set_bigintspan(s1, s2));

        public static void floatspan_set_intspan(IntPtr s1, IntPtr s2)
            => SafeExecution(() => MEOSExternalFunctions.floatspan_set_intspan(s1, s2));

        public static void intspan_set_bigintspan(IntPtr s1, IntPtr s2)
            => SafeExecution(() => MEOSExternalFunctions.intspan_set_bigintspan(s1, s2));

        public static void intspan_set_floatspan(IntPtr s1, IntPtr s2)
            => SafeExecution(() => MEOSExternalFunctions.intspan_set_floatspan(s1, s2));

        public static IntPtr numset_shift_scale(IntPtr s, long shift, long width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.numset_shift_scale(s, shift, width, hasshift, haswidth));

        public static IntPtr numspan_expand(IntPtr s, long value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.numspan_expand(s, value));

        public static IntPtr numspan_shift_scale(IntPtr s, long shift, long width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.numspan_shift_scale(s, shift, width, hasshift, haswidth));

        public static IntPtr numspanset_shift_scale(IntPtr ss, long shift, long width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.numspanset_shift_scale(ss, shift, width, hasshift, haswidth));

        public static IntPtr set_compact(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_compact(s));

        public static void span_expand(IntPtr s1, IntPtr s2)
            => SafeExecution(() => MEOSExternalFunctions.span_expand(s1, s2));

        public static IntPtr spanset_compact(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_compact(ss));

        public static IntPtr tbox_expand_value(IntPtr box, long value, int basetyp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_expand_value(box, value, basetyp));

        public static IntPtr textcat_textset_text_common(IntPtr s, IntPtr txt, bool invert)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.textcat_textset_text_common(s, txt, invert));

        public static void tstzspan_set_datespan(IntPtr s1, IntPtr s2)
            => SafeExecution(() => MEOSExternalFunctions.tstzspan_set_datespan(s1, s2));

        public static bool adjacent_span_value(IntPtr s, long value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_span_value(s, value));

        public static bool adjacent_spanset_value(IntPtr ss, long value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_spanset_value(ss, value));

        public static bool adjacent_value_spanset(long value, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_value_spanset(value, ss));

        public static bool contained_value_set(long value, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_value_set(value, s));

        public static bool contained_value_span(long value, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_value_span(value, s));

        public static bool contained_value_spanset(long value, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_value_spanset(value, ss));

        public static bool contains_set_value(IntPtr s, long value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_set_value(s, value));

        public static bool contains_span_value(IntPtr s, long value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_span_value(s, value));

        public static bool contains_spanset_value(IntPtr ss, long value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_spanset_value(ss, value));

        public static bool ovadj_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ovadj_span_span(s1, s2));

        public static bool left_set_value(IntPtr s, long value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_set_value(s, value));

        public static bool left_span_value(IntPtr s, long value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_span_value(s, value));

        public static bool left_spanset_value(IntPtr ss, long value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_spanset_value(ss, value));

        public static bool left_value_set(long value, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_value_set(value, s));

        public static bool left_value_span(long value, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_value_span(value, s));

        public static bool left_value_spanset(long value, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_value_spanset(value, ss));

        public static bool lfnadj_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.lfnadj_span_span(s1, s2));

        public static bool overleft_set_value(IntPtr s, long value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_set_value(s, value));

        public static bool overleft_span_value(IntPtr s, long value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_span_value(s, value));

        public static bool overleft_spanset_value(IntPtr ss, long value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_spanset_value(ss, value));

        public static bool overleft_value_set(long value, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_value_set(value, s));

        public static bool overleft_value_span(long value, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_value_span(value, s));

        public static bool overleft_value_spanset(long value, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_value_spanset(value, ss));

        public static bool overright_set_value(IntPtr s, long value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_set_value(s, value));

        public static bool overright_span_value(IntPtr s, long value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_span_value(s, value));

        public static bool overright_spanset_value(IntPtr ss, long value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_spanset_value(ss, value));

        public static bool overright_value_set(long value, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_value_set(value, s));

        public static bool overright_value_span(long value, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_value_span(value, s));

        public static bool overright_value_spanset(long value, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_value_spanset(value, ss));

        public static bool right_value_set(long value, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_value_set(value, s));

        public static bool right_set_value(IntPtr s, long value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_set_value(s, value));

        public static bool right_value_span(long value, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_value_span(value, s));

        public static bool right_value_spanset(long value, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_value_spanset(value, ss));

        public static bool right_span_value(IntPtr s, long value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_span_value(s, value));

        public static bool right_spanset_value(IntPtr ss, long value)
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

        public static IntPtr intersection_set_value(IntPtr s, long value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_set_value(s, value));

        public static IntPtr intersection_span_value(IntPtr s, long value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_span_value(s, value));

        public static IntPtr intersection_spanset_value(IntPtr ss, long value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_spanset_value(ss, value));

        public static IntPtr intersection_value_set(long value, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_value_set(value, s));

        public static IntPtr intersection_value_span(long value, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_value_span(value, s));

        public static IntPtr intersection_value_spanset(long value, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_value_spanset(value, ss));

        public static int mi_span_span(IntPtr s1, IntPtr s2, IntPtr result)
            => SafeExecution<int>(() => MEOSExternalFunctions.mi_span_span(s1, s2, result));

        public static IntPtr minus_set_value(IntPtr s, long value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_set_value(s, value));

        public static IntPtr minus_span_value(IntPtr s, long value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_span_value(s, value));

        public static IntPtr minus_spanset_value(IntPtr ss, long value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_spanset_value(ss, value));

        public static IntPtr minus_value_set(long value, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_value_set(value, s));

        public static IntPtr minus_value_span(long value, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_value_span(value, s));

        public static IntPtr minus_value_spanset(long value, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_value_spanset(value, ss));

        public static IntPtr union_set_value(IntPtr s, long value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_set_value(s, value));

        public static IntPtr union_span_value(IntPtr s, long value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_span_value(s, value));

        public static IntPtr union_spanset_value(IntPtr ss, long value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_spanset_value(ss, value));

        public static IntPtr union_value_set(long value, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_value_set(value, s));

        public static IntPtr union_value_span(long value, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_value_span(value, s));

        public static IntPtr union_value_spanset(long value, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_value_spanset(value, ss));

        public static long distance_set_set(IntPtr s1, IntPtr s2)
            => SafeExecution<long>(() => MEOSExternalFunctions.distance_set_set(s1, s2));

        public static long distance_set_value(IntPtr s, long value)
            => SafeExecution<long>(() => MEOSExternalFunctions.distance_set_value(s, value));

        public static long distance_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<long>(() => MEOSExternalFunctions.distance_span_span(s1, s2));

        public static long distance_span_value(IntPtr s, long value)
            => SafeExecution<long>(() => MEOSExternalFunctions.distance_span_value(s, value));

        public static long distance_spanset_span(IntPtr ss, IntPtr s)
            => SafeExecution<long>(() => MEOSExternalFunctions.distance_spanset_span(ss, s));

        public static long distance_spanset_spanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<long>(() => MEOSExternalFunctions.distance_spanset_spanset(ss1, ss2));

        public static long distance_spanset_value(IntPtr ss, long value)
            => SafeExecution<long>(() => MEOSExternalFunctions.distance_spanset_value(ss, value));

        public static long distance_value_value(long l, long r, int basetype)
            => SafeExecution<long>(() => MEOSExternalFunctions.distance_value_value(l, r, basetype));

        public static IntPtr spanbase_extent_transfn(IntPtr state, long value, int basetype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanbase_extent_transfn(state, value, basetype));

        public static IntPtr value_union_transfn(IntPtr state, long value, int basetype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.value_union_transfn(state, value, basetype));

        public static IntPtr number_tstzspan_to_tbox(long d, int basetype, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.number_tstzspan_to_tbox(d, basetype, s));

        public static IntPtr number_timestamptz_to_tbox(long d, int basetype, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.number_timestamptz_to_tbox(d, basetype, t));

        public static void tbox_set(IntPtr s, IntPtr p, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tbox_set(s, p, box));

        public static void float_set_tbox(double d, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.float_set_tbox(d, box));

        public static void int_set_tbox(int i, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.int_set_tbox(i, box));

        public static void number_set_tbox(long d, int basetype, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.number_set_tbox(d, basetype, box));

        public static IntPtr number_tbox(long value, int basetype)
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

        public static IntPtr tbox_shift_scale_value(IntPtr box, long shift, long width, bool hasshift, bool haswidth)
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

        public static IntPtr tbigintinst_from_mfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbigintinst_from_mfjson(mfjson));

        public static IntPtr tbigintinst_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbigintinst_in(str));

        public static IntPtr tbigintseq_from_mfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbigintseq_from_mfjson(mfjson));

        public static IntPtr tbigintseqset_from_mfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbigintseqset_from_mfjson(mfjson));

        public static IntPtr tbigintseqset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbigintseqset_in(str));

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

        public static IntPtr temporal_from_base_temp(long value, int temptype, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_from_base_temp(value, temptype, temp));

        public static IntPtr tinstant_copy(IntPtr inst)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_copy(inst));

        public static IntPtr tinstant_make(long value, int temptype, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_make(value, temptype, t));

        public static IntPtr tinstant_make_free(long value, int temptype, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_make_free(value, temptype, t));

        public static IntPtr tsequence_copy(IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_copy(seq));

        public static IntPtr tsequence_from_base_temp(long value, int temptype, IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_from_base_temp(value, temptype, seq));

        public static IntPtr tsequence_from_base_tstzset(long value, int temptype, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_from_base_tstzset(value, temptype, s));

        public static IntPtr tsequence_from_base_tstzspan(long value, int temptype, IntPtr s, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_from_base_tstzspan(value, temptype, s, interp));

        public static IntPtr tsequence_make_exp(IntPtr instants, int count, int maxcount, bool lower_inc, bool upper_inc, int interp, bool normalize)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_make_exp(instants, count, maxcount, lower_inc, upper_inc, interp, normalize));

        public static IntPtr tsequence_make_free(IntPtr instants, int count, bool lower_inc, bool upper_inc, int interp, bool normalize)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_make_free(instants, count, lower_inc, upper_inc, interp, normalize));

        public static IntPtr tsequenceset_copy(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_copy(ss));

        public static IntPtr tseqsetarr_to_tseqset(IntPtr seqsets, int count, int totalseqs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tseqsetarr_to_tseqset(seqsets, count, totalseqs));

        public static IntPtr tsequenceset_from_base_temp(long value, int temptype, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_from_base_temp(value, temptype, ss));

        public static IntPtr tsequenceset_from_base_tstzspanset(long value, int temptype, IntPtr ss, int interp)
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

        public static long temporal_end_value(IntPtr temp)
            => SafeExecution<long>(() => MEOSExternalFunctions.temporal_end_value(temp));

        public static IntPtr temporal_inst_n(IntPtr temp, int n)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_inst_n(temp, n));

        public static IntPtr[] temporal_insts_p(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_insts_p(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr temporal_max_inst_p(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_max_inst_p(temp));

        public static long temporal_max_value(IntPtr temp)
            => SafeExecution<long>(() => MEOSExternalFunctions.temporal_max_value(temp));

        public static ulong temporal_mem_size(IntPtr temp)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.temporal_mem_size(temp));

        public static IntPtr temporal_min_inst_p(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_min_inst_p(temp));

        public static long temporal_min_value(IntPtr temp)
            => SafeExecution<long>(() => MEOSExternalFunctions.temporal_min_value(temp));

        public static IntPtr[] temporal_sequences_p(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_sequences_p(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static void temporal_set_bbox(IntPtr temp, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.temporal_set_bbox(temp, box));

        public static IntPtr temporal_start_inst(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_start_inst(temp));

        public static long temporal_start_value(IntPtr temp)
            => SafeExecution<long>(() => MEOSExternalFunctions.temporal_start_value(temp));

        public static long[] temporal_values_p(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_values_p(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                long[] _out = new long[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool temporal_value_n(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.temporal_value_n(temp, n, result));

        public static long[] temporal_values(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_values(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                long[] _out = new long[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int tinstant_hash(IntPtr inst)
            => SafeExecution<int>(() => MEOSExternalFunctions.tinstant_hash(inst));

        public static IntPtr[] tinstant_insts(IntPtr inst)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_insts(inst, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static void tinstant_set_bbox(IntPtr inst, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tinstant_set_bbox(inst, box));

        public static IntPtr tinstant_time(IntPtr inst)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_time(inst));

        public static long[] tinstant_timestamps(IntPtr inst)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_timestamps(inst, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                long[] _out = new long[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static long tinstant_value_p(IntPtr inst)
            => SafeExecution<long>(() => MEOSExternalFunctions.tinstant_value_p(inst));

        public static long tinstant_value(IntPtr inst)
            => SafeExecution<long>(() => MEOSExternalFunctions.tinstant_value(inst));

        public static bool tinstant_value_at_timestamptz(IntPtr inst, long t, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tinstant_value_at_timestamptz(inst, t, result));

        public static long[] tinstant_values_p(IntPtr inst)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_values_p(inst, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                long[] _out = new long[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static void tnumber_set_span(IntPtr temp, IntPtr s)
            => SafeExecution(() => MEOSExternalFunctions.tnumber_set_span(temp, s));

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

        public static int tsequence_hash(IntPtr seq)
            => SafeExecution<int>(() => MEOSExternalFunctions.tsequence_hash(seq));

        public static IntPtr[] tsequence_insts_p(IntPtr seq)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_insts_p(seq, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr tsequence_max_inst_p(IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_max_inst_p(seq));

        public static long tsequence_max_val(IntPtr seq)
            => SafeExecution<long>(() => MEOSExternalFunctions.tsequence_max_val(seq));

        public static IntPtr tsequence_min_inst_p(IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_min_inst_p(seq));

        public static long tsequence_min_val(IntPtr seq)
            => SafeExecution<long>(() => MEOSExternalFunctions.tsequence_min_val(seq));

        public static IntPtr[] tsequence_segments(IntPtr seq)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_segments(seq, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] tsequence_seqs(IntPtr seq)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_seqs(seq, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static long tsequence_start_timestamptz(IntPtr seq)
            => SafeExecution<long>(() => MEOSExternalFunctions.tsequence_start_timestamptz(seq));

        public static IntPtr tsequence_time(IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_time(seq));

        public static long[] tsequence_timestamps(IntPtr seq)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_timestamps(seq, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                long[] _out = new long[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool tsequence_value_at_timestamptz(IntPtr seq, long t, bool strict, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tsequence_value_at_timestamptz(seq, t, strict, result));

        public static long[] tsequence_values_p(IntPtr seq)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_values_p(seq, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                long[] _out = new long[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr tsequenceset_duration(IntPtr ss, bool boundspan)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_duration(ss, boundspan));

        public static long tsequenceset_end_timestamptz(IntPtr ss)
            => SafeExecution<long>(() => MEOSExternalFunctions.tsequenceset_end_timestamptz(ss));

        public static int tsequenceset_hash(IntPtr ss)
            => SafeExecution<int>(() => MEOSExternalFunctions.tsequenceset_hash(ss));

        public static IntPtr tsequenceset_inst_n(IntPtr ss, int n)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_inst_n(ss, n));

        public static IntPtr[] tsequenceset_insts_p(IntPtr ss)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_insts_p(ss, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr tsequenceset_max_inst_p(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_max_inst_p(ss));

        public static long tsequenceset_max_val(IntPtr ss)
            => SafeExecution<long>(() => MEOSExternalFunctions.tsequenceset_max_val(ss));

        public static IntPtr tsequenceset_min_inst_p(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_min_inst_p(ss));

        public static long tsequenceset_min_val(IntPtr ss)
            => SafeExecution<long>(() => MEOSExternalFunctions.tsequenceset_min_val(ss));

        public static int tsequenceset_num_instants(IntPtr ss)
            => SafeExecution<int>(() => MEOSExternalFunctions.tsequenceset_num_instants(ss));

        public static int tsequenceset_num_timestamps(IntPtr ss)
            => SafeExecution<int>(() => MEOSExternalFunctions.tsequenceset_num_timestamps(ss));

        public static IntPtr[] tsequenceset_segments(IntPtr ss)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_segments(ss, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr tsequenceset_sequences_p(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_sequences_p(ss));

        public static long tsequenceset_start_timestamptz(IntPtr ss)
            => SafeExecution<long>(() => MEOSExternalFunctions.tsequenceset_start_timestamptz(ss));

        public static IntPtr tsequenceset_time(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_time(ss));

        public static bool tsequenceset_timestamptz_n(IntPtr ss, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tsequenceset_timestamptz_n(ss, n, result));

        public static long[] tsequenceset_timestamps(IntPtr ss)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_timestamps(ss, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                long[] _out = new long[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool tsequenceset_value_at_timestamptz(IntPtr ss, long t, bool strict, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tsequenceset_value_at_timestamptz(ss, t, strict, result));

        public static bool tsequenceset_value_n(IntPtr ss, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tsequenceset_value_n(ss, n, result));

        public static bool tsequenceset_value_n_p(IntPtr ss, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tsequenceset_value_n_p(ss, n, result));

        public static long[] tsequenceset_values_p(IntPtr ss)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_values_p(ss, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                long[] _out = new long[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

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

        public static IntPtr tnumber_shift_scale_value(IntPtr temp, long shift, long width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_shift_scale_value(temp, shift, width, hasshift, haswidth));

        public static IntPtr tnumberinst_shift_value(IntPtr inst, long shift)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumberinst_shift_value(inst, shift));

        public static IntPtr tnumberseq_shift_scale_value(IntPtr seq, long shift, long width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumberseq_shift_scale_value(seq, shift, width, hasshift, haswidth));

        public static IntPtr tnumberseqset_shift_scale_value(IntPtr ss, long start, long width, bool hasshift, bool haswidth)
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

        public static IntPtr temporal_restrict_value(IntPtr temp, long value, bool atfunc)
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

        public static IntPtr tinstant_restrict_value(IntPtr inst, long value, bool atfunc)
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

        public static IntPtr tsequenceset_restrict_value(IntPtr ss, long value, bool atfunc)
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

        public static int always_eq_base_temporal(long value, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_base_temporal(value, temp));

        public static int always_eq_temporal_base(IntPtr temp, long value)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_temporal_base(temp, value));

        public static int always_ne_base_temporal(long value, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_base_temporal(value, temp));

        public static int always_ne_temporal_base(IntPtr temp, long value)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_temporal_base(temp, value));

        public static int always_ge_base_temporal(long value, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ge_base_temporal(value, temp));

        public static int always_ge_temporal_base(IntPtr temp, long value)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ge_temporal_base(temp, value));

        public static int always_gt_base_temporal(long value, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_gt_base_temporal(value, temp));

        public static int always_gt_temporal_base(IntPtr temp, long value)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_gt_temporal_base(temp, value));

        public static int always_le_base_temporal(long value, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_le_base_temporal(value, temp));

        public static int always_le_temporal_base(IntPtr temp, long value)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_le_temporal_base(temp, value));

        public static int always_lt_base_temporal(long value, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_lt_base_temporal(value, temp));

        public static int always_lt_temporal_base(IntPtr temp, long value)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_lt_temporal_base(temp, value));

        public static int ever_eq_base_temporal(long value, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_base_temporal(value, temp));

        public static int ever_eq_temporal_base(IntPtr temp, long value)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_temporal_base(temp, value));

        public static int ever_ne_base_temporal(long value, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_base_temporal(value, temp));

        public static int ever_ne_temporal_base(IntPtr temp, long value)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_temporal_base(temp, value));

        public static int ever_ge_base_temporal(long value, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ge_base_temporal(value, temp));

        public static int ever_ge_temporal_base(IntPtr temp, long value)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ge_temporal_base(temp, value));

        public static int ever_gt_base_temporal(long value, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_gt_base_temporal(value, temp));

        public static int ever_gt_temporal_base(IntPtr temp, long value)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_gt_temporal_base(temp, value));

        public static int ever_le_base_temporal(long value, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_le_base_temporal(value, temp));

        public static int ever_le_temporal_base(IntPtr temp, long value)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_le_temporal_base(temp, value));

        public static int ever_lt_base_temporal(long value, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_lt_base_temporal(value, temp));

        public static int ever_lt_temporal_base(IntPtr temp, long value)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_lt_temporal_base(temp, value));

        public static IntPtr tnumberinst_abs(IntPtr inst)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumberinst_abs(inst));

        public static double tnumberinst_distance(IntPtr inst1, IntPtr inst2)
            => SafeExecution<double>(() => MEOSExternalFunctions.tnumberinst_distance(inst1, inst2));

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

        public static IntPtr tdistance_tnumber_number(IntPtr temp, long value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdistance_tnumber_number(temp, value));

        public static double nad_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tbox_tbox(box1, box2));

        public static double nad_tnumber_number(IntPtr temp, long value)
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

        public static IntPtr skiplist_make(IntPtr key_size, IntPtr value_size, IntPtr comp_fn, IntPtr merge_fn)
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

        public static IntPtr[] span_bins(IntPtr s, long size, long origin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.span_bins(s, size, origin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] spanset_bins(IntPtr ss, long size, long origin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_bins(ss, size, origin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] tnumber_value_bins(IntPtr temp, long size, long origin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_value_bins(temp, size, origin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] tnumber_value_time_boxes(IntPtr temp, long vsize, IntPtr duration, long vorigin, long torigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_value_time_boxes(temp, vsize, duration, vorigin, torigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static (IntPtr[], long[]) tnumber_value_split(IntPtr temp, long vsize, long vorigin)
        {
            IntPtr _out_bins = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_value_split(temp, vsize, vorigin, _out_bins, _count_count));
                int _n = Marshal.ReadInt32(_count_count);
                IntPtr[] _resultArr = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _resultArr[_i] = Marshal.ReadIntPtr(_resultPtr, _i * IntPtr.Size); }
                IntPtr __out_bins_arr = Marshal.ReadIntPtr(_out_bins);
                long[] __out_bins_out = new long[_n];
                Marshal.Copy(__out_bins_arr, __out_bins_out, 0, _n);
                return (_resultArr, __out_bins_out);
            }
            finally
            {
            Marshal.FreeHGlobal(_out_bins);
            Marshal.FreeHGlobal(_count_count);
            }
        }

        public static IntPtr tbox_get_value_time_tile(long value, long t, long vsize, IntPtr duration, long vorigin, long torigin, int basetype, int spantype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_get_value_time_tile(value, t, vsize, duration, vorigin, torigin, basetype, spantype));

        public static (IntPtr[], long[], long[]) tnumber_value_time_split(IntPtr temp, long size, IntPtr duration, long vorigin, long torigin)
        {
            IntPtr _out_value_bins = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _out_time_bins = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_value_time_split(temp, size, duration, vorigin, torigin, _out_value_bins, _out_time_bins, _count_count));
                int _n = Marshal.ReadInt32(_count_count);
                IntPtr[] _resultArr = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _resultArr[_i] = Marshal.ReadIntPtr(_resultPtr, _i * IntPtr.Size); }
                IntPtr __out_value_bins_arr = Marshal.ReadIntPtr(_out_value_bins);
                long[] __out_value_bins_out = new long[_n];
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

        public static string double2_out(IntPtr d, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.double2_out(d, maxdd));

        public static void double2_set(double a, double b, IntPtr result)
            => SafeExecution(() => MEOSExternalFunctions.double2_set(a, b, result));

        public static IntPtr double2_add(IntPtr d1, IntPtr d2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.double2_add(d1, d2));

        public static bool double2_eq(IntPtr d1, IntPtr d2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.double2_eq(d1, d2));

        public static string double3_out(IntPtr d, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.double3_out(d, maxdd));

        public static void double3_set(double a, double b, double c, IntPtr result)
            => SafeExecution(() => MEOSExternalFunctions.double3_set(a, b, c, result));

        public static IntPtr double3_add(IntPtr d1, IntPtr d2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.double3_add(d1, d2));

        public static bool double3_eq(IntPtr d1, IntPtr d2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.double3_eq(d1, d2));

        public static string double4_out(IntPtr d, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.double4_out(d, maxdd));

        public static void double4_set(double a, double b, double c, double d, IntPtr result)
            => SafeExecution(() => MEOSExternalFunctions.double4_set(a, b, c, d, result));

        public static IntPtr double4_add(IntPtr d1, IntPtr d2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.double4_add(d1, d2));

        public static bool double4_eq(IntPtr d1, IntPtr d2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.double4_eq(d1, d2));

        public static bool double2_collinear(IntPtr x1, IntPtr x2, IntPtr x3, double ratio)
            => SafeExecution<bool>(() => MEOSExternalFunctions.double2_collinear(x1, x2, x3, ratio));

        public static bool double3_collinear(IntPtr x1, IntPtr x2, IntPtr x3, double ratio)
            => SafeExecution<bool>(() => MEOSExternalFunctions.double3_collinear(x1, x2, x3, ratio));

        public static bool double4_collinear(IntPtr x1, IntPtr x2, IntPtr x3, double ratio)
            => SafeExecution<bool>(() => MEOSExternalFunctions.double4_collinear(x1, x2, x3, ratio));

        public static IntPtr double2segm_interpolate(IntPtr start, IntPtr end, IntPtr ratio)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.double2segm_interpolate(start, end, ratio));

        public static IntPtr double3segm_interpolate(IntPtr start, IntPtr end, IntPtr ratio)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.double3segm_interpolate(start, end, ratio));

        public static IntPtr double4segm_interpolate(IntPtr start, IntPtr end, IntPtr ratio)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.double4segm_interpolate(start, end, ratio));

        public static int pg_atoi(string s, int size, int c)
            => SafeExecution<int>(() => MEOSExternalFunctions.pg_atoi(s, size, c));

        public static bool ensure_has_X(int type, short flags)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_has_X(type, flags));

        public static bool ensure_has_Z(int type, short flags)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_has_Z(type, flags));

        public static bool ensure_has_T(int type, short flags)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_has_T(type, flags));

        public static bool ensure_has_not_Z(int type, short flags)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_has_not_Z(type, flags));

        public static bool ensure_not_null(IntPtr ptr)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_not_null(ptr));

        public static bool ensure_one_not_null(IntPtr ptr1, IntPtr ptr2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_one_not_null(ptr1, ptr2));

        public static bool ensure_one_true(bool hasshift, bool haswidth)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_one_true(hasshift, haswidth));

        public static bool ensure_valid_interp(int temptype, int interp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_interp(temptype, interp));

        public static bool ensure_continuous(IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_continuous(temp));

        public static bool ensure_same_interp(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_same_interp(temp1, temp2));

        public static bool ensure_same_continuous_interp(short flags1, short flags2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_same_continuous_interp(flags1, flags2));

        public static bool ensure_linear_interp(short flags)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_linear_interp(flags));

        public static bool ensure_nonlinear_interp(short flags)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_nonlinear_interp(flags));

        public static bool ensure_common_dimension(short flags1, short flags2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_common_dimension(flags1, flags2));

        public static bool ensure_temporal_isof_type(IntPtr temp, int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_temporal_isof_type(temp, type));

        public static bool ensure_temporal_isof_basetype(IntPtr temp, int basetype)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_temporal_isof_basetype(temp, basetype));

        public static bool ensure_temporal_isof_subtype(IntPtr temp, int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_temporal_isof_subtype(temp, type));

        public static bool ensure_same_temporal_type(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_same_temporal_type(temp1, temp2));

        public static bool ensure_valid_tnumber_numspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tnumber_numspan(temp, s));

        public static bool ensure_valid_tnumber_numspanset(IntPtr temp, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tnumber_numspanset(temp, ss));

        public static bool ensure_valid_tnumber_tbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tnumber_tbox(temp, box));

        public static bool ensure_valid_temporal_set(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_temporal_set(temp, s));

        public static bool ensure_valid_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_temporal_temporal(temp1, temp2));

        public static bool ensure_valid_tnumber_tnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tnumber_tnumber(temp1, temp2));

        public static bool ensure_not_negative(int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_not_negative(i));

        public static bool ensure_positive(int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_positive(i));

        public static bool not_negative_datum(long size, int basetype)
            => SafeExecution<bool>(() => MEOSExternalFunctions.not_negative_datum(size, basetype));

        public static bool ensure_not_negative_datum(long size, int basetype)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_not_negative_datum(size, basetype));

        public static bool positive_datum(long size, int basetype)
            => SafeExecution<bool>(() => MEOSExternalFunctions.positive_datum(size, basetype));

        public static bool ensure_positive_datum(long size, int basetype)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_positive_datum(size, basetype));

        public static bool ensure_valid_day_duration(IntPtr duration)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_day_duration(duration));

        public static bool positive_duration(IntPtr duration)
            => SafeExecution<bool>(() => MEOSExternalFunctions.positive_duration(duration));

        public static bool ensure_positive_duration(IntPtr duration)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_positive_duration(duration));

        public static IntPtr temporal_bbox_ptr(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_bbox_ptr(temp));

        public static bool intersection_temporal_temporal(IntPtr temp1, IntPtr temp2, IntPtr mode, IntPtr inter1, IntPtr inter2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.intersection_temporal_temporal(temp1, temp2, mode, inter1, inter2));

        public static string mobilitydb_version()
            => SafeExecution<string>(() => MEOSExternalFunctions.mobilitydb_version());

        public static string mobilitydb_full_version()
            => SafeExecution<string>(() => MEOSExternalFunctions.mobilitydb_full_version());

        public static IntPtr round_fn(int basetype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.round_fn(basetype));

        public static bool temporal_bbox_restrict_value(IntPtr temp, long value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.temporal_bbox_restrict_value(temp, value));

        public static bool ensure_valid_tcbuffer_cbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tcbuffer_cbuffer(temp, cb));

        public static bool ensure_valid_tcbuffer_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tcbuffer_geo(temp, gs));

        public static bool ensure_valid_tcbuffer_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tcbuffer_stbox(temp, box));

        public static bool ensure_valid_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tcbuffer_tcbuffer(temp1, temp2));

        public static int tcbuffersegm_intersection_value(long start, long end, long value, long lower, long upper, IntPtr t1, IntPtr t2)
            => SafeExecution<int>(() => MEOSExternalFunctions.tcbuffersegm_intersection_value(start, end, value, lower, upper, t1, t2));

        public static int tcbuffersegm_intersection(long start1, long end1, long start2, long end2, long lower, long upper, IntPtr t1, IntPtr t2)
            => SafeExecution<int>(() => MEOSExternalFunctions.tcbuffersegm_intersection(start1, end1, start2, end2, lower, upper, t1, t2));

        public static int tcbuffersegm_dwithin_turnpt(long start1, long end1, long start2, long end2, long dist, long lower, long upper, IntPtr t1, IntPtr t2)
            => SafeExecution<int>(() => MEOSExternalFunctions.tcbuffersegm_dwithin_turnpt(start1, end1, start2, end2, dist, lower, upper, t1, t2));

        public static int tcbuffersegm_tdwithin_turnpt(long start1, long end1, long start2, long end2, long dist, long lower, long upper, IntPtr t1, IntPtr t2)
            => SafeExecution<int>(() => MEOSExternalFunctions.tcbuffersegm_tdwithin_turnpt(start1, end1, start2, end2, dist, lower, upper, t1, t2));

        public static int tcbuffersegm_distance_turnpt(long start1, long end1, long start2, long end2, long dist, long lower, long upper, IntPtr t1, IntPtr t2)
            => SafeExecution<int>(() => MEOSExternalFunctions.tcbuffersegm_distance_turnpt(start1, end1, start2, end2, dist, lower, upper, t1, t2));

        public static IntPtr tcbuffer_geo_ctx_make(IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffer_geo_ctx_make(gs));

        public static void tcbuffer_geo_ctx_free(IntPtr ctx)
            => SafeExecution(() => MEOSExternalFunctions.tcbuffer_geo_ctx_free(ctx));

        public static int tcbuffer_geo_ctx_nsegs(IntPtr ctx)
            => SafeExecution<int>(() => MEOSExternalFunctions.tcbuffer_geo_ctx_nsegs(ctx));

        public static bool tcbuffer_disc_within_ctx(IntPtr cb, double dist, IntPtr ctx)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tcbuffer_disc_within_ctx(cb, dist, ctx));

        public static int tcbufferseg_within_ctx(IntPtr cb1, IntPtr cb2, double dist, IntPtr ctx, IntPtr outlo, IntPtr outhi, int maxout)
            => SafeExecution<int>(() => MEOSExternalFunctions.tcbufferseg_within_ctx(cb1, cb2, dist, ctx, outlo, outhi, maxout));

        public static bool tcbuffer_disc_touch_ctx(IntPtr cb, IntPtr ctx)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tcbuffer_disc_touch_ctx(cb, ctx));

        public static int tcbufferseg_touch_roots(IntPtr cb1, IntPtr cb2, IntPtr ctx, IntPtr outt, int maxout)
            => SafeExecution<int>(() => MEOSExternalFunctions.tcbufferseg_touch_roots(cb1, cb2, ctx, outt, maxout));

        public static bool cbuffer_set_stbox(IntPtr cb, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.cbuffer_set_stbox(cb, box));

        public static void cbufferarr_set_stbox(IntPtr values, int count, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.cbufferarr_set_stbox(values, count, box));

        public static void cbuffer_timestamptz_set_stbox(IntPtr cb, long t, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.cbuffer_timestamptz_set_stbox(cb, t, box));

        public static void cbuffer_tstzspan_set_stbox(IntPtr cb, IntPtr s, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.cbuffer_tstzspan_set_stbox(cb, s, box));

        public static void tcbufferinst_set_stbox(IntPtr inst, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tcbufferinst_set_stbox(inst, box));

        public static void tcbufferinstarr_set_stbox(IntPtr instants, int count, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tcbufferinstarr_set_stbox(instants, count, box));

        public static void tcbufferseq_expand_stbox(IntPtr seq, IntPtr inst)
            => SafeExecution(() => MEOSExternalFunctions.tcbufferseq_expand_stbox(seq, inst));

        public static IntPtr tcbufferinst_traversed_area(IntPtr inst)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbufferinst_traversed_area(inst));

        public static IntPtr tcbufferseq_traversed_area(IntPtr seq, bool unary_union)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbufferseq_traversed_area(seq, unary_union));

        public static IntPtr tcbufferseqset_traversed_area(IntPtr ss, bool unary_union)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbufferseqset_traversed_area(ss, unary_union));

        public static IntPtr tcbuffersegm_traversed_area(IntPtr inst1, IntPtr inst2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffersegm_traversed_area(inst1, inst2));

        public static IntPtr tcbuffer_restrict_cbuffer(IntPtr temp, IntPtr cb, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffer_restrict_cbuffer(temp, cb, atfunc));

        public static IntPtr tcbuffer_restrict_stbox(IntPtr temp, IntPtr box, bool border_inc, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffer_restrict_stbox(temp, box, border_inc, atfunc));

        public static IntPtr tcbuffer_restrict_geom(IntPtr temp, IntPtr gs, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcbuffer_restrict_geom(temp, gs, atfunc));

        public static int ea_contains_geo_tcbuffer(IntPtr gs, IntPtr temp, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_contains_geo_tcbuffer(gs, temp, ever));

        public static int ea_contains_tcbuffer_geo(IntPtr temp, IntPtr gs, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_contains_tcbuffer_geo(temp, gs, ever));

        public static int ea_contains_tcbuffer_cbuffer(IntPtr temp, IntPtr cb, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_contains_tcbuffer_cbuffer(temp, cb, ever));

        public static int ea_contains_cbuffer_tcbuffer(IntPtr cb, IntPtr temp, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_contains_cbuffer_tcbuffer(cb, temp, ever));

        public static int ea_covers_geo_tcbuffer(IntPtr gs, IntPtr temp, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_covers_geo_tcbuffer(gs, temp, ever));

        public static int ea_covers_tcbuffer_geo(IntPtr temp, IntPtr gs, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_covers_tcbuffer_geo(temp, gs, ever));

        public static int ea_covers_tcbuffer_cbuffer(IntPtr temp, IntPtr cb, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_covers_tcbuffer_cbuffer(temp, cb, ever));

        public static int ea_covers_cbuffer_tcbuffer(IntPtr cb, IntPtr temp, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_covers_cbuffer_tcbuffer(cb, temp, ever));

        public static int ea_covers_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_covers_tcbuffer_tcbuffer(temp1, temp2, ever));

        public static int ea_disjoint_tcbuffer_geo(IntPtr temp, IntPtr gs, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_disjoint_tcbuffer_geo(temp, gs, ever));

        public static int ea_disjoint_geo_tcbuffer(IntPtr gs, IntPtr temp, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_disjoint_geo_tcbuffer(gs, temp, ever));

        public static int ea_disjoint_tcbuffer_cbuffer(IntPtr temp, IntPtr cb, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_disjoint_tcbuffer_cbuffer(temp, cb, ever));

        public static int ea_disjoint_cbuffer_tcbuffer(IntPtr cb, IntPtr temp, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_disjoint_cbuffer_tcbuffer(cb, temp, ever));

        public static int ea_disjoint_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_disjoint_tcbuffer_tcbuffer(temp1, temp2, ever));

        public static int ea_intersects_tcbuffer_geo(IntPtr temp, IntPtr gs, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_intersects_tcbuffer_geo(temp, gs, ever));

        public static int ea_intersects_geo_tcbuffer(IntPtr gs, IntPtr temp, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_intersects_geo_tcbuffer(gs, temp, ever));

        public static int ea_intersects_tcbuffer_cbuffer(IntPtr temp, IntPtr cb, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_intersects_tcbuffer_cbuffer(temp, cb, ever));

        public static int ea_intersects_cbuffer_tcbuffer(IntPtr cb, IntPtr temp, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_intersects_cbuffer_tcbuffer(cb, temp, ever));

        public static int ea_intersects_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_intersects_tcbuffer_tcbuffer(temp1, temp2, ever));

        public static int ea_touches_tcbuffer_geo(IntPtr temp, IntPtr gs, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_touches_tcbuffer_geo(temp, gs, ever));

        public static int ea_touches_geo_tcbuffer(IntPtr gs, IntPtr temp, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_touches_geo_tcbuffer(gs, temp, ever));

        public static int ea_touches_tcbuffer_cbuffer(IntPtr temp, IntPtr cb, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_touches_tcbuffer_cbuffer(temp, cb, ever));

        public static int ea_touches_cbuffer_tcbuffer(IntPtr cb, IntPtr temp, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_touches_cbuffer_tcbuffer(cb, temp, ever));

        public static int ea_touches_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_touches_tcbuffer_tcbuffer(temp1, temp2, ever));

        public static int ea_dwithin_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2, double dist, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_dwithin_tcbuffer_tcbuffer(temp1, temp2, dist, ever));

        public static IntPtr tinterrel_tcbuffer_cbuffer(IntPtr temp, IntPtr cb, bool tinter)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinterrel_tcbuffer_cbuffer(temp, cb, tinter));

        public static IntPtr tinterrel_tcbuffer_geo(IntPtr temp, IntPtr gs, bool tinter)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinterrel_tcbuffer_geo(temp, gs, tinter));

        public static int edisjoint_tcbuffer_geo_native(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.edisjoint_tcbuffer_geo_native(temp, gs));

        public static int eatouches_tcbuffer_geo_native(IntPtr temp, IntPtr gs, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.eatouches_tcbuffer_geo_native(temp, gs, ever));

        public static IntPtr clipper2_clip_poly_poly(IntPtr subj, IntPtr clip, int op)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.clipper2_clip_poly_poly(subj, clip, op));

        public static IntPtr clipper2_traj_poly_periods(IntPtr seq, IntPtr gs, IntPtr out_count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.clipper2_traj_poly_periods(seq, gs, out_count));

        public static IntPtr clip_poly_poly(IntPtr subj, IntPtr clip, IntPtr operation)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.clip_poly_poly(subj, clip, operation));

        public static int lwproj_lookup(int srid_from, int srid_to, IntPtr pj)
            => SafeExecution<int>(() => MEOSExternalFunctions.lwproj_lookup(srid_from, srid_to, pj));

        public static int spheroid_init_from_srid(int srid, IntPtr s)
            => SafeExecution<int>(() => MEOSExternalFunctions.spheroid_init_from_srid(srid, s));

        public static void srid_check_latlong(int srid)
            => SafeExecution(() => MEOSExternalFunctions.srid_check_latlong(srid));

        public static int srid_is_latlong(int srid)
            => SafeExecution<int>(() => MEOSExternalFunctions.srid_is_latlong(srid));

        public static IntPtr geom_serialize(IntPtr lwgeom)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geom_serialize(lwgeom));

        public static IntPtr geog_serialize(IntPtr lwgeom)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geog_serialize(lwgeom));

        public static IntPtr meos_postgis_valid_typmod(IntPtr gs, int typmod)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.meos_postgis_valid_typmod(gs, typmod));

        public static string geo_as_wkt(IntPtr gs, int precision, bool extended)
            => SafeExecution<string>(() => MEOSExternalFunctions.geo_as_wkt(gs, precision, extended));

        public static IntPtr box2d_to_lwgeom(IntPtr box, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.box2d_to_lwgeom(box, srid));

        public static IntPtr box3d_to_lwgeom(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.box3d_to_lwgeom(box));

        public static IntPtr MEOS_POSTGIS2GEOS(IntPtr pglwgeom)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.MEOS_POSTGIS2GEOS(pglwgeom));

        public static IntPtr MEOS_GEOS2POSTGIS(IntPtr geom, byte want3d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.MEOS_GEOS2POSTGIS(geom, want3d));

        public static bool geom_spatialrel(IntPtr gs1, IntPtr gs2, IntPtr rel)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geom_spatialrel(gs1, gs2, rel));

        public static IntPtr lwgeom_line_interpolate_point(IntPtr geom, double fraction, int srid, byte repeat)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.lwgeom_line_interpolate_point(geom, fraction, srid, repeat));

        public static void point_get_coords(IntPtr point, bool hasz, IntPtr x, IntPtr y, IntPtr z)
            => SafeExecution(() => MEOSExternalFunctions.point_get_coords(point, hasz, x, y, z));

        public static void tstzset_stbox_slice(long tsdatum, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tstzset_stbox_slice(tsdatum, box));

        public static void tstzspanset_stbox_slice(long psdatum, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tstzspanset_stbox_slice(psdatum, box));

        public static bool stbox_index_leaf_consistent(IntPtr key, IntPtr query, int strategy)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_index_leaf_consistent(key, query, strategy));

        public static bool stbox_gist_inner_consistent(IntPtr key, IntPtr query, int strategy)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_gist_inner_consistent(key, query, strategy));

        public static bool stbox_index_recheck(int strategy)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_index_recheck(strategy));

        public static IntPtr stboxnode_copy(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stboxnode_copy(box));

        public static int getQuadrant8D(IntPtr centroid, IntPtr inBox)
            => SafeExecution<int>(() => MEOSExternalFunctions.getQuadrant8D(centroid, inBox));

        public static void stboxnode_init(IntPtr centroid, IntPtr nodebox)
            => SafeExecution(() => MEOSExternalFunctions.stboxnode_init(centroid, nodebox));

        public static void stboxnode_quadtree_next(IntPtr nodebox, IntPtr centroid, int quadrant, IntPtr next_nodebox)
            => SafeExecution(() => MEOSExternalFunctions.stboxnode_quadtree_next(nodebox, centroid, quadrant, next_nodebox));

        public static void stboxnode_kdtree_next(IntPtr nodebox, IntPtr centroid, int node, int level, IntPtr next_nodebox)
            => SafeExecution(() => MEOSExternalFunctions.stboxnode_kdtree_next(nodebox, centroid, node, level, next_nodebox));

        public static bool overlap8D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlap8D(nodebox, query));

        public static bool overlapKD(IntPtr nodebox, IntPtr query, int level)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlapKD(nodebox, query, level));

        public static bool contain8D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contain8D(nodebox, query));

        public static bool containKD(IntPtr nodebox, IntPtr query, int level)
            => SafeExecution<bool>(() => MEOSExternalFunctions.containKD(nodebox, query, level));

        public static bool left8D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left8D(nodebox, query));

        public static bool overLeft8D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overLeft8D(nodebox, query));

        public static bool right8D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right8D(nodebox, query));

        public static bool overRight8D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overRight8D(nodebox, query));

        public static bool below8D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.below8D(nodebox, query));

        public static bool overBelow8D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overBelow8D(nodebox, query));

        public static bool above8D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.above8D(nodebox, query));

        public static bool overAbove8D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overAbove8D(nodebox, query));

        public static bool front8D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.front8D(nodebox, query));

        public static bool overFront8D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overFront8D(nodebox, query));

        public static bool back8D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.back8D(nodebox, query));

        public static bool overBack8D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overBack8D(nodebox, query));

        public static bool before8D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before8D(nodebox, query));

        public static bool overBefore8D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overBefore8D(nodebox, query));

        public static bool after8D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after8D(nodebox, query));

        public static bool overAfter8D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overAfter8D(nodebox, query));

        public static double distance_stbox_nodebox(IntPtr query, IntPtr nodebox)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_stbox_nodebox(query, nodebox));

        public static void tspatial_spgist_get_stbox(long value, int type, IntPtr result)
            => SafeExecution(() => MEOSExternalFunctions.tspatial_spgist_get_stbox(value, type, result));

        public static void mobilitydb_init()
            => SafeExecution(() => MEOSExternalFunctions.mobilitydb_init());

        public static IntPtr geo_stbox(IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_stbox(gs));

        public static IntPtr stbox_geo(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_geo(box));

        public static IntPtr tcomp_geo_tgeo(IntPtr gs, IntPtr temp, IntPtr func)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcomp_geo_tgeo(gs, temp, func));

        public static IntPtr tcomp_tgeo_geo(IntPtr temp, IntPtr gs, IntPtr func)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcomp_tgeo_geo(temp, gs, func));

        public static bool ensure_geoaggstate(IntPtr state, int srid, bool hasz)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_geoaggstate(state, srid, hasz));

        public static bool ensure_geoaggstate_state(IntPtr state1, IntPtr state2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_geoaggstate_state(state1, state2));

        public static IntPtr[] tpoint_transform_tcentroid(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_transform_tcentroid(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr tpointinst_tcentroid_finalfn(IntPtr instants, int count, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpointinst_tcentroid_finalfn(instants, count, srid));

        public static IntPtr tpointseq_tcentroid_finalfn(IntPtr sequences, int count, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpointseq_tcentroid_finalfn(sequences, count, srid));

        public static bool point3d_min_dist(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4, IntPtr fraction)
            => SafeExecution<bool>(() => MEOSExternalFunctions.point3d_min_dist(p1, p2, p3, p4, fraction));

        public static int tgeompointsegm_distance_turnpt(long start1, long end1, long start2, long end2, long param, long lower, long upper, IntPtr t1, IntPtr t2)
            => SafeExecution<int>(() => MEOSExternalFunctions.tgeompointsegm_distance_turnpt(start1, end1, start2, end2, param, lower, upper, t1, t2));

        public static int tgeogpointsegm_distance_turnpt(long start1, long end1, long start2, long end2, long param, long lower, long upper, IntPtr t1, IntPtr t2)
            => SafeExecution<int>(() => MEOSExternalFunctions.tgeogpointsegm_distance_turnpt(start1, end1, start2, end2, param, lower, upper, t1, t2));

        public static double tinstant_distance(IntPtr inst1, IntPtr inst2, IntPtr func)
            => SafeExecution<double>(() => MEOSExternalFunctions.tinstant_distance(inst1, inst2, func));

        public static IntPtr[] tpointseq_at_geom(IntPtr seq, IntPtr gs)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpointseq_at_geom(seq, gs, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] tpointseq_interperiods(IntPtr seq, IntPtr gs)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpointseq_interperiods(seq, gs, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static void datum_point4d(long value, IntPtr p)
            => SafeExecution(() => MEOSExternalFunctions.datum_point4d(value, p));

        public static int geopoint_cmp(IntPtr gs1, IntPtr gs2)
            => SafeExecution<int>(() => MEOSExternalFunctions.geopoint_cmp(gs1, gs2));

        public static bool geopoint_eq(IntPtr gs1, IntPtr gs2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geopoint_eq(gs1, gs2));

        public static bool geopoint_same(IntPtr gs1, IntPtr gs2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geopoint_same(gs1, gs2));

        public static bool datum_point_eq(long point1, long point2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.datum_point_eq(point1, point2));

        public static bool datum_point_same(long point1, long point2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.datum_point_same(point1, point2));

        public static long datum2_point_eq(long point1, long point2)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum2_point_eq(point1, point2));

        public static long datum2_point_ne(long point1, long point2)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum2_point_ne(point1, point2));

        public static long datum2_point_same(long point1, long point2)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum2_point_same(point1, point2));

        public static long datum2_point_nsame(long point1, long point2)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum2_point_nsame(point1, point2));

        public static long datum2_geom_centroid(long geo)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum2_geom_centroid(geo));

        public static long datum2_geog_centroid(long geo)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum2_geog_centroid(geo));

        public static IntPtr[] geo_extract_elements(IntPtr gs)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_extract_elements(gs, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr geo_serialize(IntPtr geom)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_serialize(geom));

        public static IntPtr geo_distance_fn(short flags)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_distance_fn(flags));

        public static IntPtr pt_distance_fn(short flags)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pt_distance_fn(flags));

        public static long datum_geom_distance2d(long geom1, long geom2)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_geom_distance2d(geom1, geom2));

        public static long datum_geom_distance3d(long geom1, long geom2)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_geom_distance3d(geom1, geom2));

        public static long datum_geog_distance(long geog1, long geog2)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_geog_distance(geog1, geog2));

        public static long datum_pt_distance2d(long geom1, long geom2)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_pt_distance2d(geom1, geom2));

        public static long datum_pt_distance3d(long geom1, long geom2)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_pt_distance3d(geom1, geom2));

        public static short spatial_flags(long d, int basetype)
            => SafeExecution<short>(() => MEOSExternalFunctions.spatial_flags(d, basetype));

        public static bool ensure_srid_is_latlong(int srid)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_srid_is_latlong(srid));

        public static bool ensure_spatial_validity(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_spatial_validity(temp1, temp2));

        public static bool ensure_not_geodetic(short flags)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_not_geodetic(flags));

        public static bool ensure_same_geodetic(short flags1, short flags2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_same_geodetic(flags1, flags2));

        public static bool ensure_same_geodetic_geo(IntPtr gs1, IntPtr gs2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_same_geodetic_geo(gs1, gs2));

        public static bool ensure_same_geodetic_tspatial_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_same_geodetic_tspatial_geo(temp, gs));

        public static bool ensure_same_geodetic_tspatial_base(IntPtr temp, long @base)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_same_geodetic_tspatial_base(temp, @base));

        public static bool ensure_srid_known(int srid)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_srid_known(srid));

        public static bool ensure_same_srid(int srid1, int srid2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_same_srid(srid1, srid2));

        public static bool ensure_srid_reconcile(int srid1, int srid2, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_srid_reconcile(srid1, srid2, result));

        public static bool ensure_same_dimensionality(short flags1, short flags2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_same_dimensionality(flags1, flags2));

        public static bool same_spatial_dimensionality(short flags1, short flags2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.same_spatial_dimensionality(flags1, flags2));

        public static bool ensure_same_spatial_dimensionality(short flags1, short flags2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_same_spatial_dimensionality(flags1, flags2));

        public static bool ensure_same_dimensionality_geo(IntPtr gs1, IntPtr gs2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_same_dimensionality_geo(gs1, gs2));

        public static bool same_dimensionality_tspatial_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.same_dimensionality_tspatial_geo(temp, gs));

        public static bool ensure_same_dimensionality_tspatial_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_same_dimensionality_tspatial_geo(temp, gs));

        public static bool ensure_same_spatial_dimensionality_stbox_geo(IntPtr box, IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_same_spatial_dimensionality_stbox_geo(box, gs));

        public static bool ensure_same_geodetic_stbox_geo(IntPtr box, IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_same_geodetic_stbox_geo(box, gs));

        public static bool ensure_has_Z_geo(IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_has_Z_geo(gs));

        public static bool ensure_has_not_Z_geo(IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_has_not_Z_geo(gs));

        public static bool ensure_has_M_geo(IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_has_M_geo(gs));

        public static bool ensure_has_not_M_geo(IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_has_not_M_geo(gs));

        public static bool ensure_not_geodetic_geo(IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_not_geodetic_geo(gs));

        public static bool ensure_point_type(IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_point_type(gs));

        public static bool ensure_mline_type(IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_mline_type(gs));

        public static bool circle_type(IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.circle_type(gs));

        public static bool ensure_circle_type(IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_circle_type(gs));

        public static bool ensure_not_empty(IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_not_empty(gs));

        public static bool ensure_valid_stbox_geo(IntPtr box, IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_stbox_geo(box, gs));

        public static bool ensure_valid_tspatial_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tspatial_geo(temp, gs));

        public static bool ensure_valid_tspatial_base(IntPtr temp, long @base)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tspatial_base(temp, @base));

        public static bool ensure_valid_tspatial_tspatial(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tspatial_tspatial(temp1, temp2));

        public static bool ensure_valid_spatial_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_spatial_stbox_stbox(box1, box2));

        public static bool ensure_valid_tgeo_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tgeo_stbox(temp, box));

        public static bool ensure_valid_geo_geo(IntPtr gs1, IntPtr gs2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_geo_geo(gs1, gs2));

        public static bool ensure_valid_tgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tgeo_geo(temp, gs));

        public static bool ensure_valid_tgeo_tgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tgeo_tgeo(temp1, temp2));

        public static bool ensure_valid_tpoint_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tpoint_geo(temp, gs));

        public static bool ensure_valid_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tpoint_tpoint(temp1, temp2));

        public static bool mline_type(IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.mline_type(gs));

        public static IntPtr tpoint_get_coord(IntPtr temp, int coord)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_get_coord(temp, coord));

        public static int eacomp_tgeo_geo(IntPtr temp, IntPtr gs, IntPtr func, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.eacomp_tgeo_geo(temp, gs, func, ever));

        public static IntPtr closest_point2d_on_segment_ratio(IntPtr p, IntPtr A, IntPtr B, IntPtr closest)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.closest_point2d_on_segment_ratio(p, A, B, closest));

        public static IntPtr closest_point3dz_on_segment_ratio(IntPtr p, IntPtr A, IntPtr B, IntPtr closest)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.closest_point3dz_on_segment_ratio(p, A, B, closest));

        public static IntPtr closest_point_on_segment_sphere(IntPtr p, IntPtr A, IntPtr B, IntPtr closest, IntPtr dist)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.closest_point_on_segment_sphere(p, A, B, closest, dist));

        public static void interpolate_point4d_spheroid(IntPtr p1, IntPtr p2, IntPtr p, IntPtr s, double f)
            => SafeExecution(() => MEOSExternalFunctions.interpolate_point4d_spheroid(p1, p2, p, s, f));

        public static IntPtr geopoint_make(double x, double y, double z, bool hasz, bool geodetic, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geopoint_make(x, y, z, hasz, geodetic, srid));

        public static IntPtr lwcircle_make(double x, double y, double radius, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.lwcircle_make(x, y, radius, srid));

        public static IntPtr geocircle_make(double x, double y, double radius, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geocircle_make(x, y, radius, srid));

        public static long pointsegm_interpolate(long start, long end, IntPtr ratio)
            => SafeExecution<long>(() => MEOSExternalFunctions.pointsegm_interpolate(start, end, ratio));

        public static IntPtr pointsegm_locate(long start, long end, long point, IntPtr dist)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pointsegm_locate(start, end, point, dist));

        public static int tgeompointsegm_intersection(long start1, long end1, long start2, long end2, long lower, long upper, IntPtr t1, IntPtr t2)
            => SafeExecution<int>(() => MEOSExternalFunctions.tgeompointsegm_intersection(start1, end1, start2, end2, lower, upper, t1, t2));

        public static int tgeogpointsegm_intersection(long start1, long end1, long start2, long end2, long lower, long upper, IntPtr t1, IntPtr t2)
            => SafeExecution<int>(() => MEOSExternalFunctions.tgeogpointsegm_intersection(start1, end1, start2, end2, lower, upper, t1, t2));

        public static bool geopoint_collinear(long value1, long value2, long value3, double ratio, bool hasz, bool geodetic)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geopoint_collinear(value1, value2, value3, ratio, hasz, geodetic));

        public static IntPtr lwpointarr_remove_duplicates(IntPtr points, int count, IntPtr newcount)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.lwpointarr_remove_duplicates(points, count, newcount));

        public static IntPtr lwpointarr_make_trajectory(IntPtr points, int count, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.lwpointarr_make_trajectory(points, count, interp));

        public static IntPtr lwline_make(long value1, long value2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.lwline_make(value1, value2));

        public static IntPtr lwcoll_from_points_lines(IntPtr points, IntPtr lines, int npoints, int nlines)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.lwcoll_from_points_lines(points, lines, npoints, nlines));

        public static int tpointseq_stops_iter(IntPtr seq, double maxdist, int mintunits, IntPtr result)
            => SafeExecution<int>(() => MEOSExternalFunctions.tpointseq_stops_iter(seq, maxdist, mintunits, result));

        public static long datum_geom_contains(long geom1, long geom2)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_geom_contains(geom1, geom2));

        public static long datum_geom_covers(long geom1, long geom2)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_geom_covers(geom1, geom2));

        public static long datum_geom_disjoint2d(long geom1, long geom2)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_geom_disjoint2d(geom1, geom2));

        public static long datum_geom_disjoint3d(long geom1, long geom2)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_geom_disjoint3d(geom1, geom2));

        public static long datum_geog_disjoint(long geog1, long geog2)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_geog_disjoint(geog1, geog2));

        public static long datum_geom_intersects2d(long geom1, long geom2)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_geom_intersects2d(geom1, geom2));

        public static long datum_geom_intersects3d(long geom1, long geom2)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_geom_intersects3d(geom1, geom2));

        public static long datum_geog_intersects(long geog1, long geog2)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_geog_intersects(geog1, geog2));

        public static long datum_geom_touches(long geom1, long geom2)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_geom_touches(geom1, geom2));

        public static long datum_geom_dwithin2d(long geom1, long geom2, long dist)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_geom_dwithin2d(geom1, geom2, dist));

        public static long datum_geom_dwithin3d(long geom1, long geom2, long dist)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_geom_dwithin3d(geom1, geom2, dist));

        public static long datum_geog_dwithin(long geog1, long geog2, long dist)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_geog_dwithin(geog1, geog2, dist));

        public static long datum_geom_relate_pattern(long geog1, long geog2, long p)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_geom_relate_pattern(geog1, geog2, p));

        public static IntPtr geo_disjoint_fn(short flags1, short flags2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_disjoint_fn(flags1, flags2));

        public static IntPtr geo_disjoint_fn_geo(short flags1, IntPtr flags2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_disjoint_fn_geo(flags1, flags2));

        public static IntPtr geo_intersects_fn(short flags1, short flags2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_intersects_fn(flags1, flags2));

        public static IntPtr geo_intersects_fn_geo(short flags1, IntPtr flags2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_intersects_fn_geo(flags1, flags2));

        public static IntPtr geo_dwithin_fn(short flags1, short flags2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_dwithin_fn(flags1, flags2));

        public static IntPtr geo_dwithin_fn_geo(short flags1, IntPtr flags2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_dwithin_fn_geo(flags1, flags2));

        public static int tpointsegm_tdwithin_turnpt(long start1, long end1, long start2, long end2, long value, long lower, long upper, IntPtr t1, IntPtr t2)
            => SafeExecution<int>(() => MEOSExternalFunctions.tpointsegm_tdwithin_turnpt(start1, end1, start2, end2, value, lower, upper, t1, t2));

        public static int spatialrel_geo_geo(IntPtr gs1, IntPtr gs2, long param, IntPtr func, int numparam, bool invert)
            => SafeExecution<int>(() => MEOSExternalFunctions.spatialrel_geo_geo(gs1, gs2, param, func, numparam, invert));

        public static int spatialrel_tgeo_tgeo(IntPtr temp1, IntPtr temp2, long param, IntPtr func, int numparam)
            => SafeExecution<int>(() => MEOSExternalFunctions.spatialrel_tgeo_tgeo(temp1, temp2, param, func, numparam));

        public static int ea_contains_geo_tgeo(IntPtr gs, IntPtr temp, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_contains_geo_tgeo(gs, temp, ever));

        public static int ea_contains_tgeo_geo(IntPtr temp, IntPtr gs, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_contains_tgeo_geo(temp, gs, ever));

        public static int ea_contains_tgeo_tgeo(IntPtr temp, IntPtr temp2, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_contains_tgeo_tgeo(temp, temp2, ever));

        public static int ea_covers_geo_tgeo(IntPtr gs, IntPtr temp, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_covers_geo_tgeo(gs, temp, ever));

        public static int ea_covers_tgeo_geo(IntPtr temp, IntPtr gs, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_covers_tgeo_geo(temp, gs, ever));

        public static int ea_covers_tgeo_tgeo(IntPtr temp, IntPtr temp2, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_covers_tgeo_tgeo(temp, temp2, ever));

        public static int ea_disjoint_geo_tgeo(IntPtr gs, IntPtr temp, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_disjoint_geo_tgeo(gs, temp, ever));

        public static int ea_disjoint_tgeo_geo(IntPtr temp, IntPtr gs, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_disjoint_tgeo_geo(temp, gs, ever));

        public static int ea_disjoint_tgeo_tgeo(IntPtr temp, IntPtr temp2, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_disjoint_tgeo_tgeo(temp, temp2, ever));

        public static int ea_intersects_geo_tgeo(IntPtr gs, IntPtr temp, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_intersects_geo_tgeo(gs, temp, ever));

        public static int ea_intersects_tgeo_geo(IntPtr temp, IntPtr gs, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_intersects_tgeo_geo(temp, gs, ever));

        public static int ea_intersects_tgeo_tgeo(IntPtr temp, IntPtr temp2, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_intersects_tgeo_tgeo(temp, temp2, ever));

        public static int ea_touches_tpoint_geo(IntPtr temp, IntPtr gs, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_touches_tpoint_geo(temp, gs, ever));

        public static int ea_touches_tgeo_geo(IntPtr temp, IntPtr gs, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_touches_tgeo_geo(temp, gs, ever));

        public static int ea_touches_tgeo_tgeo(IntPtr temp, IntPtr temp2, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_touches_tgeo_tgeo(temp, temp2, ever));

        public static int ea_dwithin_tgeo_geo(IntPtr temp, IntPtr gs, double dist, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_dwithin_tgeo_geo(temp, gs, dist, ever));

        public static int ea_dwithin_tgeo_tgeo(IntPtr temp1, IntPtr temp2, double dist, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_dwithin_tgeo_tgeo(temp1, temp2, dist, ever));

        public static int ea_spatialrel_tspatial_geo(IntPtr temp, IntPtr gs, IntPtr func, bool ever, bool invert)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_spatialrel_tspatial_geo(temp, gs, func, ever, invert));

        public static int ea_spatialrel_tspatial_tspatial(IntPtr temp1, IntPtr temp2, IntPtr func, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_spatialrel_tspatial_tspatial(temp1, temp2, func, ever));

        public static IntPtr tspatialrel_tspatial_base(IntPtr temp, long @base, long param, IntPtr func, int numparam, bool invert)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tspatialrel_tspatial_base(temp, @base, param, func, numparam, invert));

        public static IntPtr tspatialrel_tspatial_tspatial(IntPtr temp1, IntPtr temp2, long param, IntPtr func, int numparam, bool invert)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tspatialrel_tspatial_tspatial(temp1, temp2, param, func, numparam, invert));

        public static IntPtr tinterrel_tgeo_geo(IntPtr temp, IntPtr gs, bool tinter)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinterrel_tgeo_geo(temp, gs, tinter));

        public static IntPtr tinterrel_tspatial_base(IntPtr temp, long @base, bool tinter, IntPtr func)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinterrel_tspatial_base(temp, @base, tinter, func));

        public static IntPtr tinterrel_tspatial_tspatial(IntPtr temp1, IntPtr temp2, bool tinter)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinterrel_tspatial_tspatial(temp1, temp2, tinter));

        public static IntPtr tdwithin_tspatial_tspatial(IntPtr sync1, IntPtr sync2, long dist, IntPtr func, IntPtr tpfn)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdwithin_tspatial_tspatial(sync1, sync2, dist, func, tpfn));

        public static int tdwithin_add_solutions(int solutions, long lower, long upper, bool lower_inc, bool upper_inc, bool upper_inc1, long t1, long t2, IntPtr instants, IntPtr result)
            => SafeExecution<int>(() => MEOSExternalFunctions.tdwithin_add_solutions(solutions, lower, upper, lower_inc, upper_inc, upper_inc1, t1, t2, instants, result));

        public static IntPtr tdwithin_tspatial_spatial(IntPtr temp, long @base, long dist, IntPtr func, IntPtr tpfn)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdwithin_tspatial_spatial(temp, @base, dist, func, tpfn));

        public static IntPtr bitmatrix_make(IntPtr count, int ndims)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bitmatrix_make(count, ndims));

        public static int tpoint_set_tiles(IntPtr temp, IntPtr state, IntPtr bm)
            => SafeExecution<int>(() => MEOSExternalFunctions.tpoint_set_tiles(temp, state, bm));

        public static IntPtr tpoint_at_tile(IntPtr temp, IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_at_tile(temp, box));

        public static void stbox_tile_state_set(double x, double y, double z, long t, double xsize, double ysize, double zsize, IntPtr tunits, bool hasx, bool hasz, bool hast, int srid, IntPtr result)
            => SafeExecution(() => MEOSExternalFunctions.stbox_tile_state_set(x, y, z, t, xsize, ysize, zsize, tunits, hasx, hasz, hast, srid, result));

        public static IntPtr stbox_tile_state_make(IntPtr temp, IntPtr box, double xsize, double ysize, double zsize, IntPtr duration, int sorigin, long torigin, bool border_inc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_tile_state_make(temp, box, xsize, ysize, zsize, duration, sorigin, torigin, border_inc));

        public static void stbox_tile_state_next(IntPtr state)
            => SafeExecution(() => MEOSExternalFunctions.stbox_tile_state_next(state));

        public static bool stbox_tile_state_get(IntPtr state, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_tile_state_get(state, box));

        public static IntPtr tgeo_space_time_tile_init(IntPtr temp, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, long torigin, bool bitmatrix, bool border_inc, IntPtr ntiles)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeo_space_time_tile_init(temp, xsize, ysize, zsize, duration, sorigin, torigin, bitmatrix, border_inc, ntiles));

        public static IntPtr stbox_space_time_tile(IntPtr point, long t, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, long torigin, bool hasx, bool hast)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_space_time_tile(point, t, xsize, ysize, zsize, duration, sorigin, torigin, hasx, hast));

        public static IntPtr create_trip(IntPtr lines, IntPtr maxSpeeds, IntPtr categories, uint noEdges, long startTime, bool disturbData, int verbosity)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.create_trip(lines, maxSpeeds, categories, noEdges, startTime, disturbData, verbosity));

        public static IntPtr spatialarr_wkt_out(IntPtr spatialarr, int basetype, int count, int maxdd, bool extended)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spatialarr_wkt_out(spatialarr, basetype, count, maxdd, extended));

        public static string spatialbase_as_text(long value, int type, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.spatialbase_as_text(value, type, maxdd));

        public static string spatialbase_as_ewkt(long value, int type, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.spatialbase_as_ewkt(value, type, maxdd));

        public static bool point_transf_pj(IntPtr gs, int srid_to, IntPtr pj)
            => SafeExecution<bool>(() => MEOSExternalFunctions.point_transf_pj(gs, srid_to, pj));

        public static void tgeoinst_set_stbox(IntPtr inst, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tgeoinst_set_stbox(inst, box));

        public static void tgeoinstarr_set_stbox(IntPtr instants, int count, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tgeoinstarr_set_stbox(instants, count, box));

        public static void tgeoseq_expand_stbox(IntPtr seq, IntPtr inst)
            => SafeExecution(() => MEOSExternalFunctions.tgeoseq_expand_stbox(seq, inst));

        public static void tspatialinst_set_stbox(IntPtr inst, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tspatialinst_set_stbox(inst, box));

        public static void tspatialinstarr_set_stbox(IntPtr instants, int count, bool lower_inc, bool upper_inc, int interp, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tspatialinstarr_set_stbox(instants, count, lower_inc, upper_inc, interp, box));

        public static void tspatialseqarr_set_stbox(IntPtr sequences, int count, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tspatialseqarr_set_stbox(sequences, count, box));

        public static void tspatialseq_expand_stbox(IntPtr seq, IntPtr inst)
            => SafeExecution(() => MEOSExternalFunctions.tspatialseq_expand_stbox(seq, inst));

        public static void spatialarr_set_bbox(IntPtr values, int basetype, int count, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.spatialarr_set_bbox(values, basetype, count, box));

        public static bool boxop_tspatial_stbox(IntPtr temp, IntPtr box, IntPtr @bool, bool invert)
            => SafeExecution<bool>(() => MEOSExternalFunctions.boxop_tspatial_stbox(temp, box, @bool, invert));

        public static bool boxop_tspatial_tspatial(IntPtr temp1, IntPtr temp2, IntPtr @bool)
            => SafeExecution<bool>(() => MEOSExternalFunctions.boxop_tspatial_tspatial(temp1, temp2, @bool));

        public static bool srid_parse(IntPtr str, IntPtr srid)
            => SafeExecution<bool>(() => MEOSExternalFunctions.srid_parse(str, srid));

        public static bool spatial_parse_elem(IntPtr str, int temptype, byte delim, IntPtr temp_srid, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.spatial_parse_elem(str, temptype, delim, temp_srid, result));

        public static bool geo_parse(IntPtr str, int basetype, byte delim, IntPtr srid, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geo_parse(str, basetype, delim, srid, result));

        public static IntPtr stbox_parse_dims(IntPtr str, bool geodetic, int srid, string type_str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_parse_dims(str, geodetic, srid, type_str));

        public static IntPtr stbox_parse(IntPtr str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_parse(str));

        public static IntPtr tpoint_parse(IntPtr str, int temptype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_parse(str, temptype));

        public static IntPtr tspatialinst_parse(IntPtr str, int temptype, bool end, IntPtr temp_srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tspatialinst_parse(str, temptype, end, temp_srid));

        public static IntPtr tspatialseq_disc_parse(IntPtr str, int temptype, IntPtr temp_srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tspatialseq_disc_parse(str, temptype, temp_srid));

        public static IntPtr tspatialseq_cont_parse(IntPtr str, int temptype, int interp, bool end, IntPtr temp_srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tspatialseq_cont_parse(str, temptype, interp, end, temp_srid));

        public static IntPtr tspatialseqset_parse(IntPtr str, int temptype, int interp, IntPtr temp_srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tspatialseqset_parse(str, temptype, interp, temp_srid));

        public static IntPtr tspatial_parse(IntPtr str, int temptype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tspatial_parse(str, temptype));

        public static bool h3_are_neighbor_cells_meos(IntPtr origin, IntPtr destination)
            => SafeExecution<bool>(() => MEOSExternalFunctions.h3_are_neighbor_cells_meos(origin, destination));

        public static IntPtr h3_cells_to_directed_edge_meos(IntPtr origin, IntPtr destination)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_cells_to_directed_edge_meos(origin, destination));

        public static bool h3_is_valid_directed_edge_meos(IntPtr edge)
            => SafeExecution<bool>(() => MEOSExternalFunctions.h3_is_valid_directed_edge_meos(edge));

        public static IntPtr h3_get_directed_edge_origin_meos(IntPtr edge)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_get_directed_edge_origin_meos(edge));

        public static IntPtr h3_get_directed_edge_destination_meos(IntPtr edge)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_get_directed_edge_destination_meos(edge));

        public static IntPtr h3_cell_to_parent_meos(IntPtr origin, int resolution)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_cell_to_parent_meos(origin, resolution));

        public static IntPtr h3_cell_to_center_child_meos(IntPtr origin, int resolution)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_cell_to_center_child_meos(origin, resolution));

        public static IntPtr h3_cell_to_child_pos_meos(IntPtr child, int parentRes)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_cell_to_child_pos_meos(child, parentRes));

        public static IntPtr h3_child_pos_to_cell_meos(IntPtr childPos, IntPtr parent, int childRes)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_child_pos_to_cell_meos(childPos, parent, childRes));

        public static int h3_get_resolution_meos(IntPtr hex)
            => SafeExecution<int>(() => MEOSExternalFunctions.h3_get_resolution_meos(hex));

        public static int h3_get_base_cell_number_meos(IntPtr hex)
            => SafeExecution<int>(() => MEOSExternalFunctions.h3_get_base_cell_number_meos(hex));

        public static bool h3_is_valid_cell_meos(IntPtr hex)
            => SafeExecution<bool>(() => MEOSExternalFunctions.h3_is_valid_cell_meos(hex));

        public static bool h3_is_res_class_iii_meos(IntPtr hex)
            => SafeExecution<bool>(() => MEOSExternalFunctions.h3_is_res_class_iii_meos(hex));

        public static bool h3_is_pentagon_meos(IntPtr hex)
            => SafeExecution<bool>(() => MEOSExternalFunctions.h3_is_pentagon_meos(hex));

        public static IntPtr h3_get_num_cells_meos(int resolution)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_get_num_cells_meos(resolution));

        public static IntPtr h3_grid_distance_meos(IntPtr originIndex, IntPtr h3Index)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_grid_distance_meos(originIndex, h3Index));

        public static IntPtr h3_cell_to_vertex_meos(IntPtr cell, int vertexNum)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_cell_to_vertex_meos(cell, vertexNum));

        public static bool h3_is_valid_vertex_meos(IntPtr vertex)
            => SafeExecution<bool>(() => MEOSExternalFunctions.h3_is_valid_vertex_meos(vertex));

        public static IntPtr h3index_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3index_in(str));

        public static string h3index_out(IntPtr cell)
            => SafeExecution<string>(() => MEOSExternalFunctions.h3index_out(cell));

        public static bool h3index_eq(IntPtr a, IntPtr b)
            => SafeExecution<bool>(() => MEOSExternalFunctions.h3index_eq(a, b));

        public static bool h3index_ne(IntPtr a, IntPtr b)
            => SafeExecution<bool>(() => MEOSExternalFunctions.h3index_ne(a, b));

        public static bool h3index_lt(IntPtr a, IntPtr b)
            => SafeExecution<bool>(() => MEOSExternalFunctions.h3index_lt(a, b));

        public static bool h3index_le(IntPtr a, IntPtr b)
            => SafeExecution<bool>(() => MEOSExternalFunctions.h3index_le(a, b));

        public static bool h3index_gt(IntPtr a, IntPtr b)
            => SafeExecution<bool>(() => MEOSExternalFunctions.h3index_gt(a, b));

        public static bool h3index_ge(IntPtr a, IntPtr b)
            => SafeExecution<bool>(() => MEOSExternalFunctions.h3index_ge(a, b));

        public static int h3index_cmp(IntPtr a, IntPtr b)
            => SafeExecution<int>(() => MEOSExternalFunctions.h3index_cmp(a, b));

        public static int h3index_hash(IntPtr cell)
            => SafeExecution<int>(() => MEOSExternalFunctions.h3index_hash(cell));

        public static IntPtr h3_grid_disk(IntPtr origin, int k)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_grid_disk(origin, k));

        public static IntPtr h3_grid_ring(IntPtr origin, int k)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_grid_ring(origin, k));

        public static IntPtr h3_grid_path_cells(IntPtr start, IntPtr end)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_grid_path_cells(start, end));

        public static IntPtr h3_cell_to_children(IntPtr origin, int childRes)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_cell_to_children(origin, childRes));

        public static IntPtr h3_compact_cells(IntPtr cells)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_compact_cells(cells));

        public static IntPtr h3_uncompact_cells(IntPtr cells, int res)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_uncompact_cells(cells, res));

        public static IntPtr h3_origin_to_directed_edges(IntPtr origin)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_origin_to_directed_edges(origin));

        public static IntPtr h3_cell_to_vertexes(IntPtr cell)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_cell_to_vertexes(cell));

        public static IntPtr h3_get_icosahedron_faces(IntPtr cell)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_get_icosahedron_faces(cell));

        public static int ensure_valid_th3index_th3index(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.ensure_valid_th3index_th3index(temp1, temp2));

        public static bool ensure_valid_th3index_h3index(IntPtr temp, IntPtr cell)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_th3index_h3index(temp, cell));

        public static bool ensure_valid_th3index_tgeogpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_th3index_tgeogpoint(temp1, temp2));

        public static long datum2_h3index_eq(long d1, long d2, int type)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum2_h3index_eq(d1, d2, type));

        public static long datum2_h3index_ne(long d1, long d2, int type)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum2_h3index_ne(d1, d2, type));

        public static bool h3index_set_stbox(IntPtr cell, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.h3index_set_stbox(cell, box));

        public static void h3indexarr_set_stbox(IntPtr values, int count, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.h3indexarr_set_stbox(values, count, box));

        public static void th3indexinst_set_stbox(IntPtr inst, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.th3indexinst_set_stbox(inst, box));

        public static void th3indexinstarr_set_stbox(IntPtr instants, int count, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.th3indexinstarr_set_stbox(instants, count, box));

        public static void th3indexseq_expand_stbox(IntPtr seq, IntPtr inst)
            => SafeExecution(() => MEOSExternalFunctions.th3indexseq_expand_stbox(seq, inst));

        public static IntPtr h3_gs_point_to_cell(IntPtr point, int resolution)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_gs_point_to_cell(point, resolution));

        public static IntPtr h3_cell_to_gs_point(IntPtr cell)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_cell_to_gs_point(cell));

        public static IntPtr h3_cell_to_gs_boundary(IntPtr cell)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_cell_to_gs_boundary(cell));

        public static IntPtr cell_boundary_to_gs(IntPtr bnd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cell_boundary_to_gs(bnd));

        public static double h3_sample_step_deg(int resolution)
            => SafeExecution<double>(() => MEOSExternalFunctions.h3_sample_step_deg(resolution));

        public static IntPtr h3_latlng_deg_to_cell(double lat_deg, double lng_deg, int resolution)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_latlng_deg_to_cell(lat_deg, lng_deg, resolution));

        public static IntPtr h3_cell_to_parent_next_meos(IntPtr cell)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_cell_to_parent_next_meos(cell));

        public static IntPtr h3_cell_to_center_child_next_meos(IntPtr cell)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_cell_to_center_child_next_meos(cell));

        public static IntPtr h3_directed_edge_to_gs_boundary(IntPtr edge)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_directed_edge_to_gs_boundary(edge));

        public static IntPtr h3_vertex_to_gs_point(IntPtr vertex)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_vertex_to_gs_point(vertex));

        public static IntPtr h3_cell_to_local_ij_meos(IntPtr origin, IntPtr cell)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_cell_to_local_ij_meos(origin, cell));

        public static IntPtr h3_local_ij_to_cell_meos(IntPtr origin, IntPtr coord)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_local_ij_to_cell_meos(origin, coord));

        public static IntPtr h3_unit_from_cstring(string unit)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3_unit_from_cstring(unit));

        public static double h3_cell_area_meos(IntPtr cell, IntPtr unit)
            => SafeExecution<double>(() => MEOSExternalFunctions.h3_cell_area_meos(cell, unit));

        public static double h3_edge_length_meos(IntPtr edge, IntPtr unit)
            => SafeExecution<double>(() => MEOSExternalFunctions.h3_edge_length_meos(edge, unit));

        public static double h3_gs_great_circle_distance_meos(IntPtr a, IntPtr b, IntPtr unit)
            => SafeExecution<double>(() => MEOSExternalFunctions.h3_gs_great_circle_distance_meos(a, b, unit));

        public static long datum_h3_get_resolution(long d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_get_resolution(d));

        public static long datum_h3_get_base_cell_number(long d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_get_base_cell_number(d));

        public static long datum_h3_is_valid_cell(long d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_is_valid_cell(d));

        public static long datum_h3_is_res_class_iii(long d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_is_res_class_iii(d));

        public static long datum_h3_is_pentagon(long d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_is_pentagon(d));

        public static long datum_h3_cell_to_parent(long cell_d, long res_d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_cell_to_parent(cell_d, res_d));

        public static long datum_h3_cell_to_parent_next(long cell_d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_cell_to_parent_next(cell_d));

        public static long datum_h3_cell_to_center_child(long cell_d, long res_d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_cell_to_center_child(cell_d, res_d));

        public static long datum_h3_cell_to_center_child_next(long cell_d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_cell_to_center_child_next(cell_d));

        public static long datum_h3_cell_to_child_pos(long cell_d, long parent_res_d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_cell_to_child_pos(cell_d, parent_res_d));

        public static long datum_h3_child_pos_to_cell(long pos_d, long parent_d, long child_res_d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_child_pos_to_cell(pos_d, parent_d, child_res_d));

        public static long datum_h3_are_neighbor_cells(long origin_d, long dest_d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_are_neighbor_cells(origin_d, dest_d));

        public static long datum_h3_cells_to_directed_edge(long origin_d, long dest_d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_cells_to_directed_edge(origin_d, dest_d));

        public static long datum_h3_is_valid_directed_edge(long d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_is_valid_directed_edge(d));

        public static long datum_h3_get_directed_edge_origin(long d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_get_directed_edge_origin(d));

        public static long datum_h3_get_directed_edge_destination(long d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_get_directed_edge_destination(d));

        public static long datum_h3_directed_edge_to_boundary(long d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_directed_edge_to_boundary(d));

        public static long datum_h3_cell_to_vertex(long cell_d, long vnum_d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_cell_to_vertex(cell_d, vnum_d));

        public static long datum_h3_vertex_to_latlng(long d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_vertex_to_latlng(d));

        public static long datum_h3_is_valid_vertex(long d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_is_valid_vertex(d));

        public static long datum_h3_grid_distance(long origin_d, long dest_d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_grid_distance(origin_d, dest_d));

        public static long datum_h3_cell_to_local_ij(long origin_d, long cell_d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_cell_to_local_ij(origin_d, cell_d));

        public static long datum_h3_local_ij_to_cell(long origin_d, long coord_d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_local_ij_to_cell(origin_d, coord_d));

        public static long datum_h3_latlng_to_cell(long point_d, long res_d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_latlng_to_cell(point_d, res_d));

        public static long datum_h3_cell_to_latlng(long d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_cell_to_latlng(d));

        public static long datum_h3_cell_to_boundary(long d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_cell_to_boundary(d));

        public static long datum_h3_cell_area(long cell_d, long unit_d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_cell_area(cell_d, unit_d));

        public static long datum_h3_edge_length(long edge_d, long unit_d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_edge_length(edge_d, unit_d));

        public static long datum_h3_great_circle_distance(long a_d, long b_d, long unit_d)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_h3_great_circle_distance(a_d, b_d, unit_d));

        public static IntPtr json_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.json_in(str));

        public static string json_out(IntPtr js)
            => SafeExecution<string>(() => MEOSExternalFunctions.json_out(js));

        public static IntPtr jsonb_from_text(IntPtr txt, bool unique_keys)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_from_text(txt, unique_keys));

        public static IntPtr jsonb_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_in(str));

        public static string jsonb_out(IntPtr jb)
            => SafeExecution<string>(() => MEOSExternalFunctions.jsonb_out(jb));

        public static IntPtr json_make(IntPtr keys_vals, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.json_make(keys_vals, count));

        public static IntPtr json_make_two_arg(IntPtr keys, IntPtr values, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.json_make_two_arg(keys, values, count));

        public static IntPtr jsonb_copy(IntPtr jb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_copy(jb));

        public static IntPtr jsonb_make(IntPtr keys_vals, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_make(keys_vals, count));

        public static IntPtr jsonb_make_two_arg(IntPtr keys, IntPtr values, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_make_two_arg(keys, values, count));

        public static bool jsonb_to_bool(IntPtr jb)
            => SafeExecution<bool>(() => MEOSExternalFunctions.jsonb_to_bool(jb));

        public static string jsonb_to_cstring(IntPtr jb)
            => SafeExecution<string>(() => MEOSExternalFunctions.jsonb_to_cstring(jb));

        public static int jsonb_to_float4(IntPtr jb)
            => SafeExecution<int>(() => MEOSExternalFunctions.jsonb_to_float4(jb));

        public static int jsonb_to_float8(IntPtr jb)
            => SafeExecution<int>(() => MEOSExternalFunctions.jsonb_to_float8(jb));

        public static short jsonb_to_int16(IntPtr jb)
            => SafeExecution<short>(() => MEOSExternalFunctions.jsonb_to_int16(jb));

        public static int jsonb_to_int32(IntPtr jb)
            => SafeExecution<int>(() => MEOSExternalFunctions.jsonb_to_int32(jb));

        public static IntPtr jsonb_to_int64(IntPtr jb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_to_int64(jb));

        public static int jsonb_to_numeric(IntPtr jb)
            => SafeExecution<int>(() => MEOSExternalFunctions.jsonb_to_numeric(jb));

        public static IntPtr jsonb_to_text(IntPtr jb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_to_text(jb));

        public static IntPtr json_array_element(IntPtr js, int element)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.json_array_element(js, element));

        public static IntPtr json_array_element_text(IntPtr js, int element)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.json_array_element_text(js, element));

        public static IntPtr[] json_array_elements(IntPtr js)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.json_array_elements(js, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] json_array_elements_text(IntPtr js)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.json_array_elements_text(js, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int json_array_length(IntPtr js)
            => SafeExecution<int>(() => MEOSExternalFunctions.json_array_length(js));

        public static (IntPtr[], IntPtr[]) json_each(IntPtr js)
        {
            IntPtr _out_values = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => MEOSExternalFunctions.json_each(js, _out_values, _count_count));
                int _n = Marshal.ReadInt32(_count_count);
                IntPtr[] _resultArr = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _resultArr[_i] = Marshal.ReadIntPtr(_resultPtr, _i * IntPtr.Size); }
                IntPtr __out_values_arr = Marshal.ReadIntPtr(_out_values);
                IntPtr[] __out_values_out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { __out_values_out[_i] = Marshal.ReadIntPtr(__out_values_arr, _i * IntPtr.Size); }
                return (_resultArr, __out_values_out);
            }
            finally
            {
            Marshal.FreeHGlobal(_out_values);
            Marshal.FreeHGlobal(_count_count);
            }
        }

        public static (IntPtr[], IntPtr[]) json_each_text(IntPtr js)
        {
            IntPtr _out_values = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => MEOSExternalFunctions.json_each_text(js, _out_values, _count_count));
                int _n = Marshal.ReadInt32(_count_count);
                IntPtr[] _resultArr = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _resultArr[_i] = Marshal.ReadIntPtr(_resultPtr, _i * IntPtr.Size); }
                IntPtr __out_values_arr = Marshal.ReadIntPtr(_out_values);
                IntPtr[] __out_values_out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { __out_values_out[_i] = Marshal.ReadIntPtr(__out_values_arr, _i * IntPtr.Size); }
                return (_resultArr, __out_values_out);
            }
            finally
            {
            Marshal.FreeHGlobal(_out_values);
            Marshal.FreeHGlobal(_count_count);
            }
        }

        public static IntPtr json_extract_path(IntPtr js, IntPtr path_elems, int path_len)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.json_extract_path(js, path_elems, path_len));

        public static IntPtr json_extract_path_text(IntPtr js, IntPtr path_elems, int path_len)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.json_extract_path_text(js, path_elems, path_len));

        public static IntPtr json_object_field(IntPtr js, IntPtr key)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.json_object_field(js, key));

        public static IntPtr json_object_field_text(IntPtr js, IntPtr key)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.json_object_field_text(js, key));

        public static IntPtr[] json_object_keys(IntPtr js)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.json_object_keys(js, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr json_typeof(IntPtr js)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.json_typeof(js));

        public static IntPtr jsonb_array_element(IntPtr jb, int element)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_array_element(jb, element));

        public static IntPtr jsonb_array_element_text(IntPtr jb, int element)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_array_element_text(jb, element));

        public static IntPtr[] jsonb_array_elements(IntPtr jb)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_array_elements(jb, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] jsonb_array_elements_text(IntPtr jb)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_array_elements_text(jb, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int jsonb_array_length(IntPtr jb)
            => SafeExecution<int>(() => MEOSExternalFunctions.jsonb_array_length(jb));

        public static bool jsonb_contained(IntPtr jb1, IntPtr jb2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.jsonb_contained(jb1, jb2));

        public static bool jsonb_contains(IntPtr jb1, IntPtr jb2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.jsonb_contains(jb1, jb2));

        public static (IntPtr[], IntPtr[]) jsonb_each(IntPtr jb)
        {
            IntPtr _out_values = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_each(jb, _out_values, _count_count));
                int _n = Marshal.ReadInt32(_count_count);
                IntPtr[] _resultArr = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _resultArr[_i] = Marshal.ReadIntPtr(_resultPtr, _i * IntPtr.Size); }
                IntPtr __out_values_arr = Marshal.ReadIntPtr(_out_values);
                IntPtr[] __out_values_out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { __out_values_out[_i] = Marshal.ReadIntPtr(__out_values_arr, _i * IntPtr.Size); }
                return (_resultArr, __out_values_out);
            }
            finally
            {
            Marshal.FreeHGlobal(_out_values);
            Marshal.FreeHGlobal(_count_count);
            }
        }

        public static (IntPtr[], IntPtr[]) jsonb_each_text(IntPtr jb)
        {
            IntPtr _out_values = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_each_text(jb, _out_values, _count_count));
                int _n = Marshal.ReadInt32(_count_count);
                IntPtr[] _resultArr = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _resultArr[_i] = Marshal.ReadIntPtr(_resultPtr, _i * IntPtr.Size); }
                IntPtr __out_values_arr = Marshal.ReadIntPtr(_out_values);
                IntPtr[] __out_values_out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { __out_values_out[_i] = Marshal.ReadIntPtr(__out_values_arr, _i * IntPtr.Size); }
                return (_resultArr, __out_values_out);
            }
            finally
            {
            Marshal.FreeHGlobal(_out_values);
            Marshal.FreeHGlobal(_count_count);
            }
        }

        public static bool jsonb_exists(IntPtr jb, IntPtr key)
            => SafeExecution<bool>(() => MEOSExternalFunctions.jsonb_exists(jb, key));

        public static bool jsonb_exists_array(IntPtr jb, IntPtr keys_elems, int keys_len, bool any)
            => SafeExecution<bool>(() => MEOSExternalFunctions.jsonb_exists_array(jb, keys_elems, keys_len, any));

        public static IntPtr jsonb_extract_path(IntPtr jb, IntPtr path_elems, int path_len)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_extract_path(jb, path_elems, path_len));

        public static IntPtr jsonb_extract_path_text(IntPtr jb, IntPtr path_elems, int path_len)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_extract_path_text(jb, path_elems, path_len));

        public static int jsonb_hash(IntPtr jb)
            => SafeExecution<int>(() => MEOSExternalFunctions.jsonb_hash(jb));

        public static IntPtr jsonb_hash_extended(IntPtr jb, IntPtr seed)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_hash_extended(jb, seed));

        public static IntPtr jsonb_object_field(IntPtr jb, IntPtr key)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_object_field(jb, key));

        public static IntPtr jsonb_object_field_text(IntPtr jb, IntPtr key)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_object_field_text(jb, key));

        public static IntPtr[] jsonb_object_keys(IntPtr jb)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_object_keys(jb, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr json_strip_nulls(IntPtr js, bool strip_in_arrays)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.json_strip_nulls(js, strip_in_arrays));

        public static IntPtr jsonb_concat(IntPtr jb1, IntPtr jb2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_concat(jb1, jb2));

        public static IntPtr jsonb_delete(IntPtr jb, IntPtr key)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_delete(jb, key));

        public static IntPtr jsonb_delete_array(IntPtr jb, IntPtr keys_elems, int keys_len)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_delete_array(jb, keys_elems, keys_len));

        public static IntPtr jsonb_delete_index(IntPtr jb, int idx)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_delete_index(jb, idx));

        public static IntPtr jsonb_delete_path(IntPtr jb, IntPtr path_elems, int path_len)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_delete_path(jb, path_elems, path_len));

        public static IntPtr jsonb_insert(IntPtr jb, IntPtr path_elems, int path_len, IntPtr newjb, bool after)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_insert(jb, path_elems, path_len, newjb, after));

        public static IntPtr jsonb_pretty(IntPtr jb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_pretty(jb));

        public static IntPtr jsonb_set(IntPtr jb, IntPtr path_elems, int path_len, IntPtr newjb, bool create)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_set(jb, path_elems, path_len, newjb, create));

        public static IntPtr jsonb_set_lax(IntPtr jb, IntPtr path_elems, int path_len, IntPtr newjb, bool create, IntPtr handle_null)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_set_lax(jb, path_elems, path_len, newjb, create, handle_null));

        public static IntPtr jsonb_strip_nulls(IntPtr jb, bool strip_in_arrays)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_strip_nulls(jb, strip_in_arrays));

        public static int jsonb_cmp(IntPtr jb1, IntPtr jb2)
            => SafeExecution<int>(() => MEOSExternalFunctions.jsonb_cmp(jb1, jb2));

        public static bool jsonb_eq(IntPtr jb1, IntPtr jb2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.jsonb_eq(jb1, jb2));

        public static bool jsonb_ge(IntPtr jb1, IntPtr jb2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.jsonb_ge(jb1, jb2));

        public static bool jsonb_gt(IntPtr jb1, IntPtr jb2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.jsonb_gt(jb1, jb2));

        public static bool jsonb_le(IntPtr jb1, IntPtr jb2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.jsonb_le(jb1, jb2));

        public static bool jsonb_lt(IntPtr jb1, IntPtr jb2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.jsonb_lt(jb1, jb2));

        public static bool jsonb_ne(IntPtr jb1, IntPtr jb2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.jsonb_ne(jb1, jb2));

        public static int jsonb_path_exists(IntPtr jb, IntPtr jp, IntPtr vars, bool silent, bool tz)
            => SafeExecution<int>(() => MEOSExternalFunctions.jsonb_path_exists(jb, jp, vars, silent, tz));

        public static bool jsonb_path_match(IntPtr jb, IntPtr jp, IntPtr vars, bool silent, bool tz)
            => SafeExecution<bool>(() => MEOSExternalFunctions.jsonb_path_match(jb, jp, vars, silent, tz));

        public static IntPtr[] jsonb_path_query_all(IntPtr jb, IntPtr jp, IntPtr vars, bool silent, bool tz)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_path_query_all(jb, jp, vars, silent, tz, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr jsonb_path_query_array(IntPtr jb, IntPtr jp, IntPtr vars, bool silent, bool tz)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_path_query_array(jb, jp, vars, silent, tz));

        public static IntPtr jsonb_path_query_first(IntPtr jb, IntPtr jp, IntPtr vars, bool silent, bool tz)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_path_query_first(jb, jp, vars, silent, tz));

        public static IntPtr jsonpath_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonpath_in(str));

        public static IntPtr jsonpath_copy(IntPtr jp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonpath_copy(jp));

        public static string jsonpath_out(IntPtr jp)
            => SafeExecution<string>(() => MEOSExternalFunctions.jsonpath_out(jp));

        public static IntPtr jsonbset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbset_in(str));

        public static string jsonbset_out(IntPtr s, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.jsonbset_out(s, maxdd));

        public static IntPtr jsonbset_make(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbset_make(values, count));

        public static IntPtr jsonb_to_set(IntPtr jb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_to_set(jb));

        public static IntPtr jsonbset_end_value(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbset_end_value(s));

        public static IntPtr jsonbset_start_value(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbset_start_value(s));

        public static bool jsonbset_value_n(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.jsonbset_value_n(s, n, result));

        public static IntPtr[] jsonbset_values(IntPtr s)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbset_values(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr concat_jsonbset_jsonb(IntPtr s, IntPtr jb, bool invert)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.concat_jsonbset_jsonb(s, jb, invert));

        public static IntPtr jsonbset_array_length(IntPtr set)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbset_array_length(set));

        public static IntPtr jsonbset_object_field(IntPtr set, IntPtr key, bool astext, IntPtr null_handle)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbset_object_field(set, key, astext, null_handle));

        public static IntPtr jsonbset_array_element(IntPtr set, int idx, bool astext, IntPtr null_handle)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbset_array_element(set, idx, astext, null_handle));

        public static IntPtr jsonbset_delete_index(IntPtr set, int idx)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbset_delete_index(set, idx));

        public static IntPtr jsonbset_delete(IntPtr set, IntPtr key)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbset_delete(set, key));

        public static IntPtr jsonbset_delete_array(IntPtr set, IntPtr keys, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbset_delete_array(set, keys, count));

        public static IntPtr jsonbset_exists(IntPtr set, IntPtr key)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbset_exists(set, key));

        public static IntPtr jsonbset_exists_array(IntPtr set, IntPtr keys, int count, bool any)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbset_exists_array(set, keys, count, any));

        public static IntPtr jsonbset_set(IntPtr set, IntPtr keys, int count, IntPtr newjb, bool create, IntPtr null_handle, bool lax)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbset_set(set, keys, count, newjb, create, null_handle, lax));

        public static IntPtr jsonbset_to_alphanumset(IntPtr set, string key, int settype, IntPtr null_handle)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbset_to_alphanumset(set, key, settype, null_handle));

        public static IntPtr jsonbset_to_intset(IntPtr set, string key, IntPtr null_handle)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbset_to_intset(set, key, null_handle));

        public static IntPtr jsonbset_to_floatset(IntPtr set, string key, IntPtr null_handle)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbset_to_floatset(set, key, null_handle));

        public static IntPtr jsonbset_to_textset_key(IntPtr set, string key, IntPtr null_handle)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbset_to_textset_key(set, key, null_handle));

        public static IntPtr jsonbset_strip_nulls(IntPtr set, bool strip_in_arrays)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbset_strip_nulls(set, strip_in_arrays));

        public static IntPtr jsonbset_pretty(IntPtr set)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbset_pretty(set));

        public static IntPtr jsonbset_delete_path(IntPtr set, IntPtr path_elems, int path_len)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbset_delete_path(set, path_elems, path_len));

        public static IntPtr jsonbset_extract_path(IntPtr set, IntPtr path_elems, int path_len, bool astext, IntPtr null_handle)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbset_extract_path(set, path_elems, path_len, astext, null_handle));

        public static IntPtr jsonbset_insert(IntPtr set, IntPtr path_elems, int path_len, IntPtr newjb, bool after)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbset_insert(set, path_elems, path_len, newjb, after));

        public static IntPtr jsonbset_path_exists(IntPtr set, IntPtr jp, IntPtr vars, bool silent, bool tz)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbset_path_exists(set, jp, vars, silent, tz));

        public static IntPtr jsonbset_path_match(IntPtr set, IntPtr jp, IntPtr vars, bool silent, bool tz)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbset_path_match(set, jp, vars, silent, tz));

        public static IntPtr jsonbset_path_query_array(IntPtr set, IntPtr jp, IntPtr vars, bool silent, bool tz)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbset_path_query_array(set, jp, vars, silent, tz));

        public static IntPtr jsonbset_path_query_first(IntPtr set, IntPtr jp, IntPtr vars, bool silent, bool tz)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbset_path_query_first(set, jp, vars, silent, tz));

        public static bool contained_jsonb_set(IntPtr jb, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_jsonb_set(jb, s));

        public static bool contains_set_jsonb(IntPtr s, IntPtr jb)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_set_jsonb(s, jb));

        public static IntPtr intersection_jsonb_set(IntPtr jb, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_jsonb_set(jb, s));

        public static IntPtr intersection_set_jsonb(IntPtr s, IntPtr jb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_set_jsonb(s, jb));

        public static IntPtr jsonb_union_transfn(IntPtr state, IntPtr jb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonb_union_transfn(state, jb));

        public static IntPtr minus_jsonb_set(IntPtr jb, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_jsonb_set(jb, s));

        public static IntPtr minus_set_jsonb(IntPtr s, IntPtr jb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_set_jsonb(s, jb));

        public static IntPtr union_jsonb_set(IntPtr jb, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_jsonb_set(jb, s));

        public static IntPtr union_set_jsonb(IntPtr s, IntPtr jb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_set_jsonb(s, jb));

        public static IntPtr tjsonb_from_mfjson(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_from_mfjson(str));

        public static IntPtr tjsonb_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_in(str));

        public static string tjsonb_out(IntPtr temp)
            => SafeExecution<string>(() => MEOSExternalFunctions.tjsonb_out(temp));

        public static IntPtr tjsonbinst_from_mfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonbinst_from_mfjson(mfjson));

        public static IntPtr tjsonbinst_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonbinst_in(str));

        public static IntPtr tjsonbseq_from_mfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonbseq_from_mfjson(mfjson));

        public static IntPtr tjsonbseq_in(string str, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonbseq_in(str, interp));

        public static IntPtr tjsonbseqset_from_mfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonbseqset_from_mfjson(mfjson));

        public static IntPtr tjsonbseqset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonbseqset_in(str));

        public static IntPtr tjsonb_from_base_temp(IntPtr jsonb, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_from_base_temp(jsonb, temp));

        public static IntPtr tjsonbinst_make(IntPtr jsonb, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonbinst_make(jsonb, t));

        public static IntPtr tjsonbseq_from_base_tstzset(IntPtr jsonb, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonbseq_from_base_tstzset(jsonb, s));

        public static IntPtr tjsonbseq_from_base_tstzspan(IntPtr jsonb, IntPtr sp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonbseq_from_base_tstzspan(jsonb, sp));

        public static IntPtr tjsonbseqset_from_base_tstzspanset(IntPtr jsonb, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonbseqset_from_base_tstzspanset(jsonb, ss));

        public static IntPtr tjsonb_to_ttext(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_to_ttext(temp));

        public static IntPtr ttext_to_tjsonb(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_to_tjsonb(temp));

        public static IntPtr tjsonb_end_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_end_value(temp));

        public static IntPtr tjsonb_start_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_start_value(temp));

        public static bool tjsonb_value_at_timestamptz(IntPtr temp, long t, bool strict, IntPtr value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tjsonb_value_at_timestamptz(temp, t, strict, value));

        public static bool tjsonb_value_n(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tjsonb_value_n(temp, n, result));

        public static IntPtr[] tjsonb_values(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_values(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr concat_tjsonb_jsonb(IntPtr temp, IntPtr jb, bool invert)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.concat_tjsonb_jsonb(temp, jb, invert));

        public static IntPtr concat_tjsonb_tjsonb(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.concat_tjsonb_tjsonb(temp1, temp2));

        public static IntPtr contains_tjsonb_jsonb(IntPtr temp, IntPtr jb, bool invert)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.contains_tjsonb_jsonb(temp, jb, invert));

        public static IntPtr contains_tjsonb_tjsonb(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.contains_tjsonb_tjsonb(temp1, temp2));

        public static IntPtr null_handle_type_from_string(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.null_handle_type_from_string(str));

        public static IntPtr tjson_array_element(IntPtr temp, int idx, IntPtr null_handle)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjson_array_element(temp, idx, null_handle));

        public static IntPtr tjson_array_length(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjson_array_length(temp));

        public static IntPtr tjson_extract_path(IntPtr temp, IntPtr path_elems, int path_len, IntPtr null_handle)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjson_extract_path(temp, path_elems, path_len, null_handle));

        public static IntPtr tjson_object_field(IntPtr temp, IntPtr key, bool astext, IntPtr null_handle)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjson_object_field(temp, key, astext, null_handle));

        public static IntPtr tjson_strip_nulls(IntPtr temp, bool strip_in_arrays)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjson_strip_nulls(temp, strip_in_arrays));

        public static IntPtr tjsonb_array_element(IntPtr temp, int idx, bool astext, IntPtr null_handle)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_array_element(temp, idx, astext, null_handle));

        public static IntPtr tjsonb_array_length(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_array_length(temp));

        public static IntPtr tjsonb_delete(IntPtr temp, IntPtr key)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_delete(temp, key));

        public static IntPtr tjsonb_delete_array(IntPtr temp, IntPtr keys, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_delete_array(temp, keys, count));

        public static IntPtr tjsonb_delete_index(IntPtr temp, int idx)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_delete_index(temp, idx));

        public static IntPtr tjsonb_delete_path(IntPtr temp, IntPtr path_elems, int path_len)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_delete_path(temp, path_elems, path_len));

        public static IntPtr tjsonb_exists(IntPtr temp, IntPtr key)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_exists(temp, key));

        public static IntPtr tjsonb_exists_array(IntPtr temp, IntPtr keys, int count, bool any)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_exists_array(temp, keys, count, any));

        public static IntPtr tjsonb_extract_path(IntPtr temp, IntPtr path_elems, int path_len, bool astext, IntPtr null_handle)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_extract_path(temp, path_elems, path_len, astext, null_handle));

        public static IntPtr tjsonb_insert(IntPtr temp, IntPtr keys, int count, IntPtr newjb, bool after)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_insert(temp, keys, count, newjb, after));

        public static IntPtr tjsonb_object_field(IntPtr temp, IntPtr key, bool astext, IntPtr null_handle)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_object_field(temp, key, astext, null_handle));

        public static IntPtr tjsonb_path_exists(IntPtr temp, IntPtr jp, IntPtr vars, bool silent, bool tz)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_path_exists(temp, jp, vars, silent, tz));

        public static IntPtr tjsonb_path_match(IntPtr temp, IntPtr jp, IntPtr vars, bool silent, bool tz)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_path_match(temp, jp, vars, silent, tz));

        public static IntPtr tjsonb_path_query_array(IntPtr temp, IntPtr jp, IntPtr vars, bool silent, bool tz)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_path_query_array(temp, jp, vars, silent, tz));

        public static IntPtr tjsonb_path_query_first(IntPtr temp, IntPtr jp, IntPtr vars, bool silent, bool tz)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_path_query_first(temp, jp, vars, silent, tz));

        public static IntPtr tjsonb_pretty(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_pretty(temp));

        public static IntPtr tjsonb_set(IntPtr temp, IntPtr keys, int count, IntPtr newjb, bool create, IntPtr handle_null, bool lax)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_set(temp, keys, count, newjb, create, handle_null, lax));

        public static IntPtr tjsonb_strip_nulls(IntPtr temp, bool strip_in_arrays)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_strip_nulls(temp, strip_in_arrays));

        public static IntPtr tjsonb_to_tbool(IntPtr temp, string key, IntPtr null_handle)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_to_tbool(temp, key, null_handle));

        public static IntPtr tjsonb_to_tfloat(IntPtr temp, string key, int interp, IntPtr null_handle)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_to_tfloat(temp, key, interp, null_handle));

        public static IntPtr tjsonb_to_tint(IntPtr temp, string key, IntPtr null_handle)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_to_tint(temp, key, null_handle));

        public static IntPtr tjsonb_to_ttext_key(IntPtr temp, string key, IntPtr null_handle)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_to_ttext_key(temp, key, null_handle));

        public static IntPtr tjsonb_at_value(IntPtr temp, IntPtr jsb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_at_value(temp, jsb));

        public static IntPtr tjsonb_minus_value(IntPtr temp, IntPtr jsb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_minus_value(temp, jsb));

        public static int always_eq_jsonb_tjsonb(IntPtr jb, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_jsonb_tjsonb(jb, temp));

        public static int always_eq_tjsonb_jsonb(IntPtr temp, IntPtr jb)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_tjsonb_jsonb(temp, jb));

        public static int always_eq_tjsonb_tjsonb(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_tjsonb_tjsonb(temp1, temp2));

        public static int always_ne_jsonb_tjsonb(IntPtr jb, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_jsonb_tjsonb(jb, temp));

        public static int always_ne_tjsonb_jsonb(IntPtr temp, IntPtr jb)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_tjsonb_jsonb(temp, jb));

        public static int always_ne_tjsonb_tjsonb(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_tjsonb_tjsonb(temp1, temp2));

        public static int ever_eq_jsonb_tjsonb(IntPtr jb, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_jsonb_tjsonb(jb, temp));

        public static int ever_eq_tjsonb_jsonb(IntPtr temp, IntPtr jb)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_tjsonb_jsonb(temp, jb));

        public static int ever_eq_tjsonb_tjsonb(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_tjsonb_tjsonb(temp1, temp2));

        public static int ever_ne_jsonb_tjsonb(IntPtr jb, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_jsonb_tjsonb(jb, temp));

        public static int ever_ne_tjsonb_jsonb(IntPtr temp, IntPtr jb)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_tjsonb_jsonb(temp, jb));

        public static int ever_ne_tjsonb_tjsonb(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_tjsonb_tjsonb(temp1, temp2));

        public static IntPtr teq_jsonb_tjsonb(IntPtr jb, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_jsonb_tjsonb(jb, temp));

        public static IntPtr teq_tjsonb_jsonb(IntPtr temp, IntPtr jb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_tjsonb_jsonb(temp, jb));

        public static IntPtr tne_jsonb_tjsonb(IntPtr jb, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_jsonb_tjsonb(jb, temp));

        public static IntPtr tne_tjsonb_jsonb(IntPtr temp, IntPtr jb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_tjsonb_jsonb(temp, jb));

        public static IntPtr setPath(IntPtr it, IntPtr path_elems, IntPtr path_nulls, int path_len, IntPtr st, int level, IntPtr newval, int op_type)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.setPath(it, path_elems, path_nulls, path_len, st, level, newval, op_type));

        public static void setPathObject(IntPtr it, IntPtr path_elems, IntPtr path_nulls, int path_len, IntPtr st, int level, IntPtr newval, uint npairs, int op_type)
            => SafeExecution(() => MEOSExternalFunctions.setPathObject(it, path_elems, path_nulls, path_len, st, level, newval, npairs, op_type));

        public static void setPathArray(IntPtr it, IntPtr path_elems, IntPtr path_nulls, int path_len, IntPtr st, int level, IntPtr newval, uint nelems, int op_type)
            => SafeExecution(() => MEOSExternalFunctions.setPathArray(it, path_elems, path_nulls, path_len, st, level, newval, nelems, op_type));

        public static long datum_jsonb_concat(long l, long r)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_jsonb_concat(l, r));

        public static long datum_jsonb_contained(long l, long r)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_jsonb_contained(l, r));

        public static long datum_jsonb_contains(long l, long r)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_jsonb_contains(l, r));

        public static long datum_jsonb_delete(long jb, long key)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_jsonb_delete(jb, key));

        public static long datum_jsonb_delete_array(long jb, long array, long count)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_jsonb_delete_array(jb, array, count));

        public static long datum_jsonb_delete_index(long jb, long idx)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_jsonb_delete_index(jb, idx));

        public static long datum_json_array_element(long txt, long element)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_json_array_element(txt, element));

        public static long datum_jsonb_array_element(long jb, long element)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_jsonb_array_element(jb, element));

        public static long datum_json_array_element_text(long txt, long element)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_json_array_element_text(txt, element));

        public static long datum_jsonb_array_element_text(long jb, long element)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_jsonb_array_element_text(jb, element));

        public static long datum_jsonb_exists(long l, long r)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_jsonb_exists(l, r));

        public static long datum_jsonb_exists_array(long value, long array, long count, long any)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_jsonb_exists_array(value, array, count, any));

        public static long datum_json_array_length(long txt)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_json_array_length(txt));

        public static long datum_jsonb_array_length(long txt)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_jsonb_array_length(txt));

        public static long datum_json_object_field(long txt, long key)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_json_object_field(txt, key));

        public static long datum_jsonb_object_field(long jb, long key)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_jsonb_object_field(jb, key));

        public static long datum_json_object_field_text(long txt, long key)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_json_object_field_text(txt, key));

        public static long datum_jsonb_object_field_text(long jb, long key)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_jsonb_object_field_text(jb, key));

        public static long datum_json_strip_nulls(long txt, long strip_in_arrays)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_json_strip_nulls(txt, strip_in_arrays));

        public static long datum_jsonb_strip_nulls(long jb, long strip_in_arrays)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_jsonb_strip_nulls(jb, strip_in_arrays));

        public static long datum_jsonb_pretty(long jb)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_jsonb_pretty(jb));

        public static long datum_json_extract_path(long txt, long path_elems, long path_len)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_json_extract_path(txt, path_elems, path_len));

        public static long datum_jsonb_extract_path(long jb, long path_elems, long path_len)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_jsonb_extract_path(jb, path_elems, path_len));

        public static long datum_json_extract_path_text(long txt, long path_elems, long path_len)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_json_extract_path_text(txt, path_elems, path_len));

        public static long datum_jsonb_extract_path_text(long jb, long path_elems, long path_len)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_jsonb_extract_path_text(jb, path_elems, path_len));

        public static long datum_jsonb_set(long jb, long keys, long count, long newjb, long create)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_jsonb_set(jb, keys, count, newjb, create));

        public static long datum_jsonb_set_lax(long jb, long keys, long count, long newjb, long create, long null_handle)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_jsonb_set_lax(jb, keys, count, newjb, create, null_handle));

        public static long datum_jsonb_delete_path(long jb, long keys, long count)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_jsonb_delete_path(jb, keys, count));

        public static long datum_jsonb_insert(long jb, long keys, long count, long newjb, long after)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_jsonb_insert(jb, keys, count, newjb, after));

        public static long datum_jsonb_path_exists(long jb, long jp, long vars, long silent, long tz)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_jsonb_path_exists(jb, jp, vars, silent, tz));

        public static long datum_jsonb_path_match(long jb, long jp, long vars, long silent, long tz)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_jsonb_path_match(jb, jp, vars, silent, tz));

        public static long datum_jsonb_path_query_array(long jb, long jp, long vars, long silent, long tz)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_jsonb_path_query_array(jb, jp, vars, silent, tz));

        public static long datum_jsonb_path_query_first(long jb, long jp, long vars, long silent, long tz)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_jsonb_path_query_first(jb, jp, vars, silent, tz));

        public static long datum_jsonb_to_text(long jb)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_jsonb_to_text(jb));

        public static long datum_text_to_jsonb(long txt)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_text_to_jsonb(txt));

        public static long datum_jsonb_to_alphanum(long jb, long key, long temptype, long null_handle)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_jsonb_to_alphanum(jb, key, temptype, null_handle));

        public static IntPtr tjsonb_to_talphanum(IntPtr temp, string key, int resbasetype, int interp, IntPtr null_handle)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tjsonb_to_talphanum(temp, key, resbasetype, interp, null_handle));

        public static IntPtr jsonbfunc_jsonbset(IntPtr s, int func, int intype, int restype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbfunc_jsonbset(s, func, intype, restype));

        public static IntPtr jsonbfunc_jsonbset_jsonb(IntPtr s, IntPtr jb, IntPtr func, bool invert)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbfunc_jsonbset_jsonb(s, jb, func, invert));

        public static IntPtr jsonbfunc_jsonbset_text(IntPtr s, IntPtr txt, IntPtr func)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.jsonbfunc_jsonbset_text(s, txt, func));

        public static IntPtr h3index_from_wkb(IntPtr wkb, IntPtr size)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3index_from_wkb(wkb, size));

        public static IntPtr h3index_from_hexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3index_from_hexwkb(hexwkb));

        public static IntPtr h3index_as_wkb(IntPtr cell, IntPtr variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.h3index_as_wkb(cell, variant, size_out));

        public static string h3index_as_hexwkb(IntPtr cell, IntPtr variant, IntPtr size_out)
            => SafeExecution<string>(() => MEOSExternalFunctions.h3index_as_hexwkb(cell, variant, size_out));

        public static IntPtr th3index_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_in(str));

        public static IntPtr th3indexinst_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3indexinst_in(str));

        public static IntPtr th3indexseq_in(string str, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3indexseq_in(str, interp));

        public static IntPtr th3indexseqset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3indexseqset_in(str));

        public static IntPtr th3index_make(IntPtr value, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_make(value, t));

        public static IntPtr th3indexinst_make(IntPtr value, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3indexinst_make(value, t));

        public static IntPtr th3indexseq_make(IntPtr values, IntPtr times, int count, bool lower_inc, bool upper_inc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3indexseq_make(values, times, count, lower_inc, upper_inc));

        public static IntPtr th3indexseqset_make(IntPtr sequences, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3indexseqset_make(sequences, count));

        public static IntPtr th3index_start_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_start_value(temp));

        public static IntPtr th3index_end_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_end_value(temp));

        public static bool th3index_value_n(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.th3index_value_n(temp, n, result));

        public static IntPtr[] th3index_values(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_values(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool th3index_value_at_timestamptz(IntPtr temp, long t, bool strict, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.th3index_value_at_timestamptz(temp, t, strict, result));

        public static IntPtr tbigint_to_th3index(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbigint_to_th3index(temp));

        public static IntPtr th3index_to_tbigint(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_to_tbigint(temp));

        public static int ever_eq_h3index_th3index(IntPtr cell, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_h3index_th3index(cell, temp));

        public static int ever_eq_th3index_h3index(IntPtr temp, IntPtr cell)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_th3index_h3index(temp, cell));

        public static int ever_ne_h3index_th3index(IntPtr cell, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_h3index_th3index(cell, temp));

        public static int ever_ne_th3index_h3index(IntPtr temp, IntPtr cell)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_th3index_h3index(temp, cell));

        public static int always_eq_h3index_th3index(IntPtr cell, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_h3index_th3index(cell, temp));

        public static int always_eq_th3index_h3index(IntPtr temp, IntPtr cell)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_th3index_h3index(temp, cell));

        public static int always_ne_h3index_th3index(IntPtr cell, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_h3index_th3index(cell, temp));

        public static int always_ne_th3index_h3index(IntPtr temp, IntPtr cell)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_th3index_h3index(temp, cell));

        public static int ever_eq_th3index_th3index(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_th3index_th3index(temp1, temp2));

        public static int ever_ne_th3index_th3index(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_th3index_th3index(temp1, temp2));

        public static int always_eq_th3index_th3index(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_th3index_th3index(temp1, temp2));

        public static int always_ne_th3index_th3index(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_th3index_th3index(temp1, temp2));

        public static IntPtr teq_h3index_th3index(IntPtr cell, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_h3index_th3index(cell, temp));

        public static IntPtr teq_th3index_h3index(IntPtr temp, IntPtr cell)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_th3index_h3index(temp, cell));

        public static IntPtr teq_th3index_th3index(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_th3index_th3index(temp1, temp2));

        public static IntPtr tne_h3index_th3index(IntPtr cell, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_h3index_th3index(cell, temp));

        public static IntPtr tne_th3index_h3index(IntPtr temp, IntPtr cell)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_th3index_h3index(temp, cell));

        public static IntPtr tne_th3index_th3index(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_th3index_th3index(temp1, temp2));

        public static IntPtr th3index_get_resolution(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_get_resolution(temp));

        public static IntPtr th3index_get_base_cell_number(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_get_base_cell_number(temp));

        public static IntPtr th3index_is_valid_cell(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_is_valid_cell(temp));

        public static IntPtr th3index_is_res_class_iii(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_is_res_class_iii(temp));

        public static IntPtr th3index_is_pentagon(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_is_pentagon(temp));

        public static IntPtr th3index_cell_to_parent(IntPtr temp, int resolution)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_cell_to_parent(temp, resolution));

        public static IntPtr th3index_cell_to_parent_next(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_cell_to_parent_next(temp));

        public static IntPtr th3index_cell_to_center_child(IntPtr temp, int resolution)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_cell_to_center_child(temp, resolution));

        public static IntPtr th3index_cell_to_center_child_next(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_cell_to_center_child_next(temp));

        public static IntPtr th3index_cell_to_child_pos(IntPtr temp, int parent_res)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_cell_to_child_pos(temp, parent_res));

        public static IntPtr th3index_child_pos_to_cell(IntPtr child_pos, IntPtr parent, int child_res)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_child_pos_to_cell(child_pos, parent, child_res));

        public static IntPtr tgeogpoint_to_th3index(IntPtr temp, int resolution)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeogpoint_to_th3index(temp, resolution));

        public static IntPtr tgeompoint_to_th3index(IntPtr temp, int resolution)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeompoint_to_th3index(temp, resolution));

        public static IntPtr th3index_to_tgeogpoint(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_to_tgeogpoint(temp));

        public static IntPtr th3index_to_tgeompoint(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_to_tgeompoint(temp));

        public static IntPtr th3index_cell_to_boundary(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_cell_to_boundary(temp));

        public static IntPtr geo_to_h3index_set(IntPtr gs, int resolution)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_to_h3index_set(gs, resolution));

        public static int ever_eq_h3indexset_th3index(IntPtr cells, IntPtr th3idx)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_h3indexset_th3index(cells, th3idx));

        public static IntPtr th3index_are_neighbor_cells(IntPtr origin, IntPtr dest)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_are_neighbor_cells(origin, dest));

        public static IntPtr th3index_cells_to_directed_edge(IntPtr origin, IntPtr dest)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_cells_to_directed_edge(origin, dest));

        public static IntPtr th3index_is_valid_directed_edge(IntPtr edge)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_is_valid_directed_edge(edge));

        public static IntPtr th3index_get_directed_edge_origin(IntPtr edge)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_get_directed_edge_origin(edge));

        public static IntPtr th3index_get_directed_edge_destination(IntPtr edge)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_get_directed_edge_destination(edge));

        public static IntPtr th3index_directed_edge_to_boundary(IntPtr edge)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_directed_edge_to_boundary(edge));

        public static IntPtr th3index_cell_to_vertex(IntPtr temp, int vertex_num)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_cell_to_vertex(temp, vertex_num));

        public static IntPtr th3index_vertex_to_latlng(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_vertex_to_latlng(temp));

        public static IntPtr th3index_is_valid_vertex(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_is_valid_vertex(temp));

        public static IntPtr th3index_grid_distance(IntPtr origin, IntPtr dest)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_grid_distance(origin, dest));

        public static IntPtr th3index_cell_to_local_ij(IntPtr origin, IntPtr cell)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_cell_to_local_ij(origin, cell));

        public static IntPtr th3index_local_ij_to_cell(IntPtr origin, IntPtr coord)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_local_ij_to_cell(origin, coord));

        public static IntPtr th3index_cell_area(IntPtr temp, string unit)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_cell_area(temp, unit));

        public static IntPtr th3index_edge_length(IntPtr temp, string unit)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.th3index_edge_length(temp, unit));

        public static IntPtr tgeogpoint_great_circle_distance(IntPtr a, IntPtr b, string unit)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeogpoint_great_circle_distance(a, b, unit));

        public static IntPtr proj_get_context()
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.proj_get_context());

        public static IntPtr geos_get_context()
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geos_get_context());

        public static long datum_geo_round(long value, long size)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_geo_round(value, size));

        public static IntPtr point_round(IntPtr gs, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.point_round(gs, maxdd));

        public static void stbox_set(bool hasx, bool hasz, bool geodetic, int srid, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, IntPtr s, IntPtr result)
            => SafeExecution(() => MEOSExternalFunctions.stbox_set(hasx, hasz, geodetic, srid, xmin, xmax, ymin, ymax, zmin, zmax, s, result));

        public static void gbox_set_stbox(IntPtr box, int srid, IntPtr result)
            => SafeExecution(() => MEOSExternalFunctions.gbox_set_stbox(box, srid, result));

        public static bool geo_set_stbox(IntPtr gs, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geo_set_stbox(gs, result));

        public static void geoarr_set_stbox(IntPtr values, int count, IntPtr result)
            => SafeExecution(() => MEOSExternalFunctions.geoarr_set_stbox(values, count, result));

        public static bool spatial_set_stbox(long d, int basetype, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.spatial_set_stbox(d, basetype, result));

        public static void spatialset_set_stbox(IntPtr set, IntPtr result)
            => SafeExecution(() => MEOSExternalFunctions.spatialset_set_stbox(set, result));

        public static void stbox_set_box3d(IntPtr box, IntPtr result)
            => SafeExecution(() => MEOSExternalFunctions.stbox_set_box3d(box, result));

        public static void stbox_set_gbox(IntPtr box, IntPtr result)
            => SafeExecution(() => MEOSExternalFunctions.stbox_set_gbox(box, result));

        public static void tstzset_set_stbox(IntPtr s, IntPtr result)
            => SafeExecution(() => MEOSExternalFunctions.tstzset_set_stbox(s, result));

        public static void tstzspan_set_stbox(IntPtr s, IntPtr result)
            => SafeExecution(() => MEOSExternalFunctions.tstzspan_set_stbox(s, result));

        public static void tstzspanset_set_stbox(IntPtr s, IntPtr result)
            => SafeExecution(() => MEOSExternalFunctions.tstzspanset_set_stbox(s, result));

        public static void stbox_expand(IntPtr box1, IntPtr box2)
            => SafeExecution(() => MEOSExternalFunctions.stbox_expand(box1, box2));

        public static bool inter_stbox_stbox(IntPtr box1, IntPtr box2, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.inter_stbox_stbox(box1, box2, result));

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

        public static void tspatial_set_stbox(IntPtr temp, IntPtr result)
            => SafeExecution(() => MEOSExternalFunctions.tspatial_set_stbox(temp, result));

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

        public static IntPtr tpoint_linear_inter_geom(IntPtr temp, IntPtr gs, bool clip)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_linear_inter_geom(temp, gs, clip));

        public static IntPtr tpoint_linear_dwithin_geom(IntPtr temp, IntPtr gs, double dist)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_linear_dwithin_geom(temp, gs, dist));

        public static IntPtr tpoint_linear_distance_geom(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_linear_distance_geom(temp, gs));

        public static IntPtr tpoint_linear_restrict_geom(IntPtr temp, IntPtr gs, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_linear_restrict_geom(temp, gs, atfunc));

        public static bool geom_clip_supported(IntPtr geom)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geom_clip_supported(geom));

        public static int spatial_srid(long d, int basetype)
            => SafeExecution<int>(() => MEOSExternalFunctions.spatial_srid(d, basetype));

        public static bool spatial_set_srid(long d, int basetype, int srid)
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

        public static IntPtr[] tgeoseq_stboxes(IntPtr seq)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeoseq_stboxes(seq, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] tgeoseq_split_n_stboxes(IntPtr seq, int max_count)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeoseq_split_n_stboxes(seq, max_count, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr tpointseqset_azimuth(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpointseqset_azimuth(ss));

        public static IntPtr tpointseqset_cumulative_length(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpointseqset_cumulative_length(ss));

        public static bool tpointseqset_is_simple(IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpointseqset_is_simple(ss));

        public static double tpointseqset_length(IntPtr ss)
            => SafeExecution<double>(() => MEOSExternalFunctions.tpointseqset_length(ss));

        public static IntPtr[] tgeoseqset_stboxes(IntPtr ss)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeoseqset_stboxes(ss, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] tgeoseqset_split_n_stboxes(IntPtr ss, int max_count)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeoseqset_split_n_stboxes(ss, max_count, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

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

        public static IntPtr[] tpointseq_make_simple(IntPtr seq)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpointseq_make_simple(seq, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static void tspatialseq_set_srid(IntPtr seq, int srid)
            => SafeExecution(() => MEOSExternalFunctions.tspatialseq_set_srid(seq, srid));

        public static IntPtr[] tpointseqset_make_simple(IntPtr ss)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpointseqset_make_simple(ss, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

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

        public static IntPtr npoint_from_wkb(IntPtr wkb, IntPtr size)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.npoint_from_wkb(wkb, size));

        public static IntPtr npoint_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.npoint_in(str));

        public static string npoint_out(IntPtr np, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.npoint_out(np, maxdd));

        public static IntPtr nsegment_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nsegment_in(str));

        public static string nsegment_out(IntPtr ns, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.nsegment_out(ns, maxdd));

        public static IntPtr npoint_make(IntPtr rid, double pos)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.npoint_make(rid, pos));

        public static IntPtr nsegment_make(IntPtr rid, double pos1, double pos2)
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

        public static IntPtr nsegment_to_stbox(IntPtr ns)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nsegment_to_stbox(ns));

        public static int npoint_hash(IntPtr np)
            => SafeExecution<int>(() => MEOSExternalFunctions.npoint_hash(np));

        public static IntPtr npoint_hash_extended(IntPtr np, IntPtr seed)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.npoint_hash_extended(np, seed));

        public static double npoint_position(IntPtr np)
            => SafeExecution<double>(() => MEOSExternalFunctions.npoint_position(np));

        public static IntPtr npoint_route(IntPtr np)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.npoint_route(np));

        public static double nsegment_end_position(IntPtr ns)
            => SafeExecution<double>(() => MEOSExternalFunctions.nsegment_end_position(ns));

        public static IntPtr nsegment_route(IntPtr ns)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nsegment_route(ns));

        public static double nsegment_start_position(IntPtr ns)
            => SafeExecution<double>(() => MEOSExternalFunctions.nsegment_start_position(ns));

        public static bool route_exists(IntPtr rid)
            => SafeExecution<bool>(() => MEOSExternalFunctions.route_exists(rid));

        public static IntPtr route_geom(IntPtr rid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.route_geom(rid));

        public static double route_length(IntPtr rid)
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
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.npointset_values(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
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

        public static IntPtr tnpoint_from_mfjson(string mfjson)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_from_mfjson(mfjson));

        public static string tnpoint_out(IntPtr temp, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.tnpoint_out(temp, maxdd));

        public static IntPtr tnpointinst_make(IntPtr np, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpointinst_make(np, t));

        public static IntPtr tnpoint_from_base_temp(IntPtr np, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_from_base_temp(np, temp));

        public static IntPtr tnpointseq_from_base_tstzset(IntPtr np, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpointseq_from_base_tstzset(np, s));

        public static IntPtr tnpointseq_from_base_tstzspan(IntPtr np, IntPtr s, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpointseq_from_base_tstzspan(np, s, interp));

        public static IntPtr tnpointseqset_from_base_tstzspanset(IntPtr np, IntPtr ss, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpointseqset_from_base_tstzspanset(np, ss, interp));

        public static IntPtr tgeompoint_to_tnpoint(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeompoint_to_tnpoint(temp));

        public static IntPtr tnpoint_to_tgeompoint(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_to_tgeompoint(temp));

        public static IntPtr tnpoint_cumulative_length(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_cumulative_length(temp));

        public static IntPtr tnpoint_end_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_end_value(temp));

        public static double tnpoint_length(IntPtr temp)
            => SafeExecution<double>(() => MEOSExternalFunctions.tnpoint_length(temp));

        public static IntPtr[] tnpoint_positions(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_positions(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr tnpoint_route(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_route(temp));

        public static IntPtr tnpoint_routes(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_routes(temp));

        public static IntPtr tnpoint_speed(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_speed(temp));

        public static IntPtr tnpoint_start_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_start_value(temp));

        public static IntPtr tnpoint_trajectory(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_trajectory(temp));

        public static bool tnpoint_value_at_timestamptz(IntPtr temp, long t, bool strict, IntPtr value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tnpoint_value_at_timestamptz(temp, t, strict, value));

        public static bool tnpoint_value_n(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tnpoint_value_n(temp, n, result));

        public static IntPtr[] tnpoint_values(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_values(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

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

        public static IntPtr tdistance_tnpoint_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdistance_tnpoint_geo(temp, gs));

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

        public static IntPtr pcpoint_hex_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pcpoint_hex_in(str));

        public static string pcpoint_hex_out(IntPtr pt, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.pcpoint_hex_out(pt, maxdd));

        public static IntPtr pcpoint_from_hexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pcpoint_from_hexwkb(hexwkb));

        public static string pcpoint_as_hexwkb(IntPtr pt)
            => SafeExecution<string>(() => MEOSExternalFunctions.pcpoint_as_hexwkb(pt));

        public static IntPtr pcpoint_copy(IntPtr pt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pcpoint_copy(pt));

        public static uint pcpoint_get_pcid(IntPtr pt)
            => SafeExecution<uint>(() => MEOSExternalFunctions.pcpoint_get_pcid(pt));

        public static int pcpoint_hash(IntPtr pt)
            => SafeExecution<int>(() => MEOSExternalFunctions.pcpoint_hash(pt));

        public static IntPtr pcpoint_hash_extended(IntPtr pt, IntPtr seed)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pcpoint_hash_extended(pt, seed));

        public static bool pcpoint_get_x(IntPtr pt, IntPtr schema, IntPtr @out)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pcpoint_get_x(pt, schema, @out));

        public static bool pcpoint_get_y(IntPtr pt, IntPtr schema, IntPtr @out)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pcpoint_get_y(pt, schema, @out));

        public static bool pcpoint_get_z(IntPtr pt, IntPtr schema, IntPtr @out)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pcpoint_get_z(pt, schema, @out));

        public static bool pcpoint_get_dim(IntPtr pt, IntPtr schema, string name, IntPtr @out)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pcpoint_get_dim(pt, schema, name, @out));

        public static IntPtr pcpoint_to_tpcbox(IntPtr pt, IntPtr schema)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pcpoint_to_tpcbox(pt, schema));

        public static IntPtr meos_pc_schema(uint pcid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.meos_pc_schema(pcid));

        public static void meos_pc_schema_register(uint pcid, IntPtr schema)
            => SafeExecution(() => MEOSExternalFunctions.meos_pc_schema_register(pcid, schema));

        public static void meos_pc_schema_register_xml(uint pcid, IntPtr schema, string xml_text)
            => SafeExecution(() => MEOSExternalFunctions.meos_pc_schema_register_xml(pcid, schema, xml_text));

        public static string meos_pc_schema_xml(uint pcid)
            => SafeExecution<string>(() => MEOSExternalFunctions.meos_pc_schema_xml(pcid));

        public static void meos_pc_schema_clear()
            => SafeExecution(() => MEOSExternalFunctions.meos_pc_schema_clear());

        public static int pcpoint_cmp(IntPtr pt1, IntPtr pt2)
            => SafeExecution<int>(() => MEOSExternalFunctions.pcpoint_cmp(pt1, pt2));

        public static bool pcpoint_eq(IntPtr pt1, IntPtr pt2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pcpoint_eq(pt1, pt2));

        public static bool pcpoint_ne(IntPtr pt1, IntPtr pt2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pcpoint_ne(pt1, pt2));

        public static bool pcpoint_lt(IntPtr pt1, IntPtr pt2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pcpoint_lt(pt1, pt2));

        public static bool pcpoint_le(IntPtr pt1, IntPtr pt2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pcpoint_le(pt1, pt2));

        public static bool pcpoint_gt(IntPtr pt1, IntPtr pt2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pcpoint_gt(pt1, pt2));

        public static bool pcpoint_ge(IntPtr pt1, IntPtr pt2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pcpoint_ge(pt1, pt2));

        public static IntPtr pcpatch_hex_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pcpatch_hex_in(str));

        public static string pcpatch_hex_out(IntPtr pa, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.pcpatch_hex_out(pa, maxdd));

        public static IntPtr pcpatch_from_hexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pcpatch_from_hexwkb(hexwkb));

        public static string pcpatch_as_hexwkb(IntPtr pa)
            => SafeExecution<string>(() => MEOSExternalFunctions.pcpatch_as_hexwkb(pa));

        public static IntPtr pcpatch_copy(IntPtr pa)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pcpatch_copy(pa));

        public static uint pcpatch_get_pcid(IntPtr pa)
            => SafeExecution<uint>(() => MEOSExternalFunctions.pcpatch_get_pcid(pa));

        public static uint pcpatch_npoints(IntPtr pa)
            => SafeExecution<uint>(() => MEOSExternalFunctions.pcpatch_npoints(pa));

        public static int pcpatch_hash(IntPtr pa)
            => SafeExecution<int>(() => MEOSExternalFunctions.pcpatch_hash(pa));

        public static IntPtr pcpatch_hash_extended(IntPtr pa, IntPtr seed)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pcpatch_hash_extended(pa, seed));

        public static int pcpatch_cmp(IntPtr pa1, IntPtr pa2)
            => SafeExecution<int>(() => MEOSExternalFunctions.pcpatch_cmp(pa1, pa2));

        public static bool pcpatch_eq(IntPtr pa1, IntPtr pa2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pcpatch_eq(pa1, pa2));

        public static bool pcpatch_ne(IntPtr pa1, IntPtr pa2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pcpatch_ne(pa1, pa2));

        public static bool pcpatch_lt(IntPtr pa1, IntPtr pa2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pcpatch_lt(pa1, pa2));

        public static bool pcpatch_le(IntPtr pa1, IntPtr pa2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pcpatch_le(pa1, pa2));

        public static bool pcpatch_gt(IntPtr pa1, IntPtr pa2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pcpatch_gt(pa1, pa2));

        public static bool pcpatch_ge(IntPtr pa1, IntPtr pa2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pcpatch_ge(pa1, pa2));

        public static IntPtr pcpointset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pcpointset_in(str));

        public static string pcpointset_out(IntPtr s, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.pcpointset_out(s, maxdd));

        public static IntPtr pcpointset_make(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pcpointset_make(values, count));

        public static IntPtr pcpoint_to_set(IntPtr pt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pcpoint_to_set(pt));

        public static IntPtr pcpointset_start_value(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pcpointset_start_value(s));

        public static IntPtr pcpointset_end_value(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pcpointset_end_value(s));

        public static bool pcpointset_value_n(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pcpointset_value_n(s, n, result));

        public static IntPtr[] pcpointset_values(IntPtr s)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.pcpointset_values(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool contains_set_pcpoint(IntPtr s, IntPtr pt)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_set_pcpoint(s, pt));

        public static bool contained_pcpoint_set(IntPtr pt, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_pcpoint_set(pt, s));

        public static IntPtr intersection_pcpoint_set(IntPtr pt, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_pcpoint_set(pt, s));

        public static IntPtr intersection_set_pcpoint(IntPtr s, IntPtr pt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_set_pcpoint(s, pt));

        public static IntPtr minus_pcpoint_set(IntPtr pt, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_pcpoint_set(pt, s));

        public static IntPtr minus_set_pcpoint(IntPtr s, IntPtr pt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_set_pcpoint(s, pt));

        public static IntPtr union_pcpoint_set(IntPtr pt, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_pcpoint_set(pt, s));

        public static IntPtr union_set_pcpoint(IntPtr s, IntPtr pt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_set_pcpoint(s, pt));

        public static IntPtr pcpoint_union_transfn(IntPtr state, IntPtr pt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pcpoint_union_transfn(state, pt));

        public static IntPtr pcpatchset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pcpatchset_in(str));

        public static string pcpatchset_out(IntPtr s, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.pcpatchset_out(s, maxdd));

        public static IntPtr pcpatchset_make(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pcpatchset_make(values, count));

        public static IntPtr pcpatch_to_set(IntPtr pa)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pcpatch_to_set(pa));

        public static IntPtr pcpatchset_start_value(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pcpatchset_start_value(s));

        public static IntPtr pcpatchset_end_value(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pcpatchset_end_value(s));

        public static bool pcpatchset_value_n(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pcpatchset_value_n(s, n, result));

        public static IntPtr[] pcpatchset_values(IntPtr s)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.pcpatchset_values(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool contains_set_pcpatch(IntPtr s, IntPtr pa)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_set_pcpatch(s, pa));

        public static bool contained_pcpatch_set(IntPtr pa, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_pcpatch_set(pa, s));

        public static IntPtr intersection_pcpatch_set(IntPtr pa, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_pcpatch_set(pa, s));

        public static IntPtr intersection_set_pcpatch(IntPtr s, IntPtr pa)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_set_pcpatch(s, pa));

        public static IntPtr minus_pcpatch_set(IntPtr pa, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_pcpatch_set(pa, s));

        public static IntPtr minus_set_pcpatch(IntPtr s, IntPtr pa)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_set_pcpatch(s, pa));

        public static IntPtr union_pcpatch_set(IntPtr pa, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_pcpatch_set(pa, s));

        public static IntPtr union_set_pcpatch(IntPtr s, IntPtr pa)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_set_pcpatch(s, pa));

        public static IntPtr pcpatch_union_transfn(IntPtr state, IntPtr pa)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pcpatch_union_transfn(state, pa));

        public static IntPtr tpcbox_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpcbox_in(str));

        public static string tpcbox_out(IntPtr box, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.tpcbox_out(box, maxdd));

        public static IntPtr tpcbox_make(bool hasx, bool hasz, bool hast, bool geodetic, int srid, uint pcid, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, IntPtr period)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpcbox_make(hasx, hasz, hast, geodetic, srid, pcid, xmin, xmax, ymin, ymax, zmin, zmax, period));

        public static IntPtr tpcbox_copy(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpcbox_copy(box));

        public static IntPtr pcpatch_to_tpcbox(IntPtr pa, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pcpatch_to_tpcbox(pa, srid));

        public static bool tpcbox_hasx(IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpcbox_hasx(box));

        public static bool tpcbox_hasz(IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpcbox_hasz(box));

        public static bool tpcbox_hast(IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpcbox_hast(box));

        public static bool tpcbox_geodetic(IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpcbox_geodetic(box));

        public static bool tpcbox_xmin(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpcbox_xmin(box, result));

        public static bool tpcbox_xmax(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpcbox_xmax(box, result));

        public static bool tpcbox_ymin(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpcbox_ymin(box, result));

        public static bool tpcbox_ymax(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpcbox_ymax(box, result));

        public static bool tpcbox_zmin(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpcbox_zmin(box, result));

        public static bool tpcbox_zmax(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpcbox_zmax(box, result));

        public static bool tpcbox_tmin(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpcbox_tmin(box, result));

        public static bool tpcbox_tmin_inc(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpcbox_tmin_inc(box, result));

        public static bool tpcbox_tmax(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpcbox_tmax(box, result));

        public static bool tpcbox_tmax_inc(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpcbox_tmax_inc(box, result));

        public static int tpcbox_srid(IntPtr box)
            => SafeExecution<int>(() => MEOSExternalFunctions.tpcbox_srid(box));

        public static uint tpcbox_pcid(IntPtr box)
            => SafeExecution<uint>(() => MEOSExternalFunctions.tpcbox_pcid(box));

        public static IntPtr tpcbox_to_stbox(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpcbox_to_stbox(box));

        public static void tpcbox_expand(IntPtr box1, IntPtr box2)
            => SafeExecution(() => MEOSExternalFunctions.tpcbox_expand(box1, box2));

        public static IntPtr tpcbox_round(IntPtr box, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpcbox_round(box, maxdd));

        public static IntPtr tpcbox_set_srid(IntPtr box, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpcbox_set_srid(box, srid));

        public static IntPtr union_tpcbox_tpcbox(IntPtr box1, IntPtr box2, bool strict)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_tpcbox_tpcbox(box1, box2, strict));

        public static bool inter_tpcbox_tpcbox(IntPtr box1, IntPtr box2, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.inter_tpcbox_tpcbox(box1, box2, result));

        public static IntPtr intersection_tpcbox_tpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_tpcbox_tpcbox(box1, box2));

        public static bool contains_tpcbox_tpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_tpcbox_tpcbox(box1, box2));

        public static bool contained_tpcbox_tpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_tpcbox_tpcbox(box1, box2));

        public static bool overlaps_tpcbox_tpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_tpcbox_tpcbox(box1, box2));

        public static bool same_tpcbox_tpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.same_tpcbox_tpcbox(box1, box2));

        public static bool adjacent_tpcbox_tpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_tpcbox_tpcbox(box1, box2));

        public static int tpcbox_cmp(IntPtr box1, IntPtr box2)
            => SafeExecution<int>(() => MEOSExternalFunctions.tpcbox_cmp(box1, box2));

        public static bool tpcbox_eq(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpcbox_eq(box1, box2));

        public static bool tpcbox_ne(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpcbox_ne(box1, box2));

        public static bool tpcbox_lt(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpcbox_lt(box1, box2));

        public static bool tpcbox_le(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpcbox_le(box1, box2));

        public static bool tpcbox_gt(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpcbox_gt(box1, box2));

        public static bool tpcbox_ge(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpcbox_ge(box1, box2));

        public static bool left_tpcbox_tpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_tpcbox_tpcbox(box1, box2));

        public static bool overleft_tpcbox_tpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_tpcbox_tpcbox(box1, box2));

        public static bool right_tpcbox_tpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_tpcbox_tpcbox(box1, box2));

        public static bool overright_tpcbox_tpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_tpcbox_tpcbox(box1, box2));

        public static bool below_tpcbox_tpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.below_tpcbox_tpcbox(box1, box2));

        public static bool overbelow_tpcbox_tpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbelow_tpcbox_tpcbox(box1, box2));

        public static bool above_tpcbox_tpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.above_tpcbox_tpcbox(box1, box2));

        public static bool overabove_tpcbox_tpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overabove_tpcbox_tpcbox(box1, box2));

        public static bool front_tpcbox_tpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.front_tpcbox_tpcbox(box1, box2));

        public static bool overfront_tpcbox_tpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overfront_tpcbox_tpcbox(box1, box2));

        public static bool back_tpcbox_tpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.back_tpcbox_tpcbox(box1, box2));

        public static bool overback_tpcbox_tpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overback_tpcbox_tpcbox(box1, box2));

        public static bool before_tpcbox_tpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_tpcbox_tpcbox(box1, box2));

        public static bool overbefore_tpcbox_tpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_tpcbox_tpcbox(box1, box2));

        public static bool after_tpcbox_tpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_tpcbox_tpcbox(box1, box2));

        public static bool overafter_tpcbox_tpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_tpcbox_tpcbox(box1, box2));

        public static bool ensure_same_pcid_tpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_same_pcid_tpcbox(box1, box2));

        public static IntPtr tpointcloudinst_make(IntPtr pt, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpointcloudinst_make(pt, t));

        public static bool eintersects_tpcpoint_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.eintersects_tpcpoint_geo(temp, gs));

        public static double nad_tpcpoint_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tpcpoint_geo(temp, gs));

        public static string pose_as_ewkt(IntPtr pose, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.pose_as_ewkt(pose, maxdd));

        public static string pose_as_hexwkb(IntPtr pose, IntPtr variant, IntPtr size_out)
            => SafeExecution<string>(() => MEOSExternalFunctions.pose_as_hexwkb(pose, variant, size_out));

        public static string pose_as_text(IntPtr pose, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.pose_as_text(pose, maxdd));

        public static IntPtr pose_as_wkb(IntPtr pose, IntPtr variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_as_wkb(pose, variant, size_out));

        public static IntPtr pose_from_wkb(IntPtr wkb, IntPtr size)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_from_wkb(wkb, size));

        public static IntPtr pose_from_hexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_from_hexwkb(hexwkb));

        public static IntPtr pose_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_in(str));

        public static string pose_out(IntPtr pose, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.pose_out(pose, maxdd));

        public static IntPtr pose_from_geopose(string json)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_from_geopose(json));

        public static string pose_as_geopose(IntPtr pose, int conformance, int precision)
            => SafeExecution<string>(() => MEOSExternalFunctions.pose_as_geopose(pose, conformance, precision));

        public static IntPtr tpose_from_geopose(string json)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_from_geopose(json));

        public static string tpose_as_geopose(IntPtr temp, int conformance, int precision)
            => SafeExecution<string>(() => MEOSExternalFunctions.tpose_as_geopose(temp, conformance, precision));

        public static IntPtr pose_apply_geo(IntPtr pose, IntPtr body)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_apply_geo(pose, body));

        public static IntPtr tpose_apply_geo(IntPtr temp, IntPtr body)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_apply_geo(temp, body));

        public static IntPtr pose_copy(IntPtr pose)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_copy(pose));

        public static IntPtr pose_make_2d(double x, double y, double theta, bool geodetic, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_make_2d(x, y, theta, geodetic, srid));

        public static IntPtr pose_make_3d(double x, double y, double z, double W, double X, double Y, double Z, bool geodetic, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_make_3d(x, y, z, W, X, Y, Z, geodetic, srid));

        public static IntPtr pose_make_point2d(IntPtr gs, double theta)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_make_point2d(gs, theta));

        public static IntPtr pose_make_point3d(IntPtr gs, double W, double X, double Y, double Z)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_make_point3d(gs, W, X, Y, Z));

        public static IntPtr pose_to_point(IntPtr pose)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_to_point(pose));

        public static IntPtr pose_to_stbox(IntPtr pose)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_to_stbox(pose));

        public static int pose_hash(IntPtr pose)
            => SafeExecution<int>(() => MEOSExternalFunctions.pose_hash(pose));

        public static IntPtr pose_hash_extended(IntPtr pose, IntPtr seed)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_hash_extended(pose, seed));

        public static double[] pose_orientation(IntPtr pose)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_orientation(pose, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                double[] _out = new double[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static double pose_rotation(IntPtr pose)
            => SafeExecution<double>(() => MEOSExternalFunctions.pose_rotation(pose));

        public static double pose_yaw(IntPtr pose)
            => SafeExecution<double>(() => MEOSExternalFunctions.pose_yaw(pose));

        public static double pose_pitch(IntPtr pose)
            => SafeExecution<double>(() => MEOSExternalFunctions.pose_pitch(pose));

        public static double pose_roll(IntPtr pose)
            => SafeExecution<double>(() => MEOSExternalFunctions.pose_roll(pose));

        public static double pose_angular_distance(IntPtr pose1, IntPtr pose2)
            => SafeExecution<double>(() => MEOSExternalFunctions.pose_angular_distance(pose1, pose2));

        public static IntPtr pose_normalize(IntPtr pose)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_normalize(pose));

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
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.poseset_values(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
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

        public static IntPtr tpose_from_mfjson(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_from_mfjson(str));

        public static IntPtr tpose_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_in(str));

        public static IntPtr tposeinst_make(IntPtr pose, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tposeinst_make(pose, t));

        public static IntPtr tpose_from_base_temp(IntPtr pose, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_from_base_temp(pose, temp));

        public static IntPtr tposeseq_from_base_tstzset(IntPtr pose, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tposeseq_from_base_tstzset(pose, s));

        public static IntPtr tposeseq_from_base_tstzspan(IntPtr pose, IntPtr s, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tposeseq_from_base_tstzspan(pose, s, interp));

        public static IntPtr tposeseqset_from_base_tstzspanset(IntPtr pose, IntPtr ss, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tposeseqset_from_base_tstzspanset(pose, ss, interp));

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

        public static IntPtr tpose_yaw(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_yaw(temp));

        public static IntPtr tpose_pitch(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_pitch(temp));

        public static IntPtr tpose_roll(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_roll(temp));

        public static IntPtr tpose_speed(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_speed(temp));

        public static IntPtr tpose_angular_speed(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_angular_speed(temp));

        public static IntPtr tpose_start_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_start_value(temp));

        public static IntPtr tpose_trajectory(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_trajectory(temp));

        public static bool tpose_value_at_timestamptz(IntPtr temp, long t, bool strict, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpose_value_at_timestamptz(temp, t, strict, result));

        public static bool tpose_value_n(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpose_value_n(temp, n, result));

        public static IntPtr[] tpose_values(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_values(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

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

        public static IntPtr tdistance_tpose_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdistance_tpose_geo(temp, gs));

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

        public static bool quadbin_is_valid_index(IntPtr index)
            => SafeExecution<bool>(() => MEOSExternalFunctions.quadbin_is_valid_index(index));

        public static bool quadbin_is_valid_cell(IntPtr cell)
            => SafeExecution<bool>(() => MEOSExternalFunctions.quadbin_is_valid_cell(cell));

        public static IntPtr quadbin_tile_to_cell(uint x, uint y, uint z)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.quadbin_tile_to_cell(x, y, z));

        public static void quadbin_cell_to_tile(IntPtr cell, IntPtr x, IntPtr y, IntPtr z)
            => SafeExecution(() => MEOSExternalFunctions.quadbin_cell_to_tile(cell, x, y, z));

        public static uint quadbin_get_resolution(IntPtr cell)
            => SafeExecution<uint>(() => MEOSExternalFunctions.quadbin_get_resolution(cell));

        public static IntPtr quadbin_cell_to_parent(IntPtr cell, uint parent_resolution)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.quadbin_cell_to_parent(cell, parent_resolution));

        public static IntPtr[] quadbin_cell_to_children(IntPtr cell, uint children_resolution)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.quadbin_cell_to_children(cell, children_resolution, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr quadbin_cell_sibling(IntPtr cell, string direction)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.quadbin_cell_sibling(cell, direction));

        public static IntPtr[] quadbin_k_ring(IntPtr cell, int k)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.quadbin_k_ring(cell, k, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr quadbin_point_to_cell(double longitude, double latitude, uint resolution)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.quadbin_point_to_cell(longitude, latitude, resolution));

        public static void quadbin_cell_to_point(IntPtr cell, IntPtr longitude, IntPtr latitude)
            => SafeExecution(() => MEOSExternalFunctions.quadbin_cell_to_point(cell, longitude, latitude));

        public static void quadbin_cell_to_bounding_box(IntPtr cell, IntPtr xmin, IntPtr ymin, IntPtr xmax, IntPtr ymax)
            => SafeExecution(() => MEOSExternalFunctions.quadbin_cell_to_bounding_box(cell, xmin, ymin, xmax, ymax));

        public static double quadbin_cell_area(IntPtr cell)
            => SafeExecution<double>(() => MEOSExternalFunctions.quadbin_cell_area(cell));

        public static string quadbin_index_to_string(IntPtr index)
            => SafeExecution<string>(() => MEOSExternalFunctions.quadbin_index_to_string(index));

        public static IntPtr quadbin_string_to_index(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.quadbin_string_to_index(str));

        public static string quadbin_cell_to_quadkey(IntPtr cell)
            => SafeExecution<string>(() => MEOSExternalFunctions.quadbin_cell_to_quadkey(cell));

        public static IntPtr quadbin_parse(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.quadbin_parse(str));

        public static bool quadbin_eq(IntPtr a, IntPtr b)
            => SafeExecution<bool>(() => MEOSExternalFunctions.quadbin_eq(a, b));

        public static bool quadbin_ne(IntPtr a, IntPtr b)
            => SafeExecution<bool>(() => MEOSExternalFunctions.quadbin_ne(a, b));

        public static bool quadbin_lt(IntPtr a, IntPtr b)
            => SafeExecution<bool>(() => MEOSExternalFunctions.quadbin_lt(a, b));

        public static bool quadbin_le(IntPtr a, IntPtr b)
            => SafeExecution<bool>(() => MEOSExternalFunctions.quadbin_le(a, b));

        public static bool quadbin_gt(IntPtr a, IntPtr b)
            => SafeExecution<bool>(() => MEOSExternalFunctions.quadbin_gt(a, b));

        public static bool quadbin_ge(IntPtr a, IntPtr b)
            => SafeExecution<bool>(() => MEOSExternalFunctions.quadbin_ge(a, b));

        public static int quadbin_cmp(IntPtr a, IntPtr b)
            => SafeExecution<int>(() => MEOSExternalFunctions.quadbin_cmp(a, b));

        public static uint quadbin_hash(IntPtr cell)
            => SafeExecution<uint>(() => MEOSExternalFunctions.quadbin_hash(cell));

        public static IntPtr quadbin_grid_disk(IntPtr origin, int k)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.quadbin_grid_disk(origin, k));

        public static IntPtr quadbin_cell_to_children_set(IntPtr origin, int children_resolution)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.quadbin_cell_to_children_set(origin, children_resolution));

        public static IntPtr tquadbin_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tquadbin_in(str));

        public static IntPtr tquadbininst_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tquadbininst_in(str));

        public static IntPtr tquadbinseq_in(string str, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tquadbinseq_in(str, interp));

        public static IntPtr tquadbinseqset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tquadbinseqset_in(str));

        public static IntPtr tquadbin_make(IntPtr value, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tquadbin_make(value, t));

        public static IntPtr tquadbininst_make(IntPtr value, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tquadbininst_make(value, t));

        public static IntPtr tquadbinseq_make(IntPtr values, IntPtr times, int count, bool lower_inc, bool upper_inc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tquadbinseq_make(values, times, count, lower_inc, upper_inc));

        public static IntPtr tquadbinseqset_make(IntPtr sequences, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tquadbinseqset_make(sequences, count));

        public static IntPtr tquadbin_start_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tquadbin_start_value(temp));

        public static IntPtr tquadbin_end_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tquadbin_end_value(temp));

        public static bool tquadbin_value_n(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tquadbin_value_n(temp, n, result));

        public static IntPtr[] tquadbin_values(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tquadbin_values(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool tquadbin_value_at_timestamptz(IntPtr temp, long t, bool strict, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tquadbin_value_at_timestamptz(temp, t, strict, result));

        public static IntPtr tbigint_to_tquadbin(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbigint_to_tquadbin(temp));

        public static IntPtr tquadbin_to_tbigint(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tquadbin_to_tbigint(temp));

        public static int ever_eq_quadbin_tquadbin(IntPtr cell, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_quadbin_tquadbin(cell, temp));

        public static int ever_eq_tquadbin_quadbin(IntPtr temp, IntPtr cell)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_tquadbin_quadbin(temp, cell));

        public static int ever_ne_quadbin_tquadbin(IntPtr cell, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_quadbin_tquadbin(cell, temp));

        public static int ever_ne_tquadbin_quadbin(IntPtr temp, IntPtr cell)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_tquadbin_quadbin(temp, cell));

        public static int always_eq_quadbin_tquadbin(IntPtr cell, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_quadbin_tquadbin(cell, temp));

        public static int always_eq_tquadbin_quadbin(IntPtr temp, IntPtr cell)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_tquadbin_quadbin(temp, cell));

        public static int always_ne_quadbin_tquadbin(IntPtr cell, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_quadbin_tquadbin(cell, temp));

        public static int always_ne_tquadbin_quadbin(IntPtr temp, IntPtr cell)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_tquadbin_quadbin(temp, cell));

        public static int ever_eq_tquadbin_tquadbin(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_tquadbin_tquadbin(temp1, temp2));

        public static int ever_ne_tquadbin_tquadbin(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_tquadbin_tquadbin(temp1, temp2));

        public static int always_eq_tquadbin_tquadbin(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_tquadbin_tquadbin(temp1, temp2));

        public static int always_ne_tquadbin_tquadbin(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_tquadbin_tquadbin(temp1, temp2));

        public static IntPtr teq_quadbin_tquadbin(IntPtr cell, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_quadbin_tquadbin(cell, temp));

        public static IntPtr teq_tquadbin_quadbin(IntPtr temp, IntPtr cell)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_tquadbin_quadbin(temp, cell));

        public static IntPtr teq_tquadbin_tquadbin(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_tquadbin_tquadbin(temp1, temp2));

        public static IntPtr tne_quadbin_tquadbin(IntPtr cell, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_quadbin_tquadbin(cell, temp));

        public static IntPtr tne_tquadbin_quadbin(IntPtr temp, IntPtr cell)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_tquadbin_quadbin(temp, cell));

        public static IntPtr tne_tquadbin_tquadbin(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_tquadbin_tquadbin(temp1, temp2));

        public static IntPtr tquadbin_cell_to_quadkey(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tquadbin_cell_to_quadkey(temp));

        public static IntPtr raquet_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.raquet_in(str));

        public static string raquet_out(IntPtr rq)
            => SafeExecution<string>(() => MEOSExternalFunctions.raquet_out(rq));

        public static IntPtr raquet_from_wkb(IntPtr wkb, IntPtr size)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.raquet_from_wkb(wkb, size));

        public static IntPtr raquet_from_hexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.raquet_from_hexwkb(hexwkb));

        public static IntPtr raquet_as_wkb(IntPtr rq, IntPtr variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.raquet_as_wkb(rq, variant, size_out));

        public static string raquet_as_hexwkb(IntPtr rq, IntPtr variant, IntPtr size_out)
            => SafeExecution<string>(() => MEOSExternalFunctions.raquet_as_hexwkb(rq, variant, size_out));

        public static IntPtr raquet_make(IntPtr quadbin, IntPtr width, IntPtr height, IntPtr pixtype, double nodata, bool has_nodata, IntPtr pixels)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.raquet_make(quadbin, width, height, pixtype, nodata, has_nodata, pixels));

        public static IntPtr raquet_copy(IntPtr rq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.raquet_copy(rq));

        public static IntPtr raquet_read(string path, IntPtr quadbin)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.raquet_read(path, quadbin));

        public static IntPtr raquet_read_bytes(IntPtr data, IntPtr size, IntPtr quadbin)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.raquet_read_bytes(data, size, quadbin));

        public static IntPtr raquet_quadbin(IntPtr rq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.raquet_quadbin(rq));

        public static int raquet_width(IntPtr rq)
            => SafeExecution<int>(() => MEOSExternalFunctions.raquet_width(rq));

        public static int raquet_height(IntPtr rq)
            => SafeExecution<int>(() => MEOSExternalFunctions.raquet_height(rq));

        public static double raquet_nodata(IntPtr rq)
            => SafeExecution<double>(() => MEOSExternalFunctions.raquet_nodata(rq));

        public static int raquet_cmp(IntPtr rq1, IntPtr rq2)
            => SafeExecution<int>(() => MEOSExternalFunctions.raquet_cmp(rq1, rq2));

        public static bool raquet_eq(IntPtr rq1, IntPtr rq2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.raquet_eq(rq1, rq2));

        public static IntPtr raster_tile_value_quadbin(IntPtr pixels, IntPtr width, IntPtr height, IntPtr quadbin, IntPtr pixtype, double nodata, bool has_nodata, IntPtr traj)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.raster_tile_value_quadbin(pixels, width, height, quadbin, pixtype, nodata, has_nodata, traj));

        public static IntPtr raster_tile_value(IntPtr rq, IntPtr traj)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.raster_tile_value(rq, traj));

        public static IntPtr[] trajectory_quadbins(IntPtr traj, uint zoom)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.trajectory_quadbins(traj, zoom, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static string trgeometry_out(IntPtr temp)
            => SafeExecution<string>(() => MEOSExternalFunctions.trgeometry_out(temp));

        public static IntPtr trgeometryinst_make(IntPtr geom, IntPtr pose, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometryinst_make(geom, pose, t));

        public static IntPtr geo_tpose_to_trgeometry(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_tpose_to_trgeometry(gs, temp));

        public static IntPtr trgeometry_to_tpose(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_to_tpose(temp));

        public static IntPtr trgeometry_to_tpoint(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_to_tpoint(temp));

        public static IntPtr trgeometry_to_tgeometry(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_to_tgeometry(temp));

        public static IntPtr trgeometry_end_instant(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_end_instant(temp));

        public static IntPtr trgeometry_end_sequence(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_end_sequence(temp));

        public static IntPtr trgeometry_end_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_end_value(temp));

        public static IntPtr trgeometry_geom(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_geom(temp));

        public static IntPtr trgeometry_instant_n(IntPtr temp, int n)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_instant_n(temp, n));

        public static IntPtr[] trgeometry_instants(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_instants(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr trgeometry_points(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_points(temp));

        public static IntPtr trgeometry_rotation(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_rotation(temp));

        public static IntPtr[] trgeometry_segments(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_segments(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr trgeometry_sequence_n(IntPtr temp, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_sequence_n(temp, i));

        public static IntPtr[] trgeometry_sequences(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_sequences(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr trgeometry_start_instant(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_start_instant(temp));

        public static IntPtr trgeometry_start_sequence(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_start_sequence(temp));

        public static IntPtr trgeometry_start_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_start_value(temp));

        public static bool trgeometry_value_n(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.trgeometry_value_n(temp, n, result));

        public static IntPtr trgeometry_traversed_area(IntPtr temp, bool unary_union)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_traversed_area(temp, unary_union));

        public static IntPtr trgeometry_centroid(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_centroid(temp));

        public static IntPtr trgeometry_convex_hull(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_convex_hull(temp));

        public static IntPtr trgeometry_body_point_trajectory(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_body_point_trajectory(temp, gs));

        public static IntPtr[] trgeometry_space_boxes(IntPtr temp, double xsize, double ysize, double zsize, IntPtr sorigin, bool bitmatrix, bool border_inc)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_space_boxes(temp, xsize, ysize, zsize, sorigin, bitmatrix, border_inc, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] trgeometry_space_time_boxes(IntPtr temp, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, long torigin, bool bitmatrix, bool border_inc)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_space_time_boxes(temp, xsize, ysize, zsize, duration, sorigin, torigin, bitmatrix, border_inc, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] trgeometry_stboxes(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_stboxes(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] trgeometry_split_n_stboxes(IntPtr temp, int box_count)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_split_n_stboxes(temp, box_count, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] trgeometry_split_each_n_stboxes(IntPtr temp, int elem_count)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_split_each_n_stboxes(temp, elem_count, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static double trgeometry_hausdorff_distance(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => MEOSExternalFunctions.trgeometry_hausdorff_distance(temp1, temp2));

        public static double trgeometry_frechet_distance(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => MEOSExternalFunctions.trgeometry_frechet_distance(temp1, temp2));

        public static double trgeometry_dyntimewarp_distance(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => MEOSExternalFunctions.trgeometry_dyntimewarp_distance(temp1, temp2));

        public static IntPtr[] trgeometry_frechet_path(IntPtr temp1, IntPtr temp2)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_frechet_path(temp1, temp2, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] trgeometry_dyntimewarp_path(IntPtr temp1, IntPtr temp2)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_dyntimewarp_path(temp1, temp2, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static double trgeometry_length(IntPtr temp)
            => SafeExecution<double>(() => MEOSExternalFunctions.trgeometry_length(temp));

        public static IntPtr trgeometry_cumulative_length(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_cumulative_length(temp));

        public static IntPtr trgeometry_speed(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_speed(temp));

        public static IntPtr trgeometry_twcentroid(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_twcentroid(temp));

        public static IntPtr trgeometry_append_tinstant(IntPtr temp, IntPtr inst, int interp, double maxdist, IntPtr maxt, bool expand)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_append_tinstant(temp, inst, interp, maxdist, maxt, expand));

        public static IntPtr trgeometry_append_tsequence(IntPtr temp, IntPtr seq, bool expand)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_append_tsequence(temp, seq, expand));

        public static IntPtr trgeometry_delete_timestamptz(IntPtr temp, long t, bool connect)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_delete_timestamptz(temp, t, connect));

        public static IntPtr trgeometry_delete_tstzset(IntPtr temp, IntPtr s, bool connect)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_delete_tstzset(temp, s, connect));

        public static IntPtr trgeometry_delete_tstzspan(IntPtr temp, IntPtr s, bool connect)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_delete_tstzspan(temp, s, connect));

        public static IntPtr trgeometry_delete_tstzspanset(IntPtr temp, IntPtr ss, bool connect)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_delete_tstzspanset(temp, ss, connect));

        public static IntPtr trgeometry_round(IntPtr temp, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_round(temp, maxdd));

        public static IntPtr trgeometry_set_interp(IntPtr temp, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_set_interp(temp, interp));

        public static IntPtr trgeometry_to_tinstant(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_to_tinstant(temp));

        public static IntPtr trgeometry_after_timestamptz(IntPtr temp, long t, bool strict)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_after_timestamptz(temp, t, strict));

        public static IntPtr trgeometry_before_timestamptz(IntPtr temp, long t, bool strict)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_before_timestamptz(temp, t, strict));

        public static IntPtr trgeometry_restrict_values(IntPtr temp, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_restrict_values(temp, s, atfunc));

        public static IntPtr trgeometry_restrict_timestamptz(IntPtr temp, long t, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_restrict_timestamptz(temp, t, atfunc));

        public static IntPtr trgeometry_restrict_tstzset(IntPtr temp, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_restrict_tstzset(temp, s, atfunc));

        public static IntPtr trgeometry_restrict_tstzspan(IntPtr temp, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_restrict_tstzspan(temp, s, atfunc));

        public static IntPtr trgeometry_restrict_tstzspanset(IntPtr temp, IntPtr ss, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_restrict_tstzspanset(temp, ss, atfunc));

        public static IntPtr trgeometry_at_geom(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_at_geom(temp, gs));

        public static IntPtr trgeometry_minus_geom(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_minus_geom(temp, gs));

        public static IntPtr trgeometry_at_stbox(IntPtr temp, IntPtr box, bool border_inc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_at_stbox(temp, box, border_inc));

        public static IntPtr trgeometry_minus_stbox(IntPtr temp, IntPtr box, bool border_inc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_minus_stbox(temp, box, border_inc));

        public static IntPtr tdistance_trgeometry_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdistance_trgeometry_geo(temp, gs));

        public static IntPtr tdistance_trgeometry_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdistance_trgeometry_tpoint(temp1, temp2));

        public static IntPtr tdistance_trgeometry_trgeometry(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdistance_trgeometry_trgeometry(temp1, temp2));

        public static double nad_stbox_trgeometry(IntPtr box, IntPtr temp)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_stbox_trgeometry(box, temp));

        public static double nad_trgeometry_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_trgeometry_geo(temp, gs));

        public static double nad_trgeometry_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_trgeometry_stbox(temp, box));

        public static double nad_trgeometry_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_trgeometry_tpoint(temp1, temp2));

        public static double nad_trgeometry_trgeometry(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_trgeometry_trgeometry(temp1, temp2));

        public static IntPtr nai_trgeometry_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nai_trgeometry_geo(temp, gs));

        public static IntPtr nai_trgeometry_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nai_trgeometry_tpoint(temp1, temp2));

        public static IntPtr nai_trgeometry_trgeometry(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nai_trgeometry_trgeometry(temp1, temp2));

        public static IntPtr shortestline_trgeometry_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.shortestline_trgeometry_geo(temp, gs));

        public static IntPtr shortestline_trgeometry_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.shortestline_trgeometry_tpoint(temp1, temp2));

        public static IntPtr shortestline_trgeometry_trgeometry(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.shortestline_trgeometry_trgeometry(temp1, temp2));

        public static int always_eq_geo_trgeometry(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_geo_trgeometry(gs, temp));

        public static int always_eq_trgeometry_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_trgeometry_geo(temp, gs));

        public static int always_eq_trgeometry_trgeometry(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_eq_trgeometry_trgeometry(temp1, temp2));

        public static int always_ne_geo_trgeometry(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_geo_trgeometry(gs, temp));

        public static int always_ne_trgeometry_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_trgeometry_geo(temp, gs));

        public static int always_ne_trgeometry_trgeometry(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.always_ne_trgeometry_trgeometry(temp1, temp2));

        public static int ever_eq_geo_trgeometry(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_geo_trgeometry(gs, temp));

        public static int ever_eq_trgeometry_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_trgeometry_geo(temp, gs));

        public static int ever_eq_trgeometry_trgeometry(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_eq_trgeometry_trgeometry(temp1, temp2));

        public static int ever_ne_geo_trgeometry(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_geo_trgeometry(gs, temp));

        public static int ever_ne_trgeometry_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_trgeometry_geo(temp, gs));

        public static int ever_ne_trgeometry_trgeometry(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.ever_ne_trgeometry_trgeometry(temp1, temp2));

        public static IntPtr teq_geo_trgeometry(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_geo_trgeometry(gs, temp));

        public static IntPtr teq_trgeometry_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_trgeometry_geo(temp, gs));

        public static IntPtr tne_geo_trgeometry(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_geo_trgeometry(gs, temp));

        public static IntPtr tne_trgeometry_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_trgeometry_geo(temp, gs));

        public static int econtains_geo_trgeometry(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.econtains_geo_trgeometry(gs, temp));

        public static int acontains_geo_trgeometry(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.acontains_geo_trgeometry(gs, temp));

        public static int ecovers_geo_trgeometry(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.ecovers_geo_trgeometry(gs, temp));

        public static int acovers_geo_trgeometry(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.acovers_geo_trgeometry(gs, temp));

        public static int ecovers_trgeometry_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.ecovers_trgeometry_geo(temp, gs));

        public static int acovers_trgeometry_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.acovers_trgeometry_geo(temp, gs));

        public static int edisjoint_trgeometry_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.edisjoint_trgeometry_geo(temp, gs));

        public static int adisjoint_trgeometry_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.adisjoint_trgeometry_geo(temp, gs));

        public static int eintersects_trgeometry_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.eintersects_trgeometry_geo(temp, gs));

        public static int aintersects_trgeometry_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.aintersects_trgeometry_geo(temp, gs));

        public static int etouches_trgeometry_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.etouches_trgeometry_geo(temp, gs));

        public static int atouches_trgeometry_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.atouches_trgeometry_geo(temp, gs));

        public static int edwithin_trgeometry_geo(IntPtr temp, IntPtr gs, double dist)
            => SafeExecution<int>(() => MEOSExternalFunctions.edwithin_trgeometry_geo(temp, gs, dist));

        public static int adwithin_trgeometry_geo(IntPtr temp, IntPtr gs, double dist)
            => SafeExecution<int>(() => MEOSExternalFunctions.adwithin_trgeometry_geo(temp, gs, dist));

        public static int edisjoint_trgeometry_trgeometry(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.edisjoint_trgeometry_trgeometry(temp1, temp2));

        public static int adisjoint_trgeometry_trgeometry(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.adisjoint_trgeometry_trgeometry(temp1, temp2));

        public static int eintersects_trgeometry_trgeometry(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.eintersects_trgeometry_trgeometry(temp1, temp2));

        public static int aintersects_trgeometry_trgeometry(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.aintersects_trgeometry_trgeometry(temp1, temp2));

        public static int edwithin_trgeometry_trgeometry(IntPtr temp1, IntPtr temp2, double dist)
            => SafeExecution<int>(() => MEOSExternalFunctions.edwithin_trgeometry_trgeometry(temp1, temp2, dist));

        public static int adwithin_trgeometry_trgeometry(IntPtr temp1, IntPtr temp2, double dist)
            => SafeExecution<int>(() => MEOSExternalFunctions.adwithin_trgeometry_trgeometry(temp1, temp2, dist));

        public static bool ensure_valid_tnpoint_npoint(IntPtr temp, IntPtr np)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tnpoint_npoint(temp, np));

        public static bool ensure_valid_tnpoint_npointset(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tnpoint_npointset(temp, s));

        public static bool ensure_valid_tnpoint_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tnpoint_geo(temp, gs));

        public static bool ensure_valid_tnpoint_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tnpoint_stbox(temp, box));

        public static bool ensure_valid_tnpoint_tnpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tnpoint_tnpoint(temp1, temp2));

        public static int tnpointsegm_intersection(long start1, long end1, long start2, long end2, long lower, long upper, IntPtr t1, IntPtr t2)
            => SafeExecution<int>(() => MEOSExternalFunctions.tnpointsegm_intersection(start1, end1, start2, end2, lower, upper, t1, t2));

        public static bool common_rid_tnpoint_npoint(IntPtr temp, IntPtr np)
            => SafeExecution<bool>(() => MEOSExternalFunctions.common_rid_tnpoint_npoint(temp, np));

        public static bool common_rid_tnpoint_npointset(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.common_rid_tnpoint_npointset(temp, s));

        public static bool common_rid_tnpoint_tnpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.common_rid_tnpoint_tnpoint(temp1, temp2));

        public static bool npoint_collinear(IntPtr np1, IntPtr np2, IntPtr np3, double ratio)
            => SafeExecution<bool>(() => MEOSExternalFunctions.npoint_collinear(np1, np2, np3, ratio));

        public static IntPtr npointsegm_interpolate(IntPtr start, IntPtr end, IntPtr ratio)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.npointsegm_interpolate(start, end, ratio));

        public static IntPtr npointsegm_locate(IntPtr start, IntPtr end, IntPtr value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.npointsegm_locate(start, end, value));

        public static IntPtr npointarr_geom(IntPtr points, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.npointarr_geom(points, count));

        public static IntPtr nsegmentarr_geom(IntPtr segments, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nsegmentarr_geom(segments, count));

        public static (IntPtr[], IntPtr[]) nsegmentarr_normalize()
        {
            IntPtr _out_segments = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => MEOSExternalFunctions.nsegmentarr_normalize(_out_segments, _count_count));
                int _n = Marshal.ReadInt32(_count_count);
                IntPtr[] _resultArr = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _resultArr[_i] = Marshal.ReadIntPtr(_resultPtr, _i * IntPtr.Size); }
                IntPtr __out_segments_arr = Marshal.ReadIntPtr(_out_segments);
                IntPtr[] __out_segments_out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { __out_segments_out[_i] = Marshal.ReadIntPtr(__out_segments_arr, _i * IntPtr.Size); }
                return (_resultArr, __out_segments_out);
            }
            finally
            {
            Marshal.FreeHGlobal(_out_segments);
            Marshal.FreeHGlobal(_count_count);
            }
        }

        public static string npoint_wkt_out(long value, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.npoint_wkt_out(value, maxdd));

        public static void npoint_set(IntPtr rid, double pos, IntPtr np)
            => SafeExecution(() => MEOSExternalFunctions.npoint_set(rid, pos, np));

        public static void nsegment_set(IntPtr rid, double pos1, double pos2, IntPtr ns)
            => SafeExecution(() => MEOSExternalFunctions.nsegment_set(rid, pos1, pos2, ns));

        public static long datum_npoint_round(long npoint, long size)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_npoint_round(npoint, size));

        public static IntPtr tnpointinst_tgeompointinst(IntPtr inst)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpointinst_tgeompointinst(inst));

        public static IntPtr tnpointseq_tgeompointseq_disc(IntPtr @is)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpointseq_tgeompointseq_disc(@is));

        public static IntPtr tnpointseq_tgeompointseq_cont(IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpointseq_tgeompointseq_cont(seq));

        public static IntPtr tnpointseqset_tgeompointseqset(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpointseqset_tgeompointseqset(ss));

        public static IntPtr tgeompointinst_tnpointinst(IntPtr inst)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeompointinst_tnpointinst(inst));

        public static IntPtr tgeompointseq_tnpointseq(IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeompointseq_tnpointseq(seq));

        public static IntPtr tgeompointseqset_tnpointseqset(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeompointseqset_tnpointseqset(ss));

        public static IntPtr tnpointinst_positions(IntPtr inst)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpointinst_positions(inst));

        public static IntPtr[] tnpointseq_positions(IntPtr seq)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpointseq_positions(seq, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] tnpointseqset_positions(IntPtr ss)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpointseqset_positions(ss, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr tnpointinst_route(IntPtr inst)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpointinst_route(inst));

        public static IntPtr tnpointinst_routes(IntPtr inst)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpointinst_routes(inst));

        public static IntPtr tnpointseq_disc_routes(IntPtr @is)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpointseq_disc_routes(@is));

        public static IntPtr tnpointseq_cont_routes(IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpointseq_cont_routes(seq));

        public static IntPtr tnpointseqset_routes(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpointseqset_routes(ss));

        public static IntPtr tnpointseq_linear_positions(IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpointseq_linear_positions(seq));

        public static IntPtr tnpoint_restrict_stbox(IntPtr temp, IntPtr box, bool border_inc, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_restrict_stbox(temp, box, border_inc, atfunc));

        public static IntPtr tnpoint_restrict_npoint(IntPtr temp, IntPtr np, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_restrict_npoint(temp, np, atfunc));

        public static IntPtr tnpoint_restrict_npointset(IntPtr temp, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_restrict_npointset(temp, s, atfunc));

        public static bool npoint_set_stbox(IntPtr np, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.npoint_set_stbox(np, box));

        public static void npointarr_set_stbox(IntPtr values, int count, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.npointarr_set_stbox(values, count, box));

        public static bool nsegment_set_stbox(IntPtr ns, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.nsegment_set_stbox(ns, box));

        public static bool npoint_timestamptz_set_stbox(IntPtr np, long t, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.npoint_timestamptz_set_stbox(np, t, box));

        public static bool npoint_tstzspan_set_stbox(IntPtr np, IntPtr s, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.npoint_tstzspan_set_stbox(np, s, box));

        public static void tnpointinst_set_stbox(IntPtr inst, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tnpointinst_set_stbox(inst, box));

        public static void tnpointinstarr_set_stbox(IntPtr inst, int count, int interp, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tnpointinstarr_set_stbox(inst, count, interp, box));

        public static void tnpointseq_expand_stbox(IntPtr seq, IntPtr inst)
            => SafeExecution(() => MEOSExternalFunctions.tnpointseq_expand_stbox(seq, inst));

        public static long datum_npoint_distance(long np1, long np2)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_npoint_distance(np1, np2));

        public static IntPtr npoint_parse(IntPtr str, bool end)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.npoint_parse(str, end));

        public static IntPtr nsegment_parse(IntPtr str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nsegment_parse(str));

        public static bool contains_rid_tnpoint_bigint(IntPtr temp, IntPtr rid, int invert)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_rid_tnpoint_bigint(temp, rid, invert));

        public static bool contained_rid_tnpoint_bigint(IntPtr temp, IntPtr rid, bool invert)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_rid_tnpoint_bigint(temp, rid, invert));

        public static bool same_rid_tnpoint_bigint(IntPtr temp, IntPtr rid, int invert)
            => SafeExecution<bool>(() => MEOSExternalFunctions.same_rid_tnpoint_bigint(temp, rid, invert));

        public static bool overlaps_rid_tnpoint_bigintset(IntPtr temp, IntPtr s, int invert)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_rid_tnpoint_bigintset(temp, s, invert));

        public static bool contains_rid_tnpoint_bigintset(IntPtr temp, IntPtr s, bool invert)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_rid_tnpoint_bigintset(temp, s, invert));

        public static bool contained_rid_tnpoint_bigintset(IntPtr temp, IntPtr s, bool invert)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_rid_tnpoint_bigintset(temp, s, invert));

        public static bool same_rid_tnpoint_bigintset(IntPtr temp, IntPtr s, int invert)
            => SafeExecution<bool>(() => MEOSExternalFunctions.same_rid_tnpoint_bigintset(temp, s, invert));

        public static bool contains_rid_tnpoint_npoint(IntPtr temp, IntPtr np, int invert)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_rid_tnpoint_npoint(temp, np, invert));

        public static bool contained_rid_npoint_tnpoint(IntPtr temp, IntPtr np, bool invert)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_rid_npoint_tnpoint(temp, np, invert));

        public static bool same_rid_tnpoint_npoint(IntPtr temp, IntPtr np, int invert)
            => SafeExecution<bool>(() => MEOSExternalFunctions.same_rid_tnpoint_npoint(temp, np, invert));

        public static bool overlaps_rid_tnpoint_tnpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_rid_tnpoint_tnpoint(temp1, temp2));

        public static bool contains_rid_tnpoint_tnpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_rid_tnpoint_tnpoint(temp1, temp2));

        public static bool contained_rid_tnpoint_tnpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_rid_tnpoint_tnpoint(temp1, temp2));

        public static bool same_rid_tnpoint_tnpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.same_rid_tnpoint_tnpoint(temp1, temp2));

        public static bool ensure_same_rid_tnpointinst(IntPtr inst1, IntPtr inst2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_same_rid_tnpointinst(inst1, inst2));

        public static IntPtr tnpoint_restrict_geom(IntPtr temp, IntPtr gs, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnpoint_restrict_geom(temp, gs, atfunc));

        public static int meos_pc_schema_get_srid(uint pcid)
            => SafeExecution<int>(() => MEOSExternalFunctions.meos_pc_schema_get_srid(pcid));

        public static bool ensure_same_pcid_pcpatch(IntPtr pa1, IntPtr pa2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_same_pcid_pcpatch(pa1, pa2));

        public static bool ensure_valid_pcpatchset_pcpatch(IntPtr s, IntPtr pa)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_pcpatchset_pcpatch(s, pa));

        public static IntPtr pcpatch_parse(IntPtr str, bool end)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pcpatch_parse(str, end));

        public static IntPtr pcpatch_filter_per_point(IntPtr pa, int pred, IntPtr extra, bool keep_when_true)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pcpatch_filter_per_point(pa, pred, extra, keep_when_true));

        public static bool pcpatch_any_point_matches(IntPtr pa, int pred, IntPtr extra)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pcpatch_any_point_matches(pa, pred, extra));

        public static bool pcpoint_in_tpcbox(IntPtr pt, IntPtr extra)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pcpoint_in_tpcbox(pt, extra));

        public static bool pcpoint_intersects_geometry(IntPtr pt, IntPtr extra)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pcpoint_intersects_geometry(pt, extra));

        public static bool ensure_same_pcid_pcpoint(IntPtr pt1, IntPtr pt2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_same_pcid_pcpoint(pt1, pt2));

        public static bool ensure_valid_pcpointset_pcpoint(IntPtr s, IntPtr pt)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_pcpointset_pcpoint(s, pt));

        public static IntPtr pcpoint_parse(IntPtr str, bool end)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pcpoint_parse(str, end));

        public static IntPtr meos_pc_point_serialize(IntPtr pcpt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.meos_pc_point_serialize(pcpt));

        public static IntPtr meos_pc_point_deserialize(IntPtr serpt, IntPtr schema)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.meos_pc_point_deserialize(serpt, schema));

        public static ulong meos_pc_patch_serialized_size(IntPtr patch)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.meos_pc_patch_serialized_size(patch));

        public static IntPtr meos_pc_patch_serialize(IntPtr patch_in, IntPtr userdata)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.meos_pc_patch_serialize(patch_in, userdata));

        public static IntPtr meos_pc_patch_serialize_to_uncompressed(IntPtr patch_in)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.meos_pc_patch_serialize_to_uncompressed(patch_in));

        public static IntPtr meos_pc_patch_deserialize(IntPtr serpatch, IntPtr schema)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.meos_pc_patch_deserialize(serpatch, schema));

        public static void tpointcloudinst_set_tpcbox(IntPtr inst, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tpointcloudinst_set_tpcbox(inst, box));

        public static void tpointcloudinstarr_set_tpcbox(IntPtr instants, int count, bool lower_inc, bool upper_inc, int interp, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tpointcloudinstarr_set_tpcbox(instants, count, lower_inc, upper_inc, interp, box));

        public static void tpointcloudseq_expand_tpcbox(IntPtr seq, IntPtr inst)
            => SafeExecution(() => MEOSExternalFunctions.tpointcloudseq_expand_tpcbox(seq, inst));

        public static void tpointcloudseqarr_set_tpcbox(IntPtr sequences, int count, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tpointcloudseqarr_set_tpcbox(sequences, count, box));

        public static IntPtr tpcbox_extent_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpcbox_extent_transfn(state, temp));

        public static bool boxop_tpointcloud_tpcbox(IntPtr temp, IntPtr box, IntPtr func, bool inverted)
            => SafeExecution<bool>(() => MEOSExternalFunctions.boxop_tpointcloud_tpcbox(temp, box, func, inverted));

        public static bool boxop_tpointcloud_tpointcloud(IntPtr temp1, IntPtr temp2, IntPtr func)
            => SafeExecution<bool>(() => MEOSExternalFunctions.boxop_tpointcloud_tpointcloud(temp1, temp2, func));

        public static void tpcbox_set_stbox(IntPtr src, IntPtr dst)
            => SafeExecution(() => MEOSExternalFunctions.tpcbox_set_stbox(src, dst));

        public static double nad_tpcbox_tpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tpcbox_tpcbox(box1, box2));

        public static double nad_tpointcloud_tpcbox(IntPtr temp, IntPtr box)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tpointcloud_tpcbox(temp, box));

        public static double nad_tpointcloud_tpointcloud(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tpointcloud_tpointcloud(temp1, temp2));

        public static IntPtr tpcbox_parse(IntPtr str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpcbox_parse(str));

        public static bool tpcbox_index_leaf_consistent(IntPtr key, IntPtr query, int strategy)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpcbox_index_leaf_consistent(key, query, strategy));

        public static bool tpcbox_gist_inner_consistent(IntPtr key, IntPtr query, int strategy)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpcbox_gist_inner_consistent(key, query, strategy));

        public static bool tpcbox_index_recheck(int strategy)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpcbox_index_recheck(strategy));

        public static bool ensure_valid_pose_geo(IntPtr pose, IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_pose_geo(pose, gs));

        public static bool ensure_valid_pose_stbox(IntPtr pose, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_pose_stbox(pose, box));

        public static bool ensure_valid_pose_pose(IntPtr pose1, IntPtr pose2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_pose_pose(pose1, pose2));

        public static bool ensure_valid_poseset_pose(IntPtr s, IntPtr pose)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_poseset_pose(s, pose));

        public static bool pose_collinear(IntPtr pose1, IntPtr pose2, IntPtr pose3, double ratio)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pose_collinear(pose1, pose2, pose3, ratio));

        public static IntPtr posesegm_interpolate(IntPtr start, IntPtr end, double ratio)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.posesegm_interpolate(start, end, ratio));

        public static IntPtr posesegm_locate(IntPtr start, IntPtr end, IntPtr value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.posesegm_locate(start, end, value));

        public static string pose_wkt_out(IntPtr pose, bool extended, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.pose_wkt_out(pose, extended, maxdd));

        public static IntPtr pose_parse(IntPtr str, bool end)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pose_parse(str, end));

        public static long datum_pose_point(long pose)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_pose_point(pose));

        public static long datum_pose_geopoint(long pose)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_pose_geopoint(pose));

        public static long datum_pose_rotation(long pose)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_pose_rotation(pose));

        public static long datum_pose_yaw(long pose)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_pose_yaw(pose));

        public static long datum_pose_pitch(long pose)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_pose_pitch(pose));

        public static long datum_pose_roll(long pose)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_pose_roll(pose));

        public static long datum_pose_apply_geo(long pose, long body)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_pose_apply_geo(pose, body));

        public static long datum_pose_round(long pose, long size)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_pose_round(pose, size));

        public static long pose_distance(long pose1, long pose2)
            => SafeExecution<long>(() => MEOSExternalFunctions.pose_distance(pose1, pose2));

        public static bool pose_set_stbox(IntPtr pose, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pose_set_stbox(pose, box));

        public static void posearr_set_stbox(IntPtr values, int count, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.posearr_set_stbox(values, count, box));

        public static bool pose_timestamptz_set_stbox(IntPtr pose, long t, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pose_timestamptz_set_stbox(pose, t, box));

        public static bool pose_tstzspan_set_stbox(IntPtr pose, IntPtr p, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pose_tstzspan_set_stbox(pose, p, box));

        public static bool ensure_valid_tpose_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tpose_geo(temp, gs));

        public static bool ensure_valid_tpose_pose(IntPtr temp, IntPtr pose)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tpose_pose(temp, pose));

        public static bool ensure_valid_tpose_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tpose_stbox(temp, box));

        public static bool ensure_valid_tpose_tpose(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tpose_tpose(temp1, temp2));

        public static int tposesegm_intersection_value(long start, long end, long value, long lower, long upper, IntPtr t1, IntPtr t2)
            => SafeExecution<int>(() => MEOSExternalFunctions.tposesegm_intersection_value(start, end, value, lower, upper, t1, t2));

        public static int tposesegm_intersection(long start1, long end1, long start2, long end2, long lower, long upper, IntPtr t1, IntPtr t2)
            => SafeExecution<int>(() => MEOSExternalFunctions.tposesegm_intersection(start1, end1, start2, end2, lower, upper, t1, t2));

        public static void tposeinst_set_stbox(IntPtr inst, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tposeinst_set_stbox(inst, box));

        public static void tposeinstarr_set_stbox(IntPtr instants, int count, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tposeinstarr_set_stbox(instants, count, box));

        public static void tposeseq_expand_stbox(IntPtr seq, IntPtr inst)
            => SafeExecution(() => MEOSExternalFunctions.tposeseq_expand_stbox(seq, inst));

        public static IntPtr tpose_restrict_geom(IntPtr temp, IntPtr gs, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_restrict_geom(temp, gs, atfunc));

        public static IntPtr tpose_restrict_stbox(IntPtr temp, IntPtr box, bool border_inc, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_restrict_stbox(temp, box, border_inc, atfunc));

        public static IntPtr tpose_restrict_elevation(IntPtr temp, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpose_restrict_elevation(temp, s, atfunc));

        public static bool bool_in(string str)
            => SafeExecution<bool>(() => MEOSExternalFunctions.bool_in(str));

        public static string bool_out(bool b)
            => SafeExecution<string>(() => MEOSExternalFunctions.bool_out(b));

        public static string float8_out(double num, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.float8_out(num, maxdd));

        public static int date_in(string str)
            => SafeExecution<int>(() => MEOSExternalFunctions.date_in(str));

        public static string date_out(int date)
            => SafeExecution<string>(() => MEOSExternalFunctions.date_out(date));

        public static int interval_cmp(IntPtr interv1, IntPtr interv2)
            => SafeExecution<int>(() => MEOSExternalFunctions.interval_cmp(interv1, interv2));

        public static IntPtr interval_in(string str, int typmod)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.interval_in(str, typmod));

        public static string interval_out(IntPtr interv)
            => SafeExecution<string>(() => MEOSExternalFunctions.interval_out(interv));

        public static long time_in(string str, int typmod)
            => SafeExecution<long>(() => MEOSExternalFunctions.time_in(str, typmod));

        public static string time_out(long time)
            => SafeExecution<string>(() => MEOSExternalFunctions.time_out(time));

        public static long timestamp_in(string str, int typmod)
            => SafeExecution<long>(() => MEOSExternalFunctions.timestamp_in(str, typmod));

        public static string timestamp_out(long ts)
            => SafeExecution<string>(() => MEOSExternalFunctions.timestamp_out(ts));

        public static long timestamptz_in(string str, int typmod)
            => SafeExecution<long>(() => MEOSExternalFunctions.timestamptz_in(str, typmod));

        public static string timestamptz_out(long tstz)
            => SafeExecution<string>(() => MEOSExternalFunctions.timestamptz_out(tstz));

        public static IntPtr cstring_to_text(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cstring_to_text(str));

        public static string text_to_cstring(IntPtr txt)
            => SafeExecution<string>(() => MEOSExternalFunctions.text_to_cstring(txt));

        public static IntPtr text_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.text_in(str));

        public static string text_out(IntPtr txt)
            => SafeExecution<string>(() => MEOSExternalFunctions.text_out(txt));

        public static int text_cmp(IntPtr txt1, IntPtr txt2, uint collid)
            => SafeExecution<int>(() => MEOSExternalFunctions.text_cmp(txt1, txt2, collid));

        public static IntPtr text_copy(IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.text_copy(txt));

        public static IntPtr text_initcap(IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.text_initcap(txt));

        public static IntPtr text_lower(IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.text_lower(txt));

        public static IntPtr text_upper(IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.text_upper(txt));

        public static IntPtr textcat_text_text(IntPtr txt1, IntPtr txt2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.textcat_text_text(txt1, txt2));

        public static int ensure_valid_tquadbin_tquadbin(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.ensure_valid_tquadbin_tquadbin(temp1, temp2));

        public static bool ensure_valid_tquadbin_quadbin(IntPtr temp, IntPtr cell)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tquadbin_quadbin(temp, cell));

        public static bool ensure_valid_tquadbin_tgeompoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tquadbin_tgeompoint(temp1, temp2));

        public static long datum2_quadbin_eq(long d1, long d2, int type)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum2_quadbin_eq(d1, d2, type));

        public static long datum2_quadbin_ne(long d1, long d2, int type)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum2_quadbin_ne(d1, d2, type));

        public static bool quadbin_set_stbox(IntPtr cell, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.quadbin_set_stbox(cell, box));

        public static void quadbinarr_set_stbox(IntPtr values, int count, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.quadbinarr_set_stbox(values, count, box));

        public static void tquadbininst_set_stbox(IntPtr inst, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tquadbininst_set_stbox(inst, box));

        public static void tquadbininstarr_set_stbox(IntPtr instants, int count, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tquadbininstarr_set_stbox(instants, count, box));

        public static void tquadbinseq_expand_stbox(IntPtr seq, IntPtr inst)
            => SafeExecution(() => MEOSExternalFunctions.tquadbinseq_expand_stbox(seq, inst));

        public static int raquet_pixtype_size(IntPtr pixtype)
            => SafeExecution<int>(() => MEOSExternalFunctions.raquet_pixtype_size(pixtype));

        public static int raquet_pixels_size(IntPtr rq)
            => SafeExecution<int>(() => MEOSExternalFunctions.raquet_pixels_size(rq));

        public static bool raster_quadbin_from_bounds(double origin_x, double origin_y, double pixel_w, double pixel_h, int xsize, int ysize, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.raster_quadbin_from_bounds(origin_x, origin_y, pixel_w, pixel_h, xsize, ysize, result));

        public static bool ensure_has_geom(short flags)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_has_geom(flags));

        public static bool ensure_valid_trgeo_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_trgeo_geo(temp, gs));

        public static bool ensure_valid_trgeo_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_trgeo_stbox(temp, box));

        public static bool ensure_valid_trgeo_trgeo(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_trgeo_trgeo(temp1, temp2));

        public static bool ensure_valid_trgeo_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_trgeo_tpoint(temp1, temp2));

        public static IntPtr trgeo_geom_p(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_geom_p(temp));

        public static string trgeo_wkt_out(IntPtr temp, int maxdd, bool extended)
            => SafeExecution<string>(() => MEOSExternalFunctions.trgeo_wkt_out(temp, maxdd, extended));

        public static IntPtr geo_tposeinst_to_trgeo(IntPtr gs, IntPtr inst)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_tposeinst_to_trgeo(gs, inst));

        public static IntPtr geo_tposeseq_to_trgeo(IntPtr gs, IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_tposeseq_to_trgeo(gs, seq));

        public static IntPtr geo_tposeseqset_to_trgeo(IntPtr gs, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_tposeseqset_to_trgeo(gs, ss));

        public static bool trgeo_value_at_timestamptz(IntPtr temp, long t, bool strict, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.trgeo_value_at_timestamptz(temp, t, strict, result));

        public static IntPtr trgeometry_restrict_value(IntPtr temp, long value, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeometry_restrict_value(temp, value, atfunc));

        public static IntPtr trgeoinst_geom_p(IntPtr inst)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeoinst_geom_p(inst));

        public static ulong trgeoinst_pose_varsize(IntPtr inst)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.trgeoinst_pose_varsize(inst));

        public static void trgeoinst_set_pose(IntPtr inst)
            => SafeExecution(() => MEOSExternalFunctions.trgeoinst_set_pose(inst));

        public static IntPtr trgeoinst_tposeinst(IntPtr inst)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeoinst_tposeinst(inst));

        public static IntPtr trgeoinst_make1(IntPtr geom, IntPtr pose, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeoinst_make1(geom, pose, t));

        public static IntPtr trgeoseq_to_tinstant(IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeoseq_to_tinstant(seq));

        public static IntPtr trgeoseqset_to_tinstant(IntPtr ts)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeoseqset_to_tinstant(ts));

        public static IntPtr trgeo_restrict_geom(IntPtr temp, IntPtr gs, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_restrict_geom(temp, gs, atfunc));

        public static IntPtr trgeo_restrict_stbox(IntPtr temp, IntPtr box, bool border_inc, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_restrict_stbox(temp, box, border_inc, atfunc));

        public static int spatialrel_trgeo_trav_geo(IntPtr temp, IntPtr gs, long param, IntPtr func, int numparam, bool invert)
            => SafeExecution<int>(() => MEOSExternalFunctions.spatialrel_trgeo_trav_geo(temp, gs, param, func, numparam, invert));

        public static int ea_contains_geo_trgeo(IntPtr gs, IntPtr temp, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_contains_geo_trgeo(gs, temp, ever));

        public static int ea_contains_trgeo_geo(IntPtr temp, IntPtr gs, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_contains_trgeo_geo(temp, gs, ever));

        public static int ea_contains_trgeo_trgeo(IntPtr temp1, IntPtr temp2, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_contains_trgeo_trgeo(temp1, temp2, ever));

        public static int ea_covers_geo_trgeo(IntPtr gs, IntPtr temp, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_covers_geo_trgeo(gs, temp, ever));

        public static int ea_covers_trgeo_geo(IntPtr temp, IntPtr gs, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_covers_trgeo_geo(temp, gs, ever));

        public static int ea_covers_trgeo_trgeo(IntPtr temp1, IntPtr temp2, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_covers_trgeo_trgeo(temp1, temp2, ever));

        public static int ea_disjoint_geo_trgeo(IntPtr gs, IntPtr temp, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_disjoint_geo_trgeo(gs, temp, ever));

        public static int ea_disjoint_trgeo_geo(IntPtr temp, IntPtr gs, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_disjoint_trgeo_geo(temp, gs, ever));

        public static int ea_disjoint_trgeo_trgeo(IntPtr temp1, IntPtr temp2, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_disjoint_trgeo_trgeo(temp1, temp2, ever));

        public static int ea_intersects_geo_trgeo(IntPtr gs, IntPtr temp, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_intersects_geo_trgeo(gs, temp, ever));

        public static int ea_intersects_trgeo_geo(IntPtr temp, IntPtr gs, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_intersects_trgeo_geo(temp, gs, ever));

        public static int ea_intersects_trgeo_trgeo(IntPtr temp1, IntPtr temp2, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_intersects_trgeo_trgeo(temp1, temp2, ever));

        public static int ea_touches_geo_trgeo(IntPtr gs, IntPtr temp, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_touches_geo_trgeo(gs, temp, ever));

        public static int ea_touches_trgeo_geo(IntPtr temp, IntPtr gs, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_touches_trgeo_geo(temp, gs, ever));

        public static int ea_touches_trgeo_trgeo(IntPtr temp1, IntPtr temp2, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_touches_trgeo_trgeo(temp1, temp2, ever));

        public static int ea_dwithin_trgeo_geo(IntPtr temp, IntPtr gs, double dist, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_dwithin_trgeo_geo(temp, gs, dist, ever));

        public static int ea_dwithin_trgeo_trgeo(IntPtr temp1, IntPtr temp2, double dist, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.ea_dwithin_trgeo_trgeo(temp1, temp2, dist, ever));

        public static IntPtr trgeoseq_geom_p(IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeoseq_geom_p(seq));

        public static ulong trgeoseq_pose_varsize(IntPtr seq)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.trgeoseq_pose_varsize(seq));

        public static void trgeoseq_set_pose(IntPtr seq)
            => SafeExecution(() => MEOSExternalFunctions.trgeoseq_set_pose(seq));

        public static IntPtr trgeoseq_tposeseq(IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeoseq_tposeseq(seq));

        public static bool trgeoseq_make_valid(IntPtr geom, IntPtr instants, int count, bool lower_inc, bool upper_inc, bool linear)
            => SafeExecution<bool>(() => MEOSExternalFunctions.trgeoseq_make_valid(geom, instants, count, lower_inc, upper_inc, linear));

        public static IntPtr trgeoseq_make1_exp(IntPtr geom, IntPtr instants, int count, int maxcount, bool lower_inc, bool upper_inc, int interp, bool normalize)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeoseq_make1_exp(geom, instants, count, maxcount, lower_inc, upper_inc, interp, normalize));

        public static IntPtr trgeoseq_make1(IntPtr geom, IntPtr instants, int count, bool lower_inc, bool upper_inc, int interp, bool normalize)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeoseq_make1(geom, instants, count, lower_inc, upper_inc, interp, normalize));

        public static IntPtr trgeoseq_make_exp(IntPtr geom, IntPtr instants, int count, int maxcount, bool lower_inc, bool upper_inc, int interp, bool normalize)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeoseq_make_exp(geom, instants, count, maxcount, lower_inc, upper_inc, interp, normalize));

        public static IntPtr trgeoseq_make(IntPtr geom, IntPtr instants, int count, bool lower_inc, bool upper_inc, int interp, bool normalize)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeoseq_make(geom, instants, count, lower_inc, upper_inc, interp, normalize));

        public static IntPtr trgeoseq_make_free_exp(IntPtr geom, IntPtr instants, int count, int maxcount, bool lower_inc, bool upper_inc, int interp, bool normalize)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeoseq_make_free_exp(geom, instants, count, maxcount, lower_inc, upper_inc, interp, normalize));

        public static IntPtr trgeoseq_make_free(IntPtr geom, IntPtr instants, int count, bool lower_inc, bool upper_inc, int interp, bool normalize)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeoseq_make_free(geom, instants, count, lower_inc, upper_inc, interp, normalize));

        public static IntPtr trgeoinst_to_tsequence(IntPtr inst, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeoinst_to_tsequence(inst, interp));

        public static IntPtr trgeoseqset_geom_p(IntPtr ts)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeoseqset_geom_p(ts));

        public static IntPtr trgeoseqset_tposeseqset(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeoseqset_tposeseqset(ss));

        public static IntPtr trgeoseqset_make1_exp(IntPtr geom, IntPtr sequences, int count, int maxcount, bool normalize)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeoseqset_make1_exp(geom, sequences, count, maxcount, normalize));

        public static IntPtr trgeoseqset_make_exp(IntPtr geom, IntPtr sequences, int count, int maxcount, bool normalize)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeoseqset_make_exp(geom, sequences, count, maxcount, normalize));

        public static IntPtr trgeoseqset_make(IntPtr geom, IntPtr sequences, int count, bool normalize)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeoseqset_make(geom, sequences, count, normalize));

        public static IntPtr trgeoseqset_make_free(IntPtr geom, IntPtr sequences, int count, bool normalize)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeoseqset_make_free(geom, sequences, count, normalize));

        public static IntPtr trgeoseqset_make_gaps(IntPtr geom, IntPtr instants, int count, int interp, IntPtr maxt, double maxdist)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeoseqset_make_gaps(geom, instants, count, interp, maxt, maxdist));

        public static IntPtr trgeoseqset_to_tsequence(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeoseqset_to_tsequence(ss));

        public static IntPtr trgeo_to_tsequence(IntPtr temp, string interp_str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_to_tsequence(temp, interp_str));

        public static IntPtr trgeo_to_tsequenceset(IntPtr temp, string interp_str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_to_tsequenceset(temp, interp_str));

        public static void trgeoinst_set_stbox(IntPtr geom, IntPtr inst, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.trgeoinst_set_stbox(geom, inst, box));

        public static void trgeoinstarr_static_stbox(IntPtr geom, IntPtr instants, int count, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.trgeoinstarr_static_stbox(geom, instants, count, box));

        public static void trgeoinstarr_rotating_stbox(IntPtr geom, IntPtr instants, int count, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.trgeoinstarr_rotating_stbox(geom, instants, count, box));

        public static void trgeoinstarr_compute_bbox(IntPtr geom, IntPtr instants, int count, int interp, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.trgeoinstarr_compute_bbox(geom, instants, count, interp, box));

        public static bool ensure_span_isof_type(IntPtr s, int spantype)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_span_isof_type(s, spantype));

        public static bool ensure_span_isof_basetype(IntPtr s, int basetype)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_span_isof_basetype(s, basetype));

        public static bool ensure_same_span_type(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_same_span_type(s1, s2));

        public static bool ensure_valid_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_span_span(s1, s2));

        public static void span_deserialize(IntPtr s, IntPtr lower, IntPtr upper)
            => SafeExecution(() => MEOSExternalFunctions.span_deserialize(s, lower, upper));

        public static int span_bound_cmp(IntPtr b1, IntPtr b2)
            => SafeExecution<int>(() => MEOSExternalFunctions.span_bound_cmp(b1, b2));

        public static int span_bound_qsort_cmp(IntPtr s1, IntPtr s2)
            => SafeExecution<int>(() => MEOSExternalFunctions.span_bound_qsort_cmp(s1, s2));

        public static int span_lower_cmp(IntPtr s1, IntPtr s2)
            => SafeExecution<int>(() => MEOSExternalFunctions.span_lower_cmp(s1, s2));

        public static int span_upper_cmp(IntPtr s1, IntPtr s2)
            => SafeExecution<int>(() => MEOSExternalFunctions.span_upper_cmp(s1, s2));

        public static long span_decr_bound(long upper, int basetype)
            => SafeExecution<long>(() => MEOSExternalFunctions.span_decr_bound(upper, basetype));

        public static long span_incr_bound(long upper, int basetype)
            => SafeExecution<long>(() => MEOSExternalFunctions.span_incr_bound(upper, basetype));

        public static IntPtr spanarr_normalize(IntPtr spans, int count, bool sort, IntPtr newcount)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanarr_normalize(spans, count, sort, newcount));

        public static void span_bounds_shift_scale_value(long shift, long width, int type, bool hasshift, bool haswidth, IntPtr lower, IntPtr upper)
            => SafeExecution(() => MEOSExternalFunctions.span_bounds_shift_scale_value(shift, width, type, hasshift, haswidth, lower, upper));

        public static void span_bounds_shift_scale_time(IntPtr shift, IntPtr duration, IntPtr lower, IntPtr upper)
            => SafeExecution(() => MEOSExternalFunctions.span_bounds_shift_scale_time(shift, duration, lower, upper));

        public static void floatspan_floor_ceil_iter(IntPtr s, int func)
            => SafeExecution(() => MEOSExternalFunctions.floatspan_floor_ceil_iter(s, func));

        public static void numspan_delta_scale_iter(IntPtr s, long origin, long delta, bool hasdelta, double scale)
            => SafeExecution(() => MEOSExternalFunctions.numspan_delta_scale_iter(s, origin, delta, hasdelta, scale));

        public static void tstzspan_delta_scale_iter(IntPtr s, long origin, long delta, double scale)
            => SafeExecution(() => MEOSExternalFunctions.tstzspan_delta_scale_iter(s, origin, delta, scale));

        public static void numspan_shift_scale_iter(IntPtr s, long shift, long width, bool hasshift, bool haswidth, IntPtr delta, IntPtr scale)
            => SafeExecution(() => MEOSExternalFunctions.numspan_shift_scale_iter(s, shift, width, hasshift, haswidth, delta, scale));

        public static void tstzspan_shift_scale1(IntPtr s, IntPtr shift, IntPtr duration, IntPtr delta, IntPtr scale)
            => SafeExecution(() => MEOSExternalFunctions.tstzspan_shift_scale1(s, shift, duration, delta, scale));

        public static int mi_span_value(IntPtr s, long value, IntPtr result)
            => SafeExecution<int>(() => MEOSExternalFunctions.mi_span_value(s, value, result));

        public static double dist_double_value_value(long l, long r, int type)
            => SafeExecution<double>(() => MEOSExternalFunctions.dist_double_value_value(l, r, type));

        public static int trgeo_geom_clip_polygon(IntPtr a1, IntPtr b1, IntPtr a2, IntPtr b2, IntPtr pa, IntPtr intervals_out)
            => SafeExecution<int>(() => MEOSExternalFunctions.trgeo_geom_clip_polygon(a1, b1, a2, b2, pa, intervals_out));

        public static int trgeo_geom_clip_lwpoly(IntPtr a1, IntPtr b1, IntPtr a2, IntPtr b2, IntPtr poly, IntPtr intervals_out)
            => SafeExecution<int>(() => MEOSExternalFunctions.trgeo_geom_clip_lwpoly(a1, b1, a2, b2, poly, intervals_out));

        public static int trgeo_geom_clip_box(IntPtr a1, IntPtr b1, IntPtr a2, IntPtr b2, double xmin, double ymin, double xmax, double ymax, IntPtr intervals_out)
            => SafeExecution<int>(() => MEOSExternalFunctions.trgeo_geom_clip_box(a1, b1, a2, b2, xmin, ymin, xmax, ymax, intervals_out));

        public static int trgeo_geom_clip_polygon_posed(IntPtr p_a_local, IntPtr p_b_local, IntPtr pose1, IntPtr pose2, IntPtr pa, IntPtr intervals_out)
            => SafeExecution<int>(() => MEOSExternalFunctions.trgeo_geom_clip_polygon_posed(p_a_local, p_b_local, pose1, pose2, pa, intervals_out));

        public static int trgeo_geom_clip_lwpoly_posed(IntPtr p_a_local, IntPtr p_b_local, IntPtr pose1, IntPtr pose2, IntPtr poly, IntPtr intervals_out)
            => SafeExecution<int>(() => MEOSExternalFunctions.trgeo_geom_clip_lwpoly_posed(p_a_local, p_b_local, pose1, pose2, poly, intervals_out));

        public static int trgeo_geom_clip_box_posed(IntPtr p_a_local, IntPtr p_b_local, IntPtr pose1, IntPtr pose2, double xmin, double ymin, double xmax, double ymax, IntPtr intervals_out)
            => SafeExecution<int>(() => MEOSExternalFunctions.trgeo_geom_clip_box_posed(p_a_local, p_b_local, pose1, pose2, xmin, ymin, xmax, ymax, intervals_out));

        public static int trgeo_geom_clip_lwgeom(IntPtr a1, IntPtr b1, IntPtr a2, IntPtr b2, IntPtr geom, IntPtr intervals_out)
            => SafeExecution<int>(() => MEOSExternalFunctions.trgeo_geom_clip_lwgeom(a1, b1, a2, b2, geom, intervals_out));

        public static int trgeo_geom_clip_lwgeom_posed(IntPtr p_a_local, IntPtr p_b_local, IntPtr pose1, IntPtr pose2, IntPtr geom, IntPtr intervals_out)
            => SafeExecution<int>(() => MEOSExternalFunctions.trgeo_geom_clip_lwgeom_posed(p_a_local, p_b_local, pose1, pose2, geom, intervals_out));

        public static IntPtr trgeo_parse(IntPtr str, int temptype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.trgeo_parse(str, temptype));

        public static bool ensure_same_geom(IntPtr gs1, IntPtr gs2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_same_geom(gs1, gs2));

        public static void lwgeom_apply_pose(IntPtr pose, IntPtr geom)
            => SafeExecution(() => MEOSExternalFunctions.lwgeom_apply_pose(pose, geom));

        public static IntPtr geom_apply_pose(IntPtr gs, IntPtr pose)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geom_apply_pose(gs, pose));

        public static double geom_radius(IntPtr gs)
            => SafeExecution<double>(() => MEOSExternalFunctions.geom_radius(gs));

        public static int v_clip_tpoly_point(IntPtr poly, IntPtr point, IntPtr pose, IntPtr poly_feature, IntPtr dist)
            => SafeExecution<int>(() => MEOSExternalFunctions.v_clip_tpoly_point(poly, point, pose, poly_feature, dist));

        public static int v_clip_tpoly_tpoly(IntPtr poly1, IntPtr poly2, IntPtr pose1, IntPtr pose2, IntPtr poly1_feature, IntPtr poly2_feature, IntPtr dist)
            => SafeExecution<int>(() => MEOSExternalFunctions.v_clip_tpoly_tpoly(poly1, poly2, pose1, pose2, poly1_feature, poly2_feature, dist));

        public static void apply_pose_point4d(IntPtr p, IntPtr pose)
            => SafeExecution(() => MEOSExternalFunctions.apply_pose_point4d(p, pose));

        public static IntPtr tfunc_tinstant(IntPtr inst, IntPtr lfinfo)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfunc_tinstant(inst, lfinfo));

        public static IntPtr tfunc_tsequence(IntPtr seq, IntPtr lfinfo)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfunc_tsequence(seq, lfinfo));

        public static IntPtr tfunc_tsequenceset(IntPtr ss, IntPtr lfinfo)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfunc_tsequenceset(ss, lfinfo));

        public static IntPtr tfunc_temporal(IntPtr temp, IntPtr lfinfo)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfunc_temporal(temp, lfinfo));

        public static IntPtr tfunc_tinstant_base(IntPtr inst, long value, IntPtr lfinfo)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfunc_tinstant_base(inst, value, lfinfo));

        public static IntPtr tfunc_tsequence_base(IntPtr seq, long value, IntPtr lfinfo)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfunc_tsequence_base(seq, value, lfinfo));

        public static IntPtr tfunc_tsequenceset_base(IntPtr ss, long value, IntPtr lfinfo)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfunc_tsequenceset_base(ss, value, lfinfo));

        public static IntPtr tfunc_temporal_base(IntPtr temp, long value, IntPtr lfinfo)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfunc_temporal_base(temp, value, lfinfo));

        public static IntPtr tfunc_tinstant_tinstant(IntPtr inst1, IntPtr inst2, IntPtr lfinfo)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfunc_tinstant_tinstant(inst1, inst2, lfinfo));

        public static IntPtr tfunc_tdiscseq_tdiscseq(IntPtr seq1, IntPtr seq2, IntPtr lfinfo)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfunc_tdiscseq_tdiscseq(seq1, seq2, lfinfo));

        public static IntPtr tfunc_tcontseq_tcontseq(IntPtr seq1, IntPtr seq2, IntPtr lfinfo)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfunc_tcontseq_tcontseq(seq1, seq2, lfinfo));

        public static IntPtr tfunc_tsequenceset_tsequenceset(IntPtr ss1, IntPtr ss2, IntPtr lfinfo)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfunc_tsequenceset_tsequenceset(ss1, ss2, lfinfo));

        public static IntPtr tfunc_temporal_temporal(IntPtr temp1, IntPtr temp2, IntPtr lfinfo)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfunc_temporal_temporal(temp1, temp2, lfinfo));

        public static int eafunc_temporal_base(IntPtr temp, long value, IntPtr lfinfo)
            => SafeExecution<int>(() => MEOSExternalFunctions.eafunc_temporal_base(temp, value, lfinfo));

        public static int eafunc_temporal_temporal(IntPtr temp1, IntPtr temp2, IntPtr lfinfo)
            => SafeExecution<int>(() => MEOSExternalFunctions.eafunc_temporal_temporal(temp1, temp2, lfinfo));

        public static IntPtr lfunc_set(IntPtr set, IntPtr lfinfo)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.lfunc_set(set, lfinfo));

        public static string set_out_fn(IntPtr s, int maxdd, IntPtr value_out)
            => SafeExecution<string>(() => MEOSExternalFunctions.set_out_fn(s, maxdd, value_out));

        public static bool ensure_set_isof_type(IntPtr s, int settype)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_set_isof_type(s, settype));

        public static bool ensure_valid_set_set(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_set_set(s1, s2));

        public static bool set_find_value(IntPtr s, long arg1, IntPtr loc)
            => SafeExecution<bool>(() => MEOSExternalFunctions.set_find_value(s, arg1, loc));

        public static IntPtr set_unnest_state_make(IntPtr set)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_unnest_state_make(set));

        public static void set_unnest_state_next(IntPtr state)
            => SafeExecution(() => MEOSExternalFunctions.set_unnest_state_next(state));

        public static bool ensure_same_skiplist_subtype(IntPtr state, IntPtr subtype)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_same_skiplist_subtype(state, subtype));

        public static void skiplist_set_extra(IntPtr state, IntPtr data, IntPtr size)
            => SafeExecution(() => MEOSExternalFunctions.skiplist_set_extra(state, data, size));

        public static IntPtr skiplist_headval(IntPtr list)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.skiplist_headval(list));

        public static int common_entry_cmp(IntPtr i1, IntPtr i2)
            => SafeExecution<int>(() => MEOSExternalFunctions.common_entry_cmp(i1, i2));

        public static bool span_index_leaf_consistent(IntPtr key, IntPtr query, int strategy)
            => SafeExecution<bool>(() => MEOSExternalFunctions.span_index_leaf_consistent(key, query, strategy));

        public static bool span_gist_inner_consistent(IntPtr key, IntPtr query, int strategy)
            => SafeExecution<bool>(() => MEOSExternalFunctions.span_gist_inner_consistent(key, query, strategy));

        public static bool span_index_recheck(int strategy)
            => SafeExecution<bool>(() => MEOSExternalFunctions.span_index_recheck(strategy));

        public static int span_lower_qsort_cmp(IntPtr a, IntPtr b)
            => SafeExecution<int>(() => MEOSExternalFunctions.span_lower_qsort_cmp(a, b));

        public static int span_upper_qsort_cmp(IntPtr a, IntPtr b)
            => SafeExecution<int>(() => MEOSExternalFunctions.span_upper_qsort_cmp(a, b));

        public static IntPtr getQuadrant2D(IntPtr centroid, IntPtr query)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.getQuadrant2D(centroid, query));

        public static bool overlap2D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlap2D(nodebox, query));

        public static bool contain2D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contain2D(nodebox, query));

        public static bool left2D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left2D(nodebox, query));

        public static bool overLeft2D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overLeft2D(nodebox, query));

        public static bool right2D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right2D(nodebox, query));

        public static bool overRight2D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overRight2D(nodebox, query));

        public static bool adjacent2D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent2D(nodebox, query));

        public static double distance_span_nodespan(IntPtr query, IntPtr nodebox)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_span_nodespan(query, nodebox));

        public static bool span_spgist_get_span(long value, int type, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.span_spgist_get_span(value, type, result));

        public static void spannode_init(IntPtr nodebox, int spantype, int basetype)
            => SafeExecution(() => MEOSExternalFunctions.spannode_init(nodebox, spantype, basetype));

        public static IntPtr spannode_copy(IntPtr orig)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spannode_copy(orig));

        public static void spannode_quadtree_next(IntPtr nodebox, IntPtr centroid, IntPtr quadrant, IntPtr next_nodespan)
            => SafeExecution(() => MEOSExternalFunctions.spannode_quadtree_next(nodebox, centroid, quadrant, next_nodespan));

        public static void spannode_kdtree_next(IntPtr nodebox, IntPtr centroid, IntPtr node, int level, IntPtr next_nodespan)
            => SafeExecution(() => MEOSExternalFunctions.spannode_kdtree_next(nodebox, centroid, node, level, next_nodespan));

        public static bool ensure_spanset_isof_type(IntPtr ss, int spansettype)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_spanset_isof_type(ss, spansettype));

        public static bool ensure_same_spanset_type(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_same_spanset_type(ss1, ss2));

        public static bool ensure_same_spanset_span_type(IntPtr ss, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_same_spanset_span_type(ss, s));

        public static bool ensure_valid_spanset_span(IntPtr ss, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_spanset_span(ss, s));

        public static bool ensure_valid_spanset_spanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_spanset_spanset(ss1, ss2));

        public static bool spanset_find_value(IntPtr ss, long v, IntPtr loc)
            => SafeExecution<bool>(() => MEOSExternalFunctions.spanset_find_value(ss, v, loc));

        public static long datum_and(long l, long r)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_and(l, r));

        public static long datum_or(long l, long r)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_or(l, r));

        public static IntPtr boolop_tbool_bool(IntPtr temp, long b, IntPtr func, bool invert)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.boolop_tbool_bool(temp, b, func, invert));

        public static IntPtr boolop_tbool_tbool(IntPtr temp1, IntPtr temp2, IntPtr func)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.boolop_tbool_tbool(temp1, temp2, func));

        public static bool ensure_same_dimensionality_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_same_dimensionality_tbox(box1, box2));

        public static IntPtr set_tbox(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_tbox(s));

        public static IntPtr span_tbox(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.span_tbox(s));

        public static IntPtr tbox_tstzspan(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_tstzspan(box));

        public static IntPtr tbox_intspan(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_intspan(box));

        public static IntPtr tbox_floatspan(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_floatspan(box));

        public static bool tbox_index_leaf_consistent(IntPtr key, IntPtr query, int strategy)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbox_index_leaf_consistent(key, query, strategy));

        public static bool tbox_gist_inner_consistent(IntPtr key, IntPtr query, int strategy)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbox_gist_inner_consistent(key, query, strategy));

        public static bool tbox_index_recheck(int strategy)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbox_index_recheck(strategy));

        public static void tboxnode_init(IntPtr centroid, IntPtr nodebox)
            => SafeExecution(() => MEOSExternalFunctions.tboxnode_init(centroid, nodebox));

        public static IntPtr tboxnode_copy(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tboxnode_copy(box));

        public static IntPtr getQuadrant4D(IntPtr centroid, IntPtr inBox)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.getQuadrant4D(centroid, inBox));

        public static void tboxnode_quadtree_next(IntPtr nodebox, IntPtr centroid, IntPtr quadrant, IntPtr next_nodebox)
            => SafeExecution(() => MEOSExternalFunctions.tboxnode_quadtree_next(nodebox, centroid, quadrant, next_nodebox));

        public static void tboxnode_kdtree_next(IntPtr nodebox, IntPtr centroid, IntPtr node, int level, IntPtr next_nodebox)
            => SafeExecution(() => MEOSExternalFunctions.tboxnode_kdtree_next(nodebox, centroid, node, level, next_nodebox));

        public static bool overlap4D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlap4D(nodebox, query));

        public static bool contain4D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contain4D(nodebox, query));

        public static bool left4D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left4D(nodebox, query));

        public static bool overLeft4D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overLeft4D(nodebox, query));

        public static bool right4D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right4D(nodebox, query));

        public static bool overRight4D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overRight4D(nodebox, query));

        public static bool before4D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before4D(nodebox, query));

        public static bool overBefore4D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overBefore4D(nodebox, query));

        public static bool after4D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after4D(nodebox, query));

        public static bool overAfter4D(IntPtr nodebox, IntPtr query)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overAfter4D(nodebox, query));

        public static double distance_tbox_nodebox(IntPtr query, IntPtr nodebox)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_tbox_nodebox(query, nodebox));

        public static void tnumber_spgist_get_tbox(long value, int type, IntPtr result)
            => SafeExecution(() => MEOSExternalFunctions.tnumber_spgist_get_tbox(value, type, result));

        public static int tbox_xmin_cmp(IntPtr box1, IntPtr box2)
            => SafeExecution<int>(() => MEOSExternalFunctions.tbox_xmin_cmp(box1, box2));

        public static int tbox_xmax_cmp(IntPtr box1, IntPtr box2)
            => SafeExecution<int>(() => MEOSExternalFunctions.tbox_xmax_cmp(box1, box2));

        public static int tbox_tmin_cmp(IntPtr box1, IntPtr box2)
            => SafeExecution<int>(() => MEOSExternalFunctions.tbox_tmin_cmp(box1, box2));

        public static int tbox_tmax_cmp(IntPtr box1, IntPtr box2)
            => SafeExecution<int>(() => MEOSExternalFunctions.tbox_tmax_cmp(box1, box2));

        public static int tbox_level_cmp(IntPtr centroid, IntPtr query, int level)
            => SafeExecution<int>(() => MEOSExternalFunctions.tbox_level_cmp(centroid, query, level));

        public static bool tcellindex_type(int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tcellindex_type(type));

        public static IntPtr dggs_cellops(int temptype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.dggs_cellops(temptype));

        public static IntPtr tcellindex_get_resolution(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcellindex_get_resolution(temp));

        public static IntPtr tcellindex_is_valid_cell(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcellindex_is_valid_cell(temp));

        public static IntPtr tcellindex_cell_to_parent(IntPtr temp, int resolution)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcellindex_cell_to_parent(temp, resolution));

        public static IntPtr tcellindex_cell_to_point(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcellindex_cell_to_point(temp));

        public static IntPtr tcellindex_cell_to_boundary(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcellindex_cell_to_boundary(temp));

        public static IntPtr tcellindex_cell_area(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcellindex_cell_area(temp));

        public static long datum_min_int32(long l, long r)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_min_int32(l, r));

        public static long datum_max_int32(long l, long r)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_max_int32(l, r));

        public static long datum_min_int64(long l, long r)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_min_int64(l, r));

        public static long datum_max_int64(long l, long r)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_max_int64(l, r));

        public static long datum_min_float8(long l, long r)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_min_float8(l, r));

        public static long datum_max_float8(long l, long r)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_max_float8(l, r));

        public static long datum_sum_int32(long l, long r)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_sum_int32(l, r));

        public static long datum_sum_int64(long l, long r)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_sum_int64(l, r));

        public static long datum_sum_float8(long l, long r)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_sum_float8(l, r));

        public static long datum_min_text(long l, long r)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_min_text(l, r));

        public static long datum_max_text(long l, long r)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_max_text(l, r));

        public static long datum_sum_double2(long l, long r)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_sum_double2(l, r));

        public static long datum_sum_double3(long l, long r)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_sum_double3(l, r));

        public static long datum_sum_double4(long l, long r)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_sum_double4(l, r));

        public static int temporal_skiplist_common(IntPtr list, IntPtr values, int count, IntPtr lower, IntPtr upper, IntPtr update)
            => SafeExecution<int>(() => MEOSExternalFunctions.temporal_skiplist_common(list, values, count, lower, upper, update));

        public static IntPtr temporal_skiplist_merge(IntPtr spliced, int spliced_count, IntPtr values, int count, IntPtr func, bool crossings, IntPtr newcount, IntPtr tofree, IntPtr nfree)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_skiplist_merge(spliced, spliced_count, values, count, func, crossings, newcount, tofree, nfree));

        public static IntPtr tinstant_tagg(IntPtr instants1, int count1, IntPtr instants2, int count2, IntPtr func, IntPtr newcount, IntPtr tofree, IntPtr nfree)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_tagg(instants1, count1, instants2, count2, func, newcount, tofree, nfree));

        public static IntPtr tsequence_tagg(IntPtr sequences1, int count1, IntPtr sequences2, int count2, IntPtr func, bool crossings, IntPtr newcount)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_tagg(sequences1, count1, sequences2, count2, func, crossings, newcount));

        public static IntPtr tcontseq_tagg_transfn(IntPtr state, IntPtr seq, IntPtr func, bool interpoint)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcontseq_tagg_transfn(state, seq, func, interpoint));

        public static IntPtr temporal_tagg_combinefn(IntPtr state1, IntPtr state2, IntPtr func, bool crossings)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_tagg_combinefn(state1, state2, func, crossings));

        public static IntPtr tinstant_tagg_transfn(IntPtr state, IntPtr inst, IntPtr func)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_tagg_transfn(state, inst, func));

        public static IntPtr tinstant_tavg_finalfn(IntPtr instants, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_tavg_finalfn(instants, count));

        public static IntPtr tsequence_tavg_finalfn(IntPtr sequences, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_tavg_finalfn(sequences, count));

        public static IntPtr tnumberinst_transform_tavg(IntPtr inst)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumberinst_transform_tavg(inst));

        public static IntPtr[] temporal_transform_tcount(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_transform_tcount(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] temporal_transform_tagg(IntPtr temp, IntPtr func)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_transform_tagg(temp, _cnt, func));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr tsequenceset_tagg_transfn(IntPtr state, IntPtr ss, IntPtr func, bool crossings)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_tagg_transfn(state, ss, func, crossings));

        public static IntPtr tdiscseq_tagg_transfn(IntPtr state, IntPtr seq, IntPtr func)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdiscseq_tagg_transfn(state, seq, func));

        public static IntPtr temporal_tagg_transfn(IntPtr state, IntPtr temp, IntPtr arg2, bool crossings)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_tagg_transfn(state, temp, arg2, crossings));

        public static IntPtr temporal_tagg_transform_transfn(IntPtr state, IntPtr temp, IntPtr func, bool crossings, IntPtr transform)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_tagg_transform_transfn(state, temp, func, crossings, transform));

        public static double temporal_similarity(IntPtr temp1, IntPtr temp2, IntPtr simfunc)
            => SafeExecution<double>(() => MEOSExternalFunctions.temporal_similarity(temp1, temp2, simfunc));

        public static IntPtr[] temporal_similarity_path(IntPtr temp1, IntPtr temp2, IntPtr simfunc)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_similarity_path(temp1, temp2, _cnt, simfunc));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static ulong temporal_bbox_size(int tempype)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.temporal_bbox_size(tempype));

        public static void tinstarr_set_bbox(IntPtr instants, int count, bool lower_inc, bool upper_inc, int interp, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tinstarr_set_bbox(instants, count, lower_inc, upper_inc, interp, box));

        public static void tsequence_compute_bbox(IntPtr seq)
            => SafeExecution(() => MEOSExternalFunctions.tsequence_compute_bbox(seq));

        public static void tseqarr_compute_bbox(IntPtr sequences, int count, IntPtr bbox)
            => SafeExecution(() => MEOSExternalFunctions.tseqarr_compute_bbox(sequences, count, bbox));

        public static void tsequenceset_compute_bbox(IntPtr ss)
            => SafeExecution(() => MEOSExternalFunctions.tsequenceset_compute_bbox(ss));

        public static bool boxop_temporal_tstzspan(IntPtr temp, IntPtr s, IntPtr func, bool invert)
            => SafeExecution<bool>(() => MEOSExternalFunctions.boxop_temporal_tstzspan(temp, s, func, invert));

        public static bool boxop_temporal_temporal(IntPtr temp1, IntPtr temp2, IntPtr func)
            => SafeExecution<bool>(() => MEOSExternalFunctions.boxop_temporal_temporal(temp1, temp2, func));

        public static bool boxop_tnumber_numspan(IntPtr temp, IntPtr span, IntPtr func, bool invert)
            => SafeExecution<bool>(() => MEOSExternalFunctions.boxop_tnumber_numspan(temp, span, func, invert));

        public static bool boxop_tnumber_tbox(IntPtr temp, IntPtr box, IntPtr func, bool invert)
            => SafeExecution<bool>(() => MEOSExternalFunctions.boxop_tnumber_tbox(temp, box, func, invert));

        public static bool boxop_tnumber_tnumber(IntPtr temp1, IntPtr temp2, IntPtr func)
            => SafeExecution<bool>(() => MEOSExternalFunctions.boxop_tnumber_tnumber(temp1, temp2, func));

        public static int eacomp_base_temporal(long value, IntPtr temp, IntPtr func, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.eacomp_base_temporal(value, temp, func, ever));

        public static int eacomp_temporal_base(IntPtr temp, long value, IntPtr func, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.eacomp_temporal_base(temp, value, func, ever));

        public static int eacomp_temporal_temporal(IntPtr temp1, IntPtr temp2, IntPtr func, bool ever)
            => SafeExecution<int>(() => MEOSExternalFunctions.eacomp_temporal_temporal(temp1, temp2, func, ever));

        public static IntPtr tcomp_base_temporal(long value, IntPtr temp, IntPtr func)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcomp_base_temporal(value, temp, func));

        public static IntPtr tcomp_temporal_base(IntPtr temp, long value, IntPtr func)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcomp_temporal_base(temp, value, func));

        public static IntPtr tcomp_temporal_temporal(IntPtr temp1, IntPtr temp2, IntPtr func)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcomp_temporal_temporal(temp1, temp2, func));

        public static IntPtr tdiscseq_at_timestamptz(IntPtr seq, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdiscseq_at_timestamptz(seq, t));

        public static IntPtr tdiscseq_restrict_value(IntPtr seq, long value, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdiscseq_restrict_value(seq, value, atfunc));

        public static IntPtr tdiscseq_restrict_values(IntPtr seq, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdiscseq_restrict_values(seq, s, atfunc));

        public static IntPtr tdiscseq_minus_timestamptz(IntPtr seq, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdiscseq_minus_timestamptz(seq, t));

        public static IntPtr tdiscseq_restrict_tstzset(IntPtr seq, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdiscseq_restrict_tstzset(seq, s, atfunc));

        public static IntPtr tdiscseq_restrict_tstzspanset(IntPtr seq, IntPtr ss, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdiscseq_restrict_tstzspanset(seq, ss, atfunc));

        public static int tcontseq_restrict_value_iter(IntPtr seq, long value, bool atfunc, IntPtr result)
            => SafeExecution<int>(() => MEOSExternalFunctions.tcontseq_restrict_value_iter(seq, value, atfunc, result));

        public static IntPtr tcontseq_delete_timestamptz(IntPtr seq, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcontseq_delete_timestamptz(seq, t));

        public static IntPtr tcontseq_delete_tstzset(IntPtr seq, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcontseq_delete_tstzset(seq, s));

        public static IntPtr tcontseq_delete_tstzspanset(IntPtr seq, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcontseq_delete_tstzspanset(seq, ss));

        public static IntPtr tcontseq_at_tstzset(IntPtr seq, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcontseq_at_tstzset(seq, s));

        public static IntPtr tcontseq_minus_timestamptz(IntPtr seq, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcontseq_minus_timestamptz(seq, t));

        public static IntPtr tcontseq_minus_tstzset(IntPtr seq, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcontseq_minus_tstzset(seq, s));

        public static IntPtr tcontseq_minus_tstzspan(IntPtr seq, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcontseq_minus_tstzspan(seq, s));

        public static IntPtr tcontseq_restrict_value(IntPtr seq, long value, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcontseq_restrict_value(seq, value, atfunc));

        public static IntPtr tcontseq_restrict_values(IntPtr seq, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcontseq_restrict_values(seq, s, atfunc));

        public static int tsequence_at_values_iter(IntPtr seq, IntPtr set, IntPtr result)
            => SafeExecution<int>(() => MEOSExternalFunctions.tsequence_at_values_iter(seq, set, result));

        public static int tnumberseq_cont_restrict_span_iter(IntPtr seq, IntPtr span, bool atfunc, IntPtr result)
            => SafeExecution<int>(() => MEOSExternalFunctions.tnumberseq_cont_restrict_span_iter(seq, span, atfunc, result));

        public static int tnumberseq_cont_restrict_spanset_iter(IntPtr seq, IntPtr ss, bool atfunc, IntPtr result)
            => SafeExecution<int>(() => MEOSExternalFunctions.tnumberseq_cont_restrict_spanset_iter(seq, ss, atfunc, result));

        public static IntPtr tsegment_at_timestamptz(IntPtr inst1, IntPtr inst2, int interp, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsegment_at_timestamptz(inst1, inst2, interp, t));

        public static int tcontseq_minus_timestamp_iter(IntPtr seq, long t, IntPtr result)
            => SafeExecution<int>(() => MEOSExternalFunctions.tcontseq_minus_timestamp_iter(seq, t, result));

        public static int tcontseq_minus_tstzset_iter(IntPtr seq, IntPtr s, IntPtr result)
            => SafeExecution<int>(() => MEOSExternalFunctions.tcontseq_minus_tstzset_iter(seq, s, result));

        public static int tcontseq_at_tstzspanset1(IntPtr seq, IntPtr ss, IntPtr result)
            => SafeExecution<int>(() => MEOSExternalFunctions.tcontseq_at_tstzspanset1(seq, ss, result));

        public static int tcontseq_minus_tstzspanset_iter(IntPtr seq, IntPtr ss, IntPtr result)
            => SafeExecution<int>(() => MEOSExternalFunctions.tcontseq_minus_tstzspanset_iter(seq, ss, result));

        public static IntPtr tcontseq_at_tstzspan(IntPtr seq, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcontseq_at_tstzspan(seq, s));

        public static IntPtr tcontseq_at_timestamptz(IntPtr seq, long t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcontseq_at_timestamptz(seq, t));

        public static IntPtr tcontseq_restrict_tstzspanset(IntPtr seq, IntPtr ss, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcontseq_restrict_tstzspanset(seq, ss, atfunc));

        public static bool tdiscseq_value_at_timestamptz(IntPtr seq, long t, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tdiscseq_value_at_timestamptz(seq, t, result));

        public static IntPtr tnumberseq_disc_restrict_span(IntPtr seq, IntPtr span, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumberseq_disc_restrict_span(seq, span, atfunc));

        public static IntPtr tnumberseq_disc_restrict_spanset(IntPtr seq, IntPtr ss, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumberseq_disc_restrict_spanset(seq, ss, atfunc));

        public static IntPtr tnumberseq_cont_restrict_span(IntPtr seq, IntPtr span, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumberseq_cont_restrict_span(seq, span, atfunc));

        public static IntPtr tnumberseq_cont_restrict_spanset(IntPtr seq, IntPtr ss, bool atfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumberseq_cont_restrict_spanset(seq, ss, atfunc));

        public static double tnumberseq_cont_twavg(IntPtr seq)
            => SafeExecution<double>(() => MEOSExternalFunctions.tnumberseq_cont_twavg(seq));

        public static int span_num_bins(IntPtr s, long size, long origin, IntPtr start_bin, IntPtr end_bin)
            => SafeExecution<int>(() => MEOSExternalFunctions.span_num_bins(s, size, origin, start_bin, end_bin));

        public static IntPtr temporal_time_bin_init(IntPtr temp, IntPtr duration, long torigin, IntPtr nbins)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_time_bin_init(temp, duration, torigin, nbins));

        public static IntPtr tbox_tile_state_make(IntPtr temp, IntPtr box, long vsize, IntPtr duration, long xorigin, long torigin)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_tile_state_make(temp, box, vsize, duration, xorigin, torigin));

        public static void tbox_tile_state_next(IntPtr state)
            => SafeExecution(() => MEOSExternalFunctions.tbox_tile_state_next(state));

        public static void tbox_tile_state_set(long value, long t, long vsize, long tunits, int basetype, int spantype, IntPtr box)
            => SafeExecution(() => MEOSExternalFunctions.tbox_tile_state_set(value, t, vsize, tunits, basetype, spantype, box));

        public static long interval_units(IntPtr interval)
            => SafeExecution<long>(() => MEOSExternalFunctions.interval_units(interval));

        public static long timestamptz_bin_start(long timestamp, long tunits, long torigin)
            => SafeExecution<long>(() => MEOSExternalFunctions.timestamptz_bin_start(timestamp, tunits, torigin));

        public static long datum_bin(long value, long size, long offset, int basetype)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_bin(value, size, offset, basetype));

        public static IntPtr tnumber_value_time_tile_init(IntPtr temp, long vsize, IntPtr duration, long vorigin, long torigin, IntPtr ntiles)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_value_time_tile_init(temp, vsize, duration, vorigin, torigin, ntiles));

        public static bool tbox_tile_state_get(IntPtr state, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbox_tile_state_get(state, box));

        public static IntPtr[] temporal_transform_wcount(IntPtr temp, IntPtr interval)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_transform_wcount(temp, interval, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] tnumber_transform_wavg(IntPtr temp, IntPtr interval)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_transform_wavg(temp, interval, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr temporal_wagg_transfn(IntPtr state, IntPtr temp, IntPtr interval, IntPtr func, bool min, bool crossings)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_wagg_transfn(state, temp, interval, func, min, crossings));

        public static IntPtr temporal_wagg_transform_transfn(IntPtr state, IntPtr temp, IntPtr interval, IntPtr func, IntPtr transform)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_wagg_transform_transfn(state, temp, interval, func, transform));

        public static void tinstant_set(IntPtr inst, long value, long t)
            => SafeExecution(() => MEOSExternalFunctions.tinstant_set(inst, value, t));

        public static double tnumberinst_double(IntPtr inst)
            => SafeExecution<double>(() => MEOSExternalFunctions.tnumberinst_double(inst));

        public static string tinstant_to_string(IntPtr inst, int maxdd, IntPtr value_out)
            => SafeExecution<string>(() => MEOSExternalFunctions.tinstant_to_string(inst, maxdd, value_out));

        public static bool tinstant_restrict_values_test(IntPtr inst, IntPtr s, bool atfunc)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tinstant_restrict_values_test(inst, s, atfunc));

        public static bool tnumberinst_restrict_span_test(IntPtr inst, IntPtr s, bool atfunc)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tnumberinst_restrict_span_test(inst, s, atfunc));

        public static bool tnumberinst_restrict_spanset_test(IntPtr inst, IntPtr ss, bool atfunc)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tnumberinst_restrict_spanset_test(inst, ss, atfunc));

        public static bool tinstant_restrict_tstzset_test(IntPtr inst, IntPtr s, bool atfunc)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tinstant_restrict_tstzset_test(inst, s, atfunc));

        public static bool tinstant_restrict_tstzspanset_test(IntPtr inst, IntPtr ss, bool atfunc)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tinstant_restrict_tstzspanset_test(inst, ss, atfunc));

        public static bool intersection_tinstant_tinstant(IntPtr inst1, IntPtr inst2, IntPtr inter1, IntPtr inter2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.intersection_tinstant_tinstant(inst1, inst2, inter1, inter2));

        public static void _mulmat(IntPtr a, IntPtr b, IntPtr c, int arows, int acols, int bcols)
            => SafeExecution(() => MEOSExternalFunctions._mulmat(a, b, c, arows, acols, bcols));

        public static void _mulvec(IntPtr a, IntPtr x, IntPtr y, int m, int n)
            => SafeExecution(() => MEOSExternalFunctions._mulvec(a, x, y, m, n));

        public static void _transpose(IntPtr a, IntPtr at, int m, int n)
            => SafeExecution(() => MEOSExternalFunctions._transpose(a, at, m, n));

        public static void _addmat(IntPtr a, IntPtr b, IntPtr c, int m, int n)
            => SafeExecution(() => MEOSExternalFunctions._addmat(a, b, c, m, n));

        public static void _negate(IntPtr a, int m, int n)
            => SafeExecution(() => MEOSExternalFunctions._negate(a, m, n));

        public static void _addeye(IntPtr a, int n)
            => SafeExecution(() => MEOSExternalFunctions._addeye(a, n));

        public static int _choldc1(IntPtr a, IntPtr p, int n)
            => SafeExecution<int>(() => MEOSExternalFunctions._choldc1(a, p, n));

        public static int _choldcsl(IntPtr A, IntPtr a, IntPtr p, int n)
            => SafeExecution<int>(() => MEOSExternalFunctions._choldcsl(A, a, p, n));

        public static int _cholsl(IntPtr A, IntPtr a, IntPtr p, int n)
            => SafeExecution<int>(() => MEOSExternalFunctions._cholsl(A, a, p, n));

        public static void _addvec(IntPtr a, IntPtr b, IntPtr c, int n)
            => SafeExecution(() => MEOSExternalFunctions._addvec(a, b, c, n));

        public static void _sub(IntPtr a, IntPtr b, IntPtr c, int n)
            => SafeExecution(() => MEOSExternalFunctions._sub(a, b, c, n));

        public static int invert(IntPtr a, IntPtr ainv)
            => SafeExecution<int>(() => MEOSExternalFunctions.invert(a, ainv));

        public static void ekf_initialize(IntPtr ekf, float pdiag)
            => SafeExecution(() => MEOSExternalFunctions.ekf_initialize(ekf, pdiag));

        public static void ekf_predict(IntPtr ekf, float fx, float F, float Q)
            => SafeExecution(() => MEOSExternalFunctions.ekf_predict(ekf, fx, F, Q));

        public static void ekf_update_step3(IntPtr ekf, float GH)
            => SafeExecution(() => MEOSExternalFunctions.ekf_update_step3(ekf, GH));

        public static int ekf_update(IntPtr ekf, float z, float hx, float H, float R)
            => SafeExecution<int>(() => MEOSExternalFunctions.ekf_update(ekf, z, hx, H, R));

        public static int tfloat_arithop_turnpt(long start1, long end1, long start2, long end2, long param, long lower, long upper, IntPtr t1, IntPtr t2)
            => SafeExecution<int>(() => MEOSExternalFunctions.tfloat_arithop_turnpt(start1, end1, start2, end2, param, lower, upper, t1, t2));

        public static IntPtr arithop_tnumber_number(IntPtr temp, long value, IntPtr oper, IntPtr func, bool invert)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.arithop_tnumber_number(temp, value, oper, func, invert));

        public static IntPtr arithop_tnumber_tnumber(IntPtr temp1, IntPtr temp2, IntPtr oper, IntPtr func, IntPtr tpfunc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.arithop_tnumber_tnumber(temp1, temp2, oper, func, tpfunc));

        public static bool float_collinear(double x1, double x2, double x3, double ratio)
            => SafeExecution<bool>(() => MEOSExternalFunctions.float_collinear(x1, x2, x3, ratio));

        public static double floatsegm_interpolate(double value1, double value2, IntPtr value)
            => SafeExecution<double>(() => MEOSExternalFunctions.floatsegm_interpolate(value1, value2, value));

        public static IntPtr floatsegm_locate(double value1, double value2, double value)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatsegm_locate(value1, value2, value));

        public static int tnumbersegm_intersection(long start1, long end1, long start2, long end2, int basetype, long lower, long upper, IntPtr t1, IntPtr t2)
            => SafeExecution<int>(() => MEOSExternalFunctions.tnumbersegm_intersection(start1, end1, start2, end2, basetype, lower, upper, t1, t2));

        public static bool tsequence_norm_test(long value1, long value2, long value3, int basetype, int interp, long t1, long t2, long t3)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tsequence_norm_test(value1, value2, value3, basetype, interp, t1, t2, t3));

        public static bool tsequence_join_test(IntPtr seq1, IntPtr seq2, IntPtr removelast, IntPtr removefirst)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tsequence_join_test(seq1, seq2, removelast, removefirst));

        public static IntPtr tsequence_join(IntPtr seq1, IntPtr seq2, bool removelast, bool removefirst)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_join(seq1, seq2, removelast, removefirst));

        public static IntPtr tinstarr_normalize(IntPtr instants, int interp, int count, IntPtr newcount)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstarr_normalize(instants, interp, count, newcount));

        public static int tcontseq_find_timestamptz(IntPtr seq, long t)
            => SafeExecution<int>(() => MEOSExternalFunctions.tcontseq_find_timestamptz(seq, t));

        public static int tdiscseq_find_timestamptz(IntPtr seq, long t)
            => SafeExecution<int>(() => MEOSExternalFunctions.tdiscseq_find_timestamptz(seq, t));

        public static IntPtr tseqarr2_to_tseqarr(IntPtr sequences, IntPtr countseqs, int count, int totalseqs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tseqarr2_to_tseqarr(sequences, countseqs, count, totalseqs));

        public static bool ensure_valid_tinstarr_common(IntPtr instants, int count, bool lower_inc, bool upper_inc, int interp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tinstarr_common(instants, count, lower_inc, upper_inc, interp));

        public static IntPtr tsequence_make_exp1(IntPtr instants, int count, int maxcount, bool lower_inc, bool upper_inc, int interp, bool normalize, IntPtr bbox)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_make_exp1(instants, count, maxcount, lower_inc, upper_inc, interp, normalize, bbox));

        public static bool synchronize_tsequence_tsequence(IntPtr seq1, IntPtr seq2, IntPtr sync1, IntPtr sync2, bool interpoint)
            => SafeExecution<bool>(() => MEOSExternalFunctions.synchronize_tsequence_tsequence(seq1, seq2, sync1, sync2, interpoint));

        public static int tfloatsegm_intersection_value(long start, long end, long value, long lower, long upper, IntPtr t)
            => SafeExecution<int>(() => MEOSExternalFunctions.tfloatsegm_intersection_value(start, end, value, lower, upper, t));

        public static int tsegment_intersection_value(long start, long end, long value, int temptype, long lower, long upper, IntPtr t1, IntPtr t2)
            => SafeExecution<int>(() => MEOSExternalFunctions.tsegment_intersection_value(start, end, value, temptype, lower, upper, t1, t2));

        public static int tsegment_intersection(long start1, long end1, long start2, long end2, int temptype, long lower, long upper, IntPtr t1, IntPtr t2)
            => SafeExecution<int>(() => MEOSExternalFunctions.tsegment_intersection(start1, end1, start2, end2, temptype, lower, upper, t1, t2));

        public static long tsegment_value_at_timestamptz(long start, long end, int temptype, long lower, long upper, long t)
            => SafeExecution<long>(() => MEOSExternalFunctions.tsegment_value_at_timestamptz(start, end, temptype, lower, upper, t));

        public static bool intersection_tdiscseq_tdiscseq(IntPtr seq1, IntPtr seq2, IntPtr inter1, IntPtr inter2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.intersection_tdiscseq_tdiscseq(seq1, seq2, inter1, inter2));

        public static bool intersection_tcontseq_tdiscseq(IntPtr seq1, IntPtr seq2, IntPtr inter1, IntPtr inter2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.intersection_tcontseq_tdiscseq(seq1, seq2, inter1, inter2));

        public static bool intersection_tdiscseq_tcontseq(IntPtr @is, IntPtr seq2, IntPtr inter1, IntPtr inter2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.intersection_tdiscseq_tcontseq(@is, seq2, inter1, inter2));

        public static bool intersection_tsequence_tinstant(IntPtr seq, IntPtr inst, IntPtr inter1, IntPtr inter2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.intersection_tsequence_tinstant(seq, inst, inter1, inter2));

        public static bool intersection_tinstant_tsequence(IntPtr inst, IntPtr seq, IntPtr inter1, IntPtr inter2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.intersection_tinstant_tsequence(inst, seq, inter1, inter2));

        public static string tsequence_to_string(IntPtr seq, int maxdd, bool component, IntPtr value_out)
            => SafeExecution<string>(() => MEOSExternalFunctions.tsequence_to_string(seq, maxdd, component, value_out));

        public static bool ensure_increasing_timestamps(IntPtr inst1, IntPtr inst2, bool strict)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_increasing_timestamps(inst1, inst2, strict));

        public static void bbox_expand(IntPtr box1, IntPtr box2, int temptype)
            => SafeExecution(() => MEOSExternalFunctions.bbox_expand(box1, box2, temptype));

        public static bool ensure_valid_tinstarr(IntPtr instants, int count, bool merge, int interp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tinstarr(instants, count, merge, interp));

        public static bool tsequence_make_valid(IntPtr instants, int count, bool lower_inc, bool upper_inc, int interp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tsequence_make_valid(instants, count, lower_inc, upper_inc, interp));

        public static void tnumberseq_shift_scale_value_iter(IntPtr seq, long origin, long delta, bool hasdelta, double scale)
            => SafeExecution(() => MEOSExternalFunctions.tnumberseq_shift_scale_value_iter(seq, origin, delta, hasdelta, scale));

        public static void tsequence_shift_scale_time_iter(IntPtr seq, long delta, double scale)
            => SafeExecution(() => MEOSExternalFunctions.tsequence_shift_scale_time_iter(seq, delta, scale));

        public static int tstepseq_to_linear_iter(IntPtr seq, IntPtr result)
            => SafeExecution<int>(() => MEOSExternalFunctions.tstepseq_to_linear_iter(seq, result));

        public static IntPtr tstepseq_to_linear(IntPtr seq)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstepseq_to_linear(seq));

        public static int tsequence_segments_iter(IntPtr seq, IntPtr result)
            => SafeExecution<int>(() => MEOSExternalFunctions.tsequence_segments_iter(seq, result));

        public static int tsequence_timestamps_iter(IntPtr seq, IntPtr times)
            => SafeExecution<int>(() => MEOSExternalFunctions.tsequence_timestamps_iter(seq, times));

        public static bool tsequenceset_find_timestamptz(IntPtr ss, long t, IntPtr loc)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tsequenceset_find_timestamptz(ss, t, loc));

        public static IntPtr tseqarr_normalize(IntPtr sequences, int count, IntPtr newcount)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tseqarr_normalize(sequences, count, newcount));

        public static double datum_distance(long value1, long value2, int basetype, short flags)
            => SafeExecution<double>(() => MEOSExternalFunctions.datum_distance(value1, value2, basetype, flags));

        public static IntPtr ensure_valid_tinstarr_gaps(IntPtr instants, int count, bool merge, double maxdist, IntPtr maxt, IntPtr nsplits)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ensure_valid_tinstarr_gaps(instants, count, merge, maxdist, maxt, nsplits));

        public static bool ensure_valid_tseqarr(IntPtr sequences, int count)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_valid_tseqarr(sequences, count));

        public static bool synchronize_tsequenceset_tsequence(IntPtr ss, IntPtr seq, IntPtr mode, IntPtr inter1, IntPtr inter2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.synchronize_tsequenceset_tsequence(ss, seq, mode, inter1, inter2));

        public static bool synchronize_tsequenceset_tsequenceset(IntPtr ss1, IntPtr ss2, IntPtr mode, IntPtr inter1, IntPtr inter2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.synchronize_tsequenceset_tsequenceset(ss1, ss2, mode, inter1, inter2));

        public static bool intersection_tsequenceset_tinstant(IntPtr ss, IntPtr inst, IntPtr inter1, IntPtr inter2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.intersection_tsequenceset_tinstant(ss, inst, inter1, inter2));

        public static bool intersection_tinstant_tsequenceset(IntPtr inst, IntPtr ss, IntPtr inter1, IntPtr inter2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.intersection_tinstant_tsequenceset(inst, ss, inter1, inter2));

        public static bool intersection_tsequenceset_tdiscseq(IntPtr ss, IntPtr @is, IntPtr inter1, IntPtr inter2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.intersection_tsequenceset_tdiscseq(ss, @is, inter1, inter2));

        public static bool intersection_tdiscseq_tsequenceset(IntPtr @is, IntPtr ss, IntPtr inter1, IntPtr inter2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.intersection_tdiscseq_tsequenceset(@is, ss, inter1, inter2));

        public static bool intersection_tsequence_tsequenceset(IntPtr seq, IntPtr ss, IntPtr mode, IntPtr inter1, IntPtr inter2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.intersection_tsequence_tsequenceset(seq, ss, mode, inter1, inter2));

        public static string tsequenceset_to_string(IntPtr ss, int maxdd, IntPtr value_out)
            => SafeExecution<string>(() => MEOSExternalFunctions.tsequenceset_to_string(ss, maxdd, value_out));

        public static long datum_textcat(long l, long r)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_textcat(l, r));

        public static long datum_lower(long value)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_lower(value));

        public static long datum_upper(long value)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_upper(value));

        public static long datum_initcap(long value)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_initcap(value));

        public static IntPtr textfunc_ttext(IntPtr temp, int func)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.textfunc_ttext(temp, func));

        public static IntPtr textfunc_ttext_text(IntPtr temp, long value, IntPtr func, bool invert)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.textfunc_ttext_text(temp, value, func, invert));

        public static IntPtr textfunc_ttext_ttext(IntPtr temp1, IntPtr temp2, IntPtr func)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.textfunc_ttext_ttext(temp1, temp2, func));

        public static IntPtr datum_as_wkb(long value, int type, IntPtr variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.datum_as_wkb(value, type, variant, size_out));

        public static string datum_as_hexwkb(long value, int type, IntPtr variant, IntPtr size)
            => SafeExecution<string>(() => MEOSExternalFunctions.datum_as_hexwkb(value, type, variant, size));

        public static long type_from_wkb(IntPtr wkb, IntPtr size, int type)
            => SafeExecution<long>(() => MEOSExternalFunctions.type_from_wkb(wkb, size, type));

        public static long type_from_hexwkb(string hexwkb, IntPtr size, int type)
            => SafeExecution<long>(() => MEOSExternalFunctions.type_from_hexwkb(hexwkb, size, type));

        public static bool ensure_end_input(IntPtr str, string type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_end_input(str, type));

        public static void p_whitespace(IntPtr str)
            => SafeExecution(() => MEOSExternalFunctions.p_whitespace(str));

        public static bool p_delimchar(IntPtr str, byte delim)
            => SafeExecution<bool>(() => MEOSExternalFunctions.p_delimchar(str, delim));

        public static bool p_obrace(IntPtr str)
            => SafeExecution<bool>(() => MEOSExternalFunctions.p_obrace(str));

        public static bool ensure_obrace(IntPtr str, string type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_obrace(str, type));

        public static bool p_cbrace(IntPtr str)
            => SafeExecution<bool>(() => MEOSExternalFunctions.p_cbrace(str));

        public static bool ensure_cbrace(IntPtr str, string type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_cbrace(str, type));

        public static bool p_obracket(IntPtr str)
            => SafeExecution<bool>(() => MEOSExternalFunctions.p_obracket(str));

        public static bool p_cbracket(IntPtr str)
            => SafeExecution<bool>(() => MEOSExternalFunctions.p_cbracket(str));

        public static bool p_oparen(IntPtr str)
            => SafeExecution<bool>(() => MEOSExternalFunctions.p_oparen(str));

        public static bool ensure_oparen(IntPtr str, string type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_oparen(str, type));

        public static bool p_cparen(IntPtr str)
            => SafeExecution<bool>(() => MEOSExternalFunctions.p_cparen(str));

        public static bool ensure_cparen(IntPtr str, string type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ensure_cparen(str, type));

        public static bool p_comma(IntPtr str)
            => SafeExecution<bool>(() => MEOSExternalFunctions.p_comma(str));

        public static bool basetype_parse(IntPtr str, int basetypid, byte delim, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.basetype_parse(str, basetypid, delim, result));

        public static bool double_parse(IntPtr str, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.double_parse(str, result));

        public static bool elem_parse(IntPtr str, int basetype, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.elem_parse(str, basetype, result));

        public static IntPtr set_parse(IntPtr str, int basetype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_parse(str, basetype));

        public static bool span_parse(IntPtr str, int spantype, bool end, IntPtr span)
            => SafeExecution<bool>(() => MEOSExternalFunctions.span_parse(str, spantype, end, span));

        public static IntPtr spanset_parse(IntPtr str, int spantype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_parse(str, spantype));

        public static IntPtr tbox_parse(IntPtr str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_parse(str));

        public static long timestamp_parse(IntPtr str)
            => SafeExecution<long>(() => MEOSExternalFunctions.timestamp_parse(str));

        public static IntPtr tinstant_parse(IntPtr str, int temptype, bool end)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tinstant_parse(str, temptype, end));

        public static IntPtr tdiscseq_parse(IntPtr str, int temptype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdiscseq_parse(str, temptype));

        public static IntPtr tcontseq_parse(IntPtr str, int temptype, int interp, bool end)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcontseq_parse(str, temptype, interp, end));

        public static IntPtr tsequenceset_parse(IntPtr str, int temptype, int interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_parse(str, temptype, interp));

        public static IntPtr temporal_parse(IntPtr str, int temptype)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_parse(str, temptype));

        public static long datum_copy(long value, int typid)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_copy(value, typid));

        public static double datum_double(long d, int type)
            => SafeExecution<double>(() => MEOSExternalFunctions.datum_double(d, type));

        public static long double_datum(double d, int type)
            => SafeExecution<long>(() => MEOSExternalFunctions.double_datum(d, type));

        public static IntPtr bstring2bytea(IntPtr wkb, IntPtr size)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bstring2bytea(wkb, size));

        public static bool basetype_in(string str, int type, bool end, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.basetype_in(str, type, end, result));

        public static string basetype_out(long value, int type, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.basetype_out(value, type, maxdd));

        public static void pfree_array(IntPtr array, int count)
            => SafeExecution(() => MEOSExternalFunctions.pfree_array(array, count));

        public static bool string_escape(string str, int quotes, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.string_escape(str, quotes, result));

        public static ulong string_unescape(string str, IntPtr result)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.string_unescape(str, result));

        public static string stringarr_to_string(IntPtr strings, int count, string prefix, byte open, byte close, int quotes, bool spaces)
            => SafeExecution<string>(() => MEOSExternalFunctions.stringarr_to_string(strings, count, prefix, open, close, quotes, spaces));

        public static void datumarr_sort(IntPtr values, int count, int basetype)
            => SafeExecution(() => MEOSExternalFunctions.datumarr_sort(values, count, basetype));

        public static void tstzarr_sort(IntPtr times, int count)
            => SafeExecution(() => MEOSExternalFunctions.tstzarr_sort(times, count));

        public static void spanarr_sort(IntPtr spans, int count)
            => SafeExecution(() => MEOSExternalFunctions.spanarr_sort(spans, count));

        public static void tinstarr_sort(IntPtr instants, int count)
            => SafeExecution(() => MEOSExternalFunctions.tinstarr_sort(instants, count));

        public static void tseqarr_sort(IntPtr sequences, int count)
            => SafeExecution(() => MEOSExternalFunctions.tseqarr_sort(sequences, count));

        public static int datumarr_remove_duplicates(IntPtr values, int count, int basetype)
            => SafeExecution<int>(() => MEOSExternalFunctions.datumarr_remove_duplicates(values, count, basetype));

        public static int tstzarr_remove_duplicates(IntPtr values, int count)
            => SafeExecution<int>(() => MEOSExternalFunctions.tstzarr_remove_duplicates(values, count));

        public static int tinstarr_remove_duplicates(IntPtr instants, int count)
            => SafeExecution<int>(() => MEOSExternalFunctions.tinstarr_remove_duplicates(instants, count));

        public static long datum_add(long l, long r, int type)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_add(l, r, type));

        public static long datum_sub(long l, long r, int type)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_sub(l, r, type));

        public static long datum_mul(long l, long r, int type)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_mul(l, r, type));

        public static long datum_div(long l, long r, int type)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum_div(l, r, type));

        public static int datum_cmp(long l, long r, int type)
            => SafeExecution<int>(() => MEOSExternalFunctions.datum_cmp(l, r, type));

        public static bool datum_eq(long l, long r, int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.datum_eq(l, r, type));

        public static bool datum_ne(long l, long r, int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.datum_ne(l, r, type));

        public static bool datum_lt(long l, long r, int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.datum_lt(l, r, type));

        public static bool datum_le(long l, long r, int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.datum_le(l, r, type));

        public static bool datum_gt(long l, long r, int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.datum_gt(l, r, type));

        public static bool datum_ge(long l, long r, int type)
            => SafeExecution<bool>(() => MEOSExternalFunctions.datum_ge(l, r, type));

        public static long datum2_eq(long l, long r, int type)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum2_eq(l, r, type));

        public static long datum2_ne(long l, long r, int type)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum2_ne(l, r, type));

        public static long datum2_lt(long l, long r, int type)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum2_lt(l, r, type));

        public static long datum2_le(long l, long r, int type)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum2_le(l, r, type));

        public static long datum2_gt(long l, long r, int type)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum2_gt(l, r, type));

        public static long datum2_ge(long l, long r, int type)
            => SafeExecution<long>(() => MEOSExternalFunctions.datum2_ge(l, r, type));

        public static double hypot3d(double x, double y, double z)
            => SafeExecution<double>(() => MEOSExternalFunctions.hypot3d(x, y, z));

    }
}
