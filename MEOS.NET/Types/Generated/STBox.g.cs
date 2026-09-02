#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>Space x time box (bbox of TSpatial).</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class STBox : Box
    {
        internal STBox(IntPtr ptr) : base(ptr) { }

        public double Area(bool spheroid)
            => MEOSExposedFunctions.stbox_area(this.Ptr, spheroid);

        public int Cmp(STBox box2)
            => MEOSExposedFunctions.stbox_cmp(this.Ptr, box2.Ptr);

        public STBox? Copy()
            => MEOSFactory.WrapSTBox(MEOSExposedFunctions.stbox_copy(this.Ptr));

        public bool Eq(STBox box2)
            => MEOSExposedFunctions.stbox_eq(this.Ptr, box2.Ptr);

        public STBox? ExpandSpace(double d)
            => MEOSFactory.WrapSTBox(MEOSExposedFunctions.stbox_expand_space(this.Ptr, d));

        public bool Ge(STBox box2)
            => MEOSExposedFunctions.stbox_ge(this.Ptr, box2.Ptr);

        public STBox? GetSpace()
            => MEOSFactory.WrapSTBox(MEOSExposedFunctions.stbox_get_space(this.Ptr));

        public bool Gt(STBox box2)
            => MEOSExposedFunctions.stbox_gt(this.Ptr, box2.Ptr);

        public uint Hash()
            => MEOSExposedFunctions.stbox_hash(this.Ptr);

        public ulong HashExtended(ulong seed)
            => MEOSExposedFunctions.stbox_hash_extended(this.Ptr, seed);

        public bool Hast()
            => MEOSExposedFunctions.stbox_hast(this.Ptr);

        public bool Hasx()
            => MEOSExposedFunctions.stbox_hasx(this.Ptr);

        public bool Hasz()
            => MEOSExposedFunctions.stbox_hasz(this.Ptr);

        public bool Isgeodetic()
            => MEOSExposedFunctions.stbox_isgeodetic(this.Ptr);

        public bool Le(STBox box2)
            => MEOSExposedFunctions.stbox_le(this.Ptr, box2.Ptr);

        public bool Lt(STBox box2)
            => MEOSExposedFunctions.stbox_lt(this.Ptr, box2.Ptr);

        public bool Ne(STBox box2)
            => MEOSExposedFunctions.stbox_ne(this.Ptr, box2.Ptr);

        public string Out(int maxdd)
            => MEOSExposedFunctions.stbox_out(this.Ptr, maxdd);

        public double Perimeter(bool spheroid)
            => MEOSExposedFunctions.stbox_perimeter(this.Ptr, spheroid);

        public STBox? Round(int maxdd)
            => MEOSFactory.WrapSTBox(MEOSExposedFunctions.stbox_round(this.Ptr, maxdd));

        public int SRID()
            => MEOSExposedFunctions.stbox_srid(this.Ptr);

        public STBox? SetSRID(int srid)
            => MEOSFactory.WrapSTBox(MEOSExposedFunctions.stbox_set_srid(this.Ptr, srid));

        public double SpatialDistance(STBox box2)
            => MEOSExposedFunctions.stbox_spatial_distance(this.Ptr, box2.Ptr);

        public Span? ToTstzspan()
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.stbox_to_tstzspan(this.Ptr));

        public STBox? Transform(int srid)
            => MEOSFactory.WrapSTBox(MEOSExposedFunctions.stbox_transform(this.Ptr, srid));

        public STBox? TransformPipeline(string pipelinestr, int srid, bool is_forward)
            => MEOSFactory.WrapSTBox(MEOSExposedFunctions.stbox_transform_pipeline(this.Ptr, pipelinestr, srid, is_forward));

        public double Volume()
            => MEOSExposedFunctions.stbox_volume(this.Ptr);

        public static STBox? FromHEXWKB(string hexwkb)
            => MEOSFactory.WrapSTBox(MEOSExposedFunctions.stbox_from_hexwkb(hexwkb));

        public static STBox? In(string str)
            => MEOSFactory.WrapSTBox(MEOSExposedFunctions.stbox_in(str));

        public static STBox? Make(bool hasx, bool hasz, bool geodetic, int srid, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, Span s)
            => MEOSFactory.WrapSTBox(MEOSExposedFunctions.stbox_make(hasx, hasz, geodetic, srid, xmin, xmax, ymin, ymax, zmin, zmax, s.Ptr));

    }
}
