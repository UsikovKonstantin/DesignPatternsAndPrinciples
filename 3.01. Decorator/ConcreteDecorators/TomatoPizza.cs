using _01._Decorator.AbstractDecorator;
using _01._Decorator.AbstractPizza;

namespace _01._Decorator.ConcreteDecorators;

public class TomatoPizza : PizzaDecorator
{
	public TomatoPizza(Pizza pizza) : base(pizza.Name + ", с томатами", pizza.Price + 15, pizza)
	{

	}
}
