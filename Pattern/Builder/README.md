# Builder Pattern

## What is the Builder Pattern?
The Builder Pattern is a creational design pattern that lets you construct complex objects step by step. It separates the construction of a complex object from its representation, allowing the same construction process to create different representations.

## Real-World Problem
Suppose you want to create different types of meals (vegetarian, non-vegetarian, etc.) in a restaurant ordering system. Each meal consists of several parts (main, side, drink), and you want to build them in a flexible way.

## Solution with Builder Pattern
The Builder Pattern lets you define a `MealDirector` that constructs a meal using a `IMealBuilder`. Different builders can create different types of meals.

## Example Code
```csharp
// Product
public class Meal {
    public string Main { get; set; }
    public string Side { get; set; }
    public string Drink { get; set; }
    public override string ToString() => $"Main: {Main}, Side: {Side}, Drink: {Drink}";
}

// Builder interface
public interface IMealBuilder {
    void BuildMain();
    void BuildSide();
    void BuildDrink();
    Meal GetMeal();
}

// Concrete builder
public class VegMealBuilder : IMealBuilder {
    private Meal _meal = new Meal();
    public void BuildMain() => _meal.Main = "Veggie Burger";
    public void BuildSide() => _meal.Side = "Salad";
    public void BuildDrink() => _meal.Drink = "Juice";
    public Meal GetMeal() => _meal;
}

// Director
public class MealDirector {
    public Meal Construct(IMealBuilder builder) {
        builder.BuildMain();
        builder.BuildSide();
        builder.BuildDrink();
        return builder.GetMeal();
    }
}

// Usage
var builder = new VegMealBuilder();
var director = new MealDirector();
Meal meal = director.Construct(builder);
Console.WriteLine(meal);
```

## How This Solves the Problem
- Allows step-by-step construction of complex objects.
- Different builders can create different meal types using the same process.
- Makes the code flexible and easy to extend.

## Summary
The Builder Pattern is ideal for constructing complex objects with many optional parts or configurations.
