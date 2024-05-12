using MEOS.NET.Helpers;
using MEOS.NET.Internal;
using MEOS.NET.Structures;
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
            var tBoxPtr = AllocHelper.AllocateArrayPointer<byte, IntPtr>(bytes, (bytesPtr) =>
            {
                return MEOSExposedFunctions.tbox_from_wkb(bytesPtr, (ulong)bytes.Length);
            });

            return new TemporalBox(tBoxPtr);
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
            int arrSize = 0;
            var arr = AllocHelper.AllocatePointer<IntPtr>(sizeof(int), (countPtr) =>
            {
                var res = MEOSExposedFunctions.tbox_as_wkb(this._ptr, variant: 4, countPtr);
                arrSize = countPtr.ToStructure<int>();

                return res;
            });

            return arr.ToArrayOfType<byte>(arrSize);
        }

        public string ToHexWKB()
        {
            return AllocHelper.AllocatePointer<string>(sizeof(int), (sizePtr) =>
            {
                return MEOSExposedFunctions.tbox_as_hexwkb(this._ptr, 0, sizePtr);
            });
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
            return AllocHelper.AllocatePointer<bool>(sizeof(bool), (resultPtr) =>
            {
                var successful = MEOSExposedFunctions.tbox_xmin_inc(this._ptr, resultPtr);
                return successful ? resultPtr.ToStructure<bool>() : false;
            });
        }

        public bool IsMaxXInclusive()
        {
            return AllocHelper.AllocatePointer<bool>(sizeof(bool), (resultPtr) =>
            {
                var successful = MEOSExposedFunctions.tbox_xmax_inc(this._ptr, resultPtr);
                return successful ? resultPtr.ToStructure<bool>() : false;
            });
        }

        public bool IsMinTInclusive()
        {
            return AllocHelper.AllocatePointer<bool>(sizeof(bool), (resultPtr) =>
            {
                var successful = MEOSExposedFunctions.tbox_tmin_inc(this._ptr, resultPtr);
                return successful ? resultPtr.ToStructure<bool>() : false;
            });
        }

        public bool IsMaxTInclusive()
        {
            return AllocHelper.AllocatePointer<bool>(sizeof(bool), (resultPtr) =>
            {
                var successful = MEOSExposedFunctions.tbox_tmax_inc(this._ptr, resultPtr);
                return successful ? resultPtr.ToStructure<bool>() : false;
            });
        }

        public double MinX()
        {
            return AllocHelper.AllocatePointer<double>(sizeof(double), (resultPtr) =>
            {
                var successful = MEOSExposedFunctions.tbox_xmin(this._ptr, resultPtr);
                return successful ? resultPtr.ToStructure<double>() : throw new InvalidOperationException("No X Min available");
            });
        }

        public double MaxX()
        {
            return AllocHelper.AllocatePointer<double>(sizeof(double), (resultPtr) =>
            {
                var successful = MEOSExposedFunctions.tbox_xmax(this._ptr, resultPtr);
                return successful ? resultPtr.ToStructure<double>() : throw new InvalidOperationException("No X Max available");
            });
        }

        public DateTime MinT()
        {
            var timestamp = AllocHelper.AllocatePointer<TimestampTz>(sizeof(long), (resultPtr) =>
            {
                var successful = MEOSExposedFunctions.tbox_tmin(this._ptr, resultPtr);
                return successful ? resultPtr.ToStructure<TimestampTz>() : throw new InvalidOperationException("No T Min available");
            });

            return timestamp.ToDateTime();
        }

        public DateTime MaxT()
        {
            var timestamp = AllocHelper.AllocatePointer<TimestampTz>(sizeof(long), (resultPtr) =>
            {
                var successful = MEOSExposedFunctions.tbox_tmax(this._ptr, resultPtr);
                return successful ? resultPtr.ToStructure<TimestampTz>() : throw new InvalidOperationException("No T Max available");
            });

            return timestamp.ToDateTime();
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

