using System;
using System.Threading.Tasks;
using Autofac;
using Tmtxt.Config.Configs;

namespace Tmtxt.WorkerBase
{
    /// <summary>
    /// Base class for Message Bus worker (SQS, Google Pub Sub, Kafka, RabbitMQ,...)
    /// </summary>
    public abstract class MessageWorker : Worker
    {
        public override async Task StartAsync()
        {
            using (var scope = AutofacContainer.BeginLifetimeScope())
            {
                var commonConfig = scope.Resolve<ICommonConfig>();
                Console.WriteLine(commonConfig.SystemType);
            }
        }
    }
}