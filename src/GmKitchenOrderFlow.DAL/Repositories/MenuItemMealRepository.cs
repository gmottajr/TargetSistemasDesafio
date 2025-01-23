using GmKitchenOrderFlow.DAL.Abstractions;
using GmKitchenOrderFlow.Domain;
using Microsoft.EntityFrameworkCore;

namespace GmKitchenOrderFlow.DAL;

public class MenuItemMealRepository : DataRepositoryBase<MenuItemMeal, long>, IMenuItemMealRepository
{
    public MenuItemMealRepository(DbContextKitchen context) : base(context)
    {
    }
}
