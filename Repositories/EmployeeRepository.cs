using System.Collections.Generic;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class EmployeeRepository
    {
        private List<Employee> _employees = new();
        public void Add(Employee employee)
        {
            if (employee != null)
                _employees.Add(employee);
        }

        public void Save()
        {
            foreach (var employee in _employees)
            {
                System.Console.WriteLine(employee);
            }
        }
    }
}
