#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The TsTzSpan class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TsTzSpan : Span
    {
        internal TsTzSpan(IntPtr ptr) : base(ptr) { }

        public DateTime Lower()
            => MEOSConvert.ToDateTime(Meos.TstzspanLower(this.Ptr));

        public string Out()
            => Meos.TstzspanOut(this.Ptr);

        public Span? ToDatespan()
            => MEOSFactory.WrapSpan(Meos.TstzspanToDatespan(this.Ptr));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.TstzspanToStbox(this.Ptr));

        public DateTime Upper()
            => MEOSConvert.ToDateTime(Meos.TstzspanUpper(this.Ptr));

        public static Span? In(string str)
            => MEOSFactory.WrapSpan(Meos.TstzspanIn(str));

        public static Span? Make(DateTime lower, DateTime upper, bool lower_inc, bool upper_inc)
            => MEOSFactory.WrapSpan(Meos.TstzspanMake(MEOSConvert.ToTimestampTz(lower), MEOSConvert.ToTimestampTz(upper), lower_inc, upper_inc));

    }
}
