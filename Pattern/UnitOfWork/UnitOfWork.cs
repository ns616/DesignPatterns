using System;
using System.Collections.Generic;

namespace Pattern.UnitOfWork
{
    /// <summary>
    /// Concrete UnitOfWork implementation managing repositories and commit logic.
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly InMemoryRepository<Customer> _customerRepository = new();
        private readonly List<Action> _pendingActions = new();

        public IRepository<Customer> Customers => new UnitOfWorkRepositoryProxy<Customer>(_customerRepository, _pendingActions);

        /// <summary>
        /// Commits all pending actions as a single transaction.
        /// </summary>
        public void Commit()
        {
            foreach (var action in _pendingActions)
            {
                action();
            }
            _pendingActions.Clear();
        }
    }

    /// <summary>
    /// Proxy repository that queues actions for commit.
    /// </summary>
    public class UnitOfWorkRepositoryProxy<T> : IRepository<T>
    {
        private readonly InMemoryRepository<T> _innerRepository;
        private readonly List<Action> _pendingActions;

        public UnitOfWorkRepositoryProxy(InMemoryRepository<T> innerRepository, List<Action> pendingActions)
        {
            _innerRepository = innerRepository;
            _pendingActions = pendingActions;
        }

        public void Add(T entity)
        {
            _pendingActions.Add(() => _innerRepository.Add(entity));
        }

        public void Remove(T entity)
        {
            _pendingActions.Add(() => _innerRepository.Remove(entity));
        }

        public IEnumerable<T> GetAll()
        {
            return _innerRepository.GetAll();
        }
    }
}
