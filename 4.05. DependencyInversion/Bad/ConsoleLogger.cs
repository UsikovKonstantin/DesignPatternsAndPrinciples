namespace _4._05._DependencyInversion.Bad;

public class ConsoleLogger
{
	public void LogInfo(string message)
	{
		Console.WriteLine(message);
	}
}
