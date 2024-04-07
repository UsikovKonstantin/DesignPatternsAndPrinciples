using _03._Command.CommandInterface;
using _03._Command.Receiver;

namespace _03._Command.ConcreteCommands;

public class TurnOnTVCommand : ICommand
{
    public TV TV { get; private set; }

    public TurnOnTVCommand(TV tv)
    {
        TV = tv;
    }

	public void Execute()
	{
		TV.TurnOn();
	}

	public void Undo()
	{
		TV.TurnOff();
	}
}
