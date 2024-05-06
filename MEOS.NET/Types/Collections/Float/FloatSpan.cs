using MEOS.NET.Internal;
using MEOS.NET.Types.Collections.Integer;

namespace MEOS.NET.Types.Collections.Float
{
	public sealed class FloatSpan : Span
	{
        internal FloatSpan(IntPtr ptr) : base(ptr)
        { }

        public static FloatSpan FromString(string input)
        {
            var res = MEOSExposedFunctions.floatspan_in(input);
            return new FloatSpan(res);
        }

        public override string ToString()
            => this.Format(maxDecimals: 15);

        public string Format(int maxDecimals)
            => MEOSExposedFunctions.floatspan_out(this._ptr, maxdd: maxDecimals);

        public override FloatSpanSet ToSpanSet()
            => (FloatSpanSet)this.ToSpanSet();

        public IntegerSpan ToIntegerSpan()
        {
            var res = MEOSExposedFunctions.floatspan_to_intspan(this._ptr);
            return new IntegerSpan(res);
        }

        public double LowerBound()
            => MEOSExposedFunctions.floatspan_lower(this._ptr);

        public double UpperBound()
            => MEOSExposedFunctions.floatspan_upper(this._ptr);

        public double Width()
        {
            throw new NotImplementedException(); // TODO : Check for new MEOS version ? Method not available
        }

        public FloatSpan Shift(double delta)
        {
            var res = MEOSExposedFunctions.floatspan_shift_scale(this._ptr, delta, 0.0, hasshift: true, haswidth: false);
            return new FloatSpan(res);
        }

        public FloatSpan Scale(double newWidth)
        {
            var res = MEOSExposedFunctions.floatspan_shift_scale(this._ptr, 0.0, newWidth, hasshift: false, haswidth: true);
            return new FloatSpan(res);
        }

        public FloatSpan ShiftScale(double delta, double newWidth)
        {
            var res = MEOSExposedFunctions.floatspan_shift_scale(this._ptr, delta, newWidth, hasshift: true, haswidth: true);
            return new FloatSpan(res);
        }

        public bool IsAdjacent(double number)
            => MEOSExposedFunctions.adjacent_span_float(this._ptr, number);

        public bool IsAdjacent(int number)
            => this.IsAdjacent((double)number);

        public bool Contains(double number)
            => MEOSExposedFunctions.contains_span_float(this._ptr, number);

        public bool Contains(int number)
            => this.Contains((double)number);

        public bool IsLeftOf(double number)
            => MEOSExposedFunctions.left_span_float(this._ptr, number);

        public bool IsLeftOf(int number)
            => this.IsLeftOf((double)number);

        public bool IsOverOrLeftOf(double number)
            => MEOSExposedFunctions.overleft_span_float(this._ptr, number);

        public bool IsOverOrLeftOf(int number)
            => this.IsOverOrLeftOf((double)number);

        public bool IsRightOf(double number)
            => MEOSExposedFunctions.right_span_float(this._ptr, number);

        public bool IsRightOf(int number)
            => this.IsRightOf((double)number);

        public bool IsOverOrRightOf(double number)
            => MEOSExposedFunctions.overright_span_float(this._ptr, number);

        public bool IsOverOrRightOf(int number)
            => this.IsOverOrRightOf((double)number);

        public double DistanceTo(double number)
            => MEOSExposedFunctions.distance_span_float(this._ptr, number);

        public double DistanceTo(int number)
            => this.DistanceTo((double)number);

        public FloatSpan IntersectionWith(double number)
        {
            var res = MEOSExposedFunctions.intersection_span_float(this._ptr, number);
            return new FloatSpan(res);
        }

        public FloatSpan IntersectionWith(int number)
            => this.IntersectionWith((double)number);

        public FloatSpan IntersectionWith(FloatSpan span)
        {
            var res = MEOSExposedFunctions.intersection_span_span(this._ptr, span._ptr);
            return new FloatSpan(res);
        }

        public FloatSpanSet IntersectionWith(FloatSpanSet spanSet)
        {
            var res = MEOSExposedFunctions.intersection_spanset_span(spanSet._ptr, this._ptr);
            return new FloatSpanSet(res);
        }

        public FloatSpanSet Minus(double number)
        {
            var res = MEOSExposedFunctions.minus_span_float(this._ptr, number);
            return new FloatSpanSet(res);
        }

        public FloatSpanSet Minus(int number)
            => this.Minus((double)number);

        public FloatSpanSet Minus(FloatSpan span)
        {
            var res = MEOSExposedFunctions.minus_span_span(this._ptr, span._ptr);
            return new FloatSpanSet(res);
        }

        public FloatSpanSet Minus(FloatSpanSet spanSet)
        {
            var res = MEOSExposedFunctions.minus_spanset_span(spanSet._ptr, this._ptr);
            return new FloatSpanSet(res);
        }

        public FloatSpanSet UnionWith(double number)
        {
            var res = MEOSExposedFunctions.union_span_float(this._ptr, number);
            return new FloatSpanSet(res);
        }

        public FloatSpanSet UnionWith(int number)
            => this.UnionWith((double)number);

        public FloatSpanSet UnionWith(FloatSpan span)
        {
            var res = MEOSExposedFunctions.union_span_span(this._ptr, span._ptr);
            return new FloatSpanSet(res);
        }

        public FloatSpanSet UnionWith(FloatSpanSet spanSet)
        {
            var res = MEOSExposedFunctions.union_spanset_span(spanSet._ptr, this._ptr);
            return new FloatSpanSet(res);
        }

        public static FloatSpanSet operator +(FloatSpan span, double number)
            => span.UnionWith(number);

        public static FloatSpanSet operator +(FloatSpan span, int number)
            => span.UnionWith(number);

        public static FloatSpanSet operator +(FloatSpan span1, FloatSpan span2)
            => span1.UnionWith(span2);

        public static FloatSpanSet operator +(FloatSpan span, FloatSpanSet spanSet)
            => span.UnionWith(spanSet);

        public static FloatSpanSet operator -(FloatSpan span, double number)
            => span.Minus(number);

        public static FloatSpanSet operator -(FloatSpan span, int number)
            => span.Minus(number);

        public static FloatSpanSet operator -(FloatSpan span1, FloatSpan span2)
            => span1.Minus(span2);

        public static FloatSpanSet operator -(FloatSpan span, FloatSpanSet spanSet)
            => span.Minus(spanSet);
    }
}

