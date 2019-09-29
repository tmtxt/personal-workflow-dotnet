using System;
using System.Threading.Tasks;
using Autofac;
using Tmtxt.Config.Configs;
using Tmtxt.Logging.Constants;
using Tmtxt.Logging.LogTrace;

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
                var logTrace = scope.Resolve<ILogTrace>();

                logTrace.Push(LogLevel.Info, "title 1", "hello");
                logTrace.Push(LogLevel.Warning, "title 2", new {A = "b", C = "d"});
                logTrace.Flush();
            }
        }
    }
}