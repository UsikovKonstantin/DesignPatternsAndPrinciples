using _09._Mediator.AbstractMediator;

namespace _09._Mediator.AbstractColleague;

public abstract class Colleague
{
    public Mediator Mediator { get; protected set; }

    public Colleague(Mediator mediator)
    {
        Mediator = mediator;
    }

    public virtual void Send(string message)
    {
        Mediator.Send(message, this);
    }

    public abstract void Notify(string message);
}
