using _01._FactoryMethod.AbstractProduct;

namespace _01._FactoryMethod.ConcreteProducts;

public class ElectroCar : Car
{
    public ElectroCar(string name, int speed) : base(name, speed)
    {

    }
}
