using System.CodeDom.Compiler;
using System.Runtime.InteropServices;
using static MEOS.NET.Internal.MEOSExposedFunctions;

namespace MEOS.NET.Internal
{
    [Obsolete("Use MEOSExposedFunctions instead.")]
    [GeneratedCode("MEOS.NET.Builder", "0.0.1")]
    internal static class MEOSFunctions
    {
        private const string DllPath = "/home/totojr/Externals/MobilityDB/build/libmeos.so";

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void meos_error(int errlevel, int errcode, string format);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int meos_errno();

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int meos_errno_set(int err);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int meos_errno_restore(int err);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int meos_errno_reset();

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void meos_initialize_timezone(string name);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void meos_initialize(string tz_str, ErrorHandlingMethod errHandler);

        /*[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void meos_initialize_error_handler(error_handler_fn err_handler);*/

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void meos_finalize_timezone();

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool meos_set_datestyle(string newval, IntPtr extra);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool meos_set_intervalstyle(string newval, int extra);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string meos_get_datestyle();

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string meos_get_intervalstyle();

        /*[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void meos_initialize(string tz_str, error_handler_fn err_handler);*/

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void meos_finalize();

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool bool_in(string in_str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string bool_out(bool b);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr cstring2text(string cstring);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern long pg_date_in(string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string pg_date_out(long d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr pg_date_mi(long d1, long d2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern long pg_date_mi_int(long d, int days);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern long pg_date_pl_int(long d, int days);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern DateTimeOffset pg_date_timestamptz(long d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int pg_interval_cmp(IntPtr interval1, IntPtr interval2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr pg_interval_in(string str, int typmod);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr pg_interval_make(int years, int months, int weeks, int days, int hours, int mins, double secs);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr pg_interval_mul(IntPtr span, double factor);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string pg_interval_out(IntPtr span);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr pg_interval_to_char(IntPtr it, IntPtr fmt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr pg_interval_pl(IntPtr span1, IntPtr span2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int pg_time_in(string str, int typmod);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string pg_time_out(int time);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern DateTime pg_timestamp_in(string str, int typmod);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr pg_timestamp_mi(DateTimeOffset dt1, DateTimeOffset dt2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern DateTimeOffset pg_timestamp_mi_interval(DateTimeOffset timestamp, IntPtr span);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string pg_timestamp_out(DateTime dt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern DateTimeOffset pg_timestamp_pl_interval(DateTimeOffset timestamp, IntPtr span);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr pg_timestamp_to_char(DateTime dt, IntPtr fmt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern DateTimeOffset pg_timestamptz_in(string str, int typmod);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern long pg_timestamptz_date(DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string pg_timestamptz_out(DateTimeOffset dt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr pg_timestamptz_to_char(DateTimeOffset dt, IntPtr fmt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern long pg_to_date(IntPtr date_txt, IntPtr fmt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern DateTimeOffset pg_to_timestamptz(IntPtr date_txt, IntPtr fmt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string text2cstring(IntPtr textptr);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string text_out(IntPtr txt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr geography_from_hexewkb(string wkt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr geography_from_text(string wkt, int srid);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr geometry_from_hexewkb(string wkt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr geometry_from_text(string wkt, int srid);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gserialized_as_ewkb(IntPtr gs, string type);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string gserialized_as_ewkt(IntPtr gs, int precision);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string gserialized_as_geojson(IntPtr gs, int option, int precision, string srs);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string gserialized_as_hexewkb(IntPtr gs, string type);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string gserialized_as_text(IntPtr gs, int precision);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gserialized_from_ewkb(IntPtr bytea_wkb, int srid);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gserialized_from_geojson(string geojson);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string gserialized_out(IntPtr gs);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr pgis_geography_in(string input, int geom_typmod);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr pgis_geometry_in(string input, int geom_typmod);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool pgis_gserialized_same(IntPtr gs1, IntPtr gs2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr bigintset_in(string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string bigintset_out(IntPtr set);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr bigintspan_in(string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string bigintspan_out(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr bigintspanset_in(string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string bigintspanset_out(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr dateset_in(string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string dateset_out(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr datespan_in(string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string datespan_out(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr datespanset_in(string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string datespanset_out(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr floatset_in(string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string floatset_out(IntPtr set, int maxdd);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr floatspan_in(string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string floatspan_out(IntPtr s, int maxdd);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr floatspanset_in(string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string floatspanset_out(IntPtr ss, int maxdd);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr geogset_in(string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr geomset_in(string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string geoset_as_ewkt(IntPtr set, int maxdd);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string geoset_as_text(IntPtr set, int maxdd);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string geoset_out(IntPtr set, int maxdd);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intset_in(string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string intset_out(IntPtr set);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intspan_in(string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string intspan_out(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intspanset_in(string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string intspanset_out(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string set_as_hexwkb(IntPtr s, byte variant, IntPtr size_out);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr set_as_wkb(IntPtr s, byte variant, IntPtr size_out);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr set_from_hexwkb(string hexwkb);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr set_from_wkb(IntPtr wkb, ulong size);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string span_as_hexwkb(IntPtr s, byte variant, IntPtr size_out);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr span_as_wkb(IntPtr s, byte variant, IntPtr size_out);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr span_from_hexwkb(string hexwkb);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr span_from_wkb(IntPtr wkb, ulong size);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string spanset_as_hexwkb(IntPtr ss, byte variant, IntPtr size_out);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr spanset_as_wkb(IntPtr ss, byte variant, IntPtr size_out);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr spanset_from_hexwkb(string hexwkb);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr spanset_from_wkb(IntPtr wkb, ulong size);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr textset_in(string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string textset_out(IntPtr set);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tstzset_in(string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string tstzset_out(IntPtr set);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tstzspan_in(string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string tstzspan_out(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tstzspanset_in(string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string tstzspanset_out(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr bigintset_make(IntPtr values, int count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr bigintspan_make(double lower, double upper, bool lower_inc, bool upper_inc);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr dateset_make(IntPtr values, int count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr datespan_make(long lower, long upper, bool lower_inc, bool upper_inc);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr floatset_make(IntPtr values, int count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr floatspan_make(double lower, double upper, bool lower_inc, bool upper_inc);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr geoset_make(IntPtr values, int count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intset_make(IntPtr values, int count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intspan_make(int lower, int upper, bool lower_inc, bool upper_inc);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr set_copy(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr span_copy(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr spanset_copy(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr spanset_make(IntPtr spans, int count, bool normalize);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr textset_make(IntPtr values, int count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tstzset_make(IntPtr values, int count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tstzspan_make(DateTimeOffset lower, DateTimeOffset upper, bool lower_inc, bool upper_inc);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr bigint_to_set(double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr bigint_to_span(int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr bigint_to_spanset(int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr date_to_set(long d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr date_to_span(long d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr date_to_spanset(long d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr date_to_tstzspan(long d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr float_to_set(double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr float_to_span(double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr float_to_spanset(double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr geo_to_set(IntPtr gs);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr int_to_set(int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr int_to_span(int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr int_to_spanset(int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr set_to_spanset(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr span_to_spanset(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr text_to_set(IntPtr txt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr timestamptz_to_set(DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr timestamptz_to_span(DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr timestamptz_to_spanset(DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double bigintset_end_value(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double bigintset_start_value(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool bigintset_value_n(IntPtr s, int n, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr bigintset_values(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double bigintspan_lower(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double bigintspan_upper(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double bigintspanset_lower(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double bigintspanset_upper(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern long dateset_end_value(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern long dateset_start_value(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool dateset_value_n(IntPtr s, int n, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr dateset_values(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr datespan_duration(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr datespanset_duration(IntPtr ss, bool boundspan);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern long datespanset_end_date(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int datespanset_num_dates(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern long datespanset_start_date(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool datespanset_date_n(IntPtr ss, int n, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr datespanset_dates(IntPtr ss, IntPtr count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double floatset_end_value(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double floatset_start_value(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool floatset_value_n(IntPtr s, int n, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr floatset_values(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double floatspan_lower(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double floatspan_upper(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double floatspanset_lower(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double floatspanset_upper(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr geoset_end_value(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int geoset_srid(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr geoset_set_srid(IntPtr s, int srid);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr geoset_start_value(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool geoset_value_n(IntPtr s, int n, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr geoset_values(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int intset_end_value(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int intset_start_value(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool intset_value_n(IntPtr s, int n, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intset_values(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int intspan_lower(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int intspan_upper(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int intspanset_lower(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int intspanset_upper(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint set_hash(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong set_hash_extended(IntPtr s, ulong seed);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int set_num_values(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr set_to_span(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint span_hash(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong span_hash_extended(IntPtr s, ulong seed);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool span_lower_inc(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool span_upper_inc(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double span_width(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr spanset_end_span(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint spanset_hash(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong spanset_hash_extended(IntPtr ss, ulong seed);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool spanset_lower_inc(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int spanset_num_spans(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr spanset_span(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr spanset_span_n(IntPtr ss, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr spanset_spans(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr spanset_start_span(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool spanset_upper_inc(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double spanset_width(IntPtr ss, bool boundspan);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr spatialset_to_stbox(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr textset_end_value(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr textset_start_value(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool textset_value_n(IntPtr s, int n, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr textset_values(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern DateTimeOffset tstzset_end_value(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern DateTimeOffset tstzset_start_value(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tstzset_value_n(IntPtr s, int n, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tstzset_values(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tstzspan_duration(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern DateTimeOffset tstzspan_lower(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern DateTimeOffset tstzspan_upper(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tstzspanset_duration(IntPtr ss, bool boundspan);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern DateTimeOffset tstzspanset_end_timestamptz(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern DateTimeOffset tstzspanset_lower(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int tstzspanset_num_timestamps(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern DateTimeOffset tstzspanset_start_timestamptz(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tstzspanset_timestamptz_n(IntPtr ss, int n, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tstzspanset_timestamps(IntPtr ss, IntPtr count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern DateTimeOffset tstzspanset_upper(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr bigintset_shift_scale(IntPtr s, double shift, double width, bool hasshift, bool haswidth);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr bigintspan_shift_scale(IntPtr s, double shift, double width, bool hasshift, bool haswidth);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr bigintspanset_shift_scale(IntPtr ss, double shift, double width, bool hasshift, bool haswidth);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr dateset_shift_scale(IntPtr s, int shift, int width, bool hasshift, bool haswidth);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr dateset_to_tstzset(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr datespan_shift_scale(IntPtr s, int shift, int width, bool hasshift, bool haswidth);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr datespan_to_tstzspan(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr datespanset_shift_scale(IntPtr ss, int shift, int width, bool hasshift, bool haswidth);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr datespanset_to_tstzspanset(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr floatset_round(IntPtr s, int maxdd);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr floatset_shift_scale(IntPtr s, double shift, double width, bool hasshift, bool haswidth);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr floatset_to_intset(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr floatspan_round(IntPtr s, int maxdd);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr floatspan_shift_scale(IntPtr s, double shift, double width, bool hasshift, bool haswidth);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr floatspan_to_intspan(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr floatspanset_to_intspanset(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr floatspanset_round(IntPtr ss, int maxdd);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr floatspanset_shift_scale(IntPtr ss, double shift, double width, bool hasshift, bool haswidth);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr geoset_round(IntPtr s, int maxdd);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intset_shift_scale(IntPtr s, int shift, int width, bool hasshift, bool haswidth);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intset_to_floatset(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intspan_shift_scale(IntPtr s, int shift, int width, bool hasshift, bool haswidth);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intspan_to_floatspan(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intspanset_to_floatspanset(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intspanset_shift_scale(IntPtr ss, int shift, int width, bool hasshift, bool haswidth);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr textset_lower(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr textset_upper(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern DateTimeOffset timestamptz_tprecision(DateTimeOffset t, IntPtr duration, DateTimeOffset torigin);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tstzset_shift_scale(IntPtr s, IntPtr shift, IntPtr duration);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tstzspan_shift_scale(IntPtr s, IntPtr shift, IntPtr duration);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tstzspan_tprecision(IntPtr s, IntPtr duration, DateTimeOffset torigin);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tstzset_to_dateset(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tstzspan_to_datespan(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tstzspanset_to_datespanset(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tstzspanset_shift_scale(IntPtr ss, IntPtr shift, IntPtr duration);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tstzspanset_tprecision(IntPtr ss, IntPtr duration, DateTimeOffset torigin);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intersection_set_bigint(IntPtr s, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intersection_set_date(IntPtr s, long d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intersection_set_float(IntPtr s, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intersection_set_geo(IntPtr s, IntPtr gs);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intersection_set_int(IntPtr s, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intersection_set_set(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intersection_set_text(IntPtr s, IntPtr txt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intersection_set_timestamptz(IntPtr s, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intersection_span_bigint(IntPtr s, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intersection_span_date(IntPtr s, long d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intersection_span_float(IntPtr s, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intersection_span_int(IntPtr s, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intersection_span_timestamptz(IntPtr s, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intersection_span_span(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intersection_spanset_bigint(IntPtr ss, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intersection_spanset_date(IntPtr ss, long d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intersection_spanset_float(IntPtr ss, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intersection_spanset_int(IntPtr ss, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intersection_spanset_span(IntPtr ss, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intersection_spanset_spanset(IntPtr ss1, IntPtr ss2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intersection_spanset_timestamptz(IntPtr ss, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_bigint_set(double i, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_bigint_span(double i, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_bigint_spanset(double i, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_date_set(long d, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_date_span(long d, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_date_spanset(long d, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_float_set(double d, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_float_span(double d, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_float_spanset(double d, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_geo_set(IntPtr gs, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_int_set(int i, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_int_span(int i, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_int_spanset(int i, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_set_bigint(IntPtr s, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_set_date(IntPtr s, long d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_set_float(IntPtr s, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_set_geo(IntPtr s, IntPtr gs);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_set_int(IntPtr s, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_set_set(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_set_text(IntPtr s, IntPtr txt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_set_timestamptz(IntPtr s, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_span_bigint(IntPtr s, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_span_date(IntPtr s, long d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_span_float(IntPtr s, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_span_int(IntPtr s, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_span_span(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_span_spanset(IntPtr s, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_span_timestamptz(IntPtr s, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_spanset_bigint(IntPtr ss, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_spanset_date(IntPtr ss, long d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_spanset_float(IntPtr ss, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_spanset_int(IntPtr ss, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_spanset_span(IntPtr ss, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_spanset_spanset(IntPtr ss1, IntPtr ss2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_spanset_timestamptz(IntPtr ss, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_text_set(IntPtr txt, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_timestamptz_span(DateTimeOffset t, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_timestamptz_spanset(DateTimeOffset t, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr minus_timestamptz_set(DateTimeOffset t, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr super_union_span_span(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr union_set_bigint(IntPtr s, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr union_set_date(IntPtr s, long d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr union_set_float(IntPtr s, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr union_set_geo(IntPtr s, IntPtr gs);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr union_set_int(IntPtr s, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr union_set_set(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr union_set_text(IntPtr s, IntPtr txt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr union_set_timestamptz(IntPtr s, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr union_span_bigint(IntPtr s, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr union_span_date(IntPtr s, long d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr union_span_float(IntPtr s, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr union_span_int(IntPtr s, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr union_span_span(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr union_span_timestamptz(IntPtr s, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr union_spanset_bigint(IntPtr ss, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr union_spanset_date(IntPtr ss, long d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr union_spanset_float(IntPtr ss, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr union_spanset_int(IntPtr ss, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr union_spanset_span(IntPtr ss, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr union_spanset_spanset(IntPtr ss1, IntPtr ss2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr union_spanset_timestamptz(IntPtr ss, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool adjacent_span_bigint(IntPtr s, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool adjacent_span_date(IntPtr s, long d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool adjacent_span_float(IntPtr s, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool adjacent_span_int(IntPtr s, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool adjacent_span_span(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool adjacent_span_timestamptz(IntPtr s, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool adjacent_spanset_bigint(IntPtr ss, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool adjacent_spanset_date(IntPtr ss, long d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool adjacent_spanset_float(IntPtr ss, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool adjacent_spanset_int(IntPtr ss, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool adjacent_spanset_timestamptz(IntPtr ss, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool adjacent_spanset_span(IntPtr ss, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool adjacent_spanset_spanset(IntPtr ss1, IntPtr ss2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_bigint_set(double i, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_bigint_span(double i, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_bigint_spanset(double i, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_date_set(long d, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_date_span(long d, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_date_spanset(long d, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_float_set(double d, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_float_span(double d, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_float_spanset(double d, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_geo_set(IntPtr gs, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_int_set(int i, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_int_span(int i, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_int_spanset(int i, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_set_set(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_span_span(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_span_spanset(IntPtr s, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_spanset_span(IntPtr ss, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_spanset_spanset(IntPtr ss1, IntPtr ss2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_text_set(IntPtr txt, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_timestamptz_set(DateTimeOffset t, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_timestamptz_span(DateTimeOffset t, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_timestamptz_spanset(DateTimeOffset t, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_set_bigint(IntPtr s, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_set_date(IntPtr s, long d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_set_float(IntPtr s, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_set_geo(IntPtr s, IntPtr gs);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_set_int(IntPtr s, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_set_set(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_set_text(IntPtr s, IntPtr t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_set_timestamptz(IntPtr s, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_span_bigint(IntPtr s, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_span_float(IntPtr s, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_span_int(IntPtr s, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_span_span(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_span_spanset(IntPtr s, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_span_timestamptz(IntPtr s, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_spanset_bigint(IntPtr ss, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_spanset_float(IntPtr ss, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_spanset_int(IntPtr ss, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_spanset_span(IntPtr ss, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_spanset_spanset(IntPtr ss1, IntPtr ss2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_spanset_timestamptz(IntPtr ss, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overlaps_set_set(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overlaps_span_span(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overlaps_spanset_span(IntPtr ss, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overlaps_spanset_spanset(IntPtr ss1, IntPtr ss2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool after_date_set(long d, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool after_date_span(long d, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool after_date_spanset(long d, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool after_set_date(IntPtr s, long d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool after_set_timestamptz(IntPtr s, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool after_span_date(IntPtr s, long d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool after_span_timestamptz(IntPtr s, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool after_spanset_date(IntPtr ss, long d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool after_spanset_timestamptz(IntPtr ss, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool after_timestamptz_set(DateTimeOffset t, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool after_timestamptz_span(DateTimeOffset t, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool after_timestamptz_spanset(DateTimeOffset t, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool before_date_set(long d, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool before_date_span(long d, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool before_date_spanset(long d, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool before_set_date(IntPtr s, long d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool before_set_timestamptz(IntPtr s, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool before_span_date(IntPtr s, long d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool before_span_timestamptz(IntPtr s, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool before_spanset_date(IntPtr ss, long d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool before_spanset_timestamptz(IntPtr ss, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool before_timestamptz_set(DateTimeOffset t, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool before_timestamptz_span(DateTimeOffset t, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool before_timestamptz_spanset(DateTimeOffset t, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_bigint_set(double i, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_bigint_span(double i, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_bigint_spanset(double i, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_float_set(double d, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_float_span(double d, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_float_spanset(double d, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_int_set(int i, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_int_span(int i, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_int_spanset(int i, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_set_bigint(IntPtr s, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_set_float(IntPtr s, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_set_int(IntPtr s, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_set_set(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_set_text(IntPtr s, IntPtr txt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_span_bigint(IntPtr s, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_span_float(IntPtr s, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_span_int(IntPtr s, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_span_span(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_span_spanset(IntPtr s, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_spanset_bigint(IntPtr ss, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_spanset_float(IntPtr ss, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_spanset_int(IntPtr ss, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_spanset_span(IntPtr ss, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_spanset_spanset(IntPtr ss1, IntPtr ss2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_text_set(IntPtr txt, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overafter_set_date(IntPtr s, long d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overafter_set_timestamptz(IntPtr s, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overafter_span_timestamptz(IntPtr s, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overafter_spanset_timestamptz(IntPtr ss, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overafter_timestamptz_set(DateTimeOffset t, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overafter_timestamptz_span(DateTimeOffset t, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overafter_timestamptz_spanset(DateTimeOffset t, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overbefore_set_date(IntPtr s, long d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overbefore_set_timestamptz(IntPtr s, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overbefore_span_timestamptz(IntPtr s, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overbefore_spanset_timestamptz(IntPtr ss, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overbefore_timestamptz_set(DateTimeOffset t, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overbefore_timestamptz_span(DateTimeOffset t, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overbefore_timestamptz_spanset(DateTimeOffset t, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_bigint_set(double i, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_bigint_span(double i, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_bigint_spanset(double i, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_float_set(double d, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_float_span(double d, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_float_spanset(double d, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_int_set(int i, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_int_span(int i, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_int_spanset(int i, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_set_bigint(IntPtr s, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_set_float(IntPtr s, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_set_int(IntPtr s, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_set_set(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_set_text(IntPtr s, IntPtr txt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_span_bigint(IntPtr s, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_span_float(IntPtr s, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_span_int(IntPtr s, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_span_span(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_span_spanset(IntPtr s, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_spanset_bigint(IntPtr ss, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_spanset_float(IntPtr ss, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_spanset_int(IntPtr ss, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_spanset_span(IntPtr ss, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_spanset_spanset(IntPtr ss1, IntPtr ss2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_text_set(IntPtr txt, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_bigint_set(double i, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_bigint_span(double i, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_bigint_spanset(double i, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_float_set(double d, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_float_span(double d, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_float_spanset(double d, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_int_set(int i, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_int_span(int i, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_int_spanset(int i, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_set_bigint(IntPtr s, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_set_float(IntPtr s, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_set_int(IntPtr s, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_set_set(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_set_text(IntPtr s, IntPtr txt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_span_bigint(IntPtr s, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_span_float(IntPtr s, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_span_int(IntPtr s, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_span_span(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_span_spanset(IntPtr s, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_spanset_bigint(IntPtr ss, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_spanset_float(IntPtr ss, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_spanset_int(IntPtr ss, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_spanset_span(IntPtr ss, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_spanset_spanset(IntPtr ss1, IntPtr ss2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_text_set(IntPtr txt, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_bigint_set(double i, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_bigint_span(double i, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_bigint_spanset(double i, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_float_set(double d, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_float_span(double d, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_float_spanset(double d, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_int_set(int i, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_int_span(int i, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_int_spanset(int i, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_set_bigint(IntPtr s, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_set_float(IntPtr s, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_set_int(IntPtr s, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_set_set(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_set_text(IntPtr s, IntPtr txt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_span_bigint(IntPtr s, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_span_float(IntPtr s, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_span_int(IntPtr s, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_span_span(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_span_spanset(IntPtr s, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_spanset_bigint(IntPtr ss, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_spanset_float(IntPtr ss, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_spanset_int(IntPtr ss, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_spanset_span(IntPtr ss, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_spanset_spanset(IntPtr ss1, IntPtr ss2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_text_set(IntPtr txt, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double distance_set_bigint(IntPtr s, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double distance_set_float(IntPtr s, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double distance_set_int(IntPtr s, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double distance_set_set(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double distance_set_timestamptz(IntPtr s, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double distance_span_bigint(IntPtr s, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double distance_span_float(IntPtr s, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double distance_span_int(IntPtr s, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double distance_span_span(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double distance_span_timestamptz(IntPtr s, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double distance_spanset_bigint(IntPtr ss, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double distance_spanset_float(IntPtr ss, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double distance_spanset_int(IntPtr ss, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double distance_spanset_timestamptz(IntPtr ss, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double distance_spanset_span(IntPtr ss, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double distance_spanset_spanset(IntPtr ss1, IntPtr ss2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int set_cmp(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool set_eq(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool set_ge(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool set_gt(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool set_le(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool set_lt(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool set_ne(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int span_cmp(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool span_eq(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool span_ge(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool span_gt(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool span_le(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool span_lt(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool span_ne(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int spanset_cmp(IntPtr ss1, IntPtr ss2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool spanset_eq(IntPtr ss1, IntPtr ss2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool spanset_ge(IntPtr ss1, IntPtr ss2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool spanset_gt(IntPtr ss1, IntPtr ss2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool spanset_le(IntPtr ss1, IntPtr ss2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool spanset_lt(IntPtr ss1, IntPtr ss2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool spanset_ne(IntPtr ss1, IntPtr ss2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr bigint_extent_transfn(IntPtr s, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr bigint_union_transfn(IntPtr state, double i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr float_extent_transfn(IntPtr s, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr float_union_transfn(IntPtr state, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr int_extent_transfn(IntPtr s, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr int_union_transfn(IntPtr state, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr set_extent_transfn(IntPtr span, IntPtr set);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr set_union_finalfn(IntPtr state);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr set_union_transfn(IntPtr state, IntPtr set);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr span_extent_transfn(IntPtr s1, IntPtr s2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr span_union_transfn(IntPtr state, IntPtr span);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr spanset_extent_transfn(IntPtr s, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr spanset_union_finalfn(IntPtr state);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr spanset_union_transfn(IntPtr state, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr text_union_transfn(IntPtr state, IntPtr txt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr timestamptz_extent_transfn(IntPtr s, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr timestamptz_tcount_transfn(IntPtr state, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr timestamptz_union_transfn(IntPtr state, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tstzset_tcount_transfn(IntPtr state, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tstzspan_tcount_transfn(IntPtr state, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tstzspanset_tcount_transfn(IntPtr state, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tbox_in(string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string tbox_out(IntPtr box, int maxdd);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tbox_from_wkb(IntPtr wkb, ulong size);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tbox_from_hexwkb(string hexwkb);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr stbox_from_wkb(IntPtr wkb, ulong size);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr stbox_from_hexwkb(string hexwkb);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tbox_as_wkb(IntPtr box, byte variant, IntPtr size_out);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string tbox_as_hexwkb(IntPtr box, byte variant, IntPtr size);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr stbox_as_wkb(IntPtr box, byte variant, IntPtr size_out);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string stbox_as_hexwkb(IntPtr box, byte variant, IntPtr size);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr stbox_in(string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string stbox_out(IntPtr box, int maxdd);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr float_tstzspan_to_tbox(double d, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr float_timestamptz_to_tbox(double d, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr geo_tstzspan_to_stbox(IntPtr gs, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr geo_timestamptz_to_stbox(IntPtr gs, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr int_tstzspan_to_tbox(int i, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr int_timestamptz_to_tbox(int i, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr numspan_tstzspan_to_tbox(IntPtr span, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr numspan_timestamptz_to_tbox(IntPtr span, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr stbox_copy(IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr stbox_make(bool hasx, bool hasz, bool geodetic, int srid, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tbox_copy(IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tbox_make(IntPtr s, IntPtr p);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr box3d_to_stbox(IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gbox_to_stbox(IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr float_to_tbox(double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr geo_to_stbox(IntPtr gs);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr int_to_tbox(int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr numset_to_tbox(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr numspan_to_tbox(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr numspanset_to_tbox(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tstzspan_to_stbox(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tstzspan_to_tbox(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tstzspanset_to_stbox(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tstzspanset_to_tbox(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr stbox_to_gbox(IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr stbox_to_box3d(IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr stbox_to_geo(IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr stbox_to_tstzspan(IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tbox_to_intspan(IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tbox_to_floatspan(IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tbox_to_tstzspan(IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr timestamptz_to_stbox(DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr timestamptz_to_tbox(DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tstzset_to_stbox(IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tstzset_to_tbox(IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tnumber_to_tbox(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_to_stbox(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool stbox_hast(IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool stbox_hasx(IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool stbox_hasz(IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool stbox_isgeodetic(IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int stbox_srid(IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool stbox_tmax(IntPtr box, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool stbox_tmax_inc(IntPtr box, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool stbox_tmin(IntPtr box, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool stbox_tmin_inc(IntPtr box, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool stbox_xmax(IntPtr box, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool stbox_xmin(IntPtr box, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool stbox_ymax(IntPtr box, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool stbox_ymin(IntPtr box, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool stbox_zmax(IntPtr box, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool stbox_zmin(IntPtr box, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tbox_hast(IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tbox_hasx(IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tbox_tmax(IntPtr box, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tbox_tmax_inc(IntPtr box, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tbox_tmin(IntPtr box, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tbox_tmin_inc(IntPtr box, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tbox_xmax(IntPtr box, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tbox_xmax_inc(IntPtr box, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tbox_xmin(IntPtr box, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tbox_xmin_inc(IntPtr box, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tboxfloat_xmax(IntPtr box, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tboxfloat_xmin(IntPtr box, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tboxint_xmax(IntPtr box, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tboxint_xmin(IntPtr box, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr stbox_expand_space(IntPtr box, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr stbox_expand_time(IntPtr box, IntPtr interval);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr stbox_get_space(IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr stbox_round(IntPtr box, int maxdd);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr stbox_set_srid(IntPtr box, int srid);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr stbox_shift_scale_time(IntPtr box, IntPtr shift, IntPtr duration);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tbox_expand_time(IntPtr box, IntPtr interval);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tbox_expand_float(IntPtr box, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tbox_expand_int(IntPtr box, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tbox_round(IntPtr box, int maxdd);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tbox_shift_scale_float(IntPtr box, double shift, double width, bool hasshift, bool haswidth);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tbox_shift_scale_int(IntPtr box, int shift, int width, bool hasshift, bool haswidth);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tbox_shift_scale_time(IntPtr box, IntPtr shift, IntPtr duration);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr union_tbox_tbox(IntPtr box1, IntPtr box2, bool strict);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool inter_tbox_tbox(IntPtr box1, IntPtr box2, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intersection_tbox_tbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr union_stbox_stbox(IntPtr box1, IntPtr box2, bool strict);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool inter_stbox_stbox(IntPtr box1, IntPtr box2, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intersection_stbox_stbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_tbox_tbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_tbox_tbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overlaps_tbox_tbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool same_tbox_tbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool adjacent_tbox_tbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_stbox_stbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_stbox_stbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overlaps_stbox_stbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool same_stbox_stbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool adjacent_stbox_stbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_tbox_tbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_tbox_tbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_tbox_tbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_tbox_tbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool before_tbox_tbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overbefore_tbox_tbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool after_tbox_tbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overafter_tbox_tbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_stbox_stbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_stbox_stbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_stbox_stbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_stbox_stbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool below_stbox_stbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overbelow_stbox_stbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool above_stbox_stbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overabove_stbox_stbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool front_stbox_stbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overfront_stbox_stbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool back_stbox_stbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overback_stbox_stbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool before_stbox_stbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overbefore_stbox_stbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool after_stbox_stbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overafter_stbox_stbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr stbox_quad_split(IntPtr box, IntPtr count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tbox_eq(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tbox_ne(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int tbox_cmp(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tbox_lt(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tbox_le(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tbox_ge(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tbox_gt(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool stbox_eq(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool stbox_ne(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int stbox_cmp(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool stbox_lt(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool stbox_le(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool stbox_ge(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool stbox_gt(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tbool_in(string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string tbool_out(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string temporal_as_hexwkb(IntPtr temp, byte variant, IntPtr size_out);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string temporal_as_mfjson(IntPtr temp, bool with_bbox, int flags, int precision, string srs);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_as_wkb(IntPtr temp, byte variant, IntPtr size_out);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_from_hexwkb(string hexwkb);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_from_mfjson(string mfjson);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_from_wkb(IntPtr wkb, ulong size);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tfloat_in(string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string tfloat_out(IntPtr temp, int maxdd);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tgeogpoint_in(string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr tgeompoint_in(string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tint_in(string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string tint_out(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string tpoint_as_ewkt(IntPtr temp, int maxdd);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string tpoint_as_text(IntPtr temp, int maxdd);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string tpoint_out(IntPtr temp, int maxdd);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ttext_in(string str);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string ttext_out(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_cp(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tbool_from_base_temp(bool b, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tboolinst_make(bool b, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tboolseq_from_base_tstzset(bool b, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tboolseq_from_base_tstzspan(bool b, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tboolseqset_from_base_tstzspanset(bool b, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_copy(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tfloat_from_base_temp(double d, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tfloatinst_make(double d, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tfloatseq_from_base_tstzspan(double d, IntPtr s, InterpolationType interp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tfloatseq_from_base_tstzset(double d, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tfloatseqset_from_base_tstzspanset(double d, IntPtr ss, InterpolationType interp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tint_from_base_temp(int i, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tintinst_make(int i, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tintseq_from_base_tstzspan(int i, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tintseq_from_base_tstzset(int i, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tintseqset_from_base_tstzspanset(int i, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_from_base_temp(IntPtr gs, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpointinst_make(IntPtr gs, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpointseq_from_base_tstzspan(IntPtr gs, IntPtr s, InterpolationType interp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpointseq_from_base_tstzset(IntPtr gs, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpointseqset_from_base_tstzspanset(IntPtr gs, IntPtr ss, InterpolationType interp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tsequence_make(IntPtr instants, int count, bool lower_inc, bool upper_inc, InterpolationType interp, bool normalize);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tsequenceset_make(IntPtr sequences, int count, bool normalize);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tsequenceset_make_gaps(IntPtr instants, int count, InterpolationType interp, IntPtr maxt, double maxdist);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ttext_from_base_temp(IntPtr txt, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ttextinst_make(IntPtr txt, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ttextseq_from_base_tstzspan(IntPtr txt, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ttextseq_from_base_tstzset(IntPtr txt, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ttextseqset_from_base_tstzspanset(IntPtr txt, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_to_tstzspan(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tfloat_to_tint(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tint_to_tfloat(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tnumber_to_span(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tbool_end_value(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tbool_start_value(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tbool_values(IntPtr temp, IntPtr count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_duration(IntPtr temp, bool boundspan);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_end_instant(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_end_sequence(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern DateTimeOffset temporal_end_timestamptz(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint temporal_hash(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_instant_n(IntPtr temp, int n);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_instants(IntPtr temp, IntPtr count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string temporal_interp(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_max_instant(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_min_instant(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int temporal_num_instants(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int temporal_num_sequences(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int temporal_num_timestamps(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_segments(IntPtr temp, IntPtr count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_sequence_n(IntPtr temp, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_sequences(IntPtr temp, IntPtr count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_start_instant(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_start_sequence(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern DateTimeOffset temporal_start_timestamptz(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_stops(IntPtr temp, double maxdist, IntPtr minduration);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern string temporal_subtype(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_time(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool temporal_timestamptz_n(IntPtr temp, int n, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_timestamps(IntPtr temp, IntPtr count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double tfloat_end_value(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double tfloat_max_value(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double tfloat_min_value(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double tfloat_start_value(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tfloat_values(IntPtr temp, IntPtr count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int tint_end_value(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int tint_max_value(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int tint_min_value(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int tint_start_value(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tint_values(IntPtr temp, IntPtr count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tnumber_valuespans(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_end_value(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_start_value(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_values(IntPtr temp, IntPtr count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ttext_end_value(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ttext_max_value(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ttext_min_value(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ttext_start_value(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ttext_values(IntPtr temp, IntPtr count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_scale_time(IntPtr temp, IntPtr duration);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_set_interp(IntPtr temp, InterpolationType interp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_shift_scale_time(IntPtr temp, IntPtr shift, IntPtr duration);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_shift_time(IntPtr temp, IntPtr shift);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_to_tinstant(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_to_tsequence(IntPtr temp, InterpolationType interp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_to_tsequenceset(IntPtr temp, InterpolationType interp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tfloat_scale_value(IntPtr temp, double width);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tfloat_shift_scale_value(IntPtr temp, double shift, double width);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tfloat_shift_value(IntPtr temp, double shift);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tint_scale_value(IntPtr temp, int width);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tint_shift_scale_value(IntPtr temp, int shift, int width);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tint_shift_value(IntPtr temp, int shift);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_append_tinstant(IntPtr temp, IntPtr inst, double maxdist, IntPtr maxt, bool expand);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_append_tsequence(IntPtr temp, IntPtr seq, bool expand);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_delete_tstzspan(IntPtr temp, IntPtr s, bool connect);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_delete_tstzspanset(IntPtr temp, IntPtr ss, bool connect);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_delete_timestamptz(IntPtr temp, DateTimeOffset t, bool connect);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_delete_tstzset(IntPtr temp, IntPtr s, bool connect);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_insert(IntPtr temp1, IntPtr temp2, bool connect);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_merge(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_merge_array(IntPtr temparr, int count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_update(IntPtr temp1, IntPtr temp2, bool connect);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tbool_at_value(IntPtr temp, bool b);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tbool_minus_value(IntPtr temp, bool b);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tbool_value_at_timestamptz(IntPtr temp, DateTimeOffset t, bool strict, IntPtr value);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_at_max(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_at_min(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_at_tstzspan(IntPtr temp, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_at_tstzspanset(IntPtr temp, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_at_timestamptz(IntPtr temp, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_at_tstzset(IntPtr temp, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_at_values(IntPtr temp, IntPtr set);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_minus_max(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_minus_min(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_minus_tstzspan(IntPtr temp, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_minus_tstzspanset(IntPtr temp, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_minus_timestamptz(IntPtr temp, DateTimeOffset t);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_minus_tstzset(IntPtr temp, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_minus_values(IntPtr temp, IntPtr set);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tfloat_at_value(IntPtr temp, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tfloat_minus_value(IntPtr temp, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tfloat_value_at_timestamptz(IntPtr temp, DateTimeOffset t, bool strict, IntPtr value);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tint_at_value(IntPtr temp, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tint_minus_value(IntPtr temp, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tint_value_at_timestamptz(IntPtr temp, DateTimeOffset t, bool strict, IntPtr value);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tnumber_at_span(IntPtr temp, IntPtr span);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tnumber_at_spanset(IntPtr temp, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tnumber_at_tbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tnumber_minus_span(IntPtr temp, IntPtr span);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tnumber_minus_spanset(IntPtr temp, IntPtr ss);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tnumber_minus_tbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_at_geom_time(IntPtr temp, IntPtr gs, IntPtr zspan, IntPtr period);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_at_stbox(IntPtr temp, IntPtr box, bool border_inc);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_at_value(IntPtr temp, IntPtr gs);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_minus_geom_time(IntPtr temp, IntPtr gs, IntPtr zspan, IntPtr period);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_minus_stbox(IntPtr temp, IntPtr box, bool border_inc);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_minus_value(IntPtr temp, IntPtr gs);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tpoint_value_at_timestamptz(IntPtr temp, DateTimeOffset t, bool strict, IntPtr value);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ttext_at_value(IntPtr temp, IntPtr txt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ttext_minus_value(IntPtr temp, IntPtr txt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ttext_value_at_timestamptz(IntPtr temp, DateTimeOffset t, bool strict, IntPtr value);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int temporal_cmp(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool temporal_eq(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool temporal_ge(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool temporal_gt(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool temporal_le(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool temporal_lt(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool temporal_ne(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tbool_always_eq(IntPtr temp, bool b);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tbool_ever_eq(IntPtr temp, bool b);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tfloat_always_eq(IntPtr temp, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tfloat_always_le(IntPtr temp, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tfloat_always_lt(IntPtr temp, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tfloat_ever_eq(IntPtr temp, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tfloat_ever_le(IntPtr temp, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tfloat_ever_lt(IntPtr temp, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tint_always_eq(IntPtr temp, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tint_always_le(IntPtr temp, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tint_always_lt(IntPtr temp, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tint_ever_eq(IntPtr temp, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tint_ever_le(IntPtr temp, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tint_ever_lt(IntPtr temp, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tpoint_always_eq(IntPtr temp, IntPtr gs);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tpoint_ever_eq(IntPtr temp, IntPtr gs);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ttext_always_eq(IntPtr temp, IntPtr txt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ttext_always_le(IntPtr temp, IntPtr txt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ttext_always_lt(IntPtr temp, IntPtr txt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ttext_ever_eq(IntPtr temp, IntPtr txt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ttext_ever_le(IntPtr temp, IntPtr txt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ttext_ever_lt(IntPtr temp, IntPtr txt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr teq_bool_tbool(bool b, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr teq_float_tfloat(double d, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr teq_int_tint(int i, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr teq_point_tpoint(IntPtr gs, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr teq_tbool_bool(IntPtr temp, bool b);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr teq_temporal_temporal(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr teq_text_ttext(IntPtr txt, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr teq_tfloat_float(IntPtr temp, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr teq_tpoint_point(IntPtr temp, IntPtr gs);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr teq_tint_int(IntPtr temp, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr teq_ttext_text(IntPtr temp, IntPtr txt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tge_float_tfloat(double d, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tge_int_tint(int i, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tge_temporal_temporal(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tge_text_ttext(IntPtr txt, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tge_tfloat_float(IntPtr temp, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tge_tint_int(IntPtr temp, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tge_ttext_text(IntPtr temp, IntPtr txt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tgt_float_tfloat(double d, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tgt_int_tint(int i, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tgt_temporal_temporal(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tgt_text_ttext(IntPtr txt, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tgt_tfloat_float(IntPtr temp, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tgt_tint_int(IntPtr temp, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tgt_ttext_text(IntPtr temp, IntPtr txt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tle_float_tfloat(double d, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tle_int_tint(int i, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tle_temporal_temporal(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tle_text_ttext(IntPtr txt, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tle_tfloat_float(IntPtr temp, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tle_tint_int(IntPtr temp, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tle_ttext_text(IntPtr temp, IntPtr txt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tlt_float_tfloat(double d, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tlt_int_tint(int i, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tlt_temporal_temporal(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tlt_text_ttext(IntPtr txt, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tlt_tfloat_float(IntPtr temp, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tlt_tint_int(IntPtr temp, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tlt_ttext_text(IntPtr temp, IntPtr txt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tne_bool_tbool(bool b, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tne_float_tfloat(double d, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tne_int_tint(int i, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tne_point_tpoint(IntPtr gs, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tne_tbool_bool(IntPtr temp, bool b);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tne_temporal_temporal(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tne_text_ttext(IntPtr txt, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tne_tfloat_float(IntPtr temp, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tne_tpoint_point(IntPtr temp, IntPtr gs);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tne_tint_int(IntPtr temp, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tne_ttext_text(IntPtr temp, IntPtr txt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool adjacent_numspan_tnumber(IntPtr s, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool adjacent_stbox_tpoint(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool adjacent_tbox_tnumber(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool adjacent_temporal_temporal(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool adjacent_temporal_tstzspan(IntPtr temp, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool adjacent_tnumber_numspan(IntPtr temp, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool adjacent_tnumber_tbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool adjacent_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool adjacent_tpoint_stbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool adjacent_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool adjacent_tstzspan_temporal(IntPtr s, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_numspan_tnumber(IntPtr s, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_stbox_tpoint(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_tbox_tnumber(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_temporal_temporal(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_temporal_tstzspan(IntPtr temp, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_tnumber_numspan(IntPtr temp, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_tnumber_tbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_tpoint_stbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contained_tstzspan_temporal(IntPtr s, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_numspan_tnumber(IntPtr s, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_stbox_tpoint(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_tbox_tnumber(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_temporal_tstzspan(IntPtr temp, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_temporal_temporal(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_tnumber_numspan(IntPtr temp, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_tnumber_tbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_tpoint_stbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool contains_tstzspan_temporal(IntPtr s, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overlaps_numspan_tnumber(IntPtr s, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overlaps_stbox_tpoint(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overlaps_tbox_tnumber(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overlaps_temporal_temporal(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overlaps_temporal_tstzspan(IntPtr temp, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overlaps_tnumber_numspan(IntPtr temp, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overlaps_tnumber_tbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overlaps_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overlaps_tpoint_stbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overlaps_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overlaps_tstzspan_temporal(IntPtr s, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool same_numspan_tnumber(IntPtr s, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool same_stbox_tpoint(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool same_tbox_tnumber(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool same_temporal_temporal(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool same_temporal_tstzspan(IntPtr temp, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool same_tnumber_numspan(IntPtr temp, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool same_tnumber_tbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool same_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool same_tpoint_stbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool same_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool same_tstzspan_temporal(IntPtr s, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool above_stbox_tpoint(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool above_tpoint_stbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool above_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool after_stbox_tpoint(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool after_tbox_tnumber(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool after_temporal_tstzspan(IntPtr temp, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool after_temporal_temporal(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool after_tnumber_tbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool after_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool after_tpoint_stbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool after_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool after_tstzspan_temporal(IntPtr s, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool back_stbox_tpoint(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool back_tpoint_stbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool back_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool before_stbox_tpoint(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool before_tbox_tnumber(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool before_temporal_tstzspan(IntPtr temp, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool before_temporal_temporal(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool before_tnumber_tbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool before_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool before_tpoint_stbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool before_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool before_tstzspan_temporal(IntPtr s, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool below_stbox_tpoint(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool below_tpoint_stbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool below_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool front_stbox_tpoint(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool front_tpoint_stbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool front_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_stbox_tpoint(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_tbox_tnumber(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_numspan_tnumber(IntPtr s, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_tnumber_numspan(IntPtr temp, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_tnumber_tbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_tpoint_stbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool left_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overabove_stbox_tpoint(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overabove_tpoint_stbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overabove_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overafter_stbox_tpoint(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overafter_tbox_tnumber(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overafter_temporal_tstzspan(IntPtr temp, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overafter_temporal_temporal(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overafter_tnumber_tbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overafter_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overafter_tpoint_stbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overafter_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overafter_tstzspan_temporal(IntPtr s, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overback_stbox_tpoint(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overback_tpoint_stbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overback_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overbefore_stbox_tpoint(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overbefore_tbox_tnumber(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overbefore_temporal_tstzspan(IntPtr temp, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overbefore_temporal_temporal(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overbefore_tnumber_tbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overbefore_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overbefore_tpoint_stbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overbefore_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overbefore_tstzspan_temporal(IntPtr s, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overbelow_stbox_tpoint(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overbelow_tpoint_stbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overbelow_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overfront_stbox_tpoint(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overfront_tpoint_stbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overfront_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_numspan_tnumber(IntPtr s, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_stbox_tpoint(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_tbox_tnumber(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_tnumber_numspan(IntPtr temp, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_tnumber_tbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_tpoint_stbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overleft_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_numspan_tnumber(IntPtr s, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_stbox_tpoint(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_tbox_tnumber(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_tnumber_numspan(IntPtr temp, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_tnumber_tbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_tpoint_stbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool overright_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_numspan_tnumber(IntPtr s, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_stbox_tpoint(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_tbox_tnumber(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_tnumber_numspan(IntPtr temp, IntPtr s);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_tnumber_tbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_tpoint_stbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool right_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tand_bool_tbool(bool b, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tand_tbool_bool(IntPtr temp, bool b);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tand_tbool_tbool(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tbool_when_true(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tnot_tbool(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tor_bool_tbool(bool b, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tor_tbool_bool(IntPtr temp, bool b);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tor_tbool_tbool(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr add_float_tfloat(double d, IntPtr tnumber);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr add_int_tint(int i, IntPtr tnumber);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr add_tfloat_float(IntPtr tnumber, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr add_tint_int(IntPtr tnumber, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr add_tnumber_tnumber(IntPtr tnumber1, IntPtr tnumber2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr div_float_tfloat(double d, IntPtr tnumber);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr div_int_tint(int i, IntPtr tnumber);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr div_tfloat_float(IntPtr tnumber, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr div_tint_int(IntPtr tnumber, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr div_tnumber_tnumber(IntPtr tnumber1, IntPtr tnumber2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double float_degrees(double value, bool normalize);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr mult_float_tfloat(double d, IntPtr tnumber);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr mult_int_tint(int i, IntPtr tnumber);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr mult_tfloat_float(IntPtr tnumber, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr mult_tint_int(IntPtr tnumber, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr mult_tnumber_tnumber(IntPtr tnumber1, IntPtr tnumber2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr sub_float_tfloat(double d, IntPtr tnumber);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr sub_int_tint(int i, IntPtr tnumber);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr sub_tfloat_float(IntPtr tnumber, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr sub_tint_int(IntPtr tnumber, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr sub_tnumber_tnumber(IntPtr tnumber1, IntPtr tnumber2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tfloat_round(IntPtr temp, int maxdd);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tfloatarr_round(IntPtr temp, int count, int maxdd);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tfloat_degrees(IntPtr temp, bool normalize);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tfloat_derivative(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tfloat_radians(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tnumber_abs(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tnumber_angular_difference(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tnumber_delta_value(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr textcat_text_ttext(IntPtr txt, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr textcat_ttext_text(IntPtr temp, IntPtr txt);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr textcat_ttext_ttext(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ttext_upper(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ttext_lower(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr distance_tfloat_float(IntPtr temp, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr distance_tint_int(IntPtr temp, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr distance_tnumber_tnumber(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr distance_tpoint_point(IntPtr temp, IntPtr gs);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr distance_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double nad_stbox_geo(IntPtr box, IntPtr gs);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double nad_stbox_stbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double nad_tbox_tbox(IntPtr box1, IntPtr box2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double nad_tfloat_float(IntPtr temp, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double nad_tfloat_tfloat(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int nad_tint_int(IntPtr temp, int i);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int nad_tint_tint(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double nad_tnumber_tbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double nad_tpoint_geo(IntPtr temp, IntPtr gs);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double nad_tpoint_stbox(IntPtr temp, IntPtr box);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double nad_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr nai_tpoint_geo(IntPtr temp, IntPtr gs);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr nai_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool shortestline_tpoint_geo(IntPtr temp, IntPtr gs, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool shortestline_tpoint_tpoint(IntPtr temp1, IntPtr temp2, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool bearing_point_point(IntPtr gs1, IntPtr gs2, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr bearing_tpoint_point(IntPtr temp, IntPtr gs, bool invert);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr bearing_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_angular_difference(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_azimuth(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_convex_hull(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_cumulative_length(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tpoint_direction(IntPtr temp, IntPtr result);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_get_x(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_get_y(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_get_z(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool tpoint_is_simple(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double tpoint_length(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_speed(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int tpoint_srid(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_stboxes(IntPtr temp, IntPtr count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_trajectory(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr geo_expand_space(IntPtr gs, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr geomeas_to_tpoint(IntPtr gs);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tgeogpoint_to_tgeompoint(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tgeompoint_to_tgeogpoint(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_expand_space(IntPtr temp, double d);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_make_simple(IntPtr temp, IntPtr count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_round(IntPtr temp, int maxdd);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpointarr_round(IntPtr temp, int count, int maxdd);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_set_srid(IntPtr temp, int srid);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int econtains_geo_tpoint(IntPtr gs, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int edisjoint_tpoint_geo(IntPtr temp, IntPtr gs);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int edisjoint_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int edwithin_tpoint_geo(IntPtr temp, IntPtr gs, double dist);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int edwithin_tpoint_tpoint(IntPtr temp1, IntPtr temp2, double dist);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int eintersects_tpoint_geo(IntPtr temp, IntPtr gs);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int eintersects_tpoint_tpoint(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int etouches_tpoint_geo(IntPtr temp, IntPtr gs);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tcontains_geo_tpoint(IntPtr gs, IntPtr temp, bool restr, bool atvalue);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tdisjoint_tpoint_geo(IntPtr temp, IntPtr gs, bool restr, bool atvalue);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tdwithin_tpoint_geo(IntPtr temp, IntPtr gs, double dist, bool restr, bool atvalue);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tdwithin_tpoint_tpoint(IntPtr temp1, IntPtr temp2, double dist, bool restr, bool atvalue);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tintersects_tpoint_geo(IntPtr temp, IntPtr gs, bool restr, bool atvalue);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ttouches_tpoint_geo(IntPtr temp, IntPtr gs, bool restr, bool atvalue);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tbool_tand_transfn(IntPtr state, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tbool_tor_transfn(IntPtr state, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_extent_transfn(IntPtr s, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_tagg_finalfn(IntPtr state);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_tcount_transfn(IntPtr state, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tfloat_tmax_transfn(IntPtr state, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tfloat_tmin_transfn(IntPtr state, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tfloat_tsum_transfn(IntPtr state, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tint_tmax_transfn(IntPtr state, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tint_tmin_transfn(IntPtr state, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tint_tsum_transfn(IntPtr state, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tnumber_extent_transfn(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double tnumber_integral(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tnumber_tavg_finalfn(IntPtr state);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tnumber_tavg_transfn(IntPtr state, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double tnumber_twavg(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_extent_transfn(IntPtr box, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_tcentroid_finalfn(IntPtr state);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_tcentroid_transfn(IntPtr state, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_twcentroid(IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ttext_tmax_transfn(IntPtr state, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ttext_tmin_transfn(IntPtr state, IntPtr temp);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_tprecision(IntPtr temp, IntPtr duration, DateTimeOffset origin);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_tsample(IntPtr temp, IntPtr duration, DateTimeOffset origin);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double temporal_dyntimewarp_distance(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_dyntimewarp_path(IntPtr temp1, IntPtr temp2, IntPtr count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double temporal_frechet_distance(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_frechet_path(IntPtr temp1, IntPtr temp2, IntPtr count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double temporal_hausdorff_distance(IntPtr temp1, IntPtr temp2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double float_bucket(double value, double size, double origin);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr floatspan_bucket_list(IntPtr bounds, double size, double origin, IntPtr count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int int_bucket(int value, int size, int origin);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr intspan_bucket_list(IntPtr bounds, int size, int origin, IntPtr count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tstzspan_bucket_list(IntPtr bounds, IntPtr duration, DateTimeOffset origin, IntPtr count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr stbox_tile(IntPtr point, DateTimeOffset t, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, DateTimeOffset torigin, bool hast);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr stbox_tile_list(IntPtr bounds, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, DateTimeOffset torigin, IntPtr count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tintbox_tile_list(IntPtr box, int xsize, IntPtr duration, int xorigin, DateTimeOffset torigin, IntPtr count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tfloatbox_tile_list(IntPtr box, double xsize, IntPtr duration, double xorigin, DateTimeOffset torigin, IntPtr count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr temporal_time_split(IntPtr temp, IntPtr duration, DateTimeOffset torigin, IntPtr time_buckets, IntPtr count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tfloat_value_split(IntPtr temp, double size, double origin, IntPtr value_buckets, IntPtr count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tfloat_value_time_split(IntPtr temp, double size, IntPtr duration, double vorigin, DateTimeOffset torigin, IntPtr value_buckets, IntPtr time_buckets, IntPtr count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern DateTimeOffset timestamptz_bucket(DateTimeOffset timestamp, IntPtr duration, DateTimeOffset origin);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tint_value_split(IntPtr temp, int size, int origin, IntPtr value_buckets, IntPtr count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tint_value_time_split(IntPtr temp, int size, IntPtr duration, int vorigin, DateTimeOffset torigin, IntPtr value_buckets, IntPtr time_buckets, IntPtr count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_space_split(IntPtr temp, float xsize, float ysize, float zsize, IntPtr sorigin, bool bitmatrix, IntPtr count);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tpoint_space_time_split(IntPtr temp, float xsize, float ysize, float zsize, IntPtr duration, IntPtr sorigin, DateTimeOffset torigin, bool bitmatrix, IntPtr time_buckets, IntPtr count);
    }
}
