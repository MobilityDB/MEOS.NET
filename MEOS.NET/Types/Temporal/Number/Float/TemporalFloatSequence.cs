using MEOS.NET.Enums;
using MEOS.NET.Functions;
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
            var res = Meos.TfloatseqFromBaseTstzset(value, tsTzSet._ptr);
            return new TemporalFloatSequence(res);
        }

        public static TemporalFloatSequence FromTimestampSpan(TimestampTzSpan tsTzSpan, double value, InterpolationType interpolation = InterpolationType.None)
        {
            var res = Meos.TfloatseqFromBaseTstzspan(value, tsTzSpan._ptr, (int)interpolation);
            return new TemporalFloatSequence(res);
        }
    }
}

