Employee employee = new Employee("Maswin", 30);

Console.WriteLine($"Name: {employee.Name}");
Console.WriteLine($"Age: {employee.Age}");
employee.Introduce();

Product product = new Product("Keyboard", 49.99f);

Console.WriteLine($"Product: {product.Name}");
Console.WriteLine($"Price: {product.Price}");

class Employee
{
    public string? Name { get; set; }

    public int Age { get; set; }

    public Employee(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Introduce()
    {
        Console.WriteLine($"Hello my name is {Name}");
    }
}

class Product
{
    public string? Name { get; set; }

    public float Price { get; set; }

    public Product(string name, float price)
    {
        Name = name;
        Price = price;
    }
}