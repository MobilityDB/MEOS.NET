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

        public bool Adjacent(FloatSpan s)
            => Meos.AdjacentSpansetSpan(this.Ptr, s.Ptr);

        public bool Adjacent(FloatSpanSet ss2)
            => Meos.AdjacentSpansetSpanset(this.Ptr, ss2.Ptr);

        public string AsText(int maxdd)
            => this.Out(maxdd);

        public Span?[] Bins(double vsize, double vorigin, bool border_inc)
            => MEOSFactory.WrapSpanArray(Meos.FloatspansetBins(this.Ptr, vsize, vorigin, border_inc));

        public SpanSet? Ceil()
            => MEOSFactory.WrapSpanSet(Meos.FloatspansetCeil(this.Ptr));

        public bool Contained(FloatSpan s)
            => Meos.ContainedSpansetSpan(this.Ptr, s.Ptr);

        public bool Contained(FloatSpanSet ss2)
            => Meos.ContainedSpansetSpanset(this.Ptr, ss2.Ptr);

        public bool Contains(double d)
            => Meos.ContainsSpansetFloat(this.Ptr, d);

        public bool Contains(FloatSpan s)
            => Meos.ContainsSpansetSpan(this.Ptr, s.Ptr);

        public bool Contains(FloatSpanSet ss2)
            => Meos.ContainsSpansetSpanset(this.Ptr, ss2.Ptr);

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

        public SpanSet? Intersection(FloatSpan s)
            => MEOSFactory.WrapSpanSet(Meos.IntersectionSpansetSpan(this.Ptr, s.Ptr));

        public SpanSet? Intersection(FloatSpanSet ss2)
            => MEOSFactory.WrapSpanSet(Meos.IntersectionSpansetSpanset(this.Ptr, ss2.Ptr));

        public bool Left(double d)
            => Meos.LeftSpansetFloat(this.Ptr, d);

        public bool Left(FloatSpan s)
            => Meos.LeftSpansetSpan(this.Ptr, s.Ptr);

        public bool Left(FloatSpanSet ss2)
            => Meos.LeftSpansetSpanset(this.Ptr, ss2.Ptr);

        public double Lower()
            => Meos.FloatspansetLower(this.Ptr);

        public SpanSet? Minus(double d)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpansetFloat(this.Ptr, d));

        public SpanSet? Minus(FloatSpan s)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpansetSpan(this.Ptr, s.Ptr));

        public SpanSet? Minus(FloatSpanSet ss2)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpansetSpanset(this.Ptr, ss2.Ptr));

        public string Out(int maxdd)
            => Meos.FloatspansetOut(this.Ptr, maxdd);

        public bool Overlaps(FloatSpan s)
            => Meos.OverlapsSpansetSpan(this.Ptr, s.Ptr);

        public bool Overlaps(FloatSpanSet ss2)
            => Meos.OverlapsSpansetSpanset(this.Ptr, ss2.Ptr);

        public bool Overleft(double d)
            => Meos.OverleftSpansetFloat(this.Ptr, d);

        public bool Overleft(FloatSpan s)
            => Meos.OverleftSpansetSpan(this.Ptr, s.Ptr);

        public bool Overleft(FloatSpanSet ss2)
            => Meos.OverleftSpansetSpanset(this.Ptr, ss2.Ptr);

        public bool Overright(double d)
            => Meos.OverrightSpansetFloat(this.Ptr, d);

        public bool Overright(FloatSpan s)
            => Meos.OverrightSpansetSpan(this.Ptr, s.Ptr);

        public bool Overright(FloatSpanSet ss2)
            => Meos.OverrightSpansetSpanset(this.Ptr, ss2.Ptr);

        public SpanSet? Radians()
            => MEOSFactory.WrapSpanSet(Meos.FloatspansetRadians(this.Ptr));

        public bool Radjacent(double d)
            => Meos.AdjacentFloatSpanset(d, this.Ptr);

        public bool Rcontained(double d)
            => Meos.ContainedFloatSpanset(d, this.Ptr);

        public bool Right(double d)
            => Meos.RightSpansetFloat(this.Ptr, d);

        public bool Right(FloatSpan s)
            => Meos.RightSpansetSpan(this.Ptr, s.Ptr);

        public bool Right(FloatSpanSet ss2)
            => Meos.RightSpansetSpanset(this.Ptr, ss2.Ptr);

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

        public SpanSet? Union(FloatSpan s)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpansetSpan(this.Ptr, s.Ptr));

        public SpanSet? Union(FloatSpanSet ss2)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpansetSpanset(this.Ptr, ss2.Ptr));

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
