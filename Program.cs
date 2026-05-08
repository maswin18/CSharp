Console.WriteLine("Enter your age:");
string? input = Console.ReadLine();

int age = Convert.ToInt32(input);

if (age >= 18)
{
    Console.WriteLine("adult");
}
else
{
    Console.WriteLine("Underage");
}
