#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TGeometry class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TGeometry : TGeo
    {
        internal TGeometry(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public bool Above(TGeometry temp2)
            => Meos.AboveTspatialTspatial(this.Ptr, temp2.Ptr);

        public int Acontains(Geometry gs)
            => Meos.AcontainsTgeoGeo(this.Ptr, gs.Ptr);

        public int Acontains(TGeometry temp2)
            => Meos.AcontainsTgeoTgeo(this.Ptr, temp2.Ptr);

        public int Acovers(Geometry gs)
            => Meos.AcoversTgeoGeo(this.Ptr, gs.Ptr);

        public int Acovers(TGeometry temp2)
            => Meos.AcoversTgeoTgeo(this.Ptr, temp2.Ptr);

        public int Adisjoint(Geometry gs)
            => Meos.AdisjointTgeoGeo(this.Ptr, gs.Ptr);

        public int Adisjoint(TGeometry temp2)
            => Meos.AdisjointTgeoTgeo(this.Ptr, temp2.Ptr);

        public bool Adjacent(TGeometry temp2)
            => Meos.AdjacentTspatialTspatial(this.Ptr, temp2.Ptr);

        public int Adwithin(TGeometry temp2, double dist, bool spheroid)
            => Meos.AdwithinTgeoTgeo(this.Ptr, temp2.Ptr, dist, spheroid);

        public bool After(TGeometry temp2)
            => Meos.AfterTspatialTspatial(this.Ptr, temp2.Ptr);

        public int Aintersects(Geometry gs)
            => Meos.AintersectsTgeoGeo(this.Ptr, gs.Ptr);

        public int Aintersects(TGeometry temp2)
            => Meos.AintersectsTgeoTgeo(this.Ptr, temp2.Ptr);

        public int AlwaysEq(Geometry gs)
            => Meos.AlwaysEqTgeoGeo(this.Ptr, gs.Ptr);

        public int AlwaysEq(TGeometry temp2)
            => Meos.AlwaysEqTgeoTgeo(this.Ptr, temp2.Ptr);

        public int AlwaysNe(Geometry gs)
            => Meos.AlwaysNeTgeoGeo(this.Ptr, gs.Ptr);

        public int AlwaysNe(TGeometry temp2)
            => Meos.AlwaysNeTgeoTgeo(this.Ptr, temp2.Ptr);

        public int Atouches(Geometry gs)
            => Meos.AtouchesTgeoGeo(this.Ptr, gs.Ptr);

        public int Atouches(TGeometry temp2)
            => Meos.AtouchesTgeoTgeo(this.Ptr, temp2.Ptr);

        public bool Back(TGeometry temp2)
            => Meos.BackTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Before(TGeometry temp2)
            => Meos.BeforeTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Below(TGeometry temp2)
            => Meos.BelowTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Contained(TGeometry temp2)
            => Meos.ContainedTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Contains(TGeometry temp2)
            => Meos.ContainsTspatialTspatial(this.Ptr, temp2.Ptr);

        public int Econtains(Geometry gs)
            => Meos.EcontainsTgeoGeo(this.Ptr, gs.Ptr);

        public int Econtains(TGeometry temp2)
            => Meos.EcontainsTgeoTgeo(this.Ptr, temp2.Ptr);

        public int Ecovers(Geometry gs)
            => Meos.EcoversTgeoGeo(this.Ptr, gs.Ptr);

        public int Ecovers(TGeometry temp2)
            => Meos.EcoversTgeoTgeo(this.Ptr, temp2.Ptr);

        public int Edisjoint(Geometry gs)
            => Meos.EdisjointTgeoGeo(this.Ptr, gs.Ptr);

        public int Edisjoint(TGeometry temp2)
            => Meos.EdisjointTgeoTgeo(this.Ptr, temp2.Ptr);

        public int Edwithin(Geometry gs, double dist, bool spheroid)
            => Meos.EdwithinTgeoGeo(this.Ptr, gs.Ptr, dist, spheroid);

        public int Edwithin(TGeometry temp2, double dist, bool spheroid)
            => Meos.EdwithinTgeoTgeo(this.Ptr, temp2.Ptr, dist, spheroid);

        public int Eintersects(Geometry gs)
            => Meos.EintersectsTgeoGeo(this.Ptr, gs.Ptr);

        public int Eintersects(TGeometry temp2)
            => Meos.EintersectsTgeoTgeo(this.Ptr, temp2.Ptr);

        public int Etouches(Geometry gs)
            => Meos.EtouchesTgeoGeo(this.Ptr, gs.Ptr);

        public int Etouches(TGeometry temp2)
            => Meos.EtouchesTgeoTgeo(this.Ptr, temp2.Ptr);

        public int EverEq(Geometry gs)
            => Meos.EverEqTgeoGeo(this.Ptr, gs.Ptr);

        public int EverEq(TGeometry temp2)
            => Meos.EverEqTgeoTgeo(this.Ptr, temp2.Ptr);

        public int EverNe(Geometry gs)
            => Meos.EverNeTgeoGeo(this.Ptr, gs.Ptr);

        public int EverNe(TGeometry temp2)
            => Meos.EverNeTgeoTgeo(this.Ptr, temp2.Ptr);

        public bool Front(TGeometry temp2)
            => Meos.FrontTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Left(TGeometry temp2)
            => Meos.LeftTspatialTspatial(this.Ptr, temp2.Ptr);

        public double Nad(Geometry gs, bool spheroid)
            => Meos.NadTgeoGeo(this.Ptr, gs.Ptr, spheroid);

        public double Nad(TGeometry temp2, bool spheroid)
            => Meos.NadTgeoTgeo(this.Ptr, temp2.Ptr, spheroid);

        public Temporal? Nai(Geometry gs, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.NaiTgeoGeo(this.Ptr, gs.Ptr, spheroid));

        public Temporal? Nai(TGeometry temp2, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.NaiTgeoTgeo(this.Ptr, temp2.Ptr, spheroid));

        public bool Overabove(TGeometry temp2)
            => Meos.OveraboveTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overafter(TGeometry temp2)
            => Meos.OverafterTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overback(TGeometry temp2)
            => Meos.OverbackTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overbefore(TGeometry temp2)
            => Meos.OverbeforeTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overbelow(TGeometry temp2)
            => Meos.OverbelowTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overfront(TGeometry temp2)
            => Meos.OverfrontTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overlaps(TGeometry temp2)
            => Meos.OverlapsTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overleft(TGeometry temp2)
            => Meos.OverleftTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overright(TGeometry temp2)
            => Meos.OverrightTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Right(TGeometry temp2)
            => Meos.RightTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Same(TGeometry temp2)
            => Meos.SameTspatialTspatial(this.Ptr, temp2.Ptr);

        public Geo? Shortestline(Geometry gs, bool spheroid)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTgeoGeo(this.Ptr, gs.Ptr, spheroid));

        public Geo? Shortestline(TGeometry temp2, bool spheroid)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTgeoTgeo(this.Ptr, temp2.Ptr, spheroid));

        public Temporal? Tcontains(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TcontainsTgeoGeo(this.Ptr, gs.Ptr));

        public Temporal? Tcontains(TGeometry temp2)
            => MEOSFactory.WrapTemporal(Meos.TcontainsTgeoTgeo(this.Ptr, temp2.Ptr));

        public Temporal? Tcovers(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TcoversTgeoGeo(this.Ptr, gs.Ptr));

        public Temporal? Tcovers(TGeometry temp2)
            => MEOSFactory.WrapTemporal(Meos.TcoversTgeoTgeo(this.Ptr, temp2.Ptr));

        public Temporal? Tdisjoint(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TdisjointTgeoGeo(this.Ptr, gs.Ptr));

        public Temporal? Tdisjoint(TGeometry temp2)
            => MEOSFactory.WrapTemporal(Meos.TdisjointTgeoTgeo(this.Ptr, temp2.Ptr));

        public Temporal? Tdistance(Geometry gs, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTgeoGeo(this.Ptr, gs.Ptr, spheroid));

        public Temporal? Tdistance(TGeometry temp2, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTgeoTgeo(this.Ptr, temp2.Ptr, spheroid));

        public Temporal? Tdwithin(Geometry gs, double dist, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.TdwithinTgeoGeo(this.Ptr, gs.Ptr, dist, spheroid));

        public Temporal? Tdwithin(TGeometry temp2, double dist, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.TdwithinTgeoTgeo(this.Ptr, temp2.Ptr, dist, spheroid));

        public Temporal? Teq(TGeometry temp2)
            => MEOSFactory.WrapTemporal(Meos.TeqTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? Teq(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TeqTgeoGeo(this.Ptr, gs.Ptr));

        public Temporal? Tintersects(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TintersectsTgeoGeo(this.Ptr, gs.Ptr));

        public Temporal? Tintersects(TGeometry temp2)
            => MEOSFactory.WrapTemporal(Meos.TintersectsTgeoTgeo(this.Ptr, temp2.Ptr));

        public Temporal? Tne(TGeometry temp2)
            => MEOSFactory.WrapTemporal(Meos.TneTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? Tne(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TneTgeoGeo(this.Ptr, gs.Ptr));

        public Temporal? ToTcbuffer()
            => MEOSFactory.WrapTemporal(Meos.TgeometryToTcbuffer(this.Ptr));

        public Temporal? ToTgeography()
            => MEOSFactory.WrapTemporal(Meos.TgeometryToTgeography(this.Ptr));

        public Temporal? ToTgeompoint()
            => MEOSFactory.WrapTemporal(Meos.TgeometryToTgeompoint(this.Ptr));

        public Temporal? Ttouches(TGeometry temp2)
            => MEOSFactory.WrapTemporal(Meos.TtouchesTgeoTgeo(this.Ptr, temp2.Ptr));

        public static Temporal? FromEWKB(byte[] wkb)
            => Temporal.FromWKB(wkb);

        public static Temporal? FromEWKT(string str)
            => TGeometry.In(str);

        public static Temporal? FromHexEWKB(string hexwkb)
            => Temporal.FromHexWKB(hexwkb);

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(Meos.TgeometryFromMfjson(str));

        public static Temporal? FromText(string str)
            => TGeometry.In(str);

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TgeometryIn(str));

    }
}
