# Flyweight Pattern

## What is the Flyweight Pattern?
The Flyweight Pattern is a structural design pattern that allows you to fit more objects into the available memory by sharing common parts of state between multiple objects, instead of keeping all data in each object.

## Real-World Problem
Suppose you are building a forest simulation with thousands of trees. Many trees share the same type (e.g., Oak, Pine), but have different positions. You want to save memory by sharing the tree type data.

## Solution with Flyweight Pattern
The pattern lets you store shared data (tree type) in flyweight objects and use them for many tree instances with different extrinsic data (position).

## Example Code
```csharp
// Flyweight interface
public interface ITreeType {
    void Display(int x, int y);
}

// Concrete flyweight
public class TreeType : ITreeType {
    private readonly string _name;
    public TreeType(string name) { _name = name; }
    public void Display(int x, int y) {
        Console.WriteLine($"Displaying {_name} tree at ({x},{y})");
    }
}

// Flyweight factory
public class TreeFactory {
    private readonly Dictionary<string, ITreeType> _types = new();
    public ITreeType GetTreeType(string name) {
        if (!_types.ContainsKey(name))
            _types[name] = new TreeType(name);
        return _types[name];
    }
}

// Usage
var factory = new TreeFactory();
var oak = factory.GetTreeType("Oak");
oak.Display(1, 2);
```

## How This Solves the Problem
- Reduces memory usage by sharing common data.
- Allows efficient creation of many similar objects.
- Separates shared (intrinsic) and unique (extrinsic) state.

## Summary
The Flyweight Pattern is ideal for applications with large numbers of similar objects, such as text editors, simulations, or games.
