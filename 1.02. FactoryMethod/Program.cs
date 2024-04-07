using _01._FactoryMethod.AbstractCreator;
using _01._FactoryMethod.AbstractProduct;
using _01._FactoryMethod.ConcreteCreators;

// Фабричный метод (Factory Method)

/*
Фабричный метод (Factory Method) - это паттерн, который определяет интерфейс для создания объектов 
	некоторого класса, но непосредственное решение о том, объект какого класса создавать происходит в подклассах. 
	То есть паттерн предполагает, что базовый класс делегирует создание объектов классам-наследникам.
 
Когда надо применять паттерн:
	Когда заранее неизвестно, объекты каких типов необходимо создавать
	Когда система должна быть независимой от процесса создания новых объектов и расширяемой: 
		в нее можно легко вводить новые классы, объекты которых система должна создавать.
	Когда создание новых объектов необходимо делегировать из базового класса классам наследникам
*/

CarManufacturer teslaManufacturer = new TeslaManufacturer("Tesla");
Car electroCar = teslaManufacturer.CreateCar();
Console.WriteLine(electroCar.ToString());

CarManufacturer renaultManufacturer = new RenaultManufacturer("Renault");
Car petrolCar = renaultManufacturer.CreateCar();
Console.WriteLine(petrolCar.ToString());

/*
Если в будущем нам потребуется производить машины какого-то другого типа, например, дизельные, 
	то мы можем с легкостью создать новый класс дизельных машин, унаследованный от Car, 
	и определить класс соответствующего производителя.
 */
