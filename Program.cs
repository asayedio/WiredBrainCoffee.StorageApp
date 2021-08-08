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
            AddEmployees(employeeRepository);
            GetEmployeeById(employeeRepository);

            var organizationRepository = new GenericRepository<Organization>();
            AddOrganizations(organizationRepository);
            Console.ReadLine();
        }

        private static void GetEmployeeById(GenericRepository<Employee> employeeRepository)
        {
            var employee = employeeRepository.GetById(2);
            Console.WriteLine($"The employee Id: {employee.Id} & first name is: {employee.FirstName}");
        }

        private static void AddEmployees(GenericRepository<Employee> employeeRepository)
        {
            employeeRepository.Add(new Employee { FirstName = "Ahmed" });
            employeeRepository.Add(new Employee { FirstName = "Sayed" });
            employeeRepository.Add(new Employee { FirstName = "Sobhy" });
            employeeRepository.Save();
        }
        private static void AddOrganizations(GenericRepository<Organization> organizationRepository)
        {
            organizationRepository.Add(new Organization { Name = "GLC" });
            organizationRepository.Add(new Organization { Name = "CELEPTA" });
            organizationRepository.Add(new Organization { Name = "COCACOLA" });
            organizationRepository.Save();
        }
    }
}
