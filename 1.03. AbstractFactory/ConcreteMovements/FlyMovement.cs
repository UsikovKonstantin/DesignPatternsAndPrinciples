using _02._AbstractFactory.AbstractMovement;

namespace _03._AbstractFactory.ConcreteMovements;

public class FlyMovement : Movement
{
	public FlyMovement() : base(10, true)
	{

	}

	public override void Move()
    {
        Console.WriteLine($"Летаю, перемещаюсь на {Distance} клеток");
    }
}
