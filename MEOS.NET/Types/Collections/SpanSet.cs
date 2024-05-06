using MEOS.NET.Internal;
using MEOS.NET.Types.General;

namespace MEOS.NET.Types.Collections
{
    public class SpanSet : MEOSObject
    {
        internal SpanSet(IntPtr ptr) : base(ptr)
        { }

        public static SpanSet FromBytes(byte[] bytes)
        {
            throw new NotImplementedException(); // TODO : same as for FromBytes in Set/SpanSet
        }

        public static SpanSet FromHexWKB(string hexWKB)
        {
            var res = MEOSExposedFunctions.spanset_from_hexwkb(hexWKB);
            return new SpanSet(res);
        }

        public SpanSet Copy()
        {
            var copy = MEOSExposedFunctions.spanset_copy(this._ptr);
            return new SpanSet(copy);
        }

        public byte[] ToBytes()
        {
            throw new NotImplementedException(); // TODO : Check PyMEOS
        }

        public string ToHexWKB()
        {
            throw new NotImplementedException();
        }

        public virtual Span ToSpan()
        {
            var res = MEOSExposedFunctions.spanset_span(this._ptr);
            return new Span(res);
        }

        public int SpanCount()
            => MEOSExposedFunctions.spanset_num_spans(this._ptr);

        public virtual Span StartSpan()
        {
            var res = MEOSExposedFunctions.spanset_start_span(this._ptr);
            return new Span(res);
        }

        public virtual Span EndSpan()
        {
            var res = MEOSExposedFunctions.spanset_end_span(this._ptr);
            return new Span(res);
        }

        public virtual Span SpanAt(int position)
        {
            var count = this.SpanCount();

            if (position < 0 || position + 1 > count)
            {
                throw new ArgumentOutOfRangeException(nameof(position), $"Requested element must be between 0 and {count - 1}");
            }

            var res = MEOSExposedFunctions.spanset_span_n(this._ptr, position);
            return new Span(res);
        }


        public virtual IEnumerable<Span> GetSpans()
        {
            var res = MEOSExposedFunctions.spanset_spans(this._ptr);
            throw new NotImplementedException(); // TODO : Transform to IEnumerable
        }

        public bool IsAdjacent(Span span)
            => MEOSExposedFunctions.adjacent_spanset_span(this._ptr, span._ptr);

        public bool IsAdjacent(SpanSet spanSet)
            => MEOSExposedFunctions.adjacent_spanset_spanset(this._ptr, spanSet._ptr);

        public bool IsContainedIn(Span span)
            => MEOSExposedFunctions.contained_spanset_span(this._ptr, span._ptr);

        public bool IsContainedIn(SpanSet spanSet)
            => MEOSExposedFunctions.contained_spanset_spanset(this._ptr, spanSet._ptr);

        public bool Contains(Span span)
            => MEOSExposedFunctions.contains_spanset_span(this._ptr, span._ptr);

        public bool Contains(SpanSet spanSet)
            => MEOSExposedFunctions.contains_spanset_spanset(this._ptr, spanSet._ptr);

        public bool Overlaps(Span span)
            => MEOSExposedFunctions.overlaps_spanset_span(this._ptr, span._ptr);

        public bool Overlaps(SpanSet spanSet)
            => MEOSExposedFunctions.overlaps_spanset_spanset(this._ptr, spanSet._ptr);

        public bool IsLeftOf(Span span)
            => MEOSExposedFunctions.left_spanset_span(this._ptr, span._ptr);

        public bool IsLeftOf(SpanSet spanSet)
            => MEOSExposedFunctions.left_spanset_spanset(this._ptr, spanSet._ptr);

        public bool IsOverOrLeftOf(Span span)
            => MEOSExposedFunctions.overleft_spanset_span(this._ptr, span._ptr);

