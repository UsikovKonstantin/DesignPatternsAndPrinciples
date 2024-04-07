namespace _4._01._SingleResponsibility.Good.PhoneLogger;

public class ConsolePhoneLogger : IPhoneLogger
{
	public void LogPhone(Phone phone)
	{
		Console.WriteLine($"{phone.Model}, {phone.Price}");
	}
}
