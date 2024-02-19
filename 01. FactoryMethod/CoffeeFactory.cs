using _01._FactoryMethod.Coffees;

namespace _01._FactoryMethod;

public class CoffeeFactory
{
	public Coffee? CreateCoffee(CoffeeType coffeeType)
	{
		Coffee? coffee;

		switch (coffeeType)
		{
			case CoffeeType.Americano:
				coffee = new Americano("Кофе Americano");
				break;
			case CoffeeType.Espresso:
				coffee = new Espresso("Кофе Espresso");
				break;
			case CoffeeType.Cappuccino:
				coffee = new Cappuccino("Кофе Cappuccino");
				break;
			case CoffeeType.CaffeLatte:
				coffee = new CaffeLatte("Кофе CaffeLatte");
				break;
			default:
				coffee = null;
				break;
		}

		return coffee;
	}
}
