using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Tmtxt.WorkerBase.Behaviors
{
    public class ExceptionHandlingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TResponse : new()
    {
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            try
            {
                return await next();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return new TResponse();
        }
    }
}