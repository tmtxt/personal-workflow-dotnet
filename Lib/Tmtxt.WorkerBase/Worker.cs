using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace Tmtxt.WorkerBase
{
    /// <summary>
    /// Base class for Async Worker
    /// </summary>
    public abstract class Worker
    {
        public Worker()
        {
        }

        #region IOC Container

        #region IOC Container with .Net Core ServiceCollection

        /// <summary>
        /// Init and register IOC container using .Net Core ServiceCollection
        /// </summary>
        /// <returns></returns>
        private ServiceCollection ConfigureServiceCollection()
        {
            // Init the ServiceContainer
            var serviceCollection = new ServiceCollection();

            // Register the services here

            // Call the abstract method so the derived class can register its own services
            ConfigureServiceCollection(serviceCollection);

            // Return
            return serviceCollection;
        }

        /// <summary>
        /// Used for the derived class to register its own extra services with the IOC container
        /// using .Net Core ServiceCollection
        /// </summary>
        /// <param name="serviceCollection"></param>
        protected abstract void ConfigureServiceCollection(ServiceCollection serviceCollection);

        #endregion

        /// <summary>
        /// Init and register the IOC container using Autofac
        /// </summary>
        /// <returns></returns>
        private IContainer ConfigureAutofacContainer()
        {
            // Register the services using .Net default service container first
            var serviceContainer = ConfigureServiceCollection();

            // Init Autofac service container
            var containerBuilder = new ContainerBuilder();
            containerBuilder.Populate(serviceContainer);

            // Register the services here

            // Call the abstract method so the derived class can register its own services
            ConfigureAutofacContainer(containerBuilder);

            var container = containerBuilder.Build();
            return container;
        }

        /// <summary>
        /// Used for the derived class to register its own extra services with the IOC container
        /// </summary>
        /// <param name="containerBuilder"></param>
        protected abstract void ConfigureAutofacContainer(ContainerBuilder containerBuilder);

        #endregion
    }
}