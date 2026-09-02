#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Structures;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>pg_int.h</c> declares.</summary>
    public static partial class Meos
    {
        public static short AddInt16Int16(short num1, short num2)
            => SafeExecution<short>(() => Native.AddInt16Int16(num1, num2));

        public static int AddInt16Int32(short num1, int num2)
            => SafeExecution<int>(() => Native.AddInt16Int32(num1, num2));

        public static long AddInt16Int64(short num1, long num2)
            => SafeExecution<long>(() => Native.AddInt16Int64(num1, num2));

        public static int AddInt32Int16(int num1, short num2)
            => SafeExecution<int>(() => Native.AddInt32Int16(num1, num2));

        public static int AddInt32Int32(int num1, int num2)
            => SafeExecution<int>(() => Native.AddInt32Int32(num1, num2));

        public static long AddInt32Int64(int num1, long num2)
            => SafeExecution<long>(() => Native.AddInt32Int64(num1, num2));

        public static long AddInt64Int16(long num1, short num2)
            => SafeExecution<long>(() => Native.AddInt64Int16(num1, num2));

        public static long AddInt64Int32(long num1, int num2)
            => SafeExecution<long>(() => Native.AddInt64Int32(num1, num2));

        public static long AddInt64Int64(long num1, long num2)
            => SafeExecution<long>(() => Native.AddInt64Int64(num1, num2));

        public static int BoolToInt32(bool b)
            => SafeExecution<int>(() => Native.BoolToInt32(b));

        public static short DivInt16Int16(short num1, short num2)
            => SafeExecution<short>(() => Native.DivInt16Int16(num1, num2));

        public static int DivInt16Int32(short num1, int num2)
            => SafeExecution<int>(() => Native.DivInt16Int32(num1, num2));

        public static long DivInt16Int64(short num1, long num2)
            => SafeExecution<long>(() => Native.DivInt16Int64(num1, num2));

        public static int DivInt32Int16(int num1, short num2)
            => SafeExecution<int>(() => Native.DivInt32Int16(num1, num2));

        public static int DivInt32Int32(int num1, int num2)
            => SafeExecution<int>(() => Native.DivInt32Int32(num1, num2));

        public static long DivInt32Int64(int num1, long num2)
            => SafeExecution<long>(() => Native.DivInt32Int64(num1, num2));

        public static long DivInt64Int16(long num1, short num2)
            => SafeExecution<long>(() => Native.DivInt64Int16(num1, num2));

        public static long DivInt64Int32(long num1, int num2)
            => SafeExecution<long>(() => Native.DivInt64Int32(num1, num2));

        public static long DivInt64Int64(long num1, long num2)
            => SafeExecution<long>(() => Native.DivInt64Int64(num1, num2));

        public static bool EqInt16Int16(short num1, short num2)
            => SafeExecution<bool>(() => Native.EqInt16Int16(num1, num2));

        public static bool EqInt16Int32(short num1, int num2)
            => SafeExecution<bool>(() => Native.EqInt16Int32(num1, num2));

        public static bool EqInt16Int64(short num1, long num2)
            => SafeExecution<bool>(() => Native.EqInt16Int64(num1, num2));

        public static bool EqInt32Int16(int num1, short num2)
            => SafeExecution<bool>(() => Native.EqInt32Int16(num1, num2));

        public static bool EqInt32Int32(int num1, int num2)
            => SafeExecution<bool>(() => Native.EqInt32Int32(num1, num2));

        public static bool EqInt32Int64(int num1, long num2)
            => SafeExecution<bool>(() => Native.EqInt32Int64(num1, num2));

        public static bool EqInt64Int16(long num1, short num2)
            => SafeExecution<bool>(() => Native.EqInt64Int16(num1, num2));

        public static bool EqInt64Int32(long num1, int num2)
            => SafeExecution<bool>(() => Native.EqInt64Int32(num1, num2));

        public static bool EqInt64Int64(long num1, long num2)
            => SafeExecution<bool>(() => Native.EqInt64Int64(num1, num2));

        public static long Float4ToInt64(float num)
            => SafeExecution<long>(() => Native.Float4ToInt64(num));

        public static long Float8ToInt64(double num)
            => SafeExecution<long>(() => Native.Float8ToInt64(num));

        public static bool GeInt16Int16(short num1, short num2)
            => SafeExecution<bool>(() => Native.GeInt16Int16(num1, num2));

        public static bool GeInt16Int32(short num1, int num2)
            => SafeExecution<bool>(() => Native.GeInt16Int32(num1, num2));

        public static bool GeInt16Int64(short num1, long num2)
            => SafeExecution<bool>(() => Native.GeInt16Int64(num1, num2));

        public static bool GeInt32Int16(int num1, short num2)
            => SafeExecution<bool>(() => Native.GeInt32Int16(num1, num2));

        public static bool GeInt32Int32(int num1, int num2)
            => SafeExecution<bool>(() => Native.GeInt32Int32(num1, num2));

        public static bool GeInt32Int64(int num1, long num2)
            => SafeExecution<bool>(() => Native.GeInt32Int64(num1, num2));

        public static bool GeInt64Int16(long num1, short num2)
            => SafeExecution<bool>(() => Native.GeInt64Int16(num1, num2));

        public static bool GeInt64Int32(long num1, int num2)
            => SafeExecution<bool>(() => Native.GeInt64Int32(num1, num2));

        public static bool GeInt64Int64(long num1, long num2)
            => SafeExecution<bool>(() => Native.GeInt64Int64(num1, num2));

        public static bool GtInt16Int16(short num1, short num2)
            => SafeExecution<bool>(() => Native.GtInt16Int16(num1, num2));

        public static bool GtInt16Int32(short num1, int num2)
            => SafeExecution<bool>(() => Native.GtInt16Int32(num1, num2));

        public static bool GtInt16Int64(short num1, long num2)
            => SafeExecution<bool>(() => Native.GtInt16Int64(num1, num2));

        public static bool GtInt32Int16(int num1, short num2)
            => SafeExecution<bool>(() => Native.GtInt32Int16(num1, num2));

        public static bool GtInt32Int32(int num1, int num2)
            => SafeExecution<bool>(() => Native.GtInt32Int32(num1, num2));

        public static bool GtInt32Int64(int num1, long num2)
            => SafeExecution<bool>(() => Native.GtInt32Int64(num1, num2));

        public static bool GtInt64Int16(long num1, short num2)
            => SafeExecution<bool>(() => Native.GtInt64Int16(num1, num2));

        public static bool GtInt64Int32(long num1, int num2)
            => SafeExecution<bool>(() => Native.GtInt64Int32(num1, num2));

        public static bool GtInt64Int64(long num1, long num2)
            => SafeExecution<bool>(() => Native.GtInt64Int64(num1, num2));

        public static short Int16Abs(short num)
            => SafeExecution<short>(() => Native.Int16Abs(num));

        public static short Int16And(short num1, short num2)
            => SafeExecution<short>(() => Native.Int16And(num1, num2));

        public static uint Int16Hash(short val)
            => SafeExecution<uint>(() => Native.Int16Hash(val));

        public static ulong Int16HashExtended(short val, ulong seed)
            => SafeExecution<ulong>(() => Native.Int16HashExtended(val, seed));

        public static short Int16In(string str)
            => SafeExecution<short>(() => Native.Int16In(str));

        public static short Int16Larger(short num1, short num2)
            => SafeExecution<short>(() => Native.Int16Larger(num1, num2));

        public static short Int16Mod(short num1, short num2)
            => SafeExecution<short>(() => Native.Int16Mod(num1, num2));

        public static short Int16Not(short num)
            => SafeExecution<short>(() => Native.Int16Not(num));

        public static short Int16Or(short num1, short num2)
            => SafeExecution<short>(() => Native.Int16Or(num1, num2));

        public static string Int16Out(short num)
            => SafeExecution<string>(() => Native.Int16Out(num));

        public static short Int16Shl(short num1, int num2)
            => SafeExecution<short>(() => Native.Int16Shl(num1, num2));

        public static short Int16Shr(short num1, int num2)
            => SafeExecution<short>(() => Native.Int16Shr(num1, num2));

        public static short Int16Smaller(short num1, short num2)
            => SafeExecution<short>(() => Native.Int16Smaller(num1, num2));

        public static int Int16ToInt32(short num)
            => SafeExecution<int>(() => Native.Int16ToInt32(num));

        public static long Int16ToInt64(short num)
            => SafeExecution<long>(() => Native.Int16ToInt64(num));

        public static short Int16Uminus(short num)
            => SafeExecution<short>(() => Native.Int16Uminus(num));

        public static short Int16Uplus(short num)
            => SafeExecution<short>(() => Native.Int16Uplus(num));

        public static short Int16Xor(short num1, short num2)
            => SafeExecution<short>(() => Native.Int16Xor(num1, num2));

        public static int Int32Abs(int num)
            => SafeExecution<int>(() => Native.Int32Abs(num));

        public static int Int32And(int num1, int num2)
            => SafeExecution<int>(() => Native.Int32And(num1, num2));

        public static int Int32Cmp(int l, int r)
            => SafeExecution<int>(() => Native.Int32Cmp(l, r));

        public static int Int32Gcd(int num1, int num2)
            => SafeExecution<int>(() => Native.Int32Gcd(num1, num2));

        public static uint Int32Hash(int val)
            => SafeExecution<uint>(() => Native.Int32Hash(val));

        public static ulong Int32HashExtended(int val, ulong seed)
            => SafeExecution<ulong>(() => Native.Int32HashExtended(val, seed));

        public static int Int32In(string str)
            => SafeExecution<int>(() => Native.Int32In(str));

        public static int Int32Inc(int num)
            => SafeExecution<int>(() => Native.Int32Inc(num));

        public static int Int32Larger(int num1, int num2)
            => SafeExecution<int>(() => Native.Int32Larger(num1, num2));

        public static int Int32Lcm(int num1, int num2)
            => SafeExecution<int>(() => Native.Int32Lcm(num1, num2));

        public static int Int32Mod(int num1, int num2)
            => SafeExecution<int>(() => Native.Int32Mod(num1, num2));

        public static int Int32Not(int num)
            => SafeExecution<int>(() => Native.Int32Not(num));

        public static int Int32Or(int num1, int num2)
            => SafeExecution<int>(() => Native.Int32Or(num1, num2));

        public static string Int32Out(int num)
            => SafeExecution<string>(() => Native.Int32Out(num));

        public static int Int32Shl(int num1, int num2)
            => SafeExecution<int>(() => Native.Int32Shl(num1, num2));

        public static int Int32Shr(int num1, int num2)
            => SafeExecution<int>(() => Native.Int32Shr(num1, num2));

        public static int Int32Smaller(int num1, int num2)
            => SafeExecution<int>(() => Native.Int32Smaller(num1, num2));

        public static bool Int32ToBool(int num)
            => SafeExecution<bool>(() => Native.Int32ToBool(num));

        public static short Int32ToInt16(int num)
            => SafeExecution<short>(() => Native.Int32ToInt16(num));

        public static long Int32ToInt64(int num)
            => SafeExecution<long>(() => Native.Int32ToInt64(num));

        public static int Int32Uminus(int num)
            => SafeExecution<int>(() => Native.Int32Uminus(num));

        public static int Int32Uplus(int num)
            => SafeExecution<int>(() => Native.Int32Uplus(num));

        public static int Int32Xor(int num1, int num2)
            => SafeExecution<int>(() => Native.Int32Xor(num1, num2));

        public static long Int64Abs(long num)
            => SafeExecution<long>(() => Native.Int64Abs(num));

        public static long Int64And(long num1, long num2)
            => SafeExecution<long>(() => Native.Int64And(num1, num2));

        public static int Int64Cmp(long l, long r)
            => SafeExecution<int>(() => Native.Int64Cmp(l, r));

        public static long Int64Dec(long num)
            => SafeExecution<long>(() => Native.Int64Dec(num));

        public static long Int64Gcd(long num1, long num2)
            => SafeExecution<long>(() => Native.Int64Gcd(num1, num2));

        public static uint Int64Hash(long num)
            => SafeExecution<uint>(() => Native.Int64Hash(num));

        public static ulong Int64HashExtended(long num, ulong seed)
            => SafeExecution<ulong>(() => Native.Int64HashExtended(num, seed));

        public static long Int64In(string str)
            => SafeExecution<long>(() => Native.Int64In(str));

        public static long Int64Inc(long num)
            => SafeExecution<long>(() => Native.Int64Inc(num));

        public static long Int64Larger(long num1, long num2)
            => SafeExecution<long>(() => Native.Int64Larger(num1, num2));

        public static long Int64Lcm(long num1, long num2)
            => SafeExecution<long>(() => Native.Int64Lcm(num1, num2));

        public static long Int64Mod(long num1, long num2)
            => SafeExecution<long>(() => Native.Int64Mod(num1, num2));

        public static long Int64Not(long num)
            => SafeExecution<long>(() => Native.Int64Not(num));

        public static long Int64Or(long num1, long num2)
            => SafeExecution<long>(() => Native.Int64Or(num1, num2));

        public static string Int64Out(long num)
            => SafeExecution<string>(() => Native.Int64Out(num));

        public static long Int64Shl(long num1, int num2)
            => SafeExecution<long>(() => Native.Int64Shl(num1, num2));

        public static long Int64Shr(long num1, int num2)
            => SafeExecution<long>(() => Native.Int64Shr(num1, num2));

        public static long Int64Smaller(long num1, long num2)
            => SafeExecution<long>(() => Native.Int64Smaller(num1, num2));

        public static float Int64ToFloat4(long num)
            => SafeExecution<float>(() => Native.Int64ToFloat4(num));

        public static double Int64ToFloat8(long num)
            => SafeExecution<double>(() => Native.Int64ToFloat8(num));

        public static short Int64ToInt16(long num)
            => SafeExecution<short>(() => Native.Int64ToInt16(num));

        public static int Int64ToInt32(long num)
            => SafeExecution<int>(() => Native.Int64ToInt32(num));

        public static long Int64Uminus(long num)
            => SafeExecution<long>(() => Native.Int64Uminus(num));

        public static long Int64Uplus(long num)
            => SafeExecution<long>(() => Native.Int64Uplus(num));

        public static long Int64Xor(long num1, long num2)
            => SafeExecution<long>(() => Native.Int64Xor(num1, num2));

        public static bool LeInt16Int16(short num1, short num2)
            => SafeExecution<bool>(() => Native.LeInt16Int16(num1, num2));

        public static bool LeInt16Int32(short num1, int num2)
            => SafeExecution<bool>(() => Native.LeInt16Int32(num1, num2));

        public static bool LeInt16Int64(short num1, long num2)
            => SafeExecution<bool>(() => Native.LeInt16Int64(num1, num2));

        public static bool LeInt32Int16(int num1, short num2)
            => SafeExecution<bool>(() => Native.LeInt32Int16(num1, num2));

        public static bool LeInt32Int32(int num1, int num2)
            => SafeExecution<bool>(() => Native.LeInt32Int32(num1, num2));

        public static bool LeInt32Int64(int num1, long num2)
            => SafeExecution<bool>(() => Native.LeInt32Int64(num1, num2));

        public static bool LeInt64Int16(long num1, short num2)
            => SafeExecution<bool>(() => Native.LeInt64Int16(num1, num2));

        public static bool LeInt64Int32(long num1, int num2)
            => SafeExecution<bool>(() => Native.LeInt64Int32(num1, num2));

        public static bool LeInt64Int64(long num1, long num2)
            => SafeExecution<bool>(() => Native.LeInt64Int64(num1, num2));

        public static bool LtInt16Int16(short num1, short num2)
            => SafeExecution<bool>(() => Native.LtInt16Int16(num1, num2));

        public static bool LtInt16Int32(short num1, int num2)
            => SafeExecution<bool>(() => Native.LtInt16Int32(num1, num2));

        public static bool LtInt16Int64(short num1, long num2)
            => SafeExecution<bool>(() => Native.LtInt16Int64(num1, num2));

        public static bool LtInt32Int16(int num1, short num2)
            => SafeExecution<bool>(() => Native.LtInt32Int16(num1, num2));

        public static bool LtInt32Int32(int num1, int num2)
            => SafeExecution<bool>(() => Native.LtInt32Int32(num1, num2));

        public static bool LtInt32Int64(int num1, long num2)
            => SafeExecution<bool>(() => Native.LtInt32Int64(num1, num2));

        public static bool LtInt64Int16(long num1, short num2)
            => SafeExecution<bool>(() => Native.LtInt64Int16(num1, num2));

        public static bool LtInt64Int32(long num1, int num2)
            => SafeExecution<bool>(() => Native.LtInt64Int32(num1, num2));

        public static bool LtInt64Int64(long num1, long num2)
            => SafeExecution<bool>(() => Native.LtInt64Int64(num1, num2));

        public static short MinusInt16Int16(short num1, short num2)
            => SafeExecution<short>(() => Native.MinusInt16Int16(num1, num2));

        public static int MinusInt16Int32(short num1, int num2)
            => SafeExecution<int>(() => Native.MinusInt16Int32(num1, num2));

        public static long MinusInt16Int64(short num1, long num2)
            => SafeExecution<long>(() => Native.MinusInt16Int64(num1, num2));

        public static int MinusInt32Int16(int num1, short num2)
            => SafeExecution<int>(() => Native.MinusInt32Int16(num1, num2));

        public static int MinusInt32Int32(int num1, int num2)
            => SafeExecution<int>(() => Native.MinusInt32Int32(num1, num2));

        public static long MinusInt32Int64(int num1, long num2)
            => SafeExecution<long>(() => Native.MinusInt32Int64(num1, num2));

        public static long MinusInt64Int16(long num1, short num2)
            => SafeExecution<long>(() => Native.MinusInt64Int16(num1, num2));

        public static long MinusInt64Int32(long num1, int num2)
            => SafeExecution<long>(() => Native.MinusInt64Int32(num1, num2));

        public static long MinusInt64Int64(long num1, long num2)
            => SafeExecution<long>(() => Native.MinusInt64Int64(num1, num2));

        public static short MulInt16Int16(short num1, short num2)
            => SafeExecution<short>(() => Native.MulInt16Int16(num1, num2));

        public static int MulInt16Int32(short num1, int num2)
            => SafeExecution<int>(() => Native.MulInt16Int32(num1, num2));

        public static long MulInt16Int64(short num1, long num2)
            => SafeExecution<long>(() => Native.MulInt16Int64(num1, num2));

        public static int MulInt32Int16(int num1, short num2)
            => SafeExecution<int>(() => Native.MulInt32Int16(num1, num2));

        public static int MulInt32Int32(int num1, int num2)
            => SafeExecution<int>(() => Native.MulInt32Int32(num1, num2));

        public static long MulInt32Int64(int num1, long num2)
            => SafeExecution<long>(() => Native.MulInt32Int64(num1, num2));

        public static long MulInt64Int16(long num1, short num2)
            => SafeExecution<long>(() => Native.MulInt64Int16(num1, num2));

        public static long MulInt64Int32(long num1, int num2)
            => SafeExecution<long>(() => Native.MulInt64Int32(num1, num2));

        public static long MulInt64Int64(long num1, long num2)
            => SafeExecution<long>(() => Native.MulInt64Int64(num1, num2));

        public static bool NeInt16Int16(short num1, short num2)
            => SafeExecution<bool>(() => Native.NeInt16Int16(num1, num2));

        public static bool NeInt16Int32(short num1, int num2)
            => SafeExecution<bool>(() => Native.NeInt16Int32(num1, num2));

        public static bool NeInt16Int64(short num1, long num2)
            => SafeExecution<bool>(() => Native.NeInt16Int64(num1, num2));

        public static bool NeInt32Int16(int num1, short num2)
            => SafeExecution<bool>(() => Native.NeInt32Int16(num1, num2));

        public static bool NeInt32Int32(int num1, int num2)
            => SafeExecution<bool>(() => Native.NeInt32Int32(num1, num2));

        public static bool NeInt32Int64(int num1, long num2)
            => SafeExecution<bool>(() => Native.NeInt32Int64(num1, num2));

        public static bool NeInt64Int16(long num1, short num2)
            => SafeExecution<bool>(() => Native.NeInt64Int16(num1, num2));

        public static bool NeInt64Int32(long num1, int num2)
            => SafeExecution<bool>(() => Native.NeInt64Int32(num1, num2));

        public static bool NeInt64Int64(long num1, long num2)
            => SafeExecution<bool>(() => Native.NeInt64Int64(num1, num2));

    }
}
