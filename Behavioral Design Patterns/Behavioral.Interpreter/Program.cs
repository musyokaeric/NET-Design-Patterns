// Interpreter Pattern:
// Given a language, define a representation for its grammar along with an interpreter
// that uses the representation to interpret sentences in the language.
// Example in .NET:
// Consider a simple arithmetic expression interpreter.

using System.Data;

// Example usage
var context = new Context();
context.Variables["x"] = 5;
context.Variables["y"] = 10;

var expression = new AddExpression(
    new VariableExpression("x"),
    new VariableExpression("y")
);

var result = expression.Interpret(context);
Console.WriteLine($"Result: {result}"); // Result: 15

// Real - life Use Case: Regular Expression Parsing and Matching
// =============================================================
// Regular expressions(regex) are a powerful tool for pattern matching in strings. The Interpreter pattern
// can be applied to create a simple regex interpreter that can parse and match patterns in a string.
// In .NET, regular expressions are already implemented as part of the framework using the System.Text.RegularExpressions
// namespace. However, for the sake of illustration, let's create a simplified example of a basic regex interpreter:


// Example usage
var literalExpression = new LiteralExpression("hello");
var wildcardExpression = new WildcardExpression();

var regex = new AndExpression(literalExpression, wildcardExpression);

var regexInterpreter = new RegexInterpreter(regex);

Console.WriteLine(regexInterpreter.Match("hello world"));  // Output: true
Console.WriteLine(regexInterpreter.Match("foo bar"));       // Output: false