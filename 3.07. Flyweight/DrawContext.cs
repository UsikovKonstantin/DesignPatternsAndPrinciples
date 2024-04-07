namespace _07._Flyweight;

public class DrawContext
{
    public int X { get; set; }
	public int Y { get; set; }
	public Color Color { get; set; }

    public DrawContext(int x, int y, Color color)
    {
        X = x;
        Y = y;
        Color = color;
    }
}
