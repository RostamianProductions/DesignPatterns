using CommandPattern_Example.Contracts.File;
using CommandPattern_Example.Dtos.File;
using CommandPattern_Example.Enums;
using CommandPattern_Example.Factories.File;
using CommandPattern_Example.Implementations.File;
using Microsoft.Extensions.DependencyInjection;

ServiceCollection services = new();
services.AddTransient<ICreateFileCommand, CreateFileCommand>();
services.AddTransient<IOpenFileCommand, OpenFileCommand>();
services.AddTransient<IFileFactory, FileFactory>();

ServiceProvider provider = services.BuildServiceProvider();
IFileFactory fileFactory = provider.GetRequiredService<IFileFactory>();

List<IFileCommand> fileCommands = new()
{
    fileFactory.GetIFileCommand(FileAction.Create),
    fileFactory.GetIFileCommand(FileAction.Open),
};

FileCommandParameterDto parameterDto = new()
{
    FileName = "MyFile.txt",
    Path = "C:\\",
};

foreach (IFileCommand fileCommand in fileCommands)
    fileCommand.Execute(parameterDto);

Console.ReadKey();