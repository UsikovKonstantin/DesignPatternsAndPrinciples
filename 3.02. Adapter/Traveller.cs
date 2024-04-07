using _02._Adapter.Target;

namespace _02._Adapter;

public class Traveller
{
    public ITransport Transport { get; set; }

    public Traveller(ITransport transport)
    {
        Transport = transport;
    }

    public void Travel()
    {
        Transport.Drive();
    }
}
