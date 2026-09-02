#nullable enable

using MEOS.NET.Enums;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Generated
{
    /// <summary>The DateSpan class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class DateSpan : Span
    {
        internal DateSpan(IntPtr ptr) : base(ptr) { }

        public DateOnly Lower()
            => MEOSConvert.ToDateOnly(MEOSExposedFunctions.datespan_lower(this.Ptr));

        public string Out()
            => MEOSExposedFunctions.datespan_out(this.Ptr);

        public Span? ShiftScale(int shift, int width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.datespan_shift_scale(this.Ptr, shift, width, hasshift, haswidth));

        public Span? ToTstzspan()
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.datespan_to_tstzspan(this.Ptr));

        public DateOnly Upper()
            => MEOSConvert.ToDateOnly(MEOSExposedFunctions.datespan_upper(this.Ptr));

        public static Span? In(string str)
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.datespan_in(str));

        public static Span? Make(DateOnly lower, DateOnly upper, bool lower_inc, bool upper_inc)
            => MEOSFactory.WrapSpan(MEOSExposedFunctions.datespan_make(MEOSConvert.ToDateADT(lower), MEOSConvert.ToDateADT(upper), lower_inc, upper_inc));

    }
}
