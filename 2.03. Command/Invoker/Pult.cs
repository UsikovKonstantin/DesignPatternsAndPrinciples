using _03._Command.CommandInterface;

namespace _03._Command.Invoker;

public class Pult
{
    public Stack<ICommand> CommandsHistory { get; private set; } = new Stack<ICommand>();
    public Dictionary<int, ICommand> Commands { get; set; } = new Dictionary<int, ICommand>();

    public void SetCommand(int code, ICommand command)
    {
        Commands[code] = command;
	}

    public void ExecuteCommand(int code)
    {
        if (Commands.ContainsKey(code))
        {
			ICommand command = Commands[code];
			if (command != null)
			{
				command.Execute();
				CommandsHistory.Push(command);
			}
		}      
	}

	public void UndoCommand()
	{
        if (CommandsHistory.Count > 0) 
        {
            ICommand command = CommandsHistory.Pop();
			command.Undo();
		}
	}
}
