#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The TsTzSpanSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TsTzSpanSet : SpanSet
    {
        internal TsTzSpanSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public DateTime EndTimestamptz()
            => MEOSConvert.ToDateTime(Meos.TstzspansetEndTimestamptz(this.Ptr));

        public DateTime Lower()
            => MEOSConvert.ToDateTime(Meos.TstzspansetLower(this.Ptr));

        public int NumTimestamps()
            => Meos.TstzspansetNumTimestamps(this.Ptr);

        public string Out()
            => Meos.TstzspansetOut(this.Ptr);

        public DateTime StartTimestamptz()
            => MEOSConvert.ToDateTime(Meos.TstzspansetStartTimestamptz(this.Ptr));

        public Set? Timestamps()
            => MEOSFactory.WrapSet(Meos.TstzspansetTimestamps(this.Ptr));

        public SpanSet? ToDatespanset()
            => MEOSFactory.WrapSpanSet(Meos.TstzspansetToDatespanset(this.Ptr));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.TstzspansetToStbox(this.Ptr));

        public DateTime Upper()
            => MEOSConvert.ToDateTime(Meos.TstzspansetUpper(this.Ptr));

        public static SpanSet? In(string str)
            => MEOSFactory.WrapSpanSet(Meos.TstzspansetIn(str));

    }
}
