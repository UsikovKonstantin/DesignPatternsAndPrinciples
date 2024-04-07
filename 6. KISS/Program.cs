// KISS - Keep it simple, stupid (будь проще)

// Плохой код, излишние условия
double CalculateAreaBad(double length, double width)
{
	double area = (length > 0 && width > 0) ? length * width : 0;
	return area;
}

// Хороший код
double CalculateArea(double length, double width)
{
	return length * width;
}


// Плохой код, излишняя сложность
void PrintNumbersRecursively(int number)
{
	if (number >= 0)
	{
		PrintNumbersRecursively(number - 1);
		Console.WriteLine(number);
	}
}

// Хороший код
void PrintNumbersLoop(int number)
{
	for (int i = 0; i <= number; i++)
	{
		Console.WriteLine(i);
	}
}
