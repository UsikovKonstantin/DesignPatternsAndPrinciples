namespace _05._Prototype.CloneableInterface;

public class Square : ICloneable
{
    public int Side { get; private set; }

    public Square(int side)
    {
		Side = side;
    }

	public double GetPerimeter()
	{
		return 4 * Side;
	}

	public double GetArea()
	{
		return Math.Pow(Side, 2);
	}

	public object Clone()
	{
		return new Square(Side);
	}

	public string GetInfoString()
	{
		return $"Side: {Side}";
	}
}
