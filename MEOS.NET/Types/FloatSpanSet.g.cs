#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The FloatSpanSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class FloatSpanSet : SpanSet
    {
        internal FloatSpanSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out(15);

        public Span?[] Bins(double vsize, double vorigin)
            => MEOSFactory.WrapSpanArray(Meos.FloatspansetBins(this.Ptr, vsize, vorigin));

        public SpanSet? Ceil()
            => MEOSFactory.WrapSpanSet(Meos.FloatspansetCeil(this.Ptr));

        public SpanSet? Degrees(bool normalize)
            => MEOSFactory.WrapSpanSet(Meos.FloatspansetDegrees(this.Ptr, normalize));

        public SpanSet? Floor()
            => MEOSFactory.WrapSpanSet(Meos.FloatspansetFloor(this.Ptr));

        public double Lower()
            => Meos.FloatspansetLower(this.Ptr);

        public string Out(int maxdd)
            => Meos.FloatspansetOut(this.Ptr, maxdd);

        public SpanSet? Radians()
            => MEOSFactory.WrapSpanSet(Meos.FloatspansetRadians(this.Ptr));

        public SpanSet? Round(int maxdd)
            => MEOSFactory.WrapSpanSet(Meos.FloatspansetRound(this.Ptr, maxdd));

        public SpanSet? ShiftScale(double shift, double width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSpanSet(Meos.FloatspansetShiftScale(this.Ptr, shift, width, hasshift, haswidth));

        public SpanSet? ToIntspanset()
            => MEOSFactory.WrapSpanSet(Meos.FloatspansetToIntspanset(this.Ptr));

        public double Upper()
            => Meos.FloatspansetUpper(this.Ptr);

        public double Width(bool boundspan)
            => Meos.FloatspansetWidth(this.Ptr, boundspan);

        public static SpanSet? In(string str)
            => MEOSFactory.WrapSpanSet(Meos.FloatspansetIn(str));

    }
}
