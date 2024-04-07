namespace _04._Singleton;

public sealed class Logger
{
	private static object _lock = new object();
	private static Logger? _instance;

	private Logger()
    {

	}

	public static Logger GetInstance()
	{
		lock (_lock)
		{
			if (_instance == null)
				_instance = new Logger();
			return _instance;
		}
	}

	public void Log(string message)
    {
        Console.WriteLine(message);
    }
}
