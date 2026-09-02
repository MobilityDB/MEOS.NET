#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>Temporal types carrying an STBox spatial bounding box.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TSpatial : Temporal
    {
        internal TSpatial(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out(15);

        public string AsEWKT(int maxdd)
            => Meos.TspatialAsEwkt(this.Ptr, maxdd);

        public string AsText(int maxdd)
            => Meos.TspatialAsText(this.Ptr, maxdd);

        public string Out(int maxdd)
            => Meos.TspatialOut(this.Ptr, maxdd);

        public int SRID()
            => Meos.TspatialSrid(this.Ptr);

        public Temporal? SetSRID(int srid)
            => MEOSFactory.WrapTemporal(Meos.TspatialSetSrid(this.Ptr, srid));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.TspatialToStbox(this.Ptr));

        public Temporal? Transform(int srid)
            => MEOSFactory.WrapTemporal(Meos.TspatialTransform(this.Ptr, srid));

        public Temporal? TransformPipeline(string pipelinestr, int srid, bool is_forward)
            => MEOSFactory.WrapTemporal(Meos.TspatialTransformPipeline(this.Ptr, pipelinestr, srid, is_forward));

    }
}
