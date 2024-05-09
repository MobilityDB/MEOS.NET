﻿using System.Runtime.InteropServices;

namespace MEOS.NET.Helpers
{
    internal static class AllocHelper
    {
        /// <summary>
        /// Allocates a pointer of given size, executes a given action, and frees the memory after.
        /// </summary>
        /// <param name="size">The size of the pointer, in bytes</param>
        /// <param name="callback">The callback to execute between the allocation and the freeing.</param>
        internal static void AllocatePointer(int size, Action<IntPtr> callback)
        {
            var pointer = Marshal.AllocHGlobal(size);

            try
            {
                callback(pointer);
            }
            finally
            {
                Marshal.FreeHGlobal(pointer);
            }

        }

        internal static T AllocatePointer<T>(int size, Func<IntPtr, T> callback)
        {
            var pointer = Marshal.AllocHGlobal(size);

            try
            {
                var result = callback(pointer);
                return result;
            }
            finally
            {
                Marshal.FreeHGlobal(pointer);
            }
        }

        internal static T ToStructure<T>(this IntPtr pointer) where T : struct
            => Marshal.PtrToStructure<T>(pointer);

        internal static T[] ToArrayOfType<T>(this IntPtr pointer, int arraySize) where T : struct
        {
            T[] arr = new T[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                IntPtr currentPtr = IntPtr.Add(pointer, Marshal.SizeOf<T>() * i);
                arr[i] = currentPtr.ToStructure<T>();
            }

            return arr;
        }
    }
}
