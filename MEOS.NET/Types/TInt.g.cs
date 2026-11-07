#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TInt class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TInt : TNumber
    {
        internal TInt(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public Temporal? Add(int i)
            => MEOSFactory.WrapTemporal(Meos.AddTintInt(this.Ptr, i));

        public int AlwaysEq(int i)
            => Meos.AlwaysEqTintInt(this.Ptr, i);

        public int AlwaysGe(int i)
            => Meos.AlwaysGeTintInt(this.Ptr, i);

        public int AlwaysGt(int i)
            => Meos.AlwaysGtTintInt(this.Ptr, i);

        public int AlwaysLe(int i)
            => Meos.AlwaysLeTintInt(this.Ptr, i);

        public int AlwaysLt(int i)
            => Meos.AlwaysLtTintInt(this.Ptr, i);

        public int AlwaysNe(int i)
            => Meos.AlwaysNeTintInt(this.Ptr, i);

        public string AsText()
            => this.Out();

        public Temporal? AtValue(int i)
            => MEOSFactory.WrapTemporal(Meos.TintAtValue(this.Ptr, i));

        public Temporal? Div(int i)
            => MEOSFactory.WrapTemporal(Meos.DivTintInt(this.Ptr, i));

        public int EndValue()
            => Meos.TintEndValue(this.Ptr);

        public int EverEq(int i)
            => Meos.EverEqTintInt(this.Ptr, i);

        public int EverGe(int i)
            => Meos.EverGeTintInt(this.Ptr, i);

        public int EverGt(int i)
            => Meos.EverGtTintInt(this.Ptr, i);

        public int EverLe(int i)
            => Meos.EverLeTintInt(this.Ptr, i);

        public int EverLt(int i)
            => Meos.EverLtTintInt(this.Ptr, i);

        public int EverNe(int i)
            => Meos.EverNeTintInt(this.Ptr, i);

        public int MaxValue()
            => Meos.TintMaxValue(this.Ptr);

        public int MinValue()
            => Meos.TintMinValue(this.Ptr);

        public Temporal? MinusValue(int i)
            => MEOSFactory.WrapTemporal(Meos.TintMinusValue(this.Ptr, i));

        public Temporal? Mul(int i)
            => MEOSFactory.WrapTemporal(Meos.MulTintInt(this.Ptr, i));

        public int Nad(int i)
            => Meos.NadTintInt(this.Ptr, i);

        public int Nad(IntSpan s)
            => Meos.NadTintIntspan(this.Ptr, s.Ptr);

        public int Nad(TBox box)
            => Meos.NadTintTbox(this.Ptr, box.Ptr);

        public int Nad(TInt temp2)
            => Meos.NadTintTint(this.Ptr, temp2.Ptr);

        public string Out()
            => Meos.TintOut(this.Ptr);

        public Temporal? Radd(int i)
            => MEOSFactory.WrapTemporal(Meos.AddIntTint(i, this.Ptr));

        public int RalwaysEq(int i)
            => Meos.AlwaysEqIntTint(i, this.Ptr);

        public int RalwaysGe(int i)
            => Meos.AlwaysGeIntTint(i, this.Ptr);

        public int RalwaysGt(int i)
            => Meos.AlwaysGtIntTint(i, this.Ptr);

        public int RalwaysLe(int i)
            => Meos.AlwaysLeIntTint(i, this.Ptr);

        public int RalwaysLt(int i)
            => Meos.AlwaysLtIntTint(i, this.Ptr);

        public int RalwaysNe(int i)
            => Meos.AlwaysNeIntTint(i, this.Ptr);

        public Temporal? Rdiv(int i)
            => MEOSFactory.WrapTemporal(Meos.DivIntTint(i, this.Ptr));

        public int ReverEq(int i)
            => Meos.EverEqIntTint(i, this.Ptr);

        public int ReverGe(int i)
            => Meos.EverGeIntTint(i, this.Ptr);

        public int ReverGt(int i)
            => Meos.EverGtIntTint(i, this.Ptr);

        public int ReverLe(int i)
            => Meos.EverLeIntTint(i, this.Ptr);

        public int ReverLt(int i)
            => Meos.EverLtIntTint(i, this.Ptr);

        public int ReverNe(int i)
            => Meos.EverNeIntTint(i, this.Ptr);

        public Temporal? Rmul(int i)
            => MEOSFactory.WrapTemporal(Meos.MulIntTint(i, this.Ptr));

        public Temporal? Rsub(int i)
            => MEOSFactory.WrapTemporal(Meos.SubIntTint(i, this.Ptr));

        public Temporal? Rteq(int i)
            => MEOSFactory.WrapTemporal(Meos.TeqIntTint(i, this.Ptr));

        public Temporal? Rtge(int i)
            => MEOSFactory.WrapTemporal(Meos.TgeIntTint(i, this.Ptr));

        public Temporal? Rtgt(int i)
            => MEOSFactory.WrapTemporal(Meos.TgtIntTint(i, this.Ptr));

        public Temporal? Rtle(int i)
            => MEOSFactory.WrapTemporal(Meos.TleIntTint(i, this.Ptr));

        public Temporal? Rtlt(int i)
            => MEOSFactory.WrapTemporal(Meos.TltIntTint(i, this.Ptr));

        public Temporal? Rtne(int i)
            => MEOSFactory.WrapTemporal(Meos.TneIntTint(i, this.Ptr));

        public Temporal? ScaleValue(int width)
            => MEOSFactory.WrapTemporal(Meos.TintScaleValue(this.Ptr, width));

        public Temporal? ShiftScaleValue(int shift, int width)
            => MEOSFactory.WrapTemporal(Meos.TintShiftScaleValue(this.Ptr, shift, width));

        public Temporal? ShiftValue(int shift)
            => MEOSFactory.WrapTemporal(Meos.TintShiftValue(this.Ptr, shift));

        public int StartValue()
            => Meos.TintStartValue(this.Ptr);

        public Temporal? Sub(int i)
            => MEOSFactory.WrapTemporal(Meos.SubTintInt(this.Ptr, i));

        public Temporal? Tdistance(int i)
            => MEOSFactory.WrapTemporal(Meos.TdistanceTintInt(this.Ptr, i));

        public Temporal? Teq(int i)
            => MEOSFactory.WrapTemporal(Meos.TeqTintInt(this.Ptr, i));

        public Temporal? Tge(int i)
            => MEOSFactory.WrapTemporal(Meos.TgeTintInt(this.Ptr, i));

        public Temporal? Tgt(int i)
            => MEOSFactory.WrapTemporal(Meos.TgtTintInt(this.Ptr, i));

        public TBox?[] TimeBoxes(Interval duration, DateTime torigin, bool border_inc)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapTBoxArray(Meos.TintTimeBoxes(this.Ptr, _duration, MEOSConvert.ToTimestampTz(torigin), border_inc));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public Temporal? Tle(int i)
            => MEOSFactory.WrapTemporal(Meos.TleTintInt(this.Ptr, i));

        public Temporal? Tlt(int i)
            => MEOSFactory.WrapTemporal(Meos.TltTintInt(this.Ptr, i));

        public Temporal? Tne(int i)
            => MEOSFactory.WrapTemporal(Meos.TneTintInt(this.Ptr, i));

        public Temporal? ToTbigint()
            => MEOSFactory.WrapTemporal(Meos.TintToTbigint(this.Ptr));

        public Temporal? ToTfloat()
            => MEOSFactory.WrapTemporal(Meos.TintToTfloat(this.Ptr));

        public (SpanSet?[], int[]) Unnest()
        {
            var _answered = Meos.TintUnnest(this.Ptr);

            return (MEOSFactory.WrapSpanSetArray(_answered.Item1), _answered.Item2);
        }

        public int Value()
            => Meos.TintValue(this.Ptr);

        public int? ValueAtTimestamptz(DateTime t, bool strict)
        {
            IntPtr _value = Marshal.AllocHGlobal(4);
            try
            {
                if (!Meos.TintValueAtTimestamptz(this.Ptr, MEOSConvert.ToTimestampTz(t), strict, _value))
                {
                    return null;
                }

                return Marshal.ReadInt32(_value);
            }
            finally
            {
                Marshal.FreeHGlobal(_value);
            }
        }

        public Span?[] ValueBins(int vsize, int vorigin, bool border_inc)
            => MEOSFactory.WrapSpanArray(Meos.TintValueBins(this.Ptr, vsize, vorigin, border_inc));

        public TBox?[] ValueBoxes(int vsize, int vorigin, bool border_inc)
            => MEOSFactory.WrapTBoxArray(Meos.TintValueBoxes(this.Ptr, vsize, vorigin, border_inc));

        public int? ValueN(int n)
        {
            IntPtr _result = Marshal.AllocHGlobal(4);
            try
            {
                if (!Meos.TintValueN(this.Ptr, n, _result))
                {
                    return null;
                }

                return Marshal.ReadInt32(_result);
            }
            finally
            {
                Marshal.FreeHGlobal(_result);
            }
        }

        public (Temporal?[], int[]) ValueSplit(int vsize, int vorigin, bool border_inc)
        {
            var _answered = Meos.TintValueSplit(this.Ptr, vsize, vorigin, border_inc);

            return (MEOSFactory.WrapTemporalArray(_answered.Item1), _answered.Item2);
        }

        public TBox?[] ValueTimeBoxes(int vsize, Interval duration, int vorigin, DateTime torigin, bool border_inc)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapTBoxArray(Meos.TintValueTimeBoxes(this.Ptr, vsize, _duration, vorigin, MEOSConvert.ToTimestampTz(torigin), border_inc));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public (Temporal?[], int[], DateTime[]) ValueTimeSplit(int vsize, Interval duration, int vorigin, DateTime torigin, bool border_inc)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                var _answered = Meos.TintValueTimeSplit(this.Ptr, vsize, _duration, vorigin, MEOSConvert.ToTimestampTz(torigin), border_inc);

                return (MEOSFactory.WrapTemporalArray(_answered.Item1), _answered.Item2, MEOSConvert.ToDateTimeArray(_answered.Item3));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public int[] Values()
            => Meos.TintValues(this.Ptr);

        public static Temporal? FromBaseTemp(int i, Temporal temp)
            => MEOSFactory.WrapTemporal(Meos.TintFromBaseTemp(i, temp.Ptr));

        public static Temporal? FromMFJSON(string str)
            => MEOSFactory.WrapTemporal(Meos.TintFromMfjson(str));

        public static Temporal? FromText(string str)
            => TInt.In(str);

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TintIn(str));

    }
}
