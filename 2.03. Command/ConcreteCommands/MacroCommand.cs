using _03._Command.CommandInterface;

namespace _03._Command.ConcreteCommands;

public class MacroCommand : ICommand
{
    public IEnumerable<ICommand> Commands { get; private set; }

    public MacroCommand(IEnumerable<ICommand> commands)
    {
        Commands = commands;
    }

    public void Execute()
	{
		foreach (ICommand command in Commands)
		{
			command?.Execute();
		}
	}

	public void Undo()
	{
		foreach (ICommand command in Commands)
		{
			command?.Undo();
		}
	}
}
