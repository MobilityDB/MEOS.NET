using System.CodeDom.Compiler;
using System.Runtime.InteropServices;

using MEOS.NET.Enums;

namespace MEOS.NET.Internal
{
    internal partial class MEOSExposedFunctions
    {
        [GeneratedCode("MEOS.NET.Builder", "0.0.2")]
        private partial class MEOSExternalFunctions
        {
            private const string DllPath = "/home/totojr/Externals/MobilityDB/build/libmeos.so";

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
            public static partial void meos_initialize_error_handler(ErrorHandlingMethod err_handler);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_finalize_timezone();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool meos_set_datestyle(string newval, IntPtr extra);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool meos_set_intervalstyle(string newval, int extra);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string meos_get_datestyle();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string meos_get_intervalstyle();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_initialize(string tz_str, ErrorHandlingMethod err_handler);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial void meos_finalize();

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool bool_in(string in_str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string bool_out([MarshalAs(UnmanagedType.I1)] bool b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr cstring2text(string cstring);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int pg_date_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string pg_date_out(int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pg_date_mi(int d1, int d2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int pg_date_mi_int(int d, int days);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int pg_date_pl_int(int d, int days);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long pg_date_timestamptz(int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int pg_interval_cmp(IntPtr interval1, IntPtr interval2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pg_interval_in(string str, int typmod);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pg_interval_make(int years, int months, int weeks, int days, int hours, int mins, double secs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pg_interval_mul(IntPtr span, double factor);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string pg_interval_out(IntPtr span);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pg_interval_to_char(IntPtr it, IntPtr fmt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pg_interval_pl(IntPtr span1, IntPtr span2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long pg_time_in(string str, int typmod);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string pg_time_out(long time);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long pg_timestamp_in(string str, int typmod);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pg_timestamp_mi(long dt1, long dt2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long pg_timestamp_mi_interval(long timestamp, IntPtr span);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string pg_timestamp_out(long dt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long pg_timestamp_pl_interval(long timestamp, IntPtr span);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pg_timestamp_to_char(long dt, IntPtr fmt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long pg_timestamptz_in(string str, int typmod);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int pg_timestamptz_date(long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string pg_timestamptz_out(long dt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pg_timestamptz_to_char(long dt, IntPtr fmt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int pg_to_date(IntPtr date_txt, IntPtr fmt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long pg_to_timestamptz(IntPtr date_txt, IntPtr fmt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string text2cstring(IntPtr textptr);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string text_out(IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geography_from_hexewkb(string wkt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geography_from_text(string wkt, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geometry_from_hexewkb(string wkt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geometry_from_text(string wkt, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr gserialized_as_ewkb(IntPtr gs, string type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string gserialized_as_ewkt(IntPtr gs, int precision);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string gserialized_as_geojson(IntPtr gs, int option, int precision, string srs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string gserialized_as_hexewkb(IntPtr gs, string type);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string gserialized_as_text(IntPtr gs, int precision);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr gserialized_from_ewkb(IntPtr bytea_wkb, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr gserialized_from_geojson(string geojson);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string gserialized_out(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pgis_geography_in(string input, int geom_typmod);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr pgis_geometry_in(string input, int geom_typmod);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool pgis_gserialized_same(IntPtr gs1, IntPtr gs2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string bigintset_out(IntPtr set);

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
            public static partial IntPtr floatspan_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string floatspan_out(IntPtr s, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspanset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string floatspanset_out(IntPtr ss, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geogset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geomset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string geoset_as_ewkt(IntPtr set, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string geoset_as_text(IntPtr set, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string geoset_out(IntPtr set, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string intset_out(IntPtr set);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intspan_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string intspan_out(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intspanset_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string intspanset_out(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string set_as_hexwkb(IntPtr s, byte variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_as_wkb(IntPtr s, byte variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_from_hexwkb(string hexwkb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_from_wkb(IntPtr wkb, ulong size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string span_as_hexwkb(IntPtr s, byte variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr span_as_wkb(IntPtr s, byte variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr span_from_hexwkb(string hexwkb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr span_from_wkb(IntPtr wkb, ulong size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string spanset_as_hexwkb(IntPtr ss, byte variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_as_wkb(IntPtr ss, byte variant, IntPtr size_out);

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
            public static partial IntPtr bigintspan_make(long lower, long upper, [MarshalAs(UnmanagedType.I1)] bool lower_inc, [MarshalAs(UnmanagedType.I1)] bool upper_inc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr dateset_make(IntPtr values, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr datespan_make(int lower, int upper, [MarshalAs(UnmanagedType.I1)] bool lower_inc, [MarshalAs(UnmanagedType.I1)] bool upper_inc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatset_make(IntPtr values, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspan_make(double lower, double upper, [MarshalAs(UnmanagedType.I1)] bool lower_inc, [MarshalAs(UnmanagedType.I1)] bool upper_inc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geoset_make(IntPtr values, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intset_make(IntPtr values, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intspan_make(int lower, int upper, [MarshalAs(UnmanagedType.I1)] bool lower_inc, [MarshalAs(UnmanagedType.I1)] bool upper_inc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_copy(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr span_copy(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_copy(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_make(IntPtr spans, int count, [MarshalAs(UnmanagedType.I1)] bool normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr textset_make(IntPtr values, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzset_make(IntPtr values, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspan_make(long lower, long upper, [MarshalAs(UnmanagedType.I1)] bool lower_inc, [MarshalAs(UnmanagedType.I1)] bool upper_inc);

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
            public static partial IntPtr date_to_tstzspan(int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr float_to_set(double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr float_to_span(double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr float_to_spanset(double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_to_set(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr int_to_set(int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr int_to_span(int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr int_to_spanset(int i);

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
            public static partial long bigintset_end_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long bigintset_start_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool bigintset_value_n(IntPtr s, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintset_values(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long bigintspan_lower(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long bigintspan_upper(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long bigintspanset_lower(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long bigintspanset_upper(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int dateset_end_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int dateset_start_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool dateset_value_n(IntPtr s, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr dateset_values(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr datespan_duration(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr datespanset_duration(IntPtr ss, [MarshalAs(UnmanagedType.I1)] bool boundspan);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int datespanset_end_date(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int datespanset_num_dates(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int datespanset_start_date(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool datespanset_date_n(IntPtr ss, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr datespanset_dates(IntPtr ss, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double floatset_end_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double floatset_start_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool floatset_value_n(IntPtr s, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatset_values(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double floatspan_lower(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double floatspan_upper(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double floatspanset_lower(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double floatspanset_upper(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geoset_end_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int geoset_srid(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geoset_set_srid(IntPtr s, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geoset_start_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool geoset_value_n(IntPtr s, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geoset_values(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int intset_end_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int intset_start_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool intset_value_n(IntPtr s, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intset_values(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int intspan_lower(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int intspan_upper(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int intspanset_lower(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int intspanset_upper(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint set_hash(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong set_hash_extended(IntPtr s, ulong seed);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int set_num_values(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_to_span(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint span_hash(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong span_hash_extended(IntPtr s, ulong seed);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool span_lower_inc(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool span_upper_inc(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double span_width(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_end_span(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial uint spanset_hash(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial ulong spanset_hash_extended(IntPtr ss, ulong seed);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool spanset_lower_inc(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int spanset_num_spans(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_span(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_span_n(IntPtr ss, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_spans(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_start_span(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool spanset_upper_inc(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double spanset_width(IntPtr ss, [MarshalAs(UnmanagedType.I1)] bool boundspan);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spatialset_to_stbox(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr textset_end_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr textset_start_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool textset_value_n(IntPtr s, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr textset_values(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long tstzset_end_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long tstzset_start_value(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
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
            public static partial IntPtr tstzspanset_duration(IntPtr ss, [MarshalAs(UnmanagedType.I1)] bool boundspan);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long tstzspanset_end_timestamptz(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long tstzspanset_lower(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tstzspanset_num_timestamps(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long tstzspanset_start_timestamptz(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tstzspanset_timestamptz_n(IntPtr ss, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspanset_timestamps(IntPtr ss, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long tstzspanset_upper(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintset_shift_scale(IntPtr s, long shift, long width, [MarshalAs(UnmanagedType.I1)] bool hasshift, [MarshalAs(UnmanagedType.I1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintspan_shift_scale(IntPtr s, long shift, long width, [MarshalAs(UnmanagedType.I1)] bool hasshift, [MarshalAs(UnmanagedType.I1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigintspanset_shift_scale(IntPtr ss, long shift, long width, [MarshalAs(UnmanagedType.I1)] bool hasshift, [MarshalAs(UnmanagedType.I1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr dateset_shift_scale(IntPtr s, int shift, int width, [MarshalAs(UnmanagedType.I1)] bool hasshift, [MarshalAs(UnmanagedType.I1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr dateset_to_tstzset(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr datespan_shift_scale(IntPtr s, int shift, int width, [MarshalAs(UnmanagedType.I1)] bool hasshift, [MarshalAs(UnmanagedType.I1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr datespan_to_tstzspan(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr datespanset_shift_scale(IntPtr ss, int shift, int width, [MarshalAs(UnmanagedType.I1)] bool hasshift, [MarshalAs(UnmanagedType.I1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr datespanset_to_tstzspanset(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatset_round(IntPtr s, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatset_shift_scale(IntPtr s, double shift, double width, [MarshalAs(UnmanagedType.I1)] bool hasshift, [MarshalAs(UnmanagedType.I1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatset_to_intset(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspan_round(IntPtr s, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspan_shift_scale(IntPtr s, double shift, double width, [MarshalAs(UnmanagedType.I1)] bool hasshift, [MarshalAs(UnmanagedType.I1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspan_to_intspan(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspanset_to_intspanset(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspanset_round(IntPtr ss, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspanset_shift_scale(IntPtr ss, double shift, double width, [MarshalAs(UnmanagedType.I1)] bool hasshift, [MarshalAs(UnmanagedType.I1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geoset_round(IntPtr s, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intset_shift_scale(IntPtr s, int shift, int width, [MarshalAs(UnmanagedType.I1)] bool hasshift, [MarshalAs(UnmanagedType.I1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intset_to_floatset(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intspan_shift_scale(IntPtr s, int shift, int width, [MarshalAs(UnmanagedType.I1)] bool hasshift, [MarshalAs(UnmanagedType.I1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intspan_to_floatspan(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intspanset_to_floatspanset(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intspanset_shift_scale(IntPtr ss, int shift, int width, [MarshalAs(UnmanagedType.I1)] bool hasshift, [MarshalAs(UnmanagedType.I1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr textset_lower(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr textset_upper(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long timestamptz_tprecision(long t, IntPtr duration, long torigin);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzset_shift_scale(IntPtr s, IntPtr shift, IntPtr duration);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspan_shift_scale(IntPtr s, IntPtr shift, IntPtr duration);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspan_tprecision(IntPtr s, IntPtr duration, long torigin);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzset_to_dateset(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspan_to_datespan(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspanset_to_datespanset(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspanset_shift_scale(IntPtr ss, IntPtr shift, IntPtr duration);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspanset_tprecision(IntPtr ss, IntPtr duration, long torigin);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_set_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_set_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_set_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_set_geo(IntPtr s, IntPtr gs);

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
            public static partial IntPtr intersection_span_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_span_span(IntPtr s1, IntPtr s2);

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
            public static partial IntPtr minus_geo_set(IntPtr gs, IntPtr s);

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
            public static partial IntPtr minus_set_geo(IntPtr s, IntPtr gs);

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
            public static partial IntPtr minus_timestamptz_span(long t, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_timestamptz_spanset(long t, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr minus_timestamptz_set(long t, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr super_union_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_set_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_set_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_set_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_set_geo(IntPtr s, IntPtr gs);

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
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool adjacent_span_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool adjacent_span_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool adjacent_span_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool adjacent_span_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool adjacent_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool adjacent_span_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool adjacent_spanset_bigint(IntPtr ss, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool adjacent_spanset_date(IntPtr ss, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool adjacent_spanset_float(IntPtr ss, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool adjacent_spanset_int(IntPtr ss, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool adjacent_spanset_timestamptz(IntPtr ss, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool adjacent_spanset_span(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool adjacent_spanset_spanset(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_bigint_set(long i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_bigint_span(long i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_bigint_spanset(long i, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_date_set(int d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_date_span(int d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_date_spanset(int d, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_float_set(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_float_span(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_float_spanset(double d, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_geo_set(IntPtr gs, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_int_set(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_int_span(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_int_spanset(int i, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_set_set(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_span_spanset(IntPtr s, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_spanset_span(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_spanset_spanset(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_text_set(IntPtr txt, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_timestamptz_set(long t, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_timestamptz_span(long t, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_timestamptz_spanset(long t, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_set_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_set_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_set_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_set_geo(IntPtr s, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_set_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_set_set(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_set_text(IntPtr s, IntPtr t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_set_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_span_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_span_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_span_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_span_spanset(IntPtr s, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_span_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_spanset_bigint(IntPtr ss, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_spanset_float(IntPtr ss, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_spanset_int(IntPtr ss, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_spanset_span(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_spanset_spanset(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_spanset_timestamptz(IntPtr ss, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overlaps_set_set(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overlaps_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overlaps_spanset_span(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overlaps_spanset_spanset(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool after_date_set(int d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool after_date_span(int d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool after_date_spanset(int d, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool after_set_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool after_set_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool after_span_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool after_span_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool after_spanset_date(IntPtr ss, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool after_spanset_timestamptz(IntPtr ss, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool after_timestamptz_set(long t, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool after_timestamptz_span(long t, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool after_timestamptz_spanset(long t, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool before_date_set(int d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool before_date_span(int d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool before_date_spanset(int d, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool before_set_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool before_set_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool before_span_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool before_span_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool before_spanset_date(IntPtr ss, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool before_spanset_timestamptz(IntPtr ss, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool before_timestamptz_set(long t, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool before_timestamptz_span(long t, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool before_timestamptz_spanset(long t, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_bigint_set(long i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_bigint_span(long i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_bigint_spanset(long i, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_float_set(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_float_span(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_float_spanset(double d, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_int_set(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_int_span(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_int_spanset(int i, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_set_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_set_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_set_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_set_set(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_set_text(IntPtr s, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_span_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_span_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_span_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_span_spanset(IntPtr s, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_spanset_bigint(IntPtr ss, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_spanset_float(IntPtr ss, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_spanset_int(IntPtr ss, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_spanset_span(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_spanset_spanset(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_text_set(IntPtr txt, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overafter_set_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overafter_set_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overafter_span_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overafter_spanset_timestamptz(IntPtr ss, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overafter_timestamptz_set(long t, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overafter_timestamptz_span(long t, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overafter_timestamptz_spanset(long t, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overbefore_set_date(IntPtr s, int d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overbefore_set_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overbefore_span_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overbefore_spanset_timestamptz(IntPtr ss, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overbefore_timestamptz_set(long t, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overbefore_timestamptz_span(long t, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overbefore_timestamptz_spanset(long t, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_bigint_set(long i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_bigint_span(long i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_bigint_spanset(long i, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_float_set(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_float_span(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_float_spanset(double d, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_int_set(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_int_span(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_int_spanset(int i, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_set_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_set_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_set_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_set_set(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_set_text(IntPtr s, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_span_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_span_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_span_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_span_spanset(IntPtr s, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_spanset_bigint(IntPtr ss, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_spanset_float(IntPtr ss, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_spanset_int(IntPtr ss, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_spanset_span(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_spanset_spanset(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_text_set(IntPtr txt, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_bigint_set(long i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_bigint_span(long i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_bigint_spanset(long i, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_float_set(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_float_span(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_float_spanset(double d, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_int_set(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_int_span(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_int_spanset(int i, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_set_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_set_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_set_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_set_set(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_set_text(IntPtr s, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_span_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_span_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_span_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_span_spanset(IntPtr s, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_spanset_bigint(IntPtr ss, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_spanset_float(IntPtr ss, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_spanset_int(IntPtr ss, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_spanset_span(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_spanset_spanset(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_text_set(IntPtr txt, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_bigint_set(long i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_bigint_span(long i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_bigint_spanset(long i, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_float_set(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_float_span(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_float_spanset(double d, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_int_set(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_int_span(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_int_spanset(int i, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_set_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_set_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_set_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_set_set(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_set_text(IntPtr s, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_span_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_span_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_span_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_span_spanset(IntPtr s, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_spanset_bigint(IntPtr ss, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_spanset_float(IntPtr ss, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_spanset_int(IntPtr ss, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_spanset_span(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_spanset_spanset(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_text_set(IntPtr txt, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_set_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_set_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_set_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_set_set(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_set_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_span_bigint(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_span_float(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_span_int(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_span_span(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_span_timestamptz(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_spanset_bigint(IntPtr ss, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_spanset_float(IntPtr ss, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_spanset_int(IntPtr ss, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_spanset_timestamptz(IntPtr ss, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_spanset_span(IntPtr ss, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double distance_spanset_spanset(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int set_cmp(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool set_eq(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool set_ge(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool set_gt(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool set_le(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool set_lt(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool set_ne(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int span_cmp(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool span_eq(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool span_ge(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool span_gt(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool span_le(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool span_lt(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool span_ne(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int spanset_cmp(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool spanset_eq(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool spanset_ge(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool spanset_gt(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool spanset_le(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool spanset_lt(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool spanset_ne(IntPtr ss1, IntPtr ss2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigint_extent_transfn(IntPtr s, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bigint_union_transfn(IntPtr state, long i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr float_extent_transfn(IntPtr s, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr float_union_transfn(IntPtr state, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr int_extent_transfn(IntPtr s, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr int_union_transfn(IntPtr state, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_extent_transfn(IntPtr span, IntPtr set);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_union_finalfn(IntPtr state);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr set_union_transfn(IntPtr state, IntPtr set);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr span_extent_transfn(IntPtr s1, IntPtr s2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr span_union_transfn(IntPtr state, IntPtr span);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_extent_transfn(IntPtr s, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_union_finalfn(IntPtr state);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr spanset_union_transfn(IntPtr state, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr text_union_transfn(IntPtr state, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr timestamptz_extent_transfn(IntPtr s, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr timestamptz_tcount_transfn(IntPtr state, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr timestamptz_union_transfn(IntPtr state, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzset_tcount_transfn(IntPtr state, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspan_tcount_transfn(IntPtr state, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspanset_tcount_transfn(IntPtr state, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tbox_out(IntPtr box, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_from_wkb(IntPtr wkb, ulong size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_from_hexwkb(string hexwkb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_from_wkb(IntPtr wkb, ulong size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_from_hexwkb(string hexwkb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_as_wkb(IntPtr box, byte variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tbox_as_hexwkb(IntPtr box, byte variant, IntPtr size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_as_wkb(IntPtr box, byte variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string stbox_as_hexwkb(IntPtr box, byte variant, IntPtr size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string stbox_out(IntPtr box, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr float_tstzspan_to_tbox(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr float_timestamptz_to_tbox(double d, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_tstzspan_to_stbox(IntPtr gs, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_timestamptz_to_stbox(IntPtr gs, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr int_tstzspan_to_tbox(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr int_timestamptz_to_tbox(int i, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr numspan_tstzspan_to_tbox(IntPtr span, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr numspan_timestamptz_to_tbox(IntPtr span, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_copy(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_make([MarshalAs(UnmanagedType.I1)] bool hasx, [MarshalAs(UnmanagedType.I1)] bool hasz, [MarshalAs(UnmanagedType.I1)] bool geodetic, int srid, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_copy(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_make(IntPtr s, IntPtr p);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr box3d_to_stbox(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr gbox_to_stbox(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr float_to_tbox(double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_to_stbox(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr int_to_tbox(int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr numset_to_tbox(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr numspan_to_tbox(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr numspanset_to_tbox(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspan_to_stbox(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspan_to_tbox(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspanset_to_stbox(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspanset_to_tbox(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_to_gbox(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_to_box3d(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_to_geo(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_to_tstzspan(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_to_intspan(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_to_floatspan(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_to_tstzspan(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr timestamptz_to_stbox(long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr timestamptz_to_tbox(long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzset_to_stbox(IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzset_to_tbox(IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_to_tbox(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_to_stbox(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool stbox_hast(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool stbox_hasx(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool stbox_hasz(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool stbox_isgeodetic(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int stbox_srid(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool stbox_tmax(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool stbox_tmax_inc(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool stbox_tmin(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool stbox_tmin_inc(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool stbox_xmax(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool stbox_xmin(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool stbox_ymax(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool stbox_ymin(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool stbox_zmax(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool stbox_zmin(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tbox_hast(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tbox_hasx(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tbox_tmax(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tbox_tmax_inc(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tbox_tmin(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tbox_tmin_inc(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tbox_xmax(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tbox_xmax_inc(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tbox_xmin(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tbox_xmin_inc(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tboxfloat_xmax(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tboxfloat_xmin(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tboxint_xmax(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tboxint_xmin(IntPtr box, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_expand_space(IntPtr box, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_expand_time(IntPtr box, IntPtr interval);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_get_space(IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_round(IntPtr box, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_set_srid(IntPtr box, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_shift_scale_time(IntPtr box, IntPtr shift, IntPtr duration);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_expand_time(IntPtr box, IntPtr interval);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_expand_float(IntPtr box, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_expand_int(IntPtr box, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_round(IntPtr box, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_shift_scale_float(IntPtr box, double shift, double width, [MarshalAs(UnmanagedType.I1)] bool hasshift, [MarshalAs(UnmanagedType.I1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_shift_scale_int(IntPtr box, int shift, int width, [MarshalAs(UnmanagedType.I1)] bool hasshift, [MarshalAs(UnmanagedType.I1)] bool haswidth);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbox_shift_scale_time(IntPtr box, IntPtr shift, IntPtr duration);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_tbox_tbox(IntPtr box1, IntPtr box2, [MarshalAs(UnmanagedType.I1)] bool strict);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool inter_tbox_tbox(IntPtr box1, IntPtr box2, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr union_stbox_stbox(IntPtr box1, IntPtr box2, [MarshalAs(UnmanagedType.I1)] bool strict);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool inter_stbox_stbox(IntPtr box1, IntPtr box2, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intersection_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overlaps_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool same_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool adjacent_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overlaps_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool same_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool adjacent_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool before_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overbefore_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool after_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overafter_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool below_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overbelow_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool above_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overabove_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool front_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overfront_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool back_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overback_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool before_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overbefore_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool after_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overafter_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_quad_split(IntPtr box, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tbox_eq(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tbox_ne(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tbox_cmp(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tbox_lt(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tbox_le(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tbox_ge(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tbox_gt(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool stbox_eq(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool stbox_ne(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int stbox_cmp(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool stbox_lt(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool stbox_le(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool stbox_ge(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool stbox_gt(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbool_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tbool_out(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string temporal_as_hexwkb(IntPtr temp, byte variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string temporal_as_mfjson(IntPtr temp, [MarshalAs(UnmanagedType.I1)] bool with_bbox, int flags, int precision, string srs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_as_wkb(IntPtr temp, byte variant, IntPtr size_out);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_from_hexwkb(string hexwkb);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_from_mfjson(string mfjson);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_from_wkb(IntPtr wkb, ulong size);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tfloat_out(IntPtr temp, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeogpoint_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeompoint_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tint_out(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tpoint_as_ewkt(IntPtr temp, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tpoint_as_text(IntPtr temp, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string tpoint_out(IntPtr temp, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_in(string str);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial string ttext_out(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_cp(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbool_from_base_temp([MarshalAs(UnmanagedType.I1)] bool b, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tboolinst_make([MarshalAs(UnmanagedType.I1)] bool b, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tboolseq_from_base_tstzset([MarshalAs(UnmanagedType.I1)] bool b, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tboolseq_from_base_tstzspan([MarshalAs(UnmanagedType.I1)] bool b, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tboolseqset_from_base_tstzspanset([MarshalAs(UnmanagedType.I1)] bool b, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_copy(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_from_base_temp(double d, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloatinst_make(double d, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloatseq_from_base_tstzspan(double d, IntPtr s, InterpolationType interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloatseq_from_base_tstzset(double d, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloatseqset_from_base_tstzspanset(double d, IntPtr ss, InterpolationType interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_from_base_temp(int i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintinst_make(int i, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintseq_from_base_tstzspan(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintseq_from_base_tstzset(int i, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintseqset_from_base_tstzspanset(int i, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_from_base_temp(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpointinst_make(IntPtr gs, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpointseq_from_base_tstzspan(IntPtr gs, IntPtr s, InterpolationType interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpointseq_from_base_tstzset(IntPtr gs, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpointseqset_from_base_tstzspanset(IntPtr gs, IntPtr ss, InterpolationType interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequence_make(IntPtr instants, int count, [MarshalAs(UnmanagedType.I1)] bool lower_inc, [MarshalAs(UnmanagedType.I1)] bool upper_inc, InterpolationType interp, [MarshalAs(UnmanagedType.I1)] bool normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_make(IntPtr sequences, int count, [MarshalAs(UnmanagedType.I1)] bool normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tsequenceset_make_gaps(IntPtr instants, int count, InterpolationType interp, IntPtr maxt, double maxdist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_from_base_temp(IntPtr txt, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttextinst_make(IntPtr txt, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttextseq_from_base_tstzspan(IntPtr txt, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttextseq_from_base_tstzset(IntPtr txt, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttextseqset_from_base_tstzspanset(IntPtr txt, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_to_tstzspan(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_to_tint(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_to_tfloat(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_to_span(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tbool_end_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tbool_start_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbool_values(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_duration(IntPtr temp, [MarshalAs(UnmanagedType.I1)] bool boundspan);

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
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool temporal_timestamptz_n(IntPtr temp, int n, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_timestamps(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tfloat_end_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tfloat_max_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tfloat_min_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tfloat_start_value(IntPtr temp);

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
            public static partial IntPtr tint_values(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_valuespans(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_end_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_start_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_values(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_end_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_max_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_min_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_start_value(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_values(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_scale_time(IntPtr temp, IntPtr duration);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_set_interp(IntPtr temp, InterpolationType interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_shift_scale_time(IntPtr temp, IntPtr shift, IntPtr duration);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_shift_time(IntPtr temp, IntPtr shift);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_to_tinstant(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_to_tsequence(IntPtr temp, InterpolationType interp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_to_tsequenceset(IntPtr temp, InterpolationType interp);

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
            public static partial IntPtr temporal_append_tinstant(IntPtr temp, IntPtr inst, double maxdist, IntPtr maxt, [MarshalAs(UnmanagedType.I1)] bool expand);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_append_tsequence(IntPtr temp, IntPtr seq, [MarshalAs(UnmanagedType.I1)] bool expand);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_delete_tstzspan(IntPtr temp, IntPtr s, [MarshalAs(UnmanagedType.I1)] bool connect);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_delete_tstzspanset(IntPtr temp, IntPtr ss, [MarshalAs(UnmanagedType.I1)] bool connect);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_delete_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.I1)] bool connect);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_delete_tstzset(IntPtr temp, IntPtr s, [MarshalAs(UnmanagedType.I1)] bool connect);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_insert(IntPtr temp1, IntPtr temp2, [MarshalAs(UnmanagedType.I1)] bool connect);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_merge(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_merge_array(IntPtr temparr, int count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_update(IntPtr temp1, IntPtr temp2, [MarshalAs(UnmanagedType.I1)] bool connect);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbool_at_value(IntPtr temp, [MarshalAs(UnmanagedType.I1)] bool b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbool_minus_value(IntPtr temp, [MarshalAs(UnmanagedType.I1)] bool b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tbool_value_at_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.I1)] bool strict, IntPtr value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_at_max(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_at_min(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_at_tstzspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_at_tstzspanset(IntPtr temp, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_at_timestamptz(IntPtr temp, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_at_tstzset(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_at_values(IntPtr temp, IntPtr set);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_minus_max(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_minus_min(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_minus_tstzspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_minus_tstzspanset(IntPtr temp, IntPtr ss);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_minus_timestamptz(IntPtr temp, long t);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_minus_tstzset(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_minus_values(IntPtr temp, IntPtr set);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_at_value(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_minus_value(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tfloat_value_at_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.I1)] bool strict, IntPtr value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_at_value(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_minus_value(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tint_value_at_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.I1)] bool strict, IntPtr value);

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
            public static partial IntPtr tpoint_at_geom_time(IntPtr temp, IntPtr gs, IntPtr zspan, IntPtr period);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_at_stbox(IntPtr temp, IntPtr box, [MarshalAs(UnmanagedType.I1)] bool border_inc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_at_value(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_minus_geom_time(IntPtr temp, IntPtr gs, IntPtr zspan, IntPtr period);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_minus_stbox(IntPtr temp, IntPtr box, [MarshalAs(UnmanagedType.I1)] bool border_inc);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_minus_value(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tpoint_value_at_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.I1)] bool strict, IntPtr value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_at_value(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_minus_value(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool ttext_value_at_timestamptz(IntPtr temp, long t, [MarshalAs(UnmanagedType.I1)] bool strict, IntPtr value);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int temporal_cmp(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool temporal_eq(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool temporal_ge(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool temporal_gt(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool temporal_le(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool temporal_lt(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool temporal_ne(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tbool_always_eq(IntPtr temp, [MarshalAs(UnmanagedType.I1)] bool b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tbool_ever_eq(IntPtr temp, [MarshalAs(UnmanagedType.I1)] bool b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tfloat_always_eq(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tfloat_always_le(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tfloat_always_lt(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tfloat_ever_eq(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tfloat_ever_le(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tfloat_ever_lt(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tint_always_eq(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tint_always_le(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tint_always_lt(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tint_ever_eq(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tint_ever_le(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tint_ever_lt(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tpoint_always_eq(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tpoint_ever_eq(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool ttext_always_eq(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool ttext_always_le(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool ttext_always_lt(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool ttext_ever_eq(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool ttext_ever_le(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool ttext_ever_lt(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_bool_tbool([MarshalAs(UnmanagedType.I1)] bool b, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_float_tfloat(double d, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_int_tint(int i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_point_tpoint(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_tbool_bool(IntPtr temp, [MarshalAs(UnmanagedType.I1)] bool b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_text_ttext(IntPtr txt, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_tfloat_float(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr teq_tpoint_point(IntPtr temp, IntPtr gs);

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
            public static partial IntPtr tne_bool_tbool([MarshalAs(UnmanagedType.I1)] bool b, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_float_tfloat(double d, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_int_tint(int i, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_point_tpoint(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_tbool_bool(IntPtr temp, [MarshalAs(UnmanagedType.I1)] bool b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_text_ttext(IntPtr txt, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_tfloat_float(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_tpoint_point(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_tint_int(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tne_ttext_text(IntPtr temp, IntPtr txt);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool adjacent_numspan_tnumber(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool adjacent_stbox_tpoint(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool adjacent_tbox_tnumber(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool adjacent_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool adjacent_temporal_tstzspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool adjacent_tnumber_numspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool adjacent_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool adjacent_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool adjacent_tpoint_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool adjacent_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool adjacent_tstzspan_temporal(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_numspan_tnumber(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_stbox_tpoint(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_tbox_tnumber(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_temporal_tstzspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_tnumber_numspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_tpoint_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contained_tstzspan_temporal(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_numspan_tnumber(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_stbox_tpoint(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_tbox_tnumber(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_temporal_tstzspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_tnumber_numspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_tpoint_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool contains_tstzspan_temporal(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overlaps_numspan_tnumber(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overlaps_stbox_tpoint(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overlaps_tbox_tnumber(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overlaps_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overlaps_temporal_tstzspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overlaps_tnumber_numspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overlaps_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overlaps_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overlaps_tpoint_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overlaps_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overlaps_tstzspan_temporal(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool same_numspan_tnumber(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool same_stbox_tpoint(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool same_tbox_tnumber(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool same_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool same_temporal_tstzspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool same_tnumber_numspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool same_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool same_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool same_tpoint_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool same_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool same_tstzspan_temporal(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool above_stbox_tpoint(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool above_tpoint_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool above_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool after_stbox_tpoint(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool after_tbox_tnumber(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool after_temporal_tstzspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool after_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool after_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool after_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool after_tpoint_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool after_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool after_tstzspan_temporal(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool back_stbox_tpoint(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool back_tpoint_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool back_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool before_stbox_tpoint(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool before_tbox_tnumber(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool before_temporal_tstzspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool before_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool before_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool before_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool before_tpoint_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool before_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool before_tstzspan_temporal(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool below_stbox_tpoint(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool below_tpoint_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool below_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool front_stbox_tpoint(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool front_tpoint_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool front_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_stbox_tpoint(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_tbox_tnumber(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_numspan_tnumber(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_tnumber_numspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_tpoint_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool left_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overabove_stbox_tpoint(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overabove_tpoint_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overabove_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overafter_stbox_tpoint(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overafter_tbox_tnumber(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overafter_temporal_tstzspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overafter_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overafter_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overafter_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overafter_tpoint_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overafter_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overafter_tstzspan_temporal(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overback_stbox_tpoint(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overback_tpoint_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overback_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overbefore_stbox_tpoint(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overbefore_tbox_tnumber(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overbefore_temporal_tstzspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overbefore_temporal_temporal(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overbefore_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overbefore_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overbefore_tpoint_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overbefore_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overbefore_tstzspan_temporal(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overbelow_stbox_tpoint(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overbelow_tpoint_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overbelow_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overfront_stbox_tpoint(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overfront_tpoint_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overfront_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_numspan_tnumber(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_stbox_tpoint(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_tbox_tnumber(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_tnumber_numspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_tpoint_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overleft_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_numspan_tnumber(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_stbox_tpoint(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_tbox_tnumber(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_tnumber_numspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_tpoint_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool overright_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_numspan_tnumber(IntPtr s, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_stbox_tpoint(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_tbox_tnumber(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_tnumber_numspan(IntPtr temp, IntPtr s);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_tpoint_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool right_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tand_bool_tbool([MarshalAs(UnmanagedType.I1)] bool b, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tand_tbool_bool(IntPtr temp, [MarshalAs(UnmanagedType.I1)] bool b);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tand_tbool_tbool(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbool_when_true(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnot_tbool(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tor_bool_tbool([MarshalAs(UnmanagedType.I1)] bool b, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tor_tbool_bool(IntPtr temp, [MarshalAs(UnmanagedType.I1)] bool b);

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
            public static partial double float_degrees(double value, [MarshalAs(UnmanagedType.I1)] bool normalize);

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
            public static partial IntPtr tfloat_round(IntPtr temp, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloatarr_round(IntPtr temp, int count, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_degrees(IntPtr temp, [MarshalAs(UnmanagedType.I1)] bool normalize);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_derivative(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_radians(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_abs(IntPtr temp);

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
            public static partial IntPtr ttext_upper(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_lower(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr distance_tfloat_float(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr distance_tint_int(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr distance_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr distance_tpoint_point(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr distance_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_stbox_geo(IntPtr box, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_stbox_stbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tbox_tbox(IntPtr box1, IntPtr box2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tfloat_float(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tfloat_tfloat(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int nad_tint_int(IntPtr temp, int i);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int nad_tint_tint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tnumber_tbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tpoint_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tpoint_stbox(IntPtr temp, IntPtr box);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double nad_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nai_tpoint_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr nai_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool shortestline_tpoint_geo(IntPtr temp, IntPtr gs, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool shortestline_tpoint_tpoint(IntPtr temp1, IntPtr temp2, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool bearing_point_point(IntPtr gs1, IntPtr gs2, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bearing_tpoint_point(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.I1)] bool invert);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr bearing_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_angular_difference(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_azimuth(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_convex_hull(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_cumulative_length(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tpoint_direction(IntPtr temp, IntPtr result);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_get_x(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_get_y(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_get_z(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static partial bool tpoint_is_simple(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tpoint_length(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_speed(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int tpoint_srid(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_stboxes(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_trajectory(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geo_expand_space(IntPtr gs, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr geomeas_to_tpoint(IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeogpoint_to_tgeompoint(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tgeompoint_to_tgeogpoint(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_expand_space(IntPtr temp, double d);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_make_simple(IntPtr temp, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_round(IntPtr temp, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpointarr_round(IntPtr temp, int count, int maxdd);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_set_srid(IntPtr temp, int srid);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int econtains_geo_tpoint(IntPtr gs, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int edisjoint_tpoint_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int edisjoint_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int edwithin_tpoint_geo(IntPtr temp, IntPtr gs, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int edwithin_tpoint_tpoint(IntPtr temp1, IntPtr temp2, double dist);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int eintersects_tpoint_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int eintersects_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int etouches_tpoint_geo(IntPtr temp, IntPtr gs);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tcontains_geo_tpoint(IntPtr gs, IntPtr temp, [MarshalAs(UnmanagedType.I1)] bool restr, [MarshalAs(UnmanagedType.I1)] bool atvalue);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdisjoint_tpoint_geo(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.I1)] bool restr, [MarshalAs(UnmanagedType.I1)] bool atvalue);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdwithin_tpoint_geo(IntPtr temp, IntPtr gs, double dist, [MarshalAs(UnmanagedType.I1)] bool restr, [MarshalAs(UnmanagedType.I1)] bool atvalue);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tdwithin_tpoint_tpoint(IntPtr temp1, IntPtr temp2, double dist, [MarshalAs(UnmanagedType.I1)] bool restr, [MarshalAs(UnmanagedType.I1)] bool atvalue);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintersects_tpoint_geo(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.I1)] bool restr, [MarshalAs(UnmanagedType.I1)] bool atvalue);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttouches_tpoint_geo(IntPtr temp, IntPtr gs, [MarshalAs(UnmanagedType.I1)] bool restr, [MarshalAs(UnmanagedType.I1)] bool atvalue);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbool_tand_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tbool_tor_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_extent_transfn(IntPtr s, IntPtr temp);

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
            public static partial IntPtr tint_tmax_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_tmin_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_tsum_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_extent_transfn(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tnumber_integral(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_tavg_finalfn(IntPtr state);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tnumber_tavg_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial double tnumber_twavg(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_extent_transfn(IntPtr box, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_tcentroid_finalfn(IntPtr state);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_tcentroid_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_twcentroid(IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_tmax_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr ttext_tmin_transfn(IntPtr state, IntPtr temp);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_tprecision(IntPtr temp, IntPtr duration, long origin);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_tsample(IntPtr temp, IntPtr duration, long origin);

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
            public static partial double float_bucket(double value, double size, double origin);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr floatspan_bucket_list(IntPtr bounds, double size, double origin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial int int_bucket(int value, int size, int origin);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr intspan_bucket_list(IntPtr bounds, int size, int origin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tstzspan_bucket_list(IntPtr bounds, IntPtr duration, long origin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_tile(IntPtr point, long t, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, long torigin, [MarshalAs(UnmanagedType.I1)] bool hast);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr stbox_tile_list(IntPtr bounds, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, long torigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tintbox_tile_list(IntPtr box, int xsize, IntPtr duration, int xorigin, long torigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloatbox_tile_list(IntPtr box, double xsize, IntPtr duration, double xorigin, long torigin, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr temporal_time_split(IntPtr temp, IntPtr duration, long torigin, IntPtr time_buckets, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_value_split(IntPtr temp, double size, double origin, IntPtr value_buckets, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tfloat_value_time_split(IntPtr temp, double size, IntPtr duration, double vorigin, long torigin, IntPtr value_buckets, IntPtr time_buckets, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial long timestamptz_bucket(long timestamp, IntPtr duration, long origin);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_value_split(IntPtr temp, int size, int origin, IntPtr value_buckets, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tint_value_time_split(IntPtr temp, int size, IntPtr duration, int vorigin, long torigin, IntPtr value_buckets, IntPtr time_buckets, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_space_split(IntPtr temp, float xsize, float ysize, float zsize, IntPtr sorigin, [MarshalAs(UnmanagedType.I1)] bool bitmatrix, IntPtr count);

            [LibraryImport(DllPath, StringMarshalling = StringMarshalling.Utf8)]
            public static partial IntPtr tpoint_space_time_split(IntPtr temp, float xsize, float ysize, float zsize, IntPtr duration, IntPtr sorigin, long torigin, [MarshalAs(UnmanagedType.I1)] bool bitmatrix, IntPtr time_buckets, IntPtr count);
        }
    }
}
