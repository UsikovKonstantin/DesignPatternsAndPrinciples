using _4._02._OpenClosed.Bad;
using _4._02._OpenClosed.Good;
using ChefBad = _4._02._OpenClosed.Bad.Chef;
using ChefGood = _4._02._OpenClosed.Good.Chef;

// O - Open-closed principle (принцип открытости для расширения / закрытости для модификации)
/*
	Программные сущности должны быть открыты для расширения и закрыты для изменения.
*/

// Bad
ChefBad chefBad = new ChefBad("John");
chefBad.Cook(MealType.Potato);
Console.WriteLine();

// Good
ChefGood chefGood = new ChefGood("Sam");
chefGood.Cook(new Potato());
Console.WriteLine();
