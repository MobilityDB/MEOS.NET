#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Structures;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>meos_quadbin.h</c> declares.</summary>
    public static partial class Meos
    {
        public static ulong QuadbinIn(string str)
            => SafeExecution<ulong>(() => Native.QuadbinIn(str));

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

        public static bool QuadbinCellToTile(ulong cell, IntPtr x, IntPtr y, IntPtr z)
            => SafeExecution<bool>(() => Native.QuadbinCellToTile(cell, x, y, z));

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

        public static IntPtr QuadbinCellToGeompoint(ulong cell)
            => SafeExecution<IntPtr>(() => Native.QuadbinCellToGeompoint(cell));

        public static IntPtr QuadbinCellToGeom(ulong cell)
            => SafeExecution<IntPtr>(() => Native.QuadbinCellToGeom(cell));

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

        public static IntPtr QuadbinCellToChildrenSet(ulong origin, int children_resolution)
            => SafeExecution<IntPtr>(() => Native.QuadbinCellToChildrenSet(origin, children_resolution));

        public static IntPtr TquadbinIn(string str)
            => SafeExecution<IntPtr>(() => Native.TquadbinIn(str));

        public static IntPtr TquadbininstIn(string str)
            => SafeExecution<IntPtr>(() => Native.TquadbininstIn(str));

        public static IntPtr TquadbinseqIn(string str, int interp)
            => SafeExecution<IntPtr>(() => Native.TquadbinseqIn(str, interp));

        public static IntPtr TquadbinseqsetIn(string str)
            => SafeExecution<IntPtr>(() => Native.TquadbinseqsetIn(str));

        public static IntPtr TquadbinMake(ulong value, long t)
            => SafeExecution<IntPtr>(() => Native.TquadbinMake(value, t));

        public static IntPtr TquadbininstMake(ulong value, long t)
            => SafeExecution<IntPtr>(() => Native.TquadbininstMake(value, t));

        public static IntPtr TquadbinseqMake(IntPtr values, IntPtr times, int count, bool lower_inc, bool upper_inc)
            => SafeExecution<IntPtr>(() => Native.TquadbinseqMake(values, times, count, lower_inc, upper_inc));

        public static IntPtr TquadbinseqsetMake(IntPtr sequences, int count)
            => SafeExecution<IntPtr>(() => Native.TquadbinseqsetMake(sequences, count));

        public static ulong TquadbinStartValue(IntPtr temp)
            => SafeExecution<ulong>(() => Native.TquadbinStartValue(temp));

        public static ulong TquadbinEndValue(IntPtr temp)
            => SafeExecution<ulong>(() => Native.TquadbinEndValue(temp));

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

        public static bool TquadbinValueAtTimestamptz(IntPtr temp, long t, bool strict, IntPtr result)
            => SafeExecution<bool>(() => Native.TquadbinValueAtTimestamptz(temp, t, strict, result));

        public static IntPtr QuadbinToSet(ulong cell)
            => SafeExecution<IntPtr>(() => Native.QuadbinToSet(cell));

        public static IntPtr TbigintToTquadbin(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TbigintToTquadbin(temp));

        public static IntPtr TquadbinToTbigint(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TquadbinToTbigint(temp));

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

        public static IntPtr TquadbinCellToQuadkey(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TquadbinCellToQuadkey(temp));

    }
}
