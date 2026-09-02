#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The IntSpanSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class IntSpanSet : SpanSet
    {
        internal IntSpanSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public Span?[] Bins(int vsize, int vorigin)
            => MEOSFactory.WrapSpanArray(Meos.IntspansetBins(this.Ptr, vsize, vorigin));

        public int Lower()
            => Meos.IntspansetLower(this.Ptr);

        public string Out()
            => Meos.IntspansetOut(this.Ptr);

        public SpanSet? ShiftScale(int shift, int width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSpanSet(Meos.IntspansetShiftScale(this.Ptr, shift, width, hasshift, haswidth));

        public SpanSet? ToFloatspanset()
            => MEOSFactory.WrapSpanSet(Meos.IntspansetToFloatspanset(this.Ptr));

        public int Upper()
            => Meos.IntspansetUpper(this.Ptr);

        public int Width(bool boundspan)
            => Meos.IntspansetWidth(this.Ptr, boundspan);

        public static SpanSet? In(string str)
            => MEOSFactory.WrapSpanSet(Meos.IntspansetIn(str));

    }
}
