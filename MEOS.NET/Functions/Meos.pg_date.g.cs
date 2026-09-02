using System.Runtime.InteropServices;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>pg_date.h</c> declares.</summary>
    public static partial class Meos
    {
        public static int AddDateInt(int date, int days)
            => SafeExecution<int>(() => Native.AddDateInt(date, days));

        public static int AddDateInterval(int date, IntPtr interv)
            => SafeExecution<int>(() => Native.AddDateInterval(date, interv));

        public static int CmpDateTimestamp(int date, long ts)
            => SafeExecution<int>(() => Native.CmpDateTimestamp(date, ts));

        public static int CmpDateDate(int date1, int date2)
            => SafeExecution<int>(() => Native.CmpDateDate(date1, date2));

        public static int CmpDateTimestamptz(int date, long tstz)
            => SafeExecution<int>(() => Native.CmpDateTimestamptz(date, tstz));

        public static int CmpTimestampDate(long ts, int date)
            => SafeExecution<int>(() => Native.CmpTimestampDate(ts, date));

        public static int CmpTimestamptzDate(long tstz, int date)
            => SafeExecution<int>(() => Native.CmpTimestamptzDate(tstz, date));

        public static IntPtr DateExtract(int date, IntPtr units)
            => SafeExecution<IntPtr>(() => Native.DateExtract(date, units));

        public static uint DateHash(int date)
            => SafeExecution<uint>(() => Native.DateHash(date));

        public static ulong DateHashExtended(int date, long seed)
            => SafeExecution<ulong>(() => Native.DateHashExtended(date, seed));

        public static bool DateIsFinite(int date)
            => SafeExecution<bool>(() => Native.DateIsFinite(date));

        public static int DateLarger(int date1, int date2)
            => SafeExecution<int>(() => Native.DateLarger(date1, date2));

        public static int DateMake(int year, int mon, int mday)
            => SafeExecution<int>(() => Native.DateMake(year, mon, mday));

        public static int DateSmaller(int date1, int date2)
            => SafeExecution<int>(() => Native.DateSmaller(date1, date2));

        public static long DateTimeToTimestamp(int date, long time)
            => SafeExecution<long>(() => Native.DateTimeToTimestamp(date, time));

        public static long DateToTimestamp(int date)
            => SafeExecution<long>(() => Native.DateToTimestamp(date));

        public static long DateToTimestamptz(int date)
            => SafeExecution<long>(() => Native.DateToTimestamptz(date));

        public static bool EqDateDate(int date1, int date2)
            => SafeExecution<bool>(() => Native.EqDateDate(date1, date2));

        public static bool EqDateTimestamp(int date, long ts)
            => SafeExecution<bool>(() => Native.EqDateTimestamp(date, ts));

        public static bool EqDateTimestamptz(int date, long tstz)
            => SafeExecution<bool>(() => Native.EqDateTimestamptz(date, tstz));

        public static bool EqTimestampDate(long ts, int date)
            => SafeExecution<bool>(() => Native.EqTimestampDate(ts, date));

        public static bool EqTimestamptzDate(long tstz, int date)
            => SafeExecution<bool>(() => Native.EqTimestamptzDate(tstz, date));

        public static bool GeDateDate(int date1, int date2)
            => SafeExecution<bool>(() => Native.GeDateDate(date1, date2));

        public static bool GeDateTimestamp(int date, long ts)
            => SafeExecution<bool>(() => Native.GeDateTimestamp(date, ts));

        public static bool GeDateTimestamptz(int date, long tstz)
            => SafeExecution<bool>(() => Native.GeDateTimestamptz(date, tstz));

        public static bool GeTimestampDate(long ts, int date)
            => SafeExecution<bool>(() => Native.GeTimestampDate(ts, date));

        public static bool GeTimestamptzDate(long tstz, int date)
            => SafeExecution<bool>(() => Native.GeTimestamptzDate(tstz, date));

        public static bool GtDateDate(int date1, int date2)
            => SafeExecution<bool>(() => Native.GtDateDate(date1, date2));

        public static bool GtDateTimestamp(int date, long ts)
            => SafeExecution<bool>(() => Native.GtDateTimestamp(date, ts));

        public static bool GtDateTimestamptz(int date, long tstz)
            => SafeExecution<bool>(() => Native.GtDateTimestamptz(date, tstz));

        public static bool GtTimestampDate(long ts, int date)
            => SafeExecution<bool>(() => Native.GtTimestampDate(ts, date));

        public static bool GtTimestamptzDate(long tstz, int date)
            => SafeExecution<bool>(() => Native.GtTimestamptzDate(tstz, date));

        public static bool LeDateDate(int date1, int date2)
            => SafeExecution<bool>(() => Native.LeDateDate(date1, date2));

        public static bool LeDateTimestamp(int date, long ts)
            => SafeExecution<bool>(() => Native.LeDateTimestamp(date, ts));

        public static bool LeDateTimestamptz(int date, long tstz)
            => SafeExecution<bool>(() => Native.LeDateTimestamptz(date, tstz));

        public static bool LeTimestampDate(long ts, int date)
            => SafeExecution<bool>(() => Native.LeTimestampDate(ts, date));

        public static bool LeTimestamptzDate(long tstz, int date)
            => SafeExecution<bool>(() => Native.LeTimestamptzDate(tstz, date));

        public static bool LtDateDate(int date1, int date2)
            => SafeExecution<bool>(() => Native.LtDateDate(date1, date2));

        public static bool LtDateTimestamp(int date, long ts)
            => SafeExecution<bool>(() => Native.LtDateTimestamp(date, ts));

        public static bool LtDateTimestamptz(int date, long tstz)
            => SafeExecution<bool>(() => Native.LtDateTimestamptz(date, tstz));

        public static bool LtTimestampDate(long ts, int date)
            => SafeExecution<bool>(() => Native.LtTimestampDate(ts, date));

        public static bool LtTimestamptzDate(long tstz, int date)
            => SafeExecution<bool>(() => Native.LtTimestamptzDate(tstz, date));

        public static int MinusDateDate(int date1, int date2)
            => SafeExecution<int>(() => Native.MinusDateDate(date1, date2));

        public static int MinusDateInt(int date, int days)
            => SafeExecution<int>(() => Native.MinusDateInt(date, days));

        public static int MinusDateInterval(int date, IntPtr span)
            => SafeExecution<int>(() => Native.MinusDateInterval(date, span));

        public static bool NeDateDate(int date1, int date2)
            => SafeExecution<bool>(() => Native.NeDateDate(date1, date2));

        public static bool NeDateTimestamp(int date, long ts)
            => SafeExecution<bool>(() => Native.NeDateTimestamp(date, ts));

        public static bool NeDateTimestamptz(int date, long tstz)
            => SafeExecution<bool>(() => Native.NeDateTimestamptz(date, tstz));

        public static bool NeTimestampDate(long ts, int date)
            => SafeExecution<bool>(() => Native.NeTimestampDate(ts, date));

        public static bool NeTimestamptzDate(long tstz, int date)
            => SafeExecution<bool>(() => Native.NeTimestamptzDate(tstz, date));

        public static int TimestampToDate(long ts)
            => SafeExecution<int>(() => Native.TimestampToDate(ts));

        public static int TimestamptzToDate(long tstz)
            => SafeExecution<int>(() => Native.TimestamptzToDate(tstz));

    }
}
