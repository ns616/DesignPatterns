# Chain of Responsibility Pattern

## What is the Chain of Responsibility Pattern?
The Chain of Responsibility Pattern is a behavioral design pattern that lets you pass requests along a chain of handlers. Each handler decides either to process the request or to pass it to the next handler in the chain.

## Real-World Problem
Suppose you are building a customer support system where requests can be handled by different departments (email support, phone support, etc.). You want each handler to process only the requests it is responsible for, and pass others along the chain.

## Solution with Chain of Responsibility Pattern
The pattern lets you create a chain of handler objects. Each handler checks if it can process the request; if not, it passes it to the next handler.

## Example Code
```csharp
// Handler interface
public interface IHandler {
    IHandler SetNext(IHandler handler);
    string Handle(string request);
}

// Base handler
public abstract class Handler : IHandler {
    private IHandler _nextHandler;
    public IHandler SetNext(IHandler handler) {
        _nextHandler = handler;
        return handler;
    }
    public virtual string Handle(string request) {
        return _nextHandler?.Handle(request);
    }
}

// Concrete handlers
public class EmailHandler : Handler {
    public override string Handle(string request) {
        if (request.Contains("email"))
            return "Handled by Email Support";
        return base.Handle(request);
    }
}
public class PhoneHandler : Handler {
    public override string Handle(string request) {
        if (request.Contains("phone"))
            return "Handled by Phone Support";
        return base.Handle(request);
    }
}

// Usage
var email = new EmailHandler();
var phone = new PhoneHandler();
email.SetNext(phone);
string result = email.Handle("phone support needed");
Console.WriteLine(result);
```

## How This Solves the Problem
- Each handler processes only the requests it is responsible for.
- Requests are passed along the chain until handled.
- New handlers can be added easily without changing existing code.

## Summary
The Chain of Responsibility Pattern is ideal for processing requests by multiple handlers in a flexible and decoupled way.
