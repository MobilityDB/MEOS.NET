#nullable enable

using System.Runtime.InteropServices;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>meos_catalog.h</c> declares.</summary>
    public static partial class Meos
    {
        public static bool TemptypeSubtype(int subtype)
            => SafeExecution<bool>(() => Native.TemptypeSubtype(subtype));

        public static bool TemptypeSubtypeAll(int subtype)
            => SafeExecution<bool>(() => Native.TemptypeSubtypeAll(subtype));

        public static string? TempsubtypeName(int subtype)
            => Marshal.PtrToStringUTF8(SafeExecution<IntPtr>(() => Native.TempsubtypeName(subtype)));

        public static bool TempsubtypeFromString(string str, IntPtr subtype)
            => SafeExecution<bool>(() => Native.TempsubtypeFromString(str, subtype));

        public static string? MeosoperName(int oper)
            => Marshal.PtrToStringUTF8(SafeExecution<IntPtr>(() => Native.MeosoperName(oper)));

        public static int MeosoperFromString(string name)
            => SafeExecution<int>(() => Native.MeosoperFromString(name));

        public static string? InterptypeName(int interp)
            => Marshal.PtrToStringUTF8(SafeExecution<IntPtr>(() => Native.InterptypeName(interp)));

        public static int InterptypeFromString(string interp_str)
            => SafeExecution<int>(() => Native.InterptypeFromString(interp_str));

        public static int MeosTypeofHexwkb(string hexwkb)
            => SafeExecution<int>(() => Native.MeosTypeofHexwkb(hexwkb));

        public static string? MeostypeName(int type)
            => Marshal.PtrToStringUTF8(SafeExecution<IntPtr>(() => Native.MeostypeName(type)));

        public static int TemptypeBasetype(int type)
            => SafeExecution<int>(() => Native.TemptypeBasetype(type));

        public static int SettypeBasetype(int type)
            => SafeExecution<int>(() => Native.SettypeBasetype(type));

        public static int SpantypeBasetype(int type)
            => SafeExecution<int>(() => Native.SpantypeBasetype(type));

        public static int SpantypeSpansettype(int type)
            => SafeExecution<int>(() => Native.SpantypeSpansettype(type));

        public static int SpansettypeSpantype(int type)
            => SafeExecution<int>(() => Native.SpansettypeSpantype(type));

        public static int BasetypeSpantype(int type)
            => SafeExecution<int>(() => Native.BasetypeSpantype(type));

        public static int BasetypeSettype(int type)
            => SafeExecution<int>(() => Native.BasetypeSettype(type));

        public static bool TnumberBasetype(int type)
            => SafeExecution<bool>(() => Native.TnumberBasetype(type));

        public static bool GeoBasetype(int type)
            => SafeExecution<bool>(() => Native.GeoBasetype(type));

        public static bool MeosBasetype(int type)
            => SafeExecution<bool>(() => Native.MeosBasetype(type));

        public static bool AlphanumBasetype(int type)
            => SafeExecution<bool>(() => Native.AlphanumBasetype(type));

        public static bool AlphanumTemptype(int type)
            => SafeExecution<bool>(() => Native.AlphanumTemptype(type));

        public static bool TimeType(int type)
            => SafeExecution<bool>(() => Native.TimeType(type));

        public static bool SetBasetype(int type)
            => SafeExecution<bool>(() => Native.SetBasetype(type));

        public static bool SetType(int type)
            => SafeExecution<bool>(() => Native.SetType(type));

        public static bool NumsetType(int type)
            => SafeExecution<bool>(() => Native.NumsetType(type));

        public static bool EnsureNumsetType(int type)
            => SafeExecution<bool>(() => Native.EnsureNumsetType(type));

        public static bool TimesetType(int type)
            => SafeExecution<bool>(() => Native.TimesetType(type));

        public static bool SetSpantype(int type)
            => SafeExecution<bool>(() => Native.SetSpantype(type));

        public static bool EnsureSetSpantype(int type)
            => SafeExecution<bool>(() => Native.EnsureSetSpantype(type));

        public static bool AlphanumsetType(int settype)
            => SafeExecution<bool>(() => Native.AlphanumsetType(settype));

        public static bool GeosetType(int type)
            => SafeExecution<bool>(() => Native.GeosetType(type));

        public static bool EnsureGeosetType(int type)
            => SafeExecution<bool>(() => Native.EnsureGeosetType(type));

        public static bool SpatialsetType(int type)
            => SafeExecution<bool>(() => Native.SpatialsetType(type));

        public static bool EnsureSpatialsetType(int type)
            => SafeExecution<bool>(() => Native.EnsureSpatialsetType(type));

        public static bool PointcloudBasetype(int type)
            => SafeExecution<bool>(() => Native.PointcloudBasetype(type));

        public static bool PointcloudsetType(int type)
            => SafeExecution<bool>(() => Native.PointcloudsetType(type));

        public static bool TpointcloudTemptype(int type)
            => SafeExecution<bool>(() => Native.TpointcloudTemptype(type));

        public static bool EnsureTpointcloudTemptype(int type)
            => SafeExecution<bool>(() => Native.EnsureTpointcloudTemptype(type));

        public static bool SpanBasetype(int type)
            => SafeExecution<bool>(() => Native.SpanBasetype(type));

        public static bool SpanCanonBasetype(int type)
            => SafeExecution<bool>(() => Native.SpanCanonBasetype(type));

        public static bool SpanType(int type)
            => SafeExecution<bool>(() => Native.SpanType(type));

        public static bool TypeSpanBbox(int type)
            => SafeExecution<bool>(() => Native.TypeSpanBbox(type));

        public static int TypeBboxtype(int type)
            => SafeExecution<int>(() => Native.TypeBboxtype(type));

        public static bool SpanTboxType(int type)
            => SafeExecution<bool>(() => Native.SpanTboxType(type));

        public static bool EnsureSpanTboxType(int type)
            => SafeExecution<bool>(() => Native.EnsureSpanTboxType(type));

        public static bool NumspanBasetype(int type)
            => SafeExecution<bool>(() => Native.NumspanBasetype(type));

        public static bool NumspanType(int type)
            => SafeExecution<bool>(() => Native.NumspanType(type));

        public static bool EnsureNumspanType(int type)
            => SafeExecution<bool>(() => Native.EnsureNumspanType(type));

        public static bool TimespanBasetype(int type)
            => SafeExecution<bool>(() => Native.TimespanBasetype(type));

        public static bool TimespanType(int type)
            => SafeExecution<bool>(() => Native.TimespanType(type));

        public static bool SpansetType(int type)
            => SafeExecution<bool>(() => Native.SpansetType(type));

        public static bool TimespansetType(int type)
            => SafeExecution<bool>(() => Native.TimespansetType(type));

        public static bool EnsureTimespansetType(int type)
            => SafeExecution<bool>(() => Native.EnsureTimespansetType(type));

        public static bool TemporalType(int type)
            => SafeExecution<bool>(() => Native.TemporalType(type));

        public static bool TemporalBasetype(int type)
            => SafeExecution<bool>(() => Native.TemporalBasetype(type));

        public static bool TemptypeSupportsLinear(int type)
            => SafeExecution<bool>(() => Native.TemptypeSupportsLinear(type));

        public static bool BasetypeByvalue(int type)
            => SafeExecution<bool>(() => Native.BasetypeByvalue(type));

        public static bool BasetypeVarlength(int type)
            => SafeExecution<bool>(() => Native.BasetypeVarlength(type));

        public static short MeostypeLength(int type)
            => SafeExecution<short>(() => Native.MeostypeLength(type));

        public static bool TalphanumType(int type)
            => SafeExecution<bool>(() => Native.TalphanumType(type));

        public static bool TalphaType(int type)
            => SafeExecution<bool>(() => Native.TalphaType(type));

        public static bool TnumberType(int type)
            => SafeExecution<bool>(() => Native.TnumberType(type));

        public static bool EnsureTnumberType(int type)
            => SafeExecution<bool>(() => Native.EnsureTnumberType(type));

        public static bool TorderType(int type)
            => SafeExecution<bool>(() => Native.TorderType(type));

        public static bool EnsureTorderType(int type)
            => SafeExecution<bool>(() => Native.EnsureTorderType(type));

        public static bool EnsureTnumberBasetype(int type)
            => SafeExecution<bool>(() => Native.EnsureTnumberBasetype(type));

        public static bool TnumberSpantype(int type)
            => SafeExecution<bool>(() => Native.TnumberSpantype(type));

        public static bool SpatialBasetype(int type)
            => SafeExecution<bool>(() => Native.SpatialBasetype(type));

        public static bool TspatialType(int type)
            => SafeExecution<bool>(() => Native.TspatialType(type));

        public static bool EnsureTspatialType(int type)
            => SafeExecution<bool>(() => Native.EnsureTspatialType(type));

        public static bool TpointType(int type)
            => SafeExecution<bool>(() => Native.TpointType(type));

        public static bool EnsureTpointType(int type)
            => SafeExecution<bool>(() => Native.EnsureTpointType(type));

        public static bool TgeoType(int type)
            => SafeExecution<bool>(() => Native.TgeoType(type));

        public static bool EnsureTgeoType(int type)
            => SafeExecution<bool>(() => Native.EnsureTgeoType(type));

        public static bool TspatialBodyType(int type)
            => SafeExecution<bool>(() => Native.TspatialBodyType(type));

        public static bool TgeoTypeAll(int type)
            => SafeExecution<bool>(() => Native.TgeoTypeAll(type));

        public static bool EnsureTgeoTypeAll(int type)
            => SafeExecution<bool>(() => Native.EnsureTgeoTypeAll(type));

        public static bool TgeometryType(int type)
            => SafeExecution<bool>(() => Native.TgeometryType(type));

        public static bool EnsureTgeometryType(int type)
            => SafeExecution<bool>(() => Native.EnsureTgeometryType(type));

        public static bool TgeodeticType(int type)
            => SafeExecution<bool>(() => Native.TgeodeticType(type));

        public static bool EnsureTgeodeticType(int type)
            => SafeExecution<bool>(() => Native.EnsureTgeodeticType(type));

        public static bool EnsureTnumberTpointType(int type)
            => SafeExecution<bool>(() => Native.EnsureTnumberTpointType(type));

    }
}
