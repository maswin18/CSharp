using System.Text.Json;
using System.Text.Json.Serialization;
using CSharp.Models;

/*
Employee employee = new Employee(
    "Maswin",
    30,
    "IT"
);

string json = JsonSerializer.Serialize(employee);

File.WriteAllText("employee.json", json);

Console.WriteLine("File saved");
*/

string json = File.ReadAllText("employee.json");

Employee? employee = JsonSerializer.Deserialize<Employee>(json);

Console.WriteLine(employee?.Name);
Console.WriteLine(employee?.Department);