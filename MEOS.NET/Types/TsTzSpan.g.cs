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

        public bool Adjacent(DateTime t)
            => Meos.AdjacentSpanTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t));

        public bool Adjacent(TBox box)
            => Meos.AdjacentTstzspanTbox(this.Ptr, box.Ptr);

        public bool Adjacent(Temporal temp)
            => Meos.AdjacentTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool After(DateTime t)
            => Meos.AfterSpanTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t));

        public bool After(TBox box)
            => Meos.AfterTstzspanTbox(this.Ptr, box.Ptr);

        public bool After(Temporal temp)
            => Meos.AfterTstzspanTemporal(this.Ptr, temp.Ptr);

        public string AsText()
            => this.Out();

        public bool Before(DateTime t)
            => Meos.BeforeSpanTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t));

        public bool Before(TBox box)
            => Meos.BeforeTstzspanTbox(this.Ptr, box.Ptr);

        public bool Before(Temporal temp)
            => Meos.BeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public Span?[] Bins(Interval duration, DateTime torigin, bool border_inc)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSpanArray(Meos.TstzspanBins(this.Ptr, _duration, MEOSConvert.ToTimestampTz(torigin), border_inc));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public bool Contained(TBox box)
            => Meos.ContainedTstzspanTbox(this.Ptr, box.Ptr);

        public bool Contained(Temporal temp)
            => Meos.ContainedTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Contains(DateTime t)
            => Meos.ContainsSpanTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t));

        public bool Contains(TBox box)
            => Meos.ContainsTstzspanTbox(this.Ptr, box.Ptr);

        public bool Contains(Temporal temp)
            => Meos.ContainsTstzspanTemporal(this.Ptr, temp.Ptr);

        public Interval? Distance(DateTime t)
            => MEOSConvert.ToStruct<Interval>(Meos.DistanceSpanTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public Interval? Distance(TsTzSpan s2)
            => MEOSConvert.ToStruct<Interval>(Meos.DistanceTstzspanTstzspan(this.Ptr, s2.Ptr));

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

        public Span? Intersection(DateTime t)
            => MEOSFactory.WrapSpan(Meos.IntersectionSpanTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public DateTime Lower()
            => MEOSConvert.ToDateTime(Meos.TstzspanLower(this.Ptr));

        public SpanSet? Minus(DateTime t)
            => MEOSFactory.WrapSpanSet(Meos.MinusSpanTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public TBox? Numspan(TsTzSpan p)
            => MEOSFactory.WrapTBox(Meos.NumspanTstzspanToTbox(this.Ptr, p.Ptr));

        public string Out()
            => Meos.TstzspanOut(this.Ptr);

        public bool Overafter(DateTime t)
            => Meos.OverafterSpanTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t));

        public bool Overafter(TBox box)
            => Meos.OverafterTstzspanTbox(this.Ptr, box.Ptr);

        public bool Overafter(Temporal temp)
            => Meos.OverafterTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overbefore(DateTime t)
            => Meos.OverbeforeSpanTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t));

        public bool Overbefore(TBox box)
            => Meos.OverbeforeTstzspanTbox(this.Ptr, box.Ptr);

        public bool Overbefore(Temporal temp)
            => Meos.OverbeforeTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Overlaps(TBox box)
            => Meos.OverlapsTstzspanTbox(this.Ptr, box.Ptr);

        public bool Overlaps(Temporal temp)
            => Meos.OverlapsTstzspanTemporal(this.Ptr, temp.Ptr);

        public bool Radjacent(DateTime t)
            => Meos.AdjacentTimestamptzSpan(MEOSConvert.ToTimestampTz(t), this.Ptr);

        public bool Rafter(DateTime t)
            => Meos.AfterTimestamptzSpan(MEOSConvert.ToTimestampTz(t), this.Ptr);

        public bool Rbefore(DateTime t)
            => Meos.BeforeTimestamptzSpan(MEOSConvert.ToTimestampTz(t), this.Ptr);

        public bool Rcontained(DateTime t)
            => Meos.ContainedTimestamptzSpan(MEOSConvert.ToTimestampTz(t), this.Ptr);

        public Span? Rintersection(DateTime t)
            => MEOSFactory.WrapSpan(Meos.IntersectionTimestamptzSpan(MEOSConvert.ToTimestampTz(t), this.Ptr));

        public SpanSet? Rminus(DateTime t)
            => MEOSFactory.WrapSpanSet(Meos.MinusTimestamptzSpan(MEOSConvert.ToTimestampTz(t), this.Ptr));

        public bool Roverafter(DateTime t)
            => Meos.OverafterTimestamptzSpan(MEOSConvert.ToTimestampTz(t), this.Ptr);

        public bool Roverbefore(DateTime t)
            => Meos.OverbeforeTimestamptzSpan(MEOSConvert.ToTimestampTz(t), this.Ptr);

        public SpanSet? Runion(DateTime t)
            => MEOSFactory.WrapSpanSet(Meos.UnionTimestamptzSpan(MEOSConvert.ToTimestampTz(t), this.Ptr));

        public bool Same(TBox box)
            => Meos.SameTstzspanTbox(this.Ptr, box.Ptr);

        public bool Same(Temporal temp)
            => Meos.SameTstzspanTemporal(this.Ptr, temp.Ptr);

        public Span? Scale(Interval duration)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSpan(Meos.TstzspanScale(this.Ptr, _duration));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public Span? Shift(Interval shift)
        {
            IntPtr _shift = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(shift, _shift, false);
                return MEOSFactory.WrapSpan(Meos.TstzspanShift(this.Ptr, _shift));
            }
            finally
            {
                Marshal.FreeHGlobal(_shift);
            }
        }

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

        public SpanSet? Union(DateTime t)
            => MEOSFactory.WrapSpanSet(Meos.UnionSpanTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public DateTime Upper()
            => MEOSConvert.ToDateTime(Meos.TstzspanUpper(this.Ptr));

        public static Span? FromText(string str)
            => TsTzSpan.In(str);

        public static Span? FromTimestamptz(DateTime t)
            => MEOSFactory.WrapSpan(Meos.TimestamptzToSpan(MEOSConvert.ToTimestampTz(t)));

        public static Span? GetBin(DateTime t, Interval duration, DateTime torigin)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSpan(Meos.TstzspanGetBin(MEOSConvert.ToTimestampTz(t), _duration, MEOSConvert.ToTimestampTz(torigin)));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public static Span? In(string str)
            => MEOSFactory.WrapSpan(Meos.TstzspanIn(str));

        public static Span? Make(DateTime lower, DateTime upper, bool lower_inc, bool upper_inc)
            => MEOSFactory.WrapSpan(Meos.TstzspanMake(MEOSConvert.ToTimestampTz(lower), MEOSConvert.ToTimestampTz(upper), lower_inc, upper_inc));

    }
}
