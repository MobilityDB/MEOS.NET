using MEOS.NET.Helpers;
using MEOS.NET.Internal;
using MEOS.NET.Types.Collections.Integer;

namespace MEOS.NET.Types.Collections.Float
{
    public sealed class FloatSet : Set
	{
        internal FloatSet(IntPtr ptr) : base(ptr)
        { }

        internal static FloatSet FromValuesPointer(IntPtr valuesArray, int arrayLength)
        {
            var res = MEOSExposedFunctions.floatset_make(valuesArray, arrayLength);
            return new FloatSet(res);
        }

        public IntegerSet ToIntegerSet()
        {
            var res = MEOSExposedFunctions.floatset_to_intset(this._ptr);
            return new IntegerSet(res);
        }

        public double StartElement()
            => MEOSExposedFunctions.floatset_start_value(this._ptr);

        public double EndElement()
            => MEOSExposedFunctions.floatset_end_value(this._ptr);

        public double ElementAt(int position)
        {
            var count = this.Count();

            if (position < 0 || position >= count)
            {
                throw new ArgumentOutOfRangeException(nameof(position), $"Requested element must be between 0 and {count - 1}");
            }

            return AllocHelper.AllocatePointer<double>(sizeof(double), (resultPtr) =>
            {
                var successful = MEOSExposedFunctions.floatset_value_n(this._ptr, position, resultPtr);
                return successful ? resultPtr.ToStructure<double>() : throw new InvalidOperationException($"Could not retrieve element at position {position}");
            }); 
        }

        public double this[int position]
        {
            get => this.ElementAt(position);
        }

        public IEnumerable<double> Values()
        {
            var count = this.Count();
            var valuesArrPtr = MEOSExposedFunctions.floatset_values(this._ptr);

            return valuesArrPtr.ToArrayOfType<double>(count);
        }

        public FloatSet Shift(double delta)
        {
            var res = MEOSExposedFunctions.floatset_shift_scale(this._ptr, delta, 0.0, hasshift: true, haswidth: false);
            return new FloatSet(res);
        }

        public FloatSet Scale(double newWidth)
        {
            var res = MEOSExposedFunctions.floatset_shift_scale(this._ptr, 0.0, newWidth, hasshift: false, haswidth: true);
            return new FloatSet(res);
        }

        public FloatSet ShiftScale(double delta, double newWidth)
        {
            var res = MEOSExposedFunctions.floatset_shift_scale(this._ptr, delta, newWidth, hasshift: true, haswidth: true);
            return new FloatSet(res);
        }

        public bool Contains(double value)
            => MEOSExposedFunctions.contains_set_float(this._ptr, value);

        public bool IsLeftOf(double value)
            => MEOSExposedFunctions.left_set_float(this._ptr, value);

        public bool IsOverOrLeftOf(double value)
            => MEOSExposedFunctions.overleft_set_float(this._ptr, value);

        public bool IsRightOf(double value)
            => MEOSExposedFunctions.right_set_float(this._ptr, value);

        public bool IsOverOrRightOf(double value)
            => MEOSExposedFunctions.overright_set_float(this._ptr, value);

        public FloatSet? IntersectionWith(double value)
        {
            var res = MEOSExposedFunctions.intersection_set_float(this._ptr, value);

            if (res == IntPtr.Zero)
            {
                return default;
            }

            return new FloatSet(res);
        }

        public FloatSet? IntersectionWith(FloatSet set)
        {
            var res = MEOSExposedFunctions.intersection_set_set(this._ptr, set._ptr);

            if (res == IntPtr.Zero)
            {
                return default;
            }

            return new FloatSet(res);
        }

        public FloatSet Minus(double value)
        {
            var res = MEOSExposedFunctions.minus_set_float(this._ptr, value);
            return new FloatSet(res);
        }

        public FloatSet Minus(FloatSet set)
        {
            var res = MEOSExposedFunctions.minus_set_set(this._ptr, set._ptr);
            return new FloatSet(res);
        }

        public FloatSet SubtractFrom(FloatSet set)
        {
            var res = MEOSExposedFunctions.minus_set_set(set._ptr, this._ptr);
            return new FloatSet(res);
        }

        public FloatSet UnionWith(double value)
        {
            var res = MEOSExposedFunctions.union_set_float(this._ptr, value);
            return new FloatSet(res);
        }

        public FloatSet UnionWith(FloatSet set)
        {
            var res = MEOSExposedFunctions.union_set_set(this._ptr, set._ptr);
            return new FloatSet(res);
        }

        public double DistanceTo(int value)
            => this.DistanceTo((double)value);

        public double DistanceTo(double value)
            => MEOSExposedFunctions.distance_set_float(this._ptr, value);

        public double DistanceTo(FloatSet set)
            => MEOSExposedFunctions.distance_set_set(this._ptr, set._ptr);

        public double DistanceTo(FloatSpan span)
            => this.ToSpanSet().DistanceTo(span);

        public double DistanceTo(FloatSpanSet spanSet)
            => this.ToSpanSet().DistanceTo(spanSet);

        public string Format(int maxDecimals = 15)
            => MEOSExposedFunctions.floatset_out(this._ptr, maxdd: maxDecimals);

        public override string ToString()
            => this.Format(maxDecimals: 15);

        // TODO : Operators
    }
}

