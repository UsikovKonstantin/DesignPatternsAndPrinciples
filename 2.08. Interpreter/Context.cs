namespace _08._Interpreter;

public class Context
{
    private Dictionary<string, double> _variables = new Dictionary<string, double>();

    public Context()
    {
        
    }

    public void SetVariable(string name, double value)
    {
        _variables[name] = value;
    }

	public void DeleteVariable(string name)
	{
        _variables.Remove(name);
	}

	public double GetVariableValue(string name)
	{
        return _variables[name];
	}
}
