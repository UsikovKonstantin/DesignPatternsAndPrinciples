using _06._Builder.Product;
using _06._Builder.ConcreteBuilders;
using _06._Builder.Director;

// Строитель (Builder)

/*
Строитель (Builder) - шаблон проектирования, который инкапсулирует 
	создание объекта и позволяет разделить его на различные этапы.

Когда использовать паттерн Строитель?
	Когда процесс создания нового объекта не должен зависеть от того, 
		из каких частей этот объект состоит и как эти части связаны между собой.
	Когда необходимо обеспечить получение различных вариаций объекта 
		в процессе его создания.
*/

Baker baker = new Baker("Иванов Иван");

Bread ryeBread = baker.CreateBread(new RyeBreadBuilder());
Console.WriteLine(ryeBread);

Bread wheatBread = baker.CreateBread(new WheatBreadBuilder());
Console.WriteLine(wheatBread);
