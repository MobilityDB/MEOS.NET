#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A cell of the Quadbin grid, the base type of TQuadbin and QuadbinSet, passed by value as H3Index is.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public readonly record struct Quadbin
    {
        /// <summary>The <c>Quadbin</c> MEOS passes this value as.</summary>
        internal readonly ulong value;

        /// <summary>The Quadbin MEOS passes as <paramref name="value"/>.</summary>
        public Quadbin(ulong value) => this.value = value;

        /// <summary>The <c>Quadbin</c> MEOS passes this value as.</summary>
        public static explicit operator ulong(Quadbin self) => self.value;

        /// <summary>The Quadbin MEOS passes as <paramref name="value"/>.</summary>
        public static explicit operator Quadbin(ulong value) => new Quadbin(value);

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public string AsHexWKB(byte variant)
            => Meos.QuadbinAsHexwkb(this.value, variant);

        public string AsText()
            => this.Out();

        public byte[]? AsWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.QuadbinAsWkb(this.value, variant, _size_out);
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
            => Meos.QuadbinCellArea(this.value);

        public Quadbin CellSibling(string direction)
            => new Quadbin(Meos.QuadbinCellSibling(this.value, direction));

        public Quadbin[] CellToChildren(uint children_resolution)
            => Array.ConvertAll(Meos.QuadbinCellToChildren(this.value, children_resolution), v => new Quadbin(v));

        public Set? CellToChildrenSet(int children_resolution)
            => MEOSFactory.WrapSet(Meos.QuadbinCellToChildrenSet(this.value, children_resolution));

        public Set? CellToCover(int resolution)
            => MEOSFactory.WrapSet(Meos.QuadbinCellToCover(this.value, resolution));

        public Geo? CellToGeom()
            => MEOSFactory.WrapGeo(Meos.QuadbinCellToGeom(this.value));

        public Geo? CellToGeompoint()
            => MEOSFactory.WrapGeo(Meos.QuadbinCellToGeompoint(this.value));

        public Quadbin CellToParent(uint parent_resolution)
            => new Quadbin(Meos.QuadbinCellToParent(this.value, parent_resolution));

        public string CellToQuadkey()
            => Meos.QuadbinCellToQuadkey(this.value);

        public int[] CellToTile()
            => Meos.QuadbinCellToTile(this.value);

        public int Cmp(Quadbin b)
            => Meos.QuadbinCmp(this.value, b.value);

        public bool Eq(Quadbin b)
            => Meos.QuadbinEq(this.value, b.value);

        public bool Ge(Quadbin b)
            => Meos.QuadbinGe(this.value, b.value);

        public uint GetResolution()
            => Meos.QuadbinGetResolution(this.value);

        public Set? GridDisk(int k)
            => MEOSFactory.WrapSet(Meos.QuadbinGridDisk(this.value, k));

        public bool Gt(Quadbin b)
            => Meos.QuadbinGt(this.value, b.value);

        public uint Hash()
            => Meos.QuadbinHash(this.value);

        public ulong HashExtended(ulong seed)
            => Meos.QuadbinHashExtended(this.value, seed);

        public string IndexToString()
            => Meos.QuadbinIndexToString(this.value);

        public bool IsValidCell()
            => Meos.QuadbinIsValidCell(this.value);

        public bool IsValidIndex()
            => Meos.QuadbinIsValidIndex(this.value);

        public Quadbin[] KRing(int k)
            => Array.ConvertAll(Meos.QuadbinKRing(this.value, k), v => new Quadbin(v));

        public bool Le(Quadbin b)
            => Meos.QuadbinLe(this.value, b.value);

        public bool Lt(Quadbin b)
            => Meos.QuadbinLt(this.value, b.value);

        public bool Ne(Quadbin b)
            => Meos.QuadbinNe(this.value, b.value);

        public string Out()
            => Meos.QuadbinOut(this.value);

        public STBox? TimestamptzToStbox(DateTime t)
            => MEOSFactory.WrapSTBox(Meos.QuadbinTimestamptzToStbox(this.value, MEOSConvert.ToTimestampTz(t)));

        public Set? ToSet()
            => MEOSFactory.WrapSet(Meos.QuadbinToSet(this.value));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.QuadbinToStbox(this.value));

        public STBox? TstzspanToStbox(Span s)
            => MEOSFactory.WrapSTBox(Meos.QuadbinTstzspanToStbox(this.value, s.Ptr));

        public static Quadbin FromHexWKB(string hexwkb)
            => new Quadbin(Meos.QuadbinFromHexwkb(hexwkb));

        public static Quadbin FromText(string str)
            => Quadbin.In(str);

        public static Quadbin FromWKB(byte[] wkb)
        {
            GCHandle _wkb = GCHandle.Alloc(wkb, GCHandleType.Pinned);
            try
            {
                return new Quadbin(Meos.QuadbinFromWkb(_wkb.AddrOfPinnedObject(), (ulong) wkb.Length));
            }
            finally
            {
                _wkb.Free();
            }
        }

        public static Quadbin In(string str)
            => new Quadbin(Meos.QuadbinIn(str));

        public static Quadbin PointToCell(double longitude, double latitude, uint resolution)
            => new Quadbin(Meos.QuadbinPointToCell(longitude, latitude, resolution));

        public static Quadbin StringToIndex(string str)
            => new Quadbin(Meos.QuadbinStringToIndex(str));

        public static Quadbin TileToCell(uint x, uint y, uint z)
            => new Quadbin(Meos.QuadbinTileToCell(x, y, z));

    }
}
