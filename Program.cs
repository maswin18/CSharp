using CSharp.Models;

Employee employee = new Employee("Maswin", 42, "IT");

Console.WriteLine($"Employee: {employee.Name}");
Console.WriteLine($"Department: {employee.Department}");

employee.Introduce();

Console.WriteLine();

Customer customer = new Customer("John", 40, "john@email.com");

Console.WriteLine($"Customer: {customer.Name}");
Console.WriteLine($"Email: {customer.Email}");

