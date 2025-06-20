# Memento Pattern

## What is the Memento Pattern?
The Memento Pattern is a behavioral design pattern that lets you capture and externalize an object's internal state so that the object can be restored to this state later, without violating encapsulation.

## Real-World Problem
Suppose you are building a text editor with undo functionality. You want to save the state of the document at various points and restore it when the user clicks undo.

## Solution with Memento Pattern
The pattern lets you create a `Memento` object to store the state, an `Originator` to create and restore mementos, and a `Caretaker` to manage the history.

## Example Code
```csharp
// Memento
public class Memento {
    public string State { get; }
    public Memento(string state) { State = state; }
}

// Originator
public class Originator {
    public string State { get; set; }
    public Memento Save() => new Memento(State);
    public void Restore(Memento memento) => State = memento.State;
}

// Caretaker
public class Caretaker {
    private readonly List<Memento> _history = new();
    public void AddMemento(Memento memento) => _history.Add(memento);
    public Memento GetMemento(int index) => _history[index];
}

// Usage
var originator = new Originator { State = "A" };
var caretaker = new Caretaker();
caretaker.AddMemento(originator.Save());
originator.State = "B";
originator.Restore(caretaker.GetMemento(0));
```

## How This Solves the Problem
- Allows undo/redo functionality.
- Preserves encapsulation of object state.
- Makes it easy to manage state history.

## Summary
The Memento Pattern is ideal for implementing undo/redo, checkpoints, or state rollback features.
