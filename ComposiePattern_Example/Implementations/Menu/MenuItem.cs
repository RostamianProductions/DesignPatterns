using ComposiePattern_Example.Contracts.Menu;

namespace ComposiePattern_Example.Implementations.Menu
{
    public class MenuItem : IMenuComponent
    {
        public string Name { get; set; }

        public void Add(IMenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public void Display(int depth = 0)
        {
            Console.WriteLine(new string('-', depth) + $" {Name}");
        }
    }
}
