using GmKitchenOrderFlow.Domain.Abstractions;

namespace GmKitchenOrderFlow.Domain;

public class Order : EntityBaseRoot<long>
{
    public string OrderNumber { get; set; } = string.Empty;
    public DateTime? DeletedAt { get; set; }
    public DateTime? CompletedAt { get; set; }
    public DateTime? CancelledAt { get; set; }
    public DateTime? ReadyAt { get; set; }
    public DateTime? PickedUpAt { get; set; }
    public List<ItemOrder>? Items { get; set; }
}