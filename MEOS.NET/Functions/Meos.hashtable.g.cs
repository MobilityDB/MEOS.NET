#nullable enable

using System.Runtime.InteropServices;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>hashtable.h</c> declares.</summary>
    public static partial class Meos
    {
        public static uint Hash(IntPtr h, IntPtr k)
            => SafeExecution<uint>(() => Native.Hash(h, k));

        public static IntPtr CreateHashtable(uint minsize, IntPtr hashfunction, IntPtr key_eq_fn)
            => SafeExecution<IntPtr>(() => Native.CreateHashtable(minsize, hashfunction, key_eq_fn));

        public static IntPtr CreateStringHashtable()
            => SafeExecution<IntPtr>(() => Native.CreateStringHashtable());

        public static int HashtableInsert(IntPtr h, IntPtr k, IntPtr v)
            => SafeExecution<int>(() => Native.HashtableInsert(h, k, v));

        public static IntPtr HashtableSearch(IntPtr h, IntPtr k)
            => SafeExecution<IntPtr>(() => Native.HashtableSearch(h, k));

        public static IntPtr HashtableRemove(IntPtr h, IntPtr k)
            => SafeExecution<IntPtr>(() => Native.HashtableRemove(h, k));

        public static uint HashStr(IntPtr str)
            => SafeExecution<uint>(() => Native.HashStr(str));

        public static int StrEq(IntPtr str1, IntPtr str2)
            => SafeExecution<int>(() => Native.StrEq(str1, str2));

        public static uint HashtableCount(IntPtr h)
            => SafeExecution<uint>(() => Native.HashtableCount(h));

        public static void HashtableDestroy(IntPtr h, int free_values)
            => SafeExecution(() => Native.HashtableDestroy(h, free_values));

        public static uint IndexFor(uint tablelength, uint hashvalue)
            => SafeExecution<uint>(() => Native.IndexFor(tablelength, hashvalue));

    }
}
