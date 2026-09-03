#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TsTzSpan class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TsTzSpan : Span
    {
        internal TsTzSpan(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public Span?[] Bins(Interval duration, DateTime origin)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSpanArray(Meos.TstzspanBins(this.Ptr, _duration, MEOSConvert.ToTimestampTz(origin)));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public Interval? Duration()
            => MEOSConvert.ToStruct<Interval>(Meos.TstzspanDuration(this.Ptr));

        public Span? Expand(Interval interv)
        {
            IntPtr _interv = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(interv, _interv, false);
                return MEOSFactory.WrapSpan(Meos.TstzspanExpand(this.Ptr, _interv));
            }
            finally
            {
                Marshal.FreeHGlobal(_interv);
            }
        }

        public DateTime Lower()
            => MEOSConvert.ToDateTime(Meos.TstzspanLower(this.Ptr));

        public string Out()
            => Meos.TstzspanOut(this.Ptr);

        public Span? ShiftScale(Interval shift, Interval duration)
        {
            IntPtr _shift = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(shift, _shift, false);
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSpan(Meos.TstzspanShiftScale(this.Ptr, _shift, _duration));
            }
            finally
            {
                Marshal.FreeHGlobal(_shift);
                Marshal.FreeHGlobal(_duration);
            }
        }

        public Span? ToDatespan()
            => MEOSFactory.WrapSpan(Meos.TstzspanToDatespan(this.Ptr));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.TstzspanToStbox(this.Ptr));

        public Span? Tprecision(Interval duration, DateTime torigin)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSpan(Meos.TstzspanTprecision(this.Ptr, _duration, MEOSConvert.ToTimestampTz(torigin)));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public DateTime Upper()
            => MEOSConvert.ToDateTime(Meos.TstzspanUpper(this.Ptr));

        public static Span? In(string str)
            => MEOSFactory.WrapSpan(Meos.TstzspanIn(str));

        public static Span? Make(DateTime lower, DateTime upper, bool lower_inc, bool upper_inc)
            => MEOSFactory.WrapSpan(Meos.TstzspanMake(MEOSConvert.ToTimestampTz(lower), MEOSConvert.ToTimestampTz(upper), lower_inc, upper_inc));

    }
}
