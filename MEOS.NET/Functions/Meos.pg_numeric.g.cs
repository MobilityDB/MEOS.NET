#nullable enable

using System.Runtime.InteropServices;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>pg_numeric.h</c> declares.</summary>
    public static partial class Meos
    {
        public static IntPtr Float4ToNumeric(float num)
            => SafeExecution<IntPtr>(() => Native.Float4ToNumeric(num));

        public static IntPtr Float8ToNumeric(double num)
            => SafeExecution<IntPtr>(() => Native.Float8ToNumeric(num));

        public static IntPtr Int16ToNumeric(short num)
            => SafeExecution<IntPtr>(() => Native.Int16ToNumeric(num));

        public static IntPtr Int32ToNumeric(int num)
            => SafeExecution<IntPtr>(() => Native.Int32ToNumeric(num));

        public static IntPtr Int64ToNumeric(long num)
            => SafeExecution<IntPtr>(() => Native.Int64ToNumeric(num));

        public static IntPtr Numeric(IntPtr num, int typmod)
            => SafeExecution<IntPtr>(() => Native.Numeric(num, typmod));

        public static IntPtr NumericAbs(IntPtr num)
            => SafeExecution<IntPtr>(() => Native.NumericAbs(num));

        public static IntPtr NumericAdd(IntPtr num1, IntPtr num2)
            => SafeExecution<IntPtr>(() => Native.NumericAdd(num1, num2));

        public static IntPtr NumericCeil(IntPtr num)
            => SafeExecution<IntPtr>(() => Native.NumericCeil(num));

        public static int NumericCmp(IntPtr num1, IntPtr num2)
            => SafeExecution<int>(() => Native.NumericCmp(num1, num2));

        public static IntPtr NumericCopy(IntPtr num)
            => SafeExecution<IntPtr>(() => Native.NumericCopy(num));

        public static IntPtr NumericDiv(IntPtr num1, IntPtr num2)
            => SafeExecution<IntPtr>(() => Native.NumericDiv(num1, num2));

        public static IntPtr NumericDivTrunc(IntPtr num1, IntPtr num2)
            => SafeExecution<IntPtr>(() => Native.NumericDivTrunc(num1, num2));

        public static bool NumericEq(IntPtr num1, IntPtr num2)
            => SafeExecution<bool>(() => Native.NumericEq(num1, num2));

        public static IntPtr NumericExp(IntPtr num)
            => SafeExecution<IntPtr>(() => Native.NumericExp(num));

        public static IntPtr NumericFac(long num)
            => SafeExecution<IntPtr>(() => Native.NumericFac(num));

        public static IntPtr NumericFloor(IntPtr num)
            => SafeExecution<IntPtr>(() => Native.NumericFloor(num));

        public static IntPtr NumericGcd(IntPtr num1, IntPtr num2)
            => SafeExecution<IntPtr>(() => Native.NumericGcd(num1, num2));

        public static bool NumericGe(IntPtr num1, IntPtr num2)
            => SafeExecution<bool>(() => Native.NumericGe(num1, num2));

        public static bool NumericGt(IntPtr num1, IntPtr num2)
            => SafeExecution<bool>(() => Native.NumericGt(num1, num2));

        public static uint NumericHash(IntPtr key)
            => SafeExecution<uint>(() => Native.NumericHash(key));

        public static ulong NumericHashExtended(IntPtr num, ulong seed)
            => SafeExecution<ulong>(() => Native.NumericHashExtended(num, seed));

        public static IntPtr NumericIn(string str, int typmod)
            => SafeExecution<IntPtr>(() => Native.NumericIn(str, typmod));

        public static IntPtr NumericInc(IntPtr num)
            => SafeExecution<IntPtr>(() => Native.NumericInc(num));

        public static IntPtr NumericLarger(IntPtr num1, IntPtr num2)
            => SafeExecution<IntPtr>(() => Native.NumericLarger(num1, num2));

        public static IntPtr NumericLcm(IntPtr num1, IntPtr num2)
            => SafeExecution<IntPtr>(() => Native.NumericLcm(num1, num2));

        public static bool NumericLe(IntPtr num1, IntPtr num2)
            => SafeExecution<bool>(() => Native.NumericLe(num1, num2));

        public static IntPtr NumericLn(IntPtr num)
            => SafeExecution<IntPtr>(() => Native.NumericLn(num));

        public static IntPtr NumericLog(IntPtr num1, IntPtr num2)
            => SafeExecution<IntPtr>(() => Native.NumericLog(num1, num2));

        public static bool NumericLt(IntPtr num1, IntPtr num2)
            => SafeExecution<bool>(() => Native.NumericLt(num1, num2));

        public static uint NumericMinScale(IntPtr num)
            => SafeExecution<uint>(() => Native.NumericMinScale(num));

        public static IntPtr NumericMinus(IntPtr num1, IntPtr num2)
            => SafeExecution<IntPtr>(() => Native.NumericMinus(num1, num2));

        public static IntPtr NumericMod(IntPtr num1, IntPtr num2)
            => SafeExecution<IntPtr>(() => Native.NumericMod(num1, num2));

        public static IntPtr NumericMul(IntPtr num1, IntPtr num2)
            => SafeExecution<IntPtr>(() => Native.NumericMul(num1, num2));

        public static bool NumericNe(IntPtr num1, IntPtr num2)
            => SafeExecution<bool>(() => Native.NumericNe(num1, num2));

        public static string NumericOut(IntPtr num)
            => SafeExecution<string>(() => Native.NumericOut(num));

        public static IntPtr NumericPow(IntPtr num1, IntPtr num2)
            => SafeExecution<IntPtr>(() => Native.NumericPow(num1, num2));

        public static IntPtr NumericRound(IntPtr num, int scale)
            => SafeExecution<IntPtr>(() => Native.NumericRound(num, scale));

        public static int NumericScale(IntPtr num)
            => SafeExecution<int>(() => Native.NumericScale(num));

        public static IntPtr NumericSign(IntPtr num)
            => SafeExecution<IntPtr>(() => Native.NumericSign(num));

        public static IntPtr NumericSmaller(IntPtr num1, IntPtr num2)
            => SafeExecution<IntPtr>(() => Native.NumericSmaller(num1, num2));

        public static IntPtr NumericSqrt(IntPtr num)
            => SafeExecution<IntPtr>(() => Native.NumericSqrt(num));

        public static float NumericToFloat4(IntPtr num)
            => SafeExecution<float>(() => Native.NumericToFloat4(num));

        public static double NumericToFloat8(IntPtr num)
            => SafeExecution<double>(() => Native.NumericToFloat8(num));

        public static short NumericToInt16(IntPtr num)
            => SafeExecution<short>(() => Native.NumericToInt16(num));

        public static int NumericToInt32(IntPtr num)
            => SafeExecution<int>(() => Native.NumericToInt32(num));

        public static long NumericToInt64(IntPtr num)
            => SafeExecution<long>(() => Native.NumericToInt64(num));

        public static IntPtr NumericTrimScale(IntPtr num)
            => SafeExecution<IntPtr>(() => Native.NumericTrimScale(num));

        public static IntPtr NumericTrunc(IntPtr num, int scale)
            => SafeExecution<IntPtr>(() => Native.NumericTrunc(num, scale));

        public static IntPtr NumericUminus(IntPtr num)
            => SafeExecution<IntPtr>(() => Native.NumericUminus(num));

        public static IntPtr NumericUplus(IntPtr num)
            => SafeExecution<IntPtr>(() => Native.NumericUplus(num));

        public static int NumericWidthBucket(IntPtr operand, IntPtr bound1, IntPtr bound2, int count)
            => SafeExecution<int>(() => Native.NumericWidthBucket(operand, bound1, bound2, count));

    }
}
