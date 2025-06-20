# Bridge Pattern

## What is the Bridge Pattern?
The Bridge Pattern is a structural design pattern that separates an abstraction from its implementation so that the two can vary independently. It is useful when both the abstractions and their implementations may change over time.

## Real-World Problem
Suppose you are building a drawing application that supports different shapes (like circles) and different rendering methods (vector or raster). You want to be able to add new shapes or new rendering methods without changing existing code.

## Solution with Bridge Pattern
The Bridge Pattern lets you define a `Shape` abstraction and a `IDrawingImplementation` interface. Concrete shapes and drawing implementations can be combined flexibly.

## Example Code
```csharp
// Implementor interface
public interface IDrawingImplementation {
    void DrawCircle(double x, double y, double radius);
}

// Concrete implementors
public class VectorDrawing : IDrawingImplementation {
    public void DrawCircle(double x, double y, double radius) {
        Console.WriteLine($"Drawing vector circle at ({x},{y}) with radius {radius}");
    }
}
public class RasterDrawing : IDrawingImplementation {
    public void DrawCircle(double x, double y, double radius) {
        Console.WriteLine($"Drawing raster circle at ({x},{y}) with radius {radius}");
    }
}

// Abstraction
public abstract class Shape {
    protected IDrawingImplementation _drawingImpl;
    protected Shape(IDrawingImplementation drawingImpl) { _drawingImpl = drawingImpl; }
    public abstract void Draw();
}

// Refined abstraction
public class Circle : Shape {
    private double _x, _y, _radius;
    public Circle(double x, double y, double radius, IDrawingImplementation drawingImpl)
        : base(drawingImpl) { _x = x; _y = y; _radius = radius; }
    public override void Draw() {
        _drawingImpl.DrawCircle(_x, _y, _radius);
    }
}

// Usage
var vector = new VectorDrawing();
var circle = new Circle(0, 0, 5, vector);
circle.Draw();
```

## How This Solves the Problem
- You can add new shapes or new drawing implementations independently.
- Reduces code duplication and increases flexibility.
- Promotes the Open/Closed Principle.

## Summary
The Bridge Pattern is ideal when you want to decouple abstractions from their implementations, especially when both may change independently.