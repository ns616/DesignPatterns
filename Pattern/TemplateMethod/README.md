# Template Method Pattern

## What is the Template Method Pattern?
The Template Method Pattern is a behavioral design pattern that defines the skeleton of an algorithm in a base class but lets subclasses override specific steps of the algorithm without changing its structure.

## Real-World Problem
Suppose you are building a beverage preparation system for a cafe. Both tea and coffee require similar steps (boil water, brew, pour, add condiments), but the details of brewing and condiments differ.

## Solution with Template Method Pattern
The pattern lets you define a base class with a template method for the algorithm, and subclasses override the variable steps.

## Example Code
```csharp
// Abstract class
public abstract class Beverage {
    public void PrepareRecipe() {
        BoilWater();
        Brew();
        PourInCup();
        AddCondiments();
    }
    protected abstract void Brew();
    protected abstract void AddCondiments();
    private void BoilWater() => Console.WriteLine("Boiling water");
    private void PourInCup() => Console.WriteLine("Pouring into cup");
}

// Concrete classes
public class Tea : Beverage {
    protected override void Brew() => Console.WriteLine("Steeping the tea");
    protected override void AddCondiments() => Console.WriteLine("Adding lemon");
}
public class Coffee : Beverage {
    protected override void Brew() => Console.WriteLine("Brewing the coffee grounds");
    protected override void AddCondiments() => Console.WriteLine("Adding sugar and milk");
}

// Usage
var tea = new Tea();
tea.PrepareRecipe();
```

## How This Solves the Problem
- Defines the overall algorithm structure in one place.
- Allows subclasses to customize specific steps.
- Promotes code reuse and consistency.

## Summary
The Template Method Pattern is ideal for algorithms with invariant steps and customizable details, such as data processing, UI rendering, or workflow engines.
