using GmKitchenOrderFlow.Domain.Abstractions;
using GmKitchenOrderFlow.Domain.enums;

namespace GmKitchenOrderFlow.Domain;

public class KitchenArea : EntityBaseRoot
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public KitchenStatusEnum Status { get; set; } = KitchenStatusEnum.Open;
    public Queue? Queue { get; set; }
    public long QueueId { get; set; } 

}