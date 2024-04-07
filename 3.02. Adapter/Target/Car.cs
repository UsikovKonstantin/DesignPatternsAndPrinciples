namespace _02._Adapter.Target;

public class Car : ITransport
{
	public void Drive()
	{
        Console.WriteLine("Машина едет по дороге");
    }
}
