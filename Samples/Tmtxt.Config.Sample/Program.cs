using System;
using Tmtxt.Config.Loaders;

namespace Tmtxt.Config.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var configurationLoader = new ConfigurationLoader();
            var configuration = configurationLoader.LoadConfigurationValues();

            // try loading these values
            var test = configuration["Environment"];
            var s = configuration["Test"];
            var s1 = configuration["Logging"];
            var s2 = configuration["Logging:LogLevel:Default"];
        }
    }
}