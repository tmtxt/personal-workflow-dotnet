using Tmtxt.Models.MessageBus;

namespace Tmtxt.WorkerBase
{
    public class WorkerBase<TMessage> where TMessageBody : MessageBody where TMessage : Message<TMessageBody>
    {

    }
}