﻿using MEOS.NET.Helpers;
using MEOS.NET.Internal;

namespace MEOS.NET.Types.Collections.Time.Timestamp
{
    public sealed class TimestampTzSpan : Span, ITimeCollection<TimestampTzSpan>
	{
        internal TimestampTzSpan(IntPtr ptr) : base(ptr)
        { }

        public static TimestampTzSpan FromBounds(DateTime tMin, DateTime tMax, bool tMinInclusive = true, bool tMaxInclusive = false)
        {
            var res = MEOSExposedFunctions.tstzspan_make(tMin.ToPgTimestamp(), tMax.ToPgTimestamp(), tMinInclusive, tMaxInclusive);
            return new TimestampTzSpan(res);
        }

        public bool Contains(TimestampTzSpan collection)
        {
            throw new NotImplementedException();
        }

        public bool IsAfter(TimestampTzSpan timeCollection)
        {
            throw new NotImplementedException();
        }

        public bool IsBefore(TimestampTzSpan timeCollection)
        {
            throw new NotImplementedException();
        }

        public bool IsContainedIn(TimestampTzSpan collection)
        {
            throw new NotImplementedException();
        }

        public bool IsLeftOf(TimestampTzSpan collection)
        {
            throw new NotImplementedException();
        }

        public bool IsOverOrAfter(TimestampTzSpan timeCollection)
        {
            throw new NotImplementedException();
        }

        public bool IsOverOrBefore(TimestampTzSpan timeCollection)
        {
            throw new NotImplementedException();
        }

        public bool IsOverOrLeftOf(TimestampTzSpan collection)
        {
            throw new NotImplementedException();
        }

        public bool IsOverOrRightOf(TimestampTzSpan collection)
        {
            throw new NotImplementedException();
        }

        public bool IsRightOf(TimestampTzSpan collection)
        {
            throw new NotImplementedException();
        }

        public bool Overlaps(TimestampTzSpan collection)
        {
            throw new NotImplementedException();
        }

        // TODO : Implement methods accordingly to PyMEOS and FloatSpan class
    }
}

