using ComposiePattern_Example.Contracts.Menu;
using ComposiePattern_Example.Dtos.Menu;
using ComposiePattern_Example.Factories.Menu;
using Microsoft.Extensions.DependencyInjection;

namespace ComposiePattern_Example.Implementations.Menu
{
    public class MenuService : IMenuService
    {
        private readonly IMenuFactory menuFactory;
        private readonly List<MenuDto> menuDtos = new()
        {
            new MenuDto
            {
                Id = 1,
                ParentId = 0,
                Name = "Documents",
            },
            new MenuDto
            {
                Id = 2,
                ParentId = 0,
                Name = "Books",
            },
            new MenuDto
            {
                Id = 3,
                ParentId = 1,
                IsLeaf = true,
                Name = "C#",
            },
            new MenuDto
            {
                Id = 4,
                ParentId = 1,
                IsLeaf = true,
                Name = "Pyrhon",
            },
            new MenuDto
            {
                Id = 5,
                ParentId = 2,
                IsLeaf = true,
                Name = "Design Patterns",
            },
        };

        public MenuService(IServiceProvider serviceProvider)
        {
            this.menuFactory = serviceProvider.GetRequiredService<IMenuFactory>();
        }

        public IEnumerable<IMenuComponent> BuildTree()
        {
            ILookup<int, MenuDto> lookup = menuDtos.ToLookup(menuDto => menuDto.ParentId);
            IEnumerable<MenuDto> roots = menuDtos.Where(menuDto => menuDto.ParentId == 0);

            foreach (MenuDto menuDto in roots)
                yield return BuildTree(menuDto, lookup);
        }

        private IMenuComponent BuildTree(MenuDto menuDto, ILookup<int, MenuDto> lookup)
        {
            if (menuDto.IsLeaf)
                return menuFactory.CreateItem(menuDto.Name);

            IMenuComponent category = menuFactory.CreateCategory(menuDto.Name);

            foreach (MenuDto item in lookup[menuDto.Id])
                category.Add(BuildTree(item, lookup));

            return category;
        }
    }
}
