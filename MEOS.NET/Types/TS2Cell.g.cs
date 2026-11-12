#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TS2Cell class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TS2Cell : TCellIndex
    {
        internal TS2Cell(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out(15);

        public bool Above(TS2Cell temp2)
            => Meos.AboveTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Adjacent(TS2Cell temp2)
            => Meos.AdjacentTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool After(TS2Cell temp2)
            => Meos.AfterTspatialTspatial(this.Ptr, temp2.Ptr);

        public int AlwaysEq(S2Cell cell)
            => Meos.AlwaysEqTs2cellS2cell(this.Ptr, cell.value);

        public int AlwaysEq(TS2Cell temp2)
            => Meos.AlwaysEqTs2cellTs2cell(this.Ptr, temp2.Ptr);

        public int AlwaysNe(S2Cell cell)
            => Meos.AlwaysNeTs2cellS2cell(this.Ptr, cell.value);

        public int AlwaysNe(TS2Cell temp2)
            => Meos.AlwaysNeTs2cellTs2cell(this.Ptr, temp2.Ptr);

        public Temporal? AtValue(S2Cell cell)
            => MEOSFactory.WrapTemporal(Meos.Ts2cellAtValue(this.Ptr, cell.value));

        public bool Before(TS2Cell temp2)
            => Meos.BeforeTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Below(TS2Cell temp2)
            => Meos.BelowTspatialTspatial(this.Ptr, temp2.Ptr);

        public Temporal? CellToToken()
            => MEOSFactory.WrapTemporal(Meos.Ts2cellCellToToken(this.Ptr));

        public bool Contained(TS2Cell temp2)
            => Meos.ContainedTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Contains(TS2Cell temp2)
            => Meos.ContainsTspatialTspatial(this.Ptr, temp2.Ptr);

        public S2Cell EndValue()
            => new S2Cell(Meos.Ts2cellEndValue(this.Ptr));

        public int EverEq(S2CellSet cells)
            => Meos.EverEqTs2cellS2cellset(this.Ptr, cells.Ptr);

        public int EverEq(S2Cell cell)
            => Meos.EverEqTs2cellS2cell(this.Ptr, cell.value);

        public int EverEq(TS2Cell temp2)
            => Meos.EverEqTs2cellTs2cell(this.Ptr, temp2.Ptr);

        public int EverNe(S2Cell cell)
            => Meos.EverNeTs2cellS2cell(this.Ptr, cell.value);

        public int EverNe(TS2Cell temp2)
            => Meos.EverNeTs2cellTs2cell(this.Ptr, temp2.Ptr);

        public Temporal? GridDistance(Temporal dest)
            => MEOSFactory.WrapTemporal(Meos.Ts2cellGridDistance(this.Ptr, dest.Ptr));

        public bool Left(TS2Cell temp2)
            => Meos.LeftTspatialTspatial(this.Ptr, temp2.Ptr);

        public Temporal? MinusValue(S2Cell cell)
            => MEOSFactory.WrapTemporal(Meos.Ts2cellMinusValue(this.Ptr, cell.value));

        public bool Overabove(TS2Cell temp2)
            => Meos.OveraboveTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overafter(TS2Cell temp2)
            => Meos.OverafterTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overbefore(TS2Cell temp2)
            => Meos.OverbeforeTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overbelow(TS2Cell temp2)
            => Meos.OverbelowTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overlaps(TS2Cell temp2)
            => Meos.OverlapsTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overleft(TS2Cell temp2)
            => Meos.OverleftTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overright(TS2Cell temp2)
            => Meos.OverrightTspatialTspatial(this.Ptr, temp2.Ptr);

        public int RalwaysEq(S2Cell cell)
            => Meos.AlwaysEqS2cellTs2cell(cell.value, this.Ptr);

        public int RalwaysNe(S2Cell cell)
            => Meos.AlwaysNeS2cellTs2cell(cell.value, this.Ptr);

        public int ReverEq(S2Cell cell)
            => Meos.EverEqS2cellTs2cell(cell.value, this.Ptr);

        public int ReverNe(S2Cell cell)
            => Meos.EverNeS2cellTs2cell(cell.value, this.Ptr);

        public bool Right(TS2Cell temp2)
            => Meos.RightTspatialTspatial(this.Ptr, temp2.Ptr);

        public Temporal? Rteq(S2Cell cell)
            => MEOSFactory.WrapTemporal(Meos.TeqS2cellTs2cell(cell.value, this.Ptr));

        public Temporal? Rtne(S2Cell cell)
            => MEOSFactory.WrapTemporal(Meos.TneS2cellTs2cell(cell.value, this.Ptr));

        public bool Same(TS2Cell temp2)
            => Meos.SameTspatialTspatial(this.Ptr, temp2.Ptr);

        public S2Cell StartValue()
            => new S2Cell(Meos.Ts2cellStartValue(this.Ptr));

        public Temporal? Teq(S2Cell cell)
            => MEOSFactory.WrapTemporal(Meos.TeqTs2cellS2cell(this.Ptr, cell.value));

        public Temporal? Teq(TS2Cell temp2)
            => MEOSFactory.WrapTemporal(Meos.TeqTs2cellTs2cell(this.Ptr, temp2.Ptr));

        public Temporal? Tne(S2Cell cell)
            => MEOSFactory.WrapTemporal(Meos.TneTs2cellS2cell(this.Ptr, cell.value));

        public Temporal? Tne(TS2Cell temp2)
            => MEOSFactory.WrapTemporal(Meos.TneTs2cellTs2cell(this.Ptr, temp2.Ptr));

        public Temporal? ToTbigint()
            => MEOSFactory.WrapTemporal(Meos.Ts2cellToTbigint(this.Ptr));

        public Temporal? ToTgeompoint()
            => MEOSFactory.WrapTemporal(Meos.Ts2cellToTgeompoint(this.Ptr));

        public (SpanSet?[], S2Cell[]) Unnest()
        {
            var _answered = Meos.Ts2cellUnnest(this.Ptr);

            return (MEOSFactory.WrapSpanSetArray(_answered.Item1), Array.ConvertAll(_answered.Item2, v => new S2Cell(v)));
        }

        public S2Cell Value()
            => new S2Cell(Meos.Ts2cellValue(this.Ptr));

        public S2Cell? ValueAtTimestamptz(DateTime t, bool strict)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.Ts2cellValueAtTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict, _result))
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

        public S2Cell? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.Ts2cellValueN(this.Ptr, n, _result))
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
            => Array.ConvertAll(Meos.Ts2cellValues(this.Ptr), v => new S2Cell(v));

        public static Temporal? FromBaseTemp(S2Cell value, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.Ts2cellFromBaseTemp(value.value, temp.Ptr));

        public static Temporal? FromEWKB(byte[] wkb)
            => Temporal.FromWKB(wkb);

        public static Temporal? FromEWKT(string str)
            => TS2Cell.In(str);

        public static Temporal? FromHexEWKB(string hexwkb)
            => Temporal.FromHexWKB(hexwkb);

        public static Temporal? FromMFJSON(string mfjson)
            => MEOSFactory.WrapTemporal(Meos.Ts2cellFromMfjson(mfjson));

        public static Temporal? FromText(string str)
            => TS2Cell.In(str);

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.Ts2cellIn(str));

    }
}
