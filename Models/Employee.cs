using CSharp.Interfaces;

namespace CSharp.Models;

public class Employee: Person, IPrintable
{
    public string? Department{get;set;}
    public Employee(string name, int age, string department)
    {
        Name = name;
        Age = age;
        Department = department;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Employee Info");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Department: {Department}");
    }
}