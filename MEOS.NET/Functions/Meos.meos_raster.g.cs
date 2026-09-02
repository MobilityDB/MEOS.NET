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

        public static double RaquetNodata(IntPtr rq)
            => SafeExecution<double>(() => Native.RaquetNodata(rq));

        public static string RaquetPixtype(IntPtr rq)
            => SafeExecution<string>(() => Native.RaquetPixtype(rq));

        public static IntPtr RaquetPixels(IntPtr rq, IntPtr size_out)
            => SafeExecution<IntPtr>(() => Native.RaquetPixels(rq, size_out));

        public static uint RaquetHash(IntPtr rq)
            => SafeExecution<uint>(() => Native.RaquetHash(rq));

        public static ulong RaquetHashExtended(IntPtr rq, ulong seed)
            => SafeExecution<ulong>(() => Native.RaquetHashExtended(rq, seed));

        public static IntPtr RasterFromWkb(IntPtr wkb, ulong size)
            => SafeExecution<IntPtr>(() => Native.RasterFromWkb(wkb, size));

        public static IntPtr RasterFromHexwkb(string hexwkb)
            => SafeExecution<IntPtr>(() => Native.RasterFromHexwkb(hexwkb));

        public static IntPtr RasterAsWkb(IntPtr rast, IntPtr size_out)
            => SafeExecution<IntPtr>(() => Native.RasterAsWkb(rast, size_out));

        public static string RasterAsHexwkb(IntPtr rast, IntPtr size_out)
            => SafeExecution<string>(() => Native.RasterAsHexwkb(rast, size_out));

        public static int RasterNumBands(IntPtr rast)
            => SafeExecution<int>(() => Native.RasterNumBands(rast));

        public static IntPtr RaquetToStbox(IntPtr rq)
            => SafeExecution<IntPtr>(() => Native.RaquetToStbox(rq));

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

        public static IntPtr RasterValue(IntPtr traj, IntPtr box, IntPtr sample, IntPtr ctx)
            => SafeExecution<IntPtr>(() => Native.RasterValue(traj, box, sample, ctx));

        public static IntPtr RasterAtValue(IntPtr traj, IntPtr box, IntPtr sample, IntPtr ctx, IntPtr vspan)
            => SafeExecution<IntPtr>(() => Native.RasterAtValue(traj, box, sample, ctx, vspan));

        public static IntPtr RasterMinusValue(IntPtr traj, IntPtr box, IntPtr sample, IntPtr ctx, IntPtr vspan)
            => SafeExecution<IntPtr>(() => Native.RasterMinusValue(traj, box, sample, ctx, vspan));

        public static int ErasterValue(IntPtr traj, IntPtr box, IntPtr sample, IntPtr ctx, IntPtr vspan)
            => SafeExecution<int>(() => Native.ErasterValue(traj, box, sample, ctx, vspan));

        public static int ArasterValue(IntPtr traj, IntPtr box, IntPtr sample, IntPtr ctx, IntPtr vspan)
            => SafeExecution<int>(() => Native.ArasterValue(traj, box, sample, ctx, vspan));

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

        public static IntPtr[] TrajectoryQuadbins(IntPtr traj, uint zoom)
        {
            IntPtr _cnt = Marshal.AllocHGlobal(sizeof(int));
            try
            {
                IntPtr _p = SafeExecution<IntPtr>(() => Native.TrajectoryQuadbins(traj, zoom, _cnt));
                int _n = Marshal.ReadInt32(_cnt);
                IntPtr[] _out = new IntPtr[_n];
                for (int _i = 0; _i < _n; _i++)
                { _out[_i] = Marshal.ReadIntPtr(_p, _i * IntPtr.Size); }
                return _out;
            }
            finally { Marshal.FreeHGlobal(_cnt); }
        }

    }
}
