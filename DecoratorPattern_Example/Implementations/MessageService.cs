using DecoratorPattern_Example.Contracts;

namespace DecoratorPattern_Example.Implementations
{
    public class MessageService : IMessageService
    {
        public void Send(string message)
        {
            Console.WriteLine($"[MessageService] Sending: {message}");
        }
    }
}
