using MEOS.NET.Enums;
using MEOS.NET.Helpers;
using MEOS.NET.Internal;
using MEOS.NET.Types.Collections.Time.Timestamp;

namespace MEOS.NET.Types.Temporal.Number.Float
{
    public class TemporalFloatSequence : TemporalFloat, ISequenceable
	{
        public TemporalSequence Sequence { get; init; }

        internal TemporalFloatSequence(IntPtr ptr) : base(ptr)
            => this.Sequence = new TemporalSequence(ptr);

        public static TemporalFloatSequence FromTimestampSet(TimestampTzSet tsTzSet, double value)
        {
            var res = MEOSExposedFunctions.tfloatseq_from_base_tstzset(value, tsTzSet._ptr);
            return new TemporalFloatSequence(res);
        }

        public static TemporalFloatSequence FromTimestampSpan(TimestampTzSpan tsTzSpan, double value, InterpolationType interpolation = InterpolationType.None)
        {
            var res = MEOSExposedFunctions.tfloatseq_from_base_tstzspan(value, tsTzSpan._ptr, interpolation);
            return new TemporalFloatSequence(res);
        }
    }
}

