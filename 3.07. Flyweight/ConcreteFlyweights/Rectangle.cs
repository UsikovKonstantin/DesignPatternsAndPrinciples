using _07._Flyweight.FlyweightInterface;

namespace _07._Flyweight.ConcreteFlyweights;

public class Rectangle : IShape
{
	public int SideA { get; private set; }
	public int SideB { get; private set; }

	public Rectangle(int sideA, int sideB)
	{
		SideA = sideA;
		SideB = sideB;
	}

	public void Draw(DrawContext context)
	{
		Console.WriteLine($"Рисую на холсте прямоугольник со сторонами {SideA}, {SideB} на позиции ({context.X}; {context.Y}), цвет - {context.Color}.");
	}
}
