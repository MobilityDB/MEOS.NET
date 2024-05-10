using MEOS.NET.Helpers;
using MEOS.NET.Internal;
using MEOS.NET.Types.Collections;
using MEOS.NET.Types.Collections.Float;
using MEOS.NET.Types.Collections.Integer;
using MEOS.NET.Types.Collections.Time.Timestamp;
using MEOS.NET.Types.General;
using MEOS.NET.Types.Temporal.Number;

namespace MEOS.NET.Types.Boxes
{
    public class TemporalBox : MEOSObject
    {
        internal TemporalBox(IntPtr ptr) : base(ptr)
        { }

        public static TemporalBox FromString(string input)
        {
            var res = MEOSExposedFunctions.tbox_in(input);
            return new TemporalBox(res);
        }

        public static TemporalBox FromBytes(byte[] bytes)
        {
            throw new NotImplementedException(); // TODO : Marshalling
        }

        public static TemporalBox FromHexWKB(string str)
        {
            var res = MEOSExposedFunctions.tbox_from_hexwkb(str);
            return new TemporalBox(res);
        }

        public static TemporalBox FromBounds(int xMin, int xMax, DateTime tMin, DateTime tMax,
            bool xMinInclusive = true, bool tMinInclusive = true, bool xMaxInclusive = false, bool tMaxInclusive = false)
        {
            var span = IntegerSpan.FromBounds(xMin, xMax, xMinInclusive, xMaxInclusive);
            var tsTzSpan = TimestampTzSpan.FromBounds(tMin, tMax, tMinInclusive, tMaxInclusive);

            var res = MEOSExposedFunctions.tbox_make(span._ptr, tsTzSpan._ptr);
            return new TemporalBox(res);
        }

        public static TemporalBox FromValue(int value)
        {
            var res = MEOSExposedFunctions.int_to_tbox(value);
            return new TemporalBox(res);
        }

        public static TemporalBox FromValue(double value)
        {
            var res = MEOSExposedFunctions.float_to_tbox(value);
            return new TemporalBox(res);
        }

        public static TemporalBox FromTime(DateTime timestamp)
        {
            var res = MEOSExposedFunctions.timestamptz_to_tbox(timestamp.ToPgTimestamp());
            return new TemporalBox(res);
        }

        public static TemporalBox FromTime(TimestampTzSet set)
        {
            var res = MEOSExposedFunctions.tstzset_to_tbox(set._ptr);
            return new TemporalBox(res);
        }

        public static TemporalBox FromTime(TimestampTzSpan span)
        {
            var res = MEOSExposedFunctions.tstzspan_to_tbox(span._ptr);
            return new TemporalBox(res);
        }

        public static TemporalBox FromTime(TimestampTzSpanSet spanSet)
        {
            var res = MEOSExposedFunctions.tstzspanset_to_tbox(spanSet._ptr);
            return new TemporalBox(res);
        }

        public static TemporalBox FromValueTime(int value, DateTime time)
        {
            var res = MEOSExposedFunctions.int_timestamptz_to_tbox(value, time.ToPgTimestamp());
            return new TemporalBox(res);
        }

        public static TemporalBox FromValueTime(double value, DateTime time)
        {
            var res = MEOSExposedFunctions.float_timestamptz_to_tbox(value, time.ToPgTimestamp());
            return new TemporalBox(res);
        }

        public static TemporalBox FromValueTime(IntegerSpan value, DateTime time)
        {
            var res = MEOSExposedFunctions.numspan_timestamptz_to_tbox(value._ptr, time.ToPgTimestamp());
            return new TemporalBox(res);
        }

        public static TemporalBox FromValueTime(FloatSpan value, DateTime time)
        {
            var res = MEOSExposedFunctions.numspan_timestamptz_to_tbox(value._ptr, time.ToPgTimestamp());
            return new TemporalBox(res);
        }

        public static TemporalBox FromValueTime(int value, TimestampTzSpan time)
        {
            var res = MEOSExposedFunctions.int_tstzspan_to_tbox(value, time._ptr);
            return new TemporalBox(res);
        }

