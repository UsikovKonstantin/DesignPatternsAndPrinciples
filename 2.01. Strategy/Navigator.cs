using _01._Strategy.Interface;

namespace _01._Strategy;

public class Navigator
{
    public double Distance { get; set; }
    public ITransport Transport { get; set; }

    public Navigator(double distance, ITransport transport)
    {
        Distance = distance;
        Transport = transport;
    }

    public void MakeRoute()
    {
        Transport.Move(Distance);
    }
}
