#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Structures;

namespace MEOS.NET.Functions
{
    /// <summary>The MEOS functions <c>meos_raster.h</c> declares.</summary>
    public static partial class Meos
    {
        public static ulong RaquetPixtypeSize(int pixtype)
            => SafeExecution<ulong>(() => Native.RaquetPixtypeSize(pixtype));

        public static int RaquetPixtypeFromString(string str)
            => SafeExecution<int>(() => Native.RaquetPixtypeFromString(str));

        public static IntPtr RaquetIn(string str)
            => SafeExecution<IntPtr>(() => Native.RaquetIn(str));

        public static string RaquetOut(IntPtr rq)
            => SafeExecution<string>(() => Native.RaquetOut(rq));

        public static IntPtr RaquetFromWkb(IntPtr wkb, ulong size)
            => SafeExecution<IntPtr>(() => Native.RaquetFromWkb(wkb, size));

        public static IntPtr RaquetFromHexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => Native.RaquetFromHexwkb(hexwkb));

        public static IntPtr RaquetAsWkb(IntPtr rq, byte variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => Native.RaquetAsWkb(rq, variant, size_out));

        public static string RaquetAsHexwkb(IntPtr rq, byte variant, IntPtr size_out)
            => SafeExecution<string>(() => Native.RaquetAsHexwkb(rq, variant, size_out));

        public static IntPtr RaquetMake(ulong quadbin, int width, int height, int pixtype, double nodata, bool has_nodata, IntPtr pixels, ulong pixels_size)
            => SafeExecution<IntPtr>(() => Native.RaquetMake(quadbin, width, height, pixtype, nodata, has_nodata, pixels, pixels_size));

        public static IntPtr RaquetCopy(IntPtr rq)
            => SafeExecution<IntPtr>(() => Native.RaquetCopy(rq));

        public static IntPtr RaquetRead(string path, ulong quadbin)
            => SafeExecution<IntPtr>(() => Native.RaquetRead(path, quadbin));

        public static IntPtr RaquetReadBytes(IntPtr data, ulong size, ulong quadbin)
            => SafeExecution<IntPtr>(() => Native.RaquetReadBytes(data, size, quadbin));

        public static ulong RaquetQuadbin(IntPtr rq)
            => SafeExecution<ulong>(() => Native.RaquetQuadbin(rq));

        public static int RaquetWidth(IntPtr rq)
            => SafeExecution<int>(() => Native.RaquetWidth(rq));

        public static int RaquetHeight(IntPtr rq)
            => SafeExecution<int>(() => Native.RaquetHeight(rq));

        public static string RaquetBandPixelType(IntPtr rq)
            => SafeExecution<string>(() => Native.RaquetBandPixelType(rq));

        public static bool RaquetBandHasNodataValue(IntPtr rq)
            => SafeExecution<bool>(() => Native.RaquetBandHasNodataValue(rq));

        public static bool RaquetBandNodataValue(IntPtr rq, IntPtr result)
            => SafeExecution<bool>(() => Native.RaquetBandNodataValue(rq, result));

        public static IntPtr RaquetPixels(IntPtr rq, IntPtr size_out)
            => SafeExecution<IntPtr>(() => Native.RaquetPixels(rq, size_out));

        public static uint RaquetHash(IntPtr rq)
            => SafeExecution<uint>(() => Native.RaquetHash(rq));

        public static ulong RaquetHashExtended(IntPtr rq, ulong seed)
            => SafeExecution<ulong>(() => Native.RaquetHashExtended(rq, seed));

        public static int RaquetMemSize(IntPtr rq)
            => SafeExecution<int>(() => Native.RaquetMemSize(rq));

        public static IntPtr RasterFromWkb(IntPtr wkb, ulong size)
            => SafeExecution<IntPtr>(() => Native.RasterFromWkb(wkb, size));

