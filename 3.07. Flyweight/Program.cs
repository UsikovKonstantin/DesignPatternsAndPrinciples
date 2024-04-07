using _07._Flyweight;
using _07._Flyweight.FlyweightFactory;
using _07._Flyweight.FlyweightInterface;

// Приспособленец (Flyweight)

/*
Паттерн Приспособленец (Flyweight) - структурный шаблон проектирования, который 
	позволяет использовать разделяемые объекты сразу в нескольких контекстах. 
	Данный паттерн используется преимущественно для оптимизации работы с памятью.

Паттерн Приспособленец следует применять при соблюдении всех следующих условий:
	Когда приложение использует большое количество однообразных объектов, 
		из-за чего происходит выделение большого количества памяти
	Когда часть состояния объекта, которое является изменяемым, можно вынести во вне. 
		Вынесение внешнего состояния позволяет заменить множество объектов небольшой 
		группой общих разделяемых объектов.
*/

ShapeFactory shapeFactory = new ShapeFactory();
List<IShape> shapes = new List<IShape>
{
	shapeFactory.CreatePoint(),
	shapeFactory.CreateCircle(10),
	shapeFactory.CreateSquare(30),
	shapeFactory.CreateCircle(20),
	shapeFactory.CreateCircle(20),
	shapeFactory.CreatePoint(),
	shapeFactory.CreateSquare(40)
};

DrawContext drawContext = new DrawContext(10, 20, Color.Green);
foreach (IShape shape in shapes)
{
	shape.Draw(drawContext);
}
Console.WriteLine();

drawContext.X = 150;
drawContext.Y = 250;
drawContext.Color = Color.Yellow;

IShape circle = shapeFactory.CreateCircle(10);
IShape square = shapeFactory.CreateSquare(7);
IShape rectangle = shapeFactory.CreateRectangle(3, 8);
circle.Draw(drawContext);
square.Draw(drawContext);
rectangle.Draw(drawContext);
