using _11._Visitor.ConcreteProducts;

namespace _11._Visitor.VisitorInterface;

public interface IVisitor
{
	void VisitBread(Bread bread);
	void VisitPen(Pen pen);
	void VisitSoccerBall(SoccerBall soccerBall);
}
