#nullable enable

using System.Runtime.InteropServices;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>pgtypes.h</c> declares.</summary>
    public static partial class Meos
    {
        public static IntPtr PgNumericIn(string str, int typmod)
            => SafeExecution<IntPtr>(() => Native.PgNumericIn(str, typmod));

        public static string PgNumericOut(IntPtr num)
            => SafeExecution<string>(() => Native.PgNumericOut(num));

        public static int PgNumericTypmodin(IntPtr tl, int n)
            => SafeExecution<int>(() => Native.PgNumericTypmodin(tl, n));

        public static string PgNumericTypmodout(int typmod)
            => SafeExecution<string>(() => Native.PgNumericTypmodout(typmod));

        public static IntPtr PgNumeric(IntPtr num, int typmod)
            => SafeExecution<IntPtr>(() => Native.PgNumeric(num, typmod));

        public static IntPtr PgNumericAbs(IntPtr num)
            => SafeExecution<IntPtr>(() => Native.PgNumericAbs(num));

        public static IntPtr PgNumericUplus(IntPtr num)
            => SafeExecution<IntPtr>(() => Native.PgNumericUplus(num));

        public static IntPtr PgNumericUminus(IntPtr num)
            => SafeExecution<IntPtr>(() => Native.PgNumericUminus(num));

        public static IntPtr PgNumericSign(IntPtr num)
            => SafeExecution<IntPtr>(() => Native.PgNumericSign(num));

        public static IntPtr PgNumericRound(IntPtr num, int scale)
            => SafeExecution<IntPtr>(() => Native.PgNumericRound(num, scale));

        public static IntPtr PgNumericTrunc(IntPtr num, int scale)
            => SafeExecution<IntPtr>(() => Native.PgNumericTrunc(num, scale));

        public static IntPtr PgNumericCeil(IntPtr num)
            => SafeExecution<IntPtr>(() => Native.PgNumericCeil(num));

        public static IntPtr PgNumericFloor(IntPtr num)
            => SafeExecution<IntPtr>(() => Native.PgNumericFloor(num));

        public static int PgNumericCmp(IntPtr num1, IntPtr num2)
            => SafeExecution<int>(() => Native.PgNumericCmp(num1, num2));

        public static bool PgNumericEq(IntPtr num1, IntPtr num2)
            => SafeExecution<bool>(() => Native.PgNumericEq(num1, num2));

        public static bool PgNumericNe(IntPtr num1, IntPtr num2)
            => SafeExecution<bool>(() => Native.PgNumericNe(num1, num2));

        public static bool PgNumericGt(IntPtr num1, IntPtr num2)
            => SafeExecution<bool>(() => Native.PgNumericGt(num1, num2));

        public static bool PgNumericGe(IntPtr num1, IntPtr num2)
            => SafeExecution<bool>(() => Native.PgNumericGe(num1, num2));

        public static bool PgNumericLt(IntPtr num1, IntPtr num2)
            => SafeExecution<bool>(() => Native.PgNumericLt(num1, num2));

        public static bool PgNumericLe(IntPtr num1, IntPtr num2)
            => SafeExecution<bool>(() => Native.PgNumericLe(num1, num2));

        public static IntPtr PgNumericAdd(IntPtr num1, IntPtr num2)
            => SafeExecution<IntPtr>(() => Native.PgNumericAdd(num1, num2));

        public static IntPtr PgNumericSub(IntPtr num1, IntPtr num2)
            => SafeExecution<IntPtr>(() => Native.PgNumericSub(num1, num2));

        public static IntPtr PgNumericMul(IntPtr num1, IntPtr num2)
            => SafeExecution<IntPtr>(() => Native.PgNumericMul(num1, num2));

        public static IntPtr PgNumericDiv(IntPtr num1, IntPtr num2)
            => SafeExecution<IntPtr>(() => Native.PgNumericDiv(num1, num2));

        public static IntPtr PgNumericDivTrunc(IntPtr num1, IntPtr num2)
            => SafeExecution<IntPtr>(() => Native.PgNumericDivTrunc(num1, num2));

        public static IntPtr PgNumericMod(IntPtr num1, IntPtr num2)
            => SafeExecution<IntPtr>(() => Native.PgNumericMod(num1, num2));

        public static IntPtr PgNumericInc(IntPtr num)
            => SafeExecution<IntPtr>(() => Native.PgNumericInc(num));

        public static IntPtr PgNumericSmaller(IntPtr num1, IntPtr num2)
            => SafeExecution<IntPtr>(() => Native.PgNumericSmaller(num1, num2));

        public static IntPtr PgNumericLarger(IntPtr num1, IntPtr num2)
            => SafeExecution<IntPtr>(() => Native.PgNumericLarger(num1, num2));

        public static IntPtr PgNumericGcd(IntPtr num1, IntPtr num2)
            => SafeExecution<IntPtr>(() => Native.PgNumericGcd(num1, num2));

        public static IntPtr PgNumericLcm(IntPtr num1, IntPtr num2)
            => SafeExecution<IntPtr>(() => Native.PgNumericLcm(num1, num2));

        public static IntPtr PgNumericFac(long num)
            => SafeExecution<IntPtr>(() => Native.PgNumericFac(num));

        public static IntPtr PgNumericSqrt(IntPtr num)
            => SafeExecution<IntPtr>(() => Native.PgNumericSqrt(num));

        public static IntPtr PgNumericExp(IntPtr num)
            => SafeExecution<IntPtr>(() => Native.PgNumericExp(num));

        public static IntPtr PgNumericLn(IntPtr num)
            => SafeExecution<IntPtr>(() => Native.PgNumericLn(num));

        public static IntPtr PgNumericLog(IntPtr num1, IntPtr num2)
            => SafeExecution<IntPtr>(() => Native.PgNumericLog(num1, num2));

        public static int PgNumericScale(IntPtr num)
            => SafeExecution<int>(() => Native.PgNumericScale(num));

        public static int PgNumericMinScale(IntPtr num)
            => SafeExecution<int>(() => Native.PgNumericMinScale(num));

        public static IntPtr PgNumericTrimScale(IntPtr num)
            => SafeExecution<IntPtr>(() => Native.PgNumericTrimScale(num));

        public static double MeosStrtod(string str, IntPtr endptr)
            => SafeExecution<double>(() => Native.MeosStrtod(str, endptr));

        public static int PgFloat4Cmp(float a, float b)
            => SafeExecution<int>(() => Native.PgFloat4Cmp(a, b));

        public static int PgFloat8Cmp(double a, double b)
            => SafeExecution<int>(() => Native.PgFloat8Cmp(a, b));

        public static IntPtr PgCstringToText(string str)
            => SafeExecution<IntPtr>(() => Native.PgCstringToText(str));

        public static IntPtr PgIcuUnicodeVersion()
            => SafeExecution<IntPtr>(() => Native.PgIcuUnicodeVersion());

        public static IntPtr PgTextConcat(IntPtr textarr, int count)
            => SafeExecution<IntPtr>(() => Native.PgTextConcat(textarr, count));

        public static IntPtr PgTextConcatWs(IntPtr textarr, int count, IntPtr sep)
            => SafeExecution<IntPtr>(() => Native.PgTextConcatWs(textarr, count, sep));

        public static bool PgTextGe(IntPtr txt1, IntPtr txt2)
            => SafeExecution<bool>(() => Native.PgTextGe(txt1, txt2));

        public static bool PgTextGt(IntPtr txt1, IntPtr txt2)
            => SafeExecution<bool>(() => Native.PgTextGt(txt1, txt2));

        public static IntPtr PgTextLarger(IntPtr txt1, IntPtr txt2)
            => SafeExecution<IntPtr>(() => Native.PgTextLarger(txt1, txt2));

        public static bool PgTextLe(IntPtr txt1, IntPtr txt2)
            => SafeExecution<bool>(() => Native.PgTextLe(txt1, txt2));

        public static IntPtr PgTextLeft(IntPtr txt, int n)
            => SafeExecution<IntPtr>(() => Native.PgTextLeft(txt, n));

        public static bool PgTextLt(IntPtr txt1, IntPtr txt2)
            => SafeExecution<bool>(() => Native.PgTextLt(txt1, txt2));

        public static bool PgTextPatternGe(IntPtr txt1, IntPtr txt2)
            => SafeExecution<bool>(() => Native.PgTextPatternGe(txt1, txt2));

        public static bool PgTextPatternGt(IntPtr txt1, IntPtr txt2)
            => SafeExecution<bool>(() => Native.PgTextPatternGt(txt1, txt2));

        public static bool PgTextPatternLe(IntPtr txt1, IntPtr txt2)
            => SafeExecution<bool>(() => Native.PgTextPatternLe(txt1, txt2));

        public static bool PgTextPatternLt(IntPtr txt1, IntPtr txt2)
            => SafeExecution<bool>(() => Native.PgTextPatternLt(txt1, txt2));

        public static IntPtr PgTextReverse(IntPtr txt)
            => SafeExecution<IntPtr>(() => Native.PgTextReverse(txt));

        public static IntPtr PgTextRight(IntPtr txt, int n)
            => SafeExecution<IntPtr>(() => Native.PgTextRight(txt, n));

        public static IntPtr PgTextSmaller(IntPtr txt1, IntPtr txt2)
            => SafeExecution<IntPtr>(() => Native.PgTextSmaller(txt1, txt2));

        public static bool PgTextStartsWith(IntPtr txt1, IntPtr txt2)
            => SafeExecution<bool>(() => Native.PgTextStartsWith(txt1, txt2));

        public static IntPtr PgTextSubstr(IntPtr txt, int start, int length)
            => SafeExecution<IntPtr>(() => Native.PgTextSubstr(txt, start, length));

        public static IntPtr PgTextSubstrNoLen(IntPtr txt, int start)
            => SafeExecution<IntPtr>(() => Native.PgTextSubstrNoLen(txt, start));

        public static bool PgUnicodeAssigned(IntPtr txt)
            => SafeExecution<bool>(() => Native.PgUnicodeAssigned(txt));

        public static bool PgUnicodeIsNormalized(IntPtr txt, IntPtr fmt)
            => SafeExecution<bool>(() => Native.PgUnicodeIsNormalized(txt, fmt));

        public static IntPtr PgUnicodeNormalizeFunc(IntPtr txt, IntPtr fmt)
            => SafeExecution<IntPtr>(() => Native.PgUnicodeNormalizeFunc(txt, fmt));

        public static IntPtr PgUnicodeVersion()
            => SafeExecution<IntPtr>(() => Native.PgUnicodeVersion());

        public static IntPtr PgUnistr(IntPtr txt)
            => SafeExecution<IntPtr>(() => Native.PgUnistr(txt));

        public static string PgTextToCstring(IntPtr txt)
            => SafeExecution<string>(() => Native.PgTextToCstring(txt));

        public static IntPtr ByteaCopy(IntPtr ba)
            => SafeExecution<IntPtr>(() => Native.ByteaCopy(ba));

        public static int PgDateIn(string str)
            => SafeExecution<int>(() => Native.PgDateIn(str));

        public static int PgDateLarger(int date1, int date2)
            => SafeExecution<int>(() => Native.PgDateLarger(date1, date2));

        public static int PgDateMake(int year, int mon, int mday)
            => SafeExecution<int>(() => Native.PgDateMake(year, mon, mday));

        public static int PgDateSmaller(int date1, int date2)
            => SafeExecution<int>(() => Native.PgDateSmaller(date1, date2));

        public static string PgDateOut(int date)
            => SafeExecution<string>(() => Native.PgDateOut(date));

        public static int PgTimeCmp(long time1, long time2)
            => SafeExecution<int>(() => Native.PgTimeCmp(time1, time2));

        public static bool PgTimeEq(long time1, long time2)
            => SafeExecution<bool>(() => Native.PgTimeEq(time1, time2));

        public static bool PgTimeGe(long time1, long time2)
            => SafeExecution<bool>(() => Native.PgTimeGe(time1, time2));

        public static bool PgTimeGt(long time1, long time2)
            => SafeExecution<bool>(() => Native.PgTimeGt(time1, time2));

        public static uint PgTimeHash(long time)
            => SafeExecution<uint>(() => Native.PgTimeHash(time));

        public static ulong PgTimeHashExtended(long time, int seed)
            => SafeExecution<ulong>(() => Native.PgTimeHashExtended(time, seed));

        public static long PgTimeIn(string str, int typmod)
            => SafeExecution<long>(() => Native.PgTimeIn(str, typmod));

        public static long PgTimeLarger(long time1, long time2)
            => SafeExecution<long>(() => Native.PgTimeLarger(time1, time2));

        public static bool PgTimeLe(long time1, long time2)
            => SafeExecution<bool>(() => Native.PgTimeLe(time1, time2));

        public static bool PgTimeLt(long time1, long time2)
            => SafeExecution<bool>(() => Native.PgTimeLt(time1, time2));

        public static bool PgTimeNe(long time1, long time2)
            => SafeExecution<bool>(() => Native.PgTimeNe(time1, time2));

        public static string PgTimeOut(long time)
            => SafeExecution<string>(() => Native.PgTimeOut(time));

        public static double PgTimePart(long time, IntPtr units)
            => SafeExecution<double>(() => Native.PgTimePart(time, units));

        public static long PgTimeScale(long date, int typmod)
            => SafeExecution<long>(() => Native.PgTimeScale(date, typmod));

        public static long PgTimeSmaller(long time1, long time2)
            => SafeExecution<long>(() => Native.PgTimeSmaller(time1, time2));

        public static IntPtr PgTimetzAtLocal(IntPtr timetz)
            => SafeExecution<IntPtr>(() => Native.PgTimetzAtLocal(timetz));

        public static int PgTimetzCmp(IntPtr timetz1, IntPtr timetz2)
            => SafeExecution<int>(() => Native.PgTimetzCmp(timetz1, timetz2));

        public static bool PgTimetzEq(IntPtr timetz1, IntPtr timetz2)
            => SafeExecution<bool>(() => Native.PgTimetzEq(timetz1, timetz2));

        public static bool PgTimetzGe(IntPtr timetz1, IntPtr timetz2)
            => SafeExecution<bool>(() => Native.PgTimetzGe(timetz1, timetz2));

        public static bool PgTimetzGt(IntPtr timetz1, IntPtr timetz2)
            => SafeExecution<bool>(() => Native.PgTimetzGt(timetz1, timetz2));

        public static uint PgTimetzHash(IntPtr timetz)
            => SafeExecution<uint>(() => Native.PgTimetzHash(timetz));

        public static ulong PgTimetzHashExtended(IntPtr timetz, long seed)
            => SafeExecution<ulong>(() => Native.PgTimetzHashExtended(timetz, seed));

        public static IntPtr PgTimetzIn(string str, int typmod)
            => SafeExecution<IntPtr>(() => Native.PgTimetzIn(str, typmod));

        public static IntPtr PgTimetzIzone(IntPtr timetz, IntPtr zone)
            => SafeExecution<IntPtr>(() => Native.PgTimetzIzone(timetz, zone));

        public static bool PgTimetzLe(IntPtr timetz1, IntPtr timetz2)
            => SafeExecution<bool>(() => Native.PgTimetzLe(timetz1, timetz2));

        public static bool PgTimetzLt(IntPtr timetz1, IntPtr timetz2)
            => SafeExecution<bool>(() => Native.PgTimetzLt(timetz1, timetz2));

        public static bool PgTimetzNe(IntPtr timetz1, IntPtr timetz2)
            => SafeExecution<bool>(() => Native.PgTimetzNe(timetz1, timetz2));

        public static string PgTimetzOut(IntPtr timetz)
            => SafeExecution<string>(() => Native.PgTimetzOut(timetz));

        public static IntPtr PgTimetzLarger(IntPtr timetz1, IntPtr timetz2)
            => SafeExecution<IntPtr>(() => Native.PgTimetzLarger(timetz1, timetz2));

        public static double PgTimetzPart(IntPtr timetz, IntPtr units)
            => SafeExecution<double>(() => Native.PgTimetzPart(timetz, units));

        public static IntPtr PgTimetzScale(IntPtr timetz, int typmod)
            => SafeExecution<IntPtr>(() => Native.PgTimetzScale(timetz, typmod));

        public static IntPtr PgTimetzSmaller(IntPtr timetz1, IntPtr timetz2)
            => SafeExecution<IntPtr>(() => Native.PgTimetzSmaller(timetz1, timetz2));

        public static IntPtr PgTimetzZone(IntPtr timetz, IntPtr zone)
            => SafeExecution<IntPtr>(() => Native.PgTimetzZone(timetz, zone));

        public static IntPtr PgIntervalJustifyDays(IntPtr interv)
            => SafeExecution<IntPtr>(() => Native.PgIntervalJustifyDays(interv));

        public static IntPtr PgIntervalJustifyHours(IntPtr interv)
            => SafeExecution<IntPtr>(() => Native.PgIntervalJustifyHours(interv));

        public static IntPtr PgIntervalJustifyInterval(IntPtr interv)
            => SafeExecution<IntPtr>(() => Native.PgIntervalJustifyInterval(interv));

        public static IntPtr PgTimestampAge(long ts1, long ts2)
            => SafeExecution<IntPtr>(() => Native.PgTimestampAge(ts1, ts2));

        public static long PgTimestampAtLocal(long ts)
            => SafeExecution<long>(() => Native.PgTimestampAtLocal(ts));

        public static long PgTimestampBin(long ts, IntPtr stride, long origin)
            => SafeExecution<long>(() => Native.PgTimestampBin(ts, stride, origin));

        public static uint PgTimestampHash(long ts)
            => SafeExecution<uint>(() => Native.PgTimestampHash(ts));

        public static ulong PgTimestampHashExtended(long tstz, ulong seed)
            => SafeExecution<ulong>(() => Native.PgTimestampHashExtended(tstz, seed));

        public static long PgTimestampIn(string str, int typmod)
            => SafeExecution<long>(() => Native.PgTimestampIn(str, typmod));

        public static long PgTimestampIzone(long ts, IntPtr zone)
            => SafeExecution<long>(() => Native.PgTimestampIzone(ts, zone));

        public static long PgTimestampLarger(long ts1, long ts2)
            => SafeExecution<long>(() => Native.PgTimestampLarger(ts1, ts2));

        public static string PgTimestampOut(long ts)
            => SafeExecution<string>(() => Native.PgTimestampOut(ts));

        public static double PgTimestampPart(long ts, IntPtr units)
            => SafeExecution<double>(() => Native.PgTimestampPart(ts, units));

        public static long PgTimestampScale(long ts, int typmod)
            => SafeExecution<long>(() => Native.PgTimestampScale(ts, typmod));

        public static long PgTimestampSmaller(long ts1, long ts2)
            => SafeExecution<long>(() => Native.PgTimestampSmaller(ts1, ts2));

        public static long PgTimestampTrunc(long ts, IntPtr units)
            => SafeExecution<long>(() => Native.PgTimestampTrunc(ts, units));

        public static long PgTimestampZone(long ts, IntPtr zone)
            => SafeExecution<long>(() => Native.PgTimestampZone(ts, zone));

        public static IntPtr PgTimestamptzAge(long tstz1, long tstz2)
            => SafeExecution<IntPtr>(() => Native.PgTimestamptzAge(tstz1, tstz2));

        public static long PgTimestamptzBin(long tstz, IntPtr stride, long origin)
            => SafeExecution<long>(() => Native.PgTimestamptzBin(tstz, stride, origin));

        public static uint PgTimestamptzHash(long tstz)
            => SafeExecution<uint>(() => Native.PgTimestamptzHash(tstz));

        public static ulong PgTimestamptzHashExtended(long tstz, ulong seed)
            => SafeExecution<ulong>(() => Native.PgTimestamptzHashExtended(tstz, seed));

        public static long PgTimestamptzIn(string str, int typmod)
            => SafeExecution<long>(() => Native.PgTimestamptzIn(str, typmod));

        public static long PgTimestamptzIzone(long tstz, IntPtr zone)
            => SafeExecution<long>(() => Native.PgTimestamptzIzone(tstz, zone));

        public static string PgTimestamptzOut(long tstz)
            => SafeExecution<string>(() => Native.PgTimestamptzOut(tstz));

        public static double PgTimestamptzPart(long tstz, IntPtr units)
            => SafeExecution<double>(() => Native.PgTimestamptzPart(tstz, units));

        public static long PgTimestamptzScale(long tstz, int typmod)
            => SafeExecution<long>(() => Native.PgTimestamptzScale(tstz, typmod));

        public static long PgTimestamptzTrunc(long tstz, IntPtr units)
            => SafeExecution<long>(() => Native.PgTimestamptzTrunc(tstz, units));

        public static long PgTimestamptzTruncZone(long tstz, IntPtr units, IntPtr zone)
            => SafeExecution<long>(() => Native.PgTimestamptzTruncZone(tstz, units, zone));

        public static long PgTimestamptzZone(long tstz, IntPtr zone)
            => SafeExecution<long>(() => Native.PgTimestamptzZone(tstz, zone));

        public static long PgTimestamptzAtLocal(long tstz)
            => SafeExecution<long>(() => Native.PgTimestamptzAtLocal(tstz));

        public static int PgIntervalCmp(IntPtr interv1, IntPtr interv2)
            => SafeExecution<int>(() => Native.PgIntervalCmp(interv1, interv2));

        public static bool PgIntervalEq(IntPtr interv1, IntPtr interv2)
            => SafeExecution<bool>(() => Native.PgIntervalEq(interv1, interv2));

        public static bool PgIntervalGe(IntPtr interv1, IntPtr interv2)
            => SafeExecution<bool>(() => Native.PgIntervalGe(interv1, interv2));

        public static bool PgIntervalGt(IntPtr interv1, IntPtr interv2)
            => SafeExecution<bool>(() => Native.PgIntervalGt(interv1, interv2));

        public static uint PgIntervalHash(IntPtr interv)
            => SafeExecution<uint>(() => Native.PgIntervalHash(interv));

        public static ulong PgIntervalHashExtended(IntPtr interv, ulong seed)
            => SafeExecution<ulong>(() => Native.PgIntervalHashExtended(interv, seed));

        public static IntPtr PgIntervalIn(string str, int typmod)
            => SafeExecution<IntPtr>(() => Native.PgIntervalIn(str, typmod));

        public static IntPtr PgIntervalLarger(IntPtr interv1, IntPtr interv2)
            => SafeExecution<IntPtr>(() => Native.PgIntervalLarger(interv1, interv2));

        public static bool PgIntervalLe(IntPtr interv1, IntPtr interv2)
            => SafeExecution<bool>(() => Native.PgIntervalLe(interv1, interv2));

        public static bool PgIntervalLt(IntPtr interv1, IntPtr interv2)
            => SafeExecution<bool>(() => Native.PgIntervalLt(interv1, interv2));

        public static bool PgIntervalNe(IntPtr interv1, IntPtr interv2)
            => SafeExecution<bool>(() => Native.PgIntervalNe(interv1, interv2));

        public static string PgIntervalOut(IntPtr interv)
            => SafeExecution<string>(() => Native.PgIntervalOut(interv));

        public static double PgIntervalPart(IntPtr interv, IntPtr units)
            => SafeExecution<double>(() => Native.PgIntervalPart(interv, units));

        public static IntPtr PgIntervalScale(IntPtr interv, int typmod)
            => SafeExecution<IntPtr>(() => Native.PgIntervalScale(interv, typmod));

        public static IntPtr PgIntervalSmaller(IntPtr interv1, IntPtr interv2)
            => SafeExecution<IntPtr>(() => Native.PgIntervalSmaller(interv1, interv2));

        public static IntPtr PgIntervalTrunc(IntPtr interv, IntPtr units)
            => SafeExecution<IntPtr>(() => Native.PgIntervalTrunc(interv, units));

        public static IntPtr PgJsonIn(string str)
            => SafeExecution<IntPtr>(() => Native.PgJsonIn(str));

        public static string PgJsonOut(IntPtr js)
            => SafeExecution<string>(() => Native.PgJsonOut(js));

        public static IntPtr PgJsonbFromText(IntPtr txt, bool unique_keys)
            => SafeExecution<IntPtr>(() => Native.PgJsonbFromText(txt, unique_keys));

        public static IntPtr PgJsonbToText(IntPtr jb)
            => SafeExecution<IntPtr>(() => Native.PgJsonbToText(jb));

        public static IntPtr PgJsonbIn(string str)
            => SafeExecution<IntPtr>(() => Native.PgJsonbIn(str));

        public static string PgJsonbOut(IntPtr jb)
            => SafeExecution<string>(() => Native.PgJsonbOut(jb));

        public static IntPtr PgJsonMake(IntPtr keyvalarr, int count)
            => SafeExecution<IntPtr>(() => Native.PgJsonMake(keyvalarr, count));

        public static IntPtr PgJsonMakeTwoArg(IntPtr keys, IntPtr values, int count)
            => SafeExecution<IntPtr>(() => Native.PgJsonMakeTwoArg(keys, values, count));

        public static IntPtr PgJsonbCopy(IntPtr jb)
            => SafeExecution<IntPtr>(() => Native.PgJsonbCopy(jb));

        public static IntPtr PgJsonbMake(IntPtr keys_vals, int count)
            => SafeExecution<IntPtr>(() => Native.PgJsonbMake(keys_vals, count));

        public static IntPtr PgJsonbMakeTwoArg(IntPtr keys, IntPtr values, int count)
            => SafeExecution<IntPtr>(() => Native.PgJsonbMakeTwoArg(keys, values, count));

        public static IntPtr[] PgJsonArrayElements(IntPtr js)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.PgJsonArrayElements(js, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] PgJsonArrayElementsText(IntPtr js)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.PgJsonArrayElementsText(js, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int PgJsonArrayLength(IntPtr js)
            => SafeExecution<int>(() => Native.PgJsonArrayLength(js));

        public static (IntPtr[], IntPtr[]) PgJsonEach(IntPtr js)
        {
            IntPtr _out_values = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => Native.PgJsonEach(js, _out_values, _count_count));
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

        public static (IntPtr[], IntPtr[]) PgJsonEachText(IntPtr js)
        {
            IntPtr _out_values = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => Native.PgJsonEachText(js, _out_values, _count_count));
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

        public static IntPtr[] PgJsonObjectKeys(IntPtr js)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.PgJsonObjectKeys(js, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr PgJsonTypeof(IntPtr js)
            => SafeExecution<IntPtr>(() => Native.PgJsonTypeof(js));

        public static IntPtr[] PgJsonbArrayElements(IntPtr jb)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.PgJsonbArrayElements(jb, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr[] PgJsonbArrayElementsText(IntPtr jb)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.PgJsonbArrayElementsText(jb, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static int PgJsonbArrayLength(IntPtr jb)
            => SafeExecution<int>(() => Native.PgJsonbArrayLength(jb));

        public static int PgJsonbCmp(IntPtr jb1, IntPtr jb2)
            => SafeExecution<int>(() => Native.PgJsonbCmp(jb1, jb2));

        public static bool PgJsonbContained(IntPtr jb1, IntPtr jb2)
            => SafeExecution<bool>(() => Native.PgJsonbContained(jb1, jb2));

        public static bool PgJsonbContains(IntPtr jb1, IntPtr jb2)
            => SafeExecution<bool>(() => Native.PgJsonbContains(jb1, jb2));

        public static (IntPtr[], IntPtr[]) PgJsonbEach(IntPtr jb)
        {
            IntPtr _out_values = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => Native.PgJsonbEach(jb, _out_values, _count_count));
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

        public static (IntPtr[], IntPtr[]) PgJsonbEachText(IntPtr jb)
        {
            IntPtr _out_values = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => Native.PgJsonbEachText(jb, _out_values, _count_count));
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

        public static bool PgJsonbEq(IntPtr jb1, IntPtr jb2)
            => SafeExecution<bool>(() => Native.PgJsonbEq(jb1, jb2));

        public static bool PgJsonbExists(IntPtr jb, IntPtr key)
            => SafeExecution<bool>(() => Native.PgJsonbExists(jb, key));

        public static bool PgJsonbExistsArray(IntPtr jb, IntPtr keys_elems, int keys_len, bool any)
            => SafeExecution<bool>(() => Native.PgJsonbExistsArray(jb, keys_elems, keys_len, any));

        public static bool PgJsonbGe(IntPtr jb1, IntPtr jb2)
            => SafeExecution<bool>(() => Native.PgJsonbGe(jb1, jb2));

        public static bool PgJsonbGt(IntPtr jb1, IntPtr jb2)
            => SafeExecution<bool>(() => Native.PgJsonbGt(jb1, jb2));

        public static uint PgJsonbHash(IntPtr jb)
            => SafeExecution<uint>(() => Native.PgJsonbHash(jb));

        public static ulong PgJsonbHashExtended(IntPtr jb, ulong seed)
            => SafeExecution<ulong>(() => Native.PgJsonbHashExtended(jb, seed));

        public static IntPtr[] PgJsonbObjectKeys(IntPtr jb)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.PgJsonbObjectKeys(jb, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr PgJsonArrayElement(IntPtr js, int element)
            => SafeExecution<IntPtr>(() => Native.PgJsonArrayElement(js, element));

        public static IntPtr PgJsonArrayElementText(IntPtr js, int element)
            => SafeExecution<IntPtr>(() => Native.PgJsonArrayElementText(js, element));

        public static IntPtr PgJsonExtractPath(IntPtr js, IntPtr path_elems, int path_len)
            => SafeExecution<IntPtr>(() => Native.PgJsonExtractPath(js, path_elems, path_len));

        public static IntPtr PgJsonExtractPathText(IntPtr js, IntPtr path_elems, int path_len)
            => SafeExecution<IntPtr>(() => Native.PgJsonExtractPathText(js, path_elems, path_len));

        public static IntPtr PgJsonObjectField(IntPtr js, IntPtr key)
            => SafeExecution<IntPtr>(() => Native.PgJsonObjectField(js, key));

        public static IntPtr PgJsonObjectFieldText(IntPtr js, IntPtr key)
            => SafeExecution<IntPtr>(() => Native.PgJsonObjectFieldText(js, key));

        public static IntPtr PgJsonStripNulls(IntPtr js, bool strip_in_arrays)
            => SafeExecution<IntPtr>(() => Native.PgJsonStripNulls(js, strip_in_arrays));

        public static IntPtr PgJsonbArrayElement(IntPtr jb, int element)
            => SafeExecution<IntPtr>(() => Native.PgJsonbArrayElement(jb, element));

        public static IntPtr PgJsonbArrayElementText(IntPtr jb, int element)
            => SafeExecution<IntPtr>(() => Native.PgJsonbArrayElementText(jb, element));

        public static IntPtr PgJsonbConcat(IntPtr jb1, IntPtr jb2)
            => SafeExecution<IntPtr>(() => Native.PgJsonbConcat(jb1, jb2));

        public static IntPtr PgJsonbDelete(IntPtr jb, IntPtr key)
            => SafeExecution<IntPtr>(() => Native.PgJsonbDelete(jb, key));

        public static IntPtr PgJsonbDeleteArray(IntPtr jb, IntPtr keys_elems, int keys_len)
            => SafeExecution<IntPtr>(() => Native.PgJsonbDeleteArray(jb, keys_elems, keys_len));

        public static IntPtr PgJsonbDeleteIndex(IntPtr jb, int idx)
            => SafeExecution<IntPtr>(() => Native.PgJsonbDeleteIndex(jb, idx));

        public static IntPtr PgJsonbDeletePath(IntPtr jb, IntPtr path_elems, int path_len)
            => SafeExecution<IntPtr>(() => Native.PgJsonbDeletePath(jb, path_elems, path_len));

        public static IntPtr PgJsonbExtractPath(IntPtr jb, IntPtr path_elems, int path_len)
            => SafeExecution<IntPtr>(() => Native.PgJsonbExtractPath(jb, path_elems, path_len));

        public static IntPtr PgJsonbExtractPathText(IntPtr jb, IntPtr path_elems, int path_len)
            => SafeExecution<IntPtr>(() => Native.PgJsonbExtractPathText(jb, path_elems, path_len));

        public static IntPtr PgJsonbInsert(IntPtr jb, IntPtr path_elems, int path_len, IntPtr newjb, bool after)
            => SafeExecution<IntPtr>(() => Native.PgJsonbInsert(jb, path_elems, path_len, newjb, after));

        public static IntPtr PgJsonbObjectField(IntPtr jb, IntPtr key)
            => SafeExecution<IntPtr>(() => Native.PgJsonbObjectField(jb, key));

        public static IntPtr PgJsonbObjectFieldText(IntPtr jb, IntPtr key)
            => SafeExecution<IntPtr>(() => Native.PgJsonbObjectFieldText(jb, key));

        public static IntPtr PgJsonbPretty(IntPtr jb)
            => SafeExecution<IntPtr>(() => Native.PgJsonbPretty(jb));

        public static IntPtr PgJsonbSet(IntPtr jb, IntPtr path_elems, int path_len, IntPtr newjb, bool create)
            => SafeExecution<IntPtr>(() => Native.PgJsonbSet(jb, path_elems, path_len, newjb, create));

        public static IntPtr PgJsonbSetLax(IntPtr jb, IntPtr path_elems, int path_len, IntPtr newjb, bool create, IntPtr handle_null)
            => SafeExecution<IntPtr>(() => Native.PgJsonbSetLax(jb, path_elems, path_len, newjb, create, handle_null));

        public static IntPtr PgJsonbStripNulls(IntPtr jb, bool strip_in_arrays)
            => SafeExecution<IntPtr>(() => Native.PgJsonbStripNulls(jb, strip_in_arrays));

        public static bool PgJsonbLe(IntPtr jb1, IntPtr jb2)
            => SafeExecution<bool>(() => Native.PgJsonbLe(jb1, jb2));

        public static bool PgJsonbLt(IntPtr jb1, IntPtr jb2)
            => SafeExecution<bool>(() => Native.PgJsonbLt(jb1, jb2));

        public static bool PgJsonbNe(IntPtr jb1, IntPtr jb2)
            => SafeExecution<bool>(() => Native.PgJsonbNe(jb1, jb2));

        public static IntPtr PgJsonpathIn(string str)
            => SafeExecution<IntPtr>(() => Native.PgJsonpathIn(str));

        public static string PgJsonpathOut(IntPtr jp)
            => SafeExecution<string>(() => Native.PgJsonpathOut(jp));

        public static IntPtr PgJsonpathCopy(IntPtr jp)
            => SafeExecution<IntPtr>(() => Native.PgJsonpathCopy(jp));

        public static int PgJsonbPathExists(IntPtr jb, IntPtr jp, IntPtr vars, bool silent, bool tz)
            => SafeExecution<int>(() => Native.PgJsonbPathExists(jb, jp, vars, silent, tz));

        public static bool PgJsonbPathMatch(IntPtr jb, IntPtr jp, IntPtr vars, bool silent, bool tz)
            => SafeExecution<bool>(() => Native.PgJsonbPathMatch(jb, jp, vars, silent, tz));

        public static IntPtr PgJsonbPathQueryArray(IntPtr jb, IntPtr jp, IntPtr vars, bool silent, bool tz)
            => SafeExecution<IntPtr>(() => Native.PgJsonbPathQueryArray(jb, jp, vars, silent, tz));

        public static IntPtr PgJsonbPathQueryFirst(IntPtr jb, IntPtr jp, IntPtr vars, bool silent, bool tz)
            => SafeExecution<IntPtr>(() => Native.PgJsonbPathQueryFirst(jb, jp, vars, silent, tz));

        public static IntPtr[] PgJsonbPathQueryAll(IntPtr jb, IntPtr jp, IntPtr vars, bool silent, bool tz)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.PgJsonbPathQueryAll(jb, jp, vars, silent, tz, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

    }
}
