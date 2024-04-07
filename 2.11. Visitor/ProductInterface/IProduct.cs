using _11._Visitor.VisitorInterface;

namespace _11._Visitor.ProductInterface;

public interface IProduct
{
	void Accept(IVisitor visitor);
}
