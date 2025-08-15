using CommandPattern_Example.Contracts.File;
using CommandPattern_Example.Dtos.File;

namespace CommandPattern_Example.Implementations.File
{
    public class OpenFileCommand : IOpenFileCommand
    {
        public void Execute(FileCommandParameterDto parameterDto)
        {
            Console.WriteLine($"File Opened ({parameterDto.Path}\\{parameterDto.FileName})");
        }
    }
}
