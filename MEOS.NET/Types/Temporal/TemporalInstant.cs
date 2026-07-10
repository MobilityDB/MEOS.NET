using MEOS.NET.Helpers;
using MEOS.NET.Internal;
using MEOS.NET.Structures;

namespace MEOS.NET.Types.Temporal
{
    public class TemporalInstant<TBase> : Temporal
    {
        public TemporalInstant(IntPtr ptr) : base(ptr)
        { }

        public DateTime Timestamp()
        {
            var timestamps = MEOSExposedFunctions.temporal_timestamps(this._ptr);

            if (timestamps.Length != 1)
            {
                throw new InvalidOperationException("The number of elements in the array of instants should be 1 for a single instant.");
            }

            return new TimestampTz { Time = timestamps[0] }.ToDateTime();
        }

        public IEnumerable<DateTime> TimestampAsEnumerable()
        {
            return new List<DateTime>
            {
                this.Timestamp(),
            };
        }

        public IEnumerable<TemporalInstant<TBase>> ToEnumerable()
        {
            return new List<TemporalInstant<TBase>>
            {
                this,
            };
        }
    }
}
