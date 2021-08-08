using System;
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repositories;

namespace WiredBrainCoffee.StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new GenericRepository<Employee>();
            employeeRepository.Add(new Employee{ FirstName = "Ahmed" });
            employeeRepository.Add(new Employee { FirstName = "Sayed" });
            employeeRepository.Add(new Employee { FirstName = "Sobhy" });
            employeeRepository.Save();

            var organizationRepository = new GenericRepository<Organization>();
            organizationRepository.Add(new Organization { Name = "GLC" });
            organizationRepository.Add(new Organization { Name = "CELEPTA" });
            organizationRepository.Add(new Organization { Name = "COCACOLA" });
            organizationRepository.Save();
            Console.ReadLine();
        }
    }
}
