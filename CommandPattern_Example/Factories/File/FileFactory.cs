using CommandPattern_Example.Contracts.File;
using CommandPattern_Example.Enums;
using Microsoft.Extensions.DependencyInjection;

namespace CommandPattern_Example.Factories.File
{
    public class FileFactory : IFileFactory
    {
        private readonly IServiceProvider serviceProvider;

        public FileFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public IFileCommand GetIFileCommand(FileAction fileAction) => fileAction switch
        {
            FileAction.Create => serviceProvider.GetRequiredService<ICreateFileCommand>(),
            FileAction.Open => serviceProvider.GetRequiredService<IOpenFileCommand>(),
            _ => throw new Exception(),
        };
    }
}
