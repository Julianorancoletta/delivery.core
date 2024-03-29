using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Delivery.Core.DomainObjects;

namespace Delivery.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
        Task<T> GetById(Guid id);
        void Add(T Item);
        void Update(T Item);
        void Delete(Guid Id);
    }
}