using GmKitchenOrderFlow.Domain.Abstractions;
using GmKitchenOrderFlow.Domain.enums;

namespace GmKitchenOrderFlow.Domain;

public class ItemOrder : EntityBase
{
    public long OrderId { get; set; }
    public long MenuItemId { get; set; }
    public short Quantity { get; set; }
    public Order? Order { get; set; }
    public MenuItemMeal? MenuItem { get; set; }
    public ItemOrderStatusEnum Status { get; set; } = ItemOrderStatusEnum.Assigned;
    public Queue? QueueCurrent { get; set; }
    public long? QueueCurrentId { get; set; }
    public List<Queue>? Queues { get; set; }
}