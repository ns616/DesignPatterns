# State Pattern

## What is the State Pattern?
The State Pattern is a behavioral design pattern that lets an object alter its behavior when its internal state changes. The object will appear to change its class.

## Real-World Problem
Suppose you are building a simple switch that can be ON or OFF. You want the switch to change its behavior (e.g., print a message) depending on its current state.

## Solution with State Pattern
The pattern lets you define state classes that encapsulate behavior for each state, and the context delegates state-specific behavior to the current state object.

## Example Code
```csharp
// State interface
public interface ISwitchState {
    void Handle(Switch sw);
}

// Context
public class Switch {
    private ISwitchState _state;
    public Switch(ISwitchState state) { _state = state; }
    public void SetState(ISwitchState state) { _state = state; }
    public void Press() { _state.Handle(this); }
}

// Concrete states
public class OnState : ISwitchState {
    public void Handle(Switch sw) {
        Console.WriteLine("Turning OFF");
        sw.SetState(new OffState());
    }
}
public class OffState : ISwitchState {
    public void Handle(Switch sw) {
        Console.WriteLine("Turning ON");
        sw.SetState(new OnState());
    }
}

// Usage
var sw = new Switch(new OffState());
sw.Press(); // Turning ON
sw.Press(); // Turning OFF
```

## How This Solves the Problem
- Encapsulates state-specific behavior in separate classes.
- Makes it easy to add new states or change behavior.
- Promotes the Open/Closed Principle.

## Summary
The State Pattern is ideal for objects that need to change behavior based on their state, such as UI controls, workflow engines, or game characters.
