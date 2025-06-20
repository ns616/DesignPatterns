# Factory Pattern

## What is the Factory Pattern?
The Factory Pattern is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created. It helps encapsulate the object creation logic, making the code more flexible and maintainable.

## Real-World Problem
Suppose you are building a notification system that can send notifications via different channels (Email, SMS, etc.). You want to allow the system to easily add new notification types in the future, without changing the code that uses the notifications.

## Solution with Factory Pattern
The Factory Pattern lets you define a `NotificationFactory` that creates notification objects based on a type. The client code only interacts with the factory and the notification interface, not the concrete classes.

## Example Code
```csharp
// Notification interface
public interface INotification {
    void Send(string message);
}

// Concrete notification types
public class EmailNotification : INotification {
    public void Send(string message) {
        Console.WriteLine($"[Email] {message}");
    }
}
public class SmsNotification : INotification {
    public void Send(string message) {
        Console.WriteLine($"[SMS] {message}");
    }
}

// Factory
public class NotificationFactory {
    public INotification CreateNotification(string type) {
        return type.ToLower() switch {
            "email" => new EmailNotification(),
            "sms" => new SmsNotification(),
            _ => throw new ArgumentException("Unknown notification type")
        };
    }
}

// Usage
var factory = new NotificationFactory();
var notification = factory.CreateNotification("email");
notification.Send("Hello, Factory Pattern!");
```

## How This Solves the Problem
- The client code does not need to know about the concrete notification classes.
- Adding a new notification type (e.g., PushNotification) only requires a new class and a small change in the factory.
- The code is open for extension but closed for modification (Open/Closed Principle).

## Summary
The Factory Pattern is ideal when you need to create objects without specifying the exact class of object that will be created. It is widely used in frameworks and libraries to provide flexibility and decoupling in object creation.