        public bool IsOverOrLeftOf(SpanSet spanSet)
            => MEOSExposedFunctions.overleft_spanset_spanset(this._ptr, spanSet._ptr);

        public bool IsRightOf(Span span)
            => MEOSExposedFunctions.right_spanset_span(this._ptr, span._ptr);

        public bool IsRightOf(SpanSet spanSet)
            => MEOSExposedFunctions.right_spanset_spanset(this._ptr, spanSet._ptr);

        public bool IsOverOrRightOf(Span span)
            => MEOSExposedFunctions.overright_spanset_span(this._ptr, span._ptr);

        public bool IsOverOrRightOf(SpanSet spanSet)
            => MEOSExposedFunctions.overright_spanset_spanset(this._ptr, spanSet._ptr);

        public double DistanceTo(Set set)
            => this.DistanceTo(set.ToSpanSet());

        public double DistanceTo(Span span)
            => MEOSExposedFunctions.distance_spanset_span(this._ptr, span._ptr);

        public double DistanceTo(SpanSet spanSet)
            => MEOSExposedFunctions.distance_spanset_spanset(this._ptr, spanSet._ptr);

        public SpanSet IntersectionWith(Span span)
        {
            var res = MEOSExposedFunctions.intersection_spanset_span(this._ptr, span._ptr);
            return new SpanSet(res);
        }

        public SpanSet IntersectionWith(SpanSet spanSet)
        {
            var res = MEOSExposedFunctions.intersection_spanset_spanset(this._ptr, spanSet._ptr);
            return new SpanSet(res);
        }

        public SpanSet Minus(Span span)
        {
            var res = MEOSExposedFunctions.minus_spanset_span(this._ptr, span._ptr);
            return new SpanSet(res);
        }

        public SpanSet Minus(SpanSet spanSet)
        {
            var res = MEOSExposedFunctions.minus_spanset_spanset(this._ptr, spanSet._ptr);
            return new SpanSet(res);
        }

        public SpanSet UnionWith(Span span)
        {
            var res = MEOSExposedFunctions.union_spanset_span(this._ptr, span._ptr);
            return new SpanSet(res);
        }

        public SpanSet UnionWith(SpanSet spanSet)
        {
            var res = MEOSExposedFunctions.union_spanset_spanset(this._ptr, spanSet._ptr);
            return new SpanSet(res);
        }

        public bool Equals(SpanSet spanSet)
            => MEOSExposedFunctions.spanset_eq(this._ptr, spanSet._ptr);

        public static SpanSet operator +(SpanSet spanSet1, SpanSet spanSet2)
            => spanSet1.UnionWith(spanSet2);

        public static SpanSet operator -(SpanSet spanSet1, SpanSet spanSet2)
            => spanSet1.Minus(spanSet2);

        public static bool operator ==(SpanSet spanSet1, SpanSet spanSet2)
            => spanSet1.Equals(spanSet2);

        public static bool operator !=(SpanSet spanSet1, SpanSet spanSet2)
            => MEOSExposedFunctions.spanset_ne(spanSet1._ptr, spanSet2._ptr);

        public static bool operator >(SpanSet spanSet1, SpanSet spanSet2)
            => MEOSExposedFunctions.spanset_gt(spanSet1._ptr, spanSet2._ptr);

        public static bool operator <(SpanSet spanSet1, SpanSet spanSet2)
            => MEOSExposedFunctions.spanset_lt(spanSet1._ptr, spanSet2._ptr);

        public static bool operator >=(SpanSet spanSet1, SpanSet spanSet2)
            => MEOSExposedFunctions.spanset_ge(spanSet1._ptr, spanSet2._ptr);

        public static bool operator <=(SpanSet spanSet1, SpanSet spanSet2)
            => MEOSExposedFunctions.spanset_le(spanSet1._ptr, spanSet2._ptr);

        public override int GetHashCode()
            => (int)MEOSExposedFunctions.spanset_hash(this._ptr);
    }
}

