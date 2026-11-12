#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A cell of the S2 grid, the base type of TS2Cell and S2CellSet, passed by value as H3Index is.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public readonly record struct S2Cell
    {
        /// <summary>The <c>S2CellId</c> MEOS passes this value as.</summary>
        internal readonly ulong value;

        /// <summary>The S2Cell MEOS passes as <paramref name="value"/>.</summary>
        public S2Cell(ulong value) => this.value = value;

        /// <summary>The <c>S2CellId</c> MEOS passes this value as.</summary>
        public static explicit operator ulong(S2Cell self) => self.value;

        /// <summary>The S2Cell MEOS passes as <paramref name="value"/>.</summary>
        public static explicit operator S2Cell(ulong value) => new S2Cell(value);

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText();

        public string AsHexWKB(byte variant)
            => Meos.S2cellAsHexwkb(this.value, variant);

        public string AsText()
            => Meos.S2cellOut(this.value);

        public byte[]? AsWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.S2cellAsWkb(this.value, variant, _size_out);
                if (_bytes == IntPtr.Zero)
                {
                    return null;
                }

                byte[] _wkb = new byte[Marshal.ReadInt64(_size_out)];
                Marshal.Copy(_bytes, _wkb, 0, _wkb.Length);
                return _wkb;
            }
            finally
            {
                Marshal.FreeHGlobal(_size_out);
            }
        }

        public double CellArea()
            => Meos.S2cellCellArea(this.value);

        public bool CellContains(S2Cell other)
            => Meos.S2cellCellContains(this.value, other.value);

        public S2Cell CellToChild(uint level, uint position)
            => new S2Cell(Meos.S2cellCellToChild(this.value, level, position));

        public S2Cell[] CellToChildren(uint level)
            => Array.ConvertAll(Meos.S2cellCellToChildren(this.value, level), v => new S2Cell(v));

        public Set? CellToChildrenSet(int children_level)
            => MEOSFactory.WrapSet(Meos.S2cellCellToChildrenSet(this.value, children_level));

        public Set? CellToCover(int resolution)
            => MEOSFactory.WrapSet(Meos.S2cellCellToCover(this.value, resolution));

        public Geo? CellToGeog()
            => MEOSFactory.WrapGeo(Meos.S2cellCellToGeog(this.value));

        public Geo? CellToGeogpoint()
            => MEOSFactory.WrapGeo(Meos.S2cellCellToGeogpoint(this.value));

        public S2Cell CellToParent(uint level)
            => new S2Cell(Meos.S2cellCellToParent(this.value, level));

        public string CellToToken()
            => Meos.S2cellCellToToken(this.value);

        public int Cmp(S2Cell b)
            => Meos.S2cellCmp(this.value, b.value);

        public int CommonAncestorLevel(S2Cell b)
            => Meos.S2cellCommonAncestorLevel(this.value, b.value);

        public double EdgeLength(uint edge)
            => Meos.S2cellEdgeLength(this.value, edge);

        public S2Cell[] EdgeNeighbors()
            => Array.ConvertAll(Meos.S2cellEdgeNeighbors(this.value), v => new S2Cell(v));

        public Set? EdgeNeighborsSet()
            => MEOSFactory.WrapSet(Meos.S2cellEdgeNeighborsSet(this.value));

        public bool Eq(S2Cell b)
            => Meos.S2cellEq(this.value, b.value);

        public bool Ge(S2Cell b)
            => Meos.S2cellGe(this.value, b.value);

        public uint GetFace()
            => Meos.S2cellGetFace(this.value);

        public uint GetResolution()
            => Meos.S2cellGetResolution(this.value);

        public bool Gt(S2Cell b)
            => Meos.S2cellGt(this.value, b.value);

        public uint Hash()
            => Meos.S2cellHash(this.value);

        public ulong HashExtended(ulong seed)
            => Meos.S2cellHashExtended(this.value, seed);

        public bool IsValidCell()
            => Meos.S2cellIsValidCell(this.value);

        public bool Le(S2Cell b)
            => Meos.S2cellLe(this.value, b.value);

        public bool Lt(S2Cell b)
            => Meos.S2cellLt(this.value, b.value);

        public bool Ne(S2Cell b)
            => Meos.S2cellNe(this.value, b.value);

        public S2Cell RangeMax()
            => new S2Cell(Meos.S2cellRangeMax(this.value));

        public S2Cell RangeMin()
            => new S2Cell(Meos.S2cellRangeMin(this.value));

        public STBox? TimestamptzToStbox(DateTime t)
            => MEOSFactory.WrapSTBox(Meos.S2cellTimestamptzToStbox(this.value, MEOSConvert.ToTimestampTz(t)));

        public Set? ToSet()
            => MEOSFactory.WrapSet(Meos.S2cellToSet(this.value));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.S2cellToStbox(this.value));

        public STBox? TstzspanToStbox(Span s)
            => MEOSFactory.WrapSTBox(Meos.S2cellTstzspanToStbox(this.value, s.Ptr));

        public static S2Cell FromHexWKB(string hexwkb)
            => new S2Cell(Meos.S2cellFromHexwkb(hexwkb));

        public static S2Cell FromText(string str)
            => new S2Cell(Meos.S2cellIn(str));

        public static S2Cell FromWKB(byte[] wkb)
        {
            GCHandle _wkb = GCHandle.Alloc(wkb, GCHandleType.Pinned);
            try
            {
                return new S2Cell(Meos.S2cellFromWkb(_wkb.AddrOfPinnedObject(), (ulong) wkb.Length));
            }
            finally
            {
                _wkb.Free();
            }
        }

        public static S2Cell PointToCell(double longitude, double latitude, uint level)
            => new S2Cell(Meos.S2cellPointToCell(longitude, latitude, level));

        public static S2Cell TokenToCell(string token)
            => new S2Cell(Meos.S2cellTokenToCell(token));

    }
}
