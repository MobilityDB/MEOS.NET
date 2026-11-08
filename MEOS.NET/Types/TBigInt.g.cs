#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TBigInt class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TBigInt : TNumber
    {
        internal TBigInt(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public Temporal? Add(long i)
            => MEOSFactory.WrapTemporal(Meos.AddTbigintBigint(this.Ptr, i));

        public Temporal? Add(TBigInt tnumber2)
            => MEOSFactory.WrapTemporal(Meos.AddTnumberTnumber(this.Ptr, tnumber2.Ptr));

        public bool Adjacent(BigIntSpan s)
            => Meos.AdjacentTnumberNumspan(this.Ptr, s.Ptr);

        public bool Adjacent(TBigInt temp2)
            => Meos.AdjacentTnumberTnumber(this.Ptr, temp2.Ptr);

        public bool After(TBigInt temp2)
            => Meos.AfterTnumberTnumber(this.Ptr, temp2.Ptr);

        public int AlwaysEq(long i)
            => Meos.AlwaysEqTbigintBigint(this.Ptr, i);

        public int AlwaysEq(TBigInt temp2)
            => Meos.AlwaysEqTemporalTemporal(this.Ptr, temp2.Ptr);

        public int AlwaysGe(long i)
            => Meos.AlwaysGeTbigintBigint(this.Ptr, i);

        public int AlwaysGe(TBigInt temp2)
            => Meos.AlwaysGeTemporalTemporal(this.Ptr, temp2.Ptr);

        public int AlwaysGt(long i)
            => Meos.AlwaysGtTbigintBigint(this.Ptr, i);

        public int AlwaysGt(TBigInt temp2)
            => Meos.AlwaysGtTemporalTemporal(this.Ptr, temp2.Ptr);

        public int AlwaysLe(long i)
            => Meos.AlwaysLeTbigintBigint(this.Ptr, i);

        public int AlwaysLe(TBigInt temp2)
            => Meos.AlwaysLeTemporalTemporal(this.Ptr, temp2.Ptr);

        public int AlwaysLt(long i)
            => Meos.AlwaysLtTbigintBigint(this.Ptr, i);

        public int AlwaysLt(TBigInt temp2)
            => Meos.AlwaysLtTemporalTemporal(this.Ptr, temp2.Ptr);

        public int AlwaysNe(long i)
            => Meos.AlwaysNeTbigintBigint(this.Ptr, i);

        public int AlwaysNe(TBigInt temp2)
            => Meos.AlwaysNeTemporalTemporal(this.Ptr, temp2.Ptr);

        public string AsText()
            => this.Out();

        public Temporal? AtValue(long i)
            => MEOSFactory.WrapTemporal(Meos.TbigintAtValue(this.Ptr, i));

        public bool Before(TBigInt temp2)
            => Meos.BeforeTnumberTnumber(this.Ptr, temp2.Ptr);

        public bool Contained(BigIntSpan s)
            => Meos.ContainedTnumberNumspan(this.Ptr, s.Ptr);

        public bool Contained(TBigInt temp2)
            => Meos.ContainedTnumberTnumber(this.Ptr, temp2.Ptr);

        public bool Contains(BigIntSpan s)
            => Meos.ContainsTnumberNumspan(this.Ptr, s.Ptr);

        public bool Contains(TBigInt temp2)
            => Meos.ContainsTnumberTnumber(this.Ptr, temp2.Ptr);

        public Temporal? Div(long i)
            => MEOSFactory.WrapTemporal(Meos.DivTbigintBigint(this.Ptr, i));

        public Temporal? Div(TBigInt tnumber2)
            => MEOSFactory.WrapTemporal(Meos.DivTnumberTnumber(this.Ptr, tnumber2.Ptr));

        public long EndValue()
            => Meos.TbigintEndValue(this.Ptr);

        public int EverEq(long i)
            => Meos.EverEqTbigintBigint(this.Ptr, i);

        public int EverEq(TBigInt temp2)
            => Meos.EverEqTemporalTemporal(this.Ptr, temp2.Ptr);

        public int EverGe(long i)
            => Meos.EverGeTbigintBigint(this.Ptr, i);

        public int EverGe(TBigInt temp2)
            => Meos.EverGeTemporalTemporal(this.Ptr, temp2.Ptr);

        public int EverGt(long i)
            => Meos.EverGtTbigintBigint(this.Ptr, i);

        public int EverGt(TBigInt temp2)
            => Meos.EverGtTemporalTemporal(this.Ptr, temp2.Ptr);

        public int EverLe(long i)
            => Meos.EverLeTbigintBigint(this.Ptr, i);

        public int EverLe(TBigInt temp2)
            => Meos.EverLeTemporalTemporal(this.Ptr, temp2.Ptr);

        public int EverLt(long i)
            => Meos.EverLtTbigintBigint(this.Ptr, i);

        public int EverLt(TBigInt temp2)
            => Meos.EverLtTemporalTemporal(this.Ptr, temp2.Ptr);

        public int EverNe(long i)
            => Meos.EverNeTbigintBigint(this.Ptr, i);

        public int EverNe(TBigInt temp2)
            => Meos.EverNeTemporalTemporal(this.Ptr, temp2.Ptr);

        public bool Left(BigIntSpan s)
            => Meos.LeftTnumberNumspan(this.Ptr, s.Ptr);

        public bool Left(TBigInt temp2)
            => Meos.LeftTnumberTnumber(this.Ptr, temp2.Ptr);

        public long MaxValue()
            => Meos.TbigintMaxValue(this.Ptr);

        public long MinValue()
            => Meos.TbigintMinValue(this.Ptr);

        public Temporal? MinusValue(long i)
            => MEOSFactory.WrapTemporal(Meos.TbigintMinusValue(this.Ptr, i));

        public Temporal? Mul(long i)
            => MEOSFactory.WrapTemporal(Meos.MulTbigintBigint(this.Ptr, i));

        public Temporal? Mul(TBigInt tnumber2)
            => MEOSFactory.WrapTemporal(Meos.MulTnumberTnumber(this.Ptr, tnumber2.Ptr));

        public long Nad(long i)
            => Meos.NadTbigintBigint(this.Ptr, i);

        public long Nad(BigIntSpan s)
            => Meos.NadTbigintBigintspan(this.Ptr, s.Ptr);

        public long Nad(TBox box)
            => Meos.NadTbigintTbox(this.Ptr, box.Ptr);

        public long Nad(TBigInt temp2)
            => Meos.NadTbigintTbigint(this.Ptr, temp2.Ptr);

        public string Out()
            => Meos.TbigintOut(this.Ptr);

        public bool Overafter(TBigInt temp2)
            => Meos.OverafterTnumberTnumber(this.Ptr, temp2.Ptr);

        public bool Overbefore(TBigInt temp2)
            => Meos.OverbeforeTnumberTnumber(this.Ptr, temp2.Ptr);

        public bool Overlaps(BigIntSpan s)
            => Meos.OverlapsTnumberNumspan(this.Ptr, s.Ptr);

        public bool Overlaps(TBigInt temp2)
            => Meos.OverlapsTnumberTnumber(this.Ptr, temp2.Ptr);

        public bool Overleft(BigIntSpan s)
            => Meos.OverleftTnumberNumspan(this.Ptr, s.Ptr);

        public bool Overleft(TBigInt temp2)
            => Meos.OverleftTnumberTnumber(this.Ptr, temp2.Ptr);

        public bool Overright(BigIntSpan s)
            => Meos.OverrightTnumberNumspan(this.Ptr, s.Ptr);

        public bool Overright(TBigInt temp2)
            => Meos.OverrightTnumberTnumber(this.Ptr, temp2.Ptr);

        public Temporal? Radd(long i)
            => MEOSFactory.WrapTemporal(Meos.AddBigintTbigint(i, this.Ptr));

        public int RalwaysEq(long i)
            => Meos.AlwaysEqBigintTbigint(i, this.Ptr);

        public int RalwaysGe(long i)
            => Meos.AlwaysGeBigintTbigint(i, this.Ptr);

        public int RalwaysGt(long i)
            => Meos.AlwaysGtBigintTbigint(i, this.Ptr);

        public int RalwaysLe(long i)
            => Meos.AlwaysLeBigintTbigint(i, this.Ptr);

        public int RalwaysLt(long i)
            => Meos.AlwaysLtBigintTbigint(i, this.Ptr);

        public int RalwaysNe(long i)
            => Meos.AlwaysNeBigintTbigint(i, this.Ptr);

        public Temporal? Rdiv(long i)
            => MEOSFactory.WrapTemporal(Meos.DivBigintTbigint(i, this.Ptr));

        public int ReverEq(long i)
            => Meos.EverEqBigintTbigint(i, this.Ptr);

        public int ReverGe(long i)
            => Meos.EverGeBigintTbigint(i, this.Ptr);

        public int ReverGt(long i)
            => Meos.EverGtBigintTbigint(i, this.Ptr);

        public int ReverLe(long i)
            => Meos.EverLeBigintTbigint(i, this.Ptr);

        public int ReverLt(long i)
            => Meos.EverLtBigintTbigint(i, this.Ptr);

        public int ReverNe(long i)
            => Meos.EverNeBigintTbigint(i, this.Ptr);

        public bool Right(BigIntSpan s)
            => Meos.RightTnumberNumspan(this.Ptr, s.Ptr);

        public bool Right(TBigInt temp2)
            => Meos.RightTnumberTnumber(this.Ptr, temp2.Ptr);

        public Temporal? Rmul(long i)
            => MEOSFactory.WrapTemporal(Meos.MulBigintTbigint(i, this.Ptr));

        public Temporal? Rsub(long i)
            => MEOSFactory.WrapTemporal(Meos.SubBigintTbigint(i, this.Ptr));

        public Temporal? Rteq(long i)
            => MEOSFactory.WrapTemporal(Meos.TeqBigintTbigint(i, this.Ptr));

        public Temporal? Rtge(long i)
            => MEOSFactory.WrapTemporal(Meos.TgeBigintTbigint(i, this.Ptr));

        public Temporal? Rtgt(long i)
            => MEOSFactory.WrapTemporal(Meos.TgtBigintTbigint(i, this.Ptr));

        public Temporal? Rtle(long i)
            => MEOSFactory.WrapTemporal(Meos.TleBigintTbigint(i, this.Ptr));

        public Temporal? Rtlt(long i)
            => MEOSFactory.WrapTemporal(Meos.TltBigintTbigint(i, this.Ptr));

        public Temporal? Rtne(long i)
            => MEOSFactory.WrapTemporal(Meos.TneBigintTbigint(i, this.Ptr));

        public bool Same(BigIntSpan s)
            => Meos.SameTnumberNumspan(this.Ptr, s.Ptr);

        public bool Same(TBigInt temp2)
            => Meos.SameTnumberTnumber(this.Ptr, temp2.Ptr);

        public Temporal? ScaleValue(long width)
            => MEOSFactory.WrapTemporal(Meos.TbigintScaleValue(this.Ptr, width));

        public Temporal? ShiftScaleValue(long shift, long width)
            => MEOSFactory.WrapTemporal(Meos.TbigintShiftScaleValue(this.Ptr, shift, width));

        public Temporal? ShiftValue(long shift)
            => MEOSFactory.WrapTemporal(Meos.TbigintShiftValue(this.Ptr, shift));

        public long StartValue()
            => Meos.TbigintStartValue(this.Ptr);

        public Temporal? Sub(long i)
            => MEOSFactory.WrapTemporal(Meos.SubTbigintBigint(this.Ptr, i));

        public Temporal? Sub(TBigInt tnumber2)
            => MEOSFactory.WrapTemporal(Meos.SubTnumberTnumber(this.Ptr, tnumber2.Ptr));

        public Temporal? Tdistance(TBigInt temp2)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTnumberTnumber(this.Ptr, temp2.Ptr));

        public Temporal? Teq(long i)
            => MEOSFactory.WrapTemporal(Meos.TeqTbigintBigint(this.Ptr, i));

        public Temporal? Teq(TBigInt temp2)
            => MEOSFactory.WrapTemporal(Meos.TeqTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? Tge(long i)
            => MEOSFactory.WrapTemporal(Meos.TgeTbigintBigint(this.Ptr, i));

        public Temporal? Tge(TBigInt temp2)
            => MEOSFactory.WrapTemporal(Meos.TgeTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? Tgt(long i)
            => MEOSFactory.WrapTemporal(Meos.TgtTbigintBigint(this.Ptr, i));

        public Temporal? Tgt(TBigInt temp2)
            => MEOSFactory.WrapTemporal(Meos.TgtTemporalTemporal(this.Ptr, temp2.Ptr));

        public TBox?[] TimeBoxes(Interval duration, DateTime torigin, bool border_inc)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapTBoxArray(Meos.TbigintTimeBoxes(this.Ptr, _duration, MEOSConvert.ToTimestampTz(torigin), border_inc));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public Temporal? Tle(long i)
            => MEOSFactory.WrapTemporal(Meos.TleTbigintBigint(this.Ptr, i));

        public Temporal? Tle(TBigInt temp2)
            => MEOSFactory.WrapTemporal(Meos.TleTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? Tlt(long i)
            => MEOSFactory.WrapTemporal(Meos.TltTbigintBigint(this.Ptr, i));

        public Temporal? Tlt(TBigInt temp2)
            => MEOSFactory.WrapTemporal(Meos.TltTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? Tne(long i)
            => MEOSFactory.WrapTemporal(Meos.TneTbigintBigint(this.Ptr, i));

        public Temporal? Tne(TBigInt temp2)
            => MEOSFactory.WrapTemporal(Meos.TneTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? ToTfloat()
            => MEOSFactory.WrapTemporal(Meos.TbigintToTfloat(this.Ptr));

        public Temporal? ToTh3index()
            => MEOSFactory.WrapTemporal(Meos.TbigintToTh3index(this.Ptr));

        public Temporal? ToTint()
            => MEOSFactory.WrapTemporal(Meos.TbigintToTint(this.Ptr));

        public Temporal? ToTquadbin()
            => MEOSFactory.WrapTemporal(Meos.TbigintToTquadbin(this.Ptr));

        public Temporal? ToTs2cell()
            => MEOSFactory.WrapTemporal(Meos.TbigintToTs2cell(this.Ptr));

        public (SpanSet?[], long[]) Unnest()
        {
            var _answered = Meos.TbigintUnnest(this.Ptr);

            return (MEOSFactory.WrapSpanSetArray(_answered.Item1), _answered.Item2);
        }

        public long Value()
            => Meos.TbigintValue(this.Ptr);

        public long? ValueAtTimestamptz(DateTime t, bool strict)
        {
            IntPtr _value = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TbigintValueAtTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict, _value))
                {
                    return null;
                }

                return Marshal.ReadInt64(_value);
            }
            finally
            {
                Marshal.FreeHGlobal(_value);
            }
        }

        public Span?[] ValueBins(long vsize, long vorigin, bool border_inc)
            => MEOSFactory.WrapSpanArray(Meos.TbigintValueBins(this.Ptr, vsize, vorigin, border_inc));

        public TBox?[] ValueBoxes(long vsize, long vorigin, bool border_inc)
            => MEOSFactory.WrapTBoxArray(Meos.TbigintValueBoxes(this.Ptr, vsize, vorigin, border_inc));

        public long? ValueN(long n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TbigintValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return Marshal.ReadInt64(_result);
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public (Temporal?[], long[]) ValueSplit(long vsize, long vorigin, bool border_inc)
        {
            var _answered = Meos.TbigintValueSplit(this.Ptr, vsize, vorigin, border_inc);

            return (MEOSFactory.WrapTemporalArray(_answered.Item1), _answered.Item2);
        }

        public TBox?[] ValueTimeBoxes(long vsize, Interval duration, long vorigin, DateTime torigin, bool border_inc)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapTBoxArray(Meos.TbigintValueTimeBoxes(this.Ptr, vsize, _duration, vorigin, MEOSConvert.ToTimestampTz(torigin), border_inc));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public (Temporal?[], long[], DateTime[]) ValueTimeSplit(long vsize, Interval duration, long vorigin, DateTime torigin, bool border_inc)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                var _answered = Meos.TbigintValueTimeSplit(this.Ptr, vsize, _duration, vorigin, MEOSConvert.ToTimestampTz(torigin), border_inc);

                return (MEOSFactory.WrapTemporalArray(_answered.Item1), _answered.Item2, MEOSConvert.ToDateTimeArray(_answered.Item3));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public long[] Values()
            => Meos.TbigintValues(this.Ptr);

        public static Temporal? FromBaseTemp(long i, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.TbigintFromBaseTemp(i, temp.Ptr));

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(Meos.TbigintFromMfjson(str));

        public static Temporal? FromText(string str)
            => TBigInt.In(str);

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TbigintIn(str));

    }
}
