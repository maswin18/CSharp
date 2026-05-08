Employee employee = new Employee("Maswin", 30);

Console.WriteLine($"Name: {employee.Name}");
Console.WriteLine($"Age: {employee.Age}");
employee.Introduce();

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