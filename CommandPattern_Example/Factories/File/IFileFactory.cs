using CommandPattern_Example.Contracts.File;
using CommandPattern_Example.Enums;

namespace CommandPattern_Example.Factories.File
{
    public interface IFileFactory
    {
        IFileCommand GetIFileCommand(FileAction fileAction);
    }
}
