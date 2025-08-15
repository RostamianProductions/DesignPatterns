using ProxyPattern_Example.Contracts.Post;
using ProxyPattern_Example.Enums;

namespace ProxyPattern_Example.Proxies
{
    public class AccessPostServiceProxy : IPostService
    {
        private readonly IPostService postService;
        private readonly UserRole currentUserRole = UserRole.Admin;

        public AccessPostServiceProxy(IPostService postService)
        {
            this.postService = postService;
        }

        public void DisplayPost(int postId)
        {
            Console.WriteLine("Proxy: Checking Access...");

            if (currentUserRole != UserRole.Admin)
            {
                Console.WriteLine("Access Denied: You Are Not Allowed To View This Post.");
                return;
            }
            else
            {
                postService.DisplayPost(postId);
            }
        }
    }
}
