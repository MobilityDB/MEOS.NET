#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The TCbuffer class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TCbuffer : TSpatial
    {
        internal TCbuffer(IntPtr ptr) : base(ptr) { }

        public Temporal? AtStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tcbuffer_at_stbox(this.Ptr, box.Ptr, border_inc));

        public Temporal? Expand(double dist)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tcbuffer_expand(this.Ptr, dist));

        public Temporal? Make(Temporal tfloat)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tcbuffer_make(this.Ptr, tfloat.Ptr));

        public Temporal? MinusStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tcbuffer_minus_stbox(this.Ptr, box.Ptr, border_inc));

        public Set? Points()
            => MEOSFactory.WrapSet(MEOSExposedFunctions.tcbuffer_points(this.Ptr));

        public Set? Radius()
            => MEOSFactory.WrapSet(MEOSExposedFunctions.tcbuffer_radius(this.Ptr));

        public Temporal? ToTfloat()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tcbuffer_to_tfloat(this.Ptr));

        public Temporal? ToTgeompoint()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tcbuffer_to_tgeompoint(this.Ptr));

        public static Temporal? FromMFJSON(string mfjson)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tcbuffer_from_mfjson(mfjson));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tcbuffer_in(str));

    }
}
