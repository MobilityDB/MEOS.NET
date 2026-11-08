#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>All PostGIS-derived spatiotemporal types (geometry/geography-based). Authoritative parent per MobilityDB manual Ch.7 Figure 7.1 (= the broad C predicate tgeo_type_all). NOTE: the narrower C predicate tgeo_type() and most tgeo_* functions reject points — class membership (manual) is broader than tgeo_* API applicability; see correction OM-M1.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TGeo : TSpatial
    {
        internal TGeo(IntPtr ptr) : base(ptr) { }

        public int Adisjoint(Geo gs)
            => Meos.AdisjointTgeoGeo(this.Ptr, gs.Ptr);

        public int Adisjoint(TGeo temp2)
            => Meos.AdisjointTgeoTgeo(this.Ptr, temp2.Ptr);

        public int Adwithin(Geo gs, double dist, bool spheroid)
            => Meos.AdwithinTgeoGeo(this.Ptr, gs.Ptr, dist, spheroid);

        public int Adwithin(TGeo temp2, double dist, bool spheroid)
            => Meos.AdwithinTgeoTgeo(this.Ptr, temp2.Ptr, dist, spheroid);

        public Temporal? Affine(double a, double b, double c, double d, double e, double f, double g, double h, double i, double xoff, double yoff, double zoff)
            => MEOSFactory.WrapTemporal(Meos.TgeoAffine(this.Ptr, a, b, c, d, e, f, g, h, i, xoff, yoff, zoff));

        public int Aintersects(Geo gs)
            => Meos.AintersectsTgeoGeo(this.Ptr, gs.Ptr);

        public int Aintersects(TGeo temp2)
            => Meos.AintersectsTgeoTgeo(this.Ptr, temp2.Ptr);

        public int AlwaysEq(Geo gs)
            => Meos.AlwaysEqTgeoGeo(this.Ptr, gs.Ptr);

        public int AlwaysEq(TGeo temp2)
            => Meos.AlwaysEqTgeoTgeo(this.Ptr, temp2.Ptr);

        public int AlwaysNe(Geo gs)
            => Meos.AlwaysNeTgeoGeo(this.Ptr, gs.Ptr);

        public int AlwaysNe(TGeo temp2)
            => Meos.AlwaysNeTgeoTgeo(this.Ptr, temp2.Ptr);

        public Temporal? AtGeom(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TgeoAtGeom(this.Ptr, gs.Ptr));

        public Temporal? AtStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TgeoAtStbox(this.Ptr, box.Ptr, border_inc));

        public Temporal? AtValue(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TgeoAtValue(this.Ptr, gs.Ptr));

        public Temporal? Centroid(bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.TgeoCentroid(this.Ptr, spheroid));

        public Geo? ConvexHull()
            => MEOSFactory.WrapGeo(Meos.TgeoConvexHull(this.Ptr));

        public int Edisjoint(Geo gs)
            => Meos.EdisjointTgeoGeo(this.Ptr, gs.Ptr);

        public int Edisjoint(TGeo temp2)
            => Meos.EdisjointTgeoTgeo(this.Ptr, temp2.Ptr);

        public int Edwithin(Geo gs, double dist, bool spheroid)
            => Meos.EdwithinTgeoGeo(this.Ptr, gs.Ptr, dist, spheroid);

        public int Edwithin(TSpatial temp2, double dist, bool spheroid)
            => Meos.EdwithinTgeoTgeo(this.Ptr, temp2.Ptr, dist, spheroid);

        public int Eintersects(Geo gs)
            => Meos.EintersectsTgeoGeo(this.Ptr, gs.Ptr);

        public int Eintersects(TSpatial temp2)
            => Meos.EintersectsTgeoTgeo(this.Ptr, temp2.Ptr);

        public Geo? EndValue()
            => MEOSFactory.WrapGeo(Meos.TgeoEndValue(this.Ptr));

        public int EverEq(Geo gs)
            => Meos.EverEqTgeoGeo(this.Ptr, gs.Ptr);

        public int EverEq(TGeo temp2)
            => Meos.EverEqTgeoTgeo(this.Ptr, temp2.Ptr);

        public int EverNe(Geo gs)
            => Meos.EverNeTgeoGeo(this.Ptr, gs.Ptr);

        public int EverNe(TGeo temp2)
            => Meos.EverNeTgeoTgeo(this.Ptr, temp2.Ptr);

        public Temporal? Force2d()
            => MEOSFactory.WrapTemporal(Meos.TgeoForce2d(this.Ptr));

        public Temporal? Force3d(double zvalue)
            => MEOSFactory.WrapTemporal(Meos.TgeoForce3d(this.Ptr, zvalue));

        public Temporal? MinusGeom(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TgeoMinusGeom(this.Ptr, gs.Ptr));

        public Temporal? MinusStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TgeoMinusStbox(this.Ptr, box.Ptr, border_inc));

        public Temporal? MinusValue(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TgeoMinusValue(this.Ptr, gs.Ptr));

        public double Nad(Geo gs, bool spheroid)
            => Meos.NadTgeoGeo(this.Ptr, gs.Ptr, spheroid);

        public double Nad(STBox box, bool spheroid)
            => Meos.NadTgeoStbox(this.Ptr, box.Ptr, spheroid);

        public double Nad(TGeo temp2, bool spheroid)
            => Meos.NadTgeoTgeo(this.Ptr, temp2.Ptr, spheroid);

        public Temporal? Nai(Geo gs, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.NaiTgeoGeo(this.Ptr, gs.Ptr, spheroid));

        public Temporal? Nai(TGeo temp2, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.NaiTgeoTgeo(this.Ptr, temp2.Ptr, spheroid));

        public Temporal? Rotate(double angle, double x0, double y0)
            => MEOSFactory.WrapTemporal(Meos.TgeoRotate(this.Ptr, angle, x0, y0));

        public Temporal? RotateGeo(double angle, Geo origin)
            => MEOSFactory.WrapTemporal(Meos.TgeoRotateGeo(this.Ptr, angle, origin.Ptr));

        public Temporal? RotateX(double angle)
            => MEOSFactory.WrapTemporal(Meos.TgeoRotateX(this.Ptr, angle));

        public Temporal? RotateY(double angle)
            => MEOSFactory.WrapTemporal(Meos.TgeoRotateY(this.Ptr, angle));

        public Temporal? RotateZ(double angle)
            => MEOSFactory.WrapTemporal(Meos.TgeoRotateZ(this.Ptr, angle));

        public Temporal? Scale(double xfactor, double yfactor, double zfactor)
            => MEOSFactory.WrapTemporal(Meos.TgeoScale(this.Ptr, xfactor, yfactor, zfactor));

        public Temporal? ScaleGeo(Geo scale)
            => MEOSFactory.WrapTemporal(Meos.TgeoScaleGeo(this.Ptr, scale.Ptr));

        public Temporal? ScaleGeoOrigin(Geo scale, Geo sorigin)
            => MEOSFactory.WrapTemporal(Meos.TgeoScaleGeoOrigin(this.Ptr, scale.Ptr, sorigin.Ptr));

        public Geo? Shortestline(Geo gs, bool spheroid)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTgeoGeo(this.Ptr, gs.Ptr, spheroid));

        public Geo? Shortestline(TGeo temp2, bool spheroid)
            => MEOSFactory.WrapGeo(Meos.ShortestlineTgeoTgeo(this.Ptr, temp2.Ptr, spheroid));

        public STBox?[] SpaceBoxes(double xsize, double ysize, double zsize, Geo sorigin, bool bitmatrix, bool border_inc)
            => MEOSFactory.WrapSTBoxArray(Meos.TgeoSpaceBoxes(this.Ptr, xsize, ysize, zsize, sorigin.Ptr, bitmatrix, border_inc));

        public (Temporal?[], Geo?[]) SpaceSplit(double xsize, double ysize, double zsize, Geo sorigin, bool bitmatrix, bool border_inc)
        {
            var _answered = Meos.TgeoSpaceSplit(this.Ptr, xsize, ysize, zsize, sorigin.Ptr, bitmatrix, border_inc);

            return (MEOSFactory.WrapTemporalArray(_answered.Item1), MEOSFactory.WrapGeoArray(_answered.Item2));
        }

        public STBox?[] SpaceTimeBoxes(double xsize, double ysize, double zsize, Interval duration, Geo sorigin, DateTime torigin, bool bitmatrix, bool border_inc)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSTBoxArray(Meos.TgeoSpaceTimeBoxes(this.Ptr, xsize, ysize, zsize, _duration, sorigin.Ptr, MEOSConvert.ToTimestampTz(torigin), bitmatrix, border_inc));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public (Temporal?[], Geo?[], DateTime[]) SpaceTimeSplit(double xsize, double ysize, double zsize, Interval duration, Geo sorigin, DateTime torigin, bool bitmatrix, bool border_inc)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                var _answered = Meos.TgeoSpaceTimeSplit(this.Ptr, xsize, ysize, zsize, _duration, sorigin.Ptr, MEOSConvert.ToTimestampTz(torigin), bitmatrix, border_inc);

                return (MEOSFactory.WrapTemporalArray(_answered.Item1), MEOSFactory.WrapGeoArray(_answered.Item2), MEOSConvert.ToDateTimeArray(_answered.Item3));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public STBox?[] SplitEachNStboxes(int elem_count)
            => MEOSFactory.WrapSTBoxArray(Meos.TgeoSplitEachNStboxes(this.Ptr, elem_count));

        public STBox?[] SplitNStboxes(int box_count)
            => MEOSFactory.WrapSTBoxArray(Meos.TgeoSplitNStboxes(this.Ptr, box_count));

        public Geo? StartValue()
            => MEOSFactory.WrapGeo(Meos.TgeoStartValue(this.Ptr));

        public STBox?[] Stboxes()
            => MEOSFactory.WrapSTBoxArray(Meos.TgeoStboxes(this.Ptr));

        public Temporal? Tdisjoint(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TdisjointTgeoGeo(this.Ptr, gs.Ptr));

        public Temporal? Tdisjoint(TGeo temp2)
            => MEOSFactory.WrapTemporal(Meos.TdisjointTgeoTgeo(this.Ptr, temp2.Ptr));

        public Temporal? Tdistance(Geo gs, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTgeoGeo(this.Ptr, gs.Ptr, spheroid));

        public Temporal? Tdistance(TGeo temp2, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTgeoTgeo(this.Ptr, temp2.Ptr, spheroid));

        public Temporal? Tdwithin(Geo gs, double dist, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.TdwithinTgeoGeo(this.Ptr, gs.Ptr, dist, spheroid));

        public Temporal? Tdwithin(TGeo temp2, double dist, bool spheroid)
            => MEOSFactory.WrapTemporal(Meos.TdwithinTgeoTgeo(this.Ptr, temp2.Ptr, dist, spheroid));

        public Temporal? Teq(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TeqTgeoGeo(this.Ptr, gs.Ptr));

        public STBox?[] TimeBoxes(Interval duration, DateTime torigin, bool bitmatrix, bool border_inc)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSTBoxArray(Meos.TgeoTimeBoxes(this.Ptr, _duration, MEOSConvert.ToTimestampTz(torigin), bitmatrix, border_inc));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public Temporal? Tintersects(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TintersectsTgeoGeo(this.Ptr, gs.Ptr));

        public Temporal? Tintersects(TGeo temp2)
            => MEOSFactory.WrapTemporal(Meos.TintersectsTgeoTgeo(this.Ptr, temp2.Ptr));

        public Temporal? Tne(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TneTgeoGeo(this.Ptr, gs.Ptr));

        public Temporal? Translate(double deltax, double deltay, double deltaz)
            => MEOSFactory.WrapTemporal(Meos.TgeoTranslate(this.Ptr, deltax, deltay, deltaz));

        public Temporal? Transscale(double deltax, double deltay, double xfactor, double yfactor)
            => MEOSFactory.WrapTemporal(Meos.TgeoTransscale(this.Ptr, deltax, deltay, xfactor, yfactor));

        public Geo? TraversedArea(bool unary_union)
            => MEOSFactory.WrapGeo(Meos.TgeoTraversedArea(this.Ptr, unary_union));

        public Temporal? Ttouches(Geometry gs)
            => MEOSFactory.WrapTemporal(Meos.TtouchesTgeoGeo(this.Ptr, gs.Ptr));

        public (SpanSet?[], Geo?[]) Unnest()
        {
            var _answered = Meos.TgeoUnnest(this.Ptr);

            return (MEOSFactory.WrapSpanSetArray(_answered.Item1), MEOSFactory.WrapGeoArray(_answered.Item2));
        }

        public Geo? Value()
            => MEOSFactory.WrapGeo(Meos.TgeoValue(this.Ptr));

        public Geo? ValueAtTimestamptz(DateTime t, bool strict)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TgeoValueAtTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict, _result))
                {
                    return null;
                }

                return MEOSFactory.WrapGeo(Marshal.ReadIntPtr(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public Geo? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TgeoValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSFactory.WrapGeo(Marshal.ReadIntPtr(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public Geo?[] Values()
            => MEOSFactory.WrapGeoArray(Meos.TgeoValues(this.Ptr));

        public static Temporal? FromBaseTemp(Geo gs, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.TgeoFromBaseTemp(gs.Ptr, temp.Ptr));

    }
}
