using System.Collections.Generic;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public interface IRepository<T> where T : IEntity
    {
        void Add(T item);
        IEnumerable<T> GetAll();
        T GetById(int Id);
        void Remove(T item);
        void Save();
    }
}