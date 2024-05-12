using MEOS.NET.Types.Temporal.Boolean;

namespace MEOS.NET.Types.Temporal
{
	public interface ITemporallyComparable<T>
	{
		TemporalBoolean TemporalLessThan(T other);
		TemporalBoolean TemporalLessThanOrEqualTo(T other);
		TemporalBoolean TemporalGreaterThan(T other);
		TemporalBoolean TemporalGreaterThanOrEqualTo(T other);
	}
}

