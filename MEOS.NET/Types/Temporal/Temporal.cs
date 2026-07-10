using MEOS.NET.Enums;
using MEOS.NET.Helpers;
using MEOS.NET.Internal;
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
            var res = MEOSExposedFunctions.teq_temporal_temporal(this._ptr, other._ptr);
            return new TemporalBoolean(res);
        }

        public TemporalBoolean TemporalNotEqual(Temporal other)
        {
            var res = MEOSExposedFunctions.tne_temporal_temporal(this._ptr, other._ptr);
            return new TemporalBoolean(res);
        }

        public TemporalBoolean TemporalGreaterThan(Temporal other)
        {
            var res = MEOSExposedFunctions.tgt_temporal_temporal(this._ptr, other._ptr);
            return new TemporalBoolean(res);
        }

        public TemporalBoolean TemporalGreaterThanOrEqualTo(Temporal other)
        {
            var res = MEOSExposedFunctions.tge_temporal_temporal(this._ptr, other._ptr);
            return new TemporalBoolean(res);
        }

        public TemporalBoolean TemporalLessThan(Temporal other)
        {
            var res = MEOSExposedFunctions.tlt_temporal_temporal(this._ptr, other._ptr);
            return new TemporalBoolean(res);
        }

        public TemporalBoolean TemporalLessThanOrEqualTo(Temporal other)
        {
            var res = MEOSExposedFunctions.tle_temporal_temporal(this._ptr, other._ptr);
            return new TemporalBoolean(res);
        }

        public Temporal Copy()
        {
            var res = MEOSExposedFunctions.temporal_copy(this._ptr);
            return new Temporal(res);
        }

        public Temporal Minus(DateTime timestamp)
        {
            var res = MEOSExposedFunctions.temporal_minus_timestamptz(this._ptr, timestamp.ToPgTimestamp());
            return new Temporal(res);
        }

        public Temporal Minus(TimestampTzSet tsTzSet)
        {
            var res = MEOSExposedFunctions.temporal_minus_tstzset(this._ptr, tsTzSet._ptr);
            return new Temporal(res);
        }

        public Temporal Minus(TimestampTzSpan tsTzSpan)
        {
            var res = MEOSExposedFunctions.temporal_minus_tstzspan(this._ptr, tsTzSpan._ptr);
            return new Temporal(res);
        }

        public Temporal Minus(TimestampTzSpanSet tsTzSpanSet)
        {
            var res = MEOSExposedFunctions.temporal_minus_tstzspanset(this._ptr, tsTzSpanSet._ptr);
            return new Temporal(res);
        }

        public Temporal At(DateTime timestamp)
        {
            var res = MEOSExposedFunctions.temporal_at_timestamptz(this._ptr, timestamp.ToPgTimestamp());
            return new Temporal(res);
        }

        public Temporal At(TimestampTzSet tsTzSet)
        {
            var res = MEOSExposedFunctions.temporal_at_tstzset(this._ptr, tsTzSet._ptr);
            return new Temporal(res);
        }

        public Temporal At(TimestampTzSpan tsTzSpan)
        {
            var res = MEOSExposedFunctions.temporal_at_tstzspan(this._ptr, tsTzSpan._ptr);
            return new Temporal(res);
        }

        public Temporal At(TimestampTzSpanSet tsTzSpanSet)
        {
            var res = MEOSExposedFunctions.temporal_at_tstzspanset(this._ptr, tsTzSpanSet._ptr);
            return new Temporal(res);
        }

        public string ToMfJSON(bool boundingBox = true, int flags = 3, int precision = 6, string srs = "")
            => MEOSExposedFunctions.temporal_as_mfjson(this._ptr, boundingBox, flags, precision, srs);

        public TimestampTzSpan BoundingBox()
        {
            var res = MEOSExposedFunctions.temporal_to_tstzspan(this._ptr);
            return new TimestampTzSpan(res);
        }

        public InterpolationType Interpolation()
        {
            var interpolationStr = MEOSExposedFunctions.temporal_interp(this._ptr);
            return EnumConverter.InterpolationTypeFromString(interpolationStr);
        }

        public TimestampTzSpanSet Time()
        {
            var res = MEOSExposedFunctions.temporal_time(this._ptr);
            return new TimestampTzSpanSet(res);
        }

        public string Duration(bool ignoreGaps = false)
        {
            var res = MEOSExposedFunctions.temporal_duration(this._ptr, ignoreGaps);
            return MEOSExposedFunctions.interval_out(res);
        }

        public TimestampTzSpan TimeSpan()
        {
            var res = MEOSExposedFunctions.temporal_to_tstzspan(this._ptr);
            return new TimestampTzSpan(res);
        }

        public TimestampTzSpan ToTimestampTzSpan()
            => this.TimeSpan();

        public int InstantsCount()
            => MEOSExposedFunctions.temporal_num_instants(this._ptr);

        // TODO : Implement other, generic, temporal methods
    }
}
