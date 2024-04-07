using _11._Visitor.ConcreteProducts;
using _11._Visitor.VisitorInterface;

namespace _11._Visitor.ConcreteVisitors;

public class PriceVisitor : IVisitor
{
    public double TotalPrice { get; private set; }

    public PriceVisitor()
    {
		TotalPrice = 0;
	}

    public void VisitBread(Bread bread)
	{
		TotalPrice += bread.Price;
	}

	public void VisitPen(Pen pen)
	{
		TotalPrice += pen.Price;
	}

	public void VisitSoccerBall(SoccerBall soccerBall)
	{
		TotalPrice += soccerBall.Price;
	}
}
