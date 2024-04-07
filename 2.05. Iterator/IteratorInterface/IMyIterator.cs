namespace _05._Iterator.IteratorInterface;

public interface IMyIterator<T>
{
	bool MoveNext();
    T Current { get; }
    void Reset();
}
