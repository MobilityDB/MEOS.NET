namespace MEOS.NET.Types.Collections.Time.Timestamp
{
    public sealed class TimestampTzSet : Set, ITimeCollection<TimestampTzSet>
	{
        internal TimestampTzSet(IntPtr ptr) : base(ptr)
        { }

        public bool Contains(TimestampTzSet collection)
        {
            throw new NotImplementedException();
        }

        public bool IsAfter(TimestampTzSet timeCollection)
        {
            throw new NotImplementedException();
        }

        public bool IsBefore(TimestampTzSet timeCollection)
        {
            throw new NotImplementedException();
        }

        public bool IsContainedIn(TimestampTzSet collection)
        {
            throw new NotImplementedException();
        }

        public bool IsLeftOf(TimestampTzSet collection)
        {
            throw new NotImplementedException();
        }

        public bool IsOverOrAfter(TimestampTzSet timeCollection)
        {
            throw new NotImplementedException();
        }

        public bool IsOverOrBefore(TimestampTzSet timeCollection)
        {
            throw new NotImplementedException();
        }

        public bool IsOverOrLeftOf(TimestampTzSet collection)
        {
            throw new NotImplementedException();
        }

        public bool IsOverOrRightOf(TimestampTzSet collection)
        {
            throw new NotImplementedException();
        }

        public bool IsRightOf(TimestampTzSet collection)
        {
            throw new NotImplementedException();
        }

        public bool Overlaps(TimestampTzSet collection)
        {
            throw new NotImplementedException();
        }
    }
}

