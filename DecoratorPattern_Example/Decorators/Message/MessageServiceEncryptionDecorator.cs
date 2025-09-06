using DecoratorPattern_Example.Attributes;
using DecoratorPattern_Example.Contracts;

namespace DecoratorPattern_Example.Decorators.Message
{
    [DecoratorOrder(1)]
    public class MessageServiceEncryptionDecorator : MessageServiceBaseDecorator
    {
        public MessageServiceEncryptionDecorator(IMessageService messageService) : base(messageService)
        {
        }

        public override void Send(string message)
        {
            message = $"*****{message}*****";
            Console.WriteLine("[Encryption] Encrypted Message.");
            messageService.Send(message);
        }
    }
}
