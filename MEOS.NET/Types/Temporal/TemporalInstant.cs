namespace MEOS.NET.Types.Temporal
{
    public class TemporalInstant<TBase> : Temporal
    {
        public TemporalInstant(IntPtr ptr) : base(ptr)
        { }

        public DateTime Timestamp()
        {
            throw new NotImplementedException(); // TODO : Check PyMEOS
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
