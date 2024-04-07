namespace _01._Decorator.AbstractPizza;

public abstract class Pizza
{
    public string Name { get; private set; }
    public double Price { get; private set; }

    public Pizza(string name, double price)
    {
        Name = name;
		Price = price;
	}
}
