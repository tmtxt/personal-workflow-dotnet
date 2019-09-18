using System;
using System.IO;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Tmtxt.Config.Constants;

namespace Tmtxt.Config.Loaders
{
    public class ConfigurationLoader : IConfigurationLoader
    {
        public IConfiguration LoadConfigurationValues()
        {
            // Init the builder
            var builder = new ConfigurationBuilder();

            // Set the path to the EntryAssembly location
            builder.SetBasePath(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));

            // Load config key-value pairs in this order

            // These json files are the default configuration values for all environments
            builder.AddJsonFile($"appsettings.{ConfigTypeConstants.Base}.json", true);
            builder.AddJsonFile($"appsettings.json", true);

            // Specific json files for each specific environment, which can override the values in the above files
            foreach (var environmentType in (EnvironmentTypeEnum[])Enum.GetValues(typeof(EnvironmentTypeEnum)))
            {
                builder.AddJsonFile($"appsettings.{ConfigTypeConstants.Base}.json", true);
                builder.AddJsonFile($"appsettings.{environmentType.ToString()}.json", true);
            }

            // Environment variables should take higher precedence and override the other values if possible
            builder.AddEnvironmentVariables();

            // Build
            return builder.Build();
        }
    }
}