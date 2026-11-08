#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The MEOS <c>GeomVal</c>, each MEOS value it holds a copy
    /// that outlives the array MEOS answered it in.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public readonly record struct GeomVal(Geo? Geom, double Val)
    {
        /// <summary>The elements of an array MEOS answered, one address each,
        /// read and the array then released with the function made for it.</summary>
        internal static GeomVal[] FromAnswer(IntPtr[] items, Action<IntPtr, int> release)
        {
            var result = new GeomVal[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                IntPtr item = items[i];
                result[i] = new GeomVal(
                    Marshal.ReadIntPtr(item, 0) is var _geom && _geom != IntPtr.Zero ? MEOSFactory.WrapGeo(Meos.GeoCopy(_geom)) : null,
                    Marshal.PtrToStructure<double>(IntPtr.Add(item, 8)));
            }

            release(items.Length > 0 ? items[0] : IntPtr.Zero, items.Length);
            return result;
        }
    }
}
