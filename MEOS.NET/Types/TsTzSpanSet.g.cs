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

        public bool Adjacent(DateTime t)
            => Meos.AdjacentSpansetTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t));

        public bool Adjacent(TsTzSpan s)
            => Meos.AdjacentSpansetSpan(this.Ptr, s.Ptr);

        public bool Adjacent(TsTzSpanSet ss2)
            => Meos.AdjacentSpansetSpanset(this.Ptr, ss2.Ptr);

        public bool After(DateTime t)
            => Meos.AfterSpansetTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t));

        public string AsText(int maxdd)
            => this.Out(maxdd);

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

        public bool Contained(TsTzSpan s)
            => Meos.ContainedSpansetSpan(this.Ptr, s.Ptr);

        public bool Contained(TsTzSpanSet ss2)
            => Meos.ContainedSpansetSpanset(this.Ptr, ss2.Ptr);

        public bool Contains(DateTime t)
            => Meos.ContainsSpansetTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t));

        public bool Contains(TsTzSpan s)
            => Meos.ContainsSpansetSpan(this.Ptr, s.Ptr);

        public bool Contains(TsTzSpanSet ss2)
            => Meos.ContainsSpansetSpanset(this.Ptr, ss2.Ptr);

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

        public SpanSet? Intersection(TsTzSpan s)
            => MEOSFactory.WrapSpanSet(Meos.IntersectionSpansetSpan(this.Ptr, s.Ptr));

        public SpanSet? Intersection(TsTzSpanSet ss2)
            => MEOSFactory.WrapSpanSet(Meos.IntersectionSpansetSpanset(this.Ptr, ss2.Ptr));

        public bool Left(TsTzSpan s)
            => Meos.LeftSpansetSpan(this.Ptr, s.Ptr);

        public bool Left(TsTzSpanSet ss2)
            => Meos.LeftSpansetSpanset(this.Ptr, ss2.Ptr);

        public DateTime Lower()
            => MEOSConvert.ToDateTime(Meos.TstzspansetLower(this.Ptr));

        public SpanSet? Minus(DateTime t)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpansetTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public SpanSet? Minus(TsTzSpan s)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpansetSpan(this.Ptr, s.Ptr));

        public SpanSet? Minus(TsTzSpanSet ss2)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpansetSpanset(this.Ptr, ss2.Ptr));

        public int NumTimestamps()
            => Meos.TstzspansetNumTimestamps(this.Ptr);

        public bool Overafter(DateTime t)
            => Meos.OverafterSpansetTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t));

        public bool Overbefore(DateTime t)
            => Meos.OverbeforeSpansetTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t));

        public bool Overlaps(TsTzSpan s)
            => Meos.OverlapsSpansetSpan(this.Ptr, s.Ptr);

        public bool Overlaps(TsTzSpanSet ss2)
            => Meos.OverlapsSpansetSpanset(this.Ptr, ss2.Ptr);

        public bool Overleft(TsTzSpan s)
            => Meos.OverleftSpansetSpan(this.Ptr, s.Ptr);

        public bool Overleft(TsTzSpanSet ss2)
            => Meos.OverleftSpansetSpanset(this.Ptr, ss2.Ptr);

        public bool Overright(TsTzSpan s)
            => Meos.OverrightSpansetSpan(this.Ptr, s.Ptr);

        public bool Overright(TsTzSpanSet ss2)
            => Meos.OverrightSpansetSpanset(this.Ptr, ss2.Ptr);

        public bool Radjacent(DateTime t)
            => Meos.AdjacentTimestamptzSpanset(MEOSConvert.ToTimestampTz(t), this.Ptr);

        public bool Rafter(DateTime t)
            => Meos.AfterTimestamptzSpanset(MEOSConvert.ToTimestampTz(t), this.Ptr);

        public bool Rbefore(DateTime t)
            => Meos.BeforeTimestamptzSpanset(MEOSConvert.ToTimestampTz(t), this.Ptr);

        public bool Rcontained(DateTime t)
            => Meos.ContainedTimestamptzSpanset(MEOSConvert.ToTimestampTz(t), this.Ptr);

        public bool Right(TsTzSpan s)
            => Meos.RightSpansetSpan(this.Ptr, s.Ptr);

        public bool Right(TsTzSpanSet ss2)
            => Meos.RightSpansetSpanset(this.Ptr, ss2.Ptr);

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

        public SpanSet? Union(TsTzSpan s)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpansetSpan(this.Ptr, s.Ptr));

        public SpanSet? Union(TsTzSpanSet ss2)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpansetSpanset(this.Ptr, ss2.Ptr));

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
