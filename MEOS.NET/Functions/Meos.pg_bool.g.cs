using System.Runtime.InteropServices;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>pg_bool.h</c> declares.</summary>
    public static partial class Meos
    {
        public static bool BoolEq(bool arg1, bool arg2)
            => SafeExecution<bool>(() => Native.BoolEq(arg1, arg2));

        public static bool BoolGe(bool arg1, bool arg2)
            => SafeExecution<bool>(() => Native.BoolGe(arg1, arg2));

        public static bool BoolGt(bool arg1, bool arg2)
            => SafeExecution<bool>(() => Native.BoolGt(arg1, arg2));

        public static uint BoolHash(bool arg)
            => SafeExecution<uint>(() => Native.BoolHash(arg));

        public static ulong BoolHashExtended(bool arg, long seed)
            => SafeExecution<ulong>(() => Native.BoolHashExtended(arg, seed));

        public static bool BoolLe(bool arg1, bool arg2)
            => SafeExecution<bool>(() => Native.BoolLe(arg1, arg2));

        public static bool BoolLt(bool arg1, bool arg2)
            => SafeExecution<bool>(() => Native.BoolLt(arg1, arg2));

        public static bool BoolNe(bool arg1, bool arg2)
            => SafeExecution<bool>(() => Native.BoolNe(arg1, arg2));

        public static IntPtr BoolToText(bool b)
            => SafeExecution<IntPtr>(() => Native.BoolToText(b));

    }
}
