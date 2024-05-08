namespace MEOS.NET.Types.Temporal.Number.Float
{
	public static class TemporalFloatInstantExtensions
	{
        public static DateTime Timestamp(this IInstanteable<double> floatInstant)
			=> floatInstant.Instant.Timestamp();

        public static IEnumerable<DateTime> TimestampAsEnumerable(this IInstanteable<double> floatInstant)
            => floatInstant.Instant.TimestampAsEnumerable();

        public static IEnumerable<TemporalInstant<double>> ToEnumerable(this IInstanteable<double> floatInstant)
            => floatInstant.Instant.ToEnumerable();
	}
}

