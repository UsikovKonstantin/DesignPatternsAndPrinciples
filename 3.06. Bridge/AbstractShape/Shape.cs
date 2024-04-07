using _06._Bridge.ColorInterface;

namespace _06._Bridge.AbstractShape;

public abstract class Shape
{
	public IColor Color { get; set; }

    public Shape(IColor color)
    {
        Color = color;
    }

    public abstract void Draw();
}
