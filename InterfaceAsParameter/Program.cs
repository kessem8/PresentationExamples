using System;

namespace InterfaceAsParameter
{
    class Program
    {
        static void Main()
        {
            // Creating instances of logger implementations
            ConsoleLogger consoleLogger = new ConsoleLogger();
            FileLogger fileLogger = new FileLogger();

            // Creating an instance of the class that uses the ILogger interface as a parameter
            LoggerService loggerService = new LoggerService();

            // Using the LoggerService to log messages using different loggers
            loggerService.LogMessageUsingLogger(consoleLogger, "Hello from ConsoleLogger!");
            loggerService.LogMessageUsingLogger(fileLogger, "Hello from FileLogger!");
        }
    }
}


