#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The H3IndexSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class H3IndexSet : SpatialSet
    {
        internal H3IndexSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public bool Contained(H3IndexSet s2)
            => Meos.ContainedSetSet(this.Ptr, s2.Ptr);

        public bool Contains(ulong cell)
            => Meos.ContainsSetH3index(this.Ptr, cell);

        public bool Contains(H3IndexSet s2)
            => Meos.ContainsSetSet(this.Ptr, s2.Ptr);

        public Set? CoverCells(int resolution)
            => MEOSFactory.WrapSet(Meos.H3indexsetCoverCells(this.Ptr, resolution));

        public ulong EndValue()
            => Meos.H3indexsetEndValue(this.Ptr);

        public int EverEq(TH3Index th3idx)
            => Meos.EverEqH3indexsetTh3index(this.Ptr, th3idx.Ptr);

        public Set? GridDisk(int k)
            => MEOSFactory.WrapSet(Meos.H3indexsetGridDisk(this.Ptr, k));

        public Set? Intersection(ulong cell)
            => MEOSFactory.WrapSet(Meos.IntersectionSetH3index(this.Ptr, cell));

        public Set? Intersection(H3IndexSet s2)
            => MEOSFactory.WrapSet(Meos.IntersectionSetSet(this.Ptr, s2.Ptr));

        public Set? Minus(ulong cell)
            => MEOSFactory.WrapSet(Meos.MinusSetH3index(this.Ptr, cell));

        public Set? Minus(H3IndexSet s2)
            => MEOSFactory.WrapSet(Meos.MinusSetSet(this.Ptr, s2.Ptr));

        public string Out()
            => Meos.H3indexsetOut(this.Ptr);

        public bool Overlaps(H3IndexSet s2)
            => Meos.OverlapsSetSet(this.Ptr, s2.Ptr);

        public bool Rcontained(ulong cell)
            => Meos.ContainedH3indexSet(cell, this.Ptr);

        public Set? Rintersection(ulong cell)
            => MEOSFactory.WrapSet(Meos.IntersectionH3indexSet(cell, this.Ptr));

        public Set? Rminus(ulong cell)
            => MEOSFactory.WrapSet(Meos.MinusH3indexSet(cell, this.Ptr));

        public Set? Runion(ulong cell)
            => MEOSFactory.WrapSet(Meos.UnionH3indexSet(cell, this.Ptr));

        public ulong StartValue()
            => Meos.H3indexsetStartValue(this.Ptr);

        public Set? Union(ulong cell)
            => MEOSFactory.WrapSet(Meos.UnionSetH3index(this.Ptr, cell));

        public Set? Union(H3IndexSet s2)
            => MEOSFactory.WrapSet(Meos.UnionSetSet(this.Ptr, s2.Ptr));

        public ulong[] Values()
            => Meos.H3indexsetValues(this.Ptr);

        public static Set? FromEWKB(byte[] wkb)
            => Set.FromWKB(wkb);

        public static Set? FromEWKT(string str)
            => H3IndexSet.In(str);

        public static Set? FromH3index(ulong cell)
            => MEOSFactory.WrapSet(Meos.H3indexToSet(cell));

        public static Set? FromHexEWKB(string hexwkb)
            => Set.FromHexWKB(hexwkb);

        public static Set? FromText(string str)
            => H3IndexSet.In(str);

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.H3indexsetIn(str));

        public static Set? Make(ulong[] values)
        {
            GCHandle _values = GCHandle.Alloc(values, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.H3indexsetMake(_values.AddrOfPinnedObject(), values.Length));
            }
            finally
            {
                _values.Free();
            }
        }

    }
}
