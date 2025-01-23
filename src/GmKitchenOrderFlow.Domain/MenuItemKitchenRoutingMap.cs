using GmKitchenOrderFlow.Domain.Abstractions;

namespace GmKitchenOrderFlow.Domain;

public class MenuItemKitchenRoutingMap : EntityBase
{
    public long MenuItemMealId { get; set; }
    public MenuItemMeal? MenuItem { get; set; }
    public long QueueId { get; set; }
    public Queue? Queue { get; set; }
    public int Priority { get; set; }
}