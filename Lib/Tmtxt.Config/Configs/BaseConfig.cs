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

            Environment = configuration.GetRequiredEnum<EnvironmentTypeEnum>("ENVIRONMENT");
        }

        #endregion

        #region Implement IBaseConfig

        public EnvironmentTypeEnum Environment { get; set; }

        #endregion
    }
}