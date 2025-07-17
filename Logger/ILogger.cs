public interface ILogger
{
    
    void Log(string message);
    void LogError(string message, string filename = "error.txt");
    void LogWarning(string message);
    void LogInfo(string message);
    void LogDebug(string message);
}