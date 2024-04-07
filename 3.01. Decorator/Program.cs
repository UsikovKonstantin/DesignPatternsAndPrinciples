using _01._Decorator.AbstractPizza;
using _01._Decorator.ConcreteDecorators;
using _01._Decorator.ConcretePizzas;

// Декоратор (Decorator)

/*
Декоратор (Decorator) представляет структурный шаблон проектирования, который 
	позволяет динамически подключать к объекту дополнительную функциональность.
	Для определения нового функционала в классах нередко используется наследование. 
	Декораторы же предоставляет наследованию более гибкую альтернативу, поскольку 
	позволяют динамически в процессе выполнения определять новые возможности у объектов.

Когда следует использовать декораторы?
	Когда надо динамически добавлять к объекту новые функциональные возможности.
		При этом данные возможности могут быть сняты с объекта.
	Когда применение наследования неприемлемо. Например, если нам надо определить множество 
		различных функциональностей и для каждой функциональности наследовать отдельный класс, 
		то структура классов может очень сильно разрастись. Еще больше она может разрастись, 
		если нам необходимо создать классы, реализующие все возможные сочетания добавляемых 
		функциональностей.
*/

// Итальянская пицца с томатами
Pizza pizza1 = new ItalianPizza();
pizza1 = new TomatoPizza(pizza1); 
Console.WriteLine("Название: {0}", pizza1.Name);
Console.WriteLine("Цена: {0}", pizza1.Price);
Console.WriteLine();

// Итальянская пиццы с сыром
Pizza pizza2 = new ItalianPizza();
pizza2 = new CheesePizza(pizza2);
Console.WriteLine("Название: {0}", pizza2.Name);
Console.WriteLine("Цена: {0}", pizza2.Price);
Console.WriteLine();

// Болгарская пиццы с томатами, сыром и луком
Pizza pizza3 = new BulgarianPizza();
pizza3 = new TomatoPizza(pizza3);
pizza3 = new CheesePizza(pizza3);
pizza3 = new OnionPizza(pizza3);
Console.WriteLine("Название: {0}", pizza3.Name);
Console.WriteLine("Цена: {0}", pizza3.Price);
Console.WriteLine();
