namespace _02._AbstractFactory.AbstractMovement;

public abstract class Movement
{
    public int Distance { get; protected set; }
	public bool CanFly { get; protected set; }

	protected Movement(int distance, bool canFly)
    {
        Distance = distance;
        CanFly = canFly;
    }

    public abstract void Move();
}
