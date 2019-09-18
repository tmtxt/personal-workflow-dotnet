using System;
using Microsoft.Extensions.Configuration;
using Tmtxt.Config.Exceptions;

namespace Tmtxt.Config.Extensions
{
    /// <summary>
    /// Extension class for Configuration value parsing
    /// </summary>
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

        /// <summary>
        /// Get a required enum value
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="configKey"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="RequiredConfigurationMissingException"></exception>
        /// <exception cref="IncorrectEnumValueException"></exception>
        public static T GetRequiredEnum<T>(this IConfiguration configuration, string configKey) where T : Enum
        {
            var val = configuration[configKey];
            if (string.IsNullOrWhiteSpace(val))
            {
                throw new RequiredConfigurationMissingException(configKey);
            }

            // try parsing
            try
            {
                return (T) Enum.Parse(typeof(T), val);
            }
            catch (ArgumentException)
            {
                throw new IncorrectEnumValueException(configKey, val);
            }
        }

        /// <summary>
        /// Get an enum value
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="configKey"></param>
        /// <param name="defaultValue"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="IncorrectEnumValueException"></exception>
        public static T GetEnum<T>(this IConfiguration configuration, string configKey, T defaultValue) where T : Enum
        {
            var val = configuration[configKey];
            if (string.IsNullOrWhiteSpace(val))
            {
                return defaultValue;
            }

            // try parsing
            try
            {
                return (T) Enum.Parse(typeof(T), val);
            }
            catch (ArgumentException)
            {
                throw new IncorrectEnumValueException(configKey, val);
            }
        }
    }
}