using System.Collections.Generic;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class GenericRepository<T>
    {
        private readonly List<T> _itmes = new();
        public void Add(T item)
        {
            if (item != null)
                _itmes.Add(item);
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
