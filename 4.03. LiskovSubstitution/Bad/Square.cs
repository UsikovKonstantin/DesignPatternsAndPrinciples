namespace _4._03._LiskovSubstitution.Bad;

public class Square : Rectangle
{
	public override double SideA
	{
		get
		{
			return base.SideA;
		}

		set
		{
			// С точки зрения квадрата всё правильно, но если мы посмотрим с точки зрения прямоугольника,
			// то при изменении одной стороны, другая не должна меняться.
			base.SideA = value;
			base.SideB = value;
		}
	}

	public override double SideB
	{
		get
		{
			return base.SideB;
		}

		set
		{
			base.SideA = value;
			base.SideB = value;
		}
	}

    public Square() : base() 
    {
        
    }

    public Square(double side) : base(side, side)
    {

    }
}
