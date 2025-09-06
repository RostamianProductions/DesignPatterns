using DecoratorPattern_Example;
using DecoratorPattern_Example.Contracts;
using Microsoft.Extensions.DependencyInjection;

ServiceCollection services = new();
services.AddDecoratorMessageService();

ServiceProvider provider = services.BuildServiceProvider();
IMessageService messageService = provider.GetRequiredService<IMessageService>();

messageService.Send("Hello World");

Console.ReadKey();