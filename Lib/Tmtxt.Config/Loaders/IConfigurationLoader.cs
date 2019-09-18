using Microsoft.Extensions.Configuration;

namespace Tmtxt.Config.Loaders
{
    /// <summary>
    /// Interface for loading all the available configuration key-value pairs from all possible sources
    /// </summary>
    public interface IConfigurationLoader
    {
        /// <summary>
        /// Load all the available configuration key-value pairs into the IConfigurationDictionary from all possible
        /// sources
        /// </summary>
        /// <returns></returns>
        IConfiguration LoadConfigurationValues();
    }
}