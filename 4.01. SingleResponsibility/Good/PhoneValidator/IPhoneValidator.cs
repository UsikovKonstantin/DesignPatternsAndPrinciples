namespace _4._01._SingleResponsibility.Good.PhoneValidator;

public interface IPhoneValidator
{
	bool IsValid(Phone phone);
	bool IsValidData(List<string?> data);
}
