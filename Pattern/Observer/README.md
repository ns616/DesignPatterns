# Observer Pattern

## What is the Observer Pattern?
The Observer Pattern is a behavioral design pattern in which an object (the subject) maintains a list of its dependents (observers) and notifies them automatically of any state changes, usually by calling one of their methods.

## Real-World Problem
Suppose you are building a news agency system where multiple subscribers want to receive updates whenever news is published. You want to notify all subscribers automatically when new information is available.

## Solution with Observer Pattern
The Observer Pattern lets you define a `NewsAgency` (subject) that notifies all registered `NewsSubscriber` (observers) when news is published.

## Example Code
```csharp
// Observer interface
public interface ISubscriber {
    void Update(string news);
}

// Concrete observer
public class NewsSubscriber : ISubscriber {
    public string Name { get; }
    public List<string> ReceivedNews { get; } = new List<string>();
    public NewsSubscriber(string name) { Name = name; }
    public void Update(string news) {
        ReceivedNews.Add(news);
        Console.WriteLine($"{Name} received news: {news}");
    }
}

// Subject
public class NewsAgency {
    private readonly List<ISubscriber> _subscribers = new();
    public void Subscribe(ISubscriber subscriber) {
        _subscribers.Add(subscriber);
    }
    public void PublishNews(string news) {
        foreach (var sub in _subscribers) {
            sub.Update(news);
        }
    }
}

// Usage
var agency = new NewsAgency();
var alice = new NewsSubscriber("Alice");
agency.Subscribe(alice);
agency.PublishNews("Breaking News!");
```

## How This Solves the Problem
- Subscribers are automatically notified when news is published.
- New subscriber types can be added without changing the subject code.
- The system is decoupled and easy to extend.

## Summary
The Observer Pattern is ideal for event-driven systems, GUIs, or any scenario where multiple objects need to react to changes in another object.
