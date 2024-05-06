namespace MEOS.NET.Types.Collections.Time.Date
{
    public sealed class DateSpan : Span, ITimeCollection<DateSpan>
	{
        internal DateSpan(IntPtr ptr) : base(ptr)
        { }

        public bool Contains(DateSpan collection)
        {
            throw new NotImplementedException();
        }

        public bool IsAfter(DateSpan timeCollection)
        {
            throw new NotImplementedException();
        }

        public bool IsBefore(DateSpan timeCollection)
        {
            throw new NotImplementedException();
        }

        public bool IsContainedIn(DateSpan collection)
        {
            throw new NotImplementedException();
        }

        public bool IsLeftOf(DateSpan collection)
        {
            throw new NotImplementedException();
        }

        public bool IsOverOrAfter(DateSpan timeCollection)
        {
            throw new NotImplementedException();
        }

        public bool IsOverOrBefore(DateSpan timeCollection)
        {
            throw new NotImplementedException();
        }

        public bool IsOverOrLeftOf(DateSpan collection)
        {
            throw new NotImplementedException();
        }

        public bool IsOverOrRightOf(DateSpan collection)
        {
            throw new NotImplementedException();
        }

        public bool IsRightOf(DateSpan collection)
        {
            throw new NotImplementedException();
        }

        public bool Overlaps(DateSpan collection)
        {
            throw new NotImplementedException();
        }
    }
}

