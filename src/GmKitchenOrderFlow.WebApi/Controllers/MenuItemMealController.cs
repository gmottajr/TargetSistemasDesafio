using Microsoft.AspNetCore.Mvc;
using GmKitchenOrderFlow.Application;
using GmKitchenOrderFlow.Application.Models;

namespace GmKitchenOrderFlow.WebApi;

public class MenuItemMealController : KitchenFlowBaseController<MenuItemMealDto, long>
{
    public MenuItemMealController(IMenuItemMealAppService applicationService) : base(applicationService)
    {
    }
}
