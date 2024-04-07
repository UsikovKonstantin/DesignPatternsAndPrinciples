namespace _4._02._OpenClosed.Bad;

public class Chef
{
	public string Name { get; private set; }

	public Chef(string name)
	{
		Name = name;
	}

	// Плохо - если добавится новый тип еды, нужно будет менять метод Cook.
	public void Cook(MealType mealType)
	{
		if (mealType == MealType.Potato)
		{
			Console.WriteLine("Помыть");
			Console.WriteLine("Почистить кожуру");
			Console.WriteLine("Поставить на огонь");
		}
		else if (mealType == MealType.Beef)
		{
			Console.WriteLine("Порезать на кусочки");
			Console.WriteLine("Добавить приправу");
			Console.WriteLine("Поставить в духовку");
		}
	}
}
