namespace _4._01._SingleResponsibility.Good.PhoneReader;

public class ConsolePhoneReader : IPhoneReader
{
	public List<string?> GetInputData()
	{
		Console.WriteLine("Введите модель:");
		string? model = Console.ReadLine();
		Console.WriteLine("Введите цену:");
		string? priceStr = Console.ReadLine();
		return new List<string?> { model, priceStr };
	}
}
