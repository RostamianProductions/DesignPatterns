namespace ComposiePattern_Example.Contracts.Menu
{
    public interface IMenuComponent
    {
        string Name { get; }
        void Add(IMenuComponent menuComponent);
        void Display(int depth = 0);
    }
}
