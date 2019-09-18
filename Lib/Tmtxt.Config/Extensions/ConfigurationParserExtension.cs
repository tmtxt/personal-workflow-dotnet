using Microsoft.Extensions.Configuration;
using Tmtxt.Config.Exceptions;

namespace Tmtxt.Config.Extensions
{
    public static class ConfigurationParserExtension
    {
        /// <summary>
        /// Get the required string from the configuration map
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="configKey"></param>
        /// <returns></returns>
        /// <exception cref="RequiredConfigurationMissingException"></exception>
        public static string GetRequiredString(this IConfiguration configuration, string configKey)
        {
            var val = configuration[configKey];
            if (!string.IsNullOrWhiteSpace(val))
            {
                return val;
            }

            throw new RequiredConfigurationMissingException(configKey);
        }

        /// <summary>
        /// Get string with default value
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="configKey"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static string GetString(this IConfiguration configuration, string configKey, string defaultValue = null)
        {
            var val = configuration[configKey];
            return !string.IsNullOrWhiteSpace(val) ? val : defaultValue;
        }
    }
}