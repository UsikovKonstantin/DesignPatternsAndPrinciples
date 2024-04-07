using _06._State.StateInterface;

namespace _06._State;

public class Water
{
    public IWaterState State { get; set; }

    public Water(IWaterState state)
    {
		State = state;
	}

    public void Frost()
    {
		State.Frost(this);
	}

    public void Heat()
    {
		State.Heat(this);
	}
}
