using _02._AbstractFactory.HeroFactories;
using _02._AbstractFactory;

// Абстрактная фабрика (Abstract Factory)

/*
Паттерн "Абстрактная фабрика" (Abstract Factory) предоставляет интерфейс 
	для создания семейств взаимосвязанных объектов с определенными интерфейсами 
	без указания конкретных типов данных объектов.

Когда использовать абстрактную фабрику:
	Когда система не должна зависеть от способа создания и компоновки новых объектов
	Когда создаваемые объекты должны использоваться вместе и являются взаимосвязанными
*/

Hero elf = new Hero(new ElfFactory());
elf.Attack();
elf.Move();

Hero warrior = new Hero(new WarriorFactory());
warrior.Attack();
warrior.Move();