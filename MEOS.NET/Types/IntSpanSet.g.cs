#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The IntSpanSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class IntSpanSet : SpanSet
    {
        internal IntSpanSet(IntPtr ptr) : base(ptr) { }

        public bool Adjacent(int i)
            => Meos.AdjacentSpansetInt(this.Ptr, i);

        public bool Adjacent(IntSpan s)
            => Meos.AdjacentSpansetSpan(this.Ptr, s.Ptr);

        public bool Adjacent(IntSpanSet ss2)
            => Meos.AdjacentSpansetSpanset(this.Ptr, ss2.Ptr);

        public Span?[] Bins(int vsize, int vorigin, bool border_inc)
            => MEOSFactory.WrapSpanArray(Meos.IntspansetBins(this.Ptr, vsize, vorigin, border_inc));

        public bool Contained(IntSpan s)
            => Meos.ContainedSpansetSpan(this.Ptr, s.Ptr);

        public bool Contained(IntSpanSet ss2)
            => Meos.ContainedSpansetSpanset(this.Ptr, ss2.Ptr);

        public bool Contains(int i)
            => Meos.ContainsSpansetInt(this.Ptr, i);

        public bool Contains(IntSpan s)
            => Meos.ContainsSpansetSpan(this.Ptr, s.Ptr);

        public bool Contains(IntSpanSet ss2)
            => Meos.ContainsSpansetSpanset(this.Ptr, ss2.Ptr);

        public int Distance(IntSpan s)
            => Meos.DistanceIntspansetIntspan(this.Ptr, s.Ptr);

        public int Distance(IntSpanSet ss2)
            => Meos.DistanceIntspansetIntspanset(this.Ptr, ss2.Ptr);

        public int Distance(int i)
            => Meos.DistanceSpansetInt(this.Ptr, i);

        public SpanSet? Intersection(int i)
            => MEOSFactory.WrapSpanSet(Meos.IntersectionSpansetInt(this.Ptr, i));

        public SpanSet? Intersection(IntSpan s)
            => MEOSFactory.WrapSpanSet(Meos.IntersectionSpansetSpan(this.Ptr, s.Ptr));

        public SpanSet? Intersection(IntSpanSet ss2)
            => MEOSFactory.WrapSpanSet(Meos.IntersectionSpansetSpanset(this.Ptr, ss2.Ptr));

        public bool Left(int i)
            => Meos.LeftSpansetInt(this.Ptr, i);

        public bool Left(IntSpan s)
            => Meos.LeftSpansetSpan(this.Ptr, s.Ptr);

        public bool Left(IntSpanSet ss2)
            => Meos.LeftSpansetSpanset(this.Ptr, ss2.Ptr);

        public int Lower()
            => Meos.IntspansetLower(this.Ptr);

        public SpanSet? Minus(int i)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpansetInt(this.Ptr, i));

        public SpanSet? Minus(IntSpan s)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpansetSpan(this.Ptr, s.Ptr));

        public SpanSet? Minus(IntSpanSet ss2)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpansetSpanset(this.Ptr, ss2.Ptr));

        public bool Overlaps(IntSpan s)
            => Meos.OverlapsSpansetSpan(this.Ptr, s.Ptr);

        public bool Overlaps(IntSpanSet ss2)
            => Meos.OverlapsSpansetSpanset(this.Ptr, ss2.Ptr);

        public bool Overleft(int i)
            => Meos.OverleftSpansetInt(this.Ptr, i);

        public bool Overleft(IntSpan s)
            => Meos.OverleftSpansetSpan(this.Ptr, s.Ptr);

        public bool Overleft(IntSpanSet ss2)
            => Meos.OverleftSpansetSpanset(this.Ptr, ss2.Ptr);

        public bool Overright(int i)
            => Meos.OverrightSpansetInt(this.Ptr, i);

        public bool Overright(IntSpan s)
            => Meos.OverrightSpansetSpan(this.Ptr, s.Ptr);

        public bool Overright(IntSpanSet ss2)
            => Meos.OverrightSpansetSpanset(this.Ptr, ss2.Ptr);

        public bool Radjacent(int i)
            => Meos.AdjacentIntSpanset(i, this.Ptr);

        public bool Rcontained(int i)
            => Meos.ContainedIntSpanset(i, this.Ptr);

        public bool Right(int i)
            => Meos.RightSpansetInt(this.Ptr, i);

        public bool Right(IntSpan s)
            => Meos.RightSpansetSpan(this.Ptr, s.Ptr);

        public bool Right(IntSpanSet ss2)
            => Meos.RightSpansetSpanset(this.Ptr, ss2.Ptr);

        public SpanSet? Rintersection(int i)
            => MEOSFactory.WrapSpanSet(Meos.IntersectionIntSpanset(i, this.Ptr));

        public bool Rleft(int i)
            => Meos.LeftIntSpanset(i, this.Ptr);

        public SpanSet? Rminus(int i)
            => MEOSFactory.WrapSpanSet(Meos.MinusIntSpanset(i, this.Ptr));

        public bool Roverleft(int i)
            => Meos.OverleftIntSpanset(i, this.Ptr);

        public bool Roverright(int i)
            => Meos.OverrightIntSpanset(i, this.Ptr);

        public bool Rright(int i)
            => Meos.RightIntSpanset(i, this.Ptr);

        public SpanSet? Runion(int i)
            => MEOSFactory.WrapSpanSet(Meos.UnionIntSpanset(i, this.Ptr));

        public SpanSet? ShiftScale(int shift, int width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSpanSet(Meos.IntspansetShiftScale(this.Ptr, shift, width, hasshift, haswidth));

        public SpanSet? ToFloatspanset()
            => MEOSFactory.WrapSpanSet(Meos.IntspansetToFloatspanset(this.Ptr));

        public SpanSet? Union(int i)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpansetInt(this.Ptr, i));

        public SpanSet? Union(IntSpan s)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpansetSpan(this.Ptr, s.Ptr));

        public SpanSet? Union(IntSpanSet ss2)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpansetSpanset(this.Ptr, ss2.Ptr));

        public int Upper()
            => Meos.IntspansetUpper(this.Ptr);

        public int Width(bool boundspan)
            => Meos.IntspansetWidth(this.Ptr, boundspan);

        public static SpanSet? FromInt(int i)
            => MEOSFactory.WrapSpanSet(Meos.IntToSpanset(i));

        public static SpanSet? FromText(string str)
            => MEOSFactory.WrapSpanSet(Meos.IntspansetIn(str));

    }
}
