using CSharp.Models;

Employee employee = new Employee("Maswin", 42);

Console.WriteLine($"Name: {employee.Name}");
Console.WriteLine($"Age: {employee.Age}");

employee.Introduce();

Product product = new Product("Keyboard", 49.99m);

Console.WriteLine($"Name: {product.Name}");
Console.WriteLine($"Price: {product.Price}");