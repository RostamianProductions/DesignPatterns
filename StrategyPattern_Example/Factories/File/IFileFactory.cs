using StrategyPattern_Example.Contracts.File;
using StrategyPattern_Example.Enums;

namespace StrategyPattern_Example.Factories.File
{
    public interface IFileFactory
    {
        ICreateFileStrategy GetICreateFileStrategy(CreateFileType createFileType);
    }
}
