# Command Pattern

## What is the Command Pattern?
The Command Pattern is a behavioral design pattern that turns a request into a stand-alone object that contains all information about the request. This allows you to parameterize methods with different requests, delay or queue a request's execution, and support undoable operations.

## Real-World Problem
Suppose you are building a remote control for a smart home. You want to be able to assign different actions (turn on/off lights, open/close doors) to buttons, and change these actions at runtime.

## Solution with Command Pattern
The pattern lets you encapsulate each action as a command object. The remote control (invoker) can execute any command without knowing the details of the action.

## Example Code
```csharp
// Command interface
public interface ICommand {
    void Execute();
}

// Receiver
public class Light {
    public void TurnOn() { Console.WriteLine("Light ON"); }
    public void TurnOff() { Console.WriteLine("Light OFF"); }
}

// Concrete commands
public class TurnOnCommand : ICommand {
    private readonly Light _light;
    public TurnOnCommand(Light light) { _light = light; }
    public void Execute() { _light.TurnOn(); }
}
public class TurnOffCommand : ICommand {
    private readonly Light _light;
    public TurnOffCommand(Light light) { _light = light; }
    public void Execute() { _light.TurnOff(); }
}

// Invoker
public class RemoteControl {
    private ICommand _command;
    public void SetCommand(ICommand command) { _command = command; }
    public void PressButton() { _command.Execute(); }
}

// Usage
var light = new Light();
var onCommand = new TurnOnCommand(light);
var remote = new RemoteControl();
remote.SetCommand(onCommand);
remote.PressButton();
```

## How This Solves the Problem
- Decouples the object that invokes the operation from the one that knows how to perform it.
- Supports undo, logging, and queuing of requests.
- Makes it easy to add new commands without changing existing code.

## Summary
The Command Pattern is ideal for parameterizing objects with operations, supporting undo/redo, and implementing transactional behavior.
