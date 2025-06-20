# Singleton Pattern

## What is the Singleton Pattern?
The Singleton Pattern is a creational design pattern that ensures a class has only one instance and provides a global point of access to it. This is useful when exactly one object is needed to coordinate actions across the system.

## Real-World Problem
Imagine you need a single, shared logger in your application. If multiple logger instances are created, log messages could be lost or duplicated, and configuration could become inconsistent.

## Solution with Singleton Pattern
The Singleton Pattern restricts the instantiation of a class to one object and provides a static method to access that instance.

## Example Code
```csharp
public sealed class Logger {
    private static readonly Logger _instance = new Logger();
    private Logger() { }
    public static Logger Instance => _instance;
    public void Log(string message) {
        Console.WriteLine($"[Singleton Logger] {DateTime.Now}: {message}");
    }
}

// Usage
Logger.Instance.Log("Hello, Singleton!");
```

## How This Solves the Problem
- Guarantees a single, shared logger instance throughout the application.
- Centralizes logging configuration and output.
- Prevents accidental creation of multiple logger objects.

## Summary
The Singleton Pattern is ideal for shared resources like loggers, configuration managers, or connection pools, where only one instance should exist for the entire application lifecycle.
