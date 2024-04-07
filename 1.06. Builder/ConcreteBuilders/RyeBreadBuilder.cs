using _06._Builder.Product;
using _06._Builder.AbstractBuilder;

namespace _06._Builder.ConcreteBuilders;

public class RyeBreadBuilder : BreadBuilder
{
    public override void SetFlour()
    {
        Bread.Flour = new Flour { Sort = "Ржаная мука 1 сорт", Weight = 250 };
    }

    public override void SetSalt()
    {
        Bread.Salt = new Salt { Weight = 12 };
    }

    public override void SetAdditives()
    {
        Bread.Additives = new List<Additive>();
	}
}
