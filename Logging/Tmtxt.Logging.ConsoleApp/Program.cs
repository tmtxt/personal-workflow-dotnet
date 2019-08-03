using System;
using Tmtxt.Logging.Constants;
using Tmtxt.Logging.Logger;

namespace Tmtxt.Logging.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
//            var logTrail = new LogTrail.LogTrail(new ConsoleLogger());

            var logTrail = new LogTrail.LogTrace();
            logTrail.Push(LogLevel.Info, "Event 1", "First message");
            logTrail.Flush();

            Console.WriteLine("End");
        }
    }
}