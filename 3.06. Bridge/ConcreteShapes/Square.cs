using _06._Bridge.AbstractShape;
using _06._Bridge.ColorInterface;

namespace _06._Bridge.ConcreteShapes;

public class Square : Shape
{
    public double Side { get; private set; }

    public Square(double side, IColor color) : base(color)
    {
        Side = side;
    }

	public override void Draw()
	{
		Console.WriteLine($"Рисую квадрат со стороной {Side}.");
		Color.Fill();
    }
}
