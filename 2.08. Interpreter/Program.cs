using _08._Interpreter;
using _08._Interpreter.ConcreteExpressions;
using _08._Interpreter.ExpressionInterface;

// Интерпретатор (Interpreter)

/*
Паттерн Интерпретатор (Interpreter) определяет представление грамматики для 
	заданного языка и интерпретатор предложений этого языка. Как правило, 
	данный шаблон проектирования применяется для часто повторяющихся операций.
*/

// (x + y) / (2 * z)
IExpression expression = 
	new DivideExpression(
		new AddExpression(
			new VariableExpression("x"), new VariableExpression("y")
		),
		new MultiplyExpression(
			new ConstantExpression(2), new VariableExpression("z")
		)
	);

Context context = new Context();
context.SetVariable("x", 3);
context.SetVariable("y", 6);
context.SetVariable("z", 1);

Console.WriteLine(expression.Evaluate(context));
