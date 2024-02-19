using _01._FactoryMethod.Houses;

namespace _01._FactoryMethod.Builders;

public abstract class Builder
{
    public string Name { get; private set; }

    public Builder(string name)
    {
        Name = name;
    }

    // Фабричный метод
    abstract public House Create();
}
