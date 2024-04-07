namespace _07._FluentBuilder;

public class User
{
	public string Name { get; set; } = string.Empty;
	public string Company { get; set; } = string.Empty;
	public int Age { get; set; }
	public bool IsMarried { get; set; }

	public static UserBuilder CreateBuilder()
	{
		return new UserBuilder();
	}

	public override string ToString()
	{
		return $"Name: {Name}, Company: {Company}, Age: {Age}, IsMarried: {IsMarried}";
	}
}
