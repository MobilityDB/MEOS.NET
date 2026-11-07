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

        public int Adisjoint(TGeogPoint temp)
            => Meos.AdisjointGeoTgeo(this.Ptr, temp.Ptr);

        public int Adisjoint(TGeography temp)
            => Meos.AdisjointGeoTgeo(this.Ptr, temp.Ptr);

        public int Aintersects(TGeogPoint temp)
            => Meos.AintersectsGeoTgeo(this.Ptr, temp.Ptr);

        public int Aintersects(TGeography temp)
            => Meos.AintersectsGeoTgeo(this.Ptr, temp.Ptr);

        public int AlwaysEq(TGeogPoint temp)
            => Meos.AlwaysEqGeoTgeo(this.Ptr, temp.Ptr);

        public int AlwaysEq(TGeography temp)
            => Meos.AlwaysEqGeoTgeo(this.Ptr, temp.Ptr);

        public int AlwaysNe(TGeogPoint temp)
            => Meos.AlwaysNeGeoTgeo(this.Ptr, temp.Ptr);

        public int AlwaysNe(TGeography temp)
            => Meos.AlwaysNeGeoTgeo(this.Ptr, temp.Ptr);

        public new double Area(bool use_spheroid)
            => Meos.GeogArea(this.Ptr, use_spheroid);

        public string AsMFJSON(int option, int precision, string srs)
            => this.AsGeoJSON(option, precision, srs);

        public new Geo? Centroid(bool use_spheroid)
            => MEOSFactory.WrapGeo(Meos.GeogCentroid(this.Ptr, use_spheroid));

        public bool Contained(GeogSet s)
            => Meos.ContainedGeoSet(this.Ptr, s.Ptr);

        public bool Disjoint(Geo gs2, bool use_spheroid)
            => Meos.GeogDisjoint(this.Ptr, gs2.Ptr, use_spheroid);

        public new double Distance(Geo g2, bool use_spheroid)
            => Meos.GeogDistance(this.Ptr, g2.Ptr, use_spheroid);

        public bool Dwithin(Geo g2, double tolerance, bool use_spheroid)
            => Meos.GeogDwithin(this.Ptr, g2.Ptr, tolerance, use_spheroid);

        public int Edisjoint(TGeogPoint temp)
            => Meos.EdisjointGeoTgeo(this.Ptr, temp.Ptr);

        public int Edisjoint(TGeography temp)
            => Meos.EdisjointGeoTgeo(this.Ptr, temp.Ptr);

        public int Edwithin(TGeogPoint temp, double dist, bool spheroid)
            => Meos.EdwithinGeoTgeo(this.Ptr, temp.Ptr, dist, spheroid);

        public int Edwithin(TGeography temp, double dist, bool spheroid)
            => Meos.EdwithinGeoTgeo(this.Ptr, temp.Ptr, dist, spheroid);

        public int Edwithin(TPose temp, double dist, bool spheroid)
            => Meos.EdwithinGeoTgeo(this.Ptr, temp.Ptr, dist, spheroid);

        public int Edwithin(TPoseChain temp, double dist, bool spheroid)
            => Meos.EdwithinGeoTgeo(this.Ptr, temp.Ptr, dist, spheroid);

        public int Eintersects(TGeogPoint temp)
            => Meos.EintersectsGeoTgeo(this.Ptr, temp.Ptr);

        public int Eintersects(TGeography temp)
            => Meos.EintersectsGeoTgeo(this.Ptr, temp.Ptr);

        public int Eintersects(TPose temp)
            => Meos.EintersectsGeoTgeo(this.Ptr, temp.Ptr);

        public int Eintersects(TPoseChain temp)
            => Meos.EintersectsGeoTgeo(this.Ptr, temp.Ptr);

        public int EverEq(TGeogPoint temp)
            => Meos.EverEqGeoTgeo(this.Ptr, temp.Ptr);

        public int EverEq(TGeography temp)
            => Meos.EverEqGeoTgeo(this.Ptr, temp.Ptr);

        public int EverNe(TGeogPoint temp)
            => Meos.EverNeGeoTgeo(this.Ptr, temp.Ptr);

        public int EverNe(TGeography temp)
            => Meos.EverNeGeoTgeo(this.Ptr, temp.Ptr);

        public Set? Intersection(GeogSet s)
            => MEOSFactory.WrapSet(Meos.IntersectionGeoSet(this.Ptr, s.Ptr));

        public bool Intersects(Geo gs2, bool use_spheroid)
            => Meos.GeogIntersects(this.Ptr, gs2.Ptr, use_spheroid);

        public new double Length(bool use_spheroid)
            => Meos.GeogLength(this.Ptr, use_spheroid);

        public Set? Minus(GeogSet s)
            => MEOSFactory.WrapSet(Meos.MinusGeoSet(this.Ptr, s.Ptr));

        public new double Perimeter(bool use_spheroid)
            => Meos.GeogPerimeter(this.Ptr, use_spheroid);

        public new Geo? Shortestline(Geo gs2, bool use_spheroid)
            => MEOSFactory.WrapGeo(Meos.GeogShortestline(this.Ptr, gs2.Ptr, use_spheroid));

        public Temporal? Tdisjoint(TGeography temp)
            => MEOSFactory.WrapTemporal(Meos.TdisjointGeoTgeo(this.Ptr, temp.Ptr));

        public Temporal? Tdwithin(TGeogPoint temp, double dist, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.TdwithinGeoTgeo(this.Ptr, temp.Ptr, dist, spheroid));

        public Temporal? Tdwithin(TGeography temp, double dist, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.TdwithinGeoTgeo(this.Ptr, temp.Ptr, dist, spheroid));

        public Temporal? Teq(TGeogPoint temp)
            => MEOSFactory.WrapTemporal(Meos.TeqGeoTgeo(this.Ptr, temp.Ptr));

        public Temporal? Teq(TGeography temp)
            => MEOSFactory.WrapTemporal(Meos.TeqGeoTgeo(this.Ptr, temp.Ptr));

        public Temporal? Tintersects(TGeography temp)
            => MEOSFactory.WrapTemporal(Meos.TintersectsGeoTgeo(this.Ptr, temp.Ptr));

        public Temporal? Tne(TGeogPoint temp)
            => MEOSFactory.WrapTemporal(Meos.TneGeoTgeo(this.Ptr, temp.Ptr));

        public Temporal? Tne(TGeography temp)
            => MEOSFactory.WrapTemporal(Meos.TneGeoTgeo(this.Ptr, temp.Ptr));

        public Geo? ToGeom()
            => MEOSFactory.WrapGeo(Meos.GeogToGeom(this.Ptr));

        public Set? Union(GeogSet s)
            => MEOSFactory.WrapSet(Meos.UnionGeoSet(this.Ptr, s.Ptr));

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

        public static Geo? FromS2cellCell(ulong cell)
            => MEOSFactory.WrapGeo(Meos.S2cellCellToGeog(cell));

        public static Geo? In(string str, int typmod)
            => MEOSFactory.WrapGeo(Meos.GeogIn(str, typmod));

    }
}
