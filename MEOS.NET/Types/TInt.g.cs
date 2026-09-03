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

        public Temporal? AtValue(int i)
            => MEOSFactory.WrapTemporal(Meos.TintAtValue(this.Ptr, i));

        public int EndValue()
            => Meos.TintEndValue(this.Ptr);

        public int MaxValue()
            => Meos.TintMaxValue(this.Ptr);

        public int MinValue()
            => Meos.TintMinValue(this.Ptr);

        public Temporal? MinusValue(int i)
            => MEOSFactory.WrapTemporal(Meos.TintMinusValue(this.Ptr, i));

        public string Out()
            => Meos.TintOut(this.Ptr);

        public Temporal? ScaleValue(int width)
            => MEOSFactory.WrapTemporal(Meos.TintScaleValue(this.Ptr, width));

        public Temporal? ShiftScaleValue(int shift, int width)
            => MEOSFactory.WrapTemporal(Meos.TintShiftScaleValue(this.Ptr, shift, width));

        public Temporal? ShiftValue(int shift)
            => MEOSFactory.WrapTemporal(Meos.TintShiftValue(this.Ptr, shift));

        public int StartValue()
            => Meos.TintStartValue(this.Ptr);

        public TBox?[] TimeBoxes(Interval duration, DateTime torigin)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapTBoxArray(Meos.TintTimeBoxes(this.Ptr, _duration, MEOSConvert.ToTimestampTz(torigin)));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public Temporal? ToTbigint()
            => MEOSFactory.WrapTemporal(Meos.TintToTbigint(this.Ptr));

        public Temporal? ToTfloat()
            => MEOSFactory.WrapTemporal(Meos.TintToTfloat(this.Ptr));

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

        public Span?[] ValueBins(int vsize, int vorigin)
            => MEOSFactory.WrapSpanArray(Meos.TintValueBins(this.Ptr, vsize, vorigin));

        public TBox?[] ValueBoxes(int vsize, int vorigin)
            => MEOSFactory.WrapTBoxArray(Meos.TintValueBoxes(this.Ptr, vsize, vorigin));

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

        public (Temporal?[], int[]) ValueSplit(int vsize, int vorigin)
        {
            var _answered = Meos.TintValueSplit(this.Ptr, vsize, vorigin);

            return (MEOSFactory.WrapTemporalArray(_answered.Item1), _answered.Item2);
        }

        public TBox?[] ValueTimeBoxes(int vsize, Interval duration, int vorigin, DateTime torigin)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                return MEOSFactory.WrapTBoxArray(Meos.TintValueTimeBoxes(this.Ptr, vsize, _duration, vorigin, MEOSConvert.ToTimestampTz(torigin)));
            }
            finally
            {
                Marshal.FreeHGlobal(_duration);
            }
        }

        public (Temporal?[], int[], DateTime[]) ValueTimeSplit(int size, Interval duration, int vorigin, DateTime torigin)
        {
            IntPtr _duration = Marshal.AllocHGlobal(Marshal.SizeOf<Interval>());
            try
            {
                Marshal.StructureToPtr(duration, _duration, false);
                var _answered = Meos.TintValueTimeSplit(this.Ptr, size, _duration, vorigin, MEOSConvert.ToTimestampTz(torigin));

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

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TintIn(str));

    }
}
