#nullable enable

using System.Globalization;
using System.Runtime.InteropServices;

using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The MEOS scalar time types as .NET values, and back, through
    /// the MEOS conversions of the counts from the Unix epoch: a DateTime and a
    /// DateOnly count from 0001-01-01, MEOS from 2000-01-01, and both sides
    /// state the Unix epoch exactly. A DateTime counts ticks of 100 ns, so one
    /// below a microsecond, which no MEOS timestamp holds, is refused; a value
    /// the other side cannot state is refused by its constructor.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    internal static class MEOSConvert
    {
        private const long TicksPerMicrosecond = TimeSpan.TicksPerMillisecond / 1000;

        private static readonly int UnixEpochDayNumber =
            DateOnly.FromDateTime(DateTime.UnixEpoch).DayNumber;

        /// <summary>The microseconds from the Unix epoch of the clock a DateTime
        /// reads, refusing a tick below a microsecond.</summary>
        private static long UnixMicroseconds(DateTime moment)
        {
            long ticks = moment.Ticks - DateTime.UnixEpoch.Ticks;
            if (ticks % TicksPerMicrosecond != 0)
            {
                throw new ArgumentOutOfRangeException(nameof(moment), moment,
                    "A MEOS timestamp holds whole microseconds.");
            }

            return ticks / TicksPerMicrosecond;
        }

        /// <summary>The DateTime of a count of microseconds from the Unix epoch.</summary>
        private static DateTime FromUnixMicroseconds(long us, DateTimeKind kind)
            => DateTime.SpecifyKind(DateTime.UnixEpoch.AddTicks(
                checked(us * TicksPerMicrosecond)), kind);

        /// <summary>A MEOS TimestampTz as a DateTime of UTC kind.</summary>
        internal static DateTime ToDateTime(long timestamptz)
            => FromUnixMicroseconds(Meos.TimestamptzToUnixUs(timestamptz),
                DateTimeKind.Utc);

        /// <summary>A DateTime as a MEOS TimestampTz: a moment of UTC or local
        /// kind at its instant, one of unspecified kind read in the zone of the
        /// MEOS session, as MEOS reads a timestamp without an offset.</summary>
        internal static long ToTimestampTz(DateTime moment)
            => moment.Kind == DateTimeKind.Unspecified
                ? Meos.TimestampToTimestamptz(
                    Meos.UnixUsToTimestamp(UnixMicroseconds(moment)))
                : Meos.UnixUsToTimestamptz(UnixMicroseconds(moment.ToUniversalTime()));

        /// <summary>A MEOS Timestamp, which has no time zone, as a DateTime of
        /// unspecified kind.</summary>
        internal static DateTime ToUnzonedDateTime(long timestamp)
            => FromUnixMicroseconds(Meos.TimestampToUnixUs(timestamp),
                DateTimeKind.Unspecified);

        /// <summary>A DateTime as a MEOS Timestamp: the clock it reads.</summary>
        internal static long ToTimestamp(DateTime moment)
            => Meos.UnixUsToTimestamp(UnixMicroseconds(moment));

        /// <summary>A MEOS DateADT as a DateOnly.</summary>
        internal static DateOnly ToDateOnly(int date)
            => DateOnly.FromDayNumber(checked(UnixEpochDayNumber + Meos.DateToUnixDays(date)));

        /// <summary>A DateOnly as a MEOS DateADT.</summary>
        internal static int ToDateADT(DateOnly day)
            => Meos.UnixDaysToDate(day.DayNumber - UnixEpochDayNumber);

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

        /// <summary>Each MEOS Timestamp of an array, as a DateTime of unspecified
        /// kind.</summary>
        internal static DateTime[] ToUnzonedDateTimeArray(long[] moments)
        {
            DateTime[] values = new DateTime[moments.Length];
            for (int i = 0; i < moments.Length; i++)
            {
                values[i] = ToUnzonedDateTime(moments[i]);
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
