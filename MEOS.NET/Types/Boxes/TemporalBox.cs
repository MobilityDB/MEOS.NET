using MEOS.NET.Helpers;
using MEOS.NET.Functions;
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
            var res = Meos.TboxIn(input);
            return new TemporalBox(res);
        }

        public static TemporalBox FromBytes(byte[] bytes)
        {
            var tBoxPtr = AllocHelper.AllocateArrayPointer<byte, IntPtr>(bytes, (bytesPtr) =>
            {
                return Meos.TboxFromWkb(bytesPtr, (ulong)bytes.Length);
            });

            return new TemporalBox(tBoxPtr);
        }

        public static TemporalBox FromHexWKB(string str)
        {
            var res = Meos.TboxFromHexwkb(str);
            return new TemporalBox(res);
        }

        public static TemporalBox FromBounds(int xMin, int xMax, DateTime tMin, DateTime tMax,
            bool xMinInclusive = true, bool tMinInclusive = true, bool xMaxInclusive = false, bool tMaxInclusive = false)
        {
            var span = IntegerSpan.FromBounds(xMin, xMax, xMinInclusive, xMaxInclusive);
            var tsTzSpan = TimestampTzSpan.FromBounds(tMin, tMax, tMinInclusive, tMaxInclusive);

            var res = Meos.TboxMake(span._ptr, tsTzSpan._ptr);
            return new TemporalBox(res);
        }

        public static TemporalBox FromValue(int value)
        {
            var res = Meos.IntToTbox(value);
            return new TemporalBox(res);
        }

        public static TemporalBox FromValue(double value)
        {
            var res = Meos.FloatToTbox(value);
            return new TemporalBox(res);
        }

        public static TemporalBox FromTime(DateTime timestamp)
        {
            var res = Meos.TimestamptzToTbox(timestamp.ToPgTimestamp());
            return new TemporalBox(res);
        }

        public static TemporalBox FromTime(TimestampTzSet set)
        {
            var res = Meos.SetToTbox(set._ptr);
            return new TemporalBox(res);
        }

        public static TemporalBox FromTime(TimestampTzSpan span)
        {
            var res = Meos.SpanToTbox(span._ptr);
            return new TemporalBox(res);
        }

        public static TemporalBox FromTime(TimestampTzSpanSet spanSet)
        {
            var res = Meos.SpansetToTbox(spanSet._ptr);
            return new TemporalBox(res);
        }

        public static TemporalBox FromValueTime(int value, DateTime time)
        {
            var res = Meos.IntTimestamptzToTbox(value, time.ToPgTimestamp());
            return new TemporalBox(res);
        }

        public static TemporalBox FromValueTime(double value, DateTime time)
        {
            var res = Meos.FloatTimestamptzToTbox(value, time.ToPgTimestamp());
            return new TemporalBox(res);
        }

        public static TemporalBox FromValueTime(IntegerSpan value, DateTime time)
        {
            var res = Meos.NumspanTimestamptzToTbox(value._ptr, time.ToPgTimestamp());
            return new TemporalBox(res);
        }

        public static TemporalBox FromValueTime(FloatSpan value, DateTime time)
        {
            var res = Meos.NumspanTimestamptzToTbox(value._ptr, time.ToPgTimestamp());
            return new TemporalBox(res);
        }

        public static TemporalBox FromValueTime(int value, TimestampTzSpan time)
        {
            var res = Meos.IntTstzspanToTbox(value, time._ptr);
            return new TemporalBox(res);
        }

        public static TemporalBox FromValueTime(double value, TimestampTzSpan time)
        {
            var res = Meos.FloatTstzspanToTbox(value, time._ptr);
            return new TemporalBox(res);
        }

        public static TemporalBox FromValueTime(IntegerSpan value, TimestampTzSpan time)
        {
            var res = Meos.NumspanTstzspanToTbox(value._ptr, time._ptr);
            return new TemporalBox(res);
        }

        public static TemporalBox FromValueTime(FloatSpan value, TimestampTzSpan time)
        {
            var res = Meos.NumspanTstzspanToTbox(value._ptr, time._ptr);
            return new TemporalBox(res);
        }

        public static TemporalBox FromTemporalNumber(TemporalNumber temporal)
        {
            var res = Meos.TnumberToTbox(temporal._ptr);
            return new TemporalBox(res);
        }

        public TemporalBox Copy()
        {
            var res = Meos.TboxCopy(this._ptr);
            return new TemporalBox(res);
        }

        public string Format(int maxDecimals = 15)
            => Meos.TboxOut(this._ptr, maxdd: maxDecimals);

        public override string ToString()
            => this.Format();

        public byte[] ToBytes()
        {
            int arrSize = 0;
            var arr = AllocHelper.AllocatePointer<IntPtr>(sizeof(int), (countPtr) =>
            {
                var res = Meos.TboxAsWkb(this._ptr, variant: 4, countPtr);
                arrSize = countPtr.ToStructure<int>();

                return res;
            });

            return arr.ToArrayOfType<byte>(arrSize);
        }

        public string ToHexWKB()
        {
            return AllocHelper.AllocatePointer<string>(sizeof(int), (sizePtr) =>
            {
                return Meos.TboxAsHexwkb(this._ptr, 0, sizePtr);
            });
        }

        public FloatSpan ToFloatSpan()
        {
            var res = Meos.TboxToFloatspan(this._ptr);
            return new FloatSpan(res);
        }

        public TimestampTzSpan ToTimestampTzSpan()
        {
            var res = Meos.TboxToTstzspan(this._ptr);
            return new TimestampTzSpan(res);
        }

        public bool HasX()
            => (Meos.TboxHasx(this._ptr));

        public bool HasT()
            => (Meos.TboxHast(this._ptr));

        public bool IsMinXInclusive()
        {
            return AllocHelper.AllocatePointer<bool>(sizeof(bool), (resultPtr) =>
            {
                var successful = (Meos.TboxXminInc(this._ptr, resultPtr));
                return successful ? resultPtr.ToStructure<bool>() : false;
            });
        }

        public bool IsMaxXInclusive()
        {
            return AllocHelper.AllocatePointer<bool>(sizeof(bool), (resultPtr) =>
            {
                var successful = (Meos.TboxXmaxInc(this._ptr, resultPtr));
                return successful ? resultPtr.ToStructure<bool>() : false;
            });
        }

        public bool IsMinTInclusive()
        {
            return AllocHelper.AllocatePointer<bool>(sizeof(bool), (resultPtr) =>
            {
                var successful = (Meos.TboxTminInc(this._ptr, resultPtr));
                return successful ? resultPtr.ToStructure<bool>() : false;
            });
        }

        public bool IsMaxTInclusive()
        {
            return AllocHelper.AllocatePointer<bool>(sizeof(bool), (resultPtr) =>
            {
                var successful = (Meos.TboxTmaxInc(this._ptr, resultPtr));
                return successful ? resultPtr.ToStructure<bool>() : false;
            });
        }

        public double MinX()
        {
            return AllocHelper.AllocatePointer<double>(sizeof(double), (resultPtr) =>
            {
                var successful = (Meos.TboxXmin(this._ptr, resultPtr));
                return successful ? resultPtr.ToStructure<double>() : throw new InvalidOperationException("No X Min available");
            });
        }

        public double MaxX()
        {
            return AllocHelper.AllocatePointer<double>(sizeof(double), (resultPtr) =>
            {
                var successful = (Meos.TboxXmax(this._ptr, resultPtr));
                return successful ? resultPtr.ToStructure<double>() : throw new InvalidOperationException("No X Max available");
            });
        }

        public DateTime MinT()
        {
            var timestamp = AllocHelper.AllocatePointer<TimestampTz>(sizeof(long), (resultPtr) =>
            {
                var successful = (Meos.TboxTmin(this._ptr, resultPtr));
                return successful ? resultPtr.ToStructure<TimestampTz>() : throw new InvalidOperationException("No T Min available");
            });

            return timestamp.ToDateTime();
        }

        public DateTime MaxT()
        {
            var timestamp = AllocHelper.AllocatePointer<TimestampTz>(sizeof(long), (resultPtr) =>
            {
                var successful = (Meos.TboxTmax(this._ptr, resultPtr));
                return successful ? resultPtr.ToStructure<TimestampTz>() : throw new InvalidOperationException("No T Max available");
            });

            return timestamp.ToDateTime();
        }

        public bool IsLeftOf(TemporalBox other)
            => (Meos.LeftTboxTbox(this._ptr, other._ptr));

        public bool IsLeftOf(TemporalNumber other)
            => this.IsLeftOf(other.BoundingBox());

        public bool IsOverOrLeftOf(TemporalBox other)
            => (Meos.OverleftTboxTbox(this._ptr, other._ptr));

        public bool IsOverOrLeftOf(TemporalNumber other)
            => this.IsOverOrLeftOf(other.BoundingBox());

        public bool IsRightOf(TemporalBox other)
            => (Meos.RightTboxTbox(this._ptr, other._ptr));

        public bool IsRightOf(TemporalNumber other)
            => this.IsRightOf(other.BoundingBox());

        public bool IsOverOrRightOf(TemporalBox other)
            => (Meos.OverrightTboxTbox(this._ptr, other._ptr));

        public bool IsOverOrRightOf(TemporalNumber other)
            => this.IsOverOrRightOf(other.BoundingBox());
    }
}

