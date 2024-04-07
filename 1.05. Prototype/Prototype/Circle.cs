namespace _05._Prototype.Prototype;

public class Circle : IFigure
{
    public int Radius { get; private set; }

    public Circle(int radius)
    {
		Radius = radius;
    }

	public double GetPerimeter()
	{
		return 2 * Math.PI * Radius;
	}

	public double GetArea()
	{
		return Math.PI * Math.Pow(Radius, 2);
	}

	public IFigure Clone()
	{
		return new Circle(Radius);
	}

	public string GetInfoString()
	{
		return $"Radius: {Radius}";
	}
}
