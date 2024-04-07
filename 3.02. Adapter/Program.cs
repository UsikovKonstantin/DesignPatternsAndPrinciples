using _02._Adapter;
using _02._Adapter.Adaptee;
using _02._Adapter.Adapter;
using _02._Adapter.Target;

// Адаптер (Adapter)

/*
Паттерн Адаптер (Adapter) предназначен для преобразования интерфейса 
	одного класса в интерфейс другого. Благодаря реализации данного паттерна 
	мы можем использовать вместе классы с несовместимыми интерфейсами.

Когда надо использовать Адаптер?
	Когда необходимо использовать имеющийся класс, но его интерфейс не соответствует потребностям.
	Когда надо использовать уже существующий класс совместно с другими классами, интерфейсы 
		которых не совместимы.
*/


Car car = new Car();
Traveller traveler = new Traveller(car);
traveler.Travel();

Camel camel = new Camel();
ITransport camelTransport = new CamelTransport(camel);
traveler.Transport = camelTransport;
traveler.Travel();
