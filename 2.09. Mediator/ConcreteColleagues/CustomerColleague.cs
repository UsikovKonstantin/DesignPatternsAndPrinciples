using _09._Mediator.AbstractColleague;
using _09._Mediator.AbstractMediator;

namespace _09._Mediator.ConcreteColleagues;

public class CustomerColleague : Colleague
{
    public CustomerColleague(Mediator mediator) : base(mediator)
    {
        
    }

	public override void Notify(string message)
	{
		Console.WriteLine($"Заказчик получил сообщение: \"{message}\"");
	}
}
