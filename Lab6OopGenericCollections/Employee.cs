using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6OopGenericCollections
{
    internal class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }

        // Constructor
        public Employee(string id, string name, string gender, decimal salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

        // Print information method
        public void PrintInfo()
        {
            Console.WriteLine($"\nEMPLOYEE INFORMATION:");
            Console.WriteLine($"ID: {Id}\n" +
                              $"Name: {Name}\n" +
                              $"Gender: {Gender}\n" +
                              $"Salary: {Salary}");
        }

        /* Method that returns true if employee is male.
         * It takes an Employee and returns a bool, so it matches
         * Predicate<Employee>, meaning it can be used as a parameter
         * in the methods Find() and FindAll() on employeeList.
         */
        public static bool IsMale(Employee employee)
        {
            return employee.Gender == "Male";
        }

    }
}
