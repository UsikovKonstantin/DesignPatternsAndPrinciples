using _08._Interpreter.ExpressionInterface;

namespace _08._Interpreter.ConcreteExpressions;

public class ConstantExpression : IExpression
{
	private readonly double _constant;

    public ConstantExpression(double constant)
    {
        _constant = constant;
    }

    public double Evaluate(Context context)
	{
		return _constant;
	}
}
