using DecoratorPattern_Example.Attributes;
using DecoratorPattern_Example.Contracts;

namespace DecoratorPattern_Example.Decorators.Message
{
    [DecoratorOrder(2)]
    public class MessageServiceLoggingDecorator : MessageServiceBaseDecorator
    {
        public MessageServiceLoggingDecorator(IMessageService messageService) : base(messageService)
        {
        }

        public override void Send(string message)
        {
            Console.WriteLine("[Logging] Sending Message.");
            messageService.Send(message);
        }
    }
}
