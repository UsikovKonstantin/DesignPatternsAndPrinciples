using _05._Iterator.IteratorInterface;

namespace _05._Iterator.ConcreteIterator;

public class BookIterator : IMyIterator<Book>
{
    private List<Book> books;
    int currentIndex = -1;

    public BookIterator(List<Book> books)
    {
        this.books = books;
    }

	public Book Current => books[currentIndex];

	public bool MoveNext()
	{
		if (currentIndex < books.Count - 1)
		{
			currentIndex++;
			return true;
		}
		else if (currentIndex == books.Count - 1)
		{
			currentIndex++;
			return false;
		}
		else
		{
			return false;
		}
	}

	public void Reset()
	{
		currentIndex = -1;
	}
}
