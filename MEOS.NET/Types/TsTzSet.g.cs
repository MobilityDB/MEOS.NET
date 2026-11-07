#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TsTzSet class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TsTzSet : Set
    {
        internal TsTzSet(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public bool After(DateTime t)
            => Meos.AfterSetTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t));

        public string AsText()
            => this.Out();

        public bool Before(DateTime t)
            => Meos.BeforeSetTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t));

        public bool Contained(TsTzSet s2)
            => Meos.ContainedSetSet(this.Ptr, s2.Ptr);

        public bool Contains(DateTime t)
            => Meos.ContainsSetTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t));

        public bool Contains(TsTzSet s2)
            => Meos.ContainsSetSet(this.Ptr, s2.Ptr);

        public Interval? Distance(DateTime t)
            => MEOSConvert.ToStruct<Interval>(Meos.DistanceSetTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public Interval? Distance(TsTzSet s2)
            => MEOSConvert.ToStruct<Interval>(Meos.DistanceTstzsetTstzset(this.Ptr, s2.Ptr));

        public DateTime EndValue()
            => MEOSConvert.ToDateTime(Meos.TstzsetEndValue(this.Ptr));

        public Set? Intersection(DateTime t)
            => MEOSFactory.WrapSet(Meos.IntersectionSetTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public Set? Intersection(TsTzSet s2)
            => MEOSFactory.WrapSet(Meos.IntersectionSetSet(this.Ptr, s2.Ptr));

        public bool Left(TsTzSet s2)
            => Meos.LeftSetSet(this.Ptr, s2.Ptr);

        public Set? Minus(DateTime t)
            => MEOSFactory.WrapSet(Meos.MinusSetTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public Set? Minus(TsTzSet s2)
            => MEOSFactory.WrapSet(Meos.MinusSetSet(this.Ptr, s2.Ptr));

        public string Out()
            => Meos.TstzsetOut(this.Ptr);

        public bool Overafter(DateTime t)
            => Meos.OverafterSetTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t));

        public bool Overbefore(DateTime t)
            => Meos.OverbeforeSetTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t));

        public bool Overlaps(TsTzSet s2)
            => Meos.OverlapsSetSet(this.Ptr, s2.Ptr);

        public bool Overleft(TsTzSet s2)
            => Meos.OverleftSetSet(this.Ptr, s2.Ptr);

        public bool Overright(TsTzSet s2)
            => Meos.OverrightSetSet(this.Ptr, s2.Ptr);

        public bool Rafter(DateTime t)
            => Meos.AfterTimestamptzSet(MEOSConvert.ToTimestampTz(t), this.Ptr);

        public bool Rbefore(DateTime t)
            => Meos.BeforeTimestamptzSet(MEOSConvert.ToTimestampTz(t), this.Ptr);

        public bool Rcontained(DateTime t)
            => Meos.ContainedTimestamptzSet(MEOSConvert.ToTimestampTz(t), this.Ptr);

        public bool Right(TsTzSet s2)
            => Meos.RightSetSet(this.Ptr, s2.Ptr);

        public Set? Rintersection(DateTime t)
            => MEOSFactory.WrapSet(Meos.IntersectionTimestamptzSet(MEOSConvert.ToTimestampTz(t), this.Ptr));

        public Set? Rminus(DateTime t)
            => MEOSFactory.WrapSet(Meos.MinusTimestamptzSet(MEOSConvert.ToTimestampTz(t), this.Ptr));

        public bool Roverafter(DateTime t)
            => Meos.OverafterTimestamptzSet(MEOSConvert.ToTimestampTz(t), this.Ptr);

        public bool Roverbefore(DateTime t)
            => Meos.OverbeforeTimestamptzSet(MEOSConvert.ToTimestampTz(t), this.Ptr);

        public Set? Runion(DateTime t)
            => MEOSFactory.WrapSet(Meos.UnionTimestamptzSet(MEOSConvert.ToTimestampTz(t), this.Ptr));

        public Set? Scale(Interval duration)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSet(Meos.TstzsetScale(this.Ptr, _duration));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public Set? Shift(Interval shift)
        {
            IntPtr _shift = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(shift, _shift, false);
                return MEOSFactory.WrapSet(Meos.TstzsetShift(this.Ptr, _shift));
            }
            finally
            {
                Marshal.FreeHGlobal(_shift);
            }
        }

        public Set? ShiftScale(Interval shift, Interval duration)
        {
            IntPtr _shift = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(shift, _shift, false);
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSet(Meos.TstzsetShiftScale(this.Ptr, _shift, _duration));
            }
            finally
            {
                Marshal.FreeHGlobal(_shift);
                Marshal.FreeHGlobal(_duration);
            }
        }

        public DateTime StartValue()
            => MEOSConvert.ToDateTime(Meos.TstzsetStartValue(this.Ptr));

        public Set? ToDateset()
            => MEOSFactory.WrapSet(Meos.TstzsetToDateset(this.Ptr));

        public STBox? ToStbox()
            => MEOSFactory.WrapSTBox(Meos.TstzsetToStbox(this.Ptr));

        public Set? Tprecision(Interval duration, DateTime torigin)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapSet(Meos.TstzsetTprecision(this.Ptr, _duration, MEOSConvert.ToTimestampTz(torigin)));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public Set? Union(DateTime t)
            => MEOSFactory.WrapSet(Meos.UnionSetTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t)));

        public Set? Union(TsTzSet s2)
            => MEOSFactory.WrapSet(Meos.UnionSetSet(this.Ptr, s2.Ptr));

        public DateTime? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TstzsetValueN(this.Ptr, n, _result))
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

        public long[] Values()
            => Meos.TstzsetValues(this.Ptr);

        public static Set? FromText(string str)
            => TsTzSet.In(str);

        public static Set? FromTimestamptz(DateTime t)
            => MEOSFactory.WrapSet(Meos.TimestamptzToSet(MEOSConvert.ToTimestampTz(t)));

        public static Set? In(string str)
            => MEOSFactory.WrapSet(Meos.TstzsetIn(str));

        public static Set? Make(long[] values)
        {
            GCHandle _values = GCHandle.Alloc(values, GCHandleType.Pinned);
            try
            {
                return MEOSFactory.WrapSet(Meos.TstzsetMake(_values.AddrOfPinnedObject(), values.Length));
            }
            finally
            {
                _values.Free();
            }
        }

    }
}
