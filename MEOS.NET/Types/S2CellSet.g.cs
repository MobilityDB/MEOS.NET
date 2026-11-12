#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The S2CellSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class S2CellSet : SpatialSet
    {
        internal S2CellSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out(15);

        public Set? CompactCells()
            => MEOSFactory.WrapSet(Meos.S2cellsetCompactCells(this.Ptr));

        public bool Contained(S2CellSet s2)
            => Meos.ContainedSetSet(this.Ptr, s2.Ptr);

        public bool Contains(S2Cell cell)
            => Meos.ContainsSetS2cell(this.Ptr, cell.value);

        public bool Contains(S2CellSet s2)
            => Meos.ContainsSetSet(this.Ptr, s2.Ptr);

        public Set? CoverCells(int resolution)
            => MEOSFactory.WrapSet(Meos.S2cellsetCoverCells(this.Ptr, resolution));

        public S2Cell EndValue()
            => new S2Cell(Meos.S2cellsetEndValue(this.Ptr));

        public int EverEq(TS2Cell temp)
            => Meos.EverEqS2cellsetTs2cell(this.Ptr, temp.Ptr);

        public Set? Intersection(S2Cell cell)
            => MEOSFactory.WrapSet(Meos.IntersectionSetS2cell(this.Ptr, cell.value));

        public Set? Intersection(S2CellSet s2)
            => MEOSFactory.WrapSet(Meos.IntersectionSetSet(this.Ptr, s2.Ptr));

        public Set? Minus(S2Cell cell)
            => MEOSFactory.WrapSet(Meos.MinusSetS2cell(this.Ptr, cell.value));

        public Set? Minus(S2CellSet s2)
            => MEOSFactory.WrapSet(Meos.MinusSetSet(this.Ptr, s2.Ptr));

        public bool Overlaps(S2CellSet s2)
            => Meos.OverlapsSetSet(this.Ptr, s2.Ptr);

        public bool Rcontained(S2Cell cell)
            => Meos.ContainedS2cellSet(cell.value, this.Ptr);

        public Set? Rintersection(S2Cell cell)
            => MEOSFactory.WrapSet(Meos.IntersectionS2cellSet(cell.value, this.Ptr));

        public Set? Rminus(S2Cell cell)
            => MEOSFactory.WrapSet(Meos.MinusS2cellSet(cell.value, this.Ptr));

        public Set? Runion(S2Cell cell)
            => MEOSFactory.WrapSet(Meos.UnionS2cellSet(cell.value, this.Ptr));

        public S2Cell StartValue()
            => new S2Cell(Meos.S2cellsetStartValue(this.Ptr));

        public Set? UncompactCells(int resolution)
            => MEOSFactory.WrapSet(Meos.S2cellsetUncompactCells(this.Ptr, resolution));

        public Set? Union(S2Cell cell)
            => MEOSFactory.WrapSet(Meos.UnionSetS2cell(this.Ptr, cell.value));

        public Set? Union(S2CellSet s2)
            => MEOSFactory.WrapSet(Meos.UnionSetSet(this.Ptr, s2.Ptr));

        public S2Cell? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.S2cellsetValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return new S2Cell(Marshal.PtrToStructure<ulong>(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public S2Cell[] Values()
            => Array.ConvertAll(Meos.S2cellsetValues(this.Ptr), v => new S2Cell(v));

        public static Set? FromEWKB(byte[] wkb)
            => Set.FromWKB(wkb);

        public static Set? FromEWKT(string str)
            => S2CellSet.In(str);

        public static Set? FromHexEWKB(string hexwkb)
            => Set.FromHexWKB(hexwkb);

        public static Set? FromText(string str)
            => S2CellSet.In(str);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.S2cellsetIn(str));

        public static Set? Make(S2Cell[] values)
        {
            GCHandle _values = GCHandle.Alloc(values, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.S2cellsetMake(_values.AddrOfPinnedObject(), values.Length));
            }
            finally
            {
                _values.Free();
            }
        }

    }
}
