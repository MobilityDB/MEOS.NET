#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

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

        public DateOnly Lower()
            => MEOSConvert.ToDateOnly(Meos.DatespanLower(this.Ptr));

        public string Out()
            => Meos.DatespanOut(this.Ptr);

        public Span? ShiftScale(int shift, int width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSpan(Meos.DatespanShiftScale(this.Ptr, shift, width, hasshift, haswidth));

        public Span? ToTstzspan()
            => MEOSFactory.WrapSpan(Meos.DatespanToTstzspan(this.Ptr));

        public DateOnly Upper()
            => MEOSConvert.ToDateOnly(Meos.DatespanUpper(this.Ptr));

        public static Span? In(string str)
            => MEOSFactory.WrapSpan(Meos.DatespanIn(str));

        public static Span? Make(DateOnly lower, DateOnly upper, bool lower_inc, bool upper_inc)
            => MEOSFactory.WrapSpan(Meos.DatespanMake(MEOSConvert.ToDateADT(lower), MEOSConvert.ToDateADT(upper), lower_inc, upper_inc));

    }
}
