#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The IntSpan class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class IntSpan : Span
    {
        internal IntSpan(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public Span?[] Bins(int vsize, int vorigin)
            => MEOSFactory.WrapSpanArray(Meos.IntspanBins(this.Ptr, vsize, vorigin));

        public Span? Expand(int value)
            => MEOSFactory.WrapSpan(Meos.IntspanExpand(this.Ptr, value));

        public int Lower()
            => Meos.IntspanLower(this.Ptr);

        public string Out()
            => Meos.IntspanOut(this.Ptr);

        public Span? ShiftScale(int shift, int width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSpan(Meos.IntspanShiftScale(this.Ptr, shift, width, hasshift, haswidth));

        public Span? ToBigintspan()
            => MEOSFactory.WrapSpan(Meos.IntspanToBigintspan(this.Ptr));

        public Span? ToFloatspan()
            => MEOSFactory.WrapSpan(Meos.IntspanToFloatspan(this.Ptr));

        public int Upper()
            => Meos.IntspanUpper(this.Ptr);

        public int Width()
            => Meos.IntspanWidth(this.Ptr);

        public static Span? In(string str)
            => MEOSFactory.WrapSpan(Meos.IntspanIn(str));

        public static Span? Make(int lower, int upper, bool lower_inc, bool upper_inc)
            => MEOSFactory.WrapSpan(Meos.IntspanMake(lower, upper, lower_inc, upper_inc));

    }
}
