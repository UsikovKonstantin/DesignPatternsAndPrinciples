using _06._Bridge.ColorInterface;

namespace _06._Bridge.ConcreteColors;

public class BlueColor : IColor
{
	public void Fill()
	{
		Console.WriteLine("Заполняю синим цветом.");
	}
}
