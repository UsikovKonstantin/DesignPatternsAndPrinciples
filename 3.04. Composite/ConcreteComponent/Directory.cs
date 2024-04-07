using _04._Composite.AbstractComponent;

namespace _04._Composite.ConcreteComponent;

public class Directory : Component
{
    public List<Component> Components { get; private set; } = new List<Component>();

    public Directory(string name) : base(name)
	{

	}

	public override void Add(Component component)
	{
		Components.Add(component);
		ModifiedAt = DateTime.Now;
	}

	public override void Remove(Component component)
	{
		Components.Remove(component);
	}

	public override string GetString(int offset = 0)
	{
		string res = base.GetString(offset) + "\n";
		foreach (Component component in Components)
		{
			res += component.GetString(offset + 4) + "\n";
		}
		return res;
	}
}
