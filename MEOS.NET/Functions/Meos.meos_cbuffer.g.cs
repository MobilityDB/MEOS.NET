#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Structures;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>meos_cbuffer.h</c> declares.</summary>
    public static partial class Meos
    {
        public static string CbufferAsEwkt(IntPtr cb, int maxdd)
            => SafeExecution<string>(() => Native.CbufferAsEwkt(cb, maxdd));

        public static string CbufferAsHexwkb(IntPtr cb, byte variant, IntPtr size_out)
            => SafeExecution<string>(() => Native.CbufferAsHexwkb(cb, variant, size_out));

        public static string CbufferAsText(IntPtr cb, int maxdd)
            => SafeExecution<string>(() => Native.CbufferAsText(cb, maxdd));

        public static IntPtr CbufferAsWkb(IntPtr cb, byte variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => Native.CbufferAsWkb(cb, variant, size_out));

        public static IntPtr CbufferFromHexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => Native.CbufferFromHexwkb(hexwkb));

        public static IntPtr CbufferFromWkb(IntPtr wkb, ulong size)
            => SafeExecution<IntPtr>(() => Native.CbufferFromWkb(wkb, size));

        public static IntPtr CbufferIn(string str)
            => SafeExecution<IntPtr>(() => Native.CbufferIn(str));

        public static string CbufferOut(IntPtr cb, int maxdd)
            => SafeExecution<string>(() => Native.CbufferOut(cb, maxdd));

        public static IntPtr CbufferCopy(IntPtr cb)
            => SafeExecution<IntPtr>(() => Native.CbufferCopy(cb));

        public static IntPtr CbufferMake(IntPtr point, double radius)
            => SafeExecution<IntPtr>(() => Native.CbufferMake(point, radius));

        public static IntPtr CbufferToGeom(IntPtr cb)
            => SafeExecution<IntPtr>(() => Native.CbufferToGeom(cb));

        public static IntPtr CbufferToStbox(IntPtr cb)
            => SafeExecution<IntPtr>(() => Native.CbufferToStbox(cb));

        public static IntPtr CbufferarrToGeom(IntPtr cbarr, int count)
            => SafeExecution<IntPtr>(() => Native.CbufferarrToGeom(cbarr, count));

        public static IntPtr GeomToCbuffer(IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.GeomToCbuffer(gs));

        public static uint CbufferHash(IntPtr cb)
            => SafeExecution<uint>(() => Native.CbufferHash(cb));

        public static ulong CbufferHashExtended(IntPtr cb, ulong seed)
            => SafeExecution<ulong>(() => Native.CbufferHashExtended(cb, seed));

        public static IntPtr CbufferPoint(IntPtr cb)
            => SafeExecution<IntPtr>(() => Native.CbufferPoint(cb));

        public static double CbufferRadius(IntPtr cb)
            => SafeExecution<double>(() => Native.CbufferRadius(cb));

        public static IntPtr CbufferRound(IntPtr cb, int maxdd)
            => SafeExecution<IntPtr>(() => Native.CbufferRound(cb, maxdd));

        public static IntPtr CbufferarrRound(IntPtr cbarr, int count, int maxdd)
            => SafeExecution<IntPtr>(() => Native.CbufferarrRound(cbarr, count, maxdd));

        public static IntPtr CbufferSetSrid(IntPtr cb, int srid)
            => SafeExecution<IntPtr>(() => Native.CbufferSetSrid(cb, srid));

        public static int CbufferSrid(IntPtr cb)
            => SafeExecution<int>(() => Native.CbufferSrid(cb));

        public static IntPtr CbufferTransform(IntPtr cb, int srid)
            => SafeExecution<IntPtr>(() => Native.CbufferTransform(cb, srid));

        public static IntPtr CbufferTransformPipeline(IntPtr cb, string pipelinestr, int srid, bool is_forward)
            => SafeExecution<IntPtr>(() => Native.CbufferTransformPipeline(cb, pipelinestr, srid, is_forward));

        public static int ContainsCbufferCbuffer(IntPtr cb1, IntPtr cb2)
            => SafeExecution<int>(() => Native.ContainsCbufferCbuffer(cb1, cb2));

        public static int CoversCbufferCbuffer(IntPtr cb1, IntPtr cb2)
            => SafeExecution<int>(() => Native.CoversCbufferCbuffer(cb1, cb2));

        public static int DisjointCbufferCbuffer(IntPtr cb1, IntPtr cb2)
            => SafeExecution<int>(() => Native.DisjointCbufferCbuffer(cb1, cb2));

        public static int DwithinCbufferCbuffer(IntPtr cb1, IntPtr cb2, double dist)
            => SafeExecution<int>(() => Native.DwithinCbufferCbuffer(cb1, cb2, dist));

        public static int IntersectsCbufferCbuffer(IntPtr cb1, IntPtr cb2)
            => SafeExecution<int>(() => Native.IntersectsCbufferCbuffer(cb1, cb2));

        public static int TouchesCbufferCbuffer(IntPtr cb1, IntPtr cb2)
            => SafeExecution<int>(() => Native.TouchesCbufferCbuffer(cb1, cb2));

        public static IntPtr CbufferTstzspanToStbox(IntPtr cb, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.CbufferTstzspanToStbox(cb, s));

        public static IntPtr CbufferTimestamptzToStbox(IntPtr cb, long t)
            => SafeExecution<IntPtr>(() => Native.CbufferTimestamptzToStbox(cb, t));

        public static double DistanceCbufferCbuffer(IntPtr cb1, IntPtr cb2)
            => SafeExecution<double>(() => Native.DistanceCbufferCbuffer(cb1, cb2));

        public static double DistanceCbufferGeo(IntPtr cb, IntPtr gs)
            => SafeExecution<double>(() => Native.DistanceCbufferGeo(cb, gs));

        public static double DistanceCbufferStbox(IntPtr cb, IntPtr box)
            => SafeExecution<double>(() => Native.DistanceCbufferStbox(cb, box));

        public static double NadCbufferStbox(IntPtr cb, IntPtr box)
            => SafeExecution<double>(() => Native.NadCbufferStbox(cb, box));

        public static int CbufferCmp(IntPtr cb1, IntPtr cb2)
            => SafeExecution<int>(() => Native.CbufferCmp(cb1, cb2));

        public static bool CbufferEq(IntPtr cb1, IntPtr cb2)
            => SafeExecution<bool>(() => Native.CbufferEq(cb1, cb2));

        public static bool CbufferGe(IntPtr cb1, IntPtr cb2)
            => SafeExecution<bool>(() => Native.CbufferGe(cb1, cb2));

        public static bool CbufferGt(IntPtr cb1, IntPtr cb2)
            => SafeExecution<bool>(() => Native.CbufferGt(cb1, cb2));

        public static bool CbufferLe(IntPtr cb1, IntPtr cb2)
            => SafeExecution<bool>(() => Native.CbufferLe(cb1, cb2));

        public static bool CbufferLt(IntPtr cb1, IntPtr cb2)
            => SafeExecution<bool>(() => Native.CbufferLt(cb1, cb2));

        public static bool CbufferNe(IntPtr cb1, IntPtr cb2)
            => SafeExecution<bool>(() => Native.CbufferNe(cb1, cb2));

        public static bool CbufferNsame(IntPtr cb1, IntPtr cb2)
            => SafeExecution<bool>(() => Native.CbufferNsame(cb1, cb2));

        public static bool CbufferSame(IntPtr cb1, IntPtr cb2)
            => SafeExecution<bool>(() => Native.CbufferSame(cb1, cb2));

        public static IntPtr CbuffersetIn(string str)
            => SafeExecution<IntPtr>(() => Native.CbuffersetIn(str));

        public static string CbuffersetOut(IntPtr s, int maxdd)
            => SafeExecution<string>(() => Native.CbuffersetOut(s, maxdd));

        public static IntPtr CbuffersetMake(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => Native.CbuffersetMake(values, count));

        public static IntPtr CbufferToSet(IntPtr cb)
            => SafeExecution<IntPtr>(() => Native.CbufferToSet(cb));

        public static IntPtr CbuffersetEndValue(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.CbuffersetEndValue(s));

        public static IntPtr CbuffersetStartValue(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.CbuffersetStartValue(s));

        public static bool CbuffersetValueN(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.CbuffersetValueN(s, n, result));

        public static IntPtr[] CbuffersetValues(IntPtr s)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.CbuffersetValues(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr CbufferUnionTransfn(IntPtr state, IntPtr cb)
            => SafeExecution<IntPtr>(() => Native.CbufferUnionTransfn(state, cb));

        public static bool ContainedCbufferSet(IntPtr cb, IntPtr s)
            => SafeExecution<bool>(() => Native.ContainedCbufferSet(cb, s));

        public static bool ContainsSetCbuffer(IntPtr s, IntPtr cb)
            => SafeExecution<bool>(() => Native.ContainsSetCbuffer(s, cb));

        public static IntPtr IntersectionCbufferSet(IntPtr cb, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.IntersectionCbufferSet(cb, s));

        public static IntPtr IntersectionSetCbuffer(IntPtr s, IntPtr cb)
            => SafeExecution<IntPtr>(() => Native.IntersectionSetCbuffer(s, cb));

        public static IntPtr MinusCbufferSet(IntPtr cb, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.MinusCbufferSet(cb, s));

        public static IntPtr MinusSetCbuffer(IntPtr s, IntPtr cb)
            => SafeExecution<IntPtr>(() => Native.MinusSetCbuffer(s, cb));

        public static IntPtr UnionCbufferSet(IntPtr cb, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.UnionCbufferSet(cb, s));

        public static IntPtr UnionSetCbuffer(IntPtr s, IntPtr cb)
            => SafeExecution<IntPtr>(() => Native.UnionSetCbuffer(s, cb));

        public static IntPtr TcbufferIn(string str)
            => SafeExecution<IntPtr>(() => Native.TcbufferIn(str));

        public static IntPtr TcbufferFromMfjson(string mfjson)
            => SafeExecution<IntPtr>(() => Native.TcbufferFromMfjson(mfjson));

        public static IntPtr TcbufferinstMake(IntPtr cb, long t)
            => SafeExecution<IntPtr>(() => Native.TcbufferinstMake(cb, t));

        public static IntPtr TcbufferMake(IntPtr tpoint, IntPtr tfloat)
            => SafeExecution<IntPtr>(() => Native.TcbufferMake(tpoint, tfloat));

        public static IntPtr TcbufferFromBaseTemp(IntPtr cb, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TcbufferFromBaseTemp(cb, temp));

        public static IntPtr TcbufferseqFromBaseTstzset(IntPtr cb, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TcbufferseqFromBaseTstzset(cb, s));

        public static IntPtr TcbufferseqFromBaseTstzspan(IntPtr cb, IntPtr s, int interp)
            => SafeExecution<IntPtr>(() => Native.TcbufferseqFromBaseTstzspan(cb, s, interp));

        public static IntPtr TcbufferseqsetFromBaseTstzspanset(IntPtr cb, IntPtr ss, int interp)
            => SafeExecution<IntPtr>(() => Native.TcbufferseqsetFromBaseTstzspanset(cb, ss, interp));

        public static IntPtr TcbufferEndValue(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TcbufferEndValue(temp));

        public static IntPtr TcbufferPoints(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TcbufferPoints(temp));

        public static IntPtr TcbufferRadius(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TcbufferRadius(temp));

        public static IntPtr TcbufferTraversedArea(IntPtr temp, bool unary_union)
            => SafeExecution<IntPtr>(() => Native.TcbufferTraversedArea(temp, unary_union));

        public static IntPtr TcbufferConvexHull(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TcbufferConvexHull(temp));

        public static IntPtr TcbufferStartValue(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TcbufferStartValue(temp));

        public static bool TcbufferValueAtTimestamptz(IntPtr temp, long t, bool strict, IntPtr value)
            => SafeExecution<bool>(() => Native.TcbufferValueAtTimestamptz(temp, t, strict, value));

        public static bool TcbufferValueN(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.TcbufferValueN(temp, n, result));

        public static IntPtr[] TcbufferValues(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TcbufferValues(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr TcbufferToTfloat(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TcbufferToTfloat(temp));

        public static IntPtr TcbufferToTgeompoint(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TcbufferToTgeompoint(temp));

        public static IntPtr TgeometryToTcbuffer(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TgeometryToTcbuffer(temp));

        public static IntPtr TcbufferExpand(IntPtr temp, double dist)
            => SafeExecution<IntPtr>(() => Native.TcbufferExpand(temp, dist));

        public static IntPtr TcbufferAtCbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<IntPtr>(() => Native.TcbufferAtCbuffer(temp, cb));

        public static IntPtr TcbufferAtGeom(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TcbufferAtGeom(temp, gs));

        public static IntPtr TcbufferAtStbox(IntPtr temp, IntPtr box, bool border_inc)
            => SafeExecution<IntPtr>(() => Native.TcbufferAtStbox(temp, box, border_inc));

        public static IntPtr TcbufferMinusCbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<IntPtr>(() => Native.TcbufferMinusCbuffer(temp, cb));

        public static IntPtr TcbufferMinusGeom(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TcbufferMinusGeom(temp, gs));

        public static IntPtr TcbufferMinusStbox(IntPtr temp, IntPtr box, bool border_inc)
            => SafeExecution<IntPtr>(() => Native.TcbufferMinusStbox(temp, box, border_inc));

        public static IntPtr TdistanceTcbufferCbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<IntPtr>(() => Native.TdistanceTcbufferCbuffer(temp, cb));

        public static IntPtr TdistanceTcbufferGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TdistanceTcbufferGeo(temp, gs));

        public static IntPtr TdistanceTcbufferTcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TdistanceTcbufferTcbuffer(temp1, temp2));

        public static double NadTcbufferCbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<double>(() => Native.NadTcbufferCbuffer(temp, cb));

        public static double NadTcbufferGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<double>(() => Native.NadTcbufferGeo(temp, gs));

        public static double NadTcbufferStbox(IntPtr temp, IntPtr box)
            => SafeExecution<double>(() => Native.NadTcbufferStbox(temp, box));

        public static double NadTcbufferTcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<double>(() => Native.NadTcbufferTcbuffer(temp1, temp2));

        public static double MindistanceTcbufferTcbuffer(IntPtr temp1, IntPtr temp2, double threshold)
            => SafeExecution<double>(() => Native.MindistanceTcbufferTcbuffer(temp1, temp2, threshold));

        public static IntPtr NaiTcbufferCbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<IntPtr>(() => Native.NaiTcbufferCbuffer(temp, cb));

        public static IntPtr NaiTcbufferGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.NaiTcbufferGeo(temp, gs));

        public static IntPtr NaiTcbufferTcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.NaiTcbufferTcbuffer(temp1, temp2));

        public static IntPtr ShortestlineTcbufferCbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<IntPtr>(() => Native.ShortestlineTcbufferCbuffer(temp, cb));

        public static IntPtr ShortestlineTcbufferGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.ShortestlineTcbufferGeo(temp, gs));

        public static IntPtr ShortestlineTcbufferTcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.ShortestlineTcbufferTcbuffer(temp1, temp2));

        public static int AlwaysEqCbufferTcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysEqCbufferTcbuffer(cb, temp));

        public static int AlwaysEqTcbufferCbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<int>(() => Native.AlwaysEqTcbufferCbuffer(temp, cb));

        public static int AlwaysEqTcbufferTcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysEqTcbufferTcbuffer(temp1, temp2));

        public static int AlwaysNeCbufferTcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysNeCbufferTcbuffer(cb, temp));

        public static int AlwaysNeTcbufferCbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<int>(() => Native.AlwaysNeTcbufferCbuffer(temp, cb));

        public static int AlwaysNeTcbufferTcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysNeTcbufferTcbuffer(temp1, temp2));

        public static int EverEqCbufferTcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<int>(() => Native.EverEqCbufferTcbuffer(cb, temp));

        public static int EverEqTcbufferCbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<int>(() => Native.EverEqTcbufferCbuffer(temp, cb));

        public static int EverEqTcbufferTcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverEqTcbufferTcbuffer(temp1, temp2));

        public static int EverNeCbufferTcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<int>(() => Native.EverNeCbufferTcbuffer(cb, temp));

        public static int EverNeTcbufferCbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<int>(() => Native.EverNeTcbufferCbuffer(temp, cb));

        public static int EverNeTcbufferTcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverNeTcbufferTcbuffer(temp1, temp2));

        public static IntPtr TeqCbufferTcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TeqCbufferTcbuffer(cb, temp));

        public static IntPtr TeqTcbufferCbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<IntPtr>(() => Native.TeqTcbufferCbuffer(temp, cb));

        public static IntPtr TneCbufferTcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TneCbufferTcbuffer(cb, temp));

        public static IntPtr TneTcbufferCbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<IntPtr>(() => Native.TneTcbufferCbuffer(temp, cb));

        public static int AcontainsCbufferTcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<int>(() => Native.AcontainsCbufferTcbuffer(cb, temp));

        public static int AcontainsGeoTcbuffer(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => Native.AcontainsGeoTcbuffer(gs, temp));

        public static int AcontainsTcbufferCbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<int>(() => Native.AcontainsTcbufferCbuffer(temp, cb));

        public static int AcontainsTcbufferGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.AcontainsTcbufferGeo(temp, gs));

        public static int AcontainsTcbufferTcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AcontainsTcbufferTcbuffer(temp1, temp2));

        public static int AcoversCbufferTcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<int>(() => Native.AcoversCbufferTcbuffer(cb, temp));

        public static int AcoversGeoTcbuffer(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => Native.AcoversGeoTcbuffer(gs, temp));

        public static int AcoversTcbufferCbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<int>(() => Native.AcoversTcbufferCbuffer(temp, cb));

        public static int AcoversTcbufferGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.AcoversTcbufferGeo(temp, gs));

        public static int AcoversTcbufferTcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AcoversTcbufferTcbuffer(temp1, temp2));

        public static int AdisjointTcbufferGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.AdisjointTcbufferGeo(temp, gs));

        public static int AdisjointTcbufferCbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<int>(() => Native.AdisjointTcbufferCbuffer(temp, cb));

        public static int AdisjointTcbufferTcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AdisjointTcbufferTcbuffer(temp1, temp2));

        public static int AdwithinTcbufferGeo(IntPtr temp, IntPtr gs, double dist)
            => SafeExecution<int>(() => Native.AdwithinTcbufferGeo(temp, gs, dist));

        public static int AdwithinTcbufferCbuffer(IntPtr temp, IntPtr cb, double dist)
            => SafeExecution<int>(() => Native.AdwithinTcbufferCbuffer(temp, cb, dist));

        public static int AdwithinTcbufferTcbuffer(IntPtr temp1, IntPtr temp2, double dist)
            => SafeExecution<int>(() => Native.AdwithinTcbufferTcbuffer(temp1, temp2, dist));

        public static int AintersectsTcbufferGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.AintersectsTcbufferGeo(temp, gs));

        public static int AintersectsTcbufferCbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<int>(() => Native.AintersectsTcbufferCbuffer(temp, cb));

        public static int AintersectsTcbufferTcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AintersectsTcbufferTcbuffer(temp1, temp2));

        public static int AtouchesTcbufferGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.AtouchesTcbufferGeo(temp, gs));

        public static int AtouchesTcbufferCbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<int>(() => Native.AtouchesTcbufferCbuffer(temp, cb));

        public static int AtouchesTcbufferTcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AtouchesTcbufferTcbuffer(temp1, temp2));

        public static int EcontainsCbufferTcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<int>(() => Native.EcontainsCbufferTcbuffer(cb, temp));

        public static int EcontainsTcbufferCbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<int>(() => Native.EcontainsTcbufferCbuffer(temp, cb));

        public static int EcontainsTcbufferGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.EcontainsTcbufferGeo(temp, gs));

        public static int EcontainsTcbufferTcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EcontainsTcbufferTcbuffer(temp1, temp2));

        public static int EcoversCbufferTcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<int>(() => Native.EcoversCbufferTcbuffer(cb, temp));

        public static int EcoversGeoTcbuffer(IntPtr gs, IntPtr temp)
            => SafeExecution<int>(() => Native.EcoversGeoTcbuffer(gs, temp));

        public static int EcoversTcbufferCbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<int>(() => Native.EcoversTcbufferCbuffer(temp, cb));

        public static int EcoversTcbufferGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.EcoversTcbufferGeo(temp, gs));

        public static int EcoversTcbufferTcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EcoversTcbufferTcbuffer(temp1, temp2));

        public static int EdisjointTcbufferGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.EdisjointTcbufferGeo(temp, gs));

        public static int EdisjointTcbufferCbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<int>(() => Native.EdisjointTcbufferCbuffer(temp, cb));

        public static int EdwithinTcbufferGeo(IntPtr temp, IntPtr gs, double dist)
            => SafeExecution<int>(() => Native.EdwithinTcbufferGeo(temp, gs, dist));

        public static int EdwithinTcbufferCbuffer(IntPtr temp, IntPtr cb, double dist)
            => SafeExecution<int>(() => Native.EdwithinTcbufferCbuffer(temp, cb, dist));

        public static int EdwithinTcbufferTcbuffer(IntPtr temp1, IntPtr temp2, double dist)
            => SafeExecution<int>(() => Native.EdwithinTcbufferTcbuffer(temp1, temp2, dist));

        public static int EintersectsTcbufferGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.EintersectsTcbufferGeo(temp, gs));

        public static int EintersectsTcbufferCbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<int>(() => Native.EintersectsTcbufferCbuffer(temp, cb));

        public static int EintersectsTcbufferTcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EintersectsTcbufferTcbuffer(temp1, temp2));

        public static int EtouchesTcbufferGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<int>(() => Native.EtouchesTcbufferGeo(temp, gs));

        public static int EtouchesTcbufferCbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<int>(() => Native.EtouchesTcbufferCbuffer(temp, cb));

        public static int EtouchesTcbufferTcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EtouchesTcbufferTcbuffer(temp1, temp2));

        public static IntPtr TcontainsCbufferTcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TcontainsCbufferTcbuffer(cb, temp));

        public static IntPtr TcontainsGeoTcbuffer(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TcontainsGeoTcbuffer(gs, temp));

        public static IntPtr TcontainsTcbufferGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TcontainsTcbufferGeo(temp, gs));

        public static IntPtr TcontainsTcbufferCbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<IntPtr>(() => Native.TcontainsTcbufferCbuffer(temp, cb));

        public static IntPtr TcontainsTcbufferTcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TcontainsTcbufferTcbuffer(temp1, temp2));

        public static IntPtr TcoversCbufferTcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TcoversCbufferTcbuffer(cb, temp));

        public static IntPtr TcoversGeoTcbuffer(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TcoversGeoTcbuffer(gs, temp));

        public static IntPtr TcoversTcbufferGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TcoversTcbufferGeo(temp, gs));

        public static IntPtr TcoversTcbufferCbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<IntPtr>(() => Native.TcoversTcbufferCbuffer(temp, cb));

        public static IntPtr TcoversTcbufferTcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TcoversTcbufferTcbuffer(temp1, temp2));

        public static IntPtr TdwithinGeoTcbuffer(IntPtr gs, IntPtr temp, double dist)
            => SafeExecution<IntPtr>(() => Native.TdwithinGeoTcbuffer(gs, temp, dist));

        public static IntPtr TdwithinTcbufferGeo(IntPtr temp, IntPtr gs, double dist)
            => SafeExecution<IntPtr>(() => Native.TdwithinTcbufferGeo(temp, gs, dist));

        public static IntPtr TdwithinTcbufferCbuffer(IntPtr temp, IntPtr cb, double dist)
            => SafeExecution<IntPtr>(() => Native.TdwithinTcbufferCbuffer(temp, cb, dist));

        public static IntPtr TdwithinTcbufferTcbuffer(IntPtr temp1, IntPtr temp2, double dist)
            => SafeExecution<IntPtr>(() => Native.TdwithinTcbufferTcbuffer(temp1, temp2, dist));

        public static IntPtr TdisjointCbufferTcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TdisjointCbufferTcbuffer(cb, temp));

        public static IntPtr TdisjointGeoTcbuffer(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TdisjointGeoTcbuffer(gs, temp));

        public static IntPtr TdisjointTcbufferGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TdisjointTcbufferGeo(temp, gs));

        public static IntPtr TdisjointTcbufferCbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<IntPtr>(() => Native.TdisjointTcbufferCbuffer(temp, cb));

        public static IntPtr TdisjointTcbufferTcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TdisjointTcbufferTcbuffer(temp1, temp2));

        public static IntPtr TintersectsCbufferTcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TintersectsCbufferTcbuffer(cb, temp));

        public static IntPtr TintersectsGeoTcbuffer(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TintersectsGeoTcbuffer(gs, temp));

        public static IntPtr TintersectsTcbufferGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TintersectsTcbufferGeo(temp, gs));

        public static IntPtr TintersectsTcbufferCbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<IntPtr>(() => Native.TintersectsTcbufferCbuffer(temp, cb));

        public static IntPtr TintersectsTcbufferTcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TintersectsTcbufferTcbuffer(temp1, temp2));

        public static IntPtr TtouchesGeoTcbuffer(IntPtr gs, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TtouchesGeoTcbuffer(gs, temp));

        public static IntPtr TtouchesTcbufferGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<IntPtr>(() => Native.TtouchesTcbufferGeo(temp, gs));

        public static IntPtr TtouchesCbufferTcbuffer(IntPtr cb, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TtouchesCbufferTcbuffer(cb, temp));

        public static IntPtr TtouchesTcbufferCbuffer(IntPtr temp, IntPtr cb)
            => SafeExecution<IntPtr>(() => Native.TtouchesTcbufferCbuffer(temp, cb));

        public static IntPtr TtouchesTcbufferTcbuffer(IntPtr temp1, IntPtr temp2)
            => SafeExecution<IntPtr>(() => Native.TtouchesTcbufferTcbuffer(temp1, temp2));

    }
}
