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

        public bool Contains(DateOnly d)
            => Meos.ContainsSpanDate(this.Ptr, MEOSConvert.ToDateADT(d));

        public int Distance(DateSpan s2)
            => Meos.DistanceDatespanDatespan(this.Ptr, s2.Ptr);

        public int Distance(DateOnly d)
            => Meos.DistanceSpanDate(this.Ptr, MEOSConvert.ToDateADT(d));

        public Interval? Duration()
            => MEOSConvert.ToStruct<Interval>(Meos.DatespanDuration(this.Ptr));

        public Span? Intersection(DateOnly d)
            => MEOSFactory.WrapSpan(Meos.IntersectionSpanDate(this.Ptr, MEOSConvert.ToDateADT(d)));

        public DateOnly Lower()
            => MEOSConvert.ToDateOnly(Meos.DatespanLower(this.Ptr));

        public SpanSet? Minus(DateOnly d)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpanDate(this.Ptr, MEOSConvert.ToDateADT(d)));

        public string Out()
            => Meos.DatespanOut(this.Ptr);

        public bool Overafter(DateOnly d)
            => Meos.OverafterSpanDate(this.Ptr, MEOSConvert.ToDateADT(d));

        public bool Overbefore(DateOnly d)
            => Meos.OverbeforeSpanDate(this.Ptr, MEOSConvert.ToDateADT(d));

        public bool Radjacent(DateOnly d)
            => Meos.AdjacentDateSpan(MEOSConvert.ToDateADT(d), this.Ptr);

        public bool Rafter(DateOnly d)
            => Meos.AfterDateSpan(MEOSConvert.ToDateADT(d), this.Ptr);

        public bool Rbefore(DateOnly d)
            => Meos.BeforeDateSpan(MEOSConvert.ToDateADT(d), this.Ptr);

        public bool Rcontained(DateOnly d)
            => Meos.ContainedDateSpan(MEOSConvert.ToDateADT(d), this.Ptr);

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
