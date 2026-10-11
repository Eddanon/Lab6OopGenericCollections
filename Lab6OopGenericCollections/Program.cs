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
                Console.WriteLine($"Employee 3, {employeeThree.Name}, is in stack.");
            }
            else
            {
                Console.WriteLine("Employee 3 isn't in the stack.");
            }

            // List with employees
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(employeeOne);
            employeeList.Add(employeeTwo);
            employeeList.Add(employeeThree);
            employeeList.Add(employeeFour);
            employeeList.Add(employeeFive);

            // Check if the list contains employeeTwo
            if (employeeList.Contains(employeeTwo))
            {
                Console.WriteLine("Employee2 object exists in the list.");
            }
            else
            {
                Console.WriteLine("EEmployee2 object does not exist in the list.");
            }

            /* Find and return the first male employee
             * The Find() method expects to receive a lambda expression or method of the 
             * delegate type Predicate<T>, which is a method with the parameter of the
             * type T, and a bool return type.
             * Normally you would use a lambda expression
             * as the parameter of the Find() method.
             * We haven't learnt about lambda yet.
             * I put the method IsMale as a parameter - since it matches
             * the Predicate<Employee> type it works.
             * Find() returns the first for which IsMale returns true,
             * or null if there is none.
             */
            Employee firstMale = employeeList.Find(Employee.IsMale);
            Console.WriteLine($"First male employee: {firstMale.Name}");


        }
    }
}
