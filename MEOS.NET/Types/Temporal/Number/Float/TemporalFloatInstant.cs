using MEOS.NET.Helpers;
using MEOS.NET.Functions;

namespace MEOS.NET.Types.Temporal.Number.Float
{
    public class TemporalFloatInstant : TemporalFloat, IInstanteable<double>
    {
        public TemporalInstant<double> Instant { get; init; }

        internal TemporalFloatInstant(IntPtr ptr) : base(ptr)
            => this.Instant = new TemporalInstant<double>(ptr);

        public static new TemporalFloatInstant FromString(string input)
            => (TemporalFloatInstant)TemporalFloat.FromString(input);

        public static TemporalFloatInstant FromTimestamp(DateTime timestamp, double value)
        {
            var res = Meos.TfloatinstMake(value, timestamp.ToPgTimestamp());
            return new TemporalFloatInstant(res);
        }

        public double Value()
            => Meos.TfloatStartValue(this._ptr);
    }
}

