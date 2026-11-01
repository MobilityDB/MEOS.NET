#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>Temporal DGGS cell indexes, the types tcellindex_type of meos/src/temporal/tcellindex.c admits (T_TH3INDEX, T_TQUADBIN, T_TS2CELL): the tcellindex_* functions every cell family answers through its DggsCellOps.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TCellIndex : TSpatial
    {
        internal TCellIndex(IntPtr ptr) : base(ptr) { }

        public Temporal? CellArea()
            => MEOSFactory.WrapTemporal(Meos.TcellindexCellArea(this.Ptr));

        public Temporal? CellToBoundary()
            => MEOSFactory.WrapTemporal(Meos.TcellindexCellToBoundary(this.Ptr));

        public Temporal? CellToParent(int resolution)
            => MEOSFactory.WrapTemporal(Meos.TcellindexCellToParent(this.Ptr, resolution));

        public Temporal? CellToPoint()
            => MEOSFactory.WrapTemporal(Meos.TcellindexCellToPoint(this.Ptr));

        public Temporal? GetResolution()
            => MEOSFactory.WrapTemporal(Meos.TcellindexGetResolution(this.Ptr));

        public Temporal? IsValidCell()
            => MEOSFactory.WrapTemporal(Meos.TcellindexIsValidCell(this.Ptr));

    }
}
