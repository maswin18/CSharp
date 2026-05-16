string result = await GetMessage();

Console.WriteLine(result);

async Task<string> GetMessage()
{
    await Task.Delay(2000);

    return "Hello from async method";
}