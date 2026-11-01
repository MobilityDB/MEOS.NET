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
            => this.Out();

        public Temporal? AreNeighborCells(Temporal dest)
            => MEOSFactory.WrapTemporal(Meos.Th3indexAreNeighborCells(this.Ptr, dest.Ptr));

        public Temporal? AtValue(ulong cell)
            => MEOSFactory.WrapTemporal(Meos.Th3indexAtValue(this.Ptr, cell));

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

        public Temporal? DirectedEdgeToBoundary()
            => MEOSFactory.WrapTemporal(Meos.Th3indexDirectedEdgeToBoundary(this.Ptr));

        public Temporal? EdgeLength()
            => MEOSFactory.WrapTemporal(Meos.Th3indexEdgeLength(this.Ptr));

        public ulong EndValue()
            => Meos.Th3indexEndValue(this.Ptr);

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

        public Temporal? LocalIjToCell(Temporal coord)
            => MEOSFactory.WrapTemporal(Meos.Th3indexLocalIjToCell(this.Ptr, coord.Ptr));

        public Temporal? MinusValue(ulong cell)
            => MEOSFactory.WrapTemporal(Meos.Th3indexMinusValue(this.Ptr, cell));

        public string Out()
            => Meos.Th3indexOut(this.Ptr);

        public ulong StartValue()
            => Meos.Th3indexStartValue(this.Ptr);

        public Temporal? ToTbigint()
            => MEOSFactory.WrapTemporal(Meos.Th3indexToTbigint(this.Ptr));

        public Temporal? ToTgeogpoint()
            => MEOSFactory.WrapTemporal(Meos.Th3indexToTgeogpoint(this.Ptr));

        public Temporal? ToTgeompoint()
            => MEOSFactory.WrapTemporal(Meos.Th3indexToTgeompoint(this.Ptr));

        public (SpanSet?[], ulong[]) Unnest()
        {
            var _answered = Meos.Th3indexUnnest(this.Ptr);

            return (MEOSFactory.WrapSpanSetArray(_answered.Item1), _answered.Item2);
        }

        public ulong Value()
            => Meos.Th3indexValue(this.Ptr);

        public ulong[] Values()
            => Meos.Th3indexValues(this.Ptr);

        public Temporal? VertexToLatlng()
            => MEOSFactory.WrapTemporal(Meos.Th3indexVertexToLatlng(this.Ptr));

        public static Temporal? FromBaseTemp(ulong value, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.Th3indexFromBaseTemp(value, temp.Ptr));

        public static Temporal? FromEWKB(byte[] wkb)
            => Temporal.FromWKB(wkb);

        public static Temporal? FromEWKT(string str)
            => TH3Index.In(str);

        public static Temporal? FromHexEWKB(string hexwkb)
            => Temporal.FromHexWKB(hexwkb);

        public static Temporal? FromMFJSON(string mfjson)
            => MEOSFactory.WrapTemporal(Meos.Th3indexFromMfjson(mfjson));

        public static Temporal? FromText(string str)
            => TH3Index.In(str);

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.Th3indexIn(str));

        public static Temporal? Make(ulong value, DateTime t)
            => MEOSFactory.WrapTemporal(Meos.Th3indexMake(value, MEOSConvert.ToTimestampTz(t)));

    }
}
