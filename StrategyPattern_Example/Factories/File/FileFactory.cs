using Microsoft.Extensions.DependencyInjection;
using StrategyPattern_Example.Contracts.File;
using StrategyPattern_Example.Enums;

namespace StrategyPattern_Example.Factories.File
{
    public class FileFactory : IFileFactory
    {
        private readonly IServiceProvider serviceProvider;

        public FileFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public ICreateFileStrategy GetICreateFileStrategy(CreateFileType createFileType) => createFileType switch
        {
            CreateFileType.Txt => serviceProvider.GetRequiredService<ICreateTxtFileStrategy>(),
            CreateFileType.Xml => serviceProvider.GetRequiredService<ICreateXmlFileStrategy>(),
            CreateFileType.Csv => serviceProvider.GetRequiredService<ICreateCsvFileStrategy>(),
            _ => throw new Exception(),
        };
    }
}
