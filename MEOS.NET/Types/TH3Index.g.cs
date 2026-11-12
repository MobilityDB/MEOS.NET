#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TH3Index class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TH3Index : TCellIndex
    {
        internal TH3Index(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public bool Above(TH3Index temp2)
            => Meos.AboveTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Adjacent(TH3Index temp2)
            => Meos.AdjacentTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool After(TH3Index temp2)
            => Meos.AfterTspatialTspatial(this.Ptr, temp2.Ptr);

        public int AlwaysEq(H3Index cell)
            => Meos.AlwaysEqTh3indexH3index(this.Ptr, cell.value);

        public int AlwaysEq(TH3Index temp2)
            => Meos.AlwaysEqTh3indexTh3index(this.Ptr, temp2.Ptr);

        public int AlwaysNe(H3Index cell)
            => Meos.AlwaysNeTh3indexH3index(this.Ptr, cell.value);

        public int AlwaysNe(TH3Index temp2)
            => Meos.AlwaysNeTh3indexTh3index(this.Ptr, temp2.Ptr);

        public Temporal? AreNeighborCells(Temporal dest)
            => MEOSFactory.WrapTemporal(Meos.Th3indexAreNeighborCells(this.Ptr, dest.Ptr));

        public Temporal? AtValue(H3Index cell)
            => MEOSFactory.WrapTemporal(Meos.Th3indexAtValue(this.Ptr, cell.value));

        public bool Before(TH3Index temp2)
            => Meos.BeforeTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Below(TH3Index temp2)
            => Meos.BelowTspatialTspatial(this.Ptr, temp2.Ptr);

        public Temporal? CellToCenterChild(int resolution)
            => MEOSFactory.WrapTemporal(Meos.Th3indexCellToCenterChild(this.Ptr, resolution));

        public Temporal? CellToCenterChildNext()
            => MEOSFactory.WrapTemporal(Meos.Th3indexCellToCenterChildNext(this.Ptr));

        public Temporal? CellToChildPos(int parent_res)
            => MEOSFactory.WrapTemporal(Meos.Th3indexCellToChildPos(this.Ptr, parent_res));

        public Temporal? CellToLocalIj(Temporal cell)
            => MEOSFactory.WrapTemporal(Meos.Th3indexCellToLocalIj(this.Ptr, cell.Ptr));

        public Temporal? CellToParentNext()
            => MEOSFactory.WrapTemporal(Meos.Th3indexCellToParentNext(this.Ptr));

        public Temporal? CellToVertex(int vertex_num)
            => MEOSFactory.WrapTemporal(Meos.Th3indexCellToVertex(this.Ptr, vertex_num));

        public Temporal? CellsToDirectedEdge(Temporal dest)
            => MEOSFactory.WrapTemporal(Meos.Th3indexCellsToDirectedEdge(this.Ptr, dest.Ptr));

        public Temporal? ChildPosToCell(Temporal parent, int child_res)
            => MEOSFactory.WrapTemporal(Meos.Th3indexChildPosToCell(this.Ptr, parent.Ptr, child_res));

        public bool Contained(TH3Index temp2)
            => Meos.ContainedTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Contains(TH3Index temp2)
            => Meos.ContainsTspatialTspatial(this.Ptr, temp2.Ptr);

        public Temporal? DirectedEdgeToBoundary()
            => MEOSFactory.WrapTemporal(Meos.Th3indexDirectedEdgeToBoundary(this.Ptr));

        public Temporal? EdgeLength()
            => MEOSFactory.WrapTemporal(Meos.Th3indexEdgeLength(this.Ptr));

        public H3Index EndValue()
            => new H3Index(Meos.Th3indexEndValue(this.Ptr));

        public int EverEq(H3Index cell)
            => Meos.EverEqTh3indexH3index(this.Ptr, cell.value);

        public int EverEq(TH3Index temp2)
            => Meos.EverEqTh3indexTh3index(this.Ptr, temp2.Ptr);

        public int EverEq(H3IndexSet cells)
            => Meos.EverEqTh3indexH3indexset(this.Ptr, cells.Ptr);

        public int EverNe(H3Index cell)
            => Meos.EverNeTh3indexH3index(this.Ptr, cell.value);

        public int EverNe(TH3Index temp2)
            => Meos.EverNeTh3indexTh3index(this.Ptr, temp2.Ptr);

        public Temporal? GetBaseCellNumber()
            => MEOSFactory.WrapTemporal(Meos.Th3indexGetBaseCellNumber(this.Ptr));

        public Temporal? GetDirectedEdgeDestination()
            => MEOSFactory.WrapTemporal(Meos.Th3indexGetDirectedEdgeDestination(this.Ptr));

        public Temporal? GetDirectedEdgeOrigin()
            => MEOSFactory.WrapTemporal(Meos.Th3indexGetDirectedEdgeOrigin(this.Ptr));

        public Temporal? GridDistance(Temporal dest)
            => MEOSFactory.WrapTemporal(Meos.Th3indexGridDistance(this.Ptr, dest.Ptr));

        public Temporal? IsPentagon()
            => MEOSFactory.WrapTemporal(Meos.Th3indexIsPentagon(this.Ptr));

        public Temporal? IsResClassIii()
            => MEOSFactory.WrapTemporal(Meos.Th3indexIsResClassIii(this.Ptr));

        public Temporal? IsValidDirectedEdge()
            => MEOSFactory.WrapTemporal(Meos.Th3indexIsValidDirectedEdge(this.Ptr));

        public Temporal? IsValidVertex()
            => MEOSFactory.WrapTemporal(Meos.Th3indexIsValidVertex(this.Ptr));

        public bool Left(TH3Index temp2)
            => Meos.LeftTspatialTspatial(this.Ptr, temp2.Ptr);

        public Temporal? LocalIjToCell(Temporal coord)
            => MEOSFactory.WrapTemporal(Meos.Th3indexLocalIjToCell(this.Ptr, coord.Ptr));

        public Temporal? MinusValue(H3Index cell)
            => MEOSFactory.WrapTemporal(Meos.Th3indexMinusValue(this.Ptr, cell.value));

        public bool Overabove(TH3Index temp2)
            => Meos.OveraboveTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overafter(TH3Index temp2)
            => Meos.OverafterTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overbefore(TH3Index temp2)
            => Meos.OverbeforeTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overbelow(TH3Index temp2)
            => Meos.OverbelowTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overlaps(TH3Index temp2)
            => Meos.OverlapsTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overleft(TH3Index temp2)
            => Meos.OverleftTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overright(TH3Index temp2)
            => Meos.OverrightTspatialTspatial(this.Ptr, temp2.Ptr);

        public int RalwaysEq(H3Index cell)
            => Meos.AlwaysEqH3indexTh3index(cell.value, this.Ptr);

        public int RalwaysNe(H3Index cell)
            => Meos.AlwaysNeH3indexTh3index(cell.value, this.Ptr);

        public int ReverEq(H3Index cell)
            => Meos.EverEqH3indexTh3index(cell.value, this.Ptr);

        public int ReverNe(H3Index cell)
            => Meos.EverNeH3indexTh3index(cell.value, this.Ptr);

        public bool Right(TH3Index temp2)
            => Meos.RightTspatialTspatial(this.Ptr, temp2.Ptr);

        public Temporal? Rteq(H3Index cell)
            => MEOSFactory.WrapTemporal(Meos.TeqH3indexTh3index(cell.value, this.Ptr));

        public Temporal? Rtne(H3Index cell)
            => MEOSFactory.WrapTemporal(Meos.TneH3indexTh3index(cell.value, this.Ptr));

        public bool Same(TH3Index temp2)
            => Meos.SameTspatialTspatial(this.Ptr, temp2.Ptr);

        public H3Index StartValue()
            => new H3Index(Meos.Th3indexStartValue(this.Ptr));

        public Temporal? Teq(H3Index cell)
            => MEOSFactory.WrapTemporal(Meos.TeqTh3indexH3index(this.Ptr, cell.value));

        public Temporal? Teq(TH3Index temp2)
            => MEOSFactory.WrapTemporal(Meos.TeqTh3indexTh3index(this.Ptr, temp2.Ptr));

        public Temporal? Tne(H3Index cell)
            => MEOSFactory.WrapTemporal(Meos.TneTh3indexH3index(this.Ptr, cell.value));

        public Temporal? Tne(TH3Index temp2)
            => MEOSFactory.WrapTemporal(Meos.TneTh3indexTh3index(this.Ptr, temp2.Ptr));

        public Temporal? ToTbigint()
            => MEOSFactory.WrapTemporal(Meos.Th3indexToTbigint(this.Ptr));

        public Temporal? ToTgeogpoint()
            => MEOSFactory.WrapTemporal(Meos.Th3indexToTgeogpoint(this.Ptr));

        public Temporal? ToTgeompoint()
            => MEOSFactory.WrapTemporal(Meos.Th3indexToTgeompoint(this.Ptr));

        public (SpanSet?[], H3Index[]) Unnest()
        {
            var _answered = Meos.Th3indexUnnest(this.Ptr);

            return (MEOSFactory.WrapSpanSetArray(_answered.Item1), Array.ConvertAll(_answered.Item2, v => new H3Index(v)));
        }

        public H3Index Value()
            => new H3Index(Meos.Th3indexValue(this.Ptr));

        public H3Index? ValueAtTimestamptz(DateTime t, bool strict)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.Th3indexValueAtTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict, _result))
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

        public H3Index? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.Th3indexValueN(this.Ptr, n, _result))
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
            => Array.ConvertAll(Meos.Th3indexValues(this.Ptr), v => new H3Index(v));

        public Temporal? VertexToLatlng()
            => MEOSFactory.WrapTemporal(Meos.Th3indexVertexToLatlng(this.Ptr));

        public static Temporal? FromBaseTemp(H3Index value, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.Th3indexFromBaseTemp(value.value, temp.Ptr));

        public static Temporal? FromEWKB(byte[] wkb)
            => Temporal.FromWKB(wkb);

        public static Temporal? FromEWKT(string str)
            => TH3Index.FromText(str);

        public static Temporal? FromHexEWKB(string hexwkb)
            => Temporal.FromHexWKB(hexwkb);

        public static Temporal? FromMFJSON(string mfjson)
            => MEOSFactory.WrapTemporal(Meos.Th3indexFromMfjson(mfjson));

        public static Temporal? FromText(string str)
            => MEOSFactory.WrapTemporal(Meos.Th3indexIn(str));

    }
}
