#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The BigIntSpan class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class BigIntSpan : Span
    {
        internal BigIntSpan(IntPtr ptr) : base(ptr) { }

        public bool Adjacent(long i)
            => Meos.AdjacentSpanBigint(this.Ptr, i);

        public bool Adjacent(BigIntSpan s2)
            => Meos.AdjacentSpanSpan(this.Ptr, s2.Ptr);

        public bool Adjacent(BigIntSpanSet ss)
            => Meos.AdjacentSpanSpanset(this.Ptr, ss.Ptr);

        public Span?[] Bins(long vsize, long vorigin, bool border_inc)
            => MEOSFactory.WrapSpanArray(Meos.BigintspanBins(this.Ptr, vsize, vorigin, border_inc));

        public bool Contained(BigIntSpan s2)
            => Meos.ContainedSpanSpan(this.Ptr, s2.Ptr);

        public bool Contained(BigIntSpanSet ss)
            => Meos.ContainedSpanSpanset(this.Ptr, ss.Ptr);

        public bool Contains(long i)
            => Meos.ContainsSpanBigint(this.Ptr, i);

        public bool Contains(BigIntSpan s2)
            => Meos.ContainsSpanSpan(this.Ptr, s2.Ptr);

        public bool Contains(BigIntSpanSet ss)
            => Meos.ContainsSpanSpanset(this.Ptr, ss.Ptr);

        public long Distance(BigIntSpan s2)
            => Meos.DistanceBigintspanBigintspan(this.Ptr, s2.Ptr);

        public long Distance(long i)
            => Meos.DistanceSpanBigint(this.Ptr, i);

        public Span? Expand(long value)
            => MEOSFactory.WrapSpan(Meos.BigintspanExpand(this.Ptr, value));

        public Span? Intersection(long i)
            => MEOSFactory.WrapSpan(Meos.IntersectionSpanBigint(this.Ptr, i));

        public Span? Intersection(BigIntSpan s2)
            => MEOSFactory.WrapSpan(Meos.IntersectionSpanSpan(this.Ptr, s2.Ptr));

        public SpanSet? Intersection(BigIntSpanSet ss)
            => MEOSFactory.WrapSpanSet(Meos.IntersectionSpanSpanset(this.Ptr, ss.Ptr));

        public bool Left(long i)
            => Meos.LeftSpanBigint(this.Ptr, i);

        public bool Left(BigIntSpan s2)
            => Meos.LeftSpanSpan(this.Ptr, s2.Ptr);

        public bool Left(BigIntSpanSet ss)
            => Meos.LeftSpanSpanset(this.Ptr, ss.Ptr);

        public long Lower()
            => Meos.BigintspanLower(this.Ptr);

        public SpanSet? Minus(long i)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpanBigint(this.Ptr, i));

        public SpanSet? Minus(BigIntSpan s2)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpanSpan(this.Ptr, s2.Ptr));

        public SpanSet? Minus(BigIntSpanSet ss)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpanSpanset(this.Ptr, ss.Ptr));

        public long Nad(TBox box)
            => Meos.NadBigintspanTbox(this.Ptr, box.Ptr);

        public bool Overlaps(BigIntSpan s2)
            => Meos.OverlapsSpanSpan(this.Ptr, s2.Ptr);

        public bool Overlaps(BigIntSpanSet ss)
            => Meos.OverlapsSpanSpanset(this.Ptr, ss.Ptr);

        public bool Overleft(long i)
            => Meos.OverleftSpanBigint(this.Ptr, i);

        public bool Overleft(BigIntSpan s2)
            => Meos.OverleftSpanSpan(this.Ptr, s2.Ptr);

        public bool Overleft(BigIntSpanSet ss)
            => Meos.OverleftSpanSpanset(this.Ptr, ss.Ptr);

        public bool Overright(long i)
            => Meos.OverrightSpanBigint(this.Ptr, i);

        public bool Overright(BigIntSpan s2)
            => Meos.OverrightSpanSpan(this.Ptr, s2.Ptr);

        public bool Overright(BigIntSpanSet ss)
            => Meos.OverrightSpanSpanset(this.Ptr, ss.Ptr);

        public bool Radjacent(long i)
            => Meos.AdjacentBigintSpan(i, this.Ptr);

        public bool Rcontained(long i)
            => Meos.ContainedBigintSpan(i, this.Ptr);

        public bool Right(long i)
            => Meos.RightSpanBigint(this.Ptr, i);

        public bool Right(BigIntSpan s2)
            => Meos.RightSpanSpan(this.Ptr, s2.Ptr);

        public bool Right(BigIntSpanSet ss)
            => Meos.RightSpanSpanset(this.Ptr, ss.Ptr);

        public Span? Rintersection(long i)
            => MEOSFactory.WrapSpan(Meos.IntersectionBigintSpan(i, this.Ptr));

        public bool Rleft(long i)
            => Meos.LeftBigintSpan(i, this.Ptr);

        public SpanSet? Rminus(long i)
            => MEOSFactory.WrapSpanSet(Meos.MinusBigintSpan(i, this.Ptr));

        public bool Roverleft(long i)
            => Meos.OverleftBigintSpan(i, this.Ptr);

        public bool Roverright(long i)
            => Meos.OverrightBigintSpan(i, this.Ptr);

        public bool Rright(long i)
            => Meos.RightBigintSpan(i, this.Ptr);

        public SpanSet? Runion(long i)
            => MEOSFactory.WrapSpanSet(Meos.UnionBigintSpan(i, this.Ptr));

        public Span? ShiftScale(long shift, long width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSpan(Meos.BigintspanShiftScale(this.Ptr, shift, width, hasshift, haswidth));

        public Span? ToFloatspan()
            => MEOSFactory.WrapSpan(Meos.BigintspanToFloatspan(this.Ptr));

        public Span? ToIntspan()
            => MEOSFactory.WrapSpan(Meos.BigintspanToIntspan(this.Ptr));

        public SpanSet? Union(long i)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpanBigint(this.Ptr, i));

        public SpanSet? Union(BigIntSpan s2)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpanSpan(this.Ptr, s2.Ptr));

        public SpanSet? Union(BigIntSpanSet ss)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpanSpanset(this.Ptr, ss.Ptr));

        public long Upper()
            => Meos.BigintspanUpper(this.Ptr);

        public long Width()
            => Meos.BigintspanWidth(this.Ptr);

        public static Span? FromBigint(long i)
            => MEOSFactory.WrapSpan(Meos.BigintToSpan(i));

        public static Span? FromText(string str)
            => MEOSFactory.WrapSpan(Meos.BigintspanIn(str));

        public static Span? GetBin(long value, long vsize, long vorigin)
            => MEOSFactory.WrapSpan(Meos.BigintspanGetBin(value, vsize, vorigin));

        public static Span? Make(long lower, long upper, bool lower_inc, bool upper_inc)
            => MEOSFactory.WrapSpan(Meos.BigintspanMake(lower, upper, lower_inc, upper_inc));

    }
}
