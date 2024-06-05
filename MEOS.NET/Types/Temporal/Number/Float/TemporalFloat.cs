using MEOS.NET.Enums;
using MEOS.NET.Helpers;
using MEOS.NET.Internal;
using MEOS.NET.Types.Collections.Float;
using MEOS.NET.Types.Temporal.Boolean;
using MEOS.NET.Types.Temporal.Number.Integer;

namespace MEOS.NET.Types.Temporal.Number.Float
{
    public class TemporalFloat : TemporalNumber,
        ITemporallyEquatable<int>, ITemporallyEquatable<double>,
        ITemporallyComparable<int>, ITemporallyComparable<double>
    {
        internal TemporalFloat(IntPtr ptr) : base(ptr)
        { }

        public static TemporalFloat FromBaseTemporal(Temporal temporal, double value)
        {
            var res = MEOSExposedFunctions.tfloat_from_base_temp(value, temporal._ptr);
            return new TemporalFloat(res);
        }

        public static TemporalFloat FromString(string input)
        {
            var res = MEOSExposedFunctions.tfloat_in(input);
            return new TemporalFloatInstant(res);
        }

        public string Format(int maxDecimals)
            => MEOSExposedFunctions.tfloat_out(this._ptr, maxdd: maxDecimals);

        public override string ToString()
            => this.Format(15);

        public TemporalInteger ToTemporalInteger()
        {
            if (this.Interpolation() == InterpolationType.Linear)
            {
                throw new InvalidOperationException("Cannot convert a temporal float with linear" +
                    "interpolation to a temporal integer.");
            }

            var res = MEOSExposedFunctions.tfloat_to_tint(this._ptr);
            return new TemporalInteger(res);
        }

        public FloatSpan ToFloatSpan()
        {
            var res = MEOSExposedFunctions.tnumber_to_span(this._ptr);
            return new FloatSpan(res);
        }

        public FloatSpanSet ToFloatSpanSet()
        {
            var res = MEOSExposedFunctions.tnumber_valuespans(this._ptr);
            return new FloatSpanSet(res);
        }

        public TemporalFloatSequence Append(TemporalFloatInstant instant, double maxDistance = 0.0)
        {
            var res = MEOSExposedFunctions.temporal_append_tinstant(this._ptr, instant._ptr, maxDistance, IntPtr.Zero, false);
            return new TemporalFloatSequence(res);
        }

        public double StartValue()
            => MEOSExposedFunctions.tfloat_start_value(this._ptr);

        public double EndValue()
            => MEOSExposedFunctions.tfloat_end_value(this._ptr);

        public double MinValue()
            => MEOSExposedFunctions.tfloat_min_value(this._ptr);

        public double MaxValue()
            => MEOSExposedFunctions.tfloat_max_value(this._ptr);

        public FloatSet ToFloatSet()
        {
            int count = 0;
            var arrayPtr = AllocHelper.AllocatePointer<IntPtr>(sizeof(int), (countPtr) =>
            {
                var arr = MEOSExposedFunctions.tfloat_values(this._ptr, countPtr);
                count = countPtr.ToStructure<int>();

                return arr;
            });

            return FloatSet.FromValuesPointer(arrayPtr, count);
        }

        public bool IsAlwaysLessThan(double value)
            => MEOSExposedFunctions.tfloat_always_lt(this._ptr, value);

        public bool IsAlwaysLessThanOrEqualTo(double value)
            => MEOSExposedFunctions.tfloat_always_le(this._ptr, value);

        public bool IsAlwaysEqualTo(double value)
            => MEOSExposedFunctions.tfloat_always_eq(this._ptr, value);

        public bool IsEverLessThan(double value)
            => MEOSExposedFunctions.tfloat_ever_lt(this._ptr, value);

        public bool IsEverLessThanOrEqualTo(double value)
            => MEOSExposedFunctions.tfloat_ever_le(this._ptr, value);

        public bool IsEverEqualTo(double value)
            => MEOSExposedFunctions.tfloat_ever_eq(this._ptr, value);

        public TemporalBoolean TemporalEqual(int other)
            => this.TemporalEqual((double)other);

        public TemporalBoolean TemporalNotEqual(int other)
            => this.TemporalNotEqual((double)other);

        public TemporalBoolean TemporalEqual(double other)
        {
            var res = MEOSExposedFunctions.teq_tfloat_float(this._ptr, other);
            return new TemporalBoolean(res);
        }

        public TemporalBoolean TemporalNotEqual(double other)
        {
            var res = MEOSExposedFunctions.tne_tfloat_float(this._ptr, other);
            return new TemporalBoolean(res);
        }

        public TemporalBoolean TemporalLessThan(double other)
        {
            var res = MEOSExposedFunctions.tlt_tfloat_float(this._ptr, other);
            return new TemporalBoolean(res);
        }

        public TemporalBoolean TemporalLessThanOrEqualTo(double other)
        {
            var res = MEOSExposedFunctions.tle_tfloat_float(this._ptr, other);
            return new TemporalBoolean(res);
        }

        public TemporalBoolean TemporalGreaterThan(double other)
        {
            var res = MEOSExposedFunctions.tgt_tfloat_float(this._ptr, other);
            return new TemporalBoolean(res);
        }

        public TemporalBoolean TemporalGreaterThanOrEqualTo(double other)
        {
            var res = MEOSExposedFunctions.tge_tfloat_float(this._ptr, other);
            return new TemporalBoolean(res);
        }

        public TemporalBoolean TemporalLessThan(int other)
            => this.TemporalLessThan((double)other);

        public TemporalBoolean TemporalLessThanOrEqualTo(int other)
            => this.TemporalLessThanOrEqualTo((double)other);

        public TemporalBoolean TemporalGreaterThan(int other)
            => this.TemporalGreaterThan((double)other);

        public TemporalBoolean TemporalGreaterThanOrEqualTo(int other)
            => this.TemporalGreaterThanOrEqualTo((double)other);

        public TemporalFloat At(double value)
        {
            var res = MEOSExposedFunctions.tfloat_at_value(this._ptr, value);
            return new TemporalFloat(res);
        }

        public TemporalFloat At(int value)
            => this.At((double)value);

        public double ValueAtTimestamp(DateTime timestamp)
        {
            var res = AllocHelper.AllocatePointer<double?>(sizeof(double), (resultPtr) =>
            {
                var successful = MEOSExposedFunctions.tfloat_value_at_timestamptz(this._ptr, timestamp.ToPgTimestamp(), strict: true, resultPtr);
                return successful ? resultPtr.ToStructure<double>() : default;
            });

            if (!res.HasValue)
            {
                throw new InvalidOperationException("Cannot retrieve value at a timestamp that does not exist in the current context.");
            }

            return res.Value;
        }

        public TemporalFloat Derivative()
        {
            var res = MEOSExposedFunctions.tfloat_derivative(this._ptr);
            return new TemporalFloat(res);
        }

        public TemporalFloat ToDegrees(bool normalize = true)
        {
            var res = MEOSExposedFunctions.tfloat_degrees(this._ptr, normalize);
            return new TemporalFloat(res);
        }

        public TemporalFloat ToRadians()
        {
            var res = MEOSExposedFunctions.tfloat_radians(this._ptr);
            return new TemporalFloat(res);
        }

        public TemporalFloat Round(int maxDecimals = 0)
        {
            var res = MEOSExposedFunctions.tfloat_round(this._ptr, maxdd: maxDecimals);
            return new TemporalFloat(res);
        }

        public TemporalFloat Shift(double delta)
        {
            var res = MEOSExposedFunctions.tfloat_shift_value(this._ptr, delta);
            return new TemporalFloat(res);
        }

        public TemporalFloat Scale(double width)
        {
            var res = MEOSExposedFunctions.tfloat_scale_value(this._ptr, width);
            return new TemporalFloat(res);
        }

        public TemporalFloat ShiftScale(double delta, double width)
        {
            var res = MEOSExposedFunctions.tfloat_shift_scale_value(this._ptr, delta, width);
            return new TemporalFloat(res);
        }

        public TemporalFloat Add(int value)
            => this.Add((double)value);

        public TemporalFloat Add(double value)
        {
            var res = MEOSExposedFunctions.add_tfloat_float(this._ptr, value);
            return new TemporalFloat(res);
        }

        public TemporalFloat Minus(int value)
            => this.Minus((double)value);

        public TemporalFloat Minus(double value)
        {
            var res = MEOSExposedFunctions.sub_tfloat_float(this._ptr, value);
            return new TemporalFloat(res);
        }

        public TemporalFloat Multiply(int value)
            => this.Multiply((double)value);

        public TemporalFloat Multiply(double value)
        {
            var res = MEOSExposedFunctions.mult_tfloat_float(this._ptr, value);
            return new TemporalFloat(res);
        }

        public TemporalFloat Divide(int value)
            => this.Divide((double)value);

        public TemporalFloat Divide(double value)
        {
            var res = MEOSExposedFunctions.div_tfloat_float(this._ptr, value);
            return new TemporalFloat(res);
        }

        public TemporalFloat DistanceTo(double other)
        {
            var res = MEOSExposedFunctions.distance_tfloat_float(this._ptr, other);
            return new TemporalFloat(res);
        }

        public TemporalFloat DistanceTo(int other)
            => this.DistanceTo((double)other);

        public double NearestApproachDistance(TemporalFloat other)
            => MEOSExposedFunctions.nad_tfloat_tfloat(this._ptr, other._ptr);

        public double NearestApproachDistance(double other)
            => MEOSExposedFunctions.nad_tfloat_float(this._ptr, other);

        public double NearestApproachDistance(int other)
            => this.NearestApproachDistance((double)other);

        public static TemporalFloat operator +(TemporalFloat tFloat, int number)
            => tFloat.Add(number);

        public static TemporalFloat operator +(TemporalFloat tFloat, double number)
            => tFloat.Add(number);

        public static TemporalFloat operator -(TemporalFloat tFloat, int number)
            => tFloat.Minus(number);

        public static TemporalFloat operator -(TemporalFloat tFloat, double number)
            => tFloat.Minus(number);

        public static TemporalFloat operator *(TemporalFloat tFloat, int number)
            => tFloat.Multiply(number);

        public static TemporalFloat operator *(TemporalFloat tFloat, double number)
            => tFloat.Multiply(number);

        public static TemporalFloat operator /(TemporalFloat tFloat, int number)
            => tFloat.Divide(number);

        public static TemporalFloat operator /(TemporalFloat tFloat, double number)
            => tFloat.Divide(number);
    }
}

