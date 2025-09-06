using DecoratorPattern_Example.Attributes;
using DecoratorPattern_Example.Contracts;
using DecoratorPattern_Example.Decorators.Message;
using DecoratorPattern_Example.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace DecoratorPattern_Example
{
    public static class IoCExtensions
    {
        public static IServiceCollection AddDecoratorMessageService(this IServiceCollection services)
        {
            services.AddTransient<MessageService>();
            List<Type> decoratorTypes = typeof(MessageServiceBaseDecorator)
                .Assembly
                .GetTypes()
                .Where(type => typeof(MessageServiceBaseDecorator).IsAssignableFrom(type) && !type.IsAbstract)
                .Select(type => new
                {
                    Type = type,
                    Order = type
                        .GetCustomAttributes(typeof(DecoratorOrderAttribute), false)
                        .Cast<DecoratorOrderAttribute>()
                        .FirstOrDefault()
                        ?.Order ?? int.MaxValue
                })
                .OrderBy(type => type.Order)
                .Select(type => type.Type)
                .ToList() ?? new();

            services.AddTransient<IMessageService>(provider =>
            {
                IMessageService messageService = provider.GetRequiredService<MessageService>();

                foreach (Type decoratorType in decoratorTypes.AsEnumerable().Reverse())
                {
                    messageService = (IMessageService)ActivatorUtilities.CreateInstance(provider, decoratorType, messageService);
                }

                return messageService;
            });

            return services;
        }
    }
}
