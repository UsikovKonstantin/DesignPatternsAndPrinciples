using _07._Flyweight.FlyweightInterface;

namespace _07._Flyweight.ConcreteFlyweights;

public class Point : IShape
{
    public Point()
    {
        
    }

    public void Draw(DrawContext context)
	{
		Console.WriteLine($"Рисую на холсте точку на позиции ({context.X}; {context.Y}), цвет - {context.Color}.");
	}
}
