namespace Tmtxt.Models.MessageBus
{
    /// <summary>
    /// Base class for MessageBus message
    /// </summary>
    public abstract class Message<TMessageBody> where TMessageBody : MessageBody
    {
        public string MessageId { get; set; }

        public abstract string QueueName { get; }
    }
}