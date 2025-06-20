# Mediator Pattern

## What is the Mediator Pattern?
The Mediator Pattern is a behavioral design pattern that defines an object (the mediator) that encapsulates how a set of objects interact. It promotes loose coupling by preventing objects from referring to each other explicitly.

## Real-World Problem
Suppose you are building a chat room where users can send messages to each other. You want to avoid direct references between users and centralize communication logic.

## Solution with Mediator Pattern
The pattern lets you define a `ChatRoom` mediator that handles message delivery between users.

## Example Code
```csharp
// Mediator interface
public interface IChatRoom {
    void ShowMessage(string user, string message);
}

// Concrete mediator
public class ChatRoom : IChatRoom {
    public void ShowMessage(string user, string message) {
        Console.WriteLine($"{user}: {message}");
    }
}

// Colleague
public class User {
    private readonly string _name;
    private readonly IChatRoom _chatRoom;
    public User(string name, IChatRoom chatRoom) {
        _name = name;
        _chatRoom = chatRoom;
    }
    public void Send(string message) {
        _chatRoom.ShowMessage(_name, message);
    }
}

// Usage
var chat = new ChatRoom();
var alice = new User("Alice", chat);
alice.Send("Hello!");
```

## How This Solves the Problem
- Centralizes communication logic.
- Reduces dependencies between objects.
- Makes the system easier to maintain and extend.

## Summary
The Mediator Pattern is ideal for coordinating communication between multiple objects, such as UI controls, chat rooms, or air traffic control systems.
