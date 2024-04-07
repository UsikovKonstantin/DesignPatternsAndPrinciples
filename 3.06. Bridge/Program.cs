using _06._Bridge.AbstractShape;
using _06._Bridge.ConcreteColors;
using _06._Bridge.ConcreteShapes;

// Мост (Bridge)

/*
Мост (Bridge) - структурный шаблон проектирования, который позволяет 
	отделить абстракцию от реализации таким образом, чтобы и абстракцию, 
	и реализацию можно было изменять независимо друг от друга.

Когда использовать данный паттерн?
	Когда надо избежать постоянной привязки абстракции к реализации.
	Когда наряду с реализацией надо изменять и абстракцию независимо друг от друга. 
		То есть изменения в абстракции не должно привести к изменениям в реализации.
*/

Shape rectangle = new Rectangle(3, 5, new RedColor());
rectangle.Draw();
Console.WriteLine();

rectangle.Color = new BlueColor();
rectangle.Draw();
Console.WriteLine();

Shape blackSquare = new Square(10, new BlackColor());
blackSquare.Draw();
Console.WriteLine();
