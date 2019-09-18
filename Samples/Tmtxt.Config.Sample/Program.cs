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
        }
    }
}