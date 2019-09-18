using System;

namespace Tmtxt.Config.Exceptions
{
    public class RequiredConfigurationMissingException : Exception
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="configKey">The config key</param>
        public RequiredConfigurationMissingException(string configKey) : base($"Config value {configKey} is required")
        {
        }
    }
}