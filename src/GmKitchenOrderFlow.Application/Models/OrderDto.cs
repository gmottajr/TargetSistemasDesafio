using System.ComponentModel.DataAnnotations;
using GmKitchenOrderFlow.Application.Models.Abstractions;
namespace GmKitchenOrderFlow.Application.Models;

public class OrderDto : ResourceDtoBaseRoot<long>
{
    [Required]
    public string OrderNumber { get; set; }
    public DateTime? CompletedAt { get; set; }
    public DateTime? CancelledAt { get; set; }
    public DateTime? ReadyAt { get; set; }
    public DateTime? PickedUpAt { get; set; }
    public List<ItemOrderDto>? Items { get; set; }
}
