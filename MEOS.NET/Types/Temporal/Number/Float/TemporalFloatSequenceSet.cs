using MEOS.NET.Enums;
using MEOS.NET.Functions;
using MEOS.NET.Types.Collections.Time.Timestamp;

namespace MEOS.NET.Types.Temporal.Number.Float
{
    public class TemporalFloatSequenceSet : TemporalFloat, ISequenceSetable
	{
        public TemporalSequenceSet SequenceSet { get; init; }

        internal TemporalFloatSequenceSet(IntPtr ptr) : base(ptr)
            => this.SequenceSet = new TemporalSequenceSet(ptr);

        public static TemporalFloatSequenceSet FromTimestampSpanSet(TimestampTzSpanSet tsTzSpanSet, double value, InterpolationType interpolation =  InterpolationType.None)
        {
            var res = Meos.TfloatseqsetFromBaseTstzspanset(value, tsTzSpanSet._ptr, (int)interpolation);
            return new TemporalFloatSequenceSet(res);
        }
    }
}

