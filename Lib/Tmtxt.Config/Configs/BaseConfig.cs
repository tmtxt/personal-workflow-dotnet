using Tmtxt.Config.Constants;
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

            SystemType = configuration.GetRequiredEnum<SystemTypeEnum>("SYSTEM_TYPE");
        }

        #endregion

        #region Implement IBaseConfig

        public SystemTypeEnum SystemType { get; set; }

        #endregion
    }
}