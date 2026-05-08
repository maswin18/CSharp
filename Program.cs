Console.WriteLine("Enter first number:");
string? firstInput = Console.ReadLine();

Console.WriteLine("Enter second number:");
string? secondInput = Console.ReadLine();

int firstNumber = Convert.ToInt32(firstInput);
int secondNumber = Convert.ToInt32(secondInput);

int addition = firstNumber + secondNumber;
int subtraction = firstNumber - secondNumber;
int multiplication = firstNumber * secondNumber;
int division = firstNumber / secondNumber;

Console.WriteLine($"Addition: {addition}");
Console.WriteLine($"Subtraction: {subtraction}");
Console.WriteLine($"Multiplication: {multiplication}");
Console.WriteLine($"Division: {division}");