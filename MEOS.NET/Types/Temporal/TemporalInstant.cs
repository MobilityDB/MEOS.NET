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
            int count = 0;
            var timestampArrPtr = AllocHelper.AllocatePointer(sizeof(int), (countPtr) =>
            {
                var res = MEOSExposedFunctions.temporal_timestamps(this._ptr, countPtr);
                count = countPtr.ToStructure<int>();

                return res;
            });
             
            if (count != 1)
            {
                throw new InvalidOperationException("The number of elements in the array of instants should be 1 for a single instant.");
            }

            var array = timestampArrPtr.ToArrayOfType<TimestampTz>(count);
            return array[0].ToDateTime();
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
