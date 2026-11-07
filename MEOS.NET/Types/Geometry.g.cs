#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The Geometry class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Geometry : Geo
    {
        internal Geometry(IntPtr ptr) : base(ptr) { }

        public int Acontains(TGeo temp)
            => Meos.AcontainsGeoTgeo(this.Ptr, temp.Ptr);

        public int Acontains(TCbuffer temp)
            => Meos.AcontainsGeoTcbuffer(this.Ptr, temp.Ptr);

        public int Acontains(TRGeometry temp)
            => Meos.AcontainsGeoTrgeometry(this.Ptr, temp.Ptr);

        public int Acovers(TGeo temp)
            => Meos.AcoversGeoTgeo(this.Ptr, temp.Ptr);

        public int Acovers(TCbuffer temp)
            => Meos.AcoversGeoTcbuffer(this.Ptr, temp.Ptr);

        public int Acovers(TRGeometry temp)
            => Meos.AcoversGeoTrgeometry(this.Ptr, temp.Ptr);

        public int Adisjoint(TCbuffer temp)
            => Meos.AdisjointGeoTcbuffer(this.Ptr, temp.Ptr);

        public int Adwithin(TGeo temp, double dist, bool spheroid)
            => Meos.AdwithinGeoTgeo(this.Ptr, temp.Ptr, dist, spheroid);

        public int Adwithin(TCbuffer temp, double dist)
            => Meos.AdwithinGeoTcbuffer(this.Ptr, temp.Ptr, dist);

        public int Aintersects(TCbuffer temp)
            => Meos.AintersectsGeoTcbuffer(this.Ptr, temp.Ptr);

        public int AlwaysEq(TRGeometry temp)
            => Meos.AlwaysEqGeoTrgeometry(this.Ptr, temp.Ptr);

        public int AlwaysNe(TRGeometry temp)
            => Meos.AlwaysNeGeoTrgeometry(this.Ptr, temp.Ptr);

        public double Area()
            => Meos.GeomArea(this.Ptr);

        public string AsMFJSON(int option, int precision, string srs)
            => this.AsGeoJSON(option, precision, srs);

        public int Atouches(TGeometry temp)
            => Meos.AtouchesGeoTgeo(this.Ptr, temp.Ptr);

        public int Atouches(TGeomPoint temp)
            => Meos.AtouchesGeoTpoint(this.Ptr, temp.Ptr);

        public int Atouches(TCbuffer temp)
            => Meos.AtouchesGeoTcbuffer(this.Ptr, temp.Ptr);

        public double? Azimuth(Geo gs2)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.GeomAzimuth(this.Ptr, gs2.Ptr, _result))
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

        public Geo? Boundary()
            => MEOSFactory.WrapGeo(Meos.GeomBoundary(this.Ptr));

        public Geo? Buffer(double size, string @params)
            => MEOSFactory.WrapGeo(Meos.GeomBuffer(this.Ptr, size, @params));

        public Geo? Centroid()
            => MEOSFactory.WrapGeo(Meos.GeomCentroid(this.Ptr));

        public bool Contains(Geo gs2)
            => Meos.GeomContains(this.Ptr, gs2.Ptr);

        public Geo? ConvexHull()
            => MEOSFactory.WrapGeo(Meos.GeomConvexHull(this.Ptr));

        public bool Covers(Geo gs2)
            => Meos.GeomCovers(this.Ptr, gs2.Ptr);

        public Geo? Difference2d(Geo gs2)
            => MEOSFactory.WrapGeo(Meos.GeomDifference2d(this.Ptr, gs2.Ptr));

        public bool Disjoint(Geo gs2)
            => Meos.GeomDisjoint(this.Ptr, gs2.Ptr);

        public bool Disjoint2d(Geo gs2)
            => Meos.GeomDisjoint2d(this.Ptr, gs2.Ptr);

        public double Distance(Geo gs2)
            => Meos.GeomDistance(this.Ptr, gs2.Ptr);

        public double Distance2d(Geo gs2)
            => Meos.GeomDistance2d(this.Ptr, gs2.Ptr);

        public double Distance3d(Geo gs2)
            => Meos.GeomDistance3d(this.Ptr, gs2.Ptr);

        public bool Dwithin(Geo gs2, double dist)
            => Meos.GeomDwithin(this.Ptr, gs2.Ptr, dist);

        public bool Dwithin2d(Geo gs2, double dist)
            => Meos.GeomDwithin2d(this.Ptr, gs2.Ptr, dist);

        public bool Dwithin3d(Geo gs2, double dist)
            => Meos.GeomDwithin3d(this.Ptr, gs2.Ptr, dist);

        public int Econtains(TGeo temp)
            => Meos.EcontainsGeoTgeo(this.Ptr, temp.Ptr);

        public int Econtains(TCbuffer temp)
            => Meos.EcontainsGeoTcbuffer(this.Ptr, temp.Ptr);

        public int Econtains(TRGeometry temp)
            => Meos.EcontainsGeoTrgeometry(this.Ptr, temp.Ptr);

        public int Ecovers(TGeo temp)
            => Meos.EcoversGeoTgeo(this.Ptr, temp.Ptr);

        public int Ecovers(TCbuffer temp)
            => Meos.EcoversGeoTcbuffer(this.Ptr, temp.Ptr);

        public int Ecovers(TRGeometry temp)
            => Meos.EcoversGeoTrgeometry(this.Ptr, temp.Ptr);

        public int Edisjoint(TCbuffer temp)
            => Meos.EdisjointGeoTcbuffer(this.Ptr, temp.Ptr);

        public int Edwithin(TCbuffer temp, double dist)
            => Meos.EdwithinGeoTcbuffer(this.Ptr, temp.Ptr, dist);

        public int Eintersects(TCbuffer temp)
            => Meos.EintersectsGeoTcbuffer(this.Ptr, temp.Ptr);

        public int Etouches(TGeometry temp)
            => Meos.EtouchesGeoTgeo(this.Ptr, temp.Ptr);

        public int Etouches(TGeomPoint temp)
            => Meos.EtouchesGeoTpoint(this.Ptr, temp.Ptr);

        public int Etouches(TCbuffer temp)
            => Meos.EtouchesGeoTcbuffer(this.Ptr, temp.Ptr);

        public int EverEq(TRGeometry temp)
            => Meos.EverEqGeoTrgeometry(this.Ptr, temp.Ptr);

        public int EverNe(TRGeometry temp)
            => Meos.EverNeGeoTrgeometry(this.Ptr, temp.Ptr);

        public Geo? Intersection2d(Geo gs2)
            => MEOSFactory.WrapGeo(Meos.GeomIntersection2d(this.Ptr, gs2.Ptr));

        public Geo? Intersection2dColl(Geo gs2)
            => MEOSFactory.WrapGeo(Meos.GeomIntersection2dColl(this.Ptr, gs2.Ptr));

        public bool Intersects(Geo gs2)
            => Meos.GeomIntersects(this.Ptr, gs2.Ptr);

        public bool Intersects2d(Geo gs2)
            => Meos.GeomIntersects2d(this.Ptr, gs2.Ptr);

        public bool Intersects3d(Geo gs2)
            => Meos.GeomIntersects3d(this.Ptr, gs2.Ptr);

        public bool IsSimple()
            => Meos.GeomIsSimple(this.Ptr);

        public double Length()
            => Meos.GeomLength(this.Ptr);

        public double MaxDistance(Geo gs2)
            => Meos.GeomMaxDistance(this.Ptr, gs2.Ptr);

        public double MaxDistance2d(Geo gs2)
            => Meos.GeomMaxDistance2d(this.Ptr, gs2.Ptr);

        public double MaxDistance3d(Geo gs2)
            => Meos.GeomMaxDistance3d(this.Ptr, gs2.Ptr);

        public (Geo?, double) MinimumBoundingRadius()
        {
            IntPtr _radius = Marshal.AllocHGlobal(8);
            try
            {
                var _answered = Meos.GeomMinimumBoundingRadius(this.Ptr, _radius);

                return (MEOSFactory.WrapGeo(_answered), Marshal.PtrToStructure<double>(_radius));
            }
            finally
            {
                Marshal.FreeHGlobal(_radius);
            }
        }

        public Geo? OrientedEnvelope()
            => MEOSFactory.WrapGeo(Meos.GeomOrientedEnvelope(this.Ptr));

        public double Perimeter()
            => Meos.GeomPerimeter(this.Ptr);

        public string Relate(Geo gs2)
            => Meos.GeomRelate(this.Ptr, gs2.Ptr);

        public bool RelatePattern(Geo gs2, string patt)
            => Meos.GeomRelatePattern(this.Ptr, gs2.Ptr, patt);

        public Geo? Shortestline(Geo gs2)
            => MEOSFactory.WrapGeo(Meos.GeomShortestline(this.Ptr, gs2.Ptr));

        public Geo? Shortestline2d(Geo gs2)
            => MEOSFactory.WrapGeo(Meos.GeomShortestline2d(this.Ptr, gs2.Ptr));

        public Geo? Shortestline3d(Geo gs2)
            => MEOSFactory.WrapGeo(Meos.GeomShortestline3d(this.Ptr, gs2.Ptr));

        public Geo? Symdifference2d(Geo gs2)
            => MEOSFactory.WrapGeo(Meos.GeomSymdifference2d(this.Ptr, gs2.Ptr));

        public Temporal? Tcontains(TGeo temp)
            => MEOSFactory.WrapTemporal(Meos.TcontainsGeoTgeo(this.Ptr, temp.Ptr));

        public Temporal? Tcontains(TCbuffer temp)
            => MEOSFactory.WrapTemporal(Meos.TcontainsGeoTcbuffer(this.Ptr, temp.Ptr));

        public Temporal? Tcovers(TGeo temp)
            => MEOSFactory.WrapTemporal(Meos.TcoversGeoTgeo(this.Ptr, temp.Ptr));

        public Temporal? Tcovers(TCbuffer temp)
            => MEOSFactory.WrapTemporal(Meos.TcoversGeoTcbuffer(this.Ptr, temp.Ptr));

        public Temporal? Tdisjoint(TCbuffer temp)
            => MEOSFactory.WrapTemporal(Meos.TdisjointGeoTcbuffer(this.Ptr, temp.Ptr));

        public Temporal? Tdwithin(TCbuffer temp, double dist)
            => MEOSFactory.WrapTemporal(Meos.TdwithinGeoTcbuffer(this.Ptr, temp.Ptr, dist));

        public Temporal? Tdwithin(TRGeometry temp, double dist)
            => MEOSFactory.WrapTemporal(Meos.TdwithinGeoTrgeometry(this.Ptr, temp.Ptr, dist));

        public Temporal? Teq(TRGeometry temp)
            => MEOSFactory.WrapTemporal(Meos.TeqGeoTrgeometry(this.Ptr, temp.Ptr));

        public Temporal? Tintersects(TCbuffer temp)
            => MEOSFactory.WrapTemporal(Meos.TintersectsGeoTcbuffer(this.Ptr, temp.Ptr));

        public Temporal? Tne(TRGeometry temp)
            => MEOSFactory.WrapTemporal(Meos.TneGeoTrgeometry(this.Ptr, temp.Ptr));

        public Cbuffer? ToCbuffer()
            => MEOSFactory.WrapCbuffer(Meos.GeomToCbuffer(this.Ptr));

        public Geo? ToGeog()
            => MEOSFactory.WrapGeo(Meos.GeomToGeog(this.Ptr));

        public Nsegment? ToNsegment()
            => MEOSFactory.WrapNsegment(Meos.GeomToNsegment(this.Ptr));

        public bool Touches(Geo gs2)
            => Meos.GeomTouches(this.Ptr, gs2.Ptr);

        public Temporal? TposeToTrgeometry(Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.GeometryTposeToTrgeometry(this.Ptr, temp.Ptr));

        public Temporal? Ttouches(TGeo temp)
            => MEOSFactory.WrapTemporal(Meos.TtouchesGeoTgeo(this.Ptr, temp.Ptr));

        public Temporal? Ttouches(TCbuffer temp)
            => MEOSFactory.WrapTemporal(Meos.TtouchesGeoTcbuffer(this.Ptr, temp.Ptr));

        public Geo? UnaryUnion()
            => MEOSFactory.WrapGeo(Meos.GeomUnaryUnion(this.Ptr));

        public Geo? Union2d(Geo gs2)
            => MEOSFactory.WrapGeo(Meos.GeomUnion2d(this.Ptr, gs2.Ptr));

        public static Geo? ArrayUnion(Geo[] gsarr)
        {
            IntPtr[] _gsarrValues = new IntPtr[gsarr.Length];
            for (int i = 0; i < gsarr.Length; i++)
            {
                _gsarrValues[i] = gsarr[i].Ptr;
            }

            GCHandle _gsarr = GCHandle.Alloc(_gsarrValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapGeo(Meos.GeomArrayUnion(_gsarr.AddrOfPinnedObject(), gsarr.Length));
            }
            finally
            {
                _gsarr.Free();
            }
        }

        public static Geo? FromCbufferarr(Cbuffer[] cbarr)
        {
            IntPtr[] _cbarrValues = new IntPtr[cbarr.Length];
            for (int i = 0; i < cbarr.Length; i++)
            {
                _cbarrValues[i] = cbarr[i].Ptr;
            }

            GCHandle _cbarr = GCHandle.Alloc(_cbarrValues, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapGeo(Meos.CbufferarrToGeom(_cbarr.AddrOfPinnedObject(), cbarr.Length));
            }
            finally
            {
                _cbarr.Free();
            }
        }

        public static Geo? FromHexEWKB(string hexwkb)
            => MEOSFactory.WrapGeo(Meos.GeomFromHexewkb(hexwkb));

        public static Geo? FromMFJSON(string geojson)
            => Geo.FromGeoJSON(geojson);

        public static Geo? FromQuadbinCell(ulong cell)
            => MEOSFactory.WrapGeo(Meos.QuadbinCellToGeom(cell));

        public static Geo? In(string str, int typmod)
            => MEOSFactory.WrapGeo(Meos.GeomIn(str, typmod));

    }
}
