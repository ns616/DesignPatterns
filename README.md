# C# Design Patterns Reference

This repository is a comprehensive educational resource demonstrating all 21 classic Gang of Four (GoF) design patterns in C#. Each pattern is implemented in its own class library under the `Pattern` folder, with clear, real-world examples, documentation, and logging for learning and quick reference.

## Pattern README Quick Links

- [Adapter](Pattern/Adapter/README.md)
- [Bridge](Pattern/Bridge/README.md)
- [Builder](Pattern/Builder/README.md)
- [Chain of Responsibility](Pattern/ChainOfResponsibility/README.md)
- [Command](Pattern/Command/README.md)
- [Composite](Pattern/Composite/README.md)
- [Decorator](Pattern/Decorator/README.md)
- [Facade](Pattern/Facade/README.md)
- [Factory](Pattern/Factory/README.md)
- [Flyweight](Pattern/Flyweight/README.md)
- [Interpreter](Pattern/Interpreter/README.md)
- [Mediator](Pattern/Mediator/README.md)
- [Memento](Pattern/Memento/README.md)
- [Observer](Pattern/Observer/README.md)
- [Prototype](Pattern/Prototype/README.md)
- [Proxy](Pattern/Proxy/README.md)
- [Singleton](Pattern/Singleton/README.md)
- [State](Pattern/State/README.md)
- [Strategy](Pattern/Strategy/README.md)
- [Template Method](Pattern/TemplateMethod/README.md)
- [Unit of Work](Pattern/UnitOfWork/README.md)
- [Visitor](Pattern/Visitor/README.md)

## Structure

```
DesignPatterns/
├── Pattern/           # All 21 design pattern libraries (one per folder)
│   ├── Adapter/
│   ├── Bridge/
│   ├── ...
├── Service/
│   └── Api/           # ASP.NET Core Web API exposing endpoints for each pattern
│       ├── Controllers/
│       ├── Api.csproj
│       └── Api.http   # Example HTTP requests for testing
├── README.md          # This file
```

## How It Works
- **Each pattern** is implemented in its own library under `Pattern/`, with interfaces and classes in separate files and a comprehensive `README.md`.
- **The API** (`Service/Api`) exposes a controller and endpoint for each pattern, allowing you to execute and observe each pattern in action via HTTP requests.
- **Responses** from the API include both the result of the pattern execution and an `Info` object describing the pattern and the example.

## Getting Started

1. **Build the Solution**
   ```sh
   dotnet build Service/DesignPatternsDemo.sln
   ```
2. **Run the API**
   ```sh
   dotnet run --project Service/Api/Api.csproj
   ```
3. **Explore the API**
   - Open your browser to `https://localhost:5001/swagger` (or the port shown in the console) to view and interact with all pattern endpoints via Swagger UI.
   - Or use the provided `Api.http` file in `Service/Api` for sample requests.

## Example API Usage

- **Singleton Logger**
  - `GET /api/singleton/log?message=Hello`
- **Factory Notification**
  - `GET /api/factory/notify?type=email&message=Hello`
- **Strategy Payment**
  - `GET /api/strategy/pay?method=creditcard&amount=100`
- **Observer News**
  - `GET /api/observer/news?headline=Breaking+News!`

Each endpoint returns a JSON response like:
```json
{
  "ResponseData": { /* result of the pattern */ },
  "Info": {
    "Pattern": "Singleton",
    "Description": "Logger is a singleton. Only one instance is used throughout the app.",
    "Example": "Logger.Instance.Log(message)"
  }
}
```

## Why This Project?
- **Quick reference** for all GoF patterns in C#
- **Educational**: Each pattern is explained with real-world context, code, and API demonstration
- **Extensible**: Add new patterns or examples easily

---

For details on each pattern, see the `README.md` inside each `Pattern/<PatternName>/` folder.
