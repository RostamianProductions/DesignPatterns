using Microsoft.Extensions.DependencyInjection;
using ProxyPattern_Example.Contracts.Post;
using ProxyPattern_Example.Implementations.Post;
using ProxyPattern_Example.Proxies;

namespace ProxyPattern_Example.Factories
{
    public class PostFactory : IPostFactory
    {
        private readonly IServiceProvider serviceProvider;

        public PostFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public IPostService GetIPostService()
        {
            PostService postService = serviceProvider.GetRequiredService<PostService>();
            LoggingPostServiceProxy loggingPostProxy = new(postService);
            AccessPostServiceProxy accessPostProxy = new(loggingPostProxy);

            return accessPostProxy;
        }
    }
}
