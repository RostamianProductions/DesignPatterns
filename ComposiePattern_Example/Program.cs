using ComposiePattern_Example.Contracts.Menu;
using ComposiePattern_Example.Factories.Menu;
using ComposiePattern_Example.Implementations.Menu;
using Microsoft.Extensions.DependencyInjection;

ServiceCollection services = new ServiceCollection();
services.AddTransient<MenuCategory>();
services.AddTransient<MenuItem>();
services.AddSingleton<IMenuFactory, MenuFactory>();
services.AddTransient<IMenuService, MenuService>();

ServiceProvider serviceProvider = services.BuildServiceProvider();
IMenuFactory menuFactory = serviceProvider.GetRequiredService<IMenuFactory>();
IMenuService menuService = serviceProvider.GetRequiredService<IMenuService>();

IEnumerable<IMenuComponent> menuComponents = menuService.BuildTree();

foreach (IMenuComponent menuComponent in menuComponents)
    menuComponent.Display();

IMenuComponent courses = menuFactory.CreateCategory("Courses");

IMenuComponent web = menuFactory.CreateCategory("Web");
web.Add(menuFactory.CreateItem("Web Form"));
web.Add(menuFactory.CreateItem("ASP.NET Core"));

IMenuComponent game = menuFactory.CreateCategory("Game");
game.Add(menuFactory.CreateItem("Unity"));
game.Add(menuFactory.CreateItem("Game Maker"));

courses.Add(web);
courses.Add(game);

menuFactory.CreateCategory("Courses");

courses.Display();

Console.ReadKey();