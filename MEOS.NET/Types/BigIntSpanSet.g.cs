#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The BigIntSpanSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class BigIntSpanSet : SpanSet
    {
        internal BigIntSpanSet(IntPtr ptr) : base(ptr) { }

        public bool Adjacent(long i)
            => Meos.AdjacentSpansetBigint(this.Ptr, i);

        public bool Adjacent(BigIntSpan s)
            => Meos.AdjacentSpansetSpan(this.Ptr, s.Ptr);

        public bool Adjacent(BigIntSpanSet ss2)
            => Meos.AdjacentSpansetSpanset(this.Ptr, ss2.Ptr);

        public string AsText(int maxdd)
            => this.Out(maxdd);

        public Span?[] Bins(long vsize, long vorigin, bool border_inc)
            => MEOSFactory.WrapSpanArray(Meos.BigintspansetBins(this.Ptr, vsize, vorigin, border_inc));

        public bool Contained(BigIntSpan s)
            => Meos.ContainedSpansetSpan(this.Ptr, s.Ptr);

        public bool Contained(BigIntSpanSet ss2)
            => Meos.ContainedSpansetSpanset(this.Ptr, ss2.Ptr);

        public bool Contains(long i)
            => Meos.ContainsSpansetBigint(this.Ptr, i);

        public bool Contains(BigIntSpan s)
            => Meos.ContainsSpansetSpan(this.Ptr, s.Ptr);

        public bool Contains(BigIntSpanSet ss2)
            => Meos.ContainsSpansetSpanset(this.Ptr, ss2.Ptr);

        public long Distance(BigIntSpan s)
            => Meos.DistanceBigintspansetBigintspan(this.Ptr, s.Ptr);

        public long Distance(BigIntSpanSet ss2)
            => Meos.DistanceBigintspansetBigintspanset(this.Ptr, ss2.Ptr);

        public long Distance(long i)
            => Meos.DistanceSpansetBigint(this.Ptr, i);

        public SpanSet? Intersection(long i)
            => MEOSFactory.WrapSpanSet(Meos.IntersectionSpansetBigint(this.Ptr, i));

        public SpanSet? Intersection(BigIntSpan s)
            => MEOSFactory.WrapSpanSet(Meos.IntersectionSpansetSpan(this.Ptr, s.Ptr));

        public SpanSet? Intersection(BigIntSpanSet ss2)
            => MEOSFactory.WrapSpanSet(Meos.IntersectionSpansetSpanset(this.Ptr, ss2.Ptr));

        public bool Left(long i)
            => Meos.LeftSpansetBigint(this.Ptr, i);

        public bool Left(BigIntSpan s)
            => Meos.LeftSpansetSpan(this.Ptr, s.Ptr);

        public bool Left(BigIntSpanSet ss2)
            => Meos.LeftSpansetSpanset(this.Ptr, ss2.Ptr);

        public long Lower()
            => Meos.BigintspansetLower(this.Ptr);

        public SpanSet? Minus(long i)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpansetBigint(this.Ptr, i));

        public SpanSet? Minus(BigIntSpan s)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpansetSpan(this.Ptr, s.Ptr));

        public SpanSet? Minus(BigIntSpanSet ss2)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpansetSpanset(this.Ptr, ss2.Ptr));

        public bool Overlaps(BigIntSpan s)
            => Meos.OverlapsSpansetSpan(this.Ptr, s.Ptr);

        public bool Overlaps(BigIntSpanSet ss2)
            => Meos.OverlapsSpansetSpanset(this.Ptr, ss2.Ptr);

        public bool Overleft(long i)
            => Meos.OverleftSpansetBigint(this.Ptr, i);

        public bool Overleft(BigIntSpan s)
            => Meos.OverleftSpansetSpan(this.Ptr, s.Ptr);

        public bool Overleft(BigIntSpanSet ss2)
            => Meos.OverleftSpansetSpanset(this.Ptr, ss2.Ptr);

        public bool Overright(long i)
            => Meos.OverrightSpansetBigint(this.Ptr, i);

        public bool Overright(BigIntSpan s)
            => Meos.OverrightSpansetSpan(this.Ptr, s.Ptr);

        public bool Overright(BigIntSpanSet ss2)
            => Meos.OverrightSpansetSpanset(this.Ptr, ss2.Ptr);

        public bool Radjacent(long i)
            => Meos.AdjacentBigintSpanset(i, this.Ptr);

        public bool Rcontained(long i)
            => Meos.ContainedBigintSpanset(i, this.Ptr);

        public bool Right(long i)
            => Meos.RightSpansetBigint(this.Ptr, i);

        public bool Right(BigIntSpan s)
            => Meos.RightSpansetSpan(this.Ptr, s.Ptr);

        public bool Right(BigIntSpanSet ss2)
            => Meos.RightSpansetSpanset(this.Ptr, ss2.Ptr);

        public SpanSet? Rintersection(long i)
            => MEOSFactory.WrapSpanSet(Meos.IntersectionBigintSpanset(i, this.Ptr));

        public bool Rleft(long i)
            => Meos.LeftBigintSpanset(i, this.Ptr);

        public SpanSet? Rminus(long i)
            => MEOSFactory.WrapSpanSet(Meos.MinusBigintSpanset(i, this.Ptr));

        public bool Roverleft(long i)
            => Meos.OverleftBigintSpanset(i, this.Ptr);

        public bool Roverright(long i)
            => Meos.OverrightBigintSpanset(i, this.Ptr);

        public bool Rright(long i)
            => Meos.RightBigintSpanset(i, this.Ptr);

        public SpanSet? Runion(long i)
            => MEOSFactory.WrapSpanSet(Meos.UnionBigintSpanset(i, this.Ptr));

        public SpanSet? ShiftScale(long shift, long width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSpanSet(Meos.BigintspansetShiftScale(this.Ptr, shift, width, hasshift, haswidth));

        public SpanSet? Union(long i)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpansetBigint(this.Ptr, i));

        public SpanSet? Union(BigIntSpan s)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpansetSpan(this.Ptr, s.Ptr));

        public SpanSet? Union(BigIntSpanSet ss2)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpansetSpanset(this.Ptr, ss2.Ptr));

        public long Upper()
            => Meos.BigintspansetUpper(this.Ptr);

        public long Width(bool boundspan)
            => Meos.BigintspansetWidth(this.Ptr, boundspan);

        public static SpanSet? FromBigint(long i)
            => MEOSFactory.WrapSpanSet(Meos.BigintToSpanset(i));

        public static SpanSet? FromText(string str)
            => BigIntSpanSet.In(str);

        public static SpanSet? In(string str)
            => MEOSFactory.WrapSpanSet(Meos.BigintspansetIn(str));

    }
}
