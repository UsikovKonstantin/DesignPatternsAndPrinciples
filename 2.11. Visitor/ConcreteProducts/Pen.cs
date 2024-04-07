using _11._Visitor.ProductInterface;
using _11._Visitor.VisitorInterface;

namespace _11._Visitor.ConcreteProducts;

public class Pen : IProduct
{
	public string Name { get; private set; }
	public double Price { get; private set; }
	public double Thickness { get; private set; }

	public Pen(string name, double price, double thickness)
	{
		Name = name;
		Price = price;
		Thickness = thickness;
	}

	public void Accept(IVisitor visitor)
	{
		visitor.VisitPen(this);
	}
}
