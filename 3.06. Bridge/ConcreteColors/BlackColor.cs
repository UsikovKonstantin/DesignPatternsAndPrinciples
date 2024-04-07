using _06._Bridge.ColorInterface;

namespace _06._Bridge.ConcreteColors;

public class BlackColor : IColor
{
	public void Fill()
	{
        Console.WriteLine("Заполняю черным цветом.");
    }
}
