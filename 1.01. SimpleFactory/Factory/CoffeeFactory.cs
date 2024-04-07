using _01._FactoryMethod.CoffeeEnum;
using _01._SimpleFactory.AbstractCoffee;
using _01._SimpleFactory.ConcreteCoffees;

namespace _01._FactoryMethod.Factory;

public class CoffeeFactory
{
    public Coffee CreateCoffee(CoffeeType coffeeType)
    {
        Coffee coffee;

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
                coffee = new Americano("Кофе Americano"); ;
                break;
        }

        return coffee;
    }
}
