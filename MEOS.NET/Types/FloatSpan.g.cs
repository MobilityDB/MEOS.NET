#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

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

        public bool Adjacent(double d)
            => Meos.AdjacentSpanFloat(this.Ptr, d);

        public string AsText(int maxdd)
            => this.Out(maxdd);

        public Span?[] Bins(double vsize, double vorigin, bool border_inc)
            => MEOSFactory.WrapSpanArray(Meos.FloatspanBins(this.Ptr, vsize, vorigin, border_inc));

        public Span? Ceil()
            => MEOSFactory.WrapSpan(Meos.FloatspanCeil(this.Ptr));

        public bool Contains(double d)
            => Meos.ContainsSpanFloat(this.Ptr, d);

        public Span? Degrees(bool normalize)
            => MEOSFactory.WrapSpan(Meos.FloatspanDegrees(this.Ptr, normalize));

        public double Distance(FloatSpan s2)
            => Meos.DistanceFloatspanFloatspan(this.Ptr, s2.Ptr);

        public double Distance(double d)
            => Meos.DistanceSpanFloat(this.Ptr, d);

        public Span? Expand(double value)
            => MEOSFactory.WrapSpan(Meos.FloatspanExpand(this.Ptr, value));

        public Span? Floor()
            => MEOSFactory.WrapSpan(Meos.FloatspanFloor(this.Ptr));

        public Span? Intersection(double d)
            => MEOSFactory.WrapSpan(Meos.IntersectionSpanFloat(this.Ptr, d));

        public bool Left(double d)
            => Meos.LeftSpanFloat(this.Ptr, d);

        public double Lower()
            => Meos.FloatspanLower(this.Ptr);

        public SpanSet? Minus(double d)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpanFloat(this.Ptr, d));

        public double Nad(TBox box)
            => Meos.NadFloatspanTbox(this.Ptr, box.Ptr);

        public string Out(int maxdd)
            => Meos.FloatspanOut(this.Ptr, maxdd);

        public bool Overleft(double d)
            => Meos.OverleftSpanFloat(this.Ptr, d);

        public bool Overright(double d)
            => Meos.OverrightSpanFloat(this.Ptr, d);

        public Span? Radians()
            => MEOSFactory.WrapSpan(Meos.FloatspanRadians(this.Ptr));

        public bool Radjacent(double d)
            => Meos.AdjacentFloatSpan(d, this.Ptr);

        public bool Rcontained(double d)
            => Meos.ContainedFloatSpan(d, this.Ptr);

        public bool Right(double d)
            => Meos.RightSpanFloat(this.Ptr, d);

        public Span? Rintersection(double d)
            => MEOSFactory.WrapSpan(Meos.IntersectionFloatSpan(d, this.Ptr));

        public bool Rleft(double d)
            => Meos.LeftFloatSpan(d, this.Ptr);

        public SpanSet? Rminus(double d)
            => MEOSFactory.WrapSpanSet(Meos.MinusFloatSpan(d, this.Ptr));

        public Span? Round(int maxdd)
            => MEOSFactory.WrapSpan(Meos.FloatspanRound(this.Ptr, maxdd));

        public bool Roverleft(double d)
            => Meos.OverleftFloatSpan(d, this.Ptr);

        public bool Roverright(double d)
            => Meos.OverrightFloatSpan(d, this.Ptr);

        public bool Rright(double d)
            => Meos.RightFloatSpan(d, this.Ptr);

        public SpanSet? Runion(double d)
            => MEOSFactory.WrapSpanSet(Meos.UnionFloatSpan(d, this.Ptr));

        public Span? ShiftScale(double shift, double width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSpan(Meos.FloatspanShiftScale(this.Ptr, shift, width, hasshift, haswidth));

        public Span? ToBigintspan()
            => MEOSFactory.WrapSpan(Meos.FloatspanToBigintspan(this.Ptr));

        public Span? ToIntspan()
            => MEOSFactory.WrapSpan(Meos.FloatspanToIntspan(this.Ptr));

        public SpanSet? Union(double d)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpanFloat(this.Ptr, d));

        public double Upper()
            => Meos.FloatspanUpper(this.Ptr);

        public double Width()
            => Meos.FloatspanWidth(this.Ptr);

        public static Span? FromFloat(double d)
            => MEOSFactory.WrapSpan(Meos.FloatToSpan(d));

        public static Span? FromText(string str)
            => FloatSpan.In(str);

        public static Span? GetBin(double value, double vsize, double vorigin)
            => MEOSFactory.WrapSpan(Meos.FloatspanGetBin(value, vsize, vorigin));

        public static Span? In(string str)
            => MEOSFactory.WrapSpan(Meos.FloatspanIn(str));

        public static Span? Make(double lower, double upper, bool lower_inc, bool upper_inc)
            => MEOSFactory.WrapSpan(Meos.FloatspanMake(lower, upper, lower_inc, upper_inc));

    }
}
