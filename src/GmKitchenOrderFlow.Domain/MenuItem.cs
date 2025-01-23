using GmKitchenOrderFlow.Domain.Abstractions;

namespace GmKitchenOrderFlow.Domain;

public class MenuItemMeal : EntityBaseRoot<long>
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public List<MenuItemMeal>? Composition { get; set; }
    public List<MenuItemKitchenRoutingMap>? KitchenRoutingMaps { get; set; }

}