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
            => this.AsText(15);

        public int Adisjoint(TGeo temp)
            => Meos.AdisjointGeoTgeo(this.Ptr, temp.Ptr);

        public int Adwithin(TGeo temp, double dist, bool spheroid)
            => Meos.AdwithinGeoTgeo(this.Ptr, temp.Ptr, dist, spheroid);

        public Geo? Affine(double a, double b, double c, double d, double e, double f, double g, double h, double i, double xoff, double yoff, double zoff)
            => MEOSFactory.WrapGeo(Meos.GeoAffine(this.Ptr, a, b, c, d, e, f, g, h, i, xoff, yoff, zoff));

        public int Aintersects(TGeo temp)
            => Meos.AintersectsGeoTgeo(this.Ptr, temp.Ptr);

        public int AlwaysEq(TGeo temp)
            => Meos.AlwaysEqGeoTgeo(this.Ptr, temp.Ptr);

        public int AlwaysNe(TGeo temp)
            => Meos.AlwaysNeGeoTgeo(this.Ptr, temp.Ptr);

        public double Area(bool spheroid)
            => Meos.GeoArea(this.Ptr, spheroid);

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

        public string AsGeoJSON(int option, int precision, string srs)
            => Meos.GeoAsGeojson(this.Ptr, option, precision, srs);

        public string AsHexEWKB(string endian)
            => Meos.GeoAsHexewkb(this.Ptr, endian);

        public string AsText(int precision)
            => Meos.GeoAsText(this.Ptr, precision);

        public double? Bearing(Geo gs2)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.BearingPointPoint(this.Ptr, gs2.Ptr, _result))
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

        public Temporal? Bearing(TPoint temp)
            => MEOSFactory.WrapTemporal(Meos.BearingPointTpoint(this.Ptr, temp.Ptr));

        public Geo? Centroid(bool spheroid)
            => MEOSFactory.WrapGeo(Meos.GeoCentroid(this.Ptr, spheroid));

        public bool Contained(GeoSet s)
            => Meos.ContainedGeoSet(this.Ptr, s.Ptr);

        public Geo? Copy()
            => MEOSFactory.WrapGeo(Meos.GeoCopy(this.Ptr));

        public double Distance(Geo gs2, bool spheroid)
            => Meos.GeoDistance(this.Ptr, gs2.Ptr, spheroid);

        public int Edisjoint(TGeo temp)
            => Meos.EdisjointGeoTgeo(this.Ptr, temp.Ptr);

        public int Edwithin(TSpatial temp, double dist, bool spheroid)
            => Meos.EdwithinGeoTgeo(this.Ptr, temp.Ptr, dist, spheroid);

        public int Eintersects(TSpatial temp)
            => Meos.EintersectsGeoTgeo(this.Ptr, temp.Ptr);

        public int Equals(Geo gs2)
            => Meos.GeoEquals(this.Ptr, gs2.Ptr);

        public int EverEq(TGeo temp)
            => Meos.EverEqGeoTgeo(this.Ptr, temp.Ptr);

        public int EverNe(TGeo temp)
            => Meos.EverNeGeoTgeo(this.Ptr, temp.Ptr);

        public Geo? GeoN(int n)
            => MEOSFactory.WrapGeo(Meos.GeoGeoN(this.Ptr, n));

        public Set? Intersection(GeoSet s)
            => MEOSFactory.WrapSet(Meos.IntersectionGeoSet(this.Ptr, s.Ptr));

        public bool IsEmpty()
            => Meos.GeoIsEmpty(this.Ptr);

        public bool IsUnitary()
            => Meos.GeoIsUnitary(this.Ptr);

        public double Length(bool spheroid)
            => Meos.GeoLength(this.Ptr, spheroid);

        public int MemSize()
            => Meos.GeoMemSize(this.Ptr);

        public Set? Minus(GeoSet s)
            => MEOSFactory.WrapSet(Meos.MinusGeoSet(this.Ptr, s.Ptr));

        public int NumGeos()
            => Meos.GeoNumGeos(this.Ptr);

        public int NumPoints()
            => Meos.GeoNumPoints(this.Ptr);

        public double Perimeter(bool spheroid)
            => Meos.GeoPerimeter(this.Ptr, spheroid);

        public Geo?[] Pointarr()
            => MEOSFactory.WrapGeoArray(Meos.GeoPointarr(this.Ptr));

        public Geo? Points()
            => MEOSFactory.WrapGeo(Meos.GeoPoints(this.Ptr));

        public Geo? Reverse()
            => MEOSFactory.WrapGeo(Meos.GeoReverse(this.Ptr));

        public Geo? Rotate(double angle, double x0, double y0)
            => MEOSFactory.WrapGeo(Meos.GeoRotate(this.Ptr, angle, x0, y0));

        public Geo? RotateGeo(double angle, Geo origin)
            => MEOSFactory.WrapGeo(Meos.GeoRotateGeo(this.Ptr, angle, origin.Ptr));

        public Geo? RotateX(double angle)
            => MEOSFactory.WrapGeo(Meos.GeoRotateX(this.Ptr, angle));

        public Geo? RotateY(double angle)
            => MEOSFactory.WrapGeo(Meos.GeoRotateY(this.Ptr, angle));

        public Geo? RotateZ(double angle)
            => MEOSFactory.WrapGeo(Meos.GeoRotateZ(this.Ptr, angle));

        public Geo? Round(int maxdd)
            => MEOSFactory.WrapGeo(Meos.GeoRound(this.Ptr, maxdd));

        public int SRID()
            => Meos.GeoSrid(this.Ptr);

        public bool Same(Geo gs2)
            => Meos.GeoSame(this.Ptr, gs2.Ptr);

        public Geo? Scale(double xfactor, double yfactor, double zfactor)
            => MEOSFactory.WrapGeo(Meos.GeoScale(this.Ptr, xfactor, yfactor, zfactor));

        public Geo? ScaleGeo(Geo scale)
            => MEOSFactory.WrapGeo(Meos.GeoScaleGeo(this.Ptr, scale.Ptr));

        public Geo? ScaleGeoOrigin(Geo scale, Geo sorigin)
            => MEOSFactory.WrapGeo(Meos.GeoScaleGeoOrigin(this.Ptr, scale.Ptr, sorigin.Ptr));

        public Geo? Segmentize(double max_seg_length)
            => MEOSFactory.WrapGeo(Meos.GeoSegmentize(this.Ptr, max_seg_length));

        public Geo? SetSRID(int srid)
            => MEOSFactory.WrapGeo(Meos.GeoSetSrid(this.Ptr, srid));

        public Geo? Shortestline(Geo gs2, bool spheroid)
            => MEOSFactory.WrapGeo(Meos.GeoShortestline(this.Ptr, gs2.Ptr, spheroid));

        public STBox?[] SplitEachNStboxes(int elem_count)
            => MEOSFactory.WrapSTBoxArray(Meos.GeoSplitEachNStboxes(this.Ptr, elem_count));

        public STBox?[] SplitNStboxes(int box_count)
            => MEOSFactory.WrapSTBoxArray(Meos.GeoSplitNStboxes(this.Ptr, box_count));

        public STBox?[] Stboxes()
            => MEOSFactory.WrapSTBoxArray(Meos.GeoStboxes(this.Ptr));

        public Temporal? Tdisjoint(TGeo temp)
            => MEOSFactory.WrapTemporal(Meos.TdisjointGeoTgeo(this.Ptr, temp.Ptr));

        public Temporal? Tdwithin(TGeo temp, double dist, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.TdwithinGeoTgeo(this.Ptr, temp.Ptr, dist, spheroid));

        public Temporal? Teq(TGeo temp)
            => MEOSFactory.WrapTemporal(Meos.TeqGeoTgeo(this.Ptr, temp.Ptr));

        public STBox? TimestamptzToStbox(DateTime t)
            => MEOSFactory.WrapSTBox(Meos.GeoTimestamptzToStbox(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public Temporal? Tintersects(TGeo temp)
            => MEOSFactory.WrapTemporal(Meos.TintersectsGeoTgeo(this.Ptr, temp.Ptr));

        public Temporal? Tne(TGeo temp)
            => MEOSFactory.WrapTemporal(Meos.TneGeoTgeo(this.Ptr, temp.Ptr));

        public H3Index ToH3indexCell(int resolution)
            => new H3Index(Meos.GeoToH3indexCell(this.Ptr, resolution));

        public Set? ToH3indexSet(int resolution)
            => MEOSFactory.WrapSet(Meos.GeoToH3indexSet(this.Ptr, resolution));

        public Quadbin ToQuadbinCell(int resolution)
            => new Quadbin(Meos.GeoToQuadbinCell(this.Ptr, resolution));

        public Set? ToQuadbinSet(int resolution)
            => MEOSFactory.WrapSet(Meos.GeoToQuadbinSet(this.Ptr, resolution));

        public S2Cell ToS2cellCell(int level)
            => new S2Cell(Meos.GeoToS2cellCell(this.Ptr, level));

        public Set? ToS2cellSet(int level)
            => MEOSFactory.WrapSet(Meos.GeoToS2cellSet(this.Ptr, level));

        public Set? ToSet()
            => MEOSFactory.WrapSet(Meos.GeoToSet(this.Ptr));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.GeoToStbox(this.Ptr));

        public Geo? Transform(int srid_to)
            => MEOSFactory.WrapGeo(Meos.GeoTransform(this.Ptr, srid_to));

        public Geo? TransformPipeline(string pipelinestr, int srid, bool is_forward)
            => MEOSFactory.WrapGeo(Meos.GeoTransformPipeline(this.Ptr, pipelinestr, srid, is_forward));

        public Geo? Translate(double deltax, double deltay, double deltaz)
            => MEOSFactory.WrapGeo(Meos.GeoTranslate(this.Ptr, deltax, deltay, deltaz));

        public Geo? Transscale(double deltax, double deltay, double xfactor, double yfactor)
            => MEOSFactory.WrapGeo(Meos.GeoTransscale(this.Ptr, deltax, deltay, xfactor, yfactor));

        public STBox? TstzspanToStbox(Span s)
            => MEOSFactory.WrapSTBox(Meos.GeoTstzspanToStbox(this.Ptr, s.Ptr));

        public Set? Union(GeoSet s)
            => MEOSFactory.WrapSet(Meos.UnionGeoSet(this.Ptr, s.Ptr));

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

        public static Geo? FromGeoJSON(string geojson)
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
