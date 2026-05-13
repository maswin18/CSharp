try
{
    Console.WriteLine("Enter number:");

    string? input = Console.ReadLine();

    int number = Convert.ToInt32(input);

    Console.WriteLine($"Number: {number}");
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Program finished");
}