using Autofac;
using Tmtxt.Logging.Logger;
using Tmtxt.Logging.LogTrace;

namespace Tmtxt.Logging
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ConsoleLogger>().As<ILogger>().InstancePerLifetimeScope();
            builder.RegisterType<LogTrace.LogTrace>().As<ILogTrace>().InstancePerLifetimeScope();
        }
    }
}