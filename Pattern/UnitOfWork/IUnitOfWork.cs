namespace Pattern.UnitOfWork
{
    /// <summary>
    /// Unit of Work interface for managing repositories and transactions.
    /// </summary>
    public interface IUnitOfWork
    {
        IRepository<Customer> Customers { get; }
        void Commit();
    }
}
