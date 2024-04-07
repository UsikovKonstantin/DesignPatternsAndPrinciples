using _01._FactoryMethod.AbstractCreator;
using _01._FactoryMethod.AbstractProduct;
using _01._FactoryMethod.ConcreteProducts;

namespace _01._FactoryMethod.ConcreteCreators;

public class TeslaManufacturer : CarManufacturer
{
    public TeslaManufacturer(string name) : base(name)
    {

    }

    public override Car CreateCar()
    {
        return new ElectroCar("Tesla Model X", 300);
    }
}
