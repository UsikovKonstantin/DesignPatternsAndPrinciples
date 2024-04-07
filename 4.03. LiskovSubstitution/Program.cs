using _4._03._LiskovSubstitution.Bad;

// L - Liskov substitution principle (принцип подстановки Лисков)
/*
	Должна быть возможность вместо базового типа подставить любой его подтип.
*/

// Bad
Rectangle rect = new Rectangle();
TestRectangle(rect);
Console.WriteLine("Прямоугольник прошел проверку");

rect = new Square();
TestRectangle(rect);
Console.WriteLine("Квадрат прошел проверку");

void TestRectangle(Rectangle rect)
{
	rect.SideA = 5;
	rect.SideB = 10;
	if (rect.GetArea() != 50)
	{
		throw new Exception();
	}
}
