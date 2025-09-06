namespace DecoratorPattern_Example.Attributes
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class DecoratorOrderAttribute : Attribute
    {
        public int Order { get; set; }

        public DecoratorOrderAttribute(int order)
        {
            Order = order;
        }
    }
}
