namespace _03._Command.Receiver;

public class TV
{
	public bool Working { get; private set; } = false;

    public void TurnOn()
	{
		if (Working)
		{
			Console.WriteLine("Телевизор уже работает");
		}
		else
		{
			Working = true;
			Console.WriteLine("Телевизор включился");
		}
    }

	public void TurnOff()
	{
		if (!Working)
		{
			Console.WriteLine("Телевизор уже выключен");
		}
		else
		{
			Working = false;
			Console.WriteLine("Телевизор выключился");
		}
	}
}
