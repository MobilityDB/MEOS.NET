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
    }
}
