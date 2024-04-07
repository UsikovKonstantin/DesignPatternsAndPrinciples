using _05._Iterator;
using _05._Iterator.ConcreteEnumerable;
using _05._Iterator.IteratorInterface;

// Итератор (Iterator)

/*
Паттерн Итератор (Iterator) предоставляет абстрактный интерфейс для последовательного доступа 
    ко всем элементам составного объекта без раскрытия его внутренней структуры.

Когда использовать итераторы?
    Когда необходимо осуществить обход объекта без раскрытия его внутренней структуры.
    Когда имеется набор составных объектов, и надо обеспечить единый интерфейс для их перебора.
    Когда необходимо предоставить несколько альтернативных вариантов перебора одного и того же объекта.
*/

List<Book> books = new List<Book> { new Book("Война и мир"), new Book("Мертвые души"), new Book("Преступление и наказание") };
Library library = new Library(books);

// 1. Использование индексатора.
for (int i = 0; i < library.Count; i++)
{
	Console.WriteLine(library[i].Name);
}
Console.WriteLine();

// 2. Использование IEnumerable.
foreach (Book book in library)
{
    Console.WriteLine(book.Name);
}
Console.WriteLine();

// 3. Использование итератора.
IMyIterator<Book> iterator = library.CreateIterator();
while (iterator.MoveNext())
{
	Book book = iterator.Current;
	Console.WriteLine(book.Name);
}
