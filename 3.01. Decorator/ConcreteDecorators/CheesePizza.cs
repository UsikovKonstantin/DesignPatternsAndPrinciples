using _01._Decorator.AbstractDecorator;
using _01._Decorator.AbstractPizza;

namespace _01._Decorator.ConcreteDecorators;

public class CheesePizza : PizzaDecorator
{
	public CheesePizza(Pizza pizza) : base(pizza.Name + ", с сыром", pizza.Price + 30, pizza)
	{

	}
}
