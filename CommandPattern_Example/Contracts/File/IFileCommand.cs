using CommandPattern_Example.Dtos.File;

namespace CommandPattern_Example.Contracts.File
{
    public interface IFileCommand
    {
        public void Execute(FileCommandParameterDto parameterDto);
    }
}
