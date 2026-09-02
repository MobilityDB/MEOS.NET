#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>Temporal types carrying an STBox spatial bounding box.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TSpatial : Temporal
    {
        internal TSpatial(IntPtr ptr) : base(ptr) { }

        public string AsEWKT(int maxdd)
            => MEOSExposedFunctions.tspatial_as_ewkt(this.Ptr, maxdd);

        public string AsText(int maxdd)
            => MEOSExposedFunctions.tspatial_as_text(this.Ptr, maxdd);

        public string Out(int maxdd)
            => MEOSExposedFunctions.tspatial_out(this.Ptr, maxdd);

        public int SRID()
            => MEOSExposedFunctions.tspatial_srid(this.Ptr);

        public Temporal? SetSRID(int srid)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tspatial_set_srid(this.Ptr, srid));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(MEOSExposedFunctions.tspatial_to_stbox(this.Ptr));

        public Temporal? Transform(int srid)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tspatial_transform(this.Ptr, srid));

        public Temporal? TransformPipeline(string pipelinestr, int srid, bool is_forward)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tspatial_transform_pipeline(this.Ptr, pipelinestr, srid, is_forward));

    }
}
