using _06._Bridge.AbstractShape;
using _06._Bridge.ColorInterface;

namespace _06._Bridge.ConcreteShapes;

public class Rectangle : Shape
{
	public double SideA { get; private set; }
	public double SideB { get; private set; }

	public Rectangle(double sideA, double sideB, IColor color) : base(color)
	{
		SideA = sideA;
		SideB = sideB;
	}

	public override void Draw()
	{
		Console.WriteLine($"Рисую прямоугольник со сторонами ({SideA}, {SideB}).");
		Color.Fill();
	}
}
