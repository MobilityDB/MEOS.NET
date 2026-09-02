#nullable enable

using System.Runtime.InteropServices;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>meos_pointcloud.h</c> declares.</summary>
    public static partial class Meos
    {
        public static IntPtr PcpointHexIn(string str)
            => SafeExecution<IntPtr>(() => Native.PcpointHexIn(str));

        public static string PcpointHexOut(IntPtr pt, int maxdd)
            => SafeExecution<string>(() => Native.PcpointHexOut(pt, maxdd));

        public static IntPtr PcpointFromHexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => Native.PcpointFromHexwkb(hexwkb));

        public static string PcpointAsHexwkb(IntPtr pt)
            => SafeExecution<string>(() => Native.PcpointAsHexwkb(pt));

        public static IntPtr PcpointMake(uint pcid, IntPtr values, int count)
            => SafeExecution<IntPtr>(() => Native.PcpointMake(pcid, values, count));

        public static IntPtr PcpointCopy(IntPtr pt)
            => SafeExecution<IntPtr>(() => Native.PcpointCopy(pt));

        public static uint PcpointGetPcid(IntPtr pt)
            => SafeExecution<uint>(() => Native.PcpointGetPcid(pt));

        public static uint PcpointHash(IntPtr pt)
            => SafeExecution<uint>(() => Native.PcpointHash(pt));

        public static ulong PcpointHashExtended(IntPtr pt, ulong seed)
            => SafeExecution<ulong>(() => Native.PcpointHashExtended(pt, seed));

        public static bool PcpointGetX(IntPtr pt, IntPtr schema, IntPtr @out)
            => SafeExecution<bool>(() => Native.PcpointGetX(pt, schema, @out));

        public static bool PcpointGetY(IntPtr pt, IntPtr schema, IntPtr @out)
            => SafeExecution<bool>(() => Native.PcpointGetY(pt, schema, @out));

        public static bool PcpointGetZ(IntPtr pt, IntPtr schema, IntPtr @out)
            => SafeExecution<bool>(() => Native.PcpointGetZ(pt, schema, @out));

        public static bool PcpointGetDim(IntPtr pt, IntPtr schema, string name, IntPtr @out)
            => SafeExecution<bool>(() => Native.PcpointGetDim(pt, schema, name, @out));

        public static IntPtr PcpointToTpcbox(IntPtr pt, IntPtr schema)
            => SafeExecution<IntPtr>(() => Native.PcpointToTpcbox(pt, schema));

        public static IntPtr MeosPcSchema(uint pcid)
            => SafeExecution<IntPtr>(() => Native.MeosPcSchema(pcid));

        public static void MeosPcSchemaRegister(uint pcid, IntPtr schema)
            => SafeExecution(() => Native.MeosPcSchemaRegister(pcid, schema));

        public static IntPtr MeosPcSchemaFromDims(uint pcid, int srid, string compression, IntPtr dims, int ndims)
            => SafeExecution<IntPtr>(() => Native.MeosPcSchemaFromDims(pcid, srid, compression, dims, ndims));

        public static bool MeosPcSchemaRegisterDims(uint pcid, int srid, string compression, IntPtr dims, int ndims)
            => SafeExecution<bool>(() => Native.MeosPcSchemaRegisterDims(pcid, srid, compression, dims, ndims));

        public static void MeosPcSchemaRegisterXml(uint pcid, IntPtr schema, string xml_text)
            => SafeExecution(() => Native.MeosPcSchemaRegisterXml(pcid, schema, xml_text));

        public static string? MeosPcSchemaXml(uint pcid)
            => Marshal.PtrToStringUTF8(SafeExecution<IntPtr>(() => Native.MeosPcSchemaXml(pcid)));

        public static void MeosPcSchemaClear()
            => SafeExecution(() => Native.MeosPcSchemaClear());

        public static int MeosPcSchemaSrid(uint pcid)
            => SafeExecution<int>(() => Native.MeosPcSchemaSrid(pcid));

        public static string? MeosPcSchemaCompression(uint pcid)
            => Marshal.PtrToStringUTF8(SafeExecution<IntPtr>(() => Native.MeosPcSchemaCompression(pcid)));

        public static int MeosPcSchemaNdims(uint pcid)
            => SafeExecution<int>(() => Native.MeosPcSchemaNdims(pcid));

        public static void MeosSetPointcloudSchemasXml(string path)
            => SafeExecution(() => Native.MeosSetPointcloudSchemasXml(path));

        public static int PcpointCmp(IntPtr pt1, IntPtr pt2)
            => SafeExecution<int>(() => Native.PcpointCmp(pt1, pt2));

        public static bool PcpointEq(IntPtr pt1, IntPtr pt2)
            => SafeExecution<bool>(() => Native.PcpointEq(pt1, pt2));

        public static bool PcpointNe(IntPtr pt1, IntPtr pt2)
            => SafeExecution<bool>(() => Native.PcpointNe(pt1, pt2));

        public static bool PcpointLt(IntPtr pt1, IntPtr pt2)
            => SafeExecution<bool>(() => Native.PcpointLt(pt1, pt2));

        public static bool PcpointLe(IntPtr pt1, IntPtr pt2)
            => SafeExecution<bool>(() => Native.PcpointLe(pt1, pt2));

        public static bool PcpointGt(IntPtr pt1, IntPtr pt2)
            => SafeExecution<bool>(() => Native.PcpointGt(pt1, pt2));

        public static bool PcpointGe(IntPtr pt1, IntPtr pt2)
            => SafeExecution<bool>(() => Native.PcpointGe(pt1, pt2));

        public static IntPtr PcpatchHexIn(string str)
            => SafeExecution<IntPtr>(() => Native.PcpatchHexIn(str));

        public static string PcpatchHexOut(IntPtr pa, int maxdd)
            => SafeExecution<string>(() => Native.PcpatchHexOut(pa, maxdd));

        public static IntPtr PcpatchFromHexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => Native.PcpatchFromHexwkb(hexwkb));

        public static string PcpatchAsHexwkb(IntPtr pa)
            => SafeExecution<string>(() => Native.PcpatchAsHexwkb(pa));

        public static IntPtr PcpatchMake(IntPtr points, int count)
            => SafeExecution<IntPtr>(() => Native.PcpatchMake(points, count));

        public static IntPtr PcpatchMakeCoords(uint pcid, IntPtr values, int count)
            => SafeExecution<IntPtr>(() => Native.PcpatchMakeCoords(pcid, values, count));

        public static IntPtr PcpatchCopy(IntPtr pa)
            => SafeExecution<IntPtr>(() => Native.PcpatchCopy(pa));

        public static uint PcpatchGetPcid(IntPtr pa)
            => SafeExecution<uint>(() => Native.PcpatchGetPcid(pa));

        public static uint PcpatchNpoints(IntPtr pa)
            => SafeExecution<uint>(() => Native.PcpatchNpoints(pa));

        public static uint PcpatchHash(IntPtr pa)
            => SafeExecution<uint>(() => Native.PcpatchHash(pa));

        public static ulong PcpatchHashExtended(IntPtr pa, ulong seed)
            => SafeExecution<ulong>(() => Native.PcpatchHashExtended(pa, seed));

        public static IntPtr PcpatchToGeom(IntPtr pa)
            => SafeExecution<IntPtr>(() => Native.PcpatchToGeom(pa));

        public static int PcpatchCmp(IntPtr pa1, IntPtr pa2)
            => SafeExecution<int>(() => Native.PcpatchCmp(pa1, pa2));

        public static bool PcpatchEq(IntPtr pa1, IntPtr pa2)
            => SafeExecution<bool>(() => Native.PcpatchEq(pa1, pa2));

        public static bool PcpatchNe(IntPtr pa1, IntPtr pa2)
            => SafeExecution<bool>(() => Native.PcpatchNe(pa1, pa2));

        public static bool PcpatchLt(IntPtr pa1, IntPtr pa2)
            => SafeExecution<bool>(() => Native.PcpatchLt(pa1, pa2));

        public static bool PcpatchLe(IntPtr pa1, IntPtr pa2)
            => SafeExecution<bool>(() => Native.PcpatchLe(pa1, pa2));

        public static bool PcpatchGt(IntPtr pa1, IntPtr pa2)
            => SafeExecution<bool>(() => Native.PcpatchGt(pa1, pa2));

        public static bool PcpatchGe(IntPtr pa1, IntPtr pa2)
            => SafeExecution<bool>(() => Native.PcpatchGe(pa1, pa2));

        public static IntPtr PcpointsetIn(string str)
            => SafeExecution<IntPtr>(() => Native.PcpointsetIn(str));

        public static string PcpointsetOut(IntPtr s, int maxdd)
            => SafeExecution<string>(() => Native.PcpointsetOut(s, maxdd));

        public static IntPtr PcpointsetMake(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => Native.PcpointsetMake(values, count));

        public static IntPtr PcpointToSet(IntPtr pt)
            => SafeExecution<IntPtr>(() => Native.PcpointToSet(pt));

        public static IntPtr PcpointsetStartValue(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.PcpointsetStartValue(s));

        public static IntPtr PcpointsetEndValue(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.PcpointsetEndValue(s));

        public static bool PcpointsetValueN(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.PcpointsetValueN(s, n, result));

        public static IntPtr[] PcpointsetValues(IntPtr s)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.PcpointsetValues(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool ContainsSetPcpoint(IntPtr s, IntPtr pt)
            => SafeExecution<bool>(() => Native.ContainsSetPcpoint(s, pt));

        public static bool ContainedPcpointSet(IntPtr pt, IntPtr s)
            => SafeExecution<bool>(() => Native.ContainedPcpointSet(pt, s));

        public static IntPtr IntersectionPcpointSet(IntPtr pt, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.IntersectionPcpointSet(pt, s));

        public static IntPtr IntersectionSetPcpoint(IntPtr s, IntPtr pt)
            => SafeExecution<IntPtr>(() => Native.IntersectionSetPcpoint(s, pt));

        public static IntPtr MinusPcpointSet(IntPtr pt, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.MinusPcpointSet(pt, s));

        public static IntPtr MinusSetPcpoint(IntPtr s, IntPtr pt)
            => SafeExecution<IntPtr>(() => Native.MinusSetPcpoint(s, pt));

        public static IntPtr UnionPcpointSet(IntPtr pt, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.UnionPcpointSet(pt, s));

        public static IntPtr UnionSetPcpoint(IntPtr s, IntPtr pt)
            => SafeExecution<IntPtr>(() => Native.UnionSetPcpoint(s, pt));

        public static IntPtr PcpointUnionTransfn(IntPtr state, IntPtr pt)
            => SafeExecution<IntPtr>(() => Native.PcpointUnionTransfn(state, pt));

        public static IntPtr PcpatchsetIn(string str)
            => SafeExecution<IntPtr>(() => Native.PcpatchsetIn(str));

        public static string PcpatchsetOut(IntPtr s, int maxdd)
            => SafeExecution<string>(() => Native.PcpatchsetOut(s, maxdd));

        public static IntPtr PcpatchsetMake(IntPtr values, int count)
            => SafeExecution<IntPtr>(() => Native.PcpatchsetMake(values, count));

        public static IntPtr PcpatchToSet(IntPtr pa)
            => SafeExecution<IntPtr>(() => Native.PcpatchToSet(pa));

        public static IntPtr PcpatchsetStartValue(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.PcpatchsetStartValue(s));

        public static IntPtr PcpatchsetEndValue(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.PcpatchsetEndValue(s));

        public static bool PcpatchsetValueN(IntPtr s, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.PcpatchsetValueN(s, n, result));

        public static IntPtr[] PcpatchsetValues(IntPtr s)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.PcpatchsetValues(s, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool ContainsSetPcpatch(IntPtr s, IntPtr pa)
            => SafeExecution<bool>(() => Native.ContainsSetPcpatch(s, pa));

        public static bool ContainedPcpatchSet(IntPtr pa, IntPtr s)
            => SafeExecution<bool>(() => Native.ContainedPcpatchSet(pa, s));

        public static IntPtr IntersectionPcpatchSet(IntPtr pa, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.IntersectionPcpatchSet(pa, s));

        public static IntPtr IntersectionSetPcpatch(IntPtr s, IntPtr pa)
            => SafeExecution<IntPtr>(() => Native.IntersectionSetPcpatch(s, pa));

        public static IntPtr MinusPcpatchSet(IntPtr pa, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.MinusPcpatchSet(pa, s));

        public static IntPtr MinusSetPcpatch(IntPtr s, IntPtr pa)
            => SafeExecution<IntPtr>(() => Native.MinusSetPcpatch(s, pa));

        public static IntPtr UnionPcpatchSet(IntPtr pa, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.UnionPcpatchSet(pa, s));

        public static IntPtr UnionSetPcpatch(IntPtr s, IntPtr pa)
            => SafeExecution<IntPtr>(() => Native.UnionSetPcpatch(s, pa));

        public static IntPtr PcpatchUnionTransfn(IntPtr state, IntPtr pa)
            => SafeExecution<IntPtr>(() => Native.PcpatchUnionTransfn(state, pa));

        public static IntPtr TpcboxIn(string str)
            => SafeExecution<IntPtr>(() => Native.TpcboxIn(str));

        public static string TpcboxOut(IntPtr box, int maxdd)
            => SafeExecution<string>(() => Native.TpcboxOut(box, maxdd));

        public static IntPtr TpcboxMake(bool hasx, bool hasz, bool hast, bool geodetic, int srid, uint pcid, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, IntPtr period)
            => SafeExecution<IntPtr>(() => Native.TpcboxMake(hasx, hasz, hast, geodetic, srid, pcid, xmin, xmax, ymin, ymax, zmin, zmax, period));

        public static IntPtr TpcboxCopy(IntPtr box)
            => SafeExecution<IntPtr>(() => Native.TpcboxCopy(box));

        public static IntPtr PcpatchToTpcbox(IntPtr pa, int srid)
            => SafeExecution<IntPtr>(() => Native.PcpatchToTpcbox(pa, srid));

        public static bool TpcboxHasx(IntPtr box)
            => SafeExecution<bool>(() => Native.TpcboxHasx(box));

        public static bool TpcboxHasz(IntPtr box)
            => SafeExecution<bool>(() => Native.TpcboxHasz(box));

        public static bool TpcboxHast(IntPtr box)
            => SafeExecution<bool>(() => Native.TpcboxHast(box));

        public static bool TpcboxGeodetic(IntPtr box)
            => SafeExecution<bool>(() => Native.TpcboxGeodetic(box));

        public static bool TpcboxXmin(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.TpcboxXmin(box, result));

        public static bool TpcboxXmax(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.TpcboxXmax(box, result));

        public static bool TpcboxYmin(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.TpcboxYmin(box, result));

        public static bool TpcboxYmax(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.TpcboxYmax(box, result));

        public static bool TpcboxZmin(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.TpcboxZmin(box, result));

        public static bool TpcboxZmax(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.TpcboxZmax(box, result));

        public static bool TpcboxTmin(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.TpcboxTmin(box, result));

        public static bool TpcboxTminInc(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.TpcboxTminInc(box, result));

        public static bool TpcboxTmax(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.TpcboxTmax(box, result));

        public static bool TpcboxTmaxInc(IntPtr box, IntPtr result)
            => SafeExecution<bool>(() => Native.TpcboxTmaxInc(box, result));

        public static int TpcboxSrid(IntPtr box)
            => SafeExecution<int>(() => Native.TpcboxSrid(box));

        public static uint TpcboxPcid(IntPtr box)
            => SafeExecution<uint>(() => Native.TpcboxPcid(box));

        public static IntPtr TpcboxToStbox(IntPtr box)
            => SafeExecution<IntPtr>(() => Native.TpcboxToStbox(box));

        public static IntPtr TpcboxRound(IntPtr box, int maxdd)
            => SafeExecution<IntPtr>(() => Native.TpcboxRound(box, maxdd));

        public static IntPtr TpcboxSetSrid(IntPtr box, int srid)
            => SafeExecution<IntPtr>(() => Native.TpcboxSetSrid(box, srid));

        public static IntPtr UnionTpcboxTpcbox(IntPtr box1, IntPtr box2, bool strict)
            => SafeExecution<IntPtr>(() => Native.UnionTpcboxTpcbox(box1, box2, strict));

        public static bool InterTpcboxTpcbox(IntPtr box1, IntPtr box2, IntPtr result)
            => SafeExecution<bool>(() => Native.InterTpcboxTpcbox(box1, box2, result));

        public static IntPtr IntersectionTpcboxTpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<IntPtr>(() => Native.IntersectionTpcboxTpcbox(box1, box2));

        public static bool ContainsTpcboxTpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.ContainsTpcboxTpcbox(box1, box2));

        public static bool ContainedTpcboxTpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.ContainedTpcboxTpcbox(box1, box2));

        public static bool OverlapsTpcboxTpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.OverlapsTpcboxTpcbox(box1, box2));

        public static bool SameTpcboxTpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.SameTpcboxTpcbox(box1, box2));

        public static bool AdjacentTpcboxTpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.AdjacentTpcboxTpcbox(box1, box2));

        public static int TpcboxCmp(IntPtr box1, IntPtr box2)
            => SafeExecution<int>(() => Native.TpcboxCmp(box1, box2));

        public static bool TpcboxEq(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.TpcboxEq(box1, box2));

        public static bool TpcboxNe(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.TpcboxNe(box1, box2));

        public static bool TpcboxLt(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.TpcboxLt(box1, box2));

        public static bool TpcboxLe(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.TpcboxLe(box1, box2));

        public static bool TpcboxGt(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.TpcboxGt(box1, box2));

        public static bool TpcboxGe(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.TpcboxGe(box1, box2));

        public static bool LeftTpcboxTpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.LeftTpcboxTpcbox(box1, box2));

        public static bool OverleftTpcboxTpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.OverleftTpcboxTpcbox(box1, box2));

        public static bool RightTpcboxTpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.RightTpcboxTpcbox(box1, box2));

        public static bool OverrightTpcboxTpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.OverrightTpcboxTpcbox(box1, box2));

        public static bool BelowTpcboxTpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.BelowTpcboxTpcbox(box1, box2));

        public static bool OverbelowTpcboxTpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.OverbelowTpcboxTpcbox(box1, box2));

        public static bool AboveTpcboxTpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.AboveTpcboxTpcbox(box1, box2));

        public static bool OveraboveTpcboxTpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.OveraboveTpcboxTpcbox(box1, box2));

        public static bool FrontTpcboxTpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.FrontTpcboxTpcbox(box1, box2));

        public static bool OverfrontTpcboxTpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.OverfrontTpcboxTpcbox(box1, box2));

        public static bool BackTpcboxTpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.BackTpcboxTpcbox(box1, box2));

        public static bool OverbackTpcboxTpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.OverbackTpcboxTpcbox(box1, box2));

        public static bool BeforeTpcboxTpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.BeforeTpcboxTpcbox(box1, box2));

        public static bool OverbeforeTpcboxTpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.OverbeforeTpcboxTpcbox(box1, box2));

        public static bool AfterTpcboxTpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.AfterTpcboxTpcbox(box1, box2));

        public static bool OverafterTpcboxTpcbox(IntPtr box1, IntPtr box2)
            => SafeExecution<bool>(() => Native.OverafterTpcboxTpcbox(box1, box2));

        public static IntPtr TpointcloudToTgeompoint(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TpointcloudToTgeompoint(temp));

        public static IntPtr TpcpatchToTgeometry(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TpcpatchToTgeometry(temp));

        public static IntPtr TpcpointinstMake(IntPtr pt, long t)
            => SafeExecution<IntPtr>(() => Native.TpcpointinstMake(pt, t));

        public static IntPtr TpcpointseqFromBaseTstzset(IntPtr pt, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TpcpointseqFromBaseTstzset(pt, s));

        public static IntPtr TpcpointseqFromBaseTstzspan(IntPtr pt, IntPtr sp)
            => SafeExecution<IntPtr>(() => Native.TpcpointseqFromBaseTstzspan(pt, sp));

        public static IntPtr TpcpointseqsetFromBaseTstzspanset(IntPtr pt, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TpcpointseqsetFromBaseTstzspanset(pt, ss));

        public static IntPtr TpcpointFromBaseTemp(IntPtr pt, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TpcpointFromBaseTemp(pt, temp));

        public static IntPtr TpcpointStartValue(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TpcpointStartValue(temp));

        public static IntPtr TpcpointEndValue(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TpcpointEndValue(temp));

        public static bool TpcpointValueN(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.TpcpointValueN(temp, n, result));

        public static IntPtr[] TpcpointValues(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TpcpointValues(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool TpcpointValueAtTimestamptz(IntPtr temp, long t, bool strict, IntPtr value)
            => SafeExecution<bool>(() => Native.TpcpointValueAtTimestamptz(temp, t, strict, value));

        public static IntPtr TpcpointAtValue(IntPtr temp, IntPtr pt)
            => SafeExecution<IntPtr>(() => Native.TpcpointAtValue(temp, pt));

        public static IntPtr TpcpointMinusValue(IntPtr temp, IntPtr pt)
            => SafeExecution<IntPtr>(() => Native.TpcpointMinusValue(temp, pt));

        public static IntPtr TpcpatchinstMake(IntPtr pa, long t)
            => SafeExecution<IntPtr>(() => Native.TpcpatchinstMake(pa, t));

        public static IntPtr TpcpatchseqFromBaseTstzset(IntPtr pa, IntPtr s)
            => SafeExecution<IntPtr>(() => Native.TpcpatchseqFromBaseTstzset(pa, s));

        public static IntPtr TpcpatchseqFromBaseTstzspan(IntPtr pa, IntPtr sp)
            => SafeExecution<IntPtr>(() => Native.TpcpatchseqFromBaseTstzspan(pa, sp));

        public static IntPtr TpcpatchseqsetFromBaseTstzspanset(IntPtr pa, IntPtr ss)
            => SafeExecution<IntPtr>(() => Native.TpcpatchseqsetFromBaseTstzspanset(pa, ss));

        public static IntPtr TpcpatchFromBaseTemp(IntPtr pa, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TpcpatchFromBaseTemp(pa, temp));

        public static IntPtr TpcpatchStartValue(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TpcpatchStartValue(temp));

        public static IntPtr TpcpatchEndValue(IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TpcpatchEndValue(temp));

        public static bool TpcpatchValueN(IntPtr temp, int n, IntPtr result)
            => SafeExecution<bool>(() => Native.TpcpatchValueN(temp, n, result));

        public static IntPtr[] TpcpatchValues(IntPtr temp)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TpcpatchValues(temp, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static bool TpcpatchValueAtTimestamptz(IntPtr temp, long t, bool strict, IntPtr value)
            => SafeExecution<bool>(() => Native.TpcpatchValueAtTimestamptz(temp, t, strict, value));

        public static IntPtr TpcpatchAtValue(IntPtr temp, IntPtr pa)
            => SafeExecution<IntPtr>(() => Native.TpcpatchAtValue(temp, pa));

        public static IntPtr TpcpatchMinusValue(IntPtr temp, IntPtr pa)
            => SafeExecution<IntPtr>(() => Native.TpcpatchMinusValue(temp, pa));

        public static int EverEqPcpointTpcpoint(IntPtr pt, IntPtr temp)
            => SafeExecution<int>(() => Native.EverEqPcpointTpcpoint(pt, temp));

        public static int EverEqTpcpointPcpoint(IntPtr temp, IntPtr pt)
            => SafeExecution<int>(() => Native.EverEqTpcpointPcpoint(temp, pt));

        public static int EverEqTpcpointTpcpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverEqTpcpointTpcpoint(temp1, temp2));

        public static int EverNePcpointTpcpoint(IntPtr pt, IntPtr temp)
            => SafeExecution<int>(() => Native.EverNePcpointTpcpoint(pt, temp));

        public static int EverNeTpcpointPcpoint(IntPtr temp, IntPtr pt)
            => SafeExecution<int>(() => Native.EverNeTpcpointPcpoint(temp, pt));

        public static int EverNeTpcpointTpcpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverNeTpcpointTpcpoint(temp1, temp2));

        public static int AlwaysEqPcpointTpcpoint(IntPtr pt, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysEqPcpointTpcpoint(pt, temp));

        public static int AlwaysEqTpcpointPcpoint(IntPtr temp, IntPtr pt)
            => SafeExecution<int>(() => Native.AlwaysEqTpcpointPcpoint(temp, pt));

        public static int AlwaysEqTpcpointTpcpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysEqTpcpointTpcpoint(temp1, temp2));

        public static int AlwaysNePcpointTpcpoint(IntPtr pt, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysNePcpointTpcpoint(pt, temp));

        public static int AlwaysNeTpcpointPcpoint(IntPtr temp, IntPtr pt)
            => SafeExecution<int>(() => Native.AlwaysNeTpcpointPcpoint(temp, pt));

        public static int AlwaysNeTpcpointTpcpoint(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysNeTpcpointTpcpoint(temp1, temp2));

        public static int EverEqPcpatchTpcpatch(IntPtr pa, IntPtr temp)
            => SafeExecution<int>(() => Native.EverEqPcpatchTpcpatch(pa, temp));

        public static int EverEqTpcpatchPcpatch(IntPtr temp, IntPtr pa)
            => SafeExecution<int>(() => Native.EverEqTpcpatchPcpatch(temp, pa));

        public static int EverEqTpcpatchTpcpatch(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverEqTpcpatchTpcpatch(temp1, temp2));

        public static int EverNePcpatchTpcpatch(IntPtr pa, IntPtr temp)
            => SafeExecution<int>(() => Native.EverNePcpatchTpcpatch(pa, temp));

        public static int EverNeTpcpatchPcpatch(IntPtr temp, IntPtr pa)
            => SafeExecution<int>(() => Native.EverNeTpcpatchPcpatch(temp, pa));

        public static int EverNeTpcpatchTpcpatch(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.EverNeTpcpatchTpcpatch(temp1, temp2));

        public static int AlwaysEqPcpatchTpcpatch(IntPtr pa, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysEqPcpatchTpcpatch(pa, temp));

        public static int AlwaysEqTpcpatchPcpatch(IntPtr temp, IntPtr pa)
            => SafeExecution<int>(() => Native.AlwaysEqTpcpatchPcpatch(temp, pa));

        public static int AlwaysEqTpcpatchTpcpatch(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysEqTpcpatchTpcpatch(temp1, temp2));

        public static int AlwaysNePcpatchTpcpatch(IntPtr pa, IntPtr temp)
            => SafeExecution<int>(() => Native.AlwaysNePcpatchTpcpatch(pa, temp));

        public static int AlwaysNeTpcpatchPcpatch(IntPtr temp, IntPtr pa)
            => SafeExecution<int>(() => Native.AlwaysNeTpcpatchPcpatch(temp, pa));

        public static int AlwaysNeTpcpatchTpcpatch(IntPtr temp1, IntPtr temp2)
            => SafeExecution<int>(() => Native.AlwaysNeTpcpatchTpcpatch(temp1, temp2));

        public static IntPtr TeqPcpointTpcpoint(IntPtr pt, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TeqPcpointTpcpoint(pt, temp));

        public static IntPtr TeqTpcpointPcpoint(IntPtr temp, IntPtr pt)
            => SafeExecution<IntPtr>(() => Native.TeqTpcpointPcpoint(temp, pt));

        public static IntPtr TnePcpointTpcpoint(IntPtr pt, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TnePcpointTpcpoint(pt, temp));

        public static IntPtr TneTpcpointPcpoint(IntPtr temp, IntPtr pt)
            => SafeExecution<IntPtr>(() => Native.TneTpcpointPcpoint(temp, pt));

        public static IntPtr TeqPcpatchTpcpatch(IntPtr pa, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TeqPcpatchTpcpatch(pa, temp));

        public static IntPtr TeqTpcpatchPcpatch(IntPtr temp, IntPtr pa)
            => SafeExecution<IntPtr>(() => Native.TeqTpcpatchPcpatch(temp, pa));

        public static IntPtr TnePcpatchTpcpatch(IntPtr pa, IntPtr temp)
            => SafeExecution<IntPtr>(() => Native.TnePcpatchTpcpatch(pa, temp));

        public static IntPtr TneTpcpatchPcpatch(IntPtr temp, IntPtr pa)
            => SafeExecution<IntPtr>(() => Native.TneTpcpatchPcpatch(temp, pa));

        public static bool AdjacentTpcboxTpointcloud(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.AdjacentTpcboxTpointcloud(box, temp));

        public static bool AdjacentTpointcloudTpcbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.AdjacentTpointcloudTpcbox(temp, box));

        public static bool AdjacentTpointcloudTpointcloud(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.AdjacentTpointcloudTpointcloud(temp1, temp2));

        public static bool ContainedTpcboxTpointcloud(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.ContainedTpcboxTpointcloud(box, temp));

        public static bool ContainedTpointcloudTpcbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.ContainedTpointcloudTpcbox(temp, box));

        public static bool ContainedTpointcloudTpointcloud(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.ContainedTpointcloudTpointcloud(temp1, temp2));

        public static bool ContainsTpcboxTpointcloud(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.ContainsTpcboxTpointcloud(box, temp));

        public static bool ContainsTpointcloudTpcbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.ContainsTpointcloudTpcbox(temp, box));

        public static bool ContainsTpointcloudTpointcloud(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.ContainsTpointcloudTpointcloud(temp1, temp2));

        public static bool OverlapsTpcboxTpointcloud(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.OverlapsTpcboxTpointcloud(box, temp));

        public static bool OverlapsTpointcloudTpcbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.OverlapsTpointcloudTpcbox(temp, box));

        public static bool OverlapsTpointcloudTpointcloud(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.OverlapsTpointcloudTpointcloud(temp1, temp2));

        public static bool SameTpcboxTpointcloud(IntPtr box, IntPtr temp)
            => SafeExecution<bool>(() => Native.SameTpcboxTpointcloud(box, temp));

        public static bool SameTpointcloudTpcbox(IntPtr temp, IntPtr box)
            => SafeExecution<bool>(() => Native.SameTpointcloudTpcbox(temp, box));

        public static bool SameTpointcloudTpointcloud(IntPtr temp1, IntPtr temp2)
            => SafeExecution<bool>(() => Native.SameTpointcloudTpointcloud(temp1, temp2));

        public static bool EintersectsTpcpointGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<bool>(() => Native.EintersectsTpcpointGeo(temp, gs));

        public static double NadTpcpointGeo(IntPtr temp, IntPtr gs)
            => SafeExecution<double>(() => Native.NadTpcpointGeo(temp, gs));

    }
}
