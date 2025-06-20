namespace Pattern.UnitOfWork
{
    /// <summary>
    /// Interface for a generic repository.
    /// </summary>
    public interface IRepository<T>
    {
        void Add(T entity);
        void Remove(T entity);
        IEnumerable<T> GetAll();
    }
}
