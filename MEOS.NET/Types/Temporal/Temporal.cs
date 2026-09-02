using MEOS.NET.Enums;
using MEOS.NET.Errors;
using MEOS.NET.Exceptions;
using MEOS.NET.Helpers;
using MEOS.NET.Functions;
using MEOS.NET.Types.General;
using MEOS.NET.Types.Collections.Time.Timestamp;
using MEOS.NET.Types.Temporal.Boolean;

namespace MEOS.NET.Types.Temporal
{
    public class Temporal : MEOSObject, ITemporallyEquatable<Temporal>, ITemporallyComparable<Temporal>
    {
        internal Temporal(IntPtr ptr) : base(ptr)
        { }

        // MEOS 1.3 split mfjson parsing per subtype: tbool_from_mfjson,
        // tint_from_mfjson, tfloat_from_mfjson, ttext_from_mfjson,
        // tgeogpoint_from_mfjson.  The previously-generic
        // temporal_from_mfjson(mfjson) no longer exists in MEOS; the new
        // temporal_from_mfjson(mfjson, meosType) requires the temptype enum
        // at the call site.  Provide the typed factories on each subclass
        // (TemporalBoolean.FromMFJson, TemporalFloat.FromMFJson, ...)
        // rather than a generic Temporal.FromMFJson that can't pick a
        // subtype from the JSON content alone.

        public TemporalBoolean TemporalEqual(Temporal other)
        {
            var res = Meos.TeqTemporalTemporal(this._ptr, other._ptr);
            return new TemporalBoolean(res);
        }

        public TemporalBoolean TemporalNotEqual(Temporal other)
        {
            var res = Meos.TneTemporalTemporal(this._ptr, other._ptr);
            return new TemporalBoolean(res);
        }

        public TemporalBoolean TemporalGreaterThan(Temporal other)
        {
            var res = Meos.TgtTemporalTemporal(this._ptr, other._ptr);
            return new TemporalBoolean(res);
        }

        public TemporalBoolean TemporalGreaterThanOrEqualTo(Temporal other)
        {
            var res = Meos.TgeTemporalTemporal(this._ptr, other._ptr);
            return new TemporalBoolean(res);
        }

        public TemporalBoolean TemporalLessThan(Temporal other)
        {
            var res = Meos.TltTemporalTemporal(this._ptr, other._ptr);
            return new TemporalBoolean(res);
        }

        public TemporalBoolean TemporalLessThanOrEqualTo(Temporal other)
        {
            var res = Meos.TleTemporalTemporal(this._ptr, other._ptr);
            return new TemporalBoolean(res);
        }

        public Temporal Copy()
        {
            var res = Meos.TemporalCopy(this._ptr);
            return new Temporal(res);
        }

        public Temporal Minus(DateTime timestamp)
        {
            var res = Meos.TemporalMinusTimestamptz(this._ptr, timestamp.ToPgTimestamp());
            return new Temporal(res);
        }

        public Temporal Minus(TimestampTzSet tsTzSet)
        {
            var res = Meos.TemporalMinusTstzset(this._ptr, tsTzSet._ptr);
            return new Temporal(res);
        }

        public Temporal Minus(TimestampTzSpan tsTzSpan)
        {
            var res = Meos.TemporalMinusTstzspan(this._ptr, tsTzSpan._ptr);
            return new Temporal(res);
        }

        public Temporal Minus(TimestampTzSpanSet tsTzSpanSet)
        {
            var res = Meos.TemporalMinusTstzspanset(this._ptr, tsTzSpanSet._ptr);
            return new Temporal(res);
        }

        public Temporal At(DateTime timestamp)
        {
            var res = Meos.TemporalAtTimestamptz(this._ptr, timestamp.ToPgTimestamp());
            return new Temporal(res);
        }

        public Temporal At(TimestampTzSet tsTzSet)
        {
            var res = Meos.TemporalAtTstzset(this._ptr, tsTzSet._ptr);
            return new Temporal(res);
        }

        public Temporal At(TimestampTzSpan tsTzSpan)
        {
            var res = Meos.TemporalAtTstzspan(this._ptr, tsTzSpan._ptr);
            return new Temporal(res);
        }

        public Temporal At(TimestampTzSpanSet tsTzSpanSet)
        {
            var res = Meos.TemporalAtTstzspanset(this._ptr, tsTzSpanSet._ptr);
            return new Temporal(res);
        }

        public string ToMfJSON(bool boundingBox = true, int flags = 3, int precision = 6, string srs = "")
            => Meos.TemporalAsMfjson(this._ptr, boundingBox, flags, precision, srs);

        public TimestampTzSpan BoundingBox()
        {
            var res = Meos.TemporalToTstzspan(this._ptr);
            return new TimestampTzSpan(res);
        }

        public InterpolationType Interpolation()
        {
            // temporal_interp names one of the interpolations MEOS defines, out of
            // its own static table, so the name is there for every temporal value.
            var interpolationStr = Meos.TemporalInterp(this._ptr)
                ?? throw new MEOSInternalErrorException(
                    (int)MEOSErrorCodes.InternalError,
                    MEOSErrorCodes.InternalError,
                    "MEOS named no interpolation for this temporal value");
            return EnumConverter.InterpolationTypeFromString(interpolationStr);
        }

        public TimestampTzSpanSet Time()
        {
            var res = Meos.TemporalTime(this._ptr);
            return new TimestampTzSpanSet(res);
        }

        public string Duration(bool ignoreGaps = false)
        {
            var res = Meos.TemporalDuration(this._ptr, ignoreGaps);
            return Meos.IntervalOut(res);
        }

        public TimestampTzSpan TimeSpan()
        {
            var res = Meos.TemporalToTstzspan(this._ptr);
            return new TimestampTzSpan(res);
        }

        public TimestampTzSpan ToTimestampTzSpan()
            => this.TimeSpan();

        public int InstantsCount()
            => Meos.TemporalNumInstants(this._ptr);

        // TODO : Implement other, generic, temporal methods
    }
}
