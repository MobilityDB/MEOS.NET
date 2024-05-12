using MEOS.NET.Internal;

namespace MEOS.NET.Types.Temporal.Number.Integer
{
    public class TemporalInteger : Temporal
    {
        internal TemporalInteger(IntPtr ptr) : base(ptr)
        { }

        public TemporalInteger Shift(int delta)
        {
            var res = MEOSExposedFunctions.tint_shift_value(this._ptr, delta);
            return new TemporalInteger(res);
        }

        public TemporalInteger Scale(int width)
        {
            var res = MEOSExposedFunctions.tint_scale_value(this._ptr, width);
            return new TemporalInteger(res);
        }

        public TemporalInteger ShiftScale(int delta, int width)
        {
            var res = MEOSExposedFunctions.tint_shift_scale_value(this._ptr, delta, width);
            return new TemporalInteger(res);
        }

        public TemporalInteger Add(int value)
        {
            var res = MEOSExposedFunctions.add_tint_int(this._ptr, value);
            return new TemporalInteger(res);
        }

        public static TemporalInteger operator +(TemporalInteger tInteger, int number)
            => tInteger.Add(number);
    }
}

