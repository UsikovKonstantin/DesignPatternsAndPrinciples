namespace _4._05._DependencyInversion.Good;

public class ConsoleLogger : ILogger
{
	public void LogInfo(string message)
	{
        Console.WriteLine(message);
    }
}
