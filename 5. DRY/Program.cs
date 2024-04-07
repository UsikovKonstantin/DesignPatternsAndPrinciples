// DRY – Don’t repeat yourself (не повторяйтесь)

// Плохой код, есть повторяющиеся блоки, их нужно вынести в отдельную функцию.
void MakeTeaBad(string type, bool withSugar)
{
	Console.Write("Boil water. ");
	if (withSugar)
	{
		Console.Write("Add sugar. ");
	}
	Console.WriteLine($"Brew the {type} tea bag.");
}

void MakeCoffeeBad(bool withSugar)
{
	Console.Write("Boil water. ");
	if (withSugar)
	{
		Console.Write("Add sugar. ");
	}
	Console.WriteLine("Brew the coffee.");
}



// Хороший код, повторений нет.
void BoilWaterAndAddSugar(bool withSugar)
{
	Console.Write("Boil water. ");
	if (withSugar)
	{
		Console.Write("Add sugar. ");
	}
}

void MakeTea(string type, bool withSugar)
{
	BoilWaterAndAddSugar(withSugar);
	Console.WriteLine($"Brew the {type} tea bag.");
}

void MakeCoffee(bool withSugar)
{
	BoilWaterAndAddSugar(withSugar);
	Console.WriteLine("Brew the coffee.");
}
