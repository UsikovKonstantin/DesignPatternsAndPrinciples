namespace _4._01._SingleResponsibility.Good.PhoneLogger;

public class FilePhoneLogger : IPhoneLogger
{
    private string _fileName;

    public FilePhoneLogger(string fileName)
    {
        _fileName = fileName;
    }

    public void LogPhone(Phone phone)
	{
		using (StreamWriter writer = new StreamWriter(_fileName, true))
		{
			writer.WriteLine($"{phone.Model}, {phone.Price}");
		}
	}
}
