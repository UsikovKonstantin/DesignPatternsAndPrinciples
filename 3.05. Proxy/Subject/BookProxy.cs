using _05._Proxy.BookInterface;
using _05._Proxy.RealSubject;

namespace _05._Proxy.Subject;

public class BookProxy : IBook
{
	private Book? _book;
	private List<Page> _pagesCache = new List<Page>();

    public BookProxy()
    {
        
    }

	public Page? GetPage(int number)
	{
		// Ищем страницу в кэше
		Page? page = _pagesCache.FirstOrDefault(p => p.Number == number);
		if (page != null)
			return page;

		// Если не нашли в кэше, то создаем реальный объект и просим у него страницу 
		if (_book == null)
			_book = new Book();
		page = _book.GetPage(number);

		// Добавляем страницу в кэш
		if (page != null)
			_pagesCache.Add(page);

		return page;
	}
}
