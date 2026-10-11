namespace Lab6OopGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create five new objects of the Employee class.
            var employeeOne = new Employee("ID01", "Johan", "Male", 25000);
            var employeeTwo = new Employee("ID02", "Anders", "Male", 30000);
            var employeeThree = new Employee("ID03", "Lina", "Femamle", 22000);
            var employeeFour = new Employee("ID04", "Niklas", "Male", 28000);
            var employeeFive = new Employee("ID05", "Gunilla", "Female", 27000);

            // Stack with the persons.
            var employees = new Stack<Employee>();
            employees.Push(employeeOne);
            employees.Push(employeeTwo);
            employees.Push(employeeThree);
            employees.Push(employeeFour);
            employees.Push(employeeFive);

            // Print all objects in the stack.
            foreach (Employee employee in employees)
            {
                employee.PrintInfo();
                Console.WriteLine($"\nEmployees left in the stack: {employees.Count}");
            }

            /* Remove and return objects with the Pop() method
             * A foreach loop can't be used here because removing
             * items from a collection while it's being iterated
             * throws an InvalidOperationException.
             */
            Console.WriteLine("------------------------------");
            Console.WriteLine("RETRIEVE USING POP() METHOD");
            Console.WriteLine($"\nFired employee: {employees.Pop().Name}\n" +
                              $"Employees left: {employees.Count}");
            Console.WriteLine($"\nFired employee: {employees.Pop().Name}\n" +
                              $"Employees left: {employees.Count}");
            Console.WriteLine($"\nFired employee: {employees.Pop().Name}\n" +
                              $"Employees left: {employees.Count}");
            Console.WriteLine($"\nFired employee: {employees.Pop().Name}\n" +
                              $"Employees left: {employees.Count}");
            Console.WriteLine($"\nFired employee: {employees.Pop().Name}\n" +
                              $"Employees left: {employees.Count}");

            // Add objects to stack again
            employees.Push(employeeOne);
            employees.Push(employeeTwo);
            employees.Push(employeeThree);
            employees.Push(employeeFour);
            employees.Push(employeeFive);

            // Return two objects with Peek() method
            Console.WriteLine("------------------------------");
            Console.WriteLine("RETRIEVE USING PEEK() METHOD");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"{employees.Peek().Name}");
                Console.WriteLine($"Employees left in the stack: {employees.Count}");
            }

            // Check if object nr. 3 exists in stack.
            Console.WriteLine("------------------------------");
            if (employees.Contains(employeeThree))
            {
                Console.WriteLine($"Employee three, {employeeThree.Name}, is in stack.");
            }
            else
            {
                Console.WriteLine("Employee three isn't in the stack.");
            }

        }
    }
}
