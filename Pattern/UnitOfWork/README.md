# Unit of Work Pattern

## Definition
The Unit of Work pattern maintains a list of objects affected by a business transaction and coordinates the writing out of changes and the resolution of concurrency problems. It acts as a transaction boundary, ensuring that all operations within a unit are committed or rolled back together.

## Real-World Example
Imagine an e-commerce system where you need to add a new customer and place an order for them. You want both actions to succeed or fail as a single transaction. The Unit of Work pattern helps coordinate these changes, ensuring data consistency.

## Implementation
This example uses an in-memory repository and a simple `Customer` entity. The `UnitOfWork` class manages repositories and queues changes until `Commit()` is called.

### Key Classes
- `IRepository<T>`: Generic repository interface
- `InMemoryRepository<T>`: In-memory implementation of the repository
- `Customer`: Example entity
- `IUnitOfWork`: Interface for the Unit of Work
- `UnitOfWork`: Concrete implementation, manages repositories and commit logic

### Example Usage
```csharp
var unitOfWork = new UnitOfWork();

// Queue operations
unitOfWork.Customers.Add(new Customer { Id = 1, Name = "Alice" });
unitOfWork.Customers.Add(new Customer { Id = 2, Name = "Bob" });
unitOfWork.Customers.Remove(new Customer { Id = 1, Name = "Alice" }); // Will not remove until commit

Console.WriteLine("Before commit: " + string.Join(", ", unitOfWork.Customers.GetAll().Select(c => c.Name)));

// Commit all changes
unitOfWork.Commit();

Console.WriteLine("After commit: " + string.Join(", ", unitOfWork.Customers.GetAll().Select(c => c.Name)));
```

### Output
```
Before commit: 
After commit: Bob
```

## Logging and Comments
All classes and methods are documented for clarity. You can add logging to the `Commit()` method or repository actions for deeper insight during API integration.

## References
- [Martin Fowler: Unit of Work](https://martinfowler.com/eaaCatalog/unitOfWork.html)

---
For a full example, see `UnitOfWorkExample.cs` in this folder.
