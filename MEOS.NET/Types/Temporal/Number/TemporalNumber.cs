using MEOS.NET.Internal;
using MEOS.NET.Types.Boxes;
using MEOS.NET.Types.Collections;
using MEOS.NET.Types.Collections.Float;
using MEOS.NET.Types.Collections.Integer;
using MEOS.NET.Types.Temporal.Number.Float;

namespace MEOS.NET.Types.Temporal.Number
{
    public class TemporalNumber : Temporal
    {
        internal TemporalNumber(IntPtr ptr) : base(ptr)
        { }

        private TemporalNumber At(Set set)
        {
            var res = MEOSExposedFunctions.temporal_at_values(this._ptr, set._ptr);
            return new TemporalNumber(res);
        }

        private TemporalNumber At(Span span)
        {
            var res = MEOSExposedFunctions.tnumber_at_span(this._ptr, span._ptr);
            return new TemporalNumber(res);
        }

        private TemporalNumber At(SpanSet spanSet)
        {
            var res = MEOSExposedFunctions.tnumber_at_spanset(this._ptr, spanSet._ptr);
            return new TemporalNumber(res);
        }

        private TemporalNumber Minus(Set set)
        {
            var res = MEOSExposedFunctions.temporal_minus_values(this._ptr, set._ptr);
            return new TemporalNumber(res);
        }

        private TemporalNumber Minus(Span span)
        {
            var res = MEOSExposedFunctions.tnumber_minus_span(this._ptr, span._ptr);
            return new TemporalNumber(res);
        }

        private TemporalNumber Minus(SpanSet spanSet)
        {
            var res = MEOSExposedFunctions.tnumber_minus_spanset(this._ptr, spanSet._ptr);
            return new TemporalNumber(res);
        }

        public TemporalNumber At(FloatSet set)
            => this.At(set as Set);

        public TemporalNumber At(IntegerSet set)
            => this.At(set as Set);

        public TemporalNumber At(FloatSpan span)
            => this.At(span as Span);

        public TemporalNumber At(IntegerSpan span)
            => this.At(span as Span);

        public TemporalNumber At(FloatSpanSet spanSet)
            => this.At(spanSet as SpanSet);

        public TemporalNumber At(IntegerSpanSet spanSet)
            => this.At(spanSet as SpanSet);

        public TemporalNumber At(TemporalBox box)
        {
            var res = MEOSExposedFunctions.tnumber_at_tbox(this._ptr, box._ptr);
            return new TemporalNumber(res);
        }

        public TemporalNumber Minus(FloatSet set)
            => this.Minus(set as Set);

        public TemporalNumber Minus(IntegerSet set)
            => this.Minus(set as Set);

        public TemporalNumber Minus(FloatSpan span)
            => this.Minus(span as Span);

        public TemporalNumber Minus(IntegerSpan span)
            => this.Minus(span as Span);

        public TemporalNumber Minus(FloatSpanSet spanSet)
            => this.Minus(spanSet as SpanSet);

        public TemporalNumber Minus(IntegerSpanSet spanSet)
            => this.Minus(spanSet as SpanSet);

        public TemporalNumber Minus(TemporalBox box)
        {
            var res = MEOSExposedFunctions.tnumber_minus_tbox(this._ptr, box._ptr);
            return new TemporalNumber(res);
        }

        public TemporalBox BoundingBox()
        {
            var res = MEOSExposedFunctions.tnumber_to_tbox(this._ptr);
            return new TemporalBox(res);
        }

        public double Integral()
            => MEOSExposedFunctions.tnumber_integral(this._ptr);

        public double TimeWeightedAverage()
            => MEOSExposedFunctions.tnumber_twavg(this._ptr);

        public bool IsLeftOf(TemporalBox other)
            => this.BoundingBox().IsLeftOf(other);

        public bool IsLeftOf(TemporalNumber other)
            => this.BoundingBox().IsLeftOf(other);

