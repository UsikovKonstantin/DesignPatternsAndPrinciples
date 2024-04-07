using _11._Visitor.ConcreteProducts;
using _11._Visitor.VisitorInterface;

namespace _11._Visitor.ConcreteVisitors;

public class InventoryVisitor : IVisitor
{
	public Dictionary<string, int> Inventory { get; private set; }

	public InventoryVisitor()
	{
		Inventory = new Dictionary<string, int>()
		{
			["Bread"] = 0,
			["Pen"] = 0,
			["SoccerBall"] = 0
		};
	}

	public void VisitBread(Bread bread)
	{
		Inventory["Bread"]++;
	}

	public void VisitPen(Pen pen)
	{
		Inventory["Pen"]++;
	}

	public void VisitSoccerBall(SoccerBall soccerBall)
	{
		Inventory["SoccerBall"]++;
	}
}
