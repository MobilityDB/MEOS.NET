namespace MEOS.NET.Types.Collections.Time
{
	public interface ITimeCollection<T> : ICollection<T>
        where T : ICollection<T>
	{
        bool IsBefore(T timeCollection);
        bool IsOverOrBefore(T timeCollection);
        bool IsOverOrAfter(T timeCollection);
        bool IsAfter(T timeCollection);
    }
}

