namespace _06._Builder.Product;

public class Flour
{
    public string Sort { get; set; } = string.Empty;
    public double Weight { get; set; }

    public override string ToString()
    {
        return $"Sort: {Sort}, Weight: {Weight}";
    }
}
