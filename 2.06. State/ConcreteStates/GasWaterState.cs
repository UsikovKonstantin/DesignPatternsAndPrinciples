using _06._State.StateInterface;

namespace _06._State.ConcreteStates;

public class GasWaterState : IWaterState
{
	public void Frost(Water water)
	{
        Console.WriteLine("Преврящаем пар в воду");
		water.State = new LiquidWaterState();
    }

	public void Heat(Water water)
	{
		Console.WriteLine("Продолжаем нагревать пар");
	}
}
