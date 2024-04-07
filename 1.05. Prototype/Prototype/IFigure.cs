namespace _05._Prototype.Prototype;

public interface IFigure
{
	double GetPerimeter();
	double GetArea();
	IFigure Clone();
	string GetInfoString();
}
