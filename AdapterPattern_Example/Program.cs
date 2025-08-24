using AdapterPattern_Example.Adapters;
using AdapterPattern_Example.Contracts;
using AdapterPattern_Example.Services;
using Microsoft.Extensions.DependencyInjection;

ServiceCollection services = new();
services.AddTransient<LegacyBankPaymentService>();
services.AddTransient<IPaymentProcessor, LegacyBankPaymentAdapter>();

ServiceProvider provider = services.BuildServiceProvider();
IPaymentProcessor paymentProcessor = provider.GetRequiredService<IPaymentProcessor>();

paymentProcessor.Pay(25000);

Console.ReadKey();