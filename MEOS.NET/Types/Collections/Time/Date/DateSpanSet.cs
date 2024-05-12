namespace MEOS.NET.Types.Collections.Time.Date
{
    public sealed class DateSpanSet : SpanSet, ITimeCollection<DateSpanSet>
	{
        internal DateSpanSet(IntPtr ptr) : base(ptr)
        { }

        public bool Contains(DateSpanSet collection)
        {
            throw new NotImplementedException();
        }

        public bool IsAfter(DateSpanSet timeCollection)
        {
            throw new NotImplementedException();
        }

        public bool IsBefore(DateSpanSet timeCollection)
        {
            throw new NotImplementedException();
        }

        public bool IsContainedIn(DateSpanSet collection)
        {
            throw new NotImplementedException();
        }

        public bool IsLeftOf(DateSpanSet collection)
        {
            throw new NotImplementedException();
        }

        public bool IsOverOrAfter(DateSpanSet timeCollection)
        {
            throw new NotImplementedException();
        }

        public bool IsOverOrBefore(DateSpanSet timeCollection)
        {
            throw new NotImplementedException();
        }

        public bool IsOverOrLeftOf(DateSpanSet collection)
        {
            throw new NotImplementedException();
        }

        public bool IsOverOrRightOf(DateSpanSet collection)
        {
            throw new NotImplementedException();
        }

        public bool IsRightOf(DateSpanSet collection)
        {
            throw new NotImplementedException();
        }

        public bool Overlaps(DateSpanSet collection)
        {
            throw new NotImplementedException();
        }

        // TODO : Implement methods accordingly to PyMEOS and FloatSpanSet class
    }
}

