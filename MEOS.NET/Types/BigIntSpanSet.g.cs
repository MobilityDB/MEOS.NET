#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The BigIntSpanSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class BigIntSpanSet : SpanSet
    {
        internal BigIntSpanSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public Span?[] Bins(long vsize, long vorigin)
            => MEOSFactory.WrapSpanArray(Meos.BigintspansetBins(this.Ptr, vsize, vorigin));

        public long Lower()
            => Meos.BigintspansetLower(this.Ptr);

        public string Out()
            => Meos.BigintspansetOut(this.Ptr);

        public SpanSet? ShiftScale(long shift, long width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSpanSet(Meos.BigintspansetShiftScale(this.Ptr, shift, width, hasshift, haswidth));

        public long Upper()
            => Meos.BigintspansetUpper(this.Ptr);

        public long Width(bool boundspan)
            => Meos.BigintspansetWidth(this.Ptr, boundspan);

        public static SpanSet? In(string str)
            => MEOSFactory.WrapSpanSet(Meos.BigintspansetIn(str));

    }
}
