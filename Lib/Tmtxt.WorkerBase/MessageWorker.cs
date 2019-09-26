using System.Threading.Tasks;
using Autofac;
using Microsoft.Extensions.DependencyInjection;

namespace Tmtxt.WorkerBase
{
    /// <summary>
    /// Base class for Message Bus worker (SQS, Google Pub Sub, Kafka, RabbitMQ,...)
    /// </summary>
    public abstract class MessageWorker : Worker
    {
        protected override void ConfigureServiceCollection(ServiceCollection serviceCollection)
        {
        }

        protected override void ConfigureAutofacContainer(ContainerBuilder containerBuilder)
        {

        }

        public override async Task StartAsync()
        {

        }
    }
}