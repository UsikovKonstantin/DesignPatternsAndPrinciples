namespace _01._SimpleFactory.AbstractCoffee;

public abstract class Coffee
{
    public string Name { get; set; }

    public Coffee(string name)
    {
        Name = name;
    }

    public void GrindCoffee()
    {
        Console.WriteLine("Перемалываем кофе");
    }

    public void MakeCoffee()
    {
        Console.WriteLine("Делаем кофе");
    }

    public void PourIntoCup()
    {
        Console.WriteLine("Наливаем в чашку");
    }
}
