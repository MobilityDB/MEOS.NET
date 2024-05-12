using MEOS.NET.Helpers;
using MEOS.NET.Internal;

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
            var res = MEOSExposedFunctions.tfloatinst_make(value, timestamp.ToPgTimestamp());
            return new TemporalFloatInstant(res);
        }

        public double Value()
            => MEOSExposedFunctions.tfloat_start_value(this._ptr);
    }
}

