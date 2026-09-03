#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>PostGIS-derived values, both of them a GSERIALIZED. Parent of Geometry and Geography exactly as TGeo parents TGeometry and TGeography, so a signature naming the C type alone is typed by the parent and the two spellings stay distinct classes.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Geo : Value
    {
        internal Geo(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public byte[]? AsEWKB(string endian)
        {
            IntPtr _size = Marshal.AllocHGlobal(sizeof(long));
            try
            {
                IntPtr _bytes = Meos.GeoAsEwkb(this.Ptr, endian, _size);
                if (_bytes == IntPtr.Zero)
                {
                    return null;
                }

                byte[] _wkb = new byte[Marshal.ReadInt64(_size)];
                Marshal.Copy(_bytes, _wkb, 0, _wkb.Length);
                return _wkb;
            }
            finally
            {
                Marshal.FreeHGlobal(_size);
            }
        }

        public string AsEWKT(int precision)
            => Meos.GeoAsEwkt(this.Ptr, precision);

        public string AsGEOJSON(int option, int precision, string srs)
            => Meos.GeoAsGeojson(this.Ptr, option, precision, srs);

        public string AsHexewkb(string endian)
            => Meos.GeoAsHexewkb(this.Ptr, endian);

        public string AsText(int precision)
            => Meos.GeoAsText(this.Ptr, precision);

        public Geo? Copy()
            => MEOSFactory.WrapGeo(Meos.GeoCopy(this.Ptr));

        public int Equals(Geo gs2)
            => Meos.GeoEquals(this.Ptr, gs2.Ptr);

        public Geo? GeoN(int n)
            => MEOSFactory.WrapGeo(Meos.GeoGeoN(this.Ptr, n));

        public bool IsEmpty()
            => Meos.GeoIsEmpty(this.Ptr);

        public bool IsUnitary()
            => Meos.GeoIsUnitary(this.Ptr);

        public int NumGeos()
            => Meos.GeoNumGeos(this.Ptr);

        public int NumPoints()
            => Meos.GeoNumPoints(this.Ptr);

        public string Out()
            => Meos.GeoOut(this.Ptr);

        public Geo?[] Pointarr()
            => MEOSFactory.WrapGeoArray(Meos.GeoPointarr(this.Ptr));

        public Geo? Points()
            => MEOSFactory.WrapGeo(Meos.GeoPoints(this.Ptr));

        public Geo? Reverse()
            => MEOSFactory.WrapGeo(Meos.GeoReverse(this.Ptr));

        public Geo? Round(int maxdd)
            => MEOSFactory.WrapGeo(Meos.GeoRound(this.Ptr, maxdd));

        public int SRID()
            => Meos.GeoSrid(this.Ptr);

        public bool Same(Geo gs2)
            => Meos.GeoSame(this.Ptr, gs2.Ptr);

        public Geo? SetSRID(int srid)
            => MEOSFactory.WrapGeo(Meos.GeoSetSrid(this.Ptr, srid));

        public STBox?[] SplitEachNStboxes(int elem_count)
            => MEOSFactory.WrapSTBoxArray(Meos.GeoSplitEachNStboxes(this.Ptr, elem_count));

        public STBox?[] SplitNStboxes(int box_count)
            => MEOSFactory.WrapSTBoxArray(Meos.GeoSplitNStboxes(this.Ptr, box_count));

        public STBox?[] Stboxes()
            => MEOSFactory.WrapSTBoxArray(Meos.GeoStboxes(this.Ptr));

        public STBox? TimestamptzToStbox(DateTime t)
            => MEOSFactory.WrapSTBox(Meos.GeoTimestamptzToStbox(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public ulong ToH3indexCell(int resolution)
            => Meos.GeoToH3indexCell(this.Ptr, resolution);

        public Set? ToH3indexSet(int resolution)
            => MEOSFactory.WrapSet(Meos.GeoToH3indexSet(this.Ptr, resolution));

        public ulong ToQuadbinCell(int resolution)
            => Meos.GeoToQuadbinCell(this.Ptr, resolution);

        public ulong ToS2cellCell(int level)
            => Meos.GeoToS2cellCell(this.Ptr, level);

        public Set? ToSet()
            => MEOSFactory.WrapSet(Meos.GeoToSet(this.Ptr));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.GeoToStbox(this.Ptr));

        public Geo? Transform(int srid_to)
            => MEOSFactory.WrapGeo(Meos.GeoTransform(this.Ptr, srid_to));

        public Geo? TransformPipeline(string pipeline, int srid_to, bool is_forward)
            => MEOSFactory.WrapGeo(Meos.GeoTransformPipeline(this.Ptr, pipeline, srid_to, is_forward));

        public STBox? TstzspanToStbox(Span s)
            => MEOSFactory.WrapSTBox(Meos.GeoTstzspanToStbox(this.Ptr, s.Ptr));

        public static uint[] ClusterDbscan(Geo[] geoms, double tolerance, int minpoints)
        {
            IntPtr[] _geomsValues = new IntPtr[geoms.Length];
            for (int i = 0; i < geoms.Length; i++)
            {
                _geomsValues[i] = geoms[i].Ptr;
            }

            GCHandle _geoms = GCHandle.Alloc(_geomsValues, GCHandleType.Pinned);
            try
            {
                return Meos.GeoClusterDbscan(_geoms.AddrOfPinnedObject(), (uint) geoms.Length, tolerance, minpoints);
            }
            finally
            {
                _geoms.Free();
            }
        }

        public static Geo?[] ClusterIntersecting(Geo[] geoms)
        {
            IntPtr[] _geomsValues = new IntPtr[geoms.Length];
            for (int i = 0; i < geoms.Length; i++)
            {
                _geomsValues[i] = geoms[i].Ptr;
            }

            GCHandle _geoms = GCHandle.Alloc(_geomsValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapGeoArray(Meos.GeoClusterIntersecting(_geoms.AddrOfPinnedObject(), (uint) geoms.Length));
            }
            finally
            {
                _geoms.Free();
            }
        }

        public static int[] ClusterKmeans(Geo[] geoms, uint k)
        {
            IntPtr[] _geomsValues = new IntPtr[geoms.Length];
            for (int i = 0; i < geoms.Length; i++)
            {
                _geomsValues[i] = geoms[i].Ptr;
            }

            GCHandle _geoms = GCHandle.Alloc(_geomsValues, GCHandleType.Pinned);
            try
            {
                return Meos.GeoClusterKmeans(_geoms.AddrOfPinnedObject(), (uint) geoms.Length, k);
            }
            finally
            {
                _geoms.Free();
            }
        }

        public static Geo?[] ClusterWithin(Geo[] geoms, double tolerance)
        {
            IntPtr[] _geomsValues = new IntPtr[geoms.Length];
            for (int i = 0; i < geoms.Length; i++)
            {
                _geomsValues[i] = geoms[i].Ptr;
            }

            GCHandle _geoms = GCHandle.Alloc(_geomsValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapGeoArray(Meos.GeoClusterWithin(_geoms.AddrOfPinnedObject(), (uint) geoms.Length, tolerance));
            }
            finally
            {
                _geoms.Free();
            }
        }

        public static Geo? CollectGarray(Geo[] gsarr)
        {
            IntPtr[] _gsarrValues = new IntPtr[gsarr.Length];
            for (int i = 0; i < gsarr.Length; i++)
            {
                _gsarrValues[i] = gsarr[i].Ptr;
            }

            GCHandle _gsarr = GCHandle.Alloc(_gsarrValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapGeo(Meos.GeoCollectGarray(_gsarr.AddrOfPinnedObject(), gsarr.Length));
            }
            finally
            {
                _gsarr.Free();
            }
        }

        public static Geo? FromEWKB(byte[] wkb, int srid)
        {
            GCHandle _wkb = GCHandle.Alloc(wkb, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapGeo(Meos.GeoFromEwkb(_wkb.AddrOfPinnedObject(), (ulong) wkb.Length, srid));
            }
            finally
            {
                _wkb.Free();
            }
        }

        public static Geo? FromGEOJSON(string geojson)
            => MEOSFactory.WrapGeo(Meos.GeoFromGeojson(geojson));

        public static Geo? FromText(string wkt, int srid)
            => MEOSFactory.WrapGeo(Meos.GeoFromText(wkt, srid));

        public static Geo? MakelineGarray(Geo[] gsarr)
        {
            IntPtr[] _gsarrValues = new IntPtr[gsarr.Length];
            for (int i = 0; i < gsarr.Length; i++)
            {
                _gsarrValues[i] = gsarr[i].Ptr;
            }

            GCHandle _gsarr = GCHandle.Alloc(_gsarrValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapGeo(Meos.GeoMakelineGarray(_gsarr.AddrOfPinnedObject(), gsarr.Length));
            }
            finally
            {
                _gsarr.Free();
            }
        }

        public static string? Typename(int type)
            => Meos.GeoTypename(type);

    }
}
