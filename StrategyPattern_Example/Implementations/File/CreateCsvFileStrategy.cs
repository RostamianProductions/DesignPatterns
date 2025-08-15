using StrategyPattern_Example.Contracts.File;

namespace StrategyPattern_Example.Implementations.CreateFile
{
    public class CreateCsvFileStrategy : ICreateCsvFileStrategy
    {
        public void CreateFile(string path)
        {
            Console.WriteLine($"The CSV File Was Created In The {path} Path.");
        }
    }
}
