using _01._Decorator.AbstractDecorator;
using _01._Decorator.AbstractPizza;

namespace _01._Decorator.ConcreteDecorators;

public class OnionPizza : PizzaDecorator
{
	public OnionPizza(Pizza pizza) : base(pizza.Name + ", с луком", pizza.Price + 7, pizza)
	{

	}
}
