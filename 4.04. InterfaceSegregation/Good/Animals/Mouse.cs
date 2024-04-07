using _4._04._InterfaceSegregation.Good.Interfaces;

namespace _4._04._InterfaceSegregation.Good.Animals;

public class Mouse : IEat, IWalk
{
	public void Eat()
	{
		Console.WriteLine("Я кушаю");
	}

	public void Walk()
	{
		Console.WriteLine("Я гуляю");
	}
}
