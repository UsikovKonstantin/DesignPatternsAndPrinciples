using _06._Builder.Product;
using _06._Builder.AbstractBuilder;

namespace _06._Builder.Director;

public class Baker
{
    public string Name { get; private set; }

    public Baker(string name)
    {
        Name = name;
    }

    public Bread CreateBread(BreadBuilder breadBuilder)
    {
        breadBuilder.SetFlour();
        breadBuilder.SetSalt();
        breadBuilder.SetAdditives();
        return breadBuilder.Bread;
    }
}
