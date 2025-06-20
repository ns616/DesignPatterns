# Facade Pattern

## What is the Facade Pattern?
The Facade Pattern is a structural design pattern that provides a simplified interface to a complex subsystem. It hides the complexities of the system and provides an easy-to-use interface for the client.

## Real-World Problem
Suppose you are building a home theater system with multiple subsystems (audio, video, lights). You want users to be able to start and stop a movie with a single method call, without dealing with each subsystem individually.

## Solution with Facade Pattern
The pattern lets you create a `HomeTheaterFacade` that wraps the subsystems and exposes simple methods for common tasks.

## Example Code
```csharp
// Subsystems
public class AudioSystem {
    public void On() => Console.WriteLine("Audio system ON");
    public void Off() => Console.WriteLine("Audio system OFF");
}
public class VideoSystem {
    public void On() => Console.WriteLine("Video system ON");
    public void Off() => Console.WriteLine("Video system OFF");
}

// Facade
public class HomeTheaterFacade {
    private readonly AudioSystem _audio = new();
    private readonly VideoSystem _video = new();
    public void WatchMovie() {
        _audio.On();
        _video.On();
        Console.WriteLine("Movie started!");
    }
    public void EndMovie() {
        _audio.Off();
        _video.Off();
        Console.WriteLine("Movie ended!");
    }
}

// Usage
var theater = new HomeTheaterFacade();
theater.WatchMovie();
theater.EndMovie();
```

## How This Solves the Problem
- Simplifies the interface for the client.
- Hides subsystem complexity.
- Makes the code easier to use and maintain.

## Summary
The Facade Pattern is ideal for providing a simple interface to complex systems, such as libraries, frameworks, or multi-step processes.
