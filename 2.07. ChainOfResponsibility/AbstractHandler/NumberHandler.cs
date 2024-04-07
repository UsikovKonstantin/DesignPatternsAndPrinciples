namespace _07._ChainOfResponsibility.AbstractHandler;

public abstract class NumberHandler
{
    public NumberHandler? NextHandler { get; set; }
    public abstract long Handle(long number);

    public NumberHandler(NumberHandler? nextHandler)
    {
        NextHandler = nextHandler;
    }
}
