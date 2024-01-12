// Interpreter Pattern:
// Given a language, define a representation for its grammar along with an interpreter
// that uses the representation to interpret sentences in the language.
// Example in .NET:
// Consider a simple arithmetic expression interpreter.

// Context
using System.Data;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

public class Context
{
    public Dictionary<string, int> Variables { get; } = new Dictionary<string, int>();
}

// Abstract Expression
public interface IExpression
{
    int Interpret(Context context);
}

// Terminal Expression
public class VariableExpression : IExpression
{
    private readonly string _variableName;

    public VariableExpression(string variableName)
    {
        _variableName = variableName;
    }

    public int Interpret(Context context)
    {
        return context.Variables.TryGetValue(_variableName, out var value) ? value : 0;
    }
}

// Nonterminal Expression
public class AddExpression : IExpression
{
    private readonly IExpression _left;
    private readonly IExpression _right;

    public AddExpression(IExpression left, IExpression right)
    {
        _left = left;
        _right = right;
    }

    public int Interpret(Context context)
    {
        return _left.Interpret(context) + _right.Interpret(context);
    }
}

// Real - life Use Case: Regular Expression Parsing and Matching
// =============================================================
// Regular expressions(regex) are a powerful tool for pattern matching in strings. The Interpreter pattern
// can be applied to create a simple regex interpreter that can parse and match patterns in a string.
// In .NET, regular expressions are already implemented as part of the framework using the System.Text.RegularExpressions
// namespace. However, for the sake of illustration, let's create a simplified example of a basic regex interpreter:

// Context
public class RegexContext
{
    public string Input { get; }

    public RegexContext(string input)
    {
        Input = input;
    }
}

// Abstract Expression
public interface IRegexExpression
{
    bool Interpret(RegexContext context);
}

// Terminal Expressions
public class LiteralExpression : IRegexExpression
{
    private readonly string _literal;

    public LiteralExpression(string literal)
    {
        _literal = literal;
    }

    public bool Interpret(RegexContext context)
    {
        return context.Input.Contains(_literal);
    }
}

public class WildcardExpression : IRegexExpression
{
    public bool Interpret(RegexContext context)
    {
        // Assuming '*' represents any character
        return true;
    }
}

// Non-terminal Expression
public class AndExpression : IRegexExpression
{
    private readonly IRegexExpression _expression1;
    private readonly IRegexExpression _expression2;

    public AndExpression(IRegexExpression expression1, IRegexExpression expression2)
    {
        _expression1 = expression1;
        _expression2 = expression2;
    }

    public bool Interpret(RegexContext context)
    {
        return _expression1.Interpret(context) && _expression2.Interpret(context);
    }
}

// Client
public class RegexInterpreter
{
    private readonly IRegexExpression _expression;

    public RegexInterpreter(IRegexExpression expression)
    {
        _expression = expression;
    }

    public bool Match(string input)
    {
        var context = new RegexContext(input);
        return _expression.Interpret(context);
    }
}