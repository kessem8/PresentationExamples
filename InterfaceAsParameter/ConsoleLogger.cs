using System;

namespace InterfaceAsParameter
{
    // Implementation of the ILogger interface
    class ConsoleLogger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"Logging to console: {message}");
        }
    }
}

