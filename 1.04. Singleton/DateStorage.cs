namespace _04._Singleton;

public sealed class DateStorage
{
	private static object _lock = new object();
	private static DateStorage? _instance;

    public DateTime Date { get; }

	private DateStorage(DateTime date)
	{
		Date = date;
	}

	public static DateStorage GetInstance(DateTime date)
	{
		lock (_lock)
		{
			if (_instance == null)
				_instance = new DateStorage(date);
			return _instance;
		}
	}
}
