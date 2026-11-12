#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The DateSpanSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class DateSpanSet : SpanSet
    {
        internal DateSpanSet(IntPtr ptr) : base(ptr) { }

        public bool Adjacent(DateOnly d)
            => Meos.AdjacentSpansetDate(this.Ptr, MEOSConvert.ToDateADT(d));

        public bool Adjacent(DateSpan s)
            => Meos.AdjacentSpansetSpan(this.Ptr, s.Ptr);

        public bool Adjacent(DateSpanSet ss2)
            => Meos.AdjacentSpansetSpanset(this.Ptr, ss2.Ptr);

        public bool After(DateOnly d)
            => Meos.AfterSpansetDate(this.Ptr, MEOSConvert.ToDateADT(d));

        public bool Before(DateOnly d)
            => Meos.BeforeSpansetDate(this.Ptr, MEOSConvert.ToDateADT(d));

        public Span?[] Bins(Interval duration, DateOnly torigin, bool border_inc)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSpanArray(Meos.DatespansetBins(this.Ptr, _duration, MEOSConvert.ToDateADT(torigin), border_inc));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public bool Contained(DateSpan s)
            => Meos.ContainedSpansetSpan(this.Ptr, s.Ptr);

        public bool Contained(DateSpanSet ss2)
            => Meos.ContainedSpansetSpanset(this.Ptr, ss2.Ptr);

        public bool Contains(DateOnly d)
            => Meos.ContainsSpansetDate(this.Ptr, MEOSConvert.ToDateADT(d));

        public bool Contains(DateSpan s)
            => Meos.ContainsSpansetSpan(this.Ptr, s.Ptr);

        public bool Contains(DateSpanSet ss2)
            => Meos.ContainsSpansetSpanset(this.Ptr, ss2.Ptr);

        public DateOnly? DateN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(4);
            try
            {
                if (!Meos.DatespansetDateN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSConvert.ToDateOnly(Marshal.ReadInt32(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public Set? Dates()
            => MEOSFactory.WrapSet(Meos.DatespansetDates(this.Ptr));

        public int Distance(DateSpan s)
            => Meos.DistanceDatespansetDatespan(this.Ptr, s.Ptr);

        public int Distance(DateSpanSet ss2)
            => Meos.DistanceDatespansetDatespanset(this.Ptr, ss2.Ptr);

        public int Distance(DateOnly d)
            => Meos.DistanceSpansetDate(this.Ptr, MEOSConvert.ToDateADT(d));

        public Interval? Duration(bool boundspan)
            => MEOSConvert.ToStruct<Interval>(Meos.DatespansetDuration(this.Ptr, boundspan));

        public DateOnly EndDate()
            => MEOSConvert.ToDateOnly(Meos.DatespansetEndDate(this.Ptr));

        public SpanSet? Intersection(DateOnly d)
            => MEOSFactory.WrapSpanSet(Meos.IntersectionSpansetDate(this.Ptr, MEOSConvert.ToDateADT(d)));

        public SpanSet? Intersection(DateSpan s)
            => MEOSFactory.WrapSpanSet(Meos.IntersectionSpansetSpan(this.Ptr, s.Ptr));

        public SpanSet? Intersection(DateSpanSet ss2)
            => MEOSFactory.WrapSpanSet(Meos.IntersectionSpansetSpanset(this.Ptr, ss2.Ptr));

        public bool Left(DateSpan s)
            => Meos.LeftSpansetSpan(this.Ptr, s.Ptr);

        public bool Left(DateSpanSet ss2)
            => Meos.LeftSpansetSpanset(this.Ptr, ss2.Ptr);

        public DateOnly Lower()
            => MEOSConvert.ToDateOnly(Meos.DatespansetLower(this.Ptr));

        public SpanSet? Minus(DateOnly d)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpansetDate(this.Ptr, MEOSConvert.ToDateADT(d)));

        public SpanSet? Minus(DateSpan s)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpansetSpan(this.Ptr, s.Ptr));

        public SpanSet? Minus(DateSpanSet ss2)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpansetSpanset(this.Ptr, ss2.Ptr));

        public int NumDates()
            => Meos.DatespansetNumDates(this.Ptr);

        public bool Overafter(DateOnly d)
            => Meos.OverafterSpansetDate(this.Ptr, MEOSConvert.ToDateADT(d));

        public bool Overbefore(DateOnly d)
            => Meos.OverbeforeSpansetDate(this.Ptr, MEOSConvert.ToDateADT(d));

        public bool Overlaps(DateSpan s)
            => Meos.OverlapsSpansetSpan(this.Ptr, s.Ptr);

        public bool Overlaps(DateSpanSet ss2)
            => Meos.OverlapsSpansetSpanset(this.Ptr, ss2.Ptr);

        public bool Overleft(DateSpan s)
            => Meos.OverleftSpansetSpan(this.Ptr, s.Ptr);

        public bool Overleft(DateSpanSet ss2)
            => Meos.OverleftSpansetSpanset(this.Ptr, ss2.Ptr);

        public bool Overright(DateSpan s)
            => Meos.OverrightSpansetSpan(this.Ptr, s.Ptr);

        public bool Overright(DateSpanSet ss2)
            => Meos.OverrightSpansetSpanset(this.Ptr, ss2.Ptr);

        public bool Radjacent(DateOnly d)
            => Meos.AdjacentDateSpanset(MEOSConvert.ToDateADT(d), this.Ptr);

        public bool Rafter(DateOnly d)
            => Meos.AfterDateSpanset(MEOSConvert.ToDateADT(d), this.Ptr);

        public bool Rbefore(DateOnly d)
            => Meos.BeforeDateSpanset(MEOSConvert.ToDateADT(d), this.Ptr);

        public bool Rcontained(DateOnly d)
            => Meos.ContainedDateSpanset(MEOSConvert.ToDateADT(d), this.Ptr);

        public bool Right(DateSpan s)
            => Meos.RightSpansetSpan(this.Ptr, s.Ptr);

        public bool Right(DateSpanSet ss2)
            => Meos.RightSpansetSpanset(this.Ptr, ss2.Ptr);

        public SpanSet? Rintersection(DateOnly d)
            => MEOSFactory.WrapSpanSet(Meos.IntersectionDateSpanset(MEOSConvert.ToDateADT(d), this.Ptr));

        public SpanSet? Rminus(DateOnly d)
            => MEOSFactory.WrapSpanSet(Meos.MinusDateSpanset(MEOSConvert.ToDateADT(d), this.Ptr));

        public bool Roverafter(DateOnly d)
            => Meos.OverafterDateSpanset(MEOSConvert.ToDateADT(d), this.Ptr);

        public bool Roverbefore(DateOnly d)
            => Meos.OverbeforeDateSpanset(MEOSConvert.ToDateADT(d), this.Ptr);

        public SpanSet? Runion(DateOnly d)
            => MEOSFactory.WrapSpanSet(Meos.UnionDateSpanset(MEOSConvert.ToDateADT(d), this.Ptr));

        public SpanSet? ShiftScale(int shift, int width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSpanSet(Meos.DatespansetShiftScale(this.Ptr, shift, width, hasshift, haswidth));

        public DateOnly StartDate()
            => MEOSConvert.ToDateOnly(Meos.DatespansetStartDate(this.Ptr));

        public SpanSet? ToTstzspanset()
            => MEOSFactory.WrapSpanSet(Meos.DatespansetToTstzspanset(this.Ptr));

        public SpanSet? Union(DateOnly d)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpansetDate(this.Ptr, MEOSConvert.ToDateADT(d)));

        public SpanSet? Union(DateSpan s)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpansetSpan(this.Ptr, s.Ptr));

        public SpanSet? Union(DateSpanSet ss2)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpansetSpanset(this.Ptr, ss2.Ptr));

        public DateOnly Upper()
            => MEOSConvert.ToDateOnly(Meos.DatespansetUpper(this.Ptr));

        public static SpanSet? FromDate(DateOnly d)
            => MEOSFactory.WrapSpanSet(Meos.DateToSpanset(MEOSConvert.ToDateADT(d)));

        public static SpanSet? FromText(string str)
            => MEOSFactory.WrapSpanSet(Meos.DatespansetIn(str));

    }
}
