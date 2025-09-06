namespace ComposiePattern_Example.Dtos.Menu
{
    public class MenuDto
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public bool IsLeaf { get; set; }
    }
}
