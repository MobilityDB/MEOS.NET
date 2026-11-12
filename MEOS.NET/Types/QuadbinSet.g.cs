#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The QuadbinSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class QuadbinSet : SpatialSet
    {
        internal QuadbinSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out(15);

        public Set? CompactCells()
            => MEOSFactory.WrapSet(Meos.QuadbinsetCompactCells(this.Ptr));

        public bool Contained(QuadbinSet s2)
            => Meos.ContainedSetSet(this.Ptr, s2.Ptr);

        public bool Contains(Quadbin cell)
            => Meos.ContainsSetQuadbin(this.Ptr, cell.value);

        public bool Contains(QuadbinSet s2)
            => Meos.ContainsSetSet(this.Ptr, s2.Ptr);

        public Set? CoverCells(int resolution)
            => MEOSFactory.WrapSet(Meos.QuadbinsetCoverCells(this.Ptr, resolution));

        public Quadbin EndValue()
            => new Quadbin(Meos.QuadbinsetEndValue(this.Ptr));

        public int EverEq(TQuadbin tqb)
            => Meos.EverEqQuadbinsetTquadbin(this.Ptr, tqb.Ptr);

        public Set? GridDisk(int k)
            => MEOSFactory.WrapSet(Meos.QuadbinsetGridDisk(this.Ptr, k));

        public Set? Intersection(Quadbin cell)
            => MEOSFactory.WrapSet(Meos.IntersectionSetQuadbin(this.Ptr, cell.value));

        public Set? Intersection(QuadbinSet s2)
            => MEOSFactory.WrapSet(Meos.IntersectionSetSet(this.Ptr, s2.Ptr));

        public Set? Minus(Quadbin cell)
            => MEOSFactory.WrapSet(Meos.MinusSetQuadbin(this.Ptr, cell.value));

        public Set? Minus(QuadbinSet s2)
            => MEOSFactory.WrapSet(Meos.MinusSetSet(this.Ptr, s2.Ptr));

        public bool Overlaps(QuadbinSet s2)
            => Meos.OverlapsSetSet(this.Ptr, s2.Ptr);

        public bool Rcontained(Quadbin cell)
            => Meos.ContainedQuadbinSet(cell.value, this.Ptr);

        public Set? Rintersection(Quadbin cell)
            => MEOSFactory.WrapSet(Meos.IntersectionQuadbinSet(cell.value, this.Ptr));

        public Set? Rminus(Quadbin cell)
            => MEOSFactory.WrapSet(Meos.MinusQuadbinSet(cell.value, this.Ptr));

        public Set? Runion(Quadbin cell)
            => MEOSFactory.WrapSet(Meos.UnionQuadbinSet(cell.value, this.Ptr));

        public Quadbin StartValue()
            => new Quadbin(Meos.QuadbinsetStartValue(this.Ptr));

        public Set? UncompactCells(int resolution)
            => MEOSFactory.WrapSet(Meos.QuadbinsetUncompactCells(this.Ptr, resolution));

        public Set? Union(Quadbin cell)
            => MEOSFactory.WrapSet(Meos.UnionSetQuadbin(this.Ptr, cell.value));

        public Set? Union(QuadbinSet s2)
            => MEOSFactory.WrapSet(Meos.UnionSetSet(this.Ptr, s2.Ptr));

        public Quadbin? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.QuadbinsetValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return new Quadbin(Marshal.PtrToStructure<ulong>(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public Quadbin[] Values()
            => Array.ConvertAll(Meos.QuadbinsetValues(this.Ptr), v => new Quadbin(v));

        public static Set? FromEWKB(byte[] wkb)
            => Set.FromWKB(wkb);

        public static Set? FromEWKT(string str)
            => QuadbinSet.In(str);

        public static Set? FromHexEWKB(string hexwkb)
            => Set.FromHexWKB(hexwkb);

        public static Set? FromText(string str)
            => QuadbinSet.In(str);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.QuadbinsetIn(str));

        public static Set? Make(Quadbin[] values)
        {
            GCHandle _values = GCHandle.Alloc(values, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.QuadbinsetMake(_values.AddrOfPinnedObject(), values.Length));
            }
            finally
            {
                _values.Free();
            }
        }

    }
}
