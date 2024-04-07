using _08._Interpreter.ExpressionInterface;

namespace _08._Interpreter.ConcreteExpressions;

public class AddExpression : IExpression
{
    private IExpression _leftExpression;
    private IExpression _rightExpression;

    public AddExpression(IExpression leftExpression, IExpression rightExpression)
    {
        _leftExpression = leftExpression;
        _rightExpression = rightExpression;
    }

    public double Evaluate(Context context)
    {
        return _leftExpression.Evaluate(context) + _rightExpression.Evaluate(context);
    }
}
