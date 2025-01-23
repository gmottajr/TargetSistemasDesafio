using GmKitchenOrderFlow.Domain.Abstractions;

namespace GmKitchenOrderFlow.Domain;

public class Queue : EntityBaseRoot<long>
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<MenuItemKitchenRoutingMap> MenuItemRouted { get; set; } = new List<MenuItemKitchenRoutingMap>();
    public List<ItemOrder>? ItemOrders { get; set; }
    public long KitchenAreaId { get; set; }
}