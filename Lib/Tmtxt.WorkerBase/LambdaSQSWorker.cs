using System.Threading.Tasks;
using Autofac;
using MediatR;
using MediatR.Extensions.Autofac.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Tmtxt.WorkerBase.Behaviors;

namespace Tmtxt.WorkerBase
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

        }

        private void RegisterBehaviors(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(ExceptionHandlingBehavior<,>)).As(typeof(IPipelineBehavior<,>));

            var entryAssembly = System.Reflection.Assembly.GetEntryAssembly();
            builder.AddMediatR(entryAssembly);
        }
    }

    /// <summary>
    /// Base class for LambdaSQS worker
    /// </summary>
    public abstract class LambdaSQSWorker : MessageWorker
    {
        protected override void ConfigureServiceCollection(ServiceCollection serviceCollection)
        {
            base.ConfigureServiceCollection(serviceCollection);
        }

        protected override void ConfigureAutofacContainer(ContainerBuilder containerBuilder)
        {
            base.ConfigureAutofacContainer(containerBuilder);
        }

        public override async Task StartAsync()
        {
            using (var scope = AutofacContainer.BeginLifetimeScope())
            {
                var mediator = scope.Resolve<IMediator>();
            }
        }
    }
}