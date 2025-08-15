using StatePattern_Example.Contracts.Post;

namespace StatePattern_Example.Implementations.Post
{
    public class ArchivedState : IArchivedState
    {
        public void Archive(PostContext postDto) =>
            Console.WriteLine("Post Is Already Archived.");

        public void Publish(PostContext postDto) =>
            Console.WriteLine("Cannot Publish an Archived Post.");
    }
}
