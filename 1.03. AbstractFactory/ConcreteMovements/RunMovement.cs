using _02._AbstractFactory.AbstractMovement;

namespace _03._AbstractFactory.ConcreteMovements;

public class RunMovement : Movement
{
	public RunMovement() : base(5, false)
	{

	}

	public override void Move()
    {
		Console.WriteLine($"Бегу, перемещаюсь на {Distance} клеток");
	}
}
