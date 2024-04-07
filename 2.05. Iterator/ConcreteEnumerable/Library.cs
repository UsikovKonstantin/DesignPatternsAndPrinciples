using System.Collections;
using _05._Iterator.ConcreteIterator;
using _05._Iterator.EnumerableInterface;
using _05._Iterator.IteratorInterface;

namespace _05._Iterator.ConcreteEnumerable;

public class Library : IMyEnumerable<Book>, IEnumerable<Book>
{
    private List<Book> _books;

    public Library(List<Book> books)
    {
        _books = books;
    }

	#region 1. Индексатор
	public Book this[int index]
    {
        get
        {
            return _books[index];
        }
    }

    public int Count
    {
        get
        {
            return _books.Count;
        }
    }
	#endregion

	#region 2. Интерфейс IEnumerable
	public IEnumerator<Book> GetEnumerator()
    {
        return _books.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _books.GetEnumerator();
    }
	#endregion

	#region 3. Паттерн "Итератор"
	public IMyIterator<Book> CreateIterator()
	{
		return new BookIterator(_books);
	}
	#endregion
}
