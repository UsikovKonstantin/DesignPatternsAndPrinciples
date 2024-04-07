using _06._Builder.Product;

namespace _06._Builder.AbstractBuilder;

public abstract class BreadBuilder
{
    public Bread Bread { get; private set; } = new Bread();

    public abstract void SetFlour();
    public abstract void SetSalt();
    public abstract void SetAdditives();
}
