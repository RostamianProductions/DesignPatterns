using Microsoft.Extensions.DependencyInjection;
using StatePattern_Example.Contracts.Post;

namespace StatePattern_Example.Implementations.Post
{
    public class DraftState : IDraftState
    {
        private readonly IServiceProvider serviceProvider;

        public DraftState(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void Archive(PostContext postDto) =>
            Console.WriteLine("Cannot Archive a Draft. Publish It First.");

        public void Publish(PostContext postDto)
        {
            Console.WriteLine("Publishing The Post...");
            postDto.State = serviceProvider.GetRequiredService<IPublishedState>();
        }
    }
}
