namespace _05._Proxy;

public class Page
{
    public int Number { get; private set; }
    public string Text { get; private set; }

    public Page(int number, string text)
    {
        Number = number;
        Text = text;
    }
}
