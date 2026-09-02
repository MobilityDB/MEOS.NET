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

        public Temporal? AtStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TgeoAtStbox(this.Ptr, box.Ptr, border_inc));

        public Temporal? Centroid()
            => MEOSFactory.WrapTemporal(Meos.TgeoCentroid(this.Ptr));

        public Temporal? MinusStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(Meos.TgeoMinusStbox(this.Ptr, box.Ptr, border_inc));

        public STBox?[] SplitEachNStboxes(int elem_count)
            => MEOSFactory.WrapSTBoxArray(Meos.TgeoSplitEachNStboxes(this.Ptr, elem_count));

        public STBox?[] SplitNStboxes(int box_count)
            => MEOSFactory.WrapSTBoxArray(Meos.TgeoSplitNStboxes(this.Ptr, box_count));

        public STBox?[] Stboxes()
            => MEOSFactory.WrapSTBoxArray(Meos.TgeoStboxes(this.Ptr));

    }
}
