namespace MEOS.NET.Types.Collections.Time.Date
{
    public sealed class DateSet : Set, ITimeCollection<DateSet>
	{
        internal DateSet(IntPtr ptr) : base(ptr)
		{ }

        public bool Contains(DateSet collection)
        {
            throw new NotImplementedException();
        }

        public bool IsAfter(DateSet timeCollection)
        {
            throw new NotImplementedException();
        }

        public bool IsBefore(DateSet timeCollection)
        {
            throw new NotImplementedException();
        }

        public bool IsContainedIn(DateSet collection)
        {
            throw new NotImplementedException();
        }

        public bool IsLeftOf(DateSet collection)
        {
            throw new NotImplementedException();
        }

        public bool IsOverOrAfter(DateSet timeCollection)
        {
            throw new NotImplementedException();
        }

        public bool IsOverOrBefore(DateSet timeCollection)
        {
            throw new NotImplementedException();
        }

        public bool IsOverOrLeftOf(DateSet collection)
        {
            throw new NotImplementedException();
        }

        public bool IsOverOrRightOf(DateSet collection)
        {
            throw new NotImplementedException();
        }

        public bool IsRightOf(DateSet collection)
        {
            throw new NotImplementedException();
        }

        public bool Overlaps(DateSet collection)
        {
            throw new NotImplementedException();
        }
    }
}

