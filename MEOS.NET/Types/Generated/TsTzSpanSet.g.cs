#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The TsTzSpanSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TsTzSpanSet : SpanSet
    {
        internal TsTzSpanSet(IntPtr ptr) : base(ptr) { }

        public DateTime EndTimestamptz()
            => MEOSConvert.ToDateTime(MEOSExposedFunctions.tstzspanset_end_timestamptz(this.Ptr));

        public DateTime Lower()
            => MEOSConvert.ToDateTime(MEOSExposedFunctions.tstzspanset_lower(this.Ptr));

        public int NumTimestamps()
            => MEOSExposedFunctions.tstzspanset_num_timestamps(this.Ptr);

        public string Out()
            => MEOSExposedFunctions.tstzspanset_out(this.Ptr);

        public DateTime StartTimestamptz()
            => MEOSConvert.ToDateTime(MEOSExposedFunctions.tstzspanset_start_timestamptz(this.Ptr));

        public Set? Timestamps()
            => MEOSFactory.WrapSet(MEOSExposedFunctions.tstzspanset_timestamps(this.Ptr));

        public SpanSet? ToDatespanset()
            => MEOSFactory.WrapSpanSet(MEOSExposedFunctions.tstzspanset_to_datespanset(this.Ptr));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(MEOSExposedFunctions.tstzspanset_to_stbox(this.Ptr));

        public DateTime Upper()
            => MEOSConvert.ToDateTime(MEOSExposedFunctions.tstzspanset_upper(this.Ptr));

        public static SpanSet? In(string str)
            => MEOSFactory.WrapSpanSet(MEOSExposedFunctions.tstzspanset_in(str));

    }
}
