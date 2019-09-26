using Tmtxt.Config.Constants;
using Tmtxt.Config.Extensions;
using Tmtxt.Config.Loaders;

namespace Tmtxt.Config.Configs
{
    public class CommonConfig : ICommonConfig
    {
        #region Constructors

        public CommonConfig(IConfigurationLoader configurationLoader)
        {
            // Load all configuration keys/values
            var configuration = configurationLoader.LoadConfigurationValues();

            // Build the CommonConfig object
            SystemType = configuration.GetRequiredEnum<SystemTypeEnum>("SYSTEM_TYPE");
        }

        #endregion

        #region Implement IBaseConfig

        public SystemTypeEnum SystemType { get; set; }

        #endregion
    }
}