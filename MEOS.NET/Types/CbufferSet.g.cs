#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The CbufferSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class CbufferSet : SpatialSet
    {
        internal CbufferSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public bool Contained(CbufferSet s2)
            => Meos.ContainedSetSet(this.Ptr, s2.Ptr);

        public bool Contains(Cbuffer cb)
            => Meos.ContainsSetCbuffer(this.Ptr, cb.Ptr);

        public bool Contains(CbufferSet s2)
            => Meos.ContainsSetSet(this.Ptr, s2.Ptr);

        public double Distance(CbufferSet s2)
            => Meos.DistanceCbuffersetCbufferset(this.Ptr, s2.Ptr);

        public Cbuffer? EndValue()
            => MEOSFactory.WrapCbuffer(Meos.CbuffersetEndValue(this.Ptr));

        public Set? Intersection(Cbuffer cb)
            => MEOSFactory.WrapSet(Meos.IntersectionSetCbuffer(this.Ptr, cb.Ptr));

        public Set? Intersection(CbufferSet s2)
            => MEOSFactory.WrapSet(Meos.IntersectionSetSet(this.Ptr, s2.Ptr));

        public Set? Minus(Cbuffer cb)
            => MEOSFactory.WrapSet(Meos.MinusSetCbuffer(this.Ptr, cb.Ptr));

        public Set? Minus(CbufferSet s2)
            => MEOSFactory.WrapSet(Meos.MinusSetSet(this.Ptr, s2.Ptr));

        public new string Out(int maxdd)
            => Meos.CbuffersetOut(this.Ptr, maxdd);

        public bool Overlaps(CbufferSet s2)
            => Meos.OverlapsSetSet(this.Ptr, s2.Ptr);

        public Cbuffer? StartValue()
            => MEOSFactory.WrapCbuffer(Meos.CbuffersetStartValue(this.Ptr));

        public Set? Union(Cbuffer cb)
            => MEOSFactory.WrapSet(Meos.UnionSetCbuffer(this.Ptr, cb.Ptr));

        public Set? Union(CbufferSet s2)
            => MEOSFactory.WrapSet(Meos.UnionSetSet(this.Ptr, s2.Ptr));

        public Cbuffer? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.CbuffersetValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSFactory.WrapCbuffer(Marshal.ReadIntPtr(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public Cbuffer?[] Values()
            => MEOSFactory.WrapCbufferArray(Meos.CbuffersetValues(this.Ptr));

        public static Set? FromEWKB(byte[] wkb)
            => Set.FromWKB(wkb);

        public static Set? FromEWKT(string str)
            => CbufferSet.In(str);

        public static Set? FromHexEWKB(string hexwkb)
            => Set.FromHexWKB(hexwkb);

        public static Set? FromText(string str)
            => CbufferSet.In(str);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.CbuffersetIn(str));

        public static Set? Make(Cbuffer[] values)
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
