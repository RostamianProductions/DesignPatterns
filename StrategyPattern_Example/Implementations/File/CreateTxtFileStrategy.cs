using StrategyPattern_Example.Contracts.File;

namespace StrategyPattern_Example.Implementations.CreateFile
{
    public class CreateTxtFileStrategy : ICreateTxtFileStrategy
    {
        public void CreateFile(string path)
        {
            Console.WriteLine($"The TXT File Was Created In The {path} Path.");
        }
    }
}
