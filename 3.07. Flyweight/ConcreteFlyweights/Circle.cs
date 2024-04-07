using _07._Flyweight.FlyweightInterface;

namespace _07._Flyweight.ConcreteFlyweights;

public class Circle : IShape
{
    public int Radius { get; private set; }

    public Circle(int radius)
    {
        Radius = radius;
    }

	public void Draw(DrawContext context)
	{
        Console.WriteLine($"Рисую на холсте круг с радиусом {Radius} на позиции ({context.X}; {context.Y}), цвет - {context.Color}.");
    }
}
