namespace _4._05._DependencyInversion.Good;

public class Book
{
	public string Name { get; private set; }
	public string Text { get; private set; }
	public ILogger Logger { get; set; }

	public Book(string name, string text, ILogger logger)
	{
		Name = name;
		Text = text;
		Logger = logger;
	}

	public void LogBook()
	{
		Logger.LogInfo($"{Name}\n{Text}");
	}
}
