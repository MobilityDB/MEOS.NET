#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The CBufferSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class CBufferSet : SpatialSet
    {
        internal CBufferSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public bool Contained(CBufferSet s2)
            => Meos.ContainedSetSet(this.Ptr, s2.Ptr);

        public bool Contains(CBuffer cb)
            => Meos.ContainsSetCbuffer(this.Ptr, cb.Ptr);

        public bool Contains(CBufferSet s2)
            => Meos.ContainsSetSet(this.Ptr, s2.Ptr);

        public double Distance(CBufferSet s2)
            => Meos.DistanceCbuffersetCbufferset(this.Ptr, s2.Ptr);

        public CBuffer? EndValue()
            => MEOSFactory.WrapCBuffer(Meos.CbuffersetEndValue(this.Ptr));

        public Set? Intersection(CBuffer cb)
            => MEOSFactory.WrapSet(Meos.IntersectionSetCbuffer(this.Ptr, cb.Ptr));

        public Set? Intersection(CBufferSet s2)
            => MEOSFactory.WrapSet(Meos.IntersectionSetSet(this.Ptr, s2.Ptr));

        public Set? Minus(CBuffer cb)
            => MEOSFactory.WrapSet(Meos.MinusSetCbuffer(this.Ptr, cb.Ptr));

        public Set? Minus(CBufferSet s2)
            => MEOSFactory.WrapSet(Meos.MinusSetSet(this.Ptr, s2.Ptr));

        public bool Overlaps(CBufferSet s2)
            => Meos.OverlapsSetSet(this.Ptr, s2.Ptr);

        public CBuffer? StartValue()
            => MEOSFactory.WrapCBuffer(Meos.CbuffersetStartValue(this.Ptr));

        public Set? Union(CBuffer cb)
            => MEOSFactory.WrapSet(Meos.UnionSetCbuffer(this.Ptr, cb.Ptr));

        public Set? Union(CBufferSet s2)
            => MEOSFactory.WrapSet(Meos.UnionSetSet(this.Ptr, s2.Ptr));

        public CBuffer? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.CbuffersetValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSFactory.WrapCBuffer(Marshal.ReadIntPtr(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public CBuffer?[] Values()
            => MEOSFactory.WrapCBufferArray(Meos.CbuffersetValues(this.Ptr));

        public static Set? FromEWKB(byte[] wkb)
            => Set.FromWKB(wkb);

        public static Set? FromEWKT(string str)
            => CBufferSet.In(str);

        public static Set? FromHexEWKB(string hexwkb)
            => Set.FromHexWKB(hexwkb);

        public static Set? FromText(string str)
            => CBufferSet.In(str);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.CbuffersetIn(str));

        public static Set? Make(CBuffer[] values)
        {
            IntPtr _values = Marshal.AllocHGlobal(32 * Math.Max(values.Length, 1));
            byte[] _valuesValue = new byte[32];
            for (int i = 0; i < values.Length; i++)
            {
                Marshal.Copy(values[i].Ptr, _valuesValue, 0, 32);
                Marshal.Copy(_valuesValue, 0, IntPtr.Add(_values, i * 32), 32);
            }

            try
            {
                return MEOSFactory.WrapSet(Meos.CbuffersetMake(_values, values.Length));
            }
            finally
            {
                Marshal.FreeHGlobal(_values);
            }
        }

    }
}
