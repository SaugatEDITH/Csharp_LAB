using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeFilterExample
{
    // Step 1: Define the Employee class with relevant properties
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Step 2: Create a list of employees
            List<Employee> employees = new List<Employee>
            {
                new Employee { Name = "John Dahal", Salary = 25000, Address = "Kathmandu" },
                new Employee { Name = "Jane karki", Salary = 18000, Address = "Kathmandu" },
                new Employee { Name = "Taylor damai", Salary = 30000, Address = "Pokhara" },
                new Employee { Name = "Scarlet Johnson", Salary = 22000, Address = "Kathmandu" }
            };

            // Step 3: Use LINQ to filter employees with Salary > 20000 and Address = "Kathmandu"
            var filteredEmployees = employees
                .Where(emp => emp.Salary > 20000 && emp.Address == "Kathmandu")
                .ToList();

            // Step 4: Display the filtered employees
            Console.WriteLine("Employees with Salary > 20000 and Address = Kathmandu:");
            foreach (var emp in filteredEmployees)
            {
                Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary}, Address: {emp.Address}");
            }
        }
    }
}
