using _02._Adapter.Adaptee;
using _02._Adapter.Target;

namespace _02._Adapter.Adapter;

public class CamelTransport : ITransport
{
    private Camel _camel;

    public CamelTransport(Camel camel)
    {
        _camel = camel;
    }

    public void Drive()
	{
        _camel.Move();
	}
}
