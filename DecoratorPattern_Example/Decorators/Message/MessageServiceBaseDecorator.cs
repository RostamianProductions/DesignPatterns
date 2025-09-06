using DecoratorPattern_Example.Contracts;

namespace DecoratorPattern_Example.Decorators.Message
{
    public abstract class MessageServiceBaseDecorator : IMessageService
    {
        protected readonly IMessageService messageService;

        protected MessageServiceBaseDecorator(IMessageService messageService)
        {
            this.messageService = messageService;
        }

        public abstract void Send(string message);
    }
}
