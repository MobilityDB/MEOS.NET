#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TFloat class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TFloat : TNumber
    {
        internal TFloat(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.AsText(15);

        public Temporal? Add(double d)
            => MEOSFactory.WrapTemporal(Meos.AddTfloatFloat(this.Ptr, d));

        public Temporal? Add(TFloat tnumber2)
            => MEOSFactory.WrapTemporal(Meos.AddTnumberTnumber(this.Ptr, tnumber2.Ptr));

        public bool Adjacent(FloatSpan s)
            => Meos.AdjacentTnumberNumspan(this.Ptr, s.Ptr);

        public bool Adjacent(TFloat temp2)
            => Meos.AdjacentTnumberTnumber(this.Ptr, temp2.Ptr);

        public bool After(TFloat temp2)
            => Meos.AfterTnumberTnumber(this.Ptr, temp2.Ptr);

        public int AlwaysEq(double d)
            => Meos.AlwaysEqTfloatFloat(this.Ptr, d);

        public int AlwaysEq(TFloat temp2)
            => Meos.AlwaysEqTemporalTemporal(this.Ptr, temp2.Ptr);

        public int AlwaysGe(double d)
            => Meos.AlwaysGeTfloatFloat(this.Ptr, d);

        public int AlwaysGe(TFloat temp2)
            => Meos.AlwaysGeTemporalTemporal(this.Ptr, temp2.Ptr);

        public int AlwaysGt(double d)
            => Meos.AlwaysGtTfloatFloat(this.Ptr, d);

        public int AlwaysGt(TFloat temp2)
            => Meos.AlwaysGtTemporalTemporal(this.Ptr, temp2.Ptr);

        public int AlwaysLe(double d)
            => Meos.AlwaysLeTfloatFloat(this.Ptr, d);

        public int AlwaysLe(TFloat temp2)
            => Meos.AlwaysLeTemporalTemporal(this.Ptr, temp2.Ptr);

        public int AlwaysLt(double d)
            => Meos.AlwaysLtTfloatFloat(this.Ptr, d);

        public int AlwaysLt(TFloat temp2)
            => Meos.AlwaysLtTemporalTemporal(this.Ptr, temp2.Ptr);

        public int AlwaysNe(double d)
            => Meos.AlwaysNeTfloatFloat(this.Ptr, d);

        public int AlwaysNe(TFloat temp2)
            => Meos.AlwaysNeTemporalTemporal(this.Ptr, temp2.Ptr);

        public int AlwaysOverlaps(TFloat temp2)
            => Meos.AlwaysOverlapsTemporalTemporal(this.Ptr, temp2.Ptr);

        public Temporal? AtValue(double d)
            => MEOSFactory.WrapTemporal(Meos.TfloatAtValue(this.Ptr, d));

        public bool Before(TFloat temp2)
            => Meos.BeforeTnumberTnumber(this.Ptr, temp2.Ptr);

        public Temporal? Ceil()
            => MEOSFactory.WrapTemporal(Meos.TfloatCeil(this.Ptr));

        public bool Contained(FloatSpan s)
            => Meos.ContainedTnumberNumspan(this.Ptr, s.Ptr);

        public bool Contained(TFloat temp2)
            => Meos.ContainedTnumberTnumber(this.Ptr, temp2.Ptr);

        public bool Contains(FloatSpan s)
            => Meos.ContainsTnumberNumspan(this.Ptr, s.Ptr);

        public bool Contains(TFloat temp2)
            => Meos.ContainsTnumberTnumber(this.Ptr, temp2.Ptr);

        public Temporal? Cos()
            => MEOSFactory.WrapTemporal(Meos.TfloatCos(this.Ptr));

        public Temporal? Degrees(bool normalize)
            => MEOSFactory.WrapTemporal(Meos.TfloatDegrees(this.Ptr, normalize));

        public Temporal? Div(double d)
            => MEOSFactory.WrapTemporal(Meos.DivTfloatFloat(this.Ptr, d));

        public Temporal? Div(TFloat tnumber2)
            => MEOSFactory.WrapTemporal(Meos.DivTnumberTnumber(this.Ptr, tnumber2.Ptr));

        public double EndValue()
            => Meos.TfloatEndValue(this.Ptr);

        public int EverEq(double d)
            => Meos.EverEqTfloatFloat(this.Ptr, d);

        public int EverEq(TFloat temp2)
            => Meos.EverEqTemporalTemporal(this.Ptr, temp2.Ptr);

        public int EverGe(double d)
            => Meos.EverGeTfloatFloat(this.Ptr, d);

        public int EverGe(TFloat temp2)
            => Meos.EverGeTemporalTemporal(this.Ptr, temp2.Ptr);

        public int EverGt(double d)
            => Meos.EverGtTfloatFloat(this.Ptr, d);

        public int EverGt(TFloat temp2)
            => Meos.EverGtTemporalTemporal(this.Ptr, temp2.Ptr);

        public int EverLe(double d)
            => Meos.EverLeTfloatFloat(this.Ptr, d);

        public int EverLe(TFloat temp2)
            => Meos.EverLeTemporalTemporal(this.Ptr, temp2.Ptr);

        public int EverLt(double d)
            => Meos.EverLtTfloatFloat(this.Ptr, d);

        public int EverLt(TFloat temp2)
            => Meos.EverLtTemporalTemporal(this.Ptr, temp2.Ptr);

        public int EverNe(double d)
            => Meos.EverNeTfloatFloat(this.Ptr, d);

        public int EverNe(TFloat temp2)
            => Meos.EverNeTemporalTemporal(this.Ptr, temp2.Ptr);

        public int EverOverlaps(TFloat temp2)
            => Meos.EverOverlapsTemporalTemporal(this.Ptr, temp2.Ptr);

        public Temporal? Exp()
            => MEOSFactory.WrapTemporal(Meos.TfloatExp(this.Ptr));

        public Temporal? Floor()
            => MEOSFactory.WrapTemporal(Meos.TfloatFloor(this.Ptr));

        public bool Left(FloatSpan s)
            => Meos.LeftTnumberNumspan(this.Ptr, s.Ptr);

        public bool Left(TFloat temp2)
            => Meos.LeftTnumberTnumber(this.Ptr, temp2.Ptr);

        public Temporal? Ln()
            => MEOSFactory.WrapTemporal(Meos.TfloatLn(this.Ptr));

        public Temporal? Log10()
            => MEOSFactory.WrapTemporal(Meos.TfloatLog10(this.Ptr));

        public double MaxValue()
            => Meos.TfloatMaxValue(this.Ptr);

        public double MinValue()
            => Meos.TfloatMinValue(this.Ptr);

        public Temporal? MinusValue(double d)
            => MEOSFactory.WrapTemporal(Meos.TfloatMinusValue(this.Ptr, d));

        public Temporal? Mul(double d)
            => MEOSFactory.WrapTemporal(Meos.MulTfloatFloat(this.Ptr, d));

        public Temporal? Mul(TFloat tnumber2)
            => MEOSFactory.WrapTemporal(Meos.MulTnumberTnumber(this.Ptr, tnumber2.Ptr));

        public double Nad(double d)
            => Meos.NadTfloatFloat(this.Ptr, d);

        public double Nad(FloatSpan s)
            => Meos.NadTfloatFloatspan(this.Ptr, s.Ptr);

        public double Nad(TFloat temp2)
            => Meos.NadTfloatTfloat(this.Ptr, temp2.Ptr);

        public double Nad(TBox box)
            => Meos.NadTfloatTbox(this.Ptr, box.Ptr);

        public bool Overafter(TFloat temp2)
            => Meos.OverafterTnumberTnumber(this.Ptr, temp2.Ptr);

        public bool Overbefore(TFloat temp2)
            => Meos.OverbeforeTnumberTnumber(this.Ptr, temp2.Ptr);

        public bool Overlaps(FloatSpan s)
            => Meos.OverlapsTnumberNumspan(this.Ptr, s.Ptr);

        public bool Overlaps(TFloat temp2)
            => Meos.OverlapsTnumberTnumber(this.Ptr, temp2.Ptr);

        public bool Overleft(FloatSpan s)
            => Meos.OverleftTnumberNumspan(this.Ptr, s.Ptr);

        public bool Overleft(TFloat temp2)
            => Meos.OverleftTnumberTnumber(this.Ptr, temp2.Ptr);

        public bool Overright(FloatSpan s)
            => Meos.OverrightTnumberNumspan(this.Ptr, s.Ptr);

        public bool Overright(TFloat temp2)
            => Meos.OverrightTnumberTnumber(this.Ptr, temp2.Ptr);

        public Temporal? Radd(double d)
            => MEOSFactory.WrapTemporal(Meos.AddFloatTfloat(d, this.Ptr));

        public Temporal? Radians()
            => MEOSFactory.WrapTemporal(Meos.TfloatRadians(this.Ptr));

        public int RalwaysEq(double d)
            => Meos.AlwaysEqFloatTfloat(d, this.Ptr);

        public int RalwaysGe(double d)
            => Meos.AlwaysGeFloatTfloat(d, this.Ptr);

        public int RalwaysGt(double d)
            => Meos.AlwaysGtFloatTfloat(d, this.Ptr);

        public int RalwaysLe(double d)
            => Meos.AlwaysLeFloatTfloat(d, this.Ptr);

        public int RalwaysLt(double d)
            => Meos.AlwaysLtFloatTfloat(d, this.Ptr);

        public int RalwaysNe(double d)
            => Meos.AlwaysNeFloatTfloat(d, this.Ptr);

        public Temporal? Rdiv(double d)
            => MEOSFactory.WrapTemporal(Meos.DivFloatTfloat(d, this.Ptr));

        public int ReverEq(double d)
            => Meos.EverEqFloatTfloat(d, this.Ptr);

        public int ReverGe(double d)
            => Meos.EverGeFloatTfloat(d, this.Ptr);

        public int ReverGt(double d)
            => Meos.EverGtFloatTfloat(d, this.Ptr);

        public int ReverLe(double d)
            => Meos.EverLeFloatTfloat(d, this.Ptr);

        public int ReverLt(double d)
            => Meos.EverLtFloatTfloat(d, this.Ptr);

        public int ReverNe(double d)
            => Meos.EverNeFloatTfloat(d, this.Ptr);

        public bool Right(FloatSpan s)
            => Meos.RightTnumberNumspan(this.Ptr, s.Ptr);

        public bool Right(TFloat temp2)
            => Meos.RightTnumberTnumber(this.Ptr, temp2.Ptr);

        public Temporal? Rmul(double d)
            => MEOSFactory.WrapTemporal(Meos.MulFloatTfloat(d, this.Ptr));

        public Temporal? Rsub(double d)
            => MEOSFactory.WrapTemporal(Meos.SubFloatTfloat(d, this.Ptr));

        public Temporal? Rteq(double d)
            => MEOSFactory.WrapTemporal(Meos.TeqFloatTfloat(d, this.Ptr));

        public Temporal? Rtge(double d)
            => MEOSFactory.WrapTemporal(Meos.TgeFloatTfloat(d, this.Ptr));

        public Temporal? Rtgt(double d)
            => MEOSFactory.WrapTemporal(Meos.TgtFloatTfloat(d, this.Ptr));

        public Temporal? Rtle(double d)
            => MEOSFactory.WrapTemporal(Meos.TleFloatTfloat(d, this.Ptr));

        public Temporal? Rtlt(double d)
            => MEOSFactory.WrapTemporal(Meos.TltFloatTfloat(d, this.Ptr));

        public Temporal? Rtne(double d)
            => MEOSFactory.WrapTemporal(Meos.TneFloatTfloat(d, this.Ptr));

        public bool Same(FloatSpan s)
            => Meos.SameTnumberNumspan(this.Ptr, s.Ptr);

        public bool Same(TFloat temp2)
            => Meos.SameTnumberTnumber(this.Ptr, temp2.Ptr);

        public Temporal? ScaleValue(double width)
            => MEOSFactory.WrapTemporal(Meos.TfloatScaleValue(this.Ptr, width));

        public Temporal? ShiftScaleValue(double shift, double width)
            => MEOSFactory.WrapTemporal(Meos.TfloatShiftScaleValue(this.Ptr, shift, width));

        public Temporal? ShiftValue(double shift)
            => MEOSFactory.WrapTemporal(Meos.TfloatShiftValue(this.Ptr, shift));

        public Temporal? Sin()
            => MEOSFactory.WrapTemporal(Meos.TfloatSin(this.Ptr));

        public double StartValue()
            => Meos.TfloatStartValue(this.Ptr);

        public Temporal? Sub(double d)
            => MEOSFactory.WrapTemporal(Meos.SubTfloatFloat(this.Ptr, d));

        public Temporal? Sub(TFloat tnumber2)
            => MEOSFactory.WrapTemporal(Meos.SubTnumberTnumber(this.Ptr, tnumber2.Ptr));

        public Temporal? Tan()
            => MEOSFactory.WrapTemporal(Meos.TfloatTan(this.Ptr));

        public Temporal? Tdistance(double d)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTfloatFloat(this.Ptr, d));

        public Temporal? Tdistance(TFloat temp2)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTnumberTnumber(this.Ptr, temp2.Ptr));

        public Temporal? Teq(double d)
            => MEOSFactory.WrapTemporal(Meos.TeqTfloatFloat(this.Ptr, d));

        public Temporal? Teq(TFloat temp2)
            => MEOSFactory.WrapTemporal(Meos.TeqTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? Tge(double d)
            => MEOSFactory.WrapTemporal(Meos.TgeTfloatFloat(this.Ptr, d));

        public Temporal? Tge(TFloat temp2)
            => MEOSFactory.WrapTemporal(Meos.TgeTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? Tgt(double d)
            => MEOSFactory.WrapTemporal(Meos.TgtTfloatFloat(this.Ptr, d));

        public Temporal? Tgt(TFloat temp2)
            => MEOSFactory.WrapTemporal(Meos.TgtTemporalTemporal(this.Ptr, temp2.Ptr));

        public TBox?[] TimeBoxes(Interval duration, DateTime torigin, bool border_inc)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapTBoxArray(Meos.TfloatTimeBoxes(this.Ptr, _duration, MEOSConvert.ToTimestampTz(torigin), border_inc));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public Temporal? Tle(double d)
            => MEOSFactory.WrapTemporal(Meos.TleTfloatFloat(this.Ptr, d));

        public Temporal? Tle(TFloat temp2)
            => MEOSFactory.WrapTemporal(Meos.TleTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? Tlt(double d)
            => MEOSFactory.WrapTemporal(Meos.TltTfloatFloat(this.Ptr, d));

        public Temporal? Tlt(TFloat temp2)
            => MEOSFactory.WrapTemporal(Meos.TltTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? Tne(double d)
            => MEOSFactory.WrapTemporal(Meos.TneTfloatFloat(this.Ptr, d));

        public Temporal? Tne(TFloat temp2)
            => MEOSFactory.WrapTemporal(Meos.TneTemporalTemporal(this.Ptr, temp2.Ptr));

        public Temporal? ToTbigint()
            => MEOSFactory.WrapTemporal(Meos.TfloatToTbigint(this.Ptr));

        public Temporal? ToTint()
            => MEOSFactory.WrapTemporal(Meos.TfloatToTint(this.Ptr));

        public (SpanSet?[], double[]) Unnest()
        {
            var _answered = Meos.TfloatUnnest(this.Ptr);

            return (MEOSFactory.WrapSpanSetArray(_answered.Item1), _answered.Item2);
        }

        public double Value()
            => Meos.TfloatValue(this.Ptr);

        public double? ValueAtTimestamptz(DateTime t, bool strict)
        {
            IntPtr _value = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TfloatValueAtTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict, _value))
                {
                    return null;
                }

                return Marshal.PtrToStructure<double>(_value);
            }
            finally
            {
                Marshal.FreeHGlobal(_value);
            }
        }

        public Span?[] ValueBins(double vsize, double vorigin, bool border_inc)
            => MEOSFactory.WrapSpanArray(Meos.TfloatValueBins(this.Ptr, vsize, vorigin, border_inc));

        public TBox?[] ValueBoxes(double vsize, double vorigin, bool border_inc)
            => MEOSFactory.WrapTBoxArray(Meos.TfloatValueBoxes(this.Ptr, vsize, vorigin, border_inc));

        public double? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(8);
            try
            {
                if (!Meos.TfloatValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return Marshal.PtrToStructure<double>(_result);
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public (Temporal?[], double[]) ValueSplit(double vsize, double vorigin, bool border_inc)
        {
            var _answered = Meos.TfloatValueSplit(this.Ptr, vsize, vorigin, border_inc);

            return (MEOSFactory.WrapTemporalArray(_answered.Item1), _answered.Item2);
        }

        public TBox?[] ValueTimeBoxes(double vsize, Interval duration, double vorigin, DateTime torigin, bool border_inc)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapTBoxArray(Meos.TfloatValueTimeBoxes(this.Ptr, vsize, _duration, vorigin, MEOSConvert.ToTimestampTz(torigin), border_inc));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public (Temporal?[], double[], DateTime[]) ValueTimeSplit(double vsize, Interval duration, double vorigin, DateTime torigin, bool border_inc)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                var _answered = Meos.TfloatValueTimeSplit(this.Ptr, vsize, _duration, vorigin, MEOSConvert.ToTimestampTz(torigin), border_inc);

                return (MEOSFactory.WrapTemporalArray(_answered.Item1), _answered.Item2, MEOSConvert.ToDateTimeArray(_answered.Item3));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public double[] Values()
            => Meos.TfloatValues(this.Ptr);

        public static Temporal? FromBaseTemp(double d, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.TfloatFromBaseTemp(d, temp.Ptr));

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(Meos.TfloatFromMfjson(str));

        public static Temporal? FromText(string str)
            => MEOSFactory.WrapTemporal(Meos.TfloatIn(str));

    }
}
