using System;

namespace InterfaceAsParameter
{
    // Class that uses the ILogger interface as a parameter
    class LoggerService
    {
        // Method that takes an ILogger interface as a parameter
        public void LogMessageUsingLogger(ILogger logger, string message)
        {
            // Using the provided logger to log the message
            logger.LogMessage(message);
        }
    }
}

