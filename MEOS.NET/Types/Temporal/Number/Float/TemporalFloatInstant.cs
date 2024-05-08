using MEOS.NET.Internal;

namespace MEOS.NET.Types.Temporal.Number.Float
{
    public class TemporalFloatInstant : TemporalFloat, IInstanteable<double>
    {
        public TemporalInstant<double> Instant { get; init; }

        internal TemporalFloatInstant(IntPtr ptr) : base(ptr)
            => this.Instant = new TemporalInstant<double>(ptr);

        public static TemporalFloatInstant FromTimestamp(DateTimeOffset timestamp, double value)
        {
            var res = MEOSExposedFunctions.tfloatinst_make(value, timestamp);
            return new TemporalFloatInstant(res);
        }

        public double Value()
        {
            throw new NotImplementedException();
        }
    }
}

