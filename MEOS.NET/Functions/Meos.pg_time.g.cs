#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Structures;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>pg_time.h</c> declares.</summary>
    public static partial class Meos
    {
        public static long DateTimetzToTimestamptz(int date, IntPtr timetz)
            => SafeExecution<long>(() => Native.DateTimetzToTimestamptz(date, timetz));

        public static long IntervalToTime(IntPtr interv)
            => SafeExecution<long>(() => Native.IntervalToTime(interv));

        public static long MinusTimeInterval(long time, IntPtr interv)
            => SafeExecution<long>(() => Native.MinusTimeInterval(time, interv));

        public static IntPtr MinusTimeTime(long time1, long time2)
            => SafeExecution<IntPtr>(() => Native.MinusTimeTime(time1, time2));

        public static IntPtr MinusTimetzInterval(IntPtr timetz, IntPtr interv)
            => SafeExecution<IntPtr>(() => Native.MinusTimetzInterval(timetz, interv));

        public static long PlusTimeInterval(long time, IntPtr interv)
            => SafeExecution<long>(() => Native.PlusTimeInterval(time, interv));

        public static IntPtr PlusTimetzInterval(IntPtr timetz, IntPtr interv)
            => SafeExecution<IntPtr>(() => Native.PlusTimetzInterval(timetz, interv));

        public static int TimeCmp(long time1, long time2)
            => SafeExecution<int>(() => Native.TimeCmp(time1, time2));

        public static bool TimeEq(long time1, long time2)
            => SafeExecution<bool>(() => Native.TimeEq(time1, time2));

        public static IntPtr TimeExtract(long time, IntPtr units)
            => SafeExecution<IntPtr>(() => Native.TimeExtract(time, units));

        public static bool TimeGe(long time1, long time2)
            => SafeExecution<bool>(() => Native.TimeGe(time1, time2));

        public static bool TimeGt(long time1, long time2)
            => SafeExecution<bool>(() => Native.TimeGt(time1, time2));

        public static uint TimeHash(long time)
            => SafeExecution<uint>(() => Native.TimeHash(time));

        public static ulong TimeHashExtended(long time, int seed)
            => SafeExecution<ulong>(() => Native.TimeHashExtended(time, seed));

        public static long TimeLarger(long time1, long time2)
            => SafeExecution<long>(() => Native.TimeLarger(time1, time2));

        public static bool TimeLe(long time1, long time2)
            => SafeExecution<bool>(() => Native.TimeLe(time1, time2));

        public static bool TimeLt(long time1, long time2)
            => SafeExecution<bool>(() => Native.TimeLt(time1, time2));

        public static long TimeMake(int tm_hour, int tm_min, double sec)
            => SafeExecution<long>(() => Native.TimeMake(tm_hour, tm_min, sec));

        public static bool TimeNe(long time1, long time2)
            => SafeExecution<bool>(() => Native.TimeNe(time1, time2));

        public static bool TimeOverlaps(long ts1, long te1, long ts2, long te2)
            => SafeExecution<bool>(() => Native.TimeOverlaps(ts1, te1, ts2, te2));

        public static double TimePart(long time, IntPtr units)
            => SafeExecution<double>(() => Native.TimePart(time, units));

        public static long TimeScale(long date, int typmod)
            => SafeExecution<long>(() => Native.TimeScale(date, typmod));

        public static long TimeSmaller(long time1, long time2)
            => SafeExecution<long>(() => Native.TimeSmaller(time1, time2));

        public static IntPtr TimeToInterval(long time)
            => SafeExecution<IntPtr>(() => Native.TimeToInterval(time));

        public static IntPtr TimeToTimetz(long time)
            => SafeExecution<IntPtr>(() => Native.TimeToTimetz(time));

        public static long TimestampToTime(long ts)
            => SafeExecution<long>(() => Native.TimestampToTime(ts));

        public static long TimestamptzToTime(long tztz)
            => SafeExecution<long>(() => Native.TimestamptzToTime(tztz));

        public static IntPtr TimestamptzToTimetz(long tztz)
            => SafeExecution<IntPtr>(() => Native.TimestamptzToTimetz(tztz));

        public static IntPtr TimetzAtLocal(IntPtr timetz)
            => SafeExecution<IntPtr>(() => Native.TimetzAtLocal(timetz));

        public static int TimetzCmp(IntPtr timetz1, IntPtr timetz2)
            => SafeExecution<int>(() => Native.TimetzCmp(timetz1, timetz2));

        public static bool TimetzEq(IntPtr timetz1, IntPtr timetz2)
            => SafeExecution<bool>(() => Native.TimetzEq(timetz1, timetz2));

        public static IntPtr TimetzExtract(IntPtr timetz, IntPtr units)
            => SafeExecution<IntPtr>(() => Native.TimetzExtract(timetz, units));

        public static bool TimetzGe(IntPtr timetz1, IntPtr timetz2)
            => SafeExecution<bool>(() => Native.TimetzGe(timetz1, timetz2));

        public static bool TimetzGt(IntPtr timetz1, IntPtr timetz2)
            => SafeExecution<bool>(() => Native.TimetzGt(timetz1, timetz2));

        public static uint TimetzHash(IntPtr timetz)
            => SafeExecution<uint>(() => Native.TimetzHash(timetz));

        public static ulong TimetzHashExtended(IntPtr timetz, long seed)
            => SafeExecution<ulong>(() => Native.TimetzHashExtended(timetz, seed));

        public static IntPtr TimetzIn(string str, int typmod)
            => SafeExecution<IntPtr>(() => Native.TimetzIn(str, typmod));

        public static IntPtr TimetzIzone(IntPtr timetz, IntPtr zone)
            => SafeExecution<IntPtr>(() => Native.TimetzIzone(timetz, zone));

        public static IntPtr TimetzLarger(IntPtr timetz1, IntPtr timetz2)
            => SafeExecution<IntPtr>(() => Native.TimetzLarger(timetz1, timetz2));

        public static bool TimetzLe(IntPtr timetz1, IntPtr timetz2)
            => SafeExecution<bool>(() => Native.TimetzLe(timetz1, timetz2));

        public static bool TimetzLt(IntPtr timetz1, IntPtr timetz2)
            => SafeExecution<bool>(() => Native.TimetzLt(timetz1, timetz2));

        public static bool TimetzNe(IntPtr timetz1, IntPtr timetz2)
            => SafeExecution<bool>(() => Native.TimetzNe(timetz1, timetz2));

        public static IntPtr TimetzCopy(IntPtr timetz)
            => SafeExecution<IntPtr>(() => Native.TimetzCopy(timetz));

        public static string TimetzOut(IntPtr timetz)
            => SafeExecution<string>(() => Native.TimetzOut(timetz));

        public static bool TimetzOverlaps(IntPtr ts1, IntPtr te1, IntPtr ts2, IntPtr te2)
            => SafeExecution<bool>(() => Native.TimetzOverlaps(ts1, te1, ts2, te2));

        public static double TimetzPart(IntPtr timetz, IntPtr units)
            => SafeExecution<double>(() => Native.TimetzPart(timetz, units));

        public static IntPtr TimetzScale(IntPtr timetz, int typmod)
            => SafeExecution<IntPtr>(() => Native.TimetzScale(timetz, typmod));

        public static IntPtr TimetzSmaller(IntPtr timetz1, IntPtr timetz2)
            => SafeExecution<IntPtr>(() => Native.TimetzSmaller(timetz1, timetz2));

        public static long TimetzToTime(IntPtr timetz)
            => SafeExecution<long>(() => Native.TimetzToTime(timetz));

        public static IntPtr TimetzZone(IntPtr timetz, IntPtr zone)
            => SafeExecution<IntPtr>(() => Native.TimetzZone(timetz, zone));

    }
}
