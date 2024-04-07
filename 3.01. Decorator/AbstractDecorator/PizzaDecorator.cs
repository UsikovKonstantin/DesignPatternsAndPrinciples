using _01._Decorator.AbstractPizza;

namespace _01._Decorator.AbstractDecorator;

public class PizzaDecorator : Pizza
{
	protected Pizza _pizza;

    public PizzaDecorator(string name, double price, Pizza pizza) : base(name, price)
    {
        _pizza = pizza;
    }
}
