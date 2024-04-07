namespace _4._01._SingleResponsibility.Bad;

public class Phone
{
	public string Model { get; private set; }
	public double Price { get; private set; }

	public Phone(string model, double price)
	{
		Model = model;
		Price = price;
	}
}
