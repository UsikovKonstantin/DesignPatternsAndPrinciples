namespace _06._Builder.Product;

public class Bread
{
    public Flour? Flour { get; set; }
    public Salt? Salt { get; set; }
    public List<Additive>? Additives { get; set; }

    public override string ToString()
    {
        string res = "";
        if (Flour != null)
            res += $"Flour: {Flour}\n";
        if (Salt != null)
            res += $"Salt: {Salt}\n";
        if (Additives != null && Additives.Count != 0)
        {
            res += $"Additives:\n";
            foreach (Additive additive in Additives)
                res += $"{additive}\n";
        }
        return res;
    }
}
