#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>A georeferenced raster of one or more bands, the value every raster accessor, clip, warp and polygonization takes. MEOS registers it in no enum, so it names no temptype.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Raster : Value
    {
        internal Raster(IntPtr ptr) : base(ptr) { }

        public Raster? AddBand(int index, string pixeltype, double initialvalue, double nodataval, bool has_nodata)
            => MEOSFactory.WrapRaster(Meos.RasterAddBand(this.Ptr, index, pixeltype, initialvalue, nodataval, has_nodata));

        public Raster? AddBandRaster(Raster fromrast, int fromband, int toindex)
            => MEOSFactory.WrapRaster(Meos.RasterAddBandRaster(this.Ptr, fromrast.Ptr, fromband, toindex));

        public string AsHexWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                return Meos.RasterAsHexwkb(this.Ptr, variant, _size_out);
            }
            finally
            {
                Marshal.FreeHGlobal(_size_out);
            }
        }

        public byte[]? AsWKB(byte variant)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.RasterAsWkb(this.Ptr, variant, _size_out);
                if (_bytes == IntPtr.Zero)
                {
                    return null;
                }

                byte[] _wkb = new byte[Marshal.ReadInt64(_size_out)];
                Marshal.Copy(_bytes, _wkb, 0, _wkb.Length);
                return _wkb;
            }
            finally
            {
                Marshal.FreeHGlobal(_size_out);
            }
        }

        public bool BandHasNodataValue(int band)
            => Meos.RasterBandHasNodataValue(this.Ptr, band);

        public double? BandNodataValue(int band)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.RasterBandNodataValue(this.Ptr, band, _result))
                {
                    return null;
                }

                return Marshal.PtrToStructure<double>(_result);
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public string BandPixelType(int band)
            => Meos.RasterBandPixelType(this.Ptr, band);

        public byte[]? BandPixels(int band)
        {
            IntPtr _size_out = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.RasterBandPixels(this.Ptr, band, _size_out);
                if (_bytes == IntPtr.Zero)
                {
                    return null;
                }

                byte[] _wkb = new byte[Marshal.ReadInt64(_size_out)];
                Marshal.Copy(_bytes, _wkb, 0, _wkb.Length);
                return _wkb;
            }
            finally
            {
                Marshal.FreeHGlobal(_size_out);
            }
        }

        public Raster? Clip(int[] bands, Geo gs, double[] nodata, bool crop, bool touched)
        {
            GCHandle _bands = GCHandle.Alloc(bands, GCHandleType.Pinned);
            GCHandle _nodata = GCHandle.Alloc(nodata, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapRaster(Meos.RasterClip(this.Ptr, _bands.AddrOfPinnedObject(), bands.Length, gs.Ptr, _nodata.AddrOfPinnedObject(), nodata.Length, crop, touched));
            }
            finally
            {
                _bands.Free();
                _nodata.Free();
            }
        }

        public Raster? Copy()
            => MEOSFactory.WrapRaster(Meos.RasterCopy(this.Ptr));

        public (double[], bool[]) DumpValues(int band, bool exclude_nodata)
        {
            var _answered = Meos.RasterDumpValues(this.Ptr, band, exclude_nodata);

            return (_answered.Item1, _answered.Item2);
        }

        public int Height()
            => Meos.RasterHeight(this.Ptr);

        public Raster? MapAlgebra(int band, string stat, string pixeltype, string extenttype, Raster customextent, int distancex, int distancey)
            => MEOSFactory.WrapRaster(Meos.RasterMapAlgebra(this.Ptr, band, stat, pixeltype, extenttype, customextent.Ptr, distancex, distancey));

        public int MemSize()
            => Meos.RasterMemSize(this.Ptr);

        public string NotSameAlignmentReason(Raster rast2)
            => Meos.RasterNotSameAlignmentReason(this.Ptr, rast2.Ptr);

        public int NumBands()
            => Meos.RasterNumBands(this.Ptr);

        public Raster? Reclass(int band, string expr, string pixeltype, bool has_nodata, double nodataval)
            => MEOSFactory.WrapRaster(Meos.RasterReclass(this.Ptr, band, expr, pixeltype, has_nodata, nodataval));

        public Raster? Rescale(double scale_x, double scale_y, string algorithm, double max_err)
            => MEOSFactory.WrapRaster(Meos.RasterRescale(this.Ptr, scale_x, scale_y, algorithm, max_err));

        public int SRID()
            => Meos.RasterSrid(this.Ptr);

        public bool SameAlignment(Raster rast2)
            => Meos.RasterSameAlignment(this.Ptr, rast2.Ptr);

        public double ScaleX()
            => Meos.RasterScaleX(this.Ptr);

        public double ScaleY()
            => Meos.RasterScaleY(this.Ptr);

        public Raster? SetValues(int band, int x, int y, int width, int height, double[] values, bool[] nodata, bool[] noset, int nosetheight, int count, bool keepnodata)
        {
            if (values.Length != nodata.Length || values.Length != noset.Length)
            {
                throw new ArgumentException(
                    "values, nodata and noset are read in step, so they hold the same number of elements.");
            }

            GCHandle _values = GCHandle.Alloc(values, GCHandleType.Pinned);
            GCHandle _nodata = GCHandle.Alloc(nodata, GCHandleType.Pinned);
            GCHandle _noset = GCHandle.Alloc(noset, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapRaster(Meos.RasterSetValues(this.Ptr, band, x, y, width, height, _values.AddrOfPinnedObject(), _nodata.AddrOfPinnedObject(), _noset.AddrOfPinnedObject(), values.Length, nosetheight, count, keepnodata));
            }
            finally
            {
                _values.Free();
                _nodata.Free();
                _noset.Free();
            }
        }

        public double SkewX()
            => Meos.RasterSkewX(this.Ptr);

        public double SkewY()
            => Meos.RasterSkewY(this.Ptr);

        public Raster? Slope(int band, Raster customextent, string pixeltype, string units, double scale, bool interpolate_nodata)
            => MEOSFactory.WrapRaster(Meos.RasterSlope(this.Ptr, band, customextent.Ptr, pixeltype, units, scale, interpolate_nodata));

        public BandStats? SummaryStats(int band, bool exclude_nodata)
            => MEOSConvert.ToStruct<BandStats>(Meos.RasterSummaryStats(this.Ptr, band, exclude_nodata));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.RasterToStbox(this.Ptr));

        public Raster? Tpi(int band, Raster customextent, string pixeltype, bool interpolate_nodata)
            => MEOSFactory.WrapRaster(Meos.RasterTpi(this.Ptr, band, customextent.Ptr, pixeltype, interpolate_nodata));

        public Raster? Transform(int srid, string algorithm, double max_err, double scale_x, double scale_y)
            => MEOSFactory.WrapRaster(Meos.RasterTransform(this.Ptr, srid, algorithm, max_err, scale_x, scale_y));

        public Raster? TransformPipeline(string pipelinestr, int srid, bool is_forward, string algorithm, double max_err, double scale_x, double scale_y)
            => MEOSFactory.WrapRaster(Meos.RasterTransformPipeline(this.Ptr, pipelinestr, srid, is_forward, algorithm, max_err, scale_x, scale_y));

        public Raster? TransformRaster(Raster alignto, string algorithm, double max_err)
            => MEOSFactory.WrapRaster(Meos.RasterTransformRaster(this.Ptr, alignto.Ptr, algorithm, max_err));

        public Raster? Tri(int band, Raster customextent, string pixeltype, bool interpolate_nodata)
            => MEOSFactory.WrapRaster(Meos.RasterTri(this.Ptr, band, customextent.Ptr, pixeltype, interpolate_nodata));

        public double UpperLeftX()
            => Meos.RasterUpperLeftX(this.Ptr);

        public double UpperLeftY()
            => Meos.RasterUpperLeftY(this.Ptr);

        public ValueCount[] ValueCount(int band, bool exclude_nodata, double[] searchvalues, double roundto)
        {
            GCHandle _searchvalues = GCHandle.Alloc(searchvalues, GCHandleType.Pinned);
            try
            {
                return MEOSConvert.ToStructArray<ValueCount>(Meos.RasterValueCount(this.Ptr, band, exclude_nodata, _searchvalues.AddrOfPinnedObject(), searchvalues.Length, roundto));
            }
            finally
            {
                _searchvalues.Free();
            }
        }

        public int Width()
            => Meos.RasterWidth(this.Ptr);

        public static Temporal? AtValue(Temporal traj, Raster rast, int band, Span vspan)
            => MEOSFactory.WrapTemporal(Meos.RasterAtValue(traj.Ptr, rast.Ptr, band, vspan.Ptr));

        public static Temporal? AtValueGdal(Temporal traj, string path, int band, Span vspan)
            => MEOSFactory.WrapTemporal(Meos.RasterAtValueGdal(traj.Ptr, path, band, vspan.Ptr));

        public static Raster? FromHexWKB(string hexwkb)
            => MEOSFactory.WrapRaster(Meos.RasterFromHexwkb(hexwkb));

        public static Raster? FromWKB(byte[] wkb)
        {
            GCHandle _wkb = GCHandle.Alloc(wkb, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapRaster(Meos.RasterFromWkb(_wkb.AddrOfPinnedObject(), (ulong) wkb.Length));
            }
            finally
            {
                _wkb.Free();
            }
        }

        public static Raster? Make(int width, int height, double upperleftx, double upperlefty, double scalex, double scaley, double skewx, double skewy, int srid, string pixeltype, double nodataval, bool has_nodata, byte[] pixels)
        {
            GCHandle _pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapRaster(Meos.RasterMake(width, height, upperleftx, upperlefty, scalex, scaley, skewx, skewy, srid, pixeltype, nodataval, has_nodata, _pixels.AddrOfPinnedObject(), (ulong) pixels.Length));
            }
            finally
            {
                _pixels.Free();
            }
        }

        public static Raster? MakeEmpty(int width, int height, double upperleftx, double upperlefty, double scalex, double scaley, double skewx, double skewy, int srid)
            => MEOSFactory.WrapRaster(Meos.RasterMakeEmpty(width, height, upperleftx, upperlefty, scalex, scaley, skewx, skewy, srid));

        public static Temporal? MinusValue(Temporal traj, Raster rast, int band, Span vspan)
            => MEOSFactory.WrapTemporal(Meos.RasterMinusValue(traj.Ptr, rast.Ptr, band, vspan.Ptr));

        public static Temporal? MinusValueGdal(Temporal traj, string path, int band, Span vspan)
            => MEOSFactory.WrapTemporal(Meos.RasterMinusValueGdal(traj.Ptr, path, band, vspan.Ptr));

        public static Temporal? TileValue(Temporal traj, Raquet rq)
            => MEOSFactory.WrapTemporal(Meos.RasterTileValue(traj.Ptr, rq.Ptr));

        public static Temporal? TileValueArray(Temporal traj, Raquet[] rqarr)
        {
            IntPtr[] _rqarrValues = new IntPtr[rqarr.Length];
            for (int i = 0; i < rqarr.Length; i++)
            {
                _rqarrValues[i] = rqarr[i].Ptr;
            }

            GCHandle _rqarr = GCHandle.Alloc(_rqarrValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapTemporal(Meos.RasterTileValueArray(traj.Ptr, _rqarr.AddrOfPinnedObject(), rqarr.Length));
            }
            finally
            {
                _rqarr.Free();
            }
        }

        public static Temporal? TileValueQuadbin(Temporal traj, byte[] pixels, int width, int height, ulong quadbin, MeosPixType pixtype, double nodata, bool has_nodata)
        {
            GCHandle _pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapTemporal(Meos.RasterTileValueQuadbin(traj.Ptr, _pixels.AddrOfPinnedObject(), (ulong) pixels.Length, width, height, quadbin, (int) pixtype, nodata, has_nodata));
            }
            finally
            {
                _pixels.Free();
            }
        }

        public static Temporal? Value(Temporal traj, Raster rast, int band, bool exclude_nodata, string resample)
            => MEOSFactory.WrapTemporal(Meos.RasterValue(traj.Ptr, rast.Ptr, band, exclude_nodata, resample));

        public static Temporal? ValueGdal(Temporal traj, string path, int band)
            => MEOSFactory.WrapTemporal(Meos.RasterValueGdal(traj.Ptr, path, band));

    }
}
