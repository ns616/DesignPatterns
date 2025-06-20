# Visitor Pattern

## What is the Visitor Pattern?
The Visitor Pattern is a behavioral design pattern that lets you separate algorithms from the objects on which they operate. It allows you to add new operations to existing object structures without modifying them.

## Real-World Problem
Suppose you are building a shopping cart system with different item types (books, pens). You want to perform operations like displaying or calculating total price, but you don't want to modify the item classes every time you add a new operation.

## Solution with Visitor Pattern
The pattern lets you define a visitor interface with a visit method for each item type. Items accept visitors and let them perform operations.

## Example Code
```csharp
// Visitor interface
public interface IVisitor {
    void Visit(Book book);
    void Visit(Pen pen);
}

// Element interface
public interface IElement {
    void Accept(IVisitor visitor);
}

// Concrete elements
public class Book : IElement {
    public string Title { get; }
    public Book(string title) { Title = title; }
    public void Accept(IVisitor visitor) => visitor.Visit(this);
}
public class Pen : IElement {
    public string Color { get; }
    public Pen(string color) { Color = color; }
    public void Accept(IVisitor visitor) => visitor.Visit(this);
}

// Concrete visitor
public class DisplayVisitor : IVisitor {
    public void Visit(Book book) => Console.WriteLine($"Book: {book.Title}");
    public void Visit(Pen pen) => Console.WriteLine($"Pen: {pen.Color}");
}

// Usage
var book = new Book("Design Patterns");
var pen = new Pen("Blue");
var visitor = new DisplayVisitor();
book.Accept(visitor);
pen.Accept(visitor);
```

## How This Solves the Problem
- Adds new operations without modifying item classes.
- Supports double dispatch for type-specific logic.
- Makes it easy to extend functionality.

## Summary
The Visitor Pattern is ideal for operations on object structures, such as traversing trees, generating reports, or applying business rules.
