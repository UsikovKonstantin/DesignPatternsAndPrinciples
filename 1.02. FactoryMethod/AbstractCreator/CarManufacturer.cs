using _01._FactoryMethod.AbstractProduct;

namespace _01._FactoryMethod.AbstractCreator;

public abstract class CarManufacturer
{
    public string Name { get; private set; }

    public CarManufacturer(string name)
    {
        Name = name;
    }

    // Фабричный метод
    abstract public Car CreateCar();
}
