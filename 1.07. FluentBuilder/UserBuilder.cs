namespace _07._FluentBuilder;

public class UserBuilder
{
	private User _user = new User();

	public UserBuilder SetName(string name)
	{
		_user.Name = name;
		return this;
	}

	public UserBuilder SetCompany(string company)
	{
		_user.Company = company;
		return this;
	}

	public UserBuilder SetAge(int age)
	{
		_user.Age = age > 0 ? age : 18;
		return this;
	}

	public UserBuilder SetIsMarried(bool isMarried)
	{
		_user.IsMarried = isMarried;
		return this;
	}

	public User Build()
	{
		return _user;
	}

	public static implicit operator User(UserBuilder builder)
	{
		return builder._user;
	}
}
