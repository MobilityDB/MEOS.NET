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

        public Temporal? AtValue(double d)
            => MEOSFactory.WrapTemporal(Meos.TfloatAtValue(this.Ptr, d));

        public Temporal? Ceil()
            => MEOSFactory.WrapTemporal(Meos.TfloatCeil(this.Ptr));

        public Temporal? Cos()
            => MEOSFactory.WrapTemporal(Meos.TfloatCos(this.Ptr));

        public Temporal? Degrees(bool normalize)
            => MEOSFactory.WrapTemporal(Meos.TfloatDegrees(this.Ptr, normalize));

        public double EndValue()
            => Meos.TfloatEndValue(this.Ptr);

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

        public string Out(int maxdd)
            => Meos.TfloatOut(this.Ptr, maxdd);

        public Temporal? Radians()
            => MEOSFactory.WrapTemporal(Meos.TfloatRadians(this.Ptr));

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

        public Temporal? Tan()
            => MEOSFactory.WrapTemporal(Meos.TfloatTan(this.Ptr));

        public TBox?[] TimeBoxes(Interval duration, DateTime torigin)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapTBoxArray(Meos.TfloatTimeBoxes(this.Ptr, _duration, MEOSConvert.ToTimestampTz(torigin)));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public Temporal? ToTbigint()
            => MEOSFactory.WrapTemporal(Meos.TfloatToTbigint(this.Ptr));

        public Temporal? ToTint()
            => MEOSFactory.WrapTemporal(Meos.TfloatToTint(this.Ptr));

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

        public Span?[] ValueBins(double vsize, double vorigin)
            => MEOSFactory.WrapSpanArray(Meos.TfloatValueBins(this.Ptr, vsize, vorigin));

        public TBox?[] ValueBoxes(double vsize, double vorigin)
            => MEOSFactory.WrapTBoxArray(Meos.TfloatValueBoxes(this.Ptr, vsize, vorigin));

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

        public TBox?[] ValueTimeBoxes(double vsize, Interval duration, double vorigin, DateTime torigin)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapTBoxArray(Meos.TfloatValueTimeBoxes(this.Ptr, vsize, _duration, vorigin, MEOSConvert.ToTimestampTz(torigin)));
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

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TfloatIn(str));

    }
}
