using ProxyPattern_Example.Contracts.Post;

namespace ProxyPattern_Example.Factories
{
    public interface IPostFactory
    {
        IPostService GetIPostService();
    }
}
