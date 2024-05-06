using MEOS.NET.Internal;
using MEOS.NET.Types.General;

namespace MEOS.NET.Types.Collections
{
    public class Span : MEOSObject
    {
        internal Span(IntPtr ptr) : base(ptr)
        { }

        public static Span FromBytes(byte[] bytes)
        {
            throw new NotImplementedException(); // TODO : same as for FromBytes in Set
        }

        public static Span FromHexWKB(string hexWKB)
        {
            var res = MEOSExposedFunctions.span_from_hexwkb(hexWKB);
            return new Span(res);
        }

        public Span Copy()
        {
            var copy = MEOSExposedFunctions.span_copy(this._ptr);
            return new Span(copy);
        }

        public byte[] ToBytes()
        {
            throw new NotImplementedException(); // TODO : Check PyMEOS
        }

        public string ToHexWKB()
        {
            throw new NotImplementedException();
        }

        public SpanSet ToSpanSet()
        {
            throw new NotImplementedException();
        }

        public bool IsLowerBoundInclusive()
            => MEOSExposedFunctions.span_lower_inc(this._ptr);

        public bool IsUpperBoundInclusive()
            => MEOSExposedFunctions.span_upper_inc(this._ptr);

        public bool IsAdjacentTo(Span span)
            => MEOSExposedFunctions.adjacent_span_span(this._ptr, span._ptr);

        public bool IsAdjacentTo(SpanSet spanSet)
            => MEOSExposedFunctions.adjacent_spanset_span(spanSet._ptr, this._ptr);

        public bool IsContainedIn(Span span)
            => MEOSExposedFunctions.contained_span_span(this._ptr, span._ptr);

        public bool IsContainedIn(SpanSet spanSet)
            => MEOSExposedFunctions.contained_span_spanset(this._ptr, spanSet._ptr);

        public bool Contains(Span span)
            => MEOSExposedFunctions.contains_span_span(this._ptr, span._ptr);

        public bool Contains(SpanSet spanSet)
            => MEOSExposedFunctions.contains_span_spanset(this._ptr, spanSet._ptr);

        public bool Overlaps(Span span)
            => MEOSExposedFunctions.overlaps_span_span(this._ptr, span._ptr);

        public bool Overlaps(SpanSet spanSet)
            => MEOSExposedFunctions.overlaps_spanset_span(spanSet._ptr, this._ptr);

        public bool Equals(Span span)
            => MEOSExposedFunctions.span_eq(this._ptr, span._ptr);

        public bool Equals(SpanSet spanSet)
        {
            var span = spanSet.AsSpan();
            return this.Equals(span);
        }

        public bool IsLeft(Span span)
            => MEOSExposedFunctions.left_span_span(this._ptr, span._ptr);

        public bool IsLeft(SpanSet spanSet)
            => MEOSExposedFunctions.left_span_spanset(this._ptr, spanSet._ptr);

        public bool IsOverOrLeft(Span span)
            => MEOSExposedFunctions.overleft_span_span(this._ptr, span._ptr);

        public bool IsOverOrLeft(SpanSet spanSet)
            => MEOSExposedFunctions.overleft_span_spanset(this._ptr, spanSet._ptr);

        public bool IsRight(Span span)
            => MEOSExposedFunctions.right_span_span(this._ptr, span._ptr);

        public bool IsRight(SpanSet spanSet)
            => MEOSExposedFunctions.right_span_spanset(this._ptr, spanSet._ptr);

        public bool IsOverOrRight(Span span)
            => MEOSExposedFunctions.overright_span_span(this._ptr, span._ptr);

        public bool IsOverOrRight(SpanSet spanSet)
            => MEOSExposedFunctions.overright_span_spanset(this._ptr, spanSet._ptr);

        public Span IntersectionWith(Span span)
        {
            var res = MEOSExposedFunctions.intersection_span_span(this._ptr, span._ptr);
            return new Span(res);
        }

        public SpanSet IntersectionWith(SpanSet spanSet)
        {
            var res = MEOSExposedFunctions.intersection_spanset_span(spanSet._ptr, this._ptr);
            return new SpanSet(res);
        }

        public Span UnionWith(Span span)
        {
            var res = MEOSExposedFunctions.union_span_span(this._ptr, span._ptr);
            return new Span(res);
        }

        public SpanSet UnionWith(SpanSet spanSet)
        {
            var res = MEOSExposedFunctions.union_spanset_span(spanSet._ptr, this._ptr);
            return new SpanSet(res);
        }

        public override int GetHashCode()
            => (int)MEOSExposedFunctions.span_hash(this._ptr);

        public static bool operator ==(Span span1, Span span2)
            => span1.Equals(span2);

        public static bool operator !=(Span span1, Span span2)
            => !span1.Equals(span2);

        public static bool operator <(Span span1, Span span2)
            => MEOSExposedFunctions.span_lt(span1._ptr, span2._ptr);

        public static bool operator >(Span span1, Span span2)
            => MEOSExposedFunctions.span_gt(span1._ptr, span2._ptr);

        public static bool operator <=(Span span1, Span span2)
            => MEOSExposedFunctions.span_le(span1._ptr, span2._ptr);

        public static bool operator >=(Span span1, Span span2)
            => MEOSExposedFunctions.span_ge(span1._ptr, span2._ptr);
    }
}

