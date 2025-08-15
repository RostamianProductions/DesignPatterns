namespace StatePattern_Example.Contracts.Post
{
    public interface IPostState
    {
        void Publish(PostContext postDto);
        void Archive(PostContext postDto);
    }
}
