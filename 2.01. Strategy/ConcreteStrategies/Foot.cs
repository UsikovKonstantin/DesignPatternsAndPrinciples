using _01._Strategy.Interface;

namespace _01._Strategy.ConcreteStrategies;

public class Foot : ITransport
{
	public void Move(double km)
	{
        Console.WriteLine($"Пешком вы преодолеете {km} км за {11 * km} мин.");
    }
}
