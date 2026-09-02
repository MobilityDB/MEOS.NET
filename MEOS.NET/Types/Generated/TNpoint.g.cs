#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The TNpoint class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TNpoint : TSpatial
    {
        internal TNpoint(IntPtr ptr) : base(ptr) { }

        public Temporal? AtNpointset(Set s)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tnpoint_at_npointset(this.Ptr, s.Ptr));

        public Temporal? AtStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tnpoint_at_stbox(this.Ptr, box.Ptr, border_inc));

        public Temporal? CumulativeLength()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tnpoint_cumulative_length(this.Ptr));

        public double Length()
            => MEOSExposedFunctions.tnpoint_length(this.Ptr);

        public Temporal? MinusNpointset(Set s)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tnpoint_minus_npointset(this.Ptr, s.Ptr));

        public Temporal? MinusStbox(STBox box, bool border_inc)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tnpoint_minus_stbox(this.Ptr, box.Ptr, border_inc));

        public new string Out(int maxdd)
            => MEOSExposedFunctions.tnpoint_out(this.Ptr, maxdd);

        public long Route()
            => MEOSExposedFunctions.tnpoint_route(this.Ptr);

        public Set? Routes()
            => MEOSFactory.WrapSet(MEOSExposedFunctions.tnpoint_routes(this.Ptr));

        public Temporal? Speed()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tnpoint_speed(this.Ptr));

        public Temporal? ToTgeompoint()
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tnpoint_to_tgeompoint(this.Ptr));

        public static Temporal? FromMFJSON(string mfjson)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tnpoint_from_mfjson(mfjson));

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(MEOSExposedFunctions.tnpoint_in(str));

    }
}
