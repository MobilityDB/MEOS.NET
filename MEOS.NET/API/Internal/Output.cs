using System.Runtime.InteropServices;

namespace MEOS.NET.API.Internal
{
	public class MEOSFunctions
	{
		private const string DllPath = @"API\\Internal\\libmeos.so";

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern void meos_initialize(const char *tz_str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern void meos_finalize(void);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool bool_in(const char *in_str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *bool_out(bool b);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern text *cstring2text(const char *cstring);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern DateADT pg_date_in(const char *str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *pg_date_out(DateADT date);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int pg_interval_cmp(const Interval *interval1, const Interval *interval2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Interval *pg_interval_in(const char *str, int32 typmod);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Interval *pg_interval_make(int32 years, int32 months, int32 weeks, int32 days, int32 hours, int32 mins, double secs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Interval *pg_interval_mul(const Interval *span, double factor);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *pg_interval_out(const Interval *span);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Interval *pg_interval_pl(const Interval *span1, const Interval *span2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TimeADT pg_time_in(const char *str, int32 typmod);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *pg_time_out(TimeADT time);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Timestamp pg_timestamp_in(const char *str, int32 typmod);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Interval *pg_timestamp_mi(TimestampTz dt1, TimestampTz dt2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TimestampTz pg_timestamp_mi_interval(TimestampTz timestamp, const Interval *span);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *pg_timestamp_out(Timestamp dt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TimestampTz pg_timestamp_pl_interval(TimestampTz timestamp, const Interval *span);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TimestampTz pg_timestamptz_in(const char *str, int32 typmod);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *pg_timestamptz_out(TimestampTz dt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *text2cstring(const text *textptr);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bytea *gserialized_as_ewkb(const GSERIALIZED *geom, char *type);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *gserialized_as_ewkt(const GSERIALIZED *geom, int precision);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *gserialized_as_geojson(const GSERIALIZED *geom, int option, int precision, char *srs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *gserialized_as_hexewkb(const GSERIALIZED *geom, const char *type);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *gserialized_as_text(const GSERIALIZED *geom, int precision);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern GSERIALIZED *gserialized_from_ewkb(const bytea *bytea_wkb, int32 srid);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern GSERIALIZED *gserialized_from_geojson(const char *geojson);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern GSERIALIZED *gserialized_from_hexewkb(const char *wkt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern GSERIALIZED *gserialized_from_text(char *wkt, int srid);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern GSERIALIZED *gserialized_in(char *input, int32 geom_typmod);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *gserialized_out(const GSERIALIZED *geom);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool pgis_gserialized_same(const GSERIALIZED *geom1, const GSERIALIZED *geom2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *bigintset_in(const char *str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *bigintset_out(const Set *set);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *bigintspan_in(const char *str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *bigintspan_out(const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *bigintspanset_in(const char *str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *bigintspanset_out(const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *floatset_in(const char *str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *floatset_out(const Set *set, int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *floatspan_in(const char *str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *floatspan_out(const Span *s, int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *floatspanset_in(const char *str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *floatspanset_out(const SpanSet *ss, int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *geogset_in(const char *str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *geogset_out(const Set *set, int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *geomset_in(const char *str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *geomset_out(const Set *set, int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *geoset_as_ewkt(const Set *set, int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *geoset_as_text(const Set *set, int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *intset_in(const char *str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *intset_out(const Set *set);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *intspan_in(const char *str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *intspan_out(const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *intspanset_in(const char *str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *intspanset_out(const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *period_in(const char *str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *period_out(const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *periodset_in(const char *str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *periodset_out(const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *set_as_hexwkb(const Set *s, uint8_t variant, size_t *size_out);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern uint8_t *set_as_wkb(const Set *s, uint8_t variant, size_t *size_out);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *set_from_hexwkb(const char *hexwkb);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *set_from_wkb(const uint8_t *wkb, size_t size);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *set_out(const Set *s, int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern uint8_t *span_as_wkb(const Span *s, uint8_t variant, size_t *size_out);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *span_as_hexwkb(const Span *s, uint8_t variant, size_t *size_out);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *span_from_hexwkb(const char *hexwkb);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *span_from_wkb(const uint8_t *wkb, size_t size);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *span_out(const Span *s, int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern uint8_t *spanset_as_wkb(const SpanSet *ss, uint8_t variant, size_t *size_out);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *spanset_as_hexwkb(const SpanSet *ss, uint8_t variant, size_t *size_out);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *spanset_from_hexwkb(const char *hexwkb);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *spanset_from_wkb(const uint8_t *wkb, size_t size);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *spanset_out(const SpanSet *ss, int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *textset_in(const char *str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *textset_out(const Set *set);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *timestampset_in(const char *str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *timestampset_out(const Set *set);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *bigintset_make(const int64 *values, int count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *bigintspan_make(int64 lower, int64 upper, bool lower_inc, bool upper_inc);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *floatset_make(const double *values, int count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *floatspan_make(double lower, double upper, bool lower_inc, bool upper_inc);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *geogset_make(const GSERIALIZED **values, int count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *geomset_make(const GSERIALIZED **values, int count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *intset_make(const int *values, int count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *intspan_make(int lower, int upper, bool lower_inc, bool upper_inc);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *period_make(TimestampTz lower, TimestampTz upper, bool lower_inc, bool upper_inc);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *set_copy(const Set *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *span_copy(const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *spanset_copy(const SpanSet *ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *spanset_make(Span *spans, int count, bool normalize);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *spanset_make_exp(Span *spans, int count, int maxcount, bool normalize, bool ordered);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *spanset_make_free(Span *spans, int count, bool normalize);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *textset_make(const text **values, int count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *timestampset_make(const TimestampTz *values, int count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *bigint_to_bigintset(int64 i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *bigint_to_bigintspan(int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *bigint_to_bigintspanset(int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *float_to_floatset(double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *float_to_floatspan(double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *float_to_floatspanset(double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *int_to_intset(int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *int_to_intspan(int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *int_to_intspanset(int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *set_to_spanset(const Set *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *span_to_spanset(const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *timestamp_to_period(TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *timestamp_to_periodset(TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *timestamp_to_tstzset(TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int64 bigintset_end_value(const Set *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int64 bigintset_start_value(const Set *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool bigintset_value_n(const Set *s, int n, int64 *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int64 *bigintset_values(const Set *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int bigintspan_lower(const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int bigintspan_upper(const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int bigintspanset_lower(const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int bigintspanset_upper(const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double floatset_end_value(const Set *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double floatset_start_value(const Set *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool floatset_value_n(const Set *s, int n, double *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double *floatset_values(const Set *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double floatspan_lower(const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double floatspan_upper(const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double floatspanset_lower(const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double floatspanset_upper(const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int geoset_srid(const Set *set);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int intset_end_value(const Set *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int intset_start_value(const Set *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool intset_value_n(const Set *s, int n, int *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int *intset_values(const Set *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int intspan_lower(const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int intspan_upper(const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int intspanset_lower(const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int intspanset_upper(const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Interval *period_duration(const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TimestampTz period_lower(const Span *p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TimestampTz period_upper(const Span *p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Interval *periodset_duration(const SpanSet *ps, bool boundspan);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TimestampTz periodset_end_timestamp(const SpanSet *ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TimestampTz periodset_lower(const SpanSet *ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int periodset_num_timestamps(const SpanSet *ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TimestampTz periodset_start_timestamp(const SpanSet *ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool periodset_timestamp_n(const SpanSet *ps, int n, TimestampTz *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TimestampTz *periodset_timestamps(const SpanSet *ps, int *count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TimestampTz periodset_upper(const SpanSet *ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern uint32 set_hash(const Set *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern uint64 set_hash_extended(const Set *s, uint64 seed);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int set_mem_size(const Set *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int set_num_values(const Set *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *set_span(const Set *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern uint32 span_hash(const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern uint64 span_hash_extended(const Span *s, uint64 seed);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool span_lower_inc(const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool span_upper_inc(const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double span_width(const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *spanset_end_span(const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern uint32 spanset_hash(const SpanSet *ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern uint64 spanset_hash_extended(const SpanSet *ps, uint64 seed);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool spanset_lower_inc(const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int spanset_mem_size(const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int spanset_num_spans(const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *spanset_span(const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *spanset_span_n(const SpanSet *ss, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern const Span **spanset_spans(const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *spanset_start_span(const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool spanset_upper_inc(const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double spanset_width(const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern STBox *spatialset_stbox(const Set *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TimestampTz timestampset_end_timestamp(const Set *ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TimestampTz timestampset_start_timestamp(const Set *ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool timestampset_timestamp_n(const Set *ts, int n, TimestampTz *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TimestampTz *timestampset_values(const Set *ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern void floatspan_set_intspan(const Span *s1, Span *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern void intspan_set_floatspan(const Span *s1, Span *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern void numspan_set_floatspan(const Span *s1, Span *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *period_tprecision(const Span *s, const Interval *duration, TimestampTz torigin);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *periodset_tprecision(const SpanSet *ss, const Interval *duration, TimestampTz torigin);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *period_shift_tscale(const Span *p, const Interval *shift, const Interval *duration);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *periodset_shift_tscale(const SpanSet *ps, const Interval *shift, const Interval *duration);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *set_shift(const Set *s, Datum shift);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern void span_expand(const Span *s1, Span *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TimestampTz timestamp_tprecision(TimestampTz t, const Interval *duration, TimestampTz torigin);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *timestampset_shift_tscale(const Set *ts, const Interval *shift, const Interval *duration);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool adjacent_bigintspan_bigint(const Span *s, int64 i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool adjacent_bigintspanset_bigint(const SpanSet *ss, int64 i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool adjacent_floatspan_float(const Span *s, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool adjacent_intspan_int(const Span *s, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool adjacent_period_timestamp(const Span *p, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool adjacent_periodset_timestamp(const SpanSet *ps, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool adjacent_span_span(const Span *s1, const Span *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool adjacent_spanset_span(const SpanSet *ss, const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool adjacent_spanset_spanset(const SpanSet *ss1, const SpanSet *ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_bigint_bigintset(int64 i, const Set *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_bigint_bigintspan(int64 i, const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_bigint_bigintspanset(int64 i, const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_float_floatset(double d, const Set *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_float_floatspan(double d, const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_float_floatspanset(double d, const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_int_intset(int i, const Set *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_int_intspanset (int i, const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_int_intspan(int i, const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_set_set(const Set *s1, const Set *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_span_span(const Span *s1, const Span *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_span_spanset(const Span *s, const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_spanset_span(const SpanSet *ss, const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_spanset_spanset(const SpanSet *ss1, const SpanSet *ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_timestamp_period(TimestampTz t, const Span *p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_timestamp_timestampset(TimestampTz t, const Set *ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contains_floatspan_float(const Span *s, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contains_floatspanset_float(const SpanSet *ss, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contains_intspan_int(const Span *s, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contains_set_set(const Set *s1, const Set *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contains_period_timestamp(const Span *p, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contains_periodset_timestamp(const SpanSet *ps, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contains_span_span(const Span *s1, const Span *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contains_span_spanset(const Span *s, const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contains_spanset_span(const SpanSet *ss, const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contains_spanset_spanset(const SpanSet *ss1, const SpanSet *ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contains_timestampset_timestamp(const Set *ts, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overlaps_set_set(const Set *s1, const Set *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overlaps_span_span(const Span *s1, const Span *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overlaps_spanset_span(const SpanSet *ss, const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overlaps_spanset_spanset(const SpanSet *ss1, const SpanSet *ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool after_timestamp_timestampset(TimestampTz t, const Set *ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool before_periodset_timestamp(const SpanSet *ps, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool before_timestamp_timestampset(TimestampTz t, const Set *ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool left_float_floatspan(double d, const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool left_floatspan_float(const Span *s, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool left_int_intspan(int i, const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool left_intspan_int(const Span *s, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool left_set_set(const Set *s1, const Set *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool left_span_span(const Span *s1, const Span *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool left_span_spanset(const Span *s, const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool left_spanset_span(const SpanSet *ss, const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool left_spanset_spanset(const SpanSet *ss1, const SpanSet *ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overafter_period_timestamp(const Span *p, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overafter_periodset_timestamp(const SpanSet *ps, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overafter_timestamp_period(TimestampTz t, const Span *p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overafter_timestamp_periodset(TimestampTz t, const SpanSet *ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overafter_timestamp_timestampset(TimestampTz t, const Set *ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overbefore_period_timestamp(const Span *p, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overbefore_periodset_timestamp(const SpanSet *ps, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overbefore_timestamp_period(TimestampTz t, const Span *p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overbefore_timestamp_periodset(TimestampTz t, const SpanSet *ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overbefore_timestamp_timestampset(TimestampTz t, const Set *ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overleft_float_floatspan(double d, const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overleft_floatspan_float(const Span *s, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overleft_int_intspan(int i, const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overleft_intspan_int(const Span *s, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overleft_set_set(const Set *s1, const Set *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overleft_span_span(const Span *s1, const Span *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overleft_span_spanset(const Span *s, const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overleft_spanset_span(const SpanSet *ss, const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overleft_spanset_spanset(const SpanSet *ss1, const SpanSet *ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overright_float_floatspan(double d, const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overright_floatspan_float(const Span *s, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overright_int_intspan(int i, const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overright_intspan_int(const Span *s, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overright_set_set(const Set *s1, const Set *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overright_span_span(const Span *s1, const Span *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overright_span_spanset(const Span *s, const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overright_spanset_span(const SpanSet *ss, const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overright_spanset_spanset(const SpanSet *ss1, const SpanSet *ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool right_float_floatspan(double d, const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool right_floatspan_float(const Span *s, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool right_int_intspan(int i, const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool right_intspan_int(const Span *s, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool right_set_set(const Set *s1, const Set *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool right_span_span(const Span *s1, const Span *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool right_span_spanset(const Span *s, const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool right_spanset_span(const SpanSet *ss, const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool right_spanset_spanset(const SpanSet *ss1, const SpanSet *ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern void bbox_union_span_span(const Span *s1, const Span *s2, Span *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *intersection_set_set(const Set *s1, const Set *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool intersection_period_timestamp(const Span *p, TimestampTz t, TimestampTz *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool intersection_periodset_timestamp(const SpanSet *ps, TimestampTz t, TimestampTz *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *intersection_span_span(const Span *s1, const Span *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *intersection_spanset_span(const SpanSet *ss, const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *intersection_spanset_spanset(const SpanSet *ss1, const SpanSet *ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool intersection_timestampset_timestamp(const Set *ts, const TimestampTz t, TimestampTz *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *minus_set_set(const Set *s1, const Set *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *minus_period_timestamp(const Span *p, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *minus_periodset_timestamp(const SpanSet *ps, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *minus_span_span(const Span *s1, const Span *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *minus_span_spanset(const Span *s, const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *minus_spanset_span(const SpanSet *ss, const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *minus_spanset_spanset(const SpanSet *ss1, const SpanSet *ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool minus_timestamp_period(TimestampTz t, const Span *p, TimestampTz *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool minus_timestamp_periodset(TimestampTz t, const SpanSet *ps, TimestampTz *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *minus_timestampset_timestamp(const Set *ts, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *union_set_set(const Set *s1, const Set *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *union_period_timestamp(const Span *p, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *union_periodset_timestamp(SpanSet *ps, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *union_span_span(const Span *s1, const Span *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *union_spanset_span(const SpanSet *ss, const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *union_spanset_spanset(const SpanSet *ss1, const SpanSet *ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *union_timestampset_timestamp(const Set *ts, const TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double distance_floatspan_float(const Span *s, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double distance_intspan_int(const Span *s, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double distance_set_set(const Set *s1, const Set *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double distance_period_timestamp(const Span *p, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double distance_periodset_timestamp(const SpanSet *ps, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double distance_span_span(const Span *s1, const Span *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double distance_spanset_span(const SpanSet *ss, const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double distance_spanset_spanset(const SpanSet *ss1, const SpanSet *ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double distance_timestampset_timestamp(const Set *ts, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *bigint_extent_transfn(Span *s, int64 i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *bigint_union_transfn(Set *state, int64 i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *float_extent_transfn(Span *s, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *float_union_transfn(Set *state, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *int_extent_transfn(Span *s, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *int_union_transfn(Set *state, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SkipList *period_tcount_transfn(SkipList *state, const Span *p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SkipList *periodset_tcount_transfn(SkipList *state, const SpanSet *ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *set_extent_transfn(Span *span, const Set *set);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *set_union_finalfn(Set *state);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *set_union_transfn(Set *state, Set *set);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *span_extent_transfn(Span *s1, const Span *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *span_union_transfn(SpanSet *state, const Span *span);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *spanset_extent_transfn(Span *s, const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *spanset_union_finalfn(SpanSet *state);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *spanset_union_transfn(SpanSet *state, const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *text_union_transfn(Set *state, const text *txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *timestamp_extent_transfn(Span *p, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SkipList *timestamp_tcount_transfn(SkipList *state, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Set *timestamp_union_transfn(Set *state, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SkipList *timestampset_tcount_transfn(SkipList *state, const Set *ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int set_cmp(const Set *s1, const Set *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool set_eq(const Set *s1, const Set *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool set_ge(const Set *s1, const Set *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool set_gt(const Set *s1, const Set *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool set_le(const Set *s1, const Set *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool set_lt(const Set *s1, const Set *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool set_ne(const Set *s1, const Set *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int span_cmp(const Span *s1, const Span *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool span_eq(const Span *s1, const Span *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool span_ge(const Span *s1, const Span *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool span_gt(const Span *s1, const Span *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool span_le(const Span *s1, const Span *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool span_lt(const Span *s1, const Span *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool span_ne(const Span *s1, const Span *s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int spanset_cmp(const SpanSet *ss1, const SpanSet *ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool spanset_eq(const SpanSet *ss1, const SpanSet *ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool spanset_ge(const SpanSet *ss1, const SpanSet *ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool spanset_gt(const SpanSet *ss1, const SpanSet *ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool spanset_le(const SpanSet *ss1, const SpanSet *ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool spanset_lt(const SpanSet *ss1, const SpanSet *ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool spanset_ne(const SpanSet *ss1, const SpanSet *ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TBox *tbox_in(const char *str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *tbox_out(const TBox *box, int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TBox *tbox_from_wkb(const uint8_t *wkb, size_t size);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TBox *tbox_from_hexwkb(const char *hexwkb);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern STBox *stbox_from_wkb(const uint8_t *wkb, size_t size);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern STBox *stbox_from_hexwkb(const char *hexwkb);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern uint8_t *tbox_as_wkb(const TBox *box, uint8_t variant, size_t *size_out);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *tbox_as_hexwkb(const TBox *box, uint8_t variant, size_t *size);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern uint8_t *stbox_as_wkb(const STBox *box, uint8_t variant, size_t *size_out);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *stbox_as_hexwkb(const STBox *box, uint8_t variant, size_t *size);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern STBox *stbox_in(const char *str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *stbox_out(const STBox *box, int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TBox *tbox_make(const Span *s, const Span *p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern void tbox_set(const Span *s, const Span *p, TBox *box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TBox *tbox_copy(const TBox *box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern STBox *stbox_copy(const STBox *box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TBox *int_to_tbox(int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TBox *float_to_tbox(double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TBox *timestamp_to_tbox(TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TBox *timestampset_to_tbox(const Set *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TBox *period_to_tbox(const Span *p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TBox *periodset_to_tbox(const SpanSet *ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TBox *int_timestamp_to_tbox(int i, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TBox *float_period_to_tbox(double d, const Span *p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TBox *float_timestamp_to_tbox(double d, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern STBox *geo_period_to_stbox(const GSERIALIZED *gs, const Span *p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern STBox *geo_timestamp_to_stbox(const GSERIALIZED *gs, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern STBox *geo_to_stbox(const GSERIALIZED *gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TBox *int_period_to_tbox(int i, const Span *p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TBox *numspan_to_tbox(const Span *s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TBox *span_timestamp_to_tbox(const Span *span, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TBox *span_period_to_tbox(const Span *span, const Span *p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *tbox_to_floatspan(const TBox *box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *tbox_to_period(const TBox *box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *stbox_to_period(const STBox *box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TBox *tnumber_to_tbox(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern GSERIALIZED *stbox_to_geo(const STBox *box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern STBox *tpoint_to_stbox(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern STBox *timestamp_to_stbox(TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern STBox *timestampset_to_stbox(const Set *ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern STBox *period_to_stbox(const Span *p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern STBox *periodset_to_stbox(const SpanSet *ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_hasx(const TBox *box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_hast(const TBox *box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_xmin(const TBox *box, double *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_xmin_inc(const TBox *box, bool *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_xmax(const TBox *box, double *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_xmax_inc(const TBox *box, bool *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_tmin(const TBox *box, TimestampTz *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_tmin_inc(const TBox *box, bool *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_tmax(const TBox *box, TimestampTz *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_tmax_inc(const TBox *box, bool *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_hasx(const STBox *box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_hasz(const STBox *box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_hast(const STBox *box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_isgeodetic(const STBox *box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_xmin(const STBox *box, double *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_xmax(const STBox *box, double *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_ymin(const STBox *box, double *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_ymax(const STBox *box, double *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_zmin(const STBox *box, double *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_zmax(const STBox *box, double *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_tmin(const STBox *box, TimestampTz *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_tmin_inc(const STBox *box, bool *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_tmax(const STBox *box, TimestampTz *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_tmax_inc(const STBox *box, bool *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int32 stbox_srid(const STBox *box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern void tbox_expand(const TBox *box1, TBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TBox *tbox_expand_value(const TBox *box, const double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TBox *tbox_expand_time(const TBox *box, const Interval *interval);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern void stbox_expand(const STBox *box1, STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern STBox *stbox_set_srid(const STBox *box, int32 srid);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern STBox *stbox_get_space(const STBox *box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern STBox *stbox_expand_space(const STBox *box, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern STBox *stbox_expand_time(const STBox *box, const Interval *interval);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contains_tbox_tbox(const TBox *box1, const TBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_tbox_tbox(const TBox *box1, const TBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overlaps_tbox_tbox(const TBox *box1, const TBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool same_tbox_tbox(const TBox *box1, const TBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool adjacent_tbox_tbox(const TBox *box1, const TBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contains_stbox_stbox(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_stbox_stbox(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overlaps_stbox_stbox(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool same_stbox_stbox(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool adjacent_stbox_stbox(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool left_tbox_tbox(const TBox *box1, const TBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overleft_tbox_tbox(const TBox *box1, const TBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool right_tbox_tbox(const TBox *box1, const TBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overright_tbox_tbox(const TBox *box1, const TBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool before_tbox_tbox(const TBox *box1, const TBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overbefore_tbox_tbox(const TBox *box1, const TBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool after_tbox_tbox(const TBox *box1, const TBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overafter_tbox_tbox(const TBox *box1, const TBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool left_stbox_stbox(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overleft_stbox_stbox(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool right_stbox_stbox(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overright_stbox_stbox(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool below_stbox_stbox(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overbelow_stbox_stbox(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool above_stbox_stbox(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overabove_stbox_stbox(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool front_stbox_stbox(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overfront_stbox_stbox(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool back_stbox_stbox(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overback_stbox_stbox(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool before_stbox_stbox(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overbefore_stbox_stbox(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool after_stbox_stbox(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overafter_stbox_stbox(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TBox *union_tbox_tbox(const TBox *box1, const TBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool inter_tbox_tbox(const TBox *box1, const TBox *box2, TBox *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TBox *intersection_tbox_tbox(const TBox *box1, const TBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern STBox *union_stbox_stbox(const STBox *box1, const STBox *box2, bool strict);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool inter_stbox_stbox(const STBox *box1, const STBox *box2, STBox *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern STBox *intersection_stbox_stbox(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern STBox *stbox_quad_split(const STBox *box, int *count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_eq(const TBox *box1, const TBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_ne(const TBox *box1, const TBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int tbox_cmp(const TBox *box1, const TBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_lt(const TBox *box1, const TBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_le(const TBox *box1, const TBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_ge(const TBox *box1, const TBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_gt(const TBox *box1, const TBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_eq(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_ne(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int stbox_cmp(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_lt(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_le(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_ge(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_gt(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tbool_in(const char *str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *tbool_out(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *temporal_as_hexwkb(const Temporal *temp, uint8_t variant, size_t *size_out);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *temporal_as_mfjson(const Temporal *temp, bool with_bbox, int flags, int precision, char *srs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern uint8_t *temporal_as_wkb(const Temporal *temp, uint8_t variant, size_t *size_out);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_from_hexwkb(const char *hexwkb);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_from_mfjson(const char *mfjson);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_from_wkb(const uint8_t *wkb, size_t size);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tfloat_in(const char *str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *tfloat_out(const Temporal *temp, int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tgeogpoint_in(const char *str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tgeompoint_in(const char *str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tint_in(const char *str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *tint_out(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *tpoint_as_ewkt(const Temporal *temp, int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *tpoint_as_text(const Temporal *temp, int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *tpoint_out(const Temporal *temp, int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *ttext_in(const char *str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *ttext_out(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tbool_from_base_temp(bool b, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TInstant *tboolinst_make(bool b, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequence *tboolseq_from_base_period(bool b, const Span *p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequence *tboolseq_from_base_timestampset(bool b, const Set *ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequenceSet *tboolseqset_from_base_periodset(bool b, const SpanSet *ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_copy(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tfloat_from_base_temp(double d, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TInstant *tfloatinst_make(double d, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequence *tfloatseq_from_base_period(double d, const Span *p, interpType interp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequence *tfloatseq_from_base_timestampset(double d, const Set *ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequenceSet *tfloatseqset_from_base_periodset(double d, const SpanSet *ps, interpType interp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tgeogpoint_from_base_temp(const GSERIALIZED *gs, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TInstant *tgeogpointinst_make(const GSERIALIZED *gs, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequence *tgeogpointseq_from_base_period(const GSERIALIZED *gs, const Span *p, interpType interp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequence *tgeogpointseq_from_base_timestampset(const GSERIALIZED *gs, const Set *ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequenceSet *tgeogpointseqset_from_base_periodset(const GSERIALIZED *gs, const SpanSet *ps, interpType interp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tgeompoint_from_base_temp(const GSERIALIZED *gs, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TInstant *tgeompointinst_make(const GSERIALIZED *gs, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequence *tgeompointseq_from_base_period(const GSERIALIZED *gs, const Span *p, interpType interp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequence *tgeompointseq_from_base_timestampset(const GSERIALIZED *gs, const Set *ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequenceSet *tgeompointseqset_from_base_periodset(const GSERIALIZED *gs, const SpanSet *ps, interpType interp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tint_from_base_temp(int i, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TInstant *tintinst_make(int i, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequence *tintseq_from_base_period(int i, const Span *p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequence *tintseq_from_base_timestampset(int i, const Set *ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequenceSet *tintseqset_from_base_periodset(int i, const SpanSet *ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequence *tsequence_make(const TInstant **instants, int count, bool lower_inc, bool upper_inc, interpType interp, bool normalize);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequence *tsequence_make_exp(const TInstant **instants, int count, int maxcount, bool lower_inc, bool upper_inc, interpType interp, bool normalize);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequenceSet *tsequenceset_make(const TSequence **sequences, int count, bool normalize);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequenceSet *tsequenceset_make_exp(const TSequence **sequences, int count, int maxcount, bool normalize);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequenceSet *tsequenceset_make_gaps(const TInstant **instants, int count, interpType interp, Interval *maxt, double maxdist);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *ttext_from_base_temp(const text *txt, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TInstant *ttextinst_make(const text *txt, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequence *ttextseq_from_base_period(const text *txt, const Span *p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequence *ttextseq_from_base_timestampset(const text *txt, const Set *ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequenceSet *ttextseqset_from_base_periodset(const text *txt, const SpanSet *ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *temporal_to_period(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tfloat_to_tint(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tint_to_tfloat(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *tnumber_to_span(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbool_end_value(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbool_start_value(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool *tbool_values(const Temporal *temp, int *count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Interval *temporal_duration(const Temporal *temp, bool boundspan);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern const TInstant *temporal_end_instant(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequence *temporal_end_sequence(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TimestampTz temporal_end_timestamp(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern uint32 temporal_hash(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern const TInstant *temporal_instant_n(const Temporal *temp, int n);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern const TInstant **temporal_instants(const Temporal *temp, int *count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *temporal_interp(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern const TInstant *temporal_max_instant(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern const TInstant *temporal_min_instant(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int temporal_num_instants(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int temporal_num_sequences(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int temporal_num_timestamps(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequence **temporal_segments(const Temporal *temp, int *count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequence *temporal_sequence_n(const Temporal *temp, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequence **temporal_sequences(const Temporal *temp, int *count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern const TInstant *temporal_start_instant(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequence *temporal_start_sequence(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TimestampTz temporal_start_timestamp(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TSequenceSet *temporal_stops(const Temporal *temp, double maxdist, const Interval *minduration);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern char *temporal_subtype(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *temporal_time(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool temporal_timestamp_n(const Temporal *temp, int n, TimestampTz *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TimestampTz *temporal_timestamps(const Temporal *temp, int *count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Datum *temporal_values(const Temporal *temp, int *count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double tfloat_end_value(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double tfloat_max_value(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double tfloat_min_value(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double tfloat_start_value(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double *tfloat_values(const Temporal *temp, int *count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int tint_end_value(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int tint_max_value(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int tint_min_value(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int tint_start_value(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int *tint_values(const Temporal *temp, int *count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *tnumber_valuespans(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern GSERIALIZED *tpoint_end_value(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern GSERIALIZED *tpoint_start_value(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern GSERIALIZED **tpoint_values(const Temporal *temp, int *count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern text *ttext_end_value(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern text *ttext_max_value(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern text *ttext_min_value(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern text *ttext_start_value(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern text **ttext_values(const Temporal *temp, int *count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_set_interp(const Temporal *temp, interpType interp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_shift(const Temporal *temp, const Interval *shift);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_shift_tscale(const Temporal *temp, const Interval *shift, const Interval *duration);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_to_tinstant(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_to_tsequence(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_to_tsequenceset(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_tprecision(const Temporal *temp, const Interval *duration, TimestampTz origin);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_tsample(const Temporal *temp, const Interval *duration, TimestampTz origin);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_tscale(const Temporal *temp, const Interval *duration);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tbool_at_value(const Temporal *temp, bool b);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tbool_minus_value(const Temporal *temp, bool b);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbool_value_at_timestamp(const Temporal *temp, TimestampTz t, bool strict, bool *value);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_at_max(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_at_min(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_at_period(const Temporal *temp, const Span *p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_at_periodset(const Temporal *temp, const SpanSet *ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_at_timestamp(const Temporal *temp, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_at_timestampset(const Temporal *temp, const Set *ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_at_values(const Temporal *temp, const Set *set);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_minus_max(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_minus_min(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_minus_period(const Temporal *temp, const Span *p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_minus_periodset(const Temporal *temp, const SpanSet *ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_minus_timestamp(const Temporal *temp, TimestampTz t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_minus_timestampset(const Temporal *temp, const Set *ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_minus_values(const Temporal *temp, const Set *set);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tfloat_at_value(const Temporal *temp, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tfloat_minus_value(const Temporal *temp, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tfloat_value_at_timestamp(const Temporal *temp, TimestampTz t, bool strict, double *value);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tint_at_value(const Temporal *temp, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tint_minus_value(const Temporal *temp, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tint_value_at_timestamp(const Temporal *temp, TimestampTz t, bool strict, int *value);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tnumber_at_span(const Temporal *temp, const Span *span);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tnumber_at_spanset(const Temporal *temp, const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tnumber_at_tbox(const Temporal *temp, const TBox *box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tnumber_minus_span(const Temporal *temp, const Span *span);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tnumber_minus_spanset(const Temporal *temp, const SpanSet *ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tnumber_minus_tbox(const Temporal *temp, const TBox *box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tpoint_at_geom_time(const Temporal *temp, const GSERIALIZED *gs, const Span *zspan, const Span *period);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tpoint_at_stbox(const Temporal *temp, const STBox *box, bool border_inc);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tpoint_at_value(const Temporal *temp, GSERIALIZED *gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tpoint_minus_geom_time(const Temporal *temp, const GSERIALIZED *gs, const Span *zspan, const Span *period);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tpoint_minus_stbox(const Temporal *temp, const STBox *box, bool border_inc);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tpoint_minus_value(const Temporal *temp, GSERIALIZED *gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tpoint_value_at_timestamp(const Temporal *temp, TimestampTz t, bool strict, GSERIALIZED **value);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *ttext_at_value(const Temporal *temp, text *txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *ttext_minus_value(const Temporal *temp, text *txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool ttext_value_at_timestamp(const Temporal *temp, TimestampTz t, bool strict, text **value);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_append_tinstant(Temporal *temp, const TInstant *inst, double maxdist, Interval *maxt, bool expand);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_append_tsequence(Temporal *temp, const TSequence *seq, bool expand);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_delete_period(const Temporal *temp, const Span *p, bool connect);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_delete_periodset(const Temporal *temp, const SpanSet *ps, bool connect);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_delete_timestamp(const Temporal *temp, TimestampTz t, bool connect);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_delete_timestampset(const Temporal *temp, const Set *ts, bool connect);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_insert(const Temporal *temp1, const Temporal *temp2, bool connect);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_merge(const Temporal *temp1, const Temporal *temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_merge_array(Temporal **temparr, int count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_update(const Temporal *temp1, const Temporal *temp2, bool connect);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tand_bool_tbool(bool b, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tand_tbool_bool(const Temporal *temp, bool b);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tand_tbool_tbool(const Temporal *temp1, const Temporal *temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SpanSet *tbool_when_true(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tnot_tbool(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tor_bool_tbool(bool b, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tor_tbool_bool(const Temporal *temp, bool b);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tor_tbool_tbool(const Temporal *temp1, const Temporal *temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *add_float_tfloat(double d, const Temporal *tnumber);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *add_int_tint(int i, const Temporal *tnumber);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *add_tfloat_float(const Temporal *tnumber, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *add_tint_int(const Temporal *tnumber, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *add_tnumber_tnumber(const Temporal *tnumber1, const Temporal *tnumber2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *div_float_tfloat(double d, const Temporal *tnumber);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *div_int_tint(int i, const Temporal *tnumber);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *div_tfloat_float(const Temporal *tnumber, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *div_tint_int(const Temporal *tnumber, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *div_tnumber_tnumber(const Temporal *tnumber1, const Temporal *tnumber2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double float_degrees(double value, bool normalize);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *mult_float_tfloat(double d, const Temporal *tnumber);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *mult_int_tint(int i, const Temporal *tnumber);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *mult_tfloat_float(const Temporal *tnumber, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *mult_tint_int(const Temporal *tnumber, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *mult_tnumber_tnumber(const Temporal *tnumber1, const Temporal *tnumber2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *sub_float_tfloat(double d, const Temporal *tnumber);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *sub_int_tint(int i, const Temporal *tnumber);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *sub_tfloat_float(const Temporal *tnumber, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *sub_tint_int(const Temporal *tnumber, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *sub_tnumber_tnumber(const Temporal *tnumber1, const Temporal *tnumber2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tfloat_degrees(const Temporal *temp, bool normalize);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tfloat_derivative(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tfloat_radians(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tnumber_abs(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tnumber_angular_difference(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tnumber_delta_value(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *textcat_text_ttext(const text *txt, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *textcat_ttext_text(const Temporal *temp, const text *txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *textcat_ttext_ttext(const Temporal *temp1, const Temporal *temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *ttext_upper(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *ttext_lower(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *distance_tfloat_float(const Temporal *temp, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *distance_tint_int(const Temporal *temp, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *distance_tnumber_tnumber(const Temporal *temp1, const Temporal *temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *distance_tpoint_geo(const Temporal *temp, const GSERIALIZED *geo);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *distance_tpoint_tpoint(const Temporal *temp1, const Temporal *temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double nad_stbox_geo(const STBox *box, const GSERIALIZED *gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double nad_stbox_stbox(const STBox *box1, const STBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double nad_tbox_tbox(const TBox *box1, const TBox *box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double nad_tfloat_float(const Temporal *temp, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double nad_tfloat_tfloat(const Temporal *temp1, const Temporal *temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int nad_tint_int(const Temporal *temp, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int nad_tint_tint(const Temporal *temp1, const Temporal *temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double nad_tnumber_tbox(const Temporal *temp, const TBox *box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double nad_tpoint_geo(const Temporal *temp, const GSERIALIZED *gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double nad_tpoint_stbox(const Temporal *temp, const STBox *box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double nad_tpoint_tpoint(const Temporal *temp1, const Temporal *temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TInstant *nai_tpoint_geo(const Temporal *temp, const GSERIALIZED *gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TInstant *nai_tpoint_tpoint(const Temporal *temp1, const Temporal *temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool shortestline_tpoint_geo(const Temporal *temp, const GSERIALIZED *gs, GSERIALIZED **result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool shortestline_tpoint_tpoint(const Temporal *temp1, const Temporal *temp2, GSERIALIZED **result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbool_always_eq(const Temporal *temp, bool b);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbool_ever_eq(const Temporal *temp, bool b);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tfloat_always_eq(const Temporal *temp, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tfloat_always_le(const Temporal *temp, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tfloat_always_lt(const Temporal *temp, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tfloat_ever_eq(const Temporal *temp, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tfloat_ever_le(const Temporal *temp, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tfloat_ever_lt(const Temporal *temp, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tgeogpoint_always_eq(const Temporal *temp, GSERIALIZED *gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tgeogpoint_ever_eq(const Temporal *temp, GSERIALIZED *gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tgeompoint_always_eq(const Temporal *temp, GSERIALIZED *gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tgeompoint_ever_eq(const Temporal *temp, GSERIALIZED *gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tint_always_eq(const Temporal *temp, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tint_always_le(const Temporal *temp, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tint_always_lt(const Temporal *temp, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tint_ever_eq(const Temporal *temp, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tint_ever_le(const Temporal *temp, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tint_ever_lt(const Temporal *temp, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tpoint_always_eq(const Temporal *temp, Datum value);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tpoint_ever_eq(const Temporal *temp, Datum value);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool ttext_always_eq(const Temporal *temp, text *txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool ttext_always_le(const Temporal *temp, text *txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool ttext_always_lt(const Temporal *temp, text *txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool ttext_ever_eq(const Temporal *temp, text *txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool ttext_ever_le(const Temporal *temp, text *txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool ttext_ever_lt(const Temporal *temp, text *txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int temporal_cmp(const Temporal *temp1, const Temporal *temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool temporal_eq(const Temporal *temp1, const Temporal *temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool temporal_ge(const Temporal *temp1, const Temporal *temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool temporal_gt(const Temporal *temp1, const Temporal *temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool temporal_le(const Temporal *temp1, const Temporal *temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool temporal_lt(const Temporal *temp1, const Temporal *temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool temporal_ne(const Temporal *temp1, const Temporal *temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *teq_bool_tbool(bool b, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *teq_float_tfloat(double d, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *teq_geo_tpoint(const GSERIALIZED *geo, const Temporal *tpoint);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *teq_int_tint(int i, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *teq_point_tgeogpoint(const GSERIALIZED *gs, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *teq_point_tgeompoint(const GSERIALIZED *gs, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *teq_tbool_bool(const Temporal *temp, bool b);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *teq_temporal_temporal(const Temporal *temp1, const Temporal *temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *teq_text_ttext(const text *txt, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *teq_tfloat_float(const Temporal *temp, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *teq_tgeogpoint_point(const Temporal *temp, const GSERIALIZED *gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *teq_tgeompoint_point(const Temporal *temp, const GSERIALIZED *gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *teq_tint_int(const Temporal *temp, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *teq_tpoint_geo(const Temporal *tpoint, const GSERIALIZED *geo);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *teq_ttext_text(const Temporal *temp, const text *txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tge_float_tfloat(double d, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tge_int_tint(int i, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tge_temporal_temporal(const Temporal *temp1, const Temporal *temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tge_text_ttext(const text *txt, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tge_tfloat_float(const Temporal *temp, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tge_tint_int(const Temporal *temp, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tge_ttext_text(const Temporal *temp, const text *txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tgt_float_tfloat(double d, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tgt_int_tint(int i, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tgt_temporal_temporal(const Temporal *temp1, const Temporal *temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tgt_text_ttext(const text *txt, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tgt_tfloat_float(const Temporal *temp, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tgt_tint_int(const Temporal *temp, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tgt_ttext_text(const Temporal *temp, const text *txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tle_float_tfloat(double d, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tle_int_tint(int i, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tle_temporal_temporal(const Temporal *temp1, const Temporal *temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tle_text_ttext(const text *txt, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tle_tfloat_float(const Temporal *temp, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tle_tint_int(const Temporal *temp, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tle_ttext_text(const Temporal *temp, const text *txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tlt_float_tfloat(double d, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tlt_int_tint(int i, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tlt_temporal_temporal(const Temporal *temp1, const Temporal *temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tlt_text_ttext(const text *txt, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tlt_tfloat_float(const Temporal *temp, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tlt_tint_int(const Temporal *temp, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tlt_ttext_text(const Temporal *temp, const text *txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tne_bool_tbool(bool b, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tne_float_tfloat(double d, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tne_geo_tpoint(const GSERIALIZED *geo, const Temporal *tpoint);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tne_int_tint(int i, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tne_point_tgeogpoint(const GSERIALIZED *gs, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tne_point_tgeompoint(const GSERIALIZED *gs, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tne_tbool_bool(const Temporal *temp, bool b);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tne_temporal_temporal(const Temporal *temp1, const Temporal *temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tne_text_ttext(const text *txt, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tne_tfloat_float(const Temporal *temp, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tne_tgeogpoint_point(const Temporal *temp, const GSERIALIZED *gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tne_tgeompoint_point(const Temporal *temp, const GSERIALIZED *gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tne_tint_int(const Temporal *temp, int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tne_tpoint_geo(const Temporal *tpoint, const GSERIALIZED *geo);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tne_ttext_text(const Temporal *temp, const text *txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool bearing_point_point(const GSERIALIZED *geo1, const GSERIALIZED *geo2, double *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *bearing_tpoint_point(const Temporal *temp, const GSERIALIZED *gs, bool invert);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *bearing_tpoint_tpoint(const Temporal *temp1, const Temporal *temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tpoint_angular_difference(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tpoint_azimuth(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern GSERIALIZED *tpoint_convex_hull(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tpoint_cumulative_length(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tpoint_direction(const Temporal *temp, double *result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tpoint_get_coord(const Temporal *temp, int coord);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tpoint_is_simple(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double tpoint_length(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tpoint_speed(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int tpoint_srid(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern STBox *tpoint_stboxes(const Temporal *temp, int *count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern GSERIALIZED *tpoint_trajectory(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern STBox *geo_expand_space(const GSERIALIZED *gs, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tgeompoint_tgeogpoint(const Temporal *temp, bool oper);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern STBox *tpoint_expand_space(const Temporal *temp, double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal **tpoint_make_simple(const Temporal *temp, int *count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tpoint_set_srid(const Temporal *temp, int32 srid);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int econtains_geo_tpoint(const GSERIALIZED *geo, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int edisjoint_tpoint_geo(const Temporal *temp, const GSERIALIZED *gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int edisjoint_tpoint_tpoint(const Temporal *temp1, const Temporal *temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int edwithin_tpoint_geo(const Temporal *temp, const GSERIALIZED *gs, double dist);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int edwithin_tpoint_tpoint(const Temporal *temp1, const Temporal *temp2, double dist);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int eintersects_tpoint_geo(const Temporal *temp, const GSERIALIZED *gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int eintersects_tpoint_tpoint(const Temporal *temp1, const Temporal *temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int etouches_tpoint_geo(const Temporal *temp, const GSERIALIZED *gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tcontains_geo_tpoint(const GSERIALIZED *gs, const Temporal *temp, bool restr, bool atvalue);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tdisjoint_tpoint_geo(const Temporal *temp, const GSERIALIZED *geo, bool restr, bool atvalue);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tdwithin_tpoint_geo(const Temporal *temp, const GSERIALIZED *gs, double dist, bool restr, bool atvalue);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tdwithin_tpoint_tpoint(const Temporal *temp1, const Temporal *temp2, double dist, bool restr, bool atvalue);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tintersects_tpoint_geo(const Temporal *temp, const GSERIALIZED *geo, bool restr, bool atvalue);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *ttouches_tpoint_geo(const Temporal *temp, const GSERIALIZED *gs, bool restr, bool atvalue);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SkipList *tbool_tand_transfn(SkipList *state, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SkipList *tbool_tor_transfn(SkipList *state, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *temporal_extent_transfn(Span *p, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *temporal_tagg_finalfn(SkipList *state);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SkipList *temporal_tcount_transfn(SkipList *state, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SkipList *tfloat_tmax_transfn(SkipList *state, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SkipList *tfloat_tmin_transfn(SkipList *state, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SkipList *tfloat_tsum_transfn(SkipList *state, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SkipList *tint_tmax_transfn(SkipList *state, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SkipList *tint_tmin_transfn(SkipList *state, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SkipList *tint_tsum_transfn(SkipList *state, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TBox *tnumber_extent_transfn(TBox *box, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double tnumber_integral(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tnumber_tavg_finalfn(SkipList *state);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SkipList *tnumber_tavg_transfn(SkipList *state, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double tnumber_twavg(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern STBox *tpoint_extent_transfn(STBox *box, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal *tpoint_tcentroid_finalfn(SkipList *state);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SkipList *tpoint_tcentroid_transfn(SkipList *state, Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern GSERIALIZED *tpoint_twcentroid(const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SkipList *ttext_tmax_transfn(SkipList *state, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern SkipList *ttext_tmin_transfn(SkipList *state, const Temporal *temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double float_bucket(double value, double size, double origin);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *floatspan_bucket_list(const Span *bounds, double size, double origin, int *newcount);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int int_bucket(int value, int size, int origin);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *intspan_bucket_list(const Span *bounds, int size, int origin, int *newcount);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Span *period_bucket_list(const Span *bounds, const Interval *duration, TimestampTz origin, int *newcount);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern STBox *stbox_tile_list(const STBox *bounds, double xsize, double ysize, double zsize, const Interval *duration, GSERIALIZED *sorigin, TimestampTz torigin, int **cellcount);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TBox *tbox_tile_list(const TBox *bounds, double xsize, const Interval *duration, double xorigin, TimestampTz torigin, int *rows, int *columns);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal **temporal_time_split(Temporal *temp, Interval *duration, TimestampTz torigin, int *newcount);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal **tfloat_value_split(Temporal *temp, double size, double origin, int *newcount);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal **tfloat_value_time_split(Temporal *temp, double size, double vorigin, Interval *duration, TimestampTz torigin, int *newcount);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern TimestampTz timestamptz_bucket(TimestampTz timestamp, const Interval *duration, TimestampTz origin);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal **tint_value_split(Temporal *temp, int size, int origin, int *newcount);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Temporal **tint_value_time_split(Temporal *temp, int size, int vorigin, Interval *duration, TimestampTz torigin, int *newcount);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double temporal_dyntimewarp_distance(const Temporal *temp1, const Temporal *temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Match *temporal_dyntimewarp_path(const Temporal *temp1, const Temporal *temp2, int *count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double temporal_frechet_distance(const Temporal *temp1, const Temporal *temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern Match *temporal_frechet_path(const Temporal *temp1, const Temporal *temp2, int *count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double temporal_hausdorff_distance(const Temporal *temp1, const Temporal *temp2);

	}
}
