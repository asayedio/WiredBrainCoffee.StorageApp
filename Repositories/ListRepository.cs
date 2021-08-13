using System.Collections.Generic;
using System.Linq;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class ListRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly List<T> _itmes = new();
        public void Add(T item)
        {
            if (item != null)
            {
                item.Id = _itmes.Any()? _itmes.Max(item=> item.Id) + 1 : 1;
                _itmes.Add(item);
            }
                
        }
        public T GetById(int Id)
        {
            return _itmes.Single(item => item.Id == Id);
        }
        public void Remove(T item)
        {
            if (item != null)
                _itmes.Remove(item);
        }
        public void Save()
        {
            foreach (var item in _itmes)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
