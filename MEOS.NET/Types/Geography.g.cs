#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The Geography class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class Geography : Geo
    {
        internal Geography(IntPtr ptr) : base(ptr) { }

        public new double Area(bool use_spheroid)
            => Meos.GeogArea(this.Ptr, use_spheroid);

        public string AsMFJSON(int option, int precision, string srs)
            => this.AsGeoJSON(option, precision, srs);

        public new Geo? Centroid(bool use_spheroid)
            => MEOSFactory.WrapGeo(Meos.GeogCentroid(this.Ptr, use_spheroid));

        public bool Disjoint(Geo gs2, bool use_spheroid)
            => Meos.GeogDisjoint(this.Ptr, gs2.Ptr, use_spheroid);

        public new double Distance(Geo g2, bool use_spheroid)
            => Meos.GeogDistance(this.Ptr, g2.Ptr, use_spheroid);

        public bool Dwithin(Geo g2, double tolerance, bool use_spheroid)
            => Meos.GeogDwithin(this.Ptr, g2.Ptr, tolerance, use_spheroid);

        public bool Intersects(Geo gs2, bool use_spheroid)
            => Meos.GeogIntersects(this.Ptr, gs2.Ptr, use_spheroid);

        public new double Length(bool use_spheroid)
            => Meos.GeogLength(this.Ptr, use_spheroid);

        public new double Perimeter(bool use_spheroid)
            => Meos.GeogPerimeter(this.Ptr, use_spheroid);

        public new Geo? Shortestline(Geo gs2, bool use_spheroid)
            => MEOSFactory.WrapGeo(Meos.GeogShortestline(this.Ptr, gs2.Ptr, use_spheroid));

        public Geo? ToGeom()
            => MEOSFactory.WrapGeo(Meos.GeogToGeom(this.Ptr));

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
                return MEOSFactory.WrapGeo(Meos.GeogArrayUnion(_gsarr.AddrOfPinnedObject(), gsarr.Length));
            }
            finally
            {
                _gsarr.Free();
            }
        }

        public static Geo? FromHexEWKB(string hexwkb)
            => MEOSFactory.WrapGeo(Meos.GeogFromHexewkb(hexwkb));

        public static Geo? FromMFJSON(string geojson)
            => Geo.FromGeoJSON(geojson);

        public static Geo? In(string str, int typmod)
            => MEOSFactory.WrapGeo(Meos.GeogIn(str, typmod));

    }
}
