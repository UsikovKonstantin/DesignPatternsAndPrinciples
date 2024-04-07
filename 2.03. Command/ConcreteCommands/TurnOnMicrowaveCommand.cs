using _03._Command.CommandInterface;
using _03._Command.Receiver;

namespace _03._Command.ConcreteCommands;

public class TurnOnMicrowaveCommand : ICommand
{
	public Microwave Microwave { get; private set; }
    public int Time { get; set; }

    public TurnOnMicrowaveCommand(Microwave microwave, int time)
	{
		Microwave = microwave;
		Time = time;
	}

	public void Execute()
	{
		Microwave.StartCooking(Time);
	}

	public void Undo()
	{
		Microwave.StopCooking();
	}
}
