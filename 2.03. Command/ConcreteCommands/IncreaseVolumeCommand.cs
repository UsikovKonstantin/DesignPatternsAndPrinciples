using _03._Command.CommandInterface;
using _03._Command.Receiver;

namespace _03._Command.ConcreteCommands;

public class IncreaseVolumeCommand : ICommand
{
	public TV TV { get; private set; }

	public IncreaseVolumeCommand(TV tv)
	{
		TV = tv;
	}

	public void Execute()
	{
        if (!TV.Working)
		{
            Console.WriteLine("Телевизор выключен");
        }
		else
		{
            Console.WriteLine("Увеличил громкость");
        }
    }

	public void Undo()
	{
		if (!TV.Working)
		{
			Console.WriteLine("Телевизор выключен");
		}
		else
		{
			Console.WriteLine("Уменьшил громкость");
		}
	}
}
