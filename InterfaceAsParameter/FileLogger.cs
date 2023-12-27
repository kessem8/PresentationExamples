using System;

namespace InterfaceAsParameter
{
    // Another implementation of the ILogger interface
    class FileLogger : ILogger
    {
        public void LogMessage(string message)
        {
            // In a real-world scenario, you would write to a file here
            Console.WriteLine($"Logging to file: {message}");
        }
    }
}

