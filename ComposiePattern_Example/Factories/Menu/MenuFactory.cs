using ComposiePattern_Example.Contracts.Menu;
using ComposiePattern_Example.Implementations.Menu;
using Microsoft.Extensions.DependencyInjection;

namespace ComposiePattern_Example.Factories.Menu
{
    public class MenuFactory : IMenuFactory
    {
        private readonly IServiceProvider serviceProvider;

        public MenuFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public IMenuComponent CreateCategory(string name)
        {
            MenuCategory category = serviceProvider.GetRequiredService<MenuCategory>();
            category.Name = name;

            return category;
        }

        public IMenuComponent CreateItem(string name)
        {
            MenuItem menuItem = serviceProvider.GetRequiredService<MenuItem>();
            menuItem.Name = name;

            return menuItem;
        }
    }
}
