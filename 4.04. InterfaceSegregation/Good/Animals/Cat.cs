using _4._04._InterfaceSegregation.Good.Interfaces;

namespace _4._04._InterfaceSegregation.Good.Animals;

// Теперь определены только те методы, которые подходят конкретному животному
public class Cat : IEat, IWalk, ISwim
{
	public void Eat()
	{
		Console.WriteLine("Я кушаю");
	}

	public void Walk()
	{
		Console.WriteLine("Я гуляю");
	}

	public void Swim()
	{
		Console.WriteLine("Я плаваю");
	}
}
