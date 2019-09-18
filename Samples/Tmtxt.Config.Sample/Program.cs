using System;
using Tmtxt.Config.Configs;
using Tmtxt.Config.Loaders;

namespace Tmtxt.Config.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Config loader
            var configurationLoader = new ConfigurationLoader();

            // Try load config key-value pairs
            var configuration = configurationLoader.LoadConfigurationValues();
            Console.WriteLine(configuration["ENVIRONMENT"]);
            Console.WriteLine(configuration["Logging"]);
            Console.WriteLine(configuration["Logging:LogLevel:Default"]);

            // Try building the BaseConfig object
            var baseConfig = new BaseConfig(configurationLoader);
            Console.WriteLine(baseConfig.Environment);
        }
    }
}