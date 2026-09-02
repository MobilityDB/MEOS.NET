using MEOS.NET.Functions;
using MEOS.NET.Types.Collections.Integer;

namespace MEOS.NET.Types.Collections.Float
{
	public sealed class FloatSpan : Span
	{
        internal FloatSpan(IntPtr ptr) : base(ptr)
        { }

        public static FloatSpan FromString(string input)
        {
            var res = Meos.FloatspanIn(input);
            return new FloatSpan(res);
        }

        public static FloatSpan FromBounds(double xMin, double xMax, bool minInclusive = true, bool maxInclusive = false)
        {
            var res = Meos.FloatspanMake(xMin, xMax, minInclusive, maxInclusive);
            return new FloatSpan(res);
        }

        public override string ToString()
            => this.Format(maxDecimals: 15);

        public string Format(int maxDecimals)
            => Meos.FloatspanOut(this._ptr, maxdd: maxDecimals);

        public override FloatSpanSet ToSpanSet()
            => (FloatSpanSet)this.ToSpanSet();

        public IntegerSpan ToIntegerSpan()
        {
            var res = Meos.FloatspanToIntspan(this._ptr);
            return new IntegerSpan(res);
        }

        public double LowerBound()
            => Meos.FloatspanLower(this._ptr);

        public double UpperBound()
            => Meos.FloatspanUpper(this._ptr);

        public FloatSpan Shift(double delta)
        {
            var res = Meos.FloatspanShiftScale(this._ptr, delta, 0.0, hasshift: true, haswidth: false);
            return new FloatSpan(res);
        }

        public FloatSpan Scale(double newWidth)
        {
            var res = Meos.FloatspanShiftScale(this._ptr, 0.0, newWidth, hasshift: false, haswidth: true);
            return new FloatSpan(res);
        }

        public FloatSpan ShiftScale(double delta, double newWidth)
        {
            var res = Meos.FloatspanShiftScale(this._ptr, delta, newWidth, hasshift: true, haswidth: true);
            return new FloatSpan(res);
        }

        public bool IsAdjacent(double number)
            => (Meos.AdjacentSpanFloat(this._ptr, number));

        public bool IsAdjacent(int number)
            => this.IsAdjacent((double)number);

        public bool Contains(double number)
            => (Meos.ContainsSpanFloat(this._ptr, number));

        public bool Contains(int number)
            => this.Contains((double)number);

        public bool IsLeftOf(double number)
            => (Meos.LeftSpanFloat(this._ptr, number));

        public bool IsLeftOf(int number)
            => this.IsLeftOf((double)number);

        public bool IsOverOrLeftOf(double number)
            => (Meos.OverleftSpanFloat(this._ptr, number));

        public bool IsOverOrLeftOf(int number)
            => this.IsOverOrLeftOf((double)number);

        public bool IsRightOf(double number)
            => (Meos.RightSpanFloat(this._ptr, number));

        public bool IsRightOf(int number)
            => this.IsRightOf((double)number);

        public bool IsOverOrRightOf(double number)
            => (Meos.OverrightSpanFloat(this._ptr, number));

        public bool IsOverOrRightOf(int number)
            => this.IsOverOrRightOf((double)number);

        public double DistanceTo(double number)
            => Meos.DistanceSpanFloat(this._ptr, number);

        public double DistanceTo(int number)
            => this.DistanceTo((double)number);

        public FloatSpan IntersectionWith(double number)
        {
            var res = Meos.IntersectionSpanFloat(this._ptr, number);
            return new FloatSpan(res);
        }

        public FloatSpan IntersectionWith(int number)
            => this.IntersectionWith((double)number);

        public FloatSpan IntersectionWith(FloatSpan span)
        {
            var res = Meos.IntersectionSpanSpan(this._ptr, span._ptr);
            return new FloatSpan(res);
        }

        public FloatSpanSet IntersectionWith(FloatSpanSet spanSet)
        {
            var res = Meos.IntersectionSpansetSpan(spanSet._ptr, this._ptr);
            return new FloatSpanSet(res);
        }

        public FloatSpanSet Minus(double number)
        {
            var res = Meos.MinusSpanFloat(this._ptr, number);
            return new FloatSpanSet(res);
        }

        public FloatSpanSet Minus(int number)
            => this.Minus((double)number);

        public FloatSpanSet Minus(FloatSpan span)
        {
            var res = Meos.MinusSpanSpan(this._ptr, span._ptr);
            return new FloatSpanSet(res);
        }

        public FloatSpanSet Minus(FloatSpanSet spanSet)
        {
            var res = Meos.MinusSpansetSpan(spanSet._ptr, this._ptr);
            return new FloatSpanSet(res);
        }

        public FloatSpanSet UnionWith(double number)
        {
            var res = Meos.UnionSpanFloat(this._ptr, number);
            return new FloatSpanSet(res);
        }

        public FloatSpanSet UnionWith(int number)
            => this.UnionWith((double)number);

        public FloatSpanSet UnionWith(FloatSpan span)
        {
            var res = Meos.UnionSpanSpan(this._ptr, span._ptr);
            return new FloatSpanSet(res);
        }

        public FloatSpanSet UnionWith(FloatSpanSet spanSet)
        {
            var res = Meos.UnionSpansetSpan(spanSet._ptr, this._ptr);
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

