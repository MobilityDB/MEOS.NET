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

        public bool Adjacent(DateTime t)
            => Meos.AdjacentSpansetTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t));

        public bool After(DateTime t)
            => Meos.AfterSpansetTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t));

        public string AsText()
            => this.Out();

        public bool Before(DateTime t)
            => Meos.BeforeSpansetTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t));

        public Span?[] Bins(Interval duration, DateTime torigin, bool border_inc)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSpanArray(Meos.TstzspansetBins(this.Ptr, _duration, MEOSConvert.ToTimestampTz(torigin), border_inc));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public bool Contains(DateTime t)
            => Meos.ContainsSpansetTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t));

        public Interval? Distance(DateTime t)
            => MEOSConvert.ToStruct<Interval>(Meos.DistanceSpansetTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public Interval? Distance(TsTzSpan s)
            => MEOSConvert.ToStruct<Interval>(Meos.DistanceTstzspansetTstzspan(this.Ptr, s.Ptr));

        public Interval? Distance(TsTzSpanSet ss2)
            => MEOSConvert.ToStruct<Interval>(Meos.DistanceTstzspansetTstzspanset(this.Ptr, ss2.Ptr));

        public Interval? Duration(bool boundspan)
            => MEOSConvert.ToStruct<Interval>(Meos.TstzspansetDuration(this.Ptr, boundspan));

        public DateTime EndTimestamptz()
            => MEOSConvert.ToDateTime(Meos.TstzspansetEndTimestamptz(this.Ptr));

        public SpanSet? Intersection(DateTime t)
            => MEOSFactory.WrapSpanSet(Meos.IntersectionSpansetTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public DateTime Lower()
            => MEOSConvert.ToDateTime(Meos.TstzspansetLower(this.Ptr));

        public SpanSet? Minus(DateTime t)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpansetTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public int NumTimestamps()
            => Meos.TstzspansetNumTimestamps(this.Ptr);

        public string Out()
            => Meos.TstzspansetOut(this.Ptr);

        public bool Overafter(DateTime t)
            => Meos.OverafterSpansetTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t));

        public bool Overbefore(DateTime t)
            => Meos.OverbeforeSpansetTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t));

        public bool Radjacent(DateTime t)
            => Meos.AdjacentTimestamptzSpanset(MEOSConvert.ToTimestampTz(t), this.Ptr);

        public bool Rafter(DateTime t)
            => Meos.AfterTimestamptzSpanset(MEOSConvert.ToTimestampTz(t), this.Ptr);

        public bool Rbefore(DateTime t)
            => Meos.BeforeTimestamptzSpanset(MEOSConvert.ToTimestampTz(t), this.Ptr);

        public bool Rcontained(DateTime t)
            => Meos.ContainedTimestamptzSpanset(MEOSConvert.ToTimestampTz(t), this.Ptr);

        public SpanSet? Rintersection(DateTime t)
            => MEOSFactory.WrapSpanSet(Meos.IntersectionTimestamptzSpanset(MEOSConvert.ToTimestampTz(t), this.Ptr));

        public SpanSet? Rminus(DateTime t)
            => MEOSFactory.WrapSpanSet(Meos.MinusTimestamptzSpanset(MEOSConvert.ToTimestampTz(t), this.Ptr));

        public bool Roverafter(DateTime t)
            => Meos.OverafterTimestamptzSpanset(MEOSConvert.ToTimestampTz(t), this.Ptr);

        public bool Roverbefore(DateTime t)
            => Meos.OverbeforeTimestamptzSpanset(MEOSConvert.ToTimestampTz(t), this.Ptr);

        public SpanSet? Runion(DateTime t)
            => MEOSFactory.WrapSpanSet(Meos.UnionTimestamptzSpanset(MEOSConvert.ToTimestampTz(t), this.Ptr));

        public SpanSet? Scale(Interval duration)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSpanSet(Meos.TstzspansetScale(this.Ptr, _duration));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public SpanSet? Shift(Interval shift)
        {
            IntPtr _shift = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(shift, _shift, false);
                return MEOSFactory.WrapSpanSet(Meos.TstzspansetShift(this.Ptr, _shift));
            }
            finally
            {
                Marshal.FreeHGlobal(_shift);
            }
        }

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

        public SpanSet? Union(DateTime t)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpansetTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public DateTime Upper()
            => MEOSConvert.ToDateTime(Meos.TstzspansetUpper(this.Ptr));

        public static SpanSet? FromText(string str)
            => TsTzSpanSet.In(str);

        public static SpanSet? FromTimestamptz(DateTime t)
            => MEOSFactory.WrapSpanSet(Meos.TimestamptzToSpanset(MEOSConvert.ToTimestampTz(t)));

        public static SpanSet? In(string str)
            => MEOSFactory.WrapSpanSet(Meos.TstzspansetIn(str));

    }
}
