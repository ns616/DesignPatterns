using System;
using System.Linq;

namespace Pattern.UnitOfWork
{
    /// <summary>
    /// Demonstrates usage of the Unit of Work pattern with a Customer repository.
    /// </summary>
    public static class UnitOfWorkExample
    {
        public static void Run()
        {
            var unitOfWork = new UnitOfWork();

            // Queue operations
            unitOfWork.Customers.Add(new Customer { Id = 1, Name = "Alice" });
            unitOfWork.Customers.Add(new Customer { Id = 2, Name = "Bob" });
            unitOfWork.Customers.Remove(new Customer { Id = 1, Name = "Alice" }); // Will not remove until commit

            Console.WriteLine("Before commit: " + string.Join(", ", unitOfWork.Customers.GetAll().Select(c => c.Name)));

            // Commit all changes
            unitOfWork.Commit();

            Console.WriteLine("After commit: " + string.Join(", ", unitOfWork.Customers.GetAll().Select(c => c.Name)));
        }
    }
}
