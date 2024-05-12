namespace MEOS.NET.Types.Temporal
{
	public interface IInstanteable<TBase>
	{
		TemporalInstant<TBase> Instant { get; init; }

		public TBase Value();
	}
}

