namespace Tmtxt.Models.MessageBus
{
    /// <summary>
    /// Base class for Message body
    /// </summary>
    public abstract class MessageBody
    {
        public string RequestedBy { get; set; }
    }
}