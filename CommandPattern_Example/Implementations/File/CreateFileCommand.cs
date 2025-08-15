using CommandPattern_Example.Contracts.File;
using CommandPattern_Example.Dtos.File;

namespace CommandPattern_Example.Implementations.File
{
    public class CreateFileCommand : ICreateFileCommand
    {
        public void Execute(FileCommandParameterDto parameterDto)
        {
            Console.WriteLine($"{parameterDto.FileName} File Created");
        }
    }
}
