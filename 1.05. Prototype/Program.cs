using _05._Prototype.CloneableInterface;
using _05._Prototype.Prototype;

// Прототип (Prototype)

/*
	Паттерн Прототип (Prototype) позволяет создавать объекты на основе уже ранее созданных объектов-прототипов. 
	То есть по сути данный паттерн предлагает технику клонирования объектов.
*/

IFigure figure = new Rectangle(30, 40);
IFigure clonedFigure = figure.Clone();
Console.WriteLine(figure.GetInfoString());
Console.WriteLine(clonedFigure.GetInfoString());
Console.WriteLine();

figure = new Circle(30);
clonedFigure = figure.Clone();
Console.WriteLine(figure.GetInfoString());
Console.WriteLine(clonedFigure.GetInfoString());
Console.WriteLine();


Square square = new Square(30);
Square clonedSquare = (Square)square.Clone();
Console.WriteLine(square.GetInfoString());
Console.WriteLine(clonedSquare.GetInfoString());
Console.WriteLine();
