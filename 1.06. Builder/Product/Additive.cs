namespace _06._Builder.Product;

public class Additive
{
    public string Name { get; set; } = string.Empty;
    public double Weight { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Weight: {Weight}";
    }
}
