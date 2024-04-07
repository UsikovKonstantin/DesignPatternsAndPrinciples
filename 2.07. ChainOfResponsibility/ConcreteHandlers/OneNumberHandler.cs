using _07._ChainOfResponsibility.AbstractHandler;

namespace _07._ChainOfResponsibility.ConcreteHandlers;

public class OneNumberHandler : NumberHandler
{
	public OneNumberHandler(NumberHandler? nextHandler = null) : base(nextHandler)
	{

	}

	public override long Handle(long number)
	{
		if (Math.Abs(number) == 1)
		{
			long result = 0;
			Console.WriteLine($"!!! OneNumberHandler обработал запрос с числом {number}. Результат: {result}.");
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
