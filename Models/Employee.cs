namespace CSharp.Models;

public class Employee : Person
{
    public string? Department {get;set;}
    public Employee(string name, int age, string department)
    {
        Name = name;
        Age = age;
        Department = department;
    }
}