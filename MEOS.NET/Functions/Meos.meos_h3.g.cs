#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Structures;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>meos_h3.h</c> declares.</summary>
    public static partial class Meos
    {
        public static ulong H3indexIn(string str)
            => SafeExecution<ulong>(() => Native.H3indexIn(str));

        public static string H3indexOut(ulong cell)
            => SafeExecution<string>(() => Native.H3indexOut(cell));

        public static bool H3IsValidCell(ulong cell)
            => SafeExecution<bool>(() => Native.H3IsValidCell(cell));

        public static bool H3IsValidDirectedEdge(ulong edge)
            => SafeExecution<bool>(() => Native.H3IsValidDirectedEdge(edge));

        public static bool H3IsValidVertex(ulong vertex)
            => SafeExecution<bool>(() => Native.H3IsValidVertex(vertex));

        public static bool H3indexEq(ulong a, ulong b)
            => SafeExecution<bool>(() => Native.H3indexEq(a, b));

        public static bool H3indexNe(ulong a, ulong b)
            => SafeExecution<bool>(() => Native.H3indexNe(a, b));

        public static bool H3indexLt(ulong a, ulong b)
            => SafeExecution<bool>(() => Native.H3indexLt(a, b));

        public static bool H3indexLe(ulong a, ulong b)
            => SafeExecution<bool>(() => Native.H3indexLe(a, b));

        public static bool H3indexGt(ulong a, ulong b)
            => SafeExecution<bool>(() => Native.H3indexGt(a, b));

        public static bool H3indexGe(ulong a, ulong b)
            => SafeExecution<bool>(() => Native.H3indexGe(a, b));

        public static int H3indexCmp(ulong a, ulong b)
            => SafeExecution<int>(() => Native.H3indexCmp(a, b));

        public static uint H3indexHash(ulong cell)
            => SafeExecution<uint>(() => Native.H3indexHash(cell));

        public static IntPtr H3GridDisk(ulong origin, int k)
            => SafeExecution<IntPtr>(() => Native.H3GridDisk(origin, k));

        public static IntPtr H3CellToChildren(ulong origin, int childRes)
            => SafeExecution<IntPtr>(() => Native.H3CellToChildren(origin, childRes));

        public static IntPtr H3CompactCells(IntPtr cells)
            => SafeExecution<IntPtr>(() => Native.H3CompactCells(cells));

        public static IntPtr H3UncompactCells(IntPtr cells, int res)
            => SafeExecution<IntPtr>(() => Native.H3UncompactCells(cells, res));

        public static IntPtr H3GridRing(ulong origin, int k)
            => SafeExecution<IntPtr>(() => Native.H3GridRing(origin, k));

        public static IntPtr H3GridPathCells(ulong start, ulong end)
            => SafeExecution<IntPtr>(() => Native.H3GridPathCells(start, end));

        public static IntPtr H3OriginToDirectedEdges(ulong origin)
            => SafeExecution<IntPtr>(() => Native.H3OriginToDirectedEdges(origin));

        public static IntPtr H3CellToVertexes(ulong cell)
            => SafeExecution<IntPtr>(() => Native.H3CellToVertexes(cell));

        public static IntPtr H3GetIcosahedronFaces(ulong cell)
            => SafeExecution<IntPtr>(() => Native.H3GetIcosahedronFaces(cell));

        public static ulong H3indexFromWkb(IntPtr wkb, ulong size)
            => SafeExecution<ulong>(() => Native.H3indexFromWkb(wkb, size));

        public static ulong H3indexFromHexwkb(string hexwkb)
            => SafeExecution<ulong>(() => Native.H3indexFromHexwkb(hexwkb));

        public static IntPtr H3indexAsWkb(ulong cell, byte variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => Native.H3indexAsWkb(cell, variant, size_out));

        public static string H3indexAsHexwkb(ulong cell, byte variant, IntPtr size_out)
            => SafeExecution<string>(() => Native.H3indexAsHexwkb(cell, variant, size_out));

        public static uint H3indexGetResolution(ulong cell)
            => SafeExecution<uint>(() => Native.H3indexGetResolution(cell));

        public static ulong H3indexCellToParent(ulong cell, uint parent_resolution)
            => SafeExecution<ulong>(() => Native.H3indexCellToParent(cell, parent_resolution));

        public static IntPtr H3indexCellToPoint(ulong cell)
            => SafeExecution<IntPtr>(() => Native.H3indexCellToPoint(cell));

        public static IntPtr H3indexCellToBoundary(ulong cell)
            => SafeExecution<IntPtr>(() => Native.H3indexCellToBoundary(cell));

        public static double H3indexCellArea(ulong cell)
            => SafeExecution<double>(() => Native.H3indexCellArea(cell));

        public static IntPtr Th3indexIn(string str)
            => SafeExecution<IntPtr>(() => Native.Th3indexIn(str));

        public static IntPtr Th3indexinstIn(string str)
            => SafeExecution<IntPtr>(() => Native.Th3indexinstIn(str));

        public static IntPtr Th3indexseqIn(string str, int interp)
            => SafeExecution<IntPtr>(() => Native.Th3indexseqIn(str, interp));

        public static IntPtr Th3indexseqsetIn(string str)
            => SafeExecution<IntPtr>(() => Native.Th3indexseqsetIn(str));

        public static IntPtr Th3indexMake(ulong value, long t)
            => SafeExecution<IntPtr>(() => Native.Th3indexMake(value, t));

        public static IntPtr Th3indexinstMake(ulong value, long t)
            => SafeExecution<IntPtr>(() => Native.Th3indexinstMake(value, t));

        public static IntPtr Th3indexseqMake(IntPtr values, IntPtr times, int count, bool lower_inc, bool upper_inc)
            => SafeExecution<IntPtr>(() => Native.Th3indexseqMake(values, times, count, lower_inc, upper_inc));

        public static IntPtr Th3indexseqsetMake(IntPtr sequences, int count)
            => SafeExecution<IntPtr>(() => Native.Th3indexseqsetMake(sequences, count));

        public static ulong Th3indexStartValue(IntPtr temp)
            => SafeExecution<ulong>(() => Native.Th3indexStartValue(temp));

        public static ulong Th3indexEndValue(IntPtr temp)
            => SafeExecution<ulong>(() => Native.Th3indexEndValue(temp));

        public static bool Th3indexValueN(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.Th3indexValueN(temp, n, result));

        public static ulong[] Th3indexValues(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.Th3indexValues(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                ulong[] _out = new ulong[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = (ulong) Marshal.ReadInt64(_p, _i * 8); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool Th3indexValueAtTimestamptz(IntPtr temp, long t, bool strict, IntPtr result)
            => SafeExecution<bool>(() => Native.Th3indexValueAtTimestamptz(temp, t, strict, result));

        public static IntPtr TbigintToTh3index(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TbigintToTh3index(temp));

        public static IntPtr Th3indexToTbigint(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.Th3indexToTbigint(temp));

        public static int EverEqH3indexTh3index(ulong cell, IntPtr temp)
            => SafeExecution<int>(() => Native.EverEqH3indexTh3index(cell, temp));

        public static int EverEqTh3indexH3index(IntPtr temp, ulong cell)
            => SafeExecution<int>(() => Native.EverEqTh3indexH3index(temp, cell));

        public static int EverNeH3indexTh3index(ulong cell, IntPtr temp)
            => SafeExecution<int>(() => Native.EverNeH3indexTh3index(cell, temp));

        public static int EverNeTh3indexH3index(IntPtr temp, ulong cell)
            => SafeExecution<int>(() => Native.EverNeTh3indexH3index(temp, cell));

        public static int AlwaysEqH3indexTh3index(ulong cell, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysEqH3indexTh3index(cell, temp));

        public static int AlwaysEqTh3indexH3index(IntPtr temp, ulong cell)
            => SafeExecution<int>(() => Native.AlwaysEqTh3indexH3index(temp, cell));

        public static int AlwaysNeH3indexTh3index(ulong cell, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysNeH3indexTh3index(cell, temp));

        public static int AlwaysNeTh3indexH3index(IntPtr temp, ulong cell)
            => SafeExecution<int>(() => Native.AlwaysNeTh3indexH3index(temp, cell));

        public static int EverEqTh3indexTh3index(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverEqTh3indexTh3index(temp1, temp2));

        public static int EverNeTh3indexTh3index(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverNeTh3indexTh3index(temp1, temp2));

        public static int AlwaysEqTh3indexTh3index(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysEqTh3indexTh3index(temp1, temp2));

        public static int AlwaysNeTh3indexTh3index(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysNeTh3indexTh3index(temp1, temp2));

        public static IntPtr TeqH3indexTh3index(ulong cell, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TeqH3indexTh3index(cell, temp));

        public static IntPtr TeqTh3indexH3index(IntPtr temp, ulong cell)
            => SafeExecution<IntPtr>(() => Native.TeqTh3indexH3index(temp, cell));

        public static IntPtr TeqTh3indexTh3index(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TeqTh3indexTh3index(temp1, temp2));

        public static IntPtr TneH3indexTh3index(ulong cell, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TneH3indexTh3index(cell, temp));

        public static IntPtr TneTh3indexH3index(IntPtr temp, ulong cell)
            => SafeExecution<IntPtr>(() => Native.TneTh3indexH3index(temp, cell));

        public static IntPtr TneTh3indexTh3index(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TneTh3indexTh3index(temp1, temp2));

        public static IntPtr Th3indexGetBaseCellNumber(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.Th3indexGetBaseCellNumber(temp));

        public static IntPtr Th3indexIsResClassIii(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.Th3indexIsResClassIii(temp));

        public static IntPtr Th3indexIsPentagon(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.Th3indexIsPentagon(temp));

        public static IntPtr Th3indexCellToParentNext(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.Th3indexCellToParentNext(temp));

        public static IntPtr Th3indexCellToCenterChild(IntPtr temp, int resolution)
            => SafeExecution<IntPtr>(() => Native.Th3indexCellToCenterChild(temp, resolution));

        public static IntPtr Th3indexCellToCenterChildNext(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.Th3indexCellToCenterChildNext(temp));

        public static IntPtr Th3indexCellToChildPos(IntPtr temp, int parent_res)
            => SafeExecution<IntPtr>(() => Native.Th3indexCellToChildPos(temp, parent_res));

        public static IntPtr Th3indexChildPosToCell(IntPtr child_pos, IntPtr parent, int child_res)
            => SafeExecution<IntPtr>(() => Native.Th3indexChildPosToCell(child_pos, parent, child_res));

        public static IntPtr TgeogpointToTh3index(IntPtr temp, int resolution)
            => SafeExecution<IntPtr>(() => Native.TgeogpointToTh3index(temp, resolution));

        public static IntPtr TgeompointToTh3index(IntPtr temp, int resolution)
            => SafeExecution<IntPtr>(() => Native.TgeompointToTh3index(temp, resolution));

        public static IntPtr Th3indexToTgeogpoint(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.Th3indexToTgeogpoint(temp));

        public static IntPtr Th3indexToTgeompoint(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.Th3indexToTgeompoint(temp));

        public static IntPtr H3indexToSet(ulong cell)
            => SafeExecution<IntPtr>(() => Native.H3indexToSet(cell));

        public static ulong GeoToH3indexCell(IntPtr point, int resolution)
            => SafeExecution<ulong>(() => Native.GeoToH3indexCell(point, resolution));

        public static IntPtr GeoToH3indexSet(IntPtr gs, int resolution)
            => SafeExecution<IntPtr>(() => Native.GeoToH3indexSet(gs, resolution));

        public static IntPtr H3indexToStbox(ulong cell)
            => SafeExecution<IntPtr>(() => Native.H3indexToStbox(cell));

        public static IntPtr H3indexTimestamptzToStbox(ulong cell, long t)
            => SafeExecution<IntPtr>(() => Native.H3indexTimestamptzToStbox(cell, t));

        public static IntPtr H3indexTstzspanToStbox(ulong cell, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.H3indexTstzspanToStbox(cell, s));

        public static int EverEqH3indexsetTh3index(IntPtr cells, IntPtr th3idx)
            => SafeExecution<int>(() => Native.EverEqH3indexsetTh3index(cells, th3idx));

        public static IntPtr Th3indexAreNeighborCells(IntPtr origin, IntPtr dest)
            => SafeExecution<IntPtr>(() => Native.Th3indexAreNeighborCells(origin, dest));

        public static IntPtr Th3indexCellsToDirectedEdge(IntPtr origin, IntPtr dest)
            => SafeExecution<IntPtr>(() => Native.Th3indexCellsToDirectedEdge(origin, dest));

        public static IntPtr Th3indexIsValidDirectedEdge(IntPtr edge)
            => SafeExecution<IntPtr>(() => Native.Th3indexIsValidDirectedEdge(edge));

        public static IntPtr Th3indexGetDirectedEdgeOrigin(IntPtr edge)
            => SafeExecution<IntPtr>(() => Native.Th3indexGetDirectedEdgeOrigin(edge));

        public static IntPtr Th3indexGetDirectedEdgeDestination(IntPtr edge)
            => SafeExecution<IntPtr>(() => Native.Th3indexGetDirectedEdgeDestination(edge));

        public static IntPtr Th3indexDirectedEdgeToBoundary(IntPtr edge)
            => SafeExecution<IntPtr>(() => Native.Th3indexDirectedEdgeToBoundary(edge));

        public static IntPtr Th3indexCellToVertex(IntPtr temp, int vertex_num)
            => SafeExecution<IntPtr>(() => Native.Th3indexCellToVertex(temp, vertex_num));

        public static IntPtr Th3indexVertexToLatlng(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.Th3indexVertexToLatlng(temp));

        public static IntPtr Th3indexIsValidVertex(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.Th3indexIsValidVertex(temp));

        public static IntPtr Th3indexGridDistance(IntPtr origin, IntPtr dest)
            => SafeExecution<IntPtr>(() => Native.Th3indexGridDistance(origin, dest));

        public static IntPtr Th3indexCellToLocalIj(IntPtr origin, IntPtr cell)
            => SafeExecution<IntPtr>(() => Native.Th3indexCellToLocalIj(origin, cell));

        public static IntPtr Th3indexLocalIjToCell(IntPtr origin, IntPtr coord)
            => SafeExecution<IntPtr>(() => Native.Th3indexLocalIjToCell(origin, coord));

        public static IntPtr Th3indexEdgeLength(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.Th3indexEdgeLength(temp));

        public static IntPtr TgeogpointGreatCircleDistance(IntPtr a, IntPtr b)
            => SafeExecution<IntPtr>(() => Native.TgeogpointGreatCircleDistance(a, b));

    }
}
