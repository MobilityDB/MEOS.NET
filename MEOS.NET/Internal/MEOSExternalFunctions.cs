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
            public static partial void rtree_insert_temporal_split(IntPtr rtree, IntPtr temp, int id, int maxboxes);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int rtree_search(IntPtr rtree, IntPtr op, IntPtr query, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int rtree_search_temporal(IntPtr rtree, IntPtr op, IntPtr temp, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int rtree_search_temporal_dedup(IntPtr rtree, IntPtr op, IntPtr temp, int maxboxes, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_initialize_error_handler(IntPtr err_handler);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_initialize_allocator(IntPtr malloc_fn, IntPtr realloc_fn, IntPtr free_fn);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_initialize_noexit_error_handler();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_initialize_timezone(string name);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_initialize_collation();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_finalize_timezone();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_finalize_collation();

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
            public static partial void meos_set_ways_csv(string path);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_initialize();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_finalize();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string bigintset_out(IntPtr set);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintspan_expand(IntPtr s, IntPtr value);

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
            public static partial IntPtr bigintspan_make(IntPtr lower, IntPtr upper, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc);

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
            public static partial IntPtr bigint_to_set(IntPtr i);

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
            public static partial IntPtr floatspan_to_bigintspan(IntPtr s);

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
            public static partial IntPtr intspan_to_bigintspan(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintspan_to_intspan(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintspan_to_floatspan(IntPtr s);

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
            public static partial IntPtr bigintset_end_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintset_start_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool bigintset_value_n(IntPtr s, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintset_values(IntPtr s, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintspan_lower(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintspan_upper(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintspan_width(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintspanset_lower(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintspanset_upper(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintspanset_width(IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool boundspan);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int dateset_end_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int dateset_start_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool dateset_value_n(IntPtr s, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr dateset_values(IntPtr s, IntPtr count);

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
            public static partial IntPtr floatset_values(IntPtr s, IntPtr count);

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
            public static partial IntPtr intset_values(IntPtr s, IntPtr count);

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
            public static partial int set_hash(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_hash_extended(IntPtr s, IntPtr seed);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int set_num_values(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int span_hash(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr span_hash_extended(IntPtr s, IntPtr seed);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool span_lower_inc(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool span_upper_inc(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_end_span(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int spanset_hash(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_hash_extended(IntPtr ss, IntPtr seed);

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
            public static partial IntPtr spanset_spanarr(IntPtr ss, IntPtr count);

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
            public static partial IntPtr textset_values(IntPtr s, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long tstzset_end_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long tstzset_start_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tstzset_value_n(IntPtr s, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzset_values(IntPtr s, IntPtr count);

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
            public static partial IntPtr bigintset_shift_scale(IntPtr s, IntPtr shift, IntPtr width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintspan_shift_scale(IntPtr s, IntPtr shift, IntPtr width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintspanset_shift_scale(IntPtr ss, IntPtr shift, IntPtr width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

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
            public static partial IntPtr set_spans(IntPtr s, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_split_each_n_spans(IntPtr s, int elems_per_span, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_split_n_spans(IntPtr s, int span_count, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_spans(IntPtr ss, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_split_each_n_spans(IntPtr ss, int elems_per_span, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_split_n_spans(IntPtr ss, int span_count, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_span_bigint(IntPtr s, IntPtr i);

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
            public static partial bool adjacent_spanset_bigint(IntPtr ss, IntPtr i);

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
            public static partial bool contained_bigint_set(IntPtr i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_bigint_span(IntPtr i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_bigint_spanset(IntPtr i, IntPtr ss);

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
            public static partial bool contains_set_bigint(IntPtr s, IntPtr i);

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
            public static partial bool contains_span_bigint(IntPtr s, IntPtr i);

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
            public static partial bool contains_spanset_bigint(IntPtr ss, IntPtr i);

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
            public static partial bool same_span_span(IntPtr s1, IntPtr s2);

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
            public static partial bool left_bigint_set(IntPtr i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_bigint_span(IntPtr i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_bigint_spanset(IntPtr i, IntPtr ss);

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
            public static partial bool left_set_bigint(IntPtr s, IntPtr i);

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
            public static partial bool left_span_bigint(IntPtr s, IntPtr i);

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
            public static partial bool left_spanset_bigint(IntPtr ss, IntPtr i);

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
            public static partial bool overleft_bigint_set(IntPtr i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_bigint_span(IntPtr i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_bigint_spanset(IntPtr i, IntPtr ss);

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
            public static partial bool overleft_set_bigint(IntPtr s, IntPtr i);

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
            public static partial bool overleft_span_bigint(IntPtr s, IntPtr i);

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
            public static partial bool overleft_spanset_bigint(IntPtr ss, IntPtr i);

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
            public static partial bool overright_bigint_set(IntPtr i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_bigint_span(IntPtr i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_bigint_spanset(IntPtr i, IntPtr ss);

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
            public static partial bool overright_set_bigint(IntPtr s, IntPtr i);

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
            public static partial bool overright_span_bigint(IntPtr s, IntPtr i);

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
            public static partial bool overright_spanset_bigint(IntPtr ss, IntPtr i);

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
            public static partial bool right_bigint_set(IntPtr i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_bigint_span(IntPtr i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_bigint_spanset(IntPtr i, IntPtr ss);

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
            public static partial bool right_set_bigint(IntPtr s, IntPtr i);

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
            public static partial bool right_span_bigint(IntPtr s, IntPtr i);

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
            public static partial bool right_spanset_bigint(IntPtr ss, IntPtr i);

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
            public static partial IntPtr intersection_bigint_set(IntPtr i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_date_set(int d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_float_set(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_int_set(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_set_bigint(IntPtr s, IntPtr i);

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
            public static partial IntPtr intersection_span_bigint(IntPtr s, IntPtr i);

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
            public static partial IntPtr intersection_spanset_bigint(IntPtr ss, IntPtr i);

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
            public static partial IntPtr minus_bigint_set(IntPtr i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_bigint_span(IntPtr i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_bigint_spanset(IntPtr i, IntPtr ss);

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
            public static partial IntPtr minus_set_bigint(IntPtr s, IntPtr i);

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
            public static partial IntPtr minus_span_bigint(IntPtr s, IntPtr i);

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
            public static partial IntPtr minus_spanset_bigint(IntPtr ss, IntPtr i);

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
            public static partial IntPtr union_bigint_set(IntPtr i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_bigint_span(IntPtr s, IntPtr i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_bigint_spanset(IntPtr i, IntPtr ss);

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
            public static partial IntPtr union_set_bigint(IntPtr s, IntPtr i);

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
            public static partial IntPtr union_span_bigint(IntPtr s, IntPtr i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_span_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_span_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_span_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr super_union_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_span_spanset(IntPtr s, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_span_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_spanset_bigint(IntPtr ss, IntPtr i);

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
            public static partial IntPtr distance_bigintset_bigintset(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr distance_bigintspan_bigintspan(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr distance_bigintspanset_bigintspan(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr distance_bigintspanset_bigintspanset(IntPtr ss1, IntPtr ss2);

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
            public static partial IntPtr distance_set_bigint(IntPtr s, IntPtr i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int distance_set_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_set_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int distance_set_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_set_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr distance_span_bigint(IntPtr s, IntPtr i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int distance_span_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_span_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int distance_span_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_span_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr distance_spanset_bigint(IntPtr ss, IntPtr i);

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
            public static partial IntPtr bigint_extent_transfn(IntPtr state, IntPtr i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigint_union_transfn(IntPtr state, IntPtr i);

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
            public static partial IntPtr bigint_get_bin(IntPtr value, IntPtr vsize, IntPtr vorigin);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintspan_bins(IntPtr s, IntPtr vsize, IntPtr vorigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintspanset_bins(IntPtr ss, IntPtr vsize, IntPtr vorigin, IntPtr count);

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
            public static partial string tbox_as_hexwkb(IntPtr box, IntPtr variant, IntPtr size_out);

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
            public static partial IntPtr bigint_timestamptz_to_tbox(IntPtr i, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr int_tstzspan_to_tbox(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigint_tstzspan_to_tbox(IntPtr i, IntPtr s);

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
            public static partial IntPtr bigint_to_tbox(IntPtr i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_to_tbox(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr span_to_tbox(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_to_tbox(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_to_intspan(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_to_bigintspan(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_to_floatspan(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_to_tstzspan(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr timestamptz_to_tbox(long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tbox_hash(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_hash_extended(IntPtr box, IntPtr seed);

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
            public static partial bool tboxbigint_xmax(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tboxint_xmin(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tboxbigint_xmin(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloatbox_expand(IntPtr box, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintbox_expand(IntPtr box, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_expand_time(IntPtr box, IntPtr interv);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_round(IntPtr box, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloatbox_shift_scale(IntPtr box, double shift, double width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintbox_shift_scale(IntPtr box, int shift, int width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_shift_scale_time(IntPtr box, IntPtr shift, IntPtr duration);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbigintbox_expand(IntPtr box, IntPtr i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbigintbox_shift_scale(IntPtr box, IntPtr shift, IntPtr width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

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
            public static partial IntPtr tbigint_from_mfjson(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbigint_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tint_out(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tbigint_out(IntPtr temp);

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
            public static partial IntPtr tbigint_from_base_temp(IntPtr i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintinst_make(int i, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbigintinst_make(IntPtr i, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintseq_from_base_tstzset(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbigintseq_from_base_tstzset(IntPtr i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintseq_from_base_tstzspan(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbigintseq_from_base_tstzspan(IntPtr i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintseqset_from_base_tstzspanset(int i, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbigintseqset_from_base_tstzspanset(IntPtr i, IntPtr ss);

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
            public static partial IntPtr tfloat_to_tbigint(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_to_tfloat(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_to_tbigint(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbigint_to_tint(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbigint_to_tfloat(IntPtr temp);

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
            public static partial int temporal_hash(IntPtr temp);

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
            public static partial string temporal_basetype_name(IntPtr temp);

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
            public static partial IntPtr tbigint_end_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tint_max_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbigint_max_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tint_min_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbigint_min_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tint_start_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbigint_start_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tbigint_value_at_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool strict, IntPtr value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tint_value_at_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool strict, IntPtr value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tint_value_n(IntPtr temp, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tbigint_value_n(IntPtr temp, IntPtr n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_values(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbigint_values(IntPtr temp, IntPtr count);

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
            public static partial IntPtr tbigint_scale_value(IntPtr temp, IntPtr width);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_shift_scale_value(IntPtr temp, int shift, int width);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbigint_shift_scale_value(IntPtr temp, IntPtr shift, IntPtr width);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_shift_value(IntPtr temp, int shift);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbigint_shift_value(IntPtr temp, IntPtr shift);

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
            public static partial int always_eq_bigint_tbigint(IntPtr i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_tbigint_bigint(IntPtr temp, IntPtr i);

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
            public static partial int always_ge_bigint_tbigint(IntPtr i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ge_tbigint_bigint(IntPtr temp, IntPtr i);

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
            public static partial int always_gt_bigint_tbigint(IntPtr i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_gt_tbigint_bigint(IntPtr temp, IntPtr i);

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
            public static partial int always_le_bigint_tbigint(IntPtr i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_le_tbigint_bigint(IntPtr temp, IntPtr i);

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
            public static partial int always_lt_bigint_tbigint(IntPtr i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_lt_tbigint_bigint(IntPtr temp, IntPtr i);

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
            public static partial int always_ne_bigint_tbigint(IntPtr i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_tbigint_bigint(IntPtr temp, IntPtr i);

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
            public static partial int ever_eq_bigint_tbigint(IntPtr i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_tbigint_bigint(IntPtr temp, IntPtr i);

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
            public static partial int ever_ge_bigint_tbigint(IntPtr i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ge_tbigint_bigint(IntPtr temp, IntPtr i);

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
            public static partial int ever_gt_bigint_tbigint(IntPtr i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_gt_tbigint_bigint(IntPtr temp, IntPtr i);

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
            public static partial int ever_le_bigint_tbigint(IntPtr i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_le_tbigint_bigint(IntPtr temp, IntPtr i);

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
            public static partial int ever_lt_bigint_tbigint(IntPtr i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_lt_tbigint_bigint(IntPtr temp, IntPtr i);

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
            public static partial int ever_ne_bigint_tbigint(IntPtr i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_tbigint_bigint(IntPtr temp, IntPtr i);

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
            public static partial IntPtr add_bigint_tbigint(IntPtr i, IntPtr tnumber);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr add_tbigint_bigint(IntPtr tnumber, IntPtr i);

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
            public static partial IntPtr div_bigint_tbigint(IntPtr i, IntPtr tnumber);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr div_tbigint_bigint(IntPtr tnumber, IntPtr i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr div_tnumber_tnumber(IntPtr tnumber1, IntPtr tnumber2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr mul_float_tfloat(double d, IntPtr tnumber);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr mul_int_tint(int i, IntPtr tnumber);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr mul_tfloat_float(IntPtr tnumber, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr mul_tint_int(IntPtr tnumber, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr mul_bigint_tbigint(IntPtr i, IntPtr tnumber);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr mul_tbigint_bigint(IntPtr tnumber, IntPtr i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr mul_tnumber_tnumber(IntPtr tnumber1, IntPtr tnumber2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr sub_float_tfloat(double d, IntPtr tnumber);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr sub_int_tint(int i, IntPtr tnumber);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr sub_tfloat_float(IntPtr tnumber, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr sub_tint_int(IntPtr tnumber, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr sub_bigint_tbigint(IntPtr i, IntPtr tnumber);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr sub_tbigint_bigint(IntPtr tnumber, IntPtr i);

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
            public static partial IntPtr tfloat_sin(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_cos(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_tan(IntPtr temp);

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
            public static partial IntPtr tbool_tand_combinefn(IntPtr state1, IntPtr state2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbool_tor_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbool_tor_combinefn(IntPtr state1, IntPtr state2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_extent_transfn(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_tagg_finalfn(IntPtr state);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_tcount_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_tcount_combinefn(IntPtr state1, IntPtr state2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_tmax_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_tmax_combinefn(IntPtr state1, IntPtr state2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_tmin_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_tmin_combinefn(IntPtr state1, IntPtr state2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_tsum_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_tsum_combinefn(IntPtr state1, IntPtr state2);

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
            public static partial IntPtr tint_tmax_combinefn(IntPtr state1, IntPtr state2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_tmin_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_tmin_combinefn(IntPtr state1, IntPtr state2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_tsum_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_tsum_combinefn(IntPtr state1, IntPtr state2);

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
            public static partial IntPtr tnumber_tavg_combinefn(IntPtr state1, IntPtr state2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_wavg_transfn(IntPtr state, IntPtr temp, IntPtr interv);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzset_tcount_transfn(IntPtr state, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspan_tcount_transfn(IntPtr state, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspanset_tcount_transfn(IntPtr state, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_merge_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_merge_combinefn(IntPtr state1, IntPtr state2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_tmax_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_tmax_combinefn(IntPtr state1, IntPtr state2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_tmin_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_tmin_combinefn(IntPtr state1, IntPtr state2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_simplify_dp(IntPtr temp, double dist, [MarshalAs(UnmanagedType.U1)] bool synchronized);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_simplify_max_dist(IntPtr temp, double dist, [MarshalAs(UnmanagedType.U1)] bool synchronized);

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
            public static partial double temporal_average_hausdorff_distance(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double temporal_lcss_distance(IntPtr temp1, IntPtr temp2, double epsilon);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_ext_kalman_filter(IntPtr temp, double gate, double q, double variance, [MarshalAs(UnmanagedType.U1)] bool to_drop);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_time_bins(IntPtr temp, IntPtr duration, long origin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_time_split(IntPtr temp, IntPtr duration, long torigin, IntPtr bins, IntPtr count);

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
            public static partial IntPtr box3d_from_gbox(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr box3d_make(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr box3d_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string box3d_out(IntPtr box, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr gbox_make([MarshalAs(UnmanagedType.U1)] bool hasz, [MarshalAs(UnmanagedType.U1)] bool hasm, [MarshalAs(UnmanagedType.U1)] bool geodetic, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, double mmin, double mmax);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr gbox_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string gbox_out(IntPtr box, int maxdd);

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
            public static partial IntPtr geog_from_hexewkb(string wkt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geog_in(string str, int typmod);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geom_from_hexewkb(string wkt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geom_in(string str, int typmod);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_copy(IntPtr gs);

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
            public static partial bool geo_is_empty(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geo_is_unitary(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string geo_typename(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double geog_area(IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool use_spheroid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geog_centroid(IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool use_spheroid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double geog_length(IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool use_spheroid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double geog_perimeter(IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool use_spheroid);

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
            public static partial IntPtr geom_shortestline2d(IntPtr gs1, IntPtr gs2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geom_shortestline3d(IntPtr gs1, IntPtr gs2);

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
            public static partial bool geom_dwithin(IntPtr gs1, IntPtr gs2, double tolerance);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geom_dwithin2d(IntPtr gs1, IntPtr gs2, double tolerance);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geom_dwithin3d(IntPtr gs1, IntPtr gs2, double tolerance);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geom_intersects(IntPtr gs1, IntPtr gs2);

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
            public static partial string spatialset_out(IntPtr s, int maxdd);

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
            public static partial IntPtr geoset_values(IntPtr s, IntPtr count);

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
            public static partial string stbox_as_hexwkb(IntPtr box, IntPtr variant, IntPtr size_out);

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
            public static partial int stbox_hash(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_hash_extended(IntPtr box, IntPtr seed);

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
            public static partial string tspatial_out(IntPtr temp, int maxdd);

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
            public static partial IntPtr tpoint_as_mvtgeom(IntPtr temp, IntPtr bounds, int extent, int buffer, [MarshalAs(UnmanagedType.U1)] bool clip_geom);

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
            public static partial bool tgeo_value_at_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool strict, IntPtr result);

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
            public static partial int acovers_geo_tgeo(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int acovers_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int acovers_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int adisjoint_geo_tgeo(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int adisjoint_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int adisjoint_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int adwithin_geo_tgeo(IntPtr gs, IntPtr temp, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int adwithin_tgeo_geo(IntPtr temp, IntPtr gs, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int adwithin_tgeo_tgeo(IntPtr temp1, IntPtr temp2, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int aintersects_geo_tgeo(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int aintersects_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int aintersects_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int atouches_geo_tgeo(IntPtr gs, IntPtr temp);

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
            public static partial int edisjoint_geo_tgeo(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int edisjoint_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int edisjoint_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int edwithin_geo_tgeo(IntPtr gs, IntPtr temp, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int edwithin_tgeo_geo(IntPtr temp, IntPtr gs, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int edwithin_tgeo_tgeo(IntPtr temp1, IntPtr temp2, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int eintersects_geo_tgeo(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int eintersects_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int eintersects_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int etouches_geo_tgeo(IntPtr gs, IntPtr temp);

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
            public static partial IntPtr edwithin_tgeoarr_tgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2, double dist, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr adwithin_tgeoarr_tgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2, double dist, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr eintersects_tgeoarr_tgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr aintersects_tgeoarr_tgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr etouches_tgeoarr_tgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr atouches_tgeoarr_tgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr edisjoint_tgeoarr_tgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr adisjoint_tgeoarr_tgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdwithin_tgeoarr_tgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2, double dist, IntPtr count, IntPtr periods);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintersects_tgeoarr_tgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2, IntPtr count, IntPtr periods);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttouches_tgeoarr_tgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2, IntPtr count, IntPtr periods);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdisjoint_tgeoarr_tgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2, IntPtr count, IntPtr periods);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdistance_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdistance_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_stbox_geo(IntPtr box, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double stbox_spatial_distance(IntPtr box1, IntPtr box2);

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
            public static partial double mindistance_tgeo_tgeo(IntPtr temp1, IntPtr temp2, double threshold);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double mindistance_tgeoarr_tgeoarr(IntPtr arr1, int count1, IntPtr arr2, int count2);

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
            public static partial IntPtr tgeo_space_split(IntPtr temp, double xsize, double ysize, double zsize, IntPtr sorigin, [MarshalAs(UnmanagedType.U1)] bool bitmatrix, [MarshalAs(UnmanagedType.U1)] bool border_inc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeo_space_time_split(IntPtr temp, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, long torigin, [MarshalAs(UnmanagedType.U1)] bool bitmatrix, [MarshalAs(UnmanagedType.U1)] bool border_inc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_cluster_kmeans(IntPtr geoms, uint ngeoms, uint k, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_cluster_dbscan(IntPtr geoms, uint ngeoms, double tolerance, int minpoints, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_cluster_intersecting(IntPtr geoms, uint ngeoms, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_cluster_within(IntPtr geoms, uint ngeoms, double tolerance, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string cbuffer_as_ewkt(IntPtr cb, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string cbuffer_as_hexwkb(IntPtr cb, IntPtr variant, IntPtr size_out);

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
            public static partial int cbuffer_hash(IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbuffer_hash_extended(IntPtr cb, IntPtr seed);

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
            public static partial IntPtr cbufferset_values(IntPtr s, IntPtr count);

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
            public static partial IntPtr tcbuffer_from_mfjson(string mfjson);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbufferinst_make(IntPtr cb, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbuffer_make(IntPtr tpoint, IntPtr tfloat);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbuffer_from_base_temp(IntPtr cb, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbufferseq_from_base_tstzset(IntPtr cb, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbufferseq_from_base_tstzspan(IntPtr cb, IntPtr s, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbufferseqset_from_base_tstzspanset(IntPtr cb, IntPtr ss, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbuffer_end_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbuffer_points(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbuffer_radius(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbuffer_traversed_area(IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool unary_union);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbuffer_convex_hull(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbuffer_start_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tcbuffer_value_at_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool strict, IntPtr value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tcbuffer_value_n(IntPtr temp, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbuffer_values(IntPtr temp, IntPtr count);

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
            public static partial double mindistance_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2, double threshold);

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
            public static partial int acovers_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2);

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
            public static partial int ecovers_geo_tcbuffer(IntPtr gs, IntPtr temp);

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
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_cbuffer_cbuffer(IntPtr cb1, IntPtr cb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_cbuffer_geo(IntPtr cb, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_cbuffer_stbox(IntPtr cb, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_cbufferset_cbuffer(IntPtr s, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool cbuffer_collinear(IntPtr cb1, IntPtr cb2, IntPtr cbuf3, double ratio);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbuffersegm_interpolate(IntPtr start, IntPtr end, IntPtr ratio);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbuffersegm_locate(IntPtr start, IntPtr end, IntPtr value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbuffer_parse(IntPtr str, [MarshalAs(UnmanagedType.U1)] bool end);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string cbuffer_wkt_out(long value, int maxdd, [MarshalAs(UnmanagedType.U1)] bool extended);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbuffer_point_p(IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_cbuffer_round(long buffer, long size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cbuffer_transf_pj(IntPtr cb, int srid_to, IntPtr pj);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double cbuffer_distance(IntPtr cb1, IntPtr cb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_cbuffer_distance(long cb1, long cb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int cbuffersegm_distance_turnpt(IntPtr start1, IntPtr end1, IntPtr start2, IntPtr end2, long lower, long upper, IntPtr t1, IntPtr t2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int cbuffer_contains(IntPtr cb1, IntPtr cb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int cbuffer_covers(IntPtr cb1, IntPtr cb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int cbuffer_disjoint(IntPtr cb1, IntPtr cb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int cbuffer_intersects(IntPtr cb1, IntPtr cb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int cbuffer_dwithin(IntPtr cb1, IntPtr cb2, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int cbuffer_touches(IntPtr cb1, IntPtr cb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_cbuffer_contains(long cb1, long cb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_cbuffer_covers(long cb1, long cb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_cbuffer_disjoint(long cb1, long cb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_cbuffer_intersects(long cb1, long cb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_cbuffer_dwithin(long cb1, long cb2, long dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_cbuffer_touches(long cb1, long cb2);

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
            public static partial int meos_typeof_hexwkb(string hexwkb);

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
            public static partial IntPtr gsl_get_generation_rng();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr gsl_get_aggregation_rng();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_ceil(long d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_degrees(long d, long normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_float_round(long value, long size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_floor(long d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int datum_hash(long d, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr datum_hash_extended(long d, int basetype, IntPtr seed);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_radians(long d);

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
            public static partial IntPtr span_make(long lower, long upper, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void span_set(long lower, long upper, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc, int basetype, int spantype, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_make_exp(IntPtr spans, int count, int maxcount, [MarshalAs(UnmanagedType.U1)] bool normalize, [MarshalAs(UnmanagedType.U1)] bool order);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_make_free(IntPtr spans, int count, [MarshalAs(UnmanagedType.U1)] bool normalize, [MarshalAs(UnmanagedType.U1)] bool order);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_span(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_spanset(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void value_set_span(long value, int basetype, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr value_set(long d, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr value_span(long d, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr value_spanset(long d, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long numspan_width(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long numspanset_width(IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool boundspan);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long set_end_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int set_mem_size(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void set_set_subspan(IntPtr s, int minidx, int maxidx, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void set_set_span(IntPtr s, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long set_start_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool set_value_n(IntPtr s, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_vals(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_values(IntPtr s, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long spanset_lower(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int spanset_mem_size(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_sps(IntPtr ss, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long spanset_upper(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void datespan_set_tstzspan(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void bigintspan_set_floatspan(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void bigintspan_set_intspan(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void floatspan_set_bigintspan(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void floatspan_set_intspan(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void intspan_set_bigintspan(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void intspan_set_floatspan(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr numset_shift_scale(IntPtr s, long shift, long width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr numspan_expand(IntPtr s, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr numspan_shift_scale(IntPtr s, long shift, long width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr numspanset_shift_scale(IntPtr ss, long shift, long width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_compact(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void span_expand(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_compact(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_expand_value(IntPtr box, long value, int basetyp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr textcat_textset_text_common(IntPtr s, IntPtr txt, [MarshalAs(UnmanagedType.U1)] bool invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tstzspan_set_datespan(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_span_value(IntPtr s, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_spanset_value(IntPtr ss, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_value_spanset(long value, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_value_set(long value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_value_span(long value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_value_spanset(long value, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_set_value(IntPtr s, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_span_value(IntPtr s, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_spanset_value(IntPtr ss, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ovadj_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_set_value(IntPtr s, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_span_value(IntPtr s, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_spanset_value(IntPtr ss, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_value_set(long value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_value_span(long value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_value_spanset(long value, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool lfnadj_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_set_value(IntPtr s, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_span_value(IntPtr s, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_spanset_value(IntPtr ss, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_value_set(long value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_value_span(long value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_value_spanset(long value, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_set_value(IntPtr s, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_span_value(IntPtr s, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_spanset_value(IntPtr ss, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_value_set(long value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_value_span(long value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_value_spanset(long value, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_value_set(long value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_set_value(IntPtr s, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_value_span(long value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_value_spanset(long value, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_span_value(IntPtr s, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_spanset_value(IntPtr ss, long value);

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
            public static partial IntPtr intersection_set_value(IntPtr s, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_span_value(IntPtr s, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_spanset_value(IntPtr ss, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_value_set(long value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_value_span(long value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_value_spanset(long value, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int mi_span_span(IntPtr s1, IntPtr s2, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_set_value(IntPtr s, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_span_value(IntPtr s, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_spanset_value(IntPtr ss, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_value_set(long value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_value_span(long value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_value_spanset(long value, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_set_value(IntPtr s, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_span_value(IntPtr s, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_spanset_value(IntPtr ss, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_value_set(long value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_value_span(long value, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_value_spanset(long value, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long distance_set_set(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long distance_set_value(IntPtr s, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long distance_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long distance_span_value(IntPtr s, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long distance_spanset_span(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long distance_spanset_spanset(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long distance_spanset_value(IntPtr ss, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long distance_value_value(long l, long r, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanbase_extent_transfn(IntPtr state, long value, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr value_union_transfn(IntPtr state, long value, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr number_tstzspan_to_tbox(long d, int basetype, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr number_timestamptz_to_tbox(long d, int basetype, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tbox_set(IntPtr s, IntPtr p, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void float_set_tbox(double d, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void int_set_tbox(int i, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void number_set_tbox(long d, int basetype, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr number_tbox(long value, int basetype);

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
            public static partial IntPtr tbox_shift_scale_value(IntPtr box, long shift, long width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

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
            public static partial IntPtr tbigintinst_from_mfjson(IntPtr mfjson);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbigintinst_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbigintseq_from_mfjson(IntPtr mfjson);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbigintseqset_from_mfjson(IntPtr mfjson);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbigintseqset_in(string str);

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
            public static partial IntPtr temporal_from_base_temp(long value, int temptype, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_copy(IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_make(long value, int temptype, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_make_free(long value, int temptype, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_copy(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_from_base_temp(long value, int temptype, IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_from_base_tstzset(long value, int temptype, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_from_base_tstzspan(long value, int temptype, IntPtr s, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_make_exp(IntPtr instants, int count, int maxcount, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc, int interp, [MarshalAs(UnmanagedType.U1)] bool normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_make_free(IntPtr instants, int count, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc, int interp, [MarshalAs(UnmanagedType.U1)] bool normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_copy(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tseqsetarr_to_tseqset(IntPtr seqsets, int count, int totalseqs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_from_base_temp(long value, int temptype, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_from_base_tstzspanset(long value, int temptype, IntPtr ss, int interp);

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
            public static partial long temporal_end_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_inst_n(IntPtr temp, int n);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_insts_p(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_max_inst_p(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long temporal_max_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong temporal_mem_size(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_min_inst_p(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long temporal_min_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_sequences_p(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void temporal_set_bbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_start_inst(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long temporal_start_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_values_p(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool temporal_value_n(IntPtr temp, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_values(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tinstant_hash(IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_insts(IntPtr inst, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tinstant_set_bbox(IntPtr inst, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_time(IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_timestamps(IntPtr inst, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long tinstant_value_p(IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long tinstant_value(IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tinstant_value_at_timestamptz(IntPtr inst, long t, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_values_p(IntPtr inst, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tnumber_set_span(IntPtr temp, IntPtr s);

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
            public static partial int tsequence_hash(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_insts_p(IntPtr seq, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_max_inst_p(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long tsequence_max_val(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_min_inst_p(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long tsequence_min_val(IntPtr seq);

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
            public static partial int tsequenceset_hash(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_inst_n(IntPtr ss, int n);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_insts_p(IntPtr ss, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_max_inst_p(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long tsequenceset_max_val(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_min_inst_p(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long tsequenceset_min_val(IntPtr ss);

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
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tsequenceset_value_n_p(IntPtr ss, int n, IntPtr result);

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
            public static partial IntPtr tnumber_shift_scale_value(IntPtr temp, long shift, long width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumberinst_shift_value(IntPtr inst, long shift);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumberseq_shift_scale_value(IntPtr seq, long shift, long width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumberseqset_shift_scale_value(IntPtr ss, long start, long width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

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
            public static partial IntPtr temporal_restrict_value(IntPtr temp, long value, [MarshalAs(UnmanagedType.U1)] bool atfunc);

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
            public static partial IntPtr tinstant_restrict_value(IntPtr inst, long value, [MarshalAs(UnmanagedType.U1)] bool atfunc);

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
            public static partial IntPtr tsequenceset_restrict_value(IntPtr ss, long value, [MarshalAs(UnmanagedType.U1)] bool atfunc);

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
            public static partial int always_eq_base_temporal(long value, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_temporal_base(IntPtr temp, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_base_temporal(long value, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_temporal_base(IntPtr temp, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ge_base_temporal(long value, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ge_temporal_base(IntPtr temp, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_gt_base_temporal(long value, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_gt_temporal_base(IntPtr temp, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_le_base_temporal(long value, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_le_temporal_base(IntPtr temp, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_lt_base_temporal(long value, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_lt_temporal_base(IntPtr temp, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_base_temporal(long value, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_temporal_base(IntPtr temp, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_base_temporal(long value, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_temporal_base(IntPtr temp, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ge_base_temporal(long value, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ge_temporal_base(IntPtr temp, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_gt_base_temporal(long value, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_gt_temporal_base(IntPtr temp, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_le_base_temporal(long value, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_le_temporal_base(IntPtr temp, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_lt_base_temporal(long value, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_lt_temporal_base(IntPtr temp, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumberinst_abs(IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tnumberinst_distance(IntPtr inst1, IntPtr inst2);

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
            public static partial IntPtr tdistance_tnumber_number(IntPtr temp, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tnumber_number(IntPtr temp, long value);

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
            public static partial IntPtr skiplist_make(IntPtr key_size, IntPtr value_size, IntPtr comp_fn, IntPtr merge_fn);

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
            public static partial IntPtr span_bins(IntPtr s, long size, long origin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_bins(IntPtr ss, long size, long origin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_value_bins(IntPtr temp, long size, long origin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_value_time_boxes(IntPtr temp, long vsize, IntPtr duration, long vorigin, long torigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_value_split(IntPtr temp, long vsize, long vorigin, IntPtr bins, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_get_value_time_tile(long value, long t, long vsize, IntPtr duration, long vorigin, long torigin, int basetype, int spantype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_value_time_split(IntPtr temp, long size, IntPtr duration, long vorigin, long torigin, IntPtr value_bins, IntPtr time_bins, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string double2_out(IntPtr d, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void double2_set(double a, double b, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr double2_add(IntPtr d1, IntPtr d2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool double2_eq(IntPtr d1, IntPtr d2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string double3_out(IntPtr d, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void double3_set(double a, double b, double c, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr double3_add(IntPtr d1, IntPtr d2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool double3_eq(IntPtr d1, IntPtr d2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string double4_out(IntPtr d, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void double4_set(double a, double b, double c, double d, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr double4_add(IntPtr d1, IntPtr d2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool double4_eq(IntPtr d1, IntPtr d2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool double2_collinear(IntPtr x1, IntPtr x2, IntPtr x3, double ratio);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool double3_collinear(IntPtr x1, IntPtr x2, IntPtr x3, double ratio);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool double4_collinear(IntPtr x1, IntPtr x2, IntPtr x3, double ratio);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr double2segm_interpolate(IntPtr start, IntPtr end, IntPtr ratio);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr double3segm_interpolate(IntPtr start, IntPtr end, IntPtr ratio);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr double4segm_interpolate(IntPtr start, IntPtr end, IntPtr ratio);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int pg_atoi(string s, int size, int c);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_has_X(int type, short flags);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_has_Z(int type, short flags);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_has_T(int type, short flags);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_has_not_Z(int type, short flags);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_not_null(IntPtr ptr);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_one_not_null(IntPtr ptr1, IntPtr ptr2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_one_true([MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_interp(int temptype, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_continuous(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_same_interp(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_same_continuous_interp(short flags1, short flags2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_linear_interp(short flags);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_nonlinear_interp(short flags);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_common_dimension(short flags1, short flags2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_temporal_isof_type(IntPtr temp, int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_temporal_isof_basetype(IntPtr temp, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_temporal_isof_subtype(IntPtr temp, int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_same_temporal_type(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tnumber_numspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tnumber_numspanset(IntPtr temp, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_temporal_set(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_not_negative(int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_positive(int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool not_negative_datum(long size, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_not_negative_datum(long size, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool positive_datum(long size, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_positive_datum(long size, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_day_duration(IntPtr duration);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool positive_duration(IntPtr duration);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_positive_duration(IntPtr duration);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_bbox_ptr(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool intersection_temporal_temporal(IntPtr temp1, IntPtr temp2, IntPtr mode, IntPtr inter1, IntPtr inter2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string mobilitydb_version();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string mobilitydb_full_version();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr round_fn(int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool temporal_bbox_restrict_value(IntPtr temp, long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tcbuffer_cbuffer(IntPtr temp, IntPtr cb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tcbuffer_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tcbuffer_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tcbuffersegm_intersection_value(long start, long end, long value, long lower, long upper, IntPtr t1, IntPtr t2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tcbuffersegm_intersection(long start1, long end1, long start2, long end2, long lower, long upper, IntPtr t1, IntPtr t2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tcbuffersegm_dwithin_turnpt(long start1, long end1, long start2, long end2, long dist, long lower, long upper, IntPtr t1, IntPtr t2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tcbuffersegm_tdwithin_turnpt(long start1, long end1, long start2, long end2, long dist, long lower, long upper, IntPtr t1, IntPtr t2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tcbuffersegm_distance_turnpt(long start1, long end1, long start2, long end2, long dist, long lower, long upper, IntPtr t1, IntPtr t2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbuffer_geo_ctx_make(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tcbuffer_geo_ctx_free(IntPtr ctx);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tcbuffer_geo_ctx_nsegs(IntPtr ctx);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tcbuffer_disc_within_ctx(IntPtr cb, double dist, IntPtr ctx);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tcbufferseg_within_ctx(IntPtr cb1, IntPtr cb2, double dist, IntPtr ctx, IntPtr outlo, IntPtr outhi, int maxout);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tcbuffer_disc_touch_ctx(IntPtr cb, IntPtr ctx);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tcbufferseg_touch_roots(IntPtr cb1, IntPtr cb2, IntPtr ctx, IntPtr outt, int maxout);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool cbuffer_set_stbox(IntPtr cb, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void cbufferarr_set_stbox(IntPtr values, int count, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void cbuffer_timestamptz_set_stbox(IntPtr cb, long t, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void cbuffer_tstzspan_set_stbox(IntPtr cb, IntPtr s, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tcbufferinst_set_stbox(IntPtr inst, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tcbufferinstarr_set_stbox(IntPtr instants, int count, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tcbufferseq_expand_stbox(IntPtr seq, IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbufferinst_traversed_area(IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbufferseq_traversed_area(IntPtr seq, [MarshalAs(UnmanagedType.U1)] bool unary_union);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbufferseqset_traversed_area(IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool unary_union);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbuffersegm_traversed_area(IntPtr inst1, IntPtr inst2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbuffer_restrict_cbuffer(IntPtr temp, IntPtr cb, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbuffer_restrict_stbox(IntPtr temp, IntPtr box, [MarshalAs(UnmanagedType.U1)] bool border_inc, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcbuffer_restrict_geom(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_contains_geo_tcbuffer(IntPtr gs, IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_contains_tcbuffer_geo(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_contains_tcbuffer_cbuffer(IntPtr temp, IntPtr cb, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_contains_cbuffer_tcbuffer(IntPtr cb, IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_covers_geo_tcbuffer(IntPtr gs, IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_covers_tcbuffer_geo(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_covers_tcbuffer_cbuffer(IntPtr temp, IntPtr cb, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_covers_cbuffer_tcbuffer(IntPtr cb, IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_covers_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_disjoint_tcbuffer_geo(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_disjoint_geo_tcbuffer(IntPtr gs, IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_disjoint_tcbuffer_cbuffer(IntPtr temp, IntPtr cb, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_disjoint_cbuffer_tcbuffer(IntPtr cb, IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_disjoint_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_intersects_tcbuffer_geo(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_intersects_geo_tcbuffer(IntPtr gs, IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_intersects_tcbuffer_cbuffer(IntPtr temp, IntPtr cb, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_intersects_cbuffer_tcbuffer(IntPtr cb, IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_intersects_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_touches_tcbuffer_geo(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_touches_geo_tcbuffer(IntPtr gs, IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_touches_tcbuffer_cbuffer(IntPtr temp, IntPtr cb, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_touches_cbuffer_tcbuffer(IntPtr cb, IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_touches_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_dwithin_tcbuffer_tcbuffer(IntPtr temp1, IntPtr temp2, double dist, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinterrel_tcbuffer_cbuffer(IntPtr temp, IntPtr cb, [MarshalAs(UnmanagedType.U1)] bool tinter);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinterrel_tcbuffer_geo(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool tinter);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int edisjoint_tcbuffer_geo_native(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int eatouches_tcbuffer_geo_native(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr clipper2_clip_poly_poly(IntPtr subj, IntPtr clip, int op);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr clipper2_traj_poly_periods(IntPtr seq, IntPtr gs, IntPtr out_count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr clip_poly_poly(IntPtr subj, IntPtr clip, IntPtr operation);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int lwproj_lookup(int srid_from, int srid_to, IntPtr pj);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int spheroid_init_from_srid(int srid, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void srid_check_latlong(int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int srid_is_latlong(int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geom_serialize(IntPtr lwgeom);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geog_serialize(IntPtr lwgeom);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr meos_postgis_valid_typmod(IntPtr gs, int typmod);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string geo_as_wkt(IntPtr gs, int precision, [MarshalAs(UnmanagedType.U1)] bool extended);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr box2d_to_lwgeom(IntPtr box, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr box3d_to_lwgeom(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr MEOS_POSTGIS2GEOS(IntPtr pglwgeom);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr MEOS_GEOS2POSTGIS(IntPtr geom, byte want3d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geom_spatialrel(IntPtr gs1, IntPtr gs2, IntPtr rel);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr lwgeom_line_interpolate_point(IntPtr geom, double fraction, int srid, byte repeat);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void point_get_coords(IntPtr point, [MarshalAs(UnmanagedType.U1)] bool hasz, IntPtr x, IntPtr y, IntPtr z);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tstzset_stbox_slice(long tsdatum, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tstzspanset_stbox_slice(long psdatum, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool stbox_index_leaf_consistent(IntPtr key, IntPtr query, int strategy);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool stbox_gist_inner_consistent(IntPtr key, IntPtr query, int strategy);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool stbox_index_recheck(int strategy);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stboxnode_copy(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int getQuadrant8D(IntPtr centroid, IntPtr inBox);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void stboxnode_init(IntPtr centroid, IntPtr nodebox);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void stboxnode_quadtree_next(IntPtr nodebox, IntPtr centroid, int quadrant, IntPtr next_nodebox);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void stboxnode_kdtree_next(IntPtr nodebox, IntPtr centroid, int node, int level, IntPtr next_nodebox);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overlap8D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overlapKD(IntPtr nodebox, IntPtr query, int level);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contain8D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool containKD(IntPtr nodebox, IntPtr query, int level);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left8D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overLeft8D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right8D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overRight8D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool below8D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overBelow8D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool above8D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overAbove8D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool front8D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overFront8D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool back8D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overBack8D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool before8D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overBefore8D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool after8D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overAfter8D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_stbox_nodebox(IntPtr query, IntPtr nodebox);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tspatial_spgist_get_stbox(long value, int type, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void mobilitydb_init();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_stbox(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_geo(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcomp_geo_tgeo(IntPtr gs, IntPtr temp, IntPtr func);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcomp_tgeo_geo(IntPtr temp, IntPtr gs, IntPtr func);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_geoaggstate(IntPtr state, int srid, [MarshalAs(UnmanagedType.U1)] bool hasz);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_geoaggstate_state(IntPtr state1, IntPtr state2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_transform_tcentroid(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpointinst_tcentroid_finalfn(IntPtr instants, int count, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpointseq_tcentroid_finalfn(IntPtr sequences, int count, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool point3d_min_dist(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4, IntPtr fraction);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tgeompointsegm_distance_turnpt(long start1, long end1, long start2, long end2, long param, long lower, long upper, IntPtr t1, IntPtr t2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tgeogpointsegm_distance_turnpt(long start1, long end1, long start2, long end2, long param, long lower, long upper, IntPtr t1, IntPtr t2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tinstant_distance(IntPtr inst1, IntPtr inst2, IntPtr func);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpointseq_at_geom(IntPtr seq, IntPtr gs, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpointseq_interperiods(IntPtr seq, IntPtr gs, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void datum_point4d(long value, IntPtr p);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int geopoint_cmp(IntPtr gs1, IntPtr gs2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geopoint_eq(IntPtr gs1, IntPtr gs2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geopoint_same(IntPtr gs1, IntPtr gs2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool datum_point_eq(long point1, long point2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool datum_point_same(long point1, long point2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum2_point_eq(long point1, long point2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum2_point_ne(long point1, long point2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum2_point_same(long point1, long point2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum2_point_nsame(long point1, long point2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum2_geom_centroid(long geo);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum2_geog_centroid(long geo);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_extract_elements(IntPtr gs, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_serialize(IntPtr geom);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_distance_fn(short flags);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pt_distance_fn(short flags);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_geom_distance2d(long geom1, long geom2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_geom_distance3d(long geom1, long geom2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_geog_distance(long geog1, long geog2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_pt_distance2d(long geom1, long geom2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_pt_distance3d(long geom1, long geom2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial short spatial_flags(long d, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_srid_is_latlong(int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_spatial_validity(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_not_geodetic(short flags);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_same_geodetic(short flags1, short flags2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_same_geodetic_geo(IntPtr gs1, IntPtr gs2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_same_geodetic_tspatial_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_same_geodetic_tspatial_base(IntPtr temp, long @base);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_srid_known(int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_same_srid(int srid1, int srid2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_srid_reconcile(int srid1, int srid2, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_same_dimensionality(short flags1, short flags2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool same_spatial_dimensionality(short flags1, short flags2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_same_spatial_dimensionality(short flags1, short flags2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_same_dimensionality_geo(IntPtr gs1, IntPtr gs2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool same_dimensionality_tspatial_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_same_dimensionality_tspatial_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_same_spatial_dimensionality_stbox_geo(IntPtr box, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_same_geodetic_stbox_geo(IntPtr box, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_has_Z_geo(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_has_not_Z_geo(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_has_M_geo(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_has_not_M_geo(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_not_geodetic_geo(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_point_type(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_mline_type(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool circle_type(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_circle_type(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_not_empty(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_stbox_geo(IntPtr box, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tspatial_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tspatial_base(IntPtr temp, long @base);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tspatial_tspatial(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_spatial_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tgeo_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_geo_geo(IntPtr gs1, IntPtr gs2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tgeo_tgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tpoint_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool mline_type(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_get_coord(IntPtr temp, int coord);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int eacomp_tgeo_geo(IntPtr temp, IntPtr gs, IntPtr func, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr closest_point2d_on_segment_ratio(IntPtr p, IntPtr A, IntPtr B, IntPtr closest);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr closest_point3dz_on_segment_ratio(IntPtr p, IntPtr A, IntPtr B, IntPtr closest);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr closest_point_on_segment_sphere(IntPtr p, IntPtr A, IntPtr B, IntPtr closest, IntPtr dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void interpolate_point4d_spheroid(IntPtr p1, IntPtr p2, IntPtr p, IntPtr s, double f);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geopoint_make(double x, double y, double z, [MarshalAs(UnmanagedType.U1)] bool hasz, [MarshalAs(UnmanagedType.U1)] bool geodetic, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr lwcircle_make(double x, double y, double radius, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geocircle_make(double x, double y, double radius, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long pointsegm_interpolate(long start, long end, IntPtr ratio);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pointsegm_locate(long start, long end, long point, IntPtr dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tgeompointsegm_intersection(long start1, long end1, long start2, long end2, long lower, long upper, IntPtr t1, IntPtr t2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tgeogpointsegm_intersection(long start1, long end1, long start2, long end2, long lower, long upper, IntPtr t1, IntPtr t2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geopoint_collinear(long value1, long value2, long value3, double ratio, [MarshalAs(UnmanagedType.U1)] bool hasz, [MarshalAs(UnmanagedType.U1)] bool geodetic);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr lwpointarr_remove_duplicates(IntPtr points, int count, IntPtr newcount);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr lwpointarr_make_trajectory(IntPtr points, int count, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr lwline_make(long value1, long value2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr lwcoll_from_points_lines(IntPtr points, IntPtr lines, int npoints, int nlines);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tpointseq_stops_iter(IntPtr seq, double maxdist, int mintunits, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_geom_contains(long geom1, long geom2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_geom_covers(long geom1, long geom2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_geom_disjoint2d(long geom1, long geom2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_geom_disjoint3d(long geom1, long geom2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_geog_disjoint(long geog1, long geog2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_geom_intersects2d(long geom1, long geom2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_geom_intersects3d(long geom1, long geom2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_geog_intersects(long geog1, long geog2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_geom_touches(long geom1, long geom2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_geom_dwithin2d(long geom1, long geom2, long dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_geom_dwithin3d(long geom1, long geom2, long dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_geog_dwithin(long geog1, long geog2, long dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_geom_relate_pattern(long geog1, long geog2, long p);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_disjoint_fn(short flags1, short flags2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_disjoint_fn_geo(short flags1, IntPtr flags2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_intersects_fn(short flags1, short flags2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_intersects_fn_geo(short flags1, IntPtr flags2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_dwithin_fn(short flags1, short flags2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_dwithin_fn_geo(short flags1, IntPtr flags2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tpointsegm_tdwithin_turnpt(long start1, long end1, long start2, long end2, long value, long lower, long upper, IntPtr t1, IntPtr t2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int spatialrel_geo_geo(IntPtr gs1, IntPtr gs2, long param, IntPtr func, int numparam, [MarshalAs(UnmanagedType.U1)] bool invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int spatialrel_tgeo_tgeo(IntPtr temp1, IntPtr temp2, long param, IntPtr func, int numparam);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_contains_geo_tgeo(IntPtr gs, IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_contains_tgeo_geo(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_contains_tgeo_tgeo(IntPtr temp, IntPtr temp2, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_covers_geo_tgeo(IntPtr gs, IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_covers_tgeo_geo(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_covers_tgeo_tgeo(IntPtr temp, IntPtr temp2, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_disjoint_geo_tgeo(IntPtr gs, IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_disjoint_tgeo_geo(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_disjoint_tgeo_tgeo(IntPtr temp, IntPtr temp2, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_intersects_geo_tgeo(IntPtr gs, IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_intersects_tgeo_geo(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_intersects_tgeo_tgeo(IntPtr temp, IntPtr temp2, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_touches_tpoint_geo(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_touches_tgeo_geo(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_touches_tgeo_tgeo(IntPtr temp, IntPtr temp2, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_dwithin_tgeo_geo(IntPtr temp, IntPtr gs, double dist, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_dwithin_tgeo_tgeo(IntPtr temp1, IntPtr temp2, double dist, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_spatialrel_tspatial_geo(IntPtr temp, IntPtr gs, IntPtr func, [MarshalAs(UnmanagedType.U1)] bool ever, [MarshalAs(UnmanagedType.U1)] bool invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_spatialrel_tspatial_tspatial(IntPtr temp1, IntPtr temp2, IntPtr func, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tspatialrel_tspatial_base(IntPtr temp, long @base, long param, IntPtr func, int numparam, [MarshalAs(UnmanagedType.U1)] bool invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tspatialrel_tspatial_tspatial(IntPtr temp1, IntPtr temp2, long param, IntPtr func, int numparam, [MarshalAs(UnmanagedType.U1)] bool invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinterrel_tgeo_geo(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool tinter);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinterrel_tspatial_base(IntPtr temp, long @base, [MarshalAs(UnmanagedType.U1)] bool tinter, IntPtr func);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinterrel_tspatial_tspatial(IntPtr temp1, IntPtr temp2, [MarshalAs(UnmanagedType.U1)] bool tinter);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdwithin_tspatial_tspatial(IntPtr sync1, IntPtr sync2, long dist, IntPtr func, IntPtr tpfn);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tdwithin_add_solutions(int solutions, long lower, long upper, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc1, long t1, long t2, IntPtr instants, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdwithin_tspatial_spatial(IntPtr temp, long @base, long dist, IntPtr func, IntPtr tpfn);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bitmatrix_make(IntPtr count, int ndims);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tpoint_set_tiles(IntPtr temp, IntPtr state, IntPtr bm);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_at_tile(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void stbox_tile_state_set(double x, double y, double z, long t, double xsize, double ysize, double zsize, IntPtr tunits, [MarshalAs(UnmanagedType.U1)] bool hasx, [MarshalAs(UnmanagedType.U1)] bool hasz, [MarshalAs(UnmanagedType.U1)] bool hast, int srid, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_tile_state_make(IntPtr temp, IntPtr box, double xsize, double ysize, double zsize, IntPtr duration, int sorigin, long torigin, [MarshalAs(UnmanagedType.U1)] bool border_inc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void stbox_tile_state_next(IntPtr state);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool stbox_tile_state_get(IntPtr state, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeo_space_time_tile_init(IntPtr temp, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, long torigin, [MarshalAs(UnmanagedType.U1)] bool bitmatrix, [MarshalAs(UnmanagedType.U1)] bool border_inc, IntPtr ntiles);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_space_time_tile(IntPtr point, long t, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, long torigin, [MarshalAs(UnmanagedType.U1)] bool hasx, [MarshalAs(UnmanagedType.U1)] bool hast);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr create_trip(IntPtr lines, IntPtr maxSpeeds, IntPtr categories, uint noEdges, long startTime, [MarshalAs(UnmanagedType.U1)] bool disturbData, int verbosity);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spatialarr_wkt_out(IntPtr spatialarr, int basetype, int count, int maxdd, [MarshalAs(UnmanagedType.U1)] bool extended);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string spatialbase_as_text(long value, int type, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string spatialbase_as_ewkt(long value, int type, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool point_transf_pj(IntPtr gs, int srid_to, IntPtr pj);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tgeoinst_set_stbox(IntPtr inst, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tgeoinstarr_set_stbox(IntPtr instants, int count, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tgeoseq_expand_stbox(IntPtr seq, IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tspatialinst_set_stbox(IntPtr inst, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tspatialinstarr_set_stbox(IntPtr instants, int count, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc, int interp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tspatialseqarr_set_stbox(IntPtr sequences, int count, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tspatialseq_expand_stbox(IntPtr seq, IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void spatialarr_set_bbox(IntPtr values, int basetype, int count, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool boxop_tspatial_stbox(IntPtr temp, IntPtr box, IntPtr @bool, [MarshalAs(UnmanagedType.U1)] bool invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool boxop_tspatial_tspatial(IntPtr temp1, IntPtr temp2, IntPtr @bool);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool srid_parse(IntPtr str, IntPtr srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool spatial_parse_elem(IntPtr str, int temptype, byte delim, IntPtr temp_srid, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geo_parse(IntPtr str, int basetype, byte delim, IntPtr srid, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_parse_dims(IntPtr str, [MarshalAs(UnmanagedType.U1)] bool geodetic, int srid, string type_str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_parse(IntPtr str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_parse(IntPtr str, int temptype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tspatialinst_parse(IntPtr str, int temptype, [MarshalAs(UnmanagedType.U1)] bool end, IntPtr temp_srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tspatialseq_disc_parse(IntPtr str, int temptype, IntPtr temp_srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tspatialseq_cont_parse(IntPtr str, int temptype, int interp, [MarshalAs(UnmanagedType.U1)] bool end, IntPtr temp_srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tspatialseqset_parse(IntPtr str, int temptype, int interp, IntPtr temp_srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tspatial_parse(IntPtr str, int temptype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool h3_are_neighbor_cells_meos(IntPtr origin, IntPtr destination);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_cells_to_directed_edge_meos(IntPtr origin, IntPtr destination);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool h3_is_valid_directed_edge_meos(IntPtr edge);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_get_directed_edge_origin_meos(IntPtr edge);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_get_directed_edge_destination_meos(IntPtr edge);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_cell_to_parent_meos(IntPtr origin, int resolution);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_cell_to_center_child_meos(IntPtr origin, int resolution);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_cell_to_child_pos_meos(IntPtr child, int parentRes);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_child_pos_to_cell_meos(IntPtr childPos, IntPtr parent, int childRes);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int h3_get_resolution_meos(IntPtr hex);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int h3_get_base_cell_number_meos(IntPtr hex);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool h3_is_valid_cell_meos(IntPtr hex);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool h3_is_res_class_iii_meos(IntPtr hex);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool h3_is_pentagon_meos(IntPtr hex);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_get_num_cells_meos(int resolution);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_grid_distance_meos(IntPtr originIndex, IntPtr h3Index);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_cell_to_vertex_meos(IntPtr cell, int vertexNum);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool h3_is_valid_vertex_meos(IntPtr vertex);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3index_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string h3index_out(IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool h3index_eq(IntPtr a, IntPtr b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool h3index_ne(IntPtr a, IntPtr b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool h3index_lt(IntPtr a, IntPtr b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool h3index_le(IntPtr a, IntPtr b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool h3index_gt(IntPtr a, IntPtr b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool h3index_ge(IntPtr a, IntPtr b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int h3index_cmp(IntPtr a, IntPtr b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int h3index_hash(IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_grid_disk(IntPtr origin, int k);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_grid_ring(IntPtr origin, int k);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_grid_path_cells(IntPtr start, IntPtr end);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_cell_to_children(IntPtr origin, int childRes);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_compact_cells(IntPtr cells);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_uncompact_cells(IntPtr cells, int res);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_origin_to_directed_edges(IntPtr origin);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_cell_to_vertexes(IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_get_icosahedron_faces(IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ensure_valid_th3index_th3index(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_th3index_h3index(IntPtr temp, IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_th3index_tgeogpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum2_h3index_eq(long d1, long d2, int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum2_h3index_ne(long d1, long d2, int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool h3index_set_stbox(IntPtr cell, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void h3indexarr_set_stbox(IntPtr values, int count, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void th3indexinst_set_stbox(IntPtr inst, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void th3indexinstarr_set_stbox(IntPtr instants, int count, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void th3indexseq_expand_stbox(IntPtr seq, IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_gs_point_to_cell(IntPtr point, int resolution);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_cell_to_gs_point(IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_cell_to_gs_boundary(IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cell_boundary_to_gs(IntPtr bnd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double h3_sample_step_deg(int resolution);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_latlng_deg_to_cell(double lat_deg, double lng_deg, int resolution);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_cell_to_parent_next_meos(IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_cell_to_center_child_next_meos(IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_directed_edge_to_gs_boundary(IntPtr edge);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_vertex_to_gs_point(IntPtr vertex);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_cell_to_local_ij_meos(IntPtr origin, IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_local_ij_to_cell_meos(IntPtr origin, IntPtr coord);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3_unit_from_cstring(string unit);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double h3_cell_area_meos(IntPtr cell, IntPtr unit);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double h3_edge_length_meos(IntPtr edge, IntPtr unit);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double h3_gs_great_circle_distance_meos(IntPtr a, IntPtr b, IntPtr unit);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_get_resolution(long d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_get_base_cell_number(long d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_is_valid_cell(long d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_is_res_class_iii(long d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_is_pentagon(long d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_cell_to_parent(long cell_d, long res_d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_cell_to_parent_next(long cell_d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_cell_to_center_child(long cell_d, long res_d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_cell_to_center_child_next(long cell_d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_cell_to_child_pos(long cell_d, long parent_res_d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_child_pos_to_cell(long pos_d, long parent_d, long child_res_d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_are_neighbor_cells(long origin_d, long dest_d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_cells_to_directed_edge(long origin_d, long dest_d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_is_valid_directed_edge(long d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_get_directed_edge_origin(long d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_get_directed_edge_destination(long d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_directed_edge_to_boundary(long d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_cell_to_vertex(long cell_d, long vnum_d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_vertex_to_latlng(long d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_is_valid_vertex(long d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_grid_distance(long origin_d, long dest_d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_cell_to_local_ij(long origin_d, long cell_d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_local_ij_to_cell(long origin_d, long coord_d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_latlng_to_cell(long point_d, long res_d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_cell_to_latlng(long d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_cell_to_boundary(long d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_cell_area(long cell_d, long unit_d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_edge_length(long edge_d, long unit_d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_h3_great_circle_distance(long a_d, long b_d, long unit_d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr json_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string json_out(IntPtr js);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_from_text(IntPtr txt, [MarshalAs(UnmanagedType.U1)] bool unique_keys);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string jsonb_out(IntPtr jb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr json_make(IntPtr keys_vals, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr json_make_two_arg(IntPtr keys, IntPtr values, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_copy(IntPtr jb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_make(IntPtr keys_vals, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_make_two_arg(IntPtr keys, IntPtr values, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool jsonb_to_bool(IntPtr jb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string jsonb_to_cstring(IntPtr jb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int jsonb_to_float4(IntPtr jb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int jsonb_to_float8(IntPtr jb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial short jsonb_to_int16(IntPtr jb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int jsonb_to_int32(IntPtr jb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_to_int64(IntPtr jb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int jsonb_to_numeric(IntPtr jb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_to_text(IntPtr jb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr json_array_element(IntPtr js, int element);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr json_array_element_text(IntPtr js, int element);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr json_array_elements(IntPtr js, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr json_array_elements_text(IntPtr js, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int json_array_length(IntPtr js);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr json_each(IntPtr js, IntPtr values, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr json_each_text(IntPtr js, IntPtr values, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr json_extract_path(IntPtr js, IntPtr path_elems, int path_len);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr json_extract_path_text(IntPtr js, IntPtr path_elems, int path_len);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr json_object_field(IntPtr js, IntPtr key);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr json_object_field_text(IntPtr js, IntPtr key);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr json_object_keys(IntPtr js, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr json_typeof(IntPtr js);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_array_element(IntPtr jb, int element);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_array_element_text(IntPtr jb, int element);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_array_elements(IntPtr jb, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_array_elements_text(IntPtr jb, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int jsonb_array_length(IntPtr jb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool jsonb_contained(IntPtr jb1, IntPtr jb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool jsonb_contains(IntPtr jb1, IntPtr jb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_each(IntPtr jb, IntPtr values, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_each_text(IntPtr jb, IntPtr values, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool jsonb_exists(IntPtr jb, IntPtr key);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool jsonb_exists_array(IntPtr jb, IntPtr keys_elems, int keys_len, [MarshalAs(UnmanagedType.U1)] bool any);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_extract_path(IntPtr jb, IntPtr path_elems, int path_len);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_extract_path_text(IntPtr jb, IntPtr path_elems, int path_len);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int jsonb_hash(IntPtr jb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_hash_extended(IntPtr jb, IntPtr seed);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_object_field(IntPtr jb, IntPtr key);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_object_field_text(IntPtr jb, IntPtr key);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_object_keys(IntPtr jb, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr json_strip_nulls(IntPtr js, [MarshalAs(UnmanagedType.U1)] bool strip_in_arrays);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_concat(IntPtr jb1, IntPtr jb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_delete(IntPtr jb, IntPtr key);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_delete_array(IntPtr jb, IntPtr keys_elems, int keys_len);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_delete_index(IntPtr jb, int idx);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_delete_path(IntPtr jb, IntPtr path_elems, int path_len);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_insert(IntPtr jb, IntPtr path_elems, int path_len, IntPtr newjb, [MarshalAs(UnmanagedType.U1)] bool after);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_pretty(IntPtr jb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_set(IntPtr jb, IntPtr path_elems, int path_len, IntPtr newjb, [MarshalAs(UnmanagedType.U1)] bool create);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_set_lax(IntPtr jb, IntPtr path_elems, int path_len, IntPtr newjb, [MarshalAs(UnmanagedType.U1)] bool create, IntPtr handle_null);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_strip_nulls(IntPtr jb, [MarshalAs(UnmanagedType.U1)] bool strip_in_arrays);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int jsonb_cmp(IntPtr jb1, IntPtr jb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool jsonb_eq(IntPtr jb1, IntPtr jb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool jsonb_ge(IntPtr jb1, IntPtr jb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool jsonb_gt(IntPtr jb1, IntPtr jb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool jsonb_le(IntPtr jb1, IntPtr jb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool jsonb_lt(IntPtr jb1, IntPtr jb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool jsonb_ne(IntPtr jb1, IntPtr jb2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int jsonb_path_exists(IntPtr jb, IntPtr jp, IntPtr vars, [MarshalAs(UnmanagedType.U1)] bool silent, [MarshalAs(UnmanagedType.U1)] bool tz);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool jsonb_path_match(IntPtr jb, IntPtr jp, IntPtr vars, [MarshalAs(UnmanagedType.U1)] bool silent, [MarshalAs(UnmanagedType.U1)] bool tz);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_path_query_all(IntPtr jb, IntPtr jp, IntPtr vars, [MarshalAs(UnmanagedType.U1)] bool silent, [MarshalAs(UnmanagedType.U1)] bool tz, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_path_query_array(IntPtr jb, IntPtr jp, IntPtr vars, [MarshalAs(UnmanagedType.U1)] bool silent, [MarshalAs(UnmanagedType.U1)] bool tz);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_path_query_first(IntPtr jb, IntPtr jp, IntPtr vars, [MarshalAs(UnmanagedType.U1)] bool silent, [MarshalAs(UnmanagedType.U1)] bool tz);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonpath_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonpath_copy(IntPtr jp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string jsonpath_out(IntPtr jp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string jsonbset_out(IntPtr s, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbset_make(IntPtr values, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_to_set(IntPtr jb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbset_end_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbset_start_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool jsonbset_value_n(IntPtr s, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbset_values(IntPtr s, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr concat_jsonbset_jsonb(IntPtr s, IntPtr jb, [MarshalAs(UnmanagedType.U1)] bool invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbset_array_length(IntPtr set);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbset_object_field(IntPtr set, IntPtr key, [MarshalAs(UnmanagedType.U1)] bool astext, IntPtr null_handle);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbset_array_element(IntPtr set, int idx, [MarshalAs(UnmanagedType.U1)] bool astext, IntPtr null_handle);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbset_delete_index(IntPtr set, int idx);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbset_delete(IntPtr set, IntPtr key);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbset_delete_array(IntPtr set, IntPtr keys, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbset_exists(IntPtr set, IntPtr key);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbset_exists_array(IntPtr set, IntPtr keys, int count, [MarshalAs(UnmanagedType.U1)] bool any);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbset_set(IntPtr set, IntPtr keys, int count, IntPtr newjb, [MarshalAs(UnmanagedType.U1)] bool create, IntPtr null_handle, [MarshalAs(UnmanagedType.U1)] bool lax);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbset_to_alphanumset(IntPtr set, string key, int settype, IntPtr null_handle);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbset_to_intset(IntPtr set, string key, IntPtr null_handle);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbset_to_floatset(IntPtr set, string key, IntPtr null_handle);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbset_to_textset_key(IntPtr set, string key, IntPtr null_handle);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbset_strip_nulls(IntPtr set, [MarshalAs(UnmanagedType.U1)] bool strip_in_arrays);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbset_pretty(IntPtr set);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbset_delete_path(IntPtr set, IntPtr path_elems, int path_len);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbset_extract_path(IntPtr set, IntPtr path_elems, int path_len, [MarshalAs(UnmanagedType.U1)] bool astext, IntPtr null_handle);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbset_insert(IntPtr set, IntPtr path_elems, int path_len, IntPtr newjb, [MarshalAs(UnmanagedType.U1)] bool after);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbset_path_exists(IntPtr set, IntPtr jp, IntPtr vars, [MarshalAs(UnmanagedType.U1)] bool silent, [MarshalAs(UnmanagedType.U1)] bool tz);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbset_path_match(IntPtr set, IntPtr jp, IntPtr vars, [MarshalAs(UnmanagedType.U1)] bool silent, [MarshalAs(UnmanagedType.U1)] bool tz);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbset_path_query_array(IntPtr set, IntPtr jp, IntPtr vars, [MarshalAs(UnmanagedType.U1)] bool silent, [MarshalAs(UnmanagedType.U1)] bool tz);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbset_path_query_first(IntPtr set, IntPtr jp, IntPtr vars, [MarshalAs(UnmanagedType.U1)] bool silent, [MarshalAs(UnmanagedType.U1)] bool tz);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_jsonb_set(IntPtr jb, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_set_jsonb(IntPtr s, IntPtr jb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_jsonb_set(IntPtr jb, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_set_jsonb(IntPtr s, IntPtr jb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonb_union_transfn(IntPtr state, IntPtr jb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_jsonb_set(IntPtr jb, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_set_jsonb(IntPtr s, IntPtr jb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_jsonb_set(IntPtr jb, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_set_jsonb(IntPtr s, IntPtr jb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_from_mfjson(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tjsonb_out(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonbinst_from_mfjson(IntPtr mfjson);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonbinst_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonbseq_from_mfjson(IntPtr mfjson);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonbseq_in(string str, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonbseqset_from_mfjson(IntPtr mfjson);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonbseqset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_from_base_temp(IntPtr jsonb, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonbinst_make(IntPtr jsonb, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonbseq_from_base_tstzset(IntPtr jsonb, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonbseq_from_base_tstzspan(IntPtr jsonb, IntPtr sp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonbseqset_from_base_tstzspanset(IntPtr jsonb, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_to_ttext(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_to_tjsonb(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_end_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_start_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tjsonb_value_at_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool strict, IntPtr value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tjsonb_value_n(IntPtr temp, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_values(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr concat_tjsonb_jsonb(IntPtr temp, IntPtr jb, [MarshalAs(UnmanagedType.U1)] bool invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr concat_tjsonb_tjsonb(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr contains_tjsonb_jsonb(IntPtr temp, IntPtr jb, [MarshalAs(UnmanagedType.U1)] bool invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr contains_tjsonb_tjsonb(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr null_handle_type_from_string(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjson_array_element(IntPtr temp, int idx, IntPtr null_handle);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjson_array_length(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjson_extract_path(IntPtr temp, IntPtr path_elems, int path_len, IntPtr null_handle);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjson_object_field(IntPtr temp, IntPtr key, [MarshalAs(UnmanagedType.U1)] bool astext, IntPtr null_handle);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjson_strip_nulls(IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool strip_in_arrays);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_array_element(IntPtr temp, int idx, [MarshalAs(UnmanagedType.U1)] bool astext, IntPtr null_handle);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_array_length(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_delete(IntPtr temp, IntPtr key);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_delete_array(IntPtr temp, IntPtr keys, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_delete_index(IntPtr temp, int idx);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_delete_path(IntPtr temp, IntPtr path_elems, int path_len);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_exists(IntPtr temp, IntPtr key);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_exists_array(IntPtr temp, IntPtr keys, int count, [MarshalAs(UnmanagedType.U1)] bool any);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_extract_path(IntPtr temp, IntPtr path_elems, int path_len, [MarshalAs(UnmanagedType.U1)] bool astext, IntPtr null_handle);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_insert(IntPtr temp, IntPtr keys, int count, IntPtr newjb, [MarshalAs(UnmanagedType.U1)] bool after);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_object_field(IntPtr temp, IntPtr key, [MarshalAs(UnmanagedType.U1)] bool astext, IntPtr null_handle);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_path_exists(IntPtr temp, IntPtr jp, IntPtr vars, [MarshalAs(UnmanagedType.U1)] bool silent, [MarshalAs(UnmanagedType.U1)] bool tz);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_path_match(IntPtr temp, IntPtr jp, IntPtr vars, [MarshalAs(UnmanagedType.U1)] bool silent, [MarshalAs(UnmanagedType.U1)] bool tz);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_path_query_array(IntPtr temp, IntPtr jp, IntPtr vars, [MarshalAs(UnmanagedType.U1)] bool silent, [MarshalAs(UnmanagedType.U1)] bool tz);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_path_query_first(IntPtr temp, IntPtr jp, IntPtr vars, [MarshalAs(UnmanagedType.U1)] bool silent, [MarshalAs(UnmanagedType.U1)] bool tz);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_pretty(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_set(IntPtr temp, IntPtr keys, int count, IntPtr newjb, [MarshalAs(UnmanagedType.U1)] bool create, IntPtr handle_null, [MarshalAs(UnmanagedType.U1)] bool lax);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_strip_nulls(IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool strip_in_arrays);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_to_tbool(IntPtr temp, string key, IntPtr null_handle);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_to_tfloat(IntPtr temp, string key, int interp, IntPtr null_handle);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_to_tint(IntPtr temp, string key, IntPtr null_handle);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_to_ttext_key(IntPtr temp, string key, IntPtr null_handle);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_at_value(IntPtr temp, IntPtr jsb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_minus_value(IntPtr temp, IntPtr jsb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_jsonb_tjsonb(IntPtr jb, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_tjsonb_jsonb(IntPtr temp, IntPtr jb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_tjsonb_tjsonb(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_jsonb_tjsonb(IntPtr jb, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_tjsonb_jsonb(IntPtr temp, IntPtr jb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_tjsonb_tjsonb(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_jsonb_tjsonb(IntPtr jb, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_tjsonb_jsonb(IntPtr temp, IntPtr jb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_tjsonb_tjsonb(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_jsonb_tjsonb(IntPtr jb, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_tjsonb_jsonb(IntPtr temp, IntPtr jb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_tjsonb_tjsonb(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_jsonb_tjsonb(IntPtr jb, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_tjsonb_jsonb(IntPtr temp, IntPtr jb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_jsonb_tjsonb(IntPtr jb, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_tjsonb_jsonb(IntPtr temp, IntPtr jb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr setPath(IntPtr it, IntPtr path_elems, IntPtr path_nulls, int path_len, IntPtr st, int level, IntPtr newval, int op_type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void setPathObject(IntPtr it, IntPtr path_elems, IntPtr path_nulls, int path_len, IntPtr st, int level, IntPtr newval, uint npairs, int op_type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void setPathArray(IntPtr it, IntPtr path_elems, IntPtr path_nulls, int path_len, IntPtr st, int level, IntPtr newval, uint nelems, int op_type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_jsonb_concat(long l, long r);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_jsonb_contained(long l, long r);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_jsonb_contains(long l, long r);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_jsonb_delete(long jb, long key);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_jsonb_delete_array(long jb, long array, long count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_jsonb_delete_index(long jb, long idx);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_json_array_element(long txt, long element);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_jsonb_array_element(long jb, long element);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_json_array_element_text(long txt, long element);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_jsonb_array_element_text(long jb, long element);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_jsonb_exists(long l, long r);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_jsonb_exists_array(long value, long array, long count, long any);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_json_array_length(long txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_jsonb_array_length(long txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_json_object_field(long txt, long key);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_jsonb_object_field(long jb, long key);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_json_object_field_text(long txt, long key);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_jsonb_object_field_text(long jb, long key);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_json_strip_nulls(long txt, long strip_in_arrays);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_jsonb_strip_nulls(long jb, long strip_in_arrays);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_jsonb_pretty(long jb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_json_extract_path(long txt, long path_elems, long path_len);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_jsonb_extract_path(long jb, long path_elems, long path_len);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_json_extract_path_text(long txt, long path_elems, long path_len);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_jsonb_extract_path_text(long jb, long path_elems, long path_len);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_jsonb_set(long jb, long keys, long count, long newjb, long create);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_jsonb_set_lax(long jb, long keys, long count, long newjb, long create, long null_handle);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_jsonb_delete_path(long jb, long keys, long count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_jsonb_insert(long jb, long keys, long count, long newjb, long after);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_jsonb_path_exists(long jb, long jp, long vars, long silent, long tz);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_jsonb_path_match(long jb, long jp, long vars, long silent, long tz);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_jsonb_path_query_array(long jb, long jp, long vars, long silent, long tz);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_jsonb_path_query_first(long jb, long jp, long vars, long silent, long tz);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_jsonb_to_text(long jb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_text_to_jsonb(long txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_jsonb_to_alphanum(long jb, long key, long temptype, long null_handle);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tjsonb_to_talphanum(IntPtr temp, string key, int resbasetype, int interp, IntPtr null_handle);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbfunc_jsonbset(IntPtr s, int func, int intype, int restype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbfunc_jsonbset_jsonb(IntPtr s, IntPtr jb, IntPtr func, [MarshalAs(UnmanagedType.U1)] bool invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr jsonbfunc_jsonbset_text(IntPtr s, IntPtr txt, IntPtr func);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3index_from_wkb(IntPtr wkb, IntPtr size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3index_from_hexwkb(string hexwkb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr h3index_as_wkb(IntPtr cell, IntPtr variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string h3index_as_hexwkb(IntPtr cell, IntPtr variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3indexinst_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3indexseq_in(string str, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3indexseqset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_make(IntPtr value, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3indexinst_make(IntPtr value, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3indexseq_make(IntPtr values, IntPtr times, int count, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3indexseqset_make(IntPtr sequences, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_start_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_end_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool th3index_value_n(IntPtr temp, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_values(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool th3index_value_at_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool strict, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbigint_to_th3index(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_to_tbigint(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_h3index_th3index(IntPtr cell, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_th3index_h3index(IntPtr temp, IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_h3index_th3index(IntPtr cell, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_th3index_h3index(IntPtr temp, IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_h3index_th3index(IntPtr cell, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_th3index_h3index(IntPtr temp, IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_h3index_th3index(IntPtr cell, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_th3index_h3index(IntPtr temp, IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_th3index_th3index(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_th3index_th3index(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_th3index_th3index(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_th3index_th3index(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_h3index_th3index(IntPtr cell, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_th3index_h3index(IntPtr temp, IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_th3index_th3index(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_h3index_th3index(IntPtr cell, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_th3index_h3index(IntPtr temp, IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_th3index_th3index(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_get_resolution(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_get_base_cell_number(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_is_valid_cell(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_is_res_class_iii(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_is_pentagon(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_cell_to_parent(IntPtr temp, int resolution);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_cell_to_parent_next(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_cell_to_center_child(IntPtr temp, int resolution);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_cell_to_center_child_next(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_cell_to_child_pos(IntPtr temp, int parent_res);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_child_pos_to_cell(IntPtr child_pos, IntPtr parent, int child_res);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeogpoint_to_th3index(IntPtr temp, int resolution);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeompoint_to_th3index(IntPtr temp, int resolution);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_to_tgeogpoint(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_to_tgeompoint(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_cell_to_boundary(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_to_h3index_set(IntPtr gs, int resolution);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_h3indexset_th3index(IntPtr cells, IntPtr th3idx);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_are_neighbor_cells(IntPtr origin, IntPtr dest);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_cells_to_directed_edge(IntPtr origin, IntPtr dest);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_is_valid_directed_edge(IntPtr edge);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_get_directed_edge_origin(IntPtr edge);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_get_directed_edge_destination(IntPtr edge);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_directed_edge_to_boundary(IntPtr edge);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_cell_to_vertex(IntPtr temp, int vertex_num);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_vertex_to_latlng(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_is_valid_vertex(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_grid_distance(IntPtr origin, IntPtr dest);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_cell_to_local_ij(IntPtr origin, IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_local_ij_to_cell(IntPtr origin, IntPtr coord);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_cell_area(IntPtr temp, string unit);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr th3index_edge_length(IntPtr temp, string unit);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeogpoint_great_circle_distance(IntPtr a, IntPtr b, string unit);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr proj_get_context();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geos_get_context();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_geo_round(long value, long size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr point_round(IntPtr gs, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void stbox_set([MarshalAs(UnmanagedType.U1)] bool hasx, [MarshalAs(UnmanagedType.U1)] bool hasz, [MarshalAs(UnmanagedType.U1)] bool geodetic, int srid, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, IntPtr s, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void gbox_set_stbox(IntPtr box, int srid, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geo_set_stbox(IntPtr gs, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void geoarr_set_stbox(IntPtr values, int count, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool spatial_set_stbox(long d, int basetype, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void spatialset_set_stbox(IntPtr set, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void stbox_set_box3d(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void stbox_set_gbox(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tstzset_set_stbox(IntPtr s, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tstzspan_set_stbox(IntPtr s, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tstzspanset_set_stbox(IntPtr s, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void stbox_expand(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool inter_stbox_stbox(IntPtr box1, IntPtr box2, IntPtr result);

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
            public static partial void tspatial_set_stbox(IntPtr temp, IntPtr result);

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
            public static partial IntPtr tpoint_linear_inter_geom(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool clip);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_linear_dwithin_geom(IntPtr temp, IntPtr gs, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_linear_distance_geom(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_linear_restrict_geom(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool geom_clip_supported(IntPtr geom);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int spatial_srid(long d, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool spatial_set_srid(long d, int basetype, int srid);

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
            public static partial IntPtr npoint_from_wkb(IntPtr wkb, IntPtr size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr npoint_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string npoint_out(IntPtr np, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nsegment_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string nsegment_out(IntPtr ns, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr npoint_make(IntPtr rid, double pos);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nsegment_make(IntPtr rid, double pos1, double pos2);

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
            public static partial IntPtr nsegment_to_stbox(IntPtr ns);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int npoint_hash(IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr npoint_hash_extended(IntPtr np, IntPtr seed);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double npoint_position(IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr npoint_route(IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nsegment_end_position(IntPtr ns);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nsegment_route(IntPtr ns);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nsegment_start_position(IntPtr ns);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool route_exists(IntPtr rid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr route_geom(IntPtr rid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double route_length(IntPtr rid);

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
            public static partial IntPtr npointset_values(IntPtr s, IntPtr count);

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
            public static partial IntPtr tnpoint_from_mfjson(string mfjson);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tnpoint_out(IntPtr temp, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpointinst_make(IntPtr np, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_from_base_temp(IntPtr np, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpointseq_from_base_tstzset(IntPtr np, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpointseq_from_base_tstzspan(IntPtr np, IntPtr s, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpointseqset_from_base_tstzspanset(IntPtr np, IntPtr ss, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeompoint_to_tnpoint(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_to_tgeompoint(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_cumulative_length(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_end_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tnpoint_length(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_positions(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_route(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_routes(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_speed(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_start_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_trajectory(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tnpoint_value_at_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool strict, IntPtr value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tnpoint_value_n(IntPtr temp, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_values(IntPtr temp, IntPtr count);

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
            public static partial IntPtr tdistance_tnpoint_geo(IntPtr temp, IntPtr gs);

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
            public static partial IntPtr pcpoint_hex_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string pcpoint_hex_out(IntPtr pt, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pcpoint_from_hexwkb(string hexwkb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string pcpoint_as_hexwkb(IntPtr pt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pcpoint_copy(IntPtr pt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint pcpoint_get_pcid(IntPtr pt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int pcpoint_hash(IntPtr pt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pcpoint_hash_extended(IntPtr pt, IntPtr seed);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pcpoint_get_x(IntPtr pt, IntPtr schema, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pcpoint_get_y(IntPtr pt, IntPtr schema, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pcpoint_get_z(IntPtr pt, IntPtr schema, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pcpoint_get_dim(IntPtr pt, IntPtr schema, string name, IntPtr @out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pcpoint_to_tpcbox(IntPtr pt, IntPtr schema);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr meos_pc_schema(uint pcid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_pc_schema_register(uint pcid, IntPtr schema);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_pc_schema_register_xml(uint pcid, IntPtr schema, string xml_text);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string meos_pc_schema_xml(uint pcid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_pc_schema_clear();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int pcpoint_cmp(IntPtr pt1, IntPtr pt2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pcpoint_eq(IntPtr pt1, IntPtr pt2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pcpoint_ne(IntPtr pt1, IntPtr pt2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pcpoint_lt(IntPtr pt1, IntPtr pt2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pcpoint_le(IntPtr pt1, IntPtr pt2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pcpoint_gt(IntPtr pt1, IntPtr pt2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pcpoint_ge(IntPtr pt1, IntPtr pt2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pcpatch_hex_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string pcpatch_hex_out(IntPtr pa, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pcpatch_from_hexwkb(string hexwkb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string pcpatch_as_hexwkb(IntPtr pa);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pcpatch_copy(IntPtr pa);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint pcpatch_get_pcid(IntPtr pa);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint pcpatch_npoints(IntPtr pa);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int pcpatch_hash(IntPtr pa);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pcpatch_hash_extended(IntPtr pa, IntPtr seed);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int pcpatch_cmp(IntPtr pa1, IntPtr pa2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pcpatch_eq(IntPtr pa1, IntPtr pa2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pcpatch_ne(IntPtr pa1, IntPtr pa2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pcpatch_lt(IntPtr pa1, IntPtr pa2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pcpatch_le(IntPtr pa1, IntPtr pa2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pcpatch_gt(IntPtr pa1, IntPtr pa2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pcpatch_ge(IntPtr pa1, IntPtr pa2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pcpointset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string pcpointset_out(IntPtr s, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pcpointset_make(IntPtr values, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pcpoint_to_set(IntPtr pt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pcpointset_start_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pcpointset_end_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pcpointset_value_n(IntPtr s, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pcpointset_values(IntPtr s, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_set_pcpoint(IntPtr s, IntPtr pt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_pcpoint_set(IntPtr pt, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_pcpoint_set(IntPtr pt, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_set_pcpoint(IntPtr s, IntPtr pt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_pcpoint_set(IntPtr pt, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_set_pcpoint(IntPtr s, IntPtr pt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_pcpoint_set(IntPtr pt, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_set_pcpoint(IntPtr s, IntPtr pt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pcpoint_union_transfn(IntPtr state, IntPtr pt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pcpatchset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string pcpatchset_out(IntPtr s, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pcpatchset_make(IntPtr values, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pcpatch_to_set(IntPtr pa);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pcpatchset_start_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pcpatchset_end_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pcpatchset_value_n(IntPtr s, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pcpatchset_values(IntPtr s, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_set_pcpatch(IntPtr s, IntPtr pa);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_pcpatch_set(IntPtr pa, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_pcpatch_set(IntPtr pa, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_set_pcpatch(IntPtr s, IntPtr pa);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_pcpatch_set(IntPtr pa, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_set_pcpatch(IntPtr s, IntPtr pa);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_pcpatch_set(IntPtr pa, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_set_pcpatch(IntPtr s, IntPtr pa);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pcpatch_union_transfn(IntPtr state, IntPtr pa);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpcbox_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tpcbox_out(IntPtr box, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpcbox_make([MarshalAs(UnmanagedType.U1)] bool hasx, [MarshalAs(UnmanagedType.U1)] bool hasz, [MarshalAs(UnmanagedType.U1)] bool hast, [MarshalAs(UnmanagedType.U1)] bool geodetic, int srid, uint pcid, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, IntPtr period);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpcbox_copy(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pcpatch_to_tpcbox(IntPtr pa, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpcbox_hasx(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpcbox_hasz(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpcbox_hast(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpcbox_geodetic(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpcbox_xmin(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpcbox_xmax(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpcbox_ymin(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpcbox_ymax(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpcbox_zmin(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpcbox_zmax(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpcbox_tmin(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpcbox_tmin_inc(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpcbox_tmax(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpcbox_tmax_inc(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tpcbox_srid(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint tpcbox_pcid(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpcbox_to_stbox(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tpcbox_expand(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpcbox_round(IntPtr box, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpcbox_set_srid(IntPtr box, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_tpcbox_tpcbox(IntPtr box1, IntPtr box2, [MarshalAs(UnmanagedType.U1)] bool strict);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool inter_tpcbox_tpcbox(IntPtr box1, IntPtr box2, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_tpcbox_tpcbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_tpcbox_tpcbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_tpcbox_tpcbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overlaps_tpcbox_tpcbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool same_tpcbox_tpcbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent_tpcbox_tpcbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tpcbox_cmp(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpcbox_eq(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpcbox_ne(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpcbox_lt(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpcbox_le(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpcbox_gt(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpcbox_ge(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left_tpcbox_tpcbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overleft_tpcbox_tpcbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right_tpcbox_tpcbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overright_tpcbox_tpcbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool below_tpcbox_tpcbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbelow_tpcbox_tpcbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool above_tpcbox_tpcbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overabove_tpcbox_tpcbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool front_tpcbox_tpcbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overfront_tpcbox_tpcbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool back_tpcbox_tpcbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overback_tpcbox_tpcbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool before_tpcbox_tpcbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overbefore_tpcbox_tpcbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool after_tpcbox_tpcbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overafter_tpcbox_tpcbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_same_pcid_tpcbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpointcloudinst_make(IntPtr pt, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool eintersects_tpcpoint_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tpcpoint_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string pose_as_ewkt(IntPtr pose, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string pose_as_hexwkb(IntPtr pose, IntPtr variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string pose_as_text(IntPtr pose, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_as_wkb(IntPtr pose, IntPtr variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_from_wkb(IntPtr wkb, IntPtr size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_from_hexwkb(string hexwkb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string pose_out(IntPtr pose, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_from_geopose(string json);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string pose_as_geopose(IntPtr pose, int conformance, int precision);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpose_from_geopose(string json);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tpose_as_geopose(IntPtr temp, int conformance, int precision);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_apply_geo(IntPtr pose, IntPtr body);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpose_apply_geo(IntPtr temp, IntPtr body);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_copy(IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_make_2d(double x, double y, double theta, [MarshalAs(UnmanagedType.U1)] bool geodetic, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_make_3d(double x, double y, double z, double W, double X, double Y, double Z, [MarshalAs(UnmanagedType.U1)] bool geodetic, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_make_point2d(IntPtr gs, double theta);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_make_point3d(IntPtr gs, double W, double X, double Y, double Z);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_to_point(IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_to_stbox(IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int pose_hash(IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_hash_extended(IntPtr pose, IntPtr seed);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_orientation(IntPtr pose, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double pose_rotation(IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double pose_yaw(IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double pose_pitch(IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double pose_roll(IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double pose_angular_distance(IntPtr pose1, IntPtr pose2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_normalize(IntPtr pose);

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
            public static partial IntPtr poseset_values(IntPtr s, IntPtr count);

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
            public static partial IntPtr tpose_from_mfjson(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpose_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tposeinst_make(IntPtr pose, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpose_from_base_temp(IntPtr pose, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tposeseq_from_base_tstzset(IntPtr pose, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tposeseq_from_base_tstzspan(IntPtr pose, IntPtr s, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tposeseqset_from_base_tstzspanset(IntPtr pose, IntPtr ss, int interp);

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
            public static partial IntPtr tpose_yaw(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpose_pitch(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpose_roll(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpose_speed(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpose_angular_speed(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpose_start_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpose_trajectory(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpose_value_at_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool strict, IntPtr result);

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
            public static partial IntPtr tdistance_tpose_geo(IntPtr temp, IntPtr gs);

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
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool quadbin_is_valid_index(IntPtr index);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool quadbin_is_valid_cell(IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr quadbin_tile_to_cell(uint x, uint y, uint z);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void quadbin_cell_to_tile(IntPtr cell, IntPtr x, IntPtr y, IntPtr z);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint quadbin_get_resolution(IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr quadbin_cell_to_parent(IntPtr cell, uint parent_resolution);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr quadbin_cell_to_children(IntPtr cell, uint children_resolution, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr quadbin_cell_sibling(IntPtr cell, string direction);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr quadbin_k_ring(IntPtr cell, int k, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr quadbin_point_to_cell(double longitude, double latitude, uint resolution);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void quadbin_cell_to_point(IntPtr cell, IntPtr longitude, IntPtr latitude);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void quadbin_cell_to_bounding_box(IntPtr cell, IntPtr xmin, IntPtr ymin, IntPtr xmax, IntPtr ymax);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double quadbin_cell_area(IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string quadbin_index_to_string(IntPtr index);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr quadbin_string_to_index(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string quadbin_cell_to_quadkey(IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr quadbin_parse(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool quadbin_eq(IntPtr a, IntPtr b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool quadbin_ne(IntPtr a, IntPtr b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool quadbin_lt(IntPtr a, IntPtr b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool quadbin_le(IntPtr a, IntPtr b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool quadbin_gt(IntPtr a, IntPtr b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool quadbin_ge(IntPtr a, IntPtr b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int quadbin_cmp(IntPtr a, IntPtr b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint quadbin_hash(IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr quadbin_grid_disk(IntPtr origin, int k);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr quadbin_cell_to_children_set(IntPtr origin, int children_resolution);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tquadbin_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tquadbininst_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tquadbinseq_in(string str, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tquadbinseqset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tquadbin_make(IntPtr value, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tquadbininst_make(IntPtr value, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tquadbinseq_make(IntPtr values, IntPtr times, int count, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tquadbinseqset_make(IntPtr sequences, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tquadbin_start_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tquadbin_end_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tquadbin_value_n(IntPtr temp, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tquadbin_values(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tquadbin_value_at_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool strict, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbigint_to_tquadbin(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tquadbin_to_tbigint(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_quadbin_tquadbin(IntPtr cell, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_tquadbin_quadbin(IntPtr temp, IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_quadbin_tquadbin(IntPtr cell, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_tquadbin_quadbin(IntPtr temp, IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_quadbin_tquadbin(IntPtr cell, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_tquadbin_quadbin(IntPtr temp, IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_quadbin_tquadbin(IntPtr cell, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_tquadbin_quadbin(IntPtr temp, IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_tquadbin_tquadbin(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_tquadbin_tquadbin(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_tquadbin_tquadbin(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_tquadbin_tquadbin(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_quadbin_tquadbin(IntPtr cell, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_tquadbin_quadbin(IntPtr temp, IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_tquadbin_tquadbin(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_quadbin_tquadbin(IntPtr cell, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_tquadbin_quadbin(IntPtr temp, IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_tquadbin_tquadbin(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tquadbin_cell_to_quadkey(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr raquet_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string raquet_out(IntPtr rq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr raquet_from_wkb(IntPtr wkb, IntPtr size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr raquet_from_hexwkb(string hexwkb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr raquet_as_wkb(IntPtr rq, IntPtr variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string raquet_as_hexwkb(IntPtr rq, IntPtr variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr raquet_make(IntPtr quadbin, IntPtr width, IntPtr height, IntPtr pixtype, double nodata, [MarshalAs(UnmanagedType.U1)] bool has_nodata, IntPtr pixels);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr raquet_copy(IntPtr rq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr raquet_read(string path, IntPtr quadbin);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr raquet_read_bytes(IntPtr data, IntPtr size, IntPtr quadbin);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr raquet_quadbin(IntPtr rq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int raquet_width(IntPtr rq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int raquet_height(IntPtr rq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double raquet_nodata(IntPtr rq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int raquet_cmp(IntPtr rq1, IntPtr rq2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool raquet_eq(IntPtr rq1, IntPtr rq2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr raster_tile_value_quadbin(IntPtr pixels, IntPtr width, IntPtr height, IntPtr quadbin, IntPtr pixtype, double nodata, [MarshalAs(UnmanagedType.U1)] bool has_nodata, IntPtr traj);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr raster_tile_value(IntPtr rq, IntPtr traj);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trajectory_quadbins(IntPtr traj, uint zoom, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string trgeometry_out(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometryinst_make(IntPtr geom, IntPtr pose, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_tpose_to_trgeometry(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_to_tpose(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_to_tpoint(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_to_tgeometry(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_end_instant(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_end_sequence(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_end_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_geom(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_instant_n(IntPtr temp, int n);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_instants(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_points(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_rotation(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_segments(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_sequence_n(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_sequences(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_start_instant(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_start_sequence(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_start_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool trgeometry_value_n(IntPtr temp, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_traversed_area(IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool unary_union);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_centroid(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_convex_hull(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_body_point_trajectory(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_space_boxes(IntPtr temp, double xsize, double ysize, double zsize, IntPtr sorigin, [MarshalAs(UnmanagedType.U1)] bool bitmatrix, [MarshalAs(UnmanagedType.U1)] bool border_inc, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_space_time_boxes(IntPtr temp, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, long torigin, [MarshalAs(UnmanagedType.U1)] bool bitmatrix, [MarshalAs(UnmanagedType.U1)] bool border_inc, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_stboxes(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_split_n_stboxes(IntPtr temp, int box_count, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_split_each_n_stboxes(IntPtr temp, int elem_count, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double trgeometry_hausdorff_distance(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double trgeometry_frechet_distance(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double trgeometry_dyntimewarp_distance(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_frechet_path(IntPtr temp1, IntPtr temp2, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_dyntimewarp_path(IntPtr temp1, IntPtr temp2, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double trgeometry_length(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_cumulative_length(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_speed(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_twcentroid(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_append_tinstant(IntPtr temp, IntPtr inst, int interp, double maxdist, IntPtr maxt, [MarshalAs(UnmanagedType.U1)] bool expand);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_append_tsequence(IntPtr temp, IntPtr seq, [MarshalAs(UnmanagedType.U1)] bool expand);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_delete_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool connect);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_delete_tstzset(IntPtr temp, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool connect);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_delete_tstzspan(IntPtr temp, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool connect);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_delete_tstzspanset(IntPtr temp, IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool connect);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_round(IntPtr temp, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_set_interp(IntPtr temp, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_to_tinstant(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_after_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool strict);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_before_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool strict);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_restrict_values(IntPtr temp, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_restrict_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_restrict_tstzset(IntPtr temp, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_restrict_tstzspan(IntPtr temp, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_restrict_tstzspanset(IntPtr temp, IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_at_geom(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_minus_geom(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_at_stbox(IntPtr temp, IntPtr box, [MarshalAs(UnmanagedType.U1)] bool border_inc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_minus_stbox(IntPtr temp, IntPtr box, [MarshalAs(UnmanagedType.U1)] bool border_inc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdistance_trgeometry_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdistance_trgeometry_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdistance_trgeometry_trgeometry(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_stbox_trgeometry(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_trgeometry_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_trgeometry_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_trgeometry_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_trgeometry_trgeometry(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nai_trgeometry_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nai_trgeometry_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nai_trgeometry_trgeometry(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr shortestline_trgeometry_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr shortestline_trgeometry_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr shortestline_trgeometry_trgeometry(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_geo_trgeometry(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_trgeometry_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_eq_trgeometry_trgeometry(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_geo_trgeometry(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_trgeometry_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int always_ne_trgeometry_trgeometry(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_geo_trgeometry(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_trgeometry_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_eq_trgeometry_trgeometry(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_geo_trgeometry(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_trgeometry_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ever_ne_trgeometry_trgeometry(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_geo_trgeometry(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_trgeometry_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_geo_trgeometry(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_trgeometry_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int econtains_geo_trgeometry(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int acontains_geo_trgeometry(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ecovers_geo_trgeometry(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int acovers_geo_trgeometry(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ecovers_trgeometry_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int acovers_trgeometry_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int edisjoint_trgeometry_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int adisjoint_trgeometry_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int eintersects_trgeometry_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int aintersects_trgeometry_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int etouches_trgeometry_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int atouches_trgeometry_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int edwithin_trgeometry_geo(IntPtr temp, IntPtr gs, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int adwithin_trgeometry_geo(IntPtr temp, IntPtr gs, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int edisjoint_trgeometry_trgeometry(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int adisjoint_trgeometry_trgeometry(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int eintersects_trgeometry_trgeometry(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int aintersects_trgeometry_trgeometry(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int edwithin_trgeometry_trgeometry(IntPtr temp1, IntPtr temp2, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int adwithin_trgeometry_trgeometry(IntPtr temp1, IntPtr temp2, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tnpoint_npoint(IntPtr temp, IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tnpoint_npointset(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tnpoint_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tnpoint_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tnpoint_tnpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tnpointsegm_intersection(long start1, long end1, long start2, long end2, long lower, long upper, IntPtr t1, IntPtr t2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool common_rid_tnpoint_npoint(IntPtr temp, IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool common_rid_tnpoint_npointset(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool common_rid_tnpoint_tnpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool npoint_collinear(IntPtr np1, IntPtr np2, IntPtr np3, double ratio);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr npointsegm_interpolate(IntPtr start, IntPtr end, IntPtr ratio);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr npointsegm_locate(IntPtr start, IntPtr end, IntPtr value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr npointarr_geom(IntPtr points, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nsegmentarr_geom(IntPtr segments, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nsegmentarr_normalize(IntPtr segments, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string npoint_wkt_out(long value, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void npoint_set(IntPtr rid, double pos, IntPtr np);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void nsegment_set(IntPtr rid, double pos1, double pos2, IntPtr ns);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_npoint_round(long npoint, long size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpointinst_tgeompointinst(IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpointseq_tgeompointseq_disc(IntPtr @is);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpointseq_tgeompointseq_cont(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpointseqset_tgeompointseqset(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeompointinst_tnpointinst(IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeompointseq_tnpointseq(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeompointseqset_tnpointseqset(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpointinst_positions(IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpointseq_positions(IntPtr seq, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpointseqset_positions(IntPtr ss, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpointinst_route(IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpointinst_routes(IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpointseq_disc_routes(IntPtr @is);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpointseq_cont_routes(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpointseqset_routes(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpointseq_linear_positions(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_restrict_stbox(IntPtr temp, IntPtr box, [MarshalAs(UnmanagedType.U1)] bool border_inc, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_restrict_npoint(IntPtr temp, IntPtr np, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_restrict_npointset(IntPtr temp, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool npoint_set_stbox(IntPtr np, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void npointarr_set_stbox(IntPtr values, int count, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool nsegment_set_stbox(IntPtr ns, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool npoint_timestamptz_set_stbox(IntPtr np, long t, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool npoint_tstzspan_set_stbox(IntPtr np, IntPtr s, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tnpointinst_set_stbox(IntPtr inst, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tnpointinstarr_set_stbox(IntPtr inst, int count, int interp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tnpointseq_expand_stbox(IntPtr seq, IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_npoint_distance(long np1, long np2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr npoint_parse(IntPtr str, [MarshalAs(UnmanagedType.U1)] bool end);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nsegment_parse(IntPtr str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_rid_tnpoint_bigint(IntPtr temp, IntPtr rid, int invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_rid_tnpoint_bigint(IntPtr temp, IntPtr rid, [MarshalAs(UnmanagedType.U1)] bool invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool same_rid_tnpoint_bigint(IntPtr temp, IntPtr rid, int invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overlaps_rid_tnpoint_bigintset(IntPtr temp, IntPtr s, int invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_rid_tnpoint_bigintset(IntPtr temp, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_rid_tnpoint_bigintset(IntPtr temp, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool same_rid_tnpoint_bigintset(IntPtr temp, IntPtr s, int invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_rid_tnpoint_npoint(IntPtr temp, IntPtr np, int invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_rid_npoint_tnpoint(IntPtr temp, IntPtr np, [MarshalAs(UnmanagedType.U1)] bool invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool same_rid_tnpoint_npoint(IntPtr temp, IntPtr np, int invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overlaps_rid_tnpoint_tnpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contains_rid_tnpoint_tnpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contained_rid_tnpoint_tnpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool same_rid_tnpoint_tnpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_same_rid_tnpointinst(IntPtr inst1, IntPtr inst2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnpoint_restrict_geom(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int meos_pc_schema_get_srid(uint pcid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_same_pcid_pcpatch(IntPtr pa1, IntPtr pa2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_pcpatchset_pcpatch(IntPtr s, IntPtr pa);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pcpatch_parse(IntPtr str, [MarshalAs(UnmanagedType.U1)] bool end);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pcpatch_filter_per_point(IntPtr pa, int pred, IntPtr extra, [MarshalAs(UnmanagedType.U1)] bool keep_when_true);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pcpatch_any_point_matches(IntPtr pa, int pred, IntPtr extra);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pcpoint_in_tpcbox(IntPtr pt, IntPtr extra);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pcpoint_intersects_geometry(IntPtr pt, IntPtr extra);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_same_pcid_pcpoint(IntPtr pt1, IntPtr pt2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_pcpointset_pcpoint(IntPtr s, IntPtr pt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pcpoint_parse(IntPtr str, [MarshalAs(UnmanagedType.U1)] bool end);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr meos_pc_point_serialize(IntPtr pcpt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr meos_pc_point_deserialize(IntPtr serpt, IntPtr schema);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong meos_pc_patch_serialized_size(IntPtr patch);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr meos_pc_patch_serialize(IntPtr patch_in, IntPtr userdata);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr meos_pc_patch_serialize_to_uncompressed(IntPtr patch_in);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr meos_pc_patch_deserialize(IntPtr serpatch, IntPtr schema);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tpointcloudinst_set_tpcbox(IntPtr inst, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tpointcloudinstarr_set_tpcbox(IntPtr instants, int count, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc, int interp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tpointcloudseq_expand_tpcbox(IntPtr seq, IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tpointcloudseqarr_set_tpcbox(IntPtr sequences, int count, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpcbox_extent_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool boxop_tpointcloud_tpcbox(IntPtr temp, IntPtr box, IntPtr func, [MarshalAs(UnmanagedType.U1)] bool inverted);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool boxop_tpointcloud_tpointcloud(IntPtr temp1, IntPtr temp2, IntPtr func);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tpcbox_set_stbox(IntPtr src, IntPtr dst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tpcbox_tpcbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tpointcloud_tpcbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tpointcloud_tpointcloud(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpcbox_parse(IntPtr str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpcbox_index_leaf_consistent(IntPtr key, IntPtr query, int strategy);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpcbox_gist_inner_consistent(IntPtr key, IntPtr query, int strategy);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tpcbox_index_recheck(int strategy);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_pose_geo(IntPtr pose, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_pose_stbox(IntPtr pose, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_pose_pose(IntPtr pose1, IntPtr pose2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_poseset_pose(IntPtr s, IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pose_collinear(IntPtr pose1, IntPtr pose2, IntPtr pose3, double ratio);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr posesegm_interpolate(IntPtr start, IntPtr end, double ratio);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr posesegm_locate(IntPtr start, IntPtr end, IntPtr value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string pose_wkt_out(IntPtr pose, [MarshalAs(UnmanagedType.U1)] bool extended, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pose_parse(IntPtr str, [MarshalAs(UnmanagedType.U1)] bool end);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_pose_point(long pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_pose_geopoint(long pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_pose_rotation(long pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_pose_yaw(long pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_pose_pitch(long pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_pose_roll(long pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_pose_apply_geo(long pose, long body);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_pose_round(long pose, long size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long pose_distance(long pose1, long pose2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pose_set_stbox(IntPtr pose, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void posearr_set_stbox(IntPtr values, int count, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pose_timestamptz_set_stbox(IntPtr pose, long t, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool pose_tstzspan_set_stbox(IntPtr pose, IntPtr p, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tpose_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tpose_pose(IntPtr temp, IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tpose_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tpose_tpose(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tposesegm_intersection_value(long start, long end, long value, long lower, long upper, IntPtr t1, IntPtr t2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tposesegm_intersection(long start1, long end1, long start2, long end2, long lower, long upper, IntPtr t1, IntPtr t2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tposeinst_set_stbox(IntPtr inst, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tposeinstarr_set_stbox(IntPtr instants, int count, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tposeseq_expand_stbox(IntPtr seq, IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpose_restrict_geom(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpose_restrict_stbox(IntPtr temp, IntPtr box, [MarshalAs(UnmanagedType.U1)] bool border_inc, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpose_restrict_elevation(IntPtr temp, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool bool_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string bool_out([MarshalAs(UnmanagedType.U1)] bool b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string float8_out(double num, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int date_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string date_out(int date);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int interval_cmp(IntPtr interv1, IntPtr interv2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr interval_in(string str, int typmod);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string interval_out(IntPtr interv);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long time_in(string str, int typmod);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string time_out(long time);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long timestamp_in(string str, int typmod);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string timestamp_out(long ts);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long timestamptz_in(string str, int typmod);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string timestamptz_out(long tstz);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cstring_to_text(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string text_to_cstring(IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr text_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string text_out(IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int text_cmp(IntPtr txt1, IntPtr txt2, uint collid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr text_copy(IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr text_initcap(IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr text_lower(IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr text_upper(IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr textcat_text_text(IntPtr txt1, IntPtr txt2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ensure_valid_tquadbin_tquadbin(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tquadbin_quadbin(IntPtr temp, IntPtr cell);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tquadbin_tgeompoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum2_quadbin_eq(long d1, long d2, int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum2_quadbin_ne(long d1, long d2, int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool quadbin_set_stbox(IntPtr cell, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void quadbinarr_set_stbox(IntPtr values, int count, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tquadbininst_set_stbox(IntPtr inst, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tquadbininstarr_set_stbox(IntPtr instants, int count, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tquadbinseq_expand_stbox(IntPtr seq, IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int raquet_pixtype_size(IntPtr pixtype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int raquet_pixels_size(IntPtr rq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool raster_quadbin_from_bounds(double origin_x, double origin_y, double pixel_w, double pixel_h, int xsize, int ysize, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_has_geom(short flags);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_trgeo_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_trgeo_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_trgeo_trgeo(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_trgeo_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_geom_p(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string trgeo_wkt_out(IntPtr temp, int maxdd, [MarshalAs(UnmanagedType.U1)] bool extended);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_tposeinst_to_trgeo(IntPtr gs, IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_tposeseq_to_trgeo(IntPtr gs, IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_tposeseqset_to_trgeo(IntPtr gs, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool trgeo_value_at_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.U1)] bool strict, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeometry_restrict_value(IntPtr temp, long value, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeoinst_geom_p(IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong trgeoinst_pose_varsize(IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void trgeoinst_set_pose(IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeoinst_tposeinst(IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeoinst_make1(IntPtr geom, IntPtr pose, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeoseq_to_tinstant(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeoseqset_to_tinstant(IntPtr ts);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_restrict_geom(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_restrict_stbox(IntPtr temp, IntPtr box, [MarshalAs(UnmanagedType.U1)] bool border_inc, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int spatialrel_trgeo_trav_geo(IntPtr temp, IntPtr gs, long param, IntPtr func, int numparam, [MarshalAs(UnmanagedType.U1)] bool invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_contains_geo_trgeo(IntPtr gs, IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_contains_trgeo_geo(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_contains_trgeo_trgeo(IntPtr temp1, IntPtr temp2, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_covers_geo_trgeo(IntPtr gs, IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_covers_trgeo_geo(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_covers_trgeo_trgeo(IntPtr temp1, IntPtr temp2, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_disjoint_geo_trgeo(IntPtr gs, IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_disjoint_trgeo_geo(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_disjoint_trgeo_trgeo(IntPtr temp1, IntPtr temp2, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_intersects_geo_trgeo(IntPtr gs, IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_intersects_trgeo_geo(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_intersects_trgeo_trgeo(IntPtr temp1, IntPtr temp2, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_touches_geo_trgeo(IntPtr gs, IntPtr temp, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_touches_trgeo_geo(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_touches_trgeo_trgeo(IntPtr temp1, IntPtr temp2, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_dwithin_trgeo_geo(IntPtr temp, IntPtr gs, double dist, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ea_dwithin_trgeo_trgeo(IntPtr temp1, IntPtr temp2, double dist, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeoseq_geom_p(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong trgeoseq_pose_varsize(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void trgeoseq_set_pose(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeoseq_tposeseq(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool trgeoseq_make_valid(IntPtr geom, IntPtr instants, int count, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc, [MarshalAs(UnmanagedType.U1)] bool linear);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeoseq_make1_exp(IntPtr geom, IntPtr instants, int count, int maxcount, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc, int interp, [MarshalAs(UnmanagedType.U1)] bool normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeoseq_make1(IntPtr geom, IntPtr instants, int count, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc, int interp, [MarshalAs(UnmanagedType.U1)] bool normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeoseq_make_exp(IntPtr geom, IntPtr instants, int count, int maxcount, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc, int interp, [MarshalAs(UnmanagedType.U1)] bool normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeoseq_make(IntPtr geom, IntPtr instants, int count, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc, int interp, [MarshalAs(UnmanagedType.U1)] bool normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeoseq_make_free_exp(IntPtr geom, IntPtr instants, int count, int maxcount, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc, int interp, [MarshalAs(UnmanagedType.U1)] bool normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeoseq_make_free(IntPtr geom, IntPtr instants, int count, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc, int interp, [MarshalAs(UnmanagedType.U1)] bool normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeoinst_to_tsequence(IntPtr inst, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeoseqset_geom_p(IntPtr ts);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeoseqset_tposeseqset(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeoseqset_make1_exp(IntPtr geom, IntPtr sequences, int count, int maxcount, [MarshalAs(UnmanagedType.U1)] bool normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeoseqset_make_exp(IntPtr geom, IntPtr sequences, int count, int maxcount, [MarshalAs(UnmanagedType.U1)] bool normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeoseqset_make(IntPtr geom, IntPtr sequences, int count, [MarshalAs(UnmanagedType.U1)] bool normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeoseqset_make_free(IntPtr geom, IntPtr sequences, int count, [MarshalAs(UnmanagedType.U1)] bool normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeoseqset_make_gaps(IntPtr geom, IntPtr instants, int count, int interp, IntPtr maxt, double maxdist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeoseqset_to_tsequence(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_to_tsequence(IntPtr temp, string interp_str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_to_tsequenceset(IntPtr temp, string interp_str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void trgeoinst_set_stbox(IntPtr geom, IntPtr inst, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void trgeoinstarr_static_stbox(IntPtr geom, IntPtr instants, int count, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void trgeoinstarr_rotating_stbox(IntPtr geom, IntPtr instants, int count, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void trgeoinstarr_compute_bbox(IntPtr geom, IntPtr instants, int count, int interp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_span_isof_type(IntPtr s, int spantype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_span_isof_basetype(IntPtr s, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_same_span_type(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void span_deserialize(IntPtr s, IntPtr lower, IntPtr upper);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int span_bound_cmp(IntPtr b1, IntPtr b2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int span_bound_qsort_cmp(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int span_lower_cmp(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int span_upper_cmp(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long span_decr_bound(long upper, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long span_incr_bound(long upper, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanarr_normalize(IntPtr spans, int count, [MarshalAs(UnmanagedType.U1)] bool sort, IntPtr newcount);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void span_bounds_shift_scale_value(long shift, long width, int type, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth, IntPtr lower, IntPtr upper);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void span_bounds_shift_scale_time(IntPtr shift, IntPtr duration, IntPtr lower, IntPtr upper);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void floatspan_floor_ceil_iter(IntPtr s, int func);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void numspan_delta_scale_iter(IntPtr s, long origin, long delta, [MarshalAs(UnmanagedType.U1)] bool hasdelta, double scale);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tstzspan_delta_scale_iter(IntPtr s, long origin, long delta, double scale);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void numspan_shift_scale_iter(IntPtr s, long shift, long width, [MarshalAs(UnmanagedType.U1)] bool hasshift, [MarshalAs(UnmanagedType.U1)] bool haswidth, IntPtr delta, IntPtr scale);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tstzspan_shift_scale1(IntPtr s, IntPtr shift, IntPtr duration, IntPtr delta, IntPtr scale);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int mi_span_value(IntPtr s, long value, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double dist_double_value_value(long l, long r, int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int trgeo_geom_clip_polygon(IntPtr a1, IntPtr b1, IntPtr a2, IntPtr b2, IntPtr pa, IntPtr intervals_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int trgeo_geom_clip_lwpoly(IntPtr a1, IntPtr b1, IntPtr a2, IntPtr b2, IntPtr poly, IntPtr intervals_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int trgeo_geom_clip_box(IntPtr a1, IntPtr b1, IntPtr a2, IntPtr b2, double xmin, double ymin, double xmax, double ymax, IntPtr intervals_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int trgeo_geom_clip_polygon_posed(IntPtr p_a_local, IntPtr p_b_local, IntPtr pose1, IntPtr pose2, IntPtr pa, IntPtr intervals_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int trgeo_geom_clip_lwpoly_posed(IntPtr p_a_local, IntPtr p_b_local, IntPtr pose1, IntPtr pose2, IntPtr poly, IntPtr intervals_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int trgeo_geom_clip_box_posed(IntPtr p_a_local, IntPtr p_b_local, IntPtr pose1, IntPtr pose2, double xmin, double ymin, double xmax, double ymax, IntPtr intervals_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int trgeo_geom_clip_lwgeom(IntPtr a1, IntPtr b1, IntPtr a2, IntPtr b2, IntPtr geom, IntPtr intervals_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int trgeo_geom_clip_lwgeom_posed(IntPtr p_a_local, IntPtr p_b_local, IntPtr pose1, IntPtr pose2, IntPtr geom, IntPtr intervals_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr trgeo_parse(IntPtr str, int temptype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_same_geom(IntPtr gs1, IntPtr gs2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void lwgeom_apply_pose(IntPtr pose, IntPtr geom);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geom_apply_pose(IntPtr gs, IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double geom_radius(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int v_clip_tpoly_point(IntPtr poly, IntPtr point, IntPtr pose, IntPtr poly_feature, IntPtr dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int v_clip_tpoly_tpoly(IntPtr poly1, IntPtr poly2, IntPtr pose1, IntPtr pose2, IntPtr poly1_feature, IntPtr poly2_feature, IntPtr dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void apply_pose_point4d(IntPtr p, IntPtr pose);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfunc_tinstant(IntPtr inst, IntPtr lfinfo);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfunc_tsequence(IntPtr seq, IntPtr lfinfo);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfunc_tsequenceset(IntPtr ss, IntPtr lfinfo);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfunc_temporal(IntPtr temp, IntPtr lfinfo);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfunc_tinstant_base(IntPtr inst, long value, IntPtr lfinfo);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfunc_tsequence_base(IntPtr seq, long value, IntPtr lfinfo);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfunc_tsequenceset_base(IntPtr ss, long value, IntPtr lfinfo);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfunc_temporal_base(IntPtr temp, long value, IntPtr lfinfo);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfunc_tinstant_tinstant(IntPtr inst1, IntPtr inst2, IntPtr lfinfo);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfunc_tdiscseq_tdiscseq(IntPtr seq1, IntPtr seq2, IntPtr lfinfo);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfunc_tcontseq_tcontseq(IntPtr seq1, IntPtr seq2, IntPtr lfinfo);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfunc_tsequenceset_tsequenceset(IntPtr ss1, IntPtr ss2, IntPtr lfinfo);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfunc_temporal_temporal(IntPtr temp1, IntPtr temp2, IntPtr lfinfo);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int eafunc_temporal_base(IntPtr temp, long value, IntPtr lfinfo);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int eafunc_temporal_temporal(IntPtr temp1, IntPtr temp2, IntPtr lfinfo);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr lfunc_set(IntPtr set, IntPtr lfinfo);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string set_out_fn(IntPtr s, int maxdd, IntPtr value_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_set_isof_type(IntPtr s, int settype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_set_set(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool set_find_value(IntPtr s, long arg1, IntPtr loc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_unnest_state_make(IntPtr set);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void set_unnest_state_next(IntPtr state);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_same_skiplist_subtype(IntPtr state, IntPtr subtype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void skiplist_set_extra(IntPtr state, IntPtr data, IntPtr size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr skiplist_headval(IntPtr list);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int common_entry_cmp(IntPtr i1, IntPtr i2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool span_index_leaf_consistent(IntPtr key, IntPtr query, int strategy);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool span_gist_inner_consistent(IntPtr key, IntPtr query, int strategy);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool span_index_recheck(int strategy);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int span_lower_qsort_cmp(IntPtr a, IntPtr b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int span_upper_qsort_cmp(IntPtr a, IntPtr b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr getQuadrant2D(IntPtr centroid, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overlap2D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contain2D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left2D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overLeft2D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right2D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overRight2D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool adjacent2D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_span_nodespan(IntPtr query, IntPtr nodebox);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool span_spgist_get_span(long value, int type, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void spannode_init(IntPtr nodebox, int spantype, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spannode_copy(IntPtr orig);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void spannode_quadtree_next(IntPtr nodebox, IntPtr centroid, IntPtr quadrant, IntPtr next_nodespan);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void spannode_kdtree_next(IntPtr nodebox, IntPtr centroid, IntPtr node, int level, IntPtr next_nodespan);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_spanset_isof_type(IntPtr ss, int spansettype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_same_spanset_type(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_same_spanset_span_type(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_spanset_span(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_spanset_spanset(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool spanset_find_value(IntPtr ss, long v, IntPtr loc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_and(long l, long r);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_or(long l, long r);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr boolop_tbool_bool(IntPtr temp, long b, IntPtr func, [MarshalAs(UnmanagedType.U1)] bool invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr boolop_tbool_tbool(IntPtr temp1, IntPtr temp2, IntPtr func);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_same_dimensionality_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_tbox(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr span_tbox(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_tstzspan(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_intspan(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_floatspan(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tbox_index_leaf_consistent(IntPtr key, IntPtr query, int strategy);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tbox_gist_inner_consistent(IntPtr key, IntPtr query, int strategy);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tbox_index_recheck(int strategy);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tboxnode_init(IntPtr centroid, IntPtr nodebox);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tboxnode_copy(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr getQuadrant4D(IntPtr centroid, IntPtr inBox);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tboxnode_quadtree_next(IntPtr nodebox, IntPtr centroid, IntPtr quadrant, IntPtr next_nodebox);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tboxnode_kdtree_next(IntPtr nodebox, IntPtr centroid, IntPtr node, int level, IntPtr next_nodebox);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overlap4D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool contain4D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool left4D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overLeft4D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool right4D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overRight4D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool before4D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overBefore4D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool after4D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool overAfter4D(IntPtr nodebox, IntPtr query);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_tbox_nodebox(IntPtr query, IntPtr nodebox);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tnumber_spgist_get_tbox(long value, int type, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tbox_xmin_cmp(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tbox_xmax_cmp(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tbox_tmin_cmp(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tbox_tmax_cmp(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tbox_level_cmp(IntPtr centroid, IntPtr query, int level);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tcellindex_type(int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr dggs_cellops(int temptype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcellindex_get_resolution(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcellindex_is_valid_cell(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcellindex_cell_to_parent(IntPtr temp, int resolution);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcellindex_cell_to_point(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcellindex_cell_to_boundary(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcellindex_cell_area(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_min_int32(long l, long r);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_max_int32(long l, long r);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_min_int64(long l, long r);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_max_int64(long l, long r);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_min_float8(long l, long r);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_max_float8(long l, long r);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_sum_int32(long l, long r);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_sum_int64(long l, long r);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_sum_float8(long l, long r);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_min_text(long l, long r);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_max_text(long l, long r);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_sum_double2(long l, long r);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_sum_double3(long l, long r);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_sum_double4(long l, long r);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int temporal_skiplist_common(IntPtr list, IntPtr values, int count, IntPtr lower, IntPtr upper, IntPtr update);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_skiplist_merge(IntPtr spliced, int spliced_count, IntPtr values, int count, IntPtr func, [MarshalAs(UnmanagedType.U1)] bool crossings, IntPtr newcount, IntPtr tofree, IntPtr nfree);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_tagg(IntPtr instants1, int count1, IntPtr instants2, int count2, IntPtr func, IntPtr newcount, IntPtr tofree, IntPtr nfree);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_tagg(IntPtr sequences1, int count1, IntPtr sequences2, int count2, IntPtr func, [MarshalAs(UnmanagedType.U1)] bool crossings, IntPtr newcount);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcontseq_tagg_transfn(IntPtr state, IntPtr seq, IntPtr func, [MarshalAs(UnmanagedType.U1)] bool interpoint);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_tagg_combinefn(IntPtr state1, IntPtr state2, IntPtr func, [MarshalAs(UnmanagedType.U1)] bool crossings);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_tagg_transfn(IntPtr state, IntPtr inst, IntPtr func);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_tavg_finalfn(IntPtr instants, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_tavg_finalfn(IntPtr sequences, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumberinst_transform_tavg(IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_transform_tcount(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_transform_tagg(IntPtr temp, IntPtr count, IntPtr func);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_tagg_transfn(IntPtr state, IntPtr ss, IntPtr func, [MarshalAs(UnmanagedType.U1)] bool crossings);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdiscseq_tagg_transfn(IntPtr state, IntPtr seq, IntPtr func);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_tagg_transfn(IntPtr state, IntPtr temp, IntPtr arg2, [MarshalAs(UnmanagedType.U1)] bool crossings);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_tagg_transform_transfn(IntPtr state, IntPtr temp, IntPtr func, [MarshalAs(UnmanagedType.U1)] bool crossings, IntPtr transform);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double temporal_similarity(IntPtr temp1, IntPtr temp2, IntPtr simfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_similarity_path(IntPtr temp1, IntPtr temp2, IntPtr count, IntPtr simfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong temporal_bbox_size(int tempype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tinstarr_set_bbox(IntPtr instants, int count, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc, int interp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tsequence_compute_bbox(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tseqarr_compute_bbox(IntPtr sequences, int count, IntPtr bbox);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tsequenceset_compute_bbox(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool boxop_temporal_tstzspan(IntPtr temp, IntPtr s, IntPtr func, [MarshalAs(UnmanagedType.U1)] bool invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool boxop_temporal_temporal(IntPtr temp1, IntPtr temp2, IntPtr func);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool boxop_tnumber_numspan(IntPtr temp, IntPtr span, IntPtr func, [MarshalAs(UnmanagedType.U1)] bool invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool boxop_tnumber_tbox(IntPtr temp, IntPtr box, IntPtr func, [MarshalAs(UnmanagedType.U1)] bool invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool boxop_tnumber_tnumber(IntPtr temp1, IntPtr temp2, IntPtr func);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int eacomp_base_temporal(long value, IntPtr temp, IntPtr func, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int eacomp_temporal_base(IntPtr temp, long value, IntPtr func, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int eacomp_temporal_temporal(IntPtr temp1, IntPtr temp2, IntPtr func, [MarshalAs(UnmanagedType.U1)] bool ever);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcomp_base_temporal(long value, IntPtr temp, IntPtr func);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcomp_temporal_base(IntPtr temp, long value, IntPtr func);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcomp_temporal_temporal(IntPtr temp1, IntPtr temp2, IntPtr func);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdiscseq_at_timestamptz(IntPtr seq, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdiscseq_restrict_value(IntPtr seq, long value, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdiscseq_restrict_values(IntPtr seq, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdiscseq_minus_timestamptz(IntPtr seq, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdiscseq_restrict_tstzset(IntPtr seq, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdiscseq_restrict_tstzspanset(IntPtr seq, IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tcontseq_restrict_value_iter(IntPtr seq, long value, [MarshalAs(UnmanagedType.U1)] bool atfunc, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcontseq_delete_timestamptz(IntPtr seq, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcontseq_delete_tstzset(IntPtr seq, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcontseq_delete_tstzspanset(IntPtr seq, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcontseq_at_tstzset(IntPtr seq, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcontseq_minus_timestamptz(IntPtr seq, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcontseq_minus_tstzset(IntPtr seq, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcontseq_minus_tstzspan(IntPtr seq, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcontseq_restrict_value(IntPtr seq, long value, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcontseq_restrict_values(IntPtr seq, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tsequence_at_values_iter(IntPtr seq, IntPtr set, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tnumberseq_cont_restrict_span_iter(IntPtr seq, IntPtr span, [MarshalAs(UnmanagedType.U1)] bool atfunc, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tnumberseq_cont_restrict_spanset_iter(IntPtr seq, IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool atfunc, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsegment_at_timestamptz(IntPtr inst1, IntPtr inst2, int interp, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tcontseq_minus_timestamp_iter(IntPtr seq, long t, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tcontseq_minus_tstzset_iter(IntPtr seq, IntPtr s, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tcontseq_at_tstzspanset1(IntPtr seq, IntPtr ss, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tcontseq_minus_tstzspanset_iter(IntPtr seq, IntPtr ss, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcontseq_at_tstzspan(IntPtr seq, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcontseq_at_timestamptz(IntPtr seq, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcontseq_restrict_tstzspanset(IntPtr seq, IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tdiscseq_value_at_timestamptz(IntPtr seq, long t, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumberseq_disc_restrict_span(IntPtr seq, IntPtr span, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumberseq_disc_restrict_spanset(IntPtr seq, IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumberseq_cont_restrict_span(IntPtr seq, IntPtr span, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumberseq_cont_restrict_spanset(IntPtr seq, IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tnumberseq_cont_twavg(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int span_num_bins(IntPtr s, long size, long origin, IntPtr start_bin, IntPtr end_bin);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_time_bin_init(IntPtr temp, IntPtr duration, long torigin, IntPtr nbins);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_tile_state_make(IntPtr temp, IntPtr box, long vsize, IntPtr duration, long xorigin, long torigin);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tbox_tile_state_next(IntPtr state);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tbox_tile_state_set(long value, long t, long vsize, long tunits, int basetype, int spantype, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long interval_units(IntPtr interval);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long timestamptz_bin_start(long timestamp, long tunits, long torigin);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_bin(long value, long size, long offset, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_value_time_tile_init(IntPtr temp, long vsize, IntPtr duration, long vorigin, long torigin, IntPtr ntiles);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tbox_tile_state_get(IntPtr state, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_transform_wcount(IntPtr temp, IntPtr interval, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_transform_wavg(IntPtr temp, IntPtr interval, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_wagg_transfn(IntPtr state, IntPtr temp, IntPtr interval, IntPtr func, [MarshalAs(UnmanagedType.U1)] bool min, [MarshalAs(UnmanagedType.U1)] bool crossings);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_wagg_transform_transfn(IntPtr state, IntPtr temp, IntPtr interval, IntPtr func, IntPtr transform);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tinstant_set(IntPtr inst, long value, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tnumberinst_double(IntPtr inst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tinstant_to_string(IntPtr inst, int maxdd, IntPtr value_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tinstant_restrict_values_test(IntPtr inst, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tnumberinst_restrict_span_test(IntPtr inst, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tnumberinst_restrict_spanset_test(IntPtr inst, IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tinstant_restrict_tstzset_test(IntPtr inst, IntPtr s, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tinstant_restrict_tstzspanset_test(IntPtr inst, IntPtr ss, [MarshalAs(UnmanagedType.U1)] bool atfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool intersection_tinstant_tinstant(IntPtr inst1, IntPtr inst2, IntPtr inter1, IntPtr inter2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void _mulmat(IntPtr a, IntPtr b, IntPtr c, int arows, int acols, int bcols);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void _mulvec(IntPtr a, IntPtr x, IntPtr y, int m, int n);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void _transpose(IntPtr a, IntPtr at, int m, int n);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void _addmat(IntPtr a, IntPtr b, IntPtr c, int m, int n);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void _negate(IntPtr a, int m, int n);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void _addeye(IntPtr a, int n);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int _choldc1(IntPtr a, IntPtr p, int n);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int _choldcsl(IntPtr A, IntPtr a, IntPtr p, int n);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int _cholsl(IntPtr A, IntPtr a, IntPtr p, int n);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void _addvec(IntPtr a, IntPtr b, IntPtr c, int n);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void _sub(IntPtr a, IntPtr b, IntPtr c, int n);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int invert(IntPtr a, IntPtr ainv);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void ekf_initialize(IntPtr ekf, float pdiag);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void ekf_predict(IntPtr ekf, float fx, float F, float Q);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void ekf_update_step3(IntPtr ekf, float GH);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int ekf_update(IntPtr ekf, float z, float hx, float H, float R);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tfloat_arithop_turnpt(long start1, long end1, long start2, long end2, long param, long lower, long upper, IntPtr t1, IntPtr t2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr arithop_tnumber_number(IntPtr temp, long value, IntPtr oper, IntPtr func, [MarshalAs(UnmanagedType.U1)] bool invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr arithop_tnumber_tnumber(IntPtr temp1, IntPtr temp2, IntPtr oper, IntPtr func, IntPtr tpfunc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool float_collinear(double x1, double x2, double x3, double ratio);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double floatsegm_interpolate(double value1, double value2, IntPtr value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatsegm_locate(double value1, double value2, double value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tnumbersegm_intersection(long start1, long end1, long start2, long end2, int basetype, long lower, long upper, IntPtr t1, IntPtr t2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tsequence_norm_test(long value1, long value2, long value3, int basetype, int interp, long t1, long t2, long t3);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tsequence_join_test(IntPtr seq1, IntPtr seq2, IntPtr removelast, IntPtr removefirst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_join(IntPtr seq1, IntPtr seq2, [MarshalAs(UnmanagedType.U1)] bool removelast, [MarshalAs(UnmanagedType.U1)] bool removefirst);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstarr_normalize(IntPtr instants, int interp, int count, IntPtr newcount);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tcontseq_find_timestamptz(IntPtr seq, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tdiscseq_find_timestamptz(IntPtr seq, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tseqarr2_to_tseqarr(IntPtr sequences, IntPtr countseqs, int count, int totalseqs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tinstarr_common(IntPtr instants, int count, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_make_exp1(IntPtr instants, int count, int maxcount, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc, int interp, [MarshalAs(UnmanagedType.U1)] bool normalize, IntPtr bbox);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool synchronize_tsequence_tsequence(IntPtr seq1, IntPtr seq2, IntPtr sync1, IntPtr sync2, [MarshalAs(UnmanagedType.U1)] bool interpoint);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tfloatsegm_intersection_value(long start, long end, long value, long lower, long upper, IntPtr t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tsegment_intersection_value(long start, long end, long value, int temptype, long lower, long upper, IntPtr t1, IntPtr t2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tsegment_intersection(long start1, long end1, long start2, long end2, int temptype, long lower, long upper, IntPtr t1, IntPtr t2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long tsegment_value_at_timestamptz(long start, long end, int temptype, long lower, long upper, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool intersection_tdiscseq_tdiscseq(IntPtr seq1, IntPtr seq2, IntPtr inter1, IntPtr inter2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool intersection_tcontseq_tdiscseq(IntPtr seq1, IntPtr seq2, IntPtr inter1, IntPtr inter2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool intersection_tdiscseq_tcontseq(IntPtr @is, IntPtr seq2, IntPtr inter1, IntPtr inter2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool intersection_tsequence_tinstant(IntPtr seq, IntPtr inst, IntPtr inter1, IntPtr inter2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool intersection_tinstant_tsequence(IntPtr inst, IntPtr seq, IntPtr inter1, IntPtr inter2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tsequence_to_string(IntPtr seq, int maxdd, [MarshalAs(UnmanagedType.U1)] bool component, IntPtr value_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_increasing_timestamps(IntPtr inst1, IntPtr inst2, [MarshalAs(UnmanagedType.U1)] bool strict);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void bbox_expand(IntPtr box1, IntPtr box2, int temptype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tinstarr(IntPtr instants, int count, [MarshalAs(UnmanagedType.U1)] bool merge, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tsequence_make_valid(IntPtr instants, int count, [MarshalAs(UnmanagedType.U1)] bool lower_inc, [MarshalAs(UnmanagedType.U1)] bool upper_inc, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tnumberseq_shift_scale_value_iter(IntPtr seq, long origin, long delta, [MarshalAs(UnmanagedType.U1)] bool hasdelta, double scale);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tsequence_shift_scale_time_iter(IntPtr seq, long delta, double scale);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tstepseq_to_linear_iter(IntPtr seq, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstepseq_to_linear(IntPtr seq);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tsequence_segments_iter(IntPtr seq, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tsequence_timestamps_iter(IntPtr seq, IntPtr times);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool tsequenceset_find_timestamptz(IntPtr ss, long t, IntPtr loc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tseqarr_normalize(IntPtr sequences, int count, IntPtr newcount);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double datum_distance(long value1, long value2, int basetype, short flags);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ensure_valid_tinstarr_gaps(IntPtr instants, int count, [MarshalAs(UnmanagedType.U1)] bool merge, double maxdist, IntPtr maxt, IntPtr nsplits);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_valid_tseqarr(IntPtr sequences, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool synchronize_tsequenceset_tsequence(IntPtr ss, IntPtr seq, IntPtr mode, IntPtr inter1, IntPtr inter2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool synchronize_tsequenceset_tsequenceset(IntPtr ss1, IntPtr ss2, IntPtr mode, IntPtr inter1, IntPtr inter2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool intersection_tsequenceset_tinstant(IntPtr ss, IntPtr inst, IntPtr inter1, IntPtr inter2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool intersection_tinstant_tsequenceset(IntPtr inst, IntPtr ss, IntPtr inter1, IntPtr inter2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool intersection_tsequenceset_tdiscseq(IntPtr ss, IntPtr @is, IntPtr inter1, IntPtr inter2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool intersection_tdiscseq_tsequenceset(IntPtr @is, IntPtr ss, IntPtr inter1, IntPtr inter2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool intersection_tsequence_tsequenceset(IntPtr seq, IntPtr ss, IntPtr mode, IntPtr inter1, IntPtr inter2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tsequenceset_to_string(IntPtr ss, int maxdd, IntPtr value_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_textcat(long l, long r);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_lower(long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_upper(long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_initcap(long value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr textfunc_ttext(IntPtr temp, int func);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr textfunc_ttext_text(IntPtr temp, long value, IntPtr func, [MarshalAs(UnmanagedType.U1)] bool invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr textfunc_ttext_ttext(IntPtr temp1, IntPtr temp2, IntPtr func);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr datum_as_wkb(long value, int type, IntPtr variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string datum_as_hexwkb(long value, int type, IntPtr variant, IntPtr size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long type_from_wkb(IntPtr wkb, IntPtr size, int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long type_from_hexwkb(string hexwkb, IntPtr size, int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_end_input(IntPtr str, string type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void p_whitespace(IntPtr str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool p_delimchar(IntPtr str, byte delim);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool p_obrace(IntPtr str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_obrace(IntPtr str, string type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool p_cbrace(IntPtr str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_cbrace(IntPtr str, string type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool p_obracket(IntPtr str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool p_cbracket(IntPtr str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool p_oparen(IntPtr str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_oparen(IntPtr str, string type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool p_cparen(IntPtr str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool ensure_cparen(IntPtr str, string type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool p_comma(IntPtr str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool basetype_parse(IntPtr str, int basetypid, byte delim, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool double_parse(IntPtr str, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool elem_parse(IntPtr str, int basetype, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_parse(IntPtr str, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool span_parse(IntPtr str, int spantype, [MarshalAs(UnmanagedType.U1)] bool end, IntPtr span);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_parse(IntPtr str, int spantype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_parse(IntPtr str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long timestamp_parse(IntPtr str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tinstant_parse(IntPtr str, int temptype, [MarshalAs(UnmanagedType.U1)] bool end);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdiscseq_parse(IntPtr str, int temptype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcontseq_parse(IntPtr str, int temptype, int interp, [MarshalAs(UnmanagedType.U1)] bool end);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_parse(IntPtr str, int temptype, int interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_parse(IntPtr str, int temptype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_copy(long value, int typid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double datum_double(long d, int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long double_datum(double d, int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bstring2bytea(IntPtr wkb, IntPtr size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool basetype_in(string str, int type, [MarshalAs(UnmanagedType.U1)] bool end, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string basetype_out(long value, int type, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void pfree_array(IntPtr array, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool string_escape(string str, int quotes, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong string_unescape(string str, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string stringarr_to_string(IntPtr strings, int count, string prefix, byte open, byte close, int quotes, [MarshalAs(UnmanagedType.U1)] bool spaces);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void datumarr_sort(IntPtr values, int count, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tstzarr_sort(IntPtr times, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void spanarr_sort(IntPtr spans, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tinstarr_sort(IntPtr instants, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void tseqarr_sort(IntPtr sequences, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int datumarr_remove_duplicates(IntPtr values, int count, int basetype);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tstzarr_remove_duplicates(IntPtr values, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tinstarr_remove_duplicates(IntPtr instants, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_add(long l, long r, int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_sub(long l, long r, int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_mul(long l, long r, int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum_div(long l, long r, int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int datum_cmp(long l, long r, int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool datum_eq(long l, long r, int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool datum_ne(long l, long r, int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool datum_lt(long l, long r, int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool datum_le(long l, long r, int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool datum_gt(long l, long r, int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool datum_ge(long l, long r, int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum2_eq(long l, long r, int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum2_ne(long l, long r, int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum2_lt(long l, long r, int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum2_le(long l, long r, int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum2_gt(long l, long r, int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long datum2_ge(long l, long r, int type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double hypot3d(double x, double y, double z);

        }
    }
}
