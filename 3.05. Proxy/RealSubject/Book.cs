using _05._Proxy.BookInterface;

namespace _05._Proxy.RealSubject;

public class Book : IBook
{
    private PageRepository _repository;

    public Book()
    {
		_repository = new PageRepository();
    }

	public Page? GetPage(int number)
	{
		return _repository.GetPage(number);
	}
}
