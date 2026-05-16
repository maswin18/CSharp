using CSharp.Models;

List<Employee> employees = new List<Employee>()
{
    new Employee("Maswin", 30, "IT"),
    new Employee("John", 40, "HR"),
    new Employee("Sarah", 25, "IT"),
    new Employee("Michael", 35, "Finance")
};

/*List<Employee> itEmployees = employees
    .Where(employee => employee.Department == "IT")
    .ToList();

foreach(Employee employee in itEmployees)
{
    Console.WriteLine(employee.Name);
}


List<Employee> orderEmployees = employees
    .OrderBy(employee => employee.Age)
    .ToList();

foreach (Employee employee in orderEmployees)
{
    Console.WriteLine($"{employee.Name} - {employee.Age}");
}


List<string?> names = employees
    .Select(employee => employee.Name)
    .ToList();

foreach (string? name in names)
{
    Console.WriteLine(name);
}

*/

Employee? employee = employees
    .FirstOrDefault(employee => employee.Name == "Sarah");

if (employee != null)
{
    Console.WriteLine(employee.Name);
    Console.WriteLine(employee.Department);
}