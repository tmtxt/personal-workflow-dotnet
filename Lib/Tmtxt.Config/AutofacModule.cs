using Autofac;
using Tmtxt.Config.Configs;
using Tmtxt.Config.Loaders;

namespace Tmtxt.Config
{
    /// <summary>
    /// Autofac Module class, used for registering components with Autofac
    /// </summary>
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ConfigurationLoader>().As<IConfigurationLoader>();
            builder.RegisterType<CommonConfig>().As<ICommonConfig>();
        }
    }
}