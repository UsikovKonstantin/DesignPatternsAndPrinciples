namespace _03._Command.CommandInterface;

public interface ICommand
{
    void Execute();
    void Undo();
}
