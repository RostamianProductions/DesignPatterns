using Microsoft.Extensions.DependencyInjection;
using StatePattern_Example;
using StatePattern_Example.Contracts.Post;
using StatePattern_Example.Implementations.Post;

ServiceCollection services = new();
services.AddTransient<IDraftState, DraftState>();
services.AddTransient<IPublishedState, PublishedState>();
services.AddTransient<IArchivedState, ArchivedState>();

ServiceProvider provider = services.BuildServiceProvider();

PostContext postContext = new(provider, "Hello World.");
postContext.Edit("Test");
postContext.Archive();
postContext.Publish();
postContext.Edit("Test");
postContext.Archive();
postContext.Edit("Test");
postContext.Publish();
postContext.Archive();

Console.ReadKey();