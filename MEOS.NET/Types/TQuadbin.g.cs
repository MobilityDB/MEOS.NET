#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TQuadbin class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TQuadbin : TCellIndex
    {
        internal TQuadbin(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public bool Above(TQuadbin temp2)
            => Meos.AboveTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Adjacent(TQuadbin temp2)
            => Meos.AdjacentTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool After(TQuadbin temp2)
            => Meos.AfterTspatialTspatial(this.Ptr, temp2.Ptr);

        public int AlwaysEq(ulong cell)
            => Meos.AlwaysEqTquadbinQuadbin(this.Ptr, cell);

        public int AlwaysEq(TQuadbin temp2)
            => Meos.AlwaysEqTquadbinTquadbin(this.Ptr, temp2.Ptr);

        public int AlwaysNe(ulong cell)
            => Meos.AlwaysNeTquadbinQuadbin(this.Ptr, cell);

        public int AlwaysNe(TQuadbin temp2)
            => Meos.AlwaysNeTquadbinTquadbin(this.Ptr, temp2.Ptr);

        public Temporal? AtValue(ulong cell)
            => MEOSFactory.WrapTemporal(Meos.TquadbinAtValue(this.Ptr, cell));

        public bool Before(TQuadbin temp2)
            => Meos.BeforeTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Below(TQuadbin temp2)
            => Meos.BelowTspatialTspatial(this.Ptr, temp2.Ptr);

        public Temporal? CellToQuadkey()
            => MEOSFactory.WrapTemporal(Meos.TquadbinCellToQuadkey(this.Ptr));

        public bool Contained(TQuadbin temp2)
            => Meos.ContainedTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Contains(TQuadbin temp2)
            => Meos.ContainsTspatialTspatial(this.Ptr, temp2.Ptr);

        public int Edwithin(Geometry gs, double dist, bool spheroid)
            => Meos.EdwithinTgeoGeo(this.Ptr, gs.Ptr, dist, spheroid);

        public int Edwithin(TQuadbin temp2, double dist, bool spheroid)
            => Meos.EdwithinTgeoTgeo(this.Ptr, temp2.Ptr, dist, spheroid);

        public int Eintersects(Geometry gs)
            => Meos.EintersectsTgeoGeo(this.Ptr, gs.Ptr);

        public int Eintersects(TQuadbin temp2)
            => Meos.EintersectsTgeoTgeo(this.Ptr, temp2.Ptr);

        public ulong EndValue()
            => Meos.TquadbinEndValue(this.Ptr);

        public int EverEq(QuadbinSet cells)
            => Meos.EverEqTquadbinQuadbinset(this.Ptr, cells.Ptr);

        public int EverEq(ulong cell)
            => Meos.EverEqTquadbinQuadbin(this.Ptr, cell);

        public int EverEq(TQuadbin temp2)
            => Meos.EverEqTquadbinTquadbin(this.Ptr, temp2.Ptr);

        public int EverNe(ulong cell)
            => Meos.EverNeTquadbinQuadbin(this.Ptr, cell);

        public int EverNe(TQuadbin temp2)
            => Meos.EverNeTquadbinTquadbin(this.Ptr, temp2.Ptr);

        public Temporal? GridDistance(Temporal dest)
            => MEOSFactory.WrapTemporal(Meos.TquadbinGridDistance(this.Ptr, dest.Ptr));

        public bool Left(TQuadbin temp2)
            => Meos.LeftTspatialTspatial(this.Ptr, temp2.Ptr);

        public Temporal? MinusValue(ulong cell)
            => MEOSFactory.WrapTemporal(Meos.TquadbinMinusValue(this.Ptr, cell));

        public string Out()
            => Meos.TquadbinOut(this.Ptr);

        public bool Overabove(TQuadbin temp2)
            => Meos.OveraboveTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overafter(TQuadbin temp2)
            => Meos.OverafterTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overbefore(TQuadbin temp2)
            => Meos.OverbeforeTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overbelow(TQuadbin temp2)
            => Meos.OverbelowTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overlaps(TQuadbin temp2)
            => Meos.OverlapsTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overleft(TQuadbin temp2)
            => Meos.OverleftTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overright(TQuadbin temp2)
            => Meos.OverrightTspatialTspatial(this.Ptr, temp2.Ptr);

        public int RalwaysEq(ulong cell)
            => Meos.AlwaysEqQuadbinTquadbin(cell, this.Ptr);

        public int RalwaysNe(ulong cell)
            => Meos.AlwaysNeQuadbinTquadbin(cell, this.Ptr);

        public int ReverEq(ulong cell)
            => Meos.EverEqQuadbinTquadbin(cell, this.Ptr);

        public int ReverNe(ulong cell)
            => Meos.EverNeQuadbinTquadbin(cell, this.Ptr);

        public bool Right(TQuadbin temp2)
            => Meos.RightTspatialTspatial(this.Ptr, temp2.Ptr);

        public Temporal? Rteq(ulong cell)
            => MEOSFactory.WrapTemporal(Meos.TeqQuadbinTquadbin(cell, this.Ptr));

        public Temporal? Rtne(ulong cell)
            => MEOSFactory.WrapTemporal(Meos.TneQuadbinTquadbin(cell, this.Ptr));

        public bool Same(TQuadbin temp2)
            => Meos.SameTspatialTspatial(this.Ptr, temp2.Ptr);

        public ulong StartValue()
            => Meos.TquadbinStartValue(this.Ptr);

        public Temporal? Teq(ulong cell)
            => MEOSFactory.WrapTemporal(Meos.TeqTquadbinQuadbin(this.Ptr, cell));

        public Temporal? Teq(TQuadbin temp2)
            => MEOSFactory.WrapTemporal(Meos.TeqTquadbinTquadbin(this.Ptr, temp2.Ptr));

        public Temporal? Tne(ulong cell)
            => MEOSFactory.WrapTemporal(Meos.TneTquadbinQuadbin(this.Ptr, cell));

        public Temporal? Tne(TQuadbin temp2)
            => MEOSFactory.WrapTemporal(Meos.TneTquadbinTquadbin(this.Ptr, temp2.Ptr));

        public Temporal? ToTbigint()
            => MEOSFactory.WrapTemporal(Meos.TquadbinToTbigint(this.Ptr));

        public Temporal? ToTgeogpoint()
            => MEOSFactory.WrapTemporal(Meos.TquadbinToTgeogpoint(this.Ptr));

        public (SpanSet?[], ulong[]) Unnest()
        {
            var _answered = Meos.TquadbinUnnest(this.Ptr);

            return (MEOSFactory.WrapSpanSetArray(_answered.Item1), _answered.Item2);
        }

        public ulong Value()
            => Meos.TquadbinValue(this.Ptr);

        public ulong? ValueAtTimestamptz(DateTime t, bool strict)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TquadbinValueAtTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict, _result))
                {
                    return null;
                }

                return Marshal.PtrToStructure<ulong>(_result);
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public ulong? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TquadbinValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return Marshal.PtrToStructure<ulong>(_result);
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public ulong[] Values()
            => Meos.TquadbinValues(this.Ptr);

        public static Temporal? FromBaseTemp(ulong value, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.TquadbinFromBaseTemp(value, temp.Ptr));

        public static Temporal? FromEWKB(byte[] wkb)
            => Temporal.FromWKB(wkb);

        public static Temporal? FromEWKT(string str)
            => TQuadbin.In(str);

        public static Temporal? FromHexEWKB(string hexwkb)
            => Temporal.FromHexWKB(hexwkb);

        public static Temporal? FromMFJSON(string mfjson)
            => MEOSFactory.WrapTemporal(Meos.TquadbinFromMfjson(mfjson));

        public static Temporal? FromText(string str)
            => TQuadbin.In(str);

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TquadbinIn(str));

        public static Temporal? Make(ulong value, DateTime t)
            => MEOSFactory.WrapTemporal(Meos.TquadbinMake(value, MEOSConvert.ToTimestampTz(t)));

    }
}
