using _11._Visitor.ProductInterface;
using _11._Visitor.VisitorInterface;

namespace _11._Visitor.ConcreteProducts;

public class Bread : IProduct
{
	public string Name { get; private set; }
	public double Price { get; private set; }
	public DateTime ExpirationDate { get; private set; }

	public Bread(string name, double price, DateTime expirationDate)
	{
		Name = name;
		Price = price;
		ExpirationDate = expirationDate;
	}

	public void Accept(IVisitor visitor)
	{
		visitor.VisitBread(this);
	}
}
