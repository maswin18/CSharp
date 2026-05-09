namespace CSharp.Models;

public class Customer : Person
{
    public string? Email {get;set;}

    public Customer(string name, int age, string email)
    {
        Name = name;
        Age = age;
        Email = email;  
    }
}