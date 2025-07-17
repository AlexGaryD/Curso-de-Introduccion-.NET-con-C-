public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }

    public void LogError(string message, string filename = "error.txt")
    {
        Console.WriteLine($"Error: {message}");//
    }

    public void LogWarning(string message)
    {
        Console.WriteLine(message);
    }

    public void LogInfo(string message)
    {
        Console.WriteLine(message);
    }
    public void LogDebug(string message)
    {
        Console.WriteLine(message);
    }
}