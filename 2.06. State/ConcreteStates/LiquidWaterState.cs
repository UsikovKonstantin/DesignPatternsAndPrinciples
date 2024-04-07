using _06._State.StateInterface;

namespace _06._State.ConcreteStates;

public class LiquidWaterState : IWaterState
{
	public void Frost(Water water)
	{
        Console.WriteLine("Замораживаем воду");
		water.State = new SolidWaterState();
    }

	public void Heat(Water water)
	{
		Console.WriteLine("Кипятим воду");
		water.State = new GasWaterState();
	}
}
