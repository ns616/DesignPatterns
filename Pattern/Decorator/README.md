# Decorator Pattern

## What is the Decorator Pattern?
The Decorator Pattern is a structural design pattern that allows you to add new functionality to objects dynamically by placing them inside special wrapper objects, called decorators. This pattern is useful for adhering to the Open/Closed Principle.

## Real-World Problem
Suppose you are building a coffee shop ordering system. You want to allow customers to add extra ingredients (like milk, sugar, etc.) to their beverages, but you don't want to create a new class for every possible combination.

## Solution with Decorator Pattern
The pattern lets you create decorator classes that wrap a beverage and add new behavior (e.g., cost, description) without modifying the original class.

## Example Code
```csharp
// Component interface
public interface IBeverage {
    string GetDescription();
    double GetCost();
}

// Concrete component
public class Coffee : IBeverage {
    public string GetDescription() => "Coffee";
    public double GetCost() => 2.0;
}

// Decorator base class
public abstract class BeverageDecorator : IBeverage {
    protected IBeverage _beverage;
    protected BeverageDecorator(IBeverage beverage) { _beverage = beverage; }
    public abstract string GetDescription();
    public abstract double GetCost();
}

// Concrete decorator
public class MilkDecorator : BeverageDecorator {
    public MilkDecorator(IBeverage beverage) : base(beverage) { }
    public override string GetDescription() => _beverage.GetDescription() + ", Milk";
    public override double GetCost() => _beverage.GetCost() + 0.5;
}

// Usage
IBeverage coffee = new Coffee();
coffee = new MilkDecorator(coffee);
Console.WriteLine(coffee.GetDescription()); // Coffee, Milk
Console.WriteLine(coffee.GetCost()); // 2.5
```

## How This Solves the Problem
- Adds new features to objects at runtime without modifying their code.
- Avoids class explosion from many combinations.
- Promotes code reuse and flexibility.

## Summary
The Decorator Pattern is ideal for adding responsibilities to objects dynamically, such as UI components, beverages, or logging wrappers.
