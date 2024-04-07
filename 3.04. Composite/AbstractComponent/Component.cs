namespace _04._Composite.AbstractComponent;

public abstract class Component
{
    public string Name { get; protected set; }
	public DateTime CreatedAt { get; protected set; }
	public DateTime ModifiedAt { get; protected set; }

    protected Component(string name)
    {
        Name = name;
        CreatedAt = DateTime.Now;
		ModifiedAt = DateTime.Now;
	}

	public virtual void Add(Component component) 
	{ 
	
	}

	public virtual void Remove(Component component) 
	{ 
	
	}

	public virtual string GetString(int offset = 0)
	{
		return new string(' ', offset) + $"Name: {Name}, " +
			$"CreatedAt: {CreatedAt}, " +
			$"ModifiedAt: {ModifiedAt}";
	}
}
