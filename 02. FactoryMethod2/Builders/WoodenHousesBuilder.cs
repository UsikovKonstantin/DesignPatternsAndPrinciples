using _01._FactoryMethod.Houses;

namespace _01._FactoryMethod.Builders;

public class WoodenHousesBuilder : Builder
{
    public WoodenHousesBuilder(string name) : base(name)
    {

    }

    public override House Create()
    {
        return new WoodenHouse();
    }
}
