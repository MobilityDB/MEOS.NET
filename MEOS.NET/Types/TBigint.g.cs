#nullable enable

using System.Runtime.InteropServices;

using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Structures;

namespace MEOS.NET.Types
{
    /// <summary>The TBigint class of the MEOS object model.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public class TBigint : TNumber
    {
        internal TBigint(IntPtr ptr) : base(ptr) { }

        /// <summary>The text MEOS writes this value as.</summary>
        public override string ToString()
            => this.Out();

        public Temporal? AtValue(long i)
            => MEOSFactory.WrapTemporal(Meos.TbigintAtValue(this.Ptr, i));

        public long EndValue()
            => Meos.TbigintEndValue(this.Ptr);

        public long MaxValue()
            => Meos.TbigintMaxValue(this.Ptr);

        public long MinValue()
            => Meos.TbigintMinValue(this.Ptr);

        public Temporal? MinusValue(long i)
            => MEOSFactory.WrapTemporal(Meos.TbigintMinusValue(this.Ptr, i));

        public string Out()
            => Meos.TbigintOut(this.Ptr);

        public Temporal? ScaleValue(long width)
            => MEOSFactory.WrapTemporal(Meos.TbigintScaleValue(this.Ptr, width));

        public Temporal? ShiftScaleValue(long shift, long width)
            => MEOSFactory.WrapTemporal(Meos.TbigintShiftScaleValue(this.Ptr, shift, width));

        public Temporal? ShiftValue(long shift)
            => MEOSFactory.WrapTemporal(Meos.TbigintShiftValue(this.Ptr, shift));

        public long StartValue()
            => Meos.TbigintStartValue(this.Ptr);

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

        public static Temporal? In(string str)
            => MEOSFactory.WrapTemporal(Meos.TbigintIn(str));

    }
}
