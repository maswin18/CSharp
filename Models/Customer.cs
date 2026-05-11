using System.Configuration.Assemblies;
using CSharp.Interfaces;

namespace CSharp.Models;

public class Customer : Person, IPrintable
{
    public string? Email {get;set;}

    public Customer(string name, int age, string email)
    {
        Name = name;
        Age = age;
        Email = email;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Customer Info");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Email: {Email}");
    }
}