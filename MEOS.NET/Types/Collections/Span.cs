using MEOS.NET.Helpers;
using MEOS.NET.Functions;
using MEOS.NET.Types.General;

namespace MEOS.NET.Types.Collections
{
    public class Span : MEOSObject
    {
        internal Span(IntPtr ptr) : base(ptr)
        { }

        public static Span FromBytes(byte[] bytes)
        {
            var setPtr = AllocHelper.AllocateArrayPointer<byte, IntPtr>(bytes, (bytesPtr) =>
            {
                return Meos.SpanFromWkb(bytesPtr, (ulong)bytes.Length);
            });

            return new Span(setPtr);
        }

        public static Span FromHexWKB(string hexWKB)
        {
            var res = Meos.SpanFromHexwkb(hexWKB);
            return new Span(res);
        }

        public Span Copy()
        {
            var copy = Meos.SpanCopy(this._ptr);
            return new Span(copy);
        }

        public byte[] ToBytes()
        {
            int arrSize = 0;
            var arr = AllocHelper.AllocatePointer<IntPtr>(sizeof(int), (countPtr) =>
            {
                var res = Meos.SpanAsWkb(this._ptr, variant: 4, countPtr);
                arrSize = countPtr.ToStructure<int>();

                return res;
            });

            return arr.ToArrayOfType<byte>(arrSize);
        }

        public string ToHexWKB()
        {
            return AllocHelper.AllocatePointer<string>(sizeof(int), (sizePtr) =>
            {
                return Meos.SpanAsHexwkb(this._ptr, 0, sizePtr);
            });
        }

        public virtual SpanSet ToSpanSet()
        {
            var res = Meos.SpanToSpanset(this._ptr);
            return new SpanSet(res);
        }

        public bool IsLowerBoundInclusive()
            => (Meos.SpanLowerInc(this._ptr));

        public bool IsUpperBoundInclusive()
            => (Meos.SpanUpperInc(this._ptr));

        public bool IsAdjacent(Span span)
            => (Meos.AdjacentSpanSpan(this._ptr, span._ptr));

        public bool IsAdjacent(SpanSet spanSet)
            => (Meos.AdjacentSpansetSpan(spanSet._ptr, this._ptr));

        public bool IsContainedIn(Span span)
            => (Meos.ContainedSpanSpan(this._ptr, span._ptr));

        public bool IsContainedIn(SpanSet spanSet)
            => (Meos.ContainedSpanSpanset(this._ptr, spanSet._ptr));

        public bool Contains(Span span)
            => (Meos.ContainsSpanSpan(this._ptr, span._ptr));

        public bool Contains(SpanSet spanSet)
            => (Meos.ContainsSpanSpanset(this._ptr, spanSet._ptr));

        public bool Overlaps(Span span)
            => (Meos.OverlapsSpanSpan(this._ptr, span._ptr));

        public bool Overlaps(SpanSet spanSet)
            => (Meos.OverlapsSpansetSpan(spanSet._ptr, this._ptr));

        public bool Equals(Span span)
            => (Meos.SpanEq(this._ptr, span._ptr));

        public bool Equals(SpanSet spanSet)
        {
            var span = spanSet.ToSpan();
            return this.Equals(span);
        }

        public double Width()
            => Meos.NumspanWidth(this._ptr);

        public bool IsLeftOf(Span span)
            => (Meos.LeftSpanSpan(this._ptr, span._ptr));

        public bool IsLeftOf(SpanSet spanSet)
            => (Meos.LeftSpanSpanset(this._ptr, spanSet._ptr));

        public bool IsOverOrLeftOf(Span span)
            => (Meos.OverleftSpanSpan(this._ptr, span._ptr));

        public bool IsOverOrLeftOf(SpanSet spanSet)
            => (Meos.OverleftSpanSpanset(this._ptr, spanSet._ptr));

        public bool IsRightOf(Span span)
            => (Meos.RightSpanSpan(this._ptr, span._ptr));

        public bool IsRightOf(SpanSet spanSet)
            => (Meos.RightSpanSpanset(this._ptr, spanSet._ptr));

        public bool IsOverOrRightOf(Span span)
            => (Meos.OverrightSpanSpan(this._ptr, span._ptr));

        public bool IsOverOrRightOf(SpanSet spanSet)
            => (Meos.OverrightSpanSpanset(this._ptr, spanSet._ptr));

        public double DistanceTo(Span span)
            => Meos.DistanceSpanSpan(this._ptr, span._ptr);

        public Span IntersectionWith(Span span)
        {
            var res = Meos.IntersectionSpanSpan(this._ptr, span._ptr);
            return new Span(res);
        }

        public SpanSet IntersectionWith(SpanSet spanSet)
        {
            var res = Meos.IntersectionSpansetSpan(spanSet._ptr, this._ptr);
            return new SpanSet(res);
        }

        public Span UnionWith(Span span)
        {
            var res = Meos.UnionSpanSpan(this._ptr, span._ptr);
            return new Span(res);
        }

        public SpanSet UnionWith(SpanSet spanSet)
        {
            var res = Meos.UnionSpansetSpan(spanSet._ptr, this._ptr);
            return new SpanSet(res);
        }

        public override int GetHashCode()
            => (int)Meos.SpanHash(this._ptr);

        public static bool operator ==(Span span1, Span span2)
            => span1.Equals(span2);

        public static bool operator !=(Span span1, Span span2)
            => !span1.Equals(span2);

        public static bool operator ==(Span span, SpanSet spanSet)
            => span.Equals(spanSet);

        public static bool operator !=(Span span, SpanSet spanSet)
            => !span.Equals(spanSet);

        public static bool operator ==(SpanSet spanSet, Span span)
            => span.Equals(spanSet);

        public static bool operator !=(SpanSet spanSet, Span span)
            => !span.Equals(spanSet);

        public static bool operator <(Span span1, Span span2)
            => (Meos.SpanLt(span1._ptr, span2._ptr));

        public static bool operator >(Span span1, Span span2)
            => (Meos.SpanGt(span1._ptr, span2._ptr));

        public static bool operator <=(Span span1, Span span2)
            => (Meos.SpanLe(span1._ptr, span2._ptr));

        public static bool operator >=(Span span1, Span span2)
            => (Meos.SpanGe(span1._ptr, span2._ptr));
    }
}

