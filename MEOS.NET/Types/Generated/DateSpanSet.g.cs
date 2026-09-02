#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The DateSpanSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class DateSpanSet : SpanSet
    {
        internal DateSpanSet(IntPtr ptr) : base(ptr) { }

        public Set? Dates()
            => MEOSFactory.WrapSet(MEOSExposedFunctions.datespanset_dates(this.Ptr));

        public DateOnly EndDate()
            => MEOSConvert.ToDateOnly(MEOSExposedFunctions.datespanset_end_date(this.Ptr));

        public DateOnly Lower()
            => MEOSConvert.ToDateOnly(MEOSExposedFunctions.datespanset_lower(this.Ptr));

        public int NumDates()
            => MEOSExposedFunctions.datespanset_num_dates(this.Ptr);

        public string Out()
            => MEOSExposedFunctions.datespanset_out(this.Ptr);

        public SpanSet? ShiftScale(int shift, int width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSpanSet(MEOSExposedFunctions.datespanset_shift_scale(this.Ptr, shift, width, hasshift, haswidth));

        public DateOnly StartDate()
            => MEOSConvert.ToDateOnly(MEOSExposedFunctions.datespanset_start_date(this.Ptr));

        public SpanSet? ToTstzspanset()
            => MEOSFactory.WrapSpanSet(MEOSExposedFunctions.datespanset_to_tstzspanset(this.Ptr));

        public DateOnly Upper()
            => MEOSConvert.ToDateOnly(MEOSExposedFunctions.datespanset_upper(this.Ptr));

        public static SpanSet? In(string str)
            => MEOSFactory.WrapSpanSet(MEOSExposedFunctions.datespanset_in(str));

    }
}
