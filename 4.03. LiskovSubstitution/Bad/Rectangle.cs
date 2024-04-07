namespace _4._03._LiskovSubstitution.Bad;

public class Rectangle
{
	public virtual double SideA { get; set; }
	public virtual double SideB { get; set; }

    public Rectangle()
    {
        SideA = 0;
		SideB = 0;
    }

    public Rectangle(double sideA, double sideB)
    {
		SideA = sideA;
		SideB = sideB;
	}

    public double GetArea()
	{
		return SideA * SideB;
	}
}
