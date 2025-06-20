# Proxy Pattern

## What is the Proxy Pattern?
The Proxy Pattern is a structural design pattern that provides a surrogate or placeholder for another object to control access to it. It is useful for lazy loading, access control, logging, and more.

## Real-World Problem
Suppose you are building an image viewer that loads large images from disk. You want to delay loading the image until it is actually needed (displayed), to save memory and improve performance.

## Solution with Proxy Pattern
The pattern lets you create a `ProxyImage` that loads the real image only when needed, and otherwise acts as a stand-in.

## Example Code
```csharp
// Subject interface
public interface IImage {
    void Display();
}

// Real subject
public class RealImage : IImage {
    private readonly string _filename;
    public RealImage(string filename) {
        _filename = filename;
        Console.WriteLine($"Loading image: {_filename}");
    }
    public void Display() {
        Console.WriteLine($"Displaying image: {_filename}");
    }
}

// Proxy
public class ProxyImage : IImage {
    private RealImage _realImage;
    private readonly string _filename;
    public ProxyImage(string filename) {
        _filename = filename;
    }
    public void Display() {
        if (_realImage == null)
            _realImage = new RealImage(_filename);
        _realImage.Display();
    }
}

// Usage
IImage image = new ProxyImage("photo.jpg");
image.Display(); // Loads and displays
image.Display(); // Displays only
```

## How This Solves the Problem
- Controls access to the real object.
- Supports lazy loading and resource management.
- Can add extra functionality (logging, security) transparently.

## Summary
The Proxy Pattern is ideal for controlling access to expensive or sensitive resources, such as files, databases, or remote services.
