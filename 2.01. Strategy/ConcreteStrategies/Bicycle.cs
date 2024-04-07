using _01._Strategy.Interface;

namespace _01._Strategy.ConcreteStrategies;

public class Bicycle : ITransport
{
	public void Move(double km)
	{
		Console.WriteLine($"На велосипеде вы преодолеете {km} км за {5 * km} мин.");
	}
}
