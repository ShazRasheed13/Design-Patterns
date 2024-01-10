using InterpreterPattern;

IExpression expression = new AdditionExpression(
    new VariableExpression("a"),
    new VariableExpression("b")
    );

expression = new MultiplicationExpression(
    expression,
    new ConstantExpression(2)
);

// Context with variable values
Dictionary<string, int> context = new Dictionary<string, int>
{
    { "a", 5 },
    { "b", 3 }
};

// Interpret and evaluate the expression
int result = expression.Interpret(context);

Console.WriteLine("Result: " + result);