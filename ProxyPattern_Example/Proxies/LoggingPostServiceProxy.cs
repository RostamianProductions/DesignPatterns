using ProxyPattern_Example.Contracts.Post;

namespace ProxyPattern_Example.Proxies
{
    public class LoggingPostServiceProxy : IPostService
    {
        private readonly IPostService postService;
        public LoggingPostServiceProxy(IPostService postService)
        {
            this.postService = postService;
        }

        public void DisplayPost(int postId)
        {
            postService.DisplayPost(postId);
            Console.WriteLine($"[Logging Proxy]: View Post {postId} - {DateTime.Now}");
        }
    }
}
