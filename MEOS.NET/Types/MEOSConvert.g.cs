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
    /// the other side cannot state is refused by its constructor. An interval,
    /// a time and a time with time zone cast through their parts: a TimeSpan,
    /// a TimeOnly and the pair of a TimeOnly and its offset, which .NET holds
    /// in no single type.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public static class MEOSConvert
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
        public static DateTime ToDateTime(long timestamptz)
            => FromUnixMicroseconds(Meos.TimestamptzToUnixUs(timestamptz),
                DateTimeKind.Utc);

        /// <summary>A DateTime as a MEOS TimestampTz: a moment of UTC or local
        /// kind at its instant, one of unspecified kind read in the zone of the
        /// MEOS session, as MEOS reads a timestamp without an offset.</summary>
        public static long ToTimestampTz(DateTime moment)
            => moment.Kind == DateTimeKind.Unspecified
                ? Meos.TimestampToTimestamptz(
                    Meos.UnixUsToTimestamp(UnixMicroseconds(moment)))
                : Meos.UnixUsToTimestamptz(UnixMicroseconds(moment.ToUniversalTime()));

        /// <summary>A MEOS Timestamp, which has no time zone, as a DateTime of
        /// unspecified kind.</summary>
        public static DateTime ToUnzonedDateTime(long timestamp)
            => FromUnixMicroseconds(Meos.TimestampToUnixUs(timestamp),
                DateTimeKind.Unspecified);

        /// <summary>A DateTime as a MEOS Timestamp: the clock it reads.</summary>
        public static long ToTimestamp(DateTime moment)
            => Meos.UnixUsToTimestamp(UnixMicroseconds(moment));

        /// <summary>A MEOS DateADT as a DateOnly.</summary>
        public static DateOnly ToDateOnly(int date)
            => DateOnly.FromDayNumber(checked(UnixEpochDayNumber + Meos.DateToUnixDays(date)));

        /// <summary>A DateOnly as a MEOS DateADT.</summary>
        public static int ToDateADT(DateOnly day)
            => Meos.UnixDaysToDate(day.DayNumber - UnixEpochDayNumber);

        private const long MicrosecondsPerDay = TimeSpan.TicksPerDay / TicksPerMicrosecond;

        /// <summary>The whole microseconds of a count of ticks, refusing a tick
        /// below a microsecond.</summary>
        private static long WholeMicroseconds(long ticks, object value, string name)
        {
            if (ticks % TicksPerMicrosecond != 0)
            {
                throw new ArgumentOutOfRangeException(name, value,
                    "A MEOS value holds whole microseconds.");
            }

            return ticks / TicksPerMicrosecond;
        }

        /// <summary>A TimeSpan as a MEOS Interval, through interval_from_parts:
        /// its whole days as days and the rest as microseconds.</summary>
        public static IntPtr ToInterval(TimeSpan duration)
            => Meos.IntervalFromParts(0, checked((int)(duration.Ticks / TimeSpan.TicksPerDay)),
                WholeMicroseconds(duration.Ticks % TimeSpan.TicksPerDay, duration,
                    nameof(duration)));

        /// <summary>A MEOS Interval as a TimeSpan, through interval_to_parts; an
        /// interval with months, which has no fixed length, or beyond the range
        /// of a TimeSpan, is refused.</summary>
        public static TimeSpan ToTimeSpan(IntPtr interval)
        {
            IntPtr parts = Marshal.AllocHGlobal(16);
            try
            {
                Meos.IntervalToParts(interval, parts, parts + 4, parts + 8);
                int months = Marshal.ReadInt32(parts);
                int days = Marshal.ReadInt32(parts + 4);
                long us = Marshal.ReadInt64(parts + 8);
                if (months != 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(interval), months,
                        "A TimeSpan cannot state an interval with months.");
                }

                long total = days * MicrosecondsPerDay + us;
                if (total > TimeSpan.MaxValue.Ticks / TicksPerMicrosecond
                    || total < TimeSpan.MinValue.Ticks / TicksPerMicrosecond)
                {
                    throw new ArgumentOutOfRangeException(nameof(interval), days,
                        "A TimeSpan cannot state this interval.");
                }

                return TimeSpan.FromTicks(total * TicksPerMicrosecond);
            }
            finally
            {
                Marshal.FreeHGlobal(parts);
            }
        }

        /// <summary>A TimeOnly as a MEOS TimeADT, through time_from_parts.</summary>
        public static long ToTimeADT(TimeOnly time)
            => Meos.TimeFromParts(WholeMicroseconds(time.Ticks, time, nameof(time)));

        /// <summary>The TimeOnly of a count of microseconds from midnight; the
        /// clock 24:00:00, which a TimeOnly ends before, is refused.</summary>
        private static TimeOnly ClockTime(long us, string name)
        {
            if (us >= MicrosecondsPerDay)
            {
                throw new ArgumentOutOfRangeException(name, us,
                    "A TimeOnly cannot state the clock 24:00:00.");
            }

            return new TimeOnly(us * TicksPerMicrosecond);
        }

        /// <summary>A MEOS TimeADT as a TimeOnly, through time_to_parts.</summary>
        public static TimeOnly ToTimeOnly(long time)
        {
            IntPtr parts = Marshal.AllocHGlobal(8);
            try
            {
                Meos.TimeToParts(time, parts);
                return ClockTime(Marshal.ReadInt64(parts), nameof(time));
            }
            finally
            {
                Marshal.FreeHGlobal(parts);
            }
        }

        /// <summary>A time and its offset from UTC as a MEOS TimeTzADT, through
        /// timetz_from_parts, whose offset is in whole seconds east of UTC.</summary>
        public static IntPtr ToTimetzADT((TimeOnly Time, TimeSpan Offset) timetz)
        {
            if (timetz.Offset.Ticks % TimeSpan.TicksPerSecond != 0)
            {
                throw new ArgumentOutOfRangeException(nameof(timetz), timetz.Offset,
                    "A MEOS time zone offset holds whole seconds.");
            }

            return Meos.TimetzFromParts(
                WholeMicroseconds(timetz.Time.Ticks, timetz.Time, nameof(timetz)),
                checked((int)(timetz.Offset.Ticks / TimeSpan.TicksPerSecond)));
        }

        /// <summary>A MEOS TimeTzADT as a time and its offset from UTC, through
        /// timetz_to_parts.</summary>
        public static (TimeOnly Time, TimeSpan Offset) ToTimeWithOffset(IntPtr timetz)
        {
            IntPtr parts = Marshal.AllocHGlobal(16);
            try
            {
                Meos.TimetzToParts(timetz, parts, parts + 8);
                return (ClockTime(Marshal.ReadInt64(parts), nameof(timetz)),
                    TimeSpan.FromSeconds(Marshal.ReadInt32(parts + 8)));
            }
            finally
            {
                Marshal.FreeHGlobal(parts);
            }
        }

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
