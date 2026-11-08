#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The PCPointSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class PCPointSet : SpatialSet
    {
        internal PCPointSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public bool Contained(PCPointSet s2)
            => Meos.ContainedSetSet(this.Ptr, s2.Ptr);

        public bool Contains(PCPoint pt)
            => Meos.ContainsSetPcpoint(this.Ptr, pt.Ptr);

        public bool Contains(PCPointSet s2)
            => Meos.ContainsSetSet(this.Ptr, s2.Ptr);

        public PCPoint? EndValue()
            => MEOSFactory.WrapPCPoint(Meos.PcpointsetEndValue(this.Ptr));

        public Set? Intersection(PCPoint pt)
            => MEOSFactory.WrapSet(Meos.IntersectionSetPcpoint(this.Ptr, pt.Ptr));

        public Set? Intersection(PCPointSet s2)
            => MEOSFactory.WrapSet(Meos.IntersectionSetSet(this.Ptr, s2.Ptr));

        public Set? Minus(PCPoint pt)
            => MEOSFactory.WrapSet(Meos.MinusSetPcpoint(this.Ptr, pt.Ptr));

        public Set? Minus(PCPointSet s2)
            => MEOSFactory.WrapSet(Meos.MinusSetSet(this.Ptr, s2.Ptr));

        public new string Out(int maxdd)
            => Meos.PcpointsetOut(this.Ptr, maxdd);

        public bool Overlaps(PCPointSet s2)
            => Meos.OverlapsSetSet(this.Ptr, s2.Ptr);

        public PCPoint? StartValue()
            => MEOSFactory.WrapPCPoint(Meos.PcpointsetStartValue(this.Ptr));

        public Set? Union(PCPoint pt)
            => MEOSFactory.WrapSet(Meos.UnionSetPcpoint(this.Ptr, pt.Ptr));

        public Set? Union(PCPointSet s2)
            => MEOSFactory.WrapSet(Meos.UnionSetSet(this.Ptr, s2.Ptr));

        public PCPoint? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.PcpointsetValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSFactory.WrapPCPoint(Marshal.ReadIntPtr(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public PCPoint?[] Values()
            => MEOSFactory.WrapPCPointArray(Meos.PcpointsetValues(this.Ptr));

        public static Set? FromEWKB(byte[] wkb)
            => Set.FromWKB(wkb);

        public static Set? FromEWKT(string str)
            => PCPointSet.In(str);

        public static Set? FromHexEWKB(string hexwkb)
            => Set.FromHexWKB(hexwkb);

        public static Set? FromText(string str)
            => PCPointSet.In(str);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.PcpointsetIn(str));

        public static Set? Make(PCPoint[] values)
        {
            IntPtr[] _valuesValues = new IntPtr[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                _valuesValues[i] = values[i].Ptr;
            }

            GCHandle _values = GCHandle.Alloc(_valuesValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.PcpointsetMake(_values.AddrOfPinnedObject(), values.Length));
            }
            finally
            {
                _values.Free();
            }
        }

    }
}
