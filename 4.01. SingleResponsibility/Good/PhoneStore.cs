using _4._01._SingleResponsibility.Good.PhoneLogger;
using _4._01._SingleResponsibility.Good.PhoneReader;
using _4._01._SingleResponsibility.Good.PhoneValidator;

namespace _4._01._SingleResponsibility.Good;

public class PhoneStore
{
	private List<Phone> _phones;
	public IPhoneReader Reader { get; set; }
	public IPhoneValidator Validator { get; set; }
	public IPhoneLogger Logger { get; set; }

	public PhoneStore(IPhoneReader reader, IPhoneValidator validator, IPhoneLogger logger)
	{
		_phones = new List<Phone>();
		Reader = reader;
		Validator = validator;
		Logger = logger;
	}

	public void Process()
	{
		// Ввод данных.
		List<string?> data = Reader.GetInputData();

		// Валидация.
		if (!Validator.IsValidData(data))
			throw new Exception("Некорректные данные.");

		// Добавление телефона в список.
		Phone phone = new Phone(data[0] ?? "", double.Parse(data[1] ?? ""));
		_phones.Add(phone);

		// Логирование данных.
		Logger.LogPhone(phone);
	}
}