        public bool IsOverOrLeftOf(TemporalBox other)
            => this.BoundingBox().IsOverOrLeftOf(other);

        public bool IsOverOrLeftOf(TemporalNumber other)
            => this.BoundingBox().IsOverOrLeftOf(other);

        public bool IsRightOf(TemporalBox other)
            => this.BoundingBox().IsRightOf(other);

        public bool IsRightOf(TemporalNumber other)
            => this.BoundingBox().IsRightOf(other);

        public bool IsOverOrRightOf(TemporalBox other)
            => this.BoundingBox().IsOverOrRightOf(other);

        public bool IsOverOrRightOf(TemporalNumber other)
            => this.BoundingBox().IsOverOrRightOf(other);

        public TemporalNumber Add(TemporalNumber other)
        {
            var res = MEOSExposedFunctions.add_tnumber_tnumber(this._ptr, other._ptr);
            return new TemporalNumber(res);
        }

        public TemporalNumber Minus(TemporalNumber other)
        {
            var res = MEOSExposedFunctions.sub_tnumber_tnumber(this._ptr, other._ptr);
            return new TemporalNumber(res);
        }

        public TemporalNumber Multiply(TemporalNumber other)
        {
            var res = MEOSExposedFunctions.mult_tnumber_tnumber(this._ptr, other._ptr);
            return new TemporalNumber(res);
        }

        public TemporalNumber Divide(TemporalNumber other)
        {
            var res = MEOSExposedFunctions.div_tnumber_tnumber(this._ptr, other._ptr);
            return new TemporalNumber(res);
        }

        public TemporalNumber Absolute()
        {
            var res = MEOSExposedFunctions.tnumber_abs(this._ptr);
            return new TemporalNumber(res);
        }

        public TemporalNumber Delta()
        {
            var res = MEOSExposedFunctions.tnumber_delta_value(this._ptr);
            return new TemporalNumber(res);
        }

        public TemporalNumber DistanceTo(TemporalNumber other)
        {
            var res = MEOSExposedFunctions.distance_tnumber_tnumber(this._ptr, other._ptr);
            return new TemporalNumber(res);
        }

        public double NearestApproachDistance(TemporalNumber other)
            => MEOSExposedFunctions.nad_tfloat_tfloat(this._ptr, other._ptr);

        public double NearestApproachDistance(TemporalBox other)
            => MEOSExposedFunctions.nad_tnumber_tbox(this._ptr, other._ptr);

        public static TemporalNumber operator /(TemporalNumber tNumber1, TemporalNumber tNumber2)
            => tNumber1.Divide(tNumber2);

        public static TemporalNumber operator *(TemporalNumber tNumber1, TemporalNumber tNumber2)
            => tNumber1.Multiply(tNumber2);

        public static TemporalNumber operator +(TemporalNumber tNumber1, TemporalNumber tNumber2)
            => tNumber1.Add(tNumber2);

        public static TemporalNumber operator -(TemporalNumber tNumber1, TemporalNumber tNumber2)
            => tNumber1.Minus(tNumber2);

        public static TemporalNumber operator -(TemporalNumber tNumber, FloatSet set)
            => tNumber.Minus(set);

        public static TemporalNumber operator -(TemporalNumber tNumber, IntegerSet set)
            => tNumber.Minus(set);

        public static TemporalNumber operator -(TemporalNumber tNumber, FloatSpan span)
            => tNumber.Minus(span);

        public static TemporalNumber operator -(TemporalNumber tNumber, IntegerSpan span)
            => tNumber.Minus(span);

        public static TemporalNumber operator -(TemporalNumber tNumber, FloatSpanSet spanSet)
            => tNumber.Minus(spanSet);

        public static TemporalNumber operator -(TemporalNumber tNumber, IntegerSpanSet spanSet)
            => tNumber.Minus(spanSet);

        public static TemporalNumber operator -(TemporalNumber tNumber, TemporalBox box)
            => tNumber.Minus(box);
    }
}

