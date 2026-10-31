#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Structures;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>meos_quadbin.h</c> declares.</summary>
    public static partial class Meos
    {
        public static string QuadbinAsHexwkb(ulong cell, byte variant, IntPtr size_out)
            => SafeExecution<string>(() => Native.QuadbinAsHexwkb(cell, variant, size_out));

        public static IntPtr QuadbinAsWkb(ulong cell, byte variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => Native.QuadbinAsWkb(cell, variant, size_out));

        public static ulong QuadbinFromHexwkb(string hexwkb)
            => SafeExecution<ulong>(() => Native.QuadbinFromHexwkb(hexwkb));

        public static ulong QuadbinFromWkb(IntPtr wkb, ulong size)
            => SafeExecution<ulong>(() => Native.QuadbinFromWkb(wkb, size));

        public static ulong QuadbinIn(string str)
            => SafeExecution<ulong>(() => Native.QuadbinIn(str));

        public static ulong BigintToQuadbin(long i)
            => SafeExecution<ulong>(() => Native.BigintToQuadbin(i));

        public static string QuadbinOut(ulong cell)
            => SafeExecution<string>(() => Native.QuadbinOut(cell));

        public static bool QuadbinEq(ulong a, ulong b)
            => SafeExecution<bool>(() => Native.QuadbinEq(a, b));

        public static bool QuadbinNe(ulong a, ulong b)
            => SafeExecution<bool>(() => Native.QuadbinNe(a, b));

        public static bool QuadbinLt(ulong a, ulong b)
            => SafeExecution<bool>(() => Native.QuadbinLt(a, b));

        public static bool QuadbinLe(ulong a, ulong b)
            => SafeExecution<bool>(() => Native.QuadbinLe(a, b));

        public static bool QuadbinGt(ulong a, ulong b)
            => SafeExecution<bool>(() => Native.QuadbinGt(a, b));

        public static bool QuadbinGe(ulong a, ulong b)
            => SafeExecution<bool>(() => Native.QuadbinGe(a, b));

        public static int QuadbinCmp(ulong a, ulong b)
            => SafeExecution<int>(() => Native.QuadbinCmp(a, b));

        public static uint QuadbinHash(ulong cell)
            => SafeExecution<uint>(() => Native.QuadbinHash(cell));

        public static ulong QuadbinHashExtended(ulong cell, ulong seed)
            => SafeExecution<ulong>(() => Native.QuadbinHashExtended(cell, seed));

        public static bool QuadbinIsValidIndex(ulong index)
            => SafeExecution<bool>(() => Native.QuadbinIsValidIndex(index));

        public static bool QuadbinIsValidCell(ulong cell)
            => SafeExecution<bool>(() => Native.QuadbinIsValidCell(cell));

        public static ulong QuadbinTileToCell(uint x, uint y, uint z)
            => SafeExecution<ulong>(() => Native.QuadbinTileToCell(x, y, z));

        public static int[] QuadbinCellToTile(ulong cell)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.QuadbinCellToTile(cell, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                int[] _out = new int[_n];
                Marshal.Copy(_p, _out, 0, _n);
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static uint QuadbinGetResolution(ulong cell)
            => SafeExecution<uint>(() => Native.QuadbinGetResolution(cell));

        public static ulong QuadbinCellToParent(ulong cell, uint parent_resolution)
            => SafeExecution<ulong>(() => Native.QuadbinCellToParent(cell, parent_resolution));

        public static ulong[] QuadbinCellToChildren(ulong cell, uint children_resolution)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.QuadbinCellToChildren(cell, children_resolution, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                ulong[] _out = new ulong[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = (ulong) Marshal.ReadInt64(_p, _i * 8); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static ulong QuadbinCellSibling(ulong cell, string direction)
            => SafeExecution<ulong>(() => Native.QuadbinCellSibling(cell, direction));

        public static ulong[] QuadbinKRing(ulong cell, int k)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.QuadbinKRing(cell, k, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                ulong[] _out = new ulong[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = (ulong) Marshal.ReadInt64(_p, _i * 8); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static ulong QuadbinPointToCell(double longitude, double latitude, uint resolution)
            => SafeExecution<ulong>(() => Native.QuadbinPointToCell(longitude, latitude, resolution));

        public static ulong GeoToQuadbinCell(IntPtr point, int resolution)
            => SafeExecution<ulong>(() => Native.GeoToQuadbinCell(point, resolution));

        public static IntPtr GeoToQuadbinSet(IntPtr gs, int resolution)
            => SafeExecution<IntPtr>(() => Native.GeoToQuadbinSet(gs, resolution));

        public static IntPtr QuadbinCellToGeompoint(ulong cell)
            => SafeExecution<IntPtr>(() => Native.QuadbinCellToGeompoint(cell));

        public static IntPtr QuadbinCellToGeom(ulong cell)
            => SafeExecution<IntPtr>(() => Native.QuadbinCellToGeom(cell));

        public static int EverEqQuadbinsetTquadbin(IntPtr cells, IntPtr tqb)
            => SafeExecution<int>(() => Native.EverEqQuadbinsetTquadbin(cells, tqb));

        public static int EverEqTquadbinQuadbinset(IntPtr tqb, IntPtr cells)
            => SafeExecution<int>(() => Native.EverEqTquadbinQuadbinset(tqb, cells));

        public static IntPtr QuadbinToStbox(ulong cell)
            => SafeExecution<IntPtr>(() => Native.QuadbinToStbox(cell));

        public static IntPtr QuadbinTimestamptzToStbox(ulong cell, long t)
            => SafeExecution<IntPtr>(() => Native.QuadbinTimestamptzToStbox(cell, t));

        public static IntPtr QuadbinTstzspanToStbox(ulong cell, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.QuadbinTstzspanToStbox(cell, s));

        public static double QuadbinCellArea(ulong cell)
            => SafeExecution<double>(() => Native.QuadbinCellArea(cell));

        public static string QuadbinIndexToString(ulong index)
            => SafeExecution<string>(() => Native.QuadbinIndexToString(index));

        public static ulong QuadbinStringToIndex(string str)
            => SafeExecution<ulong>(() => Native.QuadbinStringToIndex(str));

        public static string QuadbinCellToQuadkey(ulong cell)
            => SafeExecution<string>(() => Native.QuadbinCellToQuadkey(cell));

        public static IntPtr QuadbinGridDisk(ulong origin, int k)
            => SafeExecution<IntPtr>(() => Native.QuadbinGridDisk(origin, k));

        public static IntPtr QuadbinsetGridDisk(IntPtr cells, int k)
            => SafeExecution<IntPtr>(() => Native.QuadbinsetGridDisk(cells, k));

        public static IntPtr QuadbinCellToChildrenSet(ulong origin, int children_resolution)
            => SafeExecution<IntPtr>(() => Native.QuadbinCellToChildrenSet(origin, children_resolution));

        public static IntPtr QuadbinsetCompactCells(IntPtr cells)
            => SafeExecution<IntPtr>(() => Native.QuadbinsetCompactCells(cells));

        public static IntPtr QuadbinsetUncompactCells(IntPtr cells, int resolution)
            => SafeExecution<IntPtr>(() => Native.QuadbinsetUncompactCells(cells, resolution));

        public static IntPtr QuadbinCellToCover(ulong cell, int resolution)
            => SafeExecution<IntPtr>(() => Native.QuadbinCellToCover(cell, resolution));

        public static IntPtr QuadbinsetCoverCells(IntPtr cells, int resolution)
            => SafeExecution<IntPtr>(() => Native.QuadbinsetCoverCells(cells, resolution));

        public static IntPtr QuadbinsetIn(string str)
            => SafeExecution<IntPtr>(() => Native.QuadbinsetIn(str));

        public static string QuadbinsetOut(IntPtr s)
            => SafeExecution<string>(() => Native.QuadbinsetOut(s));

        public static IntPtr QuadbinsetMake(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => Native.QuadbinsetMake(values, count));

        public static ulong QuadbinsetEndValue(IntPtr s)
            => SafeExecution<ulong>(() => Native.QuadbinsetEndValue(s));

        public static ulong QuadbinsetStartValue(IntPtr s)
            => SafeExecution<ulong>(() => Native.QuadbinsetStartValue(s));

        public static bool QuadbinsetValueN(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.QuadbinsetValueN(s, n, result));

        public static ulong[] QuadbinsetValues(IntPtr s)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.QuadbinsetValues(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                ulong[] _out = new ulong[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = (ulong) Marshal.ReadInt64(_p, _i * 8); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool ContainedQuadbinSet(ulong cell, IntPtr s)
            => SafeExecution<bool>(() => Native.ContainedQuadbinSet(cell, s));

        public static bool ContainsSetQuadbin(IntPtr s, ulong cell)
            => SafeExecution<bool>(() => Native.ContainsSetQuadbin(s, cell));

        public static IntPtr IntersectionQuadbinSet(ulong cell, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.IntersectionQuadbinSet(cell, s));

        public static IntPtr IntersectionSetQuadbin(IntPtr s, ulong cell)
            => SafeExecution<IntPtr>(() => Native.IntersectionSetQuadbin(s, cell));

        public static IntPtr MinusQuadbinSet(ulong cell, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.MinusQuadbinSet(cell, s));

        public static IntPtr MinusSetQuadbin(IntPtr s, ulong cell)
            => SafeExecution<IntPtr>(() => Native.MinusSetQuadbin(s, cell));

        public static IntPtr UnionQuadbinSet(ulong cell, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.UnionQuadbinSet(cell, s));

        public static IntPtr UnionSetQuadbin(IntPtr s, ulong cell)
            => SafeExecution<IntPtr>(() => Native.UnionSetQuadbin(s, cell));

        public static IntPtr QuadbinUnionTransfn(IntPtr state, ulong cell)
            => SafeExecution<IntPtr>(() => Native.QuadbinUnionTransfn(state, cell));

        public static IntPtr TquadbinIn(string str)
            => SafeExecution<IntPtr>(() => Native.TquadbinIn(str));

        public static IntPtr TquadbininstIn(string str)
            => SafeExecution<IntPtr>(() => Native.TquadbininstIn(str));

        public static IntPtr TquadbinseqIn(string str, int interp)
            => SafeExecution<IntPtr>(() => Native.TquadbinseqIn(str, interp));

        public static IntPtr TquadbinseqsetIn(string str)
            => SafeExecution<IntPtr>(() => Native.TquadbinseqsetIn(str));

        public static string TquadbinOut(IntPtr temp)
            => SafeExecution<string>(() => Native.TquadbinOut(temp));

        public static IntPtr TquadbinFromMfjson(string mfjson)
            => SafeExecution<IntPtr>(() => Native.TquadbinFromMfjson(mfjson));

        public static IntPtr TquadbinMake(ulong value, long t)
            => SafeExecution<IntPtr>(() => Native.TquadbinMake(value, t));

        public static IntPtr TquadbininstMake(ulong value, long t)
            => SafeExecution<IntPtr>(() => Native.TquadbininstMake(value, t));

        public static IntPtr TquadbinFromBaseTemp(ulong value, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TquadbinFromBaseTemp(value, temp));

        public static IntPtr TquadbinseqFromBaseTstzset(ulong value, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TquadbinseqFromBaseTstzset(value, s));

        public static IntPtr TquadbinseqFromBaseTstzspan(ulong value, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TquadbinseqFromBaseTstzspan(value, s));

        public static IntPtr TquadbinseqsetFromBaseTstzspanset(ulong value, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TquadbinseqsetFromBaseTstzspanset(value, ss));

        public static IntPtr TquadbinseqMake(IntPtr values, IntPtr times, int count, bool lower_inc, bool upper_inc)
            => SafeExecution<IntPtr>(() => Native.TquadbinseqMake(values, times, count, lower_inc, upper_inc));

        public static IntPtr TquadbinseqsetMake(IntPtr sequences, int count)
            => SafeExecution<IntPtr>(() => Native.TquadbinseqsetMake(sequences, count));

        public static ulong TquadbinStartValue(IntPtr temp)
            => SafeExecution<ulong>(() => Native.TquadbinStartValue(temp));

        public static ulong TquadbinEndValue(IntPtr temp)
            => SafeExecution<ulong>(() => Native.TquadbinEndValue(temp));

        public static ulong TquadbinValue(IntPtr temp)
            => SafeExecution<ulong>(() => Native.TquadbinValue(temp));

        public static bool TquadbinValueN(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.TquadbinValueN(temp, n, result));

        public static ulong[] TquadbinValues(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TquadbinValues(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                ulong[] _out = new ulong[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = (ulong) Marshal.ReadInt64(_p, _i * 8); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static (IntPtr[], ulong[]) TquadbinUnnest(IntPtr temp)
        {
            IntPtr _out_values = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => Native.TquadbinUnnest(temp, _out_values, _count_count));
                int _n = Marshal.ReadInt32(_count_count);
                IntPtr[] _resultArr = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _resultArr[_i] = Marshal.ReadIntPtr(_resultPtr, _i * IntPtr.Size); }
                IntPtr __out_values_arr = Marshal.ReadIntPtr(_out_values);
                ulong[] __out_values_out = new ulong[_n];
                for (int _i = 0; _i < _n; _i++)
                { __out_values_out[_i] = (ulong) Marshal.ReadInt64(__out_values_arr, _i * 8); }
                return (_resultArr, __out_values_out);
            }
            finally
            {
            Marshal.FreeHGlobal(_out_values);
            Marshal.FreeHGlobal(_count_count);
            }
        }

        public static bool TquadbinValueAtTimestamptz(IntPtr temp, long t, bool strict, IntPtr result)
            => SafeExecution<bool>(() => Native.TquadbinValueAtTimestamptz(temp, t, strict, result));

        public static IntPtr QuadbinToSet(ulong cell)
            => SafeExecution<IntPtr>(() => Native.QuadbinToSet(cell));

        public static IntPtr TbigintToTquadbin(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TbigintToTquadbin(temp));

        public static IntPtr TquadbinToTbigint(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TquadbinToTbigint(temp));

        public static IntPtr TquadbinAtValue(IntPtr temp, ulong cell)
            => SafeExecution<IntPtr>(() => Native.TquadbinAtValue(temp, cell));

        public static IntPtr TquadbinMinusValue(IntPtr temp, ulong cell)
            => SafeExecution<IntPtr>(() => Native.TquadbinMinusValue(temp, cell));

        public static int EverEqQuadbinTquadbin(ulong cell, IntPtr temp)
            => SafeExecution<int>(() => Native.EverEqQuadbinTquadbin(cell, temp));

        public static int EverEqTquadbinQuadbin(IntPtr temp, ulong cell)
            => SafeExecution<int>(() => Native.EverEqTquadbinQuadbin(temp, cell));

        public static int EverNeQuadbinTquadbin(ulong cell, IntPtr temp)
            => SafeExecution<int>(() => Native.EverNeQuadbinTquadbin(cell, temp));

        public static int EverNeTquadbinQuadbin(IntPtr temp, ulong cell)
            => SafeExecution<int>(() => Native.EverNeTquadbinQuadbin(temp, cell));

        public static int AlwaysEqQuadbinTquadbin(ulong cell, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysEqQuadbinTquadbin(cell, temp));

        public static int AlwaysEqTquadbinQuadbin(IntPtr temp, ulong cell)
            => SafeExecution<int>(() => Native.AlwaysEqTquadbinQuadbin(temp, cell));

        public static int AlwaysNeQuadbinTquadbin(ulong cell, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysNeQuadbinTquadbin(cell, temp));

        public static int AlwaysNeTquadbinQuadbin(IntPtr temp, ulong cell)
            => SafeExecution<int>(() => Native.AlwaysNeTquadbinQuadbin(temp, cell));

        public static int EverEqTquadbinTquadbin(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverEqTquadbinTquadbin(temp1, temp2));

        public static int EverNeTquadbinTquadbin(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverNeTquadbinTquadbin(temp1, temp2));

        public static int AlwaysEqTquadbinTquadbin(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysEqTquadbinTquadbin(temp1, temp2));

        public static int AlwaysNeTquadbinTquadbin(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysNeTquadbinTquadbin(temp1, temp2));

        public static IntPtr TeqQuadbinTquadbin(ulong cell, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TeqQuadbinTquadbin(cell, temp));

        public static IntPtr TeqTquadbinQuadbin(IntPtr temp, ulong cell)
            => SafeExecution<IntPtr>(() => Native.TeqTquadbinQuadbin(temp, cell));

        public static IntPtr TeqTquadbinTquadbin(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TeqTquadbinTquadbin(temp1, temp2));

        public static IntPtr TneQuadbinTquadbin(ulong cell, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TneQuadbinTquadbin(cell, temp));

        public static IntPtr TneTquadbinQuadbin(IntPtr temp, ulong cell)
            => SafeExecution<IntPtr>(() => Native.TneTquadbinQuadbin(temp, cell));

        public static IntPtr TneTquadbinTquadbin(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TneTquadbinTquadbin(temp1, temp2));

        public static IntPtr TgeogpointToTquadbin(IntPtr temp, int resolution, bool border_inc)
            => SafeExecution<IntPtr>(() => Native.TgeogpointToTquadbin(temp, resolution, border_inc));

        public static IntPtr TgeompointToTquadbin(IntPtr temp, int resolution, bool border_inc)
            => SafeExecution<IntPtr>(() => Native.TgeompointToTquadbin(temp, resolution, border_inc));

        public static (IntPtr[], ulong[]) TgeogpointQuadbinSplit(IntPtr temp, int resolution, bool border_inc)
        {
            IntPtr _out_cells = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => Native.TgeogpointQuadbinSplit(temp, resolution, border_inc, _out_cells, _count_count));
                int _n = Marshal.ReadInt32(_count_count);
                IntPtr[] _resultArr = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _resultArr[_i] = Marshal.ReadIntPtr(_resultPtr, _i * IntPtr.Size); }
                IntPtr __out_cells_arr = Marshal.ReadIntPtr(_out_cells);
                ulong[] __out_cells_out = new ulong[_n];
                for (int _i = 0; _i < _n; _i++)
                { __out_cells_out[_i] = (ulong) Marshal.ReadInt64(__out_cells_arr, _i * 8); }
                return (_resultArr, __out_cells_out);
            }
            finally
            {
            Marshal.FreeHGlobal(_out_cells);
            Marshal.FreeHGlobal(_count_count);
            }
        }

        public static (IntPtr[], ulong[]) TgeompointQuadbinSplit(IntPtr temp, int resolution, bool border_inc)
        {
            IntPtr _out_cells = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => Native.TgeompointQuadbinSplit(temp, resolution, border_inc, _out_cells, _count_count));
                int _n = Marshal.ReadInt32(_count_count);
                IntPtr[] _resultArr = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _resultArr[_i] = Marshal.ReadIntPtr(_resultPtr, _i * IntPtr.Size); }
                IntPtr __out_cells_arr = Marshal.ReadIntPtr(_out_cells);
                ulong[] __out_cells_out = new ulong[_n];
                for (int _i = 0; _i < _n; _i++)
                { __out_cells_out[_i] = (ulong) Marshal.ReadInt64(__out_cells_arr, _i * 8); }
                return (_resultArr, __out_cells_out);
            }
            finally
            {
            Marshal.FreeHGlobal(_out_cells);
            Marshal.FreeHGlobal(_count_count);
            }
        }

        public static IntPtr TquadbinCellToQuadkey(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TquadbinCellToQuadkey(temp));

        public static IntPtr TquadbinGridDistance(IntPtr origin, IntPtr dest)
            => SafeExecution<IntPtr>(() => Native.TquadbinGridDistance(origin, dest));

    }
}
