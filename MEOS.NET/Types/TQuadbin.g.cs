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
            => this.Out(15);

        public bool Above(TQuadbin temp2)
            => Meos.AboveTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Adjacent(TQuadbin temp2)
            => Meos.AdjacentTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool After(TQuadbin temp2)
            => Meos.AfterTspatialTspatial(this.Ptr, temp2.Ptr);

        public int AlwaysEq(Quadbin cell)
            => Meos.AlwaysEqTquadbinQuadbin(this.Ptr, cell.value);

        public int AlwaysEq(TQuadbin temp2)
            => Meos.AlwaysEqTquadbinTquadbin(this.Ptr, temp2.Ptr);

        public int AlwaysNe(Quadbin cell)
            => Meos.AlwaysNeTquadbinQuadbin(this.Ptr, cell.value);

        public int AlwaysNe(TQuadbin temp2)
            => Meos.AlwaysNeTquadbinTquadbin(this.Ptr, temp2.Ptr);

        public Temporal? AtValue(Quadbin cell)
            => MEOSFactory.WrapTemporal(Meos.TquadbinAtValue(this.Ptr, cell.value));

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

        public Quadbin EndValue()
            => new Quadbin(Meos.TquadbinEndValue(this.Ptr));

        public int EverEq(QuadbinSet cells)
            => Meos.EverEqTquadbinQuadbinset(this.Ptr, cells.Ptr);

        public int EverEq(Quadbin cell)
            => Meos.EverEqTquadbinQuadbin(this.Ptr, cell.value);

        public int EverEq(TQuadbin temp2)
            => Meos.EverEqTquadbinTquadbin(this.Ptr, temp2.Ptr);

        public int EverNe(Quadbin cell)
            => Meos.EverNeTquadbinQuadbin(this.Ptr, cell.value);

        public int EverNe(TQuadbin temp2)
            => Meos.EverNeTquadbinTquadbin(this.Ptr, temp2.Ptr);

        public Temporal? GridDistance(Temporal dest)
            => MEOSFactory.WrapTemporal(Meos.TquadbinGridDistance(this.Ptr, dest.Ptr));

        public bool Left(TQuadbin temp2)
            => Meos.LeftTspatialTspatial(this.Ptr, temp2.Ptr);

        public Temporal? MinusValue(Quadbin cell)
            => MEOSFactory.WrapTemporal(Meos.TquadbinMinusValue(this.Ptr, cell.value));

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

        public int RalwaysEq(Quadbin cell)
            => Meos.AlwaysEqQuadbinTquadbin(cell.value, this.Ptr);

        public int RalwaysNe(Quadbin cell)
            => Meos.AlwaysNeQuadbinTquadbin(cell.value, this.Ptr);

        public int ReverEq(Quadbin cell)
            => Meos.EverEqQuadbinTquadbin(cell.value, this.Ptr);

        public int ReverNe(Quadbin cell)
            => Meos.EverNeQuadbinTquadbin(cell.value, this.Ptr);

        public bool Right(TQuadbin temp2)
            => Meos.RightTspatialTspatial(this.Ptr, temp2.Ptr);

        public Temporal? Rteq(Quadbin cell)
            => MEOSFactory.WrapTemporal(Meos.TeqQuadbinTquadbin(cell.value, this.Ptr));

        public Temporal? Rtne(Quadbin cell)
            => MEOSFactory.WrapTemporal(Meos.TneQuadbinTquadbin(cell.value, this.Ptr));

        public bool Same(TQuadbin temp2)
            => Meos.SameTspatialTspatial(this.Ptr, temp2.Ptr);

        public Quadbin StartValue()
            => new Quadbin(Meos.TquadbinStartValue(this.Ptr));

        public Temporal? Teq(Quadbin cell)
            => MEOSFactory.WrapTemporal(Meos.TeqTquadbinQuadbin(this.Ptr, cell.value));

        public Temporal? Teq(TQuadbin temp2)
            => MEOSFactory.WrapTemporal(Meos.TeqTquadbinTquadbin(this.Ptr, temp2.Ptr));

        public Temporal? Tne(Quadbin cell)
            => MEOSFactory.WrapTemporal(Meos.TneTquadbinQuadbin(this.Ptr, cell.value));

        public Temporal? Tne(TQuadbin temp2)
            => MEOSFactory.WrapTemporal(Meos.TneTquadbinTquadbin(this.Ptr, temp2.Ptr));

        public Temporal? ToTbigint()
            => MEOSFactory.WrapTemporal(Meos.TquadbinToTbigint(this.Ptr));

        public Temporal? ToTgeogpoint()
            => MEOSFactory.WrapTemporal(Meos.TquadbinToTgeogpoint(this.Ptr));

        public (SpanSet?[], Quadbin[]) Unnest()
        {
            var _answered = Meos.TquadbinUnnest(this.Ptr);

            return (MEOSFactory.WrapSpanSetArray(_answered.Item1), Array.ConvertAll(_answered.Item2, v => new Quadbin(v)));
        }

        public Quadbin Value()
            => new Quadbin(Meos.TquadbinValue(this.Ptr));

        public Quadbin? ValueAtTimestamptz(DateTime t, bool strict)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TquadbinValueAtTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict, _result))
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

        public Quadbin? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TquadbinValueN(this.Ptr, n, _result))
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
            => Array.ConvertAll(Meos.TquadbinValues(this.Ptr), v => new Quadbin(v));

        public static Temporal? FromBaseTemp(Quadbin value, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.TquadbinFromBaseTemp(value.value, temp.Ptr));

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

    }
}
