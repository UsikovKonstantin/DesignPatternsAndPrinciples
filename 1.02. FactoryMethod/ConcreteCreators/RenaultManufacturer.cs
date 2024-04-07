using _01._FactoryMethod.AbstractCreator;
using _01._FactoryMethod.AbstractProduct;
using _01._FactoryMethod.ConcreteProducts;

namespace _01._FactoryMethod.ConcreteCreators;

public class RenaultManufacturer : CarManufacturer
{
    public RenaultManufacturer(string name) : base(name)
    {

    }

    public override Car CreateCar()
    {
        return new PetrolCar("Renault Logan", 200);
    }
}
