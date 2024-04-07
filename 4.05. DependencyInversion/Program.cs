using _4._05._DependencyInversion.Good;
using BookBad = _4._05._DependencyInversion.Bad.Book;
using BookGood = _4._05._DependencyInversion.Good.Book;

// D - Dependency inversion principle (принцип инверсии зависимостей)
/*
	Сильная связь классов - это плохо.
*/

// Bad
BookBad bookBad = new BookBad("name", "some text");
bookBad.LogBook();
Console.WriteLine();

// Good
BookGood bookGood = new BookGood("name", "some text", new ConsoleLogger());
bookGood.LogBook();
Console.WriteLine();
