using _03._Command.CommandInterface;
using _03._Command.ConcreteCommands;
using _03._Command.Invoker;
using _03._Command.Receiver;

// Команда (Command)

/*
Паттерн "Команда" (Command) позволяет инкапсулировать запрос на выполнение определенного действия 
	в виде отдельного объекта. Этот объект запроса на действие и называется командой. При этом объекты, 
	инициирующие запросы на выполнение действия, отделяются от объектов, которые выполняют это действие.
	Команды могут использовать параметры, которые передают ассоциированную с командой информацию. 

Когда использовать команды?
	Когда надо передавать в качестве параметров определенные действия, вызываемые в ответ на другие действия. 
		То есть когда необходимы функции обратного действия в ответ на определенные действия.
	Когда необходимо обеспечить выполнение очереди запросов, а также их возможную отмену.
*/


// Invoker - инициатор (кто вызывает команды)
Pult pult = new Pult();

// Receiver - получатель (кто выполняет команды)
TV tv = new TV();
Microwave microwave = new Microwave();

// Команды
pult.SetCommand(1, new TurnOnTVCommand(tv));
pult.SetCommand(2, new IncreaseVolumeCommand(tv));
pult.SetCommand(3, new TurnOnMicrowaveCommand(microwave, 100));
List<ICommand> commands = new List<ICommand> { new TurnOnTVCommand(tv), new IncreaseVolumeCommand(tv), new IncreaseVolumeCommand(tv) };
pult.SetCommand(4, new MacroCommand(commands));

// Выполнение команд
pult.ExecuteCommand(1);
pult.ExecuteCommand(2);
pult.ExecuteCommand(2);

pult.UndoCommand();
pult.UndoCommand();
pult.UndoCommand();
Console.WriteLine();

pult.ExecuteCommand(3);
pult.UndoCommand();
Console.WriteLine();

pult.ExecuteCommand(4);
pult.UndoCommand();
