using _01._Strategy.Interface;

namespace _01._Strategy.ConcreteStrategies;

public class Bus : ITransport
{
	public void Move(double km)
	{
		Console.WriteLine($"На автобусе вы преодолеете {km} км за {4 * km} мин.");
	}
}
