namespace Tmtxt.Models.MessageBus.Messages.DataDownloader
{
    public class Message : MessageBus.Message<MessageBody>
    {
        public override string QueueName => "message_body";
    }
}