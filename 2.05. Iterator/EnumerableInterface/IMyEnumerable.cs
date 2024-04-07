using _05._Iterator.IteratorInterface;

namespace _05._Iterator.EnumerableInterface;

public interface IMyEnumerable<T>
{
    IMyIterator<T> CreateIterator();
}
