using Microsoft.Extensions.DependencyInjection;
using StrategyPattern_Example.Contracts.File;
using StrategyPattern_Example.Enums;
using StrategyPattern_Example.Factories.File;
using StrategyPattern_Example.Implementations.CreateFile;

ServiceCollection services = new();
services.AddTransient<ICreateTxtFileStrategy, CreateTxtFileStrategy>();
services.AddTransient<ICreateXmlFileStrategy, CreateXmlFileStrategy>();
services.AddTransient<ICreateCsvFileStrategy, CreateCsvFileStrategy>();
services.AddTransient<IFileFactory, FileFactory>();

ServiceProvider provider = services.BuildServiceProvider();
IFileFactory fileFactory = provider.GetRequiredService<IFileFactory>();

fileFactory
  .GetICreateFileStrategy(CreateFileType.Txt)
  .CreateFile("C:\\");

fileFactory
  .GetICreateFileStrategy(CreateFileType.Csv)
  .CreateFile("C:\\");

fileFactory
  .GetICreateFileStrategy(CreateFileType.Xml)
  .CreateFile("C:\\");

Console.ReadKey();