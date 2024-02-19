using _01._FactoryMethod.Houses;

namespace _01._FactoryMethod.Builders;

public class PanelHousesBuilder : Builder
{
    public PanelHousesBuilder(string name) : base(name)
    {

    }

    public override House Create()
    {
        return new PanelHouse();
    }
}
