# Interpreter Pattern

## What is the Interpreter Pattern?
The Interpreter Pattern is a behavioral design pattern that defines a representation for a grammar and an interpreter to interpret sentences in the language. It is useful for parsing and evaluating expressions.

## Real-World Problem
Suppose you are building a calculator that can evaluate simple arithmetic expressions like "x + y" where x and y are variables. You want to interpret these expressions at runtime.

## Solution with Interpreter Pattern
The pattern lets you define an abstract `Expression` class and concrete classes for variables and operations. The context provides variable values.

## Example Code
```csharp
// Abstract expression
public abstract class Expression {
    public abstract int Interpret(Dictionary<string, int> context);
}

// Terminal expression
public class VariableExpression : Expression {
    private readonly string _name;
    public VariableExpression(string name) { _name = name; }
    public override int Interpret(Dictionary<string, int> context) {
        return context[_name];
    }
}

// Non-terminal expression
public class AddExpression : Expression {
    private readonly Expression _left, _right;
    public AddExpression(Expression left, Expression right) {
        _left = left; _right = right;
    }
    public override int Interpret(Dictionary<string, int> context) {
        return _left.Interpret(context) + _right.Interpret(context);
    }
}

// Usage
var context = new Dictionary<string, int> { ["x"] = 2, ["y"] = 3 };
var expr = new AddExpression(new VariableExpression("x"), new VariableExpression("y"));
int result = expr.Interpret(context); // 5
```

## How This Solves the Problem
- Allows dynamic evaluation of expressions.
- Supports extensible grammars and operations.
- Separates parsing logic from evaluation logic.

## Summary
The Interpreter Pattern is ideal for implementing simple languages, expression evaluators, or configuration parsers.
