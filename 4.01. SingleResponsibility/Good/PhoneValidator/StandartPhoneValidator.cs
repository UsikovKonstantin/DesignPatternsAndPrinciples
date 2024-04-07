namespace _4._01._SingleResponsibility.Good.PhoneValidator;

public class StandartPhoneValidator : IPhoneValidator
{
	public bool IsValid(Phone phone)
	{
		return !string.IsNullOrEmpty(phone.Model) && phone.Price > 0;
	}

	public bool IsValidData(List<string?> data)
	{
		if (data.Count != 2)
			return false;

		bool parsingSucceeded = double.TryParse(data[1], out double price);
		if (!parsingSucceeded || string.IsNullOrEmpty(data[0]) || price <= 0)
			return false;

		return true;
	}
}
