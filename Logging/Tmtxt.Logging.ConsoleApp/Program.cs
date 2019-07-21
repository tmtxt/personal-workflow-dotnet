using System;
using Tmtxt.Logging.Constants;

namespace Tmtxt.Logging.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var logTrail = new LogTrail.LogTrail();

            logTrail.Add(LogLevel.Info, "Event 1", "First message");

            Console.WriteLine("End");
        }
    }
}