#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Structures;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>meos_internal.h</c> declares.</summary>
    public static partial class Meos
    {
        public static IntPtr MeosArrayGetIntl(IntPtr array, int n)
            => SafeExecution<IntPtr>(() => Native.MeosArrayGetIntl(array, n));

        public static IntPtr PrngGetGenerationRng()
            => SafeExecution<IntPtr>(() => Native.PrngGetGenerationRng());

        public static IntPtr PrngGetAggregationRng()
            => SafeExecution<IntPtr>(() => Native.PrngGetAggregationRng());

        public static double MeosRandomDouble(IntPtr rng)
            => SafeExecution<double>(() => Native.MeosRandomDouble(rng));

        public static double MeosRandomExponential(IntPtr rng, double mean)
            => SafeExecution<double>(() => Native.MeosRandomExponential(rng, mean));

        public static uint MeosRandomBinomial20Half(IntPtr rng)
            => SafeExecution<uint>(() => Native.MeosRandomBinomial20Half(rng));

        public static bool BasetypeIn(string str, int type, bool end, IntPtr result)
            => SafeExecution<bool>(() => Native.BasetypeIn(str, type, end, result));

        public static ulong DatumCeil(ulong d)
            => SafeExecution<ulong>(() => Native.DatumCeil(d));

        public static ulong DatumDegrees(ulong d, ulong normalize)
            => SafeExecution<ulong>(() => Native.DatumDegrees(d, normalize));

        public static ulong DatumFloatRound(ulong value, ulong size)
            => SafeExecution<ulong>(() => Native.DatumFloatRound(value, size));

        public static ulong DatumFloor(ulong d)
            => SafeExecution<ulong>(() => Native.DatumFloor(d));

        public static uint DatumHash(ulong d, int basetype)
            => SafeExecution<uint>(() => Native.DatumHash(d, basetype));

        public static ulong DatumHashExtended(ulong d, int basetype, ulong seed)
            => SafeExecution<ulong>(() => Native.DatumHashExtended(d, basetype, seed));

        public static ulong DatumRadians(ulong d)
            => SafeExecution<ulong>(() => Native.DatumRadians(d));

        public static void FloatspanRoundSet(IntPtr s, int maxdd, IntPtr result)
            => SafeExecution(() => Native.FloatspanRoundSet(s, maxdd, result));

        public static IntPtr SetIn(string str, int settype)
            => SafeExecution<IntPtr>(() => Native.SetIn(str, settype));

        public static string SetOut(IntPtr s, int maxdd)
        {
            nuint _size = 0;
            IntPtr _p = SafeExecution<IntPtr>(() => Native.SetOut(s, maxdd, out _size));
            if (_p == IntPtr.Zero)
            {
                return null!;
            }

            try
            {
                return Marshal.PtrToStringUTF8(_p, (int)_size - 1);
            }
            finally
            {
                Marshal.FreeCoTaskMem(_p);
            }
        }

        public static IntPtr SpanIn(string str, int spantype)
            => SafeExecution<IntPtr>(() => Native.SpanIn(str, spantype));

        public static string SpanOut(IntPtr s, int maxdd)
        {
            nuint _size = 0;
            IntPtr _p = SafeExecution<IntPtr>(() => Native.SpanOut(s, maxdd, out _size));
            if (_p == IntPtr.Zero)
            {
                return null!;
            }

            try
            {
                return Marshal.PtrToStringUTF8(_p, (int)_size - 1);
            }
            finally
            {
                Marshal.FreeCoTaskMem(_p);
            }
        }

        public static IntPtr SpansetIn(string str, int spantype)
            => SafeExecution<IntPtr>(() => Native.SpansetIn(str, spantype));

        public static string SpansetOut(IntPtr ss, int maxdd)
        {
            nuint _size = 0;
            IntPtr _p = SafeExecution<IntPtr>(() => Native.SpansetOut(ss, maxdd, out _size));
            if (_p == IntPtr.Zero)
            {
                return null!;
            }

            try
            {
                return Marshal.PtrToStringUTF8(_p, (int)_size - 1);
            }
            finally
            {
                Marshal.FreeCoTaskMem(_p);
            }
        }

        public static IntPtr SetMake(IntPtr values, int count, int basetype, bool order)
            => SafeExecution<IntPtr>(() => Native.SetMake(values, count, basetype, order));

        public static IntPtr SetMakeExp(IntPtr values, int count, int maxcount, int basetype, bool order)
            => SafeExecution<IntPtr>(() => Native.SetMakeExp(values, count, maxcount, basetype, order));

        public static IntPtr SetMakeFree(IntPtr values, int count, int basetype, bool order)
            => SafeExecution<IntPtr>(() => Native.SetMakeFree(values, count, basetype, order));

        public static IntPtr SpanMake(ulong lower, ulong upper, bool lower_inc, bool upper_inc, int basetype)
            => SafeExecution<IntPtr>(() => Native.SpanMake(lower, upper, lower_inc, upper_inc, basetype));

        public static void SpanSet(ulong lower, ulong upper, bool lower_inc, bool upper_inc, int basetype, int spantype, IntPtr s)
            => SafeExecution(() => Native.SpanSet(lower, upper, lower_inc, upper_inc, basetype, spantype, s));

        public static IntPtr SpansetMakeExp(IntPtr spans, int count, int maxcount, bool normalize, bool order)
            => SafeExecution<IntPtr>(() => Native.SpansetMakeExp(spans, count, maxcount, normalize, order));

        public static IntPtr SpansetMakeFree(IntPtr spans, int count, bool normalize, bool order)
            => SafeExecution<IntPtr>(() => Native.SpansetMakeFree(spans, count, normalize, order));

        public static IntPtr SetSortkeyIntl(IntPtr s, IntPtr size)
            => SafeExecution<IntPtr>(() => Native.SetSortkeyIntl(s, size));

        public static IntPtr SpanSortkeyIntl(IntPtr s, IntPtr size)
            => SafeExecution<IntPtr>(() => Native.SpanSortkeyIntl(s, size));

        public static IntPtr SpansetSortkeyIntl(IntPtr ss, IntPtr size)
            => SafeExecution<IntPtr>(() => Native.SpansetSortkeyIntl(ss, size));

        public static IntPtr SetSpan(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.SetSpan(s));

        public static IntPtr SetSpanset(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.SetSpanset(s));

        public static void ValueSetSpan(ulong value, int basetype, IntPtr s)
            => SafeExecution(() => Native.ValueSetSpan(value, basetype, s));

        public static IntPtr ValueSet(ulong d, int basetype)
            => SafeExecution<IntPtr>(() => Native.ValueSet(d, basetype));

        public static IntPtr ValueSpan(ulong d, int basetype)
            => SafeExecution<IntPtr>(() => Native.ValueSpan(d, basetype));

        public static IntPtr ValueSpanset(ulong d, int basetype)
            => SafeExecution<IntPtr>(() => Native.ValueSpanset(d, basetype));

        public static ulong NumspanWidth(IntPtr s)
            => SafeExecution<ulong>(() => Native.NumspanWidth(s));

        public static ulong NumspansetWidth(IntPtr ss, bool boundspan)
            => SafeExecution<ulong>(() => Native.NumspansetWidth(ss, boundspan));

        public static ulong SetEndValue(IntPtr s)
            => SafeExecution<ulong>(() => Native.SetEndValue(s));

        public static void SetSetSubspan(IntPtr s, int minidx, int maxidx, IntPtr result)
            => SafeExecution(() => Native.SetSetSubspan(s, minidx, maxidx, result));

        public static void SetSetSpan(IntPtr s, IntPtr result)
            => SafeExecution(() => Native.SetSetSpan(s, result));

        public static ulong SetStartValue(IntPtr s)
            => SafeExecution<ulong>(() => Native.SetStartValue(s));

        public static bool SetValueN(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.SetValueN(s, n, result));

        public static IntPtr SetVals(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.SetVals(s));

        public static ulong[] SetValues(IntPtr s)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.SetValues(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                ulong[] _out = new ulong[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = (ulong) Marshal.ReadInt64(_p, _i * 8); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static ulong SpansetLower(IntPtr ss)
            => SafeExecution<ulong>(() => Native.SpansetLower(ss));

        public static IntPtr[] SpansetSps(IntPtr ss)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.SpansetSps(ss, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static ulong SpansetUpper(IntPtr ss)
            => SafeExecution<ulong>(() => Native.SpansetUpper(ss));

        public static void DatespanSetTstzspan(IntPtr s1, IntPtr s2)
            => SafeExecution(() => Native.DatespanSetTstzspan(s1, s2));

        public static void BigintspanSetFloatspan(IntPtr s1, IntPtr s2)
            => SafeExecution(() => Native.BigintspanSetFloatspan(s1, s2));

        public static void BigintspanSetIntspan(IntPtr s1, IntPtr s2)
            => SafeExecution(() => Native.BigintspanSetIntspan(s1, s2));

        public static void FloatspanSetBigintspan(IntPtr s1, IntPtr s2)
            => SafeExecution(() => Native.FloatspanSetBigintspan(s1, s2));

        public static void FloatspanSetIntspan(IntPtr s1, IntPtr s2)
            => SafeExecution(() => Native.FloatspanSetIntspan(s1, s2));

        public static void IntspanSetBigintspan(IntPtr s1, IntPtr s2)
            => SafeExecution(() => Native.IntspanSetBigintspan(s1, s2));

        public static void IntspanSetFloatspan(IntPtr s1, IntPtr s2)
            => SafeExecution(() => Native.IntspanSetFloatspan(s1, s2));

        public static IntPtr NumsetShiftScale(IntPtr s, ulong shift, ulong width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => Native.NumsetShiftScale(s, shift, width, hasshift, haswidth));

        public static IntPtr TstzsetShiftScaleIntl(IntPtr s, IntPtr shift, IntPtr duration)
            => SafeExecution<IntPtr>(() => Native.TstzsetShiftScaleIntl(s, shift, duration));

        public static IntPtr NumspanExpand(IntPtr s, ulong value)
            => SafeExecution<IntPtr>(() => Native.NumspanExpand(s, value));

        public static IntPtr NumspanShiftScale(IntPtr s, ulong shift, ulong width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => Native.NumspanShiftScale(s, shift, width, hasshift, haswidth));

        public static IntPtr TstzspanShiftScaleIntl(IntPtr s, IntPtr shift, IntPtr duration)
            => SafeExecution<IntPtr>(() => Native.TstzspanShiftScaleIntl(s, shift, duration));

        public static IntPtr NumspansetShiftScale(IntPtr ss, ulong shift, ulong width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => Native.NumspansetShiftScale(ss, shift, width, hasshift, haswidth));

        public static IntPtr TstzspansetShiftScaleIntl(IntPtr ss, IntPtr shift, IntPtr duration)
            => SafeExecution<IntPtr>(() => Native.TstzspansetShiftScaleIntl(ss, shift, duration));

        public static IntPtr SetCompact(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.SetCompact(s));

        public static void SpanExpand(IntPtr s1, IntPtr s2)
            => SafeExecution(() => Native.SpanExpand(s1, s2));

        public static IntPtr SuperUnionSpanSpan(IntPtr s1, IntPtr s2)
            => SafeExecution<IntPtr>(() => Native.SuperUnionSpanSpan(s1, s2));

        public static IntPtr SpansetCompact(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.SpansetCompact(ss));

        public static IntPtr TboxExpandValue(IntPtr box, ulong value, int basetyp)
            => SafeExecution<IntPtr>(() => Native.TboxExpandValue(box, value, basetyp));

        public static IntPtr TextcatTextsetTextCommon(IntPtr s, IntPtr txt, bool invert)
            => SafeExecution<IntPtr>(() => Native.TextcatTextsetTextCommon(s, txt, invert));

        public static void TstzspanSetDatespan(IntPtr s1, IntPtr s2)
            => SafeExecution(() => Native.TstzspanSetDatespan(s1, s2));

        public static bool AdjacentSpanValue(IntPtr s, ulong value)
            => SafeExecution<bool>(() => Native.AdjacentSpanValue(s, value));

        public static bool AdjacentSpansetValue(IntPtr ss, ulong value)
            => SafeExecution<bool>(() => Native.AdjacentSpansetValue(ss, value));

        public static bool AdjacentValueSpanset(ulong value, IntPtr ss)
            => SafeExecution<bool>(() => Native.AdjacentValueSpanset(value, ss));

        public static bool ContainedValueSet(ulong value, IntPtr s)
            => SafeExecution<bool>(() => Native.ContainedValueSet(value, s));

        public static bool ContainedValueSpan(ulong value, IntPtr s)
            => SafeExecution<bool>(() => Native.ContainedValueSpan(value, s));

        public static bool ContainedValueSpanset(ulong value, IntPtr ss)
            => SafeExecution<bool>(() => Native.ContainedValueSpanset(value, ss));

        public static bool ContainsSetValue(IntPtr s, ulong value)
            => SafeExecution<bool>(() => Native.ContainsSetValue(s, value));

        public static bool ContainsSpanValue(IntPtr s, ulong value)
            => SafeExecution<bool>(() => Native.ContainsSpanValue(s, value));

        public static bool ContainsSpansetValue(IntPtr ss, ulong value)
            => SafeExecution<bool>(() => Native.ContainsSpansetValue(ss, value));

        public static bool OvadjSpanSpan(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.OvadjSpanSpan(s1, s2));

        public static bool LeftSetValue(IntPtr s, ulong value)
            => SafeExecution<bool>(() => Native.LeftSetValue(s, value));

        public static bool LeftSpanValue(IntPtr s, ulong value)
            => SafeExecution<bool>(() => Native.LeftSpanValue(s, value));

        public static bool LeftSpansetValue(IntPtr ss, ulong value)
            => SafeExecution<bool>(() => Native.LeftSpansetValue(ss, value));

        public static bool LeftValueSet(ulong value, IntPtr s)
            => SafeExecution<bool>(() => Native.LeftValueSet(value, s));

        public static bool LeftValueSpan(ulong value, IntPtr s)
            => SafeExecution<bool>(() => Native.LeftValueSpan(value, s));

        public static bool LeftValueSpanset(ulong value, IntPtr ss)
            => SafeExecution<bool>(() => Native.LeftValueSpanset(value, ss));

        public static bool LfnadjSpanSpan(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.LfnadjSpanSpan(s1, s2));

        public static bool OverleftSetValue(IntPtr s, ulong value)
            => SafeExecution<bool>(() => Native.OverleftSetValue(s, value));

        public static bool OverleftSpanValue(IntPtr s, ulong value)
            => SafeExecution<bool>(() => Native.OverleftSpanValue(s, value));

        public static bool OverleftSpansetValue(IntPtr ss, ulong value)
            => SafeExecution<bool>(() => Native.OverleftSpansetValue(ss, value));

        public static bool OverleftValueSet(ulong value, IntPtr s)
            => SafeExecution<bool>(() => Native.OverleftValueSet(value, s));

        public static bool OverleftValueSpan(ulong value, IntPtr s)
            => SafeExecution<bool>(() => Native.OverleftValueSpan(value, s));

        public static bool OverleftValueSpanset(ulong value, IntPtr ss)
            => SafeExecution<bool>(() => Native.OverleftValueSpanset(value, ss));

        public static bool OverrightSetValue(IntPtr s, ulong value)
            => SafeExecution<bool>(() => Native.OverrightSetValue(s, value));

        public static bool OverrightSpanValue(IntPtr s, ulong value)
            => SafeExecution<bool>(() => Native.OverrightSpanValue(s, value));

        public static bool OverrightSpansetValue(IntPtr ss, ulong value)
            => SafeExecution<bool>(() => Native.OverrightSpansetValue(ss, value));

        public static bool OverrightValueSet(ulong value, IntPtr s)
            => SafeExecution<bool>(() => Native.OverrightValueSet(value, s));

        public static bool OverrightValueSpan(ulong value, IntPtr s)
            => SafeExecution<bool>(() => Native.OverrightValueSpan(value, s));

        public static bool OverrightValueSpanset(ulong value, IntPtr ss)
            => SafeExecution<bool>(() => Native.OverrightValueSpanset(value, ss));

        public static bool RightValueSet(ulong value, IntPtr s)
            => SafeExecution<bool>(() => Native.RightValueSet(value, s));

        public static bool RightSetValue(IntPtr s, ulong value)
            => SafeExecution<bool>(() => Native.RightSetValue(s, value));

        public static bool RightValueSpan(ulong value, IntPtr s)
            => SafeExecution<bool>(() => Native.RightValueSpan(value, s));

        public static bool RightValueSpanset(ulong value, IntPtr ss)
            => SafeExecution<bool>(() => Native.RightValueSpanset(value, ss));

        public static bool RightSpanValue(IntPtr s, ulong value)
            => SafeExecution<bool>(() => Native.RightSpanValue(s, value));

        public static bool RightSpansetValue(IntPtr ss, ulong value)
            => SafeExecution<bool>(() => Native.RightSpansetValue(ss, value));

        public static bool BboxType(int bboxtype)
            => SafeExecution<bool>(() => Native.BboxType(bboxtype));

        public static ulong BboxGetSize(int bboxtype)
            => SafeExecution<ulong>(() => Native.BboxGetSize(bboxtype));

        public static int BboxMaxDims(int bboxtype)
            => SafeExecution<int>(() => Native.BboxMaxDims(bboxtype));

        public static bool TemporalBboxEq(IntPtr box1, IntPtr box2, int temptype)
            => SafeExecution<bool>(() => Native.TemporalBboxEq(box1, box2, temptype));

        public static int TemporalBboxCmp(IntPtr box1, IntPtr box2, int temptype)
            => SafeExecution<int>(() => Native.TemporalBboxCmp(box1, box2, temptype));

        public static bool EnsureBboxTemporalCompatible(int bboxtype, IntPtr temp)
            => SafeExecution<bool>(() => Native.EnsureBboxTemporalCompatible(bboxtype, temp));

        public static bool EnsureSameIndexBboxtype(int bboxtype1, int bboxtype2)
            => SafeExecution<bool>(() => Native.EnsureSameIndexBboxtype(bboxtype1, bboxtype2));

        public static bool EnsureIndexJoinOp(int op)
            => SafeExecution<bool>(() => Native.EnsureIndexJoinOp(op));

        public static bool BboxSameStructure(int bboxtype, IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.BboxSameStructure(bboxtype, box1, box2));

        public static bool EnsureIndexOp(int bboxtype, int op)
            => SafeExecution<bool>(() => Native.EnsureIndexOp(bboxtype, op));

        public static bool IndexOpIsValid(int bboxtype, int op, IntPtr box, IntPtr query)
            => SafeExecution<bool>(() => Native.IndexOpIsValid(bboxtype, op, box, query));

        public static bool IndexOpApply(int bboxtype, int op, IntPtr box, IntPtr query)
            => SafeExecution<bool>(() => Native.IndexOpApply(bboxtype, op, box, query));

        public static void IndexQueryProject(int bboxtype, IntPtr query, IntPtr box, IntPtr result)
            => SafeExecution(() => Native.IndexQueryProject(bboxtype, query, box, result));

        public static bool IndexDistanceIsValid(int bboxtype, IntPtr box, IntPtr query)
            => SafeExecution<bool>(() => Native.IndexDistanceIsValid(bboxtype, box, query));

        public static double IndexDistanceApply(int bboxtype, IntPtr box, IntPtr query)
            => SafeExecution<double>(() => Native.IndexDistanceApply(bboxtype, box, query));

        public static bool EnsureIndexResult(IntPtr result)
            => SafeExecution<bool>(() => Native.EnsureIndexResult(result));

        public static IntPtr RtreeCreate(int bboxtype)
            => SafeExecution<IntPtr>(() => Native.RtreeCreate(bboxtype));

        public static IntPtr SptreeCreate(int bboxtype, int kind)
            => SafeExecution<IntPtr>(() => Native.SptreeCreate(bboxtype, kind));

        public static int RtreeSearchIntl(IntPtr rtree, int op, IntPtr query, IntPtr result)
            => SafeExecution<int>(() => Native.RtreeSearchIntl(rtree, op, query, result));

        public static int SptreeSearchIntl(IntPtr sptree, int op, IntPtr query, IntPtr result)
            => SafeExecution<int>(() => Native.SptreeSearchIntl(sptree, op, query, result));

        // GAP bbox_temporal_split_boxes: the catalog states this answers an array and
        //     states no element type for it — `void *` names neither the type to read an
        //     element as nor the width to step by

        public static bool SpanContains(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.SpanContains(s1, s2));

        public static bool SpanContained(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.SpanContained(s1, s2));

        public static bool SpanOverlaps(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.SpanOverlaps(s1, s2));

        public static bool SpanSame(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.SpanSame(s1, s2));

        public static bool SpanAdjacent(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.SpanAdjacent(s1, s2));

        public static bool SpanLeft(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.SpanLeft(s1, s2));

        public static bool SpanRight(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.SpanRight(s1, s2));

        public static bool SpanOverleft(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.SpanOverleft(s1, s2));

        public static bool SpanOverright(IntPtr s1, IntPtr s2)
            => SafeExecution<bool>(() => Native.SpanOverright(s1, s2));

        public static void BboxUnionSpanSpan(IntPtr s1, IntPtr s2, IntPtr result)
            => SafeExecution(() => Native.BboxUnionSpanSpan(s1, s2, result));

        public static bool InterSpanSpan(IntPtr s1, IntPtr s2, IntPtr result)
            => SafeExecution<bool>(() => Native.InterSpanSpan(s1, s2, result));

        public static IntPtr IntersectionSetValue(IntPtr s, ulong value)
            => SafeExecution<IntPtr>(() => Native.IntersectionSetValue(s, value));

        public static IntPtr IntersectionSpanValue(IntPtr s, ulong value)
            => SafeExecution<IntPtr>(() => Native.IntersectionSpanValue(s, value));

        public static IntPtr IntersectionSpansetValue(IntPtr ss, ulong value)
            => SafeExecution<IntPtr>(() => Native.IntersectionSpansetValue(ss, value));

        public static IntPtr IntersectionValueSet(ulong value, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.IntersectionValueSet(value, s));

        public static IntPtr IntersectionValueSpan(ulong value, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.IntersectionValueSpan(value, s));

        public static IntPtr IntersectionValueSpanset(ulong value, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.IntersectionValueSpanset(value, ss));

        public static int MiSpanSpan(IntPtr s1, IntPtr s2, IntPtr result)
            => SafeExecution<int>(() => Native.MiSpanSpan(s1, s2, result));

        public static IntPtr MinusSetValue(IntPtr s, ulong value)
            => SafeExecution<IntPtr>(() => Native.MinusSetValue(s, value));

        public static IntPtr MinusSpanValue(IntPtr s, ulong value)
            => SafeExecution<IntPtr>(() => Native.MinusSpanValue(s, value));

        public static IntPtr MinusSpansetValue(IntPtr ss, ulong value)
            => SafeExecution<IntPtr>(() => Native.MinusSpansetValue(ss, value));

        public static IntPtr MinusValueSet(ulong value, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.MinusValueSet(value, s));

        public static IntPtr MinusValueSpan(ulong value, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.MinusValueSpan(value, s));

        public static IntPtr MinusValueSpanset(ulong value, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.MinusValueSpanset(value, ss));

        public static IntPtr UnionSetValue(IntPtr s, ulong value)
            => SafeExecution<IntPtr>(() => Native.UnionSetValue(s, value));

        public static IntPtr UnionSpanValue(IntPtr s, ulong value)
            => SafeExecution<IntPtr>(() => Native.UnionSpanValue(s, value));

        public static IntPtr UnionSpansetValue(IntPtr ss, ulong value)
            => SafeExecution<IntPtr>(() => Native.UnionSpansetValue(ss, value));

        public static IntPtr UnionValueSet(ulong value, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.UnionValueSet(value, s));

        public static IntPtr UnionValueSpan(ulong value, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.UnionValueSpan(value, s));

        public static IntPtr UnionValueSpanset(ulong value, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.UnionValueSpanset(value, ss));

        public static ulong DistanceSetSet(IntPtr s1, IntPtr s2)
            => SafeExecution<ulong>(() => Native.DistanceSetSet(s1, s2));

        public static ulong DistanceSetValue(IntPtr s, ulong value)
            => SafeExecution<ulong>(() => Native.DistanceSetValue(s, value));

        public static ulong DistanceSpanSpan(IntPtr s1, IntPtr s2)
            => SafeExecution<ulong>(() => Native.DistanceSpanSpan(s1, s2));

        public static ulong DistanceSpanValue(IntPtr s, ulong value)
            => SafeExecution<ulong>(() => Native.DistanceSpanValue(s, value));

        public static ulong DistanceSpansetSpan(IntPtr ss, IntPtr s)
            => SafeExecution<ulong>(() => Native.DistanceSpansetSpan(ss, s));

        public static ulong DistanceSpansetSpanset(IntPtr ss1, IntPtr ss2)
            => SafeExecution<ulong>(() => Native.DistanceSpansetSpanset(ss1, ss2));

        public static ulong DistanceSpansetValue(IntPtr ss, ulong value)
            => SafeExecution<ulong>(() => Native.DistanceSpansetValue(ss, value));

        public static ulong DistanceValueValue(ulong l, ulong r, int basetype)
            => SafeExecution<ulong>(() => Native.DistanceValueValue(l, r, basetype));

        public static IntPtr SpanbaseExtentTransfn(IntPtr state, ulong value, int basetype)
            => SafeExecution<IntPtr>(() => Native.SpanbaseExtentTransfn(state, value, basetype));

        public static IntPtr ValueUnionTransfn(IntPtr state, ulong value, int basetype)
            => SafeExecution<IntPtr>(() => Native.ValueUnionTransfn(state, value, basetype));

        public static IntPtr NumberTstzspanToTbox(ulong d, int basetype, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.NumberTstzspanToTbox(d, basetype, s));

        public static IntPtr NumberTimestamptzToTbox(ulong d, int basetype, long t)
            => SafeExecution<IntPtr>(() => Native.NumberTimestamptzToTbox(d, basetype, t));

        public static void TboxSet(IntPtr s, IntPtr p, IntPtr box)
            => SafeExecution(() => Native.TboxSet(s, p, box));

        public static void FloatSetTbox(double d, IntPtr box)
            => SafeExecution(() => Native.FloatSetTbox(d, box));

        public static void IntSetTbox(int i, IntPtr box)
            => SafeExecution(() => Native.IntSetTbox(i, box));

        public static void NumberSetTbox(ulong d, int basetype, IntPtr box)
            => SafeExecution(() => Native.NumberSetTbox(d, basetype, box));

        public static IntPtr NumberTbox(ulong value, int basetype)
            => SafeExecution<IntPtr>(() => Native.NumberTbox(value, basetype));

        public static void NumsetSetTbox(IntPtr s, IntPtr box)
            => SafeExecution(() => Native.NumsetSetTbox(s, box));

        public static void NumspanSetTbox(IntPtr span, IntPtr box)
            => SafeExecution(() => Native.NumspanSetTbox(span, box));

        public static void TimestamptzSetTbox(long t, IntPtr box)
            => SafeExecution(() => Native.TimestamptzSetTbox(t, box));

        public static void TstzsetSetTbox(IntPtr s, IntPtr box)
            => SafeExecution(() => Native.TstzsetSetTbox(s, box));

        public static void TstzspanSetTbox(IntPtr s, IntPtr box)
            => SafeExecution(() => Native.TstzspanSetTbox(s, box));

        public static IntPtr TboxShiftScaleTimeIntl(IntPtr box, IntPtr shift, IntPtr duration)
            => SafeExecution<IntPtr>(() => Native.TboxShiftScaleTimeIntl(box, shift, duration));

        public static IntPtr TboxShiftScaleValue(IntPtr box, ulong shift, ulong width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => Native.TboxShiftScaleValue(box, shift, width, hasshift, haswidth));

        public static void TboxExpand(IntPtr box1, IntPtr box2)
            => SafeExecution(() => Native.TboxExpand(box1, box2));

        public static bool TboxContains(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.TboxContains(box1, box2));

        public static bool TboxContained(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.TboxContained(box1, box2));

        public static bool TboxOverlaps(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.TboxOverlaps(box1, box2));

        public static bool TboxSame(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.TboxSame(box1, box2));

        public static bool TboxAdjacent(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.TboxAdjacent(box1, box2));

        public static bool TboxLeft(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.TboxLeft(box1, box2));

        public static bool TboxRight(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.TboxRight(box1, box2));

        public static bool TboxOverleft(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.TboxOverleft(box1, box2));

        public static bool TboxOverright(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.TboxOverright(box1, box2));

        public static bool TboxBefore(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.TboxBefore(box1, box2));

        public static bool TboxAfter(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.TboxAfter(box1, box2));

        public static bool TboxOverbefore(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.TboxOverbefore(box1, box2));

        public static bool TboxOverafter(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.TboxOverafter(box1, box2));

        public static bool InterTboxTbox(IntPtr box1, IntPtr box2, IntPtr result)
            => SafeExecution<bool>(() => Native.InterTboxTbox(box1, box2, result));

        public static IntPtr TboxSortkeyIntl(IntPtr box, IntPtr size)
            => SafeExecution<IntPtr>(() => Native.TboxSortkeyIntl(box, size));

        public static IntPtr TboolinstFromMfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => Native.TboolinstFromMfjson(mfjson));

        public static IntPtr TboolinstIn(string str)
            => SafeExecution<IntPtr>(() => Native.TboolinstIn(str));

        public static IntPtr TboolseqFromMfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => Native.TboolseqFromMfjson(mfjson));

        public static IntPtr TboolseqIn(string str, int interp)
            => SafeExecution<IntPtr>(() => Native.TboolseqIn(str, interp));

        public static IntPtr TboolseqsetFromMfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => Native.TboolseqsetFromMfjson(mfjson));

        public static IntPtr TboolseqsetIn(string str)
            => SafeExecution<IntPtr>(() => Native.TboolseqsetIn(str));

        public static IntPtr TemporalIn(string str, int temptype)
            => SafeExecution<IntPtr>(() => Native.TemporalIn(str, temptype));

        public static string TemporalOut(IntPtr temp, int maxdd)
        {
            nuint _size = 0;
            IntPtr _p = SafeExecution<IntPtr>(() => Native.TemporalOut(temp, maxdd, out _size));
            if (_p == IntPtr.Zero)
            {
                return null!;
            }

            try
            {
                return Marshal.PtrToStringUTF8(_p, (int)_size - 1);
            }
            finally
            {
                Marshal.FreeCoTaskMem(_p);
            }
        }

        public static IntPtr TemparrOut(IntPtr temparr, int count, int maxdd)
            => SafeExecution<IntPtr>(() => Native.TemparrOut(temparr, count, maxdd));

        public static IntPtr TfloatinstFromMfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => Native.TfloatinstFromMfjson(mfjson));

        public static IntPtr TfloatinstIn(string str)
            => SafeExecution<IntPtr>(() => Native.TfloatinstIn(str));

        public static IntPtr TfloatseqFromMfjson(IntPtr mfjson, int interp)
            => SafeExecution<IntPtr>(() => Native.TfloatseqFromMfjson(mfjson, interp));

        public static IntPtr TfloatseqIn(string str, int interp)
            => SafeExecution<IntPtr>(() => Native.TfloatseqIn(str, interp));

        public static IntPtr TfloatseqsetFromMfjson(IntPtr mfjson, int interp)
            => SafeExecution<IntPtr>(() => Native.TfloatseqsetFromMfjson(mfjson, interp));

        public static IntPtr TfloatseqsetIn(string str)
            => SafeExecution<IntPtr>(() => Native.TfloatseqsetIn(str));

        public static IntPtr TinstantFromMfjson(IntPtr mfjson, bool spatial, int srid, int temptype)
            => SafeExecution<IntPtr>(() => Native.TinstantFromMfjson(mfjson, spatial, srid, temptype));

        public static IntPtr TinstantIn(string str, int temptype)
            => SafeExecution<IntPtr>(() => Native.TinstantIn(str, temptype));

        public static string TinstantOut(IntPtr inst, int maxdd)
        {
            nuint _size = 0;
            IntPtr _p = SafeExecution<IntPtr>(() => Native.TinstantOut(inst, maxdd, out _size));
            if (_p == IntPtr.Zero)
            {
                return null!;
            }

            try
            {
                return Marshal.PtrToStringUTF8(_p, (int)_size - 1);
            }
            finally
            {
                Marshal.FreeCoTaskMem(_p);
            }
        }

        public static IntPtr TbigintinstFromMfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => Native.TbigintinstFromMfjson(mfjson));

        public static IntPtr TbigintinstIn(string str)
            => SafeExecution<IntPtr>(() => Native.TbigintinstIn(str));

        public static IntPtr TbigintseqFromMfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => Native.TbigintseqFromMfjson(mfjson));

        public static IntPtr TbigintseqIn(string str, int interp)
            => SafeExecution<IntPtr>(() => Native.TbigintseqIn(str, interp));

        public static IntPtr TbigintseqsetFromMfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => Native.TbigintseqsetFromMfjson(mfjson));

        public static IntPtr TbigintseqsetIn(string str)
            => SafeExecution<IntPtr>(() => Native.TbigintseqsetIn(str));

        public static IntPtr TintinstFromMfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => Native.TintinstFromMfjson(mfjson));

        public static IntPtr TintinstIn(string str)
            => SafeExecution<IntPtr>(() => Native.TintinstIn(str));

        public static IntPtr TintseqFromMfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => Native.TintseqFromMfjson(mfjson));

        public static IntPtr TintseqIn(string str, int interp)
            => SafeExecution<IntPtr>(() => Native.TintseqIn(str, interp));

        public static IntPtr TintseqsetFromMfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => Native.TintseqsetFromMfjson(mfjson));

        public static IntPtr TintseqsetIn(string str)
            => SafeExecution<IntPtr>(() => Native.TintseqsetIn(str));

        public static IntPtr TsequenceFromMfjson(IntPtr mfjson, bool spatial, int srid, int temptype, int interp)
            => SafeExecution<IntPtr>(() => Native.TsequenceFromMfjson(mfjson, spatial, srid, temptype, interp));

        public static IntPtr TsequenceIn(string str, int temptype, int interp)
            => SafeExecution<IntPtr>(() => Native.TsequenceIn(str, temptype, interp));

        public static string TsequenceOut(IntPtr seq, int maxdd)
        {
            nuint _size = 0;
            IntPtr _p = SafeExecution<IntPtr>(() => Native.TsequenceOut(seq, maxdd, out _size));
            if (_p == IntPtr.Zero)
            {
                return null!;
            }

            try
            {
                return Marshal.PtrToStringUTF8(_p, (int)_size - 1);
            }
            finally
            {
                Marshal.FreeCoTaskMem(_p);
            }
        }

        public static IntPtr TsequencesetFromMfjson(IntPtr mfjson, bool spatial, int srid, int temptype, int interp)
            => SafeExecution<IntPtr>(() => Native.TsequencesetFromMfjson(mfjson, spatial, srid, temptype, interp));

        public static IntPtr TsequencesetIn(string str, int temptype, int interp)
            => SafeExecution<IntPtr>(() => Native.TsequencesetIn(str, temptype, interp));

        public static string TsequencesetOut(IntPtr ss, int maxdd)
        {
            nuint _size = 0;
            IntPtr _p = SafeExecution<IntPtr>(() => Native.TsequencesetOut(ss, maxdd, out _size));
            if (_p == IntPtr.Zero)
            {
                return null!;
            }

            try
            {
                return Marshal.PtrToStringUTF8(_p, (int)_size - 1);
            }
            finally
            {
                Marshal.FreeCoTaskMem(_p);
            }
        }

        public static IntPtr TtextinstFromMfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => Native.TtextinstFromMfjson(mfjson));

        public static IntPtr TtextinstIn(string str)
            => SafeExecution<IntPtr>(() => Native.TtextinstIn(str));

        public static IntPtr TtextseqFromMfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => Native.TtextseqFromMfjson(mfjson));

        public static IntPtr TtextseqIn(string str, int interp)
            => SafeExecution<IntPtr>(() => Native.TtextseqIn(str, interp));

        public static IntPtr TtextseqsetFromMfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => Native.TtextseqsetFromMfjson(mfjson));

        public static IntPtr TtextseqsetIn(string str)
            => SafeExecution<IntPtr>(() => Native.TtextseqsetIn(str));

        public static IntPtr TjsonbinstFromMfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => Native.TjsonbinstFromMfjson(mfjson));

        public static IntPtr TjsonbseqFromMfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => Native.TjsonbseqFromMfjson(mfjson));

        public static IntPtr TjsonbseqsetFromMfjson(IntPtr mfjson)
            => SafeExecution<IntPtr>(() => Native.TjsonbseqsetFromMfjson(mfjson));

        public static IntPtr TemporalFromMfjson(string mfjson, int temptype)
            => SafeExecution<IntPtr>(() => Native.TemporalFromMfjson(mfjson, temptype));

        public static IntPtr TemporalFromBaseTemp(ulong value, int temptype, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TemporalFromBaseTemp(value, temptype, temp));

        public static IntPtr TinstantCopy(IntPtr inst)
            => SafeExecution<IntPtr>(() => Native.TinstantCopy(inst));

        public static IntPtr TinstantMake(ulong value, int temptype, long t)
            => SafeExecution<IntPtr>(() => Native.TinstantMake(value, temptype, t));

        public static IntPtr TinstantMakeFree(ulong value, int temptype, long t)
            => SafeExecution<IntPtr>(() => Native.TinstantMakeFree(value, temptype, t));

        public static IntPtr TsequenceCopy(IntPtr seq)
            => SafeExecution<IntPtr>(() => Native.TsequenceCopy(seq));

        public static IntPtr TsequenceDerivative(IntPtr seq, bool spheroid)
            => SafeExecution<IntPtr>(() => Native.TsequenceDerivative(seq, spheroid));

        public static IntPtr TsequenceFromBaseTemp(ulong value, int temptype, IntPtr seq)
            => SafeExecution<IntPtr>(() => Native.TsequenceFromBaseTemp(value, temptype, seq));

        public static IntPtr TsequenceFromBaseTstzset(ulong value, int temptype, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TsequenceFromBaseTstzset(value, temptype, s));

        public static IntPtr TsequenceFromBaseTstzspan(ulong value, int temptype, IntPtr s, int interp)
            => SafeExecution<IntPtr>(() => Native.TsequenceFromBaseTstzspan(value, temptype, s, interp));

        public static IntPtr TsequenceMakeExp(IntPtr instants, int count, int maxcount, bool lower_inc, bool upper_inc, int interp, bool normalize)
            => SafeExecution<IntPtr>(() => Native.TsequenceMakeExp(instants, count, maxcount, lower_inc, upper_inc, interp, normalize));

        public static IntPtr TsequenceMakeFree(IntPtr instants, int count, bool lower_inc, bool upper_inc, int interp, bool normalize)
            => SafeExecution<IntPtr>(() => Native.TsequenceMakeFree(instants, count, lower_inc, upper_inc, interp, normalize));

        public static IntPtr TsequencesetCopy(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TsequencesetCopy(ss));

        public static IntPtr TsequencesetDerivative(IntPtr ss, bool spheroid)
            => SafeExecution<IntPtr>(() => Native.TsequencesetDerivative(ss, spheroid));

        public static IntPtr TseqsetarrToTseqset(IntPtr seqsets, int count, int totalseqs)
            => SafeExecution<IntPtr>(() => Native.TseqsetarrToTseqset(seqsets, count, totalseqs));

        public static IntPtr TsequencesetFromBaseTemp(ulong value, int temptype, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TsequencesetFromBaseTemp(value, temptype, ss));

        public static IntPtr TsequencesetFromBaseTstzspanset(ulong value, int temptype, IntPtr ss, int interp)
            => SafeExecution<IntPtr>(() => Native.TsequencesetFromBaseTstzspanset(value, temptype, ss, interp));

        public static IntPtr TsequencesetMakeExp(IntPtr sequences, int count, int maxcount, bool normalize)
            => SafeExecution<IntPtr>(() => Native.TsequencesetMakeExp(sequences, count, maxcount, normalize));

        public static IntPtr TsequencesetMakeFree(IntPtr sequences, int count, bool normalize)
            => SafeExecution<IntPtr>(() => Native.TsequencesetMakeFree(sequences, count, normalize));

        public static void TemporalSetTstzspan(IntPtr temp, IntPtr s)
            => SafeExecution(() => Native.TemporalSetTstzspan(temp, s));

        public static void TinstantSetTstzspan(IntPtr inst, IntPtr s)
            => SafeExecution(() => Native.TinstantSetTstzspan(inst, s));

        public static void TnumberSetTbox(IntPtr temp, IntPtr box)
            => SafeExecution(() => Native.TnumberSetTbox(temp, box));

        public static void TnumberinstSetTbox(IntPtr inst, IntPtr box)
            => SafeExecution(() => Native.TnumberinstSetTbox(inst, box));

        public static void TnumberseqSetTbox(IntPtr seq, IntPtr box)
            => SafeExecution(() => Native.TnumberseqSetTbox(seq, box));

        public static void TnumberseqsetSetTbox(IntPtr ss, IntPtr box)
            => SafeExecution(() => Native.TnumberseqsetSetTbox(ss, box));

        public static void TsequenceSetTstzspan(IntPtr seq, IntPtr s)
            => SafeExecution(() => Native.TsequenceSetTstzspan(seq, s));

        public static void TsequencesetSetTstzspan(IntPtr ss, IntPtr s)
            => SafeExecution(() => Native.TsequencesetSetTstzspan(ss, s));

        public static IntPtr TemporalEndInst(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TemporalEndInst(temp));

        public static ulong TemporalEndValue(IntPtr temp)
            => SafeExecution<ulong>(() => Native.TemporalEndValue(temp));

        public static IntPtr TemporalInstN(IntPtr temp, int n)
            => SafeExecution<IntPtr>(() => Native.TemporalInstN(temp, n));

        public static IntPtr[] TemporalInstsP(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TemporalInstsP(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr TemporalMaxInstP(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TemporalMaxInstP(temp));

        public static ulong TemporalMaxValue(IntPtr temp)
            => SafeExecution<ulong>(() => Native.TemporalMaxValue(temp));

        public static IntPtr TemporalMinInstP(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TemporalMinInstP(temp));

        public static ulong TemporalMinValue(IntPtr temp)
            => SafeExecution<ulong>(() => Native.TemporalMinValue(temp));

        public static IntPtr[] TemporalSequencesP(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TemporalSequencesP(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static void TemporalSetBbox(IntPtr temp, IntPtr box)
            => SafeExecution(() => Native.TemporalSetBbox(temp, box));

        public static IntPtr TemporalStartInst(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TemporalStartInst(temp));

        public static ulong TemporalStartValue(IntPtr temp)
            => SafeExecution<ulong>(() => Native.TemporalStartValue(temp));

        public static ulong[] TemporalValuesP(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TemporalValuesP(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                ulong[] _out = new ulong[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = (ulong) Marshal.ReadInt64(_p, _i * 8); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool TemporalValueN(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.TemporalValueN(temp, n, result));

        public static ulong[] TemporalValues(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TemporalValues(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                ulong[] _out = new ulong[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = (ulong) Marshal.ReadInt64(_p, _i * 8); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static uint TinstantHash(IntPtr inst)
            => SafeExecution<uint>(() => Native.TinstantHash(inst));

        public static ulong TinstantHashExtended(IntPtr inst, ulong seed)
            => SafeExecution<ulong>(() => Native.TinstantHashExtended(inst, seed));

        public static IntPtr[] TinstantInsts(IntPtr inst)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TinstantInsts(inst, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static void TinstantSetBbox(IntPtr inst, IntPtr box)
            => SafeExecution(() => Native.TinstantSetBbox(inst, box));

        public static IntPtr TinstantTime(IntPtr inst)
            => SafeExecution<IntPtr>(() => Native.TinstantTime(inst));

        public static long[] TinstantTimestamps(IntPtr inst)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TinstantTimestamps(inst, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                long[] _out = new long[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static ulong TinstantValueP(IntPtr inst)
            => SafeExecution<ulong>(() => Native.TinstantValueP(inst));

        public static ulong TinstantValue(IntPtr inst)
            => SafeExecution<ulong>(() => Native.TinstantValue(inst));

        public static bool TinstantValueAtTimestamptz(IntPtr inst, long t, IntPtr result)
            => SafeExecution<bool>(() => Native.TinstantValueAtTimestamptz(inst, t, result));

        public static ulong[] TinstantValuesP(IntPtr inst)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TinstantValuesP(inst, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                ulong[] _out = new ulong[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = (ulong) Marshal.ReadInt64(_p, _i * 8); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static void TnumberSetSpan(IntPtr temp, IntPtr s)
            => SafeExecution(() => Native.TnumberSetSpan(temp, s));

        public static IntPtr TnumberinstValuespans(IntPtr inst)
            => SafeExecution<IntPtr>(() => Native.TnumberinstValuespans(inst));

        public static double TnumberseqAvgVal(IntPtr seq)
            => SafeExecution<double>(() => Native.TnumberseqAvgVal(seq));

        public static IntPtr TnumberseqValuespans(IntPtr seq)
            => SafeExecution<IntPtr>(() => Native.TnumberseqValuespans(seq));

        public static double TnumberseqsetAvgVal(IntPtr ss)
            => SafeExecution<double>(() => Native.TnumberseqsetAvgVal(ss));

        public static IntPtr TnumberseqsetValuespans(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TnumberseqsetValuespans(ss));

        public static IntPtr TsequenceDuration(IntPtr seq)
            => SafeExecution<IntPtr>(() => Native.TsequenceDuration(seq));

        public static long TsequenceEndTimestamptz(IntPtr seq)
            => SafeExecution<long>(() => Native.TsequenceEndTimestamptz(seq));

        public static uint TsequenceHash(IntPtr seq)
            => SafeExecution<uint>(() => Native.TsequenceHash(seq));

        public static ulong TsequenceHashExtended(IntPtr seq, ulong seed)
            => SafeExecution<ulong>(() => Native.TsequenceHashExtended(seq, seed));

        public static IntPtr[] TsequenceInstsP(IntPtr seq)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TsequenceInstsP(seq, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr TsequenceMaxInstP(IntPtr seq)
            => SafeExecution<IntPtr>(() => Native.TsequenceMaxInstP(seq));

        public static ulong TsequenceMaxVal(IntPtr seq)
            => SafeExecution<ulong>(() => Native.TsequenceMaxVal(seq));

        public static IntPtr TsequenceMinInstP(IntPtr seq)
            => SafeExecution<IntPtr>(() => Native.TsequenceMinInstP(seq));

        public static ulong TsequenceMinVal(IntPtr seq)
            => SafeExecution<ulong>(() => Native.TsequenceMinVal(seq));

        public static IntPtr[] TsequenceSegments(IntPtr seq)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TsequenceSegments(seq, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TsequenceSeqs(IntPtr seq)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TsequenceSeqs(seq, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static long TsequenceStartTimestamptz(IntPtr seq)
            => SafeExecution<long>(() => Native.TsequenceStartTimestamptz(seq));

        public static IntPtr TsequenceTime(IntPtr seq)
            => SafeExecution<IntPtr>(() => Native.TsequenceTime(seq));

        public static long[] TsequenceTimestamps(IntPtr seq)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TsequenceTimestamps(seq, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                long[] _out = new long[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool TsequenceValueAtTimestamptz(IntPtr seq, long t, bool strict, IntPtr result)
            => SafeExecution<bool>(() => Native.TsequenceValueAtTimestamptz(seq, t, strict, result));

        public static ulong[] TsequenceValuesP(IntPtr seq)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TsequenceValuesP(seq, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                ulong[] _out = new ulong[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = (ulong) Marshal.ReadInt64(_p, _i * 8); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr TsequencesetDuration(IntPtr ss, bool boundspan)
            => SafeExecution<IntPtr>(() => Native.TsequencesetDuration(ss, boundspan));

        public static long TsequencesetEndTimestamptz(IntPtr ss)
            => SafeExecution<long>(() => Native.TsequencesetEndTimestamptz(ss));

        public static uint TsequencesetHash(IntPtr ss)
            => SafeExecution<uint>(() => Native.TsequencesetHash(ss));

        public static ulong TsequencesetHashExtended(IntPtr ss, ulong seed)
            => SafeExecution<ulong>(() => Native.TsequencesetHashExtended(ss, seed));

        public static IntPtr TsequencesetInstN(IntPtr ss, int n)
            => SafeExecution<IntPtr>(() => Native.TsequencesetInstN(ss, n));

        public static IntPtr[] TsequencesetInstsP(IntPtr ss)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TsequencesetInstsP(ss, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr TsequencesetMaxInstP(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TsequencesetMaxInstP(ss));

        public static ulong TsequencesetMaxVal(IntPtr ss)
            => SafeExecution<ulong>(() => Native.TsequencesetMaxVal(ss));

        public static IntPtr TsequencesetMinInstP(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TsequencesetMinInstP(ss));

        public static ulong TsequencesetMinVal(IntPtr ss)
            => SafeExecution<ulong>(() => Native.TsequencesetMinVal(ss));

        public static int TsequencesetNumInstants(IntPtr ss)
            => SafeExecution<int>(() => Native.TsequencesetNumInstants(ss));

        public static int TsequencesetNumTimestamps(IntPtr ss)
            => SafeExecution<int>(() => Native.TsequencesetNumTimestamps(ss));

        public static IntPtr[] TsequencesetSegments(IntPtr ss)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TsequencesetSegments(ss, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr TsequencesetSequencesP(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TsequencesetSequencesP(ss));

        public static long TsequencesetStartTimestamptz(IntPtr ss)
            => SafeExecution<long>(() => Native.TsequencesetStartTimestamptz(ss));

        public static IntPtr TsequencesetTime(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TsequencesetTime(ss));

        public static bool TsequencesetTimestamptzN(IntPtr ss, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.TsequencesetTimestamptzN(ss, n, result));

        public static long[] TsequencesetTimestamps(IntPtr ss)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TsequencesetTimestamps(ss, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                long[] _out = new long[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool TsequencesetValueAtTimestamptz(IntPtr ss, long t, bool strict, IntPtr result)
            => SafeExecution<bool>(() => Native.TsequencesetValueAtTimestamptz(ss, t, strict, result));

        public static bool TsequencesetValueN(IntPtr ss, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.TsequencesetValueN(ss, n, result));

        public static bool TsequencesetValueNP(IntPtr ss, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.TsequencesetValueNP(ss, n, result));

        public static ulong[] TsequencesetValuesP(IntPtr ss)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TsequencesetValuesP(ss, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                ulong[] _out = new ulong[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = (ulong) Marshal.ReadInt64(_p, _i * 8); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static void TemporalRestart(IntPtr temp, int count)
            => SafeExecution(() => Native.TemporalRestart(temp, count));

        public static IntPtr TemporalTsequence(IntPtr temp, int interp)
            => SafeExecution<IntPtr>(() => Native.TemporalTsequence(temp, interp));

        public static IntPtr TemporalTsequenceset(IntPtr temp, int interp)
            => SafeExecution<IntPtr>(() => Native.TemporalTsequenceset(temp, interp));

        public static (IntPtr[], ulong[]) TemporalUnnest(IntPtr temp)
        {
            IntPtr _out_values = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => Native.TemporalUnnest(temp, _out_values, _count_count));
                int _n = Marshal.ReadInt32(_count_count);
                IntPtr[] _resultArr = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _resultArr[_i] = Marshal.ReadIntPtr(_resultPtr, _i * IntPtr.Size); }
                IntPtr __out_values_arr = Marshal.ReadIntPtr(_out_values);
                ulong[] __out_values_out = new ulong[_n];
                for (int _i = 0; _i < _n; _i++)
                { __out_values_out[_i] = (ulong) Marshal.ReadInt64(__out_values_arr, _i * 8); }
                return (_resultArr, __out_values_out);
            }
            finally
            {
            Marshal.FreeHGlobal(_out_values);
            Marshal.FreeHGlobal(_count_count);
            }
        }

        public static IntPtr TinstantShiftTime(IntPtr inst, IntPtr interv)
            => SafeExecution<IntPtr>(() => Native.TinstantShiftTime(inst, interv));

        public static IntPtr TinstantAsTsequence(IntPtr inst, int interp)
            => SafeExecution<IntPtr>(() => Native.TinstantAsTsequence(inst, interp));

        public static IntPtr TinstantToTsequenceFree(IntPtr inst, int interp)
            => SafeExecution<IntPtr>(() => Native.TinstantToTsequenceFree(inst, interp));

        public static IntPtr TinstantAsTsequenceset(IntPtr inst, int interp)
            => SafeExecution<IntPtr>(() => Native.TinstantAsTsequenceset(inst, interp));

        public static IntPtr TemporalShiftScaleTimeIntl(IntPtr temp, IntPtr shift, IntPtr duration)
            => SafeExecution<IntPtr>(() => Native.TemporalShiftScaleTimeIntl(temp, shift, duration));

        public static IntPtr TnumberShiftScaleValue(IntPtr temp, ulong shift, ulong width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => Native.TnumberShiftScaleValue(temp, shift, width, hasshift, haswidth));

        public static IntPtr TnumberinstShiftValue(IntPtr inst, ulong shift)
            => SafeExecution<IntPtr>(() => Native.TnumberinstShiftValue(inst, shift));

        public static IntPtr TnumberseqShiftScaleValue(IntPtr seq, ulong shift, ulong width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => Native.TnumberseqShiftScaleValue(seq, shift, width, hasshift, haswidth));

        public static IntPtr TnumberseqsetShiftScaleValue(IntPtr ss, ulong start, ulong width, bool hasshift, bool haswidth)
            => SafeExecution<IntPtr>(() => Native.TnumberseqsetShiftScaleValue(ss, start, width, hasshift, haswidth));

        public static void TsequenceRestart(IntPtr seq, int count)
            => SafeExecution(() => Native.TsequenceRestart(seq, count));

        public static IntPtr TsequenceSetInterp(IntPtr seq, int interp)
            => SafeExecution<IntPtr>(() => Native.TsequenceSetInterp(seq, interp));

        public static IntPtr TsequenceShiftScaleTime(IntPtr seq, IntPtr shift, IntPtr duration)
            => SafeExecution<IntPtr>(() => Native.TsequenceShiftScaleTime(seq, shift, duration));

        public static IntPtr TsequenceSubseq(IntPtr seq, int from, int to, bool lower_inc, bool upper_inc)
            => SafeExecution<IntPtr>(() => Native.TsequenceSubseq(seq, from, to, lower_inc, upper_inc));

        public static IntPtr TsequenceAsTinstant(IntPtr seq)
            => SafeExecution<IntPtr>(() => Native.TsequenceAsTinstant(seq));

        public static IntPtr TsequenceAsTsequenceset(IntPtr seq)
            => SafeExecution<IntPtr>(() => Native.TsequenceAsTsequenceset(seq));

        public static IntPtr TsequenceToTsequencesetFree(IntPtr seq)
            => SafeExecution<IntPtr>(() => Native.TsequenceToTsequencesetFree(seq));

        public static IntPtr TsequenceToTsequencesetInterp(IntPtr seq, int interp)
            => SafeExecution<IntPtr>(() => Native.TsequenceToTsequencesetInterp(seq, interp));

        public static void TsequencesetRestart(IntPtr ss, int count)
            => SafeExecution(() => Native.TsequencesetRestart(ss, count));

        public static IntPtr TsequencesetSetInterp(IntPtr ss, int interp)
            => SafeExecution<IntPtr>(() => Native.TsequencesetSetInterp(ss, interp));

        public static IntPtr TsequencesetShiftScaleTime(IntPtr ss, IntPtr start, IntPtr duration)
            => SafeExecution<IntPtr>(() => Native.TsequencesetShiftScaleTime(ss, start, duration));

        public static IntPtr TsequencesetToDiscrete(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TsequencesetToDiscrete(ss));

        public static IntPtr TsequencesetToLinear(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TsequencesetToLinear(ss));

        public static IntPtr TsequencesetToStep(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TsequencesetToStep(ss));

        public static IntPtr TsequencesetAsTinstant(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TsequencesetAsTinstant(ss));

        public static IntPtr TsequencesetAsTsequence(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TsequencesetAsTsequence(ss));

        public static IntPtr TinstantMerge(IntPtr inst1, IntPtr inst2)
            => SafeExecution<IntPtr>(() => Native.TinstantMerge(inst1, inst2));

        public static IntPtr TinstantMergeArray(IntPtr instants, int count)
            => SafeExecution<IntPtr>(() => Native.TinstantMergeArray(instants, count));

        public static IntPtr TsequenceAppendTinstant(IntPtr seq, IntPtr inst, double maxdist, IntPtr maxt, bool expand)
            => SafeExecution<IntPtr>(() => Native.TsequenceAppendTinstant(seq, inst, maxdist, maxt, expand));

        public static IntPtr TsequenceAppendTsequence(IntPtr seq1, IntPtr seq2, bool expand)
            => SafeExecution<IntPtr>(() => Native.TsequenceAppendTsequence(seq1, seq2, expand));

        public static IntPtr TsequenceDeleteTimestamptz(IntPtr seq, long t, bool connect)
            => SafeExecution<IntPtr>(() => Native.TsequenceDeleteTimestamptz(seq, t, connect));

        public static IntPtr TsequenceDeleteTstzset(IntPtr seq, IntPtr s, bool connect)
            => SafeExecution<IntPtr>(() => Native.TsequenceDeleteTstzset(seq, s, connect));

        public static IntPtr TsequenceDeleteTstzspan(IntPtr seq, IntPtr s, bool connect)
            => SafeExecution<IntPtr>(() => Native.TsequenceDeleteTstzspan(seq, s, connect));

        public static IntPtr TsequenceDeleteTstzspanset(IntPtr seq, IntPtr ss, bool connect)
            => SafeExecution<IntPtr>(() => Native.TsequenceDeleteTstzspanset(seq, ss, connect));

        public static IntPtr TsequenceInsert(IntPtr seq1, IntPtr seq2, bool connect)
            => SafeExecution<IntPtr>(() => Native.TsequenceInsert(seq1, seq2, connect));

        public static IntPtr TsequenceMerge(IntPtr seq1, IntPtr seq2)
            => SafeExecution<IntPtr>(() => Native.TsequenceMerge(seq1, seq2));

        public static IntPtr TsequenceMergeArray(IntPtr sequences, int count)
            => SafeExecution<IntPtr>(() => Native.TsequenceMergeArray(sequences, count));

        public static IntPtr TsequencesetAppendTinstant(IntPtr ss, IntPtr inst, double maxdist, IntPtr maxt, bool expand)
            => SafeExecution<IntPtr>(() => Native.TsequencesetAppendTinstant(ss, inst, maxdist, maxt, expand));

        public static IntPtr TsequencesetAppendTsequence(IntPtr ss, IntPtr seq, bool expand)
            => SafeExecution<IntPtr>(() => Native.TsequencesetAppendTsequence(ss, seq, expand));

        public static IntPtr TsequencesetDeleteTimestamptz(IntPtr ss, long t)
            => SafeExecution<IntPtr>(() => Native.TsequencesetDeleteTimestamptz(ss, t));

        public static IntPtr TsequencesetDeleteTstzset(IntPtr ss, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TsequencesetDeleteTstzset(ss, s));

        public static IntPtr TsequencesetDeleteTstzspan(IntPtr ss, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TsequencesetDeleteTstzspan(ss, s));

        public static IntPtr TsequencesetDeleteTstzspanset(IntPtr ss, IntPtr ps)
            => SafeExecution<IntPtr>(() => Native.TsequencesetDeleteTstzspanset(ss, ps));

        public static IntPtr TsequencesetInsert(IntPtr ss1, IntPtr ss2)
            => SafeExecution<IntPtr>(() => Native.TsequencesetInsert(ss1, ss2));

        public static IntPtr TsequencesetMerge(IntPtr ss1, IntPtr ss2)
            => SafeExecution<IntPtr>(() => Native.TsequencesetMerge(ss1, ss2));

        public static IntPtr TsequencesetMergeArray(IntPtr seqsets, int count)
            => SafeExecution<IntPtr>(() => Native.TsequencesetMergeArray(seqsets, count));

        public static void TsequenceExpandBbox(IntPtr seq, IntPtr inst)
            => SafeExecution(() => Native.TsequenceExpandBbox(seq, inst));

        public static void TsequenceSetBbox(IntPtr seq, IntPtr box)
            => SafeExecution(() => Native.TsequenceSetBbox(seq, box));

        public static void TsequencesetExpandBbox(IntPtr ss, IntPtr seq)
            => SafeExecution(() => Native.TsequencesetExpandBbox(ss, seq));

        public static void TsequencesetSetBbox(IntPtr ss, IntPtr box)
            => SafeExecution(() => Native.TsequencesetSetBbox(ss, box));

        public static IntPtr TcontseqAfterTimestamptz(IntPtr seq, long t, bool strict)
            => SafeExecution<IntPtr>(() => Native.TcontseqAfterTimestamptz(seq, t, strict));

        public static IntPtr TcontseqBeforeTimestamptz(IntPtr seq, long t, bool strict)
            => SafeExecution<IntPtr>(() => Native.TcontseqBeforeTimestamptz(seq, t, strict));

        public static IntPtr TcontseqRestrictMinmax(IntPtr seq, bool min, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TcontseqRestrictMinmax(seq, min, atfunc));

        public static IntPtr TdiscseqAfterTimestamptz(IntPtr seq, long t, bool strict)
            => SafeExecution<IntPtr>(() => Native.TdiscseqAfterTimestamptz(seq, t, strict));

        public static IntPtr TdiscseqBeforeTimestamptz(IntPtr seq, long t, bool strict)
            => SafeExecution<IntPtr>(() => Native.TdiscseqBeforeTimestamptz(seq, t, strict));

        public static IntPtr TdiscseqRestrictMinmax(IntPtr seq, bool min, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TdiscseqRestrictMinmax(seq, min, atfunc));

        public static bool TemporalBboxRestrictSet(IntPtr temp, IntPtr set)
            => SafeExecution<bool>(() => Native.TemporalBboxRestrictSet(temp, set));

        public static IntPtr TemporalRestrictMinmax(IntPtr temp, bool min, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TemporalRestrictMinmax(temp, min, atfunc));

        public static IntPtr TemporalRestrictTimestamptz(IntPtr temp, long t, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TemporalRestrictTimestamptz(temp, t, atfunc));

        public static IntPtr TemporalRestrictTstzset(IntPtr temp, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TemporalRestrictTstzset(temp, s, atfunc));

        public static IntPtr TemporalRestrictTstzspan(IntPtr temp, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TemporalRestrictTstzspan(temp, s, atfunc));

        public static IntPtr TemporalRestrictTstzspanset(IntPtr temp, IntPtr ss, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TemporalRestrictTstzspanset(temp, ss, atfunc));

        public static IntPtr TemporalRestrictValue(IntPtr temp, ulong value, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TemporalRestrictValue(temp, value, atfunc));

        public static IntPtr TemporalRestrictValues(IntPtr temp, IntPtr set, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TemporalRestrictValues(temp, set, atfunc));

        public static bool TemporalValueAtTimestamptz(IntPtr temp, long t, bool strict, IntPtr result)
            => SafeExecution<bool>(() => Native.TemporalValueAtTimestamptz(temp, t, strict, result));

        public static IntPtr TinstantAfterTimestamptz(IntPtr inst, long t, bool strict)
            => SafeExecution<IntPtr>(() => Native.TinstantAfterTimestamptz(inst, t, strict));

        public static IntPtr TinstantBeforeTimestamptz(IntPtr inst, long t, bool strict)
            => SafeExecution<IntPtr>(() => Native.TinstantBeforeTimestamptz(inst, t, strict));

        public static IntPtr TinstantRestrictTstzspan(IntPtr inst, IntPtr period, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TinstantRestrictTstzspan(inst, period, atfunc));

        public static IntPtr TinstantRestrictTstzspanset(IntPtr inst, IntPtr ss, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TinstantRestrictTstzspanset(inst, ss, atfunc));

        public static IntPtr TinstantRestrictTimestamptz(IntPtr inst, long t, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TinstantRestrictTimestamptz(inst, t, atfunc));

        public static IntPtr TinstantRestrictTstzset(IntPtr inst, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TinstantRestrictTstzset(inst, s, atfunc));

        public static IntPtr TinstantRestrictValue(IntPtr inst, ulong value, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TinstantRestrictValue(inst, value, atfunc));

        public static IntPtr TinstantRestrictValues(IntPtr inst, IntPtr set, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TinstantRestrictValues(inst, set, atfunc));

        public static IntPtr TnumberRestrictSpan(IntPtr temp, IntPtr span, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TnumberRestrictSpan(temp, span, atfunc));

        public static IntPtr TnumberRestrictSpanset(IntPtr temp, IntPtr ss, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TnumberRestrictSpanset(temp, ss, atfunc));

        public static IntPtr TnumberinstRestrictSpan(IntPtr inst, IntPtr span, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TnumberinstRestrictSpan(inst, span, atfunc));

        public static IntPtr TnumberinstRestrictSpanset(IntPtr inst, IntPtr ss, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TnumberinstRestrictSpanset(inst, ss, atfunc));

        public static IntPtr TnumberseqsetRestrictSpan(IntPtr ss, IntPtr span, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TnumberseqsetRestrictSpan(ss, span, atfunc));

        public static IntPtr TnumberseqsetRestrictSpanset(IntPtr ss, IntPtr spanset, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TnumberseqsetRestrictSpanset(ss, spanset, atfunc));

        public static IntPtr TsequenceAtTimestamptz(IntPtr seq, long t)
            => SafeExecution<IntPtr>(() => Native.TsequenceAtTimestamptz(seq, t));

        public static IntPtr TsequenceRestrictTstzspan(IntPtr seq, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TsequenceRestrictTstzspan(seq, s, atfunc));

        public static IntPtr TsequenceRestrictTstzspanset(IntPtr seq, IntPtr ss, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TsequenceRestrictTstzspanset(seq, ss, atfunc));

        public static IntPtr TsequencesetAfterTimestamptz(IntPtr ss, long t, bool strict)
            => SafeExecution<IntPtr>(() => Native.TsequencesetAfterTimestamptz(ss, t, strict));

        public static IntPtr TsequencesetBeforeTimestamptz(IntPtr ss, long t, bool strict)
            => SafeExecution<IntPtr>(() => Native.TsequencesetBeforeTimestamptz(ss, t, strict));

        public static IntPtr TsequencesetRestrictMinmax(IntPtr ss, bool min, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TsequencesetRestrictMinmax(ss, min, atfunc));

        public static IntPtr TsequencesetRestrictTstzspan(IntPtr ss, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TsequencesetRestrictTstzspan(ss, s, atfunc));

        public static IntPtr TsequencesetRestrictTstzspanset(IntPtr ss, IntPtr ps, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TsequencesetRestrictTstzspanset(ss, ps, atfunc));

        public static IntPtr TsequencesetRestrictTimestamptz(IntPtr ss, long t, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TsequencesetRestrictTimestamptz(ss, t, atfunc));

        public static IntPtr TsequencesetRestrictTstzset(IntPtr ss, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TsequencesetRestrictTstzset(ss, s, atfunc));

        public static IntPtr TsequencesetRestrictValue(IntPtr ss, ulong value, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TsequencesetRestrictValue(ss, value, atfunc));

        public static IntPtr TsequencesetRestrictValues(IntPtr ss, IntPtr s, bool atfunc)
            => SafeExecution<IntPtr>(() => Native.TsequencesetRestrictValues(ss, s, atfunc));

        public static int TinstantCmp(IntPtr inst1, IntPtr inst2)
            => SafeExecution<int>(() => Native.TinstantCmp(inst1, inst2));

        public static IntPtr TemporalSortkeyIntl(IntPtr temp, IntPtr size)
            => SafeExecution<IntPtr>(() => Native.TemporalSortkeyIntl(temp, size));

        public static bool TinstantEq(IntPtr inst1, IntPtr inst2)
            => SafeExecution<bool>(() => Native.TinstantEq(inst1, inst2));

        public static int TsequenceCmp(IntPtr seq1, IntPtr seq2)
            => SafeExecution<int>(() => Native.TsequenceCmp(seq1, seq2));

        public static bool TsequenceEq(IntPtr seq1, IntPtr seq2)
            => SafeExecution<bool>(() => Native.TsequenceEq(seq1, seq2));

        public static int TsequencesetCmp(IntPtr ss1, IntPtr ss2)
            => SafeExecution<int>(() => Native.TsequencesetCmp(ss1, ss2));

        public static bool TsequencesetEq(IntPtr ss1, IntPtr ss2)
            => SafeExecution<bool>(() => Native.TsequencesetEq(ss1, ss2));

        public static int AlwaysEqBaseTemporal(ulong value, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysEqBaseTemporal(value, temp));

        public static int AlwaysEqTemporalBase(IntPtr temp, ulong value)
            => SafeExecution<int>(() => Native.AlwaysEqTemporalBase(temp, value));

        public static int AlwaysNeBaseTemporal(ulong value, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysNeBaseTemporal(value, temp));

        public static int AlwaysNeTemporalBase(IntPtr temp, ulong value)
            => SafeExecution<int>(() => Native.AlwaysNeTemporalBase(temp, value));

        public static int AlwaysGeBaseTemporal(ulong value, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysGeBaseTemporal(value, temp));

        public static int AlwaysGeTemporalBase(IntPtr temp, ulong value)
            => SafeExecution<int>(() => Native.AlwaysGeTemporalBase(temp, value));

        public static int AlwaysGtBaseTemporal(ulong value, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysGtBaseTemporal(value, temp));

        public static int AlwaysGtTemporalBase(IntPtr temp, ulong value)
            => SafeExecution<int>(() => Native.AlwaysGtTemporalBase(temp, value));

        public static int AlwaysLeBaseTemporal(ulong value, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysLeBaseTemporal(value, temp));

        public static int AlwaysLeTemporalBase(IntPtr temp, ulong value)
            => SafeExecution<int>(() => Native.AlwaysLeTemporalBase(temp, value));

        public static int AlwaysLtBaseTemporal(ulong value, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysLtBaseTemporal(value, temp));

        public static int AlwaysLtTemporalBase(IntPtr temp, ulong value)
            => SafeExecution<int>(() => Native.AlwaysLtTemporalBase(temp, value));

        public static int EverEqBaseTemporal(ulong value, IntPtr temp)
            => SafeExecution<int>(() => Native.EverEqBaseTemporal(value, temp));

        public static int EverEqTemporalBase(IntPtr temp, ulong value)
            => SafeExecution<int>(() => Native.EverEqTemporalBase(temp, value));

        public static int EverNeBaseTemporal(ulong value, IntPtr temp)
            => SafeExecution<int>(() => Native.EverNeBaseTemporal(value, temp));

        public static int EverNeTemporalBase(IntPtr temp, ulong value)
            => SafeExecution<int>(() => Native.EverNeTemporalBase(temp, value));

        public static int EverGeBaseTemporal(ulong value, IntPtr temp)
            => SafeExecution<int>(() => Native.EverGeBaseTemporal(value, temp));

        public static int EverGeTemporalBase(IntPtr temp, ulong value)
            => SafeExecution<int>(() => Native.EverGeTemporalBase(temp, value));

        public static int EverGtBaseTemporal(ulong value, IntPtr temp)
            => SafeExecution<int>(() => Native.EverGtBaseTemporal(value, temp));

        public static int EverGtTemporalBase(IntPtr temp, ulong value)
            => SafeExecution<int>(() => Native.EverGtTemporalBase(temp, value));

        public static int EverLeBaseTemporal(ulong value, IntPtr temp)
            => SafeExecution<int>(() => Native.EverLeBaseTemporal(value, temp));

        public static int EverLeTemporalBase(IntPtr temp, ulong value)
            => SafeExecution<int>(() => Native.EverLeTemporalBase(temp, value));

        public static int EverLtBaseTemporal(ulong value, IntPtr temp)
            => SafeExecution<int>(() => Native.EverLtBaseTemporal(value, temp));

        public static int EverLtTemporalBase(IntPtr temp, ulong value)
            => SafeExecution<int>(() => Native.EverLtTemporalBase(temp, value));

        public static IntPtr TeqBaseTemporal(ulong value, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TeqBaseTemporal(value, temp));

        public static IntPtr TeqTemporalBase(IntPtr temp, ulong value)
            => SafeExecution<IntPtr>(() => Native.TeqTemporalBase(temp, value));

        public static IntPtr TneBaseTemporal(ulong value, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TneBaseTemporal(value, temp));

        public static IntPtr TneTemporalBase(IntPtr temp, ulong value)
            => SafeExecution<IntPtr>(() => Native.TneTemporalBase(temp, value));

        public static IntPtr TltBaseTemporal(ulong value, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TltBaseTemporal(value, temp));

        public static IntPtr TltTemporalBase(IntPtr temp, ulong value)
            => SafeExecution<IntPtr>(() => Native.TltTemporalBase(temp, value));

        public static IntPtr TleBaseTemporal(ulong value, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TleBaseTemporal(value, temp));

        public static IntPtr TleTemporalBase(IntPtr temp, ulong value)
            => SafeExecution<IntPtr>(() => Native.TleTemporalBase(temp, value));

        public static IntPtr TgtBaseTemporal(ulong value, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TgtBaseTemporal(value, temp));

        public static IntPtr TgtTemporalBase(IntPtr temp, ulong value)
            => SafeExecution<IntPtr>(() => Native.TgtTemporalBase(temp, value));

        public static IntPtr TgeBaseTemporal(ulong value, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TgeBaseTemporal(value, temp));

        public static IntPtr TgeTemporalBase(IntPtr temp, ulong value)
            => SafeExecution<IntPtr>(() => Native.TgeTemporalBase(temp, value));

        public static IntPtr TnumberinstAbs(IntPtr inst)
            => SafeExecution<IntPtr>(() => Native.TnumberinstAbs(inst));

        public static double TnumberinstDistance(IntPtr inst1, IntPtr inst2)
            => SafeExecution<double>(() => Native.TnumberinstDistance(inst1, inst2));

        public static IntPtr TnumberseqAbs(IntPtr seq)
            => SafeExecution<IntPtr>(() => Native.TnumberseqAbs(seq));

        public static IntPtr TnumberseqAngularDifference(IntPtr seq)
            => SafeExecution<IntPtr>(() => Native.TnumberseqAngularDifference(seq));

        public static IntPtr TnumberseqDeltaValue(IntPtr seq)
            => SafeExecution<IntPtr>(() => Native.TnumberseqDeltaValue(seq));

        public static IntPtr TnumberseqsetAbs(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TnumberseqsetAbs(ss));

        public static IntPtr TnumberseqsetAngularDifference(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TnumberseqsetAngularDifference(ss));

        public static IntPtr TnumberseqsetDeltaValue(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TnumberseqsetDeltaValue(ss));

        public static IntPtr TdistanceTnumberNumber(IntPtr temp, ulong value)
            => SafeExecution<IntPtr>(() => Native.TdistanceTnumberNumber(temp, value));

        public static ulong NadTboxTbox(IntPtr box1, IntPtr box2)
            => SafeExecution<ulong>(() => Native.NadTboxTbox(box1, box2));

        public static ulong NadTnumberNumber(IntPtr temp, ulong value)
            => SafeExecution<ulong>(() => Native.NadTnumberNumber(temp, value));

        public static ulong NadTnumberTbox(IntPtr temp, IntPtr box)
            => SafeExecution<ulong>(() => Native.NadTnumberTbox(temp, box));

        public static ulong NadNumspanTbox(IntPtr s, IntPtr box)
            => SafeExecution<ulong>(() => Native.NadNumspanTbox(s, box));

        public static ulong NadTnumberNumspan(IntPtr temp, IntPtr s)
            => SafeExecution<ulong>(() => Native.NadTnumberNumspan(temp, s));

        public static ulong NadTnumberTnumber(IntPtr temp1, IntPtr temp2)
            => SafeExecution<ulong>(() => Native.NadTnumberTnumber(temp1, temp2));

        public static double TnumberseqIntegral(IntPtr seq)
            => SafeExecution<double>(() => Native.TnumberseqIntegral(seq));

        public static double TnumberseqTwavg(IntPtr seq)
            => SafeExecution<double>(() => Native.TnumberseqTwavg(seq));

        public static double TnumberseqsetIntegral(IntPtr ss)
            => SafeExecution<double>(() => Native.TnumberseqsetIntegral(ss));

        public static double TnumberseqsetTwavg(IntPtr ss)
            => SafeExecution<double>(() => Native.TnumberseqsetTwavg(ss));

        public static IntPtr TemporalCompact(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TemporalCompact(temp));

        public static IntPtr TsequenceCompact(IntPtr seq)
            => SafeExecution<IntPtr>(() => Native.TsequenceCompact(seq));

        public static IntPtr TsequencesetCompact(IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TsequencesetCompact(ss));

        public static IntPtr TemporalSkiplistMake()
            => SafeExecution<IntPtr>(() => Native.TemporalSkiplistMake());

        public static IntPtr SkiplistMake(ulong key_size, ulong value_size, IntPtr comp_fn, IntPtr merge_fn)
            => SafeExecution<IntPtr>(() => Native.SkiplistMake(key_size, value_size, comp_fn, merge_fn));

        public static int SkiplistSearch(IntPtr list, IntPtr key, IntPtr value)
            => SafeExecution<int>(() => Native.SkiplistSearch(list, key, value));

        public static void SkiplistFree(IntPtr list)
            => SafeExecution(() => Native.SkiplistFree(list));

        public static void SkiplistSplice(IntPtr list, IntPtr keys, IntPtr values, int count, IntPtr func, bool crossings, int sktype)
            => SafeExecution(() => Native.SkiplistSplice(list, keys, values, count, func, crossings, sktype));

        public static void TemporalSkiplistSplice(IntPtr list, IntPtr values, int count, IntPtr func, bool crossings)
            => SafeExecution(() => Native.TemporalSkiplistSplice(list, values, count, func, crossings));

        public static IntPtr SkiplistValues(IntPtr list)
            => SafeExecution<IntPtr>(() => Native.SkiplistValues(list));

        public static IntPtr SkiplistKeysValues(IntPtr list, IntPtr values)
            => SafeExecution<IntPtr>(() => Native.SkiplistKeysValues(list, values));

        public static IntPtr[] SpanBins(IntPtr s, ulong vsize, ulong vorigin, bool border_inc)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.SpanBins(s, vsize, vorigin, border_inc, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 24); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] SpansetBins(IntPtr ss, ulong vsize, ulong vorigin, bool border_inc)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.SpansetBins(ss, vsize, vorigin, border_inc, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 24); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TnumberValueBins(IntPtr temp, ulong vsize, ulong vorigin, bool border_inc)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TnumberValueBins(temp, vsize, vorigin, border_inc, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 24); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] TnumberValueTimeBoxes(IntPtr temp, ulong vsize, IntPtr duration, ulong vorigin, long torigin, bool border_inc)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TnumberValueTimeBoxes(temp, vsize, duration, vorigin, torigin, border_inc, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 56); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static (IntPtr[], ulong[]) TnumberValueSplit(IntPtr temp, ulong vsize, ulong vorigin, bool border_inc)
        {
            IntPtr _out_bins = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => Native.TnumberValueSplit(temp, vsize, vorigin, border_inc, _out_bins, _count_count));
                int _n = Marshal.ReadInt32(_count_count);
                IntPtr[] _resultArr = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _resultArr[_i] = Marshal.ReadIntPtr(_resultPtr, _i * IntPtr.Size); }
                IntPtr __out_bins_arr = Marshal.ReadIntPtr(_out_bins);
                ulong[] __out_bins_out = new ulong[_n];
                for (int _i = 0; _i < _n; _i++)
                { __out_bins_out[_i] = (ulong) Marshal.ReadInt64(__out_bins_arr, _i * 8); }
                return (_resultArr, __out_bins_out);
            }
            finally
            {
            Marshal.FreeHGlobal(_out_bins);
            Marshal.FreeHGlobal(_count_count);
            }
        }

        public static IntPtr TboxValueTimeTile(ulong value, long t, ulong vsize, IntPtr duration, ulong vorigin, long torigin, int basetype, int spantype)
            => SafeExecution<IntPtr>(() => Native.TboxValueTimeTile(value, t, vsize, duration, vorigin, torigin, basetype, spantype));

        public static IntPtr[] TboxValueTimeTiles(IntPtr box, ulong vsize, IntPtr duration, ulong vorigin, long torigin, bool border_inc)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TboxValueTimeTiles(box, vsize, duration, vorigin, torigin, border_inc, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 56); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static (IntPtr[], ulong[], long[]) TnumberValueTimeSplit(IntPtr temp, ulong vsize, IntPtr duration, ulong vorigin, long torigin, bool border_inc)
        {
            IntPtr _out_value_bins = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _out_time_bins = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => Native.TnumberValueTimeSplit(temp, vsize, duration, vorigin, torigin, border_inc, _out_value_bins, _out_time_bins, _count_count));
                int _n = Marshal.ReadInt32(_count_count);
                IntPtr[] _resultArr = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _resultArr[_i] = Marshal.ReadIntPtr(_resultPtr, _i * IntPtr.Size); }
                IntPtr __out_value_bins_arr = Marshal.ReadIntPtr(_out_value_bins);
                ulong[] __out_value_bins_out = new ulong[_n];
                for (int _i = 0; _i < _n; _i++)
                { __out_value_bins_out[_i] = (ulong) Marshal.ReadInt64(__out_value_bins_arr, _i * 8); }
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

    }
}
