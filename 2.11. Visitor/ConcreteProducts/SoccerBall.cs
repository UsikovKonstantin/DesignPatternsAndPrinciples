using _11._Visitor.ProductInterface;
using _11._Visitor.VisitorInterface;

namespace _11._Visitor.ConcreteProducts;

public class SoccerBall : IProduct
{
	public string Name { get; private set; }
	public double Price { get; private set; }
	public int Size { get; private set; }

	public SoccerBall(string name, double price, int size)
    {
        Name = name;
		Price = price;
		Size = size;
	}

    public void Accept(IVisitor visitor)
	{
		visitor.VisitSoccerBall(this);
	}
}
