namespace _4._01._SingleResponsibility.Bad;

public class PhoneStore
{
	private List<Phone> _phones;

    public PhoneStore()
    {
		_phones = new List<Phone>();    
    }

    public void Process()
	{
		// Ввод данных (этим должен заниматься отдельный класс).
		Console.WriteLine("Введите модель:");
		string? model = Console.ReadLine();
		Console.WriteLine("Введите цену:");
		string? priceStr = Console.ReadLine();

		// Валидация (этим должен заниматься отдельный класс).
		bool parsingSucceeded = double.TryParse(priceStr, out double price);
		if (!parsingSucceeded || string.IsNullOrEmpty(model) || price <= 0)
			throw new Exception("Некорректные данные.");
		
		// Добавление телефона в список.
		_phones.Add(new Phone(model, price));

		// Логирование данных (этим должен заниматься отдельный класс).
		using (StreamWriter writer = new StreamWriter("store.txt", true))
		{
			writer.WriteLine($"{model}, {price}");
		}
	}
}
