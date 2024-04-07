namespace _01._FactoryMethod.AbstractProduct;

public abstract class Car
{
    public string Name { get; private set; }
    public int MaxSpeed { get; private set; }

    protected Car(string name, int speed)
    {
        Name = name;
        MaxSpeed = speed;
    }

	public override string ToString()
	{
        return $"Name: {Name}, MaxSpeed: {MaxSpeed}";
	}
}
