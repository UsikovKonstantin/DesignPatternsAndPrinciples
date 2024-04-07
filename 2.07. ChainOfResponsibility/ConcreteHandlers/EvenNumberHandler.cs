using _07._ChainOfResponsibility.AbstractHandler;

namespace _07._ChainOfResponsibility.ConcreteHandlers;

public class EvenNumberHandler : NumberHandler
{
	public EvenNumberHandler(NumberHandler? nextHandler = null) : base(nextHandler)
	{

	}

	public override long Handle(long number)
	{
		if (number % 2 == 0)
		{
			long result = number / 2;
            Console.WriteLine($"EvenNumberHandler обработал запрос с числом {number}. Результат: {result}.");
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
