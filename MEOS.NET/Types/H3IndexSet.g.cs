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
            => this.AsText(15);

        public bool Contained(H3IndexSet s2)
            => Meos.ContainedSetSet(this.Ptr, s2.Ptr);

        public bool Contains(H3Index cell)
            => Meos.ContainsSetH3index(this.Ptr, cell.value);

        public bool Contains(H3IndexSet s2)
            => Meos.ContainsSetSet(this.Ptr, s2.Ptr);

        public Set? CoverCells(int resolution)
            => MEOSFactory.WrapSet(Meos.H3indexsetCoverCells(this.Ptr, resolution));

        public H3Index EndValue()
            => new H3Index(Meos.H3indexsetEndValue(this.Ptr));

        public int EverEq(TH3Index th3idx)
            => Meos.EverEqH3indexsetTh3index(this.Ptr, th3idx.Ptr);

        public Set? GridDisk(int k)
            => MEOSFactory.WrapSet(Meos.H3indexsetGridDisk(this.Ptr, k));

        public Set? Intersection(H3Index cell)
            => MEOSFactory.WrapSet(Meos.IntersectionSetH3index(this.Ptr, cell.value));

        public Set? Intersection(H3IndexSet s2)
            => MEOSFactory.WrapSet(Meos.IntersectionSetSet(this.Ptr, s2.Ptr));

        public Set? Minus(H3Index cell)
            => MEOSFactory.WrapSet(Meos.MinusSetH3index(this.Ptr, cell.value));

        public Set? Minus(H3IndexSet s2)
            => MEOSFactory.WrapSet(Meos.MinusSetSet(this.Ptr, s2.Ptr));

        public bool Overlaps(H3IndexSet s2)
            => Meos.OverlapsSetSet(this.Ptr, s2.Ptr);

        public bool Rcontained(H3Index cell)
            => Meos.ContainedH3indexSet(cell.value, this.Ptr);

        public Set? Rintersection(H3Index cell)
            => MEOSFactory.WrapSet(Meos.IntersectionH3indexSet(cell.value, this.Ptr));

        public Set? Rminus(H3Index cell)
            => MEOSFactory.WrapSet(Meos.MinusH3indexSet(cell.value, this.Ptr));

        public Set? Runion(H3Index cell)
            => MEOSFactory.WrapSet(Meos.UnionH3indexSet(cell.value, this.Ptr));

        public H3Index StartValue()
            => new H3Index(Meos.H3indexsetStartValue(this.Ptr));

        public Set? Union(H3Index cell)
            => MEOSFactory.WrapSet(Meos.UnionSetH3index(this.Ptr, cell.value));

        public Set? Union(H3IndexSet s2)
            => MEOSFactory.WrapSet(Meos.UnionSetSet(this.Ptr, s2.Ptr));

        public H3Index? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.H3indexsetValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return new H3Index(Marshal.PtrToStructure<ulong>(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public H3Index[] Values()
            => Array.ConvertAll(Meos.H3indexsetValues(this.Ptr), v => new H3Index(v));

        public static Set? FromEWKB(byte[] wkb)
            => Set.FromWKB(wkb);

        public static Set? FromEWKT(string str)
            => H3IndexSet.FromText(str);

        public static Set? FromHexEWKB(string hexwkb)
            => Set.FromHexWKB(hexwkb);

        public static Set? FromText(string str)
            => MEOSFactory.WrapSet(Meos.H3indexsetIn(str));

        public static Set? Make(H3Index[] values)
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
