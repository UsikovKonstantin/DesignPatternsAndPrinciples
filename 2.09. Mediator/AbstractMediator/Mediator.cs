using _09._Mediator.AbstractColleague;

namespace _09._Mediator.AbstractMediator;

public abstract class Mediator
{
    public abstract void Send(string message, Colleague colleague);
}
