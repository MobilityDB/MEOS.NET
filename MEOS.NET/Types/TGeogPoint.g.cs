#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TGeogPoint class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TGeogPoint : TPoint
    {
        internal TGeogPoint(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public int Adisjoint(Geography gs)
            => Meos.AdisjointTgeoGeo(this.Ptr, gs.Ptr);

        public int Adisjoint(TGeogPoint temp2)
            => Meos.AdisjointTgeoTgeo(this.Ptr, temp2.Ptr);

        public bool Adjacent(TGeogPoint temp2)
            => Meos.AdjacentTspatialTspatial(this.Ptr, temp2.Ptr);

        public int Adwithin(Geography gs, double dist, bool spheroid)
            => Meos.AdwithinTgeoGeo(this.Ptr, gs.Ptr, dist, spheroid);

        public int Adwithin(TGeogPoint temp2, double dist, bool spheroid)
            => Meos.AdwithinTgeoTgeo(this.Ptr, temp2.Ptr, dist, spheroid);

        public bool After(TGeogPoint temp2)
            => Meos.AfterTspatialTspatial(this.Ptr, temp2.Ptr);

        public int Aintersects(Geography gs)
            => Meos.AintersectsTgeoGeo(this.Ptr, gs.Ptr);

        public int Aintersects(TGeogPoint temp2)
            => Meos.AintersectsTgeoTgeo(this.Ptr, temp2.Ptr);

        public int AlwaysEq(Geography gs)
            => Meos.AlwaysEqTgeoGeo(this.Ptr, gs.Ptr);

        public int AlwaysEq(TGeogPoint temp2)
            => Meos.AlwaysEqTgeoTgeo(this.Ptr, temp2.Ptr);

        public int AlwaysNe(Geography gs)
            => Meos.AlwaysNeTgeoGeo(this.Ptr, gs.Ptr);

        public int AlwaysNe(TGeogPoint temp2)
            => Meos.AlwaysNeTgeoTgeo(this.Ptr, temp2.Ptr);

        public Temporal? Bearing(Geography gs, bool invert)
            => MEOSFactory.WrapTemporal(Meos.BearingTpointPoint(this.Ptr, gs.Ptr, invert));

        public bool Before(TGeogPoint temp2)
            => Meos.BeforeTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Contained(TGeogPoint temp2)
            => Meos.ContainedTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Contains(TGeogPoint temp2)
            => Meos.ContainsTspatialTspatial(this.Ptr, temp2.Ptr);

        public int Edisjoint(Geography gs)
            => Meos.EdisjointTgeoGeo(this.Ptr, gs.Ptr);

        public int Edisjoint(TGeogPoint temp2)
            => Meos.EdisjointTgeoTgeo(this.Ptr, temp2.Ptr);

        public int Edwithin(Geography gs, double dist, bool spheroid)
            => Meos.EdwithinTgeoGeo(this.Ptr, gs.Ptr, dist, spheroid);

        public int Edwithin(TGeogPoint temp2, double dist, bool spheroid)
            => Meos.EdwithinTgeoTgeo(this.Ptr, temp2.Ptr, dist, spheroid);

        public int Eintersects(Geography gs)
            => Meos.EintersectsTgeoGeo(this.Ptr, gs.Ptr);

        public int Eintersects(TGeogPoint temp2)
            => Meos.EintersectsTgeoTgeo(this.Ptr, temp2.Ptr);

        public int EverEq(Geography gs)
            => Meos.EverEqTgeoGeo(this.Ptr, gs.Ptr);

        public int EverEq(TGeogPoint temp2)
            => Meos.EverEqTgeoTgeo(this.Ptr, temp2.Ptr);

        public int EverNe(Geography gs)
            => Meos.EverNeTgeoGeo(this.Ptr, gs.Ptr);

        public int EverNe(TGeogPoint temp2)
            => Meos.EverNeTgeoTgeo(this.Ptr, temp2.Ptr);

        public Temporal? GreatCircleDistance(Temporal b)
            => MEOSFactory.WrapTemporal(Meos.TgeogpointGreatCircleDistance(this.Ptr, b.Ptr));

        public (Temporal?[], ulong[]) H3indexSplit(int resolution, bool border_inc)
        {
            var _answered = Meos.TgeogpointH3indexSplit(this.Ptr, resolution, border_inc);

            return (MEOSFactory.WrapTemporalArray(_answered.Item1), _answered.Item2);
        }

        public double Nad(Geography gs, bool spheroid)
            => Meos.NadTgeoGeo(this.Ptr, gs.Ptr, spheroid);

        public double Nad(TGeogPoint temp2, bool spheroid)
            => Meos.NadTgeoTgeo(this.Ptr, temp2.Ptr, spheroid);

        public Temporal? Nai(Geography gs, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.NaiTgeoGeo(this.Ptr, gs.Ptr, spheroid));

        public Temporal? Nai(TGeogPoint temp2, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.NaiTgeoTgeo(this.Ptr, temp2.Ptr, spheroid));

        public bool Overafter(TGeogPoint temp2)
            => Meos.OverafterTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overbefore(TGeogPoint temp2)
            => Meos.OverbeforeTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overlaps(TGeogPoint temp2)
            => Meos.OverlapsTspatialTspatial(this.Ptr, temp2.Ptr);

        public (Temporal?[], ulong[]) QuadbinSplit(int resolution, bool border_inc)
        {
            var _answered = Meos.TgeogpointQuadbinSplit(this.Ptr, resolution, border_inc);

            return (MEOSFactory.WrapTemporalArray(_answered.Item1), _answered.Item2);
        }

        public (Temporal?[], ulong[]) S2cellSplit(int level, bool border_inc)
        {
            var _answered = Meos.TgeogpointS2cellSplit(this.Ptr, level, border_inc);

            return (MEOSFactory.WrapTemporalArray(_answered.Item1), _answered.Item2);
        }

        public bool Same(TGeogPoint temp2)
            => Meos.SameTspatialTspatial(this.Ptr, temp2.Ptr);

        public Geo? Shortestline(Geography gs, bool spheroid)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTgeoGeo(this.Ptr, gs.Ptr, spheroid));

        public Geo? Shortestline(TGeogPoint temp2, bool spheroid)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTgeoTgeo(this.Ptr, temp2.Ptr, spheroid));

        public Temporal? Tdisjoint(Geography gs)
            => MEOSFactory.WrapTemporal(Meos.TdisjointTgeoGeo(this.Ptr, gs.Ptr));

        public Temporal? Tdisjoint(TGeogPoint temp2)
            => MEOSFactory.WrapTemporal(Meos.TdisjointTgeoTgeo(this.Ptr, temp2.Ptr));

        public Temporal? Tdistance(Geography gs, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTgeoGeo(this.Ptr, gs.Ptr, spheroid));

        public Temporal? Tdistance(TGeogPoint temp2, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTgeoTgeo(this.Ptr, temp2.Ptr, spheroid));

        public Temporal? Tdwithin(Geography gs, double dist, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.TdwithinTgeoGeo(this.Ptr, gs.Ptr, dist, spheroid));

        public Temporal? Tdwithin(TGeogPoint temp2, double dist, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.TdwithinTgeoTgeo(this.Ptr, temp2.Ptr, dist, spheroid));

        public Temporal? Teq(TGeogPoint temp2)
            => MEOSFactory.WrapTemporal(Meos.TeqTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? Teq(Geography gs)
            => MEOSFactory.WrapTemporal(Meos.TeqTgeoGeo(this.Ptr, gs.Ptr));

        public Temporal? Tintersects(Geography gs)
            => MEOSFactory.WrapTemporal(Meos.TintersectsTgeoGeo(this.Ptr, gs.Ptr));

        public Temporal? Tintersects(TGeogPoint temp2)
            => MEOSFactory.WrapTemporal(Meos.TintersectsTgeoTgeo(this.Ptr, temp2.Ptr));

        public Temporal? Tne(TGeogPoint temp2)
            => MEOSFactory.WrapTemporal(Meos.TneTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? Tne(Geography gs)
            => MEOSFactory.WrapTemporal(Meos.TneTgeoGeo(this.Ptr, gs.Ptr));

        public Temporal? ToTgeography()
            => MEOSFactory.WrapTemporal(Meos.TgeogpointToTgeography(this.Ptr));

        public Temporal? ToTgeompoint()
            => MEOSFactory.WrapTemporal(Meos.TgeogpointToTgeompoint(this.Ptr));

        public Temporal? ToTh3index(int resolution, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TgeogpointToTh3index(this.Ptr, resolution, border_inc));

        public Temporal? ToTquadbin(int resolution, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TgeogpointToTquadbin(this.Ptr, resolution, border_inc));

        public Temporal? ToTs2cell(int level, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TgeogpointToTs2cell(this.Ptr, level, border_inc));

        public static Temporal? FromEWKB(byte[] wkb)
            => Temporal.FromWKB(wkb);

        public static Temporal? FromEWKT(string str)
            => TGeogPoint.In(str);

        public static Temporal? FromHexEWKB(string hexwkb)
            => Temporal.FromHexWKB(hexwkb);

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(Meos.TgeogpointFromMfjson(str));

        public static Temporal? FromText(string str)
            => TGeogPoint.In(str);

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TgeogpointIn(str));

    }
}
