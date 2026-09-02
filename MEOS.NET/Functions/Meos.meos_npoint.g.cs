#nullable enable

using System.Runtime.InteropServices;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>meos_npoint.h</c> declares.</summary>
    public static partial class Meos
    {
        public static string NpointAsEwkt(IntPtr np, int maxdd)
            => SafeExecution<string>(() => Native.NpointAsEwkt(np, maxdd));

        public static string NpointAsHexwkb(IntPtr np, byte variant, IntPtr size_out)
            => SafeExecution<string>(() => Native.NpointAsHexwkb(np, variant, size_out));

        public static string NpointAsText(IntPtr np, int maxdd)
            => SafeExecution<string>(() => Native.NpointAsText(np, maxdd));

        public static IntPtr NpointAsWkb(IntPtr np, byte variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => Native.NpointAsWkb(np, variant, size_out));

        public static IntPtr NpointFromHexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => Native.NpointFromHexwkb(hexwkb));

        public static IntPtr NpointFromWkb(IntPtr wkb, ulong size)
            => SafeExecution<IntPtr>(() => Native.NpointFromWkb(wkb, size));

        public static IntPtr NpointIn(string str)
            => SafeExecution<IntPtr>(() => Native.NpointIn(str));

        public static string NpointOut(IntPtr np, int maxdd)
            => SafeExecution<string>(() => Native.NpointOut(np, maxdd));

        public static IntPtr NsegmentIn(string str)
            => SafeExecution<IntPtr>(() => Native.NsegmentIn(str));

        public static string NsegmentOut(IntPtr ns, int maxdd)
            => SafeExecution<string>(() => Native.NsegmentOut(ns, maxdd));

        public static IntPtr NpointMake(long rid, double pos)
            => SafeExecution<IntPtr>(() => Native.NpointMake(rid, pos));

        public static IntPtr NsegmentMake(long rid, double pos1, double pos2)
            => SafeExecution<IntPtr>(() => Native.NsegmentMake(rid, pos1, pos2));

        public static IntPtr GeompointToNpoint(IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.GeompointToNpoint(gs));

        public static IntPtr GeomToNsegment(IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.GeomToNsegment(gs));

        public static IntPtr NpointToGeompoint(IntPtr np)
            => SafeExecution<IntPtr>(() => Native.NpointToGeompoint(np));

        public static IntPtr NpointToNsegment(IntPtr np)
            => SafeExecution<IntPtr>(() => Native.NpointToNsegment(np));

        public static IntPtr NpointToStbox(IntPtr np)
            => SafeExecution<IntPtr>(() => Native.NpointToStbox(np));

        public static IntPtr NsegmentToGeom(IntPtr ns)
            => SafeExecution<IntPtr>(() => Native.NsegmentToGeom(ns));

        public static IntPtr NsegmentToStbox(IntPtr ns)
            => SafeExecution<IntPtr>(() => Native.NsegmentToStbox(ns));

        public static uint NpointHash(IntPtr np)
            => SafeExecution<uint>(() => Native.NpointHash(np));

        public static ulong NpointHashExtended(IntPtr np, ulong seed)
            => SafeExecution<ulong>(() => Native.NpointHashExtended(np, seed));

        public static double NpointPosition(IntPtr np)
            => SafeExecution<double>(() => Native.NpointPosition(np));

        public static long NpointRoute(IntPtr np)
            => SafeExecution<long>(() => Native.NpointRoute(np));

        public static double NsegmentEndPosition(IntPtr ns)
            => SafeExecution<double>(() => Native.NsegmentEndPosition(ns));

        public static long NsegmentRoute(IntPtr ns)
            => SafeExecution<long>(() => Native.NsegmentRoute(ns));

        public static double NsegmentStartPosition(IntPtr ns)
            => SafeExecution<double>(() => Native.NsegmentStartPosition(ns));

        public static bool RouteExists(long rid)
            => SafeExecution<bool>(() => Native.RouteExists(rid));

        public static IntPtr RouteGeom(long rid)
            => SafeExecution<IntPtr>(() => Native.RouteGeom(rid));

        public static double RouteLength(long rid)
            => SafeExecution<double>(() => Native.RouteLength(rid));

        public static IntPtr NpointRound(IntPtr np, int maxdd)
            => SafeExecution<IntPtr>(() => Native.NpointRound(np, maxdd));

        public static IntPtr NsegmentRound(IntPtr ns, int maxdd)
            => SafeExecution<IntPtr>(() => Native.NsegmentRound(ns, maxdd));

        public static int GetSridWays()
            => SafeExecution<int>(() => Native.GetSridWays());

        public static int NpointSrid(IntPtr np)
            => SafeExecution<int>(() => Native.NpointSrid(np));

        public static int NsegmentSrid(IntPtr ns)
            => SafeExecution<int>(() => Native.NsegmentSrid(ns));

        public static IntPtr NpointTimestamptzToStbox(IntPtr np, long t)
            => SafeExecution<IntPtr>(() => Native.NpointTimestamptzToStbox(np, t));

        public static IntPtr NpointTstzspanToStbox(IntPtr np, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.NpointTstzspanToStbox(np, s));

        public static int NpointCmp(IntPtr np1, IntPtr np2)
            => SafeExecution<int>(() => Native.NpointCmp(np1, np2));

        public static bool NpointEq(IntPtr np1, IntPtr np2)
            => SafeExecution<bool>(() => Native.NpointEq(np1, np2));

        public static bool NpointGe(IntPtr np1, IntPtr np2)
            => SafeExecution<bool>(() => Native.NpointGe(np1, np2));

        public static bool NpointGt(IntPtr np1, IntPtr np2)
            => SafeExecution<bool>(() => Native.NpointGt(np1, np2));

        public static bool NpointLe(IntPtr np1, IntPtr np2)
            => SafeExecution<bool>(() => Native.NpointLe(np1, np2));

        public static bool NpointLt(IntPtr np1, IntPtr np2)
            => SafeExecution<bool>(() => Native.NpointLt(np1, np2));

        public static bool NpointNe(IntPtr np1, IntPtr np2)
            => SafeExecution<bool>(() => Native.NpointNe(np1, np2));

        public static bool NpointSame(IntPtr np1, IntPtr np2)
            => SafeExecution<bool>(() => Native.NpointSame(np1, np2));

        public static int NsegmentCmp(IntPtr ns1, IntPtr ns2)
            => SafeExecution<int>(() => Native.NsegmentCmp(ns1, ns2));

        public static bool NsegmentEq(IntPtr ns1, IntPtr ns2)
            => SafeExecution<bool>(() => Native.NsegmentEq(ns1, ns2));

        public static bool NsegmentGe(IntPtr ns1, IntPtr ns2)
            => SafeExecution<bool>(() => Native.NsegmentGe(ns1, ns2));

        public static bool NsegmentGt(IntPtr ns1, IntPtr ns2)
            => SafeExecution<bool>(() => Native.NsegmentGt(ns1, ns2));

        public static bool NsegmentLe(IntPtr ns1, IntPtr ns2)
            => SafeExecution<bool>(() => Native.NsegmentLe(ns1, ns2));

        public static bool NsegmentLt(IntPtr ns1, IntPtr ns2)
            => SafeExecution<bool>(() => Native.NsegmentLt(ns1, ns2));

        public static bool NsegmentNe(IntPtr ns1, IntPtr ns2)
            => SafeExecution<bool>(() => Native.NsegmentNe(ns1, ns2));

        public static IntPtr NpointsetIn(string str)
            => SafeExecution<IntPtr>(() => Native.NpointsetIn(str));

        public static string NpointsetOut(IntPtr s, int maxdd)
            => SafeExecution<string>(() => Native.NpointsetOut(s, maxdd));

        public static IntPtr NpointsetMake(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => Native.NpointsetMake(values, count));

        public static IntPtr NpointToSet(IntPtr np)
            => SafeExecution<IntPtr>(() => Native.NpointToSet(np));

        public static IntPtr NpointsetEndValue(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.NpointsetEndValue(s));

        public static IntPtr NpointsetRoutes(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.NpointsetRoutes(s));

        public static IntPtr NpointsetStartValue(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.NpointsetStartValue(s));

        public static bool NpointsetValueN(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.NpointsetValueN(s, n, result));

        public static IntPtr[] NpointsetValues(IntPtr s)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.NpointsetValues(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool ContainedNpointSet(IntPtr np, IntPtr s)
            => SafeExecution<bool>(() => Native.ContainedNpointSet(np, s));

        public static bool ContainsSetNpoint(IntPtr s, IntPtr np)
            => SafeExecution<bool>(() => Native.ContainsSetNpoint(s, np));

        public static IntPtr IntersectionNpointSet(IntPtr np, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.IntersectionNpointSet(np, s));

        public static IntPtr IntersectionSetNpoint(IntPtr s, IntPtr np)
            => SafeExecution<IntPtr>(() => Native.IntersectionSetNpoint(s, np));

        public static IntPtr MinusNpointSet(IntPtr np, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.MinusNpointSet(np, s));

        public static IntPtr MinusSetNpoint(IntPtr s, IntPtr np)
            => SafeExecution<IntPtr>(() => Native.MinusSetNpoint(s, np));

        public static IntPtr NpointUnionTransfn(IntPtr state, IntPtr np)
            => SafeExecution<IntPtr>(() => Native.NpointUnionTransfn(state, np));

        public static IntPtr UnionNpointSet(IntPtr np, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.UnionNpointSet(np, s));

        public static IntPtr UnionSetNpoint(IntPtr s, IntPtr np)
            => SafeExecution<IntPtr>(() => Native.UnionSetNpoint(s, np));

        public static IntPtr TnpointIn(string str)
            => SafeExecution<IntPtr>(() => Native.TnpointIn(str));

        public static IntPtr TnpointFromMfjson(string mfjson)
            => SafeExecution<IntPtr>(() => Native.TnpointFromMfjson(mfjson));

        public static string TnpointOut(IntPtr temp, int maxdd)
            => SafeExecution<string>(() => Native.TnpointOut(temp, maxdd));

        public static IntPtr TnpointinstMake(IntPtr np, long t)
            => SafeExecution<IntPtr>(() => Native.TnpointinstMake(np, t));

        public static IntPtr TnpointFromBaseTemp(IntPtr np, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TnpointFromBaseTemp(np, temp));

        public static IntPtr TnpointseqFromBaseTstzset(IntPtr np, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TnpointseqFromBaseTstzset(np, s));

        public static IntPtr TnpointseqFromBaseTstzspan(IntPtr np, IntPtr s, int interp)
            => SafeExecution<IntPtr>(() => Native.TnpointseqFromBaseTstzspan(np, s, interp));

        public static IntPtr TnpointseqsetFromBaseTstzspanset(IntPtr np, IntPtr ss, int interp)
            => SafeExecution<IntPtr>(() => Native.TnpointseqsetFromBaseTstzspanset(np, ss, interp));

        public static IntPtr TgeompointToTnpoint(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TgeompointToTnpoint(temp));

        public static IntPtr TnpointToTgeompoint(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TnpointToTgeompoint(temp));

        public static IntPtr TnpointCumulativeLength(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TnpointCumulativeLength(temp));

        public static IntPtr TnpointEndValue(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TnpointEndValue(temp));

        public static double TnpointLength(IntPtr temp)
            => SafeExecution<double>(() => Native.TnpointLength(temp));

        public static IntPtr[] TnpointPositions(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TnpointPositions(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static long TnpointRoute(IntPtr temp)
            => SafeExecution<long>(() => Native.TnpointRoute(temp));

        public static IntPtr TnpointRoutes(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TnpointRoutes(temp));

        public static IntPtr TnpointSpeed(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TnpointSpeed(temp));

        public static IntPtr TnpointStartValue(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TnpointStartValue(temp));

        public static IntPtr TnpointTrajectory(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TnpointTrajectory(temp));

        public static bool TnpointValueAtTimestamptz(IntPtr temp, long t, bool strict, IntPtr value)
            => SafeExecution<bool>(() => Native.TnpointValueAtTimestamptz(temp, t, strict, value));

        public static bool TnpointValueN(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.TnpointValueN(temp, n, result));

        public static IntPtr[] TnpointValues(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TnpointValues(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr TnpointTwcentroid(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TnpointTwcentroid(temp));

        public static IntPtr TnpointAtGeom(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TnpointAtGeom(temp, gs));

        public static IntPtr TnpointAtNpoint(IntPtr temp, IntPtr np)
            => SafeExecution<IntPtr>(() => Native.TnpointAtNpoint(temp, np));

        public static IntPtr TnpointAtNpointset(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TnpointAtNpointset(temp, s));

        public static IntPtr TnpointAtStbox(IntPtr temp, IntPtr box, bool border_inc)
            => SafeExecution<IntPtr>(() => Native.TnpointAtStbox(temp, box, border_inc));

        public static IntPtr TnpointMinusGeom(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TnpointMinusGeom(temp, gs));

        public static IntPtr TnpointMinusNpoint(IntPtr temp, IntPtr np)
            => SafeExecution<IntPtr>(() => Native.TnpointMinusNpoint(temp, np));

        public static IntPtr TnpointMinusNpointset(IntPtr temp, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TnpointMinusNpointset(temp, s));

        public static IntPtr TnpointMinusStbox(IntPtr temp, IntPtr box, bool border_inc)
            => SafeExecution<IntPtr>(() => Native.TnpointMinusStbox(temp, box, border_inc));

        public static IntPtr TdistanceTnpointNpoint(IntPtr temp, IntPtr np)
            => SafeExecution<IntPtr>(() => Native.TdistanceTnpointNpoint(temp, np));

        public static IntPtr TdistanceTnpointGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TdistanceTnpointGeo(temp, gs));

        public static IntPtr TdistanceTnpointTnpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TdistanceTnpointTnpoint(temp1, temp2));

        public static double NadTnpointGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<double>(() => Native.NadTnpointGeo(temp, gs));

        public static double NadTnpointNpoint(IntPtr temp, IntPtr np)
            => SafeExecution<double>(() => Native.NadTnpointNpoint(temp, np));

        public static double NadTnpointStbox(IntPtr temp, IntPtr box)
            => SafeExecution<double>(() => Native.NadTnpointStbox(temp, box));

        public static double NadTnpointTnpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => Native.NadTnpointTnpoint(temp1, temp2));

        public static IntPtr NaiTnpointGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.NaiTnpointGeo(temp, gs));

        public static IntPtr NaiTnpointNpoint(IntPtr temp, IntPtr np)
            => SafeExecution<IntPtr>(() => Native.NaiTnpointNpoint(temp, np));

        public static IntPtr NaiTnpointTnpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.NaiTnpointTnpoint(temp1, temp2));

        public static IntPtr ShortestlineTnpointGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.ShortestlineTnpointGeo(temp, gs));

        public static IntPtr ShortestlineTnpointNpoint(IntPtr temp, IntPtr np)
            => SafeExecution<IntPtr>(() => Native.ShortestlineTnpointNpoint(temp, np));

        public static IntPtr ShortestlineTnpointTnpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.ShortestlineTnpointTnpoint(temp1, temp2));

        public static IntPtr TnpointTcentroidTransfn(IntPtr state, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TnpointTcentroidTransfn(state, temp));

        public static int AlwaysEqNpointTnpoint(IntPtr np, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysEqNpointTnpoint(np, temp));

        public static int AlwaysEqTnpointNpoint(IntPtr temp, IntPtr np)
            => SafeExecution<int>(() => Native.AlwaysEqTnpointNpoint(temp, np));

        public static int AlwaysEqTnpointTnpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysEqTnpointTnpoint(temp1, temp2));

        public static int AlwaysNeNpointTnpoint(IntPtr np, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysNeNpointTnpoint(np, temp));

        public static int AlwaysNeTnpointNpoint(IntPtr temp, IntPtr np)
            => SafeExecution<int>(() => Native.AlwaysNeTnpointNpoint(temp, np));

        public static int AlwaysNeTnpointTnpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysNeTnpointTnpoint(temp1, temp2));

        public static int EverEqNpointTnpoint(IntPtr np, IntPtr temp)
            => SafeExecution<int>(() => Native.EverEqNpointTnpoint(np, temp));

        public static int EverEqTnpointNpoint(IntPtr temp, IntPtr np)
            => SafeExecution<int>(() => Native.EverEqTnpointNpoint(temp, np));

        public static int EverEqTnpointTnpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverEqTnpointTnpoint(temp1, temp2));

        public static int EverNeNpointTnpoint(IntPtr np, IntPtr temp)
            => SafeExecution<int>(() => Native.EverNeNpointTnpoint(np, temp));

        public static int EverNeTnpointNpoint(IntPtr temp, IntPtr np)
            => SafeExecution<int>(() => Native.EverNeTnpointNpoint(temp, np));

        public static int EverNeTnpointTnpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverNeTnpointTnpoint(temp1, temp2));

        public static IntPtr TeqTnpointNpoint(IntPtr temp, IntPtr np)
            => SafeExecution<IntPtr>(() => Native.TeqTnpointNpoint(temp, np));

        public static IntPtr TneTnpointNpoint(IntPtr temp, IntPtr np)
            => SafeExecution<IntPtr>(() => Native.TneTnpointNpoint(temp, np));

    }
}
