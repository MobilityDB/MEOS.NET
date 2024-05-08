using System.CodeDom.Compiler;
using MEOS.NET.Enums;

namespace MEOS.NET.Internal
{
    [GeneratedCode("MEOS.NET.Builder", "0.0.2")]
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

        public static void meos_initialize_timezone(string name)
            => SafeExecution(() => MEOSExternalFunctions.meos_initialize_timezone(name));

        public static void meos_initialize_error_handler(ErrorHandlingMethod err_handler)
            => SafeExecution(() => MEOSExternalFunctions.meos_initialize_error_handler(err_handler));

        public static void meos_finalize_timezone()
            => SafeExecution(() => MEOSExternalFunctions.meos_finalize_timezone());

        public static bool meos_set_datestyle(string newval, IntPtr extra)
            => SafeExecution<bool>(() => MEOSExternalFunctions.meos_set_datestyle(newval, extra));

        public static bool meos_set_intervalstyle(string newval, int extra)
            => SafeExecution<bool>(() => MEOSExternalFunctions.meos_set_intervalstyle(newval, extra));

        public static string meos_get_datestyle()
            => SafeExecution<string>(() => MEOSExternalFunctions.meos_get_datestyle());

        public static string meos_get_intervalstyle()
            => SafeExecution<string>(() => MEOSExternalFunctions.meos_get_intervalstyle());

        public static void meos_initialize(string tz_str, ErrorHandlingMethod err_handler)
            => SafeExecution(() => MEOSExternalFunctions.meos_initialize(tz_str, err_handler));

        public static void meos_finalize()
            => SafeExecution(() => MEOSExternalFunctions.meos_finalize());

        public static bool bool_in(string in_str)
            => SafeExecution<bool>(() => MEOSExternalFunctions.bool_in(in_str));

        public static string bool_out(bool b)
            => SafeExecution<string>(() => MEOSExternalFunctions.bool_out(b));

