namespace _4._05._DependencyInversion.Good;

public class FileLogger : ILogger
{
	private string _fileName;

	public FileLogger(string fileName)
	{
		_fileName = fileName;
	}

	public void LogInfo(string message)
	{
		using (StreamWriter writer = new StreamWriter(_fileName, true))
		{
			writer.WriteLine(message);
		}
	}
}
