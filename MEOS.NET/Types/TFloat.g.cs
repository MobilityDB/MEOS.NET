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
            => this.Out(15);

        public Temporal? Add(double d)
            => MEOSFactory.WrapTemporal(Meos.AddTfloatFloat(this.Ptr, d));

        public int AlwaysEq(double d)
            => Meos.AlwaysEqTfloatFloat(this.Ptr, d);

        public int AlwaysGe(double d)
            => Meos.AlwaysGeTfloatFloat(this.Ptr, d);

        public int AlwaysGt(double d)
            => Meos.AlwaysGtTfloatFloat(this.Ptr, d);

        public int AlwaysLe(double d)
            => Meos.AlwaysLeTfloatFloat(this.Ptr, d);

        public int AlwaysLt(double d)
            => Meos.AlwaysLtTfloatFloat(this.Ptr, d);

        public int AlwaysNe(double d)
            => Meos.AlwaysNeTfloatFloat(this.Ptr, d);

        public string AsText(int maxdd)
            => this.Out(maxdd);

        public Temporal? AtValue(double d)
            => MEOSFactory.WrapTemporal(Meos.TfloatAtValue(this.Ptr, d));

        public Temporal? Ceil()
            => MEOSFactory.WrapTemporal(Meos.TfloatCeil(this.Ptr));

        public Temporal? Cos()
            => MEOSFactory.WrapTemporal(Meos.TfloatCos(this.Ptr));

        public Temporal? Degrees(bool normalize)
            => MEOSFactory.WrapTemporal(Meos.TfloatDegrees(this.Ptr, normalize));

        public Temporal? Div(double d)
            => MEOSFactory.WrapTemporal(Meos.DivTfloatFloat(this.Ptr, d));

        public double EndValue()
            => Meos.TfloatEndValue(this.Ptr);

        public int EverEq(double d)
            => Meos.EverEqTfloatFloat(this.Ptr, d);

        public int EverGe(double d)
            => Meos.EverGeTfloatFloat(this.Ptr, d);

        public int EverGt(double d)
            => Meos.EverGtTfloatFloat(this.Ptr, d);

        public int EverLe(double d)
            => Meos.EverLeTfloatFloat(this.Ptr, d);

        public int EverLt(double d)
            => Meos.EverLtTfloatFloat(this.Ptr, d);

        public int EverNe(double d)
            => Meos.EverNeTfloatFloat(this.Ptr, d);

        public Temporal? Exp()
            => MEOSFactory.WrapTemporal(Meos.TfloatExp(this.Ptr));

        public Temporal? Floor()
            => MEOSFactory.WrapTemporal(Meos.TfloatFloor(this.Ptr));

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

        public double Nad(double d)
            => Meos.NadTfloatFloat(this.Ptr, d);

        public double Nad(FloatSpan s)
            => Meos.NadTfloatFloatspan(this.Ptr, s.Ptr);

        public double Nad(TFloat temp2)
            => Meos.NadTfloatTfloat(this.Ptr, temp2.Ptr);

        public double Nad(TBox box)
            => Meos.NadTfloatTbox(this.Ptr, box.Ptr);

        public string Out(int maxdd)
            => Meos.TfloatOut(this.Ptr, maxdd);

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

        public Temporal? Tan()
            => MEOSFactory.WrapTemporal(Meos.TfloatTan(this.Ptr));

        public Temporal? Tdistance(double d)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTfloatFloat(this.Ptr, d));

        public Temporal? Teq(double d)
            => MEOSFactory.WrapTemporal(Meos.TeqTfloatFloat(this.Ptr, d));

        public Temporal? Tge(double d)
            => MEOSFactory.WrapTemporal(Meos.TgeTfloatFloat(this.Ptr, d));

        public Temporal? Tgt(double d)
            => MEOSFactory.WrapTemporal(Meos.TgtTfloatFloat(this.Ptr, d));

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

        public Temporal? Tlt(double d)
            => MEOSFactory.WrapTemporal(Meos.TltTfloatFloat(this.Ptr, d));

        public Temporal? Tne(double d)
            => MEOSFactory.WrapTemporal(Meos.TneTfloatFloat(this.Ptr, d));

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
            => TFloat.In(str);

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TfloatIn(str));

    }
}
