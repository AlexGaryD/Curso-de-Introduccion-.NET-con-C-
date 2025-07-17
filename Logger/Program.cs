ILogger consoleLogger = new ConsoleLogger();
consoleLogger.Log("Este es un mensaje de log en la consola");

ILogger fileLogger = new FileLogger();

fileLogger.Log("Este es un mensaje de log en un archivo");

consoleLogger.LogError("Este es un mensaje de log en la consola Error");
fileLogger.LogError("Este es un mensaje de log en un archivo Error","error.txt");
fileLogger.LogError("Este es un mensaje de log en un archivo Error","error1.txt");
