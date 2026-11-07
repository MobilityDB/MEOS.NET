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

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public bool Adjacent(int i)
            => Meos.AdjacentSpanInt(this.Ptr, i);

        public string AsText()
            => this.Out();

        public Span?[] Bins(int vsize, int vorigin, bool border_inc)
            => MEOSFactory.WrapSpanArray(Meos.IntspanBins(this.Ptr, vsize, vorigin, border_inc));

        public bool Contains(int i)
            => Meos.ContainsSpanInt(this.Ptr, i);

        public int Distance(IntSpan s2)
            => Meos.DistanceIntspanIntspan(this.Ptr, s2.Ptr);

        public int Distance(int i)
            => Meos.DistanceSpanInt(this.Ptr, i);

        public Span? Expand(int value)
            => MEOSFactory.WrapSpan(Meos.IntspanExpand(this.Ptr, value));

        public Span? Intersection(int i)
            => MEOSFactory.WrapSpan(Meos.IntersectionSpanInt(this.Ptr, i));

        public bool Left(int i)
            => Meos.LeftSpanInt(this.Ptr, i);

        public int Lower()
            => Meos.IntspanLower(this.Ptr);

        public SpanSet? Minus(int i)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpanInt(this.Ptr, i));

        public int Nad(TBox box)
            => Meos.NadIntspanTbox(this.Ptr, box.Ptr);

        public string Out()
            => Meos.IntspanOut(this.Ptr);

        public bool Overleft(int i)
            => Meos.OverleftSpanInt(this.Ptr, i);

        public bool Overright(int i)
            => Meos.OverrightSpanInt(this.Ptr, i);

        public bool Radjacent(int i)
            => Meos.AdjacentIntSpan(i, this.Ptr);

        public bool Rcontained(int i)
            => Meos.ContainedIntSpan(i, this.Ptr);

        public bool Right(int i)
            => Meos.RightSpanInt(this.Ptr, i);

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

        public int Upper()
            => Meos.IntspanUpper(this.Ptr);

        public int Width()
            => Meos.IntspanWidth(this.Ptr);

        public static Span? FromInt(int i)
            => MEOSFactory.WrapSpan(Meos.IntToSpan(i));

        public static Span? FromText(string str)
            => IntSpan.In(str);

        public static Span? GetBin(int value, int vsize, int vorigin)
            => MEOSFactory.WrapSpan(Meos.IntspanGetBin(value, vsize, vorigin));

        public static Span? In(string str)
            => MEOSFactory.WrapSpan(Meos.IntspanIn(str));

        public static Span? Make(int lower, int upper, bool lower_inc, bool upper_inc)
            => MEOSFactory.WrapSpan(Meos.IntspanMake(lower, upper, lower_inc, upper_inc));

    }
}
