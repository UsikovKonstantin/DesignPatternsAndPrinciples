using _07._ChainOfResponsibility.AbstractHandler;

namespace _07._ChainOfResponsibility.ConcreteHandlers;

public class OddNumberHandler : NumberHandler
{
	public OddNumberHandler(NumberHandler? nextHandler = null) : base(nextHandler)
	{

	}

	public override long Handle(long number)
	{
		if (number % 2 != 0)
		{
			long result = 3 * number + 1;
			Console.WriteLine($"OddNumberHandler обработал запрос с числом {number}. Результат: {result}.");
			return result;
		}
		else
		{
			if (NextHandler == null)
			{
				return 0;
			}
			return NextHandler.Handle(number);
		}
	}
}
