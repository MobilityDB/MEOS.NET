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

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public bool Adjacent(long i)
            => Meos.AdjacentSpansetBigint(this.Ptr, i);

        public string AsText()
            => this.Out();

        public Span?[] Bins(long vsize, long vorigin, bool border_inc)
            => MEOSFactory.WrapSpanArray(Meos.BigintspansetBins(this.Ptr, vsize, vorigin, border_inc));

        public bool Contains(long i)
            => Meos.ContainsSpansetBigint(this.Ptr, i);

        public long Distance(BigIntSpan s)
            => Meos.DistanceBigintspansetBigintspan(this.Ptr, s.Ptr);

        public long Distance(BigIntSpanSet ss2)
            => Meos.DistanceBigintspansetBigintspanset(this.Ptr, ss2.Ptr);

        public long Distance(long i)
            => Meos.DistanceSpansetBigint(this.Ptr, i);

        public SpanSet? Intersection(long i)
            => MEOSFactory.WrapSpanSet(Meos.IntersectionSpansetBigint(this.Ptr, i));

        public bool Left(long i)
            => Meos.LeftSpansetBigint(this.Ptr, i);

        public long Lower()
            => Meos.BigintspansetLower(this.Ptr);

        public SpanSet? Minus(long i)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpansetBigint(this.Ptr, i));

        public string Out()
            => Meos.BigintspansetOut(this.Ptr);

        public bool Overleft(long i)
            => Meos.OverleftSpansetBigint(this.Ptr, i);

        public bool Overright(long i)
            => Meos.OverrightSpansetBigint(this.Ptr, i);

        public bool Radjacent(long i)
            => Meos.AdjacentBigintSpanset(i, this.Ptr);

        public bool Rcontained(long i)
            => Meos.ContainedBigintSpanset(i, this.Ptr);

        public bool Right(long i)
            => Meos.RightSpansetBigint(this.Ptr, i);

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
