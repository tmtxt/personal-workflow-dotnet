using Tmtxt.Config.Extensions;
using Tmtxt.Config.Loaders;

namespace Tmtxt.Config.Configs
{
    public class BaseConfig : IBaseConfig
    {
        #region Constructors

        public BaseConfig(IConfigurationLoader configurationLoader)
        {
            var configuration = configurationLoader.LoadConfigurationValues();

            Environment = configuration.GetRequiredString("ENVIRONMENT");
        }

        #endregion

        #region Implement IBaseConfig

        public string Environment { get; set; }

        #endregion
    }
}