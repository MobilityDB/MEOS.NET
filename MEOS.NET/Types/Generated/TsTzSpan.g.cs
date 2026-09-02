#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The TsTzSpan class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TsTzSpan : Span
    {
        internal TsTzSpan(IntPtr ptr) : base(ptr) { }

        public DateTime Lower()
            => MEOSConvert.ToDateTime(MEOSExposedFunctions.tstzspan_lower(this.Ptr));

        public string Out()
            => MEOSExposedFunctions.tstzspan_out(this.Ptr);

        public Span? ToDatespan()
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.tstzspan_to_datespan(this.Ptr));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(MEOSExposedFunctions.tstzspan_to_stbox(this.Ptr));

        public DateTime Upper()
            => MEOSConvert.ToDateTime(MEOSExposedFunctions.tstzspan_upper(this.Ptr));

        public static Span? In(string str)
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.tstzspan_in(str));

        public static Span? Make(DateTime lower, DateTime upper, bool lower_inc, bool upper_inc)
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.tstzspan_make(MEOSConvert.ToTimestampTz(lower), MEOSConvert.ToTimestampTz(upper), lower_inc, upper_inc));

    }
}
