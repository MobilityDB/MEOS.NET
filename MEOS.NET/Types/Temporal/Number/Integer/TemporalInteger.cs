using MEOS.NET.Functions;

namespace MEOS.NET.Types.Temporal.Number.Integer
{
    public class TemporalInteger : Temporal
    {
        internal TemporalInteger(IntPtr ptr) : base(ptr)
        { }

        public TemporalInteger Shift(int delta)
        {
            var res = Meos.TintShiftValue(this._ptr, delta);
            return new TemporalInteger(res);
        }

        public TemporalInteger Scale(int width)
        {
            var res = Meos.TintScaleValue(this._ptr, width);
            return new TemporalInteger(res);
        }

        public TemporalInteger ShiftScale(int delta, int width)
        {
            var res = Meos.TintShiftScaleValue(this._ptr, delta, width);
            return new TemporalInteger(res);
        }

        public TemporalInteger Add(int value)
        {
            var res = Meos.AddTintInt(this._ptr, value);
            return new TemporalInteger(res);
        }

        public static TemporalInteger operator +(TemporalInteger tInteger, int number)
            => tInteger.Add(number);
    }
}

