using MEOS.NET.Internal;
using MEOS.NET.Structures;

namespace MEOS.NET.Helpers
{
    internal static class DateHelper
    {
        internal static DateTime ToDateTime(this TimestampTz pgTimestamp)
        {
            var str = MEOSExposedFunctions.pg_timestamptz_out(pgTimestamp.Time);
            return DateTime.Parse(str);
        }

        internal static long ToPgTimestamp(this DateTime dateTime)
        {
            var res = MEOSExposedFunctions.pg_timestamptz_in(dateTime.ToString("s"), -1); // ToString("s") -> ISO 8601 formatted date string
            return res;
        }
    }
}
