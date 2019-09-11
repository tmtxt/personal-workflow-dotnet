using System.ComponentModel.Design;
using Autofac;
using Microsoft.Extensions.DependencyInjection;
using Tmtxt.WorkerBase;

namespace Tmtxt.Workers.DataDownloader
{
    public class Worker : LambdaSQSWorker
    {
        protected override void ConfigureServiceCollection(ServiceCollection serviceCollection)
        {
            base.ConfigureServiceCollection(serviceCollection);
        }

        protected override void ConfigureAutofacContainer(ContainerBuilder containerBuilder)
        {
            base.ConfigureAutofacContainer(containerBuilder);
        }
    }
}