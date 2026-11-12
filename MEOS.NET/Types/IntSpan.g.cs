#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The IntSpan class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class IntSpan : Span
    {
        internal IntSpan(IntPtr ptr) : base(ptr) { }

        public bool Adjacent(int i)
            => Meos.AdjacentSpanInt(this.Ptr, i);

        public bool Adjacent(IntSpan s2)
            => Meos.AdjacentSpanSpan(this.Ptr, s2.Ptr);

        public bool Adjacent(IntSpanSet ss)
            => Meos.AdjacentSpanSpanset(this.Ptr, ss.Ptr);

        public Span?[] Bins(int vsize, int vorigin, bool border_inc)
            => MEOSFactory.WrapSpanArray(Meos.IntspanBins(this.Ptr, vsize, vorigin, border_inc));

        public bool Contained(IntSpan s2)
            => Meos.ContainedSpanSpan(this.Ptr, s2.Ptr);

        public bool Contained(IntSpanSet ss)
            => Meos.ContainedSpanSpanset(this.Ptr, ss.Ptr);

        public bool Contains(int i)
            => Meos.ContainsSpanInt(this.Ptr, i);

        public bool Contains(IntSpan s2)
            => Meos.ContainsSpanSpan(this.Ptr, s2.Ptr);

        public bool Contains(IntSpanSet ss)
            => Meos.ContainsSpanSpanset(this.Ptr, ss.Ptr);

        public int Distance(IntSpan s2)
            => Meos.DistanceIntspanIntspan(this.Ptr, s2.Ptr);

        public int Distance(int i)
            => Meos.DistanceSpanInt(this.Ptr, i);

        public Span? Expand(int value)
            => MEOSFactory.WrapSpan(Meos.IntspanExpand(this.Ptr, value));

        public Span? Intersection(int i)
            => MEOSFactory.WrapSpan(Meos.IntersectionSpanInt(this.Ptr, i));

        public Span? Intersection(IntSpan s2)
            => MEOSFactory.WrapSpan(Meos.IntersectionSpanSpan(this.Ptr, s2.Ptr));

        public SpanSet? Intersection(IntSpanSet ss)
            => MEOSFactory.WrapSpanSet(Meos.IntersectionSpanSpanset(this.Ptr, ss.Ptr));

        public bool Left(int i)
            => Meos.LeftSpanInt(this.Ptr, i);

        public bool Left(IntSpan s2)
            => Meos.LeftSpanSpan(this.Ptr, s2.Ptr);

        public bool Left(IntSpanSet ss)
            => Meos.LeftSpanSpanset(this.Ptr, ss.Ptr);

        public int Lower()
            => Meos.IntspanLower(this.Ptr);

        public SpanSet? Minus(int i)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpanInt(this.Ptr, i));

        public SpanSet? Minus(IntSpan s2)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpanSpan(this.Ptr, s2.Ptr));

        public SpanSet? Minus(IntSpanSet ss)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpanSpanset(this.Ptr, ss.Ptr));

        public int Nad(TBox box)
            => Meos.NadIntspanTbox(this.Ptr, box.Ptr);

        public bool Overlaps(IntSpan s2)
            => Meos.OverlapsSpanSpan(this.Ptr, s2.Ptr);

        public bool Overlaps(IntSpanSet ss)
            => Meos.OverlapsSpanSpanset(this.Ptr, ss.Ptr);

        public bool Overleft(int i)
            => Meos.OverleftSpanInt(this.Ptr, i);

        public bool Overleft(IntSpan s2)
            => Meos.OverleftSpanSpan(this.Ptr, s2.Ptr);

        public bool Overleft(IntSpanSet ss)
            => Meos.OverleftSpanSpanset(this.Ptr, ss.Ptr);

        public bool Overright(int i)
            => Meos.OverrightSpanInt(this.Ptr, i);

        public bool Overright(IntSpan s2)
            => Meos.OverrightSpanSpan(this.Ptr, s2.Ptr);

        public bool Overright(IntSpanSet ss)
            => Meos.OverrightSpanSpanset(this.Ptr, ss.Ptr);

        public bool Radjacent(int i)
            => Meos.AdjacentIntSpan(i, this.Ptr);

        public bool Rcontained(int i)
            => Meos.ContainedIntSpan(i, this.Ptr);

        public bool Right(int i)
            => Meos.RightSpanInt(this.Ptr, i);

        public bool Right(IntSpan s2)
            => Meos.RightSpanSpan(this.Ptr, s2.Ptr);

        public bool Right(IntSpanSet ss)
            => Meos.RightSpanSpanset(this.Ptr, ss.Ptr);

        public Span? Rintersection(int i)
            => MEOSFactory.WrapSpan(Meos.IntersectionIntSpan(i, this.Ptr));

        public bool Rleft(int i)
            => Meos.LeftIntSpan(i, this.Ptr);

        public SpanSet? Rminus(int i)
            => MEOSFactory.WrapSpanSet(Meos.MinusIntSpan(i, this.Ptr));

        public bool Roverleft(int i)
            => Meos.OverleftIntSpan(i, this.Ptr);

        public bool Roverright(int i)
            => Meos.OverrightIntSpan(i, this.Ptr);

        public bool Rright(int i)
            => Meos.RightIntSpan(i, this.Ptr);

        public SpanSet? Runion(int i)
            => MEOSFactory.WrapSpanSet(Meos.UnionIntSpan(i, this.Ptr));

        public Span? ShiftScale(int shift, int width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSpan(Meos.IntspanShiftScale(this.Ptr, shift, width, hasshift, haswidth));

        public Span? ToBigintspan()
            => MEOSFactory.WrapSpan(Meos.IntspanToBigintspan(this.Ptr));

        public Span? ToFloatspan()
            => MEOSFactory.WrapSpan(Meos.IntspanToFloatspan(this.Ptr));

        public SpanSet? Union(int i)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpanInt(this.Ptr, i));

        public SpanSet? Union(IntSpan s2)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpanSpan(this.Ptr, s2.Ptr));

        public SpanSet? Union(IntSpanSet ss)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpanSpanset(this.Ptr, ss.Ptr));

        public int Upper()
            => Meos.IntspanUpper(this.Ptr);

        public int Width()
            => Meos.IntspanWidth(this.Ptr);

        public static Span? FromInt(int i)
            => MEOSFactory.WrapSpan(Meos.IntToSpan(i));

        public static Span? FromText(string str)
            => MEOSFactory.WrapSpan(Meos.IntspanIn(str));

        public static Span? GetBin(int value, int vsize, int vorigin)
            => MEOSFactory.WrapSpan(Meos.IntspanGetBin(value, vsize, vorigin));

        public static Span? Make(int lower, int upper, bool lower_inc, bool upper_inc)
            => MEOSFactory.WrapSpan(Meos.IntspanMake(lower, upper, lower_inc, upper_inc));

    }
}
