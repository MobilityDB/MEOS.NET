#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Structures;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>meos.h</c> declares.</summary>
    public static partial class Meos
    {
        public static bool BoolIn(string str)
            => SafeExecution<bool>(() => Native.BoolIn(str));

        public static string BoolOut(bool b)
            => SafeExecution<string>(() => Native.BoolOut(b));

        public static string Float8Out(double num, int maxdd)
            => SafeExecution<string>(() => Native.Float8Out(num, maxdd));

        public static int DateIn(string str)
            => SafeExecution<int>(() => Native.DateIn(str));

        public static string DateOut(int date)
            => SafeExecution<string>(() => Native.DateOut(date));

        public static int IntervalCmp(IntPtr interv1, IntPtr interv2)
            => SafeExecution<int>(() => Native.IntervalCmp(interv1, interv2));

        public static IntPtr IntervalIn(string str, int typmod)
            => SafeExecution<IntPtr>(() => Native.IntervalIn(str, typmod));

        public static string IntervalOut(IntPtr interv)
            => SafeExecution<string>(() => Native.IntervalOut(interv));

        public static long TimeIn(string str, int typmod)
            => SafeExecution<long>(() => Native.TimeIn(str, typmod));

        public static string TimeOut(long time)
            => SafeExecution<string>(() => Native.TimeOut(time));

        public static long TimestampIn(string str, int typmod)
            => SafeExecution<long>(() => Native.TimestampIn(str, typmod));

        public static string TimestampOut(long ts)
            => SafeExecution<string>(() => Native.TimestampOut(ts));

        public static long TimestamptzIn(string str, int typmod)
            => SafeExecution<long>(() => Native.TimestamptzIn(str, typmod));

        public static string TimestamptzOut(long tstz)
            => SafeExecution<string>(() => Native.TimestamptzOut(tstz));

        public static IntPtr CstringToText(string str)
            => SafeExecution<IntPtr>(() => Native.CstringToText(str));

        public static string TextToCstring(IntPtr txt)
            => SafeExecution<string>(() => Native.TextToCstring(txt));

        public static IntPtr TextIn(string str)
            => SafeExecution<IntPtr>(() => Native.TextIn(str));

        public static string TextOut(IntPtr txt)
            => SafeExecution<string>(() => Native.TextOut(txt));

        public static int TextCmp(IntPtr txt1, IntPtr txt2, uint collid)
            => SafeExecution<int>(() => Native.TextCmp(txt1, txt2, collid));

        public static IntPtr TextCopy(IntPtr txt)
            => SafeExecution<IntPtr>(() => Native.TextCopy(txt));

        public static IntPtr TextInitcap(IntPtr txt)
            => SafeExecution<IntPtr>(() => Native.TextInitcap(txt));

        public static IntPtr TextLower(IntPtr txt)
            => SafeExecution<IntPtr>(() => Native.TextLower(txt));

        public static IntPtr TextUpper(IntPtr txt)
            => SafeExecution<IntPtr>(() => Native.TextUpper(txt));

        public static IntPtr TextcatTextText(IntPtr txt1, IntPtr txt2)
            => SafeExecution<IntPtr>(() => Native.TextcatTextText(txt1, txt2));

        public static void MeosError(int errlevel, int errcode, string format)
            => SafeExecution(() => Native.MeosError(errlevel, errcode, format));

        public static int MeosErrno()
            => SafeExecution<int>(() => Native.MeosErrno());

        public static int MeosErrnoSet(int err)
            => SafeExecution<int>(() => Native.MeosErrnoSet(err));

        public static int MeosErrnoRestore(int err)
            => SafeExecution<int>(() => Native.MeosErrnoRestore(err));

        public static int MeosErrnoReset()
            => SafeExecution<int>(() => Native.MeosErrnoReset());

        public static IntPtr MeosArrayCreate(int elem_size)
            => SafeExecution<IntPtr>(() => Native.MeosArrayCreate(elem_size));

        public static void MeosArrayAdd(IntPtr array, IntPtr value)
            => SafeExecution(() => Native.MeosArrayAdd(array, value));

        public static IntPtr MeosArrayGet(IntPtr array, int n)
            => SafeExecution<IntPtr>(() => Native.MeosArrayGet(array, n));

        public static int MeosArrayCount(IntPtr array)
            => SafeExecution<int>(() => Native.MeosArrayCount(array));

        public static void MeosArrayReset(IntPtr array)
            => SafeExecution(() => Native.MeosArrayReset(array));

        public static void MeosArrayResetFree(IntPtr array)
            => SafeExecution(() => Native.MeosArrayResetFree(array));

        public static void MeosArrayDestroy(IntPtr array)
            => SafeExecution(() => Native.MeosArrayDestroy(array));

        public static void MeosArrayDestroyFree(IntPtr array)
            => SafeExecution(() => Native.MeosArrayDestroyFree(array));

        public static IntPtr RtreeCreateIntspan()
            => SafeExecution<IntPtr>(() => Native.RtreeCreateIntspan());

        public static IntPtr RtreeCreateBigintspan()
            => SafeExecution<IntPtr>(() => Native.RtreeCreateBigintspan());

        public static IntPtr RtreeCreateFloatspan()
            => SafeExecution<IntPtr>(() => Native.RtreeCreateFloatspan());

        public static IntPtr RtreeCreateDatespan()
            => SafeExecution<IntPtr>(() => Native.RtreeCreateDatespan());

        public static IntPtr RtreeCreateTstzspan()
            => SafeExecution<IntPtr>(() => Native.RtreeCreateTstzspan());

        public static IntPtr RtreeCreateTbox()
            => SafeExecution<IntPtr>(() => Native.RtreeCreateTbox());

        public static IntPtr RtreeCreateStbox()
            => SafeExecution<IntPtr>(() => Native.RtreeCreateStbox());

        public static IntPtr RtreeCreateTpcbox()
            => SafeExecution<IntPtr>(() => Native.RtreeCreateTpcbox());

        public static void RtreeFree(IntPtr rtree)
            => SafeExecution(() => Native.RtreeFree(rtree));

        public static int RtreeNumEntries(IntPtr rtree)
            => SafeExecution<int>(() => Native.RtreeNumEntries(rtree));

        public static long RtreeMemSize(IntPtr rtree)
            => SafeExecution<long>(() => Native.RtreeMemSize(rtree));

        public static int RtreeHeight(IntPtr rtree)
            => SafeExecution<int>(() => Native.RtreeHeight(rtree));

        public static bool RtreeInsert(IntPtr rtree, IntPtr box, long id)
            => SafeExecution<bool>(() => Native.RtreeInsert(rtree, box, id));

        public static bool RtreeLoad(IntPtr rtree, IntPtr boxes, IntPtr ids, int count)
            => SafeExecution<bool>(() => Native.RtreeLoad(rtree, boxes, ids, count));

        public static bool RtreeInsertTemporal(IntPtr rtree, IntPtr temp, long id)
            => SafeExecution<bool>(() => Native.RtreeInsertTemporal(rtree, temp, id));

        public static bool RtreeInsertTemporalSplit(IntPtr rtree, IntPtr temp, long id, int maxboxes)
            => SafeExecution<bool>(() => Native.RtreeInsertTemporalSplit(rtree, temp, id, maxboxes));

        public static int RtreeSearch(IntPtr rtree, int op, IntPtr query, IntPtr result)
            => SafeExecution<int>(() => Native.RtreeSearch(rtree, op, query, result));

        public static int RtreeJoin(IntPtr rtree1, IntPtr rtree2, int op, IntPtr result)
            => SafeExecution<int>(() => Native.RtreeJoin(rtree1, rtree2, op, result));

        public static int RtreeSearchTemporal(IntPtr rtree, int op, IntPtr temp, IntPtr result)
            => SafeExecution<int>(() => Native.RtreeSearchTemporal(rtree, op, temp, result));

        public static int RtreeSearchTemporalDedup(IntPtr rtree, int op, IntPtr temp, int maxboxes, IntPtr result)
            => SafeExecution<int>(() => Native.RtreeSearchTemporalDedup(rtree, op, temp, maxboxes, result));

        public static IntPtr RtreeNnCursorOpen(IntPtr rtree, IntPtr query)
            => SafeExecution<IntPtr>(() => Native.RtreeNnCursorOpen(rtree, query));

        public static bool RtreeNnCursorNext(IntPtr cursor, IntPtr id_out, IntPtr dist_out)
            => SafeExecution<bool>(() => Native.RtreeNnCursorNext(cursor, id_out, dist_out));

        public static void RtreeNnCursorClose(IntPtr cursor)
            => SafeExecution(() => Native.RtreeNnCursorClose(cursor));

        public static IntPtr SptreeCreateIntspan(int kind)
            => SafeExecution<IntPtr>(() => Native.SptreeCreateIntspan(kind));

        public static IntPtr SptreeCreateBigintspan(int kind)
            => SafeExecution<IntPtr>(() => Native.SptreeCreateBigintspan(kind));

        public static IntPtr SptreeCreateFloatspan(int kind)
            => SafeExecution<IntPtr>(() => Native.SptreeCreateFloatspan(kind));

        public static IntPtr SptreeCreateDatespan(int kind)
            => SafeExecution<IntPtr>(() => Native.SptreeCreateDatespan(kind));

        public static IntPtr SptreeCreateTstzspan(int kind)
            => SafeExecution<IntPtr>(() => Native.SptreeCreateTstzspan(kind));

        public static IntPtr SptreeCreateTbox(int kind)
            => SafeExecution<IntPtr>(() => Native.SptreeCreateTbox(kind));

        public static IntPtr SptreeCreateStbox(int kind)
            => SafeExecution<IntPtr>(() => Native.SptreeCreateStbox(kind));

        public static IntPtr SptreeCreateTpcbox(int kind)
            => SafeExecution<IntPtr>(() => Native.SptreeCreateTpcbox(kind));

        public static void SptreeFree(IntPtr sptree)
            => SafeExecution(() => Native.SptreeFree(sptree));

        public static int SptreeNumEntries(IntPtr sptree)
            => SafeExecution<int>(() => Native.SptreeNumEntries(sptree));

        public static long SptreeMemSize(IntPtr sptree)
            => SafeExecution<long>(() => Native.SptreeMemSize(sptree));

        public static int SptreeHeight(IntPtr sptree)
            => SafeExecution<int>(() => Native.SptreeHeight(sptree));

        public static bool SptreeInsert(IntPtr sptree, IntPtr box, long id)
            => SafeExecution<bool>(() => Native.SptreeInsert(sptree, box, id));

        public static bool SptreeLoad(IntPtr sptree, IntPtr boxes, IntPtr ids, int count)
            => SafeExecution<bool>(() => Native.SptreeLoad(sptree, boxes, ids, count));

        public static bool SptreeInsertTemporal(IntPtr sptree, IntPtr temp, long id)
            => SafeExecution<bool>(() => Native.SptreeInsertTemporal(sptree, temp, id));

        public static bool SptreeInsertTemporalSplit(IntPtr sptree, IntPtr temp, long id, int maxboxes)
            => SafeExecution<bool>(() => Native.SptreeInsertTemporalSplit(sptree, temp, id, maxboxes));

        public static int SptreeSearch(IntPtr sptree, int op, IntPtr query, IntPtr result)
            => SafeExecution<int>(() => Native.SptreeSearch(sptree, op, query, result));

        public static int SptreeJoin(IntPtr sptree1, IntPtr sptree2, int op, IntPtr result)
            => SafeExecution<int>(() => Native.SptreeJoin(sptree1, sptree2, op, result));

        public static int SptreeSearchTemporal(IntPtr sptree, int op, IntPtr temp, IntPtr result)
            => SafeExecution<int>(() => Native.SptreeSearchTemporal(sptree, op, temp, result));

        public static int SptreeSearchTemporalDedup(IntPtr sptree, int op, IntPtr temp, int maxboxes, IntPtr result)
            => SafeExecution<int>(() => Native.SptreeSearchTemporalDedup(sptree, op, temp, maxboxes, result));

        public static IntPtr SptreeNnCursorOpen(IntPtr sptree, IntPtr query)
            => SafeExecution<IntPtr>(() => Native.SptreeNnCursorOpen(sptree, query));

        public static bool SptreeNnCursorNext(IntPtr cursor, IntPtr id_out, IntPtr dist_out)
            => SafeExecution<bool>(() => Native.SptreeNnCursorNext(cursor, id_out, dist_out));

        public static void SptreeNnCursorClose(IntPtr cursor)
            => SafeExecution(() => Native.SptreeNnCursorClose(cursor));

        public static void MeosInitializeErrorHandler(IntPtr err_handler)
            => SafeExecution(() => Native.MeosInitializeErrorHandler(err_handler));

        public static void MeosInitializeAllocator(IntPtr malloc_fn, IntPtr realloc_fn, IntPtr free_fn)
            => SafeExecution(() => Native.MeosInitializeAllocator(malloc_fn, realloc_fn, free_fn));

        public static void MeosInitializeNoexitErrorHandler()
            => SafeExecution(() => Native.MeosInitializeNoexitErrorHandler());

        public static void MeosInitializeTimezone(string name)
            => SafeExecution(() => Native.MeosInitializeTimezone(name));

        public static void MeosInitializeCollation()
            => SafeExecution(() => Native.MeosInitializeCollation());

        public static void MeosFinalizeTimezone()
            => SafeExecution(() => Native.MeosFinalizeTimezone());

        public static void MeosFinalizeCollation()
            => SafeExecution(() => Native.MeosFinalizeCollation());

        public static void MeosFinalizeProjsrs()
            => SafeExecution(() => Native.MeosFinalizeProjsrs());

        public static void MeosFinalizeWays()
            => SafeExecution(() => Native.MeosFinalizeWays());

        public static void MeosInitializePointcloud()
            => SafeExecution(() => Native.MeosInitializePointcloud());

        public static bool MeosSetDatestyle(string newval, IntPtr extra)
            => SafeExecution<bool>(() => Native.MeosSetDatestyle(newval, extra));

        public static bool MeosSetIntervalstyle(string newval, int extra)
            => SafeExecution<bool>(() => Native.MeosSetIntervalstyle(newval, extra));

        public static string MeosGetDatestyle()
            => SafeExecution<string>(() => Native.MeosGetDatestyle());

        public static string MeosGetIntervalstyle()
            => SafeExecution<string>(() => Native.MeosGetIntervalstyle());

        public static void MeosSetSpatialRefSysCsv(string path)
            => SafeExecution(() => Native.MeosSetSpatialRefSysCsv(path));

        public static void MeosSetWaysCsv(string path)
            => SafeExecution(() => Native.MeosSetWaysCsv(path));

        public static void MeosInitialize()
            => SafeExecution(() => Native.MeosInitialize());

        public static void MeosFinalize()
            => SafeExecution(() => Native.MeosFinalize());

        public static string MeosVersion()
            => SafeExecution<string>(() => Native.MeosVersion());

        public static string MeosFullVersion()
            => SafeExecution<string>(() => Native.MeosFullVersion());

        public static string MobilitydbVersion()
            => SafeExecution<string>(() => Native.MobilitydbVersion());

        public static string MobilitydbFullVersion()
            => SafeExecution<string>(() => Native.MobilitydbFullVersion());

        public static IntPtr BigintsetIn(string str)
            => SafeExecution<IntPtr>(() => Native.BigintsetIn(str));

        public static string BigintsetOut(IntPtr set)
            => SafeExecution<string>(() => Native.BigintsetOut(set));

        public static IntPtr BigintspanExpand(IntPtr s, long value)
            => SafeExecution<IntPtr>(() => Native.BigintspanExpand(s, value));

        public static IntPtr BigintspanIn(string str)
            => SafeExecution<IntPtr>(() => Native.BigintspanIn(str));

        public static string BigintspanOut(IntPtr s)
            => SafeExecution<string>(() => Native.BigintspanOut(s));

        public static IntPtr BigintspansetIn(string str)
            => SafeExecution<IntPtr>(() => Native.BigintspansetIn(str));

        public static string BigintspansetOut(IntPtr ss)
            => SafeExecution<string>(() => Native.BigintspansetOut(ss));

        public static IntPtr DatesetIn(string str)
            => SafeExecution<IntPtr>(() => Native.DatesetIn(str));

        public static string DatesetOut(IntPtr s)
            => SafeExecution<string>(() => Native.DatesetOut(s));

        public static IntPtr DatespanIn(string str)
            => SafeExecution<IntPtr>(() => Native.DatespanIn(str));

        public static string DatespanOut(IntPtr s)
            => SafeExecution<string>(() => Native.DatespanOut(s));

        public static IntPtr DatespansetIn(string str)
            => SafeExecution<IntPtr>(() => Native.DatespansetIn(str));

        public static string DatespansetOut(IntPtr ss)
            => SafeExecution<string>(() => Native.DatespansetOut(ss));

        public static IntPtr FloatsetIn(string str)
            => SafeExecution<IntPtr>(() => Native.FloatsetIn(str));

        public static string FloatsetOut(IntPtr set, int maxdd)
            => SafeExecution<string>(() => Native.FloatsetOut(set, maxdd));

        public static IntPtr FloatspanExpand(IntPtr s, double value)
            => SafeExecution<IntPtr>(() => Native.FloatspanExpand(s, value));

        public static IntPtr FloatspanIn(string str)
            => SafeExecution<IntPtr>(() => Native.FloatspanIn(str));

        public static string FloatspanOut(IntPtr s, int maxdd)
            => SafeExecution<string>(() => Native.FloatspanOut(s, maxdd));

        public static IntPtr FloatspansetIn(string str)
            => SafeExecution<IntPtr>(() => Native.FloatspansetIn(str));

        public static string FloatspansetOut(IntPtr ss, int maxdd)
            => SafeExecution<string>(() => Native.FloatspansetOut(ss, maxdd));

        public static IntPtr IntsetIn(string str)
            => SafeExecution<IntPtr>(() => Native.IntsetIn(str));

        public static string IntsetOut(IntPtr set)
            => SafeExecution<string>(() => Native.IntsetOut(set));

        public static IntPtr IntspanExpand(IntPtr s, int value)
            => SafeExecution<IntPtr>(() => Native.IntspanExpand(s, value));

        public static IntPtr IntspanIn(string str)
            => SafeExecution<IntPtr>(() => Native.IntspanIn(str));

        public static string IntspanOut(IntPtr s)
            => SafeExecution<string>(() => Native.IntspanOut(s));

        public static IntPtr IntspansetIn(string str)
            => SafeExecution<IntPtr>(() => Native.IntspansetIn(str));

        public static string IntspansetOut(IntPtr ss)
            => SafeExecution<string>(() => Native.IntspansetOut(ss));

        public static string SetAsHexwkb(IntPtr s, byte variant, IntPtr size_out)
            => SafeExecution<string>(() => Native.SetAsHexwkb(s, variant, size_out));

        public static IntPtr SetAsWkb(IntPtr s, byte variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => Native.SetAsWkb(s, variant, size_out));

        public static IntPtr SetFromHexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => Native.SetFromHexwkb(hexwkb));

        public static IntPtr SetFromWkb(IntPtr wkb, ulong size)
            => SafeExecution<IntPtr>(() => Native.SetFromWkb(wkb, size));

        public static string SpanAsHexwkb(IntPtr s, byte variant, IntPtr size_out)
            => SafeExecution<string>(() => Native.SpanAsHexwkb(s, variant, size_out));

        public static IntPtr SpanAsWkb(IntPtr s, byte variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => Native.SpanAsWkb(s, variant, size_out));

        public static IntPtr SpanFromHexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => Native.SpanFromHexwkb(hexwkb));

        public static IntPtr SpanFromWkb(IntPtr wkb, ulong size)
            => SafeExecution<IntPtr>(() => Native.SpanFromWkb(wkb, size));

        public static string SpansetAsHexwkb(IntPtr ss, byte variant, IntPtr size_out)
            => SafeExecution<string>(() => Native.SpansetAsHexwkb(ss, variant, size_out));

        public static IntPtr SpansetAsWkb(IntPtr ss, byte variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => Native.SpansetAsWkb(ss, variant, size_out));

        public static IntPtr SpansetFromHexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => Native.SpansetFromHexwkb(hexwkb));

        public static IntPtr SpansetFromWkb(IntPtr wkb, ulong size)
            => SafeExecution<IntPtr>(() => Native.SpansetFromWkb(wkb, size));

        public static IntPtr TextsetIn(string str)
            => SafeExecution<IntPtr>(() => Native.TextsetIn(str));

        public static string TextsetOut(IntPtr set)
            => SafeExecution<string>(() => Native.TextsetOut(set));

        public static IntPtr TstzsetIn(string str)
            => SafeExecution<IntPtr>(() => Native.TstzsetIn(str));

        public static string TstzsetOut(IntPtr set)
            => SafeExecution<string>(() => Native.TstzsetOut(set));

        public static IntPtr TstzspanIn(string str)
            => SafeExecution<IntPtr>(() => Native.TstzspanIn(str));

        public static string TstzspanOut(IntPtr s)
            => SafeExecution<string>(() => Native.TstzspanOut(s));

        public static IntPtr TstzspansetIn(string str)
            => SafeExecution<IntPtr>(() => Native.TstzspansetIn(str));

        public static string TstzspansetOut(IntPtr ss)
            => SafeExecution<string>(() => Native.TstzspansetOut(ss));

        public static IntPtr BigintsetMake(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => Native.BigintsetMake(values, count));

        public static IntPtr BigintspanMake(long lower, long upper, bool lower_inc, bool upper_inc)
            => SafeExecution<IntPtr>(() => Native.BigintspanMake(lower, upper, lower_inc, upper_inc));

        public static IntPtr DatesetMake(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => Native.DatesetMake(values, count));

        public static IntPtr DatespanMake(int lower, int upper, bool lower_inc, bool upper_inc)
            => SafeExecution<IntPtr>(() => Native.DatespanMake(lower, upper, lower_inc, upper_inc));

        public static IntPtr FloatsetMake(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => Native.FloatsetMake(values, count));

        public static IntPtr FloatspanMake(double lower, double upper, bool lower_inc, bool upper_inc)
            => SafeExecution<IntPtr>(() => Native.FloatspanMake(lower, upper, lower_inc, upper_inc));

        public static IntPtr IntsetMake(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => Native.IntsetMake(values, count));

        public static IntPtr IntspanMake(int lower, int upper, bool lower_inc, bool upper_inc)
            => SafeExecution<IntPtr>(() => Native.IntspanMake(lower, upper, lower_inc, upper_inc));

        public static IntPtr SetCopy(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.SetCopy(s));

        public static IntPtr SpanCopy(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.SpanCopy(s));

        public static IntPtr SpansetCopy(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.SpansetCopy(ss));

        public static IntPtr SpansetMake(IntPtr spans, int count)
            => SafeExecution<IntPtr>(() => Native.SpansetMake(spans, count));

        public static IntPtr TextsetMake(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => Native.TextsetMake(values, count));

        public static IntPtr TstzsetMake(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => Native.TstzsetMake(values, count));

        public static IntPtr TstzspanMake(long lower, long upper, bool lower_inc, bool upper_inc)
            => SafeExecution<IntPtr>(() => Native.TstzspanMake(lower, upper, lower_inc, upper_inc));

        public static IntPtr BigintToSet(long i)
            => SafeExecution<IntPtr>(() => Native.BigintToSet(i));

        public static IntPtr BigintToSpan(int i)
            => SafeExecution<IntPtr>(() => Native.BigintToSpan(i));

        public static IntPtr BigintToSpanset(int i)
            => SafeExecution<IntPtr>(() => Native.BigintToSpanset(i));

        public static IntPtr DateToSet(int d)
            => SafeExecution<IntPtr>(() => Native.DateToSet(d));

        public static IntPtr DateToSpan(int d)
            => SafeExecution<IntPtr>(() => Native.DateToSpan(d));

        public static IntPtr DateToSpanset(int d)
            => SafeExecution<IntPtr>(() => Native.DateToSpanset(d));

        public static IntPtr DatesetToTstzset(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.DatesetToTstzset(s));

        public static IntPtr DatespanToTstzspan(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.DatespanToTstzspan(s));

        public static IntPtr DatespansetToTstzspanset(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.DatespansetToTstzspanset(ss));

        public static IntPtr FloatToSet(double d)
            => SafeExecution<IntPtr>(() => Native.FloatToSet(d));

        public static IntPtr FloatToSpan(double d)
            => SafeExecution<IntPtr>(() => Native.FloatToSpan(d));

        public static IntPtr FloatToSpanset(double d)
            => SafeExecution<IntPtr>(() => Native.FloatToSpanset(d));

        public static IntPtr FloatsetToIntset(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.FloatsetToIntset(s));

        public static IntPtr FloatspanToIntspan(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.FloatspanToIntspan(s));

        public static IntPtr FloatspanToBigintspan(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.FloatspanToBigintspan(s));

        public static IntPtr FloatspansetToIntspanset(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.FloatspansetToIntspanset(ss));

        public static IntPtr IntToSet(int i)
            => SafeExecution<IntPtr>(() => Native.IntToSet(i));

        public static IntPtr IntToSpan(int i)
            => SafeExecution<IntPtr>(() => Native.IntToSpan(i));

        public static IntPtr IntToSpanset(int i)
            => SafeExecution<IntPtr>(() => Native.IntToSpanset(i));

        public static IntPtr IntsetToFloatset(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.IntsetToFloatset(s));

        public static IntPtr IntspanToFloatspan(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.IntspanToFloatspan(s));

        public static IntPtr IntspanToBigintspan(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.IntspanToBigintspan(s));

        public static IntPtr BigintspanToIntspan(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.BigintspanToIntspan(s));

        public static IntPtr BigintspanToFloatspan(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.BigintspanToFloatspan(s));

        public static IntPtr IntspansetToFloatspanset(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.IntspansetToFloatspanset(ss));

        public static IntPtr SetToSpan(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.SetToSpan(s));

        public static IntPtr SetToSpanset(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.SetToSpanset(s));

        public static IntPtr SpanToSpanset(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.SpanToSpanset(s));

        public static IntPtr TextToSet(IntPtr txt)
            => SafeExecution<IntPtr>(() => Native.TextToSet(txt));

        public static IntPtr TimestamptzToSet(long t)
            => SafeExecution<IntPtr>(() => Native.TimestamptzToSet(t));

        public static IntPtr TimestamptzToSpan(long t)
            => SafeExecution<IntPtr>(() => Native.TimestamptzToSpan(t));

        public static IntPtr TimestamptzToSpanset(long t)
            => SafeExecution<IntPtr>(() => Native.TimestamptzToSpanset(t));

        public static IntPtr TstzsetToDateset(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TstzsetToDateset(s));

        public static IntPtr TstzspanToDatespan(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TstzspanToDatespan(s));

        public static IntPtr TstzspansetToDatespanset(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TstzspansetToDatespanset(ss));

        public static long BigintsetEndValue(IntPtr s)
            => SafeExecution<long>(() => Native.BigintsetEndValue(s));

        public static long BigintsetStartValue(IntPtr s)
            => SafeExecution<long>(() => Native.BigintsetStartValue(s));

        public static bool BigintsetValueN(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.BigintsetValueN(s, n, result));

        public static long[] BigintsetValues(IntPtr s)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.BigintsetValues(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                long[] _out = new long[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static long BigintspanLower(IntPtr s)
            => SafeExecution<long>(() => Native.BigintspanLower(s));

        public static long BigintspanUpper(IntPtr s)
            => SafeExecution<long>(() => Native.BigintspanUpper(s));

        public static long BigintspanWidth(IntPtr s)
            => SafeExecution<long>(() => Native.BigintspanWidth(s));

        public static long BigintspansetLower(IntPtr ss)
            => SafeExecution<long>(() => Native.BigintspansetLower(ss));

        public static long BigintspansetUpper(IntPtr ss)
            => SafeExecution<long>(() => Native.BigintspansetUpper(ss));

        public static long BigintspansetWidth(IntPtr ss, bool boundspan)
            => SafeExecution<long>(() => Native.BigintspansetWidth(ss, boundspan));

        public static int DatesetEndValue(IntPtr s)
            => SafeExecution<int>(() => Native.DatesetEndValue(s));

        public static int DatesetStartValue(IntPtr s)
            => SafeExecution<int>(() => Native.DatesetStartValue(s));

        public static bool DatesetValueN(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.DatesetValueN(s, n, result));

        public static int[] DatesetValues(IntPtr s)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.DatesetValues(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                int[] _out = new int[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr DatespanDuration(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.DatespanDuration(s));

        public static int DatespanLower(IntPtr s)
            => SafeExecution<int>(() => Native.DatespanLower(s));

        public static int DatespanUpper(IntPtr s)
            => SafeExecution<int>(() => Native.DatespanUpper(s));

        public static bool DatespansetDateN(IntPtr ss, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.DatespansetDateN(ss, n, result));

        public static IntPtr DatespansetDates(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.DatespansetDates(ss));

        public static IntPtr DatespansetDuration(IntPtr ss, bool boundspan)
            => SafeExecution<IntPtr>(() => Native.DatespansetDuration(ss, boundspan));

        public static int DatespansetEndDate(IntPtr ss)
            => SafeExecution<int>(() => Native.DatespansetEndDate(ss));

        public static int DatespansetLower(IntPtr ss)
            => SafeExecution<int>(() => Native.DatespansetLower(ss));

        public static int DatespansetNumDates(IntPtr ss)
            => SafeExecution<int>(() => Native.DatespansetNumDates(ss));

        public static int DatespansetStartDate(IntPtr ss)
            => SafeExecution<int>(() => Native.DatespansetStartDate(ss));

        public static int DatespansetUpper(IntPtr ss)
            => SafeExecution<int>(() => Native.DatespansetUpper(ss));

        public static double FloatsetEndValue(IntPtr s)
            => SafeExecution<double>(() => Native.FloatsetEndValue(s));

        public static double FloatsetStartValue(IntPtr s)
            => SafeExecution<double>(() => Native.FloatsetStartValue(s));

        public static bool FloatsetValueN(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.FloatsetValueN(s, n, result));

        public static double[] FloatsetValues(IntPtr s)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.FloatsetValues(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                double[] _out = new double[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static double FloatspanLower(IntPtr s)
            => SafeExecution<double>(() => Native.FloatspanLower(s));

        public static double FloatspanUpper(IntPtr s)
            => SafeExecution<double>(() => Native.FloatspanUpper(s));

        public static double FloatspanWidth(IntPtr s)
            => SafeExecution<double>(() => Native.FloatspanWidth(s));

        public static double FloatspansetLower(IntPtr ss)
            => SafeExecution<double>(() => Native.FloatspansetLower(ss));

        public static double FloatspansetUpper(IntPtr ss)
            => SafeExecution<double>(() => Native.FloatspansetUpper(ss));

        public static double FloatspansetWidth(IntPtr ss, bool boundspan)
            => SafeExecution<double>(() => Native.FloatspansetWidth(ss, boundspan));

        public static int IntsetEndValue(IntPtr s)
            => SafeExecution<int>(() => Native.IntsetEndValue(s));

        public static int IntsetStartValue(IntPtr s)
            => SafeExecution<int>(() => Native.IntsetStartValue(s));

        public static bool IntsetValueN(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.IntsetValueN(s, n, result));

        public static int[] IntsetValues(IntPtr s)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.IntsetValues(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                int[] _out = new int[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int IntspanLower(IntPtr s)
            => SafeExecution<int>(() => Native.IntspanLower(s));

        public static int IntspanUpper(IntPtr s)
            => SafeExecution<int>(() => Native.IntspanUpper(s));

        public static int IntspanWidth(IntPtr s)
            => SafeExecution<int>(() => Native.IntspanWidth(s));

        public static int IntspansetLower(IntPtr ss)
            => SafeExecution<int>(() => Native.IntspansetLower(ss));

        public static int IntspansetUpper(IntPtr ss)
            => SafeExecution<int>(() => Native.IntspansetUpper(ss));

        public static int IntspansetWidth(IntPtr ss, bool boundspan)
            => SafeExecution<int>(() => Native.IntspansetWidth(ss, boundspan));

        public static uint SetHash(IntPtr s)
            => SafeExecution<uint>(() => Native.SetHash(s));

        public static ulong SetHashExtended(IntPtr s, ulong seed)
            => SafeExecution<ulong>(() => Native.SetHashExtended(s, seed));

        public static int SetNumValues(IntPtr s)
            => SafeExecution<int>(() => Native.SetNumValues(s));

        public static uint SpanHash(IntPtr s)
            => SafeExecution<uint>(() => Native.SpanHash(s));

        public static ulong SpanHashExtended(IntPtr s, ulong seed)
            => SafeExecution<ulong>(() => Native.SpanHashExtended(s, seed));

        public static bool SpanLowerInc(IntPtr s)
            => SafeExecution<bool>(() => Native.SpanLowerInc(s));

        public static bool SpanUpperInc(IntPtr s)
            => SafeExecution<bool>(() => Native.SpanUpperInc(s));

        public static IntPtr SpansetEndSpan(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.SpansetEndSpan(ss));

        public static uint SpansetHash(IntPtr ss)
            => SafeExecution<uint>(() => Native.SpansetHash(ss));

        public static ulong SpansetHashExtended(IntPtr ss, ulong seed)
            => SafeExecution<ulong>(() => Native.SpansetHashExtended(ss, seed));

        public static bool SpansetLowerInc(IntPtr ss)
            => SafeExecution<bool>(() => Native.SpansetLowerInc(ss));

        public static int SpansetNumSpans(IntPtr ss)
            => SafeExecution<int>(() => Native.SpansetNumSpans(ss));

        public static IntPtr SpansetSpan(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.SpansetSpan(ss));

        public static IntPtr SpansetSpanN(IntPtr ss, int i)
            => SafeExecution<IntPtr>(() => Native.SpansetSpanN(ss, i));

        public static IntPtr[] SpansetSpanarr(IntPtr ss)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.SpansetSpanarr(ss, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr SpansetStartSpan(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.SpansetStartSpan(ss));

        public static bool SpansetUpperInc(IntPtr ss)
            => SafeExecution<bool>(() => Native.SpansetUpperInc(ss));

        public static IntPtr TextsetEndValue(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TextsetEndValue(s));

        public static IntPtr TextsetStartValue(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TextsetStartValue(s));

        public static bool TextsetValueN(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.TextsetValueN(s, n, result));

        public static IntPtr[] TextsetValues(IntPtr s)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TextsetValues(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static long TstzsetEndValue(IntPtr s)
            => SafeExecution<long>(() => Native.TstzsetEndValue(s));

        public static long TstzsetStartValue(IntPtr s)
            => SafeExecution<long>(() => Native.TstzsetStartValue(s));

        public static bool TstzsetValueN(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.TstzsetValueN(s, n, result));

        public static long[] TstzsetValues(IntPtr s)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TstzsetValues(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                long[] _out = new long[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr TstzspanDuration(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TstzspanDuration(s));

        public static long TstzspanLower(IntPtr s)
            => SafeExecution<long>(() => Native.TstzspanLower(s));

        public static long TstzspanUpper(IntPtr s)
            => SafeExecution<long>(() => Native.TstzspanUpper(s));

        public static IntPtr TstzspansetDuration(IntPtr ss, bool boundspan)
            => SafeExecution<IntPtr>(() => Native.TstzspansetDuration(ss, boundspan));

        public static long TstzspansetEndTimestamptz(IntPtr ss)
            => SafeExecution<long>(() => Native.TstzspansetEndTimestamptz(ss));

        public static long TstzspansetLower(IntPtr ss)
            => SafeExecution<long>(() => Native.TstzspansetLower(ss));

        public static int TstzspansetNumTimestamps(IntPtr ss)
            => SafeExecution<int>(() => Native.TstzspansetNumTimestamps(ss));

        public static long TstzspansetStartTimestamptz(IntPtr ss)
            => SafeExecution<long>(() => Native.TstzspansetStartTimestamptz(ss));

        public static IntPtr TstzspansetTimestamps(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TstzspansetTimestamps(ss));

        public static bool TstzspansetTimestamptzN(IntPtr ss, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.TstzspansetTimestamptzN(ss, n, result));

        public static long TstzspansetUpper(IntPtr ss)
            => SafeExecution<long>(() => Native.TstzspansetUpper(ss));

        public static IntPtr BigintsetShiftScale(IntPtr s, long shift, long width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => Native.BigintsetShiftScale(s, shift, width, hasshift, haswidth));

        public static IntPtr BigintspanShiftScale(IntPtr s, long shift, long width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => Native.BigintspanShiftScale(s, shift, width, hasshift, haswidth));

        public static IntPtr BigintspansetShiftScale(IntPtr ss, long shift, long width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => Native.BigintspansetShiftScale(ss, shift, width, hasshift, haswidth));

        public static IntPtr DatesetShiftScale(IntPtr s, int shift, int width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => Native.DatesetShiftScale(s, shift, width, hasshift, haswidth));

        public static IntPtr DatespanShiftScale(IntPtr s, int shift, int width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => Native.DatespanShiftScale(s, shift, width, hasshift, haswidth));

        public static IntPtr DatespansetShiftScale(IntPtr ss, int shift, int width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => Native.DatespansetShiftScale(ss, shift, width, hasshift, haswidth));

        public static IntPtr FloatsetCeil(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.FloatsetCeil(s));

        public static IntPtr FloatsetDegrees(IntPtr s, bool normalize)
            => SafeExecution<IntPtr>(() => Native.FloatsetDegrees(s, normalize));

        public static IntPtr FloatsetFloor(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.FloatsetFloor(s));

        public static IntPtr FloatsetRadians(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.FloatsetRadians(s));

        public static IntPtr FloatsetShiftScale(IntPtr s, double shift, double width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => Native.FloatsetShiftScale(s, shift, width, hasshift, haswidth));

        public static IntPtr FloatspanCeil(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.FloatspanCeil(s));

        public static IntPtr FloatspanDegrees(IntPtr s, bool normalize)
            => SafeExecution<IntPtr>(() => Native.FloatspanDegrees(s, normalize));

        public static IntPtr FloatspanFloor(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.FloatspanFloor(s));

        public static IntPtr FloatspanRadians(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.FloatspanRadians(s));

        public static IntPtr FloatspanRound(IntPtr s, int maxdd)
            => SafeExecution<IntPtr>(() => Native.FloatspanRound(s, maxdd));

        public static IntPtr FloatspanShiftScale(IntPtr s, double shift, double width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => Native.FloatspanShiftScale(s, shift, width, hasshift, haswidth));

        public static IntPtr FloatspansetCeil(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.FloatspansetCeil(ss));

        public static IntPtr FloatspansetFloor(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.FloatspansetFloor(ss));

        public static IntPtr FloatspansetDegrees(IntPtr ss, bool normalize)
            => SafeExecution<IntPtr>(() => Native.FloatspansetDegrees(ss, normalize));

        public static IntPtr FloatspansetRadians(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.FloatspansetRadians(ss));

        public static IntPtr FloatspansetRound(IntPtr ss, int maxdd)
            => SafeExecution<IntPtr>(() => Native.FloatspansetRound(ss, maxdd));

        public static IntPtr FloatspansetShiftScale(IntPtr ss, double shift, double width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => Native.FloatspansetShiftScale(ss, shift, width, hasshift, haswidth));

        public static IntPtr IntsetShiftScale(IntPtr s, int shift, int width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => Native.IntsetShiftScale(s, shift, width, hasshift, haswidth));

        public static IntPtr IntspanShiftScale(IntPtr s, int shift, int width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => Native.IntspanShiftScale(s, shift, width, hasshift, haswidth));

        public static IntPtr IntspansetShiftScale(IntPtr ss, int shift, int width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => Native.IntspansetShiftScale(ss, shift, width, hasshift, haswidth));

        public static IntPtr TstzspanExpand(IntPtr s, IntPtr interv)
            => SafeExecution<IntPtr>(() => Native.TstzspanExpand(s, interv));

        public static IntPtr SetRound(IntPtr s, int maxdd)
            => SafeExecution<IntPtr>(() => Native.SetRound(s, maxdd));

        public static IntPtr TextcatTextTextset(IntPtr txt, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TextcatTextTextset(txt, s));

        public static IntPtr TextcatTextsetText(IntPtr s, IntPtr txt)
            => SafeExecution<IntPtr>(() => Native.TextcatTextsetText(s, txt));

        public static IntPtr TextsetInitcap(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TextsetInitcap(s));

        public static IntPtr TextsetLower(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TextsetLower(s));

        public static IntPtr TextsetUpper(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TextsetUpper(s));

        public static long TimestamptzTprecision(long t, IntPtr duration, long torigin)
            => SafeExecution<long>(() => Native.TimestamptzTprecision(t, duration, torigin));

        public static IntPtr TstzsetShiftScale(IntPtr s, IntPtr shift, IntPtr duration)
            => SafeExecution<IntPtr>(() => Native.TstzsetShiftScale(s, shift, duration));

        public static IntPtr TstzsetTprecision(IntPtr s, IntPtr duration, long torigin)
            => SafeExecution<IntPtr>(() => Native.TstzsetTprecision(s, duration, torigin));

        public static IntPtr TstzspanShiftScale(IntPtr s, IntPtr shift, IntPtr duration)
            => SafeExecution<IntPtr>(() => Native.TstzspanShiftScale(s, shift, duration));

        public static IntPtr TstzspanTprecision(IntPtr s, IntPtr duration, long torigin)
            => SafeExecution<IntPtr>(() => Native.TstzspanTprecision(s, duration, torigin));

        public static IntPtr TstzspansetShiftScale(IntPtr ss, IntPtr shift, IntPtr duration)
            => SafeExecution<IntPtr>(() => Native.TstzspansetShiftScale(ss, shift, duration));

        public static IntPtr TstzspansetTprecision(IntPtr ss, IntPtr duration, long torigin)
            => SafeExecution<IntPtr>(() => Native.TstzspansetTprecision(ss, duration, torigin));

        public static int SetCmp(IntPtr s1, IntPtr s2)
            => SafeExecution<int>(() => Native.SetCmp(s1, s2));

        public static bool SetEq(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.SetEq(s1, s2));

        public static bool SetGe(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.SetGe(s1, s2));

        public static bool SetGt(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.SetGt(s1, s2));

        public static bool SetLe(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.SetLe(s1, s2));

        public static bool SetLt(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.SetLt(s1, s2));

        public static bool SetNe(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.SetNe(s1, s2));

        public static int SpanCmp(IntPtr s1, IntPtr s2)
            => SafeExecution<int>(() => Native.SpanCmp(s1, s2));

        public static bool SpanEq(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.SpanEq(s1, s2));

        public static bool SpanGe(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.SpanGe(s1, s2));

        public static bool SpanGt(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.SpanGt(s1, s2));

        public static bool SpanLe(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.SpanLe(s1, s2));

        public static bool SpanLt(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.SpanLt(s1, s2));

        public static bool SpanNe(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.SpanNe(s1, s2));

        public static int SpansetCmp(IntPtr ss1, IntPtr ss2)
            => SafeExecution<int>(() => Native.SpansetCmp(ss1, ss2));

        public static bool SpansetEq(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => Native.SpansetEq(ss1, ss2));

        public static bool SpansetGe(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => Native.SpansetGe(ss1, ss2));

        public static bool SpansetGt(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => Native.SpansetGt(ss1, ss2));

        public static bool SpansetLe(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => Native.SpansetLe(ss1, ss2));

        public static bool SpansetLt(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => Native.SpansetLt(ss1, ss2));

        public static bool SpansetNe(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => Native.SpansetNe(ss1, ss2));

        public static IntPtr[] SetSpans(IntPtr s)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.SetSpans(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 24); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] SetSplitEachNSpans(IntPtr s, int elems_per_span)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.SetSplitEachNSpans(s, elems_per_span, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 24); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] SetSplitNSpans(IntPtr s, int span_count)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.SetSplitNSpans(s, span_count, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 24); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] SpansetSpans(IntPtr ss)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.SpansetSpans(ss, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 24); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] SpansetSplitEachNSpans(IntPtr ss, int elems_per_span)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.SpansetSplitEachNSpans(ss, elems_per_span, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 24); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] SpansetSplitNSpans(IntPtr ss, int span_count)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.SpansetSplitNSpans(ss, span_count, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 24); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool AdjacentSpanBigint(IntPtr s, long i)
            => SafeExecution<bool>(() => Native.AdjacentSpanBigint(s, i));

        public static bool AdjacentSpanDate(IntPtr s, int d)
            => SafeExecution<bool>(() => Native.AdjacentSpanDate(s, d));

        public static bool AdjacentSpanFloat(IntPtr s, double d)
            => SafeExecution<bool>(() => Native.AdjacentSpanFloat(s, d));

        public static bool AdjacentSpanInt(IntPtr s, int i)
            => SafeExecution<bool>(() => Native.AdjacentSpanInt(s, i));

        public static bool AdjacentSpanSpan(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.AdjacentSpanSpan(s1, s2));

        public static bool AdjacentSpanSpanset(IntPtr s, IntPtr ss)
            => SafeExecution<bool>(() => Native.AdjacentSpanSpanset(s, ss));

        public static bool AdjacentSpanTimestamptz(IntPtr s, long t)
            => SafeExecution<bool>(() => Native.AdjacentSpanTimestamptz(s, t));

        public static bool AdjacentBigintSpan(long i, IntPtr s)
            => SafeExecution<bool>(() => Native.AdjacentBigintSpan(i, s));

        public static bool AdjacentDateSpan(int d, IntPtr s)
            => SafeExecution<bool>(() => Native.AdjacentDateSpan(d, s));

        public static bool AdjacentFloatSpan(double d, IntPtr s)
            => SafeExecution<bool>(() => Native.AdjacentFloatSpan(d, s));

        public static bool AdjacentIntSpan(int i, IntPtr s)
            => SafeExecution<bool>(() => Native.AdjacentIntSpan(i, s));

        public static bool AdjacentTimestamptzSpan(long t, IntPtr s)
            => SafeExecution<bool>(() => Native.AdjacentTimestamptzSpan(t, s));

        public static bool AdjacentSpansetBigint(IntPtr ss, long i)
            => SafeExecution<bool>(() => Native.AdjacentSpansetBigint(ss, i));

        public static bool AdjacentSpansetDate(IntPtr ss, int d)
            => SafeExecution<bool>(() => Native.AdjacentSpansetDate(ss, d));

        public static bool AdjacentSpansetFloat(IntPtr ss, double d)
            => SafeExecution<bool>(() => Native.AdjacentSpansetFloat(ss, d));

        public static bool AdjacentSpansetInt(IntPtr ss, int i)
            => SafeExecution<bool>(() => Native.AdjacentSpansetInt(ss, i));

        public static bool AdjacentSpansetTimestamptz(IntPtr ss, long t)
            => SafeExecution<bool>(() => Native.AdjacentSpansetTimestamptz(ss, t));

        public static bool AdjacentSpansetSpan(IntPtr ss, IntPtr s)
            => SafeExecution<bool>(() => Native.AdjacentSpansetSpan(ss, s));

        public static bool AdjacentSpansetSpanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => Native.AdjacentSpansetSpanset(ss1, ss2));

        public static bool ContainedBigintSet(long i, IntPtr s)
            => SafeExecution<bool>(() => Native.ContainedBigintSet(i, s));

        public static bool ContainedBigintSpan(long i, IntPtr s)
            => SafeExecution<bool>(() => Native.ContainedBigintSpan(i, s));

        public static bool ContainedBigintSpanset(long i, IntPtr ss)
            => SafeExecution<bool>(() => Native.ContainedBigintSpanset(i, ss));

        public static bool ContainedDateSet(int d, IntPtr s)
            => SafeExecution<bool>(() => Native.ContainedDateSet(d, s));

        public static bool ContainedDateSpan(int d, IntPtr s)
            => SafeExecution<bool>(() => Native.ContainedDateSpan(d, s));

        public static bool ContainedDateSpanset(int d, IntPtr ss)
            => SafeExecution<bool>(() => Native.ContainedDateSpanset(d, ss));

        public static bool ContainedFloatSet(double d, IntPtr s)
            => SafeExecution<bool>(() => Native.ContainedFloatSet(d, s));

        public static bool ContainedFloatSpan(double d, IntPtr s)
            => SafeExecution<bool>(() => Native.ContainedFloatSpan(d, s));

        public static bool ContainedFloatSpanset(double d, IntPtr ss)
            => SafeExecution<bool>(() => Native.ContainedFloatSpanset(d, ss));

        public static bool ContainedIntSet(int i, IntPtr s)
            => SafeExecution<bool>(() => Native.ContainedIntSet(i, s));

        public static bool ContainedIntSpan(int i, IntPtr s)
            => SafeExecution<bool>(() => Native.ContainedIntSpan(i, s));

        public static bool ContainedIntSpanset(int i, IntPtr ss)
            => SafeExecution<bool>(() => Native.ContainedIntSpanset(i, ss));

        public static bool ContainedSetSet(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.ContainedSetSet(s1, s2));

        public static bool ContainedSpanSpan(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.ContainedSpanSpan(s1, s2));

        public static bool ContainedSpanSpanset(IntPtr s, IntPtr ss)
            => SafeExecution<bool>(() => Native.ContainedSpanSpanset(s, ss));

        public static bool ContainedSpansetSpan(IntPtr ss, IntPtr s)
            => SafeExecution<bool>(() => Native.ContainedSpansetSpan(ss, s));

        public static bool ContainedSpansetSpanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => Native.ContainedSpansetSpanset(ss1, ss2));

        public static bool ContainedTextSet(IntPtr txt, IntPtr s)
            => SafeExecution<bool>(() => Native.ContainedTextSet(txt, s));

        public static bool ContainedTimestamptzSet(long t, IntPtr s)
            => SafeExecution<bool>(() => Native.ContainedTimestamptzSet(t, s));

        public static bool ContainedTimestamptzSpan(long t, IntPtr s)
            => SafeExecution<bool>(() => Native.ContainedTimestamptzSpan(t, s));

        public static bool ContainedTimestamptzSpanset(long t, IntPtr ss)
            => SafeExecution<bool>(() => Native.ContainedTimestamptzSpanset(t, ss));

        public static bool ContainsSetBigint(IntPtr s, long i)
            => SafeExecution<bool>(() => Native.ContainsSetBigint(s, i));

        public static bool ContainsSetDate(IntPtr s, int d)
            => SafeExecution<bool>(() => Native.ContainsSetDate(s, d));

        public static bool ContainsSetFloat(IntPtr s, double d)
            => SafeExecution<bool>(() => Native.ContainsSetFloat(s, d));

        public static bool ContainsSetInt(IntPtr s, int i)
            => SafeExecution<bool>(() => Native.ContainsSetInt(s, i));

        public static bool ContainsSetSet(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.ContainsSetSet(s1, s2));

        public static bool ContainsSetText(IntPtr s, IntPtr t)
            => SafeExecution<bool>(() => Native.ContainsSetText(s, t));

        public static bool ContainsSetTimestamptz(IntPtr s, long t)
            => SafeExecution<bool>(() => Native.ContainsSetTimestamptz(s, t));

        public static bool ContainsSpanBigint(IntPtr s, long i)
            => SafeExecution<bool>(() => Native.ContainsSpanBigint(s, i));

        public static bool ContainsSpanDate(IntPtr s, int d)
            => SafeExecution<bool>(() => Native.ContainsSpanDate(s, d));

        public static bool ContainsSpanFloat(IntPtr s, double d)
            => SafeExecution<bool>(() => Native.ContainsSpanFloat(s, d));

        public static bool ContainsSpanInt(IntPtr s, int i)
            => SafeExecution<bool>(() => Native.ContainsSpanInt(s, i));

        public static bool ContainsSpanSpan(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.ContainsSpanSpan(s1, s2));

        public static bool ContainsSpanSpanset(IntPtr s, IntPtr ss)
            => SafeExecution<bool>(() => Native.ContainsSpanSpanset(s, ss));

        public static bool ContainsSpanTimestamptz(IntPtr s, long t)
            => SafeExecution<bool>(() => Native.ContainsSpanTimestamptz(s, t));

        public static bool ContainsSpansetBigint(IntPtr ss, long i)
            => SafeExecution<bool>(() => Native.ContainsSpansetBigint(ss, i));

        public static bool ContainsSpansetDate(IntPtr ss, int d)
            => SafeExecution<bool>(() => Native.ContainsSpansetDate(ss, d));

        public static bool ContainsSpansetFloat(IntPtr ss, double d)
            => SafeExecution<bool>(() => Native.ContainsSpansetFloat(ss, d));

        public static bool ContainsSpansetInt(IntPtr ss, int i)
            => SafeExecution<bool>(() => Native.ContainsSpansetInt(ss, i));

        public static bool ContainsSpansetSpan(IntPtr ss, IntPtr s)
            => SafeExecution<bool>(() => Native.ContainsSpansetSpan(ss, s));

        public static bool ContainsSpansetSpanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => Native.ContainsSpansetSpanset(ss1, ss2));

        public static bool ContainsSpansetTimestamptz(IntPtr ss, long t)
            => SafeExecution<bool>(() => Native.ContainsSpansetTimestamptz(ss, t));

        public static bool OverlapsSetSet(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.OverlapsSetSet(s1, s2));

        public static bool OverlapsSpanSpan(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.OverlapsSpanSpan(s1, s2));

        public static bool OverlapsSpanSpanset(IntPtr s, IntPtr ss)
            => SafeExecution<bool>(() => Native.OverlapsSpanSpanset(s, ss));

        public static bool OverlapsSpansetSpan(IntPtr ss, IntPtr s)
            => SafeExecution<bool>(() => Native.OverlapsSpansetSpan(ss, s));

        public static bool OverlapsSpansetSpanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => Native.OverlapsSpansetSpanset(ss1, ss2));

        public static bool SameSpanSpan(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.SameSpanSpan(s1, s2));

        public static bool AfterDateSet(int d, IntPtr s)
            => SafeExecution<bool>(() => Native.AfterDateSet(d, s));

        public static bool AfterDateSpan(int d, IntPtr s)
            => SafeExecution<bool>(() => Native.AfterDateSpan(d, s));

        public static bool AfterDateSpanset(int d, IntPtr ss)
            => SafeExecution<bool>(() => Native.AfterDateSpanset(d, ss));

        public static bool AfterSetDate(IntPtr s, int d)
            => SafeExecution<bool>(() => Native.AfterSetDate(s, d));

        public static bool AfterSetTimestamptz(IntPtr s, long t)
            => SafeExecution<bool>(() => Native.AfterSetTimestamptz(s, t));

        public static bool AfterSpanDate(IntPtr s, int d)
            => SafeExecution<bool>(() => Native.AfterSpanDate(s, d));

        public static bool AfterSpanTimestamptz(IntPtr s, long t)
            => SafeExecution<bool>(() => Native.AfterSpanTimestamptz(s, t));

        public static bool AfterSpansetDate(IntPtr ss, int d)
            => SafeExecution<bool>(() => Native.AfterSpansetDate(ss, d));

        public static bool AfterSpansetTimestamptz(IntPtr ss, long t)
            => SafeExecution<bool>(() => Native.AfterSpansetTimestamptz(ss, t));

        public static bool AfterTimestamptzSet(long t, IntPtr s)
            => SafeExecution<bool>(() => Native.AfterTimestamptzSet(t, s));

        public static bool AfterTimestamptzSpan(long t, IntPtr s)
            => SafeExecution<bool>(() => Native.AfterTimestamptzSpan(t, s));

        public static bool AfterTimestamptzSpanset(long t, IntPtr ss)
            => SafeExecution<bool>(() => Native.AfterTimestamptzSpanset(t, ss));

        public static bool BeforeDateSet(int d, IntPtr s)
            => SafeExecution<bool>(() => Native.BeforeDateSet(d, s));

        public static bool BeforeDateSpan(int d, IntPtr s)
            => SafeExecution<bool>(() => Native.BeforeDateSpan(d, s));

        public static bool BeforeDateSpanset(int d, IntPtr ss)
            => SafeExecution<bool>(() => Native.BeforeDateSpanset(d, ss));

        public static bool BeforeSetDate(IntPtr s, int d)
            => SafeExecution<bool>(() => Native.BeforeSetDate(s, d));

        public static bool BeforeSetTimestamptz(IntPtr s, long t)
            => SafeExecution<bool>(() => Native.BeforeSetTimestamptz(s, t));

        public static bool BeforeSpanDate(IntPtr s, int d)
            => SafeExecution<bool>(() => Native.BeforeSpanDate(s, d));

        public static bool BeforeSpanTimestamptz(IntPtr s, long t)
            => SafeExecution<bool>(() => Native.BeforeSpanTimestamptz(s, t));

        public static bool BeforeSpansetDate(IntPtr ss, int d)
            => SafeExecution<bool>(() => Native.BeforeSpansetDate(ss, d));

        public static bool BeforeSpansetTimestamptz(IntPtr ss, long t)
            => SafeExecution<bool>(() => Native.BeforeSpansetTimestamptz(ss, t));

        public static bool BeforeTimestamptzSet(long t, IntPtr s)
            => SafeExecution<bool>(() => Native.BeforeTimestamptzSet(t, s));

        public static bool BeforeTimestamptzSpan(long t, IntPtr s)
            => SafeExecution<bool>(() => Native.BeforeTimestamptzSpan(t, s));

        public static bool BeforeTimestamptzSpanset(long t, IntPtr ss)
            => SafeExecution<bool>(() => Native.BeforeTimestamptzSpanset(t, ss));

        public static bool LeftBigintSet(long i, IntPtr s)
            => SafeExecution<bool>(() => Native.LeftBigintSet(i, s));

        public static bool LeftBigintSpan(long i, IntPtr s)
            => SafeExecution<bool>(() => Native.LeftBigintSpan(i, s));

        public static bool LeftBigintSpanset(long i, IntPtr ss)
            => SafeExecution<bool>(() => Native.LeftBigintSpanset(i, ss));

        public static bool LeftFloatSet(double d, IntPtr s)
            => SafeExecution<bool>(() => Native.LeftFloatSet(d, s));

        public static bool LeftFloatSpan(double d, IntPtr s)
            => SafeExecution<bool>(() => Native.LeftFloatSpan(d, s));

        public static bool LeftFloatSpanset(double d, IntPtr ss)
            => SafeExecution<bool>(() => Native.LeftFloatSpanset(d, ss));

        public static bool LeftIntSet(int i, IntPtr s)
            => SafeExecution<bool>(() => Native.LeftIntSet(i, s));

        public static bool LeftIntSpan(int i, IntPtr s)
            => SafeExecution<bool>(() => Native.LeftIntSpan(i, s));

        public static bool LeftIntSpanset(int i, IntPtr ss)
            => SafeExecution<bool>(() => Native.LeftIntSpanset(i, ss));

        public static bool LeftSetBigint(IntPtr s, long i)
            => SafeExecution<bool>(() => Native.LeftSetBigint(s, i));

        public static bool LeftSetFloat(IntPtr s, double d)
            => SafeExecution<bool>(() => Native.LeftSetFloat(s, d));

        public static bool LeftSetInt(IntPtr s, int i)
            => SafeExecution<bool>(() => Native.LeftSetInt(s, i));

        public static bool LeftSetSet(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.LeftSetSet(s1, s2));

        public static bool LeftSetText(IntPtr s, IntPtr txt)
            => SafeExecution<bool>(() => Native.LeftSetText(s, txt));

        public static bool LeftSpanBigint(IntPtr s, long i)
            => SafeExecution<bool>(() => Native.LeftSpanBigint(s, i));

        public static bool LeftSpanFloat(IntPtr s, double d)
            => SafeExecution<bool>(() => Native.LeftSpanFloat(s, d));

        public static bool LeftSpanInt(IntPtr s, int i)
            => SafeExecution<bool>(() => Native.LeftSpanInt(s, i));

        public static bool LeftSpanSpan(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.LeftSpanSpan(s1, s2));

        public static bool LeftSpanSpanset(IntPtr s, IntPtr ss)
            => SafeExecution<bool>(() => Native.LeftSpanSpanset(s, ss));

        public static bool LeftSpansetBigint(IntPtr ss, long i)
            => SafeExecution<bool>(() => Native.LeftSpansetBigint(ss, i));

        public static bool LeftSpansetFloat(IntPtr ss, double d)
            => SafeExecution<bool>(() => Native.LeftSpansetFloat(ss, d));

        public static bool LeftSpansetInt(IntPtr ss, int i)
            => SafeExecution<bool>(() => Native.LeftSpansetInt(ss, i));

        public static bool LeftSpansetSpan(IntPtr ss, IntPtr s)
            => SafeExecution<bool>(() => Native.LeftSpansetSpan(ss, s));

        public static bool LeftSpansetSpanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => Native.LeftSpansetSpanset(ss1, ss2));

        public static bool LeftTextSet(IntPtr txt, IntPtr s)
            => SafeExecution<bool>(() => Native.LeftTextSet(txt, s));

        public static bool OverafterDateSet(int d, IntPtr s)
            => SafeExecution<bool>(() => Native.OverafterDateSet(d, s));

        public static bool OverafterDateSpan(int d, IntPtr s)
            => SafeExecution<bool>(() => Native.OverafterDateSpan(d, s));

        public static bool OverafterDateSpanset(int d, IntPtr ss)
            => SafeExecution<bool>(() => Native.OverafterDateSpanset(d, ss));

        public static bool OverafterSetDate(IntPtr s, int d)
            => SafeExecution<bool>(() => Native.OverafterSetDate(s, d));

        public static bool OverafterSetTimestamptz(IntPtr s, long t)
            => SafeExecution<bool>(() => Native.OverafterSetTimestamptz(s, t));

        public static bool OverafterSpanDate(IntPtr s, int d)
            => SafeExecution<bool>(() => Native.OverafterSpanDate(s, d));

        public static bool OverafterSpanTimestamptz(IntPtr s, long t)
            => SafeExecution<bool>(() => Native.OverafterSpanTimestamptz(s, t));

        public static bool OverafterSpansetDate(IntPtr ss, int d)
            => SafeExecution<bool>(() => Native.OverafterSpansetDate(ss, d));

        public static bool OverafterSpansetTimestamptz(IntPtr ss, long t)
            => SafeExecution<bool>(() => Native.OverafterSpansetTimestamptz(ss, t));

        public static bool OverafterTimestamptzSet(long t, IntPtr s)
            => SafeExecution<bool>(() => Native.OverafterTimestamptzSet(t, s));

        public static bool OverafterTimestamptzSpan(long t, IntPtr s)
            => SafeExecution<bool>(() => Native.OverafterTimestamptzSpan(t, s));

        public static bool OverafterTimestamptzSpanset(long t, IntPtr ss)
            => SafeExecution<bool>(() => Native.OverafterTimestamptzSpanset(t, ss));

        public static bool OverbeforeDateSet(int d, IntPtr s)
            => SafeExecution<bool>(() => Native.OverbeforeDateSet(d, s));

        public static bool OverbeforeDateSpan(int d, IntPtr s)
            => SafeExecution<bool>(() => Native.OverbeforeDateSpan(d, s));

        public static bool OverbeforeDateSpanset(int d, IntPtr ss)
            => SafeExecution<bool>(() => Native.OverbeforeDateSpanset(d, ss));

        public static bool OverbeforeSetDate(IntPtr s, int d)
            => SafeExecution<bool>(() => Native.OverbeforeSetDate(s, d));

        public static bool OverbeforeSetTimestamptz(IntPtr s, long t)
            => SafeExecution<bool>(() => Native.OverbeforeSetTimestamptz(s, t));

        public static bool OverbeforeSpanDate(IntPtr s, int d)
            => SafeExecution<bool>(() => Native.OverbeforeSpanDate(s, d));

        public static bool OverbeforeSpanTimestamptz(IntPtr s, long t)
            => SafeExecution<bool>(() => Native.OverbeforeSpanTimestamptz(s, t));

        public static bool OverbeforeSpansetDate(IntPtr ss, int d)
            => SafeExecution<bool>(() => Native.OverbeforeSpansetDate(ss, d));

        public static bool OverbeforeSpansetTimestamptz(IntPtr ss, long t)
            => SafeExecution<bool>(() => Native.OverbeforeSpansetTimestamptz(ss, t));

        public static bool OverbeforeTimestamptzSet(long t, IntPtr s)
            => SafeExecution<bool>(() => Native.OverbeforeTimestamptzSet(t, s));

        public static bool OverbeforeTimestamptzSpan(long t, IntPtr s)
            => SafeExecution<bool>(() => Native.OverbeforeTimestamptzSpan(t, s));

        public static bool OverbeforeTimestamptzSpanset(long t, IntPtr ss)
            => SafeExecution<bool>(() => Native.OverbeforeTimestamptzSpanset(t, ss));

        public static bool OverleftBigintSet(long i, IntPtr s)
            => SafeExecution<bool>(() => Native.OverleftBigintSet(i, s));

        public static bool OverleftBigintSpan(long i, IntPtr s)
            => SafeExecution<bool>(() => Native.OverleftBigintSpan(i, s));

        public static bool OverleftBigintSpanset(long i, IntPtr ss)
            => SafeExecution<bool>(() => Native.OverleftBigintSpanset(i, ss));

        public static bool OverleftFloatSet(double d, IntPtr s)
            => SafeExecution<bool>(() => Native.OverleftFloatSet(d, s));

        public static bool OverleftFloatSpan(double d, IntPtr s)
            => SafeExecution<bool>(() => Native.OverleftFloatSpan(d, s));

        public static bool OverleftFloatSpanset(double d, IntPtr ss)
            => SafeExecution<bool>(() => Native.OverleftFloatSpanset(d, ss));

        public static bool OverleftIntSet(int i, IntPtr s)
            => SafeExecution<bool>(() => Native.OverleftIntSet(i, s));

        public static bool OverleftIntSpan(int i, IntPtr s)
            => SafeExecution<bool>(() => Native.OverleftIntSpan(i, s));

        public static bool OverleftIntSpanset(int i, IntPtr ss)
            => SafeExecution<bool>(() => Native.OverleftIntSpanset(i, ss));

        public static bool OverleftSetBigint(IntPtr s, long i)
            => SafeExecution<bool>(() => Native.OverleftSetBigint(s, i));

        public static bool OverleftSetFloat(IntPtr s, double d)
            => SafeExecution<bool>(() => Native.OverleftSetFloat(s, d));

        public static bool OverleftSetInt(IntPtr s, int i)
            => SafeExecution<bool>(() => Native.OverleftSetInt(s, i));

        public static bool OverleftSetSet(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.OverleftSetSet(s1, s2));

        public static bool OverleftSetText(IntPtr s, IntPtr txt)
            => SafeExecution<bool>(() => Native.OverleftSetText(s, txt));

        public static bool OverleftSpanBigint(IntPtr s, long i)
            => SafeExecution<bool>(() => Native.OverleftSpanBigint(s, i));

        public static bool OverleftSpanFloat(IntPtr s, double d)
            => SafeExecution<bool>(() => Native.OverleftSpanFloat(s, d));

        public static bool OverleftSpanInt(IntPtr s, int i)
            => SafeExecution<bool>(() => Native.OverleftSpanInt(s, i));

        public static bool OverleftSpanSpan(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.OverleftSpanSpan(s1, s2));

        public static bool OverleftSpanSpanset(IntPtr s, IntPtr ss)
            => SafeExecution<bool>(() => Native.OverleftSpanSpanset(s, ss));

        public static bool OverleftSpansetBigint(IntPtr ss, long i)
            => SafeExecution<bool>(() => Native.OverleftSpansetBigint(ss, i));

        public static bool OverleftSpansetFloat(IntPtr ss, double d)
            => SafeExecution<bool>(() => Native.OverleftSpansetFloat(ss, d));

        public static bool OverleftSpansetInt(IntPtr ss, int i)
            => SafeExecution<bool>(() => Native.OverleftSpansetInt(ss, i));

        public static bool OverleftSpansetSpan(IntPtr ss, IntPtr s)
            => SafeExecution<bool>(() => Native.OverleftSpansetSpan(ss, s));

        public static bool OverleftSpansetSpanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => Native.OverleftSpansetSpanset(ss1, ss2));

        public static bool OverleftTextSet(IntPtr txt, IntPtr s)
            => SafeExecution<bool>(() => Native.OverleftTextSet(txt, s));

        public static bool OverrightBigintSet(long i, IntPtr s)
            => SafeExecution<bool>(() => Native.OverrightBigintSet(i, s));

        public static bool OverrightBigintSpan(long i, IntPtr s)
            => SafeExecution<bool>(() => Native.OverrightBigintSpan(i, s));

        public static bool OverrightBigintSpanset(long i, IntPtr ss)
            => SafeExecution<bool>(() => Native.OverrightBigintSpanset(i, ss));

        public static bool OverrightFloatSet(double d, IntPtr s)
            => SafeExecution<bool>(() => Native.OverrightFloatSet(d, s));

        public static bool OverrightFloatSpan(double d, IntPtr s)
            => SafeExecution<bool>(() => Native.OverrightFloatSpan(d, s));

        public static bool OverrightFloatSpanset(double d, IntPtr ss)
            => SafeExecution<bool>(() => Native.OverrightFloatSpanset(d, ss));

        public static bool OverrightIntSet(int i, IntPtr s)
            => SafeExecution<bool>(() => Native.OverrightIntSet(i, s));

        public static bool OverrightIntSpan(int i, IntPtr s)
            => SafeExecution<bool>(() => Native.OverrightIntSpan(i, s));

        public static bool OverrightIntSpanset(int i, IntPtr ss)
            => SafeExecution<bool>(() => Native.OverrightIntSpanset(i, ss));

        public static bool OverrightSetBigint(IntPtr s, long i)
            => SafeExecution<bool>(() => Native.OverrightSetBigint(s, i));

        public static bool OverrightSetFloat(IntPtr s, double d)
            => SafeExecution<bool>(() => Native.OverrightSetFloat(s, d));

        public static bool OverrightSetInt(IntPtr s, int i)
            => SafeExecution<bool>(() => Native.OverrightSetInt(s, i));

        public static bool OverrightSetSet(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.OverrightSetSet(s1, s2));

        public static bool OverrightSetText(IntPtr s, IntPtr txt)
            => SafeExecution<bool>(() => Native.OverrightSetText(s, txt));

        public static bool OverrightSpanBigint(IntPtr s, long i)
            => SafeExecution<bool>(() => Native.OverrightSpanBigint(s, i));

        public static bool OverrightSpanFloat(IntPtr s, double d)
            => SafeExecution<bool>(() => Native.OverrightSpanFloat(s, d));

        public static bool OverrightSpanInt(IntPtr s, int i)
            => SafeExecution<bool>(() => Native.OverrightSpanInt(s, i));

        public static bool OverrightSpanSpan(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.OverrightSpanSpan(s1, s2));

        public static bool OverrightSpanSpanset(IntPtr s, IntPtr ss)
            => SafeExecution<bool>(() => Native.OverrightSpanSpanset(s, ss));

        public static bool OverrightSpansetBigint(IntPtr ss, long i)
            => SafeExecution<bool>(() => Native.OverrightSpansetBigint(ss, i));

        public static bool OverrightSpansetFloat(IntPtr ss, double d)
            => SafeExecution<bool>(() => Native.OverrightSpansetFloat(ss, d));

        public static bool OverrightSpansetInt(IntPtr ss, int i)
            => SafeExecution<bool>(() => Native.OverrightSpansetInt(ss, i));

        public static bool OverrightSpansetSpan(IntPtr ss, IntPtr s)
            => SafeExecution<bool>(() => Native.OverrightSpansetSpan(ss, s));

        public static bool OverrightSpansetSpanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => Native.OverrightSpansetSpanset(ss1, ss2));

        public static bool OverrightTextSet(IntPtr txt, IntPtr s)
            => SafeExecution<bool>(() => Native.OverrightTextSet(txt, s));

        public static bool RightBigintSet(long i, IntPtr s)
            => SafeExecution<bool>(() => Native.RightBigintSet(i, s));

        public static bool RightBigintSpan(long i, IntPtr s)
            => SafeExecution<bool>(() => Native.RightBigintSpan(i, s));

        public static bool RightBigintSpanset(long i, IntPtr ss)
            => SafeExecution<bool>(() => Native.RightBigintSpanset(i, ss));

        public static bool RightFloatSet(double d, IntPtr s)
            => SafeExecution<bool>(() => Native.RightFloatSet(d, s));

        public static bool RightFloatSpan(double d, IntPtr s)
            => SafeExecution<bool>(() => Native.RightFloatSpan(d, s));

        public static bool RightFloatSpanset(double d, IntPtr ss)
            => SafeExecution<bool>(() => Native.RightFloatSpanset(d, ss));

        public static bool RightIntSet(int i, IntPtr s)
            => SafeExecution<bool>(() => Native.RightIntSet(i, s));

        public static bool RightIntSpan(int i, IntPtr s)
            => SafeExecution<bool>(() => Native.RightIntSpan(i, s));

        public static bool RightIntSpanset(int i, IntPtr ss)
            => SafeExecution<bool>(() => Native.RightIntSpanset(i, ss));

        public static bool RightSetBigint(IntPtr s, long i)
            => SafeExecution<bool>(() => Native.RightSetBigint(s, i));

        public static bool RightSetFloat(IntPtr s, double d)
            => SafeExecution<bool>(() => Native.RightSetFloat(s, d));

        public static bool RightSetInt(IntPtr s, int i)
            => SafeExecution<bool>(() => Native.RightSetInt(s, i));

        public static bool RightSetSet(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.RightSetSet(s1, s2));

        public static bool RightSetText(IntPtr s, IntPtr txt)
            => SafeExecution<bool>(() => Native.RightSetText(s, txt));

        public static bool RightSpanBigint(IntPtr s, long i)
            => SafeExecution<bool>(() => Native.RightSpanBigint(s, i));

        public static bool RightSpanFloat(IntPtr s, double d)
            => SafeExecution<bool>(() => Native.RightSpanFloat(s, d));

        public static bool RightSpanInt(IntPtr s, int i)
            => SafeExecution<bool>(() => Native.RightSpanInt(s, i));

        public static bool RightSpanSpan(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.RightSpanSpan(s1, s2));

        public static bool RightSpanSpanset(IntPtr s, IntPtr ss)
            => SafeExecution<bool>(() => Native.RightSpanSpanset(s, ss));

        public static bool RightSpansetBigint(IntPtr ss, long i)
            => SafeExecution<bool>(() => Native.RightSpansetBigint(ss, i));

        public static bool RightSpansetFloat(IntPtr ss, double d)
            => SafeExecution<bool>(() => Native.RightSpansetFloat(ss, d));

        public static bool RightSpansetInt(IntPtr ss, int i)
            => SafeExecution<bool>(() => Native.RightSpansetInt(ss, i));

        public static bool RightSpansetSpan(IntPtr ss, IntPtr s)
            => SafeExecution<bool>(() => Native.RightSpansetSpan(ss, s));

        public static bool RightSpansetSpanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => Native.RightSpansetSpanset(ss1, ss2));

        public static bool RightTextSet(IntPtr txt, IntPtr s)
            => SafeExecution<bool>(() => Native.RightTextSet(txt, s));

        public static IntPtr IntersectionBigintSet(long i, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.IntersectionBigintSet(i, s));

        public static IntPtr IntersectionDateSet(int d, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.IntersectionDateSet(d, s));

        public static IntPtr IntersectionFloatSet(double d, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.IntersectionFloatSet(d, s));

        public static IntPtr IntersectionIntSet(int i, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.IntersectionIntSet(i, s));

        public static IntPtr IntersectionSetBigint(IntPtr s, long i)
            => SafeExecution<IntPtr>(() => Native.IntersectionSetBigint(s, i));

        public static IntPtr IntersectionSetDate(IntPtr s, int d)
            => SafeExecution<IntPtr>(() => Native.IntersectionSetDate(s, d));

        public static IntPtr IntersectionSetFloat(IntPtr s, double d)
            => SafeExecution<IntPtr>(() => Native.IntersectionSetFloat(s, d));

        public static IntPtr IntersectionSetInt(IntPtr s, int i)
            => SafeExecution<IntPtr>(() => Native.IntersectionSetInt(s, i));

        public static IntPtr IntersectionSetSet(IntPtr s1, IntPtr s2)
            => SafeExecution<IntPtr>(() => Native.IntersectionSetSet(s1, s2));

        public static IntPtr IntersectionSetText(IntPtr s, IntPtr txt)
            => SafeExecution<IntPtr>(() => Native.IntersectionSetText(s, txt));

        public static IntPtr IntersectionSetTimestamptz(IntPtr s, long t)
            => SafeExecution<IntPtr>(() => Native.IntersectionSetTimestamptz(s, t));

        public static IntPtr IntersectionSpanBigint(IntPtr s, long i)
            => SafeExecution<IntPtr>(() => Native.IntersectionSpanBigint(s, i));

        public static IntPtr IntersectionSpanDate(IntPtr s, int d)
            => SafeExecution<IntPtr>(() => Native.IntersectionSpanDate(s, d));

        public static IntPtr IntersectionSpanFloat(IntPtr s, double d)
            => SafeExecution<IntPtr>(() => Native.IntersectionSpanFloat(s, d));

        public static IntPtr IntersectionSpanInt(IntPtr s, int i)
            => SafeExecution<IntPtr>(() => Native.IntersectionSpanInt(s, i));

        public static IntPtr IntersectionSpanSpan(IntPtr s1, IntPtr s2)
            => SafeExecution<IntPtr>(() => Native.IntersectionSpanSpan(s1, s2));

        public static IntPtr IntersectionSpanSpanset(IntPtr s, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.IntersectionSpanSpanset(s, ss));

        public static IntPtr IntersectionSpanTimestamptz(IntPtr s, long t)
            => SafeExecution<IntPtr>(() => Native.IntersectionSpanTimestamptz(s, t));

        public static IntPtr IntersectionSpansetBigint(IntPtr ss, long i)
            => SafeExecution<IntPtr>(() => Native.IntersectionSpansetBigint(ss, i));

        public static IntPtr IntersectionSpansetDate(IntPtr ss, int d)
            => SafeExecution<IntPtr>(() => Native.IntersectionSpansetDate(ss, d));

        public static IntPtr IntersectionSpansetFloat(IntPtr ss, double d)
            => SafeExecution<IntPtr>(() => Native.IntersectionSpansetFloat(ss, d));

        public static IntPtr IntersectionSpansetInt(IntPtr ss, int i)
            => SafeExecution<IntPtr>(() => Native.IntersectionSpansetInt(ss, i));

        public static IntPtr IntersectionSpansetSpan(IntPtr ss, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.IntersectionSpansetSpan(ss, s));

        public static IntPtr IntersectionSpansetSpanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<IntPtr>(() => Native.IntersectionSpansetSpanset(ss1, ss2));

        public static IntPtr IntersectionSpansetTimestamptz(IntPtr ss, long t)
            => SafeExecution<IntPtr>(() => Native.IntersectionSpansetTimestamptz(ss, t));

        public static IntPtr IntersectionTextSet(IntPtr txt, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.IntersectionTextSet(txt, s));

        public static IntPtr IntersectionTimestamptzSet(long t, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.IntersectionTimestamptzSet(t, s));

        public static IntPtr MinusBigintSet(long i, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.MinusBigintSet(i, s));

        public static IntPtr MinusBigintSpan(long i, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.MinusBigintSpan(i, s));

        public static IntPtr MinusBigintSpanset(long i, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.MinusBigintSpanset(i, ss));

        public static IntPtr MinusDateSet(int d, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.MinusDateSet(d, s));

        public static IntPtr MinusDateSpan(int d, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.MinusDateSpan(d, s));

        public static IntPtr MinusDateSpanset(int d, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.MinusDateSpanset(d, ss));

        public static IntPtr MinusFloatSet(double d, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.MinusFloatSet(d, s));

        public static IntPtr MinusFloatSpan(double d, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.MinusFloatSpan(d, s));

        public static IntPtr MinusFloatSpanset(double d, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.MinusFloatSpanset(d, ss));

        public static IntPtr MinusIntSet(int i, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.MinusIntSet(i, s));

        public static IntPtr MinusIntSpan(int i, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.MinusIntSpan(i, s));

        public static IntPtr MinusIntSpanset(int i, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.MinusIntSpanset(i, ss));

        public static IntPtr MinusSetBigint(IntPtr s, long i)
            => SafeExecution<IntPtr>(() => Native.MinusSetBigint(s, i));

        public static IntPtr MinusSetDate(IntPtr s, int d)
            => SafeExecution<IntPtr>(() => Native.MinusSetDate(s, d));

        public static IntPtr MinusSetFloat(IntPtr s, double d)
            => SafeExecution<IntPtr>(() => Native.MinusSetFloat(s, d));

        public static IntPtr MinusSetInt(IntPtr s, int i)
            => SafeExecution<IntPtr>(() => Native.MinusSetInt(s, i));

        public static IntPtr MinusSetSet(IntPtr s1, IntPtr s2)
            => SafeExecution<IntPtr>(() => Native.MinusSetSet(s1, s2));

        public static IntPtr MinusSetText(IntPtr s, IntPtr txt)
            => SafeExecution<IntPtr>(() => Native.MinusSetText(s, txt));

        public static IntPtr MinusSetTimestamptz(IntPtr s, long t)
            => SafeExecution<IntPtr>(() => Native.MinusSetTimestamptz(s, t));

        public static IntPtr MinusSpanBigint(IntPtr s, long i)
            => SafeExecution<IntPtr>(() => Native.MinusSpanBigint(s, i));

        public static IntPtr MinusSpanDate(IntPtr s, int d)
            => SafeExecution<IntPtr>(() => Native.MinusSpanDate(s, d));

        public static IntPtr MinusSpanFloat(IntPtr s, double d)
            => SafeExecution<IntPtr>(() => Native.MinusSpanFloat(s, d));

        public static IntPtr MinusSpanInt(IntPtr s, int i)
            => SafeExecution<IntPtr>(() => Native.MinusSpanInt(s, i));

        public static IntPtr MinusSpanSpan(IntPtr s1, IntPtr s2)
            => SafeExecution<IntPtr>(() => Native.MinusSpanSpan(s1, s2));

        public static IntPtr MinusSpanSpanset(IntPtr s, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.MinusSpanSpanset(s, ss));

        public static IntPtr MinusSpanTimestamptz(IntPtr s, long t)
            => SafeExecution<IntPtr>(() => Native.MinusSpanTimestamptz(s, t));

        public static IntPtr MinusSpansetBigint(IntPtr ss, long i)
            => SafeExecution<IntPtr>(() => Native.MinusSpansetBigint(ss, i));

        public static IntPtr MinusSpansetDate(IntPtr ss, int d)
            => SafeExecution<IntPtr>(() => Native.MinusSpansetDate(ss, d));

        public static IntPtr MinusSpansetFloat(IntPtr ss, double d)
            => SafeExecution<IntPtr>(() => Native.MinusSpansetFloat(ss, d));

        public static IntPtr MinusSpansetInt(IntPtr ss, int i)
            => SafeExecution<IntPtr>(() => Native.MinusSpansetInt(ss, i));

        public static IntPtr MinusSpansetSpan(IntPtr ss, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.MinusSpansetSpan(ss, s));

        public static IntPtr MinusSpansetSpanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<IntPtr>(() => Native.MinusSpansetSpanset(ss1, ss2));

        public static IntPtr MinusSpansetTimestamptz(IntPtr ss, long t)
            => SafeExecution<IntPtr>(() => Native.MinusSpansetTimestamptz(ss, t));

        public static IntPtr MinusTextSet(IntPtr txt, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.MinusTextSet(txt, s));

        public static IntPtr MinusTimestamptzSet(long t, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.MinusTimestamptzSet(t, s));

        public static IntPtr MinusTimestamptzSpan(long t, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.MinusTimestamptzSpan(t, s));

        public static IntPtr MinusTimestamptzSpanset(long t, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.MinusTimestamptzSpanset(t, ss));

        public static IntPtr UnionBigintSet(long i, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.UnionBigintSet(i, s));

        public static IntPtr UnionBigintSpan(long i, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.UnionBigintSpan(i, s));

        public static IntPtr UnionBigintSpanset(long i, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.UnionBigintSpanset(i, ss));

        public static IntPtr UnionDateSet(int d, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.UnionDateSet(d, s));

        public static IntPtr UnionDateSpan(int d, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.UnionDateSpan(d, s));

        public static IntPtr UnionDateSpanset(int d, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.UnionDateSpanset(d, ss));

        public static IntPtr UnionFloatSet(double d, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.UnionFloatSet(d, s));

        public static IntPtr UnionFloatSpan(double d, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.UnionFloatSpan(d, s));

        public static IntPtr UnionFloatSpanset(double d, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.UnionFloatSpanset(d, ss));

        public static IntPtr UnionIntSet(int i, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.UnionIntSet(i, s));

        public static IntPtr UnionIntSpan(int i, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.UnionIntSpan(i, s));

        public static IntPtr UnionIntSpanset(int i, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.UnionIntSpanset(i, ss));

        public static IntPtr UnionSetBigint(IntPtr s, long i)
            => SafeExecution<IntPtr>(() => Native.UnionSetBigint(s, i));

        public static IntPtr UnionSetDate(IntPtr s, int d)
            => SafeExecution<IntPtr>(() => Native.UnionSetDate(s, d));

        public static IntPtr UnionSetFloat(IntPtr s, double d)
            => SafeExecution<IntPtr>(() => Native.UnionSetFloat(s, d));

        public static IntPtr UnionSetInt(IntPtr s, int i)
            => SafeExecution<IntPtr>(() => Native.UnionSetInt(s, i));

        public static IntPtr UnionSetSet(IntPtr s1, IntPtr s2)
            => SafeExecution<IntPtr>(() => Native.UnionSetSet(s1, s2));

        public static IntPtr UnionSetText(IntPtr s, IntPtr txt)
            => SafeExecution<IntPtr>(() => Native.UnionSetText(s, txt));

        public static IntPtr UnionSetTimestamptz(IntPtr s, long t)
            => SafeExecution<IntPtr>(() => Native.UnionSetTimestamptz(s, t));

        public static IntPtr UnionSpanBigint(IntPtr s, long i)
            => SafeExecution<IntPtr>(() => Native.UnionSpanBigint(s, i));

        public static IntPtr UnionSpanDate(IntPtr s, int d)
            => SafeExecution<IntPtr>(() => Native.UnionSpanDate(s, d));

        public static IntPtr UnionSpanFloat(IntPtr s, double d)
            => SafeExecution<IntPtr>(() => Native.UnionSpanFloat(s, d));

        public static IntPtr UnionSpanInt(IntPtr s, int i)
            => SafeExecution<IntPtr>(() => Native.UnionSpanInt(s, i));

        public static IntPtr UnionSpanSpan(IntPtr s1, IntPtr s2)
            => SafeExecution<IntPtr>(() => Native.UnionSpanSpan(s1, s2));

        public static IntPtr UnionSpanSpanset(IntPtr s, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.UnionSpanSpanset(s, ss));

        public static IntPtr UnionSpanTimestamptz(IntPtr s, long t)
            => SafeExecution<IntPtr>(() => Native.UnionSpanTimestamptz(s, t));

        public static IntPtr UnionSpansetBigint(IntPtr ss, long i)
            => SafeExecution<IntPtr>(() => Native.UnionSpansetBigint(ss, i));

        public static IntPtr UnionSpansetDate(IntPtr ss, int d)
            => SafeExecution<IntPtr>(() => Native.UnionSpansetDate(ss, d));

        public static IntPtr UnionSpansetFloat(IntPtr ss, double d)
            => SafeExecution<IntPtr>(() => Native.UnionSpansetFloat(ss, d));

        public static IntPtr UnionSpansetInt(IntPtr ss, int i)
            => SafeExecution<IntPtr>(() => Native.UnionSpansetInt(ss, i));

        public static IntPtr UnionSpansetSpan(IntPtr ss, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.UnionSpansetSpan(ss, s));

        public static IntPtr UnionSpansetSpanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<IntPtr>(() => Native.UnionSpansetSpanset(ss1, ss2));

        public static IntPtr UnionSpansetTimestamptz(IntPtr ss, long t)
            => SafeExecution<IntPtr>(() => Native.UnionSpansetTimestamptz(ss, t));

        public static IntPtr UnionTextSet(IntPtr txt, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.UnionTextSet(txt, s));

        public static IntPtr UnionTimestamptzSet(long t, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.UnionTimestamptzSet(t, s));

        public static IntPtr UnionTimestamptzSpan(long t, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.UnionTimestamptzSpan(t, s));

        public static IntPtr UnionTimestamptzSpanset(long t, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.UnionTimestamptzSpanset(t, ss));

        public static long DistanceBigintsetBigintset(IntPtr s1, IntPtr s2)
            => SafeExecution<long>(() => Native.DistanceBigintsetBigintset(s1, s2));

        public static long DistanceBigintspanBigintspan(IntPtr s1, IntPtr s2)
            => SafeExecution<long>(() => Native.DistanceBigintspanBigintspan(s1, s2));

        public static long DistanceBigintspansetBigintspan(IntPtr ss, IntPtr s)
            => SafeExecution<long>(() => Native.DistanceBigintspansetBigintspan(ss, s));

        public static long DistanceBigintspansetBigintspanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<long>(() => Native.DistanceBigintspansetBigintspanset(ss1, ss2));

        public static int DistanceDatesetDateset(IntPtr s1, IntPtr s2)
            => SafeExecution<int>(() => Native.DistanceDatesetDateset(s1, s2));

        public static int DistanceDatespanDatespan(IntPtr s1, IntPtr s2)
            => SafeExecution<int>(() => Native.DistanceDatespanDatespan(s1, s2));

        public static int DistanceDatespansetDatespan(IntPtr ss, IntPtr s)
            => SafeExecution<int>(() => Native.DistanceDatespansetDatespan(ss, s));

        public static int DistanceDatespansetDatespanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<int>(() => Native.DistanceDatespansetDatespanset(ss1, ss2));

        public static double DistanceFloatsetFloatset(IntPtr s1, IntPtr s2)
            => SafeExecution<double>(() => Native.DistanceFloatsetFloatset(s1, s2));

        public static double DistanceFloatspanFloatspan(IntPtr s1, IntPtr s2)
            => SafeExecution<double>(() => Native.DistanceFloatspanFloatspan(s1, s2));

        public static double DistanceFloatspansetFloatspan(IntPtr ss, IntPtr s)
            => SafeExecution<double>(() => Native.DistanceFloatspansetFloatspan(ss, s));

        public static double DistanceFloatspansetFloatspanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<double>(() => Native.DistanceFloatspansetFloatspanset(ss1, ss2));

        public static int DistanceIntsetIntset(IntPtr s1, IntPtr s2)
            => SafeExecution<int>(() => Native.DistanceIntsetIntset(s1, s2));

        public static int DistanceIntspanIntspan(IntPtr s1, IntPtr s2)
            => SafeExecution<int>(() => Native.DistanceIntspanIntspan(s1, s2));

        public static int DistanceIntspansetIntspan(IntPtr ss, IntPtr s)
            => SafeExecution<int>(() => Native.DistanceIntspansetIntspan(ss, s));

        public static int DistanceIntspansetIntspanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<int>(() => Native.DistanceIntspansetIntspanset(ss1, ss2));

        public static long DistanceSetBigint(IntPtr s, long i)
            => SafeExecution<long>(() => Native.DistanceSetBigint(s, i));

        public static int DistanceSetDate(IntPtr s, int d)
            => SafeExecution<int>(() => Native.DistanceSetDate(s, d));

        public static double DistanceSetFloat(IntPtr s, double d)
            => SafeExecution<double>(() => Native.DistanceSetFloat(s, d));

        public static int DistanceSetInt(IntPtr s, int i)
            => SafeExecution<int>(() => Native.DistanceSetInt(s, i));

        public static double DistanceSetTimestamptz(IntPtr s, long t)
            => SafeExecution<double>(() => Native.DistanceSetTimestamptz(s, t));

        public static long DistanceSpanBigint(IntPtr s, long i)
            => SafeExecution<long>(() => Native.DistanceSpanBigint(s, i));

        public static int DistanceSpanDate(IntPtr s, int d)
            => SafeExecution<int>(() => Native.DistanceSpanDate(s, d));

        public static double DistanceSpanFloat(IntPtr s, double d)
            => SafeExecution<double>(() => Native.DistanceSpanFloat(s, d));

        public static int DistanceSpanInt(IntPtr s, int i)
            => SafeExecution<int>(() => Native.DistanceSpanInt(s, i));

        public static double DistanceSpanTimestamptz(IntPtr s, long t)
            => SafeExecution<double>(() => Native.DistanceSpanTimestamptz(s, t));

        public static long DistanceSpansetBigint(IntPtr ss, long i)
            => SafeExecution<long>(() => Native.DistanceSpansetBigint(ss, i));

        public static int DistanceSpansetDate(IntPtr ss, int d)
            => SafeExecution<int>(() => Native.DistanceSpansetDate(ss, d));

        public static double DistanceSpansetFloat(IntPtr ss, double d)
            => SafeExecution<double>(() => Native.DistanceSpansetFloat(ss, d));

        public static int DistanceSpansetInt(IntPtr ss, int i)
            => SafeExecution<int>(() => Native.DistanceSpansetInt(ss, i));

        public static double DistanceSpansetTimestamptz(IntPtr ss, long t)
            => SafeExecution<double>(() => Native.DistanceSpansetTimestamptz(ss, t));

        public static double DistanceTstzsetTstzset(IntPtr s1, IntPtr s2)
            => SafeExecution<double>(() => Native.DistanceTstzsetTstzset(s1, s2));

        public static double DistanceTstzspanTstzspan(IntPtr s1, IntPtr s2)
            => SafeExecution<double>(() => Native.DistanceTstzspanTstzspan(s1, s2));

        public static double DistanceTstzspansetTstzspan(IntPtr ss, IntPtr s)
            => SafeExecution<double>(() => Native.DistanceTstzspansetTstzspan(ss, s));

        public static double DistanceTstzspansetTstzspanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<double>(() => Native.DistanceTstzspansetTstzspanset(ss1, ss2));

        public static IntPtr BigintExtentTransfn(IntPtr state, long i)
            => SafeExecution<IntPtr>(() => Native.BigintExtentTransfn(state, i));

        public static IntPtr BigintUnionTransfn(IntPtr state, long i)
            => SafeExecution<IntPtr>(() => Native.BigintUnionTransfn(state, i));

        public static IntPtr DateExtentTransfn(IntPtr state, int d)
            => SafeExecution<IntPtr>(() => Native.DateExtentTransfn(state, d));

        public static IntPtr DateUnionTransfn(IntPtr state, int d)
            => SafeExecution<IntPtr>(() => Native.DateUnionTransfn(state, d));

        public static IntPtr FloatExtentTransfn(IntPtr state, double d)
            => SafeExecution<IntPtr>(() => Native.FloatExtentTransfn(state, d));

        public static IntPtr FloatUnionTransfn(IntPtr state, double d)
            => SafeExecution<IntPtr>(() => Native.FloatUnionTransfn(state, d));

        public static IntPtr IntExtentTransfn(IntPtr state, int i)
            => SafeExecution<IntPtr>(() => Native.IntExtentTransfn(state, i));

        public static IntPtr IntUnionTransfn(IntPtr state, int i)
            => SafeExecution<IntPtr>(() => Native.IntUnionTransfn(state, i));

        public static IntPtr SetExtentTransfn(IntPtr state, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.SetExtentTransfn(state, s));

        public static IntPtr SetUnionFinalfn(IntPtr state)
            => SafeExecution<IntPtr>(() => Native.SetUnionFinalfn(state));

        public static IntPtr SetUnionTransfn(IntPtr state, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.SetUnionTransfn(state, s));

        public static IntPtr SpanExtentTransfn(IntPtr state, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.SpanExtentTransfn(state, s));

        public static IntPtr SpanUnionTransfn(IntPtr state, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.SpanUnionTransfn(state, s));

        public static IntPtr SpansetExtentTransfn(IntPtr state, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.SpansetExtentTransfn(state, ss));

        public static IntPtr SpansetUnionFinalfn(IntPtr state)
            => SafeExecution<IntPtr>(() => Native.SpansetUnionFinalfn(state));

        public static IntPtr SpansetUnionTransfn(IntPtr state, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.SpansetUnionTransfn(state, ss));

        public static IntPtr TextUnionTransfn(IntPtr state, IntPtr txt)
            => SafeExecution<IntPtr>(() => Native.TextUnionTransfn(state, txt));

        public static IntPtr TimestamptzExtentTransfn(IntPtr state, long t)
            => SafeExecution<IntPtr>(() => Native.TimestamptzExtentTransfn(state, t));

        public static IntPtr TimestamptzUnionTransfn(IntPtr state, long t)
            => SafeExecution<IntPtr>(() => Native.TimestamptzUnionTransfn(state, t));

        public static long BigintGetBin(long value, long vsize, long vorigin)
            => SafeExecution<long>(() => Native.BigintGetBin(value, vsize, vorigin));

        public static IntPtr[] BigintspanBins(IntPtr s, long vsize, long vorigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.BigintspanBins(s, vsize, vorigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 24); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] BigintspansetBins(IntPtr ss, long vsize, long vorigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.BigintspansetBins(ss, vsize, vorigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 24); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int DateGetBin(int d, IntPtr duration, int torigin)
            => SafeExecution<int>(() => Native.DateGetBin(d, duration, torigin));

        public static IntPtr[] DatespanBins(IntPtr s, IntPtr duration, int torigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.DatespanBins(s, duration, torigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 24); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] DatespansetBins(IntPtr ss, IntPtr duration, int torigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.DatespansetBins(ss, duration, torigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 24); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static double FloatGetBin(double value, double vsize, double vorigin)
            => SafeExecution<double>(() => Native.FloatGetBin(value, vsize, vorigin));

        public static IntPtr[] FloatspanBins(IntPtr s, double vsize, double vorigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.FloatspanBins(s, vsize, vorigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 24); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] FloatspansetBins(IntPtr ss, double vsize, double vorigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.FloatspansetBins(ss, vsize, vorigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 24); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int IntGetBin(int value, int vsize, int vorigin)
            => SafeExecution<int>(() => Native.IntGetBin(value, vsize, vorigin));

        public static IntPtr[] IntspanBins(IntPtr s, int vsize, int vorigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.IntspanBins(s, vsize, vorigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 24); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] IntspansetBins(IntPtr ss, int vsize, int vorigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.IntspansetBins(ss, vsize, vorigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 24); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static long TimestamptzGetBin(long t, IntPtr duration, long torigin)
            => SafeExecution<long>(() => Native.TimestamptzGetBin(t, duration, torigin));

        public static IntPtr[] TstzspanBins(IntPtr s, IntPtr duration, long origin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TstzspanBins(s, duration, origin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 24); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TstzspansetBins(IntPtr ss, IntPtr duration, long torigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TstzspansetBins(ss, duration, torigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 24); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static string TboxAsHexwkb(IntPtr box, byte variant, IntPtr size_out)
            => SafeExecution<string>(() => Native.TboxAsHexwkb(box, variant, size_out));

        public static IntPtr TboxAsWkb(IntPtr box, byte variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => Native.TboxAsWkb(box, variant, size_out));

        public static IntPtr TboxFromHexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => Native.TboxFromHexwkb(hexwkb));

        public static IntPtr TboxFromWkb(IntPtr wkb, ulong size)
            => SafeExecution<IntPtr>(() => Native.TboxFromWkb(wkb, size));

        public static IntPtr TboxIn(string str)
            => SafeExecution<IntPtr>(() => Native.TboxIn(str));

        public static string TboxOut(IntPtr box, int maxdd)
            => SafeExecution<string>(() => Native.TboxOut(box, maxdd));

        public static IntPtr FloatTimestamptzToTbox(double d, long t)
            => SafeExecution<IntPtr>(() => Native.FloatTimestamptzToTbox(d, t));

        public static IntPtr FloatTstzspanToTbox(double d, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.FloatTstzspanToTbox(d, s));

        public static IntPtr IntTimestamptzToTbox(int i, long t)
            => SafeExecution<IntPtr>(() => Native.IntTimestamptzToTbox(i, t));

        public static IntPtr BigintTimestamptzToTbox(long i, long t)
            => SafeExecution<IntPtr>(() => Native.BigintTimestamptzToTbox(i, t));

        public static IntPtr IntTstzspanToTbox(int i, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.IntTstzspanToTbox(i, s));

        public static IntPtr BigintTstzspanToTbox(long i, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.BigintTstzspanToTbox(i, s));

        public static IntPtr NumspanTstzspanToTbox(IntPtr span, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.NumspanTstzspanToTbox(span, s));

        public static IntPtr NumspanTimestamptzToTbox(IntPtr span, long t)
            => SafeExecution<IntPtr>(() => Native.NumspanTimestamptzToTbox(span, t));

        public static IntPtr TboxCopy(IntPtr box)
            => SafeExecution<IntPtr>(() => Native.TboxCopy(box));

        public static IntPtr TboxMake(IntPtr s, IntPtr p)
            => SafeExecution<IntPtr>(() => Native.TboxMake(s, p));

        public static IntPtr FloatToTbox(double d)
            => SafeExecution<IntPtr>(() => Native.FloatToTbox(d));

        public static IntPtr IntToTbox(int i)
            => SafeExecution<IntPtr>(() => Native.IntToTbox(i));

        public static IntPtr BigintToTbox(long i)
            => SafeExecution<IntPtr>(() => Native.BigintToTbox(i));

        public static IntPtr SetToTbox(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.SetToTbox(s));

        public static IntPtr SpanToTbox(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.SpanToTbox(s));

        public static IntPtr SpansetToTbox(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.SpansetToTbox(ss));

        public static IntPtr TboxToIntspan(IntPtr box)
            => SafeExecution<IntPtr>(() => Native.TboxToIntspan(box));

        public static IntPtr TboxToBigintspan(IntPtr box)
            => SafeExecution<IntPtr>(() => Native.TboxToBigintspan(box));

        public static IntPtr TboxToFloatspan(IntPtr box)
            => SafeExecution<IntPtr>(() => Native.TboxToFloatspan(box));

        public static IntPtr TboxToTstzspan(IntPtr box)
            => SafeExecution<IntPtr>(() => Native.TboxToTstzspan(box));

        public static IntPtr TimestamptzToTbox(long t)
            => SafeExecution<IntPtr>(() => Native.TimestamptzToTbox(t));

        public static uint TboxHash(IntPtr box)
            => SafeExecution<uint>(() => Native.TboxHash(box));

        public static ulong TboxHashExtended(IntPtr box, ulong seed)
            => SafeExecution<ulong>(() => Native.TboxHashExtended(box, seed));

        public static bool TboxHast(IntPtr box)
            => SafeExecution<bool>(() => Native.TboxHast(box));

        public static bool TboxHasx(IntPtr box)
            => SafeExecution<bool>(() => Native.TboxHasx(box));

        public static bool TboxTmax(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.TboxTmax(box, result));

        public static bool TboxTmaxInc(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.TboxTmaxInc(box, result));

        public static bool TboxTmin(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.TboxTmin(box, result));

        public static bool TboxTminInc(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.TboxTminInc(box, result));

        public static bool TboxXmax(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.TboxXmax(box, result));

        public static bool TboxXmaxInc(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.TboxXmaxInc(box, result));

        public static bool TboxXmin(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.TboxXmin(box, result));

        public static bool TboxXminInc(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.TboxXminInc(box, result));

        public static bool TboxfloatXmax(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.TboxfloatXmax(box, result));

        public static bool TboxfloatXmin(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.TboxfloatXmin(box, result));

        public static bool TboxintXmax(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.TboxintXmax(box, result));

        public static bool TboxbigintXmax(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.TboxbigintXmax(box, result));

        public static bool TboxintXmin(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.TboxintXmin(box, result));

        public static bool TboxbigintXmin(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.TboxbigintXmin(box, result));

        public static IntPtr TfloatboxExpand(IntPtr box, double d)
            => SafeExecution<IntPtr>(() => Native.TfloatboxExpand(box, d));

        public static IntPtr TintboxExpand(IntPtr box, int i)
            => SafeExecution<IntPtr>(() => Native.TintboxExpand(box, i));

        public static IntPtr TboxExpandTime(IntPtr box, IntPtr interv)
            => SafeExecution<IntPtr>(() => Native.TboxExpandTime(box, interv));

        public static IntPtr TboxRound(IntPtr box, int maxdd)
            => SafeExecution<IntPtr>(() => Native.TboxRound(box, maxdd));

        public static IntPtr TfloatboxShiftScale(IntPtr box, double shift, double width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => Native.TfloatboxShiftScale(box, shift, width, hasshift, haswidth));

        public static IntPtr TintboxShiftScale(IntPtr box, int shift, int width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => Native.TintboxShiftScale(box, shift, width, hasshift, haswidth));

        public static IntPtr TboxShiftScaleTime(IntPtr box, IntPtr shift, IntPtr duration)
            => SafeExecution<IntPtr>(() => Native.TboxShiftScaleTime(box, shift, duration));

        public static IntPtr TbigintboxExpand(IntPtr box, long i)
            => SafeExecution<IntPtr>(() => Native.TbigintboxExpand(box, i));

        public static IntPtr TbigintboxShiftScale(IntPtr box, long shift, long width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => Native.TbigintboxShiftScale(box, shift, width, hasshift, haswidth));

        public static IntPtr UnionTboxTbox(IntPtr box1, IntPtr box2, bool strict)
            => SafeExecution<IntPtr>(() => Native.UnionTboxTbox(box1, box2, strict));

        public static IntPtr IntersectionTboxTbox(IntPtr box1, IntPtr box2)
            => SafeExecution<IntPtr>(() => Native.IntersectionTboxTbox(box1, box2));

        public static bool AdjacentTboxTbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.AdjacentTboxTbox(box1, box2));

        public static bool ContainedTboxTbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.ContainedTboxTbox(box1, box2));

        public static bool ContainsTboxTbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.ContainsTboxTbox(box1, box2));

        public static bool OverlapsTboxTbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.OverlapsTboxTbox(box1, box2));

        public static bool SameTboxTbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.SameTboxTbox(box1, box2));

        public static bool AfterTboxTbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.AfterTboxTbox(box1, box2));

        public static bool BeforeTboxTbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.BeforeTboxTbox(box1, box2));

        public static bool LeftTboxTbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.LeftTboxTbox(box1, box2));

        public static bool OverafterTboxTbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.OverafterTboxTbox(box1, box2));

        public static bool OverbeforeTboxTbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.OverbeforeTboxTbox(box1, box2));

        public static bool OverleftTboxTbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.OverleftTboxTbox(box1, box2));

        public static bool OverrightTboxTbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.OverrightTboxTbox(box1, box2));

        public static bool RightTboxTbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.RightTboxTbox(box1, box2));

        public static int TboxCmp(IntPtr box1, IntPtr box2)
            => SafeExecution<int>(() => Native.TboxCmp(box1, box2));

        public static bool TboxEq(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.TboxEq(box1, box2));

        public static bool TboxGe(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.TboxGe(box1, box2));

        public static bool TboxGt(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.TboxGt(box1, box2));

        public static bool TboxLe(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.TboxLe(box1, box2));

        public static bool TboxLt(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.TboxLt(box1, box2));

        public static bool TboxNe(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.TboxNe(box1, box2));

        public static IntPtr TboolFromMfjson(string str)
            => SafeExecution<IntPtr>(() => Native.TboolFromMfjson(str));

        public static IntPtr TboolIn(string str)
            => SafeExecution<IntPtr>(() => Native.TboolIn(str));

        public static string TboolOut(IntPtr temp)
            => SafeExecution<string>(() => Native.TboolOut(temp));

        public static string TemporalAsHexwkb(IntPtr temp, byte variant, IntPtr size_out)
            => SafeExecution<string>(() => Native.TemporalAsHexwkb(temp, variant, size_out));

        public static string TemporalAsMfjson(IntPtr temp, bool with_bbox, int flags, int precision, string srs)
            => SafeExecution<string>(() => Native.TemporalAsMfjson(temp, with_bbox, flags, precision, srs));

        public static IntPtr TemporalAsWkb(IntPtr temp, byte variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => Native.TemporalAsWkb(temp, variant, size_out));

        public static byte WkbVariantFromEndian(string endian)
            => SafeExecution<byte>(() => Native.WkbVariantFromEndian(endian));

        public static IntPtr TemporalFromHexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => Native.TemporalFromHexwkb(hexwkb));

        public static IntPtr TemporalFromWkb(IntPtr wkb, ulong size)
            => SafeExecution<IntPtr>(() => Native.TemporalFromWkb(wkb, size));

        public static IntPtr TfloatFromMfjson(string str)
            => SafeExecution<IntPtr>(() => Native.TfloatFromMfjson(str));

        public static IntPtr TfloatIn(string str)
            => SafeExecution<IntPtr>(() => Native.TfloatIn(str));

        public static string TfloatOut(IntPtr temp, int maxdd)
            => SafeExecution<string>(() => Native.TfloatOut(temp, maxdd));

        public static IntPtr TintFromMfjson(string str)
            => SafeExecution<IntPtr>(() => Native.TintFromMfjson(str));

        public static IntPtr TbigintFromMfjson(string str)
            => SafeExecution<IntPtr>(() => Native.TbigintFromMfjson(str));

        public static IntPtr TintIn(string str)
            => SafeExecution<IntPtr>(() => Native.TintIn(str));

        public static IntPtr TbigintIn(string str)
            => SafeExecution<IntPtr>(() => Native.TbigintIn(str));

        public static string TintOut(IntPtr temp)
            => SafeExecution<string>(() => Native.TintOut(temp));

        public static string TbigintOut(IntPtr temp)
            => SafeExecution<string>(() => Native.TbigintOut(temp));

        public static IntPtr TtextFromMfjson(string str)
            => SafeExecution<IntPtr>(() => Native.TtextFromMfjson(str));

        public static IntPtr TtextIn(string str)
            => SafeExecution<IntPtr>(() => Native.TtextIn(str));

        public static string TtextOut(IntPtr temp)
            => SafeExecution<string>(() => Native.TtextOut(temp));

        public static IntPtr TboolFromBaseTemp(bool b, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TboolFromBaseTemp(b, temp));

        public static IntPtr TboolinstMake(bool b, long t)
            => SafeExecution<IntPtr>(() => Native.TboolinstMake(b, t));

        public static IntPtr TboolseqFromBaseTstzset(bool b, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TboolseqFromBaseTstzset(b, s));

        public static IntPtr TboolseqFromBaseTstzspan(bool b, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TboolseqFromBaseTstzspan(b, s));

        public static IntPtr TboolseqsetFromBaseTstzspanset(bool b, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TboolseqsetFromBaseTstzspanset(b, ss));

        public static IntPtr TemporalCopy(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TemporalCopy(temp));

        public static IntPtr TfloatFromBaseTemp(double d, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TfloatFromBaseTemp(d, temp));

        public static IntPtr TfloatinstMake(double d, long t)
            => SafeExecution<IntPtr>(() => Native.TfloatinstMake(d, t));

        public static IntPtr TfloatseqFromBaseTstzset(double d, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TfloatseqFromBaseTstzset(d, s));

        public static IntPtr TfloatseqFromBaseTstzspan(double d, IntPtr s, int interp)
            => SafeExecution<IntPtr>(() => Native.TfloatseqFromBaseTstzspan(d, s, interp));

        public static IntPtr TfloatseqsetFromBaseTstzspanset(double d, IntPtr ss, int interp)
            => SafeExecution<IntPtr>(() => Native.TfloatseqsetFromBaseTstzspanset(d, ss, interp));

        public static IntPtr TintFromBaseTemp(int i, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TintFromBaseTemp(i, temp));

        public static IntPtr TbigintFromBaseTemp(long i, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TbigintFromBaseTemp(i, temp));

        public static IntPtr TintinstMake(int i, long t)
            => SafeExecution<IntPtr>(() => Native.TintinstMake(i, t));

        public static IntPtr TbigintinstMake(long i, long t)
            => SafeExecution<IntPtr>(() => Native.TbigintinstMake(i, t));

        public static IntPtr TintseqFromBaseTstzset(int i, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TintseqFromBaseTstzset(i, s));

        public static IntPtr TbigintseqFromBaseTstzset(long i, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TbigintseqFromBaseTstzset(i, s));

        public static IntPtr TintseqFromBaseTstzspan(int i, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TintseqFromBaseTstzspan(i, s));

        public static IntPtr TbigintseqFromBaseTstzspan(long i, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TbigintseqFromBaseTstzspan(i, s));

        public static IntPtr TintseqsetFromBaseTstzspanset(int i, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TintseqsetFromBaseTstzspanset(i, ss));

        public static IntPtr TbigintseqsetFromBaseTstzspanset(long i, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TbigintseqsetFromBaseTstzspanset(i, ss));

        public static IntPtr TsequenceMake(IntPtr instants, int count, bool lower_inc, bool upper_inc, int interp, bool normalize)
            => SafeExecution<IntPtr>(() => Native.TsequenceMake(instants, count, lower_inc, upper_inc, interp, normalize));

        public static IntPtr TsequencesetMake(IntPtr sequences, int count, bool normalize)
            => SafeExecution<IntPtr>(() => Native.TsequencesetMake(sequences, count, normalize));

        public static IntPtr TsequencesetMakeGaps(IntPtr instants, int count, int interp, IntPtr maxt, double maxdist)
            => SafeExecution<IntPtr>(() => Native.TsequencesetMakeGaps(instants, count, interp, maxt, maxdist));

        public static IntPtr TtextFromBaseTemp(IntPtr txt, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TtextFromBaseTemp(txt, temp));

        public static IntPtr TtextinstMake(IntPtr txt, long t)
            => SafeExecution<IntPtr>(() => Native.TtextinstMake(txt, t));

        public static IntPtr TtextseqFromBaseTstzset(IntPtr txt, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TtextseqFromBaseTstzset(txt, s));

        public static IntPtr TtextseqFromBaseTstzspan(IntPtr txt, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TtextseqFromBaseTstzspan(txt, s));

        public static IntPtr TtextseqsetFromBaseTstzspanset(IntPtr txt, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TtextseqsetFromBaseTstzspanset(txt, ss));

        public static IntPtr TboolToTint(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TboolToTint(temp));

        public static IntPtr TemporalToTstzspan(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TemporalToTstzspan(temp));

        public static IntPtr TfloatToTint(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TfloatToTint(temp));

        public static IntPtr TfloatToTbigint(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TfloatToTbigint(temp));

        public static IntPtr TintToTfloat(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TintToTfloat(temp));

        public static IntPtr TintToTbigint(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TintToTbigint(temp));

        public static IntPtr TbigintToTint(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TbigintToTint(temp));

        public static IntPtr TbigintToTfloat(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TbigintToTfloat(temp));

        public static IntPtr TnumberToSpan(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TnumberToSpan(temp));

        public static IntPtr TnumberToTbox(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TnumberToTbox(temp));

        public static bool TboolEndValue(IntPtr temp)
            => SafeExecution<bool>(() => Native.TboolEndValue(temp));

        public static bool TboolStartValue(IntPtr temp)
            => SafeExecution<bool>(() => Native.TboolStartValue(temp));

        public static bool TboolValueAtTimestamptz(IntPtr temp, long t, bool strict, IntPtr value)
            => SafeExecution<bool>(() => Native.TboolValueAtTimestamptz(temp, t, strict, value));

        public static bool TboolValueN(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.TboolValueN(temp, n, result));

        public static bool[] TboolValues(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TboolValues(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                bool[] _out = new bool[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadByte(_p, _i) != 0; }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr TemporalDuration(IntPtr temp, bool boundspan)
            => SafeExecution<IntPtr>(() => Native.TemporalDuration(temp, boundspan));

        public static IntPtr TemporalEndInstant(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TemporalEndInstant(temp));

        public static IntPtr TemporalEndSequence(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TemporalEndSequence(temp));

        public static long TemporalEndTimestamptz(IntPtr temp)
            => SafeExecution<long>(() => Native.TemporalEndTimestamptz(temp));

        public static uint TemporalHash(IntPtr temp)
            => SafeExecution<uint>(() => Native.TemporalHash(temp));

        public static ulong TemporalHashExtended(IntPtr temp, ulong seed)
            => SafeExecution<ulong>(() => Native.TemporalHashExtended(temp, seed));

        public static IntPtr TemporalInstantN(IntPtr temp, int n)
            => SafeExecution<IntPtr>(() => Native.TemporalInstantN(temp, n));

        public static IntPtr[] TemporalInstants(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TemporalInstants(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static string? TemporalInterp(IntPtr temp)
            => Marshal.PtrToStringUTF8(SafeExecution<IntPtr>(() => Native.TemporalInterp(temp)));

        public static bool TemporalLowerInc(IntPtr temp)
            => SafeExecution<bool>(() => Native.TemporalLowerInc(temp));

        public static IntPtr TemporalMaxInstant(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TemporalMaxInstant(temp));

        public static IntPtr TemporalMinInstant(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TemporalMinInstant(temp));

        public static int TemporalNumInstants(IntPtr temp)
            => SafeExecution<int>(() => Native.TemporalNumInstants(temp));

        public static int TemporalNumSequences(IntPtr temp)
            => SafeExecution<int>(() => Native.TemporalNumSequences(temp));

        public static int TemporalNumTimestamps(IntPtr temp)
            => SafeExecution<int>(() => Native.TemporalNumTimestamps(temp));

        public static IntPtr TemporalSegmDuration(IntPtr temp, IntPtr duration, bool atleast, bool strict)
            => SafeExecution<IntPtr>(() => Native.TemporalSegmDuration(temp, duration, atleast, strict));

        public static IntPtr[] TemporalSegments(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TemporalSegments(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr TemporalSequenceN(IntPtr temp, int i)
            => SafeExecution<IntPtr>(() => Native.TemporalSequenceN(temp, i));

        public static IntPtr[] TemporalSequences(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TemporalSequences(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr TemporalStartInstant(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TemporalStartInstant(temp));

        public static IntPtr TemporalStartSequence(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TemporalStartSequence(temp));

        public static long TemporalStartTimestamptz(IntPtr temp)
            => SafeExecution<long>(() => Native.TemporalStartTimestamptz(temp));

        public static IntPtr TemporalStops(IntPtr temp, double maxdist, IntPtr minduration)
            => SafeExecution<IntPtr>(() => Native.TemporalStops(temp, maxdist, minduration));

        public static string? TemporalSubtype(IntPtr temp)
            => Marshal.PtrToStringUTF8(SafeExecution<IntPtr>(() => Native.TemporalSubtype(temp)));

        public static string? TemporalBasetypeName(IntPtr temp)
            => Marshal.PtrToStringUTF8(SafeExecution<IntPtr>(() => Native.TemporalBasetypeName(temp)));

        public static IntPtr TemporalTime(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TemporalTime(temp));

        public static long[] TemporalTimestamps(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TemporalTimestamps(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                long[] _out = new long[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool TemporalTimestamptzN(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.TemporalTimestamptzN(temp, n, result));

        public static bool TemporalUpperInc(IntPtr temp)
            => SafeExecution<bool>(() => Native.TemporalUpperInc(temp));

        public static double TfloatEndValue(IntPtr temp)
            => SafeExecution<double>(() => Native.TfloatEndValue(temp));

        public static double TfloatMinValue(IntPtr temp)
            => SafeExecution<double>(() => Native.TfloatMinValue(temp));

        public static double TfloatMaxValue(IntPtr temp)
            => SafeExecution<double>(() => Native.TfloatMaxValue(temp));

        public static double TfloatStartValue(IntPtr temp)
            => SafeExecution<double>(() => Native.TfloatStartValue(temp));

        public static bool TfloatValueAtTimestamptz(IntPtr temp, long t, bool strict, IntPtr value)
            => SafeExecution<bool>(() => Native.TfloatValueAtTimestamptz(temp, t, strict, value));

        public static bool TfloatValueN(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.TfloatValueN(temp, n, result));

        public static double[] TfloatValues(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TfloatValues(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                double[] _out = new double[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int TintEndValue(IntPtr temp)
            => SafeExecution<int>(() => Native.TintEndValue(temp));

        public static long TbigintEndValue(IntPtr temp)
            => SafeExecution<long>(() => Native.TbigintEndValue(temp));

        public static int TintMaxValue(IntPtr temp)
            => SafeExecution<int>(() => Native.TintMaxValue(temp));

        public static long TbigintMaxValue(IntPtr temp)
            => SafeExecution<long>(() => Native.TbigintMaxValue(temp));

        public static int TintMinValue(IntPtr temp)
            => SafeExecution<int>(() => Native.TintMinValue(temp));

        public static long TbigintMinValue(IntPtr temp)
            => SafeExecution<long>(() => Native.TbigintMinValue(temp));

        public static int TintStartValue(IntPtr temp)
            => SafeExecution<int>(() => Native.TintStartValue(temp));

        public static long TbigintStartValue(IntPtr temp)
            => SafeExecution<long>(() => Native.TbigintStartValue(temp));

        public static bool TbigintValueAtTimestamptz(IntPtr temp, long t, bool strict, IntPtr value)
            => SafeExecution<bool>(() => Native.TbigintValueAtTimestamptz(temp, t, strict, value));

        public static bool TintValueAtTimestamptz(IntPtr temp, long t, bool strict, IntPtr value)
            => SafeExecution<bool>(() => Native.TintValueAtTimestamptz(temp, t, strict, value));

        public static bool TintValueN(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.TintValueN(temp, n, result));

        public static bool TbigintValueN(IntPtr temp, long n, IntPtr result)
            => SafeExecution<bool>(() => Native.TbigintValueN(temp, n, result));

        public static int[] TintValues(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TintValues(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                int[] _out = new int[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static long[] TbigintValues(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TbigintValues(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                long[] _out = new long[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static double TnumberAvgValue(IntPtr temp)
            => SafeExecution<double>(() => Native.TnumberAvgValue(temp));

        public static double TnumberIntegral(IntPtr temp)
            => SafeExecution<double>(() => Native.TnumberIntegral(temp));

        public static double TnumberTwavg(IntPtr temp)
            => SafeExecution<double>(() => Native.TnumberTwavg(temp));

        public static IntPtr TnumberValuespans(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TnumberValuespans(temp));

        public static IntPtr TtextEndValue(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TtextEndValue(temp));

        public static IntPtr TtextMaxValue(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TtextMaxValue(temp));

        public static IntPtr TtextMinValue(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TtextMinValue(temp));

        public static IntPtr TtextStartValue(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TtextStartValue(temp));

        public static bool TtextValueAtTimestamptz(IntPtr temp, long t, bool strict, IntPtr value)
            => SafeExecution<bool>(() => Native.TtextValueAtTimestamptz(temp, t, strict, value));

        public static bool TtextValueN(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.TtextValueN(temp, n, result));

        public static IntPtr[] TtextValues(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TtextValues(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static double FloatDegrees(double value, bool normalize)
            => SafeExecution<double>(() => Native.FloatDegrees(value, normalize));

        public static IntPtr TemparrRound(IntPtr temp, int count, int maxdd)
            => SafeExecution<IntPtr>(() => Native.TemparrRound(temp, count, maxdd));

        public static IntPtr TemporalRound(IntPtr temp, int maxdd)
            => SafeExecution<IntPtr>(() => Native.TemporalRound(temp, maxdd));

        public static IntPtr TemporalScaleTime(IntPtr temp, IntPtr duration)
            => SafeExecution<IntPtr>(() => Native.TemporalScaleTime(temp, duration));

        public static IntPtr TemporalSetInterp(IntPtr temp, int interp)
            => SafeExecution<IntPtr>(() => Native.TemporalSetInterp(temp, interp));

        public static IntPtr TemporalShiftScaleTime(IntPtr temp, IntPtr shift, IntPtr duration)
            => SafeExecution<IntPtr>(() => Native.TemporalShiftScaleTime(temp, shift, duration));

        public static IntPtr TemporalShiftTime(IntPtr temp, IntPtr shift)
            => SafeExecution<IntPtr>(() => Native.TemporalShiftTime(temp, shift));

        public static IntPtr TemporalAsTinstant(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TemporalAsTinstant(temp));

        public static IntPtr TemporalAsTsequence(IntPtr temp, int interp)
            => SafeExecution<IntPtr>(() => Native.TemporalAsTsequence(temp, interp));

        public static IntPtr TemporalAsTsequenceset(IntPtr temp, int interp)
            => SafeExecution<IntPtr>(() => Native.TemporalAsTsequenceset(temp, interp));

        public static IntPtr TfloatCeil(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TfloatCeil(temp));

        public static IntPtr TfloatDegrees(IntPtr temp, bool normalize)
            => SafeExecution<IntPtr>(() => Native.TfloatDegrees(temp, normalize));

        public static IntPtr TfloatFloor(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TfloatFloor(temp));

        public static IntPtr TfloatRadians(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TfloatRadians(temp));

        public static IntPtr TfloatScaleValue(IntPtr temp, double width)
            => SafeExecution<IntPtr>(() => Native.TfloatScaleValue(temp, width));

        public static IntPtr TfloatShiftScaleValue(IntPtr temp, double shift, double width)
            => SafeExecution<IntPtr>(() => Native.TfloatShiftScaleValue(temp, shift, width));

        public static IntPtr TfloatShiftValue(IntPtr temp, double shift)
            => SafeExecution<IntPtr>(() => Native.TfloatShiftValue(temp, shift));

        public static IntPtr TintScaleValue(IntPtr temp, int width)
            => SafeExecution<IntPtr>(() => Native.TintScaleValue(temp, width));

        public static IntPtr TbigintScaleValue(IntPtr temp, long width)
            => SafeExecution<IntPtr>(() => Native.TbigintScaleValue(temp, width));

        public static IntPtr TintShiftScaleValue(IntPtr temp, int shift, int width)
            => SafeExecution<IntPtr>(() => Native.TintShiftScaleValue(temp, shift, width));

        public static IntPtr TbigintShiftScaleValue(IntPtr temp, long shift, long width)
            => SafeExecution<IntPtr>(() => Native.TbigintShiftScaleValue(temp, shift, width));

        public static IntPtr TintShiftValue(IntPtr temp, int shift)
            => SafeExecution<IntPtr>(() => Native.TintShiftValue(temp, shift));

        public static IntPtr TbigintShiftValue(IntPtr temp, long shift)
            => SafeExecution<IntPtr>(() => Native.TbigintShiftValue(temp, shift));

        public static IntPtr TemporalAppendTinstant(IntPtr temp, IntPtr inst, int interp, double maxdist, IntPtr maxt, bool expand)
            => SafeExecution<IntPtr>(() => Native.TemporalAppendTinstant(temp, inst, interp, maxdist, maxt, expand));

        public static IntPtr TemporalAppendTsequence(IntPtr temp, IntPtr seq, bool expand)
            => SafeExecution<IntPtr>(() => Native.TemporalAppendTsequence(temp, seq, expand));

        public static IntPtr TemporalDeleteTimestamptz(IntPtr temp, long t, bool connect)
            => SafeExecution<IntPtr>(() => Native.TemporalDeleteTimestamptz(temp, t, connect));

        public static IntPtr TemporalDeleteTstzset(IntPtr temp, IntPtr s, bool connect)
            => SafeExecution<IntPtr>(() => Native.TemporalDeleteTstzset(temp, s, connect));

        public static IntPtr TemporalDeleteTstzspan(IntPtr temp, IntPtr s, bool connect)
            => SafeExecution<IntPtr>(() => Native.TemporalDeleteTstzspan(temp, s, connect));

        public static IntPtr TemporalDeleteTstzspanset(IntPtr temp, IntPtr ss, bool connect)
            => SafeExecution<IntPtr>(() => Native.TemporalDeleteTstzspanset(temp, ss, connect));

        public static IntPtr TemporalInsert(IntPtr temp1, IntPtr temp2, bool connect)
            => SafeExecution<IntPtr>(() => Native.TemporalInsert(temp1, temp2, connect));

        public static IntPtr TemporalMerge(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TemporalMerge(temp1, temp2));

        public static IntPtr TemporalMergeArray(IntPtr temparr, int count)
            => SafeExecution<IntPtr>(() => Native.TemporalMergeArray(temparr, count));

        public static IntPtr TemporalUpdate(IntPtr temp1, IntPtr temp2, bool connect)
            => SafeExecution<IntPtr>(() => Native.TemporalUpdate(temp1, temp2, connect));

        public static IntPtr TboolAtValue(IntPtr temp, bool b)
            => SafeExecution<IntPtr>(() => Native.TboolAtValue(temp, b));

        public static IntPtr TboolMinusValue(IntPtr temp, bool b)
            => SafeExecution<IntPtr>(() => Native.TboolMinusValue(temp, b));

        public static IntPtr TemporalAfterTimestamptz(IntPtr temp, long t, bool strict)
            => SafeExecution<IntPtr>(() => Native.TemporalAfterTimestamptz(temp, t, strict));

        public static IntPtr TemporalAtMax(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TemporalAtMax(temp));

        public static IntPtr TemporalAtMin(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TemporalAtMin(temp));

        public static IntPtr TemporalAtTimestamptz(IntPtr temp, long t)
            => SafeExecution<IntPtr>(() => Native.TemporalAtTimestamptz(temp, t));

        public static IntPtr TemporalAtTstzset(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TemporalAtTstzset(temp, s));

        public static IntPtr TemporalAtTstzspan(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TemporalAtTstzspan(temp, s));

        public static IntPtr TemporalAtTstzspanset(IntPtr temp, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TemporalAtTstzspanset(temp, ss));

        public static IntPtr TemporalAtValues(IntPtr temp, IntPtr set)
            => SafeExecution<IntPtr>(() => Native.TemporalAtValues(temp, set));

        public static IntPtr TemporalBeforeTimestamptz(IntPtr temp, long t, bool strict)
            => SafeExecution<IntPtr>(() => Native.TemporalBeforeTimestamptz(temp, t, strict));

        public static IntPtr TemporalMinusMax(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TemporalMinusMax(temp));

        public static IntPtr TemporalMinusMin(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TemporalMinusMin(temp));

        public static IntPtr TemporalMinusTimestamptz(IntPtr temp, long t)
            => SafeExecution<IntPtr>(() => Native.TemporalMinusTimestamptz(temp, t));

        public static IntPtr TemporalMinusTstzset(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TemporalMinusTstzset(temp, s));

        public static IntPtr TemporalMinusTstzspan(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TemporalMinusTstzspan(temp, s));

        public static IntPtr TemporalMinusTstzspanset(IntPtr temp, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TemporalMinusTstzspanset(temp, ss));

        public static IntPtr TemporalMinusValues(IntPtr temp, IntPtr set)
            => SafeExecution<IntPtr>(() => Native.TemporalMinusValues(temp, set));

        public static IntPtr TfloatAtValue(IntPtr temp, double d)
            => SafeExecution<IntPtr>(() => Native.TfloatAtValue(temp, d));

        public static IntPtr TfloatMinusValue(IntPtr temp, double d)
            => SafeExecution<IntPtr>(() => Native.TfloatMinusValue(temp, d));

        public static IntPtr TintAtValue(IntPtr temp, int i)
            => SafeExecution<IntPtr>(() => Native.TintAtValue(temp, i));

        public static IntPtr TintMinusValue(IntPtr temp, int i)
            => SafeExecution<IntPtr>(() => Native.TintMinusValue(temp, i));

        public static IntPtr TnumberAtSpan(IntPtr temp, IntPtr span)
            => SafeExecution<IntPtr>(() => Native.TnumberAtSpan(temp, span));

        public static IntPtr TnumberAtSpanset(IntPtr temp, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TnumberAtSpanset(temp, ss));

        public static IntPtr TnumberAtTbox(IntPtr temp, IntPtr box)
            => SafeExecution<IntPtr>(() => Native.TnumberAtTbox(temp, box));

        public static IntPtr TnumberMinusSpan(IntPtr temp, IntPtr span)
            => SafeExecution<IntPtr>(() => Native.TnumberMinusSpan(temp, span));

        public static IntPtr TnumberMinusSpanset(IntPtr temp, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TnumberMinusSpanset(temp, ss));

        public static IntPtr TnumberMinusTbox(IntPtr temp, IntPtr box)
            => SafeExecution<IntPtr>(() => Native.TnumberMinusTbox(temp, box));

        public static IntPtr TtextAtValue(IntPtr temp, IntPtr txt)
            => SafeExecution<IntPtr>(() => Native.TtextAtValue(temp, txt));

        public static IntPtr TtextMinusValue(IntPtr temp, IntPtr txt)
            => SafeExecution<IntPtr>(() => Native.TtextMinusValue(temp, txt));

        public static int TemporalCmp(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.TemporalCmp(temp1, temp2));

        public static bool TemporalEq(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.TemporalEq(temp1, temp2));

        public static bool TemporalGe(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.TemporalGe(temp1, temp2));

        public static bool TemporalGt(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.TemporalGt(temp1, temp2));

        public static bool TemporalLe(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.TemporalLe(temp1, temp2));

        public static bool TemporalLt(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.TemporalLt(temp1, temp2));

        public static bool TemporalNe(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.TemporalNe(temp1, temp2));

        public static int AlwaysEqBoolTbool(bool b, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysEqBoolTbool(b, temp));

        public static int AlwaysEqFloatTfloat(double d, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysEqFloatTfloat(d, temp));

        public static int AlwaysEqIntTint(int i, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysEqIntTint(i, temp));

        public static int AlwaysEqTboolBool(IntPtr temp, bool b)
            => SafeExecution<int>(() => Native.AlwaysEqTboolBool(temp, b));

        public static int AlwaysEqTemporalTemporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysEqTemporalTemporal(temp1, temp2));

        public static int AlwaysEqTextTtext(IntPtr txt, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysEqTextTtext(txt, temp));

        public static int AlwaysEqTfloatFloat(IntPtr temp, double d)
            => SafeExecution<int>(() => Native.AlwaysEqTfloatFloat(temp, d));

        public static int AlwaysEqTintInt(IntPtr temp, int i)
            => SafeExecution<int>(() => Native.AlwaysEqTintInt(temp, i));

        public static int AlwaysEqBigintTbigint(long i, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysEqBigintTbigint(i, temp));

        public static int AlwaysEqTbigintBigint(IntPtr temp, long i)
            => SafeExecution<int>(() => Native.AlwaysEqTbigintBigint(temp, i));

        public static int AlwaysEqTtextText(IntPtr temp, IntPtr txt)
            => SafeExecution<int>(() => Native.AlwaysEqTtextText(temp, txt));

        public static int AlwaysGeFloatTfloat(double d, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysGeFloatTfloat(d, temp));

        public static int AlwaysGeIntTint(int i, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysGeIntTint(i, temp));

        public static int AlwaysGeTemporalTemporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysGeTemporalTemporal(temp1, temp2));

        public static int AlwaysGeTextTtext(IntPtr txt, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysGeTextTtext(txt, temp));

        public static int AlwaysGeTfloatFloat(IntPtr temp, double d)
            => SafeExecution<int>(() => Native.AlwaysGeTfloatFloat(temp, d));

        public static int AlwaysGeTintInt(IntPtr temp, int i)
            => SafeExecution<int>(() => Native.AlwaysGeTintInt(temp, i));

        public static int AlwaysGeBigintTbigint(long i, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysGeBigintTbigint(i, temp));

        public static int AlwaysGeTbigintBigint(IntPtr temp, long i)
            => SafeExecution<int>(() => Native.AlwaysGeTbigintBigint(temp, i));

        public static int AlwaysGeTtextText(IntPtr temp, IntPtr txt)
            => SafeExecution<int>(() => Native.AlwaysGeTtextText(temp, txt));

        public static int AlwaysGtFloatTfloat(double d, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysGtFloatTfloat(d, temp));

        public static int AlwaysGtIntTint(int i, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysGtIntTint(i, temp));

        public static int AlwaysGtTemporalTemporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysGtTemporalTemporal(temp1, temp2));

        public static int AlwaysGtTextTtext(IntPtr txt, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysGtTextTtext(txt, temp));

        public static int AlwaysGtTfloatFloat(IntPtr temp, double d)
            => SafeExecution<int>(() => Native.AlwaysGtTfloatFloat(temp, d));

        public static int AlwaysGtTintInt(IntPtr temp, int i)
            => SafeExecution<int>(() => Native.AlwaysGtTintInt(temp, i));

        public static int AlwaysGtBigintTbigint(long i, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysGtBigintTbigint(i, temp));

        public static int AlwaysGtTbigintBigint(IntPtr temp, long i)
            => SafeExecution<int>(() => Native.AlwaysGtTbigintBigint(temp, i));

        public static int AlwaysGtTtextText(IntPtr temp, IntPtr txt)
            => SafeExecution<int>(() => Native.AlwaysGtTtextText(temp, txt));

        public static int AlwaysLeFloatTfloat(double d, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysLeFloatTfloat(d, temp));

        public static int AlwaysLeIntTint(int i, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysLeIntTint(i, temp));

        public static int AlwaysLeTemporalTemporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysLeTemporalTemporal(temp1, temp2));

        public static int AlwaysLeTextTtext(IntPtr txt, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysLeTextTtext(txt, temp));

        public static int AlwaysLeTfloatFloat(IntPtr temp, double d)
            => SafeExecution<int>(() => Native.AlwaysLeTfloatFloat(temp, d));

        public static int AlwaysLeTintInt(IntPtr temp, int i)
            => SafeExecution<int>(() => Native.AlwaysLeTintInt(temp, i));

        public static int AlwaysLeBigintTbigint(long i, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysLeBigintTbigint(i, temp));

        public static int AlwaysLeTbigintBigint(IntPtr temp, long i)
            => SafeExecution<int>(() => Native.AlwaysLeTbigintBigint(temp, i));

        public static int AlwaysLeTtextText(IntPtr temp, IntPtr txt)
            => SafeExecution<int>(() => Native.AlwaysLeTtextText(temp, txt));

        public static int AlwaysLtFloatTfloat(double d, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysLtFloatTfloat(d, temp));

        public static int AlwaysLtIntTint(int i, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysLtIntTint(i, temp));

        public static int AlwaysLtTemporalTemporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysLtTemporalTemporal(temp1, temp2));

        public static int AlwaysLtTextTtext(IntPtr txt, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysLtTextTtext(txt, temp));

        public static int AlwaysLtTfloatFloat(IntPtr temp, double d)
            => SafeExecution<int>(() => Native.AlwaysLtTfloatFloat(temp, d));

        public static int AlwaysLtTintInt(IntPtr temp, int i)
            => SafeExecution<int>(() => Native.AlwaysLtTintInt(temp, i));

        public static int AlwaysLtBigintTbigint(long i, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysLtBigintTbigint(i, temp));

        public static int AlwaysLtTbigintBigint(IntPtr temp, long i)
            => SafeExecution<int>(() => Native.AlwaysLtTbigintBigint(temp, i));

        public static int AlwaysLtTtextText(IntPtr temp, IntPtr txt)
            => SafeExecution<int>(() => Native.AlwaysLtTtextText(temp, txt));

        public static int AlwaysNeBoolTbool(bool b, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysNeBoolTbool(b, temp));

        public static int AlwaysNeFloatTfloat(double d, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysNeFloatTfloat(d, temp));

        public static int AlwaysNeIntTint(int i, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysNeIntTint(i, temp));

        public static int AlwaysNeTboolBool(IntPtr temp, bool b)
            => SafeExecution<int>(() => Native.AlwaysNeTboolBool(temp, b));

        public static int AlwaysNeTemporalTemporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysNeTemporalTemporal(temp1, temp2));

        public static int AlwaysNeTextTtext(IntPtr txt, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysNeTextTtext(txt, temp));

        public static int AlwaysNeTfloatFloat(IntPtr temp, double d)
            => SafeExecution<int>(() => Native.AlwaysNeTfloatFloat(temp, d));

        public static int AlwaysNeTintInt(IntPtr temp, int i)
            => SafeExecution<int>(() => Native.AlwaysNeTintInt(temp, i));

        public static int AlwaysNeBigintTbigint(long i, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysNeBigintTbigint(i, temp));

        public static int AlwaysNeTbigintBigint(IntPtr temp, long i)
            => SafeExecution<int>(() => Native.AlwaysNeTbigintBigint(temp, i));

        public static int AlwaysNeTtextText(IntPtr temp, IntPtr txt)
            => SafeExecution<int>(() => Native.AlwaysNeTtextText(temp, txt));

        public static int EverEqBoolTbool(bool b, IntPtr temp)
            => SafeExecution<int>(() => Native.EverEqBoolTbool(b, temp));

        public static int EverEqFloatTfloat(double d, IntPtr temp)
            => SafeExecution<int>(() => Native.EverEqFloatTfloat(d, temp));

        public static int EverEqIntTint(int i, IntPtr temp)
            => SafeExecution<int>(() => Native.EverEqIntTint(i, temp));

        public static int EverEqTboolBool(IntPtr temp, bool b)
            => SafeExecution<int>(() => Native.EverEqTboolBool(temp, b));

        public static int EverEqTemporalTemporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverEqTemporalTemporal(temp1, temp2));

        public static int EverEqTextTtext(IntPtr txt, IntPtr temp)
            => SafeExecution<int>(() => Native.EverEqTextTtext(txt, temp));

        public static int EverEqTfloatFloat(IntPtr temp, double d)
            => SafeExecution<int>(() => Native.EverEqTfloatFloat(temp, d));

        public static int EverEqTintInt(IntPtr temp, int i)
            => SafeExecution<int>(() => Native.EverEqTintInt(temp, i));

        public static int EverEqBigintTbigint(long i, IntPtr temp)
            => SafeExecution<int>(() => Native.EverEqBigintTbigint(i, temp));

        public static int EverEqTbigintBigint(IntPtr temp, long i)
            => SafeExecution<int>(() => Native.EverEqTbigintBigint(temp, i));

        public static int EverEqTtextText(IntPtr temp, IntPtr txt)
            => SafeExecution<int>(() => Native.EverEqTtextText(temp, txt));

        public static int EverGeFloatTfloat(double d, IntPtr temp)
            => SafeExecution<int>(() => Native.EverGeFloatTfloat(d, temp));

        public static int EverGeIntTint(int i, IntPtr temp)
            => SafeExecution<int>(() => Native.EverGeIntTint(i, temp));

        public static int EverGeTemporalTemporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverGeTemporalTemporal(temp1, temp2));

        public static int EverGeTextTtext(IntPtr txt, IntPtr temp)
            => SafeExecution<int>(() => Native.EverGeTextTtext(txt, temp));

        public static int EverGeTfloatFloat(IntPtr temp, double d)
            => SafeExecution<int>(() => Native.EverGeTfloatFloat(temp, d));

        public static int EverGeTintInt(IntPtr temp, int i)
            => SafeExecution<int>(() => Native.EverGeTintInt(temp, i));

        public static int EverGeBigintTbigint(long i, IntPtr temp)
            => SafeExecution<int>(() => Native.EverGeBigintTbigint(i, temp));

        public static int EverGeTbigintBigint(IntPtr temp, long i)
            => SafeExecution<int>(() => Native.EverGeTbigintBigint(temp, i));

        public static int EverGeTtextText(IntPtr temp, IntPtr txt)
            => SafeExecution<int>(() => Native.EverGeTtextText(temp, txt));

        public static int EverGtFloatTfloat(double d, IntPtr temp)
            => SafeExecution<int>(() => Native.EverGtFloatTfloat(d, temp));

        public static int EverGtIntTint(int i, IntPtr temp)
            => SafeExecution<int>(() => Native.EverGtIntTint(i, temp));

        public static int EverGtTemporalTemporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverGtTemporalTemporal(temp1, temp2));

        public static int EverGtTextTtext(IntPtr txt, IntPtr temp)
            => SafeExecution<int>(() => Native.EverGtTextTtext(txt, temp));

        public static int EverGtTfloatFloat(IntPtr temp, double d)
            => SafeExecution<int>(() => Native.EverGtTfloatFloat(temp, d));

        public static int EverGtTintInt(IntPtr temp, int i)
            => SafeExecution<int>(() => Native.EverGtTintInt(temp, i));

        public static int EverGtBigintTbigint(long i, IntPtr temp)
            => SafeExecution<int>(() => Native.EverGtBigintTbigint(i, temp));

        public static int EverGtTbigintBigint(IntPtr temp, long i)
            => SafeExecution<int>(() => Native.EverGtTbigintBigint(temp, i));

        public static int EverGtTtextText(IntPtr temp, IntPtr txt)
            => SafeExecution<int>(() => Native.EverGtTtextText(temp, txt));

        public static int EverLeFloatTfloat(double d, IntPtr temp)
            => SafeExecution<int>(() => Native.EverLeFloatTfloat(d, temp));

        public static int EverLeIntTint(int i, IntPtr temp)
            => SafeExecution<int>(() => Native.EverLeIntTint(i, temp));

        public static int EverLeTemporalTemporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverLeTemporalTemporal(temp1, temp2));

        public static int EverLeTextTtext(IntPtr txt, IntPtr temp)
            => SafeExecution<int>(() => Native.EverLeTextTtext(txt, temp));

        public static int EverLeTfloatFloat(IntPtr temp, double d)
            => SafeExecution<int>(() => Native.EverLeTfloatFloat(temp, d));

        public static int EverLeTintInt(IntPtr temp, int i)
            => SafeExecution<int>(() => Native.EverLeTintInt(temp, i));

        public static int EverLeBigintTbigint(long i, IntPtr temp)
            => SafeExecution<int>(() => Native.EverLeBigintTbigint(i, temp));

        public static int EverLeTbigintBigint(IntPtr temp, long i)
            => SafeExecution<int>(() => Native.EverLeTbigintBigint(temp, i));

        public static int EverLeTtextText(IntPtr temp, IntPtr txt)
            => SafeExecution<int>(() => Native.EverLeTtextText(temp, txt));

        public static int EverLtFloatTfloat(double d, IntPtr temp)
            => SafeExecution<int>(() => Native.EverLtFloatTfloat(d, temp));

        public static int EverLtIntTint(int i, IntPtr temp)
            => SafeExecution<int>(() => Native.EverLtIntTint(i, temp));

        public static int EverLtTemporalTemporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverLtTemporalTemporal(temp1, temp2));

        public static int EverLtTextTtext(IntPtr txt, IntPtr temp)
            => SafeExecution<int>(() => Native.EverLtTextTtext(txt, temp));

        public static int EverLtTfloatFloat(IntPtr temp, double d)
            => SafeExecution<int>(() => Native.EverLtTfloatFloat(temp, d));

        public static int EverLtTintInt(IntPtr temp, int i)
            => SafeExecution<int>(() => Native.EverLtTintInt(temp, i));

        public static int EverLtBigintTbigint(long i, IntPtr temp)
            => SafeExecution<int>(() => Native.EverLtBigintTbigint(i, temp));

        public static int EverLtTbigintBigint(IntPtr temp, long i)
            => SafeExecution<int>(() => Native.EverLtTbigintBigint(temp, i));

        public static int EverLtTtextText(IntPtr temp, IntPtr txt)
            => SafeExecution<int>(() => Native.EverLtTtextText(temp, txt));

        public static int EverNeBoolTbool(bool b, IntPtr temp)
            => SafeExecution<int>(() => Native.EverNeBoolTbool(b, temp));

        public static int EverNeFloatTfloat(double d, IntPtr temp)
            => SafeExecution<int>(() => Native.EverNeFloatTfloat(d, temp));

        public static int EverNeIntTint(int i, IntPtr temp)
            => SafeExecution<int>(() => Native.EverNeIntTint(i, temp));

        public static int EverNeTboolBool(IntPtr temp, bool b)
            => SafeExecution<int>(() => Native.EverNeTboolBool(temp, b));

        public static int EverNeTemporalTemporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverNeTemporalTemporal(temp1, temp2));

        public static int EverNeTextTtext(IntPtr txt, IntPtr temp)
            => SafeExecution<int>(() => Native.EverNeTextTtext(txt, temp));

        public static int EverNeTfloatFloat(IntPtr temp, double d)
            => SafeExecution<int>(() => Native.EverNeTfloatFloat(temp, d));

        public static int EverNeTintInt(IntPtr temp, int i)
            => SafeExecution<int>(() => Native.EverNeTintInt(temp, i));

        public static int EverNeBigintTbigint(long i, IntPtr temp)
            => SafeExecution<int>(() => Native.EverNeBigintTbigint(i, temp));

        public static int EverNeTbigintBigint(IntPtr temp, long i)
            => SafeExecution<int>(() => Native.EverNeTbigintBigint(temp, i));

        public static int EverNeTtextText(IntPtr temp, IntPtr txt)
            => SafeExecution<int>(() => Native.EverNeTtextText(temp, txt));

        public static IntPtr TeqBigintTbigint(long i, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TeqBigintTbigint(i, temp));

        public static IntPtr TeqBoolTbool(bool b, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TeqBoolTbool(b, temp));

        public static IntPtr TeqFloatTfloat(double d, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TeqFloatTfloat(d, temp));

        public static IntPtr TeqIntTint(int i, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TeqIntTint(i, temp));

        public static IntPtr TeqTbigintBigint(IntPtr temp, long i)
            => SafeExecution<IntPtr>(() => Native.TeqTbigintBigint(temp, i));

        public static IntPtr TeqTboolBool(IntPtr temp, bool b)
            => SafeExecution<IntPtr>(() => Native.TeqTboolBool(temp, b));

        public static IntPtr TeqTemporalTemporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TeqTemporalTemporal(temp1, temp2));

        public static IntPtr TeqTextTtext(IntPtr txt, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TeqTextTtext(txt, temp));

        public static IntPtr TeqTfloatFloat(IntPtr temp, double d)
            => SafeExecution<IntPtr>(() => Native.TeqTfloatFloat(temp, d));

        public static IntPtr TeqTintInt(IntPtr temp, int i)
            => SafeExecution<IntPtr>(() => Native.TeqTintInt(temp, i));

        public static IntPtr TeqTtextText(IntPtr temp, IntPtr txt)
            => SafeExecution<IntPtr>(() => Native.TeqTtextText(temp, txt));

        public static IntPtr TgeBigintTbigint(long i, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TgeBigintTbigint(i, temp));

        public static IntPtr TgeFloatTfloat(double d, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TgeFloatTfloat(d, temp));

        public static IntPtr TgeIntTint(int i, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TgeIntTint(i, temp));

        public static IntPtr TgeTemporalTemporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TgeTemporalTemporal(temp1, temp2));

        public static IntPtr TgeTextTtext(IntPtr txt, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TgeTextTtext(txt, temp));

        public static IntPtr TgeTbigintBigint(IntPtr temp, long i)
            => SafeExecution<IntPtr>(() => Native.TgeTbigintBigint(temp, i));

        public static IntPtr TgeTfloatFloat(IntPtr temp, double d)
            => SafeExecution<IntPtr>(() => Native.TgeTfloatFloat(temp, d));

        public static IntPtr TgeTintInt(IntPtr temp, int i)
            => SafeExecution<IntPtr>(() => Native.TgeTintInt(temp, i));

        public static IntPtr TgeTtextText(IntPtr temp, IntPtr txt)
            => SafeExecution<IntPtr>(() => Native.TgeTtextText(temp, txt));

        public static IntPtr TgtBigintTbigint(long i, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TgtBigintTbigint(i, temp));

        public static IntPtr TgtFloatTfloat(double d, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TgtFloatTfloat(d, temp));

        public static IntPtr TgtIntTint(int i, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TgtIntTint(i, temp));

        public static IntPtr TgtTemporalTemporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TgtTemporalTemporal(temp1, temp2));

        public static IntPtr TgtTextTtext(IntPtr txt, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TgtTextTtext(txt, temp));

        public static IntPtr TgtTbigintBigint(IntPtr temp, long i)
            => SafeExecution<IntPtr>(() => Native.TgtTbigintBigint(temp, i));

        public static IntPtr TgtTfloatFloat(IntPtr temp, double d)
            => SafeExecution<IntPtr>(() => Native.TgtTfloatFloat(temp, d));

        public static IntPtr TgtTintInt(IntPtr temp, int i)
            => SafeExecution<IntPtr>(() => Native.TgtTintInt(temp, i));

        public static IntPtr TgtTtextText(IntPtr temp, IntPtr txt)
            => SafeExecution<IntPtr>(() => Native.TgtTtextText(temp, txt));

        public static IntPtr TleBigintTbigint(long i, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TleBigintTbigint(i, temp));

        public static IntPtr TleFloatTfloat(double d, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TleFloatTfloat(d, temp));

        public static IntPtr TleIntTint(int i, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TleIntTint(i, temp));

        public static IntPtr TleTemporalTemporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TleTemporalTemporal(temp1, temp2));

        public static IntPtr TleTextTtext(IntPtr txt, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TleTextTtext(txt, temp));

        public static IntPtr TleTbigintBigint(IntPtr temp, long i)
            => SafeExecution<IntPtr>(() => Native.TleTbigintBigint(temp, i));

        public static IntPtr TleTfloatFloat(IntPtr temp, double d)
            => SafeExecution<IntPtr>(() => Native.TleTfloatFloat(temp, d));

        public static IntPtr TleTintInt(IntPtr temp, int i)
            => SafeExecution<IntPtr>(() => Native.TleTintInt(temp, i));

        public static IntPtr TleTtextText(IntPtr temp, IntPtr txt)
            => SafeExecution<IntPtr>(() => Native.TleTtextText(temp, txt));

        public static IntPtr TltBigintTbigint(long i, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TltBigintTbigint(i, temp));

        public static IntPtr TltFloatTfloat(double d, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TltFloatTfloat(d, temp));

        public static IntPtr TltIntTint(int i, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TltIntTint(i, temp));

        public static IntPtr TltTemporalTemporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TltTemporalTemporal(temp1, temp2));

        public static IntPtr TltTextTtext(IntPtr txt, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TltTextTtext(txt, temp));

        public static IntPtr TltTbigintBigint(IntPtr temp, long i)
            => SafeExecution<IntPtr>(() => Native.TltTbigintBigint(temp, i));

        public static IntPtr TltTfloatFloat(IntPtr temp, double d)
            => SafeExecution<IntPtr>(() => Native.TltTfloatFloat(temp, d));

        public static IntPtr TltTintInt(IntPtr temp, int i)
            => SafeExecution<IntPtr>(() => Native.TltTintInt(temp, i));

        public static IntPtr TltTtextText(IntPtr temp, IntPtr txt)
            => SafeExecution<IntPtr>(() => Native.TltTtextText(temp, txt));

        public static IntPtr TneBigintTbigint(long i, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TneBigintTbigint(i, temp));

        public static IntPtr TneBoolTbool(bool b, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TneBoolTbool(b, temp));

        public static IntPtr TneFloatTfloat(double d, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TneFloatTfloat(d, temp));

        public static IntPtr TneIntTint(int i, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TneIntTint(i, temp));

        public static IntPtr TneTbigintBigint(IntPtr temp, long i)
            => SafeExecution<IntPtr>(() => Native.TneTbigintBigint(temp, i));

        public static IntPtr TneTboolBool(IntPtr temp, bool b)
            => SafeExecution<IntPtr>(() => Native.TneTboolBool(temp, b));

        public static IntPtr TneTemporalTemporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TneTemporalTemporal(temp1, temp2));

        public static IntPtr TneTextTtext(IntPtr txt, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TneTextTtext(txt, temp));

        public static IntPtr TneTfloatFloat(IntPtr temp, double d)
            => SafeExecution<IntPtr>(() => Native.TneTfloatFloat(temp, d));

        public static IntPtr TneTintInt(IntPtr temp, int i)
            => SafeExecution<IntPtr>(() => Native.TneTintInt(temp, i));

        public static IntPtr TneTtextText(IntPtr temp, IntPtr txt)
            => SafeExecution<IntPtr>(() => Native.TneTtextText(temp, txt));

        public static IntPtr[] TemporalSpans(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TemporalSpans(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 24); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TemporalSplitEachNSpans(IntPtr temp, int elem_count)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TemporalSplitEachNSpans(temp, elem_count, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 24); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TemporalSplitNSpans(IntPtr temp, int span_count)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TemporalSplitNSpans(temp, span_count, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 24); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TnumberSplitEachNTboxes(IntPtr temp, int elem_count)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TnumberSplitEachNTboxes(temp, elem_count, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 56); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TnumberSplitNTboxes(IntPtr temp, int box_count)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TnumberSplitNTboxes(temp, box_count, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 56); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TnumberTboxes(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TnumberTboxes(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 56); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool AdjacentNumspanTnumber(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => Native.AdjacentNumspanTnumber(s, temp));

        public static bool AdjacentTboxTnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.AdjacentTboxTnumber(box, temp));

        public static bool AdjacentTemporalTemporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.AdjacentTemporalTemporal(temp1, temp2));

        public static bool AdjacentTemporalTstzspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => Native.AdjacentTemporalTstzspan(temp, s));

        public static bool AdjacentTnumberNumspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => Native.AdjacentTnumberNumspan(temp, s));

        public static bool AdjacentTnumberTbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.AdjacentTnumberTbox(temp, box));

        public static bool AdjacentTnumberTnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.AdjacentTnumberTnumber(temp1, temp2));

        public static bool AdjacentTstzspanTemporal(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => Native.AdjacentTstzspanTemporal(s, temp));

        public static bool ContainedNumspanTnumber(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => Native.ContainedNumspanTnumber(s, temp));

        public static bool ContainedTboxTnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.ContainedTboxTnumber(box, temp));

        public static bool ContainedTemporalTemporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.ContainedTemporalTemporal(temp1, temp2));

        public static bool ContainedTemporalTstzspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => Native.ContainedTemporalTstzspan(temp, s));

        public static bool ContainedTnumberNumspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => Native.ContainedTnumberNumspan(temp, s));

        public static bool ContainedTnumberTbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.ContainedTnumberTbox(temp, box));

        public static bool ContainedTnumberTnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.ContainedTnumberTnumber(temp1, temp2));

        public static bool ContainedTstzspanTemporal(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => Native.ContainedTstzspanTemporal(s, temp));

        public static bool ContainsNumspanTnumber(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => Native.ContainsNumspanTnumber(s, temp));

        public static bool ContainsTboxTnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.ContainsTboxTnumber(box, temp));

        public static bool ContainsTemporalTstzspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => Native.ContainsTemporalTstzspan(temp, s));

        public static bool ContainsTemporalTemporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.ContainsTemporalTemporal(temp1, temp2));

        public static bool ContainsTnumberNumspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => Native.ContainsTnumberNumspan(temp, s));

        public static bool ContainsTnumberTbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.ContainsTnumberTbox(temp, box));

        public static bool ContainsTnumberTnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.ContainsTnumberTnumber(temp1, temp2));

        public static bool ContainsTstzspanTemporal(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => Native.ContainsTstzspanTemporal(s, temp));

        public static bool OverlapsNumspanTnumber(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => Native.OverlapsNumspanTnumber(s, temp));

        public static bool OverlapsTboxTnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.OverlapsTboxTnumber(box, temp));

        public static bool OverlapsTemporalTemporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.OverlapsTemporalTemporal(temp1, temp2));

        public static bool TemporalTimeOverlaps(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.TemporalTimeOverlaps(temp1, temp2));

        public static bool OverlapsTemporalTstzspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => Native.OverlapsTemporalTstzspan(temp, s));

        public static bool OverlapsTnumberNumspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => Native.OverlapsTnumberNumspan(temp, s));

        public static bool OverlapsTnumberTbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.OverlapsTnumberTbox(temp, box));

        public static bool OverlapsTnumberTnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.OverlapsTnumberTnumber(temp1, temp2));

        public static bool OverlapsTstzspanTemporal(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => Native.OverlapsTstzspanTemporal(s, temp));

        public static bool SameNumspanTnumber(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => Native.SameNumspanTnumber(s, temp));

        public static bool SameTboxTnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.SameTboxTnumber(box, temp));

        public static bool SameTemporalTemporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.SameTemporalTemporal(temp1, temp2));

        public static bool SameTemporalTstzspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => Native.SameTemporalTstzspan(temp, s));

        public static bool SameTnumberNumspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => Native.SameTnumberNumspan(temp, s));

        public static bool SameTnumberTbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.SameTnumberTbox(temp, box));

        public static bool SameTnumberTnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.SameTnumberTnumber(temp1, temp2));

        public static bool SameTstzspanTemporal(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => Native.SameTstzspanTemporal(s, temp));

        public static bool AfterTboxTnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.AfterTboxTnumber(box, temp));

        public static bool AfterTemporalTstzspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => Native.AfterTemporalTstzspan(temp, s));

        public static bool AfterTemporalTemporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.AfterTemporalTemporal(temp1, temp2));

        public static bool AfterTnumberTbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.AfterTnumberTbox(temp, box));

        public static bool AfterTnumberTnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.AfterTnumberTnumber(temp1, temp2));

        public static bool AfterTstzspanTemporal(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => Native.AfterTstzspanTemporal(s, temp));

        public static bool BeforeTboxTnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.BeforeTboxTnumber(box, temp));

        public static bool BeforeTemporalTstzspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => Native.BeforeTemporalTstzspan(temp, s));

        public static bool BeforeTemporalTemporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.BeforeTemporalTemporal(temp1, temp2));

        public static bool BeforeTnumberTbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.BeforeTnumberTbox(temp, box));

        public static bool BeforeTnumberTnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.BeforeTnumberTnumber(temp1, temp2));

        public static bool BeforeTstzspanTemporal(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => Native.BeforeTstzspanTemporal(s, temp));

        public static bool LeftTboxTnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.LeftTboxTnumber(box, temp));

        public static bool LeftNumspanTnumber(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => Native.LeftNumspanTnumber(s, temp));

        public static bool LeftTnumberNumspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => Native.LeftTnumberNumspan(temp, s));

        public static bool LeftTnumberTbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.LeftTnumberTbox(temp, box));

        public static bool LeftTnumberTnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.LeftTnumberTnumber(temp1, temp2));

        public static bool OverafterTboxTnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.OverafterTboxTnumber(box, temp));

        public static bool OverafterTemporalTstzspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => Native.OverafterTemporalTstzspan(temp, s));

        public static bool OverafterTemporalTemporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.OverafterTemporalTemporal(temp1, temp2));

        public static bool OverafterTnumberTbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.OverafterTnumberTbox(temp, box));

        public static bool OverafterTnumberTnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.OverafterTnumberTnumber(temp1, temp2));

        public static bool OverafterTstzspanTemporal(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => Native.OverafterTstzspanTemporal(s, temp));

        public static bool OverbeforeTboxTnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.OverbeforeTboxTnumber(box, temp));

        public static bool OverbeforeTemporalTstzspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => Native.OverbeforeTemporalTstzspan(temp, s));

        public static bool OverbeforeTemporalTemporal(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.OverbeforeTemporalTemporal(temp1, temp2));

        public static bool OverbeforeTnumberTbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.OverbeforeTnumberTbox(temp, box));

        public static bool OverbeforeTnumberTnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.OverbeforeTnumberTnumber(temp1, temp2));

        public static bool OverbeforeTstzspanTemporal(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => Native.OverbeforeTstzspanTemporal(s, temp));

        public static bool OverleftNumspanTnumber(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => Native.OverleftNumspanTnumber(s, temp));

        public static bool OverleftTboxTnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.OverleftTboxTnumber(box, temp));

        public static bool OverleftTnumberNumspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => Native.OverleftTnumberNumspan(temp, s));

        public static bool OverleftTnumberTbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.OverleftTnumberTbox(temp, box));

        public static bool OverleftTnumberTnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.OverleftTnumberTnumber(temp1, temp2));

        public static bool OverrightNumspanTnumber(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => Native.OverrightNumspanTnumber(s, temp));

        public static bool OverrightTboxTnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.OverrightTboxTnumber(box, temp));

        public static bool OverrightTnumberNumspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => Native.OverrightTnumberNumspan(temp, s));

        public static bool OverrightTnumberTbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.OverrightTnumberTbox(temp, box));

        public static bool OverrightTnumberTnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.OverrightTnumberTnumber(temp1, temp2));

        public static bool RightNumspanTnumber(IntPtr s, IntPtr temp)
            => SafeExecution<bool>(() => Native.RightNumspanTnumber(s, temp));

        public static bool RightTboxTnumber(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.RightTboxTnumber(box, temp));

        public static bool RightTnumberNumspan(IntPtr temp, IntPtr s)
            => SafeExecution<bool>(() => Native.RightTnumberNumspan(temp, s));

        public static bool RightTnumberTbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.RightTnumberTbox(temp, box));

        public static bool RightTnumberTnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.RightTnumberTnumber(temp1, temp2));

        public static IntPtr TandBoolTbool(bool b, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TandBoolTbool(b, temp));

        public static IntPtr TandTboolBool(IntPtr temp, bool b)
            => SafeExecution<IntPtr>(() => Native.TandTboolBool(temp, b));

        public static IntPtr TandTboolTbool(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TandTboolTbool(temp1, temp2));

        public static IntPtr TboolWhenTrue(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TboolWhenTrue(temp));

        public static IntPtr TnotTbool(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TnotTbool(temp));

        public static IntPtr TorBoolTbool(bool b, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TorBoolTbool(b, temp));

        public static IntPtr TorTboolBool(IntPtr temp, bool b)
            => SafeExecution<IntPtr>(() => Native.TorTboolBool(temp, b));

        public static IntPtr TorTboolTbool(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TorTboolTbool(temp1, temp2));

        public static IntPtr AddFloatTfloat(double d, IntPtr tnumber)
            => SafeExecution<IntPtr>(() => Native.AddFloatTfloat(d, tnumber));

        public static IntPtr AddIntTint(int i, IntPtr tnumber)
            => SafeExecution<IntPtr>(() => Native.AddIntTint(i, tnumber));

        public static IntPtr AddTfloatFloat(IntPtr tnumber, double d)
            => SafeExecution<IntPtr>(() => Native.AddTfloatFloat(tnumber, d));

        public static IntPtr AddTintInt(IntPtr tnumber, int i)
            => SafeExecution<IntPtr>(() => Native.AddTintInt(tnumber, i));

        public static IntPtr AddBigintTbigint(long i, IntPtr tnumber)
            => SafeExecution<IntPtr>(() => Native.AddBigintTbigint(i, tnumber));

        public static IntPtr AddTbigintBigint(IntPtr tnumber, long i)
            => SafeExecution<IntPtr>(() => Native.AddTbigintBigint(tnumber, i));

        public static IntPtr AddTnumberTnumber(IntPtr tnumber1, IntPtr tnumber2)
            => SafeExecution<IntPtr>(() => Native.AddTnumberTnumber(tnumber1, tnumber2));

        public static IntPtr DivFloatTfloat(double d, IntPtr tnumber)
            => SafeExecution<IntPtr>(() => Native.DivFloatTfloat(d, tnumber));

        public static IntPtr DivIntTint(int i, IntPtr tnumber)
            => SafeExecution<IntPtr>(() => Native.DivIntTint(i, tnumber));

        public static IntPtr DivTfloatFloat(IntPtr tnumber, double d)
            => SafeExecution<IntPtr>(() => Native.DivTfloatFloat(tnumber, d));

        public static IntPtr DivTintInt(IntPtr tnumber, int i)
            => SafeExecution<IntPtr>(() => Native.DivTintInt(tnumber, i));

        public static IntPtr DivBigintTbigint(long i, IntPtr tnumber)
            => SafeExecution<IntPtr>(() => Native.DivBigintTbigint(i, tnumber));

        public static IntPtr DivTbigintBigint(IntPtr tnumber, long i)
            => SafeExecution<IntPtr>(() => Native.DivTbigintBigint(tnumber, i));

        public static IntPtr DivTnumberTnumber(IntPtr tnumber1, IntPtr tnumber2)
            => SafeExecution<IntPtr>(() => Native.DivTnumberTnumber(tnumber1, tnumber2));

        public static IntPtr MulFloatTfloat(double d, IntPtr tnumber)
            => SafeExecution<IntPtr>(() => Native.MulFloatTfloat(d, tnumber));

        public static IntPtr MulIntTint(int i, IntPtr tnumber)
            => SafeExecution<IntPtr>(() => Native.MulIntTint(i, tnumber));

        public static IntPtr MulTfloatFloat(IntPtr tnumber, double d)
            => SafeExecution<IntPtr>(() => Native.MulTfloatFloat(tnumber, d));

        public static IntPtr MulTintInt(IntPtr tnumber, int i)
            => SafeExecution<IntPtr>(() => Native.MulTintInt(tnumber, i));

        public static IntPtr MulBigintTbigint(long i, IntPtr tnumber)
            => SafeExecution<IntPtr>(() => Native.MulBigintTbigint(i, tnumber));

        public static IntPtr MulTbigintBigint(IntPtr tnumber, long i)
            => SafeExecution<IntPtr>(() => Native.MulTbigintBigint(tnumber, i));

        public static IntPtr MulTnumberTnumber(IntPtr tnumber1, IntPtr tnumber2)
            => SafeExecution<IntPtr>(() => Native.MulTnumberTnumber(tnumber1, tnumber2));

        public static IntPtr SubFloatTfloat(double d, IntPtr tnumber)
            => SafeExecution<IntPtr>(() => Native.SubFloatTfloat(d, tnumber));

        public static IntPtr SubIntTint(int i, IntPtr tnumber)
            => SafeExecution<IntPtr>(() => Native.SubIntTint(i, tnumber));

        public static IntPtr SubTfloatFloat(IntPtr tnumber, double d)
            => SafeExecution<IntPtr>(() => Native.SubTfloatFloat(tnumber, d));

        public static IntPtr SubTintInt(IntPtr tnumber, int i)
            => SafeExecution<IntPtr>(() => Native.SubTintInt(tnumber, i));

        public static IntPtr SubBigintTbigint(long i, IntPtr tnumber)
            => SafeExecution<IntPtr>(() => Native.SubBigintTbigint(i, tnumber));

        public static IntPtr SubTbigintBigint(IntPtr tnumber, long i)
            => SafeExecution<IntPtr>(() => Native.SubTbigintBigint(tnumber, i));

        public static IntPtr SubTnumberTnumber(IntPtr tnumber1, IntPtr tnumber2)
            => SafeExecution<IntPtr>(() => Native.SubTnumberTnumber(tnumber1, tnumber2));

        public static IntPtr TemporalDerivative(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TemporalDerivative(temp));

        public static IntPtr TfloatExp(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TfloatExp(temp));

        public static IntPtr TfloatLn(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TfloatLn(temp));

        public static IntPtr TfloatLog10(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TfloatLog10(temp));

        public static IntPtr TfloatSin(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TfloatSin(temp));

        public static IntPtr TfloatCos(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TfloatCos(temp));

        public static IntPtr TfloatTan(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TfloatTan(temp));

        public static IntPtr TnumberAbs(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TnumberAbs(temp));

        public static IntPtr TnumberTrend(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TnumberTrend(temp));

        public static double FloatAngularDifference(double degrees1, double degrees2)
            => SafeExecution<double>(() => Native.FloatAngularDifference(degrees1, degrees2));

        public static IntPtr TnumberAngularDifference(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TnumberAngularDifference(temp));

        public static IntPtr TnumberDeltaValue(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TnumberDeltaValue(temp));

        public static IntPtr TextcatTextTtext(IntPtr txt, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TextcatTextTtext(txt, temp));

        public static IntPtr TextcatTtextText(IntPtr temp, IntPtr txt)
            => SafeExecution<IntPtr>(() => Native.TextcatTtextText(temp, txt));

        public static IntPtr TextcatTtextTtext(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TextcatTtextTtext(temp1, temp2));

        public static IntPtr TtextInitcap(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TtextInitcap(temp));

        public static IntPtr TtextUpper(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TtextUpper(temp));

        public static IntPtr TtextLower(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TtextLower(temp));

        public static IntPtr TdistanceTfloatFloat(IntPtr temp, double d)
            => SafeExecution<IntPtr>(() => Native.TdistanceTfloatFloat(temp, d));

        public static IntPtr TdistanceTintInt(IntPtr temp, int i)
            => SafeExecution<IntPtr>(() => Native.TdistanceTintInt(temp, i));

        public static IntPtr TdistanceTnumberTnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TdistanceTnumberTnumber(temp1, temp2));

        public static double NadTboxfloatTboxfloat(IntPtr box1, IntPtr box2)
            => SafeExecution<double>(() => Native.NadTboxfloatTboxfloat(box1, box2));

        public static int NadTboxintTboxint(IntPtr box1, IntPtr box2)
            => SafeExecution<int>(() => Native.NadTboxintTboxint(box1, box2));

        public static double NadTfloatFloat(IntPtr temp, double d)
            => SafeExecution<double>(() => Native.NadTfloatFloat(temp, d));

        public static double NadTfloatTfloat(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => Native.NadTfloatTfloat(temp1, temp2));

        public static double NadTfloatTbox(IntPtr temp, IntPtr box)
            => SafeExecution<double>(() => Native.NadTfloatTbox(temp, box));

        public static long NadTbigintBigint(IntPtr temp, long i)
            => SafeExecution<long>(() => Native.NadTbigintBigint(temp, i));

        public static long NadTbigintTbox(IntPtr temp, IntPtr box)
            => SafeExecution<long>(() => Native.NadTbigintTbox(temp, box));

        public static long NadTbigintTbigint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<long>(() => Native.NadTbigintTbigint(temp1, temp2));

        public static long NadTboxbigintTboxbigint(IntPtr box1, IntPtr box2)
            => SafeExecution<long>(() => Native.NadTboxbigintTboxbigint(box1, box2));

        public static int NadTintInt(IntPtr temp, int i)
            => SafeExecution<int>(() => Native.NadTintInt(temp, i));

        public static int NadTintTbox(IntPtr temp, IntPtr box)
            => SafeExecution<int>(() => Native.NadTintTbox(temp, box));

        public static int NadTintTint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.NadTintTint(temp1, temp2));

        public static IntPtr TbigintTmaxTransfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TbigintTmaxTransfn(state, temp));

        public static IntPtr TbigintTmaxCombinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => Native.TbigintTmaxCombinefn(state1, state2));

        public static IntPtr TbigintTminTransfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TbigintTminTransfn(state, temp));

        public static IntPtr TbigintTminCombinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => Native.TbigintTminCombinefn(state1, state2));

        public static IntPtr TbigintTsumTransfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TbigintTsumTransfn(state, temp));

        public static IntPtr TbigintTsumCombinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => Native.TbigintTsumCombinefn(state1, state2));

        public static IntPtr TbigintWmaxTransfn(IntPtr state, IntPtr temp, IntPtr interv)
            => SafeExecution<IntPtr>(() => Native.TbigintWmaxTransfn(state, temp, interv));

        public static IntPtr TbigintWminTransfn(IntPtr state, IntPtr temp, IntPtr interv)
            => SafeExecution<IntPtr>(() => Native.TbigintWminTransfn(state, temp, interv));

        public static IntPtr TbigintWsumTransfn(IntPtr state, IntPtr temp, IntPtr interv)
            => SafeExecution<IntPtr>(() => Native.TbigintWsumTransfn(state, temp, interv));

        public static IntPtr TboolTandTransfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TboolTandTransfn(state, temp));

        public static IntPtr TboolTandCombinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => Native.TboolTandCombinefn(state1, state2));

        public static IntPtr TboolTorTransfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TboolTorTransfn(state, temp));

        public static IntPtr TboolTorCombinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => Native.TboolTorCombinefn(state1, state2));

        public static IntPtr TemporalExtentTransfn(IntPtr s, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TemporalExtentTransfn(s, temp));

        public static IntPtr TemporalTaggFinalfn(IntPtr state)
            => SafeExecution<IntPtr>(() => Native.TemporalTaggFinalfn(state));

        public static IntPtr TemporalTcountTransfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TemporalTcountTransfn(state, temp));

        public static IntPtr TemporalTcountCombinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => Native.TemporalTcountCombinefn(state1, state2));

        public static IntPtr TfloatTmaxTransfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TfloatTmaxTransfn(state, temp));

        public static IntPtr TfloatTmaxCombinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => Native.TfloatTmaxCombinefn(state1, state2));

        public static IntPtr TfloatTminTransfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TfloatTminTransfn(state, temp));

        public static IntPtr TfloatTminCombinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => Native.TfloatTminCombinefn(state1, state2));

        public static IntPtr TfloatTsumTransfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TfloatTsumTransfn(state, temp));

        public static IntPtr TfloatTsumCombinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => Native.TfloatTsumCombinefn(state1, state2));

        public static IntPtr TfloatWmaxTransfn(IntPtr state, IntPtr temp, IntPtr interv)
            => SafeExecution<IntPtr>(() => Native.TfloatWmaxTransfn(state, temp, interv));

        public static IntPtr TfloatWminTransfn(IntPtr state, IntPtr temp, IntPtr interv)
            => SafeExecution<IntPtr>(() => Native.TfloatWminTransfn(state, temp, interv));

        public static IntPtr TfloatWsumTransfn(IntPtr state, IntPtr temp, IntPtr interv)
            => SafeExecution<IntPtr>(() => Native.TfloatWsumTransfn(state, temp, interv));

        public static IntPtr TimestamptzTcountTransfn(IntPtr state, long t)
            => SafeExecution<IntPtr>(() => Native.TimestamptzTcountTransfn(state, t));

        public static IntPtr TintTmaxTransfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TintTmaxTransfn(state, temp));

        public static IntPtr TintTmaxCombinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => Native.TintTmaxCombinefn(state1, state2));

        public static IntPtr TintTminTransfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TintTminTransfn(state, temp));

        public static IntPtr TintTminCombinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => Native.TintTminCombinefn(state1, state2));

        public static IntPtr TintTsumTransfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TintTsumTransfn(state, temp));

        public static IntPtr TintTsumCombinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => Native.TintTsumCombinefn(state1, state2));

        public static IntPtr TintWmaxTransfn(IntPtr state, IntPtr temp, IntPtr interv)
            => SafeExecution<IntPtr>(() => Native.TintWmaxTransfn(state, temp, interv));

        public static IntPtr TintWminTransfn(IntPtr state, IntPtr temp, IntPtr interv)
            => SafeExecution<IntPtr>(() => Native.TintWminTransfn(state, temp, interv));

        public static IntPtr TintWsumTransfn(IntPtr state, IntPtr temp, IntPtr interv)
            => SafeExecution<IntPtr>(() => Native.TintWsumTransfn(state, temp, interv));

        public static IntPtr TnumberExtentTransfn(IntPtr box, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TnumberExtentTransfn(box, temp));

        public static IntPtr TnumberTavgFinalfn(IntPtr state)
            => SafeExecution<IntPtr>(() => Native.TnumberTavgFinalfn(state));

        public static IntPtr TnumberTavgTransfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TnumberTavgTransfn(state, temp));

        public static IntPtr TnumberTavgCombinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => Native.TnumberTavgCombinefn(state1, state2));

        public static IntPtr TnumberWavgTransfn(IntPtr state, IntPtr temp, IntPtr interv)
            => SafeExecution<IntPtr>(() => Native.TnumberWavgTransfn(state, temp, interv));

        public static IntPtr TstzsetTcountTransfn(IntPtr state, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TstzsetTcountTransfn(state, s));

        public static IntPtr TstzspanTcountTransfn(IntPtr state, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TstzspanTcountTransfn(state, s));

        public static IntPtr TstzspansetTcountTransfn(IntPtr state, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TstzspansetTcountTransfn(state, ss));

        public static IntPtr TemporalMergeTransfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TemporalMergeTransfn(state, temp));

        public static IntPtr TemporalMergeCombinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => Native.TemporalMergeCombinefn(state1, state2));

        public static IntPtr TtextTmaxTransfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TtextTmaxTransfn(state, temp));

        public static IntPtr TtextTmaxCombinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => Native.TtextTmaxCombinefn(state1, state2));

        public static IntPtr TtextTminTransfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TtextTminTransfn(state, temp));

        public static IntPtr TtextTminCombinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => Native.TtextTminCombinefn(state1, state2));

        public static IntPtr TemporalSimplifyDp(IntPtr temp, double dist, bool synchronized)
            => SafeExecution<IntPtr>(() => Native.TemporalSimplifyDp(temp, dist, synchronized));

        public static IntPtr TemporalSimplifyMaxDist(IntPtr temp, double dist, bool synchronized)
            => SafeExecution<IntPtr>(() => Native.TemporalSimplifyMaxDist(temp, dist, synchronized));

        public static IntPtr TemporalSimplifyMinDist(IntPtr temp, double dist)
            => SafeExecution<IntPtr>(() => Native.TemporalSimplifyMinDist(temp, dist));

        public static IntPtr TemporalSimplifyMinTdelta(IntPtr temp, IntPtr mint)
            => SafeExecution<IntPtr>(() => Native.TemporalSimplifyMinTdelta(temp, mint));

        public static IntPtr TemporalTprecision(IntPtr temp, IntPtr duration, long origin)
            => SafeExecution<IntPtr>(() => Native.TemporalTprecision(temp, duration, origin));

        public static IntPtr TemporalTsample(IntPtr temp, IntPtr duration, long origin, int interp)
            => SafeExecution<IntPtr>(() => Native.TemporalTsample(temp, duration, origin, interp));

        public static double TemporalDyntimewarpDistance(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => Native.TemporalDyntimewarpDistance(temp1, temp2));

        public static IntPtr[] TemporalDyntimewarpPath(IntPtr temp1, IntPtr temp2)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TemporalDyntimewarpPath(temp1, temp2, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 8); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static double TemporalFrechetDistance(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => Native.TemporalFrechetDistance(temp1, temp2));

        public static IntPtr[] TemporalFrechetPath(IntPtr temp1, IntPtr temp2)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TemporalFrechetPath(temp1, temp2, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 8); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static double TemporalHausdorffDistance(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => Native.TemporalHausdorffDistance(temp1, temp2));

        public static double TemporalAverageHausdorffDistance(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => Native.TemporalAverageHausdorffDistance(temp1, temp2));

        public static double TemporalLcssDistance(IntPtr temp1, IntPtr temp2, double epsilon)
            => SafeExecution<double>(() => Native.TemporalLcssDistance(temp1, temp2, epsilon));

        public static IntPtr TemporalExtKalmanFilter(IntPtr temp, double gate, double q, double variance, bool to_drop)
            => SafeExecution<IntPtr>(() => Native.TemporalExtKalmanFilter(temp, gate, q, variance, to_drop));

        public static IntPtr[] TemporalTimeBins(IntPtr temp, IntPtr duration, long origin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TemporalTimeBins(temp, duration, origin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 24); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static (IntPtr[], long[]) TemporalTimeSplit(IntPtr temp, IntPtr duration, long torigin)
        {
            IntPtr _out_bins = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => Native.TemporalTimeSplit(temp, duration, torigin, _out_bins, _count_count));
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

        public static IntPtr[] TfloatTimeBoxes(IntPtr temp, IntPtr duration, long torigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TfloatTimeBoxes(temp, duration, torigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 56); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TfloatValueBins(IntPtr temp, double vsize, double vorigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TfloatValueBins(temp, vsize, vorigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 24); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TfloatValueBoxes(IntPtr temp, double vsize, double vorigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TfloatValueBoxes(temp, vsize, vorigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 56); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static (IntPtr[], double[]) TfloatValueSplit(IntPtr temp, double size, double origin)
        {
            IntPtr _out_bins = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => Native.TfloatValueSplit(temp, size, origin, _out_bins, _count_count));
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

        public static IntPtr[] TfloatValueTimeBoxes(IntPtr temp, double vsize, IntPtr duration, double vorigin, long torigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TfloatValueTimeBoxes(temp, vsize, duration, vorigin, torigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 56); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static (IntPtr[], double[], long[]) TfloatValueTimeSplit(IntPtr temp, double vsize, IntPtr duration, double vorigin, long torigin)
        {
            IntPtr _out_value_bins = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _out_time_bins = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => Native.TfloatValueTimeSplit(temp, vsize, duration, vorigin, torigin, _out_value_bins, _out_time_bins, _count_count));
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

        public static IntPtr[] TfloatboxTimeTiles(IntPtr box, IntPtr duration, long torigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TfloatboxTimeTiles(box, duration, torigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 56); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TfloatboxValueTiles(IntPtr box, double vsize, double vorigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TfloatboxValueTiles(box, vsize, vorigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 56); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TfloatboxValueTimeTiles(IntPtr box, double vsize, IntPtr duration, double vorigin, long torigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TfloatboxValueTimeTiles(box, vsize, duration, vorigin, torigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 56); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TintTimeBoxes(IntPtr temp, IntPtr duration, long torigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TintTimeBoxes(temp, duration, torigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 56); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TintValueBins(IntPtr temp, int vsize, int vorigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TintValueBins(temp, vsize, vorigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 24); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TintValueBoxes(IntPtr temp, int vsize, int vorigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TintValueBoxes(temp, vsize, vorigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 56); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static (IntPtr[], int[]) TintValueSplit(IntPtr temp, int vsize, int vorigin)
        {
            IntPtr _out_bins = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => Native.TintValueSplit(temp, vsize, vorigin, _out_bins, _count_count));
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

        public static IntPtr[] TintValueTimeBoxes(IntPtr temp, int vsize, IntPtr duration, int vorigin, long torigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TintValueTimeBoxes(temp, vsize, duration, vorigin, torigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 56); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static (IntPtr[], int[], long[]) TintValueTimeSplit(IntPtr temp, int size, IntPtr duration, int vorigin, long torigin)
        {
            IntPtr _out_value_bins = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _out_time_bins = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => Native.TintValueTimeSplit(temp, size, duration, vorigin, torigin, _out_value_bins, _out_time_bins, _count_count));
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

        public static IntPtr[] TintboxTimeTiles(IntPtr box, IntPtr duration, long torigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TintboxTimeTiles(box, duration, torigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 56); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TintboxValueTiles(IntPtr box, int xsize, int xorigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TintboxValueTiles(box, xsize, xorigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 56); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TintboxValueTimeTiles(IntPtr box, int xsize, IntPtr duration, int xorigin, long torigin)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TintboxValueTimeTiles(box, xsize, duration, xorigin, torigin, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 56); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

    }
}
