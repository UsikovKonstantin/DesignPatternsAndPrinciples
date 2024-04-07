using _06._Builder.Product;
using _06._Builder.AbstractBuilder;

namespace _06._Builder.ConcreteBuilders;

public class WheatBreadBuilder : BreadBuilder
{
    public override void SetFlour()
    {
        Bread.Flour = new Flour { Sort = "Пшеничная мука высший сорт", Weight = 200 };
    }

    public override void SetSalt()
    {
        Bread.Salt = new Salt { Weight = 10 };
    }

    public override void SetAdditives()
    {
        Bread.Additives = new List<Additive>() { new Additive { Name = "Улучшитель хлебопекарный", Weight = 5 } };
    }
}
