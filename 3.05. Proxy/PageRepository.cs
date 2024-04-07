namespace _05._Proxy;

public class PageRepository
{
	private List<Page> _pages;

    public PageRepository()
    {
		_pages = new List<Page>()
		{
			new Page(1, "Привет"),
			new Page(2, "мир"),
			new Page(3, "!")
		};
	}

	public Page? GetPage(int number)
	{
		return _pages.FirstOrDefault(p => p.Number == number);
	}
}
