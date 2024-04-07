using _06._State.StateInterface;

namespace _06._State.ConcreteStates;

public class SolidWaterState : IWaterState
{
	public void Frost(Water water)
	{
        Console.WriteLine("Продолжаем замораживать лед");
    }

	public void Heat(Water water)
	{
		Console.WriteLine("Размораживаем лед");
		water.State = new LiquidWaterState();
	}
}
