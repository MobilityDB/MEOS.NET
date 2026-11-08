#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The MEOS <c>Pixel</c>, each MEOS value it holds a copy
    /// that outlives the array MEOS answered it in.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public readonly record struct Pixel(int X, int Y, bool Nodata, double Value, Geo? Geom)
    {
        /// <summary>The elements of an array MEOS answered, one address each,
        /// read and the array then released with the function made for it.</summary>
        internal static Pixel[] FromAnswer(IntPtr[] items, Action<IntPtr, int> release)
        {
            var result = new Pixel[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                IntPtr item = items[i];
                result[i] = new Pixel(
                    Marshal.PtrToStructure<int>(IntPtr.Add(item, 0)),
                    Marshal.PtrToStructure<int>(IntPtr.Add(item, 4)),
                    Marshal.ReadByte(item, 8) != 0,
                    Marshal.PtrToStructure<double>(IntPtr.Add(item, 16)),
                    Marshal.ReadIntPtr(item, 24) is var _geom && _geom != IntPtr.Zero ? MEOSFactory.WrapGeo(Meos.GeoCopy(_geom)) : null);
            }

            release(items.Length > 0 ? items[0] : IntPtr.Zero, items.Length);
            return result;
        }
    }
}
