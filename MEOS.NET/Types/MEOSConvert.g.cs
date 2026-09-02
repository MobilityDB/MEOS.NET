#nullable enable

using System.Globalization;

using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The MEOS scalar time types as .NET values, and back.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    internal static class MEOSConvert
    {
        /// <summary>A MEOS TimestampTz as a DateTime.</summary>
        internal static DateTime ToDateTime(long timestamptz)
            => DateTime.Parse(Meos.TimestamptzOut(timestamptz),
                CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal
                    | DateTimeStyles.AssumeUniversal);

        /// <summary>A DateTime as a MEOS TimestampTz.</summary>
        internal static long ToTimestampTz(DateTime moment)
            => Meos.TimestamptzIn(
                moment.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss.ffffff+00",
                    CultureInfo.InvariantCulture), -1);

        /// <summary>A MEOS DateADT as a DateOnly.</summary>
        internal static DateOnly ToDateOnly(int date)
            => DateOnly.Parse(Meos.DateOut(date),
                CultureInfo.InvariantCulture);

        /// <summary>A DateOnly as a MEOS DateADT.</summary>
        internal static int ToDateADT(DateOnly day)
            => Meos.DateIn(
                day.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
    }
}
