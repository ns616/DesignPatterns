namespace Pattern.UnitOfWork
{
    /// <summary>
    /// Simple in-memory repository implementation.
    /// </summary>
    public class InMemoryRepository<T> : IRepository<T>
    {
        private readonly List<T> _data = new();
        public void Add(T entity) => _data.Add(entity);
        public void Remove(T entity) => _data.Remove(entity);
        public IEnumerable<T> GetAll() => _data;
    }
}
