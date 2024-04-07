using _09._Mediator.AbstractColleague;
using _09._Mediator.AbstractMediator;

namespace _09._Mediator.ConcreteColleagues;

public class ProgrammerColleague : Colleague
{
    public ProgrammerColleague(Mediator mediator) : base(mediator)
    {
        
    }

    public override void Notify(string message)
	{
		Console.WriteLine($"Программист получил сообщение: \"{message}\"");
	}
}
