namespace _4._04._InterfaceSegregation.Bad;

public class Cat : IAnimal
{
	public void Eat()
	{
		Console.WriteLine("Я кушаю");
	}

	public void Fly()
	{
		// Плохо, кошка не умеет летать, но метод мы определить должны
		throw new NotImplementedException();
	}

	public void Swim()
	{
		Console.WriteLine("Я плаваю");
	}

	public void Walk()
	{
		Console.WriteLine("Я гуляю");
	}
}
