using _07._Flyweight.FlyweightInterface;

namespace _07._Flyweight.ConcreteFlyweights;

public class Square : IShape
{
	public int Side { get; private set; }

	public Square(int side)
	{
		Side = side;
	}

	public void Draw(DrawContext context)
	{
		Console.WriteLine($"Рисую на холсте квадрат со стороной {Side} на позиции ({context.X}; {context.Y}), цвет - {context.Color}.");
	}
}
