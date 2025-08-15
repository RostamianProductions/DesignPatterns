using StrategyPattern_Example.Contracts.File;

namespace StrategyPattern_Example.Implementations.CreateFile
{
    public class CreateXmlFileStrategy : ICreateXmlFileStrategy
    {
        public void CreateFile(string path)
        {
            Console.WriteLine($"The XML File Was Created In The {path} Path.");
        }
    }
}
