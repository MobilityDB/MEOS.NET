namespace MEOS.NET.Types.Collections
{
	public interface ICollection<T>
	{
        bool IsContainedIn(T collection);
        bool Contains(T collection);
        abstract bool Overlaps(T collection);
        bool IsLeftOf(T collection);
        bool IsOverOrLeftOf(T collection);
        bool IsRightOf(T collection);
        bool IsOverOrRightOf(T collection);
    }
}

