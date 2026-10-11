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
        }
    }
}
