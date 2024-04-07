using _06._Bridge.AbstractShape;
using _06._Bridge.ColorInterface;

namespace _06._Bridge.ConcreteShapes;

public class Circle : Shape
{
	public double Radius { get; private set; }

	public Circle(double radius, IColor color) : base(color)
	{
		Radius = radius;
	}

	public override void Draw()
	{
		Console.WriteLine($"Рисую круг с радиусом {Radius}.");
		Color.Fill();
	}
}