        public static IntPtr cstring2text(string cstring)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.cstring2text(cstring));

        public static long pg_date_in(string str)
            => SafeExecution<long>(() => MEOSExternalFunctions.pg_date_in(str));

        public static string pg_date_out(long d)
            => SafeExecution<string>(() => MEOSExternalFunctions.pg_date_out(d));

        public static IntPtr pg_date_mi(long d1, long d2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pg_date_mi(d1, d2));

        public static long pg_date_mi_int(long d, int days)
            => SafeExecution<long>(() => MEOSExternalFunctions.pg_date_mi_int(d, days));

        public static long pg_date_pl_int(long d, int days)
            => SafeExecution<long>(() => MEOSExternalFunctions.pg_date_pl_int(d, days));

        public static DateTimeOffset pg_date_timestamptz(long d)
            => SafeExecution<DateTimeOffset>(() => MEOSExternalFunctions.pg_date_timestamptz(d));

        public static int pg_interval_cmp(IntPtr interval1, IntPtr interval2)
            => SafeExecution<int>(() => MEOSExternalFunctions.pg_interval_cmp(interval1, interval2));

        public static IntPtr pg_interval_in(string str, int typmod)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pg_interval_in(str, typmod));

        public static IntPtr pg_interval_make(int years, int months, int weeks, int days, int hours, int mins, double secs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pg_interval_make(years, months, weeks, days, hours, mins, secs));

        public static IntPtr pg_interval_mul(IntPtr span, double factor)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pg_interval_mul(span, factor));

        public static string pg_interval_out(IntPtr span)
            => SafeExecution<string>(() => MEOSExternalFunctions.pg_interval_out(span));

        public static IntPtr pg_interval_to_char(IntPtr it, IntPtr fmt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pg_interval_to_char(it, fmt));

        public static IntPtr pg_interval_pl(IntPtr span1, IntPtr span2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pg_interval_pl(span1, span2));

        public static int pg_time_in(string str, int typmod)
            => SafeExecution<int>(() => MEOSExternalFunctions.pg_time_in(str, typmod));

        public static string pg_time_out(int time)
            => SafeExecution<string>(() => MEOSExternalFunctions.pg_time_out(time));

        public static DateTime pg_timestamp_in(string str, int typmod)
            => SafeExecution<DateTime>(() => MEOSExternalFunctions.pg_timestamp_in(str, typmod));

        public static IntPtr pg_timestamp_mi(DateTimeOffset dt1, DateTimeOffset dt2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pg_timestamp_mi(dt1, dt2));

        public static DateTimeOffset pg_timestamp_mi_interval(DateTimeOffset timestamp, IntPtr span)
            => SafeExecution<DateTimeOffset>(() => MEOSExternalFunctions.pg_timestamp_mi_interval(timestamp, span));

        public static string pg_timestamp_out(DateTime dt)
            => SafeExecution<string>(() => MEOSExternalFunctions.pg_timestamp_out(dt));

        public static DateTimeOffset pg_timestamp_pl_interval(DateTimeOffset timestamp, IntPtr span)
            => SafeExecution<DateTimeOffset>(() => MEOSExternalFunctions.pg_timestamp_pl_interval(timestamp, span));

        public static IntPtr pg_timestamp_to_char(DateTime dt, IntPtr fmt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pg_timestamp_to_char(dt, fmt));

        public static DateTimeOffset pg_timestamptz_in(string str, int typmod)
            => SafeExecution<DateTimeOffset>(() => MEOSExternalFunctions.pg_timestamptz_in(str, typmod));

        public static long pg_timestamptz_date(DateTimeOffset t)
            => SafeExecution<long>(() => MEOSExternalFunctions.pg_timestamptz_date(t));

        public static string pg_timestamptz_out(DateTimeOffset dt)
            => SafeExecution<string>(() => MEOSExternalFunctions.pg_timestamptz_out(dt));

        public static IntPtr pg_timestamptz_to_char(DateTimeOffset dt, IntPtr fmt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pg_timestamptz_to_char(dt, fmt));

        public static long pg_to_date(IntPtr date_txt, IntPtr fmt)
            => SafeExecution<long>(() => MEOSExternalFunctions.pg_to_date(date_txt, fmt));

        public static DateTimeOffset pg_to_timestamptz(IntPtr date_txt, IntPtr fmt)
            => SafeExecution<DateTimeOffset>(() => MEOSExternalFunctions.pg_to_timestamptz(date_txt, fmt));

        public static string text2cstring(IntPtr textptr)
            => SafeExecution<string>(() => MEOSExternalFunctions.text2cstring(textptr));

        public static string text_out(IntPtr txt)
            => SafeExecution<string>(() => MEOSExternalFunctions.text_out(txt));

        public static IntPtr geography_from_hexewkb(string wkt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geography_from_hexewkb(wkt));

        public static IntPtr geography_from_text(string wkt, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geography_from_text(wkt, srid));

        public static IntPtr geometry_from_hexewkb(string wkt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geometry_from_hexewkb(wkt));

        public static IntPtr geometry_from_text(string wkt, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geometry_from_text(wkt, srid));

        public static IntPtr gserialized_as_ewkb(IntPtr gs, string type)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.gserialized_as_ewkb(gs, type));

        public static string gserialized_as_ewkt(IntPtr gs, int precision)
            => SafeExecution<string>(() => MEOSExternalFunctions.gserialized_as_ewkt(gs, precision));

        public static string gserialized_as_geojson(IntPtr gs, int option, int precision, string srs)
            => SafeExecution<string>(() => MEOSExternalFunctions.gserialized_as_geojson(gs, option, precision, srs));

        public static string gserialized_as_hexewkb(IntPtr gs, string type)
            => SafeExecution<string>(() => MEOSExternalFunctions.gserialized_as_hexewkb(gs, type));

        public static string gserialized_as_text(IntPtr gs, int precision)
            => SafeExecution<string>(() => MEOSExternalFunctions.gserialized_as_text(gs, precision));

        public static IntPtr gserialized_from_ewkb(IntPtr bytea_wkb, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.gserialized_from_ewkb(bytea_wkb, srid));

        public static IntPtr gserialized_from_geojson(string geojson)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.gserialized_from_geojson(geojson));

        public static string gserialized_out(IntPtr gs)
            => SafeExecution<string>(() => MEOSExternalFunctions.gserialized_out(gs));

        public static IntPtr pgis_geography_in(string input, int geom_typmod)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pgis_geography_in(input, geom_typmod));

        public static IntPtr pgis_geometry_in(string input, int geom_typmod)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.pgis_geometry_in(input, geom_typmod));

        public static bool pgis_gserialized_same(IntPtr gs1, IntPtr gs2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.pgis_gserialized_same(gs1, gs2));

        public static IntPtr bigintset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintset_in(str));

        public static string bigintset_out(IntPtr set)
            => SafeExecution<string>(() => MEOSExternalFunctions.bigintset_out(set));

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

        public static IntPtr floatspan_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspan_in(str));

        public static string floatspan_out(IntPtr s, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.floatspan_out(s, maxdd));

        public static IntPtr floatspanset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspanset_in(str));

        public static string floatspanset_out(IntPtr ss, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.floatspanset_out(ss, maxdd));

        public static IntPtr geogset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geogset_in(str));

        public static IntPtr geomset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geomset_in(str));

        public static string geoset_as_ewkt(IntPtr set, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.geoset_as_ewkt(set, maxdd));

        public static string geoset_as_text(IntPtr set, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.geoset_as_text(set, maxdd));

        public static string geoset_out(IntPtr set, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.geoset_out(set, maxdd));

        public static IntPtr intset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intset_in(str));

        public static string intset_out(IntPtr set)
            => SafeExecution<string>(() => MEOSExternalFunctions.intset_out(set));

        public static IntPtr intspan_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intspan_in(str));

        public static string intspan_out(IntPtr s)
            => SafeExecution<string>(() => MEOSExternalFunctions.intspan_out(s));

        public static IntPtr intspanset_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intspanset_in(str));

        public static string intspanset_out(IntPtr ss)
            => SafeExecution<string>(() => MEOSExternalFunctions.intspanset_out(ss));

        public static string set_as_hexwkb(IntPtr s, byte variant, IntPtr size_out)
            => SafeExecution<string>(() => MEOSExternalFunctions.set_as_hexwkb(s, variant, size_out));

        public static IntPtr set_as_wkb(IntPtr s, byte variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_as_wkb(s, variant, size_out));

        public static IntPtr set_from_hexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_from_hexwkb(hexwkb));

        public static IntPtr set_from_wkb(IntPtr wkb, ulong size)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_from_wkb(wkb, size));

        public static string span_as_hexwkb(IntPtr s, byte variant, IntPtr size_out)
            => SafeExecution<string>(() => MEOSExternalFunctions.span_as_hexwkb(s, variant, size_out));

        public static IntPtr span_as_wkb(IntPtr s, byte variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.span_as_wkb(s, variant, size_out));

        public static IntPtr span_from_hexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.span_from_hexwkb(hexwkb));

        public static IntPtr span_from_wkb(IntPtr wkb, ulong size)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.span_from_wkb(wkb, size));

        public static string spanset_as_hexwkb(IntPtr ss, byte variant, IntPtr size_out)
            => SafeExecution<string>(() => MEOSExternalFunctions.spanset_as_hexwkb(ss, variant, size_out));

        public static IntPtr spanset_as_wkb(IntPtr ss, byte variant, IntPtr size_out)
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

        public static IntPtr bigintspan_make(double lower, double upper, bool lower_inc, bool upper_inc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintspan_make(lower, upper, lower_inc, upper_inc));

        public static IntPtr dateset_make(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.dateset_make(values, count));

        public static IntPtr datespan_make(long lower, long upper, bool lower_inc, bool upper_inc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.datespan_make(lower, upper, lower_inc, upper_inc));

        public static IntPtr floatset_make(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatset_make(values, count));

        public static IntPtr floatspan_make(double lower, double upper, bool lower_inc, bool upper_inc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspan_make(lower, upper, lower_inc, upper_inc));

        public static IntPtr geoset_make(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geoset_make(values, count));

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

        public static IntPtr spanset_make(IntPtr spans, int count, bool normalize)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_make(spans, count, normalize));

        public static IntPtr textset_make(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.textset_make(values, count));

        public static IntPtr tstzset_make(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzset_make(values, count));

        public static IntPtr tstzspan_make(DateTimeOffset lower, DateTimeOffset upper, bool lower_inc, bool upper_inc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspan_make(lower, upper, lower_inc, upper_inc));

        public static IntPtr bigint_to_set(double i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigint_to_set(i));

        public static IntPtr bigint_to_span(int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigint_to_span(i));

        public static IntPtr bigint_to_spanset(int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigint_to_spanset(i));

        public static IntPtr date_to_set(long d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.date_to_set(d));

        public static IntPtr date_to_span(long d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.date_to_span(d));

        public static IntPtr date_to_spanset(long d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.date_to_spanset(d));

        public static IntPtr date_to_tstzspan(long d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.date_to_tstzspan(d));

        public static IntPtr float_to_set(double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.float_to_set(d));

        public static IntPtr float_to_span(double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.float_to_span(d));

        public static IntPtr float_to_spanset(double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.float_to_spanset(d));

        public static IntPtr geo_to_set(IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_to_set(gs));

        public static IntPtr int_to_set(int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.int_to_set(i));

        public static IntPtr int_to_span(int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.int_to_span(i));

        public static IntPtr int_to_spanset(int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.int_to_spanset(i));

        public static IntPtr set_to_spanset(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_to_spanset(s));

        public static IntPtr span_to_spanset(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.span_to_spanset(s));

        public static IntPtr text_to_set(IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.text_to_set(txt));

        public static IntPtr timestamptz_to_set(DateTimeOffset t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.timestamptz_to_set(t));

        public static IntPtr timestamptz_to_span(DateTimeOffset t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.timestamptz_to_span(t));

        public static IntPtr timestamptz_to_spanset(DateTimeOffset t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.timestamptz_to_spanset(t));

        public static double bigintset_end_value(IntPtr s)
            => SafeExecution<double>(() => MEOSExternalFunctions.bigintset_end_value(s));

        public static double bigintset_start_value(IntPtr s)
            => SafeExecution<double>(() => MEOSExternalFunctions.bigintset_start_value(s));

        public static bool bigintset_value_n(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.bigintset_value_n(s, n, result));

        public static IntPtr bigintset_values(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintset_values(s));

        public static double bigintspan_lower(IntPtr s)
            => SafeExecution<double>(() => MEOSExternalFunctions.bigintspan_lower(s));

        public static double bigintspan_upper(IntPtr s)
            => SafeExecution<double>(() => MEOSExternalFunctions.bigintspan_upper(s));

        public static double bigintspanset_lower(IntPtr ss)
            => SafeExecution<double>(() => MEOSExternalFunctions.bigintspanset_lower(ss));

        public static double bigintspanset_upper(IntPtr ss)
            => SafeExecution<double>(() => MEOSExternalFunctions.bigintspanset_upper(ss));

        public static long dateset_end_value(IntPtr s)
            => SafeExecution<long>(() => MEOSExternalFunctions.dateset_end_value(s));

        public static long dateset_start_value(IntPtr s)
            => SafeExecution<long>(() => MEOSExternalFunctions.dateset_start_value(s));

        public static bool dateset_value_n(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.dateset_value_n(s, n, result));

        public static IntPtr dateset_values(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.dateset_values(s));

        public static IntPtr datespan_duration(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.datespan_duration(s));

        public static IntPtr datespanset_duration(IntPtr ss, bool boundspan)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.datespanset_duration(ss, boundspan));

        public static long datespanset_end_date(IntPtr ss)
            => SafeExecution<long>(() => MEOSExternalFunctions.datespanset_end_date(ss));

        public static int datespanset_num_dates(IntPtr ss)
            => SafeExecution<int>(() => MEOSExternalFunctions.datespanset_num_dates(ss));

        public static long datespanset_start_date(IntPtr ss)
            => SafeExecution<long>(() => MEOSExternalFunctions.datespanset_start_date(ss));

        public static bool datespanset_date_n(IntPtr ss, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.datespanset_date_n(ss, n, result));

        public static IntPtr datespanset_dates(IntPtr ss, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.datespanset_dates(ss, count));

        public static double floatset_end_value(IntPtr s)
            => SafeExecution<double>(() => MEOSExternalFunctions.floatset_end_value(s));

        public static double floatset_start_value(IntPtr s)
            => SafeExecution<double>(() => MEOSExternalFunctions.floatset_start_value(s));

        public static bool floatset_value_n(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.floatset_value_n(s, n, result));

        public static IntPtr floatset_values(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatset_values(s));

        public static double floatspan_lower(IntPtr s)
            => SafeExecution<double>(() => MEOSExternalFunctions.floatspan_lower(s));

        public static double floatspan_upper(IntPtr s)
            => SafeExecution<double>(() => MEOSExternalFunctions.floatspan_upper(s));

        public static double floatspanset_lower(IntPtr ss)
            => SafeExecution<double>(() => MEOSExternalFunctions.floatspanset_lower(ss));

        public static double floatspanset_upper(IntPtr ss)
            => SafeExecution<double>(() => MEOSExternalFunctions.floatspanset_upper(ss));

        public static IntPtr geoset_end_value(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geoset_end_value(s));

        public static int geoset_srid(IntPtr s)
            => SafeExecution<int>(() => MEOSExternalFunctions.geoset_srid(s));

        public static IntPtr geoset_set_srid(IntPtr s, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geoset_set_srid(s, srid));

        public static IntPtr geoset_start_value(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geoset_start_value(s));

        public static bool geoset_value_n(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.geoset_value_n(s, n, result));

        public static IntPtr geoset_values(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geoset_values(s));

        public static int intset_end_value(IntPtr s)
            => SafeExecution<int>(() => MEOSExternalFunctions.intset_end_value(s));

        public static int intset_start_value(IntPtr s)
            => SafeExecution<int>(() => MEOSExternalFunctions.intset_start_value(s));

        public static bool intset_value_n(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.intset_value_n(s, n, result));

        public static IntPtr intset_values(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intset_values(s));

        public static int intspan_lower(IntPtr s)
            => SafeExecution<int>(() => MEOSExternalFunctions.intspan_lower(s));

        public static int intspan_upper(IntPtr s)
            => SafeExecution<int>(() => MEOSExternalFunctions.intspan_upper(s));

        public static int intspanset_lower(IntPtr ss)
            => SafeExecution<int>(() => MEOSExternalFunctions.intspanset_lower(ss));

        public static int intspanset_upper(IntPtr ss)
            => SafeExecution<int>(() => MEOSExternalFunctions.intspanset_upper(ss));

        public static uint set_hash(IntPtr s)
            => SafeExecution<uint>(() => MEOSExternalFunctions.set_hash(s));

        public static ulong set_hash_extended(IntPtr s, ulong seed)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.set_hash_extended(s, seed));

        public static int set_num_values(IntPtr s)
            => SafeExecution<int>(() => MEOSExternalFunctions.set_num_values(s));

        public static IntPtr set_to_span(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_to_span(s));

        public static uint span_hash(IntPtr s)
            => SafeExecution<uint>(() => MEOSExternalFunctions.span_hash(s));

        public static ulong span_hash_extended(IntPtr s, ulong seed)
            => SafeExecution<ulong>(() => MEOSExternalFunctions.span_hash_extended(s, seed));

        public static bool span_lower_inc(IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.span_lower_inc(s));

        public static bool span_upper_inc(IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.span_upper_inc(s));

        public static double span_width(IntPtr s)
            => SafeExecution<double>(() => MEOSExternalFunctions.span_width(s));

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

        public static IntPtr spanset_spans(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_spans(ss));

        public static IntPtr spanset_start_span(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_start_span(ss));

        public static bool spanset_upper_inc(IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.spanset_upper_inc(ss));

        public static double spanset_width(IntPtr ss, bool boundspan)
            => SafeExecution<double>(() => MEOSExternalFunctions.spanset_width(ss, boundspan));

        public static IntPtr spatialset_to_stbox(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spatialset_to_stbox(s));

        public static IntPtr textset_end_value(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.textset_end_value(s));

        public static IntPtr textset_start_value(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.textset_start_value(s));

        public static bool textset_value_n(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.textset_value_n(s, n, result));

        public static IntPtr textset_values(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.textset_values(s));

        public static DateTimeOffset tstzset_end_value(IntPtr s)
            => SafeExecution<DateTimeOffset>(() => MEOSExternalFunctions.tstzset_end_value(s));

        public static DateTimeOffset tstzset_start_value(IntPtr s)
            => SafeExecution<DateTimeOffset>(() => MEOSExternalFunctions.tstzset_start_value(s));

        public static bool tstzset_value_n(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tstzset_value_n(s, n, result));

        public static IntPtr tstzset_values(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzset_values(s));

        public static IntPtr tstzspan_duration(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspan_duration(s));

        public static DateTimeOffset tstzspan_lower(IntPtr s)
            => SafeExecution<DateTimeOffset>(() => MEOSExternalFunctions.tstzspan_lower(s));

        public static DateTimeOffset tstzspan_upper(IntPtr s)
            => SafeExecution<DateTimeOffset>(() => MEOSExternalFunctions.tstzspan_upper(s));

        public static IntPtr tstzspanset_duration(IntPtr ss, bool boundspan)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspanset_duration(ss, boundspan));

        public static DateTimeOffset tstzspanset_end_timestamptz(IntPtr ss)
            => SafeExecution<DateTimeOffset>(() => MEOSExternalFunctions.tstzspanset_end_timestamptz(ss));

        public static DateTimeOffset tstzspanset_lower(IntPtr ss)
            => SafeExecution<DateTimeOffset>(() => MEOSExternalFunctions.tstzspanset_lower(ss));

        public static int tstzspanset_num_timestamps(IntPtr ss)
            => SafeExecution<int>(() => MEOSExternalFunctions.tstzspanset_num_timestamps(ss));

        public static DateTimeOffset tstzspanset_start_timestamptz(IntPtr ss)
            => SafeExecution<DateTimeOffset>(() => MEOSExternalFunctions.tstzspanset_start_timestamptz(ss));

        public static bool tstzspanset_timestamptz_n(IntPtr ss, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tstzspanset_timestamptz_n(ss, n, result));

        public static IntPtr tstzspanset_timestamps(IntPtr ss, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspanset_timestamps(ss, count));

        public static DateTimeOffset tstzspanset_upper(IntPtr ss)
            => SafeExecution<DateTimeOffset>(() => MEOSExternalFunctions.tstzspanset_upper(ss));

        public static IntPtr bigintset_shift_scale(IntPtr s, double shift, double width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintset_shift_scale(s, shift, width, hasshift, haswidth));

        public static IntPtr bigintspan_shift_scale(IntPtr s, double shift, double width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintspan_shift_scale(s, shift, width, hasshift, haswidth));

        public static IntPtr bigintspanset_shift_scale(IntPtr ss, double shift, double width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigintspanset_shift_scale(ss, shift, width, hasshift, haswidth));

        public static IntPtr dateset_shift_scale(IntPtr s, int shift, int width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.dateset_shift_scale(s, shift, width, hasshift, haswidth));

        public static IntPtr dateset_to_tstzset(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.dateset_to_tstzset(s));

        public static IntPtr datespan_shift_scale(IntPtr s, int shift, int width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.datespan_shift_scale(s, shift, width, hasshift, haswidth));

        public static IntPtr datespan_to_tstzspan(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.datespan_to_tstzspan(s));

        public static IntPtr datespanset_shift_scale(IntPtr ss, int shift, int width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.datespanset_shift_scale(ss, shift, width, hasshift, haswidth));

        public static IntPtr datespanset_to_tstzspanset(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.datespanset_to_tstzspanset(ss));

        public static IntPtr floatset_round(IntPtr s, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatset_round(s, maxdd));

        public static IntPtr floatset_shift_scale(IntPtr s, double shift, double width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatset_shift_scale(s, shift, width, hasshift, haswidth));

        public static IntPtr floatset_to_intset(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatset_to_intset(s));

        public static IntPtr floatspan_round(IntPtr s, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspan_round(s, maxdd));

        public static IntPtr floatspan_shift_scale(IntPtr s, double shift, double width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspan_shift_scale(s, shift, width, hasshift, haswidth));

        public static IntPtr floatspan_to_intspan(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspan_to_intspan(s));

        public static IntPtr floatspanset_to_intspanset(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspanset_to_intspanset(ss));

        public static IntPtr floatspanset_round(IntPtr ss, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspanset_round(ss, maxdd));

        public static IntPtr floatspanset_shift_scale(IntPtr ss, double shift, double width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspanset_shift_scale(ss, shift, width, hasshift, haswidth));

        public static IntPtr geoset_round(IntPtr s, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geoset_round(s, maxdd));

        public static IntPtr intset_shift_scale(IntPtr s, int shift, int width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intset_shift_scale(s, shift, width, hasshift, haswidth));

        public static IntPtr intset_to_floatset(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intset_to_floatset(s));

        public static IntPtr intspan_shift_scale(IntPtr s, int shift, int width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intspan_shift_scale(s, shift, width, hasshift, haswidth));

        public static IntPtr intspan_to_floatspan(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intspan_to_floatspan(s));

        public static IntPtr intspanset_to_floatspanset(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intspanset_to_floatspanset(ss));

        public static IntPtr intspanset_shift_scale(IntPtr ss, int shift, int width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intspanset_shift_scale(ss, shift, width, hasshift, haswidth));

        public static IntPtr textset_lower(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.textset_lower(s));

        public static IntPtr textset_upper(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.textset_upper(s));

        public static DateTimeOffset timestamptz_tprecision(DateTimeOffset t, IntPtr duration, DateTimeOffset torigin)
            => SafeExecution<DateTimeOffset>(() => MEOSExternalFunctions.timestamptz_tprecision(t, duration, torigin));

        public static IntPtr tstzset_shift_scale(IntPtr s, IntPtr shift, IntPtr duration)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzset_shift_scale(s, shift, duration));

        public static IntPtr tstzspan_shift_scale(IntPtr s, IntPtr shift, IntPtr duration)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspan_shift_scale(s, shift, duration));

        public static IntPtr tstzspan_tprecision(IntPtr s, IntPtr duration, DateTimeOffset torigin)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspan_tprecision(s, duration, torigin));

        public static IntPtr tstzset_to_dateset(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzset_to_dateset(s));

        public static IntPtr tstzspan_to_datespan(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspan_to_datespan(s));

        public static IntPtr tstzspanset_to_datespanset(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspanset_to_datespanset(ss));

        public static IntPtr tstzspanset_shift_scale(IntPtr ss, IntPtr shift, IntPtr duration)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspanset_shift_scale(ss, shift, duration));

        public static IntPtr tstzspanset_tprecision(IntPtr ss, IntPtr duration, DateTimeOffset torigin)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspanset_tprecision(ss, duration, torigin));

        public static IntPtr intersection_set_bigint(IntPtr s, double i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_set_bigint(s, i));

        public static IntPtr intersection_set_date(IntPtr s, long d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_set_date(s, d));

        public static IntPtr intersection_set_float(IntPtr s, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_set_float(s, d));

        public static IntPtr intersection_set_geo(IntPtr s, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_set_geo(s, gs));

        public static IntPtr intersection_set_int(IntPtr s, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_set_int(s, i));

        public static IntPtr intersection_set_set(IntPtr s1, IntPtr s2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_set_set(s1, s2));

        public static IntPtr intersection_set_text(IntPtr s, IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_set_text(s, txt));

        public static IntPtr intersection_set_timestamptz(IntPtr s, DateTimeOffset t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_set_timestamptz(s, t));

        public static IntPtr intersection_span_bigint(IntPtr s, double i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_span_bigint(s, i));

        public static IntPtr intersection_span_date(IntPtr s, long d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_span_date(s, d));

        public static IntPtr intersection_span_float(IntPtr s, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_span_float(s, d));

        public static IntPtr intersection_span_int(IntPtr s, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_span_int(s, i));

        public static IntPtr intersection_span_timestamptz(IntPtr s, DateTimeOffset t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_span_timestamptz(s, t));

        public static IntPtr intersection_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_span_span(s1, s2));

        public static IntPtr intersection_spanset_bigint(IntPtr ss, double i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_spanset_bigint(ss, i));

        public static IntPtr intersection_spanset_date(IntPtr ss, long d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_spanset_date(ss, d));

        public static IntPtr intersection_spanset_float(IntPtr ss, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_spanset_float(ss, d));

        public static IntPtr intersection_spanset_int(IntPtr ss, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_spanset_int(ss, i));

        public static IntPtr intersection_spanset_span(IntPtr ss, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_spanset_span(ss, s));

        public static IntPtr intersection_spanset_spanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_spanset_spanset(ss1, ss2));

        public static IntPtr intersection_spanset_timestamptz(IntPtr ss, DateTimeOffset t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_spanset_timestamptz(ss, t));

        public static IntPtr minus_bigint_set(double i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_bigint_set(i, s));

        public static IntPtr minus_bigint_span(double i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_bigint_span(i, s));

        public static IntPtr minus_bigint_spanset(double i, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_bigint_spanset(i, ss));

        public static IntPtr minus_date_set(long d, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_date_set(d, s));

        public static IntPtr minus_date_span(long d, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_date_span(d, s));

        public static IntPtr minus_date_spanset(long d, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_date_spanset(d, ss));

        public static IntPtr minus_float_set(double d, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_float_set(d, s));

        public static IntPtr minus_float_span(double d, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_float_span(d, s));

        public static IntPtr minus_float_spanset(double d, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_float_spanset(d, ss));

        public static IntPtr minus_geo_set(IntPtr gs, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_geo_set(gs, s));

        public static IntPtr minus_int_set(int i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_int_set(i, s));

        public static IntPtr minus_int_span(int i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_int_span(i, s));

        public static IntPtr minus_int_spanset(int i, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_int_spanset(i, ss));

        public static IntPtr minus_set_bigint(IntPtr s, double i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_set_bigint(s, i));

        public static IntPtr minus_set_date(IntPtr s, long d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_set_date(s, d));

        public static IntPtr minus_set_float(IntPtr s, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_set_float(s, d));

        public static IntPtr minus_set_geo(IntPtr s, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_set_geo(s, gs));

        public static IntPtr minus_set_int(IntPtr s, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_set_int(s, i));

        public static IntPtr minus_set_set(IntPtr s1, IntPtr s2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_set_set(s1, s2));

        public static IntPtr minus_set_text(IntPtr s, IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_set_text(s, txt));

        public static IntPtr minus_set_timestamptz(IntPtr s, DateTimeOffset t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_set_timestamptz(s, t));

        public static IntPtr minus_span_bigint(IntPtr s, double i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_span_bigint(s, i));

        public static IntPtr minus_span_date(IntPtr s, long d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_span_date(s, d));

        public static IntPtr minus_span_float(IntPtr s, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_span_float(s, d));

        public static IntPtr minus_span_int(IntPtr s, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_span_int(s, i));

        public static IntPtr minus_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_span_span(s1, s2));

        public static IntPtr minus_span_spanset(IntPtr s, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_span_spanset(s, ss));

        public static IntPtr minus_span_timestamptz(IntPtr s, DateTimeOffset t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_span_timestamptz(s, t));

        public static IntPtr minus_spanset_bigint(IntPtr ss, double i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_spanset_bigint(ss, i));

        public static IntPtr minus_spanset_date(IntPtr ss, long d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_spanset_date(ss, d));

        public static IntPtr minus_spanset_float(IntPtr ss, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_spanset_float(ss, d));

        public static IntPtr minus_spanset_int(IntPtr ss, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_spanset_int(ss, i));

        public static IntPtr minus_spanset_span(IntPtr ss, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_spanset_span(ss, s));

        public static IntPtr minus_spanset_spanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_spanset_spanset(ss1, ss2));

        public static IntPtr minus_spanset_timestamptz(IntPtr ss, DateTimeOffset t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_spanset_timestamptz(ss, t));

        public static IntPtr minus_text_set(IntPtr txt, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_text_set(txt, s));

        public static IntPtr minus_timestamptz_span(DateTimeOffset t, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_timestamptz_span(t, s));

        public static IntPtr minus_timestamptz_spanset(DateTimeOffset t, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_timestamptz_spanset(t, ss));

        public static IntPtr minus_timestamptz_set(DateTimeOffset t, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.minus_timestamptz_set(t, s));

        public static IntPtr super_union_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.super_union_span_span(s1, s2));

        public static IntPtr union_set_bigint(IntPtr s, double i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_set_bigint(s, i));

        public static IntPtr union_set_date(IntPtr s, long d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_set_date(s, d));

        public static IntPtr union_set_float(IntPtr s, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_set_float(s, d));

        public static IntPtr union_set_geo(IntPtr s, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_set_geo(s, gs));

        public static IntPtr union_set_int(IntPtr s, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_set_int(s, i));

        public static IntPtr union_set_set(IntPtr s1, IntPtr s2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_set_set(s1, s2));

        public static IntPtr union_set_text(IntPtr s, IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_set_text(s, txt));

        public static IntPtr union_set_timestamptz(IntPtr s, DateTimeOffset t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_set_timestamptz(s, t));

        public static IntPtr union_span_bigint(IntPtr s, double i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_span_bigint(s, i));

        public static IntPtr union_span_date(IntPtr s, long d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_span_date(s, d));

        public static IntPtr union_span_float(IntPtr s, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_span_float(s, d));

        public static IntPtr union_span_int(IntPtr s, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_span_int(s, i));

        public static IntPtr union_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_span_span(s1, s2));

        public static IntPtr union_span_timestamptz(IntPtr s, DateTimeOffset t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_span_timestamptz(s, t));

        public static IntPtr union_spanset_bigint(IntPtr ss, double i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_spanset_bigint(ss, i));

        public static IntPtr union_spanset_date(IntPtr ss, long d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_spanset_date(ss, d));

        public static IntPtr union_spanset_float(IntPtr ss, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_spanset_float(ss, d));

        public static IntPtr union_spanset_int(IntPtr ss, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_spanset_int(ss, i));

        public static IntPtr union_spanset_span(IntPtr ss, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_spanset_span(ss, s));

        public static IntPtr union_spanset_spanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_spanset_spanset(ss1, ss2));

        public static IntPtr union_spanset_timestamptz(IntPtr ss, DateTimeOffset t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_spanset_timestamptz(ss, t));

        public static bool adjacent_span_bigint(IntPtr s, double i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_span_bigint(s, i));

        public static bool adjacent_span_date(IntPtr s, long d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_span_date(s, d));

        public static bool adjacent_span_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_span_float(s, d));

        public static bool adjacent_span_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_span_int(s, i));

        public static bool adjacent_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_span_span(s1, s2));

        public static bool adjacent_span_timestamptz(IntPtr s, DateTimeOffset t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_span_timestamptz(s, t));

        public static bool adjacent_spanset_bigint(IntPtr ss, double i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_spanset_bigint(ss, i));

        public static bool adjacent_spanset_date(IntPtr ss, long d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_spanset_date(ss, d));

        public static bool adjacent_spanset_float(IntPtr ss, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_spanset_float(ss, d));

        public static bool adjacent_spanset_int(IntPtr ss, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_spanset_int(ss, i));

        public static bool adjacent_spanset_timestamptz(IntPtr ss, DateTimeOffset t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_spanset_timestamptz(ss, t));

        public static bool adjacent_spanset_span(IntPtr ss, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_spanset_span(ss, s));

        public static bool adjacent_spanset_spanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_spanset_spanset(ss1, ss2));

        public static bool contained_bigint_set(double i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_bigint_set(i, s));

        public static bool contained_bigint_span(double i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_bigint_span(i, s));

        public static bool contained_bigint_spanset(double i, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_bigint_spanset(i, ss));

        public static bool contained_date_set(long d, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_date_set(d, s));

        public static bool contained_date_span(long d, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_date_span(d, s));

        public static bool contained_date_spanset(long d, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_date_spanset(d, ss));

        public static bool contained_float_set(double d, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_float_set(d, s));

        public static bool contained_float_span(double d, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_float_span(d, s));

        public static bool contained_float_spanset(double d, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_float_spanset(d, ss));

        public static bool contained_geo_set(IntPtr gs, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_geo_set(gs, s));

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

        public static bool contained_timestamptz_set(DateTimeOffset t, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_timestamptz_set(t, s));

        public static bool contained_timestamptz_span(DateTimeOffset t, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_timestamptz_span(t, s));

        public static bool contained_timestamptz_spanset(DateTimeOffset t, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_timestamptz_spanset(t, ss));

        public static bool contains_set_bigint(IntPtr s, double i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_set_bigint(s, i));

        public static bool contains_set_date(IntPtr s, long d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_set_date(s, d));

        public static bool contains_set_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_set_float(s, d));

        public static bool contains_set_geo(IntPtr s, IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_set_geo(s, gs));

        public static bool contains_set_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_set_int(s, i));

        public static bool contains_set_set(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_set_set(s1, s2));

        public static bool contains_set_text(IntPtr s, IntPtr t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_set_text(s, t));

        public static bool contains_set_timestamptz(IntPtr s, DateTimeOffset t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_set_timestamptz(s, t));

        public static bool contains_span_bigint(IntPtr s, double i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_span_bigint(s, i));

        public static bool contains_span_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_span_float(s, d));

        public static bool contains_span_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_span_int(s, i));

        public static bool contains_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_span_span(s1, s2));

        public static bool contains_span_spanset(IntPtr s, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_span_spanset(s, ss));

        public static bool contains_span_timestamptz(IntPtr s, DateTimeOffset t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_span_timestamptz(s, t));

        public static bool contains_spanset_bigint(IntPtr ss, double i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_spanset_bigint(ss, i));

        public static bool contains_spanset_float(IntPtr ss, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_spanset_float(ss, d));

        public static bool contains_spanset_int(IntPtr ss, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_spanset_int(ss, i));

        public static bool contains_spanset_span(IntPtr ss, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_spanset_span(ss, s));

        public static bool contains_spanset_spanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_spanset_spanset(ss1, ss2));

        public static bool contains_spanset_timestamptz(IntPtr ss, DateTimeOffset t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_spanset_timestamptz(ss, t));

        public static bool overlaps_set_set(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_set_set(s1, s2));

        public static bool overlaps_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_span_span(s1, s2));

        public static bool overlaps_spanset_span(IntPtr ss, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_spanset_span(ss, s));

        public static bool overlaps_spanset_spanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_spanset_spanset(ss1, ss2));

        public static bool after_date_set(long d, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_date_set(d, s));

        public static bool after_date_span(long d, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_date_span(d, s));

        public static bool after_date_spanset(long d, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_date_spanset(d, ss));

        public static bool after_set_date(IntPtr s, long d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_set_date(s, d));

        public static bool after_set_timestamptz(IntPtr s, DateTimeOffset t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_set_timestamptz(s, t));

        public static bool after_span_date(IntPtr s, long d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_span_date(s, d));

        public static bool after_span_timestamptz(IntPtr s, DateTimeOffset t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_span_timestamptz(s, t));

        public static bool after_spanset_date(IntPtr ss, long d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_spanset_date(ss, d));

        public static bool after_spanset_timestamptz(IntPtr ss, DateTimeOffset t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_spanset_timestamptz(ss, t));

        public static bool after_timestamptz_set(DateTimeOffset t, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_timestamptz_set(t, s));

        public static bool after_timestamptz_span(DateTimeOffset t, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_timestamptz_span(t, s));

        public static bool after_timestamptz_spanset(DateTimeOffset t, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_timestamptz_spanset(t, ss));

        public static bool before_date_set(long d, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_date_set(d, s));

        public static bool before_date_span(long d, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_date_span(d, s));

        public static bool before_date_spanset(long d, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_date_spanset(d, ss));

        public static bool before_set_date(IntPtr s, long d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_set_date(s, d));

        public static bool before_set_timestamptz(IntPtr s, DateTimeOffset t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_set_timestamptz(s, t));

        public static bool before_span_date(IntPtr s, long d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_span_date(s, d));

        public static bool before_span_timestamptz(IntPtr s, DateTimeOffset t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_span_timestamptz(s, t));

        public static bool before_spanset_date(IntPtr ss, long d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_spanset_date(ss, d));

        public static bool before_spanset_timestamptz(IntPtr ss, DateTimeOffset t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_spanset_timestamptz(ss, t));

        public static bool before_timestamptz_set(DateTimeOffset t, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_timestamptz_set(t, s));

        public static bool before_timestamptz_span(DateTimeOffset t, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_timestamptz_span(t, s));

        public static bool before_timestamptz_spanset(DateTimeOffset t, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_timestamptz_spanset(t, ss));

        public static bool left_bigint_set(double i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_bigint_set(i, s));

        public static bool left_bigint_span(double i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_bigint_span(i, s));

        public static bool left_bigint_spanset(double i, IntPtr ss)
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

        public static bool left_set_bigint(IntPtr s, double i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_set_bigint(s, i));

        public static bool left_set_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_set_float(s, d));

        public static bool left_set_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_set_int(s, i));

        public static bool left_set_set(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_set_set(s1, s2));

        public static bool left_set_text(IntPtr s, IntPtr txt)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_set_text(s, txt));

        public static bool left_span_bigint(IntPtr s, double i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_span_bigint(s, i));

        public static bool left_span_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_span_float(s, d));

        public static bool left_span_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_span_int(s, i));

        public static bool left_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_span_span(s1, s2));

        public static bool left_span_spanset(IntPtr s, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_span_spanset(s, ss));

        public static bool left_spanset_bigint(IntPtr ss, double i)
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

        public static bool overafter_set_date(IntPtr s, long d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_set_date(s, d));

        public static bool overafter_set_timestamptz(IntPtr s, DateTimeOffset t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_set_timestamptz(s, t));

        public static bool overafter_span_timestamptz(IntPtr s, DateTimeOffset t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_span_timestamptz(s, t));

        public static bool overafter_spanset_timestamptz(IntPtr ss, DateTimeOffset t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_spanset_timestamptz(ss, t));

        public static bool overafter_timestamptz_set(DateTimeOffset t, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_timestamptz_set(t, s));

        public static bool overafter_timestamptz_span(DateTimeOffset t, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_timestamptz_span(t, s));

        public static bool overafter_timestamptz_spanset(DateTimeOffset t, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_timestamptz_spanset(t, ss));

        public static bool overbefore_set_date(IntPtr s, long d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_set_date(s, d));

        public static bool overbefore_set_timestamptz(IntPtr s, DateTimeOffset t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_set_timestamptz(s, t));

        public static bool overbefore_span_timestamptz(IntPtr s, DateTimeOffset t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_span_timestamptz(s, t));

        public static bool overbefore_spanset_timestamptz(IntPtr ss, DateTimeOffset t)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_spanset_timestamptz(ss, t));

        public static bool overbefore_timestamptz_set(DateTimeOffset t, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_timestamptz_set(t, s));

        public static bool overbefore_timestamptz_span(DateTimeOffset t, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_timestamptz_span(t, s));

        public static bool overbefore_timestamptz_spanset(DateTimeOffset t, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_timestamptz_spanset(t, ss));

        public static bool overleft_bigint_set(double i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_bigint_set(i, s));

        public static bool overleft_bigint_span(double i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_bigint_span(i, s));

        public static bool overleft_bigint_spanset(double i, IntPtr ss)
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

        public static bool overleft_set_bigint(IntPtr s, double i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_set_bigint(s, i));

        public static bool overleft_set_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_set_float(s, d));

        public static bool overleft_set_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_set_int(s, i));

        public static bool overleft_set_set(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_set_set(s1, s2));

        public static bool overleft_set_text(IntPtr s, IntPtr txt)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_set_text(s, txt));

        public static bool overleft_span_bigint(IntPtr s, double i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_span_bigint(s, i));

        public static bool overleft_span_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_span_float(s, d));

        public static bool overleft_span_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_span_int(s, i));

        public static bool overleft_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_span_span(s1, s2));

        public static bool overleft_span_spanset(IntPtr s, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_span_spanset(s, ss));

        public static bool overleft_spanset_bigint(IntPtr ss, double i)
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

        public static bool overright_bigint_set(double i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_bigint_set(i, s));

        public static bool overright_bigint_span(double i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_bigint_span(i, s));

        public static bool overright_bigint_spanset(double i, IntPtr ss)
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

        public static bool overright_set_bigint(IntPtr s, double i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_set_bigint(s, i));

        public static bool overright_set_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_set_float(s, d));

        public static bool overright_set_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_set_int(s, i));

        public static bool overright_set_set(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_set_set(s1, s2));

        public static bool overright_set_text(IntPtr s, IntPtr txt)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_set_text(s, txt));

        public static bool overright_span_bigint(IntPtr s, double i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_span_bigint(s, i));

        public static bool overright_span_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_span_float(s, d));

        public static bool overright_span_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_span_int(s, i));

        public static bool overright_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_span_span(s1, s2));

        public static bool overright_span_spanset(IntPtr s, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_span_spanset(s, ss));

        public static bool overright_spanset_bigint(IntPtr ss, double i)
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

        public static bool right_bigint_set(double i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_bigint_set(i, s));

        public static bool right_bigint_span(double i, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_bigint_span(i, s));

        public static bool right_bigint_spanset(double i, IntPtr ss)
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

        public static bool right_set_bigint(IntPtr s, double i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_set_bigint(s, i));

        public static bool right_set_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_set_float(s, d));

        public static bool right_set_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_set_int(s, i));

        public static bool right_set_set(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_set_set(s1, s2));

        public static bool right_set_text(IntPtr s, IntPtr txt)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_set_text(s, txt));

        public static bool right_span_bigint(IntPtr s, double i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_span_bigint(s, i));

        public static bool right_span_float(IntPtr s, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_span_float(s, d));

        public static bool right_span_int(IntPtr s, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_span_int(s, i));

        public static bool right_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_span_span(s1, s2));

        public static bool right_span_spanset(IntPtr s, IntPtr ss)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_span_spanset(s, ss));

        public static bool right_spanset_bigint(IntPtr ss, double i)
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

        public static double distance_set_bigint(IntPtr s, double i)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_set_bigint(s, i));

        public static double distance_set_float(IntPtr s, double d)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_set_float(s, d));

        public static double distance_set_int(IntPtr s, int i)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_set_int(s, i));

        public static double distance_set_set(IntPtr s1, IntPtr s2)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_set_set(s1, s2));

        public static double distance_set_timestamptz(IntPtr s, DateTimeOffset t)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_set_timestamptz(s, t));

        public static double distance_span_bigint(IntPtr s, double i)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_span_bigint(s, i));

        public static double distance_span_float(IntPtr s, double d)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_span_float(s, d));

        public static double distance_span_int(IntPtr s, int i)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_span_int(s, i));

        public static double distance_span_span(IntPtr s1, IntPtr s2)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_span_span(s1, s2));

        public static double distance_span_timestamptz(IntPtr s, DateTimeOffset t)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_span_timestamptz(s, t));

        public static double distance_spanset_bigint(IntPtr ss, double i)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_spanset_bigint(ss, i));

        public static double distance_spanset_float(IntPtr ss, double d)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_spanset_float(ss, d));

        public static double distance_spanset_int(IntPtr ss, int i)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_spanset_int(ss, i));

        public static double distance_spanset_timestamptz(IntPtr ss, DateTimeOffset t)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_spanset_timestamptz(ss, t));

        public static double distance_spanset_span(IntPtr ss, IntPtr s)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_spanset_span(ss, s));

        public static double distance_spanset_spanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<double>(() => MEOSExternalFunctions.distance_spanset_spanset(ss1, ss2));

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

        public static IntPtr bigint_extent_transfn(IntPtr s, double i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigint_extent_transfn(s, i));

        public static IntPtr bigint_union_transfn(IntPtr state, double i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bigint_union_transfn(state, i));

        public static IntPtr float_extent_transfn(IntPtr s, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.float_extent_transfn(s, d));

        public static IntPtr float_union_transfn(IntPtr state, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.float_union_transfn(state, d));

        public static IntPtr int_extent_transfn(IntPtr s, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.int_extent_transfn(s, i));

        public static IntPtr int_union_transfn(IntPtr state, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.int_union_transfn(state, i));

        public static IntPtr set_extent_transfn(IntPtr span, IntPtr set)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_extent_transfn(span, set));

        public static IntPtr set_union_finalfn(IntPtr state)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_union_finalfn(state));

        public static IntPtr set_union_transfn(IntPtr state, IntPtr set)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.set_union_transfn(state, set));

        public static IntPtr span_extent_transfn(IntPtr s1, IntPtr s2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.span_extent_transfn(s1, s2));

        public static IntPtr span_union_transfn(IntPtr state, IntPtr span)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.span_union_transfn(state, span));

        public static IntPtr spanset_extent_transfn(IntPtr s, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_extent_transfn(s, ss));

        public static IntPtr spanset_union_finalfn(IntPtr state)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_union_finalfn(state));

        public static IntPtr spanset_union_transfn(IntPtr state, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.spanset_union_transfn(state, ss));

        public static IntPtr text_union_transfn(IntPtr state, IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.text_union_transfn(state, txt));

        public static IntPtr timestamptz_extent_transfn(IntPtr s, DateTimeOffset t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.timestamptz_extent_transfn(s, t));

        public static IntPtr timestamptz_tcount_transfn(IntPtr state, DateTimeOffset t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.timestamptz_tcount_transfn(state, t));

        public static IntPtr timestamptz_union_transfn(IntPtr state, DateTimeOffset t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.timestamptz_union_transfn(state, t));

        public static IntPtr tstzset_tcount_transfn(IntPtr state, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzset_tcount_transfn(state, s));

        public static IntPtr tstzspan_tcount_transfn(IntPtr state, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspan_tcount_transfn(state, s));

        public static IntPtr tstzspanset_tcount_transfn(IntPtr state, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspanset_tcount_transfn(state, ss));

        public static IntPtr tbox_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_in(str));

        public static string tbox_out(IntPtr box, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.tbox_out(box, maxdd));

        public static IntPtr tbox_from_wkb(IntPtr wkb, ulong size)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_from_wkb(wkb, size));

        public static IntPtr tbox_from_hexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_from_hexwkb(hexwkb));

        public static IntPtr stbox_from_wkb(IntPtr wkb, ulong size)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_from_wkb(wkb, size));

        public static IntPtr stbox_from_hexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_from_hexwkb(hexwkb));

        public static IntPtr tbox_as_wkb(IntPtr box, byte variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_as_wkb(box, variant, size_out));

        public static string tbox_as_hexwkb(IntPtr box, byte variant, IntPtr size)
            => SafeExecution<string>(() => MEOSExternalFunctions.tbox_as_hexwkb(box, variant, size));

        public static IntPtr stbox_as_wkb(IntPtr box, byte variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_as_wkb(box, variant, size_out));

        public static string stbox_as_hexwkb(IntPtr box, byte variant, IntPtr size)
            => SafeExecution<string>(() => MEOSExternalFunctions.stbox_as_hexwkb(box, variant, size));

        public static IntPtr stbox_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_in(str));

        public static string stbox_out(IntPtr box, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.stbox_out(box, maxdd));

        public static IntPtr float_tstzspan_to_tbox(double d, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.float_tstzspan_to_tbox(d, s));

        public static IntPtr float_timestamptz_to_tbox(double d, DateTimeOffset t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.float_timestamptz_to_tbox(d, t));

        public static IntPtr geo_tstzspan_to_stbox(IntPtr gs, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_tstzspan_to_stbox(gs, s));

        public static IntPtr geo_timestamptz_to_stbox(IntPtr gs, DateTimeOffset t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_timestamptz_to_stbox(gs, t));

        public static IntPtr int_tstzspan_to_tbox(int i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.int_tstzspan_to_tbox(i, s));

        public static IntPtr int_timestamptz_to_tbox(int i, DateTimeOffset t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.int_timestamptz_to_tbox(i, t));

        public static IntPtr numspan_tstzspan_to_tbox(IntPtr span, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.numspan_tstzspan_to_tbox(span, s));

        public static IntPtr numspan_timestamptz_to_tbox(IntPtr span, DateTimeOffset t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.numspan_timestamptz_to_tbox(span, t));

        public static IntPtr stbox_copy(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_copy(box));

        public static IntPtr stbox_make(bool hasx, bool hasz, bool geodetic, int srid, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_make(hasx, hasz, geodetic, srid, xmin, xmax, ymin, ymax, zmin, zmax, s));

        public static IntPtr tbox_copy(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_copy(box));

        public static IntPtr tbox_make(IntPtr s, IntPtr p)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_make(s, p));

        public static IntPtr box3d_to_stbox(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.box3d_to_stbox(box));

        public static IntPtr gbox_to_stbox(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.gbox_to_stbox(box));

        public static IntPtr float_to_tbox(double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.float_to_tbox(d));

        public static IntPtr geo_to_stbox(IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_to_stbox(gs));

        public static IntPtr int_to_tbox(int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.int_to_tbox(i));

        public static IntPtr numset_to_tbox(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.numset_to_tbox(s));

        public static IntPtr numspan_to_tbox(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.numspan_to_tbox(s));

        public static IntPtr numspanset_to_tbox(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.numspanset_to_tbox(ss));

        public static IntPtr tstzspan_to_stbox(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspan_to_stbox(s));

        public static IntPtr tstzspan_to_tbox(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspan_to_tbox(s));

        public static IntPtr tstzspanset_to_stbox(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspanset_to_stbox(ss));

        public static IntPtr tstzspanset_to_tbox(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspanset_to_tbox(ss));

        public static IntPtr stbox_to_gbox(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_to_gbox(box));

        public static IntPtr stbox_to_box3d(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_to_box3d(box));

        public static IntPtr stbox_to_geo(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_to_geo(box));

        public static IntPtr stbox_to_tstzspan(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_to_tstzspan(box));

        public static IntPtr tbox_to_intspan(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_to_intspan(box));

        public static IntPtr tbox_to_floatspan(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_to_floatspan(box));

        public static IntPtr tbox_to_tstzspan(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_to_tstzspan(box));

        public static IntPtr timestamptz_to_stbox(DateTimeOffset t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.timestamptz_to_stbox(t));

        public static IntPtr timestamptz_to_tbox(DateTimeOffset t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.timestamptz_to_tbox(t));

        public static IntPtr tstzset_to_stbox(IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzset_to_stbox(s));

        public static IntPtr tstzset_to_tbox(IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzset_to_tbox(ss));

        public static IntPtr tnumber_to_tbox(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_to_tbox(temp));

        public static IntPtr tpoint_to_stbox(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_to_stbox(temp));

        public static bool stbox_hast(IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_hast(box));

        public static bool stbox_hasx(IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_hasx(box));

        public static bool stbox_hasz(IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_hasz(box));

        public static bool stbox_isgeodetic(IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_isgeodetic(box));

        public static int stbox_srid(IntPtr box)
            => SafeExecution<int>(() => MEOSExternalFunctions.stbox_srid(box));

        public static bool stbox_tmax(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_tmax(box, result));

        public static bool stbox_tmax_inc(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_tmax_inc(box, result));

        public static bool stbox_tmin(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_tmin(box, result));

        public static bool stbox_tmin_inc(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_tmin_inc(box, result));

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

        public static IntPtr stbox_expand_space(IntPtr box, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_expand_space(box, d));

        public static IntPtr stbox_expand_time(IntPtr box, IntPtr interval)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_expand_time(box, interval));

        public static IntPtr stbox_get_space(IntPtr box)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_get_space(box));

        public static IntPtr stbox_round(IntPtr box, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_round(box, maxdd));

        public static IntPtr stbox_set_srid(IntPtr box, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_set_srid(box, srid));

        public static IntPtr stbox_shift_scale_time(IntPtr box, IntPtr shift, IntPtr duration)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_shift_scale_time(box, shift, duration));

        public static IntPtr tbox_expand_time(IntPtr box, IntPtr interval)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_expand_time(box, interval));

        public static IntPtr tbox_expand_float(IntPtr box, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_expand_float(box, d));

        public static IntPtr tbox_expand_int(IntPtr box, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_expand_int(box, i));

        public static IntPtr tbox_round(IntPtr box, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_round(box, maxdd));

        public static IntPtr tbox_shift_scale_float(IntPtr box, double shift, double width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_shift_scale_float(box, shift, width, hasshift, haswidth));

        public static IntPtr tbox_shift_scale_int(IntPtr box, int shift, int width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_shift_scale_int(box, shift, width, hasshift, haswidth));

        public static IntPtr tbox_shift_scale_time(IntPtr box, IntPtr shift, IntPtr duration)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbox_shift_scale_time(box, shift, duration));

        public static IntPtr union_tbox_tbox(IntPtr box1, IntPtr box2, bool strict)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_tbox_tbox(box1, box2, strict));

        public static bool inter_tbox_tbox(IntPtr box1, IntPtr box2, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.inter_tbox_tbox(box1, box2, result));

        public static IntPtr intersection_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_tbox_tbox(box1, box2));

        public static IntPtr union_stbox_stbox(IntPtr box1, IntPtr box2, bool strict)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.union_stbox_stbox(box1, box2, strict));

        public static bool inter_stbox_stbox(IntPtr box1, IntPtr box2, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.inter_stbox_stbox(box1, box2, result));

        public static IntPtr intersection_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intersection_stbox_stbox(box1, box2));

        public static bool contains_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_tbox_tbox(box1, box2));

        public static bool contained_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_tbox_tbox(box1, box2));

        public static bool overlaps_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_tbox_tbox(box1, box2));

        public static bool same_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.same_tbox_tbox(box1, box2));

        public static bool adjacent_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_tbox_tbox(box1, box2));

        public static bool contains_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_stbox_stbox(box1, box2));

        public static bool contained_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_stbox_stbox(box1, box2));

        public static bool overlaps_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_stbox_stbox(box1, box2));

        public static bool same_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.same_stbox_stbox(box1, box2));

        public static bool adjacent_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_stbox_stbox(box1, box2));

        public static bool left_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_tbox_tbox(box1, box2));

        public static bool overleft_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_tbox_tbox(box1, box2));

        public static bool right_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_tbox_tbox(box1, box2));

        public static bool overright_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_tbox_tbox(box1, box2));

        public static bool before_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_tbox_tbox(box1, box2));

        public static bool overbefore_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_tbox_tbox(box1, box2));

        public static bool after_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_tbox_tbox(box1, box2));

        public static bool overafter_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_tbox_tbox(box1, box2));

        public static bool left_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_stbox_stbox(box1, box2));

        public static bool overleft_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_stbox_stbox(box1, box2));

        public static bool right_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_stbox_stbox(box1, box2));

        public static bool overright_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_stbox_stbox(box1, box2));

        public static bool below_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.below_stbox_stbox(box1, box2));

        public static bool overbelow_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbelow_stbox_stbox(box1, box2));

        public static bool above_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.above_stbox_stbox(box1, box2));

        public static bool overabove_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overabove_stbox_stbox(box1, box2));

        public static bool front_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.front_stbox_stbox(box1, box2));

        public static bool overfront_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overfront_stbox_stbox(box1, box2));

        public static bool back_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.back_stbox_stbox(box1, box2));

        public static bool overback_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overback_stbox_stbox(box1, box2));

        public static bool before_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_stbox_stbox(box1, box2));

        public static bool overbefore_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_stbox_stbox(box1, box2));

        public static bool after_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_stbox_stbox(box1, box2));

        public static bool overafter_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_stbox_stbox(box1, box2));

        public static IntPtr stbox_quad_split(IntPtr box, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_quad_split(box, count));

        public static bool tbox_eq(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbox_eq(box1, box2));

        public static bool tbox_ne(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbox_ne(box1, box2));

        public static int tbox_cmp(IntPtr box1, IntPtr box2)
            => SafeExecution<int>(() => MEOSExternalFunctions.tbox_cmp(box1, box2));

        public static bool tbox_lt(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbox_lt(box1, box2));

        public static bool tbox_le(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbox_le(box1, box2));

        public static bool tbox_ge(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbox_ge(box1, box2));

        public static bool tbox_gt(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbox_gt(box1, box2));

        public static bool stbox_eq(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_eq(box1, box2));

        public static bool stbox_ne(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_ne(box1, box2));

        public static int stbox_cmp(IntPtr box1, IntPtr box2)
            => SafeExecution<int>(() => MEOSExternalFunctions.stbox_cmp(box1, box2));

        public static bool stbox_lt(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_lt(box1, box2));

        public static bool stbox_le(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_le(box1, box2));

        public static bool stbox_ge(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_ge(box1, box2));

        public static bool stbox_gt(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.stbox_gt(box1, box2));

        public static IntPtr tbool_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbool_in(str));

        public static string tbool_out(IntPtr temp)
            => SafeExecution<string>(() => MEOSExternalFunctions.tbool_out(temp));

        public static string temporal_as_hexwkb(IntPtr temp, byte variant, IntPtr size_out)
            => SafeExecution<string>(() => MEOSExternalFunctions.temporal_as_hexwkb(temp, variant, size_out));

        public static string temporal_as_mfjson(IntPtr temp, bool with_bbox, int flags, int precision, string srs)
            => SafeExecution<string>(() => MEOSExternalFunctions.temporal_as_mfjson(temp, with_bbox, flags, precision, srs));

        public static IntPtr temporal_as_wkb(IntPtr temp, byte variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_as_wkb(temp, variant, size_out));

        public static IntPtr temporal_from_hexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_from_hexwkb(hexwkb));

        public static IntPtr temporal_from_mfjson(string mfjson)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_from_mfjson(mfjson));

        public static IntPtr temporal_from_wkb(IntPtr wkb, ulong size)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_from_wkb(wkb, size));

        public static IntPtr tfloat_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_in(str));

        public static string tfloat_out(IntPtr temp, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.tfloat_out(temp, maxdd));

        public static IntPtr tgeogpoint_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeogpoint_in(str));

        public static IntPtr tgeompoint_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeompoint_in(str));

        public static IntPtr tint_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_in(str));

        public static string tint_out(IntPtr temp)
            => SafeExecution<string>(() => MEOSExternalFunctions.tint_out(temp));

        public static string tpoint_as_ewkt(IntPtr temp, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.tpoint_as_ewkt(temp, maxdd));

        public static string tpoint_as_text(IntPtr temp, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.tpoint_as_text(temp, maxdd));

        public static string tpoint_out(IntPtr temp, int maxdd)
            => SafeExecution<string>(() => MEOSExternalFunctions.tpoint_out(temp, maxdd));

        public static IntPtr ttext_in(string str)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_in(str));

        public static string ttext_out(IntPtr temp)
            => SafeExecution<string>(() => MEOSExternalFunctions.ttext_out(temp));

        public static IntPtr temporal_cp(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_cp(temp));

        public static IntPtr tbool_from_base_temp(bool b, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbool_from_base_temp(b, temp));

        public static IntPtr tboolinst_make(bool b, DateTimeOffset t)
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

        public static IntPtr tfloatinst_make(double d, DateTimeOffset t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloatinst_make(d, t));

        public static IntPtr tfloatseq_from_base_tstzspan(double d, IntPtr s, InterpolationType interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloatseq_from_base_tstzspan(d, s, interp));

        public static IntPtr tfloatseq_from_base_tstzset(double d, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloatseq_from_base_tstzset(d, s));

        public static IntPtr tfloatseqset_from_base_tstzspanset(double d, IntPtr ss, InterpolationType interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloatseqset_from_base_tstzspanset(d, ss, interp));

        public static IntPtr tint_from_base_temp(int i, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_from_base_temp(i, temp));

        public static IntPtr tintinst_make(int i, DateTimeOffset t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintinst_make(i, t));

        public static IntPtr tintseq_from_base_tstzspan(int i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintseq_from_base_tstzspan(i, s));

        public static IntPtr tintseq_from_base_tstzset(int i, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintseq_from_base_tstzset(i, s));

        public static IntPtr tintseqset_from_base_tstzspanset(int i, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintseqset_from_base_tstzspanset(i, ss));

        public static IntPtr tpoint_from_base_temp(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_from_base_temp(gs, temp));

        public static IntPtr tpointinst_make(IntPtr gs, DateTimeOffset t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpointinst_make(gs, t));

        public static IntPtr tpointseq_from_base_tstzspan(IntPtr gs, IntPtr s, InterpolationType interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpointseq_from_base_tstzspan(gs, s, interp));

        public static IntPtr tpointseq_from_base_tstzset(IntPtr gs, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpointseq_from_base_tstzset(gs, s));

        public static IntPtr tpointseqset_from_base_tstzspanset(IntPtr gs, IntPtr ss, InterpolationType interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpointseqset_from_base_tstzspanset(gs, ss, interp));

        public static IntPtr tsequence_make(IntPtr instants, int count, bool lower_inc, bool upper_inc, InterpolationType interp, bool normalize)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequence_make(instants, count, lower_inc, upper_inc, interp, normalize));

        public static IntPtr tsequenceset_make(IntPtr sequences, int count, bool normalize)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_make(sequences, count, normalize));

        public static IntPtr tsequenceset_make_gaps(IntPtr instants, int count, InterpolationType interp, IntPtr maxt, double maxdist)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tsequenceset_make_gaps(instants, count, interp, maxt, maxdist));

        public static IntPtr ttext_from_base_temp(IntPtr txt, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_from_base_temp(txt, temp));

        public static IntPtr ttextinst_make(IntPtr txt, DateTimeOffset t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttextinst_make(txt, t));

        public static IntPtr ttextseq_from_base_tstzspan(IntPtr txt, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttextseq_from_base_tstzspan(txt, s));

        public static IntPtr ttextseq_from_base_tstzset(IntPtr txt, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttextseq_from_base_tstzset(txt, s));

        public static IntPtr ttextseqset_from_base_tstzspanset(IntPtr txt, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttextseqset_from_base_tstzspanset(txt, ss));

        public static IntPtr temporal_to_tstzspan(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_to_tstzspan(temp));

        public static IntPtr tfloat_to_tint(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_to_tint(temp));

        public static IntPtr tint_to_tfloat(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_to_tfloat(temp));

        public static IntPtr tnumber_to_span(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_to_span(temp));

        public static bool tbool_end_value(IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbool_end_value(temp));

        public static bool tbool_start_value(IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbool_start_value(temp));

        public static IntPtr tbool_values(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbool_values(temp, count));

        public static IntPtr temporal_duration(IntPtr temp, bool boundspan)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_duration(temp, boundspan));

        public static IntPtr temporal_end_instant(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_end_instant(temp));

        public static IntPtr temporal_end_sequence(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_end_sequence(temp));

        public static DateTimeOffset temporal_end_timestamptz(IntPtr temp)
            => SafeExecution<DateTimeOffset>(() => MEOSExternalFunctions.temporal_end_timestamptz(temp));

        public static uint temporal_hash(IntPtr temp)
            => SafeExecution<uint>(() => MEOSExternalFunctions.temporal_hash(temp));

        public static IntPtr temporal_instant_n(IntPtr temp, int n)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_instant_n(temp, n));

        public static IntPtr temporal_instants(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_instants(temp, count));

        public static string temporal_interp(IntPtr temp)
            => SafeExecution<string>(() => MEOSExternalFunctions.temporal_interp(temp));

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

        public static DateTimeOffset temporal_start_timestamptz(IntPtr temp)
            => SafeExecution<DateTimeOffset>(() => MEOSExternalFunctions.temporal_start_timestamptz(temp));

        public static IntPtr temporal_stops(IntPtr temp, double maxdist, IntPtr minduration)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_stops(temp, maxdist, minduration));

        public static string temporal_subtype(IntPtr temp)
            => SafeExecution<string>(() => MEOSExternalFunctions.temporal_subtype(temp));

        public static IntPtr temporal_time(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_time(temp));

        public static bool temporal_timestamptz_n(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.temporal_timestamptz_n(temp, n, result));

        public static IntPtr temporal_timestamps(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_timestamps(temp, count));

        public static double tfloat_end_value(IntPtr temp)
            => SafeExecution<double>(() => MEOSExternalFunctions.tfloat_end_value(temp));

        public static double tfloat_max_value(IntPtr temp)
            => SafeExecution<double>(() => MEOSExternalFunctions.tfloat_max_value(temp));

        public static double tfloat_min_value(IntPtr temp)
            => SafeExecution<double>(() => MEOSExternalFunctions.tfloat_min_value(temp));

        public static double tfloat_start_value(IntPtr temp)
            => SafeExecution<double>(() => MEOSExternalFunctions.tfloat_start_value(temp));

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

        public static IntPtr tint_values(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_values(temp, count));

        public static IntPtr tnumber_valuespans(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_valuespans(temp));

        public static IntPtr tpoint_end_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_end_value(temp));

        public static IntPtr tpoint_start_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_start_value(temp));

        public static IntPtr tpoint_values(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_values(temp, count));

        public static IntPtr ttext_end_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_end_value(temp));

        public static IntPtr ttext_max_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_max_value(temp));

        public static IntPtr ttext_min_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_min_value(temp));

        public static IntPtr ttext_start_value(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_start_value(temp));

        public static IntPtr ttext_values(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_values(temp, count));

        public static IntPtr temporal_scale_time(IntPtr temp, IntPtr duration)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_scale_time(temp, duration));

        public static IntPtr temporal_set_interp(IntPtr temp, InterpolationType interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_set_interp(temp, interp));

        public static IntPtr temporal_shift_scale_time(IntPtr temp, IntPtr shift, IntPtr duration)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_shift_scale_time(temp, shift, duration));

        public static IntPtr temporal_shift_time(IntPtr temp, IntPtr shift)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_shift_time(temp, shift));

        public static IntPtr temporal_to_tinstant(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_to_tinstant(temp));

        public static IntPtr temporal_to_tsequence(IntPtr temp, InterpolationType interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_to_tsequence(temp, interp));

        public static IntPtr temporal_to_tsequenceset(IntPtr temp, InterpolationType interp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_to_tsequenceset(temp, interp));

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

        public static IntPtr temporal_append_tinstant(IntPtr temp, IntPtr inst, double maxdist, IntPtr maxt, bool expand)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_append_tinstant(temp, inst, maxdist, maxt, expand));

        public static IntPtr temporal_append_tsequence(IntPtr temp, IntPtr seq, bool expand)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_append_tsequence(temp, seq, expand));

        public static IntPtr temporal_delete_tstzspan(IntPtr temp, IntPtr s, bool connect)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_delete_tstzspan(temp, s, connect));

        public static IntPtr temporal_delete_tstzspanset(IntPtr temp, IntPtr ss, bool connect)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_delete_tstzspanset(temp, ss, connect));

        public static IntPtr temporal_delete_timestamptz(IntPtr temp, DateTimeOffset t, bool connect)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_delete_timestamptz(temp, t, connect));

        public static IntPtr temporal_delete_tstzset(IntPtr temp, IntPtr s, bool connect)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_delete_tstzset(temp, s, connect));

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

        public static bool tbool_value_at_timestamptz(IntPtr temp, DateTimeOffset t, bool strict, IntPtr value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbool_value_at_timestamptz(temp, t, strict, value));

        public static IntPtr temporal_at_max(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_at_max(temp));

        public static IntPtr temporal_at_min(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_at_min(temp));

        public static IntPtr temporal_at_tstzspan(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_at_tstzspan(temp, s));

        public static IntPtr temporal_at_tstzspanset(IntPtr temp, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_at_tstzspanset(temp, ss));

        public static IntPtr temporal_at_timestamptz(IntPtr temp, DateTimeOffset t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_at_timestamptz(temp, t));

        public static IntPtr temporal_at_tstzset(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_at_tstzset(temp, s));

        public static IntPtr temporal_at_values(IntPtr temp, IntPtr set)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_at_values(temp, set));

        public static IntPtr temporal_minus_max(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_minus_max(temp));

        public static IntPtr temporal_minus_min(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_minus_min(temp));

        public static IntPtr temporal_minus_tstzspan(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_minus_tstzspan(temp, s));

        public static IntPtr temporal_minus_tstzspanset(IntPtr temp, IntPtr ss)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_minus_tstzspanset(temp, ss));

        public static IntPtr temporal_minus_timestamptz(IntPtr temp, DateTimeOffset t)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_minus_timestamptz(temp, t));

        public static IntPtr temporal_minus_tstzset(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_minus_tstzset(temp, s));

        public static IntPtr temporal_minus_values(IntPtr temp, IntPtr set)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_minus_values(temp, set));

        public static IntPtr tfloat_at_value(IntPtr temp, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_at_value(temp, d));

        public static IntPtr tfloat_minus_value(IntPtr temp, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_minus_value(temp, d));

        public static bool tfloat_value_at_timestamptz(IntPtr temp, DateTimeOffset t, bool strict, IntPtr value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tfloat_value_at_timestamptz(temp, t, strict, value));

        public static IntPtr tint_at_value(IntPtr temp, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_at_value(temp, i));

        public static IntPtr tint_minus_value(IntPtr temp, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_minus_value(temp, i));

        public static bool tint_value_at_timestamptz(IntPtr temp, DateTimeOffset t, bool strict, IntPtr value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tint_value_at_timestamptz(temp, t, strict, value));

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

        public static IntPtr tpoint_at_geom_time(IntPtr temp, IntPtr gs, IntPtr zspan, IntPtr period)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_at_geom_time(temp, gs, zspan, period));

        public static IntPtr tpoint_at_stbox(IntPtr temp, IntPtr box, bool border_inc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_at_stbox(temp, box, border_inc));

        public static IntPtr tpoint_at_value(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_at_value(temp, gs));

        public static IntPtr tpoint_minus_geom_time(IntPtr temp, IntPtr gs, IntPtr zspan, IntPtr period)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_minus_geom_time(temp, gs, zspan, period));

        public static IntPtr tpoint_minus_stbox(IntPtr temp, IntPtr box, bool border_inc)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_minus_stbox(temp, box, border_inc));

        public static IntPtr tpoint_minus_value(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_minus_value(temp, gs));

        public static bool tpoint_value_at_timestamptz(IntPtr temp, DateTimeOffset t, bool strict, IntPtr value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpoint_value_at_timestamptz(temp, t, strict, value));

        public static IntPtr ttext_at_value(IntPtr temp, IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_at_value(temp, txt));

        public static IntPtr ttext_minus_value(IntPtr temp, IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_minus_value(temp, txt));

        public static bool ttext_value_at_timestamptz(IntPtr temp, DateTimeOffset t, bool strict, IntPtr value)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ttext_value_at_timestamptz(temp, t, strict, value));

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

        public static bool tbool_always_eq(IntPtr temp, bool b)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbool_always_eq(temp, b));

        public static bool tbool_ever_eq(IntPtr temp, bool b)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tbool_ever_eq(temp, b));

        public static bool tfloat_always_eq(IntPtr temp, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tfloat_always_eq(temp, d));

        public static bool tfloat_always_le(IntPtr temp, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tfloat_always_le(temp, d));

        public static bool tfloat_always_lt(IntPtr temp, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tfloat_always_lt(temp, d));

        public static bool tfloat_ever_eq(IntPtr temp, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tfloat_ever_eq(temp, d));

        public static bool tfloat_ever_le(IntPtr temp, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tfloat_ever_le(temp, d));

        public static bool tfloat_ever_lt(IntPtr temp, double d)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tfloat_ever_lt(temp, d));

        public static bool tint_always_eq(IntPtr temp, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tint_always_eq(temp, i));

        public static bool tint_always_le(IntPtr temp, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tint_always_le(temp, i));

        public static bool tint_always_lt(IntPtr temp, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tint_always_lt(temp, i));

        public static bool tint_ever_eq(IntPtr temp, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tint_ever_eq(temp, i));

        public static bool tint_ever_le(IntPtr temp, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tint_ever_le(temp, i));

        public static bool tint_ever_lt(IntPtr temp, int i)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tint_ever_lt(temp, i));

        public static bool tpoint_always_eq(IntPtr temp, IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpoint_always_eq(temp, gs));

        public static bool tpoint_ever_eq(IntPtr temp, IntPtr gs)
            => SafeExecution<bool>(() => MEOSExternalFunctions.tpoint_ever_eq(temp, gs));

        public static bool ttext_always_eq(IntPtr temp, IntPtr txt)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ttext_always_eq(temp, txt));

        public static bool ttext_always_le(IntPtr temp, IntPtr txt)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ttext_always_le(temp, txt));

        public static bool ttext_always_lt(IntPtr temp, IntPtr txt)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ttext_always_lt(temp, txt));

        public static bool ttext_ever_eq(IntPtr temp, IntPtr txt)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ttext_ever_eq(temp, txt));

        public static bool ttext_ever_le(IntPtr temp, IntPtr txt)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ttext_ever_le(temp, txt));

        public static bool ttext_ever_lt(IntPtr temp, IntPtr txt)
            => SafeExecution<bool>(() => MEOSExternalFunctions.ttext_ever_lt(temp, txt));

        public static IntPtr teq_bool_tbool(bool b, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_bool_tbool(b, temp));

        public static IntPtr teq_float_tfloat(double d, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_float_tfloat(d, temp));

        public static IntPtr teq_int_tint(int i, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_int_tint(i, temp));

        public static IntPtr teq_point_tpoint(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_point_tpoint(gs, temp));

        public static IntPtr teq_tbool_bool(IntPtr temp, bool b)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_tbool_bool(temp, b));

        public static IntPtr teq_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_temporal_temporal(temp1, temp2));

        public static IntPtr teq_text_ttext(IntPtr txt, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_text_ttext(txt, temp));

        public static IntPtr teq_tfloat_float(IntPtr temp, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_tfloat_float(temp, d));

        public static IntPtr teq_tpoint_point(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.teq_tpoint_point(temp, gs));

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

        public static IntPtr tne_point_tpoint(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_point_tpoint(gs, temp));

        public static IntPtr tne_tbool_bool(IntPtr temp, bool b)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_tbool_bool(temp, b));

        public static IntPtr tne_temporal_temporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_temporal_temporal(temp1, temp2));

        public static IntPtr tne_text_ttext(IntPtr txt, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_text_ttext(txt, temp));

        public static IntPtr tne_tfloat_float(IntPtr temp, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_tfloat_float(temp, d));

        public static IntPtr tne_tpoint_point(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_tpoint_point(temp, gs));

        public static IntPtr tne_tint_int(IntPtr temp, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_tint_int(temp, i));

        public static IntPtr tne_ttext_text(IntPtr temp, IntPtr txt)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tne_ttext_text(temp, txt));

        public static bool adjacent_numspan_tnumber(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_numspan_tnumber(s, temp));

        public static bool adjacent_stbox_tpoint(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_stbox_tpoint(box, temp));

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

        public static bool adjacent_tpoint_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_tpoint_stbox(temp, box));

        public static bool adjacent_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_tpoint_tpoint(temp1, temp2));

        public static bool adjacent_tstzspan_temporal(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.adjacent_tstzspan_temporal(s, temp));

        public static bool contained_numspan_tnumber(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_numspan_tnumber(s, temp));

        public static bool contained_stbox_tpoint(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_stbox_tpoint(box, temp));

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

        public static bool contained_tpoint_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_tpoint_stbox(temp, box));

        public static bool contained_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_tpoint_tpoint(temp1, temp2));

        public static bool contained_tstzspan_temporal(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contained_tstzspan_temporal(s, temp));

        public static bool contains_numspan_tnumber(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_numspan_tnumber(s, temp));

        public static bool contains_stbox_tpoint(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_stbox_tpoint(box, temp));

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

        public static bool contains_tpoint_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_tpoint_stbox(temp, box));

        public static bool contains_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_tpoint_tpoint(temp1, temp2));

        public static bool contains_tstzspan_temporal(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.contains_tstzspan_temporal(s, temp));

        public static bool overlaps_numspan_tnumber(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_numspan_tnumber(s, temp));

        public static bool overlaps_stbox_tpoint(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_stbox_tpoint(box, temp));

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

        public static bool overlaps_tpoint_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_tpoint_stbox(temp, box));

        public static bool overlaps_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_tpoint_tpoint(temp1, temp2));

        public static bool overlaps_tstzspan_temporal(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overlaps_tstzspan_temporal(s, temp));

        public static bool same_numspan_tnumber(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.same_numspan_tnumber(s, temp));

        public static bool same_stbox_tpoint(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.same_stbox_tpoint(box, temp));

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

        public static bool same_tpoint_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.same_tpoint_stbox(temp, box));

        public static bool same_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.same_tpoint_tpoint(temp1, temp2));

        public static bool same_tstzspan_temporal(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.same_tstzspan_temporal(s, temp));

        public static bool above_stbox_tpoint(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.above_stbox_tpoint(box, temp));

        public static bool above_tpoint_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.above_tpoint_stbox(temp, box));

        public static bool above_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.above_tpoint_tpoint(temp1, temp2));

        public static bool after_stbox_tpoint(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_stbox_tpoint(box, temp));

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

        public static bool after_tpoint_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_tpoint_stbox(temp, box));

        public static bool after_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_tpoint_tpoint(temp1, temp2));

        public static bool after_tstzspan_temporal(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.after_tstzspan_temporal(s, temp));

        public static bool back_stbox_tpoint(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.back_stbox_tpoint(box, temp));

        public static bool back_tpoint_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.back_tpoint_stbox(temp, box));

        public static bool back_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.back_tpoint_tpoint(temp1, temp2));

        public static bool before_stbox_tpoint(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_stbox_tpoint(box, temp));

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

        public static bool before_tpoint_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_tpoint_stbox(temp, box));

        public static bool before_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_tpoint_tpoint(temp1, temp2));

        public static bool before_tstzspan_temporal(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.before_tstzspan_temporal(s, temp));

        public static bool below_stbox_tpoint(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.below_stbox_tpoint(box, temp));

        public static bool below_tpoint_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.below_tpoint_stbox(temp, box));

        public static bool below_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.below_tpoint_tpoint(temp1, temp2));

        public static bool front_stbox_tpoint(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.front_stbox_tpoint(box, temp));

        public static bool front_tpoint_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.front_tpoint_stbox(temp, box));

        public static bool front_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.front_tpoint_tpoint(temp1, temp2));

        public static bool left_stbox_tpoint(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_stbox_tpoint(box, temp));

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

        public static bool left_tpoint_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_tpoint_stbox(temp, box));

        public static bool left_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.left_tpoint_tpoint(temp1, temp2));

        public static bool overabove_stbox_tpoint(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overabove_stbox_tpoint(box, temp));

        public static bool overabove_tpoint_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overabove_tpoint_stbox(temp, box));

        public static bool overabove_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overabove_tpoint_tpoint(temp1, temp2));

        public static bool overafter_stbox_tpoint(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_stbox_tpoint(box, temp));

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

        public static bool overafter_tpoint_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_tpoint_stbox(temp, box));

        public static bool overafter_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_tpoint_tpoint(temp1, temp2));

        public static bool overafter_tstzspan_temporal(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overafter_tstzspan_temporal(s, temp));

        public static bool overback_stbox_tpoint(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overback_stbox_tpoint(box, temp));

        public static bool overback_tpoint_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overback_tpoint_stbox(temp, box));

        public static bool overback_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overback_tpoint_tpoint(temp1, temp2));

        public static bool overbefore_stbox_tpoint(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_stbox_tpoint(box, temp));

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

        public static bool overbefore_tpoint_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_tpoint_stbox(temp, box));

        public static bool overbefore_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_tpoint_tpoint(temp1, temp2));

        public static bool overbefore_tstzspan_temporal(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbefore_tstzspan_temporal(s, temp));

        public static bool overbelow_stbox_tpoint(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbelow_stbox_tpoint(box, temp));

        public static bool overbelow_tpoint_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbelow_tpoint_stbox(temp, box));

        public static bool overbelow_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overbelow_tpoint_tpoint(temp1, temp2));

        public static bool overfront_stbox_tpoint(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overfront_stbox_tpoint(box, temp));

        public static bool overfront_tpoint_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overfront_tpoint_stbox(temp, box));

        public static bool overfront_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overfront_tpoint_tpoint(temp1, temp2));

        public static bool overleft_numspan_tnumber(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_numspan_tnumber(s, temp));

        public static bool overleft_stbox_tpoint(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_stbox_tpoint(box, temp));

        public static bool overleft_tbox_tnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_tbox_tnumber(box, temp));

        public static bool overleft_tnumber_numspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_tnumber_numspan(temp, s));

        public static bool overleft_tnumber_tbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_tnumber_tbox(temp, box));

        public static bool overleft_tnumber_tnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_tnumber_tnumber(temp1, temp2));

        public static bool overleft_tpoint_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_tpoint_stbox(temp, box));

        public static bool overleft_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overleft_tpoint_tpoint(temp1, temp2));

        public static bool overright_numspan_tnumber(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_numspan_tnumber(s, temp));

        public static bool overright_stbox_tpoint(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_stbox_tpoint(box, temp));

        public static bool overright_tbox_tnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_tbox_tnumber(box, temp));

        public static bool overright_tnumber_numspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_tnumber_numspan(temp, s));

        public static bool overright_tnumber_tbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_tnumber_tbox(temp, box));

        public static bool overright_tnumber_tnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_tnumber_tnumber(temp1, temp2));

        public static bool overright_tpoint_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_tpoint_stbox(temp, box));

        public static bool overright_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.overright_tpoint_tpoint(temp1, temp2));

        public static bool right_numspan_tnumber(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_numspan_tnumber(s, temp));

        public static bool right_stbox_tpoint(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_stbox_tpoint(box, temp));

        public static bool right_tbox_tnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_tbox_tnumber(box, temp));

        public static bool right_tnumber_numspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_tnumber_numspan(temp, s));

        public static bool right_tnumber_tbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_tnumber_tbox(temp, box));

        public static bool right_tnumber_tnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_tnumber_tnumber(temp1, temp2));

        public static bool right_tpoint_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_tpoint_stbox(temp, box));

        public static bool right_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => MEOSExternalFunctions.right_tpoint_tpoint(temp1, temp2));

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

        public static double float_degrees(double value, bool normalize)
            => SafeExecution<double>(() => MEOSExternalFunctions.float_degrees(value, normalize));

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

        public static IntPtr tfloat_round(IntPtr temp, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_round(temp, maxdd));

        public static IntPtr tfloatarr_round(IntPtr temp, int count, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloatarr_round(temp, count, maxdd));

        public static IntPtr tfloat_degrees(IntPtr temp, bool normalize)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_degrees(temp, normalize));

        public static IntPtr tfloat_derivative(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_derivative(temp));

        public static IntPtr tfloat_radians(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_radians(temp));

        public static IntPtr tnumber_abs(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_abs(temp));

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

        public static IntPtr ttext_upper(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_upper(temp));

        public static IntPtr ttext_lower(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_lower(temp));

        public static IntPtr distance_tfloat_float(IntPtr temp, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.distance_tfloat_float(temp, d));

        public static IntPtr distance_tint_int(IntPtr temp, int i)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.distance_tint_int(temp, i));

        public static IntPtr distance_tnumber_tnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.distance_tnumber_tnumber(temp1, temp2));

        public static IntPtr distance_tpoint_point(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.distance_tpoint_point(temp, gs));

        public static IntPtr distance_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.distance_tpoint_tpoint(temp1, temp2));

        public static double nad_stbox_geo(IntPtr box, IntPtr gs)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_stbox_geo(box, gs));

        public static double nad_stbox_stbox(IntPtr box1, IntPtr box2)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_stbox_stbox(box1, box2));

        public static double nad_tbox_tbox(IntPtr box1, IntPtr box2)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tbox_tbox(box1, box2));

        public static double nad_tfloat_float(IntPtr temp, double d)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tfloat_float(temp, d));

        public static double nad_tfloat_tfloat(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tfloat_tfloat(temp1, temp2));

        public static int nad_tint_int(IntPtr temp, int i)
            => SafeExecution<int>(() => MEOSExternalFunctions.nad_tint_int(temp, i));

        public static int nad_tint_tint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.nad_tint_tint(temp1, temp2));

        public static double nad_tnumber_tbox(IntPtr temp, IntPtr box)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tnumber_tbox(temp, box));

        public static double nad_tpoint_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tpoint_geo(temp, gs));

        public static double nad_tpoint_stbox(IntPtr temp, IntPtr box)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tpoint_stbox(temp, box));

        public static double nad_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => MEOSExternalFunctions.nad_tpoint_tpoint(temp1, temp2));

        public static IntPtr nai_tpoint_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nai_tpoint_geo(temp, gs));

        public static IntPtr nai_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.nai_tpoint_tpoint(temp1, temp2));

        public static bool shortestline_tpoint_geo(IntPtr temp, IntPtr gs, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.shortestline_tpoint_geo(temp, gs, result));

        public static bool shortestline_tpoint_tpoint(IntPtr temp1, IntPtr temp2, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.shortestline_tpoint_tpoint(temp1, temp2, result));

        public static bool bearing_point_point(IntPtr gs1, IntPtr gs2, IntPtr result)
            => SafeExecution<bool>(() => MEOSExternalFunctions.bearing_point_point(gs1, gs2, result));

        public static IntPtr bearing_tpoint_point(IntPtr temp, IntPtr gs, bool invert)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bearing_tpoint_point(temp, gs, invert));

        public static IntPtr bearing_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.bearing_tpoint_tpoint(temp1, temp2));

        public static IntPtr tpoint_angular_difference(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_angular_difference(temp));

        public static IntPtr tpoint_azimuth(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_azimuth(temp));

        public static IntPtr tpoint_convex_hull(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_convex_hull(temp));

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

        public static int tpoint_srid(IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.tpoint_srid(temp));

        public static IntPtr tpoint_stboxes(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_stboxes(temp, count));

        public static IntPtr tpoint_trajectory(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_trajectory(temp));

        public static IntPtr geo_expand_space(IntPtr gs, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geo_expand_space(gs, d));

        public static IntPtr geomeas_to_tpoint(IntPtr gs)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.geomeas_to_tpoint(gs));

        public static IntPtr tgeogpoint_to_tgeompoint(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeogpoint_to_tgeompoint(temp));

        public static IntPtr tgeompoint_to_tgeogpoint(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tgeompoint_to_tgeogpoint(temp));

        public static IntPtr tpoint_expand_space(IntPtr temp, double d)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_expand_space(temp, d));

        public static IntPtr tpoint_make_simple(IntPtr temp, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_make_simple(temp, count));

        public static IntPtr tpoint_round(IntPtr temp, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_round(temp, maxdd));

        public static IntPtr tpointarr_round(IntPtr temp, int count, int maxdd)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpointarr_round(temp, count, maxdd));

        public static IntPtr tpoint_set_srid(IntPtr temp, int srid)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_set_srid(temp, srid));

        public static int econtains_geo_tpoint(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => MEOSExternalFunctions.econtains_geo_tpoint(gs, temp));

        public static int edisjoint_tpoint_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.edisjoint_tpoint_geo(temp, gs));

        public static int edisjoint_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.edisjoint_tpoint_tpoint(temp1, temp2));

        public static int edwithin_tpoint_geo(IntPtr temp, IntPtr gs, double dist)
            => SafeExecution<int>(() => MEOSExternalFunctions.edwithin_tpoint_geo(temp, gs, dist));

        public static int edwithin_tpoint_tpoint(IntPtr temp1, IntPtr temp2, double dist)
            => SafeExecution<int>(() => MEOSExternalFunctions.edwithin_tpoint_tpoint(temp1, temp2, dist));

        public static int eintersects_tpoint_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.eintersects_tpoint_geo(temp, gs));

        public static int eintersects_tpoint_tpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => MEOSExternalFunctions.eintersects_tpoint_tpoint(temp1, temp2));

        public static int etouches_tpoint_geo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => MEOSExternalFunctions.etouches_tpoint_geo(temp, gs));

        public static IntPtr tcontains_geo_tpoint(IntPtr gs, IntPtr temp, bool restr, bool atvalue)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tcontains_geo_tpoint(gs, temp, restr, atvalue));

        public static IntPtr tdisjoint_tpoint_geo(IntPtr temp, IntPtr gs, bool restr, bool atvalue)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdisjoint_tpoint_geo(temp, gs, restr, atvalue));

        public static IntPtr tdwithin_tpoint_geo(IntPtr temp, IntPtr gs, double dist, bool restr, bool atvalue)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdwithin_tpoint_geo(temp, gs, dist, restr, atvalue));

        public static IntPtr tdwithin_tpoint_tpoint(IntPtr temp1, IntPtr temp2, double dist, bool restr, bool atvalue)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tdwithin_tpoint_tpoint(temp1, temp2, dist, restr, atvalue));

        public static IntPtr tintersects_tpoint_geo(IntPtr temp, IntPtr gs, bool restr, bool atvalue)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintersects_tpoint_geo(temp, gs, restr, atvalue));

        public static IntPtr ttouches_tpoint_geo(IntPtr temp, IntPtr gs, bool restr, bool atvalue)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttouches_tpoint_geo(temp, gs, restr, atvalue));

        public static IntPtr tbool_tand_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbool_tand_transfn(state, temp));

        public static IntPtr tbool_tor_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tbool_tor_transfn(state, temp));

        public static IntPtr temporal_extent_transfn(IntPtr s, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_extent_transfn(s, temp));

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

        public static IntPtr tint_tmax_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_tmax_transfn(state, temp));

        public static IntPtr tint_tmin_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_tmin_transfn(state, temp));

        public static IntPtr tint_tsum_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_tsum_transfn(state, temp));

        public static IntPtr tnumber_extent_transfn(IntPtr box, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_extent_transfn(box, temp));

        public static double tnumber_integral(IntPtr temp)
            => SafeExecution<double>(() => MEOSExternalFunctions.tnumber_integral(temp));

        public static IntPtr tnumber_tavg_finalfn(IntPtr state)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_tavg_finalfn(state));

        public static IntPtr tnumber_tavg_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tnumber_tavg_transfn(state, temp));

        public static double tnumber_twavg(IntPtr temp)
            => SafeExecution<double>(() => MEOSExternalFunctions.tnumber_twavg(temp));

        public static IntPtr tpoint_extent_transfn(IntPtr box, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_extent_transfn(box, temp));

        public static IntPtr tpoint_tcentroid_finalfn(IntPtr state)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_tcentroid_finalfn(state));

        public static IntPtr tpoint_tcentroid_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_tcentroid_transfn(state, temp));

        public static IntPtr tpoint_twcentroid(IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_twcentroid(temp));

        public static IntPtr ttext_tmax_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_tmax_transfn(state, temp));

        public static IntPtr ttext_tmin_transfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.ttext_tmin_transfn(state, temp));

        public static IntPtr temporal_tprecision(IntPtr temp, IntPtr duration, DateTimeOffset origin)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_tprecision(temp, duration, origin));

        public static IntPtr temporal_tsample(IntPtr temp, IntPtr duration, DateTimeOffset origin)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_tsample(temp, duration, origin));

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

        public static double float_bucket(double value, double size, double origin)
            => SafeExecution<double>(() => MEOSExternalFunctions.float_bucket(value, size, origin));

        public static IntPtr floatspan_bucket_list(IntPtr bounds, double size, double origin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.floatspan_bucket_list(bounds, size, origin, count));

        public static int int_bucket(int value, int size, int origin)
            => SafeExecution<int>(() => MEOSExternalFunctions.int_bucket(value, size, origin));

        public static IntPtr intspan_bucket_list(IntPtr bounds, int size, int origin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.intspan_bucket_list(bounds, size, origin, count));

        public static IntPtr tstzspan_bucket_list(IntPtr bounds, IntPtr duration, DateTimeOffset origin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tstzspan_bucket_list(bounds, duration, origin, count));

        public static IntPtr stbox_tile(IntPtr point, DateTimeOffset t, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, DateTimeOffset torigin, bool hast)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_tile(point, t, xsize, ysize, zsize, duration, sorigin, torigin, hast));

        public static IntPtr stbox_tile_list(IntPtr bounds, double xsize, double ysize, double zsize, IntPtr duration, IntPtr sorigin, DateTimeOffset torigin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.stbox_tile_list(bounds, xsize, ysize, zsize, duration, sorigin, torigin, count));

        public static IntPtr tintbox_tile_list(IntPtr box, int xsize, IntPtr duration, int xorigin, DateTimeOffset torigin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tintbox_tile_list(box, xsize, duration, xorigin, torigin, count));

        public static IntPtr tfloatbox_tile_list(IntPtr box, double xsize, IntPtr duration, double xorigin, DateTimeOffset torigin, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloatbox_tile_list(box, xsize, duration, xorigin, torigin, count));

        public static IntPtr temporal_time_split(IntPtr temp, IntPtr duration, DateTimeOffset torigin, IntPtr time_buckets, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.temporal_time_split(temp, duration, torigin, time_buckets, count));

        public static IntPtr tfloat_value_split(IntPtr temp, double size, double origin, IntPtr value_buckets, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_value_split(temp, size, origin, value_buckets, count));

        public static IntPtr tfloat_value_time_split(IntPtr temp, double size, IntPtr duration, double vorigin, DateTimeOffset torigin, IntPtr value_buckets, IntPtr time_buckets, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tfloat_value_time_split(temp, size, duration, vorigin, torigin, value_buckets, time_buckets, count));

        public static DateTimeOffset timestamptz_bucket(DateTimeOffset timestamp, IntPtr duration, DateTimeOffset origin)
            => SafeExecution<DateTimeOffset>(() => MEOSExternalFunctions.timestamptz_bucket(timestamp, duration, origin));

        public static IntPtr tint_value_split(IntPtr temp, int size, int origin, IntPtr value_buckets, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_value_split(temp, size, origin, value_buckets, count));

        public static IntPtr tint_value_time_split(IntPtr temp, int size, IntPtr duration, int vorigin, DateTimeOffset torigin, IntPtr value_buckets, IntPtr time_buckets, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tint_value_time_split(temp, size, duration, vorigin, torigin, value_buckets, time_buckets, count));

        public static IntPtr tpoint_space_split(IntPtr temp, float xsize, float ysize, float zsize, IntPtr sorigin, bool bitmatrix, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_space_split(temp, xsize, ysize, zsize, sorigin, bitmatrix, count));

        public static IntPtr tpoint_space_time_split(IntPtr temp, float xsize, float ysize, float zsize, IntPtr duration, IntPtr sorigin, DateTimeOffset torigin, bool bitmatrix, IntPtr time_buckets, IntPtr count)
            => SafeExecution<IntPtr>(() => MEOSExternalFunctions.tpoint_space_time_split(temp, xsize, ysize, zsize, duration, sorigin, torigin, bitmatrix, time_buckets, count));
    }
}
