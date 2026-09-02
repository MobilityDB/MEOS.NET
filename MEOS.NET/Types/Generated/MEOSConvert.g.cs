#nullable enable

using System.Globalization;

using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The MEOS scalar time types as .NET values, and back.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    internal static class MEOSConvert
    {
        /// <summary>A MEOS TimestampTz as a DateTime.</summary>
        internal static DateTime ToDateTime(long timestamptz)
            => DateTime.Parse(MEOSExposedFunctions.timestamptz_out(timestamptz),
                CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal
                    | DateTimeStyles.AssumeUniversal);

        /// <summary>A DateTime as a MEOS TimestampTz.</summary>
        internal static long ToTimestampTz(DateTime moment)
            => MEOSExposedFunctions.timestamptz_in(
                moment.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss.ffffff+00",
                    CultureInfo.InvariantCulture), -1);

        /// <summary>A MEOS DateADT as a DateOnly.</summary>
        internal static DateOnly ToDateOnly(int date)
            => DateOnly.Parse(MEOSExposedFunctions.date_out(date),
                CultureInfo.InvariantCulture);

        /// <summary>A DateOnly as a MEOS DateADT.</summary>
        internal static int ToDateADT(DateOnly day)
            => MEOSExposedFunctions.date_in(
                day.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
    }
}