        public static TemporalBox FromValueTime(double value, TimestampTzSpan time)
        {
            var res = MEOSExposedFunctions.float_tstzspan_to_tbox(value, time._ptr);
            return new TemporalBox(res);
        }

        public static TemporalBox FromValueTime(IntegerSpan value, TimestampTzSpan time)
        {
            var res = MEOSExposedFunctions.numspan_tstzspan_to_tbox(value._ptr, time._ptr);
            return new TemporalBox(res);
        }

        public static TemporalBox FromValueTime(FloatSpan value, TimestampTzSpan time)
        {
            var res = MEOSExposedFunctions.numspan_tstzspan_to_tbox(value._ptr, time._ptr);
            return new TemporalBox(res);
        }

        public static TemporalBox FromTemporalNumber(TemporalNumber temporal)
        {
            var res = MEOSExposedFunctions.tnumber_to_tbox(temporal._ptr);
            return new TemporalBox(res);
        }

        public TemporalBox Copy()
        {
            var res = MEOSExposedFunctions.tbox_copy(this._ptr);
            return new TemporalBox(res);
        }

        public string Format(int maxDecimals = 15)
            => MEOSExposedFunctions.tbox_out(this._ptr, maxdd: maxDecimals);

        public override string ToString()
            => this.Format();

        public byte[] ToBytes()
        {
            throw new NotImplementedException(); // TODO : Marshalling
        }

        public string ToHexWKB()
        {
            throw new NotImplementedException(); // TODO : Check PyMEOS
        }

        public FloatSpan ToFloatSpan()
        {
            var res = MEOSExposedFunctions.tbox_to_floatspan(this._ptr);
            return new FloatSpan(res);
        }

        public TimestampTzSpan ToTimestampTzSpan()
        {
            var res = MEOSExposedFunctions.tbox_to_tstzspan(this._ptr);
            return new TimestampTzSpan(res);
        }

        public bool HasX()
            => MEOSExposedFunctions.tbox_hasx(this._ptr);

        public bool HasT()
            => MEOSExposedFunctions.tbox_hast(this._ptr);

        public bool IsMinXInclusive()
        {
            throw new NotImplementedException(); // TODO : Marshalling
        }

        public bool IsMaxXInclusive()
        {
            throw new NotImplementedException(); // TODO : Marshalling
        }

        public bool IsMinTInclusive()
        {
            throw new NotImplementedException(); // TODO : Marshalling
        }

        public bool IsMaxTInclusive()
        {
            throw new NotImplementedException(); // TODO : Marshalling
        }

        public double MinX()
        {
            throw new NotImplementedException(); // TODO : Marshalling
        }

        public double MaxX()
        {
            throw new NotImplementedException(); // TODO : Marshalling
        }

        public DateTime MinT()
        {
            throw new NotImplementedException(); // TODO : Marshalling
        }

        public DateTime MaxT()
        {
            throw new NotImplementedException(); // TODO : Marshalling
        }

        public bool IsLeftOf(TemporalBox other)
            => MEOSExposedFunctions.left_tbox_tbox(this._ptr, other._ptr);

        public bool IsLeftOf(TemporalNumber other)
            => this.IsLeftOf(other.BoundingBox());

        public bool IsOverOrLeftOf(TemporalBox other)
            => MEOSExposedFunctions.overleft_tbox_tbox(this._ptr, other._ptr);

        public bool IsOverOrLeftOf(TemporalNumber other)
            => this.IsOverOrLeftOf(other.BoundingBox());

        public bool IsRightOf(TemporalBox other)
            => MEOSExposedFunctions.right_tbox_tbox(this._ptr, other._ptr);

        public bool IsRightOf(TemporalNumber other)
            => this.IsRightOf(other.BoundingBox());

        public bool IsOverOrRightOf(TemporalBox other)
            => MEOSExposedFunctions.overright_tbox_tbox(this._ptr, other._ptr);

        public bool IsOverOrRightOf(TemporalNumber other)
            => this.IsOverOrRightOf(other.BoundingBox());
    }
}

