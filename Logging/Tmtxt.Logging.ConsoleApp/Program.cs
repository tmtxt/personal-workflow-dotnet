using System.Collections.Generic;
using Tmtxt.Logging.Constants;
using Tmtxt.Logging.Logger;

namespace Tmtxt.Logging.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new ConsoleLogger();
            var logTrace = new LogTrace.LogTrace(new List<ILogger> { logger });

            logTrace.Push(LogLevel.Info, "title 1", "message 1");
            logTrace.Flush();
        }
    }
}