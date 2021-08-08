﻿using System;
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repositories;

namespace WiredBrainCoffee.StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new EmployeeRepository();
            employeeRepository.Add(new Employee{ FirstName = "Ahmed" });
            employeeRepository.Add(new Employee { FirstName = "Sayed" });
            employeeRepository.Add(new Employee { FirstName = "Sobhy" });
            employeeRepository.Save();
            Console.ReadLine();
        }
    }
}
