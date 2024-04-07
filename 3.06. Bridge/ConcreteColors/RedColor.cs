using _06._Bridge.ColorInterface;

namespace _06._Bridge.ConcreteColors;

public class RedColor : IColor
{
	public void Fill()
	{
		Console.WriteLine("Заполняю красным цветом.");
	}
}
