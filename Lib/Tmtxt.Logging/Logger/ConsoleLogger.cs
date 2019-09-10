using System;
using System.Collections.Generic;
using Tmtxt.Logging.Constants;

namespace Tmtxt.Logging.Logger
{
    public class ConsoleLogger : ILogger

    {
        public void Log(LogLevel logLevel, string message, IDictionary<string, object> props)
        {
            var strLogLevel = logLevel.ToString().ToUpper();
            Console.WriteLine(logLevel.ToString());
            Console.WriteLine(message);
        }
    }
}