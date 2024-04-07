using _11._Visitor.ProductInterface;
using _11._Visitor.VisitorInterface;

namespace _11._Visitor;

public class Store
{
	private List<IProduct> _products;

    public Store()
    {
		_products = new List<IProduct>();
	}

    public void AddProduct(IProduct product)
	{
		_products.Add(product);
	}

	public void RemoveProduct(IProduct product)
	{
		_products.Remove(product);
	}

	public void AcceptVisitor(IVisitor visitor)
	{
		foreach (IProduct product in _products)
			product.Accept(visitor);
	}
}
