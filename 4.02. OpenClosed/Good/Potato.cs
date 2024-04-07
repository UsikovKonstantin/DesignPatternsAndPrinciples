namespace _4._02._OpenClosed.Good;

public class Potato : IMeal
{
	public void Cook()
	{
		Console.WriteLine("Помыть");
		Console.WriteLine("Почистить кожуру");
		Console.WriteLine("Поставить на огонь");
	}
}
