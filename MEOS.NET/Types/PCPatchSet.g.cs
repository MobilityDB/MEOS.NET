#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The PCPatchSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class PCPatchSet : SpatialSet
    {
        internal PCPatchSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public bool Contained(PCPatchSet s2)
            => Meos.ContainedSetSet(this.Ptr, s2.Ptr);

        public bool Contains(PCPatch pa)
            => Meos.ContainsSetPcpatch(this.Ptr, pa.Ptr);

        public bool Contains(PCPatchSet s2)
            => Meos.ContainsSetSet(this.Ptr, s2.Ptr);

        public PCPatch? EndValue()
            => MEOSFactory.WrapPCPatch(Meos.PcpatchsetEndValue(this.Ptr));

        public Set? Intersection(PCPatch pa)
            => MEOSFactory.WrapSet(Meos.IntersectionSetPcpatch(this.Ptr, pa.Ptr));

        public Set? Intersection(PCPatchSet s2)
            => MEOSFactory.WrapSet(Meos.IntersectionSetSet(this.Ptr, s2.Ptr));

        public Set? Minus(PCPatch pa)
            => MEOSFactory.WrapSet(Meos.MinusSetPcpatch(this.Ptr, pa.Ptr));

        public Set? Minus(PCPatchSet s2)
            => MEOSFactory.WrapSet(Meos.MinusSetSet(this.Ptr, s2.Ptr));

        public bool Overlaps(PCPatchSet s2)
            => Meos.OverlapsSetSet(this.Ptr, s2.Ptr);

        public PCPatch? StartValue()
            => MEOSFactory.WrapPCPatch(Meos.PcpatchsetStartValue(this.Ptr));

        public Set? Union(PCPatch pa)
            => MEOSFactory.WrapSet(Meos.UnionSetPcpatch(this.Ptr, pa.Ptr));

        public Set? Union(PCPatchSet s2)
            => MEOSFactory.WrapSet(Meos.UnionSetSet(this.Ptr, s2.Ptr));

        public PCPatch? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.PcpatchsetValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSFactory.WrapPCPatch(Marshal.ReadIntPtr(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public PCPatch?[] Values()
            => MEOSFactory.WrapPCPatchArray(Meos.PcpatchsetValues(this.Ptr));

        public static Set? FromEWKB(byte[] wkb)
            => Set.FromWKB(wkb);

        public static Set? FromEWKT(string str)
            => PCPatchSet.FromText(str);

        public static Set? FromHexEWKB(string hexwkb)
            => Set.FromHexWKB(hexwkb);

        public static Set? FromText(string str)
            => MEOSFactory.WrapSet(Meos.PcpatchsetIn(str));

        public static Set? Make(PCPatch[] values)
        {
            IntPtr[] _valuesValues = new IntPtr[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                _valuesValues[i] = values[i].Ptr;
            }

            GCHandle _values = GCHandle.Alloc(_valuesValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.PcpatchsetMake(_values.AddrOfPinnedObject(), values.Length));
            }
            finally
            {
                _values.Free();
            }
        }

    }
}
