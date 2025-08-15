using Microsoft.Extensions.DependencyInjection;
using StatePattern_Example.Contracts.Post;

namespace StatePattern_Example
{
    public class PostContext
    {
        private readonly IServiceProvider serviceProvider;

        public string Content { get; set; }
        public IPostState State { get; set; }

        public PostContext(IServiceProvider serviceProvider, string content)
        {
            this.serviceProvider = serviceProvider;
            Content = content;
            State = serviceProvider.GetRequiredService<IDraftState>();
        }

        public void Publish() => State.Publish(this);

        public void Archive() => State.Archive(this);

        public void Edit(string newContent)
        {
            if (State is IDraftState)
            {
                Content = newContent;
                Console.WriteLine($"Post Edited: {Content}");
            }
            else
            {
                Console.WriteLine($"Cannot Edited Post In Current State.");
            }
        }
    }
}
