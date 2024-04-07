namespace _4._02._OpenClosed.Good;

public class Chef
{
	public string Name { get; private set; }

	public Chef(string name)
	{
		Name = name;
	}

	public void Cook(IMeal meal)
	{
		meal.Cook();
	}
}
