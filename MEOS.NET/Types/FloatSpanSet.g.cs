#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

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

        public bool Adjacent(double d)
            => Meos.AdjacentSpansetFloat(this.Ptr, d);

        public string AsText(int maxdd)
            => this.Out(maxdd);

        public Span?[] Bins(double vsize, double vorigin, bool border_inc)
            => MEOSFactory.WrapSpanArray(Meos.FloatspansetBins(this.Ptr, vsize, vorigin, border_inc));

        public SpanSet? Ceil()
            => MEOSFactory.WrapSpanSet(Meos.FloatspansetCeil(this.Ptr));

        public bool Contains(double d)
            => Meos.ContainsSpansetFloat(this.Ptr, d);

        public SpanSet? Degrees(bool normalize)
            => MEOSFactory.WrapSpanSet(Meos.FloatspansetDegrees(this.Ptr, normalize));

        public double Distance(FloatSpan s)
            => Meos.DistanceFloatspansetFloatspan(this.Ptr, s.Ptr);

        public double Distance(FloatSpanSet ss2)
            => Meos.DistanceFloatspansetFloatspanset(this.Ptr, ss2.Ptr);

        public double Distance(double d)
            => Meos.DistanceSpansetFloat(this.Ptr, d);

        public SpanSet? Floor()
            => MEOSFactory.WrapSpanSet(Meos.FloatspansetFloor(this.Ptr));

        public SpanSet? Intersection(double d)
            => MEOSFactory.WrapSpanSet(Meos.IntersectionSpansetFloat(this.Ptr, d));

        public bool Left(double d)
            => Meos.LeftSpansetFloat(this.Ptr, d);

        public double Lower()
            => Meos.FloatspansetLower(this.Ptr);

        public SpanSet? Minus(double d)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpansetFloat(this.Ptr, d));

        public string Out(int maxdd)
            => Meos.FloatspansetOut(this.Ptr, maxdd);

        public bool Overleft(double d)
            => Meos.OverleftSpansetFloat(this.Ptr, d);

        public bool Overright(double d)
            => Meos.OverrightSpansetFloat(this.Ptr, d);

        public SpanSet? Radians()
            => MEOSFactory.WrapSpanSet(Meos.FloatspansetRadians(this.Ptr));

        public bool Radjacent(double d)
            => Meos.AdjacentFloatSpanset(d, this.Ptr);

        public bool Rcontained(double d)
            => Meos.ContainedFloatSpanset(d, this.Ptr);

        public bool Right(double d)
            => Meos.RightSpansetFloat(this.Ptr, d);

        public SpanSet? Rintersection(double d)
            => MEOSFactory.WrapSpanSet(Meos.IntersectionFloatSpanset(d, this.Ptr));

        public bool Rleft(double d)
            => Meos.LeftFloatSpanset(d, this.Ptr);

        public SpanSet? Rminus(double d)
            => MEOSFactory.WrapSpanSet(Meos.MinusFloatSpanset(d, this.Ptr));

        public SpanSet? Round(int maxdd)
            => MEOSFactory.WrapSpanSet(Meos.FloatspansetRound(this.Ptr, maxdd));

        public bool Roverleft(double d)
            => Meos.OverleftFloatSpanset(d, this.Ptr);

        public bool Roverright(double d)
            => Meos.OverrightFloatSpanset(d, this.Ptr);

        public bool Rright(double d)
            => Meos.RightFloatSpanset(d, this.Ptr);

        public SpanSet? Runion(double d)
            => MEOSFactory.WrapSpanSet(Meos.UnionFloatSpanset(d, this.Ptr));

        public SpanSet? ShiftScale(double shift, double width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSpanSet(Meos.FloatspansetShiftScale(this.Ptr, shift, width, hasshift, haswidth));

        public SpanSet? ToIntspanset()
            => MEOSFactory.WrapSpanSet(Meos.FloatspansetToIntspanset(this.Ptr));

        public SpanSet? Union(double d)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpansetFloat(this.Ptr, d));

        public double Upper()
            => Meos.FloatspansetUpper(this.Ptr);

        public double Width(bool boundspan)
            => Meos.FloatspansetWidth(this.Ptr, boundspan);

        public static SpanSet? FromFloat(double d)
            => MEOSFactory.WrapSpanSet(Meos.FloatToSpanset(d));

        public static SpanSet? FromText(string str)
            => FloatSpanSet.In(str);

        public static SpanSet? In(string str)
            => MEOSFactory.WrapSpanSet(Meos.FloatspansetIn(str));

    }
}
