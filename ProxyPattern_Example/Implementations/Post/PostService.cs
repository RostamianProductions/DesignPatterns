using ProxyPattern_Example.Contracts.Post;

namespace ProxyPattern_Example.Implementations.Post
{
    public class PostService : IPostService
    {
        public void DisplayPost(int postId)
        {
            Console.WriteLine($"Loding Post {postId} From Database...");
            Console.WriteLine($"Post {postId}: Title = Proxy Pattern, Content = This Is The Real Post Content.");
        }
    }
}
