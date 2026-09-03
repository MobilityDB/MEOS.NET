#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>All PostGIS-derived spatiotemporal types (geometry/geography-based). Authoritative parent per MobilityDB manual Ch.7 Figure 7.1 (= the broad C predicate tgeo_type_all). NOTE: the narrower C predicate tgeo_type() and most tgeo_* functions reject points — class membership (manual) is broader than tgeo_* API applicability; see correction OM-M1.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TGeo : TSpatial
    {
        internal TGeo(IntPtr ptr) : base(ptr) { }

        public Temporal? AtGeom(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TgeoAtGeom(this.Ptr, gs.Ptr));

        public Temporal? AtStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TgeoAtStbox(this.Ptr, box.Ptr, border_inc));

        public Temporal? AtValue(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TgeoAtValue(this.Ptr, gs.Ptr));

        public Temporal? Centroid()
            => MEOSFactory.WrapTemporal(Meos.TgeoCentroid(this.Ptr));

        public Geo? ConvexHull()
            => MEOSFactory.WrapGeo(Meos.TgeoConvexHull(this.Ptr));

        public Geo? EndValue()
            => MEOSFactory.WrapGeo(Meos.TgeoEndValue(this.Ptr));

        public Temporal? MinusGeom(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TgeoMinusGeom(this.Ptr, gs.Ptr));

        public Temporal? MinusStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TgeoMinusStbox(this.Ptr, box.Ptr, border_inc));

        public Temporal? MinusValue(Geo gs)
            => MEOSFactory.WrapTemporal(Meos.TgeoMinusValue(this.Ptr, gs.Ptr));

        public Temporal? Scale(Geo scale, Geo sorigin)
            => MEOSFactory.WrapTemporal(Meos.TgeoScale(this.Ptr, scale.Ptr, sorigin.Ptr));

        public STBox?[] SpaceBoxes(double xsize, double ysize, double zsize, Geo sorigin, bool bitmatrix, bool border_inc)
            => MEOSFactory.WrapSTBoxArray(Meos.TgeoSpaceBoxes(this.Ptr, xsize, ysize, zsize, sorigin.Ptr, bitmatrix, border_inc));

        public STBox?[] SplitEachNStboxes(int elem_count)
            => MEOSFactory.WrapSTBoxArray(Meos.TgeoSplitEachNStboxes(this.Ptr, elem_count));

        public STBox?[] SplitNStboxes(int box_count)
            => MEOSFactory.WrapSTBoxArray(Meos.TgeoSplitNStboxes(this.Ptr, box_count));

        public Geo? StartValue()
            => MEOSFactory.WrapGeo(Meos.TgeoStartValue(this.Ptr));

        public STBox?[] Stboxes()
            => MEOSFactory.WrapSTBoxArray(Meos.TgeoStboxes(this.Ptr));

        public Geo? TraversedArea(bool unary_union)
            => MEOSFactory.WrapGeo(Meos.TgeoTraversedArea(this.Ptr, unary_union));

        public Geo?[] Values()
            => MEOSFactory.WrapGeoArray(Meos.TgeoValues(this.Ptr));

        public static Temporal? FromBaseTemp(Geo gs, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.TgeoFromBaseTemp(gs.Ptr, temp.Ptr));

    }
}
