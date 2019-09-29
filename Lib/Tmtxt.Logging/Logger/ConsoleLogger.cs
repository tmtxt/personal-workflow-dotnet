using System;
using System.Collections.Generic;
using System.Text;
using Tmtxt.Logging.Constants;

namespace Tmtxt.Logging.Logger
{
    public class ConsoleLogger : ILogger
    {
        public void Log(LogLevel logLevel, string message, IDictionary<string, object> props)
        {
            // Log Level
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(logLevel.ToString().ToUpper()).Append("\n");

            // Log props
            foreach (var prop in props)
            {
                var propMsg = $"{prop.Key} : {prop.Value}\n";
                stringBuilder.Append(propMsg);
            }

            // Log message
            stringBuilder.Append(message).Append("\n");

            // Write
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}