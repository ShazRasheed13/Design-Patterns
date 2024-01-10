using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public interface IExpression
    {
        int Interpret(Dictionary<string,int> context);
    }

    // Abstract expression interface
    public class VariableExpression(string variable) : IExpression
    {
        public int Interpret(Dictionary<string, int> context)
        {
            return context[variable];
        }
    }

    // Terminal expression - Constant
    public class ConstantExpression(int value) : IExpression
    {
        public int Interpret(Dictionary<string, int> context)
        {
            return value;
        }
    }

    // Non-terminal expression - Addition
    public class AdditionExpression(IExpression left, IExpression right) : IExpression
    {
        public int Interpret(Dictionary<string, int> context)
        {
            return left.Interpret(context) + right.Interpret(context);
        }
    }

    // Non-terminal expression - Multiplication
    public class MultiplicationExpression(IExpression left, IExpression right) : IExpression
    {
        public int Interpret(Dictionary<string, int> context)
        {
            return left.Interpret(context) * right.Interpret(context);
        }
    }
}
