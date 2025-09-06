using ComposiePattern_Example.Contracts.Menu;

namespace ComposiePattern_Example.Factories.Menu
{
    public interface IMenuFactory
    {
        IMenuComponent CreateCategory(string name);
        IMenuComponent CreateItem(string name);
    }
}
