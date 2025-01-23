using GmKitchenOrderFlow.DAL;
using GmKitchenOrderFlow.Application.Models;
using GmKitchenOrderFlow.Domain;

namespace GmKitchenOrderFlow.Application.Services;

public class MenuItemMealAppService : AppServiceBase<MenuItemMealDto, MenuItemMeal, long>, IMenuItemMealAppService
{
    public MenuItemMealAppService(IMenuItemMealRepository repository) : base(repository)
    {
    }
}
