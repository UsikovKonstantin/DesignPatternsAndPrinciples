using _08._Interpreter.ExpressionInterface;

namespace _08._Interpreter.ConcreteExpressions;

public class VariableExpression : IExpression
{
    public string Name { get; private set; }

    public VariableExpression(string name)
    {
        Name = name;
    }

    public double Evaluate(Context context)
    {
        return context.GetVariableValue(Name);
    }
}
