using System;
using System.Collections;
using System.Diagnostics;
using Tmtxt.Logging.Constants;

namespace Tmtxt.Logging.Logger
{
    public class ConsoleLogger : ILogger

    {
        public void Log(LogLevel logLevel, string message, IDictionary props)
        {
            var strLogLevel = logLevel.ToString().ToUpper();

            Console.WriteLine(logLevel.ToString());
        }
    }
}