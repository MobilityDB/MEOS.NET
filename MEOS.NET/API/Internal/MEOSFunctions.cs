using System.Runtime.InteropServices;

namespace MEOS.NET.API.Internal
{
	public static class MEOSFunctions
	{
		private const string DllPath = @"API\\Internal\\libmeos.so";

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern void meos_initialize(string tz_str);

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
		public static extern string pg_date_out(long date);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int pg_interval_cmp(IntPtr interval1,IntPtr interval2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr pg_interval_in(string str,int typmod);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr pg_interval_make(int years,int months,int weeks,int days,int hours,int mins,double secs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr pg_interval_mul(IntPtr span,double factor);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string pg_interval_out(IntPtr span);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr pg_interval_pl(IntPtr span1,IntPtr span2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int pg_time_in(string str,int typmod);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string pg_time_out(int time);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern DateTime pg_timestamp_in(string str,int typmod);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr pg_timestamp_mi(DateTimeOffset dt1,DateTimeOffset dt2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern DateTimeOffset pg_timestamp_mi_interval(DateTimeOffset timestamp,IntPtr span);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string pg_timestamp_out(DateTime dt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern DateTimeOffset pg_timestamp_pl_interval(DateTimeOffset timestamp,IntPtr span);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern DateTimeOffset pg_timestamptz_in(string str,int typmod);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string pg_timestamptz_out(DateTimeOffset dt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string text2cstring(IntPtr textptr);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr gserialized_as_ewkb(IntPtr geom,string type);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string gserialized_as_ewkt(IntPtr geom,int precision);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string gserialized_as_geojson(IntPtr geom,int option,int precision,string srs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string gserialized_as_hexewkb(IntPtr geom,string type);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string gserialized_as_text(IntPtr geom,int precision);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr gserialized_from_ewkb(IntPtr bytea_wkb,int srid);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr gserialized_from_geojson(string geojson);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr gserialized_from_hexewkb(string wkt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr gserialized_from_text(string wkt,int srid);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr gserialized_in(string input,int geom_typmod);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string gserialized_out(IntPtr geom);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool pgis_gserialized_same(IntPtr geom1,IntPtr geom2);

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
		public static extern IntPtr floatset_in(string str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string floatset_out(IntPtr set,int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr floatspan_in(string str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string floatspan_out(IntPtr s,int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr floatspanset_in(string str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string floatspanset_out(IntPtr ss,int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr geogset_in(string str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string geogset_out(IntPtr set,int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr geomset_in(string str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string geomset_out(IntPtr set,int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string geoset_as_ewkt(IntPtr set,int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string geoset_as_text(IntPtr set,int maxdd);

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
		public static extern IntPtr period_in(string str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string period_out(IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr periodset_in(string str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string periodset_out(IntPtr ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string set_as_hexwkb(IntPtr s,byte variant,IntPtr size_out);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr set_as_wkb(IntPtr s,byte variant,IntPtr size_out);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr set_from_hexwkb(string hexwkb);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr set_from_wkb(IntPtr wkb,ulong size);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string set_out(IntPtr s,int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr span_as_wkb(IntPtr s,byte variant,IntPtr size_out);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string span_as_hexwkb(IntPtr s,byte variant,IntPtr size_out);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr span_from_hexwkb(string hexwkb);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr span_from_wkb(IntPtr wkb,ulong size);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string span_out(IntPtr s,int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr spanset_as_wkb(IntPtr ss,byte variant,IntPtr size_out);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string spanset_as_hexwkb(IntPtr ss,byte variant,IntPtr size_out);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr spanset_from_hexwkb(string hexwkb);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr spanset_from_wkb(IntPtr wkb,ulong size);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string spanset_out(IntPtr ss,int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr textset_in(string str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string textset_out(IntPtr set);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr timestampset_in(string str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string timestampset_out(IntPtr set);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr bigintset_make(IntPtr values,int count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr bigintspan_make(double lower,double upper,bool lower_inc,bool upper_inc);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr floatset_make(IntPtr values,int count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr floatspan_make(double lower,double upper,bool lower_inc,bool upper_inc);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr geogset_make(IntPtr values,int count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr geomset_make(IntPtr values,int count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr intset_make(IntPtr values,int count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr intspan_make(int lower,int upper,bool lower_inc,bool upper_inc);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr period_make(DateTimeOffset lower,DateTimeOffset upper,bool lower_inc,bool upper_inc);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr set_copy(IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr span_copy(IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr spanset_copy(IntPtr ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr spanset_make(IntPtr spans,int count,bool normalize);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr spanset_make_exp(IntPtr spans,int count,int maxcount,bool normalize,bool ordered);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr spanset_make_free(IntPtr spans,int count,bool normalize);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr textset_make(IntPtr values,int count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr timestampset_make(IntPtr values,int count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr bigint_to_bigintset(double i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr bigint_to_bigintspan(int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr bigint_to_bigintspanset(int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr float_to_floatset(double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr float_to_floatspan(double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr float_to_floatspanset(double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr int_to_intset(int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr int_to_intspan(int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr int_to_intspanset(int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr set_to_spanset(IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr span_to_spanset(IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr timestamp_to_period(DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr timestamp_to_periodset(DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr timestamp_to_tstzset(DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double bigintset_end_value(IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double bigintset_start_value(IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool bigintset_value_n(IntPtr s,int n,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr bigintset_values(IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int bigintspan_lower(IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int bigintspan_upper(IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int bigintspanset_lower(IntPtr ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int bigintspanset_upper(IntPtr ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double floatset_end_value(IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double floatset_start_value(IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool floatset_value_n(IntPtr s,int n,IntPtr result);

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
		public static extern int geoset_srid(IntPtr set);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int intset_end_value(IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int intset_start_value(IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool intset_value_n(IntPtr s,int n,IntPtr result);

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
		public static extern IntPtr period_duration(IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern DateTimeOffset period_lower(IntPtr p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern DateTimeOffset period_upper(IntPtr p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr periodset_duration(IntPtr ps,bool boundspan);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern DateTimeOffset periodset_end_timestamp(IntPtr ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern DateTimeOffset periodset_lower(IntPtr ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int periodset_num_timestamps(IntPtr ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern DateTimeOffset periodset_start_timestamp(IntPtr ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool periodset_timestamp_n(IntPtr ps,int n,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr periodset_timestamps(IntPtr ps,IntPtr count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern DateTimeOffset periodset_upper(IntPtr ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern uint set_hash(IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong set_hash_extended(IntPtr s,ulong seed);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int set_mem_size(IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int set_num_values(IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr set_span(IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern uint span_hash(IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong span_hash_extended(IntPtr s,ulong seed);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool span_lower_inc(IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool span_upper_inc(IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double span_width(IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr spanset_end_span(IntPtr ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern uint spanset_hash(IntPtr ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong spanset_hash_extended(IntPtr ps,ulong seed);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool spanset_lower_inc(IntPtr ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int spanset_mem_size(IntPtr ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int spanset_num_spans(IntPtr ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr spanset_span(IntPtr ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr spanset_span_n(IntPtr ss,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr spanset_spans(IntPtr ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr spanset_start_span(IntPtr ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool spanset_upper_inc(IntPtr ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double spanset_width(IntPtr ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr spatialset_stbox(IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern DateTimeOffset timestampset_end_timestamp(IntPtr ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern DateTimeOffset timestampset_start_timestamp(IntPtr ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool timestampset_timestamp_n(IntPtr ts,int n,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr timestampset_values(IntPtr ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern void floatspan_set_intspan(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern void intspan_set_floatspan(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern void numspan_set_floatspan(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr period_tprecision(IntPtr s,IntPtr duration,DateTimeOffset torigin);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr periodset_tprecision(IntPtr ss,IntPtr duration,DateTimeOffset torigin);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr period_shift_tscale(IntPtr p,IntPtr shift,IntPtr duration);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr periodset_shift_tscale(IntPtr ps,IntPtr shift,IntPtr duration);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr set_shift(IntPtr s,object shift);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern void span_expand(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern DateTimeOffset timestamp_tprecision(DateTimeOffset t,IntPtr duration,DateTimeOffset torigin);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr timestampset_shift_tscale(IntPtr ts,IntPtr shift,IntPtr duration);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool adjacent_bigintspan_bigint(IntPtr s,double i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool adjacent_bigintspanset_bigint(IntPtr ss,double i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool adjacent_floatspan_float(IntPtr s,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool adjacent_intspan_int(IntPtr s,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool adjacent_period_timestamp(IntPtr p,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool adjacent_periodset_timestamp(IntPtr ps,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool adjacent_span_span(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool adjacent_spanset_span(IntPtr ss,IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool adjacent_spanset_spanset(IntPtr ss1,IntPtr ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_bigint_bigintset(double i,IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_bigint_bigintspan(double i,IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_bigint_bigintspanset(double i,IntPtr ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_float_floatset(double d,IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_float_floatspan(double d,IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_float_floatspanset(double d,IntPtr ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_int_intset(int i,IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_int_intspanset(int i,IntPtr ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_int_intspan(int i,IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_set_set(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_span_span(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_span_spanset(IntPtr s,IntPtr ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_spanset_span(IntPtr ss,IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_spanset_spanset(IntPtr ss1,IntPtr ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_timestamp_period(DateTimeOffset t,IntPtr p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_timestamp_timestampset(DateTimeOffset t,IntPtr ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contains_floatspan_float(IntPtr s,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contains_floatspanset_float(IntPtr ss,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contains_intspan_int(IntPtr s,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contains_set_set(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contains_period_timestamp(IntPtr p,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contains_periodset_timestamp(IntPtr ps,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contains_span_span(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contains_span_spanset(IntPtr s,IntPtr ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contains_spanset_span(IntPtr ss,IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contains_spanset_spanset(IntPtr ss1,IntPtr ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contains_timestampset_timestamp(IntPtr ts,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overlaps_set_set(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overlaps_span_span(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overlaps_spanset_span(IntPtr ss,IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overlaps_spanset_spanset(IntPtr ss1,IntPtr ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool after_timestamp_timestampset(DateTimeOffset t,IntPtr ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool before_periodset_timestamp(IntPtr ps,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool before_timestamp_timestampset(DateTimeOffset t,IntPtr ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool left_float_floatspan(double d,IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool left_floatspan_float(IntPtr s,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool left_int_intspan(int i,IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool left_intspan_int(IntPtr s,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool left_set_set(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool left_span_span(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool left_span_spanset(IntPtr s,IntPtr ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool left_spanset_span(IntPtr ss,IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool left_spanset_spanset(IntPtr ss1,IntPtr ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overafter_period_timestamp(IntPtr p,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overafter_periodset_timestamp(IntPtr ps,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overafter_timestamp_period(DateTimeOffset t,IntPtr p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overafter_timestamp_periodset(DateTimeOffset t,IntPtr ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overafter_timestamp_timestampset(DateTimeOffset t,IntPtr ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overbefore_period_timestamp(IntPtr p,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overbefore_periodset_timestamp(IntPtr ps,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overbefore_timestamp_period(DateTimeOffset t,IntPtr p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overbefore_timestamp_periodset(DateTimeOffset t,IntPtr ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overbefore_timestamp_timestampset(DateTimeOffset t,IntPtr ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overleft_float_floatspan(double d,IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overleft_floatspan_float(IntPtr s,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overleft_int_intspan(int i,IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overleft_intspan_int(IntPtr s,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overleft_set_set(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overleft_span_span(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overleft_span_spanset(IntPtr s,IntPtr ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overleft_spanset_span(IntPtr ss,IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overleft_spanset_spanset(IntPtr ss1,IntPtr ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overright_float_floatspan(double d,IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overright_floatspan_float(IntPtr s,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overright_int_intspan(int i,IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overright_intspan_int(IntPtr s,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overright_set_set(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overright_span_span(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overright_span_spanset(IntPtr s,IntPtr ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overright_spanset_span(IntPtr ss,IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overright_spanset_spanset(IntPtr ss1,IntPtr ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool right_float_floatspan(double d,IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool right_floatspan_float(IntPtr s,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool right_int_intspan(int i,IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool right_intspan_int(IntPtr s,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool right_set_set(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool right_span_span(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool right_span_spanset(IntPtr s,IntPtr ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool right_spanset_span(IntPtr ss,IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool right_spanset_spanset(IntPtr ss1,IntPtr ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern void bbox_union_span_span(IntPtr s1,IntPtr s2,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr intersection_set_set(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool intersection_period_timestamp(IntPtr p,DateTimeOffset t,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool intersection_periodset_timestamp(IntPtr ps,DateTimeOffset t,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr intersection_span_span(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr intersection_spanset_span(IntPtr ss,IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr intersection_spanset_spanset(IntPtr ss1,IntPtr ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool intersection_timestampset_timestamp(IntPtr ts,DateTimeOffset t,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr minus_set_set(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr minus_period_timestamp(IntPtr p,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr minus_periodset_timestamp(IntPtr ps,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr minus_span_span(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr minus_span_spanset(IntPtr s,IntPtr ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr minus_spanset_span(IntPtr ss,IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr minus_spanset_spanset(IntPtr ss1,IntPtr ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool minus_timestamp_period(DateTimeOffset t,IntPtr p,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool minus_timestamp_periodset(DateTimeOffset t,IntPtr ps,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr minus_timestampset_timestamp(IntPtr ts,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr union_set_set(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr union_period_timestamp(IntPtr p,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr union_periodset_timestamp(IntPtr ps,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr union_span_span(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr union_spanset_span(IntPtr ss,IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr union_spanset_spanset(IntPtr ss1,IntPtr ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr union_timestampset_timestamp(IntPtr ts,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double distance_floatspan_float(IntPtr s,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double distance_intspan_int(IntPtr s,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double distance_set_set(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double distance_period_timestamp(IntPtr p,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double distance_periodset_timestamp(IntPtr ps,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double distance_span_span(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double distance_spanset_span(IntPtr ss,IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double distance_spanset_spanset(IntPtr ss1,IntPtr ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double distance_timestampset_timestamp(IntPtr ts,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr bigint_extent_transfn(IntPtr s,double i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr bigint_union_transfn(IntPtr state,double i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr float_extent_transfn(IntPtr s,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr float_union_transfn(IntPtr state,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr int_extent_transfn(IntPtr s,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr int_union_transfn(IntPtr state,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr period_tcount_transfn(IntPtr state,IntPtr p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr periodset_tcount_transfn(IntPtr state,IntPtr ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr set_extent_transfn(IntPtr span,IntPtr set);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr set_union_finalfn(IntPtr state);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr set_union_transfn(IntPtr state,IntPtr set);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr span_extent_transfn(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr span_union_transfn(IntPtr state,IntPtr span);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr spanset_extent_transfn(IntPtr s,IntPtr ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr spanset_union_finalfn(IntPtr state);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr spanset_union_transfn(IntPtr state,IntPtr ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr text_union_transfn(IntPtr state,IntPtr txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr timestamp_extent_transfn(IntPtr p,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr timestamp_tcount_transfn(IntPtr state,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr timestamp_union_transfn(IntPtr state,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr timestampset_tcount_transfn(IntPtr state,IntPtr ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int set_cmp(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool set_eq(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool set_ge(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool set_gt(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool set_le(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool set_lt(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool set_ne(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int span_cmp(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool span_eq(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool span_ge(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool span_gt(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool span_le(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool span_lt(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool span_ne(IntPtr s1,IntPtr s2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int spanset_cmp(IntPtr ss1,IntPtr ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool spanset_eq(IntPtr ss1,IntPtr ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool spanset_ge(IntPtr ss1,IntPtr ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool spanset_gt(IntPtr ss1,IntPtr ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool spanset_le(IntPtr ss1,IntPtr ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool spanset_lt(IntPtr ss1,IntPtr ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool spanset_ne(IntPtr ss1,IntPtr ss2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tbox_in(string str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string tbox_out(IntPtr box,int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tbox_from_wkb(IntPtr wkb,ulong size);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tbox_from_hexwkb(string hexwkb);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr stbox_from_wkb(IntPtr wkb,ulong size);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr stbox_from_hexwkb(string hexwkb);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tbox_as_wkb(IntPtr box,byte variant,IntPtr size_out);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string tbox_as_hexwkb(IntPtr box,byte variant,IntPtr size);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr stbox_as_wkb(IntPtr box,byte variant,IntPtr size_out);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string stbox_as_hexwkb(IntPtr box,byte variant,IntPtr size);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr stbox_in(string str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string stbox_out(IntPtr box,int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tbox_make(IntPtr s,IntPtr p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern void tbox_set(IntPtr s,IntPtr p,IntPtr box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tbox_copy(IntPtr box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr stbox_copy(IntPtr box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr int_to_tbox(int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr float_to_tbox(double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr timestamp_to_tbox(DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr timestampset_to_tbox(IntPtr ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr period_to_tbox(IntPtr p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr periodset_to_tbox(IntPtr ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr int_timestamp_to_tbox(int i,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr float_period_to_tbox(double d,IntPtr p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr float_timestamp_to_tbox(double d,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr geo_period_to_stbox(IntPtr gs,IntPtr p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr geo_timestamp_to_stbox(IntPtr gs,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr geo_to_stbox(IntPtr gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr int_period_to_tbox(int i,IntPtr p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr numspan_to_tbox(IntPtr s);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr span_timestamp_to_tbox(IntPtr span,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr span_period_to_tbox(IntPtr span,IntPtr p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tbox_to_floatspan(IntPtr box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tbox_to_period(IntPtr box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr stbox_to_period(IntPtr box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tnumber_to_tbox(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr stbox_to_geo(IntPtr box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tpoint_to_stbox(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr timestamp_to_stbox(DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr timestampset_to_stbox(IntPtr ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr period_to_stbox(IntPtr p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr periodset_to_stbox(IntPtr ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_hasx(IntPtr box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_hast(IntPtr box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_xmin(IntPtr box,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_xmin_inc(IntPtr box,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_xmax(IntPtr box,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_xmax_inc(IntPtr box,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_tmin(IntPtr box,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_tmin_inc(IntPtr box,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_tmax(IntPtr box,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_tmax_inc(IntPtr box,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_hasx(IntPtr box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_hasz(IntPtr box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_hast(IntPtr box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_isgeodetic(IntPtr box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_xmin(IntPtr box,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_xmax(IntPtr box,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_ymin(IntPtr box,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_ymax(IntPtr box,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_zmin(IntPtr box,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_zmax(IntPtr box,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_tmin(IntPtr box,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_tmin_inc(IntPtr box,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_tmax(IntPtr box,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_tmax_inc(IntPtr box,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int stbox_srid(IntPtr box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern void tbox_expand(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tbox_expand_value(IntPtr box,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tbox_expand_time(IntPtr box,IntPtr interval);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern void stbox_expand(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr stbox_set_srid(IntPtr box,int srid);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr stbox_get_space(IntPtr box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr stbox_expand_space(IntPtr box,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr stbox_expand_time(IntPtr box,IntPtr interval);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contains_tbox_tbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_tbox_tbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overlaps_tbox_tbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool same_tbox_tbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool adjacent_tbox_tbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contains_stbox_stbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool contained_stbox_stbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overlaps_stbox_stbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool same_stbox_stbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool adjacent_stbox_stbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool left_tbox_tbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overleft_tbox_tbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool right_tbox_tbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overright_tbox_tbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool before_tbox_tbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overbefore_tbox_tbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool after_tbox_tbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overafter_tbox_tbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool left_stbox_stbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overleft_stbox_stbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool right_stbox_stbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overright_stbox_stbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool below_stbox_stbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overbelow_stbox_stbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool above_stbox_stbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overabove_stbox_stbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool front_stbox_stbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overfront_stbox_stbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool back_stbox_stbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overback_stbox_stbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool before_stbox_stbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overbefore_stbox_stbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool after_stbox_stbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool overafter_stbox_stbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr union_tbox_tbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool inter_tbox_tbox(IntPtr box1,IntPtr box2,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr intersection_tbox_tbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr union_stbox_stbox(IntPtr box1,IntPtr box2,bool strict);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool inter_stbox_stbox(IntPtr box1,IntPtr box2,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr intersection_stbox_stbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr stbox_quad_split(IntPtr box,IntPtr count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_eq(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_ne(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int tbox_cmp(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_lt(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_le(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_ge(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbox_gt(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_eq(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_ne(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int stbox_cmp(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_lt(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_le(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_ge(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool stbox_gt(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tbool_in(string str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string tbool_out(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string temporal_as_hexwkb(IntPtr temp,byte variant,IntPtr size_out);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string temporal_as_mfjson(IntPtr temp,bool with_bbox,int flags,int precision,string srs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_as_wkb(IntPtr temp,byte variant,IntPtr size_out);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_from_hexwkb(string hexwkb);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_from_mfjson(string mfjson);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_from_wkb(IntPtr wkb,ulong size);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tfloat_in(string str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string tfloat_out(IntPtr temp,int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tgeogpoint_in(string str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tgeompoint_in(string str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tint_in(string str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string tint_out(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string tpoint_as_ewkt(IntPtr temp,int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string tpoint_as_text(IntPtr temp,int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string tpoint_out(IntPtr temp,int maxdd);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ttext_in(string str);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string ttext_out(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tbool_from_base_temp(bool b,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tboolinst_make(bool b,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tboolseq_from_base_period(bool b,IntPtr p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tboolseq_from_base_timestampset(bool b,IntPtr ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tboolseqset_from_base_periodset(bool b,IntPtr ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_copy(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tfloat_from_base_temp(double d,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tfloatinst_make(double d,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tfloatseq_from_base_period(double d,IntPtr p,InterpolationType interp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tfloatseq_from_base_timestampset(double d,IntPtr ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tfloatseqset_from_base_periodset(double d,IntPtr ps,InterpolationType interp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tgeogpoint_from_base_temp(IntPtr gs,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tgeogpointinst_make(IntPtr gs,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tgeogpointseq_from_base_period(IntPtr gs,IntPtr p,InterpolationType interp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tgeogpointseq_from_base_timestampset(IntPtr gs,IntPtr ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tgeogpointseqset_from_base_periodset(IntPtr gs,IntPtr ps,InterpolationType interp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tgeompoint_from_base_temp(IntPtr gs,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tgeompointinst_make(IntPtr gs,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tgeompointseq_from_base_period(IntPtr gs,IntPtr p,InterpolationType interp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tgeompointseq_from_base_timestampset(IntPtr gs,IntPtr ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tgeompointseqset_from_base_periodset(IntPtr gs,IntPtr ps,InterpolationType interp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tint_from_base_temp(int i,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tintinst_make(int i,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tintseq_from_base_period(int i,IntPtr p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tintseq_from_base_timestampset(int i,IntPtr ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tintseqset_from_base_periodset(int i,IntPtr ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tsequence_make(IntPtr instants,int count,bool lower_inc,bool upper_inc,InterpolationType interp,bool normalize);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tsequence_make_exp(IntPtr instants,int count,int maxcount,bool lower_inc,bool upper_inc,InterpolationType interp,bool normalize);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tsequenceset_make(IntPtr sequences,int count,bool normalize);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tsequenceset_make_exp(IntPtr sequences,int count,int maxcount,bool normalize);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tsequenceset_make_gaps(IntPtr instants,int count,InterpolationType interp,IntPtr maxt,double maxdist);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ttext_from_base_temp(IntPtr txt,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ttextinst_make(IntPtr txt,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ttextseq_from_base_period(IntPtr txt,IntPtr p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ttextseq_from_base_timestampset(IntPtr txt,IntPtr ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ttextseqset_from_base_periodset(IntPtr txt,IntPtr ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_to_period(IntPtr temp);

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
		public static extern IntPtr tbool_values(IntPtr temp,IntPtr count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_duration(IntPtr temp,bool boundspan);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_end_instant(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_end_sequence(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern DateTimeOffset temporal_end_timestamp(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern uint temporal_hash(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_instant_n(IntPtr temp,int n);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_instants(IntPtr temp,IntPtr count);

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
		public static extern IntPtr temporal_segments(IntPtr temp,IntPtr count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_sequence_n(IntPtr temp,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_sequences(IntPtr temp,IntPtr count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_start_instant(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_start_sequence(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern DateTimeOffset temporal_start_timestamp(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_stops(IntPtr temp,double maxdist,IntPtr minduration);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern string temporal_subtype(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_time(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool temporal_timestamp_n(IntPtr temp,int n,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_timestamps(IntPtr temp,IntPtr count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_values(IntPtr temp,IntPtr count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double tfloat_end_value(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double tfloat_max_value(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double tfloat_min_value(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double tfloat_start_value(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tfloat_values(IntPtr temp,IntPtr count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int tint_end_value(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int tint_max_value(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int tint_min_value(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int tint_start_value(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tint_values(IntPtr temp,IntPtr count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tnumber_valuespans(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tpoint_end_value(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tpoint_start_value(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tpoint_values(IntPtr temp,IntPtr count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ttext_end_value(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ttext_max_value(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ttext_min_value(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ttext_start_value(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ttext_values(IntPtr temp,IntPtr count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_set_interp(IntPtr temp,InterpolationType interp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_shift(IntPtr temp,IntPtr shift);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_shift_tscale(IntPtr temp,IntPtr shift,IntPtr duration);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_to_tinstant(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_to_tsequence(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_to_tsequenceset(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_tprecision(IntPtr temp,IntPtr duration,DateTimeOffset origin);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_tsample(IntPtr temp,IntPtr duration,DateTimeOffset origin);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_tscale(IntPtr temp,IntPtr duration);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tbool_at_value(IntPtr temp,bool b);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tbool_minus_value(IntPtr temp,bool b);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbool_value_at_timestamp(IntPtr temp,DateTimeOffset t,bool strict,IntPtr value);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_at_max(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_at_min(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_at_period(IntPtr temp,IntPtr p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_at_periodset(IntPtr temp,IntPtr ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_at_timestamp(IntPtr temp,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_at_timestampset(IntPtr temp,IntPtr ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_at_values(IntPtr temp,IntPtr set);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_minus_max(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_minus_min(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_minus_period(IntPtr temp,IntPtr p);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_minus_periodset(IntPtr temp,IntPtr ps);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_minus_timestamp(IntPtr temp,DateTimeOffset t);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_minus_timestampset(IntPtr temp,IntPtr ts);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_minus_values(IntPtr temp,IntPtr set);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tfloat_at_value(IntPtr temp,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tfloat_minus_value(IntPtr temp,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tfloat_value_at_timestamp(IntPtr temp,DateTimeOffset t,bool strict,IntPtr value);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tint_at_value(IntPtr temp,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tint_minus_value(IntPtr temp,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tint_value_at_timestamp(IntPtr temp,DateTimeOffset t,bool strict,IntPtr value);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tnumber_at_span(IntPtr temp,IntPtr span);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tnumber_at_spanset(IntPtr temp,IntPtr ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tnumber_at_tbox(IntPtr temp,IntPtr box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tnumber_minus_span(IntPtr temp,IntPtr span);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tnumber_minus_spanset(IntPtr temp,IntPtr ss);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tnumber_minus_tbox(IntPtr temp,IntPtr box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tpoint_at_geom_time(IntPtr temp,IntPtr gs,IntPtr zspan,IntPtr period);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tpoint_at_stbox(IntPtr temp,IntPtr box,bool border_inc);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tpoint_at_value(IntPtr temp,IntPtr gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tpoint_minus_geom_time(IntPtr temp,IntPtr gs,IntPtr zspan,IntPtr period);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tpoint_minus_stbox(IntPtr temp,IntPtr box,bool border_inc);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tpoint_minus_value(IntPtr temp,IntPtr gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tpoint_value_at_timestamp(IntPtr temp,DateTimeOffset t,bool strict,IntPtr value);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ttext_at_value(IntPtr temp,IntPtr txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ttext_minus_value(IntPtr temp,IntPtr txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool ttext_value_at_timestamp(IntPtr temp,DateTimeOffset t,bool strict,IntPtr value);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_append_tinstant(IntPtr temp,IntPtr inst,double maxdist,IntPtr maxt,bool expand);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_append_tsequence(IntPtr temp,IntPtr seq,bool expand);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_delete_period(IntPtr temp,IntPtr p,bool connect);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_delete_periodset(IntPtr temp,IntPtr ps,bool connect);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_delete_timestamp(IntPtr temp,DateTimeOffset t,bool connect);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_delete_timestampset(IntPtr temp,IntPtr ts,bool connect);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_insert(IntPtr temp1,IntPtr temp2,bool connect);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_merge(IntPtr temp1,IntPtr temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_merge_array(IntPtr temparr,int count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_update(IntPtr temp1,IntPtr temp2,bool connect);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tand_bool_tbool(bool b,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tand_tbool_bool(IntPtr temp,bool b);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tand_tbool_tbool(IntPtr temp1,IntPtr temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tbool_when_true(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tnot_tbool(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tor_bool_tbool(bool b,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tor_tbool_bool(IntPtr temp,bool b);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tor_tbool_tbool(IntPtr temp1,IntPtr temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr add_float_tfloat(double d,IntPtr tnumber);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr add_int_tint(int i,IntPtr tnumber);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr add_tfloat_float(IntPtr tnumber,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr add_tint_int(IntPtr tnumber,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr add_tnumber_tnumber(IntPtr tnumber1,IntPtr tnumber2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr div_float_tfloat(double d,IntPtr tnumber);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr div_int_tint(int i,IntPtr tnumber);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr div_tfloat_float(IntPtr tnumber,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr div_tint_int(IntPtr tnumber,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr div_tnumber_tnumber(IntPtr tnumber1,IntPtr tnumber2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double float_degrees(double value,bool normalize);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr mult_float_tfloat(double d,IntPtr tnumber);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr mult_int_tint(int i,IntPtr tnumber);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr mult_tfloat_float(IntPtr tnumber,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr mult_tint_int(IntPtr tnumber,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr mult_tnumber_tnumber(IntPtr tnumber1,IntPtr tnumber2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr sub_float_tfloat(double d,IntPtr tnumber);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr sub_int_tint(int i,IntPtr tnumber);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr sub_tfloat_float(IntPtr tnumber,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr sub_tint_int(IntPtr tnumber,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr sub_tnumber_tnumber(IntPtr tnumber1,IntPtr tnumber2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tfloat_degrees(IntPtr temp,bool normalize);

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
		public static extern IntPtr textcat_text_ttext(IntPtr txt,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr textcat_ttext_text(IntPtr temp,IntPtr txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr textcat_ttext_ttext(IntPtr temp1,IntPtr temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ttext_upper(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ttext_lower(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr distance_tfloat_float(IntPtr temp,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr distance_tint_int(IntPtr temp,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr distance_tnumber_tnumber(IntPtr temp1,IntPtr temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr distance_tpoint_geo(IntPtr temp,IntPtr geo);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr distance_tpoint_tpoint(IntPtr temp1,IntPtr temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double nad_stbox_geo(IntPtr box,IntPtr gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double nad_stbox_stbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double nad_tbox_tbox(IntPtr box1,IntPtr box2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double nad_tfloat_float(IntPtr temp,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double nad_tfloat_tfloat(IntPtr temp1,IntPtr temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int nad_tint_int(IntPtr temp,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int nad_tint_tint(IntPtr temp1,IntPtr temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double nad_tnumber_tbox(IntPtr temp,IntPtr box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double nad_tpoint_geo(IntPtr temp,IntPtr gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double nad_tpoint_stbox(IntPtr temp,IntPtr box);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double nad_tpoint_tpoint(IntPtr temp1,IntPtr temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr nai_tpoint_geo(IntPtr temp,IntPtr gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr nai_tpoint_tpoint(IntPtr temp1,IntPtr temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool shortestline_tpoint_geo(IntPtr temp,IntPtr gs,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool shortestline_tpoint_tpoint(IntPtr temp1,IntPtr temp2,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbool_always_eq(IntPtr temp,bool b);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tbool_ever_eq(IntPtr temp,bool b);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tfloat_always_eq(IntPtr temp,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tfloat_always_le(IntPtr temp,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tfloat_always_lt(IntPtr temp,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tfloat_ever_eq(IntPtr temp,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tfloat_ever_le(IntPtr temp,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tfloat_ever_lt(IntPtr temp,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tgeogpoint_always_eq(IntPtr temp,IntPtr gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tgeogpoint_ever_eq(IntPtr temp,IntPtr gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tgeompoint_always_eq(IntPtr temp,IntPtr gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tgeompoint_ever_eq(IntPtr temp,IntPtr gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tint_always_eq(IntPtr temp,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tint_always_le(IntPtr temp,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tint_always_lt(IntPtr temp,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tint_ever_eq(IntPtr temp,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tint_ever_le(IntPtr temp,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tint_ever_lt(IntPtr temp,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tpoint_always_eq(IntPtr temp,object value);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tpoint_ever_eq(IntPtr temp,object value);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool ttext_always_eq(IntPtr temp,IntPtr txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool ttext_always_le(IntPtr temp,IntPtr txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool ttext_always_lt(IntPtr temp,IntPtr txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool ttext_ever_eq(IntPtr temp,IntPtr txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool ttext_ever_le(IntPtr temp,IntPtr txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool ttext_ever_lt(IntPtr temp,IntPtr txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int temporal_cmp(IntPtr temp1,IntPtr temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool temporal_eq(IntPtr temp1,IntPtr temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool temporal_ge(IntPtr temp1,IntPtr temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool temporal_gt(IntPtr temp1,IntPtr temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool temporal_le(IntPtr temp1,IntPtr temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool temporal_lt(IntPtr temp1,IntPtr temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool temporal_ne(IntPtr temp1,IntPtr temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr teq_bool_tbool(bool b,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr teq_float_tfloat(double d,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr teq_geo_tpoint(IntPtr geo,IntPtr tpoint);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr teq_int_tint(int i,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr teq_point_tgeogpoint(IntPtr gs,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr teq_point_tgeompoint(IntPtr gs,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr teq_tbool_bool(IntPtr temp,bool b);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr teq_temporal_temporal(IntPtr temp1,IntPtr temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr teq_text_ttext(IntPtr txt,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr teq_tfloat_float(IntPtr temp,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr teq_tgeogpoint_point(IntPtr temp,IntPtr gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr teq_tgeompoint_point(IntPtr temp,IntPtr gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr teq_tint_int(IntPtr temp,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr teq_tpoint_geo(IntPtr tpoint,IntPtr geo);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr teq_ttext_text(IntPtr temp,IntPtr txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tge_float_tfloat(double d,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tge_int_tint(int i,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tge_temporal_temporal(IntPtr temp1,IntPtr temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tge_text_ttext(IntPtr txt,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tge_tfloat_float(IntPtr temp,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tge_tint_int(IntPtr temp,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tge_ttext_text(IntPtr temp,IntPtr txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tgt_float_tfloat(double d,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tgt_int_tint(int i,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tgt_temporal_temporal(IntPtr temp1,IntPtr temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tgt_text_ttext(IntPtr txt,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tgt_tfloat_float(IntPtr temp,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tgt_tint_int(IntPtr temp,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tgt_ttext_text(IntPtr temp,IntPtr txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tle_float_tfloat(double d,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tle_int_tint(int i,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tle_temporal_temporal(IntPtr temp1,IntPtr temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tle_text_ttext(IntPtr txt,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tle_tfloat_float(IntPtr temp,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tle_tint_int(IntPtr temp,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tle_ttext_text(IntPtr temp,IntPtr txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tlt_float_tfloat(double d,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tlt_int_tint(int i,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tlt_temporal_temporal(IntPtr temp1,IntPtr temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tlt_text_ttext(IntPtr txt,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tlt_tfloat_float(IntPtr temp,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tlt_tint_int(IntPtr temp,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tlt_ttext_text(IntPtr temp,IntPtr txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tne_bool_tbool(bool b,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tne_float_tfloat(double d,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tne_geo_tpoint(IntPtr geo,IntPtr tpoint);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tne_int_tint(int i,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tne_point_tgeogpoint(IntPtr gs,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tne_point_tgeompoint(IntPtr gs,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tne_tbool_bool(IntPtr temp,bool b);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tne_temporal_temporal(IntPtr temp1,IntPtr temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tne_text_ttext(IntPtr txt,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tne_tfloat_float(IntPtr temp,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tne_tgeogpoint_point(IntPtr temp,IntPtr gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tne_tgeompoint_point(IntPtr temp,IntPtr gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tne_tint_int(IntPtr temp,int i);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tne_tpoint_geo(IntPtr tpoint,IntPtr geo);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tne_ttext_text(IntPtr temp,IntPtr txt);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool bearing_point_point(IntPtr geo1,IntPtr geo2,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr bearing_tpoint_point(IntPtr temp,IntPtr gs,bool invert);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr bearing_tpoint_tpoint(IntPtr temp1,IntPtr temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tpoint_angular_difference(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tpoint_azimuth(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tpoint_convex_hull(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tpoint_cumulative_length(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tpoint_direction(IntPtr temp,IntPtr result);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tpoint_get_coord(IntPtr temp,int coord);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern bool tpoint_is_simple(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double tpoint_length(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tpoint_speed(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int tpoint_srid(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tpoint_stboxes(IntPtr temp,IntPtr count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tpoint_trajectory(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr geo_expand_space(IntPtr gs,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tgeompoint_tgeogpoint(IntPtr temp,bool oper);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tpoint_expand_space(IntPtr temp,double d);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tpoint_make_simple(IntPtr temp,IntPtr count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tpoint_set_srid(IntPtr temp,int srid);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int econtains_geo_tpoint(IntPtr geo,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int edisjoint_tpoint_geo(IntPtr temp,IntPtr gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int edisjoint_tpoint_tpoint(IntPtr temp1,IntPtr temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int edwithin_tpoint_geo(IntPtr temp,IntPtr gs,double dist);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int edwithin_tpoint_tpoint(IntPtr temp1,IntPtr temp2,double dist);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int eintersects_tpoint_geo(IntPtr temp,IntPtr gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int eintersects_tpoint_tpoint(IntPtr temp1,IntPtr temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int etouches_tpoint_geo(IntPtr temp,IntPtr gs);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tcontains_geo_tpoint(IntPtr gs,IntPtr temp,bool restr,bool atvalue);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tdisjoint_tpoint_geo(IntPtr temp,IntPtr geo,bool restr,bool atvalue);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tdwithin_tpoint_geo(IntPtr temp,IntPtr gs,double dist,bool restr,bool atvalue);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tdwithin_tpoint_tpoint(IntPtr temp1,IntPtr temp2,double dist,bool restr,bool atvalue);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tintersects_tpoint_geo(IntPtr temp,IntPtr geo,bool restr,bool atvalue);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ttouches_tpoint_geo(IntPtr temp,IntPtr gs,bool restr,bool atvalue);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tbool_tand_transfn(IntPtr state,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tbool_tor_transfn(IntPtr state,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_extent_transfn(IntPtr p,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_tagg_finalfn(IntPtr state);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_tcount_transfn(IntPtr state,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tfloat_tmax_transfn(IntPtr state,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tfloat_tmin_transfn(IntPtr state,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tfloat_tsum_transfn(IntPtr state,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tint_tmax_transfn(IntPtr state,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tint_tmin_transfn(IntPtr state,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tint_tsum_transfn(IntPtr state,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tnumber_extent_transfn(IntPtr box,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double tnumber_integral(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tnumber_tavg_finalfn(IntPtr state);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tnumber_tavg_transfn(IntPtr state,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double tnumber_twavg(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tpoint_extent_transfn(IntPtr box,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tpoint_tcentroid_finalfn(IntPtr state);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tpoint_tcentroid_transfn(IntPtr state,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tpoint_twcentroid(IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ttext_tmax_transfn(IntPtr state,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ttext_tmin_transfn(IntPtr state,IntPtr temp);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double float_bucket(double value,double size,double origin);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr floatspan_bucket_list(IntPtr bounds,double size,double origin,IntPtr newcount);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern int int_bucket(int value,int size,int origin);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr intspan_bucket_list(IntPtr bounds,int size,int origin,IntPtr newcount);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr period_bucket_list(IntPtr bounds,IntPtr duration,DateTimeOffset origin,IntPtr newcount);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr stbox_tile_list(IntPtr bounds,double xsize,double ysize,double zsize,IntPtr duration,IntPtr sorigin,DateTimeOffset torigin,IntPtr cellcount);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tbox_tile_list(IntPtr bounds,double xsize,IntPtr duration,double xorigin,DateTimeOffset torigin,IntPtr rows,IntPtr columns);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_time_split(IntPtr temp,IntPtr duration,DateTimeOffset torigin,IntPtr newcount);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tfloat_value_split(IntPtr temp,double size,double origin,IntPtr newcount);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tfloat_value_time_split(IntPtr temp,double size,double vorigin,IntPtr duration,DateTimeOffset torigin,IntPtr newcount);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern DateTimeOffset timestamptz_bucket(DateTimeOffset timestamp,IntPtr duration,DateTimeOffset origin);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tint_value_split(IntPtr temp,int size,int origin,IntPtr newcount);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr tint_value_time_split(IntPtr temp,int size,int vorigin,IntPtr duration,DateTimeOffset torigin,IntPtr newcount);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double temporal_dyntimewarp_distance(IntPtr temp1,IntPtr temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_dyntimewarp_path(IntPtr temp1,IntPtr temp2,IntPtr count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double temporal_frechet_distance(IntPtr temp1,IntPtr temp2);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr temporal_frechet_path(IntPtr temp1,IntPtr temp2,IntPtr count);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern double temporal_hausdorff_distance(IntPtr temp1,IntPtr temp2);

	}
}
