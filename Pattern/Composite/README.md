# Composite Pattern

## What is the Composite Pattern?
The Composite Pattern is a structural design pattern that lets you compose objects into tree structures to represent part-whole hierarchies. It allows clients to treat individual objects and compositions of objects uniformly.

## Real-World Problem
Suppose you are building a file system where files and directories should be treated the same way. You want to be able to display, add, or remove files and directories using the same interface.

## Solution with Composite Pattern
The pattern lets you define a common interface for both files and directories. Directories can contain files or other directories, forming a tree structure.

## Example Code
```csharp
// Component interface
public interface IFileSystemItem {
    void Display(string indent = "");
}

// Leaf
public class File : IFileSystemItem {
    public string Name { get; }
    public File(string name) { Name = name; }
    public void Display(string indent = "") {
        Console.WriteLine($"{indent}- {Name}");
    }
}

// Composite
public class Directory : IFileSystemItem {
    public string Name { get; }
    private readonly List<IFileSystemItem> _children = new();
    public Directory(string name) { Name = name; }
    public void Add(IFileSystemItem item) { _children.Add(item); }
    public void Display(string indent = "") {
        Console.WriteLine($"{indent}+ {Name}");
        foreach (var child in _children)
            child.Display(indent + "  ");
    }
}

// Usage
var root = new Directory("root");
root.Add(new File("file1.txt"));
var subDir = new Directory("sub");
subDir.Add(new File("file2.txt"));
root.Add(subDir);
root.Display();
```

## How This Solves the Problem
- Treats files and directories uniformly.
- Supports recursive structures and operations.
- Makes it easy to add new types of components.

## Summary
The Composite Pattern is ideal for representing part-whole hierarchies, such as file systems, organization charts, or UI components.
