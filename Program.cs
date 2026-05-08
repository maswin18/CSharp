SayHello("Maswin");
SayHello("John");

void SayHello(string name)
{
    Console.WriteLine($"Hello {name}");
}

int AddNumbers(int firstNumber, int secondNumber)
{
    return firstNumber + secondNumber;
}

int result = AddNumbers(10, 20);

Console.WriteLine($"Output: {result}");