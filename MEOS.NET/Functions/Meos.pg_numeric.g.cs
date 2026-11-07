#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Structures;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>pg_numeric.h</c> declares.</summary>
    public static partial class Meos
    {
        public static IntPtr NumericIn(string str, int typmod)
            => SafeExecution<IntPtr>(() => Native.NumericIn(str, typmod));

        public static string NumericOut(IntPtr num)
        {
            nuint _size = 0;
            IntPtr _p = SafeExecution<IntPtr>(() => Native.NumericOut(num, out _size));
            if (_p == IntPtr.Zero)
            {
                return null!;
            }

            try
            {
                return Marshal.PtrToStringUTF8(_p, (int)_size - 1);
            }
            finally
            {
                Marshal.FreeCoTaskMem(_p);
            }
        }

    }
}
