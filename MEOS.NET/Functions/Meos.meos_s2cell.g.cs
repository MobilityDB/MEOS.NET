#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Structures;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>meos_s2cell.h</c> declares.</summary>
    public static partial class Meos
    {
        public static ulong S2cellIn(string str)
            => SafeExecution<ulong>(() => Native.S2cellIn(str));

        public static string S2cellOut(ulong cell)
            => SafeExecution<string>(() => Native.S2cellOut(cell));

        public static bool S2cellEq(ulong a, ulong b)
            => SafeExecution<bool>(() => Native.S2cellEq(a, b));

        public static bool S2cellNe(ulong a, ulong b)
            => SafeExecution<bool>(() => Native.S2cellNe(a, b));

        public static bool S2cellLt(ulong a, ulong b)
            => SafeExecution<bool>(() => Native.S2cellLt(a, b));

        public static bool S2cellLe(ulong a, ulong b)
            => SafeExecution<bool>(() => Native.S2cellLe(a, b));

        public static bool S2cellGt(ulong a, ulong b)
            => SafeExecution<bool>(() => Native.S2cellGt(a, b));

        public static bool S2cellGe(ulong a, ulong b)
            => SafeExecution<bool>(() => Native.S2cellGe(a, b));

        public static int S2cellCmp(ulong a, ulong b)
            => SafeExecution<int>(() => Native.S2cellCmp(a, b));

        public static uint S2cellHash(ulong cell)
            => SafeExecution<uint>(() => Native.S2cellHash(cell));

        public static ulong S2cellHashExtended(ulong cell, ulong seed)
            => SafeExecution<ulong>(() => Native.S2cellHashExtended(cell, seed));

        public static bool S2cellIsValidCell(ulong cell)
            => SafeExecution<bool>(() => Native.S2cellIsValidCell(cell));

        public static string S2cellCellToToken(ulong cell)
            => SafeExecution<string>(() => Native.S2cellCellToToken(cell));

        public static ulong S2cellTokenToCell(string token)
            => SafeExecution<ulong>(() => Native.S2cellTokenToCell(token));

        public static uint S2cellGetResolution(ulong cell)
            => SafeExecution<uint>(() => Native.S2cellGetResolution(cell));

        public static uint S2cellGetFace(ulong cell)
            => SafeExecution<uint>(() => Native.S2cellGetFace(cell));

        public static ulong S2cellCellToParent(ulong cell, uint level)
            => SafeExecution<ulong>(() => Native.S2cellCellToParent(cell, level));

        public static ulong S2cellCellToChild(ulong cell, uint level, uint position)
            => SafeExecution<ulong>(() => Native.S2cellCellToChild(cell, level, position));

        public static IntPtr[] S2cellCellToChildren(ulong cell, uint level)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.S2cellCellToChildren(cell, level, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool S2cellCellContains(ulong cell, ulong other)
            => SafeExecution<bool>(() => Native.S2cellCellContains(cell, other));

        public static int S2cellCommonAncestorLevel(ulong a, ulong b)
            => SafeExecution<int>(() => Native.S2cellCommonAncestorLevel(a, b));

        public static ulong S2cellRangeMin(ulong cell)
            => SafeExecution<ulong>(() => Native.S2cellRangeMin(cell));

        public static ulong S2cellRangeMax(ulong cell)
            => SafeExecution<ulong>(() => Native.S2cellRangeMax(cell));

        public static IntPtr[] S2cellEdgeNeighbors(ulong cell)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.S2cellEdgeNeighbors(cell, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static ulong S2cellPointToCell(double longitude, double latitude, uint level)
            => SafeExecution<ulong>(() => Native.S2cellPointToCell(longitude, latitude, level));

        public static double S2cellCellArea(ulong cell)
            => SafeExecution<double>(() => Native.S2cellCellArea(cell));

        public static double S2cellEdgeLength(ulong cell, uint edge)
            => SafeExecution<double>(() => Native.S2cellEdgeLength(cell, edge));

        public static ulong GeoToS2cellCell(IntPtr point, int level)
            => SafeExecution<ulong>(() => Native.GeoToS2cellCell(point, level));

        public static IntPtr S2cellCellToGeogpoint(ulong cell)
            => SafeExecution<IntPtr>(() => Native.S2cellCellToGeogpoint(cell));

        public static IntPtr S2cellCellToGeog(ulong cell)
            => SafeExecution<IntPtr>(() => Native.S2cellCellToGeog(cell));

        public static IntPtr S2cellToStbox(ulong cell)
            => SafeExecution<IntPtr>(() => Native.S2cellToStbox(cell));

        public static IntPtr S2cellTimestamptzToStbox(ulong cell, long t)
            => SafeExecution<IntPtr>(() => Native.S2cellTimestamptzToStbox(cell, t));

        public static IntPtr S2cellTstzspanToStbox(ulong cell, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.S2cellTstzspanToStbox(cell, s));

        public static IntPtr S2cellEdgeNeighborsSet(ulong cell)
            => SafeExecution<IntPtr>(() => Native.S2cellEdgeNeighborsSet(cell));

        public static IntPtr S2cellCellToChildrenSet(ulong cell, int children_level)
            => SafeExecution<IntPtr>(() => Native.S2cellCellToChildrenSet(cell, children_level));

        public static IntPtr Ts2cellIn(string str)
            => SafeExecution<IntPtr>(() => Native.Ts2cellIn(str));

        public static IntPtr Ts2cellinstIn(string str)
            => SafeExecution<IntPtr>(() => Native.Ts2cellinstIn(str));

        public static IntPtr Ts2cellseqIn(string str, int interp)
            => SafeExecution<IntPtr>(() => Native.Ts2cellseqIn(str, interp));

        public static IntPtr Ts2cellseqsetIn(string str)
            => SafeExecution<IntPtr>(() => Native.Ts2cellseqsetIn(str));

        public static IntPtr Ts2cellMake(ulong value, long t)
            => SafeExecution<IntPtr>(() => Native.Ts2cellMake(value, t));

        public static IntPtr Ts2cellinstMake(ulong value, long t)
            => SafeExecution<IntPtr>(() => Native.Ts2cellinstMake(value, t));

        public static IntPtr Ts2cellseqMake(IntPtr values, IntPtr times, int count, bool lower_inc, bool upper_inc)
            => SafeExecution<IntPtr>(() => Native.Ts2cellseqMake(values, times, count, lower_inc, upper_inc));

        public static IntPtr Ts2cellseqsetMake(IntPtr sequences, int count)
            => SafeExecution<IntPtr>(() => Native.Ts2cellseqsetMake(sequences, count));

        public static ulong Ts2cellStartValue(IntPtr temp)
            => SafeExecution<ulong>(() => Native.Ts2cellStartValue(temp));

        public static ulong Ts2cellEndValue(IntPtr temp)
            => SafeExecution<ulong>(() => Native.Ts2cellEndValue(temp));

        public static bool Ts2cellValueN(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.Ts2cellValueN(temp, n, result));

        public static IntPtr[] Ts2cellValues(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.Ts2cellValues(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool Ts2cellValueAtTimestamptz(IntPtr temp, long t, bool strict, IntPtr result)
            => SafeExecution<bool>(() => Native.Ts2cellValueAtTimestamptz(temp, t, strict, result));

        public static IntPtr S2cellToSet(ulong cell)
            => SafeExecution<IntPtr>(() => Native.S2cellToSet(cell));

        public static IntPtr TbigintToTs2cell(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TbigintToTs2cell(temp));

        public static IntPtr Ts2cellToTbigint(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.Ts2cellToTbigint(temp));

        public static int EverEqS2cellTs2cell(ulong cell, IntPtr temp)
            => SafeExecution<int>(() => Native.EverEqS2cellTs2cell(cell, temp));

        public static int EverEqTs2cellS2cell(IntPtr temp, ulong cell)
            => SafeExecution<int>(() => Native.EverEqTs2cellS2cell(temp, cell));

        public static int EverNeS2cellTs2cell(ulong cell, IntPtr temp)
            => SafeExecution<int>(() => Native.EverNeS2cellTs2cell(cell, temp));

        public static int EverNeTs2cellS2cell(IntPtr temp, ulong cell)
            => SafeExecution<int>(() => Native.EverNeTs2cellS2cell(temp, cell));

        public static int AlwaysEqS2cellTs2cell(ulong cell, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysEqS2cellTs2cell(cell, temp));

        public static int AlwaysEqTs2cellS2cell(IntPtr temp, ulong cell)
            => SafeExecution<int>(() => Native.AlwaysEqTs2cellS2cell(temp, cell));

        public static int AlwaysNeS2cellTs2cell(ulong cell, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysNeS2cellTs2cell(cell, temp));

        public static int AlwaysNeTs2cellS2cell(IntPtr temp, ulong cell)
            => SafeExecution<int>(() => Native.AlwaysNeTs2cellS2cell(temp, cell));

        public static int EverEqTs2cellTs2cell(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverEqTs2cellTs2cell(temp1, temp2));

        public static int EverNeTs2cellTs2cell(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverNeTs2cellTs2cell(temp1, temp2));

        public static int AlwaysEqTs2cellTs2cell(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysEqTs2cellTs2cell(temp1, temp2));

        public static int AlwaysNeTs2cellTs2cell(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysNeTs2cellTs2cell(temp1, temp2));

        public static IntPtr TeqS2cellTs2cell(ulong cell, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TeqS2cellTs2cell(cell, temp));

        public static IntPtr TeqTs2cellS2cell(IntPtr temp, ulong cell)
            => SafeExecution<IntPtr>(() => Native.TeqTs2cellS2cell(temp, cell));

        public static IntPtr TeqTs2cellTs2cell(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TeqTs2cellTs2cell(temp1, temp2));

        public static IntPtr TneS2cellTs2cell(ulong cell, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TneS2cellTs2cell(cell, temp));

        public static IntPtr TneTs2cellS2cell(IntPtr temp, ulong cell)
            => SafeExecution<IntPtr>(() => Native.TneTs2cellS2cell(temp, cell));

        public static IntPtr TneTs2cellTs2cell(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TneTs2cellTs2cell(temp1, temp2));

        public static IntPtr Ts2cellCellToToken(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.Ts2cellCellToToken(temp));

    }
}
