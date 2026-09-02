using MEOS.NET.Functions;
using MEOS.NET.Types.Collections.Integer;

namespace MEOS.NET.Types.Collections.Float
{
	public sealed class FloatSpanSet : SpanSet
	{
        internal FloatSpanSet(IntPtr ptr) : base(ptr)
        { }

        public static FloatSpanSet FromString(string input)
        {
            var res = Meos.FloatspansetIn(input);
            return new FloatSpanSet(res);
        }

        public override FloatSpan ToSpan()
            => (FloatSpan)base.ToSpan();

        public IntegerSpanSet ToIntegerSpanSet()
        {
            var res = Meos.FloatspansetToIntspanset(this._ptr);
            return new IntegerSpanSet(res);
        }

        public string Format(int maxDecimals)
            => Meos.FloatspansetOut(this._ptr, maxdd: maxDecimals);

        public override string ToString()
            => this.Format(15);

        public override FloatSpan StartSpan()
            => (FloatSpan)base.StartSpan();

        public override FloatSpan EndSpan()
            => (FloatSpan)base.EndSpan();

        public override FloatSpan SpanAt(int position)
            => (FloatSpan)base.SpanAt(position);

        public FloatSpanSet Shift(double delta)
        {
            var res = Meos.FloatspansetShiftScale(this._ptr, delta, 0.0, hasshift: true, haswidth: false);
            return new FloatSpanSet(res);
        }

        public FloatSpanSet Scale(double newWidth)
        {
            var res = Meos.FloatspansetShiftScale(this._ptr, 0.0, newWidth, hasshift: false, haswidth: true);
            return new FloatSpanSet(res);
        }

        public FloatSpanSet ShiftScale(double delta, double newWidth)
        {
            var res = Meos.FloatspansetShiftScale(this._ptr, delta, newWidth, hasshift: true, haswidth: true);
            return new FloatSpanSet(res);
        }

        public bool IsAdjacent(double number)
            => (Meos.AdjacentSpansetFloat(this._ptr, number));

        public bool IsAdjacent(int number)
            => this.IsAdjacent((double)number);

        public bool Contains(double number)
            => (Meos.ContainsSpansetFloat(this._ptr, number));

        public bool Contains(int number)
            => this.IsAdjacent((double)number);

        public bool IsLeftOf(double number)
            => (Meos.LeftSpansetFloat(this._ptr, number));

        public bool IsLeftOf(int number)
            => this.IsLeftOf((double)number);

        public bool IsOverOrLeftOf(double number)
            => (Meos.OverleftSpansetFloat(this._ptr, number));

        public bool IsOverOrLeftOf(int number)
            => this.IsOverOrLeftOf((double)number);

        public bool IsRightOf(double number)
            => (Meos.RightSpansetFloat(this._ptr, number));

        public bool IsRightOf(int number)
            => this.IsRightOf((double)number);

        public bool IsOverOrRightOf(double number)
            => (Meos.OverrightSpansetFloat(this._ptr, number));

        public bool IsOverOrRightOf(int number)
            => this.IsOverOrLeftOf((double)number);

        public double DistanceTo(double number)
            => Meos.DistanceSpansetFloat(this._ptr, number);

        public double DistanceTo(int number)
            => this.DistanceTo((double)number);

        public FloatSpanSet IntersectionWith(double number)
        {
            var res = Meos.IntersectionSpansetFloat(this._ptr, number);
            return new FloatSpanSet(res);
        }

        public FloatSpanSet IntersectionWith(int number)
            => this.IntersectionWith((double)number);

        public FloatSpanSet Minus(double number)
        {
            var res = Meos.MinusSpansetFloat(this._ptr, number);
            return new FloatSpanSet(res);
        }

        public FloatSpanSet Minus(int number)
            => this.Minus((double)number);

        public FloatSpanSet UnionWith(double number)
        {
            var res = Meos.UnionSpansetFloat(this._ptr, number);
            return new FloatSpanSet(res);
        }

        public FloatSpanSet UnionWith(int number)
            => this.UnionWith((double)number);

        public static FloatSpanSet operator +(FloatSpanSet spanSet, double number)
            => spanSet.UnionWith(number);

        public static FloatSpanSet operator +(FloatSpanSet spanSet, int number)
            => spanSet.UnionWith((double)number);

        public static FloatSpanSet operator -(FloatSpanSet spanSet, double number)
            => spanSet.Minus(number);

        public static FloatSpanSet operator -(FloatSpanSet spanSet, int number)
            => spanSet.Minus((double)number);
    }
}

