namespace _05._Prototype.Prototype;

public class Rectangle : IFigure
{
    public int SideA { get; private set; }
	public int SideB { get; private set; }

    public Rectangle(int sideA, int sideB)
    {
		SideA = sideA;
		SideB = sideB;    
    }

	public double GetPerimeter()
	{
		return 2 * (SideA + SideB);
	}

	public double GetArea()
	{
		return SideA * SideB;
	}

	public IFigure Clone()
	{
		return new Rectangle(SideA, SideB);
	}

	public string GetInfoString()
	{
		return $"SideA: {SideA}, SideB: {SideB}";
	}
}
