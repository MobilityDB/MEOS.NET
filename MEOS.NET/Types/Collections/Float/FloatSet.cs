using MEOS.NET.Helpers;
using MEOS.NET.Functions;
using MEOS.NET.Types.Collections.Integer;

namespace MEOS.NET.Types.Collections.Float
{
    public sealed class FloatSet : Set
	{
        internal FloatSet(IntPtr ptr) : base(ptr)
        { }

        internal static FloatSet FromValues(double[] values)
        {
            var res = AllocHelper.AllocateArrayPointer<double, IntPtr>(values,
                (valuesPtr) => Meos.FloatsetMake(valuesPtr, values.Length));
            return new FloatSet(res);
        }

        public IntegerSet ToIntegerSet()
        {
            var res = Meos.FloatsetToIntset(this._ptr);
            return new IntegerSet(res);
        }

        public double StartElement()
            => Meos.FloatsetStartValue(this._ptr);

        public double EndElement()
            => Meos.FloatsetEndValue(this._ptr);

        public double ElementAt(int position)
        {
            var count = this.Count();

            if (position < 0 || position >= count)
            {
                throw new ArgumentOutOfRangeException(nameof(position), $"Requested element must be between 0 and {count - 1}");
            }

            return AllocHelper.AllocatePointer<double>(sizeof(double), (resultPtr) =>
            {
                var successful = (Meos.FloatsetValueN(this._ptr, position, resultPtr));
                return successful ? resultPtr.ToStructure<double>() : throw new InvalidOperationException($"Could not retrieve element at position {position}");
            }); 
        }

        public double this[int position]
        {
            get => this.ElementAt(position);
        }

        public IEnumerable<double> Values()
            => Meos.FloatsetValues(this._ptr);

        public FloatSet Shift(double delta)
        {
            var res = Meos.FloatsetShiftScale(this._ptr, delta, 0.0, hasshift: true, haswidth: false);
            return new FloatSet(res);
        }

        public FloatSet Scale(double newWidth)
        {
            var res = Meos.FloatsetShiftScale(this._ptr, 0.0, newWidth, hasshift: false, haswidth: true);
            return new FloatSet(res);
        }

        public FloatSet ShiftScale(double delta, double newWidth)
        {
            var res = Meos.FloatsetShiftScale(this._ptr, delta, newWidth, hasshift: true, haswidth: true);
            return new FloatSet(res);
        }

        public bool Contains(double value)
            => (Meos.ContainsSetFloat(this._ptr, value));

        public bool IsLeftOf(double value)
            => (Meos.LeftSetFloat(this._ptr, value));

        public bool IsOverOrLeftOf(double value)
            => (Meos.OverleftSetFloat(this._ptr, value));

        public bool IsRightOf(double value)
            => (Meos.RightSetFloat(this._ptr, value));

        public bool IsOverOrRightOf(double value)
            => (Meos.OverrightSetFloat(this._ptr, value));

        public FloatSet? IntersectionWith(double value)
        {
            var res = Meos.IntersectionSetFloat(this._ptr, value);

            if (res == IntPtr.Zero)
            {
                return default;
            }

            return new FloatSet(res);
        }

        public FloatSet? IntersectionWith(FloatSet set)
        {
            var res = Meos.IntersectionSetSet(this._ptr, set._ptr);

            if (res == IntPtr.Zero)
            {
                return default;
            }

            return new FloatSet(res);
        }

        public FloatSet Minus(double value)
        {
            var res = Meos.MinusSetFloat(this._ptr, value);
            return new FloatSet(res);
        }

        public FloatSet Minus(FloatSet set)
        {
            var res = Meos.MinusSetSet(this._ptr, set._ptr);
            return new FloatSet(res);
        }

        public FloatSet SubtractFrom(FloatSet set)
        {
            var res = Meos.MinusSetSet(set._ptr, this._ptr);
            return new FloatSet(res);
        }

        public FloatSet UnionWith(double value)
        {
            var res = Meos.UnionSetFloat(this._ptr, value);
            return new FloatSet(res);
        }

        public FloatSet UnionWith(FloatSet set)
        {
            var res = Meos.UnionSetSet(this._ptr, set._ptr);
            return new FloatSet(res);
        }

        public double DistanceTo(int value)
            => this.DistanceTo((double)value);

        public double DistanceTo(double value)
            => Meos.DistanceSetFloat(this._ptr, value);

        public double DistanceTo(FloatSet set)
            => Meos.DistanceSetSet(this._ptr, set._ptr);

        public double DistanceTo(FloatSpan span)
            => this.ToSpanSet().DistanceTo(span);

        public double DistanceTo(FloatSpanSet spanSet)
            => this.ToSpanSet().DistanceTo(spanSet);

        public string Format(int maxDecimals = 15)
            => Meos.FloatsetOut(this._ptr, maxdd: maxDecimals);

        public override string ToString()
            => this.Format(maxDecimals: 15);

        // TODO : Operators
    }
}

