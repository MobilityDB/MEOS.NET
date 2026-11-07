#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TGeography class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TGeography : TGeo
    {
        internal TGeography(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public int Adisjoint(Geography gs)
            => Meos.AdisjointTgeoGeo(this.Ptr, gs.Ptr);

        public int Adisjoint(TGeography temp2)
            => Meos.AdisjointTgeoTgeo(this.Ptr, temp2.Ptr);

        public bool Adjacent(TGeography temp2)
            => Meos.AdjacentTspatialTspatial(this.Ptr, temp2.Ptr);

        public int Adwithin(TGeography temp2, double dist, bool spheroid)
            => Meos.AdwithinTgeoTgeo(this.Ptr, temp2.Ptr, dist, spheroid);

        public bool After(TGeography temp2)
            => Meos.AfterTspatialTspatial(this.Ptr, temp2.Ptr);

        public int Aintersects(Geography gs)
            => Meos.AintersectsTgeoGeo(this.Ptr, gs.Ptr);

        public int Aintersects(TGeography temp2)
            => Meos.AintersectsTgeoTgeo(this.Ptr, temp2.Ptr);

        public int AlwaysEq(Geography gs)
            => Meos.AlwaysEqTgeoGeo(this.Ptr, gs.Ptr);

        public int AlwaysEq(TGeography temp2)
            => Meos.AlwaysEqTgeoTgeo(this.Ptr, temp2.Ptr);

        public int AlwaysNe(Geography gs)
            => Meos.AlwaysNeTgeoGeo(this.Ptr, gs.Ptr);

        public int AlwaysNe(TGeography temp2)
            => Meos.AlwaysNeTgeoTgeo(this.Ptr, temp2.Ptr);

        public bool Before(TGeography temp2)
            => Meos.BeforeTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Contained(TGeography temp2)
            => Meos.ContainedTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Contains(TGeography temp2)
            => Meos.ContainsTspatialTspatial(this.Ptr, temp2.Ptr);

        public int Edisjoint(Geography gs)
            => Meos.EdisjointTgeoGeo(this.Ptr, gs.Ptr);

        public int Edisjoint(TGeography temp2)
            => Meos.EdisjointTgeoTgeo(this.Ptr, temp2.Ptr);

        public int Edwithin(Geography gs, double dist, bool spheroid)
            => Meos.EdwithinTgeoGeo(this.Ptr, gs.Ptr, dist, spheroid);

        public int Edwithin(TGeography temp2, double dist, bool spheroid)
            => Meos.EdwithinTgeoTgeo(this.Ptr, temp2.Ptr, dist, spheroid);

        public int Eintersects(Geography gs)
            => Meos.EintersectsTgeoGeo(this.Ptr, gs.Ptr);

        public int Eintersects(TGeography temp2)
            => Meos.EintersectsTgeoTgeo(this.Ptr, temp2.Ptr);

        public int EverEq(Geography gs)
            => Meos.EverEqTgeoGeo(this.Ptr, gs.Ptr);

        public int EverEq(TGeography temp2)
            => Meos.EverEqTgeoTgeo(this.Ptr, temp2.Ptr);

        public int EverNe(Geography gs)
            => Meos.EverNeTgeoGeo(this.Ptr, gs.Ptr);

        public int EverNe(TGeography temp2)
            => Meos.EverNeTgeoTgeo(this.Ptr, temp2.Ptr);

        public double Nad(Geography gs, bool spheroid)
            => Meos.NadTgeoGeo(this.Ptr, gs.Ptr, spheroid);

        public double Nad(TGeography temp2, bool spheroid)
            => Meos.NadTgeoTgeo(this.Ptr, temp2.Ptr, spheroid);

        public Temporal? Nai(Geography gs, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.NaiTgeoGeo(this.Ptr, gs.Ptr, spheroid));

        public Temporal? Nai(TGeography temp2, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.NaiTgeoTgeo(this.Ptr, temp2.Ptr, spheroid));

        public bool Overafter(TGeography temp2)
            => Meos.OverafterTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overbefore(TGeography temp2)
            => Meos.OverbeforeTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overlaps(TGeography temp2)
            => Meos.OverlapsTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Same(TGeography temp2)
            => Meos.SameTspatialTspatial(this.Ptr, temp2.Ptr);

        public Geo? Shortestline(Geography gs, bool spheroid)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTgeoGeo(this.Ptr, gs.Ptr, spheroid));

        public Geo? Shortestline(TGeography temp2, bool spheroid)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTgeoTgeo(this.Ptr, temp2.Ptr, spheroid));

        public Temporal? Tdisjoint(Geography gs)
            => MEOSFactory.WrapTemporal(Meos.TdisjointTgeoGeo(this.Ptr, gs.Ptr));

        public Temporal? Tdisjoint(TGeography temp2)
            => MEOSFactory.WrapTemporal(Meos.TdisjointTgeoTgeo(this.Ptr, temp2.Ptr));

        public Temporal? Tdistance(Geography gs, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTgeoGeo(this.Ptr, gs.Ptr, spheroid));

        public Temporal? Tdistance(TGeography temp2, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTgeoTgeo(this.Ptr, temp2.Ptr, spheroid));

        public Temporal? Tdwithin(Geography gs, double dist, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.TdwithinTgeoGeo(this.Ptr, gs.Ptr, dist, spheroid));

        public Temporal? Tdwithin(TGeography temp2, double dist, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.TdwithinTgeoTgeo(this.Ptr, temp2.Ptr, dist, spheroid));

        public Temporal? Teq(TGeography temp2)
            => MEOSFactory.WrapTemporal(Meos.TeqTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? Teq(Geography gs)
            => MEOSFactory.WrapTemporal(Meos.TeqTgeoGeo(this.Ptr, gs.Ptr));

        public Temporal? Tintersects(Geography gs)
            => MEOSFactory.WrapTemporal(Meos.TintersectsTgeoGeo(this.Ptr, gs.Ptr));

        public Temporal? Tintersects(TGeography temp2)
            => MEOSFactory.WrapTemporal(Meos.TintersectsTgeoTgeo(this.Ptr, temp2.Ptr));

        public Temporal? Tne(TGeography temp2)
            => MEOSFactory.WrapTemporal(Meos.TneTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? Tne(Geography gs)
            => MEOSFactory.WrapTemporal(Meos.TneTgeoGeo(this.Ptr, gs.Ptr));

        public Temporal? ToTgeogpoint()
            => MEOSFactory.WrapTemporal(Meos.TgeographyToTgeogpoint(this.Ptr));

        public Temporal? ToTgeometry()
            => MEOSFactory.WrapTemporal(Meos.TgeographyToTgeometry(this.Ptr));

        public static Temporal? FromEWKB(byte[] wkb)
            => Temporal.FromWKB(wkb);

        public static Temporal? FromEWKT(string str)
            => TGeography.In(str);

        public static Temporal? FromHexEWKB(string hexwkb)
            => Temporal.FromHexWKB(hexwkb);

        public static Temporal? FromMFJSON(string mfjson)
            => MEOSFactory.WrapTemporal(Meos.TgeographyFromMfjson(mfjson));

        public static Temporal? FromText(string str)
            => TGeography.In(str);

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TgeographyIn(str));

    }
}
