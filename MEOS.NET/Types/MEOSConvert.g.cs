#nullable enable

using System.Globalization;
using System.Runtime.InteropServices;

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

        /// <summary>Each MEOS TimestampTz of an array, as a DateTime.</summary>
        internal static DateTime[] ToDateTimeArray(long[] moments)
        {
            DateTime[] values = new DateTime[moments.Length];
            for (int i = 0; i < moments.Length; i++)
            {
                values[i] = ToDateTime(moments[i]);
            }

            return values;
        }

        /// <summary>Each MEOS DateADT of an array, as a DateOnly.</summary>
        internal static DateOnly[] ToDateOnlyArray(int[] days)
        {
            DateOnly[] values = new DateOnly[days.Length];
            for (int i = 0; i < days.Length; i++)
            {
                values[i] = ToDateOnly(days[i]);
            }

            return values;
        }

        /// <summary>The struct MEOS answers through a pointer, as a value. The
        /// memory behind the pointer stays MEOS's, as it does for every other
        /// value the layer reads back.</summary>
        internal static T? ToStruct<T>(IntPtr ptr) where T : struct
            => ptr == IntPtr.Zero ? null : Marshal.PtrToStructure<T>(ptr);

        /// <summary>Each struct of an array MEOS answers, as a value.</summary>
        internal static T[] ToStructArray<T>(IntPtr[] ptrs) where T : struct
        {
            T[] values = new T[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                values[i] = Marshal.PtrToStructure<T>(ptrs[i]);
            }

            return values;
        }
    }
}
