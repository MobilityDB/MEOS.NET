#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TGeomPoint class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TGeomPoint : TPoint
    {
        internal TGeomPoint(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public bool Above(TGeomPoint temp2)
            => Meos.AboveTspatialTspatial(this.Ptr, temp2.Ptr);

        public int Adisjoint(Geometry gs)
            => Meos.AdisjointTgeoGeo(this.Ptr, gs.Ptr);

        public int Adisjoint(TGeomPoint temp2)
            => Meos.AdisjointTgeoTgeo(this.Ptr, temp2.Ptr);

        public bool Adjacent(TGeomPoint temp2)
            => Meos.AdjacentTspatialTspatial(this.Ptr, temp2.Ptr);

        public int Adwithin(Geometry gs, double dist, bool spheroid)
            => Meos.AdwithinTgeoGeo(this.Ptr, gs.Ptr, dist, spheroid);

        public int Adwithin(TGeomPoint temp2, double dist, bool spheroid)
            => Meos.AdwithinTgeoTgeo(this.Ptr, temp2.Ptr, dist, spheroid);

        public bool After(TGeomPoint temp2)
            => Meos.AfterTspatialTspatial(this.Ptr, temp2.Ptr);

        public int Aintersects(Geometry gs)
            => Meos.AintersectsTgeoGeo(this.Ptr, gs.Ptr);

        public int Aintersects(TGeomPoint temp2)
            => Meos.AintersectsTgeoTgeo(this.Ptr, temp2.Ptr);

        public int AlwaysEq(Geometry gs)
            => Meos.AlwaysEqTgeoGeo(this.Ptr, gs.Ptr);

        public int AlwaysEq(TGeomPoint temp2)
            => Meos.AlwaysEqTgeoTgeo(this.Ptr, temp2.Ptr);

        public int AlwaysNe(Geometry gs)
            => Meos.AlwaysNeTgeoGeo(this.Ptr, gs.Ptr);

        public int AlwaysNe(TGeomPoint temp2)
            => Meos.AlwaysNeTgeoTgeo(this.Ptr, temp2.Ptr);

        public int Atouches(Geometry gs)
            => Meos.AtouchesTpointGeo(this.Ptr, gs.Ptr);

        public bool Back(TGeomPoint temp2)
            => Meos.BackTspatialTspatial(this.Ptr, temp2.Ptr);

        public Temporal? Bearing(TGeomPoint temp2)
            => MEOSFactory.WrapTemporal(Meos.BearingTpointTpoint(this.Ptr, temp2.Ptr));

        public Temporal? Bearing(Geometry gs, bool invert)
            => MEOSFactory.WrapTemporal(Meos.BearingTpointPoint(this.Ptr, gs.Ptr, invert));

        public bool Before(TGeomPoint temp2)
            => Meos.BeforeTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Below(TGeomPoint temp2)
            => Meos.BelowTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Contained(TGeomPoint temp2)
            => Meos.ContainedTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Contains(TGeomPoint temp2)
            => Meos.ContainsTspatialTspatial(this.Ptr, temp2.Ptr);

        public int Edisjoint(Geometry gs)
            => Meos.EdisjointTgeoGeo(this.Ptr, gs.Ptr);

        public int Edisjoint(TGeomPoint temp2)
            => Meos.EdisjointTgeoTgeo(this.Ptr, temp2.Ptr);

        public int Edwithin(Geometry gs, double dist, bool spheroid)
            => Meos.EdwithinTgeoGeo(this.Ptr, gs.Ptr, dist, spheroid);

        public int Edwithin(TGeomPoint temp2, double dist, bool spheroid)
            => Meos.EdwithinTgeoTgeo(this.Ptr, temp2.Ptr, dist, spheroid);

        public int Eintersects(Geometry gs)
            => Meos.EintersectsTgeoGeo(this.Ptr, gs.Ptr);

        public int Eintersects(TGeomPoint temp2)
            => Meos.EintersectsTgeoTgeo(this.Ptr, temp2.Ptr);

        public int Etouches(Geometry gs)
            => Meos.EtouchesTpointGeo(this.Ptr, gs.Ptr);

        public int EverEq(Geometry gs)
            => Meos.EverEqTgeoGeo(this.Ptr, gs.Ptr);

        public int EverEq(TGeomPoint temp2)
            => Meos.EverEqTgeoTgeo(this.Ptr, temp2.Ptr);

        public int EverNe(Geometry gs)
            => Meos.EverNeTgeoGeo(this.Ptr, gs.Ptr);

        public int EverNe(TGeomPoint temp2)
            => Meos.EverNeTgeoTgeo(this.Ptr, temp2.Ptr);

        public bool Front(TGeomPoint temp2)
            => Meos.FrontTspatialTspatial(this.Ptr, temp2.Ptr);

        public (Temporal?[], ulong[]) H3indexSplit(int resolution, bool border_inc)
        {
            var _answered = Meos.TgeompointH3indexSplit(this.Ptr, resolution, border_inc);

            return (MEOSFactory.WrapTemporalArray(_answered.Item1), _answered.Item2);
        }

        public bool Left(TGeomPoint temp2)
            => Meos.LeftTspatialTspatial(this.Ptr, temp2.Ptr);

        public double Nad(Geometry gs, bool spheroid)
            => Meos.NadTgeoGeo(this.Ptr, gs.Ptr, spheroid);

        public double Nad(TGeomPoint temp2, bool spheroid)
            => Meos.NadTgeoTgeo(this.Ptr, temp2.Ptr, spheroid);

        public Temporal? Nai(Geometry gs, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.NaiTgeoGeo(this.Ptr, gs.Ptr, spheroid));

        public Temporal? Nai(TGeomPoint temp2, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.NaiTgeoTgeo(this.Ptr, temp2.Ptr, spheroid));

        public bool Overabove(TGeomPoint temp2)
            => Meos.OveraboveTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overafter(TGeomPoint temp2)
            => Meos.OverafterTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overback(TGeomPoint temp2)
            => Meos.OverbackTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overbefore(TGeomPoint temp2)
            => Meos.OverbeforeTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overbelow(TGeomPoint temp2)
            => Meos.OverbelowTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overfront(TGeomPoint temp2)
            => Meos.OverfrontTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overlaps(TGeomPoint temp2)
            => Meos.OverlapsTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overleft(TGeomPoint temp2)
            => Meos.OverleftTspatialTspatial(this.Ptr, temp2.Ptr);

        public bool Overright(TGeomPoint temp2)
            => Meos.OverrightTspatialTspatial(this.Ptr, temp2.Ptr);

        public (Temporal?[], ulong[]) QuadbinSplit(int resolution, bool border_inc)
        {
            var _answered = Meos.TgeompointQuadbinSplit(this.Ptr, resolution, border_inc);

            return (MEOSFactory.WrapTemporalArray(_answered.Item1), _answered.Item2);
        }

        public bool Right(TGeomPoint temp2)
            => Meos.RightTspatialTspatial(this.Ptr, temp2.Ptr);

        public (Temporal?[], ulong[]) S2cellSplit(int level, bool border_inc)
        {
            var _answered = Meos.TgeompointS2cellSplit(this.Ptr, level, border_inc);

            return (MEOSFactory.WrapTemporalArray(_answered.Item1), _answered.Item2);
        }

        public bool Same(TGeomPoint temp2)
            => Meos.SameTspatialTspatial(this.Ptr, temp2.Ptr);

        public Geo? Shortestline(Geometry gs, bool spheroid)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTgeoGeo(this.Ptr, gs.Ptr, spheroid));

        public Geo? Shortestline(TGeomPoint temp2, bool spheroid)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTgeoTgeo(this.Ptr, temp2.Ptr, spheroid));

        public Temporal? Tdisjoint(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TdisjointTgeoGeo(this.Ptr, gs.Ptr));

        public Temporal? Tdisjoint(TGeomPoint temp2)
            => MEOSFactory.WrapTemporal(Meos.TdisjointTgeoTgeo(this.Ptr, temp2.Ptr));

        public Temporal? Tdistance(Geometry gs, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTgeoGeo(this.Ptr, gs.Ptr, spheroid));

        public Temporal? Tdistance(TGeomPoint temp2, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTgeoTgeo(this.Ptr, temp2.Ptr, spheroid));

        public Temporal? Tdwithin(Geometry gs, double dist, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.TdwithinTgeoGeo(this.Ptr, gs.Ptr, dist, spheroid));

        public Temporal? Tdwithin(TGeomPoint temp2, double dist, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.TdwithinTgeoTgeo(this.Ptr, temp2.Ptr, dist, spheroid));

        public Temporal? Teq(TGeomPoint temp2)
            => MEOSFactory.WrapTemporal(Meos.TeqTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? Teq(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TeqTgeoGeo(this.Ptr, gs.Ptr));

        public Temporal? Tintersects(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TintersectsTgeoGeo(this.Ptr, gs.Ptr));

        public Temporal? Tintersects(TGeomPoint temp2)
            => MEOSFactory.WrapTemporal(Meos.TintersectsTgeoTgeo(this.Ptr, temp2.Ptr));

        public Temporal? Tne(TGeomPoint temp2)
            => MEOSFactory.WrapTemporal(Meos.TneTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? Tne(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TneTgeoGeo(this.Ptr, gs.Ptr));

        public Temporal? ToTgeogpoint()
            => MEOSFactory.WrapTemporal(Meos.TgeompointToTgeogpoint(this.Ptr));

        public Temporal? ToTgeometry()
            => MEOSFactory.WrapTemporal(Meos.TgeompointToTgeometry(this.Ptr));

        public Temporal? ToTh3index(int resolution, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TgeompointToTh3index(this.Ptr, resolution, border_inc));

        public Temporal? ToTnpoint()
            => MEOSFactory.WrapTemporal(Meos.TgeompointToTnpoint(this.Ptr));

        public Temporal? ToTquadbin(int resolution, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TgeompointToTquadbin(this.Ptr, resolution, border_inc));

        public Temporal? ToTs2cell(int level, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TgeompointToTs2cell(this.Ptr, level, border_inc));

        public static Temporal? FromEWKB(byte[] wkb)
            => Temporal.FromWKB(wkb);

        public static Temporal? FromEWKT(string str)
            => TGeomPoint.In(str);

        public static Temporal? FromHexEWKB(string hexwkb)
            => Temporal.FromHexWKB(hexwkb);

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(Meos.TgeompointFromMfjson(str));

        public static Temporal? FromText(string str)
            => TGeomPoint.In(str);

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TgeompointIn(str));

    }
}
