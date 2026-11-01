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

        public double Area()
            => Meos.GeomArea(this.Ptr);

        public string AsMFJSON(int option, int precision, string srs)
            => this.AsGeoJSON(option, precision, srs);

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

        public bool Dwithin(Geo gs2, double tolerance)
            => Meos.GeomDwithin(this.Ptr, gs2.Ptr, tolerance);

        public bool Dwithin2d(Geo gs2, double tolerance)
            => Meos.GeomDwithin2d(this.Ptr, gs2.Ptr, tolerance);

        public bool Dwithin3d(Geo gs2, double tolerance)
            => Meos.GeomDwithin3d(this.Ptr, gs2.Ptr, tolerance);

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

        public static Geo? FromHexEWKB(string hexwkb)
            => MEOSFactory.WrapGeo(Meos.GeomFromHexewkb(hexwkb));

        public static Geo? FromMFJSON(string geojson)
            => Geo.FromGeoJSON(geojson);

        public static Geo? In(string str, int typmod)
            => MEOSFactory.WrapGeo(Meos.GeomIn(str, typmod));

    }
}
