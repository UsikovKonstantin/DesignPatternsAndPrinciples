namespace _4._05._DependencyInversion.Bad;

public class Book
{
    public string Name { get; private set; }
    public string Text { get; private set; }

	// Плохо, сильная связь классов, а что если захотим логировать в файл?
	public ConsoleLogger Logger { get; private set; }

	public Book(string name, string text)
	{
		Name = name;
		Text = text;
		Logger = new ConsoleLogger();
	}

	public void LogBook()
	{
		Logger.LogInfo($"{Name}\n{Text}");
	}
}
