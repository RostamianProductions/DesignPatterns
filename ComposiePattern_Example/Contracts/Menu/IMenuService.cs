
namespace ComposiePattern_Example.Contracts.Menu
{
    public interface IMenuService
    {
        IEnumerable<IMenuComponent> BuildTree();
    }
}
