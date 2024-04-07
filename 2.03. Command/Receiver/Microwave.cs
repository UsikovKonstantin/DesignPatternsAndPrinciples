namespace _03._Command.Receiver;

public class Microwave
{
	public bool Working { get; private set; } = false;

	public void StartCooking(int time)
	{
		if (Working)
		{
			Console.WriteLine("Микроволновка уже работает");
		}
		else
		{
			Working = true;
			Console.WriteLine("Микроволновка включилась");
		}
	}

	public void StopCooking()
	{
		if (!Working)
		{
			Console.WriteLine("Микроволновка уже выключена");
		}
		else
		{
			Working = false;
			Console.WriteLine("Микроволновка выключилась");
		}
	}
}
