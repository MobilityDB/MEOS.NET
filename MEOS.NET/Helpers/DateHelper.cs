using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Helpers
{
    internal static class DateHelper
    {
        internal static DateTime ToDateTime(this TimestampTz pgTimestamp)
        {
            var str = Meos.TimestamptzOut(pgTimestamp.Time);
            return DateTime.Parse(str);
        }

        internal static long ToPgTimestamp(this DateTime dateTime)
        {
            var res = Meos.TimestamptzIn(dateTime.ToString("s"), -1); // ToString("s") -> ISO 8601 formatted date string
            return res;
        }
    }
}
