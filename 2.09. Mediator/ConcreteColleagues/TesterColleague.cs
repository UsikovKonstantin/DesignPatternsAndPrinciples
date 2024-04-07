using _09._Mediator.AbstractColleague;
using _09._Mediator.AbstractMediator;

namespace _09._Mediator.ConcreteColleagues;

public class TesterColleague : Colleague
{
    public TesterColleague(Mediator mediator) : base(mediator)
    {
        
    }

    public override void Notify(string message)
	{
		Console.WriteLine($"Тестировщик получил сообщение: \"{message}\"");
	}
}
