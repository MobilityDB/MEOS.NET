#nullable enable

using System.Runtime.InteropServices;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>pc_api.h</c> declares.</summary>
    public static partial class Meos
    {
        public static IntPtr Pcalloc(ulong size)
            => SafeExecution<IntPtr>(() => Native.Pcalloc(size));

        public static IntPtr Pcrealloc(IntPtr mem, ulong size)
            => SafeExecution<IntPtr>(() => Native.Pcrealloc(mem, size));

        public static void Pcfree(IntPtr mem)
            => SafeExecution(() => Native.Pcfree(mem));

        public static void Pcerror(string fmt)
            => SafeExecution(() => Native.Pcerror(fmt));

        public static void Pcinfo(string fmt)
            => SafeExecution(() => Native.Pcinfo(fmt));

        public static void Pcwarn(string fmt)
            => SafeExecution(() => Native.Pcwarn(fmt));

        public static void PcSetHandlers(IntPtr allocator, IntPtr reallocator, IntPtr deallocator, IntPtr error_handler, IntPtr info_handler, IntPtr warning_handler)
            => SafeExecution(() => Native.PcSetHandlers(allocator, reallocator, deallocator, error_handler, info_handler, warning_handler));

        public static void PcInstallDefaultHandlers()
            => SafeExecution(() => Native.PcInstallDefaultHandlers());

        public static IntPtr PcBytesFromHexbytes(string hexbuf, ulong hexsize)
            => SafeExecution<IntPtr>(() => Native.PcBytesFromHexbytes(hexbuf, hexsize));

        public static string PcHexbytesFromBytes(IntPtr bytebuf, ulong bytesize)
            => SafeExecution<string>(() => Native.PcHexbytesFromBytes(bytebuf, bytesize));

        public static uint PcWkbGetPcid(IntPtr wkb)
            => SafeExecution<uint>(() => Native.PcWkbGetPcid(wkb));

        public static IntPtr PcDimstatsMake(IntPtr schema)
            => SafeExecution<IntPtr>(() => Native.PcDimstatsMake(schema));

        public static string? PcCompressionName(int num)
            => Marshal.PtrToStringUTF8(SafeExecution<IntPtr>(() => Native.PcCompressionName(num)));

        public static void PcSchemaFree(IntPtr pcs)
            => SafeExecution(() => Native.PcSchemaFree(pcs));

        public static IntPtr PcSchemaNew(uint ndims)
            => SafeExecution<IntPtr>(() => Native.PcSchemaNew(ndims));

        public static int PcInterpretationNumber(string str)
            => SafeExecution<int>(() => Native.PcInterpretationNumber(str));

        public static int PcCompressionNumber(string str)
            => SafeExecution<int>(() => Native.PcCompressionNumber(str));

        public static IntPtr PcSchemaFromXml(string xmlstr)
            => SafeExecution<IntPtr>(() => Native.PcSchemaFromXml(xmlstr));

        public static string PcSchemaToJson(IntPtr pcs)
            => SafeExecution<string>(() => Native.PcSchemaToJson(pcs));

        public static IntPtr PcSchemaGetDimension(IntPtr s, uint dim)
            => SafeExecution<IntPtr>(() => Native.PcSchemaGetDimension(s, dim));

        public static IntPtr PcSchemaGetDimensionByName(IntPtr s, string name)
            => SafeExecution<IntPtr>(() => Native.PcSchemaGetDimensionByName(s, name));

        public static uint PcSchemaIsValid(IntPtr s)
            => SafeExecution<uint>(() => Native.PcSchemaIsValid(s));

        public static IntPtr PcSchemaClone(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.PcSchemaClone(s));

        public static void PcSchemaSetDimension(IntPtr s, IntPtr d)
            => SafeExecution(() => Native.PcSchemaSetDimension(s, d));

        public static void PcSchemaCheckXyzm(IntPtr s)
            => SafeExecution(() => Native.PcSchemaCheckXyzm(s));

        public static ulong PcSchemaGetSize(IntPtr s)
            => SafeExecution<ulong>(() => Native.PcSchemaGetSize(s));

        public static uint PcSchemaSameDimensions(IntPtr s1, IntPtr s2)
            => SafeExecution<uint>(() => Native.PcSchemaSameDimensions(s1, s2));

        public static uint PcSchemaSameInterpretations(IntPtr s1, IntPtr s2)
            => SafeExecution<uint>(() => Native.PcSchemaSameInterpretations(s1, s2));

        public static IntPtr PcPointlistMake(uint npoints)
            => SafeExecution<IntPtr>(() => Native.PcPointlistMake(npoints));

        public static void PcPointlistFree(IntPtr pl)
            => SafeExecution(() => Native.PcPointlistFree(pl));

        public static void PcPointlistAddPoint(IntPtr pl, IntPtr pt)
            => SafeExecution(() => Native.PcPointlistAddPoint(pl, pt));

        public static IntPtr PcPointlistGetPoint(IntPtr pl, int i)
            => SafeExecution<IntPtr>(() => Native.PcPointlistGetPoint(pl, i));

        public static IntPtr PcPointMake(IntPtr s)
            => SafeExecution<IntPtr>(() => Native.PcPointMake(s));

        public static IntPtr PcPointFromData(IntPtr s, IntPtr data)
            => SafeExecution<IntPtr>(() => Native.PcPointFromData(s, data));

        public static IntPtr PcPointFromDoubleArray(IntPtr s, IntPtr array, uint offset, uint stride)
            => SafeExecution<IntPtr>(() => Native.PcPointFromDoubleArray(s, array, offset, stride));

        public static IntPtr PcPointToDoubleArray(IntPtr pt)
            => SafeExecution<IntPtr>(() => Native.PcPointToDoubleArray(pt));

        public static void PcPointFree(IntPtr pt)
            => SafeExecution(() => Native.PcPointFree(pt));

        public static int PcPointGetDoubleByName(IntPtr pt, string name, IntPtr val)
            => SafeExecution<int>(() => Native.PcPointGetDoubleByName(pt, name, val));

        public static int PcPointGetDoubleByIndex(IntPtr pt, uint idx, IntPtr val)
            => SafeExecution<int>(() => Native.PcPointGetDoubleByIndex(pt, idx, val));

        public static int PcPointGetDouble(IntPtr pt, IntPtr dim, IntPtr val)
            => SafeExecution<int>(() => Native.PcPointGetDouble(pt, dim, val));

        public static int PcPointSetDoubleByName(IntPtr pt, string name, double val)
            => SafeExecution<int>(() => Native.PcPointSetDoubleByName(pt, name, val));

        public static int PcPointSetDoubleByIndex(IntPtr pt, uint idx, double val)
            => SafeExecution<int>(() => Native.PcPointSetDoubleByIndex(pt, idx, val));

        public static int PcPointSetDouble(IntPtr pt, IntPtr dim, double val)
            => SafeExecution<int>(() => Native.PcPointSetDouble(pt, dim, val));

        public static int PcPointGetX(IntPtr pt, IntPtr val)
            => SafeExecution<int>(() => Native.PcPointGetX(pt, val));

        public static int PcPointGetY(IntPtr pt, IntPtr val)
            => SafeExecution<int>(() => Native.PcPointGetY(pt, val));

        public static int PcPointGetZ(IntPtr pt, IntPtr val)
            => SafeExecution<int>(() => Native.PcPointGetZ(pt, val));

        public static int PcPointGetM(IntPtr pt, IntPtr val)
            => SafeExecution<int>(() => Native.PcPointGetM(pt, val));

        public static int PcPointSetX(IntPtr pt, double val)
            => SafeExecution<int>(() => Native.PcPointSetX(pt, val));

        public static int PcPointSetY(IntPtr pt, double val)
            => SafeExecution<int>(() => Native.PcPointSetY(pt, val));

        public static int PcPointSetZ(IntPtr pt, double val)
            => SafeExecution<int>(() => Native.PcPointSetZ(pt, val));

        public static int PcPointSetM(IntPtr pt, double val)
            => SafeExecution<int>(() => Native.PcPointSetM(pt, val));

        public static IntPtr PcPointFromWkb(IntPtr s, IntPtr wkb, ulong wkbsize)
            => SafeExecution<IntPtr>(() => Native.PcPointFromWkb(s, wkb, wkbsize));

        public static IntPtr PcPointToWkb(IntPtr pt, IntPtr wkbsize)
            => SafeExecution<IntPtr>(() => Native.PcPointToWkb(pt, wkbsize));

        public static string PcPointToString(IntPtr pt)
            => SafeExecution<string>(() => Native.PcPointToString(pt));

        public static IntPtr PcPointToGeometryWkb(IntPtr pt, IntPtr wkbsize)
            => SafeExecution<IntPtr>(() => Native.PcPointToGeometryWkb(pt, wkbsize));

        public static IntPtr PcPatchFromPointlist(IntPtr ptl)
            => SafeExecution<IntPtr>(() => Native.PcPatchFromPointlist(ptl));

        public static IntPtr PcPointlistFromPatch(IntPtr patch)
            => SafeExecution<IntPtr>(() => Native.PcPointlistFromPatch(patch));

        public static IntPtr PcPatchFromPatchlist(IntPtr palist, int numpatches)
            => SafeExecution<IntPtr>(() => Native.PcPatchFromPatchlist(palist, numpatches));

        public static void PcPatchFree(IntPtr patch)
            => SafeExecution(() => Native.PcPatchFree(patch));

        public static IntPtr PcPatchCompress(IntPtr patch, IntPtr userdata)
            => SafeExecution<IntPtr>(() => Native.PcPatchCompress(patch, userdata));

        public static IntPtr PcPatchUncompress(IntPtr patch)
            => SafeExecution<IntPtr>(() => Native.PcPatchUncompress(patch));

        public static IntPtr PcPatchFromWkb(IntPtr s, IntPtr wkb, ulong wkbsize)
            => SafeExecution<IntPtr>(() => Native.PcPatchFromWkb(s, wkb, wkbsize));

        public static IntPtr PcPatchToWkb(IntPtr patch, IntPtr wkbsize)
            => SafeExecution<IntPtr>(() => Native.PcPatchToWkb(patch, wkbsize));

        public static string PcPatchToString(IntPtr patch)
            => SafeExecution<string>(() => Native.PcPatchToString(patch));

        public static ulong PcPatchDimensionalSerializedSize(IntPtr patch)
            => SafeExecution<ulong>(() => Native.PcPatchDimensionalSerializedSize(patch));

        public static ulong PcBytesSerializedSize(IntPtr pcb)
            => SafeExecution<ulong>(() => Native.PcBytesSerializedSize(pcb));

        public static int PcBytesSerialize(IntPtr pcb, IntPtr buf, IntPtr size)
            => SafeExecution<int>(() => Native.PcBytesSerialize(pcb, buf, size));

        public static int PcBytesDeserialize(IntPtr buf, IntPtr dim, IntPtr pcb, int @readonly, int flip_endian)
            => SafeExecution<int>(() => Native.PcBytesDeserialize(buf, dim, pcb, @readonly, flip_endian));

        public static IntPtr PcStatsNewFromData(IntPtr schema, IntPtr mindata, IntPtr maxdata, IntPtr avgdata)
            => SafeExecution<IntPtr>(() => Native.PcStatsNewFromData(schema, mindata, maxdata, avgdata));

        public static IntPtr PcStatsNew(IntPtr schema)
            => SafeExecution<IntPtr>(() => Native.PcStatsNew(schema));

        public static void PcStatsFree(IntPtr stats)
            => SafeExecution(() => Native.PcStatsFree(stats));

        public static ulong PcStatsSize(IntPtr schema)
            => SafeExecution<ulong>(() => Native.PcStatsSize(schema));

        public static int PcPatchComputeStats(IntPtr patch)
            => SafeExecution<int>(() => Native.PcPatchComputeStats(patch));

        public static int PcPatchComputeExtent(IntPtr patch)
            => SafeExecution<int>(() => Native.PcPatchComputeExtent(patch));

        public static int PcBoundsIntersects(IntPtr b1, IntPtr b2)
            => SafeExecution<int>(() => Native.PcBoundsIntersects(b1, b2));

        public static IntPtr PcBoundingDiagonalWkbFromBounds(IntPtr bounds, IntPtr schema, IntPtr wkbsize)
            => SafeExecution<IntPtr>(() => Native.PcBoundingDiagonalWkbFromBounds(bounds, schema, wkbsize));

        public static IntPtr PcBoundingDiagonalWkbFromStats(IntPtr stats, IntPtr wkbsize)
            => SafeExecution<IntPtr>(() => Native.PcBoundingDiagonalWkbFromStats(stats, wkbsize));

        public static IntPtr PcPatchFilterLtByName(IntPtr pa, string name, double val)
            => SafeExecution<IntPtr>(() => Native.PcPatchFilterLtByName(pa, name, val));

        public static IntPtr PcPatchFilterGtByName(IntPtr pa, string name, double val)
            => SafeExecution<IntPtr>(() => Native.PcPatchFilterGtByName(pa, name, val));

        public static IntPtr PcPatchFilterEqualByName(IntPtr pa, string name, double val)
            => SafeExecution<IntPtr>(() => Native.PcPatchFilterEqualByName(pa, name, val));

        public static IntPtr PcPatchFilterBetweenByName(IntPtr pa, string name, double val1, double val2)
            => SafeExecution<IntPtr>(() => Native.PcPatchFilterBetweenByName(pa, name, val1, val2));

        public static IntPtr PcPatchPointn(IntPtr patch, int n)
            => SafeExecution<IntPtr>(() => Native.PcPatchPointn(patch, n));

        public static IntPtr PcPatchSort(IntPtr pa, IntPtr name, int ndims)
            => SafeExecution<IntPtr>(() => Native.PcPatchSort(pa, name, ndims));

        public static uint PcPatchIsSorted(IntPtr pa, IntPtr name, int ndims, byte strict)
            => SafeExecution<uint>(() => Native.PcPatchIsSorted(pa, name, ndims, strict));

        public static IntPtr PcPatchRange(IntPtr pa, int first, int count)
            => SafeExecution<IntPtr>(() => Native.PcPatchRange(pa, first, count));

        public static IntPtr PcPatchSetSchema(IntPtr patch, IntPtr schema, double def)
            => SafeExecution<IntPtr>(() => Native.PcPatchSetSchema(patch, schema, def));

        public static IntPtr PcPatchTransform(IntPtr patch, IntPtr schema, double def)
            => SafeExecution<IntPtr>(() => Native.PcPatchTransform(patch, schema, def));

    }
}