        public static IntPtr RasterFromHexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => Native.RasterFromHexwkb(hexwkb));

        public static IntPtr RasterAsWkb(IntPtr rast, byte variant, IntPtr size_out)
            => SafeExecution<IntPtr>(() => Native.RasterAsWkb(rast, variant, size_out));

        public static string RasterAsHexwkb(IntPtr rast, byte variant, IntPtr size_out)
            => SafeExecution<string>(() => Native.RasterAsHexwkb(rast, variant, size_out));

        public static IntPtr RasterCopy(IntPtr rast)
            => SafeExecution<IntPtr>(() => Native.RasterCopy(rast));

        public static IntPtr RasterMake(int width, int height, double upperleftx, double upperlefty, double scalex, double scaley, double skewx, double skewy, int srid, string pixeltype, double nodataval, bool has_nodata, IntPtr pixels, ulong size)
            => SafeExecution<IntPtr>(() => Native.RasterMake(width, height, upperleftx, upperlefty, scalex, scaley, skewx, skewy, srid, pixeltype, nodataval, has_nodata, pixels, size));

        public static IntPtr RasterMakeEmpty(int width, int height, double upperleftx, double upperlefty, double scalex, double scaley, double skewx, double skewy, int srid)
            => SafeExecution<IntPtr>(() => Native.RasterMakeEmpty(width, height, upperleftx, upperlefty, scalex, scaley, skewx, skewy, srid));

        public static IntPtr RasterAddBand(IntPtr rast, int index, string pixeltype, double initialvalue, double nodataval, bool has_nodata)
            => SafeExecution<IntPtr>(() => Native.RasterAddBand(rast, index, pixeltype, initialvalue, nodataval, has_nodata));

        public static IntPtr RasterAddBandRaster(IntPtr torast, IntPtr fromrast, int fromband, int toindex)
            => SafeExecution<IntPtr>(() => Native.RasterAddBandRaster(torast, fromrast, fromband, toindex));

        public static int RasterMemSize(IntPtr rast)
            => SafeExecution<int>(() => Native.RasterMemSize(rast));

        public static int RasterNumBands(IntPtr rast)
            => SafeExecution<int>(() => Native.RasterNumBands(rast));

        public static int RasterWidth(IntPtr rast)
            => SafeExecution<int>(() => Native.RasterWidth(rast));

        public static int RasterHeight(IntPtr rast)
            => SafeExecution<int>(() => Native.RasterHeight(rast));

        public static int RasterSrid(IntPtr rast)
            => SafeExecution<int>(() => Native.RasterSrid(rast));

        public static double RasterUpperLeftX(IntPtr rast)
            => SafeExecution<double>(() => Native.RasterUpperLeftX(rast));

        public static double RasterUpperLeftY(IntPtr rast)
            => SafeExecution<double>(() => Native.RasterUpperLeftY(rast));

        public static double RasterScaleX(IntPtr rast)
            => SafeExecution<double>(() => Native.RasterScaleX(rast));

        public static double RasterScaleY(IntPtr rast)
            => SafeExecution<double>(() => Native.RasterScaleY(rast));

        public static double RasterSkewX(IntPtr rast)
            => SafeExecution<double>(() => Native.RasterSkewX(rast));

        public static double RasterSkewY(IntPtr rast)
            => SafeExecution<double>(() => Native.RasterSkewY(rast));

        public static string RasterBandPixelType(IntPtr rast, int band)
            => SafeExecution<string>(() => Native.RasterBandPixelType(rast, band));

        public static bool RasterBandHasNodataValue(IntPtr rast, int band)
            => SafeExecution<bool>(() => Native.RasterBandHasNodataValue(rast, band));

        public static bool RasterBandNodataValue(IntPtr rast, int band, IntPtr result)
            => SafeExecution<bool>(() => Native.RasterBandNodataValue(rast, band, result));

        public static IntPtr RasterBandPixels(IntPtr rast, int band, IntPtr size_out)
            => SafeExecution<IntPtr>(() => Native.RasterBandPixels(rast, band, size_out));

        public static long BandstatsCount(IntPtr stats)
            => SafeExecution<long>(() => Native.BandstatsCount(stats));

        public static bool BandstatsSum(IntPtr stats, IntPtr result)
            => SafeExecution<bool>(() => Native.BandstatsSum(stats, result));

        public static bool BandstatsMean(IntPtr stats, IntPtr result)
            => SafeExecution<bool>(() => Native.BandstatsMean(stats, result));

        public static bool BandstatsStddev(IntPtr stats, IntPtr result)
            => SafeExecution<bool>(() => Native.BandstatsStddev(stats, result));

        public static bool BandstatsMin(IntPtr stats, IntPtr result)
            => SafeExecution<bool>(() => Native.BandstatsMin(stats, result));

        public static bool BandstatsMax(IntPtr stats, IntPtr result)
            => SafeExecution<bool>(() => Native.BandstatsMax(stats, result));

        public static IntPtr RasterClip(IntPtr rast, IntPtr bands, int nbands, IntPtr gs, IntPtr nodata, int nnodata, bool crop, bool touched)
            => SafeExecution<IntPtr>(() => Native.RasterClip(rast, bands, nbands, gs, nodata, nnodata, crop, touched));

        public static IntPtr RasterTransform(IntPtr rast, int srid, string algorithm, double max_err, double scale_x, double scale_y)
            => SafeExecution<IntPtr>(() => Native.RasterTransform(rast, srid, algorithm, max_err, scale_x, scale_y));

        public static IntPtr RasterTransformPipeline(IntPtr rast, string pipelinestr, int srid, bool is_forward, string algorithm, double max_err, double scale_x, double scale_y)
            => SafeExecution<IntPtr>(() => Native.RasterTransformPipeline(rast, pipelinestr, srid, is_forward, algorithm, max_err, scale_x, scale_y));

        public static IntPtr RasterTransformRaster(IntPtr rast, IntPtr alignto, string algorithm, double max_err)
            => SafeExecution<IntPtr>(() => Native.RasterTransformRaster(rast, alignto, algorithm, max_err));

        public static IntPtr RasterRescale(IntPtr rast, double scale_x, double scale_y, string algorithm, double max_err)
            => SafeExecution<IntPtr>(() => Native.RasterRescale(rast, scale_x, scale_y, algorithm, max_err));

        public static IntPtr[] RasterDumpAsPolygons(IntPtr rast, int band, bool exclude_nodata)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.RasterDumpAsPolygons(rast, band, exclude_nodata, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 16); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static (double[], bool[]) RasterDumpValues(IntPtr rast, int band, bool exclude_nodata)
        {
            IntPtr _out_nodata = Marshal.AllocHGlobal(IntPtr.Size);
            IntPtr _count_count = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _resultPtr = SafeExecution<IntPtr>(() => Native.RasterDumpValues(rast, band, exclude_nodata, _out_nodata, _count_count));
                int _n = Marshal.ReadInt32(_count_count);
                double[] _resultArr = new double[_n];
                Marshal.Copy(_resultPtr, _resultArr, 0, _n);
                IntPtr __out_nodata_arr = Marshal.ReadIntPtr(_out_nodata);
                bool[] __out_nodata_out = new bool[_n];
                for (int _i = 0; _i < _n; _i++)
                { __out_nodata_out[_i] = Marshal.ReadByte(__out_nodata_arr, _i) != 0; }
                return (_resultArr, __out_nodata_out);
            }
            finally
            {
            Marshal.FreeHGlobal(_out_nodata);
            Marshal.FreeHGlobal(_count_count);
            }
        }

        public static IntPtr[] RasterPixelAsPoints(IntPtr rast, int band, bool exclude_nodata)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.RasterPixelAsPoints(rast, band, exclude_nodata, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 32); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr RasterSummaryStats(IntPtr rast, int band, bool exclude_nodata)
            => SafeExecution<IntPtr>(() => Native.RasterSummaryStats(rast, band, exclude_nodata));

        public static IntPtr[] RasterValueCount(IntPtr rast, int band, bool exclude_nodata, IntPtr searchvalues, int nsearch, double roundto)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.RasterValueCount(rast, band, exclude_nodata, searchvalues, nsearch, roundto, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = IntPtr.Add(_p, _i * 24); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

        public static IntPtr RasterSetValues(IntPtr rast, int band, int x, int y, int width, int height, IntPtr values, IntPtr nodata, IntPtr noset, int nosetwidth, int nosetheight, int count, bool keepnodata)
            => SafeExecution<IntPtr>(() => Native.RasterSetValues(rast, band, x, y, width, height, values, nodata, noset, nosetwidth, nosetheight, count, keepnodata));

        public static IntPtr RasterReclass(IntPtr rast, int band, string expr, string pixeltype, bool has_nodata, double nodataval)
            => SafeExecution<IntPtr>(() => Native.RasterReclass(rast, band, expr, pixeltype, has_nodata, nodataval));

        public static IntPtr RasterSlope(IntPtr rast, int band, IntPtr customextent, string pixeltype, string units, double scale, bool interpolate_nodata)
            => SafeExecution<IntPtr>(() => Native.RasterSlope(rast, band, customextent, pixeltype, units, scale, interpolate_nodata));

        public static IntPtr RasterTpi(IntPtr rast, int band, IntPtr customextent, string pixeltype, bool interpolate_nodata)
            => SafeExecution<IntPtr>(() => Native.RasterTpi(rast, band, customextent, pixeltype, interpolate_nodata));

        public static IntPtr RasterTri(IntPtr rast, int band, IntPtr customextent, string pixeltype, bool interpolate_nodata)
            => SafeExecution<IntPtr>(() => Native.RasterTri(rast, band, customextent, pixeltype, interpolate_nodata));

        public static IntPtr RasterMapAlgebra(IntPtr rast, int band, string stat, string pixeltype, string extenttype, IntPtr customextent, int distancex, int distancey)
            => SafeExecution<IntPtr>(() => Native.RasterMapAlgebra(rast, band, stat, pixeltype, extenttype, customextent, distancex, distancey));

        public static void GeomvalArrFree(IntPtr gvarr, int count)
            => SafeExecution(() => Native.GeomvalArrFree(gvarr, count));

        public static void PixelArrFree(IntPtr pixarr, int count)
            => SafeExecution(() => Native.PixelArrFree(pixarr, count));

        public static IntPtr AddFloatRaster(double d, IntPtr rast)
            => SafeExecution<IntPtr>(() => Native.AddFloatRaster(d, rast));

        public static IntPtr AddRasterFloat(IntPtr rast, double d)
            => SafeExecution<IntPtr>(() => Native.AddRasterFloat(rast, d));

        public static IntPtr AddRasterRaster(IntPtr rast1, IntPtr rast2)
            => SafeExecution<IntPtr>(() => Native.AddRasterRaster(rast1, rast2));

        public static IntPtr DivFloatRaster(double d, IntPtr rast)
            => SafeExecution<IntPtr>(() => Native.DivFloatRaster(d, rast));

        public static IntPtr DivRasterFloat(IntPtr rast, double d)
            => SafeExecution<IntPtr>(() => Native.DivRasterFloat(rast, d));

        public static IntPtr DivRasterRaster(IntPtr rast1, IntPtr rast2)
            => SafeExecution<IntPtr>(() => Native.DivRasterRaster(rast1, rast2));

        public static IntPtr MulFloatRaster(double d, IntPtr rast)
            => SafeExecution<IntPtr>(() => Native.MulFloatRaster(d, rast));

        public static IntPtr MulRasterFloat(IntPtr rast, double d)
            => SafeExecution<IntPtr>(() => Native.MulRasterFloat(rast, d));

        public static IntPtr MulRasterRaster(IntPtr rast1, IntPtr rast2)
            => SafeExecution<IntPtr>(() => Native.MulRasterRaster(rast1, rast2));

        public static IntPtr SubFloatRaster(double d, IntPtr rast)
            => SafeExecution<IntPtr>(() => Native.SubFloatRaster(d, rast));

        public static IntPtr SubRasterFloat(IntPtr rast, double d)
            => SafeExecution<IntPtr>(() => Native.SubRasterFloat(rast, d));

        public static IntPtr SubRasterRaster(IntPtr rast1, IntPtr rast2)
            => SafeExecution<IntPtr>(() => Native.SubRasterRaster(rast1, rast2));

        public static bool RasterSameAlignment(IntPtr rast1, IntPtr rast2)
            => SafeExecution<bool>(() => Native.RasterSameAlignment(rast1, rast2));

        public static string RasterNotSameAlignmentReason(IntPtr rast1, IntPtr rast2)
            => SafeExecution<string>(() => Native.RasterNotSameAlignmentReason(rast1, rast2));

        public static IntPtr RasterSameAlignmentCombinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => Native.RasterSameAlignmentCombinefn(state1, state2));

        public static bool RasterSameAlignmentFinalfn(IntPtr state)
            => SafeExecution<bool>(() => Native.RasterSameAlignmentFinalfn(state));

        public static IntPtr RasterSameAlignmentTransfn(IntPtr state, IntPtr rast)
            => SafeExecution<IntPtr>(() => Native.RasterSameAlignmentTransfn(state, rast));

        public static IntPtr RasterSummaryStatsCombinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => Native.RasterSummaryStatsCombinefn(state1, state2));

        public static IntPtr RasterSummaryStatsFinalfn(IntPtr state)
            => SafeExecution<IntPtr>(() => Native.RasterSummaryStatsFinalfn(state));

        public static IntPtr RasterSummaryStatsTransfn(IntPtr state, IntPtr rast, int band, bool exclude_nodata)
            => SafeExecution<IntPtr>(() => Native.RasterSummaryStatsTransfn(state, rast, band, exclude_nodata));

        public static IntPtr RasterUnionCombinefn(IntPtr state1, IntPtr state2)
            => SafeExecution<IntPtr>(() => Native.RasterUnionCombinefn(state1, state2));

        public static IntPtr RasterUnionFinalfn(IntPtr state)
            => SafeExecution<IntPtr>(() => Native.RasterUnionFinalfn(state));

        public static IntPtr RasterUnionTransfn(IntPtr state, IntPtr rast, int band, string uniontype)
            => SafeExecution<IntPtr>(() => Native.RasterUnionTransfn(state, rast, band, uniontype));

        public static IntPtr RasteralignstateDeserialize(IntPtr bytes, ulong size)
            => SafeExecution<IntPtr>(() => Native.RasteralignstateDeserialize(bytes, size));

        public static IntPtr RasteralignstateSerialize(IntPtr state, IntPtr size_out)
            => SafeExecution<IntPtr>(() => Native.RasteralignstateSerialize(state, size_out));

        public static IntPtr RasterstatsstateDeserialize(IntPtr bytes, ulong size)
            => SafeExecution<IntPtr>(() => Native.RasterstatsstateDeserialize(bytes, size));

        public static IntPtr RasterstatsstateSerialize(IntPtr state, IntPtr size_out)
            => SafeExecution<IntPtr>(() => Native.RasterstatsstateSerialize(state, size_out));

        public static IntPtr RasterunionstateDeserialize(IntPtr bytes, ulong size)
            => SafeExecution<IntPtr>(() => Native.RasterunionstateDeserialize(bytes, size));

        public static IntPtr RasterunionstateSerialize(IntPtr state, IntPtr size_out)
            => SafeExecution<IntPtr>(() => Native.RasterunionstateSerialize(state, size_out));

        public static IntPtr RaquetToStbox(IntPtr rq)
            => SafeExecution<IntPtr>(() => Native.RaquetToStbox(rq));

        public static IntPtr RasterToStbox(IntPtr rast)
            => SafeExecution<IntPtr>(() => Native.RasterToStbox(rast));

        public static int RaquetCmp(IntPtr rq1, IntPtr rq2)
            => SafeExecution<int>(() => Native.RaquetCmp(rq1, rq2));

        public static bool RaquetEq(IntPtr rq1, IntPtr rq2)
            => SafeExecution<bool>(() => Native.RaquetEq(rq1, rq2));

        public static bool RaquetNe(IntPtr rq1, IntPtr rq2)
            => SafeExecution<bool>(() => Native.RaquetNe(rq1, rq2));

        public static bool RaquetLt(IntPtr rq1, IntPtr rq2)
            => SafeExecution<bool>(() => Native.RaquetLt(rq1, rq2));

        public static bool RaquetLe(IntPtr rq1, IntPtr rq2)
            => SafeExecution<bool>(() => Native.RaquetLe(rq1, rq2));

        public static bool RaquetGe(IntPtr rq1, IntPtr rq2)
            => SafeExecution<bool>(() => Native.RaquetGe(rq1, rq2));

        public static bool RaquetGt(IntPtr rq1, IntPtr rq2)
            => SafeExecution<bool>(() => Native.RaquetGt(rq1, rq2));

        public static IntPtr RasterValue(IntPtr traj, IntPtr rast, int band, bool exclude_nodata, string resample)
            => SafeExecution<IntPtr>(() => Native.RasterValue(traj, rast, band, exclude_nodata, resample));

        public static IntPtr RasterAtValue(IntPtr traj, IntPtr rast, int band, IntPtr vspan)
            => SafeExecution<IntPtr>(() => Native.RasterAtValue(traj, rast, band, vspan));

        public static IntPtr RasterMinusValue(IntPtr traj, IntPtr rast, int band, IntPtr vspan)
            => SafeExecution<IntPtr>(() => Native.RasterMinusValue(traj, rast, band, vspan));

        public static int ErasterValue(IntPtr traj, IntPtr rast, int band, IntPtr vspan)
            => SafeExecution<int>(() => Native.ErasterValue(traj, rast, band, vspan));

        public static int ArasterValue(IntPtr traj, IntPtr rast, int band, IntPtr vspan)
            => SafeExecution<int>(() => Native.ArasterValue(traj, rast, band, vspan));

        public static IntPtr RasterValueGdal(IntPtr traj, string path, int band)
            => SafeExecution<IntPtr>(() => Native.RasterValueGdal(traj, path, band));

        public static IntPtr RasterAtValueGdal(IntPtr traj, string path, int band, IntPtr vspan)
            => SafeExecution<IntPtr>(() => Native.RasterAtValueGdal(traj, path, band, vspan));

        public static IntPtr RasterMinusValueGdal(IntPtr traj, string path, int band, IntPtr vspan)
            => SafeExecution<IntPtr>(() => Native.RasterMinusValueGdal(traj, path, band, vspan));

        public static int ErasterValueGdal(IntPtr traj, string path, int band, IntPtr vspan)
            => SafeExecution<int>(() => Native.ErasterValueGdal(traj, path, band, vspan));

        public static int ArasterValueGdal(IntPtr traj, string path, int band, IntPtr vspan)
            => SafeExecution<int>(() => Native.ArasterValueGdal(traj, path, band, vspan));

        public static IntPtr RasterTileValueQuadbin(IntPtr traj, IntPtr pixels, ulong pixels_size, int width, int height, ulong quadbin, int pixtype, double nodata, bool has_nodata)
            => SafeExecution<IntPtr>(() => Native.RasterTileValueQuadbin(traj, pixels, pixels_size, width, height, quadbin, pixtype, nodata, has_nodata));

        public static IntPtr RasterTileValue(IntPtr traj, IntPtr rq)
            => SafeExecution<IntPtr>(() => Native.RasterTileValue(traj, rq));

        public static IntPtr RasterTileValueArray(IntPtr traj, IntPtr rqarr, int count)
            => SafeExecution<IntPtr>(() => Native.RasterTileValueArray(traj, rqarr, count));

    }
}
