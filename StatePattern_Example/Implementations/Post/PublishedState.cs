using Microsoft.Extensions.DependencyInjection;
using StatePattern_Example.Contracts.Post;

namespace StatePattern_Example.Implementations.Post
{
    public class PublishedState : IPublishedState
    {
        private readonly IServiceProvider serviceProvider;

        public PublishedState(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void Archive(PostContext postDto)
        {
            Console.WriteLine("Archiving The Post...");
            postDto.State = serviceProvider.GetRequiredService<IArchivedState>();
        }

        public void Publish(PostContext postDto) =>
            Console.WriteLine("Post Is Already Published.");
    }
}
