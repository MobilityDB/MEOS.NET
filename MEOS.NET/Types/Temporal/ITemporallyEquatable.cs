using MEOS.NET.Types.Temporal.Boolean;

namespace MEOS.NET.Types.Temporal
{
	public interface ITemporallyEquatable<T>
	{
        TemporalBoolean TemporalEqual(T other);
		TemporalBoolean TemporalNotEqual(T other);
	}
}