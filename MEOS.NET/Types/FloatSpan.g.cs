#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The FloatSpan class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class FloatSpan : Span
    {
        internal FloatSpan(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out(15);

        public Span?[] Bins(double vsize, double vorigin)
            => MEOSFactory.WrapSpanArray(Meos.FloatspanBins(this.Ptr, vsize, vorigin));

        public Span? Ceil()
            => MEOSFactory.WrapSpan(Meos.FloatspanCeil(this.Ptr));

        public Span? Degrees(bool normalize)
            => MEOSFactory.WrapSpan(Meos.FloatspanDegrees(this.Ptr, normalize));

        public Span? Expand(double value)
            => MEOSFactory.WrapSpan(Meos.FloatspanExpand(this.Ptr, value));

        public Span? Floor()
            => MEOSFactory.WrapSpan(Meos.FloatspanFloor(this.Ptr));

        public double Lower()
            => Meos.FloatspanLower(this.Ptr);

        public string Out(int maxdd)
            => Meos.FloatspanOut(this.Ptr, maxdd);

        public Span? Radians()
            => MEOSFactory.WrapSpan(Meos.FloatspanRadians(this.Ptr));

        public Span? Round(int maxdd)
            => MEOSFactory.WrapSpan(Meos.FloatspanRound(this.Ptr, maxdd));

        public Span? ShiftScale(double shift, double width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSpan(Meos.FloatspanShiftScale(this.Ptr, shift, width, hasshift, haswidth));

        public Span? ToBigintspan()
            => MEOSFactory.WrapSpan(Meos.FloatspanToBigintspan(this.Ptr));

        public Span? ToIntspan()
            => MEOSFactory.WrapSpan(Meos.FloatspanToIntspan(this.Ptr));

        public double Upper()
            => Meos.FloatspanUpper(this.Ptr);

        public double Width()
            => Meos.FloatspanWidth(this.Ptr);

        public static Span? In(string str)
            => MEOSFactory.WrapSpan(Meos.FloatspanIn(str));

        public static Span? Make(double lower, double upper, bool lower_inc, bool upper_inc)
            => MEOSFactory.WrapSpan(Meos.FloatspanMake(lower, upper, lower_inc, upper_inc));

    }
}
