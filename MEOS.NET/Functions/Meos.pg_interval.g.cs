#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Structures;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>pg_interval.h</c> declares.</summary>
    public static partial class Meos
    {
        public static IntPtr AddIntervalInterval(IntPtr interv1, IntPtr interv2)
            => SafeExecution<IntPtr>(() => Native.AddIntervalInterval(interv1, interv2));

        public static IntPtr DivIntervalFloat8(IntPtr interv, double factor)
            => SafeExecution<IntPtr>(() => Native.DivIntervalFloat8(interv, factor));

        public static IntPtr IntervalCopy(IntPtr interv)
            => SafeExecution<IntPtr>(() => Native.IntervalCopy(interv));

        public static bool IntervalEq(IntPtr interv1, IntPtr interv2)
            => SafeExecution<bool>(() => Native.IntervalEq(interv1, interv2));

        public static IntPtr IntervalExtract(IntPtr interv, IntPtr units)
            => SafeExecution<IntPtr>(() => Native.IntervalExtract(interv, units));

        public static bool IntervalGe(IntPtr interv1, IntPtr interv2)
            => SafeExecution<bool>(() => Native.IntervalGe(interv1, interv2));

        public static bool IntervalGt(IntPtr interv1, IntPtr interv2)
            => SafeExecution<bool>(() => Native.IntervalGt(interv1, interv2));

        public static uint IntervalHash(IntPtr interv)
            => SafeExecution<uint>(() => Native.IntervalHash(interv));

        public static ulong IntervalHashExtended(IntPtr interv, ulong seed)
            => SafeExecution<ulong>(() => Native.IntervalHashExtended(interv, seed));

        public static bool IntervalIsFinite(IntPtr interv)
            => SafeExecution<bool>(() => Native.IntervalIsFinite(interv));

        public static IntPtr IntervalJustifyDays(IntPtr interv)
            => SafeExecution<IntPtr>(() => Native.IntervalJustifyDays(interv));

        public static IntPtr IntervalJustifyHours(IntPtr interv)
            => SafeExecution<IntPtr>(() => Native.IntervalJustifyHours(interv));

        public static IntPtr IntervalJustifyInterval(IntPtr interv)
            => SafeExecution<IntPtr>(() => Native.IntervalJustifyInterval(interv));

        public static IntPtr IntervalLarger(IntPtr interv1, IntPtr interv2)
            => SafeExecution<IntPtr>(() => Native.IntervalLarger(interv1, interv2));

        public static bool IntervalLe(IntPtr interv1, IntPtr interv2)
            => SafeExecution<bool>(() => Native.IntervalLe(interv1, interv2));

        public static bool IntervalLt(IntPtr interv1, IntPtr interv2)
            => SafeExecution<bool>(() => Native.IntervalLt(interv1, interv2));

        public static IntPtr IntervalMake(int years, int months, int weeks, int days, int hours, int mins, double secs)
            => SafeExecution<IntPtr>(() => Native.IntervalMake(years, months, weeks, days, hours, mins, secs));

        public static bool IntervalNe(IntPtr interv1, IntPtr interv2)
            => SafeExecution<bool>(() => Native.IntervalNe(interv1, interv2));

        public static IntPtr IntervalNegate(IntPtr interv)
            => SafeExecution<IntPtr>(() => Native.IntervalNegate(interv));

        public static double IntervalPart(IntPtr interv, IntPtr units)
            => SafeExecution<double>(() => Native.IntervalPart(interv, units));

        public static IntPtr IntervalScale(IntPtr interv, int typmod)
            => SafeExecution<IntPtr>(() => Native.IntervalScale(interv, typmod));

        public static IntPtr IntervalSmaller(IntPtr interv1, IntPtr interv2)
            => SafeExecution<IntPtr>(() => Native.IntervalSmaller(interv1, interv2));

        public static IntPtr IntervalTrunc(IntPtr interv, IntPtr units)
            => SafeExecution<IntPtr>(() => Native.IntervalTrunc(interv, units));

        public static IntPtr MinusIntervalInterval(IntPtr interv1, IntPtr interv2)
            => SafeExecution<IntPtr>(() => Native.MinusIntervalInterval(interv1, interv2));

        public static IntPtr MulFloat8Interval(double factor, IntPtr interv)
            => SafeExecution<IntPtr>(() => Native.MulFloat8Interval(factor, interv));

        public static IntPtr MulIntervalFloat8(IntPtr interv, double factor)
            => SafeExecution<IntPtr>(() => Native.MulIntervalFloat8(interv, factor));

    }
}
