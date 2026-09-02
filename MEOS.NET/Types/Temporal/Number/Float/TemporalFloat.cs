using MEOS.NET.Enums;
using MEOS.NET.Helpers;
using MEOS.NET.Functions;
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
            var res = Meos.TfloatFromBaseTemp(value, temporal._ptr);
            return new TemporalFloat(res);
        }

        public static TemporalFloat FromString(string input)
        {
            var res = Meos.TfloatIn(input);
            return new TemporalFloatInstant(res);
        }

        public static TemporalFloat FromMFJson(string mfJsonStr)
            => new TemporalFloat(Meos.TfloatFromMfjson(mfJsonStr));

        public string Format(int maxDecimals)
            => Meos.TfloatOut(this._ptr, maxdd: maxDecimals);

        public override string ToString()
            => this.Format(15);

        public TemporalInteger ToTemporalInteger()
        {
            if (this.Interpolation() == InterpolationType.Linear)
            {
                throw new InvalidOperationException("Cannot convert a temporal float with linear" +
                    "interpolation to a temporal integer.");
            }

            var res = Meos.TfloatToTint(this._ptr);
            return new TemporalInteger(res);
        }

        public FloatSpan ToFloatSpan()
        {
            var res = Meos.TnumberToSpan(this._ptr);
            return new FloatSpan(res);
        }

        public FloatSpanSet ToFloatSpanSet()
        {
            var res = Meos.TnumberValuespans(this._ptr);
            return new FloatSpanSet(res);
        }

        public double StartValue()
            => Meos.TfloatStartValue(this._ptr);

        public double EndValue()
            => Meos.TfloatEndValue(this._ptr);

        public double MinValue()
            => Meos.TfloatMinValue(this._ptr);

        public double MaxValue()
            => Meos.TfloatMaxValue(this._ptr);

        public FloatSet ToFloatSet()
        {
            var values = Meos.TfloatValues(this._ptr);
            return FloatSet.FromValues(values);
        }

        public bool IsAlwaysLessThan(double value)
            => (Meos.AlwaysLtTfloatFloat(this._ptr, value) != 0);

        public bool IsAlwaysLessThanOrEqualTo(double value)
            => (Meos.AlwaysLeTfloatFloat(this._ptr, value) != 0);

        public bool IsAlwaysEqualTo(double value)
            => (Meos.AlwaysEqTfloatFloat(this._ptr, value) != 0);

        public bool IsEverLessThan(double value)
            => (Meos.EverLtTfloatFloat(this._ptr, value) != 0);

        public bool IsEverLessThanOrEqualTo(double value)
            => (Meos.EverLeTfloatFloat(this._ptr, value) != 0);

        public bool IsEverEqualTo(double value)
            => (Meos.EverEqTfloatFloat(this._ptr, value) != 0);

        public TemporalBoolean TemporalEqual(int other)
            => this.TemporalEqual((double)other);

        public TemporalBoolean TemporalNotEqual(int other)
            => this.TemporalNotEqual((double)other);

        public TemporalBoolean TemporalEqual(double other)
        {
            var res = Meos.TeqTfloatFloat(this._ptr, other);
            return new TemporalBoolean(res);
        }

        public TemporalBoolean TemporalNotEqual(double other)
        {
            var res = Meos.TneTfloatFloat(this._ptr, other);
            return new TemporalBoolean(res);
        }

        public TemporalBoolean TemporalLessThan(double other)
        {
            var res = Meos.TltTfloatFloat(this._ptr, other);
            return new TemporalBoolean(res);
        }

        public TemporalBoolean TemporalLessThanOrEqualTo(double other)
        {
            var res = Meos.TleTfloatFloat(this._ptr, other);
            return new TemporalBoolean(res);
        }

        public TemporalBoolean TemporalGreaterThan(double other)
        {
            var res = Meos.TgtTfloatFloat(this._ptr, other);
            return new TemporalBoolean(res);
        }

        public TemporalBoolean TemporalGreaterThanOrEqualTo(double other)
        {
            var res = Meos.TgeTfloatFloat(this._ptr, other);
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
            var res = Meos.TfloatAtValue(this._ptr, value);
            return new TemporalFloat(res);
        }

        public TemporalFloat At(int value)
            => this.At((double)value);

        public double ValueAtTimestamp(DateTime timestamp)
        {
            var res = AllocHelper.AllocatePointer<double?>(sizeof(double), (resultPtr) =>
            {
                var successful = (Meos.TfloatValueAtTimestamptz(this._ptr, timestamp.ToPgTimestamp(), strict: true, resultPtr));
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
            var res = Meos.TemporalDerivative(this._ptr);
            return new TemporalFloat(res);
        }

        public TemporalFloat ToDegrees(bool normalize = true)
        {
            var res = Meos.TfloatDegrees(this._ptr, normalize);
            return new TemporalFloat(res);
        }

        public TemporalFloat ToRadians()
        {
            var res = Meos.TfloatRadians(this._ptr);
            return new TemporalFloat(res);
        }

        public TemporalFloat Round(int maxDecimals = 0)
        {
            var res = Meos.TemporalRound(this._ptr, maxdd: maxDecimals);
            return new TemporalFloat(res);
        }

        public TemporalFloat Shift(double delta)
        {
            var res = Meos.TfloatShiftValue(this._ptr, delta);
            return new TemporalFloat(res);
        }

        public TemporalFloat Scale(double width)
        {
            var res = Meos.TfloatScaleValue(this._ptr, width);
            return new TemporalFloat(res);
        }

        public TemporalFloat ShiftScale(double delta, double width)
        {
            var res = Meos.TfloatShiftScaleValue(this._ptr, delta, width);
            return new TemporalFloat(res);
        }

        public TemporalFloat Add(int value)
            => this.Add((double)value);

        public TemporalFloat Add(double value)
        {
            var res = Meos.AddTfloatFloat(this._ptr, value);
            return new TemporalFloat(res);
        }

        public TemporalFloat Minus(int value)
            => this.Minus((double)value);

        public TemporalFloat Minus(double value)
        {
            var res = Meos.SubTfloatFloat(this._ptr, value);
            return new TemporalFloat(res);
        }

        public TemporalFloat Multiply(int value)
            => this.Multiply((double)value);

        public TemporalFloat Multiply(double value)
        {
            var res = Meos.MulTfloatFloat(this._ptr, value);
            return new TemporalFloat(res);
        }

        public TemporalFloat Divide(int value)
            => this.Divide((double)value);

        public TemporalFloat Divide(double value)
        {
            var res = Meos.DivTfloatFloat(this._ptr, value);
            return new TemporalFloat(res);
        }

        public TemporalFloat DistanceTo(double other)
        {
            var res = Meos.TdistanceTfloatFloat(this._ptr, other);
            return new TemporalFloat(res);
        }

        public TemporalFloat DistanceTo(int other)
            => this.DistanceTo((double)other);

        public double NearestApproachDistance(TemporalFloat other)
            => Meos.NadTfloatTfloat(this._ptr, other._ptr);

        public double NearestApproachDistance(double other)
            => Meos.NadTfloatFloat(this._ptr, other);

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

