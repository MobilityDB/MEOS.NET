#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The DateSpan class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class DateSpan : Span
    {
        internal DateSpan(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public bool Adjacent(DateOnly d)
            => Meos.AdjacentSpanDate(this.Ptr, MEOSConvert.ToDateADT(d));

        public bool Adjacent(DateSpan s2)
            => Meos.AdjacentSpanSpan(this.Ptr, s2.Ptr);

        public bool Adjacent(DateSpanSet ss)
            => Meos.AdjacentSpanSpanset(this.Ptr, ss.Ptr);

        public bool After(DateOnly d)
            => Meos.AfterSpanDate(this.Ptr, MEOSConvert.ToDateADT(d));

        public string AsText()
            => this.Out();

        public bool Before(DateOnly d)
            => Meos.BeforeSpanDate(this.Ptr, MEOSConvert.ToDateADT(d));

        public Span?[] Bins(Interval duration, DateOnly torigin, bool border_inc)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSpanArray(Meos.DatespanBins(this.Ptr, _duration, MEOSConvert.ToDateADT(torigin), border_inc));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public bool Contained(DateSpan s2)
            => Meos.ContainedSpanSpan(this.Ptr, s2.Ptr);

        public bool Contained(DateSpanSet ss)
            => Meos.ContainedSpanSpanset(this.Ptr, ss.Ptr);

        public bool Contains(DateOnly d)
            => Meos.ContainsSpanDate(this.Ptr, MEOSConvert.ToDateADT(d));

        public bool Contains(DateSpan s2)
            => Meos.ContainsSpanSpan(this.Ptr, s2.Ptr);

        public bool Contains(DateSpanSet ss)
            => Meos.ContainsSpanSpanset(this.Ptr, ss.Ptr);

        public int Distance(DateSpan s2)
            => Meos.DistanceDatespanDatespan(this.Ptr, s2.Ptr);

        public int Distance(DateOnly d)
            => Meos.DistanceSpanDate(this.Ptr, MEOSConvert.ToDateADT(d));

        public Interval? Duration()
            => MEOSConvert.ToStruct<Interval>(Meos.DatespanDuration(this.Ptr));

        public Span? Intersection(DateOnly d)
            => MEOSFactory.WrapSpan(Meos.IntersectionSpanDate(this.Ptr, MEOSConvert.ToDateADT(d)));

        public Span? Intersection(DateSpan s2)
            => MEOSFactory.WrapSpan(Meos.IntersectionSpanSpan(this.Ptr, s2.Ptr));

        public SpanSet? Intersection(DateSpanSet ss)
            => MEOSFactory.WrapSpanSet(Meos.IntersectionSpanSpanset(this.Ptr, ss.Ptr));

        public bool Left(DateSpan s2)
            => Meos.LeftSpanSpan(this.Ptr, s2.Ptr);

        public bool Left(DateSpanSet ss)
            => Meos.LeftSpanSpanset(this.Ptr, ss.Ptr);

        public DateOnly Lower()
            => MEOSConvert.ToDateOnly(Meos.DatespanLower(this.Ptr));

        public SpanSet? Minus(DateOnly d)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpanDate(this.Ptr, MEOSConvert.ToDateADT(d)));

        public SpanSet? Minus(DateSpan s2)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpanSpan(this.Ptr, s2.Ptr));

        public SpanSet? Minus(DateSpanSet ss)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpanSpanset(this.Ptr, ss.Ptr));

        public string Out()
            => Meos.DatespanOut(this.Ptr);

        public bool Overafter(DateOnly d)
            => Meos.OverafterSpanDate(this.Ptr, MEOSConvert.ToDateADT(d));

        public bool Overbefore(DateOnly d)
            => Meos.OverbeforeSpanDate(this.Ptr, MEOSConvert.ToDateADT(d));

        public bool Overlaps(DateSpan s2)
            => Meos.OverlapsSpanSpan(this.Ptr, s2.Ptr);

        public bool Overlaps(DateSpanSet ss)
            => Meos.OverlapsSpanSpanset(this.Ptr, ss.Ptr);

        public bool Overleft(DateSpan s2)
            => Meos.OverleftSpanSpan(this.Ptr, s2.Ptr);

        public bool Overleft(DateSpanSet ss)
            => Meos.OverleftSpanSpanset(this.Ptr, ss.Ptr);

        public bool Overright(DateSpan s2)
            => Meos.OverrightSpanSpan(this.Ptr, s2.Ptr);

        public bool Overright(DateSpanSet ss)
            => Meos.OverrightSpanSpanset(this.Ptr, ss.Ptr);

        public bool Radjacent(DateOnly d)
            => Meos.AdjacentDateSpan(MEOSConvert.ToDateADT(d), this.Ptr);

        public bool Rafter(DateOnly d)
            => Meos.AfterDateSpan(MEOSConvert.ToDateADT(d), this.Ptr);

        public bool Rbefore(DateOnly d)
            => Meos.BeforeDateSpan(MEOSConvert.ToDateADT(d), this.Ptr);

        public bool Rcontained(DateOnly d)
            => Meos.ContainedDateSpan(MEOSConvert.ToDateADT(d), this.Ptr);

        public bool Right(DateSpan s2)
            => Meos.RightSpanSpan(this.Ptr, s2.Ptr);

        public bool Right(DateSpanSet ss)
            => Meos.RightSpanSpanset(this.Ptr, ss.Ptr);

        public Span? Rintersection(DateOnly d)
            => MEOSFactory.WrapSpan(Meos.IntersectionDateSpan(MEOSConvert.ToDateADT(d), this.Ptr));

        public SpanSet? Rminus(DateOnly d)
            => MEOSFactory.WrapSpanSet(Meos.MinusDateSpan(MEOSConvert.ToDateADT(d), this.Ptr));

        public bool Roverafter(DateOnly d)
            => Meos.OverafterDateSpan(MEOSConvert.ToDateADT(d), this.Ptr);

        public bool Roverbefore(DateOnly d)
            => Meos.OverbeforeDateSpan(MEOSConvert.ToDateADT(d), this.Ptr);

        public SpanSet? Runion(DateOnly d)
            => MEOSFactory.WrapSpanSet(Meos.UnionDateSpan(MEOSConvert.ToDateADT(d), this.Ptr));

        public Span? ShiftScale(int shift, int width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSpan(Meos.DatespanShiftScale(this.Ptr, shift, width, hasshift, haswidth));

        public Span? ToTstzspan()
            => MEOSFactory.WrapSpan(Meos.DatespanToTstzspan(this.Ptr));

        public SpanSet? Union(DateOnly d)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpanDate(this.Ptr, MEOSConvert.ToDateADT(d)));

        public SpanSet? Union(DateSpan s2)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpanSpan(this.Ptr, s2.Ptr));

        public SpanSet? Union(DateSpanSet ss)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpanSpanset(this.Ptr, ss.Ptr));

        public DateOnly Upper()
            => MEOSConvert.ToDateOnly(Meos.DatespanUpper(this.Ptr));

        public static Span? FromDate(DateOnly d)
            => MEOSFactory.WrapSpan(Meos.DateToSpan(MEOSConvert.ToDateADT(d)));

        public static Span? FromText(string str)
            => DateSpan.In(str);

        public static Span? GetBin(DateOnly d, Interval duration, DateOnly torigin)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSpan(Meos.DatespanGetBin(MEOSConvert.ToDateADT(d), _duration, MEOSConvert.ToDateADT(torigin)));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public static Span? In(string str)
            => MEOSFactory.WrapSpan(Meos.DatespanIn(str));

        public static Span? Make(DateOnly lower, DateOnly upper, bool lower_inc, bool upper_inc)
            => MEOSFactory.WrapSpan(Meos.DatespanMake(MEOSConvert.ToDateADT(lower), MEOSConvert.ToDateADT(upper), lower_inc, upper_inc));

    }
}
