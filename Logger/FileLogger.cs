public class FileLogger : ILogger
{
    public void Log(string message)
    {
        File.WriteAllText("log.txt", message);
    }
    public void LogError(string message, string filename = "error.txt")
    {
        File.AppendAllText(filename, "Error: " + message + Environment.NewLine);
    }
    public void LogWarning(string message)
    {
        File.AppendAllText("log.txt", "Warning: " + message + Environment.NewLine);
    }
    public void LogInfo(string message)
    {
        File.AppendAllText("log.txt", "Info: " + message + Environment.NewLine);
    }
    public void LogDebug(string message)
    {
        File.AppendAllText("log.txt", "Debug: " + message + Environment.NewLine);
    }
}