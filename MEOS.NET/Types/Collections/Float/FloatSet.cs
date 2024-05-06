using MEOS.NET.Internal;
using MEOS.NET.Types.Collections.Integer;

namespace MEOS.NET.Types.Collections.Float
{
    public sealed class FloatSet : Set
	{
        internal FloatSet(IntPtr ptr) : base(ptr)
        { }

        public IntegerSet ToIntegerSet()
            => throw new NotImplementedException(); // TODO : Check PyMEOS

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

            throw new NotImplementedException();

            /*double result;
            MEOSExposedFunctions.floatset_value_n(this._ptr, position, res);*/

            // TODO : Convert IntPtr (double*) to C# double
        }

        public double this[int position]
        {
            get => this.ElementAt(position);
        }

        public IEnumerable<double> Values()
        {
            // TODO : Convert IntPtr to IEnumerable
            throw new NotImplementedException();
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

        public bool IsLeft(double value)
            => MEOSExposedFunctions.left_set_float(this._ptr, value);

        public bool IsOverOrLeft(double value)
            => MEOSExposedFunctions.overleft_set_float(this._ptr, value);

        public bool IsRight(double value)
            => MEOSExposedFunctions.right_set_float(this._ptr, value);

        public bool IsOverOrRight(double value)
            => MEOSExposedFunctions.overright_set_float(this._ptr, value);

        public FloatSet Intersection(double value)
        {
            var res = MEOSExposedFunctions.intersection_set_float(this._ptr, value);
            return new FloatSet(res); // TODO : If inter is empty, what happens with IntPtr to check if null ?? (IntPtr.Zero ??)
        }

        public FloatSet Intersection(FloatSet set)
        {
            var res = MEOSExposedFunctions.intersection_set_set(this._ptr, set._ptr);
            return new FloatSet(res); // TODO : If inter is empty, what happens with IntPtr to check if null ?? (IntPtr.Zero ??)
                                      // TODO : Apply first TO-DO to all function having the case...
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

        public FloatSet Union(double value)
        {
            var res = MEOSExposedFunctions.union_set_float(this._ptr, value);
            return new FloatSet(res);
        }

        public FloatSet Union(FloatSet set)
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
            => throw new NotImplementedException(); // TODO : Convert to SpanSet (yes, spanset) and use distance method of Span

        public double DistanceTo(FloatSpanSet spanSet)
            => throw new NotImplementedException(); // TODO : Same as FloatSpan distance

        public string Format(int maxDecimals = 15)
            => MEOSExposedFunctions.floatset_out(this._ptr, maxdd: maxDecimals);

        public override string ToString()
            => this.Format(maxDecimals: 15);
    }
}

