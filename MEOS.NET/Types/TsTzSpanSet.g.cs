#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TsTzSpanSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TsTzSpanSet : SpanSet
    {
        internal TsTzSpanSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public Span?[] Bins(Interval duration, DateTime torigin)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSpanArray(Meos.TstzspansetBins(this.Ptr, _duration, MEOSConvert.ToTimestampTz(torigin)));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public Interval? Duration(bool boundspan)
            => MEOSConvert.ToStruct<Interval>(Meos.TstzspansetDuration(this.Ptr, boundspan));

        public DateTime EndTimestamptz()
            => MEOSConvert.ToDateTime(Meos.TstzspansetEndTimestamptz(this.Ptr));

        public DateTime Lower()
            => MEOSConvert.ToDateTime(Meos.TstzspansetLower(this.Ptr));

        public int NumTimestamps()
            => Meos.TstzspansetNumTimestamps(this.Ptr);

        public string Out()
            => Meos.TstzspansetOut(this.Ptr);

        public SpanSet? ShiftScale(Interval shift, Interval duration)
        {
            IntPtr _shift = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(shift, _shift, false);
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSpanSet(Meos.TstzspansetShiftScale(this.Ptr, _shift, _duration));
            }
            finally
            {
                Marshal.FreeHGlobal(_shift);
                Marshal.FreeHGlobal(_duration);
            }
        }

        public DateTime StartTimestamptz()
            => MEOSConvert.ToDateTime(Meos.TstzspansetStartTimestamptz(this.Ptr));

        public Set? Timestamps()
            => MEOSFactory.WrapSet(Meos.TstzspansetTimestamps(this.Ptr));

        public DateTime? TimestamptzN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TstzspansetTimestamptzN(this.Ptr, n, _result))
                {
                    return null;
                }

                return MEOSConvert.ToDateTime(Marshal.ReadInt64(_result));
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public SpanSet? ToDatespanset()
            => MEOSFactory.WrapSpanSet(Meos.TstzspansetToDatespanset(this.Ptr));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.TstzspansetToStbox(this.Ptr));

        public SpanSet? Tprecision(Interval duration, DateTime torigin)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSpanSet(Meos.TstzspansetTprecision(this.Ptr, _duration, MEOSConvert.ToTimestampTz(torigin)));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public DateTime Upper()
            => MEOSConvert.ToDateTime(Meos.TstzspansetUpper(this.Ptr));

        public static SpanSet? In(string str)
            => MEOSFactory.WrapSpanSet(Meos.TstzspansetIn(str));

    }
}
