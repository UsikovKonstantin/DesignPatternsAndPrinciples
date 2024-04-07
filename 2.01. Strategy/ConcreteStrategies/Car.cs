using _01._Strategy.Interface;

namespace _01._Strategy.ConcreteStrategies;

public class Car : ITransport
{
	public void Move(double km)
	{
		Console.WriteLine($"На машине вы преодолеете {km} км за {2 * km} мин.");
	}
}
