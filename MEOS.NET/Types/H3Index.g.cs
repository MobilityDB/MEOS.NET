#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A cell of the H3 grid, the base type of TH3Index and H3IndexSet. MEOS passes it by value, as a uint64; it is a class all the same because it reads and writes formats of its own (text, WKB, hex WKB), and every type a binding exposes has its readers and writers.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public readonly record struct H3Index
    {
        /// <summary>The <c>H3Index</c> MEOS passes this value as.</summary>
        internal readonly ulong value;

        /// <summary>The H3Index MEOS passes as <paramref name="value"/>.</summary>
        public H3Index(ulong value) => this.value = value;

        /// <summary>The <c>H3Index</c> MEOS passes this value as.</summary>
        public static explicit operator ulong(H3Index self) => self.value;

        /// <summary>The H3Index MEOS passes as <paramref name="value"/>.</summary>
        public static explicit operator H3Index(ulong value) => new H3Index(value);

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public string AsHexWKB(byte variant)
            => Meos.H3indexAsHexwkb(this.value, variant);

        public string AsText()
            => this.Out();

        public byte[]? AsWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.H3indexAsWkb(this.value, variant, _size_out);
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
            => Meos.H3indexCellArea(this.value);

        public Geo? CellToBoundary()
            => MEOSFactory.WrapGeo(Meos.H3indexCellToBoundary(this.value));

        public Set? CellToCover(int resolution)
            => MEOSFactory.WrapSet(Meos.H3indexCellToCover(this.value, resolution));

        public H3Index CellToParent(uint parent_resolution)
            => new H3Index(Meos.H3indexCellToParent(this.value, parent_resolution));

        public Geo? CellToPoint()
            => MEOSFactory.WrapGeo(Meos.H3indexCellToPoint(this.value));

        public int Cmp(H3Index b)
            => Meos.H3indexCmp(this.value, b.value);

        public bool Eq(H3Index b)
            => Meos.H3indexEq(this.value, b.value);

        public bool Ge(H3Index b)
            => Meos.H3indexGe(this.value, b.value);

        public uint GetResolution()
            => Meos.H3indexGetResolution(this.value);

        public bool Gt(H3Index b)
            => Meos.H3indexGt(this.value, b.value);

        public uint Hash()
            => Meos.H3indexHash(this.value);

        public ulong HashExtended(ulong seed)
            => Meos.H3indexHashExtended(this.value, seed);

        public bool Le(H3Index b)
            => Meos.H3indexLe(this.value, b.value);

        public bool Lt(H3Index b)
            => Meos.H3indexLt(this.value, b.value);

        public bool Ne(H3Index b)
            => Meos.H3indexNe(this.value, b.value);

        public string Out()
            => Meos.H3indexOut(this.value);

        public STBox? TimestamptzToStbox(DateTime t)
            => MEOSFactory.WrapSTBox(Meos.H3indexTimestamptzToStbox(this.value, MEOSConvert.ToTimestampTz(t)));

        public Set? ToSet()
            => MEOSFactory.WrapSet(Meos.H3indexToSet(this.value));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.H3indexToStbox(this.value));

        public STBox? TstzspanToStbox(Span s)
            => MEOSFactory.WrapSTBox(Meos.H3indexTstzspanToStbox(this.value, s.Ptr));

        public static H3Index FromHexWKB(string hexwkb)
            => new H3Index(Meos.H3indexFromHexwkb(hexwkb));

        public static H3Index FromText(string str)
            => H3Index.In(str);

        public static H3Index FromWKB(byte[] wkb)
        {
            GCHandle _wkb = GCHandle.Alloc(wkb, GCHandleType.Pinned);
            try
            {
                return new H3Index(Meos.H3indexFromWkb(_wkb.AddrOfPinnedObject(), (ulong) wkb.Length));
            }
            finally
            {
                _wkb.Free();
            }
        }

        public static H3Index In(string str)
            => new H3Index(Meos.H3indexIn(str));

    }
}
