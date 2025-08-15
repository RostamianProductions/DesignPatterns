using Microsoft.Extensions.DependencyInjection;
using ProxyPattern_Example.Contracts.Post;
using ProxyPattern_Example.Factories;
using ProxyPattern_Example.Implementations.Post;

ServiceCollection services = new();
services.AddTransient<PostService>();
services.AddTransient<IPostFactory, PostFactory>();

ServiceProvider provider = services.BuildServiceProvider();

IPostFactory postFactory = provider.GetRequiredService<IPostFactory>();
IPostService postService = postFactory.GetIPostService();
postService.DisplayPost(25);

Console.ReadKey();