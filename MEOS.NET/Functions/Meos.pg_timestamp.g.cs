using System.Runtime.InteropServices;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>pg_timestamp.h</c> declares.</summary>
    public static partial class Meos
    {
        public static long AddTimestampInterval(long ts, IntPtr interv)
            => SafeExecution<long>(() => Native.AddTimestampInterval(ts, interv));

        public static long AddTimestamptzInterval(long tstz, IntPtr interv)
            => SafeExecution<long>(() => Native.AddTimestamptzInterval(tstz, interv));

        public static long AddTimestamptzIntervalAtZone(long tstz, IntPtr interv, IntPtr zone)
            => SafeExecution<long>(() => Native.AddTimestamptzIntervalAtZone(tstz, interv, zone));

        public static int CmpTimestampTimestamp(long ts1, long ts2)
            => SafeExecution<int>(() => Native.CmpTimestampTimestamp(ts1, ts2));

        public static int CmpTimestampTimestamptz(long ts, long tstz)
            => SafeExecution<int>(() => Native.CmpTimestampTimestamptz(ts, tstz));

        public static int CmpTimestamptzTimestamp(long tstz, long ts)
            => SafeExecution<int>(() => Native.CmpTimestamptzTimestamp(tstz, ts));

        public static bool EqTimestampTimestamp(long ts1, long ts2)
            => SafeExecution<bool>(() => Native.EqTimestampTimestamp(ts1, ts2));

        public static bool EqTimestampTimestamptz(long ts, long tstz)
            => SafeExecution<bool>(() => Native.EqTimestampTimestamptz(ts, tstz));

        public static bool EqTimestamptzTimestamp(long tstz, long ts)
            => SafeExecution<bool>(() => Native.EqTimestamptzTimestamp(tstz, ts));

        public static bool EqTimestamptzTimestamptz(long tstz1, long tstz2)
            => SafeExecution<bool>(() => Native.EqTimestamptzTimestamptz(tstz1, tstz2));

        public static long Float8ToTimestamptz(double seconds)
            => SafeExecution<long>(() => Native.Float8ToTimestamptz(seconds));

        public static bool GtTimestampTimestamp(long ts1, long ts2)
            => SafeExecution<bool>(() => Native.GtTimestampTimestamp(ts1, ts2));

        public static bool GtTimestampTimestamptz(long ts, long tstz)
            => SafeExecution<bool>(() => Native.GtTimestampTimestamptz(ts, tstz));

        public static bool GtTimestamptzTimestamp(long tstz, long ts)
            => SafeExecution<bool>(() => Native.GtTimestamptzTimestamp(tstz, ts));

        public static bool GeTimestampTimestamp(long ts1, long ts2)
            => SafeExecution<bool>(() => Native.GeTimestampTimestamp(ts1, ts2));

        public static bool GeTimestampTimestamptz(long ts, long tstz)
            => SafeExecution<bool>(() => Native.GeTimestampTimestamptz(ts, tstz));

        public static bool GeTimestamptzTimestamp(long tstz, long ts)
            => SafeExecution<bool>(() => Native.GeTimestamptzTimestamp(tstz, ts));

        public static bool LeTimestampTimestamp(long ts1, long ts2)
            => SafeExecution<bool>(() => Native.LeTimestampTimestamp(ts1, ts2));

        public static bool LeTimestampTimestamptz(long ts, long tstz)
            => SafeExecution<bool>(() => Native.LeTimestampTimestamptz(ts, tstz));

        public static bool LeTimestamptzTimestamp(long tstz, long ts)
            => SafeExecution<bool>(() => Native.LeTimestamptzTimestamp(tstz, ts));

        public static bool LtTimestampTimestamp(long ts1, long ts2)
            => SafeExecution<bool>(() => Native.LtTimestampTimestamp(ts1, ts2));

        public static bool LtTimestampTimestamptz(long ts, long tstz)
            => SafeExecution<bool>(() => Native.LtTimestampTimestamptz(ts, tstz));

        public static bool LtTimestamptzTimestamp(long tstz, long ts)
            => SafeExecution<bool>(() => Native.LtTimestamptzTimestamp(tstz, ts));

        public static long MinusTimestampInterval(long ts, IntPtr interv)
            => SafeExecution<long>(() => Native.MinusTimestampInterval(ts, interv));

        public static IntPtr MinusTimestampTimestamp(long ts1, long ts2)
            => SafeExecution<IntPtr>(() => Native.MinusTimestampTimestamp(ts1, ts2));

        public static long MinusTimestamptzInterval(long tstz, IntPtr interv)
            => SafeExecution<long>(() => Native.MinusTimestamptzInterval(tstz, interv));

        public static long MinusTimestamptzIntervalAtZone(long tstz, IntPtr interv, IntPtr zone)
            => SafeExecution<long>(() => Native.MinusTimestamptzIntervalAtZone(tstz, interv, zone));

        public static IntPtr MinusTimestamptzTimestamptz(long tstz1, long tstz2)
            => SafeExecution<IntPtr>(() => Native.MinusTimestamptzTimestamptz(tstz1, tstz2));

        public static bool NeTimestampTimestamp(long ts1, long ts2)
            => SafeExecution<bool>(() => Native.NeTimestampTimestamp(ts1, ts2));

        public static bool NeTimestampTimestamptz(long ts, long tstz)
            => SafeExecution<bool>(() => Native.NeTimestampTimestamptz(ts, tstz));

        public static bool NeTimestamptzTimestamp(long tstz, long ts)
            => SafeExecution<bool>(() => Native.NeTimestamptzTimestamp(tstz, ts));

        public static IntPtr TimestampAge(long ts1, long ts2)
            => SafeExecution<IntPtr>(() => Native.TimestampAge(ts1, ts2));

        public static long TimestampAtLocal(long ts)
            => SafeExecution<long>(() => Native.TimestampAtLocal(ts));

        public static long TimestampBin(long ts, IntPtr stride, long origin)
            => SafeExecution<long>(() => Native.TimestampBin(ts, stride, origin));

        public static IntPtr TimestampExtract(long ts, IntPtr units)
            => SafeExecution<IntPtr>(() => Native.TimestampExtract(ts, units));

        public static uint TimestampHash(long ts)
            => SafeExecution<uint>(() => Native.TimestampHash(ts));

        public static ulong TimestampHashExtended(long tstz, ulong seed)
            => SafeExecution<ulong>(() => Native.TimestampHashExtended(tstz, seed));

        public static bool TimestampIsFinite(long ts)
            => SafeExecution<bool>(() => Native.TimestampIsFinite(ts));

        public static long TimestampIzone(long ts, IntPtr zone)
            => SafeExecution<long>(() => Native.TimestampIzone(ts, zone));

        public static IntPtr TimeOfDay()
            => SafeExecution<IntPtr>(() => Native.TimeOfDay());

        public static long TimestampLarger(long ts1, long ts2)
            => SafeExecution<long>(() => Native.TimestampLarger(ts1, ts2));

        public static long TimestampMake(int year, int month, int mday, int hour, int min, double sec)
            => SafeExecution<long>(() => Native.TimestampMake(year, month, mday, hour, min, sec));

        public static bool TimestampOverlaps(long ts1, long te1, long ts2, long te2)
            => SafeExecution<bool>(() => Native.TimestampOverlaps(ts1, te1, ts2, te2));

        public static double TimestampPart(long ts, IntPtr units)
            => SafeExecution<double>(() => Native.TimestampPart(ts, units));

        public static long TimestampScale(long ts, int typmod)
            => SafeExecution<long>(() => Native.TimestampScale(ts, typmod));

        public static long TimestampSmaller(long ts1, long ts2)
            => SafeExecution<long>(() => Native.TimestampSmaller(ts1, ts2));

        public static long TimestampToTimestamptz(long ts)
            => SafeExecution<long>(() => Native.TimestampToTimestamptz(ts));

        public static long TimestampTrunc(long ts, IntPtr units)
            => SafeExecution<long>(() => Native.TimestampTrunc(ts, units));

        public static long TimestampZone(long ts, IntPtr zone)
            => SafeExecution<long>(() => Native.TimestampZone(ts, zone));

        public static IntPtr TimestamptzAge(long tstz1, long tstz2)
            => SafeExecution<IntPtr>(() => Native.TimestamptzAge(tstz1, tstz2));

        public static long TimestamptzAtLocal(long tstz)
            => SafeExecution<long>(() => Native.TimestamptzAtLocal(tstz));

        public static long TimestamptzBin(long tstz, IntPtr stride, long origin)
            => SafeExecution<long>(() => Native.TimestamptzBin(tstz, stride, origin));

        public static IntPtr TimestamptzExtract(long tstz, IntPtr units)
            => SafeExecution<IntPtr>(() => Native.TimestamptzExtract(tstz, units));

        public static int TimestamptzHash(long tstz)
            => SafeExecution<int>(() => Native.TimestamptzHash(tstz));

        public static ulong TimestamptzHashExtended(long tstz, ulong seed)
            => SafeExecution<ulong>(() => Native.TimestamptzHashExtended(tstz, seed));

        public static long TimestamptzIzone(long tstz, IntPtr zone)
            => SafeExecution<long>(() => Native.TimestamptzIzone(tstz, zone));

        public static long TimestamptzMake(int year, int month, int day, int hour, int min, double sec)
            => SafeExecution<long>(() => Native.TimestamptzMake(year, month, day, hour, min, sec));

        public static long TimestamptzMakeAtTimezone(int year, int month, int day, int hour, int min, double sec, IntPtr zone)
            => SafeExecution<long>(() => Native.TimestamptzMakeAtTimezone(year, month, day, hour, min, sec, zone));

        public static bool TimestamptzOverlaps(long ts1, long te1, long ts2, long te2)
            => SafeExecution<bool>(() => Native.TimestamptzOverlaps(ts1, te1, ts2, te2));

        public static double TimestamptzPart(long tstz, IntPtr units)
            => SafeExecution<double>(() => Native.TimestamptzPart(tstz, units));

        public static long TimestamptzScale(long tstz, int typmod)
            => SafeExecution<long>(() => Native.TimestamptzScale(tstz, typmod));

        public static long TimestamptzShift(long tstz, IntPtr interv)
            => SafeExecution<long>(() => Native.TimestamptzShift(tstz, interv));

        public static long TimestamptzToTimestamp(long tstz)
            => SafeExecution<long>(() => Native.TimestamptzToTimestamp(tstz));

        public static long TimestamptzTrunc(long tstz, IntPtr units)
            => SafeExecution<long>(() => Native.TimestamptzTrunc(tstz, units));

        public static long TimestamptzTruncZone(long tstz, IntPtr units, IntPtr zone)
            => SafeExecution<long>(() => Native.TimestamptzTruncZone(tstz, units, zone));

        public static long TimestamptzZone(long tstz, IntPtr zone)
            => SafeExecution<long>(() => Native.TimestamptzZone(tstz, zone));

    }
}
