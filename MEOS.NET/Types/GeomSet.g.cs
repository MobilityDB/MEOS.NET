#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The GeomSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class GeomSet : Set
    {
        internal GeomSet(IntPtr ptr) : base(ptr) { }

        public Geo? EndValue()
            => MEOSFactory.WrapGeo(Meos.GeosetEndValue(this.Ptr));

        public Geo? StartValue()
            => MEOSFactory.WrapGeo(Meos.GeosetStartValue(this.Ptr));

        public Geo?[] Values()
            => MEOSFactory.WrapGeoArray(Meos.GeosetValues(this.Ptr));

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.GeomsetIn(str));

        public static Set? Make(Geo[] values)
        {
            IntPtr[] _valuesValues = new IntPtr[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                _valuesValues[i] = values[i].Ptr;
            }

            GCHandle _values = GCHandle.Alloc(_valuesValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.GeosetMake(_values.AddrOfPinnedObject(), values.Length));
            }
            finally
            {
                _values.Free();
            }
        }

    }
}
