#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;

namespace MEOS.NET.Types
{
    /// <summary>The DateSpanSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class DateSpanSet : SpanSet
    {
        internal DateSpanSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

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

        public DateOnly EndDate()
            => MEOSConvert.ToDateOnly(Meos.DatespansetEndDate(this.Ptr));

        public DateOnly Lower()
            => MEOSConvert.ToDateOnly(Meos.DatespansetLower(this.Ptr));

        public int NumDates()
            => Meos.DatespansetNumDates(this.Ptr);

        public string Out()
            => Meos.DatespansetOut(this.Ptr);

        public SpanSet? ShiftScale(int shift, int width, bool hasshift, bool haswidth)
            => MEOSFactory.WrapSpanSet(Meos.DatespansetShiftScale(this.Ptr, shift, width, hasshift, haswidth));

        public DateOnly StartDate()
            => MEOSConvert.ToDateOnly(Meos.DatespansetStartDate(this.Ptr));

        public SpanSet? ToTstzspanset()
            => MEOSFactory.WrapSpanSet(Meos.DatespansetToTstzspanset(this.Ptr));

        public DateOnly Upper()
            => MEOSConvert.ToDateOnly(Meos.DatespansetUpper(this.Ptr));

        public static SpanSet? In(string str)
            => MEOSFactory.WrapSpanSet(Meos.DatespansetIn(str));

    }
}
